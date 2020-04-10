using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Sharpility.Extensions;
using NodaTime;

namespace BungieNetApi._Platform.Models
{
    /// <summary>
    /// DictionaryComponentResponseOfuint32AndDestinyVendorComponent
    /// </summary>
    public sealed class DictionaryComponentResponseOfuint32AndDestinyVendorComponent:  IEquatable<DictionaryComponentResponseOfuint32AndDestinyVendorComponent>
    { 
        /// <summary>
        /// Data
        /// </summary>
        public Dictionary<string, DestinyEntitiesVendorsDestinyVendorComponent> Data { get; private set; }

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
        /// Use DictionaryComponentResponseOfuint32AndDestinyVendorComponent.Builder() for instance creation instead.
        /// </summary>
        [Obsolete]
        public DictionaryComponentResponseOfuint32AndDestinyVendorComponent()
        {
        }

        private DictionaryComponentResponseOfuint32AndDestinyVendorComponent(Dictionary<string, DestinyEntitiesVendorsDestinyVendorComponent> Data, int? Privacy, bool? Disabled)
        {
            
            this.Data = Data;
            
            this.Privacy = Privacy;
            
            this.Disabled = Disabled;
            
        }

        /// <summary>
        /// Returns builder of DictionaryComponentResponseOfuint32AndDestinyVendorComponent.
        /// </summary>
        /// <returns>DictionaryComponentResponseOfuint32AndDestinyVendorComponentBuilder</returns>
        public static DictionaryComponentResponseOfuint32AndDestinyVendorComponentBuilder Builder()
        {
            return new DictionaryComponentResponseOfuint32AndDestinyVendorComponentBuilder();
        }

        /// <summary>
        /// Returns DictionaryComponentResponseOfuint32AndDestinyVendorComponentBuilder with properties set.
        /// Use it to change properties.
        /// </summary>
        /// <returns>DictionaryComponentResponseOfuint32AndDestinyVendorComponentBuilder</returns>
        public DictionaryComponentResponseOfuint32AndDestinyVendorComponentBuilder With()
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

        public bool Equals(DictionaryComponentResponseOfuint32AndDestinyVendorComponent other)
        {
            return Equals((object) other);
        }

        public override int GetHashCode()
        {
            return this.PropertiesHash();
        }

        /// <summary>
        /// Implementation of == operator for (DictionaryComponentResponseOfuint32AndDestinyVendorComponent.
        /// </summary>
        /// <param name="left">Compared (DictionaryComponentResponseOfuint32AndDestinyVendorComponent</param>
        /// <param name="right">Compared (DictionaryComponentResponseOfuint32AndDestinyVendorComponent</param>
        /// <returns>true if compared items are equals, false otherwise</returns>
        public static bool operator == (DictionaryComponentResponseOfuint32AndDestinyVendorComponent left, DictionaryComponentResponseOfuint32AndDestinyVendorComponent right)
        {
            return Equals(left, right);
        }

        /// <summary>
        /// Implementation of != operator for (DictionaryComponentResponseOfuint32AndDestinyVendorComponent.
        /// </summary>
        /// <param name="left">Compared (DictionaryComponentResponseOfuint32AndDestinyVendorComponent</param>
        /// <param name="right">Compared (DictionaryComponentResponseOfuint32AndDestinyVendorComponent</param>
        /// <returns>true if compared items are not equals, false otherwise</returns>
        public static bool operator != (DictionaryComponentResponseOfuint32AndDestinyVendorComponent left, DictionaryComponentResponseOfuint32AndDestinyVendorComponent right)
        {
            return !Equals(left, right);
        }

        /// <summary>
        /// Builder of DictionaryComponentResponseOfuint32AndDestinyVendorComponent.
        /// </summary>
        public sealed class DictionaryComponentResponseOfuint32AndDestinyVendorComponentBuilder
        {
            private Dictionary<string, DestinyEntitiesVendorsDestinyVendorComponent> _Data;
            private int? _Privacy;
            private bool? _Disabled;

            internal DictionaryComponentResponseOfuint32AndDestinyVendorComponentBuilder()
            {
                SetupDefaults();
            }

            private void SetupDefaults()
            {
            }

            /// <summary>
            /// Sets value for DictionaryComponentResponseOfuint32AndDestinyVendorComponent.Data property.
            /// </summary>
            /// <param name="value">Data</param>
            public DictionaryComponentResponseOfuint32AndDestinyVendorComponentBuilder Data(Dictionary<string, DestinyEntitiesVendorsDestinyVendorComponent> value)
            {
                _Data = value;
                return this;
            }

            /// <summary>
            /// Sets value for DictionaryComponentResponseOfuint32AndDestinyVendorComponent.Privacy property.
            /// </summary>
            /// <param name="value">Privacy</param>
            public DictionaryComponentResponseOfuint32AndDestinyVendorComponentBuilder Privacy(int? value)
            {
                _Privacy = value;
                return this;
            }

            /// <summary>
            /// Sets value for DictionaryComponentResponseOfuint32AndDestinyVendorComponent.Disabled property.
            /// </summary>
            /// <param name="value">If true, this component is disabled.</param>
            public DictionaryComponentResponseOfuint32AndDestinyVendorComponentBuilder Disabled(bool? value)
            {
                _Disabled = value;
                return this;
            }


            /// <summary>
            /// Builds instance of DictionaryComponentResponseOfuint32AndDestinyVendorComponent.
            /// </summary>
            /// <returns>DictionaryComponentResponseOfuint32AndDestinyVendorComponent</returns>
            public DictionaryComponentResponseOfuint32AndDestinyVendorComponent Build()
            {
                Validate();
                return new DictionaryComponentResponseOfuint32AndDestinyVendorComponent(
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