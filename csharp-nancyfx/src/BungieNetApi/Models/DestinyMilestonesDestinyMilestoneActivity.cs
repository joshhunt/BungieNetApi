using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Sharpility.Extensions;
using NodaTime;

namespace BungieNetApi._Platform.Models
{
    /// <summary>
    /// Sometimes, we know the specific activity that the Milestone wants you to play. This entity provides additional information about that Activity and all of its variants. (sometimes there&#39;s only one variant, but I think you get the point)
    /// </summary>
    public sealed class DestinyMilestonesDestinyMilestoneActivity:  IEquatable<DestinyMilestonesDestinyMilestoneActivity>
    { 
        /// <summary>
        /// The hash of an arbitrarily chosen variant of this activity. We&#39;ll go ahead and call that the \&quot;canonical\&quot; activity, because if you&#39;re using this value you should only use it for properties that are common across the variants: things like the name of the activity, it&#39;s location, etc... Use this hash to look up the DestinyActivityDefinition of this activity for rendering data.
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
        /// If the activity has modifiers, this will be the list of modifiers that all variants have in common. Perform lookups against DestinyActivityModifierDefinition which defines the modifier being applied to get at the modifier data. Note that, in the DestiyActivityDefinition, you will see many more modifiers than this being referred to: those are all *possible* modifiers for the activity, not the active ones. Use only the active ones to match what&#39;s really live.
        /// </summary>
        public List<int?> ModifierHashes { get; private set; }

        /// <summary>
        /// If you want more than just name/location/etc... you&#39;re going to have to dig into and show the variants of the conceptual activity. These will differ in seemingly arbitrary ways, like difficulty level and modifiers applied. Show it in whatever way tickles your fancy.
        /// </summary>
        public List<DestinyMilestonesDestinyMilestoneActivityVariant> Variants { get; private set; }


        /// <summary>
        /// Empty constructor required by some serializers.
        /// Use DestinyMilestonesDestinyMilestoneActivity.Builder() for instance creation instead.
        /// </summary>
        [Obsolete]
        public DestinyMilestonesDestinyMilestoneActivity()
        {
        }

        private DestinyMilestonesDestinyMilestoneActivity(int? ActivityHash, int? ActivityModeHash, ActivityModeTypeEnum? ActivityModeType, List<int?> ModifierHashes, List<DestinyMilestonesDestinyMilestoneActivityVariant> Variants)
        {
            
            this.ActivityHash = ActivityHash;
            
            this.ActivityModeHash = ActivityModeHash;
            
            this.ActivityModeType = ActivityModeType;
            
            this.ModifierHashes = ModifierHashes;
            
            this.Variants = Variants;
            
        }

        /// <summary>
        /// Returns builder of DestinyMilestonesDestinyMilestoneActivity.
        /// </summary>
        /// <returns>DestinyMilestonesDestinyMilestoneActivityBuilder</returns>
        public static DestinyMilestonesDestinyMilestoneActivityBuilder Builder()
        {
            return new DestinyMilestonesDestinyMilestoneActivityBuilder();
        }

        /// <summary>
        /// Returns DestinyMilestonesDestinyMilestoneActivityBuilder with properties set.
        /// Use it to change properties.
        /// </summary>
        /// <returns>DestinyMilestonesDestinyMilestoneActivityBuilder</returns>
        public DestinyMilestonesDestinyMilestoneActivityBuilder With()
        {
            return Builder()
                .ActivityHash(ActivityHash)
                .ActivityModeHash(ActivityModeHash)
                .ActivityModeType(ActivityModeType)
                .ModifierHashes(ModifierHashes)
                .Variants(Variants);
        }

        public override string ToString()
        {
            return this.PropertiesToString();
        }

        public override bool Equals(object obj)
        {
            return this.EqualsByProperties(obj);
        }

        public bool Equals(DestinyMilestonesDestinyMilestoneActivity other)
        {
            return Equals((object) other);
        }

        public override int GetHashCode()
        {
            return this.PropertiesHash();
        }

        /// <summary>
        /// Implementation of == operator for (DestinyMilestonesDestinyMilestoneActivity.
        /// </summary>
        /// <param name="left">Compared (DestinyMilestonesDestinyMilestoneActivity</param>
        /// <param name="right">Compared (DestinyMilestonesDestinyMilestoneActivity</param>
        /// <returns>true if compared items are equals, false otherwise</returns>
        public static bool operator == (DestinyMilestonesDestinyMilestoneActivity left, DestinyMilestonesDestinyMilestoneActivity right)
        {
            return Equals(left, right);
        }

        /// <summary>
        /// Implementation of != operator for (DestinyMilestonesDestinyMilestoneActivity.
        /// </summary>
        /// <param name="left">Compared (DestinyMilestonesDestinyMilestoneActivity</param>
        /// <param name="right">Compared (DestinyMilestonesDestinyMilestoneActivity</param>
        /// <returns>true if compared items are not equals, false otherwise</returns>
        public static bool operator != (DestinyMilestonesDestinyMilestoneActivity left, DestinyMilestonesDestinyMilestoneActivity right)
        {
            return !Equals(left, right);
        }

