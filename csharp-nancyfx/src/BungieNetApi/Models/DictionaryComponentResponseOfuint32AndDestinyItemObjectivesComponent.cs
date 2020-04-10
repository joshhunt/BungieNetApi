using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Sharpility.Extensions;
using NodaTime;

namespace BungieNetApi._Platform.Models
{
    /// <summary>
    /// DictionaryComponentResponseOfuint32AndDestinyItemObjectivesComponent
    /// </summary>
    public sealed class DictionaryComponentResponseOfuint32AndDestinyItemObjectivesComponent:  IEquatable<DictionaryComponentResponseOfuint32AndDestinyItemObjectivesComponent>
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
        /// Use DictionaryComponentResponseOfuint32AndDestinyItemObjectivesComponent.Builder() for instance creation instead.
        /// </summary>
        [Obsolete]
        public DictionaryComponentResponseOfuint32AndDestinyItemObjectivesComponent()
        {
        }

        private DictionaryComponentResponseOfuint32AndDestinyItemObjectivesComponent(Dictionary<string, DestinyEntitiesItemsDestinyItemObjectivesComponent> Data, int? Privacy, bool? Disabled)
        {
            
            this.Data = Data;
            
            this.Privacy = Privacy;
            
            this.Disabled = Disabled;
            
        }

        /// <summary>
        /// Returns builder of DictionaryComponentResponseOfuint32AndDestinyItemObjectivesComponent.
        /// </summary>
        /// <returns>DictionaryComponentResponseOfuint32AndDestinyItemObjectivesComponentBuilder</returns>
        public static DictionaryComponentResponseOfuint32AndDestinyItemObjectivesComponentBuilder Builder()
        {
            return new DictionaryComponentResponseOfuint32AndDestinyItemObjectivesComponentBuilder();
        }

        /// <summary>
        /// Returns DictionaryComponentResponseOfuint32AndDestinyItemObjectivesComponentBuilder with properties set.
        /// Use it to change properties.
        /// </summary>
        /// <returns>DictionaryComponentResponseOfuint32AndDestinyItemObjectivesComponentBuilder</returns>
        public DictionaryComponentResponseOfuint32AndDestinyItemObjectivesComponentBuilder With()
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

        public bool Equals(DictionaryComponentResponseOfuint32AndDestinyItemObjectivesComponent other)
        {
            return Equals((object) other);
        }

        public override int GetHashCode()
        {
            return this.PropertiesHash();
        }

        /// <summary>
        /// Implementation of == operator for (DictionaryComponentResponseOfuint32AndDestinyItemObjectivesComponent.
        /// </summary>
        /// <param name="left">Compared (DictionaryComponentResponseOfuint32AndDestinyItemObjectivesComponent</param>
        /// <param name="right">Compared (DictionaryComponentResponseOfuint32AndDestinyItemObjectivesComponent</param>
        /// <returns>true if compared items are equals, false otherwise</returns>
        public static bool operator == (DictionaryComponentResponseOfuint32AndDestinyItemObjectivesComponent left, DictionaryComponentResponseOfuint32AndDestinyItemObjectivesComponent right)
        {
            return Equals(left, right);
        }

        /// <summary>
        /// Implementation of != operator for (DictionaryComponentResponseOfuint32AndDestinyItemObjectivesComponent.
        /// </summary>
        /// <param name="left">Compared (DictionaryComponentResponseOfuint32AndDestinyItemObjectivesComponent</param>
        /// <param name="right">Compared (DictionaryComponentResponseOfuint32AndDestinyItemObjectivesComponent</param>
        /// <returns>true if compared items are not equals, false otherwise</returns>
        public static bool operator != (DictionaryComponentResponseOfuint32AndDestinyItemObjectivesComponent left, DictionaryComponentResponseOfuint32AndDestinyItemObjectivesComponent right)
        {
            return !Equals(left, right);
        }

        /// <summary>
        /// Builder of DictionaryComponentResponseOfuint32AndDestinyItemObjectivesComponent.
        /// </summary>
        public sealed class DictionaryComponentResponseOfuint32AndDestinyItemObjectivesComponentBuilder
        {
            private Dictionary<string, DestinyEntitiesItemsDestinyItemObjectivesComponent> _Data;
            private int? _Privacy;
            private bool? _Disabled;

            internal DictionaryComponentResponseOfuint32AndDestinyItemObjectivesComponentBuilder()
            {
                SetupDefaults();
            }

            private void SetupDefaults()
            {
            }

            /// <summary>
            /// Sets value for DictionaryComponentResponseOfuint32AndDestinyItemObjectivesComponent.Data property.
            /// </summary>
            /// <param name="value">Data</param>
            public DictionaryComponentResponseOfuint32AndDestinyItemObjectivesComponentBuilder Data(Dictionary<string, DestinyEntitiesItemsDestinyItemObjectivesComponent> value)
            {
                _Data = value;
                return this;
            }

            /// <summary>
            /// Sets value for DictionaryComponentResponseOfuint32AndDestinyItemObjectivesComponent.Privacy property.
            /// </summary>
            /// <param name="value">Privacy</param>
            public DictionaryComponentResponseOfuint32AndDestinyItemObjectivesComponentBuilder Privacy(int? value)
            {
                _Privacy = value;
                return this;
            }

            /// <summary>
            /// Sets value for DictionaryComponentResponseOfuint32AndDestinyItemObjectivesComponent.Disabled property.
            /// </summary>
            /// <param name="value">If true, this component is disabled.</param>
            public DictionaryComponentResponseOfuint32AndDestinyItemObjectivesComponentBuilder Disabled(bool? value)
            {
                _Disabled = value;
                return this;
            }


            /// <summary>
            /// Builds instance of DictionaryComponentResponseOfuint32AndDestinyItemObjectivesComponent.
            /// </summary>
            /// <returns>DictionaryComponentResponseOfuint32AndDestinyItemObjectivesComponent</returns>
            public DictionaryComponentResponseOfuint32AndDestinyItemObjectivesComponent Build()
            {
                Validate();
                return new DictionaryComponentResponseOfuint32AndDestinyItemObjectivesComponent(
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