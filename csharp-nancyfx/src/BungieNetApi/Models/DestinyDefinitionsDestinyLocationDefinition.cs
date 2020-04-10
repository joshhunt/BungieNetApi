using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Sharpility.Extensions;
using NodaTime;

namespace BungieNetApi._Platform.Models
{
    /// <summary>
    /// A \&quot;Location\&quot; is a sort of shortcut for referring to a specific combination of Activity, Destination, Place, and even Bubble or NavPoint within a space.  Most of this data isn&#39;t intrinsically useful to us, but Objectives refer to locations, and through that we can at least infer the Activity, Destination, and Place being referred to by the Objective.
    /// </summary>
    public sealed class DestinyDefinitionsDestinyLocationDefinition:  IEquatable<DestinyDefinitionsDestinyLocationDefinition>
    { 
        /// <summary>
        /// If the location has a Vendor on it, this is the hash identifier for that Vendor. Look them up with DestinyVendorDefinition.
        /// </summary>
        public int? VendorHash { get; private set; }

        /// <summary>
        /// A Location may refer to different specific spots in the world based on the world&#39;s current state. This is a list of those potential spots, and the data we can use at runtime to determine which one of the spots is the currently valid one.
        /// </summary>
        public List<DestinyDefinitionsDestinyLocationReleaseDefinition> LocationReleases { get; private set; }

        /// <summary>
        /// The unique identifier for this entity. Guaranteed to be unique for the type of entity, but not globally.  When entities refer to each other in Destiny content, it is this hash that they are referring to.
        /// </summary>
        public int? Hash { get; private set; }

        /// <summary>
        /// The index of the entity as it was found in the investment tables.
        /// </summary>
        public int? Index { get; private set; }

        /// <summary>
        /// If this is true, then there is an entity with this identifier/type combination, but BNet is not yet allowed to show it. Sorry!
        /// </summary>
        public bool? Redacted { get; private set; }


        /// <summary>
        /// Empty constructor required by some serializers.
        /// Use DestinyDefinitionsDestinyLocationDefinition.Builder() for instance creation instead.
        /// </summary>
        [Obsolete]
        public DestinyDefinitionsDestinyLocationDefinition()
        {
        }

        private DestinyDefinitionsDestinyLocationDefinition(int? VendorHash, List<DestinyDefinitionsDestinyLocationReleaseDefinition> LocationReleases, int? Hash, int? Index, bool? Redacted)
        {
            
            this.VendorHash = VendorHash;
            
            this.LocationReleases = LocationReleases;
            
            this.Hash = Hash;
            
            this.Index = Index;
            
            this.Redacted = Redacted;
            
        }

        /// <summary>
        /// Returns builder of DestinyDefinitionsDestinyLocationDefinition.
        /// </summary>
        /// <returns>DestinyDefinitionsDestinyLocationDefinitionBuilder</returns>
        public static DestinyDefinitionsDestinyLocationDefinitionBuilder Builder()
        {
            return new DestinyDefinitionsDestinyLocationDefinitionBuilder();
        }

        /// <summary>
        /// Returns DestinyDefinitionsDestinyLocationDefinitionBuilder with properties set.
        /// Use it to change properties.
        /// </summary>
        /// <returns>DestinyDefinitionsDestinyLocationDefinitionBuilder</returns>
        public DestinyDefinitionsDestinyLocationDefinitionBuilder With()
        {
            return Builder()
                .VendorHash(VendorHash)
                .LocationReleases(LocationReleases)
                .Hash(Hash)
                .Index(Index)
                .Redacted(Redacted);
        }

        public override string ToString()
        {
            return this.PropertiesToString();
        }

        public override bool Equals(object obj)
        {
            return this.EqualsByProperties(obj);
        }

        public bool Equals(DestinyDefinitionsDestinyLocationDefinition other)
        {
            return Equals((object) other);
        }

        public override int GetHashCode()
        {
            return this.PropertiesHash();
        }

