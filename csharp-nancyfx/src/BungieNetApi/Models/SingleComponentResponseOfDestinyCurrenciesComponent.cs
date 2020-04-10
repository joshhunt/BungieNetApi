using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Sharpility.Extensions;
using NodaTime;

namespace BungieNetApi._Platform.Models
{
    /// <summary>
    /// SingleComponentResponseOfDestinyCurrenciesComponent
    /// </summary>
    public sealed class SingleComponentResponseOfDestinyCurrenciesComponent:  IEquatable<SingleComponentResponseOfDestinyCurrenciesComponent>
    { 
        /// <summary>
        /// Data
        /// </summary>
        public DestinyComponentsInventoryDestinyCurrenciesComponent Data { get; private set; }

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
        /// Use SingleComponentResponseOfDestinyCurrenciesComponent.Builder() for instance creation instead.
        /// </summary>
        [Obsolete]
        public SingleComponentResponseOfDestinyCurrenciesComponent()
        {
        }

        private SingleComponentResponseOfDestinyCurrenciesComponent(DestinyComponentsInventoryDestinyCurrenciesComponent Data, int? Privacy, bool? Disabled)
        {
            
            this.Data = Data;
            
            this.Privacy = Privacy;
            
            this.Disabled = Disabled;
            
        }

        /// <summary>
        /// Returns builder of SingleComponentResponseOfDestinyCurrenciesComponent.
        /// </summary>
        /// <returns>SingleComponentResponseOfDestinyCurrenciesComponentBuilder</returns>
        public static SingleComponentResponseOfDestinyCurrenciesComponentBuilder Builder()
        {
            return new SingleComponentResponseOfDestinyCurrenciesComponentBuilder();
        }

        /// <summary>
        /// Returns SingleComponentResponseOfDestinyCurrenciesComponentBuilder with properties set.
        /// Use it to change properties.
        /// </summary>
        /// <returns>SingleComponentResponseOfDestinyCurrenciesComponentBuilder</returns>
        public SingleComponentResponseOfDestinyCurrenciesComponentBuilder With()
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

        public bool Equals(SingleComponentResponseOfDestinyCurrenciesComponent other)
        {
            return Equals((object) other);
        }

        public override int GetHashCode()
        {
            return this.PropertiesHash();
        }

        /// <summary>
        /// Implementation of == operator for (SingleComponentResponseOfDestinyCurrenciesComponent.
        /// </summary>
        /// <param name="left">Compared (SingleComponentResponseOfDestinyCurrenciesComponent</param>
        /// <param name="right">Compared (SingleComponentResponseOfDestinyCurrenciesComponent</param>
        /// <returns>true if compared items are equals, false otherwise</returns>
        public static bool operator == (SingleComponentResponseOfDestinyCurrenciesComponent left, SingleComponentResponseOfDestinyCurrenciesComponent right)
        {
            return Equals(left, right);
        }

        /// <summary>
        /// Implementation of != operator for (SingleComponentResponseOfDestinyCurrenciesComponent.
        /// </summary>
        /// <param name="left">Compared (SingleComponentResponseOfDestinyCurrenciesComponent</param>
        /// <param name="right">Compared (SingleComponentResponseOfDestinyCurrenciesComponent</param>
        /// <returns>true if compared items are not equals, false otherwise</returns>
        public static bool operator != (SingleComponentResponseOfDestinyCurrenciesComponent left, SingleComponentResponseOfDestinyCurrenciesComponent right)
        {
            return !Equals(left, right);
        }

        /// <summary>
        /// Builder of SingleComponentResponseOfDestinyCurrenciesComponent.
        /// </summary>
        public sealed class SingleComponentResponseOfDestinyCurrenciesComponentBuilder
        {
            private DestinyComponentsInventoryDestinyCurrenciesComponent _Data;
            private int? _Privacy;
            private bool? _Disabled;

            internal SingleComponentResponseOfDestinyCurrenciesComponentBuilder()
            {
                SetupDefaults();
            }

            private void SetupDefaults()
            {
            }

            /// <summary>
            /// Sets value for SingleComponentResponseOfDestinyCurrenciesComponent.Data property.
            /// </summary>
            /// <param name="value">Data</param>
            public SingleComponentResponseOfDestinyCurrenciesComponentBuilder Data(DestinyComponentsInventoryDestinyCurrenciesComponent value)
            {
                _Data = value;
                return this;
            }

            /// <summary>
            /// Sets value for SingleComponentResponseOfDestinyCurrenciesComponent.Privacy property.
            /// </summary>
            /// <param name="value">Privacy</param>
            public SingleComponentResponseOfDestinyCurrenciesComponentBuilder Privacy(int? value)
            {
                _Privacy = value;
                return this;
            }

            /// <summary>
            /// Sets value for SingleComponentResponseOfDestinyCurrenciesComponent.Disabled property.
            /// </summary>
            /// <param name="value">If true, this component is disabled.</param>
            public SingleComponentResponseOfDestinyCurrenciesComponentBuilder Disabled(bool? value)
            {
                _Disabled = value;
                return this;
            }


            /// <summary>
            /// Builds instance of SingleComponentResponseOfDestinyCurrenciesComponent.
            /// </summary>
            /// <returns>SingleComponentResponseOfDestinyCurrenciesComponent</returns>
            public SingleComponentResponseOfDestinyCurrenciesComponent Build()
            {
                Validate();
                return new SingleComponentResponseOfDestinyCurrenciesComponent(
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