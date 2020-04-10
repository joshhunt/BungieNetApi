using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Sharpility.Extensions;
using NodaTime;

namespace BungieNetApi._Platform.Models
{
    /// <summary>
    /// DictionaryComponentResponseOfint64AndDestinyItemTalentGridComponent
    /// </summary>
    public sealed class DictionaryComponentResponseOfint64AndDestinyItemTalentGridComponent:  IEquatable<DictionaryComponentResponseOfint64AndDestinyItemTalentGridComponent>
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
        /// Use DictionaryComponentResponseOfint64AndDestinyItemTalentGridComponent.Builder() for instance creation instead.
        /// </summary>
        [Obsolete]
        public DictionaryComponentResponseOfint64AndDestinyItemTalentGridComponent()
        {
        }

        private DictionaryComponentResponseOfint64AndDestinyItemTalentGridComponent(Dictionary<string, DestinyEntitiesItemsDestinyItemTalentGridComponent> Data, int? Privacy, bool? Disabled)
        {
            
            this.Data = Data;
            
            this.Privacy = Privacy;
            
            this.Disabled = Disabled;
            
        }

        /// <summary>
        /// Returns builder of DictionaryComponentResponseOfint64AndDestinyItemTalentGridComponent.
        /// </summary>
        /// <returns>DictionaryComponentResponseOfint64AndDestinyItemTalentGridComponentBuilder</returns>
        public static DictionaryComponentResponseOfint64AndDestinyItemTalentGridComponentBuilder Builder()
        {
            return new DictionaryComponentResponseOfint64AndDestinyItemTalentGridComponentBuilder();
        }

        /// <summary>
        /// Returns DictionaryComponentResponseOfint64AndDestinyItemTalentGridComponentBuilder with properties set.
        /// Use it to change properties.
        /// </summary>
        /// <returns>DictionaryComponentResponseOfint64AndDestinyItemTalentGridComponentBuilder</returns>
        public DictionaryComponentResponseOfint64AndDestinyItemTalentGridComponentBuilder With()
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

        public bool Equals(DictionaryComponentResponseOfint64AndDestinyItemTalentGridComponent other)
        {
            return Equals((object) other);
        }

        public override int GetHashCode()
        {
            return this.PropertiesHash();
        }

        /// <summary>
        /// Implementation of == operator for (DictionaryComponentResponseOfint64AndDestinyItemTalentGridComponent.
        /// </summary>
        /// <param name="left">Compared (DictionaryComponentResponseOfint64AndDestinyItemTalentGridComponent</param>
        /// <param name="right">Compared (DictionaryComponentResponseOfint64AndDestinyItemTalentGridComponent</param>
        /// <returns>true if compared items are equals, false otherwise</returns>
        public static bool operator == (DictionaryComponentResponseOfint64AndDestinyItemTalentGridComponent left, DictionaryComponentResponseOfint64AndDestinyItemTalentGridComponent right)
        {
            return Equals(left, right);
        }

        /// <summary>
        /// Implementation of != operator for (DictionaryComponentResponseOfint64AndDestinyItemTalentGridComponent.
        /// </summary>
        /// <param name="left">Compared (DictionaryComponentResponseOfint64AndDestinyItemTalentGridComponent</param>
        /// <param name="right">Compared (DictionaryComponentResponseOfint64AndDestinyItemTalentGridComponent</param>
        /// <returns>true if compared items are not equals, false otherwise</returns>
        public static bool operator != (DictionaryComponentResponseOfint64AndDestinyItemTalentGridComponent left, DictionaryComponentResponseOfint64AndDestinyItemTalentGridComponent right)
        {
            return !Equals(left, right);
        }

        /// <summary>
        /// Builder of DictionaryComponentResponseOfint64AndDestinyItemTalentGridComponent.
        /// </summary>
        public sealed class DictionaryComponentResponseOfint64AndDestinyItemTalentGridComponentBuilder
        {
            private Dictionary<string, DestinyEntitiesItemsDestinyItemTalentGridComponent> _Data;
            private int? _Privacy;
            private bool? _Disabled;

            internal DictionaryComponentResponseOfint64AndDestinyItemTalentGridComponentBuilder()
            {
                SetupDefaults();
            }

            private void SetupDefaults()
            {
            }

            /// <summary>
            /// Sets value for DictionaryComponentResponseOfint64AndDestinyItemTalentGridComponent.Data property.
            /// </summary>
            /// <param name="value">Data</param>
            public DictionaryComponentResponseOfint64AndDestinyItemTalentGridComponentBuilder Data(Dictionary<string, DestinyEntitiesItemsDestinyItemTalentGridComponent> value)
            {
                _Data = value;
                return this;
            }

            /// <summary>
            /// Sets value for DictionaryComponentResponseOfint64AndDestinyItemTalentGridComponent.Privacy property.
            /// </summary>
            /// <param name="value">Privacy</param>
            public DictionaryComponentResponseOfint64AndDestinyItemTalentGridComponentBuilder Privacy(int? value)
            {
                _Privacy = value;
                return this;
            }

            /// <summary>
            /// Sets value for DictionaryComponentResponseOfint64AndDestinyItemTalentGridComponent.Disabled property.
            /// </summary>
            /// <param name="value">If true, this component is disabled.</param>
            public DictionaryComponentResponseOfint64AndDestinyItemTalentGridComponentBuilder Disabled(bool? value)
            {
                _Disabled = value;
                return this;
            }


            /// <summary>
            /// Builds instance of DictionaryComponentResponseOfint64AndDestinyItemTalentGridComponent.
            /// </summary>
            /// <returns>DictionaryComponentResponseOfint64AndDestinyItemTalentGridComponent</returns>
            public DictionaryComponentResponseOfint64AndDestinyItemTalentGridComponent Build()
            {
                Validate();
                return new DictionaryComponentResponseOfint64AndDestinyItemTalentGridComponent(
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