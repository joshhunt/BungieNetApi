using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Sharpility.Extensions;
using NodaTime;

namespace BungieNetApi._Platform.Models
{
    /// <summary>
    /// DictionaryComponentResponseOfint64AndDestinyItemInstanceComponent
    /// </summary>
    public sealed class DictionaryComponentResponseOfint64AndDestinyItemInstanceComponent:  IEquatable<DictionaryComponentResponseOfint64AndDestinyItemInstanceComponent>
    { 
        /// <summary>
        /// Data
        /// </summary>
        public Dictionary<string, DestinyEntitiesItemsDestinyItemInstanceComponent> Data { get; private set; }

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
        /// Use DictionaryComponentResponseOfint64AndDestinyItemInstanceComponent.Builder() for instance creation instead.
        /// </summary>
        [Obsolete]
        public DictionaryComponentResponseOfint64AndDestinyItemInstanceComponent()
        {
        }

        private DictionaryComponentResponseOfint64AndDestinyItemInstanceComponent(Dictionary<string, DestinyEntitiesItemsDestinyItemInstanceComponent> Data, int? Privacy, bool? Disabled)
        {
            
            this.Data = Data;
            
            this.Privacy = Privacy;
            
            this.Disabled = Disabled;
            
        }

        /// <summary>
        /// Returns builder of DictionaryComponentResponseOfint64AndDestinyItemInstanceComponent.
        /// </summary>
        /// <returns>DictionaryComponentResponseOfint64AndDestinyItemInstanceComponentBuilder</returns>
        public static DictionaryComponentResponseOfint64AndDestinyItemInstanceComponentBuilder Builder()
        {
            return new DictionaryComponentResponseOfint64AndDestinyItemInstanceComponentBuilder();
        }

        /// <summary>
        /// Returns DictionaryComponentResponseOfint64AndDestinyItemInstanceComponentBuilder with properties set.
        /// Use it to change properties.
        /// </summary>
        /// <returns>DictionaryComponentResponseOfint64AndDestinyItemInstanceComponentBuilder</returns>
        public DictionaryComponentResponseOfint64AndDestinyItemInstanceComponentBuilder With()
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

        public bool Equals(DictionaryComponentResponseOfint64AndDestinyItemInstanceComponent other)
        {
            return Equals((object) other);
        }

        public override int GetHashCode()
        {
            return this.PropertiesHash();
        }

        /// <summary>
        /// Implementation of == operator for (DictionaryComponentResponseOfint64AndDestinyItemInstanceComponent.
        /// </summary>
        /// <param name="left">Compared (DictionaryComponentResponseOfint64AndDestinyItemInstanceComponent</param>
        /// <param name="right">Compared (DictionaryComponentResponseOfint64AndDestinyItemInstanceComponent</param>
        /// <returns>true if compared items are equals, false otherwise</returns>
        public static bool operator == (DictionaryComponentResponseOfint64AndDestinyItemInstanceComponent left, DictionaryComponentResponseOfint64AndDestinyItemInstanceComponent right)
        {
            return Equals(left, right);
        }

        /// <summary>
        /// Implementation of != operator for (DictionaryComponentResponseOfint64AndDestinyItemInstanceComponent.
        /// </summary>
        /// <param name="left">Compared (DictionaryComponentResponseOfint64AndDestinyItemInstanceComponent</param>
        /// <param name="right">Compared (DictionaryComponentResponseOfint64AndDestinyItemInstanceComponent</param>
        /// <returns>true if compared items are not equals, false otherwise</returns>
        public static bool operator != (DictionaryComponentResponseOfint64AndDestinyItemInstanceComponent left, DictionaryComponentResponseOfint64AndDestinyItemInstanceComponent right)
        {
            return !Equals(left, right);
        }

        /// <summary>
        /// Builder of DictionaryComponentResponseOfint64AndDestinyItemInstanceComponent.
        /// </summary>
        public sealed class DictionaryComponentResponseOfint64AndDestinyItemInstanceComponentBuilder
        {
            private Dictionary<string, DestinyEntitiesItemsDestinyItemInstanceComponent> _Data;
            private int? _Privacy;
            private bool? _Disabled;

            internal DictionaryComponentResponseOfint64AndDestinyItemInstanceComponentBuilder()
            {
                SetupDefaults();
            }

            private void SetupDefaults()
            {
            }

            /// <summary>
            /// Sets value for DictionaryComponentResponseOfint64AndDestinyItemInstanceComponent.Data property.
            /// </summary>
            /// <param name="value">Data</param>
            public DictionaryComponentResponseOfint64AndDestinyItemInstanceComponentBuilder Data(Dictionary<string, DestinyEntitiesItemsDestinyItemInstanceComponent> value)
            {
                _Data = value;
                return this;
            }

            /// <summary>
            /// Sets value for DictionaryComponentResponseOfint64AndDestinyItemInstanceComponent.Privacy property.
            /// </summary>
            /// <param name="value">Privacy</param>
            public DictionaryComponentResponseOfint64AndDestinyItemInstanceComponentBuilder Privacy(int? value)
            {
                _Privacy = value;
                return this;
            }

            /// <summary>
            /// Sets value for DictionaryComponentResponseOfint64AndDestinyItemInstanceComponent.Disabled property.
            /// </summary>
            /// <param name="value">If true, this component is disabled.</param>
            public DictionaryComponentResponseOfint64AndDestinyItemInstanceComponentBuilder Disabled(bool? value)
            {
                _Disabled = value;
                return this;
            }


            /// <summary>
            /// Builds instance of DictionaryComponentResponseOfint64AndDestinyItemInstanceComponent.
            /// </summary>
            /// <returns>DictionaryComponentResponseOfint64AndDestinyItemInstanceComponent</returns>
            public DictionaryComponentResponseOfint64AndDestinyItemInstanceComponent Build()
            {
                Validate();
                return new DictionaryComponentResponseOfint64AndDestinyItemInstanceComponent(
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