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
    public sealed class DestinyEntitiesVendorsDestinyVendorComponent:  IEquatable<DestinyEntitiesVendorsDestinyVendorComponent>
    { 
        /// <summary>
        /// If True, you can purchase from the Vendor.  Theoretically, Vendors can be restricted from selling items. In practice, none do that (yet?).
        /// </summary>
        public bool? CanPurchase { get; private set; }

        /// <summary>
        /// If the Vendor has a related Reputation, this is the Progression data that represents the character&#39;s Reputation level with this Vendor.
        /// </summary>
        public DestinyDestinyProgression Progression { get; private set; }

        /// <summary>
        /// An index into the vendor definition&#39;s \&quot;locations\&quot; property array, indicating which location they are at currently. If -1, then the vendor has no known location (and you may choose not to show them in your UI as a result. I mean, it&#39;s your bag honey)
        /// </summary>
        public int? VendorLocationIndex { get; private set; }

        /// <summary>
        /// If this vendor has a seasonal rank, this will be the calculated value of that rank. How nice is that? I mean, that&#39;s pretty sweeet. It&#39;s a whole 32 bit integer.
        /// </summary>
        public int? SeasonalRank { get; private set; }

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
        /// Use DestinyEntitiesVendorsDestinyVendorComponent.Builder() for instance creation instead.
        /// </summary>
        [Obsolete]
        public DestinyEntitiesVendorsDestinyVendorComponent()
        {
        }

        private DestinyEntitiesVendorsDestinyVendorComponent(bool? CanPurchase, DestinyDestinyProgression Progression, int? VendorLocationIndex, int? SeasonalRank, int? VendorHash, DateTime? NextRefreshDate, bool? Enabled)
        {
            
            this.CanPurchase = CanPurchase;
            
            this.Progression = Progression;
            
            this.VendorLocationIndex = VendorLocationIndex;
            
            this.SeasonalRank = SeasonalRank;
            
            this.VendorHash = VendorHash;
            
            this.NextRefreshDate = NextRefreshDate;
            
            this.Enabled = Enabled;
            
        }

        /// <summary>
        /// Returns builder of DestinyEntitiesVendorsDestinyVendorComponent.
        /// </summary>
        /// <returns>DestinyEntitiesVendorsDestinyVendorComponentBuilder</returns>
        public static DestinyEntitiesVendorsDestinyVendorComponentBuilder Builder()
        {
            return new DestinyEntitiesVendorsDestinyVendorComponentBuilder();
        }

        /// <summary>
        /// Returns DestinyEntitiesVendorsDestinyVendorComponentBuilder with properties set.
        /// Use it to change properties.
        /// </summary>
        /// <returns>DestinyEntitiesVendorsDestinyVendorComponentBuilder</returns>
        public DestinyEntitiesVendorsDestinyVendorComponentBuilder With()
        {
            return Builder()
                .CanPurchase(CanPurchase)
                .Progression(Progression)
                .VendorLocationIndex(VendorLocationIndex)
                .SeasonalRank(SeasonalRank)
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

        public bool Equals(DestinyEntitiesVendorsDestinyVendorComponent other)
        {
            return Equals((object) other);
        }

        public override int GetHashCode()
        {
            return this.PropertiesHash();
        }

        /// <summary>
        /// Implementation of == operator for (DestinyEntitiesVendorsDestinyVendorComponent.
        /// </summary>
        /// <param name="left">Compared (DestinyEntitiesVendorsDestinyVendorComponent</param>
        /// <param name="right">Compared (DestinyEntitiesVendorsDestinyVendorComponent</param>
        /// <returns>true if compared items are equals, false otherwise</returns>
        public static bool operator == (DestinyEntitiesVendorsDestinyVendorComponent left, DestinyEntitiesVendorsDestinyVendorComponent right)
        {
            return Equals(left, right);
        }

        /// <summary>
        /// Implementation of != operator for (DestinyEntitiesVendorsDestinyVendorComponent.
        /// </summary>
        /// <param name="left">Compared (DestinyEntitiesVendorsDestinyVendorComponent</param>
        /// <param name="right">Compared (DestinyEntitiesVendorsDestinyVendorComponent</param>
        /// <returns>true if compared items are not equals, false otherwise</returns>
        public static bool operator != (DestinyEntitiesVendorsDestinyVendorComponent left, DestinyEntitiesVendorsDestinyVendorComponent right)
        {
            return !Equals(left, right);
        }

        /// <summary>
        /// Builder of DestinyEntitiesVendorsDestinyVendorComponent.
        /// </summary>
        public sealed class DestinyEntitiesVendorsDestinyVendorComponentBuilder
        {
            private bool? _CanPurchase;
            private DestinyDestinyProgression _Progression;
            private int? _VendorLocationIndex;
            private int? _SeasonalRank;
            private int? _VendorHash;
            private DateTime? _NextRefreshDate;
            private bool? _Enabled;

            internal DestinyEntitiesVendorsDestinyVendorComponentBuilder()
            {
                SetupDefaults();
            }

            private void SetupDefaults()
            {
            }

            /// <summary>
            /// Sets value for DestinyEntitiesVendorsDestinyVendorComponent.CanPurchase property.
            /// </summary>
            /// <param name="value">If True, you can purchase from the Vendor.  Theoretically, Vendors can be restricted from selling items. In practice, none do that (yet?).</param>
            public DestinyEntitiesVendorsDestinyVendorComponentBuilder CanPurchase(bool? value)
            {
                _CanPurchase = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyEntitiesVendorsDestinyVendorComponent.Progression property.
            /// </summary>
            /// <param name="value">If the Vendor has a related Reputation, this is the Progression data that represents the character&#39;s Reputation level with this Vendor.</param>
            public DestinyEntitiesVendorsDestinyVendorComponentBuilder Progression(DestinyDestinyProgression value)
            {
                _Progression = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyEntitiesVendorsDestinyVendorComponent.VendorLocationIndex property.
            /// </summary>
            /// <param name="value">An index into the vendor definition&#39;s \&quot;locations\&quot; property array, indicating which location they are at currently. If -1, then the vendor has no known location (and you may choose not to show them in your UI as a result. I mean, it&#39;s your bag honey)</param>
            public DestinyEntitiesVendorsDestinyVendorComponentBuilder VendorLocationIndex(int? value)
            {
                _VendorLocationIndex = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyEntitiesVendorsDestinyVendorComponent.SeasonalRank property.
            /// </summary>
            /// <param name="value">If this vendor has a seasonal rank, this will be the calculated value of that rank. How nice is that? I mean, that&#39;s pretty sweeet. It&#39;s a whole 32 bit integer.</param>
            public DestinyEntitiesVendorsDestinyVendorComponentBuilder SeasonalRank(int? value)
            {
                _SeasonalRank = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyEntitiesVendorsDestinyVendorComponent.VendorHash property.
            /// </summary>
            /// <param name="value">The unique identifier for the vendor. Use it to look up their DestinyVendorDefinition.</param>
            public DestinyEntitiesVendorsDestinyVendorComponentBuilder VendorHash(int? value)
            {
                _VendorHash = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyEntitiesVendorsDestinyVendorComponent.NextRefreshDate property.
            /// </summary>
            /// <param name="value">The date when this vendor&#39;s inventory will next rotate/refresh.  Note that this is distinct from the date ranges that the vendor is visible/available in-game: this field indicates the specific time when the vendor&#39;s available items refresh and rotate, regardless of whether the vendor is actually available at that time. Unfortunately, these two values may be (and are, for the case of important vendors like Xur) different.  Issue https://github.com/Bungie-net/api/issues/353 is tracking a fix to start providing visibility date ranges where possible in addition to this refresh date, so that all important dates for vendors are available for use.</param>
            public DestinyEntitiesVendorsDestinyVendorComponentBuilder NextRefreshDate(DateTime? value)
            {
                _NextRefreshDate = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyEntitiesVendorsDestinyVendorComponent.Enabled property.
            /// </summary>
            /// <param name="value">If True, the Vendor is currently accessible.   If False, they may not actually be visible in the world at the moment.</param>
            public DestinyEntitiesVendorsDestinyVendorComponentBuilder Enabled(bool? value)
            {
                _Enabled = value;
                return this;
            }


            /// <summary>
            /// Builds instance of DestinyEntitiesVendorsDestinyVendorComponent.
            /// </summary>
            /// <returns>DestinyEntitiesVendorsDestinyVendorComponent</returns>
            public DestinyEntitiesVendorsDestinyVendorComponent Build()
            {
                Validate();
                return new DestinyEntitiesVendorsDestinyVendorComponent(
                    CanPurchase: _CanPurchase,
                    Progression: _Progression,
                    VendorLocationIndex: _VendorLocationIndex,
                    SeasonalRank: _SeasonalRank,
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