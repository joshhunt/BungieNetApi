using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Sharpility.Extensions;
using NodaTime;

namespace BungieNetApi._Platform.Models
{
    /// <summary>
    /// DestinyAdvancedAwaAuthorizationResult
    /// </summary>
    public sealed class DestinyAdvancedAwaAuthorizationResult:  IEquatable<DestinyAdvancedAwaAuthorizationResult>
    { 
        /// <summary>
        /// Indication of how the user responded to the request. If the value is \&quot;Approved\&quot; the actionToken will contain the token that can be presented when performing the advanced write action.
        /// </summary>
        public int? UserSelection { get; private set; }

        /// <summary>
        /// ResponseReason
        /// </summary>
        public int? ResponseReason { get; private set; }

        /// <summary>
        /// Message to the app developer to help understand the response.
        /// </summary>
        public string DeveloperNote { get; private set; }

        /// <summary>
        /// Credential used to prove the user authorized an advanced write action.
        /// </summary>
        public string ActionToken { get; private set; }

        /// <summary>
        /// This token may be used to perform the requested action this number of times, at a maximum. If this value is 0, then there is no limit.
        /// </summary>
        public int? MaximumNumberOfUses { get; private set; }

        /// <summary>
        /// Time, UTC, when token expires.
        /// </summary>
        public DateTime? ValidUntil { get; private set; }

        /// <summary>
        /// Advanced Write Action Type from the permission request.
        /// </summary>
        public int? Type { get; private set; }

        /// <summary>
        /// MembershipType from the permission request.
        /// </summary>
        public int? MembershipType { get; private set; }


        /// <summary>
        /// Empty constructor required by some serializers.
        /// Use DestinyAdvancedAwaAuthorizationResult.Builder() for instance creation instead.
        /// </summary>
        [Obsolete]
        public DestinyAdvancedAwaAuthorizationResult()
        {
        }

        private DestinyAdvancedAwaAuthorizationResult(int? UserSelection, int? ResponseReason, string DeveloperNote, string ActionToken, int? MaximumNumberOfUses, DateTime? ValidUntil, int? Type, int? MembershipType)
        {
            
            this.UserSelection = UserSelection;
            
            this.ResponseReason = ResponseReason;
            
            this.DeveloperNote = DeveloperNote;
            
            this.ActionToken = ActionToken;
            
            this.MaximumNumberOfUses = MaximumNumberOfUses;
            
            this.ValidUntil = ValidUntil;
            
            this.Type = Type;
            
            this.MembershipType = MembershipType;
            
        }

        /// <summary>
        /// Returns builder of DestinyAdvancedAwaAuthorizationResult.
        /// </summary>
        /// <returns>DestinyAdvancedAwaAuthorizationResultBuilder</returns>
        public static DestinyAdvancedAwaAuthorizationResultBuilder Builder()
        {
            return new DestinyAdvancedAwaAuthorizationResultBuilder();
        }

        /// <summary>
        /// Returns DestinyAdvancedAwaAuthorizationResultBuilder with properties set.
        /// Use it to change properties.
        /// </summary>
        /// <returns>DestinyAdvancedAwaAuthorizationResultBuilder</returns>
        public DestinyAdvancedAwaAuthorizationResultBuilder With()
        {
            return Builder()
                .UserSelection(UserSelection)
                .ResponseReason(ResponseReason)
                .DeveloperNote(DeveloperNote)
                .ActionToken(ActionToken)
                .MaximumNumberOfUses(MaximumNumberOfUses)
                .ValidUntil(ValidUntil)
                .Type(Type)
                .MembershipType(MembershipType);
        }

        public override string ToString()
        {
            return this.PropertiesToString();
        }

        public override bool Equals(object obj)
        {
            return this.EqualsByProperties(obj);
        }

        public bool Equals(DestinyAdvancedAwaAuthorizationResult other)
        {
            return Equals((object) other);
        }

        public override int GetHashCode()
        {
            return this.PropertiesHash();
        }

        /// <summary>
        /// Implementation of == operator for (DestinyAdvancedAwaAuthorizationResult.
        /// </summary>
        /// <param name="left">Compared (DestinyAdvancedAwaAuthorizationResult</param>
        /// <param name="right">Compared (DestinyAdvancedAwaAuthorizationResult</param>
        /// <returns>true if compared items are equals, false otherwise</returns>
        public static bool operator == (DestinyAdvancedAwaAuthorizationResult left, DestinyAdvancedAwaAuthorizationResult right)
        {
            return Equals(left, right);
        }

        /// <summary>
        /// Implementation of != operator for (DestinyAdvancedAwaAuthorizationResult.
        /// </summary>
        /// <param name="left">Compared (DestinyAdvancedAwaAuthorizationResult</param>
        /// <param name="right">Compared (DestinyAdvancedAwaAuthorizationResult</param>
        /// <returns>true if compared items are not equals, false otherwise</returns>
        public static bool operator != (DestinyAdvancedAwaAuthorizationResult left, DestinyAdvancedAwaAuthorizationResult right)
        {
            return !Equals(left, right);
        }

        /// <summary>
        /// Builder of DestinyAdvancedAwaAuthorizationResult.
        /// </summary>
        public sealed class DestinyAdvancedAwaAuthorizationResultBuilder
        {
            private int? _UserSelection;
            private int? _ResponseReason;
            private string _DeveloperNote;
            private string _ActionToken;
            private int? _MaximumNumberOfUses;
            private DateTime? _ValidUntil;
            private int? _Type;
            private int? _MembershipType;

            internal DestinyAdvancedAwaAuthorizationResultBuilder()
            {
                SetupDefaults();
            }

            private void SetupDefaults()
            {
            }

            /// <summary>
            /// Sets value for DestinyAdvancedAwaAuthorizationResult.UserSelection property.
            /// </summary>
            /// <param name="value">Indication of how the user responded to the request. If the value is \&quot;Approved\&quot; the actionToken will contain the token that can be presented when performing the advanced write action.</param>
            public DestinyAdvancedAwaAuthorizationResultBuilder UserSelection(int? value)
            {
                _UserSelection = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyAdvancedAwaAuthorizationResult.ResponseReason property.
            /// </summary>
            /// <param name="value">ResponseReason</param>
            public DestinyAdvancedAwaAuthorizationResultBuilder ResponseReason(int? value)
            {
                _ResponseReason = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyAdvancedAwaAuthorizationResult.DeveloperNote property.
            /// </summary>
            /// <param name="value">Message to the app developer to help understand the response.</param>
            public DestinyAdvancedAwaAuthorizationResultBuilder DeveloperNote(string value)
            {
                _DeveloperNote = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyAdvancedAwaAuthorizationResult.ActionToken property.
            /// </summary>
            /// <param name="value">Credential used to prove the user authorized an advanced write action.</param>
            public DestinyAdvancedAwaAuthorizationResultBuilder ActionToken(string value)
            {
                _ActionToken = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyAdvancedAwaAuthorizationResult.MaximumNumberOfUses property.
            /// </summary>
            /// <param name="value">This token may be used to perform the requested action this number of times, at a maximum. If this value is 0, then there is no limit.</param>
            public DestinyAdvancedAwaAuthorizationResultBuilder MaximumNumberOfUses(int? value)
            {
                _MaximumNumberOfUses = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyAdvancedAwaAuthorizationResult.ValidUntil property.
            /// </summary>
            /// <param name="value">Time, UTC, when token expires.</param>
            public DestinyAdvancedAwaAuthorizationResultBuilder ValidUntil(DateTime? value)
            {
                _ValidUntil = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyAdvancedAwaAuthorizationResult.Type property.
            /// </summary>
            /// <param name="value">Advanced Write Action Type from the permission request.</param>
            public DestinyAdvancedAwaAuthorizationResultBuilder Type(int? value)
            {
                _Type = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyAdvancedAwaAuthorizationResult.MembershipType property.
            /// </summary>
            /// <param name="value">MembershipType from the permission request.</param>
            public DestinyAdvancedAwaAuthorizationResultBuilder MembershipType(int? value)
            {
                _MembershipType = value;
                return this;
            }


            /// <summary>
            /// Builds instance of DestinyAdvancedAwaAuthorizationResult.
            /// </summary>
            /// <returns>DestinyAdvancedAwaAuthorizationResult</returns>
            public DestinyAdvancedAwaAuthorizationResult Build()
            {
                Validate();
                return new DestinyAdvancedAwaAuthorizationResult(
                    UserSelection: _UserSelection,
                    ResponseReason: _ResponseReason,
                    DeveloperNote: _DeveloperNote,
                    ActionToken: _ActionToken,
                    MaximumNumberOfUses: _MaximumNumberOfUses,
                    ValidUntil: _ValidUntil,
                    Type: _Type,
                    MembershipType: _MembershipType
                );
            }

            private void Validate()
            { 
            }
        }

        
    }
}