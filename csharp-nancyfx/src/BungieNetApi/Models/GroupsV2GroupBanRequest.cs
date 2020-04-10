using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Sharpility.Extensions;
using NodaTime;

namespace BungieNetApi._Platform.Models
{
    /// <summary>
    /// GroupsV2GroupBanRequest
    /// </summary>
    public sealed class GroupsV2GroupBanRequest:  IEquatable<GroupsV2GroupBanRequest>
    { 
        /// <summary>
        /// Comment
        /// </summary>
        public string Comment { get; private set; }

        /// <summary>
        /// Length
        /// </summary>
        public int? Length { get; private set; }


        /// <summary>
        /// Empty constructor required by some serializers.
        /// Use GroupsV2GroupBanRequest.Builder() for instance creation instead.
        /// </summary>
        [Obsolete]
        public GroupsV2GroupBanRequest()
        {
        }

        private GroupsV2GroupBanRequest(string Comment, int? Length)
        {
            
            this.Comment = Comment;
            
            this.Length = Length;
            
        }

        /// <summary>
        /// Returns builder of GroupsV2GroupBanRequest.
        /// </summary>
        /// <returns>GroupsV2GroupBanRequestBuilder</returns>
        public static GroupsV2GroupBanRequestBuilder Builder()
        {
            return new GroupsV2GroupBanRequestBuilder();
        }

        /// <summary>
        /// Returns GroupsV2GroupBanRequestBuilder with properties set.
        /// Use it to change properties.
        /// </summary>
        /// <returns>GroupsV2GroupBanRequestBuilder</returns>
        public GroupsV2GroupBanRequestBuilder With()
        {
            return Builder()
                .Comment(Comment)
                .Length(Length);
        }

        public override string ToString()
        {
            return this.PropertiesToString();
        }

        public override bool Equals(object obj)
        {
            return this.EqualsByProperties(obj);
        }

        public bool Equals(GroupsV2GroupBanRequest other)
        {
            return Equals((object) other);
        }

        public override int GetHashCode()
        {
            return this.PropertiesHash();
        }

        /// <summary>
        /// Implementation of == operator for (GroupsV2GroupBanRequest.
        /// </summary>
        /// <param name="left">Compared (GroupsV2GroupBanRequest</param>
        /// <param name="right">Compared (GroupsV2GroupBanRequest</param>
        /// <returns>true if compared items are equals, false otherwise</returns>
        public static bool operator == (GroupsV2GroupBanRequest left, GroupsV2GroupBanRequest right)
        {
            return Equals(left, right);
        }

        /// <summary>
        /// Implementation of != operator for (GroupsV2GroupBanRequest.
        /// </summary>
        /// <param name="left">Compared (GroupsV2GroupBanRequest</param>
        /// <param name="right">Compared (GroupsV2GroupBanRequest</param>
        /// <returns>true if compared items are not equals, false otherwise</returns>
        public static bool operator != (GroupsV2GroupBanRequest left, GroupsV2GroupBanRequest right)
        {
            return !Equals(left, right);
        }

        /// <summary>
        /// Builder of GroupsV2GroupBanRequest.
        /// </summary>
        public sealed class GroupsV2GroupBanRequestBuilder
        {
            private string _Comment;
            private int? _Length;

            internal GroupsV2GroupBanRequestBuilder()
            {
                SetupDefaults();
            }

            private void SetupDefaults()
            {
            }

            /// <summary>
            /// Sets value for GroupsV2GroupBanRequest.Comment property.
            /// </summary>
            /// <param name="value">Comment</param>
            public GroupsV2GroupBanRequestBuilder Comment(string value)
            {
                _Comment = value;
                return this;
            }

            /// <summary>
            /// Sets value for GroupsV2GroupBanRequest.Length property.
            /// </summary>
            /// <param name="value">Length</param>
            public GroupsV2GroupBanRequestBuilder Length(int? value)
            {
                _Length = value;
                return this;
            }


            /// <summary>
            /// Builds instance of GroupsV2GroupBanRequest.
            /// </summary>
            /// <returns>GroupsV2GroupBanRequest</returns>
            public GroupsV2GroupBanRequest Build()
            {
                Validate();
                return new GroupsV2GroupBanRequest(
                    Comment: _Comment,
                    Length: _Length
                );
            }

            private void Validate()
            { 
            }
        }

        
    }
}