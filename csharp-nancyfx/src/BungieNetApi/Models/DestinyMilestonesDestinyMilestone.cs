using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Sharpility.Extensions;
using NodaTime;

namespace BungieNetApi._Platform.Models
{
    /// <summary>
    /// Represents a runtime instance of a user&#39;s milestone status. Live Milestone data should be combined with DestinyMilestoneDefinition data to show the user a picture of what is available for them to do in the game, and their status in regards to said \&quot;things to do.\&quot; Consider it a big, wonky to-do list, or Advisors 3.0 for those who remember the Destiny 1 API.
    /// </summary>
    public sealed class DestinyMilestonesDestinyMilestone:  IEquatable<DestinyMilestonesDestinyMilestone>
    { 
        /// <summary>
        /// The unique identifier for the Milestone. Use it to look up the DestinyMilestoneDefinition, so you can combine the other data in this contract with static definition data.
        /// </summary>
        public int? MilestoneHash { get; private set; }

        /// <summary>
        /// Indicates what quests are available for this Milestone. Usually this will be only a single Quest, but some quests have multiple available that you can choose from at any given time. All possible quests for a milestone can be found in the DestinyMilestoneDefinition, but they must be combined with this Live data to determine which one(s) are actually active right now. It is possible for Milestones to not have any quests.
        /// </summary>
        public List<DestinyMilestonesDestinyMilestoneQuest> AvailableQuests { get; private set; }

        /// <summary>
        /// The currently active Activities in this milestone, when the Milestone is driven by Challenges.  Not all Milestones have Challenges, but when they do this will indicate the Activities and Challenges under those Activities related to this Milestone.
        /// </summary>
        public List<DestinyMilestonesDestinyMilestoneChallengeActivity> Activities { get; private set; }

        /// <summary>
        /// Milestones may have arbitrary key/value pairs associated with them, for data that users will want to know about but that doesn&#39;t fit neatly into any of the common components such as Quests. A good example of this would be - if this existed in Destiny 1 - the number of wins you currently have on your Trials of Osiris ticket. Looking in the DestinyMilestoneDefinition, you can use the string identifier of this dictionary to look up more info about the value, including localized string content for displaying the value. The value in the dictionary is the floating point number. The definition will tell you how to format this number.
        /// </summary>
        public Dictionary<string, float?> Values { get; private set; }

        /// <summary>
        /// A milestone may have one or more active vendors that are \&quot;related\&quot; to it (that provide rewards, or that are the initiators of the Milestone). I already regret this, even as I&#39;m typing it. [I told you I&#39;d regret this] You see, sometimes a milestone may be directly correlated with a set of vendors that provide varying tiers of rewards. The player may not be able to interact with one or more of those vendors. This will return the hashes of the Vendors that the player *can* interact with, allowing you to show their current inventory as rewards or related items to the Milestone or its activities.  Before we even use it, it&#39;s already deprecated! How much of a bummer is that? We need more data.
        /// </summary>
        public List<int?> VendorHashes { get; private set; }

        /// <summary>
        /// Replaces vendorHashes, which I knew was going to be trouble the day it walked in the door. This will return not only what Vendors are active and relevant to the activity (in an implied order that you can choose to ignore), but also other data - for example, if the Vendor is featuring a specific item relevant to this event that you should show with them.
        /// </summary>
        public List<DestinyMilestonesDestinyMilestoneVendor> Vendors { get; private set; }

        /// <summary>
        /// If the entity to which this component is attached has known active Rewards for the player, this will detail information about those rewards, keyed by the RewardEntry Hash. (See DestinyMilestoneDefinition for more information about Reward Entries) Note that these rewards are not for the Quests related to the Milestone. Think of these as \&quot;overview/checklist\&quot; rewards that may be provided for Milestones that may provide rewards for performing a variety of tasks that aren&#39;t under a specific Quest.
        /// </summary>
        public List<DestinyMilestonesDestinyMilestoneRewardCategory> Rewards { get; private set; }

        /// <summary>
        /// If known, this is the date when the event last began or refreshed. It will only be populated for events with fixed and repeating start and end dates.
        /// </summary>
        public DateTime? StartDate { get; private set; }

        /// <summary>
        /// If known, this is the date when the event will next end or repeat. It will only be populated for events with fixed and repeating start and end dates.
        /// </summary>
        public DateTime? EndDate { get; private set; }

        /// <summary>
        /// Used for ordering milestones in a display to match how we order them in BNet. May pull from static data, or possibly in the future from dynamic information.
        /// </summary>
        public int? Order { get; private set; }


        /// <summary>
        /// Empty constructor required by some serializers.
        /// Use DestinyMilestonesDestinyMilestone.Builder() for instance creation instead.
        /// </summary>
        [Obsolete]
        public DestinyMilestonesDestinyMilestone()
        {
        }

