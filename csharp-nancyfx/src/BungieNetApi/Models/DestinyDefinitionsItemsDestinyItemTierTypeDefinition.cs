using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Sharpility.Extensions;
using NodaTime;

namespace BungieNetApi._Platform.Models
{
    /// <summary>
    /// Defines the tier type of an item. Mostly this provides human readable properties for types like Common, Rare, etc...  It also provides some base data for infusion that could be useful.
    /// </summary>
    public sealed class DestinyDefinitionsItemsDestinyItemTierTypeDefinition:  IEquatable<DestinyDefinitionsItemsDestinyItemTierTypeDefinition>
    { 
        /// <summary>
        /// DisplayProperties
        /// </summary>
        public DestinyDefinitionsCommonDestinyDisplayPropertiesDefinition DisplayProperties { get; private set; }

        /// <summary>
        /// If this tier defines infusion properties, they will be contained here.
        /// </summary>
        public DestinyDefinitionsItemsDestinyItemTierTypeInfusionBlock InfusionProcess { get; private set; }

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
        /// Use DestinyDefinitionsItemsDestinyItemTierTypeDefinition.Builder() for instance creation instead.
        /// </summary>
        [Obsolete]
        public DestinyDefinitionsItemsDestinyItemTierTypeDefinition()
        {
        }

        private DestinyDefinitionsItemsDestinyItemTierTypeDefinition(DestinyDefinitionsCommonDestinyDisplayPropertiesDefinition DisplayProperties, DestinyDefinitionsItemsDestinyItemTierTypeInfusionBlock InfusionProcess, int? Hash, int? Index, bool? Redacted)
        {
            
            this.DisplayProperties = DisplayProperties;
            
            this.InfusionProcess = InfusionProcess;
            
            this.Hash = Hash;
            
            this.Index = Index;
            
            this.Redacted = Redacted;
            
        }

        /// <summary>
        /// Returns builder of DestinyDefinitionsItemsDestinyItemTierTypeDefinition.
        /// </summary>
        /// <returns>DestinyDefinitionsItemsDestinyItemTierTypeDefinitionBuilder</returns>
        public static DestinyDefinitionsItemsDestinyItemTierTypeDefinitionBuilder Builder()
        {
            return new DestinyDefinitionsItemsDestinyItemTierTypeDefinitionBuilder();
        }

        /// <summary>
        /// Returns DestinyDefinitionsItemsDestinyItemTierTypeDefinitionBuilder with properties set.
        /// Use it to change properties.
        /// </summary>
        /// <returns>DestinyDefinitionsItemsDestinyItemTierTypeDefinitionBuilder</returns>
        public DestinyDefinitionsItemsDestinyItemTierTypeDefinitionBuilder With()
        {
            return Builder()
                .DisplayProperties(DisplayProperties)
                .InfusionProcess(InfusionProcess)
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

        public bool Equals(DestinyDefinitionsItemsDestinyItemTierTypeDefinition other)
        {
            return Equals((object) other);
        }

        public override int GetHashCode()
        {
            return this.PropertiesHash();
        }

        /// <summary>
        /// Implementation of == operator for (DestinyDefinitionsItemsDestinyItemTierTypeDefinition.
        /// </summary>
        /// <param name="left">Compared (DestinyDefinitionsItemsDestinyItemTierTypeDefinition</param>
        /// <param name="right">Compared (DestinyDefinitionsItemsDestinyItemTierTypeDefinition</param>
        /// <returns>true if compared items are equals, false otherwise</returns>
        public static bool operator == (DestinyDefinitionsItemsDestinyItemTierTypeDefinition left, DestinyDefinitionsItemsDestinyItemTierTypeDefinition right)
        {
            return Equals(left, right);
        }

        /// <summary>
        /// Implementation of != operator for (DestinyDefinitionsItemsDestinyItemTierTypeDefinition.
        /// </summary>
        /// <param name="left">Compared (DestinyDefinitionsItemsDestinyItemTierTypeDefinition</param>
        /// <param name="right">Compared (DestinyDefinitionsItemsDestinyItemTierTypeDefinition</param>
        /// <returns>true if compared items are not equals, false otherwise</returns>
        public static bool operator != (DestinyDefinitionsItemsDestinyItemTierTypeDefinition left, DestinyDefinitionsItemsDestinyItemTierTypeDefinition right)
        {
            return !Equals(left, right);
        }

        /// <summary>
        /// Builder of DestinyDefinitionsItemsDestinyItemTierTypeDefinition.
        /// </summary>
        public sealed class DestinyDefinitionsItemsDestinyItemTierTypeDefinitionBuilder
        {
            private DestinyDefinitionsCommonDestinyDisplayPropertiesDefinition _DisplayProperties;
            private DestinyDefinitionsItemsDestinyItemTierTypeInfusionBlock _InfusionProcess;
            private int? _Hash;
            private int? _Index;
            private bool? _Redacted;

            internal DestinyDefinitionsItemsDestinyItemTierTypeDefinitionBuilder()
            {
                SetupDefaults();
            }

            private void SetupDefaults()
            {
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsItemsDestinyItemTierTypeDefinition.DisplayProperties property.
            /// </summary>
            /// <param name="value">DisplayProperties</param>
            public DestinyDefinitionsItemsDestinyItemTierTypeDefinitionBuilder DisplayProperties(DestinyDefinitionsCommonDestinyDisplayPropertiesDefinition value)
            {
                _DisplayProperties = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsItemsDestinyItemTierTypeDefinition.InfusionProcess property.
            /// </summary>
            /// <param name="value">If this tier defines infusion properties, they will be contained here.</param>
            public DestinyDefinitionsItemsDestinyItemTierTypeDefinitionBuilder InfusionProcess(DestinyDefinitionsItemsDestinyItemTierTypeInfusionBlock value)
            {
                _InfusionProcess = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsItemsDestinyItemTierTypeDefinition.Hash property.
            /// </summary>
            /// <param name="value">The unique identifier for this entity. Guaranteed to be unique for the type of entity, but not globally.  When entities refer to each other in Destiny content, it is this hash that they are referring to.</param>
            public DestinyDefinitionsItemsDestinyItemTierTypeDefinitionBuilder Hash(int? value)
            {
                _Hash = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsItemsDestinyItemTierTypeDefinition.Index property.
            /// </summary>
            /// <param name="value">The index of the entity as it was found in the investment tables.</param>
            public DestinyDefinitionsItemsDestinyItemTierTypeDefinitionBuilder Index(int? value)
            {
                _Index = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsItemsDestinyItemTierTypeDefinition.Redacted property.
            /// </summary>
            /// <param name="value">If this is true, then there is an entity with this identifier/type combination, but BNet is not yet allowed to show it. Sorry!</param>
            public DestinyDefinitionsItemsDestinyItemTierTypeDefinitionBuilder Redacted(bool? value)
            {
                _Redacted = value;
                return this;
            }


            /// <summary>
            /// Builds instance of DestinyDefinitionsItemsDestinyItemTierTypeDefinition.
            /// </summary>
            /// <returns>DestinyDefinitionsItemsDestinyItemTierTypeDefinition</returns>
            public DestinyDefinitionsItemsDestinyItemTierTypeDefinition Build()
            {
                Validate();
                return new DestinyDefinitionsItemsDestinyItemTierTypeDefinition(
                    DisplayProperties: _DisplayProperties,
                    InfusionProcess: _InfusionProcess,
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