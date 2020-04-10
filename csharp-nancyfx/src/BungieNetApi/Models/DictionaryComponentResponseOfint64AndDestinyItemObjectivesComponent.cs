using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Sharpility.Extensions;
using NodaTime;

namespace BungieNetApi._Platform.Models
{
    /// <summary>
    /// DictionaryComponentResponseOfint64AndDestinyItemObjectivesComponent
    /// </summary>
    public sealed class DictionaryComponentResponseOfint64AndDestinyItemObjectivesComponent:  IEquatable<DictionaryComponentResponseOfint64AndDestinyItemObjectivesComponent>
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
        /// Use DictionaryComponentResponseOfint64AndDestinyItemObjectivesComponent.Builder() for instance creation instead.
        /// </summary>
        [Obsolete]
        public DictionaryComponentResponseOfint64AndDestinyItemObjectivesComponent()
        {
        }

        private DictionaryComponentResponseOfint64AndDestinyItemObjectivesComponent(Dictionary<string, DestinyEntitiesItemsDestinyItemObjectivesComponent> Data, int? Privacy, bool? Disabled)
        {
            
            this.Data = Data;
            
            this.Privacy = Privacy;
            
            this.Disabled = Disabled;
            
        }

        /// <summary>
        /// Returns builder of DictionaryComponentResponseOfint64AndDestinyItemObjectivesComponent.
        /// </summary>
        /// <returns>DictionaryComponentResponseOfint64AndDestinyItemObjectivesComponentBuilder</returns>
        public static DictionaryComponentResponseOfint64AndDestinyItemObjectivesComponentBuilder Builder()
        {
            return new DictionaryComponentResponseOfint64AndDestinyItemObjectivesComponentBuilder();
        }

        /// <summary>
        /// Returns DictionaryComponentResponseOfint64AndDestinyItemObjectivesComponentBuilder with properties set.
        /// Use it to change properties.
        /// </summary>
        /// <returns>DictionaryComponentResponseOfint64AndDestinyItemObjectivesComponentBuilder</returns>
        public DictionaryComponentResponseOfint64AndDestinyItemObjectivesComponentBuilder With()
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

        public bool Equals(DictionaryComponentResponseOfint64AndDestinyItemObjectivesComponent other)
        {
            return Equals((object) other);
        }

        public override int GetHashCode()
        {
            return this.PropertiesHash();
        }

        /// <summary>
        /// Implementation of == operator for (DictionaryComponentResponseOfint64AndDestinyItemObjectivesComponent.
        /// </summary>
        /// <param name="left">Compared (DictionaryComponentResponseOfint64AndDestinyItemObjectivesComponent</param>
        /// <param name="right">Compared (DictionaryComponentResponseOfint64AndDestinyItemObjectivesComponent</param>
        /// <returns>true if compared items are equals, false otherwise</returns>
        public static bool operator == (DictionaryComponentResponseOfint64AndDestinyItemObjectivesComponent left, DictionaryComponentResponseOfint64AndDestinyItemObjectivesComponent right)
        {
            return Equals(left, right);
        }

        /// <summary>
        /// Implementation of != operator for (DictionaryComponentResponseOfint64AndDestinyItemObjectivesComponent.
        /// </summary>
        /// <param name="left">Compared (DictionaryComponentResponseOfint64AndDestinyItemObjectivesComponent</param>
        /// <param name="right">Compared (DictionaryComponentResponseOfint64AndDestinyItemObjectivesComponent</param>
        /// <returns>true if compared items are not equals, false otherwise</returns>
        public static bool operator != (DictionaryComponentResponseOfint64AndDestinyItemObjectivesComponent left, DictionaryComponentResponseOfint64AndDestinyItemObjectivesComponent right)
        {
            return !Equals(left, right);
        }

        /// <summary>
        /// Builder of DictionaryComponentResponseOfint64AndDestinyItemObjectivesComponent.
        /// </summary>
        public sealed class DictionaryComponentResponseOfint64AndDestinyItemObjectivesComponentBuilder
        {
            private Dictionary<string, DestinyEntitiesItemsDestinyItemObjectivesComponent> _Data;
            private int? _Privacy;
            private bool? _Disabled;

            internal DictionaryComponentResponseOfint64AndDestinyItemObjectivesComponentBuilder()
            {
                SetupDefaults();
            }

            private void SetupDefaults()
            {
            }

            /// <summary>
            /// Sets value for DictionaryComponentResponseOfint64AndDestinyItemObjectivesComponent.Data property.
            /// </summary>
            /// <param name="value">Data</param>
            public DictionaryComponentResponseOfint64AndDestinyItemObjectivesComponentBuilder Data(Dictionary<string, DestinyEntitiesItemsDestinyItemObjectivesComponent> value)
            {
                _Data = value;
                return this;
            }

            /// <summary>
            /// Sets value for DictionaryComponentResponseOfint64AndDestinyItemObjectivesComponent.Privacy property.
            /// </summary>
            /// <param name="value">Privacy</param>
            public DictionaryComponentResponseOfint64AndDestinyItemObjectivesComponentBuilder Privacy(int? value)
            {
                _Privacy = value;
                return this;
            }

            /// <summary>
            /// Sets value for DictionaryComponentResponseOfint64AndDestinyItemObjectivesComponent.Disabled property.
            /// </summary>
            /// <param name="value">If true, this component is disabled.</param>
            public DictionaryComponentResponseOfint64AndDestinyItemObjectivesComponentBuilder Disabled(bool? value)
            {
                _Disabled = value;
                return this;
            }


            /// <summary>
            /// Builds instance of DictionaryComponentResponseOfint64AndDestinyItemObjectivesComponent.
            /// </summary>
            /// <returns>DictionaryComponentResponseOfint64AndDestinyItemObjectivesComponent</returns>
            public DictionaryComponentResponseOfint64AndDestinyItemObjectivesComponent Build()
            {
                Validate();
                return new DictionaryComponentResponseOfint64AndDestinyItemObjectivesComponent(
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