using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Sharpility.Extensions;
using NodaTime;

namespace BungieNetApi._Platform.Models
{
    /// <summary>
    /// DictionaryComponentResponseOfint64AndDestinyPresentationNodesComponent
    /// </summary>
    public sealed class DictionaryComponentResponseOfint64AndDestinyPresentationNodesComponent:  IEquatable<DictionaryComponentResponseOfint64AndDestinyPresentationNodesComponent>
    { 
        /// <summary>
        /// Data
        /// </summary>
        public Dictionary<string, DestinyComponentsPresentationDestinyPresentationNodesComponent> Data { get; private set; }

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
        /// Use DictionaryComponentResponseOfint64AndDestinyPresentationNodesComponent.Builder() for instance creation instead.
        /// </summary>
        [Obsolete]
        public DictionaryComponentResponseOfint64AndDestinyPresentationNodesComponent()
        {
        }

        private DictionaryComponentResponseOfint64AndDestinyPresentationNodesComponent(Dictionary<string, DestinyComponentsPresentationDestinyPresentationNodesComponent> Data, int? Privacy, bool? Disabled)
        {
            
            this.Data = Data;
            
            this.Privacy = Privacy;
            
            this.Disabled = Disabled;
            
        }

        /// <summary>
        /// Returns builder of DictionaryComponentResponseOfint64AndDestinyPresentationNodesComponent.
        /// </summary>
        /// <returns>DictionaryComponentResponseOfint64AndDestinyPresentationNodesComponentBuilder</returns>
        public static DictionaryComponentResponseOfint64AndDestinyPresentationNodesComponentBuilder Builder()
        {
            return new DictionaryComponentResponseOfint64AndDestinyPresentationNodesComponentBuilder();
        }

        /// <summary>
        /// Returns DictionaryComponentResponseOfint64AndDestinyPresentationNodesComponentBuilder with properties set.
        /// Use it to change properties.
        /// </summary>
        /// <returns>DictionaryComponentResponseOfint64AndDestinyPresentationNodesComponentBuilder</returns>
        public DictionaryComponentResponseOfint64AndDestinyPresentationNodesComponentBuilder With()
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

        public bool Equals(DictionaryComponentResponseOfint64AndDestinyPresentationNodesComponent other)
        {
            return Equals((object) other);
        }

        public override int GetHashCode()
        {
            return this.PropertiesHash();
        }

        /// <summary>
        /// Implementation of == operator for (DictionaryComponentResponseOfint64AndDestinyPresentationNodesComponent.
        /// </summary>
        /// <param name="left">Compared (DictionaryComponentResponseOfint64AndDestinyPresentationNodesComponent</param>
        /// <param name="right">Compared (DictionaryComponentResponseOfint64AndDestinyPresentationNodesComponent</param>
        /// <returns>true if compared items are equals, false otherwise</returns>
        public static bool operator == (DictionaryComponentResponseOfint64AndDestinyPresentationNodesComponent left, DictionaryComponentResponseOfint64AndDestinyPresentationNodesComponent right)
        {
            return Equals(left, right);
        }

        /// <summary>
        /// Implementation of != operator for (DictionaryComponentResponseOfint64AndDestinyPresentationNodesComponent.
        /// </summary>
        /// <param name="left">Compared (DictionaryComponentResponseOfint64AndDestinyPresentationNodesComponent</param>
        /// <param name="right">Compared (DictionaryComponentResponseOfint64AndDestinyPresentationNodesComponent</param>
        /// <returns>true if compared items are not equals, false otherwise</returns>
        public static bool operator != (DictionaryComponentResponseOfint64AndDestinyPresentationNodesComponent left, DictionaryComponentResponseOfint64AndDestinyPresentationNodesComponent right)
        {
            return !Equals(left, right);
        }

        /// <summary>
        /// Builder of DictionaryComponentResponseOfint64AndDestinyPresentationNodesComponent.
        /// </summary>
        public sealed class DictionaryComponentResponseOfint64AndDestinyPresentationNodesComponentBuilder
        {
            private Dictionary<string, DestinyComponentsPresentationDestinyPresentationNodesComponent> _Data;
            private int? _Privacy;
            private bool? _Disabled;

            internal DictionaryComponentResponseOfint64AndDestinyPresentationNodesComponentBuilder()
            {
                SetupDefaults();
            }

            private void SetupDefaults()
            {
            }

            /// <summary>
            /// Sets value for DictionaryComponentResponseOfint64AndDestinyPresentationNodesComponent.Data property.
            /// </summary>
            /// <param name="value">Data</param>
            public DictionaryComponentResponseOfint64AndDestinyPresentationNodesComponentBuilder Data(Dictionary<string, DestinyComponentsPresentationDestinyPresentationNodesComponent> value)
            {
                _Data = value;
                return this;
            }

            /// <summary>
            /// Sets value for DictionaryComponentResponseOfint64AndDestinyPresentationNodesComponent.Privacy property.
            /// </summary>
            /// <param name="value">Privacy</param>
            public DictionaryComponentResponseOfint64AndDestinyPresentationNodesComponentBuilder Privacy(int? value)
            {
                _Privacy = value;
                return this;
            }

            /// <summary>
            /// Sets value for DictionaryComponentResponseOfint64AndDestinyPresentationNodesComponent.Disabled property.
            /// </summary>
            /// <param name="value">If true, this component is disabled.</param>
            public DictionaryComponentResponseOfint64AndDestinyPresentationNodesComponentBuilder Disabled(bool? value)
            {
                _Disabled = value;
                return this;
            }


            /// <summary>
            /// Builds instance of DictionaryComponentResponseOfint64AndDestinyPresentationNodesComponent.
            /// </summary>
            /// <returns>DictionaryComponentResponseOfint64AndDestinyPresentationNodesComponent</returns>
            public DictionaryComponentResponseOfint64AndDestinyPresentationNodesComponent Build()
            {
                Validate();
                return new DictionaryComponentResponseOfint64AndDestinyPresentationNodesComponent(
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