using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Sharpility.Extensions;
using NodaTime;

namespace BungieNetApi._Platform.Models
{
    /// <summary>
    /// GroupsV2GroupOptionalConversation
    /// </summary>
    public sealed class GroupsV2GroupOptionalConversation:  IEquatable<GroupsV2GroupOptionalConversation>
    { 
        /// <summary>
        /// GroupId
        /// </summary>
        public long? GroupId { get; private set; }

        /// <summary>
        /// ConversationId
        /// </summary>
        public long? ConversationId { get; private set; }

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
        public int? ChatSecurity { get; private set; }


        /// <summary>
        /// Empty constructor required by some serializers.
        /// Use GroupsV2GroupOptionalConversation.Builder() for instance creation instead.
        /// </summary>
        [Obsolete]
        public GroupsV2GroupOptionalConversation()
        {
        }

        private GroupsV2GroupOptionalConversation(long? GroupId, long? ConversationId, bool? ChatEnabled, string ChatName, int? ChatSecurity)
        {
            
            this.GroupId = GroupId;
            
            this.ConversationId = ConversationId;
            
            this.ChatEnabled = ChatEnabled;
            
            this.ChatName = ChatName;
            
            this.ChatSecurity = ChatSecurity;
            
        }

        /// <summary>
        /// Returns builder of GroupsV2GroupOptionalConversation.
        /// </summary>
        /// <returns>GroupsV2GroupOptionalConversationBuilder</returns>
        public static GroupsV2GroupOptionalConversationBuilder Builder()
        {
            return new GroupsV2GroupOptionalConversationBuilder();
        }

        /// <summary>
        /// Returns GroupsV2GroupOptionalConversationBuilder with properties set.
        /// Use it to change properties.
        /// </summary>
        /// <returns>GroupsV2GroupOptionalConversationBuilder</returns>
        public GroupsV2GroupOptionalConversationBuilder With()
        {
            return Builder()
                .GroupId(GroupId)
                .ConversationId(ConversationId)
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

        public bool Equals(GroupsV2GroupOptionalConversation other)
        {
            return Equals((object) other);
        }

        public override int GetHashCode()
        {
            return this.PropertiesHash();
        }

        /// <summary>
        /// Implementation of == operator for (GroupsV2GroupOptionalConversation.
        /// </summary>
        /// <param name="left">Compared (GroupsV2GroupOptionalConversation</param>
        /// <param name="right">Compared (GroupsV2GroupOptionalConversation</param>
        /// <returns>true if compared items are equals, false otherwise</returns>
        public static bool operator == (GroupsV2GroupOptionalConversation left, GroupsV2GroupOptionalConversation right)
        {
            return Equals(left, right);
        }

        /// <summary>
        /// Implementation of != operator for (GroupsV2GroupOptionalConversation.
        /// </summary>
        /// <param name="left">Compared (GroupsV2GroupOptionalConversation</param>
        /// <param name="right">Compared (GroupsV2GroupOptionalConversation</param>
        /// <returns>true if compared items are not equals, false otherwise</returns>
        public static bool operator != (GroupsV2GroupOptionalConversation left, GroupsV2GroupOptionalConversation right)
        {
            return !Equals(left, right);
        }

        /// <summary>
        /// Builder of GroupsV2GroupOptionalConversation.
        /// </summary>
        public sealed class GroupsV2GroupOptionalConversationBuilder
        {
            private long? _GroupId;
            private long? _ConversationId;
            private bool? _ChatEnabled;
            private string _ChatName;
            private int? _ChatSecurity;

            internal GroupsV2GroupOptionalConversationBuilder()
            {
                SetupDefaults();
            }

            private void SetupDefaults()
            {
            }

            /// <summary>
            /// Sets value for GroupsV2GroupOptionalConversation.GroupId property.
            /// </summary>
            /// <param name="value">GroupId</param>
            public GroupsV2GroupOptionalConversationBuilder GroupId(long? value)
            {
                _GroupId = value;
                return this;
            }

            /// <summary>
            /// Sets value for GroupsV2GroupOptionalConversation.ConversationId property.
            /// </summary>
            /// <param name="value">ConversationId</param>
            public GroupsV2GroupOptionalConversationBuilder ConversationId(long? value)
            {
                _ConversationId = value;
                return this;
            }

            /// <summary>
            /// Sets value for GroupsV2GroupOptionalConversation.ChatEnabled property.
            /// </summary>
            /// <param name="value">ChatEnabled</param>
            public GroupsV2GroupOptionalConversationBuilder ChatEnabled(bool? value)
            {
                _ChatEnabled = value;
                return this;
            }

            /// <summary>
            /// Sets value for GroupsV2GroupOptionalConversation.ChatName property.
            /// </summary>
            /// <param name="value">ChatName</param>
            public GroupsV2GroupOptionalConversationBuilder ChatName(string value)
            {
                _ChatName = value;
                return this;
            }

            /// <summary>
            /// Sets value for GroupsV2GroupOptionalConversation.ChatSecurity property.
            /// </summary>
            /// <param name="value">ChatSecurity</param>
            public GroupsV2GroupOptionalConversationBuilder ChatSecurity(int? value)
            {
                _ChatSecurity = value;
                return this;
            }


            /// <summary>
            /// Builds instance of GroupsV2GroupOptionalConversation.
            /// </summary>
            /// <returns>GroupsV2GroupOptionalConversation</returns>
            public GroupsV2GroupOptionalConversation Build()
            {
                Validate();
                return new GroupsV2GroupOptionalConversation(
                    GroupId: _GroupId,
                    ConversationId: _ConversationId,
                    ChatEnabled: _ChatEnabled,
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