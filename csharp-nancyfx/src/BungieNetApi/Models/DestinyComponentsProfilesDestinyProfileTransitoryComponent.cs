using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Sharpility.Extensions;
using NodaTime;

namespace BungieNetApi._Platform.Models
{
    /// <summary>
    /// This is an experimental set of data that Bungie considers to be \&quot;transitory\&quot; - information that may be useful for API users, but that is coming from a non-authoritative data source about information that could potentially change at a more frequent pace than Bungie.net will receive updates about it.  This information is provided exclusively for convenience should any of it be useful to users: we provide no guarantees to the accuracy or timeliness of data that comes from this source. Know that this data can potentially be out-of-date or even wrong entirely if the user disconnected from the game or suddenly changed their status before we can receive refreshed data.
    /// </summary>
    public sealed class DestinyComponentsProfilesDestinyProfileTransitoryComponent:  IEquatable<DestinyComponentsProfilesDestinyProfileTransitoryComponent>
    { 
        /// <summary>
        /// If you have any members currently in your party, this is some (very) bare-bones information about those members.
        /// </summary>
        public List<DestinyComponentsProfilesDestinyProfileTransitoryPartyMember> PartyMembers { get; private set; }

        /// <summary>
        /// If you are in an activity, this is some transitory info about the activity currently being played.
        /// </summary>
        public DestinyComponentsProfilesDestinyProfileTransitoryCurrentActivity CurrentActivity { get; private set; }

        /// <summary>
        /// Information about whether and what might prevent you from joining this person on a fireteam.
        /// </summary>
        public DestinyComponentsProfilesDestinyProfileTransitoryJoinability Joinability { get; private set; }

        /// <summary>
        /// Information about tracked entities.
        /// </summary>
        public List<DestinyComponentsProfilesDestinyProfileTransitoryTrackingEntry> Tracking { get; private set; }

        /// <summary>
        /// The hash identifier for the DestinyDestinationDefinition of the last location you were orbiting when in orbit.
        /// </summary>
        public int? LastOrbitedDestinationHash { get; private set; }


        /// <summary>
        /// Empty constructor required by some serializers.
        /// Use DestinyComponentsProfilesDestinyProfileTransitoryComponent.Builder() for instance creation instead.
        /// </summary>
        [Obsolete]
        public DestinyComponentsProfilesDestinyProfileTransitoryComponent()
        {
        }

        private DestinyComponentsProfilesDestinyProfileTransitoryComponent(List<DestinyComponentsProfilesDestinyProfileTransitoryPartyMember> PartyMembers, DestinyComponentsProfilesDestinyProfileTransitoryCurrentActivity CurrentActivity, DestinyComponentsProfilesDestinyProfileTransitoryJoinability Joinability, List<DestinyComponentsProfilesDestinyProfileTransitoryTrackingEntry> Tracking, int? LastOrbitedDestinationHash)
        {
            
            this.PartyMembers = PartyMembers;
            
            this.CurrentActivity = CurrentActivity;
            
            this.Joinability = Joinability;
            
            this.Tracking = Tracking;
            
            this.LastOrbitedDestinationHash = LastOrbitedDestinationHash;
            
        }

        /// <summary>
        /// Returns builder of DestinyComponentsProfilesDestinyProfileTransitoryComponent.
        /// </summary>
        /// <returns>DestinyComponentsProfilesDestinyProfileTransitoryComponentBuilder</returns>
        public static DestinyComponentsProfilesDestinyProfileTransitoryComponentBuilder Builder()
        {
            return new DestinyComponentsProfilesDestinyProfileTransitoryComponentBuilder();
        }

        /// <summary>
        /// Returns DestinyComponentsProfilesDestinyProfileTransitoryComponentBuilder with properties set.
        /// Use it to change properties.
        /// </summary>
        /// <returns>DestinyComponentsProfilesDestinyProfileTransitoryComponentBuilder</returns>
        public DestinyComponentsProfilesDestinyProfileTransitoryComponentBuilder With()
        {
            return Builder()
                .PartyMembers(PartyMembers)
                .CurrentActivity(CurrentActivity)
                .Joinability(Joinability)
                .Tracking(Tracking)
                .LastOrbitedDestinationHash(LastOrbitedDestinationHash);
        }

        public override string ToString()
        {
            return this.PropertiesToString();
        }

        public override bool Equals(object obj)
        {
            return this.EqualsByProperties(obj);
        }

        public bool Equals(DestinyComponentsProfilesDestinyProfileTransitoryComponent other)
        {
            return Equals((object) other);
        }

        public override int GetHashCode()
        {
            return this.PropertiesHash();
        }

