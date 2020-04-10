using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Sharpility.Extensions;
using NodaTime;

namespace BungieNetApi._Platform.Models
{
    /// <summary>
    /// DictionaryComponentResponseOfuint32AndDestinyPublicVendorComponent
    /// </summary>
    public sealed class DictionaryComponentResponseOfuint32AndDestinyPublicVendorComponent:  IEquatable<DictionaryComponentResponseOfuint32AndDestinyPublicVendorComponent>
    { 
        /// <summary>
        /// Data
        /// </summary>
        public Dictionary<string, DestinyComponentsVendorsDestinyPublicVendorComponent> Data { get; private set; }

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
        /// Use DictionaryComponentResponseOfuint32AndDestinyPublicVendorComponent.Builder() for instance creation instead.
        /// </summary>
        [Obsolete]
        public DictionaryComponentResponseOfuint32AndDestinyPublicVendorComponent()
        {
        }

        private DictionaryComponentResponseOfuint32AndDestinyPublicVendorComponent(Dictionary<string, DestinyComponentsVendorsDestinyPublicVendorComponent> Data, int? Privacy, bool? Disabled)
        {
            
            this.Data = Data;
            
            this.Privacy = Privacy;
            
            this.Disabled = Disabled;
            
        }

        /// <summary>
        /// Returns builder of DictionaryComponentResponseOfuint32AndDestinyPublicVendorComponent.
        /// </summary>
        /// <returns>DictionaryComponentResponseOfuint32AndDestinyPublicVendorComponentBuilder</returns>
        public static DictionaryComponentResponseOfuint32AndDestinyPublicVendorComponentBuilder Builder()
        {
            return new DictionaryComponentResponseOfuint32AndDestinyPublicVendorComponentBuilder();
        }

        /// <summary>
        /// Returns DictionaryComponentResponseOfuint32AndDestinyPublicVendorComponentBuilder with properties set.
        /// Use it to change properties.
        /// </summary>
        /// <returns>DictionaryComponentResponseOfuint32AndDestinyPublicVendorComponentBuilder</returns>
        public DictionaryComponentResponseOfuint32AndDestinyPublicVendorComponentBuilder With()
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

        public bool Equals(DictionaryComponentResponseOfuint32AndDestinyPublicVendorComponent other)
        {
            return Equals((object) other);
        }

        public override int GetHashCode()
        {
            return this.PropertiesHash();
        }

        /// <summary>
        /// Implementation of == operator for (DictionaryComponentResponseOfuint32AndDestinyPublicVendorComponent.
        /// </summary>
        /// <param name="left">Compared (DictionaryComponentResponseOfuint32AndDestinyPublicVendorComponent</param>
        /// <param name="right">Compared (DictionaryComponentResponseOfuint32AndDestinyPublicVendorComponent</param>
        /// <returns>true if compared items are equals, false otherwise</returns>
        public static bool operator == (DictionaryComponentResponseOfuint32AndDestinyPublicVendorComponent left, DictionaryComponentResponseOfuint32AndDestinyPublicVendorComponent right)
        {
            return Equals(left, right);
        }

        /// <summary>
        /// Implementation of != operator for (DictionaryComponentResponseOfuint32AndDestinyPublicVendorComponent.
        /// </summary>
        /// <param name="left">Compared (DictionaryComponentResponseOfuint32AndDestinyPublicVendorComponent</param>
        /// <param name="right">Compared (DictionaryComponentResponseOfuint32AndDestinyPublicVendorComponent</param>
        /// <returns>true if compared items are not equals, false otherwise</returns>
        public static bool operator != (DictionaryComponentResponseOfuint32AndDestinyPublicVendorComponent left, DictionaryComponentResponseOfuint32AndDestinyPublicVendorComponent right)
        {
            return !Equals(left, right);
        }

        /// <summary>
        /// Builder of DictionaryComponentResponseOfuint32AndDestinyPublicVendorComponent.
        /// </summary>
        public sealed class DictionaryComponentResponseOfuint32AndDestinyPublicVendorComponentBuilder
        {
            private Dictionary<string, DestinyComponentsVendorsDestinyPublicVendorComponent> _Data;
            private int? _Privacy;
            private bool? _Disabled;

            internal DictionaryComponentResponseOfuint32AndDestinyPublicVendorComponentBuilder()
            {
                SetupDefaults();
            }

            private void SetupDefaults()
            {
            }

            /// <summary>
            /// Sets value for DictionaryComponentResponseOfuint32AndDestinyPublicVendorComponent.Data property.
            /// </summary>
            /// <param name="value">Data</param>
            public DictionaryComponentResponseOfuint32AndDestinyPublicVendorComponentBuilder Data(Dictionary<string, DestinyComponentsVendorsDestinyPublicVendorComponent> value)
            {
                _Data = value;
                return this;
            }

            /// <summary>
            /// Sets value for DictionaryComponentResponseOfuint32AndDestinyPublicVendorComponent.Privacy property.
            /// </summary>
            /// <param name="value">Privacy</param>
            public DictionaryComponentResponseOfuint32AndDestinyPublicVendorComponentBuilder Privacy(int? value)
            {
                _Privacy = value;
                return this;
            }

            /// <summary>
            /// Sets value for DictionaryComponentResponseOfuint32AndDestinyPublicVendorComponent.Disabled property.
            /// </summary>
            /// <param name="value">If true, this component is disabled.</param>
            public DictionaryComponentResponseOfuint32AndDestinyPublicVendorComponentBuilder Disabled(bool? value)
            {
                _Disabled = value;
                return this;
            }


            /// <summary>
            /// Builds instance of DictionaryComponentResponseOfuint32AndDestinyPublicVendorComponent.
            /// </summary>
            /// <returns>DictionaryComponentResponseOfuint32AndDestinyPublicVendorComponent</returns>
            public DictionaryComponentResponseOfuint32AndDestinyPublicVendorComponent Build()
            {
                Validate();
                return new DictionaryComponentResponseOfuint32AndDestinyPublicVendorComponent(
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