using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Sharpility.Extensions;
using NodaTime;

namespace BungieNetApi._Platform.Models
{
    /// <summary>
    /// This represents a single \&quot;thing\&quot; being tracked by the player.  This can point to many types of entities, but only a subset of them will actually have a valid hash identifier for whatever it is being pointed to.  It&#39;s up to you to interpret what it means when various combinations of these entries have values being tracked.
    /// </summary>
    public sealed class DestinyComponentsProfilesDestinyProfileTransitoryTrackingEntry:  IEquatable<DestinyComponentsProfilesDestinyProfileTransitoryTrackingEntry>
    { 
        /// <summary>
        /// OPTIONAL - If this is tracking a DestinyLocationDefinition, this is the identifier for that location.
        /// </summary>
        public int? LocationHash { get; private set; }

        /// <summary>
        /// OPTIONAL - If this is tracking the status of a DestinyInventoryItemDefinition, this is the identifier for that item.
        /// </summary>
        public int? ItemHash { get; private set; }

        /// <summary>
        /// OPTIONAL - If this is tracking the status of a DestinyObjectiveDefinition, this is the identifier for that objective.
        /// </summary>
        public int? ObjectiveHash { get; private set; }

        /// <summary>
        /// OPTIONAL - If this is tracking the status of a DestinyActivityDefinition, this is the identifier for that activity.
        /// </summary>
        public int? ActivityHash { get; private set; }

        /// <summary>
        /// OPTIONAL - If this is tracking the status of a quest, this is the identifier for the DestinyInventoryItemDefinition that containst that questline data.
        /// </summary>
        public int? QuestlineItemHash { get; private set; }

        /// <summary>
        /// OPTIONAL - I&#39;ve got to level with you, I don&#39;t really know what this is. Is it when you started tracking it? Is it only populated for tracked items that have time limits?  I don&#39;t know, but we can get at it - when I get time to actually test what it is, I&#39;ll update this. In the meantime, bask in the mysterious data.
        /// </summary>
        public DateTime? TrackedDate { get; private set; }


        /// <summary>
        /// Empty constructor required by some serializers.
        /// Use DestinyComponentsProfilesDestinyProfileTransitoryTrackingEntry.Builder() for instance creation instead.
        /// </summary>
        [Obsolete]
        public DestinyComponentsProfilesDestinyProfileTransitoryTrackingEntry()
        {
        }

        private DestinyComponentsProfilesDestinyProfileTransitoryTrackingEntry(int? LocationHash, int? ItemHash, int? ObjectiveHash, int? ActivityHash, int? QuestlineItemHash, DateTime? TrackedDate)
        {
            
            this.LocationHash = LocationHash;
            
            this.ItemHash = ItemHash;
            
            this.ObjectiveHash = ObjectiveHash;
            
            this.ActivityHash = ActivityHash;
            
            this.QuestlineItemHash = QuestlineItemHash;
            
            this.TrackedDate = TrackedDate;
            
        }

        /// <summary>
        /// Returns builder of DestinyComponentsProfilesDestinyProfileTransitoryTrackingEntry.
        /// </summary>
        /// <returns>DestinyComponentsProfilesDestinyProfileTransitoryTrackingEntryBuilder</returns>
        public static DestinyComponentsProfilesDestinyProfileTransitoryTrackingEntryBuilder Builder()
        {
            return new DestinyComponentsProfilesDestinyProfileTransitoryTrackingEntryBuilder();
        }

        /// <summary>
        /// Returns DestinyComponentsProfilesDestinyProfileTransitoryTrackingEntryBuilder with properties set.
        /// Use it to change properties.
        /// </summary>
        /// <returns>DestinyComponentsProfilesDestinyProfileTransitoryTrackingEntryBuilder</returns>
        public DestinyComponentsProfilesDestinyProfileTransitoryTrackingEntryBuilder With()
        {
            return Builder()
                .LocationHash(LocationHash)
                .ItemHash(ItemHash)
                .ObjectiveHash(ObjectiveHash)
                .ActivityHash(ActivityHash)
                .QuestlineItemHash(QuestlineItemHash)
                .TrackedDate(TrackedDate);
        }

        public override string ToString()
        {
            return this.PropertiesToString();
        }

        public override bool Equals(object obj)
        {
            return this.EqualsByProperties(obj);
        }

        public bool Equals(DestinyComponentsProfilesDestinyProfileTransitoryTrackingEntry other)
        {
            return Equals((object) other);
        }

        public override int GetHashCode()
        {
            return this.PropertiesHash();
        }

        /// <summary>
        /// Implementation of == operator for (DestinyComponentsProfilesDestinyProfileTransitoryTrackingEntry.
        /// </summary>
        /// <param name="left">Compared (DestinyComponentsProfilesDestinyProfileTransitoryTrackingEntry</param>
        /// <param name="right">Compared (DestinyComponentsProfilesDestinyProfileTransitoryTrackingEntry</param>
        /// <returns>true if compared items are equals, false otherwise</returns>
        public static bool operator == (DestinyComponentsProfilesDestinyProfileTransitoryTrackingEntry left, DestinyComponentsProfilesDestinyProfileTransitoryTrackingEntry right)
        {
            return Equals(left, right);
        }

