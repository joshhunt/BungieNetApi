using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Sharpility.Extensions;
using NodaTime;

namespace BungieNetApi._Platform.Models
{
    /// <summary>
    /// DictionaryComponentResponseOfuint32AndDestinyItemSocketsComponent
    /// </summary>
    public sealed class DictionaryComponentResponseOfuint32AndDestinyItemSocketsComponent:  IEquatable<DictionaryComponentResponseOfuint32AndDestinyItemSocketsComponent>
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
        /// Use DictionaryComponentResponseOfuint32AndDestinyItemSocketsComponent.Builder() for instance creation instead.
        /// </summary>
        [Obsolete]
        public DictionaryComponentResponseOfuint32AndDestinyItemSocketsComponent()
        {
        }

        private DictionaryComponentResponseOfuint32AndDestinyItemSocketsComponent(Dictionary<string, DestinyEntitiesItemsDestinyItemSocketsComponent> Data, int? Privacy, bool? Disabled)
        {
            
            this.Data = Data;
            
            this.Privacy = Privacy;
            
            this.Disabled = Disabled;
            
        }

        /// <summary>
        /// Returns builder of DictionaryComponentResponseOfuint32AndDestinyItemSocketsComponent.
        /// </summary>
        /// <returns>DictionaryComponentResponseOfuint32AndDestinyItemSocketsComponentBuilder</returns>
        public static DictionaryComponentResponseOfuint32AndDestinyItemSocketsComponentBuilder Builder()
        {
            return new DictionaryComponentResponseOfuint32AndDestinyItemSocketsComponentBuilder();
        }

        /// <summary>
        /// Returns DictionaryComponentResponseOfuint32AndDestinyItemSocketsComponentBuilder with properties set.
        /// Use it to change properties.
        /// </summary>
        /// <returns>DictionaryComponentResponseOfuint32AndDestinyItemSocketsComponentBuilder</returns>
        public DictionaryComponentResponseOfuint32AndDestinyItemSocketsComponentBuilder With()
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

        public bool Equals(DictionaryComponentResponseOfuint32AndDestinyItemSocketsComponent other)
        {
            return Equals((object) other);
        }

        public override int GetHashCode()
        {
            return this.PropertiesHash();
        }

        /// <summary>
        /// Implementation of == operator for (DictionaryComponentResponseOfuint32AndDestinyItemSocketsComponent.
        /// </summary>
        /// <param name="left">Compared (DictionaryComponentResponseOfuint32AndDestinyItemSocketsComponent</param>
        /// <param name="right">Compared (DictionaryComponentResponseOfuint32AndDestinyItemSocketsComponent</param>
        /// <returns>true if compared items are equals, false otherwise</returns>
        public static bool operator == (DictionaryComponentResponseOfuint32AndDestinyItemSocketsComponent left, DictionaryComponentResponseOfuint32AndDestinyItemSocketsComponent right)
        {
            return Equals(left, right);
        }

        /// <summary>
        /// Implementation of != operator for (DictionaryComponentResponseOfuint32AndDestinyItemSocketsComponent.
        /// </summary>
        /// <param name="left">Compared (DictionaryComponentResponseOfuint32AndDestinyItemSocketsComponent</param>
        /// <param name="right">Compared (DictionaryComponentResponseOfuint32AndDestinyItemSocketsComponent</param>
        /// <returns>true if compared items are not equals, false otherwise</returns>
        public static bool operator != (DictionaryComponentResponseOfuint32AndDestinyItemSocketsComponent left, DictionaryComponentResponseOfuint32AndDestinyItemSocketsComponent right)
        {
            return !Equals(left, right);
        }

        /// <summary>
        /// Builder of DictionaryComponentResponseOfuint32AndDestinyItemSocketsComponent.
        /// </summary>
        public sealed class DictionaryComponentResponseOfuint32AndDestinyItemSocketsComponentBuilder
        {
            private Dictionary<string, DestinyEntitiesItemsDestinyItemSocketsComponent> _Data;
            private int? _Privacy;
            private bool? _Disabled;

            internal DictionaryComponentResponseOfuint32AndDestinyItemSocketsComponentBuilder()
            {
                SetupDefaults();
            }

            private void SetupDefaults()
            {
            }

            /// <summary>
            /// Sets value for DictionaryComponentResponseOfuint32AndDestinyItemSocketsComponent.Data property.
            /// </summary>
            /// <param name="value">Data</param>
            public DictionaryComponentResponseOfuint32AndDestinyItemSocketsComponentBuilder Data(Dictionary<string, DestinyEntitiesItemsDestinyItemSocketsComponent> value)
            {
                _Data = value;
                return this;
            }

            /// <summary>
            /// Sets value for DictionaryComponentResponseOfuint32AndDestinyItemSocketsComponent.Privacy property.
            /// </summary>
            /// <param name="value">Privacy</param>
            public DictionaryComponentResponseOfuint32AndDestinyItemSocketsComponentBuilder Privacy(int? value)
            {
                _Privacy = value;
                return this;
            }

            /// <summary>
            /// Sets value for DictionaryComponentResponseOfuint32AndDestinyItemSocketsComponent.Disabled property.
            /// </summary>
            /// <param name="value">If true, this component is disabled.</param>
            public DictionaryComponentResponseOfuint32AndDestinyItemSocketsComponentBuilder Disabled(bool? value)
            {
                _Disabled = value;
                return this;
            }


            /// <summary>
            /// Builds instance of DictionaryComponentResponseOfuint32AndDestinyItemSocketsComponent.
            /// </summary>
            /// <returns>DictionaryComponentResponseOfuint32AndDestinyItemSocketsComponent</returns>
            public DictionaryComponentResponseOfuint32AndDestinyItemSocketsComponent Build()
            {
                Validate();
                return new DictionaryComponentResponseOfuint32AndDestinyItemSocketsComponent(
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