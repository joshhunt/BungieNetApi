using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Sharpility.Extensions;
using NodaTime;

namespace BungieNetApi._Platform.Models
{
    /// <summary>
    /// This is some bare minimum information about a party member in a Fireteam. Unfortunately, without great computational expense on our side we can only get at the data contained here. I&#39;d like to give you a character ID for example, but we don&#39;t have it. But we do have these three pieces of information. May they help you on your quest to show meaningful data about current Fireteams.  Notably, we don&#39;t and can&#39;t feasibly return info on characters. If you can, try to use just the data below for your UI and purposes. Only hit us with further queries if you absolutely must know the character ID of the currently playing character. Pretty please with sugar on top.
    /// </summary>
    public sealed class DestinyComponentsProfilesDestinyProfileTransitoryPartyMember:  IEquatable<DestinyComponentsProfilesDestinyProfileTransitoryPartyMember>
    { 
        /// <summary>
        /// The Membership ID that matches the party member.
        /// </summary>
        public long? MembershipId { get; private set; }

        /// <summary>
        /// The identifier for the DestinyInventoryItemDefinition of the player&#39;s emblem.
        /// </summary>
        public int? EmblemHash { get; private set; }

        /// <summary>
        /// The player&#39;s last known display name.
        /// </summary>
        public string DisplayName { get; private set; }

        /// <summary>
        /// A Flags Enumeration value indicating the states that the player is in relevant to being on a fireteam.
        /// </summary>
        public int? Status { get; private set; }


        /// <summary>
        /// Empty constructor required by some serializers.
        /// Use DestinyComponentsProfilesDestinyProfileTransitoryPartyMember.Builder() for instance creation instead.
        /// </summary>
        [Obsolete]
        public DestinyComponentsProfilesDestinyProfileTransitoryPartyMember()
        {
        }

        private DestinyComponentsProfilesDestinyProfileTransitoryPartyMember(long? MembershipId, int? EmblemHash, string DisplayName, int? Status)
        {
            
            this.MembershipId = MembershipId;
            
            this.EmblemHash = EmblemHash;
            
            this.DisplayName = DisplayName;
            
            this.Status = Status;
            
        }

        /// <summary>
        /// Returns builder of DestinyComponentsProfilesDestinyProfileTransitoryPartyMember.
        /// </summary>
        /// <returns>DestinyComponentsProfilesDestinyProfileTransitoryPartyMemberBuilder</returns>
        public static DestinyComponentsProfilesDestinyProfileTransitoryPartyMemberBuilder Builder()
        {
            return new DestinyComponentsProfilesDestinyProfileTransitoryPartyMemberBuilder();
        }

        /// <summary>
        /// Returns DestinyComponentsProfilesDestinyProfileTransitoryPartyMemberBuilder with properties set.
        /// Use it to change properties.
        /// </summary>
        /// <returns>DestinyComponentsProfilesDestinyProfileTransitoryPartyMemberBuilder</returns>
        public DestinyComponentsProfilesDestinyProfileTransitoryPartyMemberBuilder With()
        {
            return Builder()
                .MembershipId(MembershipId)
                .EmblemHash(EmblemHash)
                .DisplayName(DisplayName)
                .Status(Status);
        }

        public override string ToString()
        {
            return this.PropertiesToString();
        }

        public override bool Equals(object obj)
        {
            return this.EqualsByProperties(obj);
        }

        public bool Equals(DestinyComponentsProfilesDestinyProfileTransitoryPartyMember other)
        {
            return Equals((object) other);
        }

        public override int GetHashCode()
        {
            return this.PropertiesHash();
        }

        /// <summary>
        /// Implementation of == operator for (DestinyComponentsProfilesDestinyProfileTransitoryPartyMember.
        /// </summary>
        /// <param name="left">Compared (DestinyComponentsProfilesDestinyProfileTransitoryPartyMember</param>
        /// <param name="right">Compared (DestinyComponentsProfilesDestinyProfileTransitoryPartyMember</param>
        /// <returns>true if compared items are equals, false otherwise</returns>
        public static bool operator == (DestinyComponentsProfilesDestinyProfileTransitoryPartyMember left, DestinyComponentsProfilesDestinyProfileTransitoryPartyMember right)
        {
            return Equals(left, right);
        }

        /// <summary>
        /// Implementation of != operator for (DestinyComponentsProfilesDestinyProfileTransitoryPartyMember.
        /// </summary>
        /// <param name="left">Compared (DestinyComponentsProfilesDestinyProfileTransitoryPartyMember</param>
        /// <param name="right">Compared (DestinyComponentsProfilesDestinyProfileTransitoryPartyMember</param>
        /// <returns>true if compared items are not equals, false otherwise</returns>
        public static bool operator != (DestinyComponentsProfilesDestinyProfileTransitoryPartyMember left, DestinyComponentsProfilesDestinyProfileTransitoryPartyMember right)
        {
            return !Equals(left, right);
        }

        /// <summary>
        /// Builder of DestinyComponentsProfilesDestinyProfileTransitoryPartyMember.
        /// </summary>
        public sealed class DestinyComponentsProfilesDestinyProfileTransitoryPartyMemberBuilder
        {
            private long? _MembershipId;
            private int? _EmblemHash;
            private string _DisplayName;
            private int? _Status;

            internal DestinyComponentsProfilesDestinyProfileTransitoryPartyMemberBuilder()
            {
                SetupDefaults();
            }

            private void SetupDefaults()
            {
            }

            /// <summary>
            /// Sets value for DestinyComponentsProfilesDestinyProfileTransitoryPartyMember.MembershipId property.
            /// </summary>
            /// <param name="value">The Membership ID that matches the party member.</param>
            public DestinyComponentsProfilesDestinyProfileTransitoryPartyMemberBuilder MembershipId(long? value)
            {
                _MembershipId = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyComponentsProfilesDestinyProfileTransitoryPartyMember.EmblemHash property.
            /// </summary>
            /// <param name="value">The identifier for the DestinyInventoryItemDefinition of the player&#39;s emblem.</param>
            public DestinyComponentsProfilesDestinyProfileTransitoryPartyMemberBuilder EmblemHash(int? value)
            {
                _EmblemHash = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyComponentsProfilesDestinyProfileTransitoryPartyMember.DisplayName property.
            /// </summary>
            /// <param name="value">The player&#39;s last known display name.</param>
            public DestinyComponentsProfilesDestinyProfileTransitoryPartyMemberBuilder DisplayName(string value)
            {
                _DisplayName = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyComponentsProfilesDestinyProfileTransitoryPartyMember.Status property.
            /// </summary>
            /// <param name="value">A Flags Enumeration value indicating the states that the player is in relevant to being on a fireteam.</param>
            public DestinyComponentsProfilesDestinyProfileTransitoryPartyMemberBuilder Status(int? value)
            {
                _Status = value;
                return this;
            }


            /// <summary>
            /// Builds instance of DestinyComponentsProfilesDestinyProfileTransitoryPartyMember.
            /// </summary>
            /// <returns>DestinyComponentsProfilesDestinyProfileTransitoryPartyMember</returns>
            public DestinyComponentsProfilesDestinyProfileTransitoryPartyMember Build()
            {
                Validate();
                return new DestinyComponentsProfilesDestinyProfileTransitoryPartyMember(
                    MembershipId: _MembershipId,
                    EmblemHash: _EmblemHash,
                    DisplayName: _DisplayName,
                    Status: _Status
                );
            }

            private void Validate()
            { 
            }
        }

        
    }
}