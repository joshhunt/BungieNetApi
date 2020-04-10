using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Sharpility.Extensions;
using NodaTime;

namespace BungieNetApi._Platform.Models
{
    /// <summary>
    /// DictionaryComponentResponseOfuint32AndDestinyItemPerksComponent
    /// </summary>
    public sealed class DictionaryComponentResponseOfuint32AndDestinyItemPerksComponent:  IEquatable<DictionaryComponentResponseOfuint32AndDestinyItemPerksComponent>
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
        /// Use DictionaryComponentResponseOfuint32AndDestinyItemPerksComponent.Builder() for instance creation instead.
        /// </summary>
        [Obsolete]
        public DictionaryComponentResponseOfuint32AndDestinyItemPerksComponent()
        {
        }

        private DictionaryComponentResponseOfuint32AndDestinyItemPerksComponent(Dictionary<string, DestinyEntitiesItemsDestinyItemPerksComponent> Data, int? Privacy, bool? Disabled)
        {
            
            this.Data = Data;
            
            this.Privacy = Privacy;
            
            this.Disabled = Disabled;
            
        }

        /// <summary>
        /// Returns builder of DictionaryComponentResponseOfuint32AndDestinyItemPerksComponent.
        /// </summary>
        /// <returns>DictionaryComponentResponseOfuint32AndDestinyItemPerksComponentBuilder</returns>
        public static DictionaryComponentResponseOfuint32AndDestinyItemPerksComponentBuilder Builder()
        {
            return new DictionaryComponentResponseOfuint32AndDestinyItemPerksComponentBuilder();
        }

        /// <summary>
        /// Returns DictionaryComponentResponseOfuint32AndDestinyItemPerksComponentBuilder with properties set.
        /// Use it to change properties.
        /// </summary>
        /// <returns>DictionaryComponentResponseOfuint32AndDestinyItemPerksComponentBuilder</returns>
        public DictionaryComponentResponseOfuint32AndDestinyItemPerksComponentBuilder With()
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

        public bool Equals(DictionaryComponentResponseOfuint32AndDestinyItemPerksComponent other)
        {
            return Equals((object) other);
        }

        public override int GetHashCode()
        {
            return this.PropertiesHash();
        }

        /// <summary>
        /// Implementation of == operator for (DictionaryComponentResponseOfuint32AndDestinyItemPerksComponent.
        /// </summary>
        /// <param name="left">Compared (DictionaryComponentResponseOfuint32AndDestinyItemPerksComponent</param>
        /// <param name="right">Compared (DictionaryComponentResponseOfuint32AndDestinyItemPerksComponent</param>
        /// <returns>true if compared items are equals, false otherwise</returns>
        public static bool operator == (DictionaryComponentResponseOfuint32AndDestinyItemPerksComponent left, DictionaryComponentResponseOfuint32AndDestinyItemPerksComponent right)
        {
            return Equals(left, right);
        }

        /// <summary>
        /// Implementation of != operator for (DictionaryComponentResponseOfuint32AndDestinyItemPerksComponent.
        /// </summary>
        /// <param name="left">Compared (DictionaryComponentResponseOfuint32AndDestinyItemPerksComponent</param>
        /// <param name="right">Compared (DictionaryComponentResponseOfuint32AndDestinyItemPerksComponent</param>
        /// <returns>true if compared items are not equals, false otherwise</returns>
        public static bool operator != (DictionaryComponentResponseOfuint32AndDestinyItemPerksComponent left, DictionaryComponentResponseOfuint32AndDestinyItemPerksComponent right)
        {
            return !Equals(left, right);
        }

        /// <summary>
        /// Builder of DictionaryComponentResponseOfuint32AndDestinyItemPerksComponent.
        /// </summary>
        public sealed class DictionaryComponentResponseOfuint32AndDestinyItemPerksComponentBuilder
        {
            private Dictionary<string, DestinyEntitiesItemsDestinyItemPerksComponent> _Data;
            private int? _Privacy;
            private bool? _Disabled;

            internal DictionaryComponentResponseOfuint32AndDestinyItemPerksComponentBuilder()
            {
                SetupDefaults();
            }

            private void SetupDefaults()
            {
            }

            /// <summary>
            /// Sets value for DictionaryComponentResponseOfuint32AndDestinyItemPerksComponent.Data property.
            /// </summary>
            /// <param name="value">Data</param>
            public DictionaryComponentResponseOfuint32AndDestinyItemPerksComponentBuilder Data(Dictionary<string, DestinyEntitiesItemsDestinyItemPerksComponent> value)
            {
                _Data = value;
                return this;
            }

            /// <summary>
            /// Sets value for DictionaryComponentResponseOfuint32AndDestinyItemPerksComponent.Privacy property.
            /// </summary>
            /// <param name="value">Privacy</param>
            public DictionaryComponentResponseOfuint32AndDestinyItemPerksComponentBuilder Privacy(int? value)
            {
                _Privacy = value;
                return this;
            }

            /// <summary>
            /// Sets value for DictionaryComponentResponseOfuint32AndDestinyItemPerksComponent.Disabled property.
            /// </summary>
            /// <param name="value">If true, this component is disabled.</param>
            public DictionaryComponentResponseOfuint32AndDestinyItemPerksComponentBuilder Disabled(bool? value)
            {
                _Disabled = value;
                return this;
            }


            /// <summary>
            /// Builds instance of DictionaryComponentResponseOfuint32AndDestinyItemPerksComponent.
            /// </summary>
            /// <returns>DictionaryComponentResponseOfuint32AndDestinyItemPerksComponent</returns>
            public DictionaryComponentResponseOfuint32AndDestinyItemPerksComponent Build()
            {
                Validate();
                return new DictionaryComponentResponseOfuint32AndDestinyItemPerksComponent(
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