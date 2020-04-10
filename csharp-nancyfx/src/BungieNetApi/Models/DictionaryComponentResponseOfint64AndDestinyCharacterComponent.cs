using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Sharpility.Extensions;
using NodaTime;

namespace BungieNetApi._Platform.Models
{
    /// <summary>
    /// DictionaryComponentResponseOfint64AndDestinyCharacterComponent
    /// </summary>
    public sealed class DictionaryComponentResponseOfint64AndDestinyCharacterComponent:  IEquatable<DictionaryComponentResponseOfint64AndDestinyCharacterComponent>
    { 
        /// <summary>
        /// Data
        /// </summary>
        public Dictionary<string, DestinyEntitiesCharactersDestinyCharacterComponent> Data { get; private set; }

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
        /// Use DictionaryComponentResponseOfint64AndDestinyCharacterComponent.Builder() for instance creation instead.
        /// </summary>
        [Obsolete]
        public DictionaryComponentResponseOfint64AndDestinyCharacterComponent()
        {
        }

        private DictionaryComponentResponseOfint64AndDestinyCharacterComponent(Dictionary<string, DestinyEntitiesCharactersDestinyCharacterComponent> Data, int? Privacy, bool? Disabled)
        {
            
            this.Data = Data;
            
            this.Privacy = Privacy;
            
            this.Disabled = Disabled;
            
        }

        /// <summary>
        /// Returns builder of DictionaryComponentResponseOfint64AndDestinyCharacterComponent.
        /// </summary>
        /// <returns>DictionaryComponentResponseOfint64AndDestinyCharacterComponentBuilder</returns>
        public static DictionaryComponentResponseOfint64AndDestinyCharacterComponentBuilder Builder()
        {
            return new DictionaryComponentResponseOfint64AndDestinyCharacterComponentBuilder();
        }

        /// <summary>
        /// Returns DictionaryComponentResponseOfint64AndDestinyCharacterComponentBuilder with properties set.
        /// Use it to change properties.
        /// </summary>
        /// <returns>DictionaryComponentResponseOfint64AndDestinyCharacterComponentBuilder</returns>
        public DictionaryComponentResponseOfint64AndDestinyCharacterComponentBuilder With()
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

        public bool Equals(DictionaryComponentResponseOfint64AndDestinyCharacterComponent other)
        {
            return Equals((object) other);
        }

        public override int GetHashCode()
        {
            return this.PropertiesHash();
        }

        /// <summary>
        /// Implementation of == operator for (DictionaryComponentResponseOfint64AndDestinyCharacterComponent.
        /// </summary>
        /// <param name="left">Compared (DictionaryComponentResponseOfint64AndDestinyCharacterComponent</param>
        /// <param name="right">Compared (DictionaryComponentResponseOfint64AndDestinyCharacterComponent</param>
        /// <returns>true if compared items are equals, false otherwise</returns>
        public static bool operator == (DictionaryComponentResponseOfint64AndDestinyCharacterComponent left, DictionaryComponentResponseOfint64AndDestinyCharacterComponent right)
        {
            return Equals(left, right);
        }

        /// <summary>
        /// Implementation of != operator for (DictionaryComponentResponseOfint64AndDestinyCharacterComponent.
        /// </summary>
        /// <param name="left">Compared (DictionaryComponentResponseOfint64AndDestinyCharacterComponent</param>
        /// <param name="right">Compared (DictionaryComponentResponseOfint64AndDestinyCharacterComponent</param>
        /// <returns>true if compared items are not equals, false otherwise</returns>
        public static bool operator != (DictionaryComponentResponseOfint64AndDestinyCharacterComponent left, DictionaryComponentResponseOfint64AndDestinyCharacterComponent right)
        {
            return !Equals(left, right);
        }

        /// <summary>
        /// Builder of DictionaryComponentResponseOfint64AndDestinyCharacterComponent.
        /// </summary>
        public sealed class DictionaryComponentResponseOfint64AndDestinyCharacterComponentBuilder
        {
            private Dictionary<string, DestinyEntitiesCharactersDestinyCharacterComponent> _Data;
            private int? _Privacy;
            private bool? _Disabled;

            internal DictionaryComponentResponseOfint64AndDestinyCharacterComponentBuilder()
            {
                SetupDefaults();
            }

            private void SetupDefaults()
            {
            }

            /// <summary>
            /// Sets value for DictionaryComponentResponseOfint64AndDestinyCharacterComponent.Data property.
            /// </summary>
            /// <param name="value">Data</param>
            public DictionaryComponentResponseOfint64AndDestinyCharacterComponentBuilder Data(Dictionary<string, DestinyEntitiesCharactersDestinyCharacterComponent> value)
            {
                _Data = value;
                return this;
            }

            /// <summary>
            /// Sets value for DictionaryComponentResponseOfint64AndDestinyCharacterComponent.Privacy property.
            /// </summary>
            /// <param name="value">Privacy</param>
            public DictionaryComponentResponseOfint64AndDestinyCharacterComponentBuilder Privacy(int? value)
            {
                _Privacy = value;
                return this;
            }

            /// <summary>
            /// Sets value for DictionaryComponentResponseOfint64AndDestinyCharacterComponent.Disabled property.
            /// </summary>
            /// <param name="value">If true, this component is disabled.</param>
            public DictionaryComponentResponseOfint64AndDestinyCharacterComponentBuilder Disabled(bool? value)
            {
                _Disabled = value;
                return this;
            }


            /// <summary>
            /// Builds instance of DictionaryComponentResponseOfint64AndDestinyCharacterComponent.
            /// </summary>
            /// <returns>DictionaryComponentResponseOfint64AndDestinyCharacterComponent</returns>
            public DictionaryComponentResponseOfint64AndDestinyCharacterComponent Build()
            {
                Validate();
                return new DictionaryComponentResponseOfint64AndDestinyCharacterComponent(
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