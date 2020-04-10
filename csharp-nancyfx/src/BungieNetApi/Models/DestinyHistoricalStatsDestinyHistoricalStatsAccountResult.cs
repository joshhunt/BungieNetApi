using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Sharpility.Extensions;
using NodaTime;

namespace BungieNetApi._Platform.Models
{
    /// <summary>
    /// DestinyHistoricalStatsDestinyHistoricalStatsAccountResult
    /// </summary>
    public sealed class DestinyHistoricalStatsDestinyHistoricalStatsAccountResult:  IEquatable<DestinyHistoricalStatsDestinyHistoricalStatsAccountResult>
    { 
        /// <summary>
        /// MergedDeletedCharacters
        /// </summary>
        public DestinyHistoricalStatsDestinyHistoricalStatsWithMerged MergedDeletedCharacters { get; private set; }

        /// <summary>
        /// MergedAllCharacters
        /// </summary>
        public DestinyHistoricalStatsDestinyHistoricalStatsWithMerged MergedAllCharacters { get; private set; }

        /// <summary>
        /// Characters
        /// </summary>
        public List<DestinyHistoricalStatsDestinyHistoricalStatsPerCharacter> Characters { get; private set; }


        /// <summary>
        /// Empty constructor required by some serializers.
        /// Use DestinyHistoricalStatsDestinyHistoricalStatsAccountResult.Builder() for instance creation instead.
        /// </summary>
        [Obsolete]
        public DestinyHistoricalStatsDestinyHistoricalStatsAccountResult()
        {
        }

        private DestinyHistoricalStatsDestinyHistoricalStatsAccountResult(DestinyHistoricalStatsDestinyHistoricalStatsWithMerged MergedDeletedCharacters, DestinyHistoricalStatsDestinyHistoricalStatsWithMerged MergedAllCharacters, List<DestinyHistoricalStatsDestinyHistoricalStatsPerCharacter> Characters)
        {
            
            this.MergedDeletedCharacters = MergedDeletedCharacters;
            
            this.MergedAllCharacters = MergedAllCharacters;
            
            this.Characters = Characters;
            
        }

        /// <summary>
        /// Returns builder of DestinyHistoricalStatsDestinyHistoricalStatsAccountResult.
        /// </summary>
        /// <returns>DestinyHistoricalStatsDestinyHistoricalStatsAccountResultBuilder</returns>
        public static DestinyHistoricalStatsDestinyHistoricalStatsAccountResultBuilder Builder()
        {
            return new DestinyHistoricalStatsDestinyHistoricalStatsAccountResultBuilder();
        }

        /// <summary>
        /// Returns DestinyHistoricalStatsDestinyHistoricalStatsAccountResultBuilder with properties set.
        /// Use it to change properties.
        /// </summary>
        /// <returns>DestinyHistoricalStatsDestinyHistoricalStatsAccountResultBuilder</returns>
        public DestinyHistoricalStatsDestinyHistoricalStatsAccountResultBuilder With()
        {
            return Builder()
                .MergedDeletedCharacters(MergedDeletedCharacters)
                .MergedAllCharacters(MergedAllCharacters)
                .Characters(Characters);
        }

        public override string ToString()
        {
            return this.PropertiesToString();
        }

        public override bool Equals(object obj)
        {
            return this.EqualsByProperties(obj);
        }

        public bool Equals(DestinyHistoricalStatsDestinyHistoricalStatsAccountResult other)
        {
            return Equals((object) other);
        }

        public override int GetHashCode()
        {
            return this.PropertiesHash();
        }

        /// <summary>
        /// Implementation of == operator for (DestinyHistoricalStatsDestinyHistoricalStatsAccountResult.
        /// </summary>
        /// <param name="left">Compared (DestinyHistoricalStatsDestinyHistoricalStatsAccountResult</param>
        /// <param name="right">Compared (DestinyHistoricalStatsDestinyHistoricalStatsAccountResult</param>
        /// <returns>true if compared items are equals, false otherwise</returns>
        public static bool operator == (DestinyHistoricalStatsDestinyHistoricalStatsAccountResult left, DestinyHistoricalStatsDestinyHistoricalStatsAccountResult right)
        {
            return Equals(left, right);
        }

        /// <summary>
        /// Implementation of != operator for (DestinyHistoricalStatsDestinyHistoricalStatsAccountResult.
        /// </summary>
        /// <param name="left">Compared (DestinyHistoricalStatsDestinyHistoricalStatsAccountResult</param>
        /// <param name="right">Compared (DestinyHistoricalStatsDestinyHistoricalStatsAccountResult</param>
        /// <returns>true if compared items are not equals, false otherwise</returns>
        public static bool operator != (DestinyHistoricalStatsDestinyHistoricalStatsAccountResult left, DestinyHistoricalStatsDestinyHistoricalStatsAccountResult right)
        {
            return !Equals(left, right);
        }

        /// <summary>
        /// Builder of DestinyHistoricalStatsDestinyHistoricalStatsAccountResult.
        /// </summary>
        public sealed class DestinyHistoricalStatsDestinyHistoricalStatsAccountResultBuilder
        {
            private DestinyHistoricalStatsDestinyHistoricalStatsWithMerged _MergedDeletedCharacters;
            private DestinyHistoricalStatsDestinyHistoricalStatsWithMerged _MergedAllCharacters;
            private List<DestinyHistoricalStatsDestinyHistoricalStatsPerCharacter> _Characters;

            internal DestinyHistoricalStatsDestinyHistoricalStatsAccountResultBuilder()
            {
                SetupDefaults();
            }

            private void SetupDefaults()
            {
            }

            /// <summary>
            /// Sets value for DestinyHistoricalStatsDestinyHistoricalStatsAccountResult.MergedDeletedCharacters property.
            /// </summary>
            /// <param name="value">MergedDeletedCharacters</param>
            public DestinyHistoricalStatsDestinyHistoricalStatsAccountResultBuilder MergedDeletedCharacters(DestinyHistoricalStatsDestinyHistoricalStatsWithMerged value)
            {
                _MergedDeletedCharacters = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyHistoricalStatsDestinyHistoricalStatsAccountResult.MergedAllCharacters property.
            /// </summary>
            /// <param name="value">MergedAllCharacters</param>
            public DestinyHistoricalStatsDestinyHistoricalStatsAccountResultBuilder MergedAllCharacters(DestinyHistoricalStatsDestinyHistoricalStatsWithMerged value)
            {
                _MergedAllCharacters = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyHistoricalStatsDestinyHistoricalStatsAccountResult.Characters property.
            /// </summary>
            /// <param name="value">Characters</param>
            public DestinyHistoricalStatsDestinyHistoricalStatsAccountResultBuilder Characters(List<DestinyHistoricalStatsDestinyHistoricalStatsPerCharacter> value)
            {
                _Characters = value;
                return this;
            }


            /// <summary>
            /// Builds instance of DestinyHistoricalStatsDestinyHistoricalStatsAccountResult.
            /// </summary>
            /// <returns>DestinyHistoricalStatsDestinyHistoricalStatsAccountResult</returns>
            public DestinyHistoricalStatsDestinyHistoricalStatsAccountResult Build()
            {
                Validate();
                return new DestinyHistoricalStatsDestinyHistoricalStatsAccountResult(
                    MergedDeletedCharacters: _MergedDeletedCharacters,
                    MergedAllCharacters: _MergedAllCharacters,
                    Characters: _Characters
                );
            }

            private void Validate()
            { 
            }
        }

        
    }
}