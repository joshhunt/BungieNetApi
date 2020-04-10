using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Sharpility.Extensions;
using NodaTime;

namespace BungieNetApi._Platform.Models
{
    /// <summary>
    /// If you want to report a player causing trouble in a game, this request will let you report that player and the specific PGCR in which the trouble was caused, along with why.  Please don&#39;t do this just because you dislike the person! I mean, I know people will do it anyways, but can you like take a good walk, or put a curse on them or something? Do me a solid and reconsider.  Note that this request object doesn&#39;t have the actual PGCR ID nor your Account/Character ID in it. We will infer that information from your authentication information and the PGCR ID that you pass into the URL of the reporting endpoint itself.
    /// </summary>
    public sealed class DestinyReportingRequestsDestinyReportOffensePgcrRequest:  IEquatable<DestinyReportingRequestsDestinyReportOffensePgcrRequest>
    { 
        /// <summary>
        /// So you&#39;ve decided to report someone instead of cursing them and their descendants. Well, okay then. This is the category or categorie(s) of infractions for which you are reporting the user. These are hash identifiers that map to DestinyReportReasonCategoryDefinition entries.
        /// </summary>
        public List<int?> ReasonCategoryHashes { get; private set; }

        /// <summary>
        /// If applicable, provide a more specific reason(s) within the general category of problems provided by the reasonHash. This is also an identifier for a reason. All reasonHashes provided must be children of at least one the reasonCategoryHashes provided.
        /// </summary>
        public List<int?> ReasonHashes { get; private set; }

        /// <summary>
        /// Within the PGCR provided when calling the Reporting endpoint, this should be the character ID of the user that you thought was violating terms of use. They must exist in the PGCR provided.
        /// </summary>
        public long? OffendingCharacterId { get; private set; }


        /// <summary>
        /// Empty constructor required by some serializers.
        /// Use DestinyReportingRequestsDestinyReportOffensePgcrRequest.Builder() for instance creation instead.
        /// </summary>
        [Obsolete]
        public DestinyReportingRequestsDestinyReportOffensePgcrRequest()
        {
        }

        private DestinyReportingRequestsDestinyReportOffensePgcrRequest(List<int?> ReasonCategoryHashes, List<int?> ReasonHashes, long? OffendingCharacterId)
        {
            
            this.ReasonCategoryHashes = ReasonCategoryHashes;
            
            this.ReasonHashes = ReasonHashes;
            
            this.OffendingCharacterId = OffendingCharacterId;
            
        }

        /// <summary>
        /// Returns builder of DestinyReportingRequestsDestinyReportOffensePgcrRequest.
        /// </summary>
        /// <returns>DestinyReportingRequestsDestinyReportOffensePgcrRequestBuilder</returns>
        public static DestinyReportingRequestsDestinyReportOffensePgcrRequestBuilder Builder()
        {
            return new DestinyReportingRequestsDestinyReportOffensePgcrRequestBuilder();
        }

        /// <summary>
        /// Returns DestinyReportingRequestsDestinyReportOffensePgcrRequestBuilder with properties set.
        /// Use it to change properties.
        /// </summary>
        /// <returns>DestinyReportingRequestsDestinyReportOffensePgcrRequestBuilder</returns>
        public DestinyReportingRequestsDestinyReportOffensePgcrRequestBuilder With()
        {
            return Builder()
                .ReasonCategoryHashes(ReasonCategoryHashes)
                .ReasonHashes(ReasonHashes)
                .OffendingCharacterId(OffendingCharacterId);
        }

        public override string ToString()
        {
            return this.PropertiesToString();
        }

        public override bool Equals(object obj)
        {
            return this.EqualsByProperties(obj);
        }

        public bool Equals(DestinyReportingRequestsDestinyReportOffensePgcrRequest other)
        {
            return Equals((object) other);
        }

        public override int GetHashCode()
        {
            return this.PropertiesHash();
        }

