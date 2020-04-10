using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Sharpility.Extensions;
using NodaTime;

namespace BungieNetApi._Platform.Models
{
    /// <summary>
    /// DictionaryComponentResponseOfint64AndDestinyItemPlugObjectivesComponent
    /// </summary>
    public sealed class DictionaryComponentResponseOfint64AndDestinyItemPlugObjectivesComponent:  IEquatable<DictionaryComponentResponseOfint64AndDestinyItemPlugObjectivesComponent>
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
        /// Use DictionaryComponentResponseOfint64AndDestinyItemPlugObjectivesComponent.Builder() for instance creation instead.
        /// </summary>
        [Obsolete]
        public DictionaryComponentResponseOfint64AndDestinyItemPlugObjectivesComponent()
        {
        }

        private DictionaryComponentResponseOfint64AndDestinyItemPlugObjectivesComponent(Dictionary<string, DestinyComponentsItemsDestinyItemPlugObjectivesComponent> Data, int? Privacy, bool? Disabled)
        {
            
            this.Data = Data;
            
            this.Privacy = Privacy;
            
            this.Disabled = Disabled;
            
        }

        /// <summary>
        /// Returns builder of DictionaryComponentResponseOfint64AndDestinyItemPlugObjectivesComponent.
        /// </summary>
        /// <returns>DictionaryComponentResponseOfint64AndDestinyItemPlugObjectivesComponentBuilder</returns>
        public static DictionaryComponentResponseOfint64AndDestinyItemPlugObjectivesComponentBuilder Builder()
        {
            return new DictionaryComponentResponseOfint64AndDestinyItemPlugObjectivesComponentBuilder();
        }

        /// <summary>
        /// Returns DictionaryComponentResponseOfint64AndDestinyItemPlugObjectivesComponentBuilder with properties set.
        /// Use it to change properties.
        /// </summary>
        /// <returns>DictionaryComponentResponseOfint64AndDestinyItemPlugObjectivesComponentBuilder</returns>
        public DictionaryComponentResponseOfint64AndDestinyItemPlugObjectivesComponentBuilder With()
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

        public bool Equals(DictionaryComponentResponseOfint64AndDestinyItemPlugObjectivesComponent other)
        {
            return Equals((object) other);
        }

        public override int GetHashCode()
        {
            return this.PropertiesHash();
        }

        /// <summary>
        /// Implementation of == operator for (DictionaryComponentResponseOfint64AndDestinyItemPlugObjectivesComponent.
        /// </summary>
        /// <param name="left">Compared (DictionaryComponentResponseOfint64AndDestinyItemPlugObjectivesComponent</param>
        /// <param name="right">Compared (DictionaryComponentResponseOfint64AndDestinyItemPlugObjectivesComponent</param>
        /// <returns>true if compared items are equals, false otherwise</returns>
        public static bool operator == (DictionaryComponentResponseOfint64AndDestinyItemPlugObjectivesComponent left, DictionaryComponentResponseOfint64AndDestinyItemPlugObjectivesComponent right)
        {
            return Equals(left, right);
        }

        /// <summary>
        /// Implementation of != operator for (DictionaryComponentResponseOfint64AndDestinyItemPlugObjectivesComponent.
        /// </summary>
        /// <param name="left">Compared (DictionaryComponentResponseOfint64AndDestinyItemPlugObjectivesComponent</param>
        /// <param name="right">Compared (DictionaryComponentResponseOfint64AndDestinyItemPlugObjectivesComponent</param>
        /// <returns>true if compared items are not equals, false otherwise</returns>
        public static bool operator != (DictionaryComponentResponseOfint64AndDestinyItemPlugObjectivesComponent left, DictionaryComponentResponseOfint64AndDestinyItemPlugObjectivesComponent right)
        {
            return !Equals(left, right);
        }

        /// <summary>
        /// Builder of DictionaryComponentResponseOfint64AndDestinyItemPlugObjectivesComponent.
        /// </summary>
        public sealed class DictionaryComponentResponseOfint64AndDestinyItemPlugObjectivesComponentBuilder
        {
            private Dictionary<string, DestinyComponentsItemsDestinyItemPlugObjectivesComponent> _Data;
            private int? _Privacy;
            private bool? _Disabled;

            internal DictionaryComponentResponseOfint64AndDestinyItemPlugObjectivesComponentBuilder()
            {
                SetupDefaults();
            }

            private void SetupDefaults()
            {
            }

            /// <summary>
            /// Sets value for DictionaryComponentResponseOfint64AndDestinyItemPlugObjectivesComponent.Data property.
            /// </summary>
            /// <param name="value">Data</param>
            public DictionaryComponentResponseOfint64AndDestinyItemPlugObjectivesComponentBuilder Data(Dictionary<string, DestinyComponentsItemsDestinyItemPlugObjectivesComponent> value)
            {
                _Data = value;
                return this;
            }

            /// <summary>
            /// Sets value for DictionaryComponentResponseOfint64AndDestinyItemPlugObjectivesComponent.Privacy property.
            /// </summary>
            /// <param name="value">Privacy</param>
            public DictionaryComponentResponseOfint64AndDestinyItemPlugObjectivesComponentBuilder Privacy(int? value)
            {
                _Privacy = value;
                return this;
            }

            /// <summary>
            /// Sets value for DictionaryComponentResponseOfint64AndDestinyItemPlugObjectivesComponent.Disabled property.
            /// </summary>
            /// <param name="value">If true, this component is disabled.</param>
            public DictionaryComponentResponseOfint64AndDestinyItemPlugObjectivesComponentBuilder Disabled(bool? value)
            {
                _Disabled = value;
                return this;
            }


            /// <summary>
            /// Builds instance of DictionaryComponentResponseOfint64AndDestinyItemPlugObjectivesComponent.
            /// </summary>
            /// <returns>DictionaryComponentResponseOfint64AndDestinyItemPlugObjectivesComponent</returns>
            public DictionaryComponentResponseOfint64AndDestinyItemPlugObjectivesComponent Build()
            {
                Validate();
                return new DictionaryComponentResponseOfint64AndDestinyItemPlugObjectivesComponent(
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