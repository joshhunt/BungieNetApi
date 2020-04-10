using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Sharpility.Extensions;
using NodaTime;

namespace BungieNetApi._Platform.Models
{
    /// <summary>
    /// SingleComponentResponseOfDestinyItemInstanceComponent
    /// </summary>
    public sealed class SingleComponentResponseOfDestinyItemInstanceComponent:  IEquatable<SingleComponentResponseOfDestinyItemInstanceComponent>
    { 
        /// <summary>
        /// Data
        /// </summary>
        public DestinyEntitiesItemsDestinyItemInstanceComponent Data { get; private set; }

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
        /// Use SingleComponentResponseOfDestinyItemInstanceComponent.Builder() for instance creation instead.
        /// </summary>
        [Obsolete]
        public SingleComponentResponseOfDestinyItemInstanceComponent()
        {
        }

        private SingleComponentResponseOfDestinyItemInstanceComponent(DestinyEntitiesItemsDestinyItemInstanceComponent Data, int? Privacy, bool? Disabled)
        {
            
            this.Data = Data;
            
            this.Privacy = Privacy;
            
            this.Disabled = Disabled;
            
        }

        /// <summary>
        /// Returns builder of SingleComponentResponseOfDestinyItemInstanceComponent.
        /// </summary>
        /// <returns>SingleComponentResponseOfDestinyItemInstanceComponentBuilder</returns>
        public static SingleComponentResponseOfDestinyItemInstanceComponentBuilder Builder()
        {
            return new SingleComponentResponseOfDestinyItemInstanceComponentBuilder();
        }

        /// <summary>
        /// Returns SingleComponentResponseOfDestinyItemInstanceComponentBuilder with properties set.
        /// Use it to change properties.
        /// </summary>
        /// <returns>SingleComponentResponseOfDestinyItemInstanceComponentBuilder</returns>
        public SingleComponentResponseOfDestinyItemInstanceComponentBuilder With()
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

        public bool Equals(SingleComponentResponseOfDestinyItemInstanceComponent other)
        {
            return Equals((object) other);
        }

        public override int GetHashCode()
        {
            return this.PropertiesHash();
        }

        /// <summary>
        /// Implementation of == operator for (SingleComponentResponseOfDestinyItemInstanceComponent.
        /// </summary>
        /// <param name="left">Compared (SingleComponentResponseOfDestinyItemInstanceComponent</param>
        /// <param name="right">Compared (SingleComponentResponseOfDestinyItemInstanceComponent</param>
        /// <returns>true if compared items are equals, false otherwise</returns>
        public static bool operator == (SingleComponentResponseOfDestinyItemInstanceComponent left, SingleComponentResponseOfDestinyItemInstanceComponent right)
        {
            return Equals(left, right);
        }

        /// <summary>
        /// Implementation of != operator for (SingleComponentResponseOfDestinyItemInstanceComponent.
        /// </summary>
        /// <param name="left">Compared (SingleComponentResponseOfDestinyItemInstanceComponent</param>
        /// <param name="right">Compared (SingleComponentResponseOfDestinyItemInstanceComponent</param>
        /// <returns>true if compared items are not equals, false otherwise</returns>
        public static bool operator != (SingleComponentResponseOfDestinyItemInstanceComponent left, SingleComponentResponseOfDestinyItemInstanceComponent right)
        {
            return !Equals(left, right);
        }

        /// <summary>
        /// Builder of SingleComponentResponseOfDestinyItemInstanceComponent.
        /// </summary>
        public sealed class SingleComponentResponseOfDestinyItemInstanceComponentBuilder
        {
            private DestinyEntitiesItemsDestinyItemInstanceComponent _Data;
            private int? _Privacy;
            private bool? _Disabled;

            internal SingleComponentResponseOfDestinyItemInstanceComponentBuilder()
            {
                SetupDefaults();
            }

            private void SetupDefaults()
            {
            }

            /// <summary>
            /// Sets value for SingleComponentResponseOfDestinyItemInstanceComponent.Data property.
            /// </summary>
            /// <param name="value">Data</param>
            public SingleComponentResponseOfDestinyItemInstanceComponentBuilder Data(DestinyEntitiesItemsDestinyItemInstanceComponent value)
            {
                _Data = value;
                return this;
            }

            /// <summary>
            /// Sets value for SingleComponentResponseOfDestinyItemInstanceComponent.Privacy property.
            /// </summary>
            /// <param name="value">Privacy</param>
            public SingleComponentResponseOfDestinyItemInstanceComponentBuilder Privacy(int? value)
            {
                _Privacy = value;
                return this;
            }

            /// <summary>
            /// Sets value for SingleComponentResponseOfDestinyItemInstanceComponent.Disabled property.
            /// </summary>
            /// <param name="value">If true, this component is disabled.</param>
            public SingleComponentResponseOfDestinyItemInstanceComponentBuilder Disabled(bool? value)
            {
                _Disabled = value;
                return this;
            }


            /// <summary>
            /// Builds instance of SingleComponentResponseOfDestinyItemInstanceComponent.
            /// </summary>
            /// <returns>SingleComponentResponseOfDestinyItemInstanceComponent</returns>
            public SingleComponentResponseOfDestinyItemInstanceComponent Build()
            {
                Validate();
                return new SingleComponentResponseOfDestinyItemInstanceComponent(
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