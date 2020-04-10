using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Sharpility.Extensions;
using NodaTime;

namespace BungieNetApi._Platform.Models
{
    /// <summary>
    /// DestinyComponentsCollectiblesDestinyCollectibleComponent
    /// </summary>
    public sealed class DestinyComponentsCollectiblesDestinyCollectibleComponent:  IEquatable<DestinyComponentsCollectiblesDestinyCollectibleComponent>
    { 
        /// <summary>
        /// State
        /// </summary>
        public int? State { get; private set; }


        /// <summary>
        /// Empty constructor required by some serializers.
        /// Use DestinyComponentsCollectiblesDestinyCollectibleComponent.Builder() for instance creation instead.
        /// </summary>
        [Obsolete]
        public DestinyComponentsCollectiblesDestinyCollectibleComponent()
        {
        }

        private DestinyComponentsCollectiblesDestinyCollectibleComponent(int? State)
        {
            
            this.State = State;
            
        }

        /// <summary>
        /// Returns builder of DestinyComponentsCollectiblesDestinyCollectibleComponent.
        /// </summary>
        /// <returns>DestinyComponentsCollectiblesDestinyCollectibleComponentBuilder</returns>
        public static DestinyComponentsCollectiblesDestinyCollectibleComponentBuilder Builder()
        {
            return new DestinyComponentsCollectiblesDestinyCollectibleComponentBuilder();
        }

        /// <summary>
        /// Returns DestinyComponentsCollectiblesDestinyCollectibleComponentBuilder with properties set.
        /// Use it to change properties.
        /// </summary>
        /// <returns>DestinyComponentsCollectiblesDestinyCollectibleComponentBuilder</returns>
        public DestinyComponentsCollectiblesDestinyCollectibleComponentBuilder With()
        {
            return Builder()
                .State(State);
        }

        public override string ToString()
        {
            return this.PropertiesToString();
        }

        public override bool Equals(object obj)
        {
            return this.EqualsByProperties(obj);
        }

        public bool Equals(DestinyComponentsCollectiblesDestinyCollectibleComponent other)
        {
            return Equals((object) other);
        }

        public override int GetHashCode()
        {
            return this.PropertiesHash();
        }

        /// <summary>
        /// Implementation of == operator for (DestinyComponentsCollectiblesDestinyCollectibleComponent.
        /// </summary>
        /// <param name="left">Compared (DestinyComponentsCollectiblesDestinyCollectibleComponent</param>
        /// <param name="right">Compared (DestinyComponentsCollectiblesDestinyCollectibleComponent</param>
        /// <returns>true if compared items are equals, false otherwise</returns>
        public static bool operator == (DestinyComponentsCollectiblesDestinyCollectibleComponent left, DestinyComponentsCollectiblesDestinyCollectibleComponent right)
        {
            return Equals(left, right);
        }

        /// <summary>
        /// Implementation of != operator for (DestinyComponentsCollectiblesDestinyCollectibleComponent.
        /// </summary>
        /// <param name="left">Compared (DestinyComponentsCollectiblesDestinyCollectibleComponent</param>
        /// <param name="right">Compared (DestinyComponentsCollectiblesDestinyCollectibleComponent</param>
        /// <returns>true if compared items are not equals, false otherwise</returns>
        public static bool operator != (DestinyComponentsCollectiblesDestinyCollectibleComponent left, DestinyComponentsCollectiblesDestinyCollectibleComponent right)
        {
            return !Equals(left, right);
        }

        /// <summary>
        /// Builder of DestinyComponentsCollectiblesDestinyCollectibleComponent.
        /// </summary>
        public sealed class DestinyComponentsCollectiblesDestinyCollectibleComponentBuilder
        {
            private int? _State;

            internal DestinyComponentsCollectiblesDestinyCollectibleComponentBuilder()
            {
                SetupDefaults();
            }

            private void SetupDefaults()
            {
            }

            /// <summary>
            /// Sets value for DestinyComponentsCollectiblesDestinyCollectibleComponent.State property.
            /// </summary>
            /// <param name="value">State</param>
            public DestinyComponentsCollectiblesDestinyCollectibleComponentBuilder State(int? value)
            {
                _State = value;
                return this;
            }


            /// <summary>
            /// Builds instance of DestinyComponentsCollectiblesDestinyCollectibleComponent.
            /// </summary>
            /// <returns>DestinyComponentsCollectiblesDestinyCollectibleComponent</returns>
            public DestinyComponentsCollectiblesDestinyCollectibleComponent Build()
            {
                Validate();
                return new DestinyComponentsCollectiblesDestinyCollectibleComponent(
                    State: _State
                );
            }

            private void Validate()
            { 
            }
        }

        
    }
}