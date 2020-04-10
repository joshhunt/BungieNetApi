using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Sharpility.Extensions;
using NodaTime;

namespace BungieNetApi._Platform.Models
{
    /// <summary>
    /// DictionaryComponentResponseOfint32AndDestinyVendorSaleItemComponent
    /// </summary>
    public sealed class DictionaryComponentResponseOfint32AndDestinyVendorSaleItemComponent:  IEquatable<DictionaryComponentResponseOfint32AndDestinyVendorSaleItemComponent>
    { 
        /// <summary>
        /// Data
        /// </summary>
        public Dictionary<string, DestinyEntitiesVendorsDestinyVendorSaleItemComponent> Data { get; private set; }

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
        /// Use DictionaryComponentResponseOfint32AndDestinyVendorSaleItemComponent.Builder() for instance creation instead.
        /// </summary>
        [Obsolete]
        public DictionaryComponentResponseOfint32AndDestinyVendorSaleItemComponent()
        {
        }

        private DictionaryComponentResponseOfint32AndDestinyVendorSaleItemComponent(Dictionary<string, DestinyEntitiesVendorsDestinyVendorSaleItemComponent> Data, int? Privacy, bool? Disabled)
        {
            
            this.Data = Data;
            
            this.Privacy = Privacy;
            
            this.Disabled = Disabled;
            
        }

        /// <summary>
        /// Returns builder of DictionaryComponentResponseOfint32AndDestinyVendorSaleItemComponent.
        /// </summary>
        /// <returns>DictionaryComponentResponseOfint32AndDestinyVendorSaleItemComponentBuilder</returns>
        public static DictionaryComponentResponseOfint32AndDestinyVendorSaleItemComponentBuilder Builder()
        {
            return new DictionaryComponentResponseOfint32AndDestinyVendorSaleItemComponentBuilder();
        }

        /// <summary>
        /// Returns DictionaryComponentResponseOfint32AndDestinyVendorSaleItemComponentBuilder with properties set.
        /// Use it to change properties.
        /// </summary>
        /// <returns>DictionaryComponentResponseOfint32AndDestinyVendorSaleItemComponentBuilder</returns>
        public DictionaryComponentResponseOfint32AndDestinyVendorSaleItemComponentBuilder With()
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

        public bool Equals(DictionaryComponentResponseOfint32AndDestinyVendorSaleItemComponent other)
        {
            return Equals((object) other);
        }

        public override int GetHashCode()
        {
            return this.PropertiesHash();
        }

        /// <summary>
        /// Implementation of == operator for (DictionaryComponentResponseOfint32AndDestinyVendorSaleItemComponent.
        /// </summary>
        /// <param name="left">Compared (DictionaryComponentResponseOfint32AndDestinyVendorSaleItemComponent</param>
        /// <param name="right">Compared (DictionaryComponentResponseOfint32AndDestinyVendorSaleItemComponent</param>
        /// <returns>true if compared items are equals, false otherwise</returns>
        public static bool operator == (DictionaryComponentResponseOfint32AndDestinyVendorSaleItemComponent left, DictionaryComponentResponseOfint32AndDestinyVendorSaleItemComponent right)
        {
            return Equals(left, right);
        }

        /// <summary>
        /// Implementation of != operator for (DictionaryComponentResponseOfint32AndDestinyVendorSaleItemComponent.
        /// </summary>
        /// <param name="left">Compared (DictionaryComponentResponseOfint32AndDestinyVendorSaleItemComponent</param>
        /// <param name="right">Compared (DictionaryComponentResponseOfint32AndDestinyVendorSaleItemComponent</param>
        /// <returns>true if compared items are not equals, false otherwise</returns>
        public static bool operator != (DictionaryComponentResponseOfint32AndDestinyVendorSaleItemComponent left, DictionaryComponentResponseOfint32AndDestinyVendorSaleItemComponent right)
        {
            return !Equals(left, right);
        }

        /// <summary>
        /// Builder of DictionaryComponentResponseOfint32AndDestinyVendorSaleItemComponent.
        /// </summary>
        public sealed class DictionaryComponentResponseOfint32AndDestinyVendorSaleItemComponentBuilder
        {
            private Dictionary<string, DestinyEntitiesVendorsDestinyVendorSaleItemComponent> _Data;
            private int? _Privacy;
            private bool? _Disabled;

            internal DictionaryComponentResponseOfint32AndDestinyVendorSaleItemComponentBuilder()
            {
                SetupDefaults();
            }

            private void SetupDefaults()
            {
            }

            /// <summary>
            /// Sets value for DictionaryComponentResponseOfint32AndDestinyVendorSaleItemComponent.Data property.
            /// </summary>
            /// <param name="value">Data</param>
            public DictionaryComponentResponseOfint32AndDestinyVendorSaleItemComponentBuilder Data(Dictionary<string, DestinyEntitiesVendorsDestinyVendorSaleItemComponent> value)
            {
                _Data = value;
                return this;
            }

            /// <summary>
            /// Sets value for DictionaryComponentResponseOfint32AndDestinyVendorSaleItemComponent.Privacy property.
            /// </summary>
            /// <param name="value">Privacy</param>
            public DictionaryComponentResponseOfint32AndDestinyVendorSaleItemComponentBuilder Privacy(int? value)
            {
                _Privacy = value;
                return this;
            }

            /// <summary>
            /// Sets value for DictionaryComponentResponseOfint32AndDestinyVendorSaleItemComponent.Disabled property.
            /// </summary>
            /// <param name="value">If true, this component is disabled.</param>
            public DictionaryComponentResponseOfint32AndDestinyVendorSaleItemComponentBuilder Disabled(bool? value)
            {
                _Disabled = value;
                return this;
            }


            /// <summary>
            /// Builds instance of DictionaryComponentResponseOfint32AndDestinyVendorSaleItemComponent.
            /// </summary>
            /// <returns>DictionaryComponentResponseOfint32AndDestinyVendorSaleItemComponent</returns>
            public DictionaryComponentResponseOfint32AndDestinyVendorSaleItemComponent Build()
            {
                Validate();
                return new DictionaryComponentResponseOfint32AndDestinyVendorSaleItemComponent(
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