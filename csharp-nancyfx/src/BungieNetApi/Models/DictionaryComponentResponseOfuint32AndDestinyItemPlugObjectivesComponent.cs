using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Sharpility.Extensions;
using NodaTime;

namespace BungieNetApi._Platform.Models
{
    /// <summary>
    /// DictionaryComponentResponseOfuint32AndDestinyItemPlugObjectivesComponent
    /// </summary>
    public sealed class DictionaryComponentResponseOfuint32AndDestinyItemPlugObjectivesComponent:  IEquatable<DictionaryComponentResponseOfuint32AndDestinyItemPlugObjectivesComponent>
    { 
        /// <summary>
        /// Data
        /// </summary>
        public Dictionary<string, DestinyComponentsItemsDestinyItemPlugObjectivesComponent> Data { get; private set; }

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
        /// Use DictionaryComponentResponseOfuint32AndDestinyItemPlugObjectivesComponent.Builder() for instance creation instead.
        /// </summary>
        [Obsolete]
        public DictionaryComponentResponseOfuint32AndDestinyItemPlugObjectivesComponent()
        {
        }

        private DictionaryComponentResponseOfuint32AndDestinyItemPlugObjectivesComponent(Dictionary<string, DestinyComponentsItemsDestinyItemPlugObjectivesComponent> Data, int? Privacy, bool? Disabled)
        {
            
            this.Data = Data;
            
            this.Privacy = Privacy;
            
            this.Disabled = Disabled;
            
        }

        /// <summary>
        /// Returns builder of DictionaryComponentResponseOfuint32AndDestinyItemPlugObjectivesComponent.
        /// </summary>
        /// <returns>DictionaryComponentResponseOfuint32AndDestinyItemPlugObjectivesComponentBuilder</returns>
        public static DictionaryComponentResponseOfuint32AndDestinyItemPlugObjectivesComponentBuilder Builder()
        {
            return new DictionaryComponentResponseOfuint32AndDestinyItemPlugObjectivesComponentBuilder();
        }

        /// <summary>
        /// Returns DictionaryComponentResponseOfuint32AndDestinyItemPlugObjectivesComponentBuilder with properties set.
        /// Use it to change properties.
        /// </summary>
        /// <returns>DictionaryComponentResponseOfuint32AndDestinyItemPlugObjectivesComponentBuilder</returns>
        public DictionaryComponentResponseOfuint32AndDestinyItemPlugObjectivesComponentBuilder With()
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

        public bool Equals(DictionaryComponentResponseOfuint32AndDestinyItemPlugObjectivesComponent other)
        {
            return Equals((object) other);
        }

        public override int GetHashCode()
        {
            return this.PropertiesHash();
        }

        /// <summary>
        /// Implementation of == operator for (DictionaryComponentResponseOfuint32AndDestinyItemPlugObjectivesComponent.
        /// </summary>
        /// <param name="left">Compared (DictionaryComponentResponseOfuint32AndDestinyItemPlugObjectivesComponent</param>
        /// <param name="right">Compared (DictionaryComponentResponseOfuint32AndDestinyItemPlugObjectivesComponent</param>
        /// <returns>true if compared items are equals, false otherwise</returns>
        public static bool operator == (DictionaryComponentResponseOfuint32AndDestinyItemPlugObjectivesComponent left, DictionaryComponentResponseOfuint32AndDestinyItemPlugObjectivesComponent right)
        {
            return Equals(left, right);
        }

        /// <summary>
        /// Implementation of != operator for (DictionaryComponentResponseOfuint32AndDestinyItemPlugObjectivesComponent.
        /// </summary>
        /// <param name="left">Compared (DictionaryComponentResponseOfuint32AndDestinyItemPlugObjectivesComponent</param>
        /// <param name="right">Compared (DictionaryComponentResponseOfuint32AndDestinyItemPlugObjectivesComponent</param>
        /// <returns>true if compared items are not equals, false otherwise</returns>
        public static bool operator != (DictionaryComponentResponseOfuint32AndDestinyItemPlugObjectivesComponent left, DictionaryComponentResponseOfuint32AndDestinyItemPlugObjectivesComponent right)
        {
            return !Equals(left, right);
        }

        /// <summary>
        /// Builder of DictionaryComponentResponseOfuint32AndDestinyItemPlugObjectivesComponent.
        /// </summary>
        public sealed class DictionaryComponentResponseOfuint32AndDestinyItemPlugObjectivesComponentBuilder
        {
            private Dictionary<string, DestinyComponentsItemsDestinyItemPlugObjectivesComponent> _Data;
            private int? _Privacy;
            private bool? _Disabled;

            internal DictionaryComponentResponseOfuint32AndDestinyItemPlugObjectivesComponentBuilder()
            {
                SetupDefaults();
            }

            private void SetupDefaults()
            {
            }

            /// <summary>
            /// Sets value for DictionaryComponentResponseOfuint32AndDestinyItemPlugObjectivesComponent.Data property.
            /// </summary>
            /// <param name="value">Data</param>
            public DictionaryComponentResponseOfuint32AndDestinyItemPlugObjectivesComponentBuilder Data(Dictionary<string, DestinyComponentsItemsDestinyItemPlugObjectivesComponent> value)
            {
                _Data = value;
                return this;
            }

            /// <summary>
            /// Sets value for DictionaryComponentResponseOfuint32AndDestinyItemPlugObjectivesComponent.Privacy property.
            /// </summary>
            /// <param name="value">Privacy</param>
            public DictionaryComponentResponseOfuint32AndDestinyItemPlugObjectivesComponentBuilder Privacy(int? value)
            {
                _Privacy = value;
                return this;
            }

            /// <summary>
            /// Sets value for DictionaryComponentResponseOfuint32AndDestinyItemPlugObjectivesComponent.Disabled property.
            /// </summary>
            /// <param name="value">If true, this component is disabled.</param>
            public DictionaryComponentResponseOfuint32AndDestinyItemPlugObjectivesComponentBuilder Disabled(bool? value)
            {
                _Disabled = value;
                return this;
            }


            /// <summary>
            /// Builds instance of DictionaryComponentResponseOfuint32AndDestinyItemPlugObjectivesComponent.
            /// </summary>
            /// <returns>DictionaryComponentResponseOfuint32AndDestinyItemPlugObjectivesComponent</returns>
            public DictionaryComponentResponseOfuint32AndDestinyItemPlugObjectivesComponent Build()
            {
                Validate();
                return new DictionaryComponentResponseOfuint32AndDestinyItemPlugObjectivesComponent(
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