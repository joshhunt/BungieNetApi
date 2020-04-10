using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Sharpility.Extensions;
using NodaTime;

namespace BungieNetApi._Platform.Models
{
    /// <summary>
    /// FireteamFireteamSummary
    /// </summary>
    public sealed class FireteamFireteamSummary:  IEquatable<FireteamFireteamSummary>
    { 
        /// <summary>
        /// FireteamId
        /// </summary>
        public long? FireteamId { get; private set; }

        /// <summary>
        /// GroupId
        /// </summary>
        public long? GroupId { get; private set; }

        /// <summary>
        /// Platform
        /// </summary>
        public int? Platform { get; private set; }

        /// <summary>
        /// ActivityType
        /// </summary>
        public int? ActivityType { get; private set; }

        /// <summary>
        /// IsImmediate
        /// </summary>
        public bool? IsImmediate { get; private set; }

        /// <summary>
        /// ScheduledTime
        /// </summary>
        public DateTime? ScheduledTime { get; private set; }

        /// <summary>
        /// OwnerMembershipId
        /// </summary>
        public long? OwnerMembershipId { get; private set; }

        /// <summary>
        /// PlayerSlotCount
        /// </summary>
        public int? PlayerSlotCount { get; private set; }

        /// <summary>
        /// AlternateSlotCount
        /// </summary>
        public int? AlternateSlotCount { get; private set; }

        /// <summary>
        /// AvailablePlayerSlotCount
        /// </summary>
        public int? AvailablePlayerSlotCount { get; private set; }

        /// <summary>
        /// AvailableAlternateSlotCount
        /// </summary>
        public int? AvailableAlternateSlotCount { get; private set; }

        /// <summary>
        /// Title
        /// </summary>
        public string Title { get; private set; }

        /// <summary>
        /// DateCreated
        /// </summary>
        public DateTime? DateCreated { get; private set; }

        /// <summary>
        /// DateModified
        /// </summary>
        public DateTime? DateModified { get; private set; }

        /// <summary>
        /// IsPublic
        /// </summary>
        public bool? IsPublic { get; private set; }

        /// <summary>
        /// Locale
        /// </summary>
        public string Locale { get; private set; }

        /// <summary>
        /// IsValid
        /// </summary>
        public bool? IsValid { get; private set; }

        /// <summary>
        /// DatePlayerModified
        /// </summary>
        public DateTime? DatePlayerModified { get; private set; }

        /// <summary>
        /// TitleBeforeModeration
        /// </summary>
        public string TitleBeforeModeration { get; private set; }


        /// <summary>
        /// Empty constructor required by some serializers.
        /// Use FireteamFireteamSummary.Builder() for instance creation instead.
        /// </summary>
        [Obsolete]
        public FireteamFireteamSummary()
        {
        }

        private FireteamFireteamSummary(long? FireteamId, long? GroupId, int? Platform, int? ActivityType, bool? IsImmediate, DateTime? ScheduledTime, long? OwnerMembershipId, int? PlayerSlotCount, int? AlternateSlotCount, int? AvailablePlayerSlotCount, int? AvailableAlternateSlotCount, string Title, DateTime? DateCreated, DateTime? DateModified, bool? IsPublic, string Locale, bool? IsValid, DateTime? DatePlayerModified, string TitleBeforeModeration)
        {
            
            this.FireteamId = FireteamId;
            
            this.GroupId = GroupId;
            
            this.Platform = Platform;
            
            this.ActivityType = ActivityType;
            
            this.IsImmediate = IsImmediate;
            
            this.ScheduledTime = ScheduledTime;
            
            this.OwnerMembershipId = OwnerMembershipId;
            
            this.PlayerSlotCount = PlayerSlotCount;
            
            this.AlternateSlotCount = AlternateSlotCount;
            
            this.AvailablePlayerSlotCount = AvailablePlayerSlotCount;
            
            this.AvailableAlternateSlotCount = AvailableAlternateSlotCount;
            
            this.Title = Title;
            
            this.DateCreated = DateCreated;
            
            this.DateModified = DateModified;
            
            this.IsPublic = IsPublic;
            
            this.Locale = Locale;
            
            this.IsValid = IsValid;
            
            this.DatePlayerModified = DatePlayerModified;
            
            this.TitleBeforeModeration = TitleBeforeModeration;
            
        }

        /// <summary>
        /// Returns builder of FireteamFireteamSummary.
        /// </summary>
        /// <returns>FireteamFireteamSummaryBuilder</returns>
        public static FireteamFireteamSummaryBuilder Builder()
        {
            return new FireteamFireteamSummaryBuilder();
        }

