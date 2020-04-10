using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Sharpility.Extensions;
using NodaTime;

namespace BungieNetApi._Platform.Models
{
    /// <summary>
    /// GroupsV2GroupOptionalConversationAddRequest
    /// </summary>
    public sealed class GroupsV2GroupOptionalConversationAddRequest:  IEquatable<GroupsV2GroupOptionalConversationAddRequest>
    { 
        /// <summary>
        /// ChatName
        /// </summary>
        public string ChatName { get; private set; }

        /// <summary>
        /// ChatSecurity
        /// </summary>
        public int? ChatSecurity { get; private set; }


        /// <summary>
        /// Empty constructor required by some serializers.
        /// Use GroupsV2GroupOptionalConversationAddRequest.Builder() for instance creation instead.
        /// </summary>
        [Obsolete]
        public GroupsV2GroupOptionalConversationAddRequest()
        {
        }

        private GroupsV2GroupOptionalConversationAddRequest(string ChatName, int? ChatSecurity)
        {
            
            this.ChatName = ChatName;
            
            this.ChatSecurity = ChatSecurity;
            
        }

        /// <summary>
        /// Returns builder of GroupsV2GroupOptionalConversationAddRequest.
        /// </summary>
        /// <returns>GroupsV2GroupOptionalConversationAddRequestBuilder</returns>
        public static GroupsV2GroupOptionalConversationAddRequestBuilder Builder()
        {
            return new GroupsV2GroupOptionalConversationAddRequestBuilder();
        }

        /// <summary>
        /// Returns GroupsV2GroupOptionalConversationAddRequestBuilder with properties set.
        /// Use it to change properties.
        /// </summary>
        /// <returns>GroupsV2GroupOptionalConversationAddRequestBuilder</returns>
        public GroupsV2GroupOptionalConversationAddRequestBuilder With()
        {
            return Builder()
                .ChatName(ChatName)
                .ChatSecurity(ChatSecurity);
        }

        public override string ToString()
        {
            return this.PropertiesToString();
        }

        public override bool Equals(object obj)
        {
            return this.EqualsByProperties(obj);
        }

        public bool Equals(GroupsV2GroupOptionalConversationAddRequest other)
        {
            return Equals((object) other);
        }

        public override int GetHashCode()
        {
            return this.PropertiesHash();
        }

        /// <summary>
        /// Implementation of == operator for (GroupsV2GroupOptionalConversationAddRequest.
        /// </summary>
        /// <param name="left">Compared (GroupsV2GroupOptionalConversationAddRequest</param>
        /// <param name="right">Compared (GroupsV2GroupOptionalConversationAddRequest</param>
        /// <returns>true if compared items are equals, false otherwise</returns>
        public static bool operator == (GroupsV2GroupOptionalConversationAddRequest left, GroupsV2GroupOptionalConversationAddRequest right)
        {
            return Equals(left, right);
        }

        /// <summary>
        /// Implementation of != operator for (GroupsV2GroupOptionalConversationAddRequest.
        /// </summary>
        /// <param name="left">Compared (GroupsV2GroupOptionalConversationAddRequest</param>
        /// <param name="right">Compared (GroupsV2GroupOptionalConversationAddRequest</param>
        /// <returns>true if compared items are not equals, false otherwise</returns>
        public static bool operator != (GroupsV2GroupOptionalConversationAddRequest left, GroupsV2GroupOptionalConversationAddRequest right)
        {
            return !Equals(left, right);
        }

        /// <summary>
        /// Builder of GroupsV2GroupOptionalConversationAddRequest.
        /// </summary>
        public sealed class GroupsV2GroupOptionalConversationAddRequestBuilder
        {
            private string _ChatName;
            private int? _ChatSecurity;

            internal GroupsV2GroupOptionalConversationAddRequestBuilder()
            {
                SetupDefaults();
            }

            private void SetupDefaults()
            {
            }

            /// <summary>
            /// Sets value for GroupsV2GroupOptionalConversationAddRequest.ChatName property.
            /// </summary>
            /// <param name="value">ChatName</param>
            public GroupsV2GroupOptionalConversationAddRequestBuilder ChatName(string value)
            {
                _ChatName = value;
                return this;
            }

            /// <summary>
            /// Sets value for GroupsV2GroupOptionalConversationAddRequest.ChatSecurity property.
            /// </summary>
            /// <param name="value">ChatSecurity</param>
            public GroupsV2GroupOptionalConversationAddRequestBuilder ChatSecurity(int? value)
            {
                _ChatSecurity = value;
                return this;
            }


            /// <summary>
            /// Builds instance of GroupsV2GroupOptionalConversationAddRequest.
            /// </summary>
            /// <returns>GroupsV2GroupOptionalConversationAddRequest</returns>
            public GroupsV2GroupOptionalConversationAddRequest Build()
            {
                Validate();
                return new GroupsV2GroupOptionalConversationAddRequest(
                    ChatName: _ChatName,
                    ChatSecurity: _ChatSecurity
                );
            }

            private void Validate()
            { 
            }
        }

        
    }
}