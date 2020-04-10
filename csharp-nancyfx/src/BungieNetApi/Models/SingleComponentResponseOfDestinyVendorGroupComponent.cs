using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Sharpility.Extensions;
using NodaTime;

namespace BungieNetApi._Platform.Models
{
    /// <summary>
    /// SingleComponentResponseOfDestinyVendorGroupComponent
    /// </summary>
    public sealed class SingleComponentResponseOfDestinyVendorGroupComponent:  IEquatable<SingleComponentResponseOfDestinyVendorGroupComponent>
    { 
        /// <summary>
        /// Data
        /// </summary>
        public DestinyComponentsVendorsDestinyVendorGroupComponent Data { get; private set; }

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
        /// Use SingleComponentResponseOfDestinyVendorGroupComponent.Builder() for instance creation instead.
        /// </summary>
        [Obsolete]
        public SingleComponentResponseOfDestinyVendorGroupComponent()
        {
        }

        private SingleComponentResponseOfDestinyVendorGroupComponent(DestinyComponentsVendorsDestinyVendorGroupComponent Data, int? Privacy, bool? Disabled)
        {
            
            this.Data = Data;
            
            this.Privacy = Privacy;
            
            this.Disabled = Disabled;
            
        }

        /// <summary>
        /// Returns builder of SingleComponentResponseOfDestinyVendorGroupComponent.
        /// </summary>
        /// <returns>SingleComponentResponseOfDestinyVendorGroupComponentBuilder</returns>
        public static SingleComponentResponseOfDestinyVendorGroupComponentBuilder Builder()
        {
            return new SingleComponentResponseOfDestinyVendorGroupComponentBuilder();
        }

        /// <summary>
        /// Returns SingleComponentResponseOfDestinyVendorGroupComponentBuilder with properties set.
        /// Use it to change properties.
        /// </summary>
        /// <returns>SingleComponentResponseOfDestinyVendorGroupComponentBuilder</returns>
        public SingleComponentResponseOfDestinyVendorGroupComponentBuilder With()
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

        public bool Equals(SingleComponentResponseOfDestinyVendorGroupComponent other)
        {
            return Equals((object) other);
        }

        public override int GetHashCode()
        {
            return this.PropertiesHash();
        }

        /// <summary>
        /// Implementation of == operator for (SingleComponentResponseOfDestinyVendorGroupComponent.
        /// </summary>
        /// <param name="left">Compared (SingleComponentResponseOfDestinyVendorGroupComponent</param>
        /// <param name="right">Compared (SingleComponentResponseOfDestinyVendorGroupComponent</param>
        /// <returns>true if compared items are equals, false otherwise</returns>
        public static bool operator == (SingleComponentResponseOfDestinyVendorGroupComponent left, SingleComponentResponseOfDestinyVendorGroupComponent right)
        {
            return Equals(left, right);
        }

        /// <summary>
        /// Implementation of != operator for (SingleComponentResponseOfDestinyVendorGroupComponent.
        /// </summary>
        /// <param name="left">Compared (SingleComponentResponseOfDestinyVendorGroupComponent</param>
        /// <param name="right">Compared (SingleComponentResponseOfDestinyVendorGroupComponent</param>
        /// <returns>true if compared items are not equals, false otherwise</returns>
        public static bool operator != (SingleComponentResponseOfDestinyVendorGroupComponent left, SingleComponentResponseOfDestinyVendorGroupComponent right)
        {
            return !Equals(left, right);
        }

        /// <summary>
        /// Builder of SingleComponentResponseOfDestinyVendorGroupComponent.
        /// </summary>
        public sealed class SingleComponentResponseOfDestinyVendorGroupComponentBuilder
        {
            private DestinyComponentsVendorsDestinyVendorGroupComponent _Data;
            private int? _Privacy;
            private bool? _Disabled;

            internal SingleComponentResponseOfDestinyVendorGroupComponentBuilder()
            {
                SetupDefaults();
            }

            private void SetupDefaults()
            {
            }

            /// <summary>
            /// Sets value for SingleComponentResponseOfDestinyVendorGroupComponent.Data property.
            /// </summary>
            /// <param name="value">Data</param>
            public SingleComponentResponseOfDestinyVendorGroupComponentBuilder Data(DestinyComponentsVendorsDestinyVendorGroupComponent value)
            {
                _Data = value;
                return this;
            }

            /// <summary>
            /// Sets value for SingleComponentResponseOfDestinyVendorGroupComponent.Privacy property.
            /// </summary>
            /// <param name="value">Privacy</param>
            public SingleComponentResponseOfDestinyVendorGroupComponentBuilder Privacy(int? value)
            {
                _Privacy = value;
                return this;
            }

            /// <summary>
            /// Sets value for SingleComponentResponseOfDestinyVendorGroupComponent.Disabled property.
            /// </summary>
            /// <param name="value">If true, this component is disabled.</param>
            public SingleComponentResponseOfDestinyVendorGroupComponentBuilder Disabled(bool? value)
            {
                _Disabled = value;
                return this;
            }


            /// <summary>
            /// Builds instance of SingleComponentResponseOfDestinyVendorGroupComponent.
            /// </summary>
            /// <returns>SingleComponentResponseOfDestinyVendorGroupComponent</returns>
            public SingleComponentResponseOfDestinyVendorGroupComponent Build()
            {
                Validate();
                return new SingleComponentResponseOfDestinyVendorGroupComponent(
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