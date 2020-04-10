using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Sharpility.Extensions;
using NodaTime;

namespace BungieNetApi._Platform.Models
{
    /// <summary>
    /// DestinyHistoricalStatsDestinyHistoricalStatsPerCharacter
    /// </summary>
    public sealed class DestinyHistoricalStatsDestinyHistoricalStatsPerCharacter:  IEquatable<DestinyHistoricalStatsDestinyHistoricalStatsPerCharacter>
    { 
        /// <summary>
        /// CharacterId
        /// </summary>
        public long? CharacterId { get; private set; }

        /// <summary>
        /// Deleted
        /// </summary>
        public bool? Deleted { get; private set; }

        /// <summary>
        /// Results
        /// </summary>
        public Dictionary<string, DestinyHistoricalStatsDestinyHistoricalStatsByPeriod> Results { get; private set; }

        /// <summary>
        /// Merged
        /// </summary>
        public DestinyHistoricalStatsDestinyHistoricalStatsByPeriod Merged { get; private set; }


        /// <summary>
        /// Empty constructor required by some serializers.
        /// Use DestinyHistoricalStatsDestinyHistoricalStatsPerCharacter.Builder() for instance creation instead.
        /// </summary>
        [Obsolete]
        public DestinyHistoricalStatsDestinyHistoricalStatsPerCharacter()
        {
        }

        private DestinyHistoricalStatsDestinyHistoricalStatsPerCharacter(long? CharacterId, bool? Deleted, Dictionary<string, DestinyHistoricalStatsDestinyHistoricalStatsByPeriod> Results, DestinyHistoricalStatsDestinyHistoricalStatsByPeriod Merged)
        {
            
            this.CharacterId = CharacterId;
            
            this.Deleted = Deleted;
            
            this.Results = Results;
            
            this.Merged = Merged;
            
        }

        /// <summary>
        /// Returns builder of DestinyHistoricalStatsDestinyHistoricalStatsPerCharacter.
        /// </summary>
        /// <returns>DestinyHistoricalStatsDestinyHistoricalStatsPerCharacterBuilder</returns>
        public static DestinyHistoricalStatsDestinyHistoricalStatsPerCharacterBuilder Builder()
        {
            return new DestinyHistoricalStatsDestinyHistoricalStatsPerCharacterBuilder();
        }

        /// <summary>
        /// Returns DestinyHistoricalStatsDestinyHistoricalStatsPerCharacterBuilder with properties set.
        /// Use it to change properties.
        /// </summary>
        /// <returns>DestinyHistoricalStatsDestinyHistoricalStatsPerCharacterBuilder</returns>
        public DestinyHistoricalStatsDestinyHistoricalStatsPerCharacterBuilder With()
        {
            return Builder()
                .CharacterId(CharacterId)
                .Deleted(Deleted)
                .Results(Results)
                .Merged(Merged);
        }

        public override string ToString()
        {
            return this.PropertiesToString();
        }

        public override bool Equals(object obj)
        {
            return this.EqualsByProperties(obj);
        }

        public bool Equals(DestinyHistoricalStatsDestinyHistoricalStatsPerCharacter other)
        {
            return Equals((object) other);
        }

        public override int GetHashCode()
        {
            return this.PropertiesHash();
        }

        /// <summary>
        /// Implementation of == operator for (DestinyHistoricalStatsDestinyHistoricalStatsPerCharacter.
        /// </summary>
        /// <param name="left">Compared (DestinyHistoricalStatsDestinyHistoricalStatsPerCharacter</param>
        /// <param name="right">Compared (DestinyHistoricalStatsDestinyHistoricalStatsPerCharacter</param>
        /// <returns>true if compared items are equals, false otherwise</returns>
        public static bool operator == (DestinyHistoricalStatsDestinyHistoricalStatsPerCharacter left, DestinyHistoricalStatsDestinyHistoricalStatsPerCharacter right)
        {
            return Equals(left, right);
        }

        /// <summary>
        /// Implementation of != operator for (DestinyHistoricalStatsDestinyHistoricalStatsPerCharacter.
        /// </summary>
        /// <param name="left">Compared (DestinyHistoricalStatsDestinyHistoricalStatsPerCharacter</param>
        /// <param name="right">Compared (DestinyHistoricalStatsDestinyHistoricalStatsPerCharacter</param>
        /// <returns>true if compared items are not equals, false otherwise</returns>
        public static bool operator != (DestinyHistoricalStatsDestinyHistoricalStatsPerCharacter left, DestinyHistoricalStatsDestinyHistoricalStatsPerCharacter right)
        {
            return !Equals(left, right);
        }

        /// <summary>
        /// Builder of DestinyHistoricalStatsDestinyHistoricalStatsPerCharacter.
        /// </summary>
        public sealed class DestinyHistoricalStatsDestinyHistoricalStatsPerCharacterBuilder
        {
            private long? _CharacterId;
            private bool? _Deleted;
            private Dictionary<string, DestinyHistoricalStatsDestinyHistoricalStatsByPeriod> _Results;
            private DestinyHistoricalStatsDestinyHistoricalStatsByPeriod _Merged;

            internal DestinyHistoricalStatsDestinyHistoricalStatsPerCharacterBuilder()
            {
                SetupDefaults();
            }

            private void SetupDefaults()
            {
            }

            /// <summary>
            /// Sets value for DestinyHistoricalStatsDestinyHistoricalStatsPerCharacter.CharacterId property.
            /// </summary>
            /// <param name="value">CharacterId</param>
            public DestinyHistoricalStatsDestinyHistoricalStatsPerCharacterBuilder CharacterId(long? value)
            {
                _CharacterId = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyHistoricalStatsDestinyHistoricalStatsPerCharacter.Deleted property.
            /// </summary>
            /// <param name="value">Deleted</param>
            public DestinyHistoricalStatsDestinyHistoricalStatsPerCharacterBuilder Deleted(bool? value)
            {
                _Deleted = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyHistoricalStatsDestinyHistoricalStatsPerCharacter.Results property.
            /// </summary>
            /// <param name="value">Results</param>
            public DestinyHistoricalStatsDestinyHistoricalStatsPerCharacterBuilder Results(Dictionary<string, DestinyHistoricalStatsDestinyHistoricalStatsByPeriod> value)
            {
                _Results = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyHistoricalStatsDestinyHistoricalStatsPerCharacter.Merged property.
            /// </summary>
            /// <param name="value">Merged</param>
            public DestinyHistoricalStatsDestinyHistoricalStatsPerCharacterBuilder Merged(DestinyHistoricalStatsDestinyHistoricalStatsByPeriod value)
            {
                _Merged = value;
                return this;
            }


            /// <summary>
            /// Builds instance of DestinyHistoricalStatsDestinyHistoricalStatsPerCharacter.
            /// </summary>
            /// <returns>DestinyHistoricalStatsDestinyHistoricalStatsPerCharacter</returns>
            public DestinyHistoricalStatsDestinyHistoricalStatsPerCharacter Build()
            {
                Validate();
                return new DestinyHistoricalStatsDestinyHistoricalStatsPerCharacter(
                    CharacterId: _CharacterId,
                    Deleted: _Deleted,
                    Results: _Results,
                    Merged: _Merged
                );
            }

            private void Validate()
            { 
            }
        }

        
    }
}