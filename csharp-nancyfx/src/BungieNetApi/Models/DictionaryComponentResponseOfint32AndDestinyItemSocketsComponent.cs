using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Sharpility.Extensions;
using NodaTime;

namespace BungieNetApi._Platform.Models
{
    /// <summary>
    /// DictionaryComponentResponseOfint32AndDestinyItemSocketsComponent
    /// </summary>
    public sealed class DictionaryComponentResponseOfint32AndDestinyItemSocketsComponent:  IEquatable<DictionaryComponentResponseOfint32AndDestinyItemSocketsComponent>
    { 
        /// <summary>
        /// Data
        /// </summary>
        public Dictionary<string, DestinyEntitiesItemsDestinyItemSocketsComponent> Data { get; private set; }

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
        /// Use DictionaryComponentResponseOfint32AndDestinyItemSocketsComponent.Builder() for instance creation instead.
        /// </summary>
        [Obsolete]
        public DictionaryComponentResponseOfint32AndDestinyItemSocketsComponent()
        {
        }

        private DictionaryComponentResponseOfint32AndDestinyItemSocketsComponent(Dictionary<string, DestinyEntitiesItemsDestinyItemSocketsComponent> Data, int? Privacy, bool? Disabled)
        {
            
            this.Data = Data;
            
            this.Privacy = Privacy;
            
            this.Disabled = Disabled;
            
        }

        /// <summary>
        /// Returns builder of DictionaryComponentResponseOfint32AndDestinyItemSocketsComponent.
        /// </summary>
        /// <returns>DictionaryComponentResponseOfint32AndDestinyItemSocketsComponentBuilder</returns>
        public static DictionaryComponentResponseOfint32AndDestinyItemSocketsComponentBuilder Builder()
        {
            return new DictionaryComponentResponseOfint32AndDestinyItemSocketsComponentBuilder();
        }

        /// <summary>
        /// Returns DictionaryComponentResponseOfint32AndDestinyItemSocketsComponentBuilder with properties set.
        /// Use it to change properties.
        /// </summary>
        /// <returns>DictionaryComponentResponseOfint32AndDestinyItemSocketsComponentBuilder</returns>
        public DictionaryComponentResponseOfint32AndDestinyItemSocketsComponentBuilder With()
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

        public bool Equals(DictionaryComponentResponseOfint32AndDestinyItemSocketsComponent other)
        {
            return Equals((object) other);
        }

        public override int GetHashCode()
        {
            return this.PropertiesHash();
        }

        /// <summary>
        /// Implementation of == operator for (DictionaryComponentResponseOfint32AndDestinyItemSocketsComponent.
        /// </summary>
        /// <param name="left">Compared (DictionaryComponentResponseOfint32AndDestinyItemSocketsComponent</param>
        /// <param name="right">Compared (DictionaryComponentResponseOfint32AndDestinyItemSocketsComponent</param>
        /// <returns>true if compared items are equals, false otherwise</returns>
        public static bool operator == (DictionaryComponentResponseOfint32AndDestinyItemSocketsComponent left, DictionaryComponentResponseOfint32AndDestinyItemSocketsComponent right)
        {
            return Equals(left, right);
        }

        /// <summary>
        /// Implementation of != operator for (DictionaryComponentResponseOfint32AndDestinyItemSocketsComponent.
        /// </summary>
        /// <param name="left">Compared (DictionaryComponentResponseOfint32AndDestinyItemSocketsComponent</param>
        /// <param name="right">Compared (DictionaryComponentResponseOfint32AndDestinyItemSocketsComponent</param>
        /// <returns>true if compared items are not equals, false otherwise</returns>
        public static bool operator != (DictionaryComponentResponseOfint32AndDestinyItemSocketsComponent left, DictionaryComponentResponseOfint32AndDestinyItemSocketsComponent right)
        {
            return !Equals(left, right);
        }

        /// <summary>
        /// Builder of DictionaryComponentResponseOfint32AndDestinyItemSocketsComponent.
        /// </summary>
        public sealed class DictionaryComponentResponseOfint32AndDestinyItemSocketsComponentBuilder
        {
            private Dictionary<string, DestinyEntitiesItemsDestinyItemSocketsComponent> _Data;
            private int? _Privacy;
            private bool? _Disabled;

            internal DictionaryComponentResponseOfint32AndDestinyItemSocketsComponentBuilder()
            {
                SetupDefaults();
            }

            private void SetupDefaults()
            {
            }

            /// <summary>
            /// Sets value for DictionaryComponentResponseOfint32AndDestinyItemSocketsComponent.Data property.
            /// </summary>
            /// <param name="value">Data</param>
            public DictionaryComponentResponseOfint32AndDestinyItemSocketsComponentBuilder Data(Dictionary<string, DestinyEntitiesItemsDestinyItemSocketsComponent> value)
            {
                _Data = value;
                return this;
            }

            /// <summary>
            /// Sets value for DictionaryComponentResponseOfint32AndDestinyItemSocketsComponent.Privacy property.
            /// </summary>
            /// <param name="value">Privacy</param>
            public DictionaryComponentResponseOfint32AndDestinyItemSocketsComponentBuilder Privacy(int? value)
            {
                _Privacy = value;
                return this;
            }

            /// <summary>
            /// Sets value for DictionaryComponentResponseOfint32AndDestinyItemSocketsComponent.Disabled property.
            /// </summary>
            /// <param name="value">If true, this component is disabled.</param>
            public DictionaryComponentResponseOfint32AndDestinyItemSocketsComponentBuilder Disabled(bool? value)
            {
                _Disabled = value;
                return this;
            }


            /// <summary>
            /// Builds instance of DictionaryComponentResponseOfint32AndDestinyItemSocketsComponent.
            /// </summary>
            /// <returns>DictionaryComponentResponseOfint32AndDestinyItemSocketsComponent</returns>
            public DictionaryComponentResponseOfint32AndDestinyItemSocketsComponent Build()
            {
                Validate();
                return new DictionaryComponentResponseOfint32AndDestinyItemSocketsComponent(
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