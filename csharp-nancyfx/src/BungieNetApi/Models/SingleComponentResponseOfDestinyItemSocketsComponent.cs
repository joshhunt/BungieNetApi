using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Sharpility.Extensions;
using NodaTime;

namespace BungieNetApi._Platform.Models
{
    /// <summary>
    /// SingleComponentResponseOfDestinyItemSocketsComponent
    /// </summary>
    public sealed class SingleComponentResponseOfDestinyItemSocketsComponent:  IEquatable<SingleComponentResponseOfDestinyItemSocketsComponent>
    { 
        /// <summary>
        /// Data
        /// </summary>
        public DestinyEntitiesItemsDestinyItemSocketsComponent Data { get; private set; }

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
        /// Use SingleComponentResponseOfDestinyItemSocketsComponent.Builder() for instance creation instead.
        /// </summary>
        [Obsolete]
        public SingleComponentResponseOfDestinyItemSocketsComponent()
        {
        }

        private SingleComponentResponseOfDestinyItemSocketsComponent(DestinyEntitiesItemsDestinyItemSocketsComponent Data, int? Privacy, bool? Disabled)
        {
            
            this.Data = Data;
            
            this.Privacy = Privacy;
            
            this.Disabled = Disabled;
            
        }

        /// <summary>
        /// Returns builder of SingleComponentResponseOfDestinyItemSocketsComponent.
        /// </summary>
        /// <returns>SingleComponentResponseOfDestinyItemSocketsComponentBuilder</returns>
        public static SingleComponentResponseOfDestinyItemSocketsComponentBuilder Builder()
        {
            return new SingleComponentResponseOfDestinyItemSocketsComponentBuilder();
        }

        /// <summary>
        /// Returns SingleComponentResponseOfDestinyItemSocketsComponentBuilder with properties set.
        /// Use it to change properties.
        /// </summary>
        /// <returns>SingleComponentResponseOfDestinyItemSocketsComponentBuilder</returns>
        public SingleComponentResponseOfDestinyItemSocketsComponentBuilder With()
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

        public bool Equals(SingleComponentResponseOfDestinyItemSocketsComponent other)
        {
            return Equals((object) other);
        }

        public override int GetHashCode()
        {
            return this.PropertiesHash();
        }

        /// <summary>
        /// Implementation of == operator for (SingleComponentResponseOfDestinyItemSocketsComponent.
        /// </summary>
        /// <param name="left">Compared (SingleComponentResponseOfDestinyItemSocketsComponent</param>
        /// <param name="right">Compared (SingleComponentResponseOfDestinyItemSocketsComponent</param>
        /// <returns>true if compared items are equals, false otherwise</returns>
        public static bool operator == (SingleComponentResponseOfDestinyItemSocketsComponent left, SingleComponentResponseOfDestinyItemSocketsComponent right)
        {
            return Equals(left, right);
        }

        /// <summary>
        /// Implementation of != operator for (SingleComponentResponseOfDestinyItemSocketsComponent.
        /// </summary>
        /// <param name="left">Compared (SingleComponentResponseOfDestinyItemSocketsComponent</param>
        /// <param name="right">Compared (SingleComponentResponseOfDestinyItemSocketsComponent</param>
        /// <returns>true if compared items are not equals, false otherwise</returns>
        public static bool operator != (SingleComponentResponseOfDestinyItemSocketsComponent left, SingleComponentResponseOfDestinyItemSocketsComponent right)
        {
            return !Equals(left, right);
        }

        /// <summary>
        /// Builder of SingleComponentResponseOfDestinyItemSocketsComponent.
        /// </summary>
        public sealed class SingleComponentResponseOfDestinyItemSocketsComponentBuilder
        {
            private DestinyEntitiesItemsDestinyItemSocketsComponent _Data;
            private int? _Privacy;
            private bool? _Disabled;

            internal SingleComponentResponseOfDestinyItemSocketsComponentBuilder()
            {
                SetupDefaults();
            }

            private void SetupDefaults()
            {
            }

            /// <summary>
            /// Sets value for SingleComponentResponseOfDestinyItemSocketsComponent.Data property.
            /// </summary>
            /// <param name="value">Data</param>
            public SingleComponentResponseOfDestinyItemSocketsComponentBuilder Data(DestinyEntitiesItemsDestinyItemSocketsComponent value)
            {
                _Data = value;
                return this;
            }

            /// <summary>
            /// Sets value for SingleComponentResponseOfDestinyItemSocketsComponent.Privacy property.
            /// </summary>
            /// <param name="value">Privacy</param>
            public SingleComponentResponseOfDestinyItemSocketsComponentBuilder Privacy(int? value)
            {
                _Privacy = value;
                return this;
            }

            /// <summary>
            /// Sets value for SingleComponentResponseOfDestinyItemSocketsComponent.Disabled property.
            /// </summary>
            /// <param name="value">If true, this component is disabled.</param>
            public SingleComponentResponseOfDestinyItemSocketsComponentBuilder Disabled(bool? value)
            {
                _Disabled = value;
                return this;
            }


            /// <summary>
            /// Builds instance of SingleComponentResponseOfDestinyItemSocketsComponent.
            /// </summary>
            /// <returns>SingleComponentResponseOfDestinyItemSocketsComponent</returns>
            public SingleComponentResponseOfDestinyItemSocketsComponent Build()
            {
                Validate();
                return new SingleComponentResponseOfDestinyItemSocketsComponent(
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