using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Sharpility.Extensions;
using NodaTime;

namespace BungieNetApi._Platform.Models
{
    /// <summary>
    /// DictionaryComponentResponseOfint64AndDestinyCharacterProgressionComponent
    /// </summary>
    public sealed class DictionaryComponentResponseOfint64AndDestinyCharacterProgressionComponent:  IEquatable<DictionaryComponentResponseOfint64AndDestinyCharacterProgressionComponent>
    { 
        /// <summary>
        /// Data
        /// </summary>
        public Dictionary<string, DestinyEntitiesCharactersDestinyCharacterProgressionComponent> Data { get; private set; }

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
        /// Use DictionaryComponentResponseOfint64AndDestinyCharacterProgressionComponent.Builder() for instance creation instead.
        /// </summary>
        [Obsolete]
        public DictionaryComponentResponseOfint64AndDestinyCharacterProgressionComponent()
        {
        }

        private DictionaryComponentResponseOfint64AndDestinyCharacterProgressionComponent(Dictionary<string, DestinyEntitiesCharactersDestinyCharacterProgressionComponent> Data, int? Privacy, bool? Disabled)
        {
            
            this.Data = Data;
            
            this.Privacy = Privacy;
            
            this.Disabled = Disabled;
            
        }

        /// <summary>
        /// Returns builder of DictionaryComponentResponseOfint64AndDestinyCharacterProgressionComponent.
        /// </summary>
        /// <returns>DictionaryComponentResponseOfint64AndDestinyCharacterProgressionComponentBuilder</returns>
        public static DictionaryComponentResponseOfint64AndDestinyCharacterProgressionComponentBuilder Builder()
        {
            return new DictionaryComponentResponseOfint64AndDestinyCharacterProgressionComponentBuilder();
        }

        /// <summary>
        /// Returns DictionaryComponentResponseOfint64AndDestinyCharacterProgressionComponentBuilder with properties set.
        /// Use it to change properties.
        /// </summary>
        /// <returns>DictionaryComponentResponseOfint64AndDestinyCharacterProgressionComponentBuilder</returns>
        public DictionaryComponentResponseOfint64AndDestinyCharacterProgressionComponentBuilder With()
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

        public bool Equals(DictionaryComponentResponseOfint64AndDestinyCharacterProgressionComponent other)
        {
            return Equals((object) other);
        }

        public override int GetHashCode()
        {
            return this.PropertiesHash();
        }

        /// <summary>
        /// Implementation of == operator for (DictionaryComponentResponseOfint64AndDestinyCharacterProgressionComponent.
        /// </summary>
        /// <param name="left">Compared (DictionaryComponentResponseOfint64AndDestinyCharacterProgressionComponent</param>
        /// <param name="right">Compared (DictionaryComponentResponseOfint64AndDestinyCharacterProgressionComponent</param>
        /// <returns>true if compared items are equals, false otherwise</returns>
        public static bool operator == (DictionaryComponentResponseOfint64AndDestinyCharacterProgressionComponent left, DictionaryComponentResponseOfint64AndDestinyCharacterProgressionComponent right)
        {
            return Equals(left, right);
        }

        /// <summary>
        /// Implementation of != operator for (DictionaryComponentResponseOfint64AndDestinyCharacterProgressionComponent.
        /// </summary>
        /// <param name="left">Compared (DictionaryComponentResponseOfint64AndDestinyCharacterProgressionComponent</param>
        /// <param name="right">Compared (DictionaryComponentResponseOfint64AndDestinyCharacterProgressionComponent</param>
        /// <returns>true if compared items are not equals, false otherwise</returns>
        public static bool operator != (DictionaryComponentResponseOfint64AndDestinyCharacterProgressionComponent left, DictionaryComponentResponseOfint64AndDestinyCharacterProgressionComponent right)
        {
            return !Equals(left, right);
        }

        /// <summary>
        /// Builder of DictionaryComponentResponseOfint64AndDestinyCharacterProgressionComponent.
        /// </summary>
        public sealed class DictionaryComponentResponseOfint64AndDestinyCharacterProgressionComponentBuilder
        {
            private Dictionary<string, DestinyEntitiesCharactersDestinyCharacterProgressionComponent> _Data;
            private int? _Privacy;
            private bool? _Disabled;

            internal DictionaryComponentResponseOfint64AndDestinyCharacterProgressionComponentBuilder()
            {
                SetupDefaults();
            }

            private void SetupDefaults()
            {
            }

            /// <summary>
            /// Sets value for DictionaryComponentResponseOfint64AndDestinyCharacterProgressionComponent.Data property.
            /// </summary>
            /// <param name="value">Data</param>
            public DictionaryComponentResponseOfint64AndDestinyCharacterProgressionComponentBuilder Data(Dictionary<string, DestinyEntitiesCharactersDestinyCharacterProgressionComponent> value)
            {
                _Data = value;
                return this;
            }

            /// <summary>
            /// Sets value for DictionaryComponentResponseOfint64AndDestinyCharacterProgressionComponent.Privacy property.
            /// </summary>
            /// <param name="value">Privacy</param>
            public DictionaryComponentResponseOfint64AndDestinyCharacterProgressionComponentBuilder Privacy(int? value)
            {
                _Privacy = value;
                return this;
            }

            /// <summary>
            /// Sets value for DictionaryComponentResponseOfint64AndDestinyCharacterProgressionComponent.Disabled property.
            /// </summary>
            /// <param name="value">If true, this component is disabled.</param>
            public DictionaryComponentResponseOfint64AndDestinyCharacterProgressionComponentBuilder Disabled(bool? value)
            {
                _Disabled = value;
                return this;
            }


            /// <summary>
            /// Builds instance of DictionaryComponentResponseOfint64AndDestinyCharacterProgressionComponent.
            /// </summary>
            /// <returns>DictionaryComponentResponseOfint64AndDestinyCharacterProgressionComponent</returns>
            public DictionaryComponentResponseOfint64AndDestinyCharacterProgressionComponent Build()
            {
                Validate();
                return new DictionaryComponentResponseOfint64AndDestinyCharacterProgressionComponent(
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