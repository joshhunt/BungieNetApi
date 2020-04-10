using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Sharpility.Extensions;
using NodaTime;

namespace BungieNetApi._Platform.Models
{
    /// <summary>
    /// DictionaryComponentResponseOfint64AndDestinyPlugSetsComponent
    /// </summary>
    public sealed class DictionaryComponentResponseOfint64AndDestinyPlugSetsComponent:  IEquatable<DictionaryComponentResponseOfint64AndDestinyPlugSetsComponent>
    { 
        /// <summary>
        /// Data
        /// </summary>
        public Dictionary<string, DestinyComponentsPlugSetsDestinyPlugSetsComponent> Data { get; private set; }

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
        /// Use DictionaryComponentResponseOfint64AndDestinyPlugSetsComponent.Builder() for instance creation instead.
        /// </summary>
        [Obsolete]
        public DictionaryComponentResponseOfint64AndDestinyPlugSetsComponent()
        {
        }

        private DictionaryComponentResponseOfint64AndDestinyPlugSetsComponent(Dictionary<string, DestinyComponentsPlugSetsDestinyPlugSetsComponent> Data, int? Privacy, bool? Disabled)
        {
            
            this.Data = Data;
            
            this.Privacy = Privacy;
            
            this.Disabled = Disabled;
            
        }

        /// <summary>
        /// Returns builder of DictionaryComponentResponseOfint64AndDestinyPlugSetsComponent.
        /// </summary>
        /// <returns>DictionaryComponentResponseOfint64AndDestinyPlugSetsComponentBuilder</returns>
        public static DictionaryComponentResponseOfint64AndDestinyPlugSetsComponentBuilder Builder()
        {
            return new DictionaryComponentResponseOfint64AndDestinyPlugSetsComponentBuilder();
        }

        /// <summary>
        /// Returns DictionaryComponentResponseOfint64AndDestinyPlugSetsComponentBuilder with properties set.
        /// Use it to change properties.
        /// </summary>
        /// <returns>DictionaryComponentResponseOfint64AndDestinyPlugSetsComponentBuilder</returns>
        public DictionaryComponentResponseOfint64AndDestinyPlugSetsComponentBuilder With()
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

        public bool Equals(DictionaryComponentResponseOfint64AndDestinyPlugSetsComponent other)
        {
            return Equals((object) other);
        }

        public override int GetHashCode()
        {
            return this.PropertiesHash();
        }

        /// <summary>
        /// Implementation of == operator for (DictionaryComponentResponseOfint64AndDestinyPlugSetsComponent.
        /// </summary>
        /// <param name="left">Compared (DictionaryComponentResponseOfint64AndDestinyPlugSetsComponent</param>
        /// <param name="right">Compared (DictionaryComponentResponseOfint64AndDestinyPlugSetsComponent</param>
        /// <returns>true if compared items are equals, false otherwise</returns>
        public static bool operator == (DictionaryComponentResponseOfint64AndDestinyPlugSetsComponent left, DictionaryComponentResponseOfint64AndDestinyPlugSetsComponent right)
        {
            return Equals(left, right);
        }

        /// <summary>
        /// Implementation of != operator for (DictionaryComponentResponseOfint64AndDestinyPlugSetsComponent.
        /// </summary>
        /// <param name="left">Compared (DictionaryComponentResponseOfint64AndDestinyPlugSetsComponent</param>
        /// <param name="right">Compared (DictionaryComponentResponseOfint64AndDestinyPlugSetsComponent</param>
        /// <returns>true if compared items are not equals, false otherwise</returns>
        public static bool operator != (DictionaryComponentResponseOfint64AndDestinyPlugSetsComponent left, DictionaryComponentResponseOfint64AndDestinyPlugSetsComponent right)
        {
            return !Equals(left, right);
        }

        /// <summary>
        /// Builder of DictionaryComponentResponseOfint64AndDestinyPlugSetsComponent.
        /// </summary>
        public sealed class DictionaryComponentResponseOfint64AndDestinyPlugSetsComponentBuilder
        {
            private Dictionary<string, DestinyComponentsPlugSetsDestinyPlugSetsComponent> _Data;
            private int? _Privacy;
            private bool? _Disabled;

            internal DictionaryComponentResponseOfint64AndDestinyPlugSetsComponentBuilder()
            {
                SetupDefaults();
            }

            private void SetupDefaults()
            {
            }

            /// <summary>
            /// Sets value for DictionaryComponentResponseOfint64AndDestinyPlugSetsComponent.Data property.
            /// </summary>
            /// <param name="value">Data</param>
            public DictionaryComponentResponseOfint64AndDestinyPlugSetsComponentBuilder Data(Dictionary<string, DestinyComponentsPlugSetsDestinyPlugSetsComponent> value)
            {
                _Data = value;
                return this;
            }

            /// <summary>
            /// Sets value for DictionaryComponentResponseOfint64AndDestinyPlugSetsComponent.Privacy property.
            /// </summary>
            /// <param name="value">Privacy</param>
            public DictionaryComponentResponseOfint64AndDestinyPlugSetsComponentBuilder Privacy(int? value)
            {
                _Privacy = value;
                return this;
            }

            /// <summary>
            /// Sets value for DictionaryComponentResponseOfint64AndDestinyPlugSetsComponent.Disabled property.
            /// </summary>
            /// <param name="value">If true, this component is disabled.</param>
            public DictionaryComponentResponseOfint64AndDestinyPlugSetsComponentBuilder Disabled(bool? value)
            {
                _Disabled = value;
                return this;
            }


            /// <summary>
            /// Builds instance of DictionaryComponentResponseOfint64AndDestinyPlugSetsComponent.
            /// </summary>
            /// <returns>DictionaryComponentResponseOfint64AndDestinyPlugSetsComponent</returns>
            public DictionaryComponentResponseOfint64AndDestinyPlugSetsComponent Build()
            {
                Validate();
                return new DictionaryComponentResponseOfint64AndDestinyPlugSetsComponent(
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