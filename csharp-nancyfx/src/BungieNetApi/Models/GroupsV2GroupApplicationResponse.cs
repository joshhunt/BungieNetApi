using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Sharpility.Extensions;
using NodaTime;

namespace BungieNetApi._Platform.Models
{
    /// <summary>
    /// GroupsV2GroupApplicationResponse
    /// </summary>
    public sealed class GroupsV2GroupApplicationResponse:  IEquatable<GroupsV2GroupApplicationResponse>
    { 
        /// <summary>
        /// Resolution
        /// </summary>
        public int? Resolution { get; private set; }


        /// <summary>
        /// Empty constructor required by some serializers.
        /// Use GroupsV2GroupApplicationResponse.Builder() for instance creation instead.
        /// </summary>
        [Obsolete]
        public GroupsV2GroupApplicationResponse()
        {
        }

        private GroupsV2GroupApplicationResponse(int? Resolution)
        {
            
            this.Resolution = Resolution;
            
        }

        /// <summary>
        /// Returns builder of GroupsV2GroupApplicationResponse.
        /// </summary>
        /// <returns>GroupsV2GroupApplicationResponseBuilder</returns>
        public static GroupsV2GroupApplicationResponseBuilder Builder()
        {
            return new GroupsV2GroupApplicationResponseBuilder();
        }

        /// <summary>
        /// Returns GroupsV2GroupApplicationResponseBuilder with properties set.
        /// Use it to change properties.
        /// </summary>
        /// <returns>GroupsV2GroupApplicationResponseBuilder</returns>
        public GroupsV2GroupApplicationResponseBuilder With()
        {
            return Builder()
                .Resolution(Resolution);
        }

        public override string ToString()
        {
            return this.PropertiesToString();
        }

        public override bool Equals(object obj)
        {
            return this.EqualsByProperties(obj);
        }

        public bool Equals(GroupsV2GroupApplicationResponse other)
        {
            return Equals((object) other);
        }

        public override int GetHashCode()
        {
            return this.PropertiesHash();
        }

        /// <summary>
        /// Implementation of == operator for (GroupsV2GroupApplicationResponse.
        /// </summary>
        /// <param name="left">Compared (GroupsV2GroupApplicationResponse</param>
        /// <param name="right">Compared (GroupsV2GroupApplicationResponse</param>
        /// <returns>true if compared items are equals, false otherwise</returns>
        public static bool operator == (GroupsV2GroupApplicationResponse left, GroupsV2GroupApplicationResponse right)
        {
            return Equals(left, right);
        }

        /// <summary>
        /// Implementation of != operator for (GroupsV2GroupApplicationResponse.
        /// </summary>
        /// <param name="left">Compared (GroupsV2GroupApplicationResponse</param>
        /// <param name="right">Compared (GroupsV2GroupApplicationResponse</param>
        /// <returns>true if compared items are not equals, false otherwise</returns>
        public static bool operator != (GroupsV2GroupApplicationResponse left, GroupsV2GroupApplicationResponse right)
        {
            return !Equals(left, right);
        }

        /// <summary>
        /// Builder of GroupsV2GroupApplicationResponse.
        /// </summary>
        public sealed class GroupsV2GroupApplicationResponseBuilder
        {
            private int? _Resolution;

            internal GroupsV2GroupApplicationResponseBuilder()
            {
                SetupDefaults();
            }

            private void SetupDefaults()
            {
            }

            /// <summary>
            /// Sets value for GroupsV2GroupApplicationResponse.Resolution property.
            /// </summary>
            /// <param name="value">Resolution</param>
            public GroupsV2GroupApplicationResponseBuilder Resolution(int? value)
            {
                _Resolution = value;
                return this;
            }


            /// <summary>
            /// Builds instance of GroupsV2GroupApplicationResponse.
            /// </summary>
            /// <returns>GroupsV2GroupApplicationResponse</returns>
            public GroupsV2GroupApplicationResponse Build()
            {
                Validate();
                return new GroupsV2GroupApplicationResponse(
                    Resolution: _Resolution
                );
            }

            private void Validate()
            { 
            }
        }

        
    }
}