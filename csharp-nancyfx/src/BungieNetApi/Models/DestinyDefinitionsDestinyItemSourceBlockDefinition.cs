using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Sharpility.Extensions;
using NodaTime;

namespace BungieNetApi._Platform.Models
{
    /// <summary>
    /// Data about an item&#39;s \&quot;sources\&quot;: ways that the item can be obtained.
    /// </summary>
    public sealed class DestinyDefinitionsDestinyItemSourceBlockDefinition:  IEquatable<DestinyDefinitionsDestinyItemSourceBlockDefinition>
    { 
        /// <summary>
        /// The list of hash identifiers for Reward Sources that hint where the item can be found (DestinyRewardSourceDefinition).
        /// </summary>
        public List<int?> SourceHashes { get; private set; }

        /// <summary>
        /// A collection of details about the stats that were computed for the ways we found that the item could be spawned.
        /// </summary>
        public List<DestinyDefinitionsSourcesDestinyItemSourceDefinition> Sources { get; private set; }

        /// <summary>
        /// If we found that this item is exclusive to a specific platform, this will be set to the BungieMembershipType enumeration that matches that platform.
        /// </summary>
        public int? Exclusive { get; private set; }

        /// <summary>
        /// A denormalized reference back to vendors that potentially sell this item.
        /// </summary>
        public List<DestinyDefinitionsDestinyItemVendorSourceReference> VendorSources { get; private set; }


        /// <summary>
        /// Empty constructor required by some serializers.
        /// Use DestinyDefinitionsDestinyItemSourceBlockDefinition.Builder() for instance creation instead.
        /// </summary>
        [Obsolete]
        public DestinyDefinitionsDestinyItemSourceBlockDefinition()
        {
        }

        private DestinyDefinitionsDestinyItemSourceBlockDefinition(List<int?> SourceHashes, List<DestinyDefinitionsSourcesDestinyItemSourceDefinition> Sources, int? Exclusive, List<DestinyDefinitionsDestinyItemVendorSourceReference> VendorSources)
        {
            
            this.SourceHashes = SourceHashes;
            
            this.Sources = Sources;
            
            this.Exclusive = Exclusive;
            
            this.VendorSources = VendorSources;
            
        }

        /// <summary>
        /// Returns builder of DestinyDefinitionsDestinyItemSourceBlockDefinition.
        /// </summary>
        /// <returns>DestinyDefinitionsDestinyItemSourceBlockDefinitionBuilder</returns>
        public static DestinyDefinitionsDestinyItemSourceBlockDefinitionBuilder Builder()
        {
            return new DestinyDefinitionsDestinyItemSourceBlockDefinitionBuilder();
        }

        /// <summary>
        /// Returns DestinyDefinitionsDestinyItemSourceBlockDefinitionBuilder with properties set.
        /// Use it to change properties.
        /// </summary>
        /// <returns>DestinyDefinitionsDestinyItemSourceBlockDefinitionBuilder</returns>
        public DestinyDefinitionsDestinyItemSourceBlockDefinitionBuilder With()
        {
            return Builder()
                .SourceHashes(SourceHashes)
                .Sources(Sources)
                .Exclusive(Exclusive)
                .VendorSources(VendorSources);
        }

        public override string ToString()
        {
            return this.PropertiesToString();
        }

        public override bool Equals(object obj)
        {
            return this.EqualsByProperties(obj);
        }

        public bool Equals(DestinyDefinitionsDestinyItemSourceBlockDefinition other)
        {
            return Equals((object) other);
        }

        public override int GetHashCode()
        {
            return this.PropertiesHash();
        }

        /// <summary>
        /// Implementation of == operator for (DestinyDefinitionsDestinyItemSourceBlockDefinition.
        /// </summary>
        /// <param name="left">Compared (DestinyDefinitionsDestinyItemSourceBlockDefinition</param>
        /// <param name="right">Compared (DestinyDefinitionsDestinyItemSourceBlockDefinition</param>
        /// <returns>true if compared items are equals, false otherwise</returns>
        public static bool operator == (DestinyDefinitionsDestinyItemSourceBlockDefinition left, DestinyDefinitionsDestinyItemSourceBlockDefinition right)
        {
            return Equals(left, right);
        }

        /// <summary>
        /// Implementation of != operator for (DestinyDefinitionsDestinyItemSourceBlockDefinition.
        /// </summary>
        /// <param name="left">Compared (DestinyDefinitionsDestinyItemSourceBlockDefinition</param>
        /// <param name="right">Compared (DestinyDefinitionsDestinyItemSourceBlockDefinition</param>
        /// <returns>true if compared items are not equals, false otherwise</returns>
        public static bool operator != (DestinyDefinitionsDestinyItemSourceBlockDefinition left, DestinyDefinitionsDestinyItemSourceBlockDefinition right)
        {
            return !Equals(left, right);
        }

        /// <summary>
        /// Builder of DestinyDefinitionsDestinyItemSourceBlockDefinition.
        /// </summary>
        public sealed class DestinyDefinitionsDestinyItemSourceBlockDefinitionBuilder
        {
            private List<int?> _SourceHashes;
            private List<DestinyDefinitionsSourcesDestinyItemSourceDefinition> _Sources;
            private int? _Exclusive;
            private List<DestinyDefinitionsDestinyItemVendorSourceReference> _VendorSources;

            internal DestinyDefinitionsDestinyItemSourceBlockDefinitionBuilder()
            {
                SetupDefaults();
            }

            private void SetupDefaults()
            {
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsDestinyItemSourceBlockDefinition.SourceHashes property.
            /// </summary>
            /// <param name="value">The list of hash identifiers for Reward Sources that hint where the item can be found (DestinyRewardSourceDefinition).</param>
            public DestinyDefinitionsDestinyItemSourceBlockDefinitionBuilder SourceHashes(List<int?> value)
            {
                _SourceHashes = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsDestinyItemSourceBlockDefinition.Sources property.
            /// </summary>
            /// <param name="value">A collection of details about the stats that were computed for the ways we found that the item could be spawned.</param>
            public DestinyDefinitionsDestinyItemSourceBlockDefinitionBuilder Sources(List<DestinyDefinitionsSourcesDestinyItemSourceDefinition> value)
            {
                _Sources = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsDestinyItemSourceBlockDefinition.Exclusive property.
            /// </summary>
            /// <param name="value">If we found that this item is exclusive to a specific platform, this will be set to the BungieMembershipType enumeration that matches that platform.</param>
            public DestinyDefinitionsDestinyItemSourceBlockDefinitionBuilder Exclusive(int? value)
            {
                _Exclusive = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsDestinyItemSourceBlockDefinition.VendorSources property.
            /// </summary>
            /// <param name="value">A denormalized reference back to vendors that potentially sell this item.</param>
            public DestinyDefinitionsDestinyItemSourceBlockDefinitionBuilder VendorSources(List<DestinyDefinitionsDestinyItemVendorSourceReference> value)
            {
                _VendorSources = value;
                return this;
            }


            /// <summary>
            /// Builds instance of DestinyDefinitionsDestinyItemSourceBlockDefinition.
            /// </summary>
            /// <returns>DestinyDefinitionsDestinyItemSourceBlockDefinition</returns>
            public DestinyDefinitionsDestinyItemSourceBlockDefinition Build()
            {
                Validate();
                return new DestinyDefinitionsDestinyItemSourceBlockDefinition(
                    SourceHashes: _SourceHashes,
                    Sources: _Sources,
                    Exclusive: _Exclusive,
                    VendorSources: _VendorSources
                );
            }

            private void Validate()
            { 
            }
        }

        
    }
}