        /// <summary>
        /// Implementation of == operator for (DestinyDefinitionsDestinyLocationDefinition.
        /// </summary>
        /// <param name="left">Compared (DestinyDefinitionsDestinyLocationDefinition</param>
        /// <param name="right">Compared (DestinyDefinitionsDestinyLocationDefinition</param>
        /// <returns>true if compared items are equals, false otherwise</returns>
        public static bool operator == (DestinyDefinitionsDestinyLocationDefinition left, DestinyDefinitionsDestinyLocationDefinition right)
        {
            return Equals(left, right);
        }

        /// <summary>
        /// Implementation of != operator for (DestinyDefinitionsDestinyLocationDefinition.
        /// </summary>
        /// <param name="left">Compared (DestinyDefinitionsDestinyLocationDefinition</param>
        /// <param name="right">Compared (DestinyDefinitionsDestinyLocationDefinition</param>
        /// <returns>true if compared items are not equals, false otherwise</returns>
        public static bool operator != (DestinyDefinitionsDestinyLocationDefinition left, DestinyDefinitionsDestinyLocationDefinition right)
        {
            return !Equals(left, right);
        }

        /// <summary>
        /// Builder of DestinyDefinitionsDestinyLocationDefinition.
        /// </summary>
        public sealed class DestinyDefinitionsDestinyLocationDefinitionBuilder
        {
            private int? _VendorHash;
            private List<DestinyDefinitionsDestinyLocationReleaseDefinition> _LocationReleases;
            private int? _Hash;
            private int? _Index;
            private bool? _Redacted;

            internal DestinyDefinitionsDestinyLocationDefinitionBuilder()
            {
                SetupDefaults();
            }

            private void SetupDefaults()
            {
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsDestinyLocationDefinition.VendorHash property.
            /// </summary>
            /// <param name="value">If the location has a Vendor on it, this is the hash identifier for that Vendor. Look them up with DestinyVendorDefinition.</param>
            public DestinyDefinitionsDestinyLocationDefinitionBuilder VendorHash(int? value)
            {
                _VendorHash = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsDestinyLocationDefinition.LocationReleases property.
            /// </summary>
            /// <param name="value">A Location may refer to different specific spots in the world based on the world&#39;s current state. This is a list of those potential spots, and the data we can use at runtime to determine which one of the spots is the currently valid one.</param>
            public DestinyDefinitionsDestinyLocationDefinitionBuilder LocationReleases(List<DestinyDefinitionsDestinyLocationReleaseDefinition> value)
            {
                _LocationReleases = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsDestinyLocationDefinition.Hash property.
            /// </summary>
            /// <param name="value">The unique identifier for this entity. Guaranteed to be unique for the type of entity, but not globally.  When entities refer to each other in Destiny content, it is this hash that they are referring to.</param>
            public DestinyDefinitionsDestinyLocationDefinitionBuilder Hash(int? value)
            {
                _Hash = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsDestinyLocationDefinition.Index property.
            /// </summary>
            /// <param name="value">The index of the entity as it was found in the investment tables.</param>
            public DestinyDefinitionsDestinyLocationDefinitionBuilder Index(int? value)
            {
                _Index = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsDestinyLocationDefinition.Redacted property.
            /// </summary>
            /// <param name="value">If this is true, then there is an entity with this identifier/type combination, but BNet is not yet allowed to show it. Sorry!</param>
            public DestinyDefinitionsDestinyLocationDefinitionBuilder Redacted(bool? value)
            {
                _Redacted = value;
                return this;
            }


            /// <summary>
            /// Builds instance of DestinyDefinitionsDestinyLocationDefinition.
            /// </summary>
            /// <returns>DestinyDefinitionsDestinyLocationDefinition</returns>
            public DestinyDefinitionsDestinyLocationDefinition Build()
            {
                Validate();
                return new DestinyDefinitionsDestinyLocationDefinition(
                    VendorHash: _VendorHash,
                    LocationReleases: _LocationReleases,
                    Hash: _Hash,
                    Index: _Index,
                    Redacted: _Redacted
                );
            }

            private void Validate()
            { 
            }
        }

        
    }
}