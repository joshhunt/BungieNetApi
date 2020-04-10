using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Sharpility.Extensions;
using NodaTime;

namespace BungieNetApi._Platform.Models
{
    /// <summary>
    /// I know what you seek. You seek linked accounts. Found them, you have.  This contract returns a minimal amount of data about Destiny Accounts that are linked through your Bungie.Net account. We will not return accounts in this response whose
    /// </summary>
    public sealed class DestinyResponsesDestinyLinkedProfilesResponse:  IEquatable<DestinyResponsesDestinyLinkedProfilesResponse>
    { 
        /// <summary>
        /// Any Destiny account for whom we could successfully pull characters will be returned here, as the Platform-level summary of user data. (no character data, no Destiny account data other than the Membership ID and Type so you can make further queries)
        /// </summary>
        public List<DestinyResponsesDestinyProfileUserInfoCard> Profiles { get; private set; }

        /// <summary>
        /// If the requested membership had a linked Bungie.Net membership ID, this is the basic information about that BNet account.  I know, Tetron; I know this is mixing UserServices concerns with DestinyServices concerns. But it&#39;s so damn convenient! https://www.youtube.com/watch?v&#x3D;X5R-bB-gKVI
        /// </summary>
        public UserUserInfoCard BnetMembership { get; private set; }

        /// <summary>
        /// This is brief summary info for profiles that we believe have valid Destiny info, but who failed to return data for some other reason and thus we know that subsequent calls for their info will also fail.
        /// </summary>
        public List<DestinyResponsesDestinyErrorProfile> ProfilesWithErrors { get; private set; }


        /// <summary>
        /// Empty constructor required by some serializers.
        /// Use DestinyResponsesDestinyLinkedProfilesResponse.Builder() for instance creation instead.
        /// </summary>
        [Obsolete]
        public DestinyResponsesDestinyLinkedProfilesResponse()
        {
        }

        private DestinyResponsesDestinyLinkedProfilesResponse(List<DestinyResponsesDestinyProfileUserInfoCard> Profiles, UserUserInfoCard BnetMembership, List<DestinyResponsesDestinyErrorProfile> ProfilesWithErrors)
        {
            
            this.Profiles = Profiles;
            
            this.BnetMembership = BnetMembership;
            
            this.ProfilesWithErrors = ProfilesWithErrors;
            
        }

        /// <summary>
        /// Returns builder of DestinyResponsesDestinyLinkedProfilesResponse.
        /// </summary>
        /// <returns>DestinyResponsesDestinyLinkedProfilesResponseBuilder</returns>
        public static DestinyResponsesDestinyLinkedProfilesResponseBuilder Builder()
        {
            return new DestinyResponsesDestinyLinkedProfilesResponseBuilder();
        }

        /// <summary>
        /// Returns DestinyResponsesDestinyLinkedProfilesResponseBuilder with properties set.
        /// Use it to change properties.
        /// </summary>
        /// <returns>DestinyResponsesDestinyLinkedProfilesResponseBuilder</returns>
        public DestinyResponsesDestinyLinkedProfilesResponseBuilder With()
        {
            return Builder()
                .Profiles(Profiles)
                .BnetMembership(BnetMembership)
                .ProfilesWithErrors(ProfilesWithErrors);
        }

        public override string ToString()
        {
            return this.PropertiesToString();
        }

        public override bool Equals(object obj)
        {
            return this.EqualsByProperties(obj);
        }

        public bool Equals(DestinyResponsesDestinyLinkedProfilesResponse other)
        {
            return Equals((object) other);
        }

        public override int GetHashCode()
        {
            return this.PropertiesHash();
        }

        /// <summary>
        /// Implementation of == operator for (DestinyResponsesDestinyLinkedProfilesResponse.
        /// </summary>
        /// <param name="left">Compared (DestinyResponsesDestinyLinkedProfilesResponse</param>
        /// <param name="right">Compared (DestinyResponsesDestinyLinkedProfilesResponse</param>
        /// <returns>true if compared items are equals, false otherwise</returns>
        public static bool operator == (DestinyResponsesDestinyLinkedProfilesResponse left, DestinyResponsesDestinyLinkedProfilesResponse right)
        {
            return Equals(left, right);
        }

        /// <summary>
        /// Implementation of != operator for (DestinyResponsesDestinyLinkedProfilesResponse.
        /// </summary>
        /// <param name="left">Compared (DestinyResponsesDestinyLinkedProfilesResponse</param>
        /// <param name="right">Compared (DestinyResponsesDestinyLinkedProfilesResponse</param>
        /// <returns>true if compared items are not equals, false otherwise</returns>
        public static bool operator != (DestinyResponsesDestinyLinkedProfilesResponse left, DestinyResponsesDestinyLinkedProfilesResponse right)
        {
            return !Equals(left, right);
        }

        /// <summary>
        /// Builder of DestinyResponsesDestinyLinkedProfilesResponse.
        /// </summary>
        public sealed class DestinyResponsesDestinyLinkedProfilesResponseBuilder
        {
            private List<DestinyResponsesDestinyProfileUserInfoCard> _Profiles;
            private UserUserInfoCard _BnetMembership;
            private List<DestinyResponsesDestinyErrorProfile> _ProfilesWithErrors;

            internal DestinyResponsesDestinyLinkedProfilesResponseBuilder()
            {
                SetupDefaults();
            }

            private void SetupDefaults()
            {
            }

            /// <summary>
            /// Sets value for DestinyResponsesDestinyLinkedProfilesResponse.Profiles property.
            /// </summary>
            /// <param name="value">Any Destiny account for whom we could successfully pull characters will be returned here, as the Platform-level summary of user data. (no character data, no Destiny account data other than the Membership ID and Type so you can make further queries)</param>
            public DestinyResponsesDestinyLinkedProfilesResponseBuilder Profiles(List<DestinyResponsesDestinyProfileUserInfoCard> value)
            {
                _Profiles = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyResponsesDestinyLinkedProfilesResponse.BnetMembership property.
            /// </summary>
            /// <param name="value">If the requested membership had a linked Bungie.Net membership ID, this is the basic information about that BNet account.  I know, Tetron; I know this is mixing UserServices concerns with DestinyServices concerns. But it&#39;s so damn convenient! https://www.youtube.com/watch?v&#x3D;X5R-bB-gKVI</param>
            public DestinyResponsesDestinyLinkedProfilesResponseBuilder BnetMembership(UserUserInfoCard value)
            {
                _BnetMembership = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyResponsesDestinyLinkedProfilesResponse.ProfilesWithErrors property.
            /// </summary>
            /// <param name="value">This is brief summary info for profiles that we believe have valid Destiny info, but who failed to return data for some other reason and thus we know that subsequent calls for their info will also fail.</param>
            public DestinyResponsesDestinyLinkedProfilesResponseBuilder ProfilesWithErrors(List<DestinyResponsesDestinyErrorProfile> value)
            {
                _ProfilesWithErrors = value;
                return this;
            }


            /// <summary>
            /// Builds instance of DestinyResponsesDestinyLinkedProfilesResponse.
            /// </summary>
            /// <returns>DestinyResponsesDestinyLinkedProfilesResponse</returns>
            public DestinyResponsesDestinyLinkedProfilesResponse Build()
            {
                Validate();
                return new DestinyResponsesDestinyLinkedProfilesResponse(
                    Profiles: _Profiles,
                    BnetMembership: _BnetMembership,
                    ProfilesWithErrors: _ProfilesWithErrors
                );
            }

            private void Validate()
            { 
            }
        }

        
    }
}