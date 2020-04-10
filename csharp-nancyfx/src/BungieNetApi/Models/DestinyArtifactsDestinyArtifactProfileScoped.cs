using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Sharpility.Extensions;
using NodaTime;

namespace BungieNetApi._Platform.Models
{
    /// <summary>
    /// Represents a Seasonal Artifact and all data related to it for the requested Account.  It can be combined with Character-scoped data for a full picture of what a character has available/has chosen, or just these settings can be used for overview information.
    /// </summary>
    public sealed class DestinyArtifactsDestinyArtifactProfileScoped:  IEquatable<DestinyArtifactsDestinyArtifactProfileScoped>
    { 
        /// <summary>
        /// ArtifactHash
        /// </summary>
        public int? ArtifactHash { get; private set; }

        /// <summary>
        /// PointProgression
        /// </summary>
        public DestinyDestinyProgression PointProgression { get; private set; }

        /// <summary>
        /// PointsAcquired
        /// </summary>
        public int? PointsAcquired { get; private set; }

        /// <summary>
        /// PowerBonusProgression
        /// </summary>
        public DestinyDestinyProgression PowerBonusProgression { get; private set; }

        /// <summary>
        /// PowerBonus
        /// </summary>
        public int? PowerBonus { get; private set; }


        /// <summary>
        /// Empty constructor required by some serializers.
        /// Use DestinyArtifactsDestinyArtifactProfileScoped.Builder() for instance creation instead.
        /// </summary>
        [Obsolete]
        public DestinyArtifactsDestinyArtifactProfileScoped()
        {
        }

        private DestinyArtifactsDestinyArtifactProfileScoped(int? ArtifactHash, DestinyDestinyProgression PointProgression, int? PointsAcquired, DestinyDestinyProgression PowerBonusProgression, int? PowerBonus)
        {
            
            this.ArtifactHash = ArtifactHash;
            
            this.PointProgression = PointProgression;
            
            this.PointsAcquired = PointsAcquired;
            
            this.PowerBonusProgression = PowerBonusProgression;
            
            this.PowerBonus = PowerBonus;
            
        }

        /// <summary>
        /// Returns builder of DestinyArtifactsDestinyArtifactProfileScoped.
        /// </summary>
        /// <returns>DestinyArtifactsDestinyArtifactProfileScopedBuilder</returns>
        public static DestinyArtifactsDestinyArtifactProfileScopedBuilder Builder()
        {
            return new DestinyArtifactsDestinyArtifactProfileScopedBuilder();
        }

        /// <summary>
        /// Returns DestinyArtifactsDestinyArtifactProfileScopedBuilder with properties set.
        /// Use it to change properties.
        /// </summary>
        /// <returns>DestinyArtifactsDestinyArtifactProfileScopedBuilder</returns>
        public DestinyArtifactsDestinyArtifactProfileScopedBuilder With()
        {
            return Builder()
                .ArtifactHash(ArtifactHash)
                .PointProgression(PointProgression)
                .PointsAcquired(PointsAcquired)
                .PowerBonusProgression(PowerBonusProgression)
                .PowerBonus(PowerBonus);
        }

        public override string ToString()
        {
            return this.PropertiesToString();
        }

        public override bool Equals(object obj)
        {
            return this.EqualsByProperties(obj);
        }

        public bool Equals(DestinyArtifactsDestinyArtifactProfileScoped other)
        {
            return Equals((object) other);
        }

        public override int GetHashCode()
        {
            return this.PropertiesHash();
        }

        /// <summary>
        /// Implementation of == operator for (DestinyArtifactsDestinyArtifactProfileScoped.
        /// </summary>
        /// <param name="left">Compared (DestinyArtifactsDestinyArtifactProfileScoped</param>
        /// <param name="right">Compared (DestinyArtifactsDestinyArtifactProfileScoped</param>
        /// <returns>true if compared items are equals, false otherwise</returns>
        public static bool operator == (DestinyArtifactsDestinyArtifactProfileScoped left, DestinyArtifactsDestinyArtifactProfileScoped right)
        {
            return Equals(left, right);
        }

        /// <summary>
        /// Implementation of != operator for (DestinyArtifactsDestinyArtifactProfileScoped.
        /// </summary>
        /// <param name="left">Compared (DestinyArtifactsDestinyArtifactProfileScoped</param>
        /// <param name="right">Compared (DestinyArtifactsDestinyArtifactProfileScoped</param>
        /// <returns>true if compared items are not equals, false otherwise</returns>
        public static bool operator != (DestinyArtifactsDestinyArtifactProfileScoped left, DestinyArtifactsDestinyArtifactProfileScoped right)
        {
            return !Equals(left, right);
        }

        /// <summary>
        /// Builder of DestinyArtifactsDestinyArtifactProfileScoped.
        /// </summary>
        public sealed class DestinyArtifactsDestinyArtifactProfileScopedBuilder
        {
            private int? _ArtifactHash;
            private DestinyDestinyProgression _PointProgression;
            private int? _PointsAcquired;
            private DestinyDestinyProgression _PowerBonusProgression;
            private int? _PowerBonus;

            internal DestinyArtifactsDestinyArtifactProfileScopedBuilder()
            {
                SetupDefaults();
            }

            private void SetupDefaults()
            {
            }

            /// <summary>
            /// Sets value for DestinyArtifactsDestinyArtifactProfileScoped.ArtifactHash property.
            /// </summary>
            /// <param name="value">ArtifactHash</param>
            public DestinyArtifactsDestinyArtifactProfileScopedBuilder ArtifactHash(int? value)
            {
                _ArtifactHash = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyArtifactsDestinyArtifactProfileScoped.PointProgression property.
            /// </summary>
            /// <param name="value">PointProgression</param>
            public DestinyArtifactsDestinyArtifactProfileScopedBuilder PointProgression(DestinyDestinyProgression value)
            {
                _PointProgression = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyArtifactsDestinyArtifactProfileScoped.PointsAcquired property.
            /// </summary>
            /// <param name="value">PointsAcquired</param>
            public DestinyArtifactsDestinyArtifactProfileScopedBuilder PointsAcquired(int? value)
            {
                _PointsAcquired = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyArtifactsDestinyArtifactProfileScoped.PowerBonusProgression property.
            /// </summary>
            /// <param name="value">PowerBonusProgression</param>
            public DestinyArtifactsDestinyArtifactProfileScopedBuilder PowerBonusProgression(DestinyDestinyProgression value)
            {
                _PowerBonusProgression = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyArtifactsDestinyArtifactProfileScoped.PowerBonus property.
            /// </summary>
            /// <param name="value">PowerBonus</param>
            public DestinyArtifactsDestinyArtifactProfileScopedBuilder PowerBonus(int? value)
            {
                _PowerBonus = value;
                return this;
            }


            /// <summary>
            /// Builds instance of DestinyArtifactsDestinyArtifactProfileScoped.
            /// </summary>
            /// <returns>DestinyArtifactsDestinyArtifactProfileScoped</returns>
            public DestinyArtifactsDestinyArtifactProfileScoped Build()
            {
                Validate();
                return new DestinyArtifactsDestinyArtifactProfileScoped(
                    ArtifactHash: _ArtifactHash,
                    PointProgression: _PointProgression,
                    PointsAcquired: _PointsAcquired,
                    PowerBonusProgression: _PowerBonusProgression,
                    PowerBonus: _PowerBonus
                );
            }

            private void Validate()
            { 
            }
        }

        
    }
}