        /// <summary>
        /// Implementation of != operator for (DestinyComponentsProfilesDestinyProfileTransitoryTrackingEntry.
        /// </summary>
        /// <param name="left">Compared (DestinyComponentsProfilesDestinyProfileTransitoryTrackingEntry</param>
        /// <param name="right">Compared (DestinyComponentsProfilesDestinyProfileTransitoryTrackingEntry</param>
        /// <returns>true if compared items are not equals, false otherwise</returns>
        public static bool operator != (DestinyComponentsProfilesDestinyProfileTransitoryTrackingEntry left, DestinyComponentsProfilesDestinyProfileTransitoryTrackingEntry right)
        {
            return !Equals(left, right);
        }

        /// <summary>
        /// Builder of DestinyComponentsProfilesDestinyProfileTransitoryTrackingEntry.
        /// </summary>
        public sealed class DestinyComponentsProfilesDestinyProfileTransitoryTrackingEntryBuilder
        {
            private int? _LocationHash;
            private int? _ItemHash;
            private int? _ObjectiveHash;
            private int? _ActivityHash;
            private int? _QuestlineItemHash;
            private DateTime? _TrackedDate;

            internal DestinyComponentsProfilesDestinyProfileTransitoryTrackingEntryBuilder()
            {
                SetupDefaults();
            }

            private void SetupDefaults()
            {
            }

            /// <summary>
            /// Sets value for DestinyComponentsProfilesDestinyProfileTransitoryTrackingEntry.LocationHash property.
            /// </summary>
            /// <param name="value">OPTIONAL - If this is tracking a DestinyLocationDefinition, this is the identifier for that location.</param>
            public DestinyComponentsProfilesDestinyProfileTransitoryTrackingEntryBuilder LocationHash(int? value)
            {
                _LocationHash = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyComponentsProfilesDestinyProfileTransitoryTrackingEntry.ItemHash property.
            /// </summary>
            /// <param name="value">OPTIONAL - If this is tracking the status of a DestinyInventoryItemDefinition, this is the identifier for that item.</param>
            public DestinyComponentsProfilesDestinyProfileTransitoryTrackingEntryBuilder ItemHash(int? value)
            {
                _ItemHash = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyComponentsProfilesDestinyProfileTransitoryTrackingEntry.ObjectiveHash property.
            /// </summary>
            /// <param name="value">OPTIONAL - If this is tracking the status of a DestinyObjectiveDefinition, this is the identifier for that objective.</param>
            public DestinyComponentsProfilesDestinyProfileTransitoryTrackingEntryBuilder ObjectiveHash(int? value)
            {
                _ObjectiveHash = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyComponentsProfilesDestinyProfileTransitoryTrackingEntry.ActivityHash property.
            /// </summary>
            /// <param name="value">OPTIONAL - If this is tracking the status of a DestinyActivityDefinition, this is the identifier for that activity.</param>
            public DestinyComponentsProfilesDestinyProfileTransitoryTrackingEntryBuilder ActivityHash(int? value)
            {
                _ActivityHash = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyComponentsProfilesDestinyProfileTransitoryTrackingEntry.QuestlineItemHash property.
            /// </summary>
            /// <param name="value">OPTIONAL - If this is tracking the status of a quest, this is the identifier for the DestinyInventoryItemDefinition that containst that questline data.</param>
            public DestinyComponentsProfilesDestinyProfileTransitoryTrackingEntryBuilder QuestlineItemHash(int? value)
            {
                _QuestlineItemHash = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyComponentsProfilesDestinyProfileTransitoryTrackingEntry.TrackedDate property.
            /// </summary>
            /// <param name="value">OPTIONAL - I&#39;ve got to level with you, I don&#39;t really know what this is. Is it when you started tracking it? Is it only populated for tracked items that have time limits?  I don&#39;t know, but we can get at it - when I get time to actually test what it is, I&#39;ll update this. In the meantime, bask in the mysterious data.</param>
            public DestinyComponentsProfilesDestinyProfileTransitoryTrackingEntryBuilder TrackedDate(DateTime? value)
            {
                _TrackedDate = value;
                return this;
            }


            /// <summary>
            /// Builds instance of DestinyComponentsProfilesDestinyProfileTransitoryTrackingEntry.
            /// </summary>
            /// <returns>DestinyComponentsProfilesDestinyProfileTransitoryTrackingEntry</returns>
            public DestinyComponentsProfilesDestinyProfileTransitoryTrackingEntry Build()
            {
                Validate();
                return new DestinyComponentsProfilesDestinyProfileTransitoryTrackingEntry(
                    LocationHash: _LocationHash,
                    ItemHash: _ItemHash,
                    ObjectiveHash: _ObjectiveHash,
                    ActivityHash: _ActivityHash,
                    QuestlineItemHash: _QuestlineItemHash,
                    TrackedDate: _TrackedDate
                );
            }

            private void Validate()
            { 
            }
        }

        
    }
}