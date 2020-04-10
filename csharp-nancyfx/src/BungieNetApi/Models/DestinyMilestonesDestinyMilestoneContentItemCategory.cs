using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Sharpility.Extensions;
using NodaTime;

namespace BungieNetApi._Platform.Models
{
    /// <summary>
    /// Part of our dynamic, localized Milestone content is arbitrary categories of items. These are built in our content management system, and thus aren&#39;t the same as programmatically generated rewards.
    /// </summary>
    public sealed class DestinyMilestonesDestinyMilestoneContentItemCategory:  IEquatable<DestinyMilestonesDestinyMilestoneContentItemCategory>
    { 
        /// <summary>
        /// Title
        /// </summary>
        public string Title { get; private set; }

        /// <summary>
        /// ItemHashes
        /// </summary>
        public List<int?> ItemHashes { get; private set; }


        /// <summary>
        /// Empty constructor required by some serializers.
        /// Use DestinyMilestonesDestinyMilestoneContentItemCategory.Builder() for instance creation instead.
        /// </summary>
        [Obsolete]
        public DestinyMilestonesDestinyMilestoneContentItemCategory()
        {
        }

        private DestinyMilestonesDestinyMilestoneContentItemCategory(string Title, List<int?> ItemHashes)
        {
            
            this.Title = Title;
            
            this.ItemHashes = ItemHashes;
            
        }

        /// <summary>
        /// Returns builder of DestinyMilestonesDestinyMilestoneContentItemCategory.
        /// </summary>
        /// <returns>DestinyMilestonesDestinyMilestoneContentItemCategoryBuilder</returns>
        public static DestinyMilestonesDestinyMilestoneContentItemCategoryBuilder Builder()
        {
            return new DestinyMilestonesDestinyMilestoneContentItemCategoryBuilder();
        }

        /// <summary>
        /// Returns DestinyMilestonesDestinyMilestoneContentItemCategoryBuilder with properties set.
        /// Use it to change properties.
        /// </summary>
        /// <returns>DestinyMilestonesDestinyMilestoneContentItemCategoryBuilder</returns>
        public DestinyMilestonesDestinyMilestoneContentItemCategoryBuilder With()
        {
            return Builder()
                .Title(Title)
                .ItemHashes(ItemHashes);
        }

        public override string ToString()
        {
            return this.PropertiesToString();
        }

        public override bool Equals(object obj)
        {
            return this.EqualsByProperties(obj);
        }

        public bool Equals(DestinyMilestonesDestinyMilestoneContentItemCategory other)
        {
            return Equals((object) other);
        }

        public override int GetHashCode()
        {
            return this.PropertiesHash();
        }

        /// <summary>
        /// Implementation of == operator for (DestinyMilestonesDestinyMilestoneContentItemCategory.
        /// </summary>
        /// <param name="left">Compared (DestinyMilestonesDestinyMilestoneContentItemCategory</param>
        /// <param name="right">Compared (DestinyMilestonesDestinyMilestoneContentItemCategory</param>
        /// <returns>true if compared items are equals, false otherwise</returns>
        public static bool operator == (DestinyMilestonesDestinyMilestoneContentItemCategory left, DestinyMilestonesDestinyMilestoneContentItemCategory right)
        {
            return Equals(left, right);
        }

        /// <summary>
        /// Implementation of != operator for (DestinyMilestonesDestinyMilestoneContentItemCategory.
        /// </summary>
        /// <param name="left">Compared (DestinyMilestonesDestinyMilestoneContentItemCategory</param>
        /// <param name="right">Compared (DestinyMilestonesDestinyMilestoneContentItemCategory</param>
        /// <returns>true if compared items are not equals, false otherwise</returns>
        public static bool operator != (DestinyMilestonesDestinyMilestoneContentItemCategory left, DestinyMilestonesDestinyMilestoneContentItemCategory right)
        {
            return !Equals(left, right);
        }

        /// <summary>
        /// Builder of DestinyMilestonesDestinyMilestoneContentItemCategory.
        /// </summary>
        public sealed class DestinyMilestonesDestinyMilestoneContentItemCategoryBuilder
        {
            private string _Title;
            private List<int?> _ItemHashes;

            internal DestinyMilestonesDestinyMilestoneContentItemCategoryBuilder()
            {
                SetupDefaults();
            }

            private void SetupDefaults()
            {
            }

            /// <summary>
            /// Sets value for DestinyMilestonesDestinyMilestoneContentItemCategory.Title property.
            /// </summary>
            /// <param name="value">Title</param>
            public DestinyMilestonesDestinyMilestoneContentItemCategoryBuilder Title(string value)
            {
                _Title = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyMilestonesDestinyMilestoneContentItemCategory.ItemHashes property.
            /// </summary>
            /// <param name="value">ItemHashes</param>
            public DestinyMilestonesDestinyMilestoneContentItemCategoryBuilder ItemHashes(List<int?> value)
            {
                _ItemHashes = value;
                return this;
            }


            /// <summary>
            /// Builds instance of DestinyMilestonesDestinyMilestoneContentItemCategory.
            /// </summary>
            /// <returns>DestinyMilestonesDestinyMilestoneContentItemCategory</returns>
            public DestinyMilestonesDestinyMilestoneContentItemCategory Build()
            {
                Validate();
                return new DestinyMilestonesDestinyMilestoneContentItemCategory(
                    Title: _Title,
                    ItemHashes: _ItemHashes
                );
            }

            private void Validate()
            { 
            }
        }

        
    }
}