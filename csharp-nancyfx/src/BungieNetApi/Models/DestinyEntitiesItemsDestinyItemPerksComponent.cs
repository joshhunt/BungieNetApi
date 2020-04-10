using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Sharpility.Extensions;
using NodaTime;

namespace BungieNetApi._Platform.Models
{
    /// <summary>
    /// Instanced items can have perks: benefits that the item bestows.  These are related to DestinySandboxPerkDefinition, and sometimes - but not always - have human readable info. When they do, they are the icons and text that you see in an item&#39;s tooltip.  Talent Grids, Sockets, and the item itself can apply Perks, which are then summarized here for your convenience.
    /// </summary>
    public sealed class DestinyEntitiesItemsDestinyItemPerksComponent:  IEquatable<DestinyEntitiesItemsDestinyItemPerksComponent>
    { 
        /// <summary>
        /// The list of perks to display in an item tooltip - and whether or not they have been activated.
        /// </summary>
        public List<DestinyPerksDestinyPerkReference> Perks { get; private set; }


        /// <summary>
        /// Empty constructor required by some serializers.
        /// Use DestinyEntitiesItemsDestinyItemPerksComponent.Builder() for instance creation instead.
        /// </summary>
        [Obsolete]
        public DestinyEntitiesItemsDestinyItemPerksComponent()
        {
        }

        private DestinyEntitiesItemsDestinyItemPerksComponent(List<DestinyPerksDestinyPerkReference> Perks)
        {
            
            this.Perks = Perks;
            
        }

        /// <summary>
        /// Returns builder of DestinyEntitiesItemsDestinyItemPerksComponent.
        /// </summary>
        /// <returns>DestinyEntitiesItemsDestinyItemPerksComponentBuilder</returns>
        public static DestinyEntitiesItemsDestinyItemPerksComponentBuilder Builder()
        {
            return new DestinyEntitiesItemsDestinyItemPerksComponentBuilder();
        }

        /// <summary>
        /// Returns DestinyEntitiesItemsDestinyItemPerksComponentBuilder with properties set.
        /// Use it to change properties.
        /// </summary>
        /// <returns>DestinyEntitiesItemsDestinyItemPerksComponentBuilder</returns>
        public DestinyEntitiesItemsDestinyItemPerksComponentBuilder With()
        {
            return Builder()
                .Perks(Perks);
        }

        public override string ToString()
        {
            return this.PropertiesToString();
        }

        public override bool Equals(object obj)
        {
            return this.EqualsByProperties(obj);
        }

        public bool Equals(DestinyEntitiesItemsDestinyItemPerksComponent other)
        {
            return Equals((object) other);
        }

        public override int GetHashCode()
        {
            return this.PropertiesHash();
        }

        /// <summary>
        /// Implementation of == operator for (DestinyEntitiesItemsDestinyItemPerksComponent.
        /// </summary>
        /// <param name="left">Compared (DestinyEntitiesItemsDestinyItemPerksComponent</param>
        /// <param name="right">Compared (DestinyEntitiesItemsDestinyItemPerksComponent</param>
        /// <returns>true if compared items are equals, false otherwise</returns>
        public static bool operator == (DestinyEntitiesItemsDestinyItemPerksComponent left, DestinyEntitiesItemsDestinyItemPerksComponent right)
        {
            return Equals(left, right);
        }

        /// <summary>
        /// Implementation of != operator for (DestinyEntitiesItemsDestinyItemPerksComponent.
        /// </summary>
        /// <param name="left">Compared (DestinyEntitiesItemsDestinyItemPerksComponent</param>
        /// <param name="right">Compared (DestinyEntitiesItemsDestinyItemPerksComponent</param>
        /// <returns>true if compared items are not equals, false otherwise</returns>
        public static bool operator != (DestinyEntitiesItemsDestinyItemPerksComponent left, DestinyEntitiesItemsDestinyItemPerksComponent right)
        {
            return !Equals(left, right);
        }

        /// <summary>
        /// Builder of DestinyEntitiesItemsDestinyItemPerksComponent.
        /// </summary>
        public sealed class DestinyEntitiesItemsDestinyItemPerksComponentBuilder
        {
            private List<DestinyPerksDestinyPerkReference> _Perks;

            internal DestinyEntitiesItemsDestinyItemPerksComponentBuilder()
            {
                SetupDefaults();
            }

            private void SetupDefaults()
            {
            }

            /// <summary>
            /// Sets value for DestinyEntitiesItemsDestinyItemPerksComponent.Perks property.
            /// </summary>
            /// <param name="value">The list of perks to display in an item tooltip - and whether or not they have been activated.</param>
            public DestinyEntitiesItemsDestinyItemPerksComponentBuilder Perks(List<DestinyPerksDestinyPerkReference> value)
            {
                _Perks = value;
                return this;
            }


            /// <summary>
            /// Builds instance of DestinyEntitiesItemsDestinyItemPerksComponent.
            /// </summary>
            /// <returns>DestinyEntitiesItemsDestinyItemPerksComponent</returns>
            public DestinyEntitiesItemsDestinyItemPerksComponent Build()
            {
                Validate();
                return new DestinyEntitiesItemsDestinyItemPerksComponent(
                    Perks: _Perks
                );
            }

            private void Validate()
            { 
            }
        }

        
    }
}