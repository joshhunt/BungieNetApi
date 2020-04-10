using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Sharpility.Extensions;
using NodaTime;

namespace BungieNetApi._Platform.Models
{
    /// <summary>
    /// SingleComponentResponseOfDestinyVendorComponent
    /// </summary>
    public sealed class SingleComponentResponseOfDestinyVendorComponent:  IEquatable<SingleComponentResponseOfDestinyVendorComponent>
    { 
        /// <summary>
        /// Data
        /// </summary>
        public DestinyEntitiesVendorsDestinyVendorComponent Data { get; private set; }

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
        /// Use SingleComponentResponseOfDestinyVendorComponent.Builder() for instance creation instead.
        /// </summary>
        [Obsolete]
        public SingleComponentResponseOfDestinyVendorComponent()
        {
        }

        private SingleComponentResponseOfDestinyVendorComponent(DestinyEntitiesVendorsDestinyVendorComponent Data, int? Privacy, bool? Disabled)
        {
            
            this.Data = Data;
            
            this.Privacy = Privacy;
            
            this.Disabled = Disabled;
            
        }

        /// <summary>
        /// Returns builder of SingleComponentResponseOfDestinyVendorComponent.
        /// </summary>
        /// <returns>SingleComponentResponseOfDestinyVendorComponentBuilder</returns>
        public static SingleComponentResponseOfDestinyVendorComponentBuilder Builder()
        {
            return new SingleComponentResponseOfDestinyVendorComponentBuilder();
        }

        /// <summary>
        /// Returns SingleComponentResponseOfDestinyVendorComponentBuilder with properties set.
        /// Use it to change properties.
        /// </summary>
        /// <returns>SingleComponentResponseOfDestinyVendorComponentBuilder</returns>
        public SingleComponentResponseOfDestinyVendorComponentBuilder With()
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

        public bool Equals(SingleComponentResponseOfDestinyVendorComponent other)
        {
            return Equals((object) other);
        }

        public override int GetHashCode()
        {
            return this.PropertiesHash();
        }

        /// <summary>
        /// Implementation of == operator for (SingleComponentResponseOfDestinyVendorComponent.
        /// </summary>
        /// <param name="left">Compared (SingleComponentResponseOfDestinyVendorComponent</param>
        /// <param name="right">Compared (SingleComponentResponseOfDestinyVendorComponent</param>
        /// <returns>true if compared items are equals, false otherwise</returns>
        public static bool operator == (SingleComponentResponseOfDestinyVendorComponent left, SingleComponentResponseOfDestinyVendorComponent right)
        {
            return Equals(left, right);
        }

        /// <summary>
        /// Implementation of != operator for (SingleComponentResponseOfDestinyVendorComponent.
        /// </summary>
        /// <param name="left">Compared (SingleComponentResponseOfDestinyVendorComponent</param>
        /// <param name="right">Compared (SingleComponentResponseOfDestinyVendorComponent</param>
        /// <returns>true if compared items are not equals, false otherwise</returns>
        public static bool operator != (SingleComponentResponseOfDestinyVendorComponent left, SingleComponentResponseOfDestinyVendorComponent right)
        {
            return !Equals(left, right);
        }

        /// <summary>
        /// Builder of SingleComponentResponseOfDestinyVendorComponent.
        /// </summary>
        public sealed class SingleComponentResponseOfDestinyVendorComponentBuilder
        {
            private DestinyEntitiesVendorsDestinyVendorComponent _Data;
            private int? _Privacy;
            private bool? _Disabled;

            internal SingleComponentResponseOfDestinyVendorComponentBuilder()
            {
                SetupDefaults();
            }

            private void SetupDefaults()
            {
            }

            /// <summary>
            /// Sets value for SingleComponentResponseOfDestinyVendorComponent.Data property.
            /// </summary>
            /// <param name="value">Data</param>
            public SingleComponentResponseOfDestinyVendorComponentBuilder Data(DestinyEntitiesVendorsDestinyVendorComponent value)
            {
                _Data = value;
                return this;
            }

            /// <summary>
            /// Sets value for SingleComponentResponseOfDestinyVendorComponent.Privacy property.
            /// </summary>
            /// <param name="value">Privacy</param>
            public SingleComponentResponseOfDestinyVendorComponentBuilder Privacy(int? value)
            {
                _Privacy = value;
                return this;
            }

            /// <summary>
            /// Sets value for SingleComponentResponseOfDestinyVendorComponent.Disabled property.
            /// </summary>
            /// <param name="value">If true, this component is disabled.</param>
            public SingleComponentResponseOfDestinyVendorComponentBuilder Disabled(bool? value)
            {
                _Disabled = value;
                return this;
            }


            /// <summary>
            /// Builds instance of SingleComponentResponseOfDestinyVendorComponent.
            /// </summary>
            /// <returns>SingleComponentResponseOfDestinyVendorComponent</returns>
            public SingleComponentResponseOfDestinyVendorComponent Build()
            {
                Validate();
                return new SingleComponentResponseOfDestinyVendorComponent(
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