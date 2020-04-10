using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Sharpility.Extensions;
using NodaTime;

namespace BungieNetApi._Platform.Models
{
    /// <summary>
    /// GroupsV2GroupOptionalConversationEditRequest
    /// </summary>
    public sealed class GroupsV2GroupOptionalConversationEditRequest:  IEquatable<GroupsV2GroupOptionalConversationEditRequest>
    { 
        /// <summary>
        /// ChatEnabled
        /// </summary>
        public bool? ChatEnabled { get; private set; }

        /// <summary>
        /// ChatName
        /// </summary>
        public string ChatName { get; private set; }

        /// <summary>
        /// ChatSecurity
        /// </summary>
        public ChatSecurityEnum? ChatSecurity { get; private set; }


        /// <summary>
        /// Empty constructor required by some serializers.
        /// Use GroupsV2GroupOptionalConversationEditRequest.Builder() for instance creation instead.
        /// </summary>
        [Obsolete]
        public GroupsV2GroupOptionalConversationEditRequest()
        {
        }

        private GroupsV2GroupOptionalConversationEditRequest(bool? ChatEnabled, string ChatName, ChatSecurityEnum? ChatSecurity)
        {
            
            this.ChatEnabled = ChatEnabled;
            
            this.ChatName = ChatName;
            
            this.ChatSecurity = ChatSecurity;
            
        }

        /// <summary>
        /// Returns builder of GroupsV2GroupOptionalConversationEditRequest.
        /// </summary>
        /// <returns>GroupsV2GroupOptionalConversationEditRequestBuilder</returns>
        public static GroupsV2GroupOptionalConversationEditRequestBuilder Builder()
        {
            return new GroupsV2GroupOptionalConversationEditRequestBuilder();
        }

        /// <summary>
        /// Returns GroupsV2GroupOptionalConversationEditRequestBuilder with properties set.
        /// Use it to change properties.
        /// </summary>
        /// <returns>GroupsV2GroupOptionalConversationEditRequestBuilder</returns>
        public GroupsV2GroupOptionalConversationEditRequestBuilder With()
        {
            return Builder()
                .ChatEnabled(ChatEnabled)
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

        public bool Equals(GroupsV2GroupOptionalConversationEditRequest other)
        {
            return Equals((object) other);
        }

        public override int GetHashCode()
        {
            return this.PropertiesHash();
        }

        /// <summary>
        /// Implementation of == operator for (GroupsV2GroupOptionalConversationEditRequest.
        /// </summary>
        /// <param name="left">Compared (GroupsV2GroupOptionalConversationEditRequest</param>
        /// <param name="right">Compared (GroupsV2GroupOptionalConversationEditRequest</param>
        /// <returns>true if compared items are equals, false otherwise</returns>
        public static bool operator == (GroupsV2GroupOptionalConversationEditRequest left, GroupsV2GroupOptionalConversationEditRequest right)
        {
            return Equals(left, right);
        }

        /// <summary>
        /// Implementation of != operator for (GroupsV2GroupOptionalConversationEditRequest.
        /// </summary>
        /// <param name="left">Compared (GroupsV2GroupOptionalConversationEditRequest</param>
        /// <param name="right">Compared (GroupsV2GroupOptionalConversationEditRequest</param>
        /// <returns>true if compared items are not equals, false otherwise</returns>
        public static bool operator != (GroupsV2GroupOptionalConversationEditRequest left, GroupsV2GroupOptionalConversationEditRequest right)
        {
            return !Equals(left, right);
        }

        /// <summary>
        /// Builder of GroupsV2GroupOptionalConversationEditRequest.
        /// </summary>
        public sealed class GroupsV2GroupOptionalConversationEditRequestBuilder
        {
            private bool? _ChatEnabled;
            private string _ChatName;
            private ChatSecurityEnum? _ChatSecurity;

            internal GroupsV2GroupOptionalConversationEditRequestBuilder()
            {
                SetupDefaults();
            }

            private void SetupDefaults()
            {
            }

            /// <summary>
            /// Sets value for GroupsV2GroupOptionalConversationEditRequest.ChatEnabled property.
            /// </summary>
            /// <param name="value">ChatEnabled</param>
            public GroupsV2GroupOptionalConversationEditRequestBuilder ChatEnabled(bool? value)
            {
                _ChatEnabled = value;
                return this;
            }

            /// <summary>
            /// Sets value for GroupsV2GroupOptionalConversationEditRequest.ChatName property.
            /// </summary>
            /// <param name="value">ChatName</param>
            public GroupsV2GroupOptionalConversationEditRequestBuilder ChatName(string value)
            {
                _ChatName = value;
                return this;
            }

            /// <summary>
            /// Sets value for GroupsV2GroupOptionalConversationEditRequest.ChatSecurity property.
            /// </summary>
            /// <param name="value">ChatSecurity</param>
            public GroupsV2GroupOptionalConversationEditRequestBuilder ChatSecurity(ChatSecurityEnum? value)
            {
                _ChatSecurity = value;
                return this;
            }


            /// <summary>
            /// Builds instance of GroupsV2GroupOptionalConversationEditRequest.
            /// </summary>
            /// <returns>GroupsV2GroupOptionalConversationEditRequest</returns>
            public GroupsV2GroupOptionalConversationEditRequest Build()
            {
                Validate();
                return new GroupsV2GroupOptionalConversationEditRequest(
                    ChatEnabled: _ChatEnabled,
                    ChatName: _ChatName,
                    ChatSecurity: _ChatSecurity
                );
            }

            private void Validate()
            { 
            }
        }

        
        public enum ChatSecurityEnum { _0, _1 };
    }
}