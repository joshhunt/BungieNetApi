using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Sharpility.Extensions;
using NodaTime;

namespace BungieNetApi._Platform.Models
{
    /// <summary>
    /// A Kiosk is a Vendor (DestinyVendorDefinition) that sells items based on whether you have already acquired that item before.  This component returns information about what Kiosk items are available to you on a *Profile* level. It is theoretically possible for Kiosks to have items gated by specific Character as well. If you ever have those, you will find them on the individual character&#39;s DestinyCharacterKiosksComponent.  Note that, because this component returns vendorItemIndexes (that is to say, indexes into the Kiosk Vendor&#39;s itemList property), these results are necessarily content version dependent. Make sure that you have the latest version of the content manifest databases before using this data.
    /// </summary>
    public sealed class DestinyComponentsKiosksDestinyKiosksComponent:  IEquatable<DestinyComponentsKiosksDestinyKiosksComponent>
    { 
        /// <summary>
        /// A dictionary keyed by the Kiosk Vendor&#39;s hash identifier (use it to look up the DestinyVendorDefinition for the relevant kiosk vendor), and whose value is a list of all the items that the user can \&quot;see\&quot; in the Kiosk, and any other interesting metadata.
        /// </summary>
        public Dictionary<string, List<DestinyComponentsKiosksDestinyKioskItem>> KioskItems { get; private set; }


        /// <summary>
        /// Empty constructor required by some serializers.
        /// Use DestinyComponentsKiosksDestinyKiosksComponent.Builder() for instance creation instead.
        /// </summary>
        [Obsolete]
        public DestinyComponentsKiosksDestinyKiosksComponent()
        {
        }

        private DestinyComponentsKiosksDestinyKiosksComponent(Dictionary<string, List<DestinyComponentsKiosksDestinyKioskItem>> KioskItems)
        {
            
            this.KioskItems = KioskItems;
            
        }

        /// <summary>
        /// Returns builder of DestinyComponentsKiosksDestinyKiosksComponent.
        /// </summary>
        /// <returns>DestinyComponentsKiosksDestinyKiosksComponentBuilder</returns>
        public static DestinyComponentsKiosksDestinyKiosksComponentBuilder Builder()
        {
            return new DestinyComponentsKiosksDestinyKiosksComponentBuilder();
        }

        /// <summary>
        /// Returns DestinyComponentsKiosksDestinyKiosksComponentBuilder with properties set.
        /// Use it to change properties.
        /// </summary>
        /// <returns>DestinyComponentsKiosksDestinyKiosksComponentBuilder</returns>
        public DestinyComponentsKiosksDestinyKiosksComponentBuilder With()
        {
            return Builder()
                .KioskItems(KioskItems);
        }

        public override string ToString()
        {
            return this.PropertiesToString();
        }

        public override bool Equals(object obj)
        {
            return this.EqualsByProperties(obj);
        }

        public bool Equals(DestinyComponentsKiosksDestinyKiosksComponent other)
        {
            return Equals((object) other);
        }

        public override int GetHashCode()
        {
            return this.PropertiesHash();
        }

        /// <summary>
        /// Implementation of == operator for (DestinyComponentsKiosksDestinyKiosksComponent.
        /// </summary>
        /// <param name="left">Compared (DestinyComponentsKiosksDestinyKiosksComponent</param>
        /// <param name="right">Compared (DestinyComponentsKiosksDestinyKiosksComponent</param>
        /// <returns>true if compared items are equals, false otherwise</returns>
        public static bool operator == (DestinyComponentsKiosksDestinyKiosksComponent left, DestinyComponentsKiosksDestinyKiosksComponent right)
        {
            return Equals(left, right);
        }

        /// <summary>
        /// Implementation of != operator for (DestinyComponentsKiosksDestinyKiosksComponent.
        /// </summary>
        /// <param name="left">Compared (DestinyComponentsKiosksDestinyKiosksComponent</param>
        /// <param name="right">Compared (DestinyComponentsKiosksDestinyKiosksComponent</param>
        /// <returns>true if compared items are not equals, false otherwise</returns>
        public static bool operator != (DestinyComponentsKiosksDestinyKiosksComponent left, DestinyComponentsKiosksDestinyKiosksComponent right)
        {
            return !Equals(left, right);
        }

        /// <summary>
        /// Builder of DestinyComponentsKiosksDestinyKiosksComponent.
        /// </summary>
        public sealed class DestinyComponentsKiosksDestinyKiosksComponentBuilder
        {
            private Dictionary<string, List<DestinyComponentsKiosksDestinyKioskItem>> _KioskItems;

            internal DestinyComponentsKiosksDestinyKiosksComponentBuilder()
            {
                SetupDefaults();
            }

            private void SetupDefaults()
            {
            }

            /// <summary>
            /// Sets value for DestinyComponentsKiosksDestinyKiosksComponent.KioskItems property.
            /// </summary>
            /// <param name="value">A dictionary keyed by the Kiosk Vendor&#39;s hash identifier (use it to look up the DestinyVendorDefinition for the relevant kiosk vendor), and whose value is a list of all the items that the user can \&quot;see\&quot; in the Kiosk, and any other interesting metadata.</param>
            public DestinyComponentsKiosksDestinyKiosksComponentBuilder KioskItems(Dictionary<string, List<DestinyComponentsKiosksDestinyKioskItem>> value)
            {
                _KioskItems = value;
                return this;
            }


            /// <summary>
            /// Builds instance of DestinyComponentsKiosksDestinyKiosksComponent.
            /// </summary>
            /// <returns>DestinyComponentsKiosksDestinyKiosksComponent</returns>
            public DestinyComponentsKiosksDestinyKiosksComponent Build()
            {
                Validate();
                return new DestinyComponentsKiosksDestinyKiosksComponent(
                    KioskItems: _KioskItems
                );
            }

            private void Validate()
            { 
            }
        }

        
    }
}