        /// <summary>
        /// Builder of DestinyMilestonesDestinyMilestoneActivity.
        /// </summary>
        public sealed class DestinyMilestonesDestinyMilestoneActivityBuilder
        {
            private int? _ActivityHash;
            private int? _ActivityModeHash;
            private ActivityModeTypeEnum? _ActivityModeType;
            private List<int?> _ModifierHashes;
            private List<DestinyMilestonesDestinyMilestoneActivityVariant> _Variants;

            internal DestinyMilestonesDestinyMilestoneActivityBuilder()
            {
                SetupDefaults();
            }

            private void SetupDefaults()
            {
            }

            /// <summary>
            /// Sets value for DestinyMilestonesDestinyMilestoneActivity.ActivityHash property.
            /// </summary>
            /// <param name="value">The hash of an arbitrarily chosen variant of this activity. We&#39;ll go ahead and call that the \&quot;canonical\&quot; activity, because if you&#39;re using this value you should only use it for properties that are common across the variants: things like the name of the activity, it&#39;s location, etc... Use this hash to look up the DestinyActivityDefinition of this activity for rendering data.</param>
            public DestinyMilestonesDestinyMilestoneActivityBuilder ActivityHash(int? value)
            {
                _ActivityHash = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyMilestonesDestinyMilestoneActivity.ActivityModeHash property.
            /// </summary>
            /// <param name="value">The hash identifier of the most specific Activity Mode under which this activity is played. This is useful for situations where the activity in question is - for instance - a PVP map, but it&#39;s not clear what mode the PVP map is being played under. If it&#39;s a playlist, this will be less specific: but hopefully useful in some way.</param>
            public DestinyMilestonesDestinyMilestoneActivityBuilder ActivityModeHash(int? value)
            {
                _ActivityModeHash = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyMilestonesDestinyMilestoneActivity.ActivityModeType property.
            /// </summary>
            /// <param name="value">The enumeration equivalent of the most specific Activity Mode under which this activity is played.</param>
            public DestinyMilestonesDestinyMilestoneActivityBuilder ActivityModeType(ActivityModeTypeEnum? value)
            {
                _ActivityModeType = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyMilestonesDestinyMilestoneActivity.ModifierHashes property.
            /// </summary>
            /// <param name="value">If the activity has modifiers, this will be the list of modifiers that all variants have in common. Perform lookups against DestinyActivityModifierDefinition which defines the modifier being applied to get at the modifier data. Note that, in the DestiyActivityDefinition, you will see many more modifiers than this being referred to: those are all *possible* modifiers for the activity, not the active ones. Use only the active ones to match what&#39;s really live.</param>
            public DestinyMilestonesDestinyMilestoneActivityBuilder ModifierHashes(List<int?> value)
            {
                _ModifierHashes = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyMilestonesDestinyMilestoneActivity.Variants property.
            /// </summary>
            /// <param name="value">If you want more than just name/location/etc... you&#39;re going to have to dig into and show the variants of the conceptual activity. These will differ in seemingly arbitrary ways, like difficulty level and modifiers applied. Show it in whatever way tickles your fancy.</param>
            public DestinyMilestonesDestinyMilestoneActivityBuilder Variants(List<DestinyMilestonesDestinyMilestoneActivityVariant> value)
            {
                _Variants = value;
                return this;
            }


            /// <summary>
            /// Builds instance of DestinyMilestonesDestinyMilestoneActivity.
            /// </summary>
            /// <returns>DestinyMilestonesDestinyMilestoneActivity</returns>
            public DestinyMilestonesDestinyMilestoneActivity Build()
            {
                Validate();
                return new DestinyMilestonesDestinyMilestoneActivity(
                    ActivityHash: _ActivityHash,
                    ActivityModeHash: _ActivityModeHash,
                    ActivityModeType: _ActivityModeType,
                    ModifierHashes: _ModifierHashes,
                    Variants: _Variants
                );
            }

            private void Validate()
            { 
            }
        }

        
        public enum ActivityModeTypeEnum { _0, _2, _3, _4, _5, _6, _7, _9, _10, _11, _12, _13, _15, _16, _17, _18, _19, _20, _21, _22, _24, _25, _26, _27, _28, _29, _30, _31, _32, _37, _38, _39, _40, _41, _42, _43, _44, _45, _46, _47, _48, _49, _50, _51, _52, _53, _54, _55, _56, _57, _58, _59, _60, _61, _62, _63, _64, _65, _66, _67, _68, _69, _70, _71, _72, _73, _74, _75, _76, _77, _78, _79, _80, _81, _82, _83, _84 };
    }
}