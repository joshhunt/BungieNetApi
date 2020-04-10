using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Sharpility.Extensions;
using NodaTime;

namespace BungieNetApi._Platform.Models
{
    /// <summary>
    /// DestinyArtifactsDestinyArtifactTier
    /// </summary>
    public sealed class DestinyArtifactsDestinyArtifactTier:  IEquatable<DestinyArtifactsDestinyArtifactTier>
    { 
        /// <summary>
        /// TierHash
        /// </summary>
        public int? TierHash { get; private set; }

        /// <summary>
        /// IsUnlocked
        /// </summary>
        public bool? IsUnlocked { get; private set; }

        /// <summary>
        /// PointsToUnlock
        /// </summary>
        public int? PointsToUnlock { get; private set; }

        /// <summary>
        /// Items
        /// </summary>
        public List<DestinyArtifactsDestinyArtifactTierItem> Items { get; private set; }


        /// <summary>
        /// Empty constructor required by some serializers.
        /// Use DestinyArtifactsDestinyArtifactTier.Builder() for instance creation instead.
        /// </summary>
        [Obsolete]
        public DestinyArtifactsDestinyArtifactTier()
        {
        }

        private DestinyArtifactsDestinyArtifactTier(int? TierHash, bool? IsUnlocked, int? PointsToUnlock, List<DestinyArtifactsDestinyArtifactTierItem> Items)
        {
            
            this.TierHash = TierHash;
            
            this.IsUnlocked = IsUnlocked;
            
            this.PointsToUnlock = PointsToUnlock;
            
            this.Items = Items;
            
        }

        /// <summary>
        /// Returns builder of DestinyArtifactsDestinyArtifactTier.
        /// </summary>
        /// <returns>DestinyArtifactsDestinyArtifactTierBuilder</returns>
        public static DestinyArtifactsDestinyArtifactTierBuilder Builder()
        {
            return new DestinyArtifactsDestinyArtifactTierBuilder();
        }

        /// <summary>
        /// Returns DestinyArtifactsDestinyArtifactTierBuilder with properties set.
        /// Use it to change properties.
        /// </summary>
        /// <returns>DestinyArtifactsDestinyArtifactTierBuilder</returns>
        public DestinyArtifactsDestinyArtifactTierBuilder With()
        {
            return Builder()
                .TierHash(TierHash)
                .IsUnlocked(IsUnlocked)
                .PointsToUnlock(PointsToUnlock)
                .Items(Items);
        }

        public override string ToString()
        {
            return this.PropertiesToString();
        }

        public override bool Equals(object obj)
        {
            return this.EqualsByProperties(obj);
        }

        public bool Equals(DestinyArtifactsDestinyArtifactTier other)
        {
            return Equals((object) other);
        }

        public override int GetHashCode()
        {
            return this.PropertiesHash();
        }

        /// <summary>
        /// Implementation of == operator for (DestinyArtifactsDestinyArtifactTier.
        /// </summary>
        /// <param name="left">Compared (DestinyArtifactsDestinyArtifactTier</param>
        /// <param name="right">Compared (DestinyArtifactsDestinyArtifactTier</param>
        /// <returns>true if compared items are equals, false otherwise</returns>
        public static bool operator == (DestinyArtifactsDestinyArtifactTier left, DestinyArtifactsDestinyArtifactTier right)
        {
            return Equals(left, right);
        }

        /// <summary>
        /// Implementation of != operator for (DestinyArtifactsDestinyArtifactTier.
        /// </summary>
        /// <param name="left">Compared (DestinyArtifactsDestinyArtifactTier</param>
        /// <param name="right">Compared (DestinyArtifactsDestinyArtifactTier</param>
        /// <returns>true if compared items are not equals, false otherwise</returns>
        public static bool operator != (DestinyArtifactsDestinyArtifactTier left, DestinyArtifactsDestinyArtifactTier right)
        {
            return !Equals(left, right);
        }

        /// <summary>
        /// Builder of DestinyArtifactsDestinyArtifactTier.
        /// </summary>
        public sealed class DestinyArtifactsDestinyArtifactTierBuilder
        {
            private int? _TierHash;
            private bool? _IsUnlocked;
            private int? _PointsToUnlock;
            private List<DestinyArtifactsDestinyArtifactTierItem> _Items;

            internal DestinyArtifactsDestinyArtifactTierBuilder()
            {
                SetupDefaults();
            }

            private void SetupDefaults()
            {
            }

            /// <summary>
            /// Sets value for DestinyArtifactsDestinyArtifactTier.TierHash property.
            /// </summary>
            /// <param name="value">TierHash</param>
            public DestinyArtifactsDestinyArtifactTierBuilder TierHash(int? value)
            {
                _TierHash = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyArtifactsDestinyArtifactTier.IsUnlocked property.
            /// </summary>
            /// <param name="value">IsUnlocked</param>
            public DestinyArtifactsDestinyArtifactTierBuilder IsUnlocked(bool? value)
            {
                _IsUnlocked = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyArtifactsDestinyArtifactTier.PointsToUnlock property.
            /// </summary>
            /// <param name="value">PointsToUnlock</param>
            public DestinyArtifactsDestinyArtifactTierBuilder PointsToUnlock(int? value)
            {
                _PointsToUnlock = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyArtifactsDestinyArtifactTier.Items property.
            /// </summary>
            /// <param name="value">Items</param>
            public DestinyArtifactsDestinyArtifactTierBuilder Items(List<DestinyArtifactsDestinyArtifactTierItem> value)
            {
                _Items = value;
                return this;
            }


            /// <summary>
            /// Builds instance of DestinyArtifactsDestinyArtifactTier.
            /// </summary>
            /// <returns>DestinyArtifactsDestinyArtifactTier</returns>
            public DestinyArtifactsDestinyArtifactTier Build()
            {
                Validate();
                return new DestinyArtifactsDestinyArtifactTier(
                    TierHash: _TierHash,
                    IsUnlocked: _IsUnlocked,
                    PointsToUnlock: _PointsToUnlock,
                    Items: _Items
                );
            }

            private void Validate()
            { 
            }
        }

        
    }
}