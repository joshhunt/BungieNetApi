using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Sharpility.Extensions;
using NodaTime;

namespace BungieNetApi._Platform.Models
{
    /// <summary>
    /// ForumPollResponse
    /// </summary>
    public sealed class ForumPollResponse:  IEquatable<ForumPollResponse>
    { 
        /// <summary>
        /// TopicId
        /// </summary>
        public long? TopicId { get; private set; }

        /// <summary>
        /// Results
        /// </summary>
        public List<ForumPollResult> Results { get; private set; }

        /// <summary>
        /// TotalVotes
        /// </summary>
        public int? TotalVotes { get; private set; }


        /// <summary>
        /// Empty constructor required by some serializers.
        /// Use ForumPollResponse.Builder() for instance creation instead.
        /// </summary>
        [Obsolete]
        public ForumPollResponse()
        {
        }

        private ForumPollResponse(long? TopicId, List<ForumPollResult> Results, int? TotalVotes)
        {
            
            this.TopicId = TopicId;
            
            this.Results = Results;
            
            this.TotalVotes = TotalVotes;
            
        }

        /// <summary>
        /// Returns builder of ForumPollResponse.
        /// </summary>
        /// <returns>ForumPollResponseBuilder</returns>
        public static ForumPollResponseBuilder Builder()
        {
            return new ForumPollResponseBuilder();
        }

        /// <summary>
        /// Returns ForumPollResponseBuilder with properties set.
        /// Use it to change properties.
        /// </summary>
        /// <returns>ForumPollResponseBuilder</returns>
        public ForumPollResponseBuilder With()
        {
            return Builder()
                .TopicId(TopicId)
                .Results(Results)
                .TotalVotes(TotalVotes);
        }

        public override string ToString()
        {
            return this.PropertiesToString();
        }

        public override bool Equals(object obj)
        {
            return this.EqualsByProperties(obj);
        }

        public bool Equals(ForumPollResponse other)
        {
            return Equals((object) other);
        }

        public override int GetHashCode()
        {
            return this.PropertiesHash();
        }

        /// <summary>
        /// Implementation of == operator for (ForumPollResponse.
        /// </summary>
        /// <param name="left">Compared (ForumPollResponse</param>
        /// <param name="right">Compared (ForumPollResponse</param>
        /// <returns>true if compared items are equals, false otherwise</returns>
        public static bool operator == (ForumPollResponse left, ForumPollResponse right)
        {
            return Equals(left, right);
        }

        /// <summary>
        /// Implementation of != operator for (ForumPollResponse.
        /// </summary>
        /// <param name="left">Compared (ForumPollResponse</param>
        /// <param name="right">Compared (ForumPollResponse</param>
        /// <returns>true if compared items are not equals, false otherwise</returns>
        public static bool operator != (ForumPollResponse left, ForumPollResponse right)
        {
            return !Equals(left, right);
        }

        /// <summary>
        /// Builder of ForumPollResponse.
        /// </summary>
        public sealed class ForumPollResponseBuilder
        {
            private long? _TopicId;
            private List<ForumPollResult> _Results;
            private int? _TotalVotes;

            internal ForumPollResponseBuilder()
            {
                SetupDefaults();
            }

            private void SetupDefaults()
            {
            }

            /// <summary>
            /// Sets value for ForumPollResponse.TopicId property.
            /// </summary>
            /// <param name="value">TopicId</param>
            public ForumPollResponseBuilder TopicId(long? value)
            {
                _TopicId = value;
                return this;
            }

            /// <summary>
            /// Sets value for ForumPollResponse.Results property.
            /// </summary>
            /// <param name="value">Results</param>
            public ForumPollResponseBuilder Results(List<ForumPollResult> value)
            {
                _Results = value;
                return this;
            }

            /// <summary>
            /// Sets value for ForumPollResponse.TotalVotes property.
            /// </summary>
            /// <param name="value">TotalVotes</param>
            public ForumPollResponseBuilder TotalVotes(int? value)
            {
                _TotalVotes = value;
                return this;
            }


            /// <summary>
            /// Builds instance of ForumPollResponse.
            /// </summary>
            /// <returns>ForumPollResponse</returns>
            public ForumPollResponse Build()
            {
                Validate();
                return new ForumPollResponse(
                    TopicId: _TopicId,
                    Results: _Results,
                    TotalVotes: _TotalVotes
                );
            }

            private void Validate()
            { 
            }
        }

        
    }
}