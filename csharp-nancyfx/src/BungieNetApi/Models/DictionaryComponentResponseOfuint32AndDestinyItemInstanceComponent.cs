using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Sharpility.Extensions;
using NodaTime;

namespace BungieNetApi._Platform.Models
{
    /// <summary>
    /// DictionaryComponentResponseOfuint32AndDestinyItemInstanceComponent
    /// </summary>
    public sealed class DictionaryComponentResponseOfuint32AndDestinyItemInstanceComponent:  IEquatable<DictionaryComponentResponseOfuint32AndDestinyItemInstanceComponent>
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
        /// Use DictionaryComponentResponseOfuint32AndDestinyItemInstanceComponent.Builder() for instance creation instead.
        /// </summary>
        [Obsolete]
        public DictionaryComponentResponseOfuint32AndDestinyItemInstanceComponent()
        {
        }

        private DictionaryComponentResponseOfuint32AndDestinyItemInstanceComponent(Dictionary<string, DestinyEntitiesItemsDestinyItemInstanceComponent> Data, int? Privacy, bool? Disabled)
        {
            
            this.Data = Data;
            
            this.Privacy = Privacy;
            
            this.Disabled = Disabled;
            
        }

        /// <summary>
        /// Returns builder of DictionaryComponentResponseOfuint32AndDestinyItemInstanceComponent.
        /// </summary>
        /// <returns>DictionaryComponentResponseOfuint32AndDestinyItemInstanceComponentBuilder</returns>
        public static DictionaryComponentResponseOfuint32AndDestinyItemInstanceComponentBuilder Builder()
        {
            return new DictionaryComponentResponseOfuint32AndDestinyItemInstanceComponentBuilder();
        }

        /// <summary>
        /// Returns DictionaryComponentResponseOfuint32AndDestinyItemInstanceComponentBuilder with properties set.
        /// Use it to change properties.
        /// </summary>
        /// <returns>DictionaryComponentResponseOfuint32AndDestinyItemInstanceComponentBuilder</returns>
        public DictionaryComponentResponseOfuint32AndDestinyItemInstanceComponentBuilder With()
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

        public bool Equals(DictionaryComponentResponseOfuint32AndDestinyItemInstanceComponent other)
        {
            return Equals((object) other);
        }

        public override int GetHashCode()
        {
            return this.PropertiesHash();
        }

        /// <summary>
        /// Implementation of == operator for (DictionaryComponentResponseOfuint32AndDestinyItemInstanceComponent.
        /// </summary>
        /// <param name="left">Compared (DictionaryComponentResponseOfuint32AndDestinyItemInstanceComponent</param>
        /// <param name="right">Compared (DictionaryComponentResponseOfuint32AndDestinyItemInstanceComponent</param>
        /// <returns>true if compared items are equals, false otherwise</returns>
        public static bool operator == (DictionaryComponentResponseOfuint32AndDestinyItemInstanceComponent left, DictionaryComponentResponseOfuint32AndDestinyItemInstanceComponent right)
        {
            return Equals(left, right);
        }

        /// <summary>
        /// Implementation of != operator for (DictionaryComponentResponseOfuint32AndDestinyItemInstanceComponent.
        /// </summary>
        /// <param name="left">Compared (DictionaryComponentResponseOfuint32AndDestinyItemInstanceComponent</param>
        /// <param name="right">Compared (DictionaryComponentResponseOfuint32AndDestinyItemInstanceComponent</param>
        /// <returns>true if compared items are not equals, false otherwise</returns>
        public static bool operator != (DictionaryComponentResponseOfuint32AndDestinyItemInstanceComponent left, DictionaryComponentResponseOfuint32AndDestinyItemInstanceComponent right)
        {
            return !Equals(left, right);
        }

        /// <summary>
        /// Builder of DictionaryComponentResponseOfuint32AndDestinyItemInstanceComponent.
        /// </summary>
        public sealed class DictionaryComponentResponseOfuint32AndDestinyItemInstanceComponentBuilder
        {
            private Dictionary<string, DestinyEntitiesItemsDestinyItemInstanceComponent> _Data;
            private int? _Privacy;
            private bool? _Disabled;

            internal DictionaryComponentResponseOfuint32AndDestinyItemInstanceComponentBuilder()
            {
                SetupDefaults();
            }

            private void SetupDefaults()
            {
            }

            /// <summary>
            /// Sets value for DictionaryComponentResponseOfuint32AndDestinyItemInstanceComponent.Data property.
            /// </summary>
            /// <param name="value">Data</param>
            public DictionaryComponentResponseOfuint32AndDestinyItemInstanceComponentBuilder Data(Dictionary<string, DestinyEntitiesItemsDestinyItemInstanceComponent> value)
            {
                _Data = value;
                return this;
            }

            /// <summary>
            /// Sets value for DictionaryComponentResponseOfuint32AndDestinyItemInstanceComponent.Privacy property.
            /// </summary>
            /// <param name="value">Privacy</param>
            public DictionaryComponentResponseOfuint32AndDestinyItemInstanceComponentBuilder Privacy(int? value)
            {
                _Privacy = value;
                return this;
            }

            /// <summary>
            /// Sets value for DictionaryComponentResponseOfuint32AndDestinyItemInstanceComponent.Disabled property.
            /// </summary>
            /// <param name="value">If true, this component is disabled.</param>
            public DictionaryComponentResponseOfuint32AndDestinyItemInstanceComponentBuilder Disabled(bool? value)
            {
                _Disabled = value;
                return this;
            }


            /// <summary>
            /// Builds instance of DictionaryComponentResponseOfuint32AndDestinyItemInstanceComponent.
            /// </summary>
            /// <returns>DictionaryComponentResponseOfuint32AndDestinyItemInstanceComponent</returns>
            public DictionaryComponentResponseOfuint32AndDestinyItemInstanceComponent Build()
            {
                Validate();
                return new DictionaryComponentResponseOfuint32AndDestinyItemInstanceComponent(
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