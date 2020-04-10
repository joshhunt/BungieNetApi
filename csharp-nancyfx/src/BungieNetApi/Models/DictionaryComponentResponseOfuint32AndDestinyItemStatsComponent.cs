using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Sharpility.Extensions;
using NodaTime;

namespace BungieNetApi._Platform.Models
{
    /// <summary>
    /// DictionaryComponentResponseOfuint32AndDestinyItemStatsComponent
    /// </summary>
    public sealed class DictionaryComponentResponseOfuint32AndDestinyItemStatsComponent:  IEquatable<DictionaryComponentResponseOfuint32AndDestinyItemStatsComponent>
    { 
        /// <summary>
        /// Data
        /// </summary>
        public Dictionary<string, DestinyEntitiesItemsDestinyItemStatsComponent> Data { get; private set; }

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
        /// Use DictionaryComponentResponseOfuint32AndDestinyItemStatsComponent.Builder() for instance creation instead.
        /// </summary>
        [Obsolete]
        public DictionaryComponentResponseOfuint32AndDestinyItemStatsComponent()
        {
        }

        private DictionaryComponentResponseOfuint32AndDestinyItemStatsComponent(Dictionary<string, DestinyEntitiesItemsDestinyItemStatsComponent> Data, int? Privacy, bool? Disabled)
        {
            
            this.Data = Data;
            
            this.Privacy = Privacy;
            
            this.Disabled = Disabled;
            
        }

        /// <summary>
        /// Returns builder of DictionaryComponentResponseOfuint32AndDestinyItemStatsComponent.
        /// </summary>
        /// <returns>DictionaryComponentResponseOfuint32AndDestinyItemStatsComponentBuilder</returns>
        public static DictionaryComponentResponseOfuint32AndDestinyItemStatsComponentBuilder Builder()
        {
            return new DictionaryComponentResponseOfuint32AndDestinyItemStatsComponentBuilder();
        }

        /// <summary>
        /// Returns DictionaryComponentResponseOfuint32AndDestinyItemStatsComponentBuilder with properties set.
        /// Use it to change properties.
        /// </summary>
        /// <returns>DictionaryComponentResponseOfuint32AndDestinyItemStatsComponentBuilder</returns>
        public DictionaryComponentResponseOfuint32AndDestinyItemStatsComponentBuilder With()
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

        public bool Equals(DictionaryComponentResponseOfuint32AndDestinyItemStatsComponent other)
        {
            return Equals((object) other);
        }

        public override int GetHashCode()
        {
            return this.PropertiesHash();
        }

        /// <summary>
        /// Implementation of == operator for (DictionaryComponentResponseOfuint32AndDestinyItemStatsComponent.
        /// </summary>
        /// <param name="left">Compared (DictionaryComponentResponseOfuint32AndDestinyItemStatsComponent</param>
        /// <param name="right">Compared (DictionaryComponentResponseOfuint32AndDestinyItemStatsComponent</param>
        /// <returns>true if compared items are equals, false otherwise</returns>
        public static bool operator == (DictionaryComponentResponseOfuint32AndDestinyItemStatsComponent left, DictionaryComponentResponseOfuint32AndDestinyItemStatsComponent right)
        {
            return Equals(left, right);
        }

        /// <summary>
        /// Implementation of != operator for (DictionaryComponentResponseOfuint32AndDestinyItemStatsComponent.
        /// </summary>
        /// <param name="left">Compared (DictionaryComponentResponseOfuint32AndDestinyItemStatsComponent</param>
        /// <param name="right">Compared (DictionaryComponentResponseOfuint32AndDestinyItemStatsComponent</param>
        /// <returns>true if compared items are not equals, false otherwise</returns>
        public static bool operator != (DictionaryComponentResponseOfuint32AndDestinyItemStatsComponent left, DictionaryComponentResponseOfuint32AndDestinyItemStatsComponent right)
        {
            return !Equals(left, right);
        }

        /// <summary>
        /// Builder of DictionaryComponentResponseOfuint32AndDestinyItemStatsComponent.
        /// </summary>
        public sealed class DictionaryComponentResponseOfuint32AndDestinyItemStatsComponentBuilder
        {
            private Dictionary<string, DestinyEntitiesItemsDestinyItemStatsComponent> _Data;
            private int? _Privacy;
            private bool? _Disabled;

            internal DictionaryComponentResponseOfuint32AndDestinyItemStatsComponentBuilder()
            {
                SetupDefaults();
            }

            private void SetupDefaults()
            {
            }

            /// <summary>
            /// Sets value for DictionaryComponentResponseOfuint32AndDestinyItemStatsComponent.Data property.
            /// </summary>
            /// <param name="value">Data</param>
            public DictionaryComponentResponseOfuint32AndDestinyItemStatsComponentBuilder Data(Dictionary<string, DestinyEntitiesItemsDestinyItemStatsComponent> value)
            {
                _Data = value;
                return this;
            }

            /// <summary>
            /// Sets value for DictionaryComponentResponseOfuint32AndDestinyItemStatsComponent.Privacy property.
            /// </summary>
            /// <param name="value">Privacy</param>
            public DictionaryComponentResponseOfuint32AndDestinyItemStatsComponentBuilder Privacy(int? value)
            {
                _Privacy = value;
                return this;
            }

            /// <summary>
            /// Sets value for DictionaryComponentResponseOfuint32AndDestinyItemStatsComponent.Disabled property.
            /// </summary>
            /// <param name="value">If true, this component is disabled.</param>
            public DictionaryComponentResponseOfuint32AndDestinyItemStatsComponentBuilder Disabled(bool? value)
            {
                _Disabled = value;
                return this;
            }


            /// <summary>
            /// Builds instance of DictionaryComponentResponseOfuint32AndDestinyItemStatsComponent.
            /// </summary>
            /// <returns>DictionaryComponentResponseOfuint32AndDestinyItemStatsComponent</returns>
            public DictionaryComponentResponseOfuint32AndDestinyItemStatsComponent Build()
            {
                Validate();
                return new DictionaryComponentResponseOfuint32AndDestinyItemStatsComponent(
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