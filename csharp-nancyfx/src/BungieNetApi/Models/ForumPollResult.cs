using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Sharpility.Extensions;
using NodaTime;

namespace BungieNetApi._Platform.Models
{
    /// <summary>
    /// ForumPollResult
    /// </summary>
    public sealed class ForumPollResult:  IEquatable<ForumPollResult>
    { 
        /// <summary>
        /// AnswerText
        /// </summary>
        public string AnswerText { get; private set; }

        /// <summary>
        /// AnswerSlot
        /// </summary>
        public int? AnswerSlot { get; private set; }

        /// <summary>
        /// LastVoteDate
        /// </summary>
        public DateTime? LastVoteDate { get; private set; }

        /// <summary>
        /// Votes
        /// </summary>
        public int? Votes { get; private set; }

        /// <summary>
        /// RequestingUserVoted
        /// </summary>
        public bool? RequestingUserVoted { get; private set; }


        /// <summary>
        /// Empty constructor required by some serializers.
        /// Use ForumPollResult.Builder() for instance creation instead.
        /// </summary>
        [Obsolete]
        public ForumPollResult()
        {
        }

        private ForumPollResult(string AnswerText, int? AnswerSlot, DateTime? LastVoteDate, int? Votes, bool? RequestingUserVoted)
        {
            
            this.AnswerText = AnswerText;
            
            this.AnswerSlot = AnswerSlot;
            
            this.LastVoteDate = LastVoteDate;
            
            this.Votes = Votes;
            
            this.RequestingUserVoted = RequestingUserVoted;
            
        }

        /// <summary>
        /// Returns builder of ForumPollResult.
        /// </summary>
        /// <returns>ForumPollResultBuilder</returns>
        public static ForumPollResultBuilder Builder()
        {
            return new ForumPollResultBuilder();
        }

        /// <summary>
        /// Returns ForumPollResultBuilder with properties set.
        /// Use it to change properties.
        /// </summary>
        /// <returns>ForumPollResultBuilder</returns>
        public ForumPollResultBuilder With()
        {
            return Builder()
                .AnswerText(AnswerText)
                .AnswerSlot(AnswerSlot)
                .LastVoteDate(LastVoteDate)
                .Votes(Votes)
                .RequestingUserVoted(RequestingUserVoted);
        }

        public override string ToString()
        {
            return this.PropertiesToString();
        }

        public override bool Equals(object obj)
        {
            return this.EqualsByProperties(obj);
        }

        public bool Equals(ForumPollResult other)
        {
            return Equals((object) other);
        }

        public override int GetHashCode()
        {
            return this.PropertiesHash();
        }

        /// <summary>
        /// Implementation of == operator for (ForumPollResult.
        /// </summary>
        /// <param name="left">Compared (ForumPollResult</param>
        /// <param name="right">Compared (ForumPollResult</param>
        /// <returns>true if compared items are equals, false otherwise</returns>
        public static bool operator == (ForumPollResult left, ForumPollResult right)
        {
            return Equals(left, right);
        }

        /// <summary>
        /// Implementation of != operator for (ForumPollResult.
        /// </summary>
        /// <param name="left">Compared (ForumPollResult</param>
        /// <param name="right">Compared (ForumPollResult</param>
        /// <returns>true if compared items are not equals, false otherwise</returns>
        public static bool operator != (ForumPollResult left, ForumPollResult right)
        {
            return !Equals(left, right);
        }

        /// <summary>
        /// Builder of ForumPollResult.
        /// </summary>
        public sealed class ForumPollResultBuilder
        {
            private string _AnswerText;
            private int? _AnswerSlot;
            private DateTime? _LastVoteDate;
            private int? _Votes;
            private bool? _RequestingUserVoted;

            internal ForumPollResultBuilder()
            {
                SetupDefaults();
            }

            private void SetupDefaults()
            {
            }

            /// <summary>
            /// Sets value for ForumPollResult.AnswerText property.
            /// </summary>
            /// <param name="value">AnswerText</param>
            public ForumPollResultBuilder AnswerText(string value)
            {
                _AnswerText = value;
                return this;
            }

            /// <summary>
            /// Sets value for ForumPollResult.AnswerSlot property.
            /// </summary>
            /// <param name="value">AnswerSlot</param>
            public ForumPollResultBuilder AnswerSlot(int? value)
            {
                _AnswerSlot = value;
                return this;
            }

            /// <summary>
            /// Sets value for ForumPollResult.LastVoteDate property.
            /// </summary>
            /// <param name="value">LastVoteDate</param>
            public ForumPollResultBuilder LastVoteDate(DateTime? value)
            {
                _LastVoteDate = value;
                return this;
            }

            /// <summary>
            /// Sets value for ForumPollResult.Votes property.
            /// </summary>
            /// <param name="value">Votes</param>
            public ForumPollResultBuilder Votes(int? value)
            {
                _Votes = value;
                return this;
            }

            /// <summary>
            /// Sets value for ForumPollResult.RequestingUserVoted property.
            /// </summary>
            /// <param name="value">RequestingUserVoted</param>
            public ForumPollResultBuilder RequestingUserVoted(bool? value)
            {
                _RequestingUserVoted = value;
                return this;
            }


            /// <summary>
            /// Builds instance of ForumPollResult.
            /// </summary>
            /// <returns>ForumPollResult</returns>
            public ForumPollResult Build()
            {
                Validate();
                return new ForumPollResult(
                    AnswerText: _AnswerText,
                    AnswerSlot: _AnswerSlot,
                    LastVoteDate: _LastVoteDate,
                    Votes: _Votes,
                    RequestingUserVoted: _RequestingUserVoted
                );
            }

            private void Validate()
            { 
            }
        }

        
    }
}