        private DestinyMilestonesDestinyMilestone(int? MilestoneHash, List<DestinyMilestonesDestinyMilestoneQuest> AvailableQuests, List<DestinyMilestonesDestinyMilestoneChallengeActivity> Activities, Dictionary<string, float?> Values, List<int?> VendorHashes, List<DestinyMilestonesDestinyMilestoneVendor> Vendors, List<DestinyMilestonesDestinyMilestoneRewardCategory> Rewards, DateTime? StartDate, DateTime? EndDate, int? Order)
        {
            
            this.MilestoneHash = MilestoneHash;
            
            this.AvailableQuests = AvailableQuests;
            
            this.Activities = Activities;
            
            this.Values = Values;
            
            this.VendorHashes = VendorHashes;
            
            this.Vendors = Vendors;
            
            this.Rewards = Rewards;
            
            this.StartDate = StartDate;
            
            this.EndDate = EndDate;
            
            this.Order = Order;
            
        }

        /// <summary>
        /// Returns builder of DestinyMilestonesDestinyMilestone.
        /// </summary>
        /// <returns>DestinyMilestonesDestinyMilestoneBuilder</returns>
        public static DestinyMilestonesDestinyMilestoneBuilder Builder()
        {
            return new DestinyMilestonesDestinyMilestoneBuilder();
        }

