using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Sharpility.Extensions;
using NodaTime;

namespace BungieNetApi._Platform.Models
{
    /// <summary>
    /// DictionaryComponentResponseOfint64AndDestinyItemReusablePlugsComponent
    /// </summary>
    public sealed class DictionaryComponentResponseOfint64AndDestinyItemReusablePlugsComponent:  IEquatable<DictionaryComponentResponseOfint64AndDestinyItemReusablePlugsComponent>
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
        /// Use DictionaryComponentResponseOfint64AndDestinyItemReusablePlugsComponent.Builder() for instance creation instead.
        /// </summary>
        [Obsolete]
        public DictionaryComponentResponseOfint64AndDestinyItemReusablePlugsComponent()
        {
        }

        private DictionaryComponentResponseOfint64AndDestinyItemReusablePlugsComponent(Dictionary<string, DestinyComponentsItemsDestinyItemReusablePlugsComponent> Data, int? Privacy, bool? Disabled)
        {
            
            this.Data = Data;
            
            this.Privacy = Privacy;
            
            this.Disabled = Disabled;
            
        }

        /// <summary>
        /// Returns builder of DictionaryComponentResponseOfint64AndDestinyItemReusablePlugsComponent.
        /// </summary>
        /// <returns>DictionaryComponentResponseOfint64AndDestinyItemReusablePlugsComponentBuilder</returns>
        public static DictionaryComponentResponseOfint64AndDestinyItemReusablePlugsComponentBuilder Builder()
        {
            return new DictionaryComponentResponseOfint64AndDestinyItemReusablePlugsComponentBuilder();
        }

        /// <summary>
        /// Returns DictionaryComponentResponseOfint64AndDestinyItemReusablePlugsComponentBuilder with properties set.
        /// Use it to change properties.
        /// </summary>
        /// <returns>DictionaryComponentResponseOfint64AndDestinyItemReusablePlugsComponentBuilder</returns>
        public DictionaryComponentResponseOfint64AndDestinyItemReusablePlugsComponentBuilder With()
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

        public bool Equals(DictionaryComponentResponseOfint64AndDestinyItemReusablePlugsComponent other)
        {
            return Equals((object) other);
        }

        public override int GetHashCode()
        {
            return this.PropertiesHash();
        }

        /// <summary>
        /// Implementation of == operator for (DictionaryComponentResponseOfint64AndDestinyItemReusablePlugsComponent.
        /// </summary>
        /// <param name="left">Compared (DictionaryComponentResponseOfint64AndDestinyItemReusablePlugsComponent</param>
        /// <param name="right">Compared (DictionaryComponentResponseOfint64AndDestinyItemReusablePlugsComponent</param>
        /// <returns>true if compared items are equals, false otherwise</returns>
        public static bool operator == (DictionaryComponentResponseOfint64AndDestinyItemReusablePlugsComponent left, DictionaryComponentResponseOfint64AndDestinyItemReusablePlugsComponent right)
        {
            return Equals(left, right);
        }

        /// <summary>
        /// Implementation of != operator for (DictionaryComponentResponseOfint64AndDestinyItemReusablePlugsComponent.
        /// </summary>
        /// <param name="left">Compared (DictionaryComponentResponseOfint64AndDestinyItemReusablePlugsComponent</param>
        /// <param name="right">Compared (DictionaryComponentResponseOfint64AndDestinyItemReusablePlugsComponent</param>
        /// <returns>true if compared items are not equals, false otherwise</returns>
        public static bool operator != (DictionaryComponentResponseOfint64AndDestinyItemReusablePlugsComponent left, DictionaryComponentResponseOfint64AndDestinyItemReusablePlugsComponent right)
        {
            return !Equals(left, right);
        }

        /// <summary>
        /// Builder of DictionaryComponentResponseOfint64AndDestinyItemReusablePlugsComponent.
        /// </summary>
        public sealed class DictionaryComponentResponseOfint64AndDestinyItemReusablePlugsComponentBuilder
        {
            private Dictionary<string, DestinyComponentsItemsDestinyItemReusablePlugsComponent> _Data;
            private int? _Privacy;
            private bool? _Disabled;

            internal DictionaryComponentResponseOfint64AndDestinyItemReusablePlugsComponentBuilder()
            {
                SetupDefaults();
            }

            private void SetupDefaults()
            {
            }

            /// <summary>
            /// Sets value for DictionaryComponentResponseOfint64AndDestinyItemReusablePlugsComponent.Data property.
            /// </summary>
            /// <param name="value">Data</param>
            public DictionaryComponentResponseOfint64AndDestinyItemReusablePlugsComponentBuilder Data(Dictionary<string, DestinyComponentsItemsDestinyItemReusablePlugsComponent> value)
            {
                _Data = value;
                return this;
            }

            /// <summary>
            /// Sets value for DictionaryComponentResponseOfint64AndDestinyItemReusablePlugsComponent.Privacy property.
            /// </summary>
            /// <param name="value">Privacy</param>
            public DictionaryComponentResponseOfint64AndDestinyItemReusablePlugsComponentBuilder Privacy(int? value)
            {
                _Privacy = value;
                return this;
            }

            /// <summary>
            /// Sets value for DictionaryComponentResponseOfint64AndDestinyItemReusablePlugsComponent.Disabled property.
            /// </summary>
            /// <param name="value">If true, this component is disabled.</param>
            public DictionaryComponentResponseOfint64AndDestinyItemReusablePlugsComponentBuilder Disabled(bool? value)
            {
                _Disabled = value;
                return this;
            }


            /// <summary>
            /// Builds instance of DictionaryComponentResponseOfint64AndDestinyItemReusablePlugsComponent.
            /// </summary>
            /// <returns>DictionaryComponentResponseOfint64AndDestinyItemReusablePlugsComponent</returns>
            public DictionaryComponentResponseOfint64AndDestinyItemReusablePlugsComponent Build()
            {
                Validate();
                return new DictionaryComponentResponseOfint64AndDestinyItemReusablePlugsComponent(
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