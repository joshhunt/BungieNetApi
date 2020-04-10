using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Sharpility.Extensions;
using NodaTime;

namespace BungieNetApi._Platform.Models
{
    /// <summary>
    /// This component contains essential/summary information about the vendor from the perspective of a character-agnostic view.
    /// </summary>
    public sealed class DestinyComponentsVendorsDestinyPublicVendorComponent:  IEquatable<DestinyComponentsVendorsDestinyPublicVendorComponent>
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
        /// Use DestinyComponentsVendorsDestinyPublicVendorComponent.Builder() for instance creation instead.
        /// </summary>
        [Obsolete]
        public DestinyComponentsVendorsDestinyPublicVendorComponent()
        {
        }

        private DestinyComponentsVendorsDestinyPublicVendorComponent(int? VendorHash, DateTime? NextRefreshDate, bool? Enabled)
        {
            
            this.VendorHash = VendorHash;
            
            this.NextRefreshDate = NextRefreshDate;
            
            this.Enabled = Enabled;
            
        }

        /// <summary>
        /// Returns builder of DestinyComponentsVendorsDestinyPublicVendorComponent.
        /// </summary>
        /// <returns>DestinyComponentsVendorsDestinyPublicVendorComponentBuilder</returns>
        public static DestinyComponentsVendorsDestinyPublicVendorComponentBuilder Builder()
        {
            return new DestinyComponentsVendorsDestinyPublicVendorComponentBuilder();
        }

        /// <summary>
        /// Returns DestinyComponentsVendorsDestinyPublicVendorComponentBuilder with properties set.
        /// Use it to change properties.
        /// </summary>
        /// <returns>DestinyComponentsVendorsDestinyPublicVendorComponentBuilder</returns>
        public DestinyComponentsVendorsDestinyPublicVendorComponentBuilder With()
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

        public bool Equals(DestinyComponentsVendorsDestinyPublicVendorComponent other)
        {
            return Equals((object) other);
        }

        public override int GetHashCode()
        {
            return this.PropertiesHash();
        }

        /// <summary>
        /// Implementation of == operator for (DestinyComponentsVendorsDestinyPublicVendorComponent.
        /// </summary>
        /// <param name="left">Compared (DestinyComponentsVendorsDestinyPublicVendorComponent</param>
        /// <param name="right">Compared (DestinyComponentsVendorsDestinyPublicVendorComponent</param>
        /// <returns>true if compared items are equals, false otherwise</returns>
        public static bool operator == (DestinyComponentsVendorsDestinyPublicVendorComponent left, DestinyComponentsVendorsDestinyPublicVendorComponent right)
        {
            return Equals(left, right);
        }

        /// <summary>
        /// Implementation of != operator for (DestinyComponentsVendorsDestinyPublicVendorComponent.
        /// </summary>
        /// <param name="left">Compared (DestinyComponentsVendorsDestinyPublicVendorComponent</param>
        /// <param name="right">Compared (DestinyComponentsVendorsDestinyPublicVendorComponent</param>
        /// <returns>true if compared items are not equals, false otherwise</returns>
        public static bool operator != (DestinyComponentsVendorsDestinyPublicVendorComponent left, DestinyComponentsVendorsDestinyPublicVendorComponent right)
        {
            return !Equals(left, right);
        }

        /// <summary>
        /// Builder of DestinyComponentsVendorsDestinyPublicVendorComponent.
        /// </summary>
        public sealed class DestinyComponentsVendorsDestinyPublicVendorComponentBuilder
        {
            private int? _VendorHash;
            private DateTime? _NextRefreshDate;
            private bool? _Enabled;

            internal DestinyComponentsVendorsDestinyPublicVendorComponentBuilder()
            {
                SetupDefaults();
            }

            private void SetupDefaults()
            {
            }

            /// <summary>
            /// Sets value for DestinyComponentsVendorsDestinyPublicVendorComponent.VendorHash property.
            /// </summary>
            /// <param name="value">The unique identifier for the vendor. Use it to look up their DestinyVendorDefinition.</param>
            public DestinyComponentsVendorsDestinyPublicVendorComponentBuilder VendorHash(int? value)
            {
                _VendorHash = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyComponentsVendorsDestinyPublicVendorComponent.NextRefreshDate property.
            /// </summary>
            /// <param name="value">The date when this vendor&#39;s inventory will next rotate/refresh.  Note that this is distinct from the date ranges that the vendor is visible/available in-game: this field indicates the specific time when the vendor&#39;s available items refresh and rotate, regardless of whether the vendor is actually available at that time. Unfortunately, these two values may be (and are, for the case of important vendors like Xur) different.  Issue https://github.com/Bungie-net/api/issues/353 is tracking a fix to start providing visibility date ranges where possible in addition to this refresh date, so that all important dates for vendors are available for use.</param>
            public DestinyComponentsVendorsDestinyPublicVendorComponentBuilder NextRefreshDate(DateTime? value)
            {
                _NextRefreshDate = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyComponentsVendorsDestinyPublicVendorComponent.Enabled property.
            /// </summary>
            /// <param name="value">If True, the Vendor is currently accessible.   If False, they may not actually be visible in the world at the moment.</param>
            public DestinyComponentsVendorsDestinyPublicVendorComponentBuilder Enabled(bool? value)
            {
                _Enabled = value;
                return this;
            }


            /// <summary>
            /// Builds instance of DestinyComponentsVendorsDestinyPublicVendorComponent.
            /// </summary>
            /// <returns>DestinyComponentsVendorsDestinyPublicVendorComponent</returns>
            public DestinyComponentsVendorsDestinyPublicVendorComponent Build()
            {
                Validate();
                return new DestinyComponentsVendorsDestinyPublicVendorComponent(
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