using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Sharpility.Extensions;
using NodaTime;

namespace BungieNetApi._Platform.Models
{
    /// <summary>
    /// A milestone may have one or more conceptual Activities associated with it, and each of those conceptual activities could have a variety of variants, modes, tiers, what-have-you. Our attempts to determine what qualifies as a conceptual activity are, unfortunately, janky. So if you see missing modes or modes that don&#39;t seem appropriate to you, let us know and I&#39;ll buy you a beer if we ever meet up in person.
    /// </summary>
    public sealed class DestinyMilestonesDestinyPublicMilestoneActivity:  IEquatable<DestinyMilestonesDestinyPublicMilestoneActivity>
    { 
        /// <summary>
        /// The hash identifier of the activity that&#39;s been chosen to be considered the canonical \&quot;conceptual\&quot; activity definition. This may have many variants, defined herein.
        /// </summary>
        public int? ActivityHash { get; private set; }

        /// <summary>
        /// The activity may have 0-to-many modifiers: if it does, this will contain the hashes to the DestinyActivityModifierDefinition that defines the modifier being applied.
        /// </summary>
        public List<int?> ModifierHashes { get; private set; }

        /// <summary>
        /// Every relevant variation of this conceptual activity, including the conceptual activity itself, have variants defined here.
        /// </summary>
        public List<DestinyMilestonesDestinyPublicMilestoneActivityVariant> Variants { get; private set; }

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
        /// Use DestinyMilestonesDestinyPublicMilestoneActivity.Builder() for instance creation instead.
        /// </summary>
        [Obsolete]
        public DestinyMilestonesDestinyPublicMilestoneActivity()
        {
        }

        private DestinyMilestonesDestinyPublicMilestoneActivity(int? ActivityHash, List<int?> ModifierHashes, List<DestinyMilestonesDestinyPublicMilestoneActivityVariant> Variants, int? ActivityModeHash, ActivityModeTypeEnum? ActivityModeType)
        {
            
            this.ActivityHash = ActivityHash;
            
            this.ModifierHashes = ModifierHashes;
            
            this.Variants = Variants;
            
            this.ActivityModeHash = ActivityModeHash;
            
            this.ActivityModeType = ActivityModeType;
            
        }

        /// <summary>
        /// Returns builder of DestinyMilestonesDestinyPublicMilestoneActivity.
        /// </summary>
        /// <returns>DestinyMilestonesDestinyPublicMilestoneActivityBuilder</returns>
        public static DestinyMilestonesDestinyPublicMilestoneActivityBuilder Builder()
        {
            return new DestinyMilestonesDestinyPublicMilestoneActivityBuilder();
        }

