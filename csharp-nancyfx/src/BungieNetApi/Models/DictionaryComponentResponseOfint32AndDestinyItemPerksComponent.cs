using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Sharpility.Extensions;
using NodaTime;

namespace BungieNetApi._Platform.Models
{
    /// <summary>
    /// DictionaryComponentResponseOfint32AndDestinyItemPerksComponent
    /// </summary>
    public sealed class DictionaryComponentResponseOfint32AndDestinyItemPerksComponent:  IEquatable<DictionaryComponentResponseOfint32AndDestinyItemPerksComponent>
    { 
        /// <summary>
        /// Data
        /// </summary>
        public Dictionary<string, DestinyEntitiesItemsDestinyItemPerksComponent> Data { get; private set; }

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
        /// Use DictionaryComponentResponseOfint32AndDestinyItemPerksComponent.Builder() for instance creation instead.
        /// </summary>
        [Obsolete]
        public DictionaryComponentResponseOfint32AndDestinyItemPerksComponent()
        {
        }

        private DictionaryComponentResponseOfint32AndDestinyItemPerksComponent(Dictionary<string, DestinyEntitiesItemsDestinyItemPerksComponent> Data, int? Privacy, bool? Disabled)
        {
            
            this.Data = Data;
            
            this.Privacy = Privacy;
            
            this.Disabled = Disabled;
            
        }

        /// <summary>
        /// Returns builder of DictionaryComponentResponseOfint32AndDestinyItemPerksComponent.
        /// </summary>
        /// <returns>DictionaryComponentResponseOfint32AndDestinyItemPerksComponentBuilder</returns>
        public static DictionaryComponentResponseOfint32AndDestinyItemPerksComponentBuilder Builder()
        {
            return new DictionaryComponentResponseOfint32AndDestinyItemPerksComponentBuilder();
        }

        /// <summary>
        /// Returns DictionaryComponentResponseOfint32AndDestinyItemPerksComponentBuilder with properties set.
        /// Use it to change properties.
        /// </summary>
        /// <returns>DictionaryComponentResponseOfint32AndDestinyItemPerksComponentBuilder</returns>
        public DictionaryComponentResponseOfint32AndDestinyItemPerksComponentBuilder With()
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

        public bool Equals(DictionaryComponentResponseOfint32AndDestinyItemPerksComponent other)
        {
            return Equals((object) other);
        }

        public override int GetHashCode()
        {
            return this.PropertiesHash();
        }

        /// <summary>
        /// Implementation of == operator for (DictionaryComponentResponseOfint32AndDestinyItemPerksComponent.
        /// </summary>
        /// <param name="left">Compared (DictionaryComponentResponseOfint32AndDestinyItemPerksComponent</param>
        /// <param name="right">Compared (DictionaryComponentResponseOfint32AndDestinyItemPerksComponent</param>
        /// <returns>true if compared items are equals, false otherwise</returns>
        public static bool operator == (DictionaryComponentResponseOfint32AndDestinyItemPerksComponent left, DictionaryComponentResponseOfint32AndDestinyItemPerksComponent right)
        {
            return Equals(left, right);
        }

        /// <summary>
        /// Implementation of != operator for (DictionaryComponentResponseOfint32AndDestinyItemPerksComponent.
        /// </summary>
        /// <param name="left">Compared (DictionaryComponentResponseOfint32AndDestinyItemPerksComponent</param>
        /// <param name="right">Compared (DictionaryComponentResponseOfint32AndDestinyItemPerksComponent</param>
        /// <returns>true if compared items are not equals, false otherwise</returns>
        public static bool operator != (DictionaryComponentResponseOfint32AndDestinyItemPerksComponent left, DictionaryComponentResponseOfint32AndDestinyItemPerksComponent right)
        {
            return !Equals(left, right);
        }

        /// <summary>
        /// Builder of DictionaryComponentResponseOfint32AndDestinyItemPerksComponent.
        /// </summary>
        public sealed class DictionaryComponentResponseOfint32AndDestinyItemPerksComponentBuilder
        {
            private Dictionary<string, DestinyEntitiesItemsDestinyItemPerksComponent> _Data;
            private int? _Privacy;
            private bool? _Disabled;

            internal DictionaryComponentResponseOfint32AndDestinyItemPerksComponentBuilder()
            {
                SetupDefaults();
            }

            private void SetupDefaults()
            {
            }

            /// <summary>
            /// Sets value for DictionaryComponentResponseOfint32AndDestinyItemPerksComponent.Data property.
            /// </summary>
            /// <param name="value">Data</param>
            public DictionaryComponentResponseOfint32AndDestinyItemPerksComponentBuilder Data(Dictionary<string, DestinyEntitiesItemsDestinyItemPerksComponent> value)
            {
                _Data = value;
                return this;
            }

            /// <summary>
            /// Sets value for DictionaryComponentResponseOfint32AndDestinyItemPerksComponent.Privacy property.
            /// </summary>
            /// <param name="value">Privacy</param>
            public DictionaryComponentResponseOfint32AndDestinyItemPerksComponentBuilder Privacy(int? value)
            {
                _Privacy = value;
                return this;
            }

            /// <summary>
            /// Sets value for DictionaryComponentResponseOfint32AndDestinyItemPerksComponent.Disabled property.
            /// </summary>
            /// <param name="value">If true, this component is disabled.</param>
            public DictionaryComponentResponseOfint32AndDestinyItemPerksComponentBuilder Disabled(bool? value)
            {
                _Disabled = value;
                return this;
            }


            /// <summary>
            /// Builds instance of DictionaryComponentResponseOfint32AndDestinyItemPerksComponent.
            /// </summary>
            /// <returns>DictionaryComponentResponseOfint32AndDestinyItemPerksComponent</returns>
            public DictionaryComponentResponseOfint32AndDestinyItemPerksComponent Build()
            {
                Validate();
                return new DictionaryComponentResponseOfint32AndDestinyItemPerksComponent(
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