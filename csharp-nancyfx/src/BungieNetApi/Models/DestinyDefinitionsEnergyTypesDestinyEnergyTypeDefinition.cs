using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Sharpility.Extensions;
using NodaTime;

namespace BungieNetApi._Platform.Models
{
    /// <summary>
    /// Represents types of Energy that can be used for costs and payments related to Armor 2.0 mods.
    /// </summary>
    public sealed class DestinyDefinitionsEnergyTypesDestinyEnergyTypeDefinition:  IEquatable<DestinyDefinitionsEnergyTypesDestinyEnergyTypeDefinition>
    { 
        /// <summary>
        /// The description of the energy type, icon etc...
        /// </summary>
        public DestinyDefinitionsCommonDestinyDisplayPropertiesDefinition DisplayProperties { get; private set; }

        /// <summary>
        /// A variant of the icon that is transparent and colorless.
        /// </summary>
        public string TransparentIconPath { get; private set; }

        /// <summary>
        /// If TRUE, the game shows this Energy type&#39;s icon. Otherwise, it doesn&#39;t. Whether you show it or not is up to you.
        /// </summary>
        public bool? ShowIcon { get; private set; }

        /// <summary>
        /// We have an enumeration for Energy types for quick reference. This is the current definition&#39;s Energy type enum value.
        /// </summary>
        public int? EnumValue { get; private set; }

        /// <summary>
        /// If this Energy Type can be used for determining the Type of Energy that an item can consume, this is the hash for the DestinyInvestmentStatDefinition that represents the stat which holds the Capacity for that energy type. (Note that this is optional because \&quot;Any\&quot; is a valid cost, but not valid for Capacity - an Armor must have a specific Energy Type for determining the energy type that the Armor is restricted to use)
        /// </summary>
        public int? CapacityStatHash { get; private set; }

        /// <summary>
        /// If this Energy Type can be used as a cost to pay for socketing Armor 2.0 items, this is the hash for the DestinyInvestmentStatDefinition that stores the plug&#39;s raw cost.
        /// </summary>
        public int? CostStatHash { get; private set; }

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
        /// Use DestinyDefinitionsEnergyTypesDestinyEnergyTypeDefinition.Builder() for instance creation instead.
        /// </summary>
        [Obsolete]
        public DestinyDefinitionsEnergyTypesDestinyEnergyTypeDefinition()
        {
        }

        private DestinyDefinitionsEnergyTypesDestinyEnergyTypeDefinition(DestinyDefinitionsCommonDestinyDisplayPropertiesDefinition DisplayProperties, string TransparentIconPath, bool? ShowIcon, int? EnumValue, int? CapacityStatHash, int? CostStatHash, int? Hash, int? Index, bool? Redacted)
        {
            
            this.DisplayProperties = DisplayProperties;
            
            this.TransparentIconPath = TransparentIconPath;
            
            this.ShowIcon = ShowIcon;
            
            this.EnumValue = EnumValue;
            
            this.CapacityStatHash = CapacityStatHash;
            
            this.CostStatHash = CostStatHash;
            
            this.Hash = Hash;
            
            this.Index = Index;
            
            this.Redacted = Redacted;
            
        }

        /// <summary>
        /// Returns builder of DestinyDefinitionsEnergyTypesDestinyEnergyTypeDefinition.
        /// </summary>
        /// <returns>DestinyDefinitionsEnergyTypesDestinyEnergyTypeDefinitionBuilder</returns>
        public static DestinyDefinitionsEnergyTypesDestinyEnergyTypeDefinitionBuilder Builder()
        {
            return new DestinyDefinitionsEnergyTypesDestinyEnergyTypeDefinitionBuilder();
        }

