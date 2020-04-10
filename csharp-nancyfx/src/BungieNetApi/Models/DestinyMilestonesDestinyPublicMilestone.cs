using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Sharpility.Extensions;
using NodaTime;

namespace BungieNetApi._Platform.Models
{
    /// <summary>
    /// Information about milestones, presented in a character state-agnostic manner. Combine this data with DestinyMilestoneDefinition to get a full picture of the milestone, which is basically a checklist of things to do in the game. Think of this as GetPublicAdvisors 3.0, for those who used the Destiny 1 API.
    /// </summary>
    public sealed class DestinyMilestonesDestinyPublicMilestone:  IEquatable<DestinyMilestonesDestinyPublicMilestone>
    { 
        /// <summary>
        /// The hash identifier for the milestone. Use it to look up the DestinyMilestoneDefinition for static data about the Milestone.
        /// </summary>
        public int? MilestoneHash { get; private set; }

        /// <summary>
        /// A milestone not need have even a single quest, but if there are active quests they will be returned here.
        /// </summary>
        public List<DestinyMilestonesDestinyPublicMilestoneQuest> AvailableQuests { get; private set; }

        /// <summary>
        /// Activities
        /// </summary>
        public List<DestinyMilestonesDestinyPublicMilestoneChallengeActivity> Activities { get; private set; }

        /// <summary>
        /// Sometimes milestones - or activities active in milestones - will have relevant vendors. These are the vendors that are currently relevant.  Deprecated, already, for the sake of the new \&quot;vendors\&quot; property that has more data. What was I thinking.
        /// </summary>
        public List<int?> VendorHashes { get; private set; }

        /// <summary>
        /// This is why we can&#39;t have nice things. This is the ordered list of vendors to be shown that relate to this milestone, potentially along with other interesting data.
        /// </summary>
        public List<DestinyMilestonesDestinyPublicMilestoneVendor> Vendors { get; private set; }

        /// <summary>
        /// If known, this is the date when the Milestone started/became active.
        /// </summary>
        public DateTime? StartDate { get; private set; }

        /// <summary>
        /// If known, this is the date when the Milestone will expire/recycle/end.
        /// </summary>
        public DateTime? EndDate { get; private set; }

        /// <summary>
        /// Used for ordering milestones in a display to match how we order them in BNet. May pull from static data, or possibly in the future from dynamic information.
        /// </summary>
        public int? Order { get; private set; }


        /// <summary>
        /// Empty constructor required by some serializers.
        /// Use DestinyMilestonesDestinyPublicMilestone.Builder() for instance creation instead.
        /// </summary>
        [Obsolete]
        public DestinyMilestonesDestinyPublicMilestone()
        {
        }

        private DestinyMilestonesDestinyPublicMilestone(int? MilestoneHash, List<DestinyMilestonesDestinyPublicMilestoneQuest> AvailableQuests, List<DestinyMilestonesDestinyPublicMilestoneChallengeActivity> Activities, List<int?> VendorHashes, List<DestinyMilestonesDestinyPublicMilestoneVendor> Vendors, DateTime? StartDate, DateTime? EndDate, int? Order)
        {
            
            this.MilestoneHash = MilestoneHash;
            
            this.AvailableQuests = AvailableQuests;
            
            this.Activities = Activities;
            
            this.VendorHashes = VendorHashes;
            
            this.Vendors = Vendors;
            
            this.StartDate = StartDate;
            
            this.EndDate = EndDate;
            
            this.Order = Order;
            
        }

        /// <summary>
        /// Returns builder of DestinyMilestonesDestinyPublicMilestone.
        /// </summary>
        /// <returns>DestinyMilestonesDestinyPublicMilestoneBuilder</returns>
        public static DestinyMilestonesDestinyPublicMilestoneBuilder Builder()
        {
            return new DestinyMilestonesDestinyPublicMilestoneBuilder();
        }

        /// <summary>
        /// Returns DestinyMilestonesDestinyPublicMilestoneBuilder with properties set.
        /// Use it to change properties.
        /// </summary>
        /// <returns>DestinyMilestonesDestinyPublicMilestoneBuilder</returns>
        public DestinyMilestonesDestinyPublicMilestoneBuilder With()
        {
            return Builder()
                .MilestoneHash(MilestoneHash)
                .AvailableQuests(AvailableQuests)
                .Activities(Activities)
                .VendorHashes(VendorHashes)
                .Vendors(Vendors)
                .StartDate(StartDate)
                .EndDate(EndDate)
                .Order(Order);
        }

        public override string ToString()
        {
            return this.PropertiesToString();
        }

        public override bool Equals(object obj)
        {
            return this.EqualsByProperties(obj);
        }

        public bool Equals(DestinyMilestonesDestinyPublicMilestone other)
        {
            return Equals((object) other);
        }

        public override int GetHashCode()
        {
            return this.PropertiesHash();
        }

        /// <summary>
        /// Implementation of == operator for (DestinyMilestonesDestinyPublicMilestone.
        /// </summary>
        /// <param name="left">Compared (DestinyMilestonesDestinyPublicMilestone</param>
        /// <param name="right">Compared (DestinyMilestonesDestinyPublicMilestone</param>
        /// <returns>true if compared items are equals, false otherwise</returns>
        public static bool operator == (DestinyMilestonesDestinyPublicMilestone left, DestinyMilestonesDestinyPublicMilestone right)
        {
            return Equals(left, right);
        }

