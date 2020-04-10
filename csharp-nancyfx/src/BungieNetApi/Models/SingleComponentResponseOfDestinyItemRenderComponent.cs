using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Sharpility.Extensions;
using NodaTime;

namespace BungieNetApi._Platform.Models
{
    /// <summary>
    /// SingleComponentResponseOfDestinyItemRenderComponent
    /// </summary>
    public sealed class SingleComponentResponseOfDestinyItemRenderComponent:  IEquatable<SingleComponentResponseOfDestinyItemRenderComponent>
    { 
        /// <summary>
        /// Data
        /// </summary>
        public DestinyEntitiesItemsDestinyItemRenderComponent Data { get; private set; }

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
        /// Use SingleComponentResponseOfDestinyItemRenderComponent.Builder() for instance creation instead.
        /// </summary>
        [Obsolete]
        public SingleComponentResponseOfDestinyItemRenderComponent()
        {
        }

        private SingleComponentResponseOfDestinyItemRenderComponent(DestinyEntitiesItemsDestinyItemRenderComponent Data, int? Privacy, bool? Disabled)
        {
            
            this.Data = Data;
            
            this.Privacy = Privacy;
            
            this.Disabled = Disabled;
            
        }

        /// <summary>
        /// Returns builder of SingleComponentResponseOfDestinyItemRenderComponent.
        /// </summary>
        /// <returns>SingleComponentResponseOfDestinyItemRenderComponentBuilder</returns>
        public static SingleComponentResponseOfDestinyItemRenderComponentBuilder Builder()
        {
            return new SingleComponentResponseOfDestinyItemRenderComponentBuilder();
        }

        /// <summary>
        /// Returns SingleComponentResponseOfDestinyItemRenderComponentBuilder with properties set.
        /// Use it to change properties.
        /// </summary>
        /// <returns>SingleComponentResponseOfDestinyItemRenderComponentBuilder</returns>
        public SingleComponentResponseOfDestinyItemRenderComponentBuilder With()
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

        public bool Equals(SingleComponentResponseOfDestinyItemRenderComponent other)
        {
            return Equals((object) other);
        }

        public override int GetHashCode()
        {
            return this.PropertiesHash();
        }

        /// <summary>
        /// Implementation of == operator for (SingleComponentResponseOfDestinyItemRenderComponent.
        /// </summary>
        /// <param name="left">Compared (SingleComponentResponseOfDestinyItemRenderComponent</param>
        /// <param name="right">Compared (SingleComponentResponseOfDestinyItemRenderComponent</param>
        /// <returns>true if compared items are equals, false otherwise</returns>
        public static bool operator == (SingleComponentResponseOfDestinyItemRenderComponent left, SingleComponentResponseOfDestinyItemRenderComponent right)
        {
            return Equals(left, right);
        }

        /// <summary>
        /// Implementation of != operator for (SingleComponentResponseOfDestinyItemRenderComponent.
        /// </summary>
        /// <param name="left">Compared (SingleComponentResponseOfDestinyItemRenderComponent</param>
        /// <param name="right">Compared (SingleComponentResponseOfDestinyItemRenderComponent</param>
        /// <returns>true if compared items are not equals, false otherwise</returns>
        public static bool operator != (SingleComponentResponseOfDestinyItemRenderComponent left, SingleComponentResponseOfDestinyItemRenderComponent right)
        {
            return !Equals(left, right);
        }

        /// <summary>
        /// Builder of SingleComponentResponseOfDestinyItemRenderComponent.
        /// </summary>
        public sealed class SingleComponentResponseOfDestinyItemRenderComponentBuilder
        {
            private DestinyEntitiesItemsDestinyItemRenderComponent _Data;
            private int? _Privacy;
            private bool? _Disabled;

            internal SingleComponentResponseOfDestinyItemRenderComponentBuilder()
            {
                SetupDefaults();
            }

            private void SetupDefaults()
            {
            }

            /// <summary>
            /// Sets value for SingleComponentResponseOfDestinyItemRenderComponent.Data property.
            /// </summary>
            /// <param name="value">Data</param>
            public SingleComponentResponseOfDestinyItemRenderComponentBuilder Data(DestinyEntitiesItemsDestinyItemRenderComponent value)
            {
                _Data = value;
                return this;
            }

            /// <summary>
            /// Sets value for SingleComponentResponseOfDestinyItemRenderComponent.Privacy property.
            /// </summary>
            /// <param name="value">Privacy</param>
            public SingleComponentResponseOfDestinyItemRenderComponentBuilder Privacy(int? value)
            {
                _Privacy = value;
                return this;
            }

            /// <summary>
            /// Sets value for SingleComponentResponseOfDestinyItemRenderComponent.Disabled property.
            /// </summary>
            /// <param name="value">If true, this component is disabled.</param>
            public SingleComponentResponseOfDestinyItemRenderComponentBuilder Disabled(bool? value)
            {
                _Disabled = value;
                return this;
            }


            /// <summary>
            /// Builds instance of SingleComponentResponseOfDestinyItemRenderComponent.
            /// </summary>
            /// <returns>SingleComponentResponseOfDestinyItemRenderComponent</returns>
            public SingleComponentResponseOfDestinyItemRenderComponent Build()
            {
                Validate();
                return new SingleComponentResponseOfDestinyItemRenderComponent(
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