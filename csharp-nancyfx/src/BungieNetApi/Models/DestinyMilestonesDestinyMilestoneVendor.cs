using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Sharpility.Extensions;
using NodaTime;

namespace BungieNetApi._Platform.Models
{
    /// <summary>
    /// If a Milestone has one or more Vendors that are relevant to it, this will contain information about that vendor that you can choose to show.
    /// </summary>
    public sealed class DestinyMilestonesDestinyMilestoneVendor:  IEquatable<DestinyMilestonesDestinyMilestoneVendor>
    { 
        /// <summary>
        /// The hash identifier of the Vendor related to this Milestone. You can show useful things from this, such as thier Faction icon or whatever you might care about.
        /// </summary>
        public int? VendorHash { get; private set; }

        /// <summary>
        /// If this vendor is featuring a specific item for this event, this will be the hash identifier of that item. I&#39;m taking bets now on how long we go before this needs to be a list or some other, more complex representation instead and I deprecate this too. I&#39;m going to go with 5 months. Calling it now, 2017-09-14 at 9:46pm PST.
        /// </summary>
        public int? PreviewItemHash { get; private set; }


        /// <summary>
        /// Empty constructor required by some serializers.
        /// Use DestinyMilestonesDestinyMilestoneVendor.Builder() for instance creation instead.
        /// </summary>
        [Obsolete]
        public DestinyMilestonesDestinyMilestoneVendor()
        {
        }

        private DestinyMilestonesDestinyMilestoneVendor(int? VendorHash, int? PreviewItemHash)
        {
            
            this.VendorHash = VendorHash;
            
            this.PreviewItemHash = PreviewItemHash;
            
        }

        /// <summary>
        /// Returns builder of DestinyMilestonesDestinyMilestoneVendor.
        /// </summary>
        /// <returns>DestinyMilestonesDestinyMilestoneVendorBuilder</returns>
        public static DestinyMilestonesDestinyMilestoneVendorBuilder Builder()
        {
            return new DestinyMilestonesDestinyMilestoneVendorBuilder();
        }

        /// <summary>
        /// Returns DestinyMilestonesDestinyMilestoneVendorBuilder with properties set.
        /// Use it to change properties.
        /// </summary>
        /// <returns>DestinyMilestonesDestinyMilestoneVendorBuilder</returns>
        public DestinyMilestonesDestinyMilestoneVendorBuilder With()
        {
            return Builder()
                .VendorHash(VendorHash)
                .PreviewItemHash(PreviewItemHash);
        }

        public override string ToString()
        {
            return this.PropertiesToString();
        }

        public override bool Equals(object obj)
        {
            return this.EqualsByProperties(obj);
        }

        public bool Equals(DestinyMilestonesDestinyMilestoneVendor other)
        {
            return Equals((object) other);
        }

        public override int GetHashCode()
        {
            return this.PropertiesHash();
        }

        /// <summary>
        /// Implementation of == operator for (DestinyMilestonesDestinyMilestoneVendor.
        /// </summary>
        /// <param name="left">Compared (DestinyMilestonesDestinyMilestoneVendor</param>
        /// <param name="right">Compared (DestinyMilestonesDestinyMilestoneVendor</param>
        /// <returns>true if compared items are equals, false otherwise</returns>
        public static bool operator == (DestinyMilestonesDestinyMilestoneVendor left, DestinyMilestonesDestinyMilestoneVendor right)
        {
            return Equals(left, right);
        }

        /// <summary>
        /// Implementation of != operator for (DestinyMilestonesDestinyMilestoneVendor.
        /// </summary>
        /// <param name="left">Compared (DestinyMilestonesDestinyMilestoneVendor</param>
        /// <param name="right">Compared (DestinyMilestonesDestinyMilestoneVendor</param>
        /// <returns>true if compared items are not equals, false otherwise</returns>
        public static bool operator != (DestinyMilestonesDestinyMilestoneVendor left, DestinyMilestonesDestinyMilestoneVendor right)
        {
            return !Equals(left, right);
        }

        /// <summary>
        /// Builder of DestinyMilestonesDestinyMilestoneVendor.
        /// </summary>
        public sealed class DestinyMilestonesDestinyMilestoneVendorBuilder
        {
            private int? _VendorHash;
            private int? _PreviewItemHash;

            internal DestinyMilestonesDestinyMilestoneVendorBuilder()
            {
                SetupDefaults();
            }

            private void SetupDefaults()
            {
            }

            /// <summary>
            /// Sets value for DestinyMilestonesDestinyMilestoneVendor.VendorHash property.
            /// </summary>
            /// <param name="value">The hash identifier of the Vendor related to this Milestone. You can show useful things from this, such as thier Faction icon or whatever you might care about.</param>
            public DestinyMilestonesDestinyMilestoneVendorBuilder VendorHash(int? value)
            {
                _VendorHash = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyMilestonesDestinyMilestoneVendor.PreviewItemHash property.
            /// </summary>
            /// <param name="value">If this vendor is featuring a specific item for this event, this will be the hash identifier of that item. I&#39;m taking bets now on how long we go before this needs to be a list or some other, more complex representation instead and I deprecate this too. I&#39;m going to go with 5 months. Calling it now, 2017-09-14 at 9:46pm PST.</param>
            public DestinyMilestonesDestinyMilestoneVendorBuilder PreviewItemHash(int? value)
            {
                _PreviewItemHash = value;
                return this;
            }


            /// <summary>
            /// Builds instance of DestinyMilestonesDestinyMilestoneVendor.
            /// </summary>
            /// <returns>DestinyMilestonesDestinyMilestoneVendor</returns>
            public DestinyMilestonesDestinyMilestoneVendor Build()
            {
                Validate();
                return new DestinyMilestonesDestinyMilestoneVendor(
                    VendorHash: _VendorHash,
                    PreviewItemHash: _PreviewItemHash
                );
            }

            private void Validate()
            { 
            }
        }

        
    }
}