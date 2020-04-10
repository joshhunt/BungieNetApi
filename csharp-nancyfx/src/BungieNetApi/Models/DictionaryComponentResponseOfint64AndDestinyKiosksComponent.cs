using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Sharpility.Extensions;
using NodaTime;

namespace BungieNetApi._Platform.Models
{
    /// <summary>
    /// DictionaryComponentResponseOfint64AndDestinyKiosksComponent
    /// </summary>
    public sealed class DictionaryComponentResponseOfint64AndDestinyKiosksComponent:  IEquatable<DictionaryComponentResponseOfint64AndDestinyKiosksComponent>
    { 
        /// <summary>
        /// Data
        /// </summary>
        public Dictionary<string, DestinyComponentsKiosksDestinyKiosksComponent> Data { get; private set; }

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
        /// Use DictionaryComponentResponseOfint64AndDestinyKiosksComponent.Builder() for instance creation instead.
        /// </summary>
        [Obsolete]
        public DictionaryComponentResponseOfint64AndDestinyKiosksComponent()
        {
        }

        private DictionaryComponentResponseOfint64AndDestinyKiosksComponent(Dictionary<string, DestinyComponentsKiosksDestinyKiosksComponent> Data, int? Privacy, bool? Disabled)
        {
            
            this.Data = Data;
            
            this.Privacy = Privacy;
            
            this.Disabled = Disabled;
            
        }

        /// <summary>
        /// Returns builder of DictionaryComponentResponseOfint64AndDestinyKiosksComponent.
        /// </summary>
        /// <returns>DictionaryComponentResponseOfint64AndDestinyKiosksComponentBuilder</returns>
        public static DictionaryComponentResponseOfint64AndDestinyKiosksComponentBuilder Builder()
        {
            return new DictionaryComponentResponseOfint64AndDestinyKiosksComponentBuilder();
        }

        /// <summary>
        /// Returns DictionaryComponentResponseOfint64AndDestinyKiosksComponentBuilder with properties set.
        /// Use it to change properties.
        /// </summary>
        /// <returns>DictionaryComponentResponseOfint64AndDestinyKiosksComponentBuilder</returns>
        public DictionaryComponentResponseOfint64AndDestinyKiosksComponentBuilder With()
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

        public bool Equals(DictionaryComponentResponseOfint64AndDestinyKiosksComponent other)
        {
            return Equals((object) other);
        }

        public override int GetHashCode()
        {
            return this.PropertiesHash();
        }

        /// <summary>
        /// Implementation of == operator for (DictionaryComponentResponseOfint64AndDestinyKiosksComponent.
        /// </summary>
        /// <param name="left">Compared (DictionaryComponentResponseOfint64AndDestinyKiosksComponent</param>
        /// <param name="right">Compared (DictionaryComponentResponseOfint64AndDestinyKiosksComponent</param>
        /// <returns>true if compared items are equals, false otherwise</returns>
        public static bool operator == (DictionaryComponentResponseOfint64AndDestinyKiosksComponent left, DictionaryComponentResponseOfint64AndDestinyKiosksComponent right)
        {
            return Equals(left, right);
        }

        /// <summary>
        /// Implementation of != operator for (DictionaryComponentResponseOfint64AndDestinyKiosksComponent.
        /// </summary>
        /// <param name="left">Compared (DictionaryComponentResponseOfint64AndDestinyKiosksComponent</param>
        /// <param name="right">Compared (DictionaryComponentResponseOfint64AndDestinyKiosksComponent</param>
        /// <returns>true if compared items are not equals, false otherwise</returns>
        public static bool operator != (DictionaryComponentResponseOfint64AndDestinyKiosksComponent left, DictionaryComponentResponseOfint64AndDestinyKiosksComponent right)
        {
            return !Equals(left, right);
        }

        /// <summary>
        /// Builder of DictionaryComponentResponseOfint64AndDestinyKiosksComponent.
        /// </summary>
        public sealed class DictionaryComponentResponseOfint64AndDestinyKiosksComponentBuilder
        {
            private Dictionary<string, DestinyComponentsKiosksDestinyKiosksComponent> _Data;
            private int? _Privacy;
            private bool? _Disabled;

            internal DictionaryComponentResponseOfint64AndDestinyKiosksComponentBuilder()
            {
                SetupDefaults();
            }

            private void SetupDefaults()
            {
            }

            /// <summary>
            /// Sets value for DictionaryComponentResponseOfint64AndDestinyKiosksComponent.Data property.
            /// </summary>
            /// <param name="value">Data</param>
            public DictionaryComponentResponseOfint64AndDestinyKiosksComponentBuilder Data(Dictionary<string, DestinyComponentsKiosksDestinyKiosksComponent> value)
            {
                _Data = value;
                return this;
            }

            /// <summary>
            /// Sets value for DictionaryComponentResponseOfint64AndDestinyKiosksComponent.Privacy property.
            /// </summary>
            /// <param name="value">Privacy</param>
            public DictionaryComponentResponseOfint64AndDestinyKiosksComponentBuilder Privacy(int? value)
            {
                _Privacy = value;
                return this;
            }

            /// <summary>
            /// Sets value for DictionaryComponentResponseOfint64AndDestinyKiosksComponent.Disabled property.
            /// </summary>
            /// <param name="value">If true, this component is disabled.</param>
            public DictionaryComponentResponseOfint64AndDestinyKiosksComponentBuilder Disabled(bool? value)
            {
                _Disabled = value;
                return this;
            }


            /// <summary>
            /// Builds instance of DictionaryComponentResponseOfint64AndDestinyKiosksComponent.
            /// </summary>
            /// <returns>DictionaryComponentResponseOfint64AndDestinyKiosksComponent</returns>
            public DictionaryComponentResponseOfint64AndDestinyKiosksComponent Build()
            {
                Validate();
                return new DictionaryComponentResponseOfint64AndDestinyKiosksComponent(
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