using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Sharpility.Extensions;
using NodaTime;

namespace BungieNetApi._Platform.Models
{
    /// <summary>
    /// DestinyAdvancedAwaPermissionRequested
    /// </summary>
    public sealed class DestinyAdvancedAwaPermissionRequested:  IEquatable<DestinyAdvancedAwaPermissionRequested>
    { 
        /// <summary>
        /// Type of advanced write action.
        /// </summary>
        public int? Type { get; private set; }

        /// <summary>
        /// Item instance ID the action shall be applied to. This is optional for all but a new AwaType values. Rule of thumb is to provide the item instance ID if one is available.
        /// </summary>
        public long? AffectedItemId { get; private set; }

        /// <summary>
        /// Destiny membership type of the account to modify.
        /// </summary>
        public int? MembershipType { get; private set; }

        /// <summary>
        /// Destiny character ID, if applicable, that will be affected by the action.
        /// </summary>
        public long? CharacterId { get; private set; }


        /// <summary>
        /// Empty constructor required by some serializers.
        /// Use DestinyAdvancedAwaPermissionRequested.Builder() for instance creation instead.
        /// </summary>
        [Obsolete]
        public DestinyAdvancedAwaPermissionRequested()
        {
        }

        private DestinyAdvancedAwaPermissionRequested(int? Type, long? AffectedItemId, int? MembershipType, long? CharacterId)
        {
            
            this.Type = Type;
            
            this.AffectedItemId = AffectedItemId;
            
            this.MembershipType = MembershipType;
            
            this.CharacterId = CharacterId;
            
        }

        /// <summary>
        /// Returns builder of DestinyAdvancedAwaPermissionRequested.
        /// </summary>
        /// <returns>DestinyAdvancedAwaPermissionRequestedBuilder</returns>
        public static DestinyAdvancedAwaPermissionRequestedBuilder Builder()
        {
            return new DestinyAdvancedAwaPermissionRequestedBuilder();
        }

        /// <summary>
        /// Returns DestinyAdvancedAwaPermissionRequestedBuilder with properties set.
        /// Use it to change properties.
        /// </summary>
        /// <returns>DestinyAdvancedAwaPermissionRequestedBuilder</returns>
        public DestinyAdvancedAwaPermissionRequestedBuilder With()
        {
            return Builder()
                .Type(Type)
                .AffectedItemId(AffectedItemId)
                .MembershipType(MembershipType)
                .CharacterId(CharacterId);
        }

        public override string ToString()
        {
            return this.PropertiesToString();
        }

        public override bool Equals(object obj)
        {
            return this.EqualsByProperties(obj);
        }

        public bool Equals(DestinyAdvancedAwaPermissionRequested other)
        {
            return Equals((object) other);
        }

        public override int GetHashCode()
        {
            return this.PropertiesHash();
        }

        /// <summary>
        /// Implementation of == operator for (DestinyAdvancedAwaPermissionRequested.
        /// </summary>
        /// <param name="left">Compared (DestinyAdvancedAwaPermissionRequested</param>
        /// <param name="right">Compared (DestinyAdvancedAwaPermissionRequested</param>
        /// <returns>true if compared items are equals, false otherwise</returns>
        public static bool operator == (DestinyAdvancedAwaPermissionRequested left, DestinyAdvancedAwaPermissionRequested right)
        {
            return Equals(left, right);
        }

        /// <summary>
        /// Implementation of != operator for (DestinyAdvancedAwaPermissionRequested.
        /// </summary>
        /// <param name="left">Compared (DestinyAdvancedAwaPermissionRequested</param>
        /// <param name="right">Compared (DestinyAdvancedAwaPermissionRequested</param>
        /// <returns>true if compared items are not equals, false otherwise</returns>
        public static bool operator != (DestinyAdvancedAwaPermissionRequested left, DestinyAdvancedAwaPermissionRequested right)
        {
            return !Equals(left, right);
        }

        /// <summary>
        /// Builder of DestinyAdvancedAwaPermissionRequested.
        /// </summary>
        public sealed class DestinyAdvancedAwaPermissionRequestedBuilder
        {
            private int? _Type;
            private long? _AffectedItemId;
            private int? _MembershipType;
            private long? _CharacterId;

            internal DestinyAdvancedAwaPermissionRequestedBuilder()
            {
                SetupDefaults();
            }

            private void SetupDefaults()
            {
            }

            /// <summary>
            /// Sets value for DestinyAdvancedAwaPermissionRequested.Type property.
            /// </summary>
            /// <param name="value">Type of advanced write action.</param>
            public DestinyAdvancedAwaPermissionRequestedBuilder Type(int? value)
            {
                _Type = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyAdvancedAwaPermissionRequested.AffectedItemId property.
            /// </summary>
            /// <param name="value">Item instance ID the action shall be applied to. This is optional for all but a new AwaType values. Rule of thumb is to provide the item instance ID if one is available.</param>
            public DestinyAdvancedAwaPermissionRequestedBuilder AffectedItemId(long? value)
            {
                _AffectedItemId = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyAdvancedAwaPermissionRequested.MembershipType property.
            /// </summary>
            /// <param name="value">Destiny membership type of the account to modify.</param>
            public DestinyAdvancedAwaPermissionRequestedBuilder MembershipType(int? value)
            {
                _MembershipType = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyAdvancedAwaPermissionRequested.CharacterId property.
            /// </summary>
            /// <param name="value">Destiny character ID, if applicable, that will be affected by the action.</param>
            public DestinyAdvancedAwaPermissionRequestedBuilder CharacterId(long? value)
            {
                _CharacterId = value;
                return this;
            }


            /// <summary>
            /// Builds instance of DestinyAdvancedAwaPermissionRequested.
            /// </summary>
            /// <returns>DestinyAdvancedAwaPermissionRequested</returns>
            public DestinyAdvancedAwaPermissionRequested Build()
            {
                Validate();
                return new DestinyAdvancedAwaPermissionRequested(
                    Type: _Type,
                    AffectedItemId: _AffectedItemId,
                    MembershipType: _MembershipType,
                    CharacterId: _CharacterId
                );
            }

            private void Validate()
            { 
            }
        }

        
    }
}