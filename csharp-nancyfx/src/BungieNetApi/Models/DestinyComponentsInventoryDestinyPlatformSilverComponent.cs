using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Sharpility.Extensions;
using NodaTime;

namespace BungieNetApi._Platform.Models
{
    /// <summary>
    /// DestinyComponentsInventoryDestinyPlatformSilverComponent
    /// </summary>
    public sealed class DestinyComponentsInventoryDestinyPlatformSilverComponent:  IEquatable<DestinyComponentsInventoryDestinyPlatformSilverComponent>
    { 
        /// <summary>
        /// If a Profile is played on multiple platforms, this is the silver they have for each platform, keyed by Membership Type.
        /// </summary>
        public Dictionary<string, DestinyEntitiesItemsDestinyItemComponent> PlatformSilver { get; private set; }


        /// <summary>
        /// Empty constructor required by some serializers.
        /// Use DestinyComponentsInventoryDestinyPlatformSilverComponent.Builder() for instance creation instead.
        /// </summary>
        [Obsolete]
        public DestinyComponentsInventoryDestinyPlatformSilverComponent()
        {
        }

        private DestinyComponentsInventoryDestinyPlatformSilverComponent(Dictionary<string, DestinyEntitiesItemsDestinyItemComponent> PlatformSilver)
        {
            
            this.PlatformSilver = PlatformSilver;
            
        }

        /// <summary>
        /// Returns builder of DestinyComponentsInventoryDestinyPlatformSilverComponent.
        /// </summary>
        /// <returns>DestinyComponentsInventoryDestinyPlatformSilverComponentBuilder</returns>
        public static DestinyComponentsInventoryDestinyPlatformSilverComponentBuilder Builder()
        {
            return new DestinyComponentsInventoryDestinyPlatformSilverComponentBuilder();
        }

        /// <summary>
        /// Returns DestinyComponentsInventoryDestinyPlatformSilverComponentBuilder with properties set.
        /// Use it to change properties.
        /// </summary>
        /// <returns>DestinyComponentsInventoryDestinyPlatformSilverComponentBuilder</returns>
        public DestinyComponentsInventoryDestinyPlatformSilverComponentBuilder With()
        {
            return Builder()
                .PlatformSilver(PlatformSilver);
        }

        public override string ToString()
        {
            return this.PropertiesToString();
        }

        public override bool Equals(object obj)
        {
            return this.EqualsByProperties(obj);
        }

        public bool Equals(DestinyComponentsInventoryDestinyPlatformSilverComponent other)
        {
            return Equals((object) other);
        }

        public override int GetHashCode()
        {
            return this.PropertiesHash();
        }

        /// <summary>
        /// Implementation of == operator for (DestinyComponentsInventoryDestinyPlatformSilverComponent.
        /// </summary>
        /// <param name="left">Compared (DestinyComponentsInventoryDestinyPlatformSilverComponent</param>
        /// <param name="right">Compared (DestinyComponentsInventoryDestinyPlatformSilverComponent</param>
        /// <returns>true if compared items are equals, false otherwise</returns>
        public static bool operator == (DestinyComponentsInventoryDestinyPlatformSilverComponent left, DestinyComponentsInventoryDestinyPlatformSilverComponent right)
        {
            return Equals(left, right);
        }

        /// <summary>
        /// Implementation of != operator for (DestinyComponentsInventoryDestinyPlatformSilverComponent.
        /// </summary>
        /// <param name="left">Compared (DestinyComponentsInventoryDestinyPlatformSilverComponent</param>
        /// <param name="right">Compared (DestinyComponentsInventoryDestinyPlatformSilverComponent</param>
        /// <returns>true if compared items are not equals, false otherwise</returns>
        public static bool operator != (DestinyComponentsInventoryDestinyPlatformSilverComponent left, DestinyComponentsInventoryDestinyPlatformSilverComponent right)
        {
            return !Equals(left, right);
        }

        /// <summary>
        /// Builder of DestinyComponentsInventoryDestinyPlatformSilverComponent.
        /// </summary>
        public sealed class DestinyComponentsInventoryDestinyPlatformSilverComponentBuilder
        {
            private Dictionary<string, DestinyEntitiesItemsDestinyItemComponent> _PlatformSilver;

            internal DestinyComponentsInventoryDestinyPlatformSilverComponentBuilder()
            {
                SetupDefaults();
            }

            private void SetupDefaults()
            {
            }

            /// <summary>
            /// Sets value for DestinyComponentsInventoryDestinyPlatformSilverComponent.PlatformSilver property.
            /// </summary>
            /// <param name="value">If a Profile is played on multiple platforms, this is the silver they have for each platform, keyed by Membership Type.</param>
            public DestinyComponentsInventoryDestinyPlatformSilverComponentBuilder PlatformSilver(Dictionary<string, DestinyEntitiesItemsDestinyItemComponent> value)
            {
                _PlatformSilver = value;
                return this;
            }


            /// <summary>
            /// Builds instance of DestinyComponentsInventoryDestinyPlatformSilverComponent.
            /// </summary>
            /// <returns>DestinyComponentsInventoryDestinyPlatformSilverComponent</returns>
            public DestinyComponentsInventoryDestinyPlatformSilverComponent Build()
            {
                Validate();
                return new DestinyComponentsInventoryDestinyPlatformSilverComponent(
                    PlatformSilver: _PlatformSilver
                );
            }

            private void Validate()
            { 
            }
        }

        
    }
}