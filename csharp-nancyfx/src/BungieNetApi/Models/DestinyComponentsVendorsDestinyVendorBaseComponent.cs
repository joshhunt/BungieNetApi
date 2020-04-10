using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Sharpility.Extensions;
using NodaTime;

namespace BungieNetApi._Platform.Models
{
    /// <summary>
    /// This component contains essential/summary information about the vendor.
    /// </summary>
    public sealed class DestinyComponentsVendorsDestinyVendorBaseComponent:  IEquatable<DestinyComponentsVendorsDestinyVendorBaseComponent>
    { 
        /// <summary>
        /// The unique identifier for the vendor. Use it to look up their DestinyVendorDefinition.
        /// </summary>
        public int? VendorHash { get; private set; }

        /// <summary>
        /// The date when this vendor&#39;s inventory will next rotate/refresh.  Note that this is distinct from the date ranges that the vendor is visible/available in-game: this field indicates the specific time when the vendor&#39;s available items refresh and rotate, regardless of whether the vendor is actually available at that time. Unfortunately, these two values may be (and are, for the case of important vendors like Xur) different.  Issue https://github.com/Bungie-net/api/issues/353 is tracking a fix to start providing visibility date ranges where possible in addition to this refresh date, so that all important dates for vendors are available for use.
        /// </summary>
        public DateTime? NextRefreshDate { get; private set; }

        /// <summary>
        /// If True, the Vendor is currently accessible.   If False, they may not actually be visible in the world at the moment.
        /// </summary>
        public bool? Enabled { get; private set; }


        /// <summary>
        /// Empty constructor required by some serializers.
        /// Use DestinyComponentsVendorsDestinyVendorBaseComponent.Builder() for instance creation instead.
        /// </summary>
        [Obsolete]
        public DestinyComponentsVendorsDestinyVendorBaseComponent()
        {
        }

        private DestinyComponentsVendorsDestinyVendorBaseComponent(int? VendorHash, DateTime? NextRefreshDate, bool? Enabled)
        {
            
            this.VendorHash = VendorHash;
            
            this.NextRefreshDate = NextRefreshDate;
            
            this.Enabled = Enabled;
            
        }

        /// <summary>
        /// Returns builder of DestinyComponentsVendorsDestinyVendorBaseComponent.
        /// </summary>
        /// <returns>DestinyComponentsVendorsDestinyVendorBaseComponentBuilder</returns>
        public static DestinyComponentsVendorsDestinyVendorBaseComponentBuilder Builder()
        {
            return new DestinyComponentsVendorsDestinyVendorBaseComponentBuilder();
        }

        /// <summary>
        /// Returns DestinyComponentsVendorsDestinyVendorBaseComponentBuilder with properties set.
        /// Use it to change properties.
        /// </summary>
        /// <returns>DestinyComponentsVendorsDestinyVendorBaseComponentBuilder</returns>
        public DestinyComponentsVendorsDestinyVendorBaseComponentBuilder With()
        {
            return Builder()
                .VendorHash(VendorHash)
                .NextRefreshDate(NextRefreshDate)
                .Enabled(Enabled);
        }

        public override string ToString()
        {
            return this.PropertiesToString();
        }

        public override bool Equals(object obj)
        {
            return this.EqualsByProperties(obj);
        }

        public bool Equals(DestinyComponentsVendorsDestinyVendorBaseComponent other)
        {
            return Equals((object) other);
        }

        public override int GetHashCode()
        {
            return this.PropertiesHash();
        }

        /// <summary>
        /// Implementation of == operator for (DestinyComponentsVendorsDestinyVendorBaseComponent.
        /// </summary>
        /// <param name="left">Compared (DestinyComponentsVendorsDestinyVendorBaseComponent</param>
        /// <param name="right">Compared (DestinyComponentsVendorsDestinyVendorBaseComponent</param>
        /// <returns>true if compared items are equals, false otherwise</returns>
        public static bool operator == (DestinyComponentsVendorsDestinyVendorBaseComponent left, DestinyComponentsVendorsDestinyVendorBaseComponent right)
        {
            return Equals(left, right);
        }

        /// <summary>
        /// Implementation of != operator for (DestinyComponentsVendorsDestinyVendorBaseComponent.
        /// </summary>
        /// <param name="left">Compared (DestinyComponentsVendorsDestinyVendorBaseComponent</param>
        /// <param name="right">Compared (DestinyComponentsVendorsDestinyVendorBaseComponent</param>
        /// <returns>true if compared items are not equals, false otherwise</returns>
        public static bool operator != (DestinyComponentsVendorsDestinyVendorBaseComponent left, DestinyComponentsVendorsDestinyVendorBaseComponent right)
        {
            return !Equals(left, right);
        }

        /// <summary>
        /// Builder of DestinyComponentsVendorsDestinyVendorBaseComponent.
        /// </summary>
        public sealed class DestinyComponentsVendorsDestinyVendorBaseComponentBuilder
        {
            private int? _VendorHash;
            private DateTime? _NextRefreshDate;
            private bool? _Enabled;

            internal DestinyComponentsVendorsDestinyVendorBaseComponentBuilder()
            {
                SetupDefaults();
            }

            private void SetupDefaults()
            {
            }

            /// <summary>
            /// Sets value for DestinyComponentsVendorsDestinyVendorBaseComponent.VendorHash property.
            /// </summary>
            /// <param name="value">The unique identifier for the vendor. Use it to look up their DestinyVendorDefinition.</param>
            public DestinyComponentsVendorsDestinyVendorBaseComponentBuilder VendorHash(int? value)
            {
                _VendorHash = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyComponentsVendorsDestinyVendorBaseComponent.NextRefreshDate property.
            /// </summary>
            /// <param name="value">The date when this vendor&#39;s inventory will next rotate/refresh.  Note that this is distinct from the date ranges that the vendor is visible/available in-game: this field indicates the specific time when the vendor&#39;s available items refresh and rotate, regardless of whether the vendor is actually available at that time. Unfortunately, these two values may be (and are, for the case of important vendors like Xur) different.  Issue https://github.com/Bungie-net/api/issues/353 is tracking a fix to start providing visibility date ranges where possible in addition to this refresh date, so that all important dates for vendors are available for use.</param>
            public DestinyComponentsVendorsDestinyVendorBaseComponentBuilder NextRefreshDate(DateTime? value)
            {
                _NextRefreshDate = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyComponentsVendorsDestinyVendorBaseComponent.Enabled property.
            /// </summary>
            /// <param name="value">If True, the Vendor is currently accessible.   If False, they may not actually be visible in the world at the moment.</param>
            public DestinyComponentsVendorsDestinyVendorBaseComponentBuilder Enabled(bool? value)
            {
                _Enabled = value;
                return this;
            }


            /// <summary>
            /// Builds instance of DestinyComponentsVendorsDestinyVendorBaseComponent.
            /// </summary>
            /// <returns>DestinyComponentsVendorsDestinyVendorBaseComponent</returns>
            public DestinyComponentsVendorsDestinyVendorBaseComponent Build()
            {
                Validate();
                return new DestinyComponentsVendorsDestinyVendorBaseComponent(
                    VendorHash: _VendorHash,
                    NextRefreshDate: _NextRefreshDate,
                    Enabled: _Enabled
                );
            }

            private void Validate()
            { 
            }
        }

        
    }
}