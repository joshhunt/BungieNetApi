using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Sharpility.Extensions;
using NodaTime;

namespace BungieNetApi._Platform.Models
{
    /// <summary>
    /// DictionaryComponentResponseOfint32AndDestinyItemRenderComponent
    /// </summary>
    public sealed class DictionaryComponentResponseOfint32AndDestinyItemRenderComponent:  IEquatable<DictionaryComponentResponseOfint32AndDestinyItemRenderComponent>
    { 
        /// <summary>
        /// Data
        /// </summary>
        public Dictionary<string, DestinyEntitiesItemsDestinyItemRenderComponent> Data { get; private set; }

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
        /// Use DictionaryComponentResponseOfint32AndDestinyItemRenderComponent.Builder() for instance creation instead.
        /// </summary>
        [Obsolete]
        public DictionaryComponentResponseOfint32AndDestinyItemRenderComponent()
        {
        }

        private DictionaryComponentResponseOfint32AndDestinyItemRenderComponent(Dictionary<string, DestinyEntitiesItemsDestinyItemRenderComponent> Data, int? Privacy, bool? Disabled)
        {
            
            this.Data = Data;
            
            this.Privacy = Privacy;
            
            this.Disabled = Disabled;
            
        }

        /// <summary>
        /// Returns builder of DictionaryComponentResponseOfint32AndDestinyItemRenderComponent.
        /// </summary>
        /// <returns>DictionaryComponentResponseOfint32AndDestinyItemRenderComponentBuilder</returns>
        public static DictionaryComponentResponseOfint32AndDestinyItemRenderComponentBuilder Builder()
        {
            return new DictionaryComponentResponseOfint32AndDestinyItemRenderComponentBuilder();
        }

        /// <summary>
        /// Returns DictionaryComponentResponseOfint32AndDestinyItemRenderComponentBuilder with properties set.
        /// Use it to change properties.
        /// </summary>
        /// <returns>DictionaryComponentResponseOfint32AndDestinyItemRenderComponentBuilder</returns>
        public DictionaryComponentResponseOfint32AndDestinyItemRenderComponentBuilder With()
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

        public bool Equals(DictionaryComponentResponseOfint32AndDestinyItemRenderComponent other)
        {
            return Equals((object) other);
        }

        public override int GetHashCode()
        {
            return this.PropertiesHash();
        }

        /// <summary>
        /// Implementation of == operator for (DictionaryComponentResponseOfint32AndDestinyItemRenderComponent.
        /// </summary>
        /// <param name="left">Compared (DictionaryComponentResponseOfint32AndDestinyItemRenderComponent</param>
        /// <param name="right">Compared (DictionaryComponentResponseOfint32AndDestinyItemRenderComponent</param>
        /// <returns>true if compared items are equals, false otherwise</returns>
        public static bool operator == (DictionaryComponentResponseOfint32AndDestinyItemRenderComponent left, DictionaryComponentResponseOfint32AndDestinyItemRenderComponent right)
        {
            return Equals(left, right);
        }

        /// <summary>
        /// Implementation of != operator for (DictionaryComponentResponseOfint32AndDestinyItemRenderComponent.
        /// </summary>
        /// <param name="left">Compared (DictionaryComponentResponseOfint32AndDestinyItemRenderComponent</param>
        /// <param name="right">Compared (DictionaryComponentResponseOfint32AndDestinyItemRenderComponent</param>
        /// <returns>true if compared items are not equals, false otherwise</returns>
        public static bool operator != (DictionaryComponentResponseOfint32AndDestinyItemRenderComponent left, DictionaryComponentResponseOfint32AndDestinyItemRenderComponent right)
        {
            return !Equals(left, right);
        }

        /// <summary>
        /// Builder of DictionaryComponentResponseOfint32AndDestinyItemRenderComponent.
        /// </summary>
        public sealed class DictionaryComponentResponseOfint32AndDestinyItemRenderComponentBuilder
        {
            private Dictionary<string, DestinyEntitiesItemsDestinyItemRenderComponent> _Data;
            private int? _Privacy;
            private bool? _Disabled;

            internal DictionaryComponentResponseOfint32AndDestinyItemRenderComponentBuilder()
            {
                SetupDefaults();
            }

            private void SetupDefaults()
            {
            }

            /// <summary>
            /// Sets value for DictionaryComponentResponseOfint32AndDestinyItemRenderComponent.Data property.
            /// </summary>
            /// <param name="value">Data</param>
            public DictionaryComponentResponseOfint32AndDestinyItemRenderComponentBuilder Data(Dictionary<string, DestinyEntitiesItemsDestinyItemRenderComponent> value)
            {
                _Data = value;
                return this;
            }

            /// <summary>
            /// Sets value for DictionaryComponentResponseOfint32AndDestinyItemRenderComponent.Privacy property.
            /// </summary>
            /// <param name="value">Privacy</param>
            public DictionaryComponentResponseOfint32AndDestinyItemRenderComponentBuilder Privacy(int? value)
            {
                _Privacy = value;
                return this;
            }

            /// <summary>
            /// Sets value for DictionaryComponentResponseOfint32AndDestinyItemRenderComponent.Disabled property.
            /// </summary>
            /// <param name="value">If true, this component is disabled.</param>
            public DictionaryComponentResponseOfint32AndDestinyItemRenderComponentBuilder Disabled(bool? value)
            {
                _Disabled = value;
                return this;
            }


            /// <summary>
            /// Builds instance of DictionaryComponentResponseOfint32AndDestinyItemRenderComponent.
            /// </summary>
            /// <returns>DictionaryComponentResponseOfint32AndDestinyItemRenderComponent</returns>
            public DictionaryComponentResponseOfint32AndDestinyItemRenderComponent Build()
            {
                Validate();
                return new DictionaryComponentResponseOfint32AndDestinyItemRenderComponent(
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