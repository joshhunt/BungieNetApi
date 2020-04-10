using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Sharpility.Extensions;
using NodaTime;

namespace BungieNetApi._Platform.Models
{
    /// <summary>
    /// GroupsV2GroupApplicationRequest
    /// </summary>
    public sealed class GroupsV2GroupApplicationRequest:  IEquatable<GroupsV2GroupApplicationRequest>
    { 
        /// <summary>
        /// Message
        /// </summary>
        public string Message { get; private set; }


        /// <summary>
        /// Empty constructor required by some serializers.
        /// Use GroupsV2GroupApplicationRequest.Builder() for instance creation instead.
        /// </summary>
        [Obsolete]
        public GroupsV2GroupApplicationRequest()
        {
        }

        private GroupsV2GroupApplicationRequest(string Message)
        {
            
            this.Message = Message;
            
        }

        /// <summary>
        /// Returns builder of GroupsV2GroupApplicationRequest.
        /// </summary>
        /// <returns>GroupsV2GroupApplicationRequestBuilder</returns>
        public static GroupsV2GroupApplicationRequestBuilder Builder()
        {
            return new GroupsV2GroupApplicationRequestBuilder();
        }

        /// <summary>
        /// Returns GroupsV2GroupApplicationRequestBuilder with properties set.
        /// Use it to change properties.
        /// </summary>
        /// <returns>GroupsV2GroupApplicationRequestBuilder</returns>
        public GroupsV2GroupApplicationRequestBuilder With()
        {
            return Builder()
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

        public bool Equals(GroupsV2GroupApplicationRequest other)
        {
            return Equals((object) other);
        }

        public override int GetHashCode()
        {
            return this.PropertiesHash();
        }

        /// <summary>
        /// Implementation of == operator for (GroupsV2GroupApplicationRequest.
        /// </summary>
        /// <param name="left">Compared (GroupsV2GroupApplicationRequest</param>
        /// <param name="right">Compared (GroupsV2GroupApplicationRequest</param>
        /// <returns>true if compared items are equals, false otherwise</returns>
        public static bool operator == (GroupsV2GroupApplicationRequest left, GroupsV2GroupApplicationRequest right)
        {
            return Equals(left, right);
        }

        /// <summary>
        /// Implementation of != operator for (GroupsV2GroupApplicationRequest.
        /// </summary>
        /// <param name="left">Compared (GroupsV2GroupApplicationRequest</param>
        /// <param name="right">Compared (GroupsV2GroupApplicationRequest</param>
        /// <returns>true if compared items are not equals, false otherwise</returns>
        public static bool operator != (GroupsV2GroupApplicationRequest left, GroupsV2GroupApplicationRequest right)
        {
            return !Equals(left, right);
        }

        /// <summary>
        /// Builder of GroupsV2GroupApplicationRequest.
        /// </summary>
        public sealed class GroupsV2GroupApplicationRequestBuilder
        {
            private string _Message;

            internal GroupsV2GroupApplicationRequestBuilder()
            {
                SetupDefaults();
            }

            private void SetupDefaults()
            {
            }

            /// <summary>
            /// Sets value for GroupsV2GroupApplicationRequest.Message property.
            /// </summary>
            /// <param name="value">Message</param>
            public GroupsV2GroupApplicationRequestBuilder Message(string value)
            {
                _Message = value;
                return this;
            }


            /// <summary>
            /// Builds instance of GroupsV2GroupApplicationRequest.
            /// </summary>
            /// <returns>GroupsV2GroupApplicationRequest</returns>
            public GroupsV2GroupApplicationRequest Build()
            {
                Validate();
                return new GroupsV2GroupApplicationRequest(
                    Message: _Message
                );
            }

            private void Validate()
            { 
            }
        }

        
    }
}