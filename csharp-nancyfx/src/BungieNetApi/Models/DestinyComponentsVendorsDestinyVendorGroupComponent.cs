using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Sharpility.Extensions;
using NodaTime;

namespace BungieNetApi._Platform.Models
{
    /// <summary>
    /// This component returns references to all of the Vendors in the response, grouped by categorizations that Bungie has deemed to be interesting, in the order in which both the groups and the vendors within that group should be rendered.
    /// </summary>
    public sealed class DestinyComponentsVendorsDestinyVendorGroupComponent:  IEquatable<DestinyComponentsVendorsDestinyVendorGroupComponent>
    { 
        /// <summary>
        /// The ordered list of groups being returned.
        /// </summary>
        public List<DestinyComponentsVendorsDestinyVendorGroup> Groups { get; private set; }


        /// <summary>
        /// Empty constructor required by some serializers.
        /// Use DestinyComponentsVendorsDestinyVendorGroupComponent.Builder() for instance creation instead.
        /// </summary>
        [Obsolete]
        public DestinyComponentsVendorsDestinyVendorGroupComponent()
        {
        }

        private DestinyComponentsVendorsDestinyVendorGroupComponent(List<DestinyComponentsVendorsDestinyVendorGroup> Groups)
        {
            
            this.Groups = Groups;
            
        }

        /// <summary>
        /// Returns builder of DestinyComponentsVendorsDestinyVendorGroupComponent.
        /// </summary>
        /// <returns>DestinyComponentsVendorsDestinyVendorGroupComponentBuilder</returns>
        public static DestinyComponentsVendorsDestinyVendorGroupComponentBuilder Builder()
        {
            return new DestinyComponentsVendorsDestinyVendorGroupComponentBuilder();
        }

        /// <summary>
        /// Returns DestinyComponentsVendorsDestinyVendorGroupComponentBuilder with properties set.
        /// Use it to change properties.
        /// </summary>
        /// <returns>DestinyComponentsVendorsDestinyVendorGroupComponentBuilder</returns>
        public DestinyComponentsVendorsDestinyVendorGroupComponentBuilder With()
        {
            return Builder()
                .Groups(Groups);
        }

        public override string ToString()
        {
            return this.PropertiesToString();
        }

        public override bool Equals(object obj)
        {
            return this.EqualsByProperties(obj);
        }

        public bool Equals(DestinyComponentsVendorsDestinyVendorGroupComponent other)
        {
            return Equals((object) other);
        }

        public override int GetHashCode()
        {
            return this.PropertiesHash();
        }

        /// <summary>
        /// Implementation of == operator for (DestinyComponentsVendorsDestinyVendorGroupComponent.
        /// </summary>
        /// <param name="left">Compared (DestinyComponentsVendorsDestinyVendorGroupComponent</param>
        /// <param name="right">Compared (DestinyComponentsVendorsDestinyVendorGroupComponent</param>
        /// <returns>true if compared items are equals, false otherwise</returns>
        public static bool operator == (DestinyComponentsVendorsDestinyVendorGroupComponent left, DestinyComponentsVendorsDestinyVendorGroupComponent right)
        {
            return Equals(left, right);
        }

        /// <summary>
        /// Implementation of != operator for (DestinyComponentsVendorsDestinyVendorGroupComponent.
        /// </summary>
        /// <param name="left">Compared (DestinyComponentsVendorsDestinyVendorGroupComponent</param>
        /// <param name="right">Compared (DestinyComponentsVendorsDestinyVendorGroupComponent</param>
        /// <returns>true if compared items are not equals, false otherwise</returns>
        public static bool operator != (DestinyComponentsVendorsDestinyVendorGroupComponent left, DestinyComponentsVendorsDestinyVendorGroupComponent right)
        {
            return !Equals(left, right);
        }

        /// <summary>
        /// Builder of DestinyComponentsVendorsDestinyVendorGroupComponent.
        /// </summary>
        public sealed class DestinyComponentsVendorsDestinyVendorGroupComponentBuilder
        {
            private List<DestinyComponentsVendorsDestinyVendorGroup> _Groups;

            internal DestinyComponentsVendorsDestinyVendorGroupComponentBuilder()
            {
                SetupDefaults();
            }

            private void SetupDefaults()
            {
            }

            /// <summary>
            /// Sets value for DestinyComponentsVendorsDestinyVendorGroupComponent.Groups property.
            /// </summary>
            /// <param name="value">The ordered list of groups being returned.</param>
            public DestinyComponentsVendorsDestinyVendorGroupComponentBuilder Groups(List<DestinyComponentsVendorsDestinyVendorGroup> value)
            {
                _Groups = value;
                return this;
            }


            /// <summary>
            /// Builds instance of DestinyComponentsVendorsDestinyVendorGroupComponent.
            /// </summary>
            /// <returns>DestinyComponentsVendorsDestinyVendorGroupComponent</returns>
            public DestinyComponentsVendorsDestinyVendorGroupComponent Build()
            {
                Validate();
                return new DestinyComponentsVendorsDestinyVendorGroupComponent(
                    Groups: _Groups
                );
            }

            private void Validate()
            { 
            }
        }

        
    }
}