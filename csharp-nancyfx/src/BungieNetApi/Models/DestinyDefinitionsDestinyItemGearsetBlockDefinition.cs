using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Sharpility.Extensions;
using NodaTime;

namespace BungieNetApi._Platform.Models
{
    /// <summary>
    /// If an item has a related gearset, this is the list of items in that set, and an unlock expression that evaluates to a number representing the progress toward gearset completion (a very rare use for unlock expressions!)
    /// </summary>
    public sealed class DestinyDefinitionsDestinyItemGearsetBlockDefinition:  IEquatable<DestinyDefinitionsDestinyItemGearsetBlockDefinition>
    { 
        /// <summary>
        /// The maximum possible number of items that can be collected.
        /// </summary>
        public int? TrackingValueMax { get; private set; }

        /// <summary>
        /// The list of hashes for items in the gearset. Use them to look up DestinyInventoryItemDefinition entries for the items in the set.
        /// </summary>
        public List<int?> ItemList { get; private set; }


        /// <summary>
        /// Empty constructor required by some serializers.
        /// Use DestinyDefinitionsDestinyItemGearsetBlockDefinition.Builder() for instance creation instead.
        /// </summary>
        [Obsolete]
        public DestinyDefinitionsDestinyItemGearsetBlockDefinition()
        {
        }

        private DestinyDefinitionsDestinyItemGearsetBlockDefinition(int? TrackingValueMax, List<int?> ItemList)
        {
            
            this.TrackingValueMax = TrackingValueMax;
            
            this.ItemList = ItemList;
            
        }

        /// <summary>
        /// Returns builder of DestinyDefinitionsDestinyItemGearsetBlockDefinition.
        /// </summary>
        /// <returns>DestinyDefinitionsDestinyItemGearsetBlockDefinitionBuilder</returns>
        public static DestinyDefinitionsDestinyItemGearsetBlockDefinitionBuilder Builder()
        {
            return new DestinyDefinitionsDestinyItemGearsetBlockDefinitionBuilder();
        }

        /// <summary>
        /// Returns DestinyDefinitionsDestinyItemGearsetBlockDefinitionBuilder with properties set.
        /// Use it to change properties.
        /// </summary>
        /// <returns>DestinyDefinitionsDestinyItemGearsetBlockDefinitionBuilder</returns>
        public DestinyDefinitionsDestinyItemGearsetBlockDefinitionBuilder With()
        {
            return Builder()
                .TrackingValueMax(TrackingValueMax)
                .ItemList(ItemList);
        }

        public override string ToString()
        {
            return this.PropertiesToString();
        }

        public override bool Equals(object obj)
        {
            return this.EqualsByProperties(obj);
        }

        public bool Equals(DestinyDefinitionsDestinyItemGearsetBlockDefinition other)
        {
            return Equals((object) other);
        }

        public override int GetHashCode()
        {
            return this.PropertiesHash();
        }

        /// <summary>
        /// Implementation of == operator for (DestinyDefinitionsDestinyItemGearsetBlockDefinition.
        /// </summary>
        /// <param name="left">Compared (DestinyDefinitionsDestinyItemGearsetBlockDefinition</param>
        /// <param name="right">Compared (DestinyDefinitionsDestinyItemGearsetBlockDefinition</param>
        /// <returns>true if compared items are equals, false otherwise</returns>
        public static bool operator == (DestinyDefinitionsDestinyItemGearsetBlockDefinition left, DestinyDefinitionsDestinyItemGearsetBlockDefinition right)
        {
            return Equals(left, right);
        }

        /// <summary>
        /// Implementation of != operator for (DestinyDefinitionsDestinyItemGearsetBlockDefinition.
        /// </summary>
        /// <param name="left">Compared (DestinyDefinitionsDestinyItemGearsetBlockDefinition</param>
        /// <param name="right">Compared (DestinyDefinitionsDestinyItemGearsetBlockDefinition</param>
        /// <returns>true if compared items are not equals, false otherwise</returns>
        public static bool operator != (DestinyDefinitionsDestinyItemGearsetBlockDefinition left, DestinyDefinitionsDestinyItemGearsetBlockDefinition right)
        {
            return !Equals(left, right);
        }

        /// <summary>
        /// Builder of DestinyDefinitionsDestinyItemGearsetBlockDefinition.
        /// </summary>
        public sealed class DestinyDefinitionsDestinyItemGearsetBlockDefinitionBuilder
        {
            private int? _TrackingValueMax;
            private List<int?> _ItemList;

            internal DestinyDefinitionsDestinyItemGearsetBlockDefinitionBuilder()
            {
                SetupDefaults();
            }

            private void SetupDefaults()
            {
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsDestinyItemGearsetBlockDefinition.TrackingValueMax property.
            /// </summary>
            /// <param name="value">The maximum possible number of items that can be collected.</param>
            public DestinyDefinitionsDestinyItemGearsetBlockDefinitionBuilder TrackingValueMax(int? value)
            {
                _TrackingValueMax = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsDestinyItemGearsetBlockDefinition.ItemList property.
            /// </summary>
            /// <param name="value">The list of hashes for items in the gearset. Use them to look up DestinyInventoryItemDefinition entries for the items in the set.</param>
            public DestinyDefinitionsDestinyItemGearsetBlockDefinitionBuilder ItemList(List<int?> value)
            {
                _ItemList = value;
                return this;
            }


            /// <summary>
            /// Builds instance of DestinyDefinitionsDestinyItemGearsetBlockDefinition.
            /// </summary>
            /// <returns>DestinyDefinitionsDestinyItemGearsetBlockDefinition</returns>
            public DestinyDefinitionsDestinyItemGearsetBlockDefinition Build()
            {
                Validate();
                return new DestinyDefinitionsDestinyItemGearsetBlockDefinition(
                    TrackingValueMax: _TrackingValueMax,
                    ItemList: _ItemList
                );
            }

            private void Validate()
            { 
            }
        }

        
    }
}