        /// <summary>
        /// Returns DestinyMilestonesDestinyMilestoneBuilder with properties set.
        /// Use it to change properties.
        /// </summary>
        /// <returns>DestinyMilestonesDestinyMilestoneBuilder</returns>
        public DestinyMilestonesDestinyMilestoneBuilder With()
        {
            return Builder()
                .MilestoneHash(MilestoneHash)
                .AvailableQuests(AvailableQuests)
                .Activities(Activities)
                .Values(Values)
                .VendorHashes(VendorHashes)
                .Vendors(Vendors)
                .Rewards(Rewards)
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

        public bool Equals(DestinyMilestonesDestinyMilestone other)
        {
            return Equals((object) other);
        }

        public override int GetHashCode()
        {
            return this.PropertiesHash();
        }

        /// <summary>
        /// Implementation of == operator for (DestinyMilestonesDestinyMilestone.
        /// </summary>
        /// <param name="left">Compared (DestinyMilestonesDestinyMilestone</param>
        /// <param name="right">Compared (DestinyMilestonesDestinyMilestone</param>
        /// <returns>true if compared items are equals, false otherwise</returns>
        public static bool operator == (DestinyMilestonesDestinyMilestone left, DestinyMilestonesDestinyMilestone right)
        {
            return Equals(left, right);
        }

        /// <summary>
        /// Implementation of != operator for (DestinyMilestonesDestinyMilestone.
        /// </summary>
        /// <param name="left">Compared (DestinyMilestonesDestinyMilestone</param>
        /// <param name="right">Compared (DestinyMilestonesDestinyMilestone</param>
        /// <returns>true if compared items are not equals, false otherwise</returns>
        public static bool operator != (DestinyMilestonesDestinyMilestone left, DestinyMilestonesDestinyMilestone right)
        {
            return !Equals(left, right);
        }

        /// <summary>
        /// Builder of DestinyMilestonesDestinyMilestone.
        /// </summary>
        public sealed class DestinyMilestonesDestinyMilestoneBuilder
        {
            private int? _MilestoneHash;
            private List<DestinyMilestonesDestinyMilestoneQuest> _AvailableQuests;
            private List<DestinyMilestonesDestinyMilestoneChallengeActivity> _Activities;
            private Dictionary<string, float?> _Values;
            private List<int?> _VendorHashes;
            private List<DestinyMilestonesDestinyMilestoneVendor> _Vendors;
            private List<DestinyMilestonesDestinyMilestoneRewardCategory> _Rewards;
            private DateTime? _StartDate;
            private DateTime? _EndDate;
            private int? _Order;

            internal DestinyMilestonesDestinyMilestoneBuilder()
            {
                SetupDefaults();
            }

            private void SetupDefaults()
            {
            }

            /// <summary>
            /// Sets value for DestinyMilestonesDestinyMilestone.MilestoneHash property.
            /// </summary>
            /// <param name="value">The unique identifier for the Milestone. Use it to look up the DestinyMilestoneDefinition, so you can combine the other data in this contract with static definition data.</param>
            public DestinyMilestonesDestinyMilestoneBuilder MilestoneHash(int? value)
            {
                _MilestoneHash = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyMilestonesDestinyMilestone.AvailableQuests property.
            /// </summary>
            /// <param name="value">Indicates what quests are available for this Milestone. Usually this will be only a single Quest, but some quests have multiple available that you can choose from at any given time. All possible quests for a milestone can be found in the DestinyMilestoneDefinition, but they must be combined with this Live data to determine which one(s) are actually active right now. It is possible for Milestones to not have any quests.</param>
            public DestinyMilestonesDestinyMilestoneBuilder AvailableQuests(List<DestinyMilestonesDestinyMilestoneQuest> value)
            {
                _AvailableQuests = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyMilestonesDestinyMilestone.Activities property.
            /// </summary>
            /// <param name="value">The currently active Activities in this milestone, when the Milestone is driven by Challenges.  Not all Milestones have Challenges, but when they do this will indicate the Activities and Challenges under those Activities related to this Milestone.</param>
            public DestinyMilestonesDestinyMilestoneBuilder Activities(List<DestinyMilestonesDestinyMilestoneChallengeActivity> value)
            {
                _Activities = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyMilestonesDestinyMilestone.Values property.
            /// </summary>
            /// <param name="value">Milestones may have arbitrary key/value pairs associated with them, for data that users will want to know about but that doesn&#39;t fit neatly into any of the common components such as Quests. A good example of this would be - if this existed in Destiny 1 - the number of wins you currently have on your Trials of Osiris ticket. Looking in the DestinyMilestoneDefinition, you can use the string identifier of this dictionary to look up more info about the value, including localized string content for displaying the value. The value in the dictionary is the floating point number. The definition will tell you how to format this number.</param>
            public DestinyMilestonesDestinyMilestoneBuilder Values(Dictionary<string, float?> value)
            {
                _Values = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyMilestonesDestinyMilestone.VendorHashes property.
            /// </summary>
            /// <param name="value">A milestone may have one or more active vendors that are \&quot;related\&quot; to it (that provide rewards, or that are the initiators of the Milestone). I already regret this, even as I&#39;m typing it. [I told you I&#39;d regret this] You see, sometimes a milestone may be directly correlated with a set of vendors that provide varying tiers of rewards. The player may not be able to interact with one or more of those vendors. This will return the hashes of the Vendors that the player *can* interact with, allowing you to show their current inventory as rewards or related items to the Milestone or its activities.  Before we even use it, it&#39;s already deprecated! How much of a bummer is that? We need more data.</param>
            public DestinyMilestonesDestinyMilestoneBuilder VendorHashes(List<int?> value)
            {
                _VendorHashes = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyMilestonesDestinyMilestone.Vendors property.
            /// </summary>
            /// <param name="value">Replaces vendorHashes, which I knew was going to be trouble the day it walked in the door. This will return not only what Vendors are active and relevant to the activity (in an implied order that you can choose to ignore), but also other data - for example, if the Vendor is featuring a specific item relevant to this event that you should show with them.</param>
            public DestinyMilestonesDestinyMilestoneBuilder Vendors(List<DestinyMilestonesDestinyMilestoneVendor> value)
            {
                _Vendors = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyMilestonesDestinyMilestone.Rewards property.
            /// </summary>
            /// <param name="value">If the entity to which this component is attached has known active Rewards for the player, this will detail information about those rewards, keyed by the RewardEntry Hash. (See DestinyMilestoneDefinition for more information about Reward Entries) Note that these rewards are not for the Quests related to the Milestone. Think of these as \&quot;overview/checklist\&quot; rewards that may be provided for Milestones that may provide rewards for performing a variety of tasks that aren&#39;t under a specific Quest.</param>
            public DestinyMilestonesDestinyMilestoneBuilder Rewards(List<DestinyMilestonesDestinyMilestoneRewardCategory> value)
            {
                _Rewards = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyMilestonesDestinyMilestone.StartDate property.
            /// </summary>
            /// <param name="value">If known, this is the date when the event last began or refreshed. It will only be populated for events with fixed and repeating start and end dates.</param>
            public DestinyMilestonesDestinyMilestoneBuilder StartDate(DateTime? value)
            {
                _StartDate = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyMilestonesDestinyMilestone.EndDate property.
            /// </summary>
            /// <param name="value">If known, this is the date when the event will next end or repeat. It will only be populated for events with fixed and repeating start and end dates.</param>
            public DestinyMilestonesDestinyMilestoneBuilder EndDate(DateTime? value)
            {
                _EndDate = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyMilestonesDestinyMilestone.Order property.
            /// </summary>
            /// <param name="value">Used for ordering milestones in a display to match how we order them in BNet. May pull from static data, or possibly in the future from dynamic information.</param>
            public DestinyMilestonesDestinyMilestoneBuilder Order(int? value)
            {
                _Order = value;
                return this;
            }


            /// <summary>
            /// Builds instance of DestinyMilestonesDestinyMilestone.
            /// </summary>
            /// <returns>DestinyMilestonesDestinyMilestone</returns>
            public DestinyMilestonesDestinyMilestone Build()
            {
                Validate();
                return new DestinyMilestonesDestinyMilestone(
                    MilestoneHash: _MilestoneHash,
                    AvailableQuests: _AvailableQuests,
                    Activities: _Activities,
                    Values: _Values,
                    VendorHashes: _VendorHashes,
                    Vendors: _Vendors,
                    Rewards: _Rewards,
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