        /// <summary>
        /// Returns DestinyMilestonesDestinyPublicMilestoneActivityBuilder with properties set.
        /// Use it to change properties.
        /// </summary>
        /// <returns>DestinyMilestonesDestinyPublicMilestoneActivityBuilder</returns>
        public DestinyMilestonesDestinyPublicMilestoneActivityBuilder With()
        {
            return Builder()
                .ActivityHash(ActivityHash)
                .ModifierHashes(ModifierHashes)
                .Variants(Variants)
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

        public bool Equals(DestinyMilestonesDestinyPublicMilestoneActivity other)
        {
            return Equals((object) other);
        }

        public override int GetHashCode()
        {
            return this.PropertiesHash();
        }

        /// <summary>
        /// Implementation of == operator for (DestinyMilestonesDestinyPublicMilestoneActivity.
        /// </summary>
        /// <param name="left">Compared (DestinyMilestonesDestinyPublicMilestoneActivity</param>
        /// <param name="right">Compared (DestinyMilestonesDestinyPublicMilestoneActivity</param>
        /// <returns>true if compared items are equals, false otherwise</returns>
        public static bool operator == (DestinyMilestonesDestinyPublicMilestoneActivity left, DestinyMilestonesDestinyPublicMilestoneActivity right)
        {
            return Equals(left, right);
        }

        /// <summary>
        /// Implementation of != operator for (DestinyMilestonesDestinyPublicMilestoneActivity.
        /// </summary>
        /// <param name="left">Compared (DestinyMilestonesDestinyPublicMilestoneActivity</param>
        /// <param name="right">Compared (DestinyMilestonesDestinyPublicMilestoneActivity</param>
        /// <returns>true if compared items are not equals, false otherwise</returns>
        public static bool operator != (DestinyMilestonesDestinyPublicMilestoneActivity left, DestinyMilestonesDestinyPublicMilestoneActivity right)
        {
            return !Equals(left, right);
        }

        /// <summary>
        /// Builder of DestinyMilestonesDestinyPublicMilestoneActivity.
        /// </summary>
        public sealed class DestinyMilestonesDestinyPublicMilestoneActivityBuilder
        {
            private int? _ActivityHash;
            private List<int?> _ModifierHashes;
            private List<DestinyMilestonesDestinyPublicMilestoneActivityVariant> _Variants;
            private int? _ActivityModeHash;
            private ActivityModeTypeEnum? _ActivityModeType;

            internal DestinyMilestonesDestinyPublicMilestoneActivityBuilder()
            {
                SetupDefaults();
            }

            private void SetupDefaults()
            {
            }

            /// <summary>
            /// Sets value for DestinyMilestonesDestinyPublicMilestoneActivity.ActivityHash property.
            /// </summary>
            /// <param name="value">The hash identifier of the activity that&#39;s been chosen to be considered the canonical \&quot;conceptual\&quot; activity definition. This may have many variants, defined herein.</param>
            public DestinyMilestonesDestinyPublicMilestoneActivityBuilder ActivityHash(int? value)
            {
                _ActivityHash = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyMilestonesDestinyPublicMilestoneActivity.ModifierHashes property.
            /// </summary>
            /// <param name="value">The activity may have 0-to-many modifiers: if it does, this will contain the hashes to the DestinyActivityModifierDefinition that defines the modifier being applied.</param>
            public DestinyMilestonesDestinyPublicMilestoneActivityBuilder ModifierHashes(List<int?> value)
            {
                _ModifierHashes = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyMilestonesDestinyPublicMilestoneActivity.Variants property.
            /// </summary>
            /// <param name="value">Every relevant variation of this conceptual activity, including the conceptual activity itself, have variants defined here.</param>
            public DestinyMilestonesDestinyPublicMilestoneActivityBuilder Variants(List<DestinyMilestonesDestinyPublicMilestoneActivityVariant> value)
            {
                _Variants = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyMilestonesDestinyPublicMilestoneActivity.ActivityModeHash property.
            /// </summary>
            /// <param name="value">The hash identifier of the most specific Activity Mode under which this activity is played. This is useful for situations where the activity in question is - for instance - a PVP map, but it&#39;s not clear what mode the PVP map is being played under. If it&#39;s a playlist, this will be less specific: but hopefully useful in some way.</param>
            public DestinyMilestonesDestinyPublicMilestoneActivityBuilder ActivityModeHash(int? value)
            {
                _ActivityModeHash = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyMilestonesDestinyPublicMilestoneActivity.ActivityModeType property.
            /// </summary>
            /// <param name="value">The enumeration equivalent of the most specific Activity Mode under which this activity is played.</param>
            public DestinyMilestonesDestinyPublicMilestoneActivityBuilder ActivityModeType(ActivityModeTypeEnum? value)
            {
                _ActivityModeType = value;
                return this;
            }


            /// <summary>
            /// Builds instance of DestinyMilestonesDestinyPublicMilestoneActivity.
            /// </summary>
            /// <returns>DestinyMilestonesDestinyPublicMilestoneActivity</returns>
            public DestinyMilestonesDestinyPublicMilestoneActivity Build()
            {
                Validate();
                return new DestinyMilestonesDestinyPublicMilestoneActivity(
                    ActivityHash: _ActivityHash,
                    ModifierHashes: _ModifierHashes,
                    Variants: _Variants,
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