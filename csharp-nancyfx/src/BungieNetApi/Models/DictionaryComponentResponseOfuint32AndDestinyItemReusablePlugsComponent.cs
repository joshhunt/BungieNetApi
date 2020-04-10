using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Sharpility.Extensions;
using NodaTime;

namespace BungieNetApi._Platform.Models
{
    /// <summary>
    /// DictionaryComponentResponseOfuint32AndDestinyItemReusablePlugsComponent
    /// </summary>
    public sealed class DictionaryComponentResponseOfuint32AndDestinyItemReusablePlugsComponent:  IEquatable<DictionaryComponentResponseOfuint32AndDestinyItemReusablePlugsComponent>
    { 
        /// <summary>
        /// Data
        /// </summary>
        public Dictionary<string, DestinyComponentsItemsDestinyItemReusablePlugsComponent> Data { get; private set; }

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
        /// Use DictionaryComponentResponseOfuint32AndDestinyItemReusablePlugsComponent.Builder() for instance creation instead.
        /// </summary>
        [Obsolete]
        public DictionaryComponentResponseOfuint32AndDestinyItemReusablePlugsComponent()
        {
        }

        private DictionaryComponentResponseOfuint32AndDestinyItemReusablePlugsComponent(Dictionary<string, DestinyComponentsItemsDestinyItemReusablePlugsComponent> Data, int? Privacy, bool? Disabled)
        {
            
            this.Data = Data;
            
            this.Privacy = Privacy;
            
            this.Disabled = Disabled;
            
        }

        /// <summary>
        /// Returns builder of DictionaryComponentResponseOfuint32AndDestinyItemReusablePlugsComponent.
        /// </summary>
        /// <returns>DictionaryComponentResponseOfuint32AndDestinyItemReusablePlugsComponentBuilder</returns>
        public static DictionaryComponentResponseOfuint32AndDestinyItemReusablePlugsComponentBuilder Builder()
        {
            return new DictionaryComponentResponseOfuint32AndDestinyItemReusablePlugsComponentBuilder();
        }

        /// <summary>
        /// Returns DictionaryComponentResponseOfuint32AndDestinyItemReusablePlugsComponentBuilder with properties set.
        /// Use it to change properties.
        /// </summary>
        /// <returns>DictionaryComponentResponseOfuint32AndDestinyItemReusablePlugsComponentBuilder</returns>
        public DictionaryComponentResponseOfuint32AndDestinyItemReusablePlugsComponentBuilder With()
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

        public bool Equals(DictionaryComponentResponseOfuint32AndDestinyItemReusablePlugsComponent other)
        {
            return Equals((object) other);
        }

        public override int GetHashCode()
        {
            return this.PropertiesHash();
        }

        /// <summary>
        /// Implementation of == operator for (DictionaryComponentResponseOfuint32AndDestinyItemReusablePlugsComponent.
        /// </summary>
        /// <param name="left">Compared (DictionaryComponentResponseOfuint32AndDestinyItemReusablePlugsComponent</param>
        /// <param name="right">Compared (DictionaryComponentResponseOfuint32AndDestinyItemReusablePlugsComponent</param>
        /// <returns>true if compared items are equals, false otherwise</returns>
        public static bool operator == (DictionaryComponentResponseOfuint32AndDestinyItemReusablePlugsComponent left, DictionaryComponentResponseOfuint32AndDestinyItemReusablePlugsComponent right)
        {
            return Equals(left, right);
        }

        /// <summary>
        /// Implementation of != operator for (DictionaryComponentResponseOfuint32AndDestinyItemReusablePlugsComponent.
        /// </summary>
        /// <param name="left">Compared (DictionaryComponentResponseOfuint32AndDestinyItemReusablePlugsComponent</param>
        /// <param name="right">Compared (DictionaryComponentResponseOfuint32AndDestinyItemReusablePlugsComponent</param>
        /// <returns>true if compared items are not equals, false otherwise</returns>
        public static bool operator != (DictionaryComponentResponseOfuint32AndDestinyItemReusablePlugsComponent left, DictionaryComponentResponseOfuint32AndDestinyItemReusablePlugsComponent right)
        {
            return !Equals(left, right);
        }

        /// <summary>
        /// Builder of DictionaryComponentResponseOfuint32AndDestinyItemReusablePlugsComponent.
        /// </summary>
        public sealed class DictionaryComponentResponseOfuint32AndDestinyItemReusablePlugsComponentBuilder
        {
            private Dictionary<string, DestinyComponentsItemsDestinyItemReusablePlugsComponent> _Data;
            private int? _Privacy;
            private bool? _Disabled;

            internal DictionaryComponentResponseOfuint32AndDestinyItemReusablePlugsComponentBuilder()
            {
                SetupDefaults();
            }

            private void SetupDefaults()
            {
            }

            /// <summary>
            /// Sets value for DictionaryComponentResponseOfuint32AndDestinyItemReusablePlugsComponent.Data property.
            /// </summary>
            /// <param name="value">Data</param>
            public DictionaryComponentResponseOfuint32AndDestinyItemReusablePlugsComponentBuilder Data(Dictionary<string, DestinyComponentsItemsDestinyItemReusablePlugsComponent> value)
            {
                _Data = value;
                return this;
            }

            /// <summary>
            /// Sets value for DictionaryComponentResponseOfuint32AndDestinyItemReusablePlugsComponent.Privacy property.
            /// </summary>
            /// <param name="value">Privacy</param>
            public DictionaryComponentResponseOfuint32AndDestinyItemReusablePlugsComponentBuilder Privacy(int? value)
            {
                _Privacy = value;
                return this;
            }

            /// <summary>
            /// Sets value for DictionaryComponentResponseOfuint32AndDestinyItemReusablePlugsComponent.Disabled property.
            /// </summary>
            /// <param name="value">If true, this component is disabled.</param>
            public DictionaryComponentResponseOfuint32AndDestinyItemReusablePlugsComponentBuilder Disabled(bool? value)
            {
                _Disabled = value;
                return this;
            }


            /// <summary>
            /// Builds instance of DictionaryComponentResponseOfuint32AndDestinyItemReusablePlugsComponent.
            /// </summary>
            /// <returns>DictionaryComponentResponseOfuint32AndDestinyItemReusablePlugsComponent</returns>
            public DictionaryComponentResponseOfuint32AndDestinyItemReusablePlugsComponent Build()
            {
                Validate();
                return new DictionaryComponentResponseOfuint32AndDestinyItemReusablePlugsComponent(
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