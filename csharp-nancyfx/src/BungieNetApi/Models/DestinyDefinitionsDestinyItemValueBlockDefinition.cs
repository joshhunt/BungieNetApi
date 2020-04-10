using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Sharpility.Extensions;
using NodaTime;

namespace BungieNetApi._Platform.Models
{
    /// <summary>
    /// This defines an item&#39;s \&quot;Value\&quot;. Unfortunately, this appears to be used in different ways depending on the way that the item itself is used.  For items being sold at a Vendor, this is the default \&quot;sale price\&quot; of the item. These days, the vendor itself almost always sets the price, but it still possible for the price to fall back to this value. For quests, it is a preview of rewards you can gain by completing the quest. For dummy items, if the itemValue refers to an Emblem, it is the emblem that should be shown as the reward. (jeez louise)  It will likely be used in a number of other ways in the future, it appears to be a bucket where they put arbitrary items and quantities into the item.
    /// </summary>
    public sealed class DestinyDefinitionsDestinyItemValueBlockDefinition:  IEquatable<DestinyDefinitionsDestinyItemValueBlockDefinition>
    { 
        /// <summary>
        /// References to the items that make up this item&#39;s \&quot;value\&quot;, and the quantity.
        /// </summary>
        public List<DestinyDestinyItemQuantity> ItemValue { get; private set; }

        /// <summary>
        /// If there&#39;s a localized text description of the value provided, this will be said description.
        /// </summary>
        public string ValueDescription { get; private set; }


        /// <summary>
        /// Empty constructor required by some serializers.
        /// Use DestinyDefinitionsDestinyItemValueBlockDefinition.Builder() for instance creation instead.
        /// </summary>
        [Obsolete]
        public DestinyDefinitionsDestinyItemValueBlockDefinition()
        {
        }

        private DestinyDefinitionsDestinyItemValueBlockDefinition(List<DestinyDestinyItemQuantity> ItemValue, string ValueDescription)
        {
            
            this.ItemValue = ItemValue;
            
            this.ValueDescription = ValueDescription;
            
        }

        /// <summary>
        /// Returns builder of DestinyDefinitionsDestinyItemValueBlockDefinition.
        /// </summary>
        /// <returns>DestinyDefinitionsDestinyItemValueBlockDefinitionBuilder</returns>
        public static DestinyDefinitionsDestinyItemValueBlockDefinitionBuilder Builder()
        {
            return new DestinyDefinitionsDestinyItemValueBlockDefinitionBuilder();
        }

        /// <summary>
        /// Returns DestinyDefinitionsDestinyItemValueBlockDefinitionBuilder with properties set.
        /// Use it to change properties.
        /// </summary>
        /// <returns>DestinyDefinitionsDestinyItemValueBlockDefinitionBuilder</returns>
        public DestinyDefinitionsDestinyItemValueBlockDefinitionBuilder With()
        {
            return Builder()
                .ItemValue(ItemValue)
                .ValueDescription(ValueDescription);
        }

        public override string ToString()
        {
            return this.PropertiesToString();
        }

        public override bool Equals(object obj)
        {
            return this.EqualsByProperties(obj);
        }

        public bool Equals(DestinyDefinitionsDestinyItemValueBlockDefinition other)
        {
            return Equals((object) other);
        }

        public override int GetHashCode()
        {
            return this.PropertiesHash();
        }

        /// <summary>
        /// Implementation of == operator for (DestinyDefinitionsDestinyItemValueBlockDefinition.
        /// </summary>
        /// <param name="left">Compared (DestinyDefinitionsDestinyItemValueBlockDefinition</param>
        /// <param name="right">Compared (DestinyDefinitionsDestinyItemValueBlockDefinition</param>
        /// <returns>true if compared items are equals, false otherwise</returns>
        public static bool operator == (DestinyDefinitionsDestinyItemValueBlockDefinition left, DestinyDefinitionsDestinyItemValueBlockDefinition right)
        {
            return Equals(left, right);
        }

        /// <summary>
        /// Implementation of != operator for (DestinyDefinitionsDestinyItemValueBlockDefinition.
        /// </summary>
        /// <param name="left">Compared (DestinyDefinitionsDestinyItemValueBlockDefinition</param>
        /// <param name="right">Compared (DestinyDefinitionsDestinyItemValueBlockDefinition</param>
        /// <returns>true if compared items are not equals, false otherwise</returns>
        public static bool operator != (DestinyDefinitionsDestinyItemValueBlockDefinition left, DestinyDefinitionsDestinyItemValueBlockDefinition right)
        {
            return !Equals(left, right);
        }

        /// <summary>
        /// Builder of DestinyDefinitionsDestinyItemValueBlockDefinition.
        /// </summary>
        public sealed class DestinyDefinitionsDestinyItemValueBlockDefinitionBuilder
        {
            private List<DestinyDestinyItemQuantity> _ItemValue;
            private string _ValueDescription;

            internal DestinyDefinitionsDestinyItemValueBlockDefinitionBuilder()
            {
                SetupDefaults();
            }

            private void SetupDefaults()
            {
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsDestinyItemValueBlockDefinition.ItemValue property.
            /// </summary>
            /// <param name="value">References to the items that make up this item&#39;s \&quot;value\&quot;, and the quantity.</param>
            public DestinyDefinitionsDestinyItemValueBlockDefinitionBuilder ItemValue(List<DestinyDestinyItemQuantity> value)
            {
                _ItemValue = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsDestinyItemValueBlockDefinition.ValueDescription property.
            /// </summary>
            /// <param name="value">If there&#39;s a localized text description of the value provided, this will be said description.</param>
            public DestinyDefinitionsDestinyItemValueBlockDefinitionBuilder ValueDescription(string value)
            {
                _ValueDescription = value;
                return this;
            }


            /// <summary>
            /// Builds instance of DestinyDefinitionsDestinyItemValueBlockDefinition.
            /// </summary>
            /// <returns>DestinyDefinitionsDestinyItemValueBlockDefinition</returns>
            public DestinyDefinitionsDestinyItemValueBlockDefinition Build()
            {
                Validate();
                return new DestinyDefinitionsDestinyItemValueBlockDefinition(
                    ItemValue: _ItemValue,
                    ValueDescription: _ValueDescription
                );
            }

            private void Validate()
            { 
            }
        }

        
    }
}