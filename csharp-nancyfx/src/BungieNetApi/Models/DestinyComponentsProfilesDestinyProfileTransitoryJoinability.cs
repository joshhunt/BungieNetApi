using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Sharpility.Extensions;
using NodaTime;

namespace BungieNetApi._Platform.Models
{
    /// <summary>
    /// Some basic information about whether you can be joined, how many slots are left etc. Note that this can change quickly, so it may not actually be useful. But perhaps it will be in some use cases?
    /// </summary>
    public sealed class DestinyComponentsProfilesDestinyProfileTransitoryJoinability:  IEquatable<DestinyComponentsProfilesDestinyProfileTransitoryJoinability>
    { 
        /// <summary>
        /// The number of slots still available on this person&#39;s fireteam.
        /// </summary>
        public int? OpenSlots { get; private set; }

        /// <summary>
        /// Who the person is currently allowing invites from.
        /// </summary>
        public int? PrivacySetting { get; private set; }

        /// <summary>
        /// Reasons why a person can&#39;t join this person&#39;s fireteam.
        /// </summary>
        public int? ClosedReasons { get; private set; }


        /// <summary>
        /// Empty constructor required by some serializers.
        /// Use DestinyComponentsProfilesDestinyProfileTransitoryJoinability.Builder() for instance creation instead.
        /// </summary>
        [Obsolete]
        public DestinyComponentsProfilesDestinyProfileTransitoryJoinability()
        {
        }

        private DestinyComponentsProfilesDestinyProfileTransitoryJoinability(int? OpenSlots, int? PrivacySetting, int? ClosedReasons)
        {
            
            this.OpenSlots = OpenSlots;
            
            this.PrivacySetting = PrivacySetting;
            
            this.ClosedReasons = ClosedReasons;
            
        }

        /// <summary>
        /// Returns builder of DestinyComponentsProfilesDestinyProfileTransitoryJoinability.
        /// </summary>
        /// <returns>DestinyComponentsProfilesDestinyProfileTransitoryJoinabilityBuilder</returns>
        public static DestinyComponentsProfilesDestinyProfileTransitoryJoinabilityBuilder Builder()
        {
            return new DestinyComponentsProfilesDestinyProfileTransitoryJoinabilityBuilder();
        }

        /// <summary>
        /// Returns DestinyComponentsProfilesDestinyProfileTransitoryJoinabilityBuilder with properties set.
        /// Use it to change properties.
        /// </summary>
        /// <returns>DestinyComponentsProfilesDestinyProfileTransitoryJoinabilityBuilder</returns>
        public DestinyComponentsProfilesDestinyProfileTransitoryJoinabilityBuilder With()
        {
            return Builder()
                .OpenSlots(OpenSlots)
                .PrivacySetting(PrivacySetting)
                .ClosedReasons(ClosedReasons);
        }

        public override string ToString()
        {
            return this.PropertiesToString();
        }

        public override bool Equals(object obj)
        {
            return this.EqualsByProperties(obj);
        }

        public bool Equals(DestinyComponentsProfilesDestinyProfileTransitoryJoinability other)
        {
            return Equals((object) other);
        }

        public override int GetHashCode()
        {
            return this.PropertiesHash();
        }

        /// <summary>
        /// Implementation of == operator for (DestinyComponentsProfilesDestinyProfileTransitoryJoinability.
        /// </summary>
        /// <param name="left">Compared (DestinyComponentsProfilesDestinyProfileTransitoryJoinability</param>
        /// <param name="right">Compared (DestinyComponentsProfilesDestinyProfileTransitoryJoinability</param>
        /// <returns>true if compared items are equals, false otherwise</returns>
        public static bool operator == (DestinyComponentsProfilesDestinyProfileTransitoryJoinability left, DestinyComponentsProfilesDestinyProfileTransitoryJoinability right)
        {
            return Equals(left, right);
        }

        /// <summary>
        /// Implementation of != operator for (DestinyComponentsProfilesDestinyProfileTransitoryJoinability.
        /// </summary>
        /// <param name="left">Compared (DestinyComponentsProfilesDestinyProfileTransitoryJoinability</param>
        /// <param name="right">Compared (DestinyComponentsProfilesDestinyProfileTransitoryJoinability</param>
        /// <returns>true if compared items are not equals, false otherwise</returns>
        public static bool operator != (DestinyComponentsProfilesDestinyProfileTransitoryJoinability left, DestinyComponentsProfilesDestinyProfileTransitoryJoinability right)
        {
            return !Equals(left, right);
        }

        /// <summary>
        /// Builder of DestinyComponentsProfilesDestinyProfileTransitoryJoinability.
        /// </summary>
        public sealed class DestinyComponentsProfilesDestinyProfileTransitoryJoinabilityBuilder
        {
            private int? _OpenSlots;
            private int? _PrivacySetting;
            private int? _ClosedReasons;

            internal DestinyComponentsProfilesDestinyProfileTransitoryJoinabilityBuilder()
            {
                SetupDefaults();
            }

            private void SetupDefaults()
            {
            }

            /// <summary>
            /// Sets value for DestinyComponentsProfilesDestinyProfileTransitoryJoinability.OpenSlots property.
            /// </summary>
            /// <param name="value">The number of slots still available on this person&#39;s fireteam.</param>
            public DestinyComponentsProfilesDestinyProfileTransitoryJoinabilityBuilder OpenSlots(int? value)
            {
                _OpenSlots = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyComponentsProfilesDestinyProfileTransitoryJoinability.PrivacySetting property.
            /// </summary>
            /// <param name="value">Who the person is currently allowing invites from.</param>
            public DestinyComponentsProfilesDestinyProfileTransitoryJoinabilityBuilder PrivacySetting(int? value)
            {
                _PrivacySetting = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyComponentsProfilesDestinyProfileTransitoryJoinability.ClosedReasons property.
            /// </summary>
            /// <param name="value">Reasons why a person can&#39;t join this person&#39;s fireteam.</param>
            public DestinyComponentsProfilesDestinyProfileTransitoryJoinabilityBuilder ClosedReasons(int? value)
            {
                _ClosedReasons = value;
                return this;
            }


            /// <summary>
            /// Builds instance of DestinyComponentsProfilesDestinyProfileTransitoryJoinability.
            /// </summary>
            /// <returns>DestinyComponentsProfilesDestinyProfileTransitoryJoinability</returns>
            public DestinyComponentsProfilesDestinyProfileTransitoryJoinability Build()
            {
                Validate();
                return new DestinyComponentsProfilesDestinyProfileTransitoryJoinability(
                    OpenSlots: _OpenSlots,
                    PrivacySetting: _PrivacySetting,
                    ClosedReasons: _ClosedReasons
                );
            }

            private void Validate()
            { 
            }
        }

        
    }
}