        /// <summary>
        /// Returns FireteamFireteamSummaryBuilder with properties set.
        /// Use it to change properties.
        /// </summary>
        /// <returns>FireteamFireteamSummaryBuilder</returns>
        public FireteamFireteamSummaryBuilder With()
        {
            return Builder()
                .FireteamId(FireteamId)
                .GroupId(GroupId)
                .Platform(Platform)
                .ActivityType(ActivityType)
                .IsImmediate(IsImmediate)
                .ScheduledTime(ScheduledTime)
                .OwnerMembershipId(OwnerMembershipId)
                .PlayerSlotCount(PlayerSlotCount)
                .AlternateSlotCount(AlternateSlotCount)
                .AvailablePlayerSlotCount(AvailablePlayerSlotCount)
                .AvailableAlternateSlotCount(AvailableAlternateSlotCount)
                .Title(Title)
                .DateCreated(DateCreated)
                .DateModified(DateModified)
                .IsPublic(IsPublic)
                .Locale(Locale)
                .IsValid(IsValid)
                .DatePlayerModified(DatePlayerModified)
                .TitleBeforeModeration(TitleBeforeModeration);
        }

        public override string ToString()
        {
            return this.PropertiesToString();
        }

        public override bool Equals(object obj)
        {
            return this.EqualsByProperties(obj);
        }

        public bool Equals(FireteamFireteamSummary other)
        {
            return Equals((object) other);
        }

        public override int GetHashCode()
        {
            return this.PropertiesHash();
        }

        /// <summary>
        /// Implementation of == operator for (FireteamFireteamSummary.
        /// </summary>
        /// <param name="left">Compared (FireteamFireteamSummary</param>
        /// <param name="right">Compared (FireteamFireteamSummary</param>
        /// <returns>true if compared items are equals, false otherwise</returns>
        public static bool operator == (FireteamFireteamSummary left, FireteamFireteamSummary right)
        {
            return Equals(left, right);
        }

        /// <summary>
        /// Implementation of != operator for (FireteamFireteamSummary.
        /// </summary>
        /// <param name="left">Compared (FireteamFireteamSummary</param>
        /// <param name="right">Compared (FireteamFireteamSummary</param>
        /// <returns>true if compared items are not equals, false otherwise</returns>
        public static bool operator != (FireteamFireteamSummary left, FireteamFireteamSummary right)
        {
            return !Equals(left, right);
        }

        /// <summary>
        /// Builder of FireteamFireteamSummary.
        /// </summary>
        public sealed class FireteamFireteamSummaryBuilder
        {
            private long? _FireteamId;
            private long? _GroupId;
            private int? _Platform;
            private int? _ActivityType;
            private bool? _IsImmediate;
            private DateTime? _ScheduledTime;
            private long? _OwnerMembershipId;
            private int? _PlayerSlotCount;
            private int? _AlternateSlotCount;
            private int? _AvailablePlayerSlotCount;
            private int? _AvailableAlternateSlotCount;
            private string _Title;
            private DateTime? _DateCreated;
            private DateTime? _DateModified;
            private bool? _IsPublic;
            private string _Locale;
            private bool? _IsValid;
            private DateTime? _DatePlayerModified;
            private string _TitleBeforeModeration;

            internal FireteamFireteamSummaryBuilder()
            {
                SetupDefaults();
            }

            private void SetupDefaults()
            {
            }

            /// <summary>
            /// Sets value for FireteamFireteamSummary.FireteamId property.
            /// </summary>
            /// <param name="value">FireteamId</param>
            public FireteamFireteamSummaryBuilder FireteamId(long? value)
            {
                _FireteamId = value;
                return this;
            }

            /// <summary>
            /// Sets value for FireteamFireteamSummary.GroupId property.
            /// </summary>
            /// <param name="value">GroupId</param>
            public FireteamFireteamSummaryBuilder GroupId(long? value)
            {
                _GroupId = value;
                return this;
            }

            /// <summary>
            /// Sets value for FireteamFireteamSummary.Platform property.
            /// </summary>
            /// <param name="value">Platform</param>
            public FireteamFireteamSummaryBuilder Platform(int? value)
            {
                _Platform = value;
                return this;
            }

            /// <summary>
            /// Sets value for FireteamFireteamSummary.ActivityType property.
            /// </summary>
            /// <param name="value">ActivityType</param>
            public FireteamFireteamSummaryBuilder ActivityType(int? value)
            {
                _ActivityType = value;
                return this;
            }

            /// <summary>
            /// Sets value for FireteamFireteamSummary.IsImmediate property.
            /// </summary>
            /// <param name="value">IsImmediate</param>
            public FireteamFireteamSummaryBuilder IsImmediate(bool? value)
            {
                _IsImmediate = value;
                return this;
            }

            /// <summary>
            /// Sets value for FireteamFireteamSummary.ScheduledTime property.
            /// </summary>
            /// <param name="value">ScheduledTime</param>
            public FireteamFireteamSummaryBuilder ScheduledTime(DateTime? value)
            {
                _ScheduledTime = value;
                return this;
            }

            /// <summary>
            /// Sets value for FireteamFireteamSummary.OwnerMembershipId property.
            /// </summary>
            /// <param name="value">OwnerMembershipId</param>
            public FireteamFireteamSummaryBuilder OwnerMembershipId(long? value)
            {
                _OwnerMembershipId = value;
                return this;
            }

