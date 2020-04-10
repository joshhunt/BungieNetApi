using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Sharpility.Extensions;
using NodaTime;

namespace BungieNetApi._Platform.Models
{
    /// <summary>
    /// DictionaryComponentResponseOfint64AndDestinyCharacterRenderComponent
    /// </summary>
    public sealed class DictionaryComponentResponseOfint64AndDestinyCharacterRenderComponent:  IEquatable<DictionaryComponentResponseOfint64AndDestinyCharacterRenderComponent>
    { 
        /// <summary>
        /// Data
        /// </summary>
        public Dictionary<string, DestinyEntitiesCharactersDestinyCharacterRenderComponent> Data { get; private set; }

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
        /// Use DictionaryComponentResponseOfint64AndDestinyCharacterRenderComponent.Builder() for instance creation instead.
        /// </summary>
        [Obsolete]
        public DictionaryComponentResponseOfint64AndDestinyCharacterRenderComponent()
        {
        }

        private DictionaryComponentResponseOfint64AndDestinyCharacterRenderComponent(Dictionary<string, DestinyEntitiesCharactersDestinyCharacterRenderComponent> Data, int? Privacy, bool? Disabled)
        {
            
            this.Data = Data;
            
            this.Privacy = Privacy;
            
            this.Disabled = Disabled;
            
        }

        /// <summary>
        /// Returns builder of DictionaryComponentResponseOfint64AndDestinyCharacterRenderComponent.
        /// </summary>
        /// <returns>DictionaryComponentResponseOfint64AndDestinyCharacterRenderComponentBuilder</returns>
        public static DictionaryComponentResponseOfint64AndDestinyCharacterRenderComponentBuilder Builder()
        {
            return new DictionaryComponentResponseOfint64AndDestinyCharacterRenderComponentBuilder();
        }

        /// <summary>
        /// Returns DictionaryComponentResponseOfint64AndDestinyCharacterRenderComponentBuilder with properties set.
        /// Use it to change properties.
        /// </summary>
        /// <returns>DictionaryComponentResponseOfint64AndDestinyCharacterRenderComponentBuilder</returns>
        public DictionaryComponentResponseOfint64AndDestinyCharacterRenderComponentBuilder With()
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

        public bool Equals(DictionaryComponentResponseOfint64AndDestinyCharacterRenderComponent other)
        {
            return Equals((object) other);
        }

        public override int GetHashCode()
        {
            return this.PropertiesHash();
        }

        /// <summary>
        /// Implementation of == operator for (DictionaryComponentResponseOfint64AndDestinyCharacterRenderComponent.
        /// </summary>
        /// <param name="left">Compared (DictionaryComponentResponseOfint64AndDestinyCharacterRenderComponent</param>
        /// <param name="right">Compared (DictionaryComponentResponseOfint64AndDestinyCharacterRenderComponent</param>
        /// <returns>true if compared items are equals, false otherwise</returns>
        public static bool operator == (DictionaryComponentResponseOfint64AndDestinyCharacterRenderComponent left, DictionaryComponentResponseOfint64AndDestinyCharacterRenderComponent right)
        {
            return Equals(left, right);
        }

        /// <summary>
        /// Implementation of != operator for (DictionaryComponentResponseOfint64AndDestinyCharacterRenderComponent.
        /// </summary>
        /// <param name="left">Compared (DictionaryComponentResponseOfint64AndDestinyCharacterRenderComponent</param>
        /// <param name="right">Compared (DictionaryComponentResponseOfint64AndDestinyCharacterRenderComponent</param>
        /// <returns>true if compared items are not equals, false otherwise</returns>
        public static bool operator != (DictionaryComponentResponseOfint64AndDestinyCharacterRenderComponent left, DictionaryComponentResponseOfint64AndDestinyCharacterRenderComponent right)
        {
            return !Equals(left, right);
        }

        /// <summary>
        /// Builder of DictionaryComponentResponseOfint64AndDestinyCharacterRenderComponent.
        /// </summary>
        public sealed class DictionaryComponentResponseOfint64AndDestinyCharacterRenderComponentBuilder
        {
            private Dictionary<string, DestinyEntitiesCharactersDestinyCharacterRenderComponent> _Data;
            private int? _Privacy;
            private bool? _Disabled;

            internal DictionaryComponentResponseOfint64AndDestinyCharacterRenderComponentBuilder()
            {
                SetupDefaults();
            }

            private void SetupDefaults()
            {
            }

            /// <summary>
            /// Sets value for DictionaryComponentResponseOfint64AndDestinyCharacterRenderComponent.Data property.
            /// </summary>
            /// <param name="value">Data</param>
            public DictionaryComponentResponseOfint64AndDestinyCharacterRenderComponentBuilder Data(Dictionary<string, DestinyEntitiesCharactersDestinyCharacterRenderComponent> value)
            {
                _Data = value;
                return this;
            }

            /// <summary>
            /// Sets value for DictionaryComponentResponseOfint64AndDestinyCharacterRenderComponent.Privacy property.
            /// </summary>
            /// <param name="value">Privacy</param>
            public DictionaryComponentResponseOfint64AndDestinyCharacterRenderComponentBuilder Privacy(int? value)
            {
                _Privacy = value;
                return this;
            }

            /// <summary>
            /// Sets value for DictionaryComponentResponseOfint64AndDestinyCharacterRenderComponent.Disabled property.
            /// </summary>
            /// <param name="value">If true, this component is disabled.</param>
            public DictionaryComponentResponseOfint64AndDestinyCharacterRenderComponentBuilder Disabled(bool? value)
            {
                _Disabled = value;
                return this;
            }


            /// <summary>
            /// Builds instance of DictionaryComponentResponseOfint64AndDestinyCharacterRenderComponent.
            /// </summary>
            /// <returns>DictionaryComponentResponseOfint64AndDestinyCharacterRenderComponent</returns>
            public DictionaryComponentResponseOfint64AndDestinyCharacterRenderComponent Build()
            {
                Validate();
                return new DictionaryComponentResponseOfint64AndDestinyCharacterRenderComponent(
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