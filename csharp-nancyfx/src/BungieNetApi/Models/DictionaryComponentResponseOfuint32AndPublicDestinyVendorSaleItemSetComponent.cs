using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Sharpility.Extensions;
using NodaTime;

namespace BungieNetApi._Platform.Models
{
    /// <summary>
    /// DictionaryComponentResponseOfuint32AndPublicDestinyVendorSaleItemSetComponent
    /// </summary>
    public sealed class DictionaryComponentResponseOfuint32AndPublicDestinyVendorSaleItemSetComponent:  IEquatable<DictionaryComponentResponseOfuint32AndPublicDestinyVendorSaleItemSetComponent>
    { 
        /// <summary>
        /// Data
        /// </summary>
        public Dictionary<string, DestinyResponsesPublicDestinyVendorSaleItemSetComponent> Data { get; private set; }

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
        /// Use DictionaryComponentResponseOfuint32AndPublicDestinyVendorSaleItemSetComponent.Builder() for instance creation instead.
        /// </summary>
        [Obsolete]
        public DictionaryComponentResponseOfuint32AndPublicDestinyVendorSaleItemSetComponent()
        {
        }

        private DictionaryComponentResponseOfuint32AndPublicDestinyVendorSaleItemSetComponent(Dictionary<string, DestinyResponsesPublicDestinyVendorSaleItemSetComponent> Data, int? Privacy, bool? Disabled)
        {
            
            this.Data = Data;
            
            this.Privacy = Privacy;
            
            this.Disabled = Disabled;
            
        }

        /// <summary>
        /// Returns builder of DictionaryComponentResponseOfuint32AndPublicDestinyVendorSaleItemSetComponent.
        /// </summary>
        /// <returns>DictionaryComponentResponseOfuint32AndPublicDestinyVendorSaleItemSetComponentBuilder</returns>
        public static DictionaryComponentResponseOfuint32AndPublicDestinyVendorSaleItemSetComponentBuilder Builder()
        {
            return new DictionaryComponentResponseOfuint32AndPublicDestinyVendorSaleItemSetComponentBuilder();
        }

        /// <summary>
        /// Returns DictionaryComponentResponseOfuint32AndPublicDestinyVendorSaleItemSetComponentBuilder with properties set.
        /// Use it to change properties.
        /// </summary>
        /// <returns>DictionaryComponentResponseOfuint32AndPublicDestinyVendorSaleItemSetComponentBuilder</returns>
        public DictionaryComponentResponseOfuint32AndPublicDestinyVendorSaleItemSetComponentBuilder With()
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

        public bool Equals(DictionaryComponentResponseOfuint32AndPublicDestinyVendorSaleItemSetComponent other)
        {
            return Equals((object) other);
        }

        public override int GetHashCode()
        {
            return this.PropertiesHash();
        }

        /// <summary>
        /// Implementation of == operator for (DictionaryComponentResponseOfuint32AndPublicDestinyVendorSaleItemSetComponent.
        /// </summary>
        /// <param name="left">Compared (DictionaryComponentResponseOfuint32AndPublicDestinyVendorSaleItemSetComponent</param>
        /// <param name="right">Compared (DictionaryComponentResponseOfuint32AndPublicDestinyVendorSaleItemSetComponent</param>
        /// <returns>true if compared items are equals, false otherwise</returns>
        public static bool operator == (DictionaryComponentResponseOfuint32AndPublicDestinyVendorSaleItemSetComponent left, DictionaryComponentResponseOfuint32AndPublicDestinyVendorSaleItemSetComponent right)
        {
            return Equals(left, right);
        }

        /// <summary>
        /// Implementation of != operator for (DictionaryComponentResponseOfuint32AndPublicDestinyVendorSaleItemSetComponent.
        /// </summary>
        /// <param name="left">Compared (DictionaryComponentResponseOfuint32AndPublicDestinyVendorSaleItemSetComponent</param>
        /// <param name="right">Compared (DictionaryComponentResponseOfuint32AndPublicDestinyVendorSaleItemSetComponent</param>
        /// <returns>true if compared items are not equals, false otherwise</returns>
        public static bool operator != (DictionaryComponentResponseOfuint32AndPublicDestinyVendorSaleItemSetComponent left, DictionaryComponentResponseOfuint32AndPublicDestinyVendorSaleItemSetComponent right)
        {
            return !Equals(left, right);
        }

        /// <summary>
        /// Builder of DictionaryComponentResponseOfuint32AndPublicDestinyVendorSaleItemSetComponent.
        /// </summary>
        public sealed class DictionaryComponentResponseOfuint32AndPublicDestinyVendorSaleItemSetComponentBuilder
        {
            private Dictionary<string, DestinyResponsesPublicDestinyVendorSaleItemSetComponent> _Data;
            private int? _Privacy;
            private bool? _Disabled;

            internal DictionaryComponentResponseOfuint32AndPublicDestinyVendorSaleItemSetComponentBuilder()
            {
                SetupDefaults();
            }

            private void SetupDefaults()
            {
            }

            /// <summary>
            /// Sets value for DictionaryComponentResponseOfuint32AndPublicDestinyVendorSaleItemSetComponent.Data property.
            /// </summary>
            /// <param name="value">Data</param>
            public DictionaryComponentResponseOfuint32AndPublicDestinyVendorSaleItemSetComponentBuilder Data(Dictionary<string, DestinyResponsesPublicDestinyVendorSaleItemSetComponent> value)
            {
                _Data = value;
                return this;
            }

            /// <summary>
            /// Sets value for DictionaryComponentResponseOfuint32AndPublicDestinyVendorSaleItemSetComponent.Privacy property.
            /// </summary>
            /// <param name="value">Privacy</param>
            public DictionaryComponentResponseOfuint32AndPublicDestinyVendorSaleItemSetComponentBuilder Privacy(int? value)
            {
                _Privacy = value;
                return this;
            }

            /// <summary>
            /// Sets value for DictionaryComponentResponseOfuint32AndPublicDestinyVendorSaleItemSetComponent.Disabled property.
            /// </summary>
            /// <param name="value">If true, this component is disabled.</param>
            public DictionaryComponentResponseOfuint32AndPublicDestinyVendorSaleItemSetComponentBuilder Disabled(bool? value)
            {
                _Disabled = value;
                return this;
            }


            /// <summary>
            /// Builds instance of DictionaryComponentResponseOfuint32AndPublicDestinyVendorSaleItemSetComponent.
            /// </summary>
            /// <returns>DictionaryComponentResponseOfuint32AndPublicDestinyVendorSaleItemSetComponent</returns>
            public DictionaryComponentResponseOfuint32AndPublicDestinyVendorSaleItemSetComponent Build()
            {
                Validate();
                return new DictionaryComponentResponseOfuint32AndPublicDestinyVendorSaleItemSetComponent(
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