using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Sharpility.Extensions;
using NodaTime;

namespace BungieNetApi._Platform.Models
{
    /// <summary>
    /// DictionaryComponentResponseOfint64AndDestinyItemSocketsComponent
    /// </summary>
    public sealed class DictionaryComponentResponseOfint64AndDestinyItemSocketsComponent:  IEquatable<DictionaryComponentResponseOfint64AndDestinyItemSocketsComponent>
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
        /// Use DictionaryComponentResponseOfint64AndDestinyItemSocketsComponent.Builder() for instance creation instead.
        /// </summary>
        [Obsolete]
        public DictionaryComponentResponseOfint64AndDestinyItemSocketsComponent()
        {
        }

        private DictionaryComponentResponseOfint64AndDestinyItemSocketsComponent(Dictionary<string, DestinyEntitiesItemsDestinyItemSocketsComponent> Data, int? Privacy, bool? Disabled)
        {
            
            this.Data = Data;
            
            this.Privacy = Privacy;
            
            this.Disabled = Disabled;
            
        }

        /// <summary>
        /// Returns builder of DictionaryComponentResponseOfint64AndDestinyItemSocketsComponent.
        /// </summary>
        /// <returns>DictionaryComponentResponseOfint64AndDestinyItemSocketsComponentBuilder</returns>
        public static DictionaryComponentResponseOfint64AndDestinyItemSocketsComponentBuilder Builder()
        {
            return new DictionaryComponentResponseOfint64AndDestinyItemSocketsComponentBuilder();
        }

        /// <summary>
        /// Returns DictionaryComponentResponseOfint64AndDestinyItemSocketsComponentBuilder with properties set.
        /// Use it to change properties.
        /// </summary>
        /// <returns>DictionaryComponentResponseOfint64AndDestinyItemSocketsComponentBuilder</returns>
        public DictionaryComponentResponseOfint64AndDestinyItemSocketsComponentBuilder With()
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

        public bool Equals(DictionaryComponentResponseOfint64AndDestinyItemSocketsComponent other)
        {
            return Equals((object) other);
        }

        public override int GetHashCode()
        {
            return this.PropertiesHash();
        }

        /// <summary>
        /// Implementation of == operator for (DictionaryComponentResponseOfint64AndDestinyItemSocketsComponent.
        /// </summary>
        /// <param name="left">Compared (DictionaryComponentResponseOfint64AndDestinyItemSocketsComponent</param>
        /// <param name="right">Compared (DictionaryComponentResponseOfint64AndDestinyItemSocketsComponent</param>
        /// <returns>true if compared items are equals, false otherwise</returns>
        public static bool operator == (DictionaryComponentResponseOfint64AndDestinyItemSocketsComponent left, DictionaryComponentResponseOfint64AndDestinyItemSocketsComponent right)
        {
            return Equals(left, right);
        }

        /// <summary>
        /// Implementation of != operator for (DictionaryComponentResponseOfint64AndDestinyItemSocketsComponent.
        /// </summary>
        /// <param name="left">Compared (DictionaryComponentResponseOfint64AndDestinyItemSocketsComponent</param>
        /// <param name="right">Compared (DictionaryComponentResponseOfint64AndDestinyItemSocketsComponent</param>
        /// <returns>true if compared items are not equals, false otherwise</returns>
        public static bool operator != (DictionaryComponentResponseOfint64AndDestinyItemSocketsComponent left, DictionaryComponentResponseOfint64AndDestinyItemSocketsComponent right)
        {
            return !Equals(left, right);
        }

        /// <summary>
        /// Builder of DictionaryComponentResponseOfint64AndDestinyItemSocketsComponent.
        /// </summary>
        public sealed class DictionaryComponentResponseOfint64AndDestinyItemSocketsComponentBuilder
        {
            private Dictionary<string, DestinyEntitiesItemsDestinyItemSocketsComponent> _Data;
            private int? _Privacy;
            private bool? _Disabled;

            internal DictionaryComponentResponseOfint64AndDestinyItemSocketsComponentBuilder()
            {
                SetupDefaults();
            }

            private void SetupDefaults()
            {
            }

            /// <summary>
            /// Sets value for DictionaryComponentResponseOfint64AndDestinyItemSocketsComponent.Data property.
            /// </summary>
            /// <param name="value">Data</param>
            public DictionaryComponentResponseOfint64AndDestinyItemSocketsComponentBuilder Data(Dictionary<string, DestinyEntitiesItemsDestinyItemSocketsComponent> value)
            {
                _Data = value;
                return this;
            }

            /// <summary>
            /// Sets value for DictionaryComponentResponseOfint64AndDestinyItemSocketsComponent.Privacy property.
            /// </summary>
            /// <param name="value">Privacy</param>
            public DictionaryComponentResponseOfint64AndDestinyItemSocketsComponentBuilder Privacy(int? value)
            {
                _Privacy = value;
                return this;
            }

            /// <summary>
            /// Sets value for DictionaryComponentResponseOfint64AndDestinyItemSocketsComponent.Disabled property.
            /// </summary>
            /// <param name="value">If true, this component is disabled.</param>
            public DictionaryComponentResponseOfint64AndDestinyItemSocketsComponentBuilder Disabled(bool? value)
            {
                _Disabled = value;
                return this;
            }


            /// <summary>
            /// Builds instance of DictionaryComponentResponseOfint64AndDestinyItemSocketsComponent.
            /// </summary>
            /// <returns>DictionaryComponentResponseOfint64AndDestinyItemSocketsComponent</returns>
            public DictionaryComponentResponseOfint64AndDestinyItemSocketsComponent Build()
            {
                Validate();
                return new DictionaryComponentResponseOfint64AndDestinyItemSocketsComponent(
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