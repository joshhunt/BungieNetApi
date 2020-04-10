using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Sharpility.Extensions;
using NodaTime;

namespace BungieNetApi._Platform.Models
{
    /// <summary>
    /// DestinyArtifactsDestinyArtifactCharacterScoped
    /// </summary>
    public sealed class DestinyArtifactsDestinyArtifactCharacterScoped:  IEquatable<DestinyArtifactsDestinyArtifactCharacterScoped>
    { 
        /// <summary>
        /// ArtifactHash
        /// </summary>
        public int? ArtifactHash { get; private set; }

        /// <summary>
        /// PointsUsed
        /// </summary>
        public int? PointsUsed { get; private set; }

        /// <summary>
        /// ResetCount
        /// </summary>
        public int? ResetCount { get; private set; }

        /// <summary>
        /// Tiers
        /// </summary>
        public List<DestinyArtifactsDestinyArtifactTier> Tiers { get; private set; }


        /// <summary>
        /// Empty constructor required by some serializers.
        /// Use DestinyArtifactsDestinyArtifactCharacterScoped.Builder() for instance creation instead.
        /// </summary>
        [Obsolete]
        public DestinyArtifactsDestinyArtifactCharacterScoped()
        {
        }

        private DestinyArtifactsDestinyArtifactCharacterScoped(int? ArtifactHash, int? PointsUsed, int? ResetCount, List<DestinyArtifactsDestinyArtifactTier> Tiers)
        {
            
            this.ArtifactHash = ArtifactHash;
            
            this.PointsUsed = PointsUsed;
            
            this.ResetCount = ResetCount;
            
            this.Tiers = Tiers;
            
        }

        /// <summary>
        /// Returns builder of DestinyArtifactsDestinyArtifactCharacterScoped.
        /// </summary>
        /// <returns>DestinyArtifactsDestinyArtifactCharacterScopedBuilder</returns>
        public static DestinyArtifactsDestinyArtifactCharacterScopedBuilder Builder()
        {
            return new DestinyArtifactsDestinyArtifactCharacterScopedBuilder();
        }

        /// <summary>
        /// Returns DestinyArtifactsDestinyArtifactCharacterScopedBuilder with properties set.
        /// Use it to change properties.
        /// </summary>
        /// <returns>DestinyArtifactsDestinyArtifactCharacterScopedBuilder</returns>
        public DestinyArtifactsDestinyArtifactCharacterScopedBuilder With()
        {
            return Builder()
                .ArtifactHash(ArtifactHash)
                .PointsUsed(PointsUsed)
                .ResetCount(ResetCount)
                .Tiers(Tiers);
        }

        public override string ToString()
        {
            return this.PropertiesToString();
        }

        public override bool Equals(object obj)
        {
            return this.EqualsByProperties(obj);
        }

        public bool Equals(DestinyArtifactsDestinyArtifactCharacterScoped other)
        {
            return Equals((object) other);
        }

        public override int GetHashCode()
        {
            return this.PropertiesHash();
        }

        /// <summary>
        /// Implementation of == operator for (DestinyArtifactsDestinyArtifactCharacterScoped.
        /// </summary>
        /// <param name="left">Compared (DestinyArtifactsDestinyArtifactCharacterScoped</param>
        /// <param name="right">Compared (DestinyArtifactsDestinyArtifactCharacterScoped</param>
        /// <returns>true if compared items are equals, false otherwise</returns>
        public static bool operator == (DestinyArtifactsDestinyArtifactCharacterScoped left, DestinyArtifactsDestinyArtifactCharacterScoped right)
        {
            return Equals(left, right);
        }

        /// <summary>
        /// Implementation of != operator for (DestinyArtifactsDestinyArtifactCharacterScoped.
        /// </summary>
        /// <param name="left">Compared (DestinyArtifactsDestinyArtifactCharacterScoped</param>
        /// <param name="right">Compared (DestinyArtifactsDestinyArtifactCharacterScoped</param>
        /// <returns>true if compared items are not equals, false otherwise</returns>
        public static bool operator != (DestinyArtifactsDestinyArtifactCharacterScoped left, DestinyArtifactsDestinyArtifactCharacterScoped right)
        {
            return !Equals(left, right);
        }

        /// <summary>
        /// Builder of DestinyArtifactsDestinyArtifactCharacterScoped.
        /// </summary>
        public sealed class DestinyArtifactsDestinyArtifactCharacterScopedBuilder
        {
            private int? _ArtifactHash;
            private int? _PointsUsed;
            private int? _ResetCount;
            private List<DestinyArtifactsDestinyArtifactTier> _Tiers;

            internal DestinyArtifactsDestinyArtifactCharacterScopedBuilder()
            {
                SetupDefaults();
            }

            private void SetupDefaults()
            {
            }

            /// <summary>
            /// Sets value for DestinyArtifactsDestinyArtifactCharacterScoped.ArtifactHash property.
            /// </summary>
            /// <param name="value">ArtifactHash</param>
            public DestinyArtifactsDestinyArtifactCharacterScopedBuilder ArtifactHash(int? value)
            {
                _ArtifactHash = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyArtifactsDestinyArtifactCharacterScoped.PointsUsed property.
            /// </summary>
            /// <param name="value">PointsUsed</param>
            public DestinyArtifactsDestinyArtifactCharacterScopedBuilder PointsUsed(int? value)
            {
                _PointsUsed = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyArtifactsDestinyArtifactCharacterScoped.ResetCount property.
            /// </summary>
            /// <param name="value">ResetCount</param>
            public DestinyArtifactsDestinyArtifactCharacterScopedBuilder ResetCount(int? value)
            {
                _ResetCount = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyArtifactsDestinyArtifactCharacterScoped.Tiers property.
            /// </summary>
            /// <param name="value">Tiers</param>
            public DestinyArtifactsDestinyArtifactCharacterScopedBuilder Tiers(List<DestinyArtifactsDestinyArtifactTier> value)
            {
                _Tiers = value;
                return this;
            }


            /// <summary>
            /// Builds instance of DestinyArtifactsDestinyArtifactCharacterScoped.
            /// </summary>
            /// <returns>DestinyArtifactsDestinyArtifactCharacterScoped</returns>
            public DestinyArtifactsDestinyArtifactCharacterScoped Build()
            {
                Validate();
                return new DestinyArtifactsDestinyArtifactCharacterScoped(
                    ArtifactHash: _ArtifactHash,
                    PointsUsed: _PointsUsed,
                    ResetCount: _ResetCount,
                    Tiers: _Tiers
                );
            }

            private void Validate()
            { 
            }
        }

        
    }
}