        /// <summary>
        /// Implementation of != operator for (DestinyMilestonesDestinyPublicMilestone.
        /// </summary>
        /// <param name="left">Compared (DestinyMilestonesDestinyPublicMilestone</param>
        /// <param name="right">Compared (DestinyMilestonesDestinyPublicMilestone</param>
        /// <returns>true if compared items are not equals, false otherwise</returns>
        public static bool operator != (DestinyMilestonesDestinyPublicMilestone left, DestinyMilestonesDestinyPublicMilestone right)
        {
            return !Equals(left, right);
        }

        /// <summary>
        /// Builder of DestinyMilestonesDestinyPublicMilestone.
        /// </summary>
        public sealed class DestinyMilestonesDestinyPublicMilestoneBuilder
        {
            private int? _MilestoneHash;
            private List<DestinyMilestonesDestinyPublicMilestoneQuest> _AvailableQuests;
            private List<DestinyMilestonesDestinyPublicMilestoneChallengeActivity> _Activities;
            private List<int?> _VendorHashes;
            private List<DestinyMilestonesDestinyPublicMilestoneVendor> _Vendors;
            private DateTime? _StartDate;
            private DateTime? _EndDate;
            private int? _Order;

            internal DestinyMilestonesDestinyPublicMilestoneBuilder()
            {
                SetupDefaults();
            }

            private void SetupDefaults()
            {
            }

            /// <summary>
            /// Sets value for DestinyMilestonesDestinyPublicMilestone.MilestoneHash property.
            /// </summary>
            /// <param name="value">The hash identifier for the milestone. Use it to look up the DestinyMilestoneDefinition for static data about the Milestone.</param>
            public DestinyMilestonesDestinyPublicMilestoneBuilder MilestoneHash(int? value)
            {
                _MilestoneHash = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyMilestonesDestinyPublicMilestone.AvailableQuests property.
            /// </summary>
            /// <param name="value">A milestone not need have even a single quest, but if there are active quests they will be returned here.</param>
            public DestinyMilestonesDestinyPublicMilestoneBuilder AvailableQuests(List<DestinyMilestonesDestinyPublicMilestoneQuest> value)
            {
                _AvailableQuests = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyMilestonesDestinyPublicMilestone.Activities property.
            /// </summary>
            /// <param name="value">Activities</param>
            public DestinyMilestonesDestinyPublicMilestoneBuilder Activities(List<DestinyMilestonesDestinyPublicMilestoneChallengeActivity> value)
            {
                _Activities = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyMilestonesDestinyPublicMilestone.VendorHashes property.
            /// </summary>
            /// <param name="value">Sometimes milestones - or activities active in milestones - will have relevant vendors. These are the vendors that are currently relevant.  Deprecated, already, for the sake of the new \&quot;vendors\&quot; property that has more data. What was I thinking.</param>
            public DestinyMilestonesDestinyPublicMilestoneBuilder VendorHashes(List<int?> value)
            {
                _VendorHashes = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyMilestonesDestinyPublicMilestone.Vendors property.
            /// </summary>
            /// <param name="value">This is why we can&#39;t have nice things. This is the ordered list of vendors to be shown that relate to this milestone, potentially along with other interesting data.</param>
            public DestinyMilestonesDestinyPublicMilestoneBuilder Vendors(List<DestinyMilestonesDestinyPublicMilestoneVendor> value)
            {
                _Vendors = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyMilestonesDestinyPublicMilestone.StartDate property.
            /// </summary>
            /// <param name="value">If known, this is the date when the Milestone started/became active.</param>
            public DestinyMilestonesDestinyPublicMilestoneBuilder StartDate(DateTime? value)
            {
                _StartDate = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyMilestonesDestinyPublicMilestone.EndDate property.
            /// </summary>
            /// <param name="value">If known, this is the date when the Milestone will expire/recycle/end.</param>
            public DestinyMilestonesDestinyPublicMilestoneBuilder EndDate(DateTime? value)
            {
                _EndDate = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyMilestonesDestinyPublicMilestone.Order property.
            /// </summary>
            /// <param name="value">Used for ordering milestones in a display to match how we order them in BNet. May pull from static data, or possibly in the future from dynamic information.</param>
            public DestinyMilestonesDestinyPublicMilestoneBuilder Order(int? value)
            {
                _Order = value;
                return this;
            }


            /// <summary>
            /// Builds instance of DestinyMilestonesDestinyPublicMilestone.
            /// </summary>
            /// <returns>DestinyMilestonesDestinyPublicMilestone</returns>
            public DestinyMilestonesDestinyPublicMilestone Build()
            {
                Validate();
                return new DestinyMilestonesDestinyPublicMilestone(
                    MilestoneHash: _MilestoneHash,
                    AvailableQuests: _AvailableQuests,
                    Activities: _Activities,
                    VendorHashes: _VendorHashes,
                    Vendors: _Vendors,
                    StartDate: _StartDate,
                    EndDate: _EndDate,
                    Order: _Order
                );
            }

            private void Validate()
            { 
            }
        }

        
    }
}