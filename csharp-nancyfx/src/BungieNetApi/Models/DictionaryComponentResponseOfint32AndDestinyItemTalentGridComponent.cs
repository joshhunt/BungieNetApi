using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Sharpility.Extensions;
using NodaTime;

namespace BungieNetApi._Platform.Models
{
    /// <summary>
    /// DictionaryComponentResponseOfint32AndDestinyItemTalentGridComponent
    /// </summary>
    public sealed class DictionaryComponentResponseOfint32AndDestinyItemTalentGridComponent:  IEquatable<DictionaryComponentResponseOfint32AndDestinyItemTalentGridComponent>
    { 
        /// <summary>
        /// Data
        /// </summary>
        public Dictionary<string, DestinyEntitiesItemsDestinyItemTalentGridComponent> Data { get; private set; }

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
        /// Use DictionaryComponentResponseOfint32AndDestinyItemTalentGridComponent.Builder() for instance creation instead.
        /// </summary>
        [Obsolete]
        public DictionaryComponentResponseOfint32AndDestinyItemTalentGridComponent()
        {
        }

        private DictionaryComponentResponseOfint32AndDestinyItemTalentGridComponent(Dictionary<string, DestinyEntitiesItemsDestinyItemTalentGridComponent> Data, int? Privacy, bool? Disabled)
        {
            
            this.Data = Data;
            
            this.Privacy = Privacy;
            
            this.Disabled = Disabled;
            
        }

        /// <summary>
        /// Returns builder of DictionaryComponentResponseOfint32AndDestinyItemTalentGridComponent.
        /// </summary>
        /// <returns>DictionaryComponentResponseOfint32AndDestinyItemTalentGridComponentBuilder</returns>
        public static DictionaryComponentResponseOfint32AndDestinyItemTalentGridComponentBuilder Builder()
        {
            return new DictionaryComponentResponseOfint32AndDestinyItemTalentGridComponentBuilder();
        }

        /// <summary>
        /// Returns DictionaryComponentResponseOfint32AndDestinyItemTalentGridComponentBuilder with properties set.
        /// Use it to change properties.
        /// </summary>
        /// <returns>DictionaryComponentResponseOfint32AndDestinyItemTalentGridComponentBuilder</returns>
        public DictionaryComponentResponseOfint32AndDestinyItemTalentGridComponentBuilder With()
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

        public bool Equals(DictionaryComponentResponseOfint32AndDestinyItemTalentGridComponent other)
        {
            return Equals((object) other);
        }

        public override int GetHashCode()
        {
            return this.PropertiesHash();
        }

        /// <summary>
        /// Implementation of == operator for (DictionaryComponentResponseOfint32AndDestinyItemTalentGridComponent.
        /// </summary>
        /// <param name="left">Compared (DictionaryComponentResponseOfint32AndDestinyItemTalentGridComponent</param>
        /// <param name="right">Compared (DictionaryComponentResponseOfint32AndDestinyItemTalentGridComponent</param>
        /// <returns>true if compared items are equals, false otherwise</returns>
        public static bool operator == (DictionaryComponentResponseOfint32AndDestinyItemTalentGridComponent left, DictionaryComponentResponseOfint32AndDestinyItemTalentGridComponent right)
        {
            return Equals(left, right);
        }

        /// <summary>
        /// Implementation of != operator for (DictionaryComponentResponseOfint32AndDestinyItemTalentGridComponent.
        /// </summary>
        /// <param name="left">Compared (DictionaryComponentResponseOfint32AndDestinyItemTalentGridComponent</param>
        /// <param name="right">Compared (DictionaryComponentResponseOfint32AndDestinyItemTalentGridComponent</param>
        /// <returns>true if compared items are not equals, false otherwise</returns>
        public static bool operator != (DictionaryComponentResponseOfint32AndDestinyItemTalentGridComponent left, DictionaryComponentResponseOfint32AndDestinyItemTalentGridComponent right)
        {
            return !Equals(left, right);
        }

        /// <summary>
        /// Builder of DictionaryComponentResponseOfint32AndDestinyItemTalentGridComponent.
        /// </summary>
        public sealed class DictionaryComponentResponseOfint32AndDestinyItemTalentGridComponentBuilder
        {
            private Dictionary<string, DestinyEntitiesItemsDestinyItemTalentGridComponent> _Data;
            private int? _Privacy;
            private bool? _Disabled;

            internal DictionaryComponentResponseOfint32AndDestinyItemTalentGridComponentBuilder()
            {
                SetupDefaults();
            }

            private void SetupDefaults()
            {
            }

            /// <summary>
            /// Sets value for DictionaryComponentResponseOfint32AndDestinyItemTalentGridComponent.Data property.
            /// </summary>
            /// <param name="value">Data</param>
            public DictionaryComponentResponseOfint32AndDestinyItemTalentGridComponentBuilder Data(Dictionary<string, DestinyEntitiesItemsDestinyItemTalentGridComponent> value)
            {
                _Data = value;
                return this;
            }

            /// <summary>
            /// Sets value for DictionaryComponentResponseOfint32AndDestinyItemTalentGridComponent.Privacy property.
            /// </summary>
            /// <param name="value">Privacy</param>
            public DictionaryComponentResponseOfint32AndDestinyItemTalentGridComponentBuilder Privacy(int? value)
            {
                _Privacy = value;
                return this;
            }

            /// <summary>
            /// Sets value for DictionaryComponentResponseOfint32AndDestinyItemTalentGridComponent.Disabled property.
            /// </summary>
            /// <param name="value">If true, this component is disabled.</param>
            public DictionaryComponentResponseOfint32AndDestinyItemTalentGridComponentBuilder Disabled(bool? value)
            {
                _Disabled = value;
                return this;
            }


            /// <summary>
            /// Builds instance of DictionaryComponentResponseOfint32AndDestinyItemTalentGridComponent.
            /// </summary>
            /// <returns>DictionaryComponentResponseOfint32AndDestinyItemTalentGridComponent</returns>
            public DictionaryComponentResponseOfint32AndDestinyItemTalentGridComponent Build()
            {
                Validate();
                return new DictionaryComponentResponseOfint32AndDestinyItemTalentGridComponent(
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