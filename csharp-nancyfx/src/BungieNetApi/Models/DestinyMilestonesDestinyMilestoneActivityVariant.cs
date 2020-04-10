using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Sharpility.Extensions;
using NodaTime;

namespace BungieNetApi._Platform.Models
{
    /// <summary>
    /// Represents custom data that we know about an individual variant of an activity.
    /// </summary>
    public sealed class DestinyMilestonesDestinyMilestoneActivityVariant:  IEquatable<DestinyMilestonesDestinyMilestoneActivityVariant>
    { 
        /// <summary>
        /// The hash for the specific variant of the activity related to this milestone. You can pull more detailed static info from the DestinyActivityDefinition, such as difficulty level.
        /// </summary>
        public int? ActivityHash { get; private set; }

        /// <summary>
        /// An OPTIONAL component: if it makes sense to talk about this activity variant in terms of whether or not it has been completed or what progress you have made in it, this will be returned. Otherwise, this will be NULL.
        /// </summary>
        public DestinyMilestonesDestinyMilestoneActivityCompletionStatus CompletionStatus { get; private set; }

        /// <summary>
        /// The hash identifier of the most specific Activity Mode under which this activity is played. This is useful for situations where the activity in question is - for instance - a PVP map, but it&#39;s not clear what mode the PVP map is being played under. If it&#39;s a playlist, this will be less specific: but hopefully useful in some way.
        /// </summary>
        public int? ActivityModeHash { get; private set; }

        /// <summary>
        /// The enumeration equivalent of the most specific Activity Mode under which this activity is played.
        /// </summary>
        public ActivityModeTypeEnum? ActivityModeType { get; private set; }


        /// <summary>
        /// Empty constructor required by some serializers.
        /// Use DestinyMilestonesDestinyMilestoneActivityVariant.Builder() for instance creation instead.
        /// </summary>
        [Obsolete]
        public DestinyMilestonesDestinyMilestoneActivityVariant()
        {
        }

        private DestinyMilestonesDestinyMilestoneActivityVariant(int? ActivityHash, DestinyMilestonesDestinyMilestoneActivityCompletionStatus CompletionStatus, int? ActivityModeHash, ActivityModeTypeEnum? ActivityModeType)
        {
            
            this.ActivityHash = ActivityHash;
            
            this.CompletionStatus = CompletionStatus;
            
            this.ActivityModeHash = ActivityModeHash;
            
            this.ActivityModeType = ActivityModeType;
            
        }

        /// <summary>
        /// Returns builder of DestinyMilestonesDestinyMilestoneActivityVariant.
        /// </summary>
        /// <returns>DestinyMilestonesDestinyMilestoneActivityVariantBuilder</returns>
        public static DestinyMilestonesDestinyMilestoneActivityVariantBuilder Builder()
        {
            return new DestinyMilestonesDestinyMilestoneActivityVariantBuilder();
        }

        /// <summary>
        /// Returns DestinyMilestonesDestinyMilestoneActivityVariantBuilder with properties set.
        /// Use it to change properties.
        /// </summary>
        /// <returns>DestinyMilestonesDestinyMilestoneActivityVariantBuilder</returns>
        public DestinyMilestonesDestinyMilestoneActivityVariantBuilder With()
        {
            return Builder()
                .ActivityHash(ActivityHash)
                .CompletionStatus(CompletionStatus)
                .ActivityModeHash(ActivityModeHash)
                .ActivityModeType(ActivityModeType);
        }

        public override string ToString()
        {
            return this.PropertiesToString();
        }

        public override bool Equals(object obj)
        {
            return this.EqualsByProperties(obj);
        }

        public bool Equals(DestinyMilestonesDestinyMilestoneActivityVariant other)
        {
            return Equals((object) other);
        }

        public override int GetHashCode()
        {
            return this.PropertiesHash();
        }

        /// <summary>
        /// Implementation of == operator for (DestinyMilestonesDestinyMilestoneActivityVariant.
        /// </summary>
        /// <param name="left">Compared (DestinyMilestonesDestinyMilestoneActivityVariant</param>
        /// <param name="right">Compared (DestinyMilestonesDestinyMilestoneActivityVariant</param>
        /// <returns>true if compared items are equals, false otherwise</returns>
        public static bool operator == (DestinyMilestonesDestinyMilestoneActivityVariant left, DestinyMilestonesDestinyMilestoneActivityVariant right)
        {
            return Equals(left, right);
        }

