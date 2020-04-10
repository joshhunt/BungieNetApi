using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Sharpility.Extensions;
using NodaTime;

namespace BungieNetApi._Platform.Models
{
    /// <summary>
    /// DictionaryComponentResponseOfint64AndDestinyCollectiblesComponent
    /// </summary>
    public sealed class DictionaryComponentResponseOfint64AndDestinyCollectiblesComponent:  IEquatable<DictionaryComponentResponseOfint64AndDestinyCollectiblesComponent>
    { 
        /// <summary>
        /// Data
        /// </summary>
        public Dictionary<string, DestinyComponentsCollectiblesDestinyCollectiblesComponent> Data { get; private set; }

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
        /// Use DictionaryComponentResponseOfint64AndDestinyCollectiblesComponent.Builder() for instance creation instead.
        /// </summary>
        [Obsolete]
        public DictionaryComponentResponseOfint64AndDestinyCollectiblesComponent()
        {
        }

        private DictionaryComponentResponseOfint64AndDestinyCollectiblesComponent(Dictionary<string, DestinyComponentsCollectiblesDestinyCollectiblesComponent> Data, int? Privacy, bool? Disabled)
        {
            
            this.Data = Data;
            
            this.Privacy = Privacy;
            
            this.Disabled = Disabled;
            
        }

        /// <summary>
        /// Returns builder of DictionaryComponentResponseOfint64AndDestinyCollectiblesComponent.
        /// </summary>
        /// <returns>DictionaryComponentResponseOfint64AndDestinyCollectiblesComponentBuilder</returns>
        public static DictionaryComponentResponseOfint64AndDestinyCollectiblesComponentBuilder Builder()
        {
            return new DictionaryComponentResponseOfint64AndDestinyCollectiblesComponentBuilder();
        }

        /// <summary>
        /// Returns DictionaryComponentResponseOfint64AndDestinyCollectiblesComponentBuilder with properties set.
        /// Use it to change properties.
        /// </summary>
        /// <returns>DictionaryComponentResponseOfint64AndDestinyCollectiblesComponentBuilder</returns>
        public DictionaryComponentResponseOfint64AndDestinyCollectiblesComponentBuilder With()
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

        public bool Equals(DictionaryComponentResponseOfint64AndDestinyCollectiblesComponent other)
        {
            return Equals((object) other);
        }

        public override int GetHashCode()
        {
            return this.PropertiesHash();
        }

        /// <summary>
        /// Implementation of == operator for (DictionaryComponentResponseOfint64AndDestinyCollectiblesComponent.
        /// </summary>
        /// <param name="left">Compared (DictionaryComponentResponseOfint64AndDestinyCollectiblesComponent</param>
        /// <param name="right">Compared (DictionaryComponentResponseOfint64AndDestinyCollectiblesComponent</param>
        /// <returns>true if compared items are equals, false otherwise</returns>
        public static bool operator == (DictionaryComponentResponseOfint64AndDestinyCollectiblesComponent left, DictionaryComponentResponseOfint64AndDestinyCollectiblesComponent right)
        {
            return Equals(left, right);
        }

        /// <summary>
        /// Implementation of != operator for (DictionaryComponentResponseOfint64AndDestinyCollectiblesComponent.
        /// </summary>
        /// <param name="left">Compared (DictionaryComponentResponseOfint64AndDestinyCollectiblesComponent</param>
        /// <param name="right">Compared (DictionaryComponentResponseOfint64AndDestinyCollectiblesComponent</param>
        /// <returns>true if compared items are not equals, false otherwise</returns>
        public static bool operator != (DictionaryComponentResponseOfint64AndDestinyCollectiblesComponent left, DictionaryComponentResponseOfint64AndDestinyCollectiblesComponent right)
        {
            return !Equals(left, right);
        }

        /// <summary>
        /// Builder of DictionaryComponentResponseOfint64AndDestinyCollectiblesComponent.
        /// </summary>
        public sealed class DictionaryComponentResponseOfint64AndDestinyCollectiblesComponentBuilder
        {
            private Dictionary<string, DestinyComponentsCollectiblesDestinyCollectiblesComponent> _Data;
            private int? _Privacy;
            private bool? _Disabled;

            internal DictionaryComponentResponseOfint64AndDestinyCollectiblesComponentBuilder()
            {
                SetupDefaults();
            }

            private void SetupDefaults()
            {
            }

            /// <summary>
            /// Sets value for DictionaryComponentResponseOfint64AndDestinyCollectiblesComponent.Data property.
            /// </summary>
            /// <param name="value">Data</param>
            public DictionaryComponentResponseOfint64AndDestinyCollectiblesComponentBuilder Data(Dictionary<string, DestinyComponentsCollectiblesDestinyCollectiblesComponent> value)
            {
                _Data = value;
                return this;
            }

            /// <summary>
            /// Sets value for DictionaryComponentResponseOfint64AndDestinyCollectiblesComponent.Privacy property.
            /// </summary>
            /// <param name="value">Privacy</param>
            public DictionaryComponentResponseOfint64AndDestinyCollectiblesComponentBuilder Privacy(int? value)
            {
                _Privacy = value;
                return this;
            }

            /// <summary>
            /// Sets value for DictionaryComponentResponseOfint64AndDestinyCollectiblesComponent.Disabled property.
            /// </summary>
            /// <param name="value">If true, this component is disabled.</param>
            public DictionaryComponentResponseOfint64AndDestinyCollectiblesComponentBuilder Disabled(bool? value)
            {
                _Disabled = value;
                return this;
            }


            /// <summary>
            /// Builds instance of DictionaryComponentResponseOfint64AndDestinyCollectiblesComponent.
            /// </summary>
            /// <returns>DictionaryComponentResponseOfint64AndDestinyCollectiblesComponent</returns>
            public DictionaryComponentResponseOfint64AndDestinyCollectiblesComponent Build()
            {
                Validate();
                return new DictionaryComponentResponseOfint64AndDestinyCollectiblesComponent(
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