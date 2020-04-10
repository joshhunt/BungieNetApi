using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Sharpility.Extensions;
using NodaTime;

namespace BungieNetApi._Platform.Models
{
    /// <summary>
    /// DictionaryComponentResponseOfint32AndDestinyItemReusablePlugsComponent
    /// </summary>
    public sealed class DictionaryComponentResponseOfint32AndDestinyItemReusablePlugsComponent:  IEquatable<DictionaryComponentResponseOfint32AndDestinyItemReusablePlugsComponent>
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
        /// Use DictionaryComponentResponseOfint32AndDestinyItemReusablePlugsComponent.Builder() for instance creation instead.
        /// </summary>
        [Obsolete]
        public DictionaryComponentResponseOfint32AndDestinyItemReusablePlugsComponent()
        {
        }

        private DictionaryComponentResponseOfint32AndDestinyItemReusablePlugsComponent(Dictionary<string, DestinyComponentsItemsDestinyItemReusablePlugsComponent> Data, int? Privacy, bool? Disabled)
        {
            
            this.Data = Data;
            
            this.Privacy = Privacy;
            
            this.Disabled = Disabled;
            
        }

        /// <summary>
        /// Returns builder of DictionaryComponentResponseOfint32AndDestinyItemReusablePlugsComponent.
        /// </summary>
        /// <returns>DictionaryComponentResponseOfint32AndDestinyItemReusablePlugsComponentBuilder</returns>
        public static DictionaryComponentResponseOfint32AndDestinyItemReusablePlugsComponentBuilder Builder()
        {
            return new DictionaryComponentResponseOfint32AndDestinyItemReusablePlugsComponentBuilder();
        }

        /// <summary>
        /// Returns DictionaryComponentResponseOfint32AndDestinyItemReusablePlugsComponentBuilder with properties set.
        /// Use it to change properties.
        /// </summary>
        /// <returns>DictionaryComponentResponseOfint32AndDestinyItemReusablePlugsComponentBuilder</returns>
        public DictionaryComponentResponseOfint32AndDestinyItemReusablePlugsComponentBuilder With()
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

        public bool Equals(DictionaryComponentResponseOfint32AndDestinyItemReusablePlugsComponent other)
        {
            return Equals((object) other);
        }

        public override int GetHashCode()
        {
            return this.PropertiesHash();
        }

        /// <summary>
        /// Implementation of == operator for (DictionaryComponentResponseOfint32AndDestinyItemReusablePlugsComponent.
        /// </summary>
        /// <param name="left">Compared (DictionaryComponentResponseOfint32AndDestinyItemReusablePlugsComponent</param>
        /// <param name="right">Compared (DictionaryComponentResponseOfint32AndDestinyItemReusablePlugsComponent</param>
        /// <returns>true if compared items are equals, false otherwise</returns>
        public static bool operator == (DictionaryComponentResponseOfint32AndDestinyItemReusablePlugsComponent left, DictionaryComponentResponseOfint32AndDestinyItemReusablePlugsComponent right)
        {
            return Equals(left, right);
        }

        /// <summary>
        /// Implementation of != operator for (DictionaryComponentResponseOfint32AndDestinyItemReusablePlugsComponent.
        /// </summary>
        /// <param name="left">Compared (DictionaryComponentResponseOfint32AndDestinyItemReusablePlugsComponent</param>
        /// <param name="right">Compared (DictionaryComponentResponseOfint32AndDestinyItemReusablePlugsComponent</param>
        /// <returns>true if compared items are not equals, false otherwise</returns>
        public static bool operator != (DictionaryComponentResponseOfint32AndDestinyItemReusablePlugsComponent left, DictionaryComponentResponseOfint32AndDestinyItemReusablePlugsComponent right)
        {
            return !Equals(left, right);
        }

        /// <summary>
        /// Builder of DictionaryComponentResponseOfint32AndDestinyItemReusablePlugsComponent.
        /// </summary>
        public sealed class DictionaryComponentResponseOfint32AndDestinyItemReusablePlugsComponentBuilder
        {
            private Dictionary<string, DestinyComponentsItemsDestinyItemReusablePlugsComponent> _Data;
            private int? _Privacy;
            private bool? _Disabled;

            internal DictionaryComponentResponseOfint32AndDestinyItemReusablePlugsComponentBuilder()
            {
                SetupDefaults();
            }

            private void SetupDefaults()
            {
            }

            /// <summary>
            /// Sets value for DictionaryComponentResponseOfint32AndDestinyItemReusablePlugsComponent.Data property.
            /// </summary>
            /// <param name="value">Data</param>
            public DictionaryComponentResponseOfint32AndDestinyItemReusablePlugsComponentBuilder Data(Dictionary<string, DestinyComponentsItemsDestinyItemReusablePlugsComponent> value)
            {
                _Data = value;
                return this;
            }

            /// <summary>
            /// Sets value for DictionaryComponentResponseOfint32AndDestinyItemReusablePlugsComponent.Privacy property.
            /// </summary>
            /// <param name="value">Privacy</param>
            public DictionaryComponentResponseOfint32AndDestinyItemReusablePlugsComponentBuilder Privacy(int? value)
            {
                _Privacy = value;
                return this;
            }

            /// <summary>
            /// Sets value for DictionaryComponentResponseOfint32AndDestinyItemReusablePlugsComponent.Disabled property.
            /// </summary>
            /// <param name="value">If true, this component is disabled.</param>
            public DictionaryComponentResponseOfint32AndDestinyItemReusablePlugsComponentBuilder Disabled(bool? value)
            {
                _Disabled = value;
                return this;
            }


            /// <summary>
            /// Builds instance of DictionaryComponentResponseOfint32AndDestinyItemReusablePlugsComponent.
            /// </summary>
            /// <returns>DictionaryComponentResponseOfint32AndDestinyItemReusablePlugsComponent</returns>
            public DictionaryComponentResponseOfint32AndDestinyItemReusablePlugsComponent Build()
            {
                Validate();
                return new DictionaryComponentResponseOfint32AndDestinyItemReusablePlugsComponent(
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