using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Sharpility.Extensions;
using NodaTime;

namespace BungieNetApi._Platform.Models
{
    /// <summary>
    /// FireteamFireteamResponse
    /// </summary>
    public sealed class FireteamFireteamResponse:  IEquatable<FireteamFireteamResponse>
    { 
        /// <summary>
        /// Summary
        /// </summary>
        public FireteamFireteamSummary Summary { get; private set; }

        /// <summary>
        /// Members
        /// </summary>
        public List<FireteamFireteamMember> Members { get; private set; }

        /// <summary>
        /// Alternates
        /// </summary>
        public List<FireteamFireteamMember> Alternates { get; private set; }


        /// <summary>
        /// Empty constructor required by some serializers.
        /// Use FireteamFireteamResponse.Builder() for instance creation instead.
        /// </summary>
        [Obsolete]
        public FireteamFireteamResponse()
        {
        }

        private FireteamFireteamResponse(FireteamFireteamSummary Summary, List<FireteamFireteamMember> Members, List<FireteamFireteamMember> Alternates)
        {
            
            this.Summary = Summary;
            
            this.Members = Members;
            
            this.Alternates = Alternates;
            
        }

        /// <summary>
        /// Returns builder of FireteamFireteamResponse.
        /// </summary>
        /// <returns>FireteamFireteamResponseBuilder</returns>
        public static FireteamFireteamResponseBuilder Builder()
        {
            return new FireteamFireteamResponseBuilder();
        }

        /// <summary>
        /// Returns FireteamFireteamResponseBuilder with properties set.
        /// Use it to change properties.
        /// </summary>
        /// <returns>FireteamFireteamResponseBuilder</returns>
        public FireteamFireteamResponseBuilder With()
        {
            return Builder()
                .Summary(Summary)
                .Members(Members)
                .Alternates(Alternates);
        }

        public override string ToString()
        {
            return this.PropertiesToString();
        }

        public override bool Equals(object obj)
        {
            return this.EqualsByProperties(obj);
        }

        public bool Equals(FireteamFireteamResponse other)
        {
            return Equals((object) other);
        }

        public override int GetHashCode()
        {
            return this.PropertiesHash();
        }

        /// <summary>
        /// Implementation of == operator for (FireteamFireteamResponse.
        /// </summary>
        /// <param name="left">Compared (FireteamFireteamResponse</param>
        /// <param name="right">Compared (FireteamFireteamResponse</param>
        /// <returns>true if compared items are equals, false otherwise</returns>
        public static bool operator == (FireteamFireteamResponse left, FireteamFireteamResponse right)
        {
            return Equals(left, right);
        }

        /// <summary>
        /// Implementation of != operator for (FireteamFireteamResponse.
        /// </summary>
        /// <param name="left">Compared (FireteamFireteamResponse</param>
        /// <param name="right">Compared (FireteamFireteamResponse</param>
        /// <returns>true if compared items are not equals, false otherwise</returns>
        public static bool operator != (FireteamFireteamResponse left, FireteamFireteamResponse right)
        {
            return !Equals(left, right);
        }

        /// <summary>
        /// Builder of FireteamFireteamResponse.
        /// </summary>
        public sealed class FireteamFireteamResponseBuilder
        {
            private FireteamFireteamSummary _Summary;
            private List<FireteamFireteamMember> _Members;
            private List<FireteamFireteamMember> _Alternates;

            internal FireteamFireteamResponseBuilder()
            {
                SetupDefaults();
            }

            private void SetupDefaults()
            {
            }

            /// <summary>
            /// Sets value for FireteamFireteamResponse.Summary property.
            /// </summary>
            /// <param name="value">Summary</param>
            public FireteamFireteamResponseBuilder Summary(FireteamFireteamSummary value)
            {
                _Summary = value;
                return this;
            }

            /// <summary>
            /// Sets value for FireteamFireteamResponse.Members property.
            /// </summary>
            /// <param name="value">Members</param>
            public FireteamFireteamResponseBuilder Members(List<FireteamFireteamMember> value)
            {
                _Members = value;
                return this;
            }

            /// <summary>
            /// Sets value for FireteamFireteamResponse.Alternates property.
            /// </summary>
            /// <param name="value">Alternates</param>
            public FireteamFireteamResponseBuilder Alternates(List<FireteamFireteamMember> value)
            {
                _Alternates = value;
                return this;
            }


            /// <summary>
            /// Builds instance of FireteamFireteamResponse.
            /// </summary>
            /// <returns>FireteamFireteamResponse</returns>
            public FireteamFireteamResponse Build()
            {
                Validate();
                return new FireteamFireteamResponse(
                    Summary: _Summary,
                    Members: _Members,
                    Alternates: _Alternates
                );
            }

            private void Validate()
            { 
            }
        }

        
    }
}