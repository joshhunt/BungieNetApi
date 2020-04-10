using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Sharpility.Extensions;
using NodaTime;

namespace BungieNetApi._Platform.Models
{
    /// <summary>
    /// DictionaryComponentResponseOfuint32AndDestinyItemPlugComponent
    /// </summary>
    public sealed class DictionaryComponentResponseOfuint32AndDestinyItemPlugComponent:  IEquatable<DictionaryComponentResponseOfuint32AndDestinyItemPlugComponent>
    { 
        /// <summary>
        /// Data
        /// </summary>
        public Dictionary<string, DestinyComponentsItemsDestinyItemPlugComponent> Data { get; private set; }

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
        /// Use DictionaryComponentResponseOfuint32AndDestinyItemPlugComponent.Builder() for instance creation instead.
        /// </summary>
        [Obsolete]
        public DictionaryComponentResponseOfuint32AndDestinyItemPlugComponent()
        {
        }

        private DictionaryComponentResponseOfuint32AndDestinyItemPlugComponent(Dictionary<string, DestinyComponentsItemsDestinyItemPlugComponent> Data, int? Privacy, bool? Disabled)
        {
            
            this.Data = Data;
            
            this.Privacy = Privacy;
            
            this.Disabled = Disabled;
            
        }

        /// <summary>
        /// Returns builder of DictionaryComponentResponseOfuint32AndDestinyItemPlugComponent.
        /// </summary>
        /// <returns>DictionaryComponentResponseOfuint32AndDestinyItemPlugComponentBuilder</returns>
        public static DictionaryComponentResponseOfuint32AndDestinyItemPlugComponentBuilder Builder()
        {
            return new DictionaryComponentResponseOfuint32AndDestinyItemPlugComponentBuilder();
        }

        /// <summary>
        /// Returns DictionaryComponentResponseOfuint32AndDestinyItemPlugComponentBuilder with properties set.
        /// Use it to change properties.
        /// </summary>
        /// <returns>DictionaryComponentResponseOfuint32AndDestinyItemPlugComponentBuilder</returns>
        public DictionaryComponentResponseOfuint32AndDestinyItemPlugComponentBuilder With()
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

        public bool Equals(DictionaryComponentResponseOfuint32AndDestinyItemPlugComponent other)
        {
            return Equals((object) other);
        }

        public override int GetHashCode()
        {
            return this.PropertiesHash();
        }

        /// <summary>
        /// Implementation of == operator for (DictionaryComponentResponseOfuint32AndDestinyItemPlugComponent.
        /// </summary>
        /// <param name="left">Compared (DictionaryComponentResponseOfuint32AndDestinyItemPlugComponent</param>
        /// <param name="right">Compared (DictionaryComponentResponseOfuint32AndDestinyItemPlugComponent</param>
        /// <returns>true if compared items are equals, false otherwise</returns>
        public static bool operator == (DictionaryComponentResponseOfuint32AndDestinyItemPlugComponent left, DictionaryComponentResponseOfuint32AndDestinyItemPlugComponent right)
        {
            return Equals(left, right);
        }

        /// <summary>
        /// Implementation of != operator for (DictionaryComponentResponseOfuint32AndDestinyItemPlugComponent.
        /// </summary>
        /// <param name="left">Compared (DictionaryComponentResponseOfuint32AndDestinyItemPlugComponent</param>
        /// <param name="right">Compared (DictionaryComponentResponseOfuint32AndDestinyItemPlugComponent</param>
        /// <returns>true if compared items are not equals, false otherwise</returns>
        public static bool operator != (DictionaryComponentResponseOfuint32AndDestinyItemPlugComponent left, DictionaryComponentResponseOfuint32AndDestinyItemPlugComponent right)
        {
            return !Equals(left, right);
        }

        /// <summary>
        /// Builder of DictionaryComponentResponseOfuint32AndDestinyItemPlugComponent.
        /// </summary>
        public sealed class DictionaryComponentResponseOfuint32AndDestinyItemPlugComponentBuilder
        {
            private Dictionary<string, DestinyComponentsItemsDestinyItemPlugComponent> _Data;
            private int? _Privacy;
            private bool? _Disabled;

            internal DictionaryComponentResponseOfuint32AndDestinyItemPlugComponentBuilder()
            {
                SetupDefaults();
            }

            private void SetupDefaults()
            {
            }

            /// <summary>
            /// Sets value for DictionaryComponentResponseOfuint32AndDestinyItemPlugComponent.Data property.
            /// </summary>
            /// <param name="value">Data</param>
            public DictionaryComponentResponseOfuint32AndDestinyItemPlugComponentBuilder Data(Dictionary<string, DestinyComponentsItemsDestinyItemPlugComponent> value)
            {
                _Data = value;
                return this;
            }

            /// <summary>
            /// Sets value for DictionaryComponentResponseOfuint32AndDestinyItemPlugComponent.Privacy property.
            /// </summary>
            /// <param name="value">Privacy</param>
            public DictionaryComponentResponseOfuint32AndDestinyItemPlugComponentBuilder Privacy(int? value)
            {
                _Privacy = value;
                return this;
            }

            /// <summary>
            /// Sets value for DictionaryComponentResponseOfuint32AndDestinyItemPlugComponent.Disabled property.
            /// </summary>
            /// <param name="value">If true, this component is disabled.</param>
            public DictionaryComponentResponseOfuint32AndDestinyItemPlugComponentBuilder Disabled(bool? value)
            {
                _Disabled = value;
                return this;
            }


            /// <summary>
            /// Builds instance of DictionaryComponentResponseOfuint32AndDestinyItemPlugComponent.
            /// </summary>
            /// <returns>DictionaryComponentResponseOfuint32AndDestinyItemPlugComponent</returns>
            public DictionaryComponentResponseOfuint32AndDestinyItemPlugComponent Build()
            {
                Validate();
                return new DictionaryComponentResponseOfuint32AndDestinyItemPlugComponent(
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