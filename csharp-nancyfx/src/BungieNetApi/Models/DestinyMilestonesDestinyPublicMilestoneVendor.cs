using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Sharpility.Extensions;
using NodaTime;

namespace BungieNetApi._Platform.Models
{
    /// <summary>
    /// DestinyMilestonesDestinyPublicMilestoneVendor
    /// </summary>
    public sealed class DestinyMilestonesDestinyPublicMilestoneVendor:  IEquatable<DestinyMilestonesDestinyPublicMilestoneVendor>
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
        /// Use DestinyMilestonesDestinyPublicMilestoneVendor.Builder() for instance creation instead.
        /// </summary>
        [Obsolete]
        public DestinyMilestonesDestinyPublicMilestoneVendor()
        {
        }

        private DestinyMilestonesDestinyPublicMilestoneVendor(int? VendorHash, int? PreviewItemHash)
        {
            
            this.VendorHash = VendorHash;
            
            this.PreviewItemHash = PreviewItemHash;
            
        }

        /// <summary>
        /// Returns builder of DestinyMilestonesDestinyPublicMilestoneVendor.
        /// </summary>
        /// <returns>DestinyMilestonesDestinyPublicMilestoneVendorBuilder</returns>
        public static DestinyMilestonesDestinyPublicMilestoneVendorBuilder Builder()
        {
            return new DestinyMilestonesDestinyPublicMilestoneVendorBuilder();
        }

        /// <summary>
        /// Returns DestinyMilestonesDestinyPublicMilestoneVendorBuilder with properties set.
        /// Use it to change properties.
        /// </summary>
        /// <returns>DestinyMilestonesDestinyPublicMilestoneVendorBuilder</returns>
        public DestinyMilestonesDestinyPublicMilestoneVendorBuilder With()
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

        public bool Equals(DestinyMilestonesDestinyPublicMilestoneVendor other)
        {
            return Equals((object) other);
        }

        public override int GetHashCode()
        {
            return this.PropertiesHash();
        }

        /// <summary>
        /// Implementation of == operator for (DestinyMilestonesDestinyPublicMilestoneVendor.
        /// </summary>
        /// <param name="left">Compared (DestinyMilestonesDestinyPublicMilestoneVendor</param>
        /// <param name="right">Compared (DestinyMilestonesDestinyPublicMilestoneVendor</param>
        /// <returns>true if compared items are equals, false otherwise</returns>
        public static bool operator == (DestinyMilestonesDestinyPublicMilestoneVendor left, DestinyMilestonesDestinyPublicMilestoneVendor right)
        {
            return Equals(left, right);
        }

        /// <summary>
        /// Implementation of != operator for (DestinyMilestonesDestinyPublicMilestoneVendor.
        /// </summary>
        /// <param name="left">Compared (DestinyMilestonesDestinyPublicMilestoneVendor</param>
        /// <param name="right">Compared (DestinyMilestonesDestinyPublicMilestoneVendor</param>
        /// <returns>true if compared items are not equals, false otherwise</returns>
        public static bool operator != (DestinyMilestonesDestinyPublicMilestoneVendor left, DestinyMilestonesDestinyPublicMilestoneVendor right)
        {
            return !Equals(left, right);
        }

        /// <summary>
        /// Builder of DestinyMilestonesDestinyPublicMilestoneVendor.
        /// </summary>
        public sealed class DestinyMilestonesDestinyPublicMilestoneVendorBuilder
        {
            private int? _VendorHash;
            private int? _PreviewItemHash;

            internal DestinyMilestonesDestinyPublicMilestoneVendorBuilder()
            {
                SetupDefaults();
            }

            private void SetupDefaults()
            {
            }

            /// <summary>
            /// Sets value for DestinyMilestonesDestinyPublicMilestoneVendor.VendorHash property.
            /// </summary>
            /// <param name="value">The hash identifier of the Vendor related to this Milestone. You can show useful things from this, such as thier Faction icon or whatever you might care about.</param>
            public DestinyMilestonesDestinyPublicMilestoneVendorBuilder VendorHash(int? value)
            {
                _VendorHash = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyMilestonesDestinyPublicMilestoneVendor.PreviewItemHash property.
            /// </summary>
            /// <param name="value">If this vendor is featuring a specific item for this event, this will be the hash identifier of that item. I&#39;m taking bets now on how long we go before this needs to be a list or some other, more complex representation instead and I deprecate this too. I&#39;m going to go with 5 months. Calling it now, 2017-09-14 at 9:46pm PST.</param>
            public DestinyMilestonesDestinyPublicMilestoneVendorBuilder PreviewItemHash(int? value)
            {
                _PreviewItemHash = value;
                return this;
            }


            /// <summary>
            /// Builds instance of DestinyMilestonesDestinyPublicMilestoneVendor.
            /// </summary>
            /// <returns>DestinyMilestonesDestinyPublicMilestoneVendor</returns>
            public DestinyMilestonesDestinyPublicMilestoneVendor Build()
            {
                Validate();
                return new DestinyMilestonesDestinyPublicMilestoneVendor(
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