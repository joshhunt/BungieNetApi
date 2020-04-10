using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Sharpility.Extensions;
using NodaTime;

namespace BungieNetApi._Platform.Models
{
    /// <summary>
    /// DictionaryComponentResponseOfint32AndDestinyItemObjectivesComponent
    /// </summary>
    public sealed class DictionaryComponentResponseOfint32AndDestinyItemObjectivesComponent:  IEquatable<DictionaryComponentResponseOfint32AndDestinyItemObjectivesComponent>
    { 
        /// <summary>
        /// Data
        /// </summary>
        public Dictionary<string, DestinyEntitiesItemsDestinyItemObjectivesComponent> Data { get; private set; }

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
        /// Use DictionaryComponentResponseOfint32AndDestinyItemObjectivesComponent.Builder() for instance creation instead.
        /// </summary>
        [Obsolete]
        public DictionaryComponentResponseOfint32AndDestinyItemObjectivesComponent()
        {
        }

        private DictionaryComponentResponseOfint32AndDestinyItemObjectivesComponent(Dictionary<string, DestinyEntitiesItemsDestinyItemObjectivesComponent> Data, int? Privacy, bool? Disabled)
        {
            
            this.Data = Data;
            
            this.Privacy = Privacy;
            
            this.Disabled = Disabled;
            
        }

        /// <summary>
        /// Returns builder of DictionaryComponentResponseOfint32AndDestinyItemObjectivesComponent.
        /// </summary>
        /// <returns>DictionaryComponentResponseOfint32AndDestinyItemObjectivesComponentBuilder</returns>
        public static DictionaryComponentResponseOfint32AndDestinyItemObjectivesComponentBuilder Builder()
        {
            return new DictionaryComponentResponseOfint32AndDestinyItemObjectivesComponentBuilder();
        }

        /// <summary>
        /// Returns DictionaryComponentResponseOfint32AndDestinyItemObjectivesComponentBuilder with properties set.
        /// Use it to change properties.
        /// </summary>
        /// <returns>DictionaryComponentResponseOfint32AndDestinyItemObjectivesComponentBuilder</returns>
        public DictionaryComponentResponseOfint32AndDestinyItemObjectivesComponentBuilder With()
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

        public bool Equals(DictionaryComponentResponseOfint32AndDestinyItemObjectivesComponent other)
        {
            return Equals((object) other);
        }

        public override int GetHashCode()
        {
            return this.PropertiesHash();
        }

        /// <summary>
        /// Implementation of == operator for (DictionaryComponentResponseOfint32AndDestinyItemObjectivesComponent.
        /// </summary>
        /// <param name="left">Compared (DictionaryComponentResponseOfint32AndDestinyItemObjectivesComponent</param>
        /// <param name="right">Compared (DictionaryComponentResponseOfint32AndDestinyItemObjectivesComponent</param>
        /// <returns>true if compared items are equals, false otherwise</returns>
        public static bool operator == (DictionaryComponentResponseOfint32AndDestinyItemObjectivesComponent left, DictionaryComponentResponseOfint32AndDestinyItemObjectivesComponent right)
        {
            return Equals(left, right);
        }

        /// <summary>
        /// Implementation of != operator for (DictionaryComponentResponseOfint32AndDestinyItemObjectivesComponent.
        /// </summary>
        /// <param name="left">Compared (DictionaryComponentResponseOfint32AndDestinyItemObjectivesComponent</param>
        /// <param name="right">Compared (DictionaryComponentResponseOfint32AndDestinyItemObjectivesComponent</param>
        /// <returns>true if compared items are not equals, false otherwise</returns>
        public static bool operator != (DictionaryComponentResponseOfint32AndDestinyItemObjectivesComponent left, DictionaryComponentResponseOfint32AndDestinyItemObjectivesComponent right)
        {
            return !Equals(left, right);
        }

        /// <summary>
        /// Builder of DictionaryComponentResponseOfint32AndDestinyItemObjectivesComponent.
        /// </summary>
        public sealed class DictionaryComponentResponseOfint32AndDestinyItemObjectivesComponentBuilder
        {
            private Dictionary<string, DestinyEntitiesItemsDestinyItemObjectivesComponent> _Data;
            private int? _Privacy;
            private bool? _Disabled;

            internal DictionaryComponentResponseOfint32AndDestinyItemObjectivesComponentBuilder()
            {
                SetupDefaults();
            }

            private void SetupDefaults()
            {
            }

            /// <summary>
            /// Sets value for DictionaryComponentResponseOfint32AndDestinyItemObjectivesComponent.Data property.
            /// </summary>
            /// <param name="value">Data</param>
            public DictionaryComponentResponseOfint32AndDestinyItemObjectivesComponentBuilder Data(Dictionary<string, DestinyEntitiesItemsDestinyItemObjectivesComponent> value)
            {
                _Data = value;
                return this;
            }

            /// <summary>
            /// Sets value for DictionaryComponentResponseOfint32AndDestinyItemObjectivesComponent.Privacy property.
            /// </summary>
            /// <param name="value">Privacy</param>
            public DictionaryComponentResponseOfint32AndDestinyItemObjectivesComponentBuilder Privacy(int? value)
            {
                _Privacy = value;
                return this;
            }

            /// <summary>
            /// Sets value for DictionaryComponentResponseOfint32AndDestinyItemObjectivesComponent.Disabled property.
            /// </summary>
            /// <param name="value">If true, this component is disabled.</param>
            public DictionaryComponentResponseOfint32AndDestinyItemObjectivesComponentBuilder Disabled(bool? value)
            {
                _Disabled = value;
                return this;
            }


            /// <summary>
            /// Builds instance of DictionaryComponentResponseOfint32AndDestinyItemObjectivesComponent.
            /// </summary>
            /// <returns>DictionaryComponentResponseOfint32AndDestinyItemObjectivesComponent</returns>
            public DictionaryComponentResponseOfint32AndDestinyItemObjectivesComponent Build()
            {
                Validate();
                return new DictionaryComponentResponseOfint32AndDestinyItemObjectivesComponent(
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