        /// <summary>
        /// Implementation of == operator for (DestinyComponentsProfilesDestinyProfileTransitoryComponent.
        /// </summary>
        /// <param name="left">Compared (DestinyComponentsProfilesDestinyProfileTransitoryComponent</param>
        /// <param name="right">Compared (DestinyComponentsProfilesDestinyProfileTransitoryComponent</param>
        /// <returns>true if compared items are equals, false otherwise</returns>
        public static bool operator == (DestinyComponentsProfilesDestinyProfileTransitoryComponent left, DestinyComponentsProfilesDestinyProfileTransitoryComponent right)
        {
            return Equals(left, right);
        }

        /// <summary>
        /// Implementation of != operator for (DestinyComponentsProfilesDestinyProfileTransitoryComponent.
        /// </summary>
        /// <param name="left">Compared (DestinyComponentsProfilesDestinyProfileTransitoryComponent</param>
        /// <param name="right">Compared (DestinyComponentsProfilesDestinyProfileTransitoryComponent</param>
        /// <returns>true if compared items are not equals, false otherwise</returns>
        public static bool operator != (DestinyComponentsProfilesDestinyProfileTransitoryComponent left, DestinyComponentsProfilesDestinyProfileTransitoryComponent right)
        {
            return !Equals(left, right);
        }

        /// <summary>
        /// Builder of DestinyComponentsProfilesDestinyProfileTransitoryComponent.
        /// </summary>
        public sealed class DestinyComponentsProfilesDestinyProfileTransitoryComponentBuilder
        {
            private List<DestinyComponentsProfilesDestinyProfileTransitoryPartyMember> _PartyMembers;
            private DestinyComponentsProfilesDestinyProfileTransitoryCurrentActivity _CurrentActivity;
            private DestinyComponentsProfilesDestinyProfileTransitoryJoinability _Joinability;
            private List<DestinyComponentsProfilesDestinyProfileTransitoryTrackingEntry> _Tracking;
            private int? _LastOrbitedDestinationHash;

            internal DestinyComponentsProfilesDestinyProfileTransitoryComponentBuilder()
            {
                SetupDefaults();
            }

            private void SetupDefaults()
            {
            }

            /// <summary>
            /// Sets value for DestinyComponentsProfilesDestinyProfileTransitoryComponent.PartyMembers property.
            /// </summary>
            /// <param name="value">If you have any members currently in your party, this is some (very) bare-bones information about those members.</param>
            public DestinyComponentsProfilesDestinyProfileTransitoryComponentBuilder PartyMembers(List<DestinyComponentsProfilesDestinyProfileTransitoryPartyMember> value)
            {
                _PartyMembers = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyComponentsProfilesDestinyProfileTransitoryComponent.CurrentActivity property.
            /// </summary>
            /// <param name="value">If you are in an activity, this is some transitory info about the activity currently being played.</param>
            public DestinyComponentsProfilesDestinyProfileTransitoryComponentBuilder CurrentActivity(DestinyComponentsProfilesDestinyProfileTransitoryCurrentActivity value)
            {
                _CurrentActivity = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyComponentsProfilesDestinyProfileTransitoryComponent.Joinability property.
            /// </summary>
            /// <param name="value">Information about whether and what might prevent you from joining this person on a fireteam.</param>
            public DestinyComponentsProfilesDestinyProfileTransitoryComponentBuilder Joinability(DestinyComponentsProfilesDestinyProfileTransitoryJoinability value)
            {
                _Joinability = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyComponentsProfilesDestinyProfileTransitoryComponent.Tracking property.
            /// </summary>
            /// <param name="value">Information about tracked entities.</param>
            public DestinyComponentsProfilesDestinyProfileTransitoryComponentBuilder Tracking(List<DestinyComponentsProfilesDestinyProfileTransitoryTrackingEntry> value)
            {
                _Tracking = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyComponentsProfilesDestinyProfileTransitoryComponent.LastOrbitedDestinationHash property.
            /// </summary>
            /// <param name="value">The hash identifier for the DestinyDestinationDefinition of the last location you were orbiting when in orbit.</param>
            public DestinyComponentsProfilesDestinyProfileTransitoryComponentBuilder LastOrbitedDestinationHash(int? value)
            {
                _LastOrbitedDestinationHash = value;
                return this;
            }


            /// <summary>
            /// Builds instance of DestinyComponentsProfilesDestinyProfileTransitoryComponent.
            /// </summary>
            /// <returns>DestinyComponentsProfilesDestinyProfileTransitoryComponent</returns>
            public DestinyComponentsProfilesDestinyProfileTransitoryComponent Build()
            {
                Validate();
                return new DestinyComponentsProfilesDestinyProfileTransitoryComponent(
                    PartyMembers: _PartyMembers,
                    CurrentActivity: _CurrentActivity,
                    Joinability: _Joinability,
                    Tracking: _Tracking,
                    LastOrbitedDestinationHash: _LastOrbitedDestinationHash
                );
            }

            private void Validate()
            { 
            }
        }

        
    }
}