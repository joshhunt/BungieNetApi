using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Sharpility.Extensions;
using NodaTime;

namespace BungieNetApi._Platform.Models
{
    /// <summary>
    /// DictionaryComponentResponseOfint64AndDestinyCharacterActivitiesComponent
    /// </summary>
    public sealed class DictionaryComponentResponseOfint64AndDestinyCharacterActivitiesComponent:  IEquatable<DictionaryComponentResponseOfint64AndDestinyCharacterActivitiesComponent>
    { 
        /// <summary>
        /// Data
        /// </summary>
        public Dictionary<string, DestinyEntitiesCharactersDestinyCharacterActivitiesComponent> Data { get; private set; }

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
        /// Use DictionaryComponentResponseOfint64AndDestinyCharacterActivitiesComponent.Builder() for instance creation instead.
        /// </summary>
        [Obsolete]
        public DictionaryComponentResponseOfint64AndDestinyCharacterActivitiesComponent()
        {
        }

        private DictionaryComponentResponseOfint64AndDestinyCharacterActivitiesComponent(Dictionary<string, DestinyEntitiesCharactersDestinyCharacterActivitiesComponent> Data, int? Privacy, bool? Disabled)
        {
            
            this.Data = Data;
            
            this.Privacy = Privacy;
            
            this.Disabled = Disabled;
            
        }

        /// <summary>
        /// Returns builder of DictionaryComponentResponseOfint64AndDestinyCharacterActivitiesComponent.
        /// </summary>
        /// <returns>DictionaryComponentResponseOfint64AndDestinyCharacterActivitiesComponentBuilder</returns>
        public static DictionaryComponentResponseOfint64AndDestinyCharacterActivitiesComponentBuilder Builder()
        {
            return new DictionaryComponentResponseOfint64AndDestinyCharacterActivitiesComponentBuilder();
        }

        /// <summary>
        /// Returns DictionaryComponentResponseOfint64AndDestinyCharacterActivitiesComponentBuilder with properties set.
        /// Use it to change properties.
        /// </summary>
        /// <returns>DictionaryComponentResponseOfint64AndDestinyCharacterActivitiesComponentBuilder</returns>
        public DictionaryComponentResponseOfint64AndDestinyCharacterActivitiesComponentBuilder With()
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

        public bool Equals(DictionaryComponentResponseOfint64AndDestinyCharacterActivitiesComponent other)
        {
            return Equals((object) other);
        }

        public override int GetHashCode()
        {
            return this.PropertiesHash();
        }

        /// <summary>
        /// Implementation of == operator for (DictionaryComponentResponseOfint64AndDestinyCharacterActivitiesComponent.
        /// </summary>
        /// <param name="left">Compared (DictionaryComponentResponseOfint64AndDestinyCharacterActivitiesComponent</param>
        /// <param name="right">Compared (DictionaryComponentResponseOfint64AndDestinyCharacterActivitiesComponent</param>
        /// <returns>true if compared items are equals, false otherwise</returns>
        public static bool operator == (DictionaryComponentResponseOfint64AndDestinyCharacterActivitiesComponent left, DictionaryComponentResponseOfint64AndDestinyCharacterActivitiesComponent right)
        {
            return Equals(left, right);
        }

        /// <summary>
        /// Implementation of != operator for (DictionaryComponentResponseOfint64AndDestinyCharacterActivitiesComponent.
        /// </summary>
        /// <param name="left">Compared (DictionaryComponentResponseOfint64AndDestinyCharacterActivitiesComponent</param>
        /// <param name="right">Compared (DictionaryComponentResponseOfint64AndDestinyCharacterActivitiesComponent</param>
        /// <returns>true if compared items are not equals, false otherwise</returns>
        public static bool operator != (DictionaryComponentResponseOfint64AndDestinyCharacterActivitiesComponent left, DictionaryComponentResponseOfint64AndDestinyCharacterActivitiesComponent right)
        {
            return !Equals(left, right);
        }

        /// <summary>
        /// Builder of DictionaryComponentResponseOfint64AndDestinyCharacterActivitiesComponent.
        /// </summary>
        public sealed class DictionaryComponentResponseOfint64AndDestinyCharacterActivitiesComponentBuilder
        {
            private Dictionary<string, DestinyEntitiesCharactersDestinyCharacterActivitiesComponent> _Data;
            private int? _Privacy;
            private bool? _Disabled;

            internal DictionaryComponentResponseOfint64AndDestinyCharacterActivitiesComponentBuilder()
            {
                SetupDefaults();
            }

            private void SetupDefaults()
            {
            }

            /// <summary>
            /// Sets value for DictionaryComponentResponseOfint64AndDestinyCharacterActivitiesComponent.Data property.
            /// </summary>
            /// <param name="value">Data</param>
            public DictionaryComponentResponseOfint64AndDestinyCharacterActivitiesComponentBuilder Data(Dictionary<string, DestinyEntitiesCharactersDestinyCharacterActivitiesComponent> value)
            {
                _Data = value;
                return this;
            }

            /// <summary>
            /// Sets value for DictionaryComponentResponseOfint64AndDestinyCharacterActivitiesComponent.Privacy property.
            /// </summary>
            /// <param name="value">Privacy</param>
            public DictionaryComponentResponseOfint64AndDestinyCharacterActivitiesComponentBuilder Privacy(int? value)
            {
                _Privacy = value;
                return this;
            }

            /// <summary>
            /// Sets value for DictionaryComponentResponseOfint64AndDestinyCharacterActivitiesComponent.Disabled property.
            /// </summary>
            /// <param name="value">If true, this component is disabled.</param>
            public DictionaryComponentResponseOfint64AndDestinyCharacterActivitiesComponentBuilder Disabled(bool? value)
            {
                _Disabled = value;
                return this;
            }


            /// <summary>
            /// Builds instance of DictionaryComponentResponseOfint64AndDestinyCharacterActivitiesComponent.
            /// </summary>
            /// <returns>DictionaryComponentResponseOfint64AndDestinyCharacterActivitiesComponent</returns>
            public DictionaryComponentResponseOfint64AndDestinyCharacterActivitiesComponent Build()
            {
                Validate();
                return new DictionaryComponentResponseOfint64AndDestinyCharacterActivitiesComponent(
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