            /// <summary>
            /// Sets value for FireteamFireteamSummary.PlayerSlotCount property.
            /// </summary>
            /// <param name="value">PlayerSlotCount</param>
            public FireteamFireteamSummaryBuilder PlayerSlotCount(int? value)
            {
                _PlayerSlotCount = value;
                return this;
            }

            /// <summary>
            /// Sets value for FireteamFireteamSummary.AlternateSlotCount property.
            /// </summary>
            /// <param name="value">AlternateSlotCount</param>
            public FireteamFireteamSummaryBuilder AlternateSlotCount(int? value)
            {
                _AlternateSlotCount = value;
                return this;
            }

            /// <summary>
            /// Sets value for FireteamFireteamSummary.AvailablePlayerSlotCount property.
            /// </summary>
            /// <param name="value">AvailablePlayerSlotCount</param>
            public FireteamFireteamSummaryBuilder AvailablePlayerSlotCount(int? value)
            {
                _AvailablePlayerSlotCount = value;
                return this;
            }

            /// <summary>
            /// Sets value for FireteamFireteamSummary.AvailableAlternateSlotCount property.
            /// </summary>
            /// <param name="value">AvailableAlternateSlotCount</param>
            public FireteamFireteamSummaryBuilder AvailableAlternateSlotCount(int? value)
            {
                _AvailableAlternateSlotCount = value;
                return this;
            }

            /// <summary>
            /// Sets value for FireteamFireteamSummary.Title property.
            /// </summary>
            /// <param name="value">Title</param>
            public FireteamFireteamSummaryBuilder Title(string value)
            {
                _Title = value;
                return this;
            }

            /// <summary>
            /// Sets value for FireteamFireteamSummary.DateCreated property.
            /// </summary>
            /// <param name="value">DateCreated</param>
            public FireteamFireteamSummaryBuilder DateCreated(DateTime? value)
            {
                _DateCreated = value;
                return this;
            }

            /// <summary>
            /// Sets value for FireteamFireteamSummary.DateModified property.
            /// </summary>
            /// <param name="value">DateModified</param>
            public FireteamFireteamSummaryBuilder DateModified(DateTime? value)
            {
                _DateModified = value;
                return this;
            }

            /// <summary>
            /// Sets value for FireteamFireteamSummary.IsPublic property.
            /// </summary>
            /// <param name="value">IsPublic</param>
            public FireteamFireteamSummaryBuilder IsPublic(bool? value)
            {
                _IsPublic = value;
                return this;
            }

            /// <summary>
            /// Sets value for FireteamFireteamSummary.Locale property.
            /// </summary>
            /// <param name="value">Locale</param>
            public FireteamFireteamSummaryBuilder Locale(string value)
            {
                _Locale = value;
                return this;
            }

            /// <summary>
            /// Sets value for FireteamFireteamSummary.IsValid property.
            /// </summary>
            /// <param name="value">IsValid</param>
            public FireteamFireteamSummaryBuilder IsValid(bool? value)
            {
                _IsValid = value;
                return this;
            }

            /// <summary>
            /// Sets value for FireteamFireteamSummary.DatePlayerModified property.
            /// </summary>
            /// <param name="value">DatePlayerModified</param>
            public FireteamFireteamSummaryBuilder DatePlayerModified(DateTime? value)
            {
                _DatePlayerModified = value;
                return this;
            }

            /// <summary>
            /// Sets value for FireteamFireteamSummary.TitleBeforeModeration property.
            /// </summary>
            /// <param name="value">TitleBeforeModeration</param>
            public FireteamFireteamSummaryBuilder TitleBeforeModeration(string value)
            {
                _TitleBeforeModeration = value;
                return this;
            }


            /// <summary>
            /// Builds instance of FireteamFireteamSummary.
            /// </summary>
            /// <returns>FireteamFireteamSummary</returns>
            public FireteamFireteamSummary Build()
            {
                Validate();
                return new FireteamFireteamSummary(
                    FireteamId: _FireteamId,
                    GroupId: _GroupId,
                    Platform: _Platform,
                    ActivityType: _ActivityType,
                    IsImmediate: _IsImmediate,
                    ScheduledTime: _ScheduledTime,
                    OwnerMembershipId: _OwnerMembershipId,
                    PlayerSlotCount: _PlayerSlotCount,
                    AlternateSlotCount: _AlternateSlotCount,
                    AvailablePlayerSlotCount: _AvailablePlayerSlotCount,
                    AvailableAlternateSlotCount: _AvailableAlternateSlotCount,
                    Title: _Title,
                    DateCreated: _DateCreated,
                    DateModified: _DateModified,
                    IsPublic: _IsPublic,
                    Locale: _Locale,
                    IsValid: _IsValid,
                    DatePlayerModified: _DatePlayerModified,
                    TitleBeforeModeration: _TitleBeforeModeration
                );
            }

            private void Validate()
            { 
            }
        }

        
    }
}