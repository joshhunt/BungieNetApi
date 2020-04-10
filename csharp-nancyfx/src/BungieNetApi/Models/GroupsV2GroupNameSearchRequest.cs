using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Sharpility.Extensions;
using NodaTime;

namespace BungieNetApi._Platform.Models
{
    /// <summary>
    /// GroupsV2GroupNameSearchRequest
    /// </summary>
    public sealed class GroupsV2GroupNameSearchRequest:  IEquatable<GroupsV2GroupNameSearchRequest>
    { 
        /// <summary>
        /// GroupName
        /// </summary>
        public string GroupName { get; private set; }

        /// <summary>
        /// GroupType
        /// </summary>
        public int? GroupType { get; private set; }


        /// <summary>
        /// Empty constructor required by some serializers.
        /// Use GroupsV2GroupNameSearchRequest.Builder() for instance creation instead.
        /// </summary>
        [Obsolete]
        public GroupsV2GroupNameSearchRequest()
        {
        }

        private GroupsV2GroupNameSearchRequest(string GroupName, int? GroupType)
        {
            
            this.GroupName = GroupName;
            
            this.GroupType = GroupType;
            
        }

        /// <summary>
        /// Returns builder of GroupsV2GroupNameSearchRequest.
        /// </summary>
        /// <returns>GroupsV2GroupNameSearchRequestBuilder</returns>
        public static GroupsV2GroupNameSearchRequestBuilder Builder()
        {
            return new GroupsV2GroupNameSearchRequestBuilder();
        }

        /// <summary>
        /// Returns GroupsV2GroupNameSearchRequestBuilder with properties set.
        /// Use it to change properties.
        /// </summary>
        /// <returns>GroupsV2GroupNameSearchRequestBuilder</returns>
        public GroupsV2GroupNameSearchRequestBuilder With()
        {
            return Builder()
                .GroupName(GroupName)
                .GroupType(GroupType);
        }

        public override string ToString()
        {
            return this.PropertiesToString();
        }

        public override bool Equals(object obj)
        {
            return this.EqualsByProperties(obj);
        }

        public bool Equals(GroupsV2GroupNameSearchRequest other)
        {
            return Equals((object) other);
        }

        public override int GetHashCode()
        {
            return this.PropertiesHash();
        }

        /// <summary>
        /// Implementation of == operator for (GroupsV2GroupNameSearchRequest.
        /// </summary>
        /// <param name="left">Compared (GroupsV2GroupNameSearchRequest</param>
        /// <param name="right">Compared (GroupsV2GroupNameSearchRequest</param>
        /// <returns>true if compared items are equals, false otherwise</returns>
        public static bool operator == (GroupsV2GroupNameSearchRequest left, GroupsV2GroupNameSearchRequest right)
        {
            return Equals(left, right);
        }

        /// <summary>
        /// Implementation of != operator for (GroupsV2GroupNameSearchRequest.
        /// </summary>
        /// <param name="left">Compared (GroupsV2GroupNameSearchRequest</param>
        /// <param name="right">Compared (GroupsV2GroupNameSearchRequest</param>
        /// <returns>true if compared items are not equals, false otherwise</returns>
        public static bool operator != (GroupsV2GroupNameSearchRequest left, GroupsV2GroupNameSearchRequest right)
        {
            return !Equals(left, right);
        }

        /// <summary>
        /// Builder of GroupsV2GroupNameSearchRequest.
        /// </summary>
        public sealed class GroupsV2GroupNameSearchRequestBuilder
        {
            private string _GroupName;
            private int? _GroupType;

            internal GroupsV2GroupNameSearchRequestBuilder()
            {
                SetupDefaults();
            }

            private void SetupDefaults()
            {
            }

            /// <summary>
            /// Sets value for GroupsV2GroupNameSearchRequest.GroupName property.
            /// </summary>
            /// <param name="value">GroupName</param>
            public GroupsV2GroupNameSearchRequestBuilder GroupName(string value)
            {
                _GroupName = value;
                return this;
            }

            /// <summary>
            /// Sets value for GroupsV2GroupNameSearchRequest.GroupType property.
            /// </summary>
            /// <param name="value">GroupType</param>
            public GroupsV2GroupNameSearchRequestBuilder GroupType(int? value)
            {
                _GroupType = value;
                return this;
            }


            /// <summary>
            /// Builds instance of GroupsV2GroupNameSearchRequest.
            /// </summary>
            /// <returns>GroupsV2GroupNameSearchRequest</returns>
            public GroupsV2GroupNameSearchRequest Build()
            {
                Validate();
                return new GroupsV2GroupNameSearchRequest(
                    GroupName: _GroupName,
                    GroupType: _GroupType
                );
            }

            private void Validate()
            { 
            }
        }

        
    }
}