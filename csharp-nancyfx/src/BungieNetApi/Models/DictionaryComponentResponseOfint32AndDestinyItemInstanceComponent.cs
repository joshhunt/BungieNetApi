using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Sharpility.Extensions;
using NodaTime;

namespace BungieNetApi._Platform.Models
{
    /// <summary>
    /// DictionaryComponentResponseOfint32AndDestinyItemInstanceComponent
    /// </summary>
    public sealed class DictionaryComponentResponseOfint32AndDestinyItemInstanceComponent:  IEquatable<DictionaryComponentResponseOfint32AndDestinyItemInstanceComponent>
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
        /// Use DictionaryComponentResponseOfint32AndDestinyItemInstanceComponent.Builder() for instance creation instead.
        /// </summary>
        [Obsolete]
        public DictionaryComponentResponseOfint32AndDestinyItemInstanceComponent()
        {
        }

        private DictionaryComponentResponseOfint32AndDestinyItemInstanceComponent(Dictionary<string, DestinyEntitiesItemsDestinyItemInstanceComponent> Data, int? Privacy, bool? Disabled)
        {
            
            this.Data = Data;
            
            this.Privacy = Privacy;
            
            this.Disabled = Disabled;
            
        }

        /// <summary>
        /// Returns builder of DictionaryComponentResponseOfint32AndDestinyItemInstanceComponent.
        /// </summary>
        /// <returns>DictionaryComponentResponseOfint32AndDestinyItemInstanceComponentBuilder</returns>
        public static DictionaryComponentResponseOfint32AndDestinyItemInstanceComponentBuilder Builder()
        {
            return new DictionaryComponentResponseOfint32AndDestinyItemInstanceComponentBuilder();
        }

        /// <summary>
        /// Returns DictionaryComponentResponseOfint32AndDestinyItemInstanceComponentBuilder with properties set.
        /// Use it to change properties.
        /// </summary>
        /// <returns>DictionaryComponentResponseOfint32AndDestinyItemInstanceComponentBuilder</returns>
        public DictionaryComponentResponseOfint32AndDestinyItemInstanceComponentBuilder With()
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

        public bool Equals(DictionaryComponentResponseOfint32AndDestinyItemInstanceComponent other)
        {
            return Equals((object) other);
        }

        public override int GetHashCode()
        {
            return this.PropertiesHash();
        }

        /// <summary>
        /// Implementation of == operator for (DictionaryComponentResponseOfint32AndDestinyItemInstanceComponent.
        /// </summary>
        /// <param name="left">Compared (DictionaryComponentResponseOfint32AndDestinyItemInstanceComponent</param>
        /// <param name="right">Compared (DictionaryComponentResponseOfint32AndDestinyItemInstanceComponent</param>
        /// <returns>true if compared items are equals, false otherwise</returns>
        public static bool operator == (DictionaryComponentResponseOfint32AndDestinyItemInstanceComponent left, DictionaryComponentResponseOfint32AndDestinyItemInstanceComponent right)
        {
            return Equals(left, right);
        }

        /// <summary>
        /// Implementation of != operator for (DictionaryComponentResponseOfint32AndDestinyItemInstanceComponent.
        /// </summary>
        /// <param name="left">Compared (DictionaryComponentResponseOfint32AndDestinyItemInstanceComponent</param>
        /// <param name="right">Compared (DictionaryComponentResponseOfint32AndDestinyItemInstanceComponent</param>
        /// <returns>true if compared items are not equals, false otherwise</returns>
        public static bool operator != (DictionaryComponentResponseOfint32AndDestinyItemInstanceComponent left, DictionaryComponentResponseOfint32AndDestinyItemInstanceComponent right)
        {
            return !Equals(left, right);
        }

        /// <summary>
        /// Builder of DictionaryComponentResponseOfint32AndDestinyItemInstanceComponent.
        /// </summary>
        public sealed class DictionaryComponentResponseOfint32AndDestinyItemInstanceComponentBuilder
        {
            private Dictionary<string, DestinyEntitiesItemsDestinyItemInstanceComponent> _Data;
            private int? _Privacy;
            private bool? _Disabled;

            internal DictionaryComponentResponseOfint32AndDestinyItemInstanceComponentBuilder()
            {
                SetupDefaults();
            }

            private void SetupDefaults()
            {
            }

            /// <summary>
            /// Sets value for DictionaryComponentResponseOfint32AndDestinyItemInstanceComponent.Data property.
            /// </summary>
            /// <param name="value">Data</param>
            public DictionaryComponentResponseOfint32AndDestinyItemInstanceComponentBuilder Data(Dictionary<string, DestinyEntitiesItemsDestinyItemInstanceComponent> value)
            {
                _Data = value;
                return this;
            }

            /// <summary>
            /// Sets value for DictionaryComponentResponseOfint32AndDestinyItemInstanceComponent.Privacy property.
            /// </summary>
            /// <param name="value">Privacy</param>
            public DictionaryComponentResponseOfint32AndDestinyItemInstanceComponentBuilder Privacy(int? value)
            {
                _Privacy = value;
                return this;
            }

            /// <summary>
            /// Sets value for DictionaryComponentResponseOfint32AndDestinyItemInstanceComponent.Disabled property.
            /// </summary>
            /// <param name="value">If true, this component is disabled.</param>
            public DictionaryComponentResponseOfint32AndDestinyItemInstanceComponentBuilder Disabled(bool? value)
            {
                _Disabled = value;
                return this;
            }


            /// <summary>
            /// Builds instance of DictionaryComponentResponseOfint32AndDestinyItemInstanceComponent.
            /// </summary>
            /// <returns>DictionaryComponentResponseOfint32AndDestinyItemInstanceComponent</returns>
            public DictionaryComponentResponseOfint32AndDestinyItemInstanceComponent Build()
            {
                Validate();
                return new DictionaryComponentResponseOfint32AndDestinyItemInstanceComponent(
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