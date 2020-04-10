using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Sharpility.Extensions;
using NodaTime;

namespace BungieNetApi._Platform.Models
{
    /// <summary>
    /// SingleComponentResponseOfDestinyVendorReceiptsComponent
    /// </summary>
    public sealed class SingleComponentResponseOfDestinyVendorReceiptsComponent:  IEquatable<SingleComponentResponseOfDestinyVendorReceiptsComponent>
    { 
        /// <summary>
        /// Data
        /// </summary>
        public DestinyEntitiesProfilesDestinyVendorReceiptsComponent Data { get; private set; }

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
        /// Use SingleComponentResponseOfDestinyVendorReceiptsComponent.Builder() for instance creation instead.
        /// </summary>
        [Obsolete]
        public SingleComponentResponseOfDestinyVendorReceiptsComponent()
        {
        }

        private SingleComponentResponseOfDestinyVendorReceiptsComponent(DestinyEntitiesProfilesDestinyVendorReceiptsComponent Data, int? Privacy, bool? Disabled)
        {
            
            this.Data = Data;
            
            this.Privacy = Privacy;
            
            this.Disabled = Disabled;
            
        }

        /// <summary>
        /// Returns builder of SingleComponentResponseOfDestinyVendorReceiptsComponent.
        /// </summary>
        /// <returns>SingleComponentResponseOfDestinyVendorReceiptsComponentBuilder</returns>
        public static SingleComponentResponseOfDestinyVendorReceiptsComponentBuilder Builder()
        {
            return new SingleComponentResponseOfDestinyVendorReceiptsComponentBuilder();
        }

        /// <summary>
        /// Returns SingleComponentResponseOfDestinyVendorReceiptsComponentBuilder with properties set.
        /// Use it to change properties.
        /// </summary>
        /// <returns>SingleComponentResponseOfDestinyVendorReceiptsComponentBuilder</returns>
        public SingleComponentResponseOfDestinyVendorReceiptsComponentBuilder With()
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

        public bool Equals(SingleComponentResponseOfDestinyVendorReceiptsComponent other)
        {
            return Equals((object) other);
        }

        public override int GetHashCode()
        {
            return this.PropertiesHash();
        }

        /// <summary>
        /// Implementation of == operator for (SingleComponentResponseOfDestinyVendorReceiptsComponent.
        /// </summary>
        /// <param name="left">Compared (SingleComponentResponseOfDestinyVendorReceiptsComponent</param>
        /// <param name="right">Compared (SingleComponentResponseOfDestinyVendorReceiptsComponent</param>
        /// <returns>true if compared items are equals, false otherwise</returns>
        public static bool operator == (SingleComponentResponseOfDestinyVendorReceiptsComponent left, SingleComponentResponseOfDestinyVendorReceiptsComponent right)
        {
            return Equals(left, right);
        }

        /// <summary>
        /// Implementation of != operator for (SingleComponentResponseOfDestinyVendorReceiptsComponent.
        /// </summary>
        /// <param name="left">Compared (SingleComponentResponseOfDestinyVendorReceiptsComponent</param>
        /// <param name="right">Compared (SingleComponentResponseOfDestinyVendorReceiptsComponent</param>
        /// <returns>true if compared items are not equals, false otherwise</returns>
        public static bool operator != (SingleComponentResponseOfDestinyVendorReceiptsComponent left, SingleComponentResponseOfDestinyVendorReceiptsComponent right)
        {
            return !Equals(left, right);
        }

        /// <summary>
        /// Builder of SingleComponentResponseOfDestinyVendorReceiptsComponent.
        /// </summary>
        public sealed class SingleComponentResponseOfDestinyVendorReceiptsComponentBuilder
        {
            private DestinyEntitiesProfilesDestinyVendorReceiptsComponent _Data;
            private int? _Privacy;
            private bool? _Disabled;

            internal SingleComponentResponseOfDestinyVendorReceiptsComponentBuilder()
            {
                SetupDefaults();
            }

            private void SetupDefaults()
            {
            }

            /// <summary>
            /// Sets value for SingleComponentResponseOfDestinyVendorReceiptsComponent.Data property.
            /// </summary>
            /// <param name="value">Data</param>
            public SingleComponentResponseOfDestinyVendorReceiptsComponentBuilder Data(DestinyEntitiesProfilesDestinyVendorReceiptsComponent value)
            {
                _Data = value;
                return this;
            }

            /// <summary>
            /// Sets value for SingleComponentResponseOfDestinyVendorReceiptsComponent.Privacy property.
            /// </summary>
            /// <param name="value">Privacy</param>
            public SingleComponentResponseOfDestinyVendorReceiptsComponentBuilder Privacy(int? value)
            {
                _Privacy = value;
                return this;
            }

            /// <summary>
            /// Sets value for SingleComponentResponseOfDestinyVendorReceiptsComponent.Disabled property.
            /// </summary>
            /// <param name="value">If true, this component is disabled.</param>
            public SingleComponentResponseOfDestinyVendorReceiptsComponentBuilder Disabled(bool? value)
            {
                _Disabled = value;
                return this;
            }


            /// <summary>
            /// Builds instance of SingleComponentResponseOfDestinyVendorReceiptsComponent.
            /// </summary>
            /// <returns>SingleComponentResponseOfDestinyVendorReceiptsComponent</returns>
            public SingleComponentResponseOfDestinyVendorReceiptsComponent Build()
            {
                Validate();
                return new SingleComponentResponseOfDestinyVendorReceiptsComponent(
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