        /// <summary>
        /// Returns DestinyDefinitionsEnergyTypesDestinyEnergyTypeDefinitionBuilder with properties set.
        /// Use it to change properties.
        /// </summary>
        /// <returns>DestinyDefinitionsEnergyTypesDestinyEnergyTypeDefinitionBuilder</returns>
        public DestinyDefinitionsEnergyTypesDestinyEnergyTypeDefinitionBuilder With()
        {
            return Builder()
                .DisplayProperties(DisplayProperties)
                .TransparentIconPath(TransparentIconPath)
                .ShowIcon(ShowIcon)
                .EnumValue(EnumValue)
                .CapacityStatHash(CapacityStatHash)
                .CostStatHash(CostStatHash)
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

        public bool Equals(DestinyDefinitionsEnergyTypesDestinyEnergyTypeDefinition other)
        {
            return Equals((object) other);
        }

        public override int GetHashCode()
        {
            return this.PropertiesHash();
        }

        /// <summary>
        /// Implementation of == operator for (DestinyDefinitionsEnergyTypesDestinyEnergyTypeDefinition.
        /// </summary>
        /// <param name="left">Compared (DestinyDefinitionsEnergyTypesDestinyEnergyTypeDefinition</param>
        /// <param name="right">Compared (DestinyDefinitionsEnergyTypesDestinyEnergyTypeDefinition</param>
        /// <returns>true if compared items are equals, false otherwise</returns>
        public static bool operator == (DestinyDefinitionsEnergyTypesDestinyEnergyTypeDefinition left, DestinyDefinitionsEnergyTypesDestinyEnergyTypeDefinition right)
        {
            return Equals(left, right);
        }

        /// <summary>
        /// Implementation of != operator for (DestinyDefinitionsEnergyTypesDestinyEnergyTypeDefinition.
        /// </summary>
        /// <param name="left">Compared (DestinyDefinitionsEnergyTypesDestinyEnergyTypeDefinition</param>
        /// <param name="right">Compared (DestinyDefinitionsEnergyTypesDestinyEnergyTypeDefinition</param>
        /// <returns>true if compared items are not equals, false otherwise</returns>
        public static bool operator != (DestinyDefinitionsEnergyTypesDestinyEnergyTypeDefinition left, DestinyDefinitionsEnergyTypesDestinyEnergyTypeDefinition right)
        {
            return !Equals(left, right);
        }

        /// <summary>
        /// Builder of DestinyDefinitionsEnergyTypesDestinyEnergyTypeDefinition.
        /// </summary>
        public sealed class DestinyDefinitionsEnergyTypesDestinyEnergyTypeDefinitionBuilder
        {
            private DestinyDefinitionsCommonDestinyDisplayPropertiesDefinition _DisplayProperties;
            private string _TransparentIconPath;
            private bool? _ShowIcon;
            private int? _EnumValue;
            private int? _CapacityStatHash;
            private int? _CostStatHash;
            private int? _Hash;
            private int? _Index;
            private bool? _Redacted;

            internal DestinyDefinitionsEnergyTypesDestinyEnergyTypeDefinitionBuilder()
            {
                SetupDefaults();
            }

            private void SetupDefaults()
            {
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsEnergyTypesDestinyEnergyTypeDefinition.DisplayProperties property.
            /// </summary>
            /// <param name="value">The description of the energy type, icon etc...</param>
            public DestinyDefinitionsEnergyTypesDestinyEnergyTypeDefinitionBuilder DisplayProperties(DestinyDefinitionsCommonDestinyDisplayPropertiesDefinition value)
            {
                _DisplayProperties = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsEnergyTypesDestinyEnergyTypeDefinition.TransparentIconPath property.
            /// </summary>
            /// <param name="value">A variant of the icon that is transparent and colorless.</param>
            public DestinyDefinitionsEnergyTypesDestinyEnergyTypeDefinitionBuilder TransparentIconPath(string value)
            {
                _TransparentIconPath = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsEnergyTypesDestinyEnergyTypeDefinition.ShowIcon property.
            /// </summary>
            /// <param name="value">If TRUE, the game shows this Energy type&#39;s icon. Otherwise, it doesn&#39;t. Whether you show it or not is up to you.</param>
            public DestinyDefinitionsEnergyTypesDestinyEnergyTypeDefinitionBuilder ShowIcon(bool? value)
            {
                _ShowIcon = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsEnergyTypesDestinyEnergyTypeDefinition.EnumValue property.
            /// </summary>
            /// <param name="value">We have an enumeration for Energy types for quick reference. This is the current definition&#39;s Energy type enum value.</param>
            public DestinyDefinitionsEnergyTypesDestinyEnergyTypeDefinitionBuilder EnumValue(int? value)
            {
                _EnumValue = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsEnergyTypesDestinyEnergyTypeDefinition.CapacityStatHash property.
            /// </summary>
            /// <param name="value">If this Energy Type can be used for determining the Type of Energy that an item can consume, this is the hash for the DestinyInvestmentStatDefinition that represents the stat which holds the Capacity for that energy type. (Note that this is optional because \&quot;Any\&quot; is a valid cost, but not valid for Capacity - an Armor must have a specific Energy Type for determining the energy type that the Armor is restricted to use)</param>
            public DestinyDefinitionsEnergyTypesDestinyEnergyTypeDefinitionBuilder CapacityStatHash(int? value)
            {
                _CapacityStatHash = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsEnergyTypesDestinyEnergyTypeDefinition.CostStatHash property.
            /// </summary>
            /// <param name="value">If this Energy Type can be used as a cost to pay for socketing Armor 2.0 items, this is the hash for the DestinyInvestmentStatDefinition that stores the plug&#39;s raw cost.</param>
            public DestinyDefinitionsEnergyTypesDestinyEnergyTypeDefinitionBuilder CostStatHash(int? value)
            {
                _CostStatHash = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsEnergyTypesDestinyEnergyTypeDefinition.Hash property.
            /// </summary>
            /// <param name="value">The unique identifier for this entity. Guaranteed to be unique for the type of entity, but not globally.  When entities refer to each other in Destiny content, it is this hash that they are referring to.</param>
            public DestinyDefinitionsEnergyTypesDestinyEnergyTypeDefinitionBuilder Hash(int? value)
            {
                _Hash = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsEnergyTypesDestinyEnergyTypeDefinition.Index property.
            /// </summary>
            /// <param name="value">The index of the entity as it was found in the investment tables.</param>
            public DestinyDefinitionsEnergyTypesDestinyEnergyTypeDefinitionBuilder Index(int? value)
            {
                _Index = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsEnergyTypesDestinyEnergyTypeDefinition.Redacted property.
            /// </summary>
            /// <param name="value">If this is true, then there is an entity with this identifier/type combination, but BNet is not yet allowed to show it. Sorry!</param>
            public DestinyDefinitionsEnergyTypesDestinyEnergyTypeDefinitionBuilder Redacted(bool? value)
            {
                _Redacted = value;
                return this;
            }


            /// <summary>
            /// Builds instance of DestinyDefinitionsEnergyTypesDestinyEnergyTypeDefinition.
            /// </summary>
            /// <returns>DestinyDefinitionsEnergyTypesDestinyEnergyTypeDefinition</returns>
            public DestinyDefinitionsEnergyTypesDestinyEnergyTypeDefinition Build()
            {
                Validate();
                return new DestinyDefinitionsEnergyTypesDestinyEnergyTypeDefinition(
                    DisplayProperties: _DisplayProperties,
                    TransparentIconPath: _TransparentIconPath,
                    ShowIcon: _ShowIcon,
                    EnumValue: _EnumValue,
                    CapacityStatHash: _CapacityStatHash,
                    CostStatHash: _CostStatHash,
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