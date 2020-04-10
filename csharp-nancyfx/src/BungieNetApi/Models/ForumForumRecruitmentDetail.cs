using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Sharpility.Extensions;
using NodaTime;

namespace BungieNetApi._Platform.Models
{
    /// <summary>
    /// ForumForumRecruitmentDetail
    /// </summary>
    public sealed class ForumForumRecruitmentDetail:  IEquatable<ForumForumRecruitmentDetail>
    { 
        /// <summary>
        /// TopicId
        /// </summary>
        public long? TopicId { get; private set; }

        /// <summary>
        /// MicrophoneRequired
        /// </summary>
        public bool? MicrophoneRequired { get; private set; }

        /// <summary>
        /// Intensity
        /// </summary>
        public int? Intensity { get; private set; }

        /// <summary>
        /// Tone
        /// </summary>
        public int? Tone { get; private set; }

        /// <summary>
        /// Approved
        /// </summary>
        public bool? Approved { get; private set; }

        /// <summary>
        /// ConversationId
        /// </summary>
        public long? ConversationId { get; private set; }

        /// <summary>
        /// PlayerSlotsTotal
        /// </summary>
        public int? PlayerSlotsTotal { get; private set; }

        /// <summary>
        /// PlayerSlotsRemaining
        /// </summary>
        public int? PlayerSlotsRemaining { get; private set; }

        /// <summary>
        /// Fireteam
        /// </summary>
        public List<UserGeneralUser> Fireteam { get; private set; }

        /// <summary>
        /// KickedPlayerIds
        /// </summary>
        public List<long?> KickedPlayerIds { get; private set; }


        /// <summary>
        /// Empty constructor required by some serializers.
        /// Use ForumForumRecruitmentDetail.Builder() for instance creation instead.
        /// </summary>
        [Obsolete]
        public ForumForumRecruitmentDetail()
        {
        }

        private ForumForumRecruitmentDetail(long? TopicId, bool? MicrophoneRequired, int? Intensity, int? Tone, bool? Approved, long? ConversationId, int? PlayerSlotsTotal, int? PlayerSlotsRemaining, List<UserGeneralUser> Fireteam, List<long?> KickedPlayerIds)
        {
            
            this.TopicId = TopicId;
            
            this.MicrophoneRequired = MicrophoneRequired;
            
            this.Intensity = Intensity;
            
            this.Tone = Tone;
            
            this.Approved = Approved;
            
            this.ConversationId = ConversationId;
            
            this.PlayerSlotsTotal = PlayerSlotsTotal;
            
            this.PlayerSlotsRemaining = PlayerSlotsRemaining;
            
            this.Fireteam = Fireteam;
            
            this.KickedPlayerIds = KickedPlayerIds;
            
        }

        /// <summary>
        /// Returns builder of ForumForumRecruitmentDetail.
        /// </summary>
        /// <returns>ForumForumRecruitmentDetailBuilder</returns>
        public static ForumForumRecruitmentDetailBuilder Builder()
        {
            return new ForumForumRecruitmentDetailBuilder();
        }

        /// <summary>
        /// Returns ForumForumRecruitmentDetailBuilder with properties set.
        /// Use it to change properties.
        /// </summary>
        /// <returns>ForumForumRecruitmentDetailBuilder</returns>
        public ForumForumRecruitmentDetailBuilder With()
        {
            return Builder()
                .TopicId(TopicId)
                .MicrophoneRequired(MicrophoneRequired)
                .Intensity(Intensity)
                .Tone(Tone)
                .Approved(Approved)
                .ConversationId(ConversationId)
                .PlayerSlotsTotal(PlayerSlotsTotal)
                .PlayerSlotsRemaining(PlayerSlotsRemaining)
                .Fireteam(Fireteam)
                .KickedPlayerIds(KickedPlayerIds);
        }

        public override string ToString()
        {
            return this.PropertiesToString();
        }

        public override bool Equals(object obj)
        {
            return this.EqualsByProperties(obj);
        }

        public bool Equals(ForumForumRecruitmentDetail other)
        {
            return Equals((object) other);
        }

        public override int GetHashCode()
        {
            return this.PropertiesHash();
        }

        /// <summary>
        /// Implementation of == operator for (ForumForumRecruitmentDetail.
        /// </summary>
        /// <param name="left">Compared (ForumForumRecruitmentDetail</param>
        /// <param name="right">Compared (ForumForumRecruitmentDetail</param>
        /// <returns>true if compared items are equals, false otherwise</returns>
        public static bool operator == (ForumForumRecruitmentDetail left, ForumForumRecruitmentDetail right)
        {
            return Equals(left, right);
        }

        /// <summary>
        /// Implementation of != operator for (ForumForumRecruitmentDetail.
        /// </summary>
        /// <param name="left">Compared (ForumForumRecruitmentDetail</param>
        /// <param name="right">Compared (ForumForumRecruitmentDetail</param>
        /// <returns>true if compared items are not equals, false otherwise</returns>
        public static bool operator != (ForumForumRecruitmentDetail left, ForumForumRecruitmentDetail right)
        {
            return !Equals(left, right);
        }

