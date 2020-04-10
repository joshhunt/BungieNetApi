using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Sharpility.Extensions;
using NodaTime;

namespace BungieNetApi._Platform.Models
{
    /// <summary>
    /// This component provides a quick lookup of every item the requested character has and how much of that item they have.  Requesting this component will allow you to circumvent manually putting together the list of which currencies you have for the purpose of testing currency requirements on an item being purchased, or operations that have costs.  You *could* figure this out yourself by doing a GetCharacter or GetProfile request and forming your own lookup table, but that is inconvenient enough that this feels like a worthwhile (and optional) redundency. Don&#39;t bother requesting it if you have already created your own lookup from prior GetCharacter/GetProfile calls.
    /// </summary>
    public sealed class DestinyComponentsInventoryDestinyCurrenciesComponent:  IEquatable<DestinyComponentsInventoryDestinyCurrenciesComponent>
    { 
        /// <summary>
        /// A dictionary - keyed by the item&#39;s hash identifier (DestinyInventoryItemDefinition), and whose value is the amount of that item you have across all available inventory buckets for purchasing.  This allows you to see whether the requesting character can afford any given purchase/action without having to re-create this list itself.
        /// </summary>
        public Dictionary<string, int?> ItemQuantities { get; private set; }


        /// <summary>
        /// Empty constructor required by some serializers.
        /// Use DestinyComponentsInventoryDestinyCurrenciesComponent.Builder() for instance creation instead.
        /// </summary>
        [Obsolete]
        public DestinyComponentsInventoryDestinyCurrenciesComponent()
        {
        }

        private DestinyComponentsInventoryDestinyCurrenciesComponent(Dictionary<string, int?> ItemQuantities)
        {
            
            this.ItemQuantities = ItemQuantities;
            
        }

        /// <summary>
        /// Returns builder of DestinyComponentsInventoryDestinyCurrenciesComponent.
        /// </summary>
        /// <returns>DestinyComponentsInventoryDestinyCurrenciesComponentBuilder</returns>
        public static DestinyComponentsInventoryDestinyCurrenciesComponentBuilder Builder()
        {
            return new DestinyComponentsInventoryDestinyCurrenciesComponentBuilder();
        }

        /// <summary>
        /// Returns DestinyComponentsInventoryDestinyCurrenciesComponentBuilder with properties set.
        /// Use it to change properties.
        /// </summary>
        /// <returns>DestinyComponentsInventoryDestinyCurrenciesComponentBuilder</returns>
        public DestinyComponentsInventoryDestinyCurrenciesComponentBuilder With()
        {
            return Builder()
                .ItemQuantities(ItemQuantities);
        }

        public override string ToString()
        {
            return this.PropertiesToString();
        }

        public override bool Equals(object obj)
        {
            return this.EqualsByProperties(obj);
        }

        public bool Equals(DestinyComponentsInventoryDestinyCurrenciesComponent other)
        {
            return Equals((object) other);
        }

        public override int GetHashCode()
        {
            return this.PropertiesHash();
        }

        /// <summary>
        /// Implementation of == operator for (DestinyComponentsInventoryDestinyCurrenciesComponent.
        /// </summary>
        /// <param name="left">Compared (DestinyComponentsInventoryDestinyCurrenciesComponent</param>
        /// <param name="right">Compared (DestinyComponentsInventoryDestinyCurrenciesComponent</param>
        /// <returns>true if compared items are equals, false otherwise</returns>
        public static bool operator == (DestinyComponentsInventoryDestinyCurrenciesComponent left, DestinyComponentsInventoryDestinyCurrenciesComponent right)
        {
            return Equals(left, right);
        }

        /// <summary>
        /// Implementation of != operator for (DestinyComponentsInventoryDestinyCurrenciesComponent.
        /// </summary>
        /// <param name="left">Compared (DestinyComponentsInventoryDestinyCurrenciesComponent</param>
        /// <param name="right">Compared (DestinyComponentsInventoryDestinyCurrenciesComponent</param>
        /// <returns>true if compared items are not equals, false otherwise</returns>
        public static bool operator != (DestinyComponentsInventoryDestinyCurrenciesComponent left, DestinyComponentsInventoryDestinyCurrenciesComponent right)
        {
            return !Equals(left, right);
        }

        /// <summary>
        /// Builder of DestinyComponentsInventoryDestinyCurrenciesComponent.
        /// </summary>
        public sealed class DestinyComponentsInventoryDestinyCurrenciesComponentBuilder
        {
            private Dictionary<string, int?> _ItemQuantities;

            internal DestinyComponentsInventoryDestinyCurrenciesComponentBuilder()
            {
                SetupDefaults();
            }

            private void SetupDefaults()
            {
            }

            /// <summary>
            /// Sets value for DestinyComponentsInventoryDestinyCurrenciesComponent.ItemQuantities property.
            /// </summary>
            /// <param name="value">A dictionary - keyed by the item&#39;s hash identifier (DestinyInventoryItemDefinition), and whose value is the amount of that item you have across all available inventory buckets for purchasing.  This allows you to see whether the requesting character can afford any given purchase/action without having to re-create this list itself.</param>
            public DestinyComponentsInventoryDestinyCurrenciesComponentBuilder ItemQuantities(Dictionary<string, int?> value)
            {
                _ItemQuantities = value;
                return this;
            }


            /// <summary>
            /// Builds instance of DestinyComponentsInventoryDestinyCurrenciesComponent.
            /// </summary>
            /// <returns>DestinyComponentsInventoryDestinyCurrenciesComponent</returns>
            public DestinyComponentsInventoryDestinyCurrenciesComponent Build()
            {
                Validate();
                return new DestinyComponentsInventoryDestinyCurrenciesComponent(
                    ItemQuantities: _ItemQuantities
                );
            }

            private void Validate()
            { 
            }
        }

        
    }
}