        /// <summary>
        /// Implementation of == operator for (DestinyReportingRequestsDestinyReportOffensePgcrRequest.
        /// </summary>
        /// <param name="left">Compared (DestinyReportingRequestsDestinyReportOffensePgcrRequest</param>
        /// <param name="right">Compared (DestinyReportingRequestsDestinyReportOffensePgcrRequest</param>
        /// <returns>true if compared items are equals, false otherwise</returns>
        public static bool operator == (DestinyReportingRequestsDestinyReportOffensePgcrRequest left, DestinyReportingRequestsDestinyReportOffensePgcrRequest right)
        {
            return Equals(left, right);
        }

        /// <summary>
        /// Implementation of != operator for (DestinyReportingRequestsDestinyReportOffensePgcrRequest.
        /// </summary>
        /// <param name="left">Compared (DestinyReportingRequestsDestinyReportOffensePgcrRequest</param>
        /// <param name="right">Compared (DestinyReportingRequestsDestinyReportOffensePgcrRequest</param>
        /// <returns>true if compared items are not equals, false otherwise</returns>
        public static bool operator != (DestinyReportingRequestsDestinyReportOffensePgcrRequest left, DestinyReportingRequestsDestinyReportOffensePgcrRequest right)
        {
            return !Equals(left, right);
        }

        /// <summary>
        /// Builder of DestinyReportingRequestsDestinyReportOffensePgcrRequest.
        /// </summary>
        public sealed class DestinyReportingRequestsDestinyReportOffensePgcrRequestBuilder
        {
            private List<int?> _ReasonCategoryHashes;
            private List<int?> _ReasonHashes;
            private long? _OffendingCharacterId;

            internal DestinyReportingRequestsDestinyReportOffensePgcrRequestBuilder()
            {
                SetupDefaults();
            }

            private void SetupDefaults()
            {
            }

            /// <summary>
            /// Sets value for DestinyReportingRequestsDestinyReportOffensePgcrRequest.ReasonCategoryHashes property.
            /// </summary>
            /// <param name="value">So you&#39;ve decided to report someone instead of cursing them and their descendants. Well, okay then. This is the category or categorie(s) of infractions for which you are reporting the user. These are hash identifiers that map to DestinyReportReasonCategoryDefinition entries.</param>
            public DestinyReportingRequestsDestinyReportOffensePgcrRequestBuilder ReasonCategoryHashes(List<int?> value)
            {
                _ReasonCategoryHashes = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyReportingRequestsDestinyReportOffensePgcrRequest.ReasonHashes property.
            /// </summary>
            /// <param name="value">If applicable, provide a more specific reason(s) within the general category of problems provided by the reasonHash. This is also an identifier for a reason. All reasonHashes provided must be children of at least one the reasonCategoryHashes provided.</param>
            public DestinyReportingRequestsDestinyReportOffensePgcrRequestBuilder ReasonHashes(List<int?> value)
            {
                _ReasonHashes = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyReportingRequestsDestinyReportOffensePgcrRequest.OffendingCharacterId property.
            /// </summary>
            /// <param name="value">Within the PGCR provided when calling the Reporting endpoint, this should be the character ID of the user that you thought was violating terms of use. They must exist in the PGCR provided.</param>
            public DestinyReportingRequestsDestinyReportOffensePgcrRequestBuilder OffendingCharacterId(long? value)
            {
                _OffendingCharacterId = value;
                return this;
            }


            /// <summary>
            /// Builds instance of DestinyReportingRequestsDestinyReportOffensePgcrRequest.
            /// </summary>
            /// <returns>DestinyReportingRequestsDestinyReportOffensePgcrRequest</returns>
            public DestinyReportingRequestsDestinyReportOffensePgcrRequest Build()
            {
                Validate();
                return new DestinyReportingRequestsDestinyReportOffensePgcrRequest(
                    ReasonCategoryHashes: _ReasonCategoryHashes,
                    ReasonHashes: _ReasonHashes,
                    OffendingCharacterId: _OffendingCharacterId
                );
            }

            private void Validate()
            { 
            }
        }

        
    }
}