        /// <summary>
        /// Implementation of != operator for (DestinyMilestonesDestinyMilestoneActivityVariant.
        /// </summary>
        /// <param name="left">Compared (DestinyMilestonesDestinyMilestoneActivityVariant</param>
        /// <param name="right">Compared (DestinyMilestonesDestinyMilestoneActivityVariant</param>
        /// <returns>true if compared items are not equals, false otherwise</returns>
        public static bool operator != (DestinyMilestonesDestinyMilestoneActivityVariant left, DestinyMilestonesDestinyMilestoneActivityVariant right)
        {
            return !Equals(left, right);
        }

        /// <summary>
        /// Builder of DestinyMilestonesDestinyMilestoneActivityVariant.
        /// </summary>
        public sealed class DestinyMilestonesDestinyMilestoneActivityVariantBuilder
        {
            private int? _ActivityHash;
            private DestinyMilestonesDestinyMilestoneActivityCompletionStatus _CompletionStatus;
            private int? _ActivityModeHash;
            private ActivityModeTypeEnum? _ActivityModeType;

            internal DestinyMilestonesDestinyMilestoneActivityVariantBuilder()
            {
                SetupDefaults();
            }

            private void SetupDefaults()
            {
            }

            /// <summary>
            /// Sets value for DestinyMilestonesDestinyMilestoneActivityVariant.ActivityHash property.
            /// </summary>
            /// <param name="value">The hash for the specific variant of the activity related to this milestone. You can pull more detailed static info from the DestinyActivityDefinition, such as difficulty level.</param>
            public DestinyMilestonesDestinyMilestoneActivityVariantBuilder ActivityHash(int? value)
            {
                _ActivityHash = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyMilestonesDestinyMilestoneActivityVariant.CompletionStatus property.
            /// </summary>
            /// <param name="value">An OPTIONAL component: if it makes sense to talk about this activity variant in terms of whether or not it has been completed or what progress you have made in it, this will be returned. Otherwise, this will be NULL.</param>
            public DestinyMilestonesDestinyMilestoneActivityVariantBuilder CompletionStatus(DestinyMilestonesDestinyMilestoneActivityCompletionStatus value)
            {
                _CompletionStatus = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyMilestonesDestinyMilestoneActivityVariant.ActivityModeHash property.
            /// </summary>
            /// <param name="value">The hash identifier of the most specific Activity Mode under which this activity is played. This is useful for situations where the activity in question is - for instance - a PVP map, but it&#39;s not clear what mode the PVP map is being played under. If it&#39;s a playlist, this will be less specific: but hopefully useful in some way.</param>
            public DestinyMilestonesDestinyMilestoneActivityVariantBuilder ActivityModeHash(int? value)
            {
                _ActivityModeHash = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyMilestonesDestinyMilestoneActivityVariant.ActivityModeType property.
            /// </summary>
            /// <param name="value">The enumeration equivalent of the most specific Activity Mode under which this activity is played.</param>
            public DestinyMilestonesDestinyMilestoneActivityVariantBuilder ActivityModeType(ActivityModeTypeEnum? value)
            {
                _ActivityModeType = value;
                return this;
            }


            /// <summary>
            /// Builds instance of DestinyMilestonesDestinyMilestoneActivityVariant.
            /// </summary>
            /// <returns>DestinyMilestonesDestinyMilestoneActivityVariant</returns>
            public DestinyMilestonesDestinyMilestoneActivityVariant Build()
            {
                Validate();
                return new DestinyMilestonesDestinyMilestoneActivityVariant(
                    ActivityHash: _ActivityHash,
                    CompletionStatus: _CompletionStatus,
                    ActivityModeHash: _ActivityModeHash,
                    ActivityModeType: _ActivityModeType
                );
            }

            private void Validate()
            { 
            }
        }

        
        public enum ActivityModeTypeEnum { _0, _2, _3, _4, _5, _6, _7, _9, _10, _11, _12, _13, _15, _16, _17, _18, _19, _20, _21, _22, _24, _25, _26, _27, _28, _29, _30, _31, _32, _37, _38, _39, _40, _41, _42, _43, _44, _45, _46, _47, _48, _49, _50, _51, _52, _53, _54, _55, _56, _57, _58, _59, _60, _61, _62, _63, _64, _65, _66, _67, _68, _69, _70, _71, _72, _73, _74, _75, _76, _77, _78, _79, _80, _81, _82, _83, _84 };
    }
}