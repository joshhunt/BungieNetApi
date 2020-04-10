using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Sharpility.Extensions;
using NodaTime;

namespace BungieNetApi._Platform.Models
{
    /// <summary>
    /// DictionaryComponentResponseOfint32AndDestinyItemPlugObjectivesComponent
    /// </summary>
    public sealed class DictionaryComponentResponseOfint32AndDestinyItemPlugObjectivesComponent:  IEquatable<DictionaryComponentResponseOfint32AndDestinyItemPlugObjectivesComponent>
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
        /// Use DictionaryComponentResponseOfint32AndDestinyItemPlugObjectivesComponent.Builder() for instance creation instead.
        /// </summary>
        [Obsolete]
        public DictionaryComponentResponseOfint32AndDestinyItemPlugObjectivesComponent()
        {
        }

        private DictionaryComponentResponseOfint32AndDestinyItemPlugObjectivesComponent(Dictionary<string, DestinyComponentsItemsDestinyItemPlugObjectivesComponent> Data, int? Privacy, bool? Disabled)
        {
            
            this.Data = Data;
            
            this.Privacy = Privacy;
            
            this.Disabled = Disabled;
            
        }

        /// <summary>
        /// Returns builder of DictionaryComponentResponseOfint32AndDestinyItemPlugObjectivesComponent.
        /// </summary>
        /// <returns>DictionaryComponentResponseOfint32AndDestinyItemPlugObjectivesComponentBuilder</returns>
        public static DictionaryComponentResponseOfint32AndDestinyItemPlugObjectivesComponentBuilder Builder()
        {
            return new DictionaryComponentResponseOfint32AndDestinyItemPlugObjectivesComponentBuilder();
        }

        /// <summary>
        /// Returns DictionaryComponentResponseOfint32AndDestinyItemPlugObjectivesComponentBuilder with properties set.
        /// Use it to change properties.
        /// </summary>
        /// <returns>DictionaryComponentResponseOfint32AndDestinyItemPlugObjectivesComponentBuilder</returns>
        public DictionaryComponentResponseOfint32AndDestinyItemPlugObjectivesComponentBuilder With()
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

        public bool Equals(DictionaryComponentResponseOfint32AndDestinyItemPlugObjectivesComponent other)
        {
            return Equals((object) other);
        }

        public override int GetHashCode()
        {
            return this.PropertiesHash();
        }

        /// <summary>
        /// Implementation of == operator for (DictionaryComponentResponseOfint32AndDestinyItemPlugObjectivesComponent.
        /// </summary>
        /// <param name="left">Compared (DictionaryComponentResponseOfint32AndDestinyItemPlugObjectivesComponent</param>
        /// <param name="right">Compared (DictionaryComponentResponseOfint32AndDestinyItemPlugObjectivesComponent</param>
        /// <returns>true if compared items are equals, false otherwise</returns>
        public static bool operator == (DictionaryComponentResponseOfint32AndDestinyItemPlugObjectivesComponent left, DictionaryComponentResponseOfint32AndDestinyItemPlugObjectivesComponent right)
        {
            return Equals(left, right);
        }

        /// <summary>
        /// Implementation of != operator for (DictionaryComponentResponseOfint32AndDestinyItemPlugObjectivesComponent.
        /// </summary>
        /// <param name="left">Compared (DictionaryComponentResponseOfint32AndDestinyItemPlugObjectivesComponent</param>
        /// <param name="right">Compared (DictionaryComponentResponseOfint32AndDestinyItemPlugObjectivesComponent</param>
        /// <returns>true if compared items are not equals, false otherwise</returns>
        public static bool operator != (DictionaryComponentResponseOfint32AndDestinyItemPlugObjectivesComponent left, DictionaryComponentResponseOfint32AndDestinyItemPlugObjectivesComponent right)
        {
            return !Equals(left, right);
        }

        /// <summary>
        /// Builder of DictionaryComponentResponseOfint32AndDestinyItemPlugObjectivesComponent.
        /// </summary>
        public sealed class DictionaryComponentResponseOfint32AndDestinyItemPlugObjectivesComponentBuilder
        {
            private Dictionary<string, DestinyComponentsItemsDestinyItemPlugObjectivesComponent> _Data;
            private int? _Privacy;
            private bool? _Disabled;

            internal DictionaryComponentResponseOfint32AndDestinyItemPlugObjectivesComponentBuilder()
            {
                SetupDefaults();
            }

            private void SetupDefaults()
            {
            }

            /// <summary>
            /// Sets value for DictionaryComponentResponseOfint32AndDestinyItemPlugObjectivesComponent.Data property.
            /// </summary>
            /// <param name="value">Data</param>
            public DictionaryComponentResponseOfint32AndDestinyItemPlugObjectivesComponentBuilder Data(Dictionary<string, DestinyComponentsItemsDestinyItemPlugObjectivesComponent> value)
            {
                _Data = value;
                return this;
            }

            /// <summary>
            /// Sets value for DictionaryComponentResponseOfint32AndDestinyItemPlugObjectivesComponent.Privacy property.
            /// </summary>
            /// <param name="value">Privacy</param>
            public DictionaryComponentResponseOfint32AndDestinyItemPlugObjectivesComponentBuilder Privacy(int? value)
            {
                _Privacy = value;
                return this;
            }

            /// <summary>
            /// Sets value for DictionaryComponentResponseOfint32AndDestinyItemPlugObjectivesComponent.Disabled property.
            /// </summary>
            /// <param name="value">If true, this component is disabled.</param>
            public DictionaryComponentResponseOfint32AndDestinyItemPlugObjectivesComponentBuilder Disabled(bool? value)
            {
                _Disabled = value;
                return this;
            }


            /// <summary>
            /// Builds instance of DictionaryComponentResponseOfint32AndDestinyItemPlugObjectivesComponent.
            /// </summary>
            /// <returns>DictionaryComponentResponseOfint32AndDestinyItemPlugObjectivesComponent</returns>
            public DictionaryComponentResponseOfint32AndDestinyItemPlugObjectivesComponent Build()
            {
                Validate();
                return new DictionaryComponentResponseOfint32AndDestinyItemPlugObjectivesComponent(
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