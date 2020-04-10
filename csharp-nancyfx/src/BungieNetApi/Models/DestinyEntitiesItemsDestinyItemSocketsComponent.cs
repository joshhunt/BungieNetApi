using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Sharpility.Extensions;
using NodaTime;

namespace BungieNetApi._Platform.Models
{
    /// <summary>
    /// Instanced items can have sockets, which are slots on the item where plugs can be inserted.  Sockets are a bit complex: be sure to examine the documentation on the DestinyInventoryItemDefinition&#39;s \&quot;socket\&quot; block and elsewhere on these objects for more details.
    /// </summary>
    public sealed class DestinyEntitiesItemsDestinyItemSocketsComponent:  IEquatable<DestinyEntitiesItemsDestinyItemSocketsComponent>
    { 
        /// <summary>
        /// The list of all sockets on the item, and their status information.
        /// </summary>
        public List<DestinyEntitiesItemsDestinyItemSocketState> Sockets { get; private set; }


        /// <summary>
        /// Empty constructor required by some serializers.
        /// Use DestinyEntitiesItemsDestinyItemSocketsComponent.Builder() for instance creation instead.
        /// </summary>
        [Obsolete]
        public DestinyEntitiesItemsDestinyItemSocketsComponent()
        {
        }

        private DestinyEntitiesItemsDestinyItemSocketsComponent(List<DestinyEntitiesItemsDestinyItemSocketState> Sockets)
        {
            
            this.Sockets = Sockets;
            
        }

        /// <summary>
        /// Returns builder of DestinyEntitiesItemsDestinyItemSocketsComponent.
        /// </summary>
        /// <returns>DestinyEntitiesItemsDestinyItemSocketsComponentBuilder</returns>
        public static DestinyEntitiesItemsDestinyItemSocketsComponentBuilder Builder()
        {
            return new DestinyEntitiesItemsDestinyItemSocketsComponentBuilder();
        }

        /// <summary>
        /// Returns DestinyEntitiesItemsDestinyItemSocketsComponentBuilder with properties set.
        /// Use it to change properties.
        /// </summary>
        /// <returns>DestinyEntitiesItemsDestinyItemSocketsComponentBuilder</returns>
        public DestinyEntitiesItemsDestinyItemSocketsComponentBuilder With()
        {
            return Builder()
                .Sockets(Sockets);
        }

        public override string ToString()
        {
            return this.PropertiesToString();
        }

        public override bool Equals(object obj)
        {
            return this.EqualsByProperties(obj);
        }

        public bool Equals(DestinyEntitiesItemsDestinyItemSocketsComponent other)
        {
            return Equals((object) other);
        }

        public override int GetHashCode()
        {
            return this.PropertiesHash();
        }

        /// <summary>
        /// Implementation of == operator for (DestinyEntitiesItemsDestinyItemSocketsComponent.
        /// </summary>
        /// <param name="left">Compared (DestinyEntitiesItemsDestinyItemSocketsComponent</param>
        /// <param name="right">Compared (DestinyEntitiesItemsDestinyItemSocketsComponent</param>
        /// <returns>true if compared items are equals, false otherwise</returns>
        public static bool operator == (DestinyEntitiesItemsDestinyItemSocketsComponent left, DestinyEntitiesItemsDestinyItemSocketsComponent right)
        {
            return Equals(left, right);
        }

        /// <summary>
        /// Implementation of != operator for (DestinyEntitiesItemsDestinyItemSocketsComponent.
        /// </summary>
        /// <param name="left">Compared (DestinyEntitiesItemsDestinyItemSocketsComponent</param>
        /// <param name="right">Compared (DestinyEntitiesItemsDestinyItemSocketsComponent</param>
        /// <returns>true if compared items are not equals, false otherwise</returns>
        public static bool operator != (DestinyEntitiesItemsDestinyItemSocketsComponent left, DestinyEntitiesItemsDestinyItemSocketsComponent right)
        {
            return !Equals(left, right);
        }

        /// <summary>
        /// Builder of DestinyEntitiesItemsDestinyItemSocketsComponent.
        /// </summary>
        public sealed class DestinyEntitiesItemsDestinyItemSocketsComponentBuilder
        {
            private List<DestinyEntitiesItemsDestinyItemSocketState> _Sockets;

            internal DestinyEntitiesItemsDestinyItemSocketsComponentBuilder()
            {
                SetupDefaults();
            }

            private void SetupDefaults()
            {
            }

            /// <summary>
            /// Sets value for DestinyEntitiesItemsDestinyItemSocketsComponent.Sockets property.
            /// </summary>
            /// <param name="value">The list of all sockets on the item, and their status information.</param>
            public DestinyEntitiesItemsDestinyItemSocketsComponentBuilder Sockets(List<DestinyEntitiesItemsDestinyItemSocketState> value)
            {
                _Sockets = value;
                return this;
            }


            /// <summary>
            /// Builds instance of DestinyEntitiesItemsDestinyItemSocketsComponent.
            /// </summary>
            /// <returns>DestinyEntitiesItemsDestinyItemSocketsComponent</returns>
            public DestinyEntitiesItemsDestinyItemSocketsComponent Build()
            {
                Validate();
                return new DestinyEntitiesItemsDestinyItemSocketsComponent(
                    Sockets: _Sockets
                );
            }

            private void Validate()
            { 
            }
        }

        
    }
}