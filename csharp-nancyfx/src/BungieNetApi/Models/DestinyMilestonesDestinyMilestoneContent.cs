using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Sharpility.Extensions;
using NodaTime;

namespace BungieNetApi._Platform.Models
{
    /// <summary>
    /// Represents localized, extended content related to Milestones. This is intentionally returned by a separate endpoint and not with Character-level Milestone data because we do not put localized data into standard Destiny responses, both for brevity of response and for caching purposes. If you really need this data, hit the Milestone Content endpoint.
    /// </summary>
    public sealed class DestinyMilestonesDestinyMilestoneContent:  IEquatable<DestinyMilestonesDestinyMilestoneContent>
    { 
        /// <summary>
        /// The \&quot;About this Milestone\&quot; text from the Firehose.
        /// </summary>
        public string About { get; private set; }

        /// <summary>
        /// The Current Status of the Milestone, as driven by the Firehose.
        /// </summary>
        public string Status { get; private set; }

        /// <summary>
        /// A list of tips, provided by the Firehose.
        /// </summary>
        public List<string> Tips { get; private set; }

        /// <summary>
        /// If DPS has defined items related to this Milestone, they can categorize those items in the Firehose. That data will then be returned as item categories here.
        /// </summary>
        public List<DestinyMilestonesDestinyMilestoneContentItemCategory> ItemCategories { get; private set; }


        /// <summary>
        /// Empty constructor required by some serializers.
        /// Use DestinyMilestonesDestinyMilestoneContent.Builder() for instance creation instead.
        /// </summary>
        [Obsolete]
        public DestinyMilestonesDestinyMilestoneContent()
        {
        }

        private DestinyMilestonesDestinyMilestoneContent(string About, string Status, List<string> Tips, List<DestinyMilestonesDestinyMilestoneContentItemCategory> ItemCategories)
        {
            
            this.About = About;
            
            this.Status = Status;
            
            this.Tips = Tips;
            
            this.ItemCategories = ItemCategories;
            
        }

        /// <summary>
        /// Returns builder of DestinyMilestonesDestinyMilestoneContent.
        /// </summary>
        /// <returns>DestinyMilestonesDestinyMilestoneContentBuilder</returns>
        public static DestinyMilestonesDestinyMilestoneContentBuilder Builder()
        {
            return new DestinyMilestonesDestinyMilestoneContentBuilder();
        }

        /// <summary>
        /// Returns DestinyMilestonesDestinyMilestoneContentBuilder with properties set.
        /// Use it to change properties.
        /// </summary>
        /// <returns>DestinyMilestonesDestinyMilestoneContentBuilder</returns>
        public DestinyMilestonesDestinyMilestoneContentBuilder With()
        {
            return Builder()
                .About(About)
                .Status(Status)
                .Tips(Tips)
                .ItemCategories(ItemCategories);
        }

        public override string ToString()
        {
            return this.PropertiesToString();
        }

        public override bool Equals(object obj)
        {
            return this.EqualsByProperties(obj);
        }

        public bool Equals(DestinyMilestonesDestinyMilestoneContent other)
        {
            return Equals((object) other);
        }

        public override int GetHashCode()
        {
            return this.PropertiesHash();
        }

        /// <summary>
        /// Implementation of == operator for (DestinyMilestonesDestinyMilestoneContent.
        /// </summary>
        /// <param name="left">Compared (DestinyMilestonesDestinyMilestoneContent</param>
        /// <param name="right">Compared (DestinyMilestonesDestinyMilestoneContent</param>
        /// <returns>true if compared items are equals, false otherwise</returns>
        public static bool operator == (DestinyMilestonesDestinyMilestoneContent left, DestinyMilestonesDestinyMilestoneContent right)
        {
            return Equals(left, right);
        }

        /// <summary>
        /// Implementation of != operator for (DestinyMilestonesDestinyMilestoneContent.
        /// </summary>
        /// <param name="left">Compared (DestinyMilestonesDestinyMilestoneContent</param>
        /// <param name="right">Compared (DestinyMilestonesDestinyMilestoneContent</param>
        /// <returns>true if compared items are not equals, false otherwise</returns>
        public static bool operator != (DestinyMilestonesDestinyMilestoneContent left, DestinyMilestonesDestinyMilestoneContent right)
        {
            return !Equals(left, right);
        }

        /// <summary>
        /// Builder of DestinyMilestonesDestinyMilestoneContent.
        /// </summary>
        public sealed class DestinyMilestonesDestinyMilestoneContentBuilder
        {
            private string _About;
            private string _Status;
            private List<string> _Tips;
            private List<DestinyMilestonesDestinyMilestoneContentItemCategory> _ItemCategories;

            internal DestinyMilestonesDestinyMilestoneContentBuilder()
            {
                SetupDefaults();
            }

            private void SetupDefaults()
            {
            }

            /// <summary>
            /// Sets value for DestinyMilestonesDestinyMilestoneContent.About property.
            /// </summary>
            /// <param name="value">The \&quot;About this Milestone\&quot; text from the Firehose.</param>
            public DestinyMilestonesDestinyMilestoneContentBuilder About(string value)
            {
                _About = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyMilestonesDestinyMilestoneContent.Status property.
            /// </summary>
            /// <param name="value">The Current Status of the Milestone, as driven by the Firehose.</param>
            public DestinyMilestonesDestinyMilestoneContentBuilder Status(string value)
            {
                _Status = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyMilestonesDestinyMilestoneContent.Tips property.
            /// </summary>
            /// <param name="value">A list of tips, provided by the Firehose.</param>
            public DestinyMilestonesDestinyMilestoneContentBuilder Tips(List<string> value)
            {
                _Tips = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyMilestonesDestinyMilestoneContent.ItemCategories property.
            /// </summary>
            /// <param name="value">If DPS has defined items related to this Milestone, they can categorize those items in the Firehose. That data will then be returned as item categories here.</param>
            public DestinyMilestonesDestinyMilestoneContentBuilder ItemCategories(List<DestinyMilestonesDestinyMilestoneContentItemCategory> value)
            {
                _ItemCategories = value;
                return this;
            }


            /// <summary>
            /// Builds instance of DestinyMilestonesDestinyMilestoneContent.
            /// </summary>
            /// <returns>DestinyMilestonesDestinyMilestoneContent</returns>
            public DestinyMilestonesDestinyMilestoneContent Build()
            {
                Validate();
                return new DestinyMilestonesDestinyMilestoneContent(
                    About: _About,
                    Status: _Status,
                    Tips: _Tips,
                    ItemCategories: _ItemCategories
                );
            }

            private void Validate()
            { 
            }
        }

        
    }
}