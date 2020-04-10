using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Sharpility.Extensions;
using NodaTime;

namespace BungieNetApi._Platform.Models
{
    /// <summary>
    /// DictionaryComponentResponseOfint64AndDestinyInventoryComponent
    /// </summary>
    public sealed class DictionaryComponentResponseOfint64AndDestinyInventoryComponent:  IEquatable<DictionaryComponentResponseOfint64AndDestinyInventoryComponent>
    { 
        /// <summary>
        /// Data
        /// </summary>
        public Dictionary<string, DestinyEntitiesInventoryDestinyInventoryComponent> Data { get; private set; }

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
        /// Use DictionaryComponentResponseOfint64AndDestinyInventoryComponent.Builder() for instance creation instead.
        /// </summary>
        [Obsolete]
        public DictionaryComponentResponseOfint64AndDestinyInventoryComponent()
        {
        }

        private DictionaryComponentResponseOfint64AndDestinyInventoryComponent(Dictionary<string, DestinyEntitiesInventoryDestinyInventoryComponent> Data, int? Privacy, bool? Disabled)
        {
            
            this.Data = Data;
            
            this.Privacy = Privacy;
            
            this.Disabled = Disabled;
            
        }

        /// <summary>
        /// Returns builder of DictionaryComponentResponseOfint64AndDestinyInventoryComponent.
        /// </summary>
        /// <returns>DictionaryComponentResponseOfint64AndDestinyInventoryComponentBuilder</returns>
        public static DictionaryComponentResponseOfint64AndDestinyInventoryComponentBuilder Builder()
        {
            return new DictionaryComponentResponseOfint64AndDestinyInventoryComponentBuilder();
        }

        /// <summary>
        /// Returns DictionaryComponentResponseOfint64AndDestinyInventoryComponentBuilder with properties set.
        /// Use it to change properties.
        /// </summary>
        /// <returns>DictionaryComponentResponseOfint64AndDestinyInventoryComponentBuilder</returns>
        public DictionaryComponentResponseOfint64AndDestinyInventoryComponentBuilder With()
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

        public bool Equals(DictionaryComponentResponseOfint64AndDestinyInventoryComponent other)
        {
            return Equals((object) other);
        }

        public override int GetHashCode()
        {
            return this.PropertiesHash();
        }

        /// <summary>
        /// Implementation of == operator for (DictionaryComponentResponseOfint64AndDestinyInventoryComponent.
        /// </summary>
        /// <param name="left">Compared (DictionaryComponentResponseOfint64AndDestinyInventoryComponent</param>
        /// <param name="right">Compared (DictionaryComponentResponseOfint64AndDestinyInventoryComponent</param>
        /// <returns>true if compared items are equals, false otherwise</returns>
        public static bool operator == (DictionaryComponentResponseOfint64AndDestinyInventoryComponent left, DictionaryComponentResponseOfint64AndDestinyInventoryComponent right)
        {
            return Equals(left, right);
        }

        /// <summary>
        /// Implementation of != operator for (DictionaryComponentResponseOfint64AndDestinyInventoryComponent.
        /// </summary>
        /// <param name="left">Compared (DictionaryComponentResponseOfint64AndDestinyInventoryComponent</param>
        /// <param name="right">Compared (DictionaryComponentResponseOfint64AndDestinyInventoryComponent</param>
        /// <returns>true if compared items are not equals, false otherwise</returns>
        public static bool operator != (DictionaryComponentResponseOfint64AndDestinyInventoryComponent left, DictionaryComponentResponseOfint64AndDestinyInventoryComponent right)
        {
            return !Equals(left, right);
        }

        /// <summary>
        /// Builder of DictionaryComponentResponseOfint64AndDestinyInventoryComponent.
        /// </summary>
        public sealed class DictionaryComponentResponseOfint64AndDestinyInventoryComponentBuilder
        {
            private Dictionary<string, DestinyEntitiesInventoryDestinyInventoryComponent> _Data;
            private int? _Privacy;
            private bool? _Disabled;

            internal DictionaryComponentResponseOfint64AndDestinyInventoryComponentBuilder()
            {
                SetupDefaults();
            }

            private void SetupDefaults()
            {
            }

            /// <summary>
            /// Sets value for DictionaryComponentResponseOfint64AndDestinyInventoryComponent.Data property.
            /// </summary>
            /// <param name="value">Data</param>
            public DictionaryComponentResponseOfint64AndDestinyInventoryComponentBuilder Data(Dictionary<string, DestinyEntitiesInventoryDestinyInventoryComponent> value)
            {
                _Data = value;
                return this;
            }

            /// <summary>
            /// Sets value for DictionaryComponentResponseOfint64AndDestinyInventoryComponent.Privacy property.
            /// </summary>
            /// <param name="value">Privacy</param>
            public DictionaryComponentResponseOfint64AndDestinyInventoryComponentBuilder Privacy(int? value)
            {
                _Privacy = value;
                return this;
            }

            /// <summary>
            /// Sets value for DictionaryComponentResponseOfint64AndDestinyInventoryComponent.Disabled property.
            /// </summary>
            /// <param name="value">If true, this component is disabled.</param>
            public DictionaryComponentResponseOfint64AndDestinyInventoryComponentBuilder Disabled(bool? value)
            {
                _Disabled = value;
                return this;
            }


            /// <summary>
            /// Builds instance of DictionaryComponentResponseOfint64AndDestinyInventoryComponent.
            /// </summary>
            /// <returns>DictionaryComponentResponseOfint64AndDestinyInventoryComponent</returns>
            public DictionaryComponentResponseOfint64AndDestinyInventoryComponent Build()
            {
                Validate();
                return new DictionaryComponentResponseOfint64AndDestinyInventoryComponent(
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