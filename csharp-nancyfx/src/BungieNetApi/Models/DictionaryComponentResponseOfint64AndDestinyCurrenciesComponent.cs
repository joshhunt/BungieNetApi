using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Sharpility.Extensions;
using NodaTime;

namespace BungieNetApi._Platform.Models
{
    /// <summary>
    /// DictionaryComponentResponseOfint64AndDestinyCurrenciesComponent
    /// </summary>
    public sealed class DictionaryComponentResponseOfint64AndDestinyCurrenciesComponent:  IEquatable<DictionaryComponentResponseOfint64AndDestinyCurrenciesComponent>
    { 
        /// <summary>
        /// Data
        /// </summary>
        public Dictionary<string, DestinyComponentsInventoryDestinyCurrenciesComponent> Data { get; private set; }

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
        /// Use DictionaryComponentResponseOfint64AndDestinyCurrenciesComponent.Builder() for instance creation instead.
        /// </summary>
        [Obsolete]
        public DictionaryComponentResponseOfint64AndDestinyCurrenciesComponent()
        {
        }

        private DictionaryComponentResponseOfint64AndDestinyCurrenciesComponent(Dictionary<string, DestinyComponentsInventoryDestinyCurrenciesComponent> Data, int? Privacy, bool? Disabled)
        {
            
            this.Data = Data;
            
            this.Privacy = Privacy;
            
            this.Disabled = Disabled;
            
        }

        /// <summary>
        /// Returns builder of DictionaryComponentResponseOfint64AndDestinyCurrenciesComponent.
        /// </summary>
        /// <returns>DictionaryComponentResponseOfint64AndDestinyCurrenciesComponentBuilder</returns>
        public static DictionaryComponentResponseOfint64AndDestinyCurrenciesComponentBuilder Builder()
        {
            return new DictionaryComponentResponseOfint64AndDestinyCurrenciesComponentBuilder();
        }

        /// <summary>
        /// Returns DictionaryComponentResponseOfint64AndDestinyCurrenciesComponentBuilder with properties set.
        /// Use it to change properties.
        /// </summary>
        /// <returns>DictionaryComponentResponseOfint64AndDestinyCurrenciesComponentBuilder</returns>
        public DictionaryComponentResponseOfint64AndDestinyCurrenciesComponentBuilder With()
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

        public bool Equals(DictionaryComponentResponseOfint64AndDestinyCurrenciesComponent other)
        {
            return Equals((object) other);
        }

        public override int GetHashCode()
        {
            return this.PropertiesHash();
        }

        /// <summary>
        /// Implementation of == operator for (DictionaryComponentResponseOfint64AndDestinyCurrenciesComponent.
        /// </summary>
        /// <param name="left">Compared (DictionaryComponentResponseOfint64AndDestinyCurrenciesComponent</param>
        /// <param name="right">Compared (DictionaryComponentResponseOfint64AndDestinyCurrenciesComponent</param>
        /// <returns>true if compared items are equals, false otherwise</returns>
        public static bool operator == (DictionaryComponentResponseOfint64AndDestinyCurrenciesComponent left, DictionaryComponentResponseOfint64AndDestinyCurrenciesComponent right)
        {
            return Equals(left, right);
        }

        /// <summary>
        /// Implementation of != operator for (DictionaryComponentResponseOfint64AndDestinyCurrenciesComponent.
        /// </summary>
        /// <param name="left">Compared (DictionaryComponentResponseOfint64AndDestinyCurrenciesComponent</param>
        /// <param name="right">Compared (DictionaryComponentResponseOfint64AndDestinyCurrenciesComponent</param>
        /// <returns>true if compared items are not equals, false otherwise</returns>
        public static bool operator != (DictionaryComponentResponseOfint64AndDestinyCurrenciesComponent left, DictionaryComponentResponseOfint64AndDestinyCurrenciesComponent right)
        {
            return !Equals(left, right);
        }

        /// <summary>
        /// Builder of DictionaryComponentResponseOfint64AndDestinyCurrenciesComponent.
        /// </summary>
        public sealed class DictionaryComponentResponseOfint64AndDestinyCurrenciesComponentBuilder
        {
            private Dictionary<string, DestinyComponentsInventoryDestinyCurrenciesComponent> _Data;
            private int? _Privacy;
            private bool? _Disabled;

            internal DictionaryComponentResponseOfint64AndDestinyCurrenciesComponentBuilder()
            {
                SetupDefaults();
            }

            private void SetupDefaults()
            {
            }

            /// <summary>
            /// Sets value for DictionaryComponentResponseOfint64AndDestinyCurrenciesComponent.Data property.
            /// </summary>
            /// <param name="value">Data</param>
            public DictionaryComponentResponseOfint64AndDestinyCurrenciesComponentBuilder Data(Dictionary<string, DestinyComponentsInventoryDestinyCurrenciesComponent> value)
            {
                _Data = value;
                return this;
            }

            /// <summary>
            /// Sets value for DictionaryComponentResponseOfint64AndDestinyCurrenciesComponent.Privacy property.
            /// </summary>
            /// <param name="value">Privacy</param>
            public DictionaryComponentResponseOfint64AndDestinyCurrenciesComponentBuilder Privacy(int? value)
            {
                _Privacy = value;
                return this;
            }

            /// <summary>
            /// Sets value for DictionaryComponentResponseOfint64AndDestinyCurrenciesComponent.Disabled property.
            /// </summary>
            /// <param name="value">If true, this component is disabled.</param>
            public DictionaryComponentResponseOfint64AndDestinyCurrenciesComponentBuilder Disabled(bool? value)
            {
                _Disabled = value;
                return this;
            }


            /// <summary>
            /// Builds instance of DictionaryComponentResponseOfint64AndDestinyCurrenciesComponent.
            /// </summary>
            /// <returns>DictionaryComponentResponseOfint64AndDestinyCurrenciesComponent</returns>
            public DictionaryComponentResponseOfint64AndDestinyCurrenciesComponent Build()
            {
                Validate();
                return new DictionaryComponentResponseOfint64AndDestinyCurrenciesComponent(
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