        /// <summary>
        /// Builder of ForumForumRecruitmentDetail.
        /// </summary>
        public sealed class ForumForumRecruitmentDetailBuilder
        {
            private long? _TopicId;
            private bool? _MicrophoneRequired;
            private int? _Intensity;
            private int? _Tone;
            private bool? _Approved;
            private long? _ConversationId;
            private int? _PlayerSlotsTotal;
            private int? _PlayerSlotsRemaining;
            private List<UserGeneralUser> _Fireteam;
            private List<long?> _KickedPlayerIds;

            internal ForumForumRecruitmentDetailBuilder()
            {
                SetupDefaults();
            }

            private void SetupDefaults()
            {
            }

            /// <summary>
            /// Sets value for ForumForumRecruitmentDetail.TopicId property.
            /// </summary>
            /// <param name="value">TopicId</param>
            public ForumForumRecruitmentDetailBuilder TopicId(long? value)
            {
                _TopicId = value;
                return this;
            }

            /// <summary>
            /// Sets value for ForumForumRecruitmentDetail.MicrophoneRequired property.
            /// </summary>
            /// <param name="value">MicrophoneRequired</param>
            public ForumForumRecruitmentDetailBuilder MicrophoneRequired(bool? value)
            {
                _MicrophoneRequired = value;
                return this;
            }

            /// <summary>
            /// Sets value for ForumForumRecruitmentDetail.Intensity property.
            /// </summary>
            /// <param name="value">Intensity</param>
            public ForumForumRecruitmentDetailBuilder Intensity(int? value)
            {
                _Intensity = value;
                return this;
            }

            /// <summary>
            /// Sets value for ForumForumRecruitmentDetail.Tone property.
            /// </summary>
            /// <param name="value">Tone</param>
            public ForumForumRecruitmentDetailBuilder Tone(int? value)
            {
                _Tone = value;
                return this;
            }

            /// <summary>
            /// Sets value for ForumForumRecruitmentDetail.Approved property.
            /// </summary>
            /// <param name="value">Approved</param>
            public ForumForumRecruitmentDetailBuilder Approved(bool? value)
            {
                _Approved = value;
                return this;
            }

            /// <summary>
            /// Sets value for ForumForumRecruitmentDetail.ConversationId property.
            /// </summary>
            /// <param name="value">ConversationId</param>
            public ForumForumRecruitmentDetailBuilder ConversationId(long? value)
            {
                _ConversationId = value;
                return this;
            }

            /// <summary>
            /// Sets value for ForumForumRecruitmentDetail.PlayerSlotsTotal property.
            /// </summary>
            /// <param name="value">PlayerSlotsTotal</param>
            public ForumForumRecruitmentDetailBuilder PlayerSlotsTotal(int? value)
            {
                _PlayerSlotsTotal = value;
                return this;
            }

            /// <summary>
            /// Sets value for ForumForumRecruitmentDetail.PlayerSlotsRemaining property.
            /// </summary>
            /// <param name="value">PlayerSlotsRemaining</param>
            public ForumForumRecruitmentDetailBuilder PlayerSlotsRemaining(int? value)
            {
                _PlayerSlotsRemaining = value;
                return this;
            }

            /// <summary>
            /// Sets value for ForumForumRecruitmentDetail.Fireteam property.
            /// </summary>
            /// <param name="value">Fireteam</param>
            public ForumForumRecruitmentDetailBuilder Fireteam(List<UserGeneralUser> value)
            {
                _Fireteam = value;
                return this;
            }

            /// <summary>
            /// Sets value for ForumForumRecruitmentDetail.KickedPlayerIds property.
            /// </summary>
            /// <param name="value">KickedPlayerIds</param>
            public ForumForumRecruitmentDetailBuilder KickedPlayerIds(List<long?> value)
            {
                _KickedPlayerIds = value;
                return this;
            }


            /// <summary>
            /// Builds instance of ForumForumRecruitmentDetail.
            /// </summary>
            /// <returns>ForumForumRecruitmentDetail</returns>
            public ForumForumRecruitmentDetail Build()
            {
                Validate();
                return new ForumForumRecruitmentDetail(
                    TopicId: _TopicId,
                    MicrophoneRequired: _MicrophoneRequired,
                    Intensity: _Intensity,
                    Tone: _Tone,
                    Approved: _Approved,
                    ConversationId: _ConversationId,
                    PlayerSlotsTotal: _PlayerSlotsTotal,
                    PlayerSlotsRemaining: _PlayerSlotsRemaining,
                    Fireteam: _Fireteam,
                    KickedPlayerIds: _KickedPlayerIds
                );
            }

            private void Validate()
            { 
            }
        }

        
    }
}