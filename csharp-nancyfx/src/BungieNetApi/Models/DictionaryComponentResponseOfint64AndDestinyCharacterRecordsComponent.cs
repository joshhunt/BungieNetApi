using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Sharpility.Extensions;
using NodaTime;

namespace BungieNetApi._Platform.Models
{
    /// <summary>
    /// DictionaryComponentResponseOfint64AndDestinyCharacterRecordsComponent
    /// </summary>
    public sealed class DictionaryComponentResponseOfint64AndDestinyCharacterRecordsComponent:  IEquatable<DictionaryComponentResponseOfint64AndDestinyCharacterRecordsComponent>
    { 
        /// <summary>
        /// Data
        /// </summary>
        public Dictionary<string, DestinyComponentsRecordsDestinyCharacterRecordsComponent> Data { get; private set; }

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
        /// Use DictionaryComponentResponseOfint64AndDestinyCharacterRecordsComponent.Builder() for instance creation instead.
        /// </summary>
        [Obsolete]
        public DictionaryComponentResponseOfint64AndDestinyCharacterRecordsComponent()
        {
        }

        private DictionaryComponentResponseOfint64AndDestinyCharacterRecordsComponent(Dictionary<string, DestinyComponentsRecordsDestinyCharacterRecordsComponent> Data, int? Privacy, bool? Disabled)
        {
            
            this.Data = Data;
            
            this.Privacy = Privacy;
            
            this.Disabled = Disabled;
            
        }

        /// <summary>
        /// Returns builder of DictionaryComponentResponseOfint64AndDestinyCharacterRecordsComponent.
        /// </summary>
        /// <returns>DictionaryComponentResponseOfint64AndDestinyCharacterRecordsComponentBuilder</returns>
        public static DictionaryComponentResponseOfint64AndDestinyCharacterRecordsComponentBuilder Builder()
        {
            return new DictionaryComponentResponseOfint64AndDestinyCharacterRecordsComponentBuilder();
        }

        /// <summary>
        /// Returns DictionaryComponentResponseOfint64AndDestinyCharacterRecordsComponentBuilder with properties set.
        /// Use it to change properties.
        /// </summary>
        /// <returns>DictionaryComponentResponseOfint64AndDestinyCharacterRecordsComponentBuilder</returns>
        public DictionaryComponentResponseOfint64AndDestinyCharacterRecordsComponentBuilder With()
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

        public bool Equals(DictionaryComponentResponseOfint64AndDestinyCharacterRecordsComponent other)
        {
            return Equals((object) other);
        }

        public override int GetHashCode()
        {
            return this.PropertiesHash();
        }

        /// <summary>
        /// Implementation of == operator for (DictionaryComponentResponseOfint64AndDestinyCharacterRecordsComponent.
        /// </summary>
        /// <param name="left">Compared (DictionaryComponentResponseOfint64AndDestinyCharacterRecordsComponent</param>
        /// <param name="right">Compared (DictionaryComponentResponseOfint64AndDestinyCharacterRecordsComponent</param>
        /// <returns>true if compared items are equals, false otherwise</returns>
        public static bool operator == (DictionaryComponentResponseOfint64AndDestinyCharacterRecordsComponent left, DictionaryComponentResponseOfint64AndDestinyCharacterRecordsComponent right)
        {
            return Equals(left, right);
        }

        /// <summary>
        /// Implementation of != operator for (DictionaryComponentResponseOfint64AndDestinyCharacterRecordsComponent.
        /// </summary>
        /// <param name="left">Compared (DictionaryComponentResponseOfint64AndDestinyCharacterRecordsComponent</param>
        /// <param name="right">Compared (DictionaryComponentResponseOfint64AndDestinyCharacterRecordsComponent</param>
        /// <returns>true if compared items are not equals, false otherwise</returns>
        public static bool operator != (DictionaryComponentResponseOfint64AndDestinyCharacterRecordsComponent left, DictionaryComponentResponseOfint64AndDestinyCharacterRecordsComponent right)
        {
            return !Equals(left, right);
        }

        /// <summary>
        /// Builder of DictionaryComponentResponseOfint64AndDestinyCharacterRecordsComponent.
        /// </summary>
        public sealed class DictionaryComponentResponseOfint64AndDestinyCharacterRecordsComponentBuilder
        {
            private Dictionary<string, DestinyComponentsRecordsDestinyCharacterRecordsComponent> _Data;
            private int? _Privacy;
            private bool? _Disabled;

            internal DictionaryComponentResponseOfint64AndDestinyCharacterRecordsComponentBuilder()
            {
                SetupDefaults();
            }

            private void SetupDefaults()
            {
            }

            /// <summary>
            /// Sets value for DictionaryComponentResponseOfint64AndDestinyCharacterRecordsComponent.Data property.
            /// </summary>
            /// <param name="value">Data</param>
            public DictionaryComponentResponseOfint64AndDestinyCharacterRecordsComponentBuilder Data(Dictionary<string, DestinyComponentsRecordsDestinyCharacterRecordsComponent> value)
            {
                _Data = value;
                return this;
            }

            /// <summary>
            /// Sets value for DictionaryComponentResponseOfint64AndDestinyCharacterRecordsComponent.Privacy property.
            /// </summary>
            /// <param name="value">Privacy</param>
            public DictionaryComponentResponseOfint64AndDestinyCharacterRecordsComponentBuilder Privacy(int? value)
            {
                _Privacy = value;
                return this;
            }

            /// <summary>
            /// Sets value for DictionaryComponentResponseOfint64AndDestinyCharacterRecordsComponent.Disabled property.
            /// </summary>
            /// <param name="value">If true, this component is disabled.</param>
            public DictionaryComponentResponseOfint64AndDestinyCharacterRecordsComponentBuilder Disabled(bool? value)
            {
                _Disabled = value;
                return this;
            }


            /// <summary>
            /// Builds instance of DictionaryComponentResponseOfint64AndDestinyCharacterRecordsComponent.
            /// </summary>
            /// <returns>DictionaryComponentResponseOfint64AndDestinyCharacterRecordsComponent</returns>
            public DictionaryComponentResponseOfint64AndDestinyCharacterRecordsComponent Build()
            {
                Validate();
                return new DictionaryComponentResponseOfint64AndDestinyCharacterRecordsComponent(
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