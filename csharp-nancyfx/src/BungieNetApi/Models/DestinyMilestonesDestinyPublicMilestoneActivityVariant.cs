using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Sharpility.Extensions;
using NodaTime;

namespace BungieNetApi._Platform.Models
{
    /// <summary>
    /// Represents a variant of an activity that&#39;s relevant to a milestone.
    /// </summary>
    public sealed class DestinyMilestonesDestinyPublicMilestoneActivityVariant:  IEquatable<DestinyMilestonesDestinyPublicMilestoneActivityVariant>
    { 
        /// <summary>
        /// The hash identifier of this activity variant. Examine the activity&#39;s definition in the Manifest database to determine what makes it a distinct variant. Usually it will be difficulty level or whether or not it is a guided game variant of the activity, but theoretically it could be distinguished in any arbitrary way.
        /// </summary>
        public int? ActivityHash { get; private set; }

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
        /// Use DestinyMilestonesDestinyPublicMilestoneActivityVariant.Builder() for instance creation instead.
        /// </summary>
        [Obsolete]
        public DestinyMilestonesDestinyPublicMilestoneActivityVariant()
        {
        }

        private DestinyMilestonesDestinyPublicMilestoneActivityVariant(int? ActivityHash, int? ActivityModeHash, ActivityModeTypeEnum? ActivityModeType)
        {
            
            this.ActivityHash = ActivityHash;
            
            this.ActivityModeHash = ActivityModeHash;
            
            this.ActivityModeType = ActivityModeType;
            
        }

        /// <summary>
        /// Returns builder of DestinyMilestonesDestinyPublicMilestoneActivityVariant.
        /// </summary>
        /// <returns>DestinyMilestonesDestinyPublicMilestoneActivityVariantBuilder</returns>
        public static DestinyMilestonesDestinyPublicMilestoneActivityVariantBuilder Builder()
        {
            return new DestinyMilestonesDestinyPublicMilestoneActivityVariantBuilder();
        }

        /// <summary>
        /// Returns DestinyMilestonesDestinyPublicMilestoneActivityVariantBuilder with properties set.
        /// Use it to change properties.
        /// </summary>
        /// <returns>DestinyMilestonesDestinyPublicMilestoneActivityVariantBuilder</returns>
        public DestinyMilestonesDestinyPublicMilestoneActivityVariantBuilder With()
        {
            return Builder()
                .ActivityHash(ActivityHash)
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

        public bool Equals(DestinyMilestonesDestinyPublicMilestoneActivityVariant other)
        {
            return Equals((object) other);
        }

        public override int GetHashCode()
        {
            return this.PropertiesHash();
        }

        /// <summary>
        /// Implementation of == operator for (DestinyMilestonesDestinyPublicMilestoneActivityVariant.
        /// </summary>
        /// <param name="left">Compared (DestinyMilestonesDestinyPublicMilestoneActivityVariant</param>
        /// <param name="right">Compared (DestinyMilestonesDestinyPublicMilestoneActivityVariant</param>
        /// <returns>true if compared items are equals, false otherwise</returns>
        public static bool operator == (DestinyMilestonesDestinyPublicMilestoneActivityVariant left, DestinyMilestonesDestinyPublicMilestoneActivityVariant right)
        {
            return Equals(left, right);
        }

        /// <summary>
        /// Implementation of != operator for (DestinyMilestonesDestinyPublicMilestoneActivityVariant.
        /// </summary>
        /// <param name="left">Compared (DestinyMilestonesDestinyPublicMilestoneActivityVariant</param>
        /// <param name="right">Compared (DestinyMilestonesDestinyPublicMilestoneActivityVariant</param>
        /// <returns>true if compared items are not equals, false otherwise</returns>
        public static bool operator != (DestinyMilestonesDestinyPublicMilestoneActivityVariant left, DestinyMilestonesDestinyPublicMilestoneActivityVariant right)
        {
            return !Equals(left, right);
        }

        /// <summary>
        /// Builder of DestinyMilestonesDestinyPublicMilestoneActivityVariant.
        /// </summary>
        public sealed class DestinyMilestonesDestinyPublicMilestoneActivityVariantBuilder
        {
            private int? _ActivityHash;
            private int? _ActivityModeHash;
            private ActivityModeTypeEnum? _ActivityModeType;

            internal DestinyMilestonesDestinyPublicMilestoneActivityVariantBuilder()
            {
                SetupDefaults();
            }

            private void SetupDefaults()
            {
            }

            /// <summary>
            /// Sets value for DestinyMilestonesDestinyPublicMilestoneActivityVariant.ActivityHash property.
            /// </summary>
            /// <param name="value">The hash identifier of this activity variant. Examine the activity&#39;s definition in the Manifest database to determine what makes it a distinct variant. Usually it will be difficulty level or whether or not it is a guided game variant of the activity, but theoretically it could be distinguished in any arbitrary way.</param>
            public DestinyMilestonesDestinyPublicMilestoneActivityVariantBuilder ActivityHash(int? value)
            {
                _ActivityHash = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyMilestonesDestinyPublicMilestoneActivityVariant.ActivityModeHash property.
            /// </summary>
            /// <param name="value">The hash identifier of the most specific Activity Mode under which this activity is played. This is useful for situations where the activity in question is - for instance - a PVP map, but it&#39;s not clear what mode the PVP map is being played under. If it&#39;s a playlist, this will be less specific: but hopefully useful in some way.</param>
            public DestinyMilestonesDestinyPublicMilestoneActivityVariantBuilder ActivityModeHash(int? value)
            {
                _ActivityModeHash = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyMilestonesDestinyPublicMilestoneActivityVariant.ActivityModeType property.
            /// </summary>
            /// <param name="value">The enumeration equivalent of the most specific Activity Mode under which this activity is played.</param>
            public DestinyMilestonesDestinyPublicMilestoneActivityVariantBuilder ActivityModeType(ActivityModeTypeEnum? value)
            {
                _ActivityModeType = value;
                return this;
            }


            /// <summary>
            /// Builds instance of DestinyMilestonesDestinyPublicMilestoneActivityVariant.
            /// </summary>
            /// <returns>DestinyMilestonesDestinyPublicMilestoneActivityVariant</returns>
            public DestinyMilestonesDestinyPublicMilestoneActivityVariant Build()
            {
                Validate();
                return new DestinyMilestonesDestinyPublicMilestoneActivityVariant(
                    ActivityHash: _ActivityHash,
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