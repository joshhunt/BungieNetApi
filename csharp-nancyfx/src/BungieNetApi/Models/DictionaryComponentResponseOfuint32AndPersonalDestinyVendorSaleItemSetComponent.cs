using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Sharpility.Extensions;
using NodaTime;

namespace BungieNetApi._Platform.Models
{
    /// <summary>
    /// DictionaryComponentResponseOfuint32AndPersonalDestinyVendorSaleItemSetComponent
    /// </summary>
    public sealed class DictionaryComponentResponseOfuint32AndPersonalDestinyVendorSaleItemSetComponent:  IEquatable<DictionaryComponentResponseOfuint32AndPersonalDestinyVendorSaleItemSetComponent>
    { 
        /// <summary>
        /// Data
        /// </summary>
        public Dictionary<string, DestinyResponsesPersonalDestinyVendorSaleItemSetComponent> Data { get; private set; }

        /// <summary>
        /// Privacy
        /// </summary>
        public int? Privacy { get; private set; }

        /// <summary>
        /// If true, this component is disabled.
        /// </summary>
        public bool? Disabled { get; private set; }


        /// <summary>
        /// Empty constructor required by some serializers.
        /// Use DictionaryComponentResponseOfuint32AndPersonalDestinyVendorSaleItemSetComponent.Builder() for instance creation instead.
        /// </summary>
        [Obsolete]
        public DictionaryComponentResponseOfuint32AndPersonalDestinyVendorSaleItemSetComponent()
        {
        }

        private DictionaryComponentResponseOfuint32AndPersonalDestinyVendorSaleItemSetComponent(Dictionary<string, DestinyResponsesPersonalDestinyVendorSaleItemSetComponent> Data, int? Privacy, bool? Disabled)
        {
            
            this.Data = Data;
            
            this.Privacy = Privacy;
            
            this.Disabled = Disabled;
            
        }

        /// <summary>
        /// Returns builder of DictionaryComponentResponseOfuint32AndPersonalDestinyVendorSaleItemSetComponent.
        /// </summary>
        /// <returns>DictionaryComponentResponseOfuint32AndPersonalDestinyVendorSaleItemSetComponentBuilder</returns>
        public static DictionaryComponentResponseOfuint32AndPersonalDestinyVendorSaleItemSetComponentBuilder Builder()
        {
            return new DictionaryComponentResponseOfuint32AndPersonalDestinyVendorSaleItemSetComponentBuilder();
        }

        /// <summary>
        /// Returns DictionaryComponentResponseOfuint32AndPersonalDestinyVendorSaleItemSetComponentBuilder with properties set.
        /// Use it to change properties.
        /// </summary>
        /// <returns>DictionaryComponentResponseOfuint32AndPersonalDestinyVendorSaleItemSetComponentBuilder</returns>
        public DictionaryComponentResponseOfuint32AndPersonalDestinyVendorSaleItemSetComponentBuilder With()
        {
            return Builder()
                .Data(Data)
                .Privacy(Privacy)
                .Disabled(Disabled);
        }

        public override string ToString()
        {
            return this.PropertiesToString();
        }

        public override bool Equals(object obj)
        {
            return this.EqualsByProperties(obj);
        }

        public bool Equals(DictionaryComponentResponseOfuint32AndPersonalDestinyVendorSaleItemSetComponent other)
        {
            return Equals((object) other);
        }

        public override int GetHashCode()
        {
            return this.PropertiesHash();
        }

        /// <summary>
        /// Implementation of == operator for (DictionaryComponentResponseOfuint32AndPersonalDestinyVendorSaleItemSetComponent.
        /// </summary>
        /// <param name="left">Compared (DictionaryComponentResponseOfuint32AndPersonalDestinyVendorSaleItemSetComponent</param>
        /// <param name="right">Compared (DictionaryComponentResponseOfuint32AndPersonalDestinyVendorSaleItemSetComponent</param>
        /// <returns>true if compared items are equals, false otherwise</returns>
        public static bool operator == (DictionaryComponentResponseOfuint32AndPersonalDestinyVendorSaleItemSetComponent left, DictionaryComponentResponseOfuint32AndPersonalDestinyVendorSaleItemSetComponent right)
        {
            return Equals(left, right);
        }

        /// <summary>
        /// Implementation of != operator for (DictionaryComponentResponseOfuint32AndPersonalDestinyVendorSaleItemSetComponent.
        /// </summary>
        /// <param name="left">Compared (DictionaryComponentResponseOfuint32AndPersonalDestinyVendorSaleItemSetComponent</param>
        /// <param name="right">Compared (DictionaryComponentResponseOfuint32AndPersonalDestinyVendorSaleItemSetComponent</param>
        /// <returns>true if compared items are not equals, false otherwise</returns>
        public static bool operator != (DictionaryComponentResponseOfuint32AndPersonalDestinyVendorSaleItemSetComponent left, DictionaryComponentResponseOfuint32AndPersonalDestinyVendorSaleItemSetComponent right)
        {
            return !Equals(left, right);
        }

        /// <summary>
        /// Builder of DictionaryComponentResponseOfuint32AndPersonalDestinyVendorSaleItemSetComponent.
        /// </summary>
        public sealed class DictionaryComponentResponseOfuint32AndPersonalDestinyVendorSaleItemSetComponentBuilder
        {
            private Dictionary<string, DestinyResponsesPersonalDestinyVendorSaleItemSetComponent> _Data;
            private int? _Privacy;
            private bool? _Disabled;

            internal DictionaryComponentResponseOfuint32AndPersonalDestinyVendorSaleItemSetComponentBuilder()
            {
                SetupDefaults();
            }

            private void SetupDefaults()
            {
            }

            /// <summary>
            /// Sets value for DictionaryComponentResponseOfuint32AndPersonalDestinyVendorSaleItemSetComponent.Data property.
            /// </summary>
            /// <param name="value">Data</param>
            public DictionaryComponentResponseOfuint32AndPersonalDestinyVendorSaleItemSetComponentBuilder Data(Dictionary<string, DestinyResponsesPersonalDestinyVendorSaleItemSetComponent> value)
            {
                _Data = value;
                return this;
            }

            /// <summary>
            /// Sets value for DictionaryComponentResponseOfuint32AndPersonalDestinyVendorSaleItemSetComponent.Privacy property.
            /// </summary>
            /// <param name="value">Privacy</param>
            public DictionaryComponentResponseOfuint32AndPersonalDestinyVendorSaleItemSetComponentBuilder Privacy(int? value)
            {
                _Privacy = value;
                return this;
            }

            /// <summary>
            /// Sets value for DictionaryComponentResponseOfuint32AndPersonalDestinyVendorSaleItemSetComponent.Disabled property.
            /// </summary>
            /// <param name="value">If true, this component is disabled.</param>
            public DictionaryComponentResponseOfuint32AndPersonalDestinyVendorSaleItemSetComponentBuilder Disabled(bool? value)
            {
                _Disabled = value;
                return this;
            }


            /// <summary>
            /// Builds instance of DictionaryComponentResponseOfuint32AndPersonalDestinyVendorSaleItemSetComponent.
            /// </summary>
            /// <returns>DictionaryComponentResponseOfuint32AndPersonalDestinyVendorSaleItemSetComponent</returns>
            public DictionaryComponentResponseOfuint32AndPersonalDestinyVendorSaleItemSetComponent Build()
            {
                Validate();
                return new DictionaryComponentResponseOfuint32AndPersonalDestinyVendorSaleItemSetComponent(
                    Data: _Data,
                    Privacy: _Privacy,
                    Disabled: _Disabled
                );
            }

            private void Validate()
            { 
            }
        }

        
    }
}