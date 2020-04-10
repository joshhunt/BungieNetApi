using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Sharpility.Extensions;
using NodaTime;

namespace BungieNetApi._Platform.Models
{
    /// <summary>
    /// DestinyDefinitionsMilestonesDestinyMilestoneChallengeActivityGraphNodeEntry
    /// </summary>
    public sealed class DestinyDefinitionsMilestonesDestinyMilestoneChallengeActivityGraphNodeEntry:  IEquatable<DestinyDefinitionsMilestonesDestinyMilestoneChallengeActivityGraphNodeEntry>
    { 
        /// <summary>
        /// ActivityGraphHash
        /// </summary>
        public int? ActivityGraphHash { get; private set; }

        /// <summary>
        /// ActivityGraphNodeHash
        /// </summary>
        public int? ActivityGraphNodeHash { get; private set; }


        /// <summary>
        /// Empty constructor required by some serializers.
        /// Use DestinyDefinitionsMilestonesDestinyMilestoneChallengeActivityGraphNodeEntry.Builder() for instance creation instead.
        /// </summary>
        [Obsolete]
        public DestinyDefinitionsMilestonesDestinyMilestoneChallengeActivityGraphNodeEntry()
        {
        }

        private DestinyDefinitionsMilestonesDestinyMilestoneChallengeActivityGraphNodeEntry(int? ActivityGraphHash, int? ActivityGraphNodeHash)
        {
            
            this.ActivityGraphHash = ActivityGraphHash;
            
            this.ActivityGraphNodeHash = ActivityGraphNodeHash;
            
        }

        /// <summary>
        /// Returns builder of DestinyDefinitionsMilestonesDestinyMilestoneChallengeActivityGraphNodeEntry.
        /// </summary>
        /// <returns>DestinyDefinitionsMilestonesDestinyMilestoneChallengeActivityGraphNodeEntryBuilder</returns>
        public static DestinyDefinitionsMilestonesDestinyMilestoneChallengeActivityGraphNodeEntryBuilder Builder()
        {
            return new DestinyDefinitionsMilestonesDestinyMilestoneChallengeActivityGraphNodeEntryBuilder();
        }

        /// <summary>
        /// Returns DestinyDefinitionsMilestonesDestinyMilestoneChallengeActivityGraphNodeEntryBuilder with properties set.
        /// Use it to change properties.
        /// </summary>
        /// <returns>DestinyDefinitionsMilestonesDestinyMilestoneChallengeActivityGraphNodeEntryBuilder</returns>
        public DestinyDefinitionsMilestonesDestinyMilestoneChallengeActivityGraphNodeEntryBuilder With()
        {
            return Builder()
                .ActivityGraphHash(ActivityGraphHash)
                .ActivityGraphNodeHash(ActivityGraphNodeHash);
        }

        public override string ToString()
        {
            return this.PropertiesToString();
        }

        public override bool Equals(object obj)
        {
            return this.EqualsByProperties(obj);
        }

        public bool Equals(DestinyDefinitionsMilestonesDestinyMilestoneChallengeActivityGraphNodeEntry other)
        {
            return Equals((object) other);
        }

        public override int GetHashCode()
        {
            return this.PropertiesHash();
        }

        /// <summary>
        /// Implementation of == operator for (DestinyDefinitionsMilestonesDestinyMilestoneChallengeActivityGraphNodeEntry.
        /// </summary>
        /// <param name="left">Compared (DestinyDefinitionsMilestonesDestinyMilestoneChallengeActivityGraphNodeEntry</param>
        /// <param name="right">Compared (DestinyDefinitionsMilestonesDestinyMilestoneChallengeActivityGraphNodeEntry</param>
        /// <returns>true if compared items are equals, false otherwise</returns>
        public static bool operator == (DestinyDefinitionsMilestonesDestinyMilestoneChallengeActivityGraphNodeEntry left, DestinyDefinitionsMilestonesDestinyMilestoneChallengeActivityGraphNodeEntry right)
        {
            return Equals(left, right);
        }

        /// <summary>
        /// Implementation of != operator for (DestinyDefinitionsMilestonesDestinyMilestoneChallengeActivityGraphNodeEntry.
        /// </summary>
        /// <param name="left">Compared (DestinyDefinitionsMilestonesDestinyMilestoneChallengeActivityGraphNodeEntry</param>
        /// <param name="right">Compared (DestinyDefinitionsMilestonesDestinyMilestoneChallengeActivityGraphNodeEntry</param>
        /// <returns>true if compared items are not equals, false otherwise</returns>
        public static bool operator != (DestinyDefinitionsMilestonesDestinyMilestoneChallengeActivityGraphNodeEntry left, DestinyDefinitionsMilestonesDestinyMilestoneChallengeActivityGraphNodeEntry right)
        {
            return !Equals(left, right);
        }

        /// <summary>
        /// Builder of DestinyDefinitionsMilestonesDestinyMilestoneChallengeActivityGraphNodeEntry.
        /// </summary>
        public sealed class DestinyDefinitionsMilestonesDestinyMilestoneChallengeActivityGraphNodeEntryBuilder
        {
            private int? _ActivityGraphHash;
            private int? _ActivityGraphNodeHash;

            internal DestinyDefinitionsMilestonesDestinyMilestoneChallengeActivityGraphNodeEntryBuilder()
            {
                SetupDefaults();
            }

            private void SetupDefaults()
            {
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsMilestonesDestinyMilestoneChallengeActivityGraphNodeEntry.ActivityGraphHash property.
            /// </summary>
            /// <param name="value">ActivityGraphHash</param>
            public DestinyDefinitionsMilestonesDestinyMilestoneChallengeActivityGraphNodeEntryBuilder ActivityGraphHash(int? value)
            {
                _ActivityGraphHash = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsMilestonesDestinyMilestoneChallengeActivityGraphNodeEntry.ActivityGraphNodeHash property.
            /// </summary>
            /// <param name="value">ActivityGraphNodeHash</param>
            public DestinyDefinitionsMilestonesDestinyMilestoneChallengeActivityGraphNodeEntryBuilder ActivityGraphNodeHash(int? value)
            {
                _ActivityGraphNodeHash = value;
                return this;
            }


            /// <summary>
            /// Builds instance of DestinyDefinitionsMilestonesDestinyMilestoneChallengeActivityGraphNodeEntry.
            /// </summary>
            /// <returns>DestinyDefinitionsMilestonesDestinyMilestoneChallengeActivityGraphNodeEntry</returns>
            public DestinyDefinitionsMilestonesDestinyMilestoneChallengeActivityGraphNodeEntry Build()
            {
                Validate();
                return new DestinyDefinitionsMilestonesDestinyMilestoneChallengeActivityGraphNodeEntry(
                    ActivityGraphHash: _ActivityGraphHash,
                    ActivityGraphNodeHash: _ActivityGraphNodeHash
                );
            }

            private void Validate()
            { 
            }
        }

        
    }
}