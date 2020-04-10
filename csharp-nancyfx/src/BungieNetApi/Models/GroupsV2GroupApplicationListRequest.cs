using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Sharpility.Extensions;
using NodaTime;

namespace BungieNetApi._Platform.Models
{
    /// <summary>
    /// GroupsV2GroupApplicationListRequest
    /// </summary>
    public sealed class GroupsV2GroupApplicationListRequest:  IEquatable<GroupsV2GroupApplicationListRequest>
    { 
        /// <summary>
        /// Memberships
        /// </summary>
        public List<UserUserMembership> Memberships { get; private set; }

        /// <summary>
        /// Message
        /// </summary>
        public string Message { get; private set; }


        /// <summary>
        /// Empty constructor required by some serializers.
        /// Use GroupsV2GroupApplicationListRequest.Builder() for instance creation instead.
        /// </summary>
        [Obsolete]
        public GroupsV2GroupApplicationListRequest()
        {
        }

        private GroupsV2GroupApplicationListRequest(List<UserUserMembership> Memberships, string Message)
        {
            
            this.Memberships = Memberships;
            
            this.Message = Message;
            
        }

        /// <summary>
        /// Returns builder of GroupsV2GroupApplicationListRequest.
        /// </summary>
        /// <returns>GroupsV2GroupApplicationListRequestBuilder</returns>
        public static GroupsV2GroupApplicationListRequestBuilder Builder()
        {
            return new GroupsV2GroupApplicationListRequestBuilder();
        }

        /// <summary>
        /// Returns GroupsV2GroupApplicationListRequestBuilder with properties set.
        /// Use it to change properties.
        /// </summary>
        /// <returns>GroupsV2GroupApplicationListRequestBuilder</returns>
        public GroupsV2GroupApplicationListRequestBuilder With()
        {
            return Builder()
                .Memberships(Memberships)
                .Message(Message);
        }

        public override string ToString()
        {
            return this.PropertiesToString();
        }

        public override bool Equals(object obj)
        {
            return this.EqualsByProperties(obj);
        }

        public bool Equals(GroupsV2GroupApplicationListRequest other)
        {
            return Equals((object) other);
        }

        public override int GetHashCode()
        {
            return this.PropertiesHash();
        }

        /// <summary>
        /// Implementation of == operator for (GroupsV2GroupApplicationListRequest.
        /// </summary>
        /// <param name="left">Compared (GroupsV2GroupApplicationListRequest</param>
        /// <param name="right">Compared (GroupsV2GroupApplicationListRequest</param>
        /// <returns>true if compared items are equals, false otherwise</returns>
        public static bool operator == (GroupsV2GroupApplicationListRequest left, GroupsV2GroupApplicationListRequest right)
        {
            return Equals(left, right);
        }

        /// <summary>
        /// Implementation of != operator for (GroupsV2GroupApplicationListRequest.
        /// </summary>
        /// <param name="left">Compared (GroupsV2GroupApplicationListRequest</param>
        /// <param name="right">Compared (GroupsV2GroupApplicationListRequest</param>
        /// <returns>true if compared items are not equals, false otherwise</returns>
        public static bool operator != (GroupsV2GroupApplicationListRequest left, GroupsV2GroupApplicationListRequest right)
        {
            return !Equals(left, right);
        }

        /// <summary>
        /// Builder of GroupsV2GroupApplicationListRequest.
        /// </summary>
        public sealed class GroupsV2GroupApplicationListRequestBuilder
        {
            private List<UserUserMembership> _Memberships;
            private string _Message;

            internal GroupsV2GroupApplicationListRequestBuilder()
            {
                SetupDefaults();
            }

            private void SetupDefaults()
            {
            }

            /// <summary>
            /// Sets value for GroupsV2GroupApplicationListRequest.Memberships property.
            /// </summary>
            /// <param name="value">Memberships</param>
            public GroupsV2GroupApplicationListRequestBuilder Memberships(List<UserUserMembership> value)
            {
                _Memberships = value;
                return this;
            }

            /// <summary>
            /// Sets value for GroupsV2GroupApplicationListRequest.Message property.
            /// </summary>
            /// <param name="value">Message</param>
            public GroupsV2GroupApplicationListRequestBuilder Message(string value)
            {
                _Message = value;
                return this;
            }


            /// <summary>
            /// Builds instance of GroupsV2GroupApplicationListRequest.
            /// </summary>
            /// <returns>GroupsV2GroupApplicationListRequest</returns>
            public GroupsV2GroupApplicationListRequest Build()
            {
                Validate();
                return new GroupsV2GroupApplicationListRequest(
                    Memberships: _Memberships,
                    Message: _Message
                );
            }

            private void Validate()
            { 
            }
        }

        
    }
}