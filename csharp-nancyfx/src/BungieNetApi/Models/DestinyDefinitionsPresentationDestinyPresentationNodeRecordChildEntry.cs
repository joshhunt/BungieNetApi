using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Sharpility.Extensions;
using NodaTime;

namespace BungieNetApi._Platform.Models
{
    /// <summary>
    /// DestinyDefinitionsPresentationDestinyPresentationNodeRecordChildEntry
    /// </summary>
    public sealed class DestinyDefinitionsPresentationDestinyPresentationNodeRecordChildEntry:  IEquatable<DestinyDefinitionsPresentationDestinyPresentationNodeRecordChildEntry>
    { 
        /// <summary>
        /// RecordHash
        /// </summary>
        public int? RecordHash { get; private set; }


        /// <summary>
        /// Empty constructor required by some serializers.
        /// Use DestinyDefinitionsPresentationDestinyPresentationNodeRecordChildEntry.Builder() for instance creation instead.
        /// </summary>
        [Obsolete]
        public DestinyDefinitionsPresentationDestinyPresentationNodeRecordChildEntry()
        {
        }

        private DestinyDefinitionsPresentationDestinyPresentationNodeRecordChildEntry(int? RecordHash)
        {
            
            this.RecordHash = RecordHash;
            
        }

        /// <summary>
        /// Returns builder of DestinyDefinitionsPresentationDestinyPresentationNodeRecordChildEntry.
        /// </summary>
        /// <returns>DestinyDefinitionsPresentationDestinyPresentationNodeRecordChildEntryBuilder</returns>
        public static DestinyDefinitionsPresentationDestinyPresentationNodeRecordChildEntryBuilder Builder()
        {
            return new DestinyDefinitionsPresentationDestinyPresentationNodeRecordChildEntryBuilder();
        }

        /// <summary>
        /// Returns DestinyDefinitionsPresentationDestinyPresentationNodeRecordChildEntryBuilder with properties set.
        /// Use it to change properties.
        /// </summary>
        /// <returns>DestinyDefinitionsPresentationDestinyPresentationNodeRecordChildEntryBuilder</returns>
        public DestinyDefinitionsPresentationDestinyPresentationNodeRecordChildEntryBuilder With()
        {
            return Builder()
                .RecordHash(RecordHash);
        }

        public override string ToString()
        {
            return this.PropertiesToString();
        }

        public override bool Equals(object obj)
        {
            return this.EqualsByProperties(obj);
        }

        public bool Equals(DestinyDefinitionsPresentationDestinyPresentationNodeRecordChildEntry other)
        {
            return Equals((object) other);
        }

        public override int GetHashCode()
        {
            return this.PropertiesHash();
        }

        /// <summary>
        /// Implementation of == operator for (DestinyDefinitionsPresentationDestinyPresentationNodeRecordChildEntry.
        /// </summary>
        /// <param name="left">Compared (DestinyDefinitionsPresentationDestinyPresentationNodeRecordChildEntry</param>
        /// <param name="right">Compared (DestinyDefinitionsPresentationDestinyPresentationNodeRecordChildEntry</param>
        /// <returns>true if compared items are equals, false otherwise</returns>
        public static bool operator == (DestinyDefinitionsPresentationDestinyPresentationNodeRecordChildEntry left, DestinyDefinitionsPresentationDestinyPresentationNodeRecordChildEntry right)
        {
            return Equals(left, right);
        }

        /// <summary>
        /// Implementation of != operator for (DestinyDefinitionsPresentationDestinyPresentationNodeRecordChildEntry.
        /// </summary>
        /// <param name="left">Compared (DestinyDefinitionsPresentationDestinyPresentationNodeRecordChildEntry</param>
        /// <param name="right">Compared (DestinyDefinitionsPresentationDestinyPresentationNodeRecordChildEntry</param>
        /// <returns>true if compared items are not equals, false otherwise</returns>
        public static bool operator != (DestinyDefinitionsPresentationDestinyPresentationNodeRecordChildEntry left, DestinyDefinitionsPresentationDestinyPresentationNodeRecordChildEntry right)
        {
            return !Equals(left, right);
        }

        /// <summary>
        /// Builder of DestinyDefinitionsPresentationDestinyPresentationNodeRecordChildEntry.
        /// </summary>
        public sealed class DestinyDefinitionsPresentationDestinyPresentationNodeRecordChildEntryBuilder
        {
            private int? _RecordHash;

            internal DestinyDefinitionsPresentationDestinyPresentationNodeRecordChildEntryBuilder()
            {
                SetupDefaults();
            }

            private void SetupDefaults()
            {
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsPresentationDestinyPresentationNodeRecordChildEntry.RecordHash property.
            /// </summary>
            /// <param name="value">RecordHash</param>
            public DestinyDefinitionsPresentationDestinyPresentationNodeRecordChildEntryBuilder RecordHash(int? value)
            {
                _RecordHash = value;
                return this;
            }


            /// <summary>
            /// Builds instance of DestinyDefinitionsPresentationDestinyPresentationNodeRecordChildEntry.
            /// </summary>
            /// <returns>DestinyDefinitionsPresentationDestinyPresentationNodeRecordChildEntry</returns>
            public DestinyDefinitionsPresentationDestinyPresentationNodeRecordChildEntry Build()
            {
                Validate();
                return new DestinyDefinitionsPresentationDestinyPresentationNodeRecordChildEntry(
                    RecordHash: _RecordHash
                );
            }

            private void Validate()
            { 
            }
        }

        
    }
}