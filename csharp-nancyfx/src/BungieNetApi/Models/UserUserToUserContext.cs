using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Sharpility.Extensions;
using NodaTime;

namespace BungieNetApi._Platform.Models
{
    /// <summary>
    /// UserUserToUserContext
    /// </summary>
    public sealed class UserUserToUserContext:  IEquatable<UserUserToUserContext>
    { 
        /// <summary>
        /// IsFollowing
        /// </summary>
        public bool? IsFollowing { get; private set; }

        /// <summary>
        /// IgnoreStatus
        /// </summary>
        public IgnoresIgnoreResponse IgnoreStatus { get; private set; }

        /// <summary>
        /// GlobalIgnoreEndDate
        /// </summary>
        public DateTime? GlobalIgnoreEndDate { get; private set; }


        /// <summary>
        /// Empty constructor required by some serializers.
        /// Use UserUserToUserContext.Builder() for instance creation instead.
        /// </summary>
        [Obsolete]
        public UserUserToUserContext()
        {
        }

        private UserUserToUserContext(bool? IsFollowing, IgnoresIgnoreResponse IgnoreStatus, DateTime? GlobalIgnoreEndDate)
        {
            
            this.IsFollowing = IsFollowing;
            
            this.IgnoreStatus = IgnoreStatus;
            
            this.GlobalIgnoreEndDate = GlobalIgnoreEndDate;
            
        }

        /// <summary>
        /// Returns builder of UserUserToUserContext.
        /// </summary>
        /// <returns>UserUserToUserContextBuilder</returns>
        public static UserUserToUserContextBuilder Builder()
        {
            return new UserUserToUserContextBuilder();
        }

        /// <summary>
        /// Returns UserUserToUserContextBuilder with properties set.
        /// Use it to change properties.
        /// </summary>
        /// <returns>UserUserToUserContextBuilder</returns>
        public UserUserToUserContextBuilder With()
        {
            return Builder()
                .IsFollowing(IsFollowing)
                .IgnoreStatus(IgnoreStatus)
                .GlobalIgnoreEndDate(GlobalIgnoreEndDate);
        }

        public override string ToString()
        {
            return this.PropertiesToString();
        }

        public override bool Equals(object obj)
        {
            return this.EqualsByProperties(obj);
        }

        public bool Equals(UserUserToUserContext other)
        {
            return Equals((object) other);
        }

        public override int GetHashCode()
        {
            return this.PropertiesHash();
        }

        /// <summary>
        /// Implementation of == operator for (UserUserToUserContext.
        /// </summary>
        /// <param name="left">Compared (UserUserToUserContext</param>
        /// <param name="right">Compared (UserUserToUserContext</param>
        /// <returns>true if compared items are equals, false otherwise</returns>
        public static bool operator == (UserUserToUserContext left, UserUserToUserContext right)
        {
            return Equals(left, right);
        }

        /// <summary>
        /// Implementation of != operator for (UserUserToUserContext.
        /// </summary>
        /// <param name="left">Compared (UserUserToUserContext</param>
        /// <param name="right">Compared (UserUserToUserContext</param>
        /// <returns>true if compared items are not equals, false otherwise</returns>
        public static bool operator != (UserUserToUserContext left, UserUserToUserContext right)
        {
            return !Equals(left, right);
        }

        /// <summary>
        /// Builder of UserUserToUserContext.
        /// </summary>
        public sealed class UserUserToUserContextBuilder
        {
            private bool? _IsFollowing;
            private IgnoresIgnoreResponse _IgnoreStatus;
            private DateTime? _GlobalIgnoreEndDate;

            internal UserUserToUserContextBuilder()
            {
                SetupDefaults();
            }

            private void SetupDefaults()
            {
            }

            /// <summary>
            /// Sets value for UserUserToUserContext.IsFollowing property.
            /// </summary>
            /// <param name="value">IsFollowing</param>
            public UserUserToUserContextBuilder IsFollowing(bool? value)
            {
                _IsFollowing = value;
                return this;
            }

            /// <summary>
            /// Sets value for UserUserToUserContext.IgnoreStatus property.
            /// </summary>
            /// <param name="value">IgnoreStatus</param>
            public UserUserToUserContextBuilder IgnoreStatus(IgnoresIgnoreResponse value)
            {
                _IgnoreStatus = value;
                return this;
            }

            /// <summary>
            /// Sets value for UserUserToUserContext.GlobalIgnoreEndDate property.
            /// </summary>
            /// <param name="value">GlobalIgnoreEndDate</param>
            public UserUserToUserContextBuilder GlobalIgnoreEndDate(DateTime? value)
            {
                _GlobalIgnoreEndDate = value;
                return this;
            }


            /// <summary>
            /// Builds instance of UserUserToUserContext.
            /// </summary>
            /// <returns>UserUserToUserContext</returns>
            public UserUserToUserContext Build()
            {
                Validate();
                return new UserUserToUserContext(
                    IsFollowing: _IsFollowing,
                    IgnoreStatus: _IgnoreStatus,
                    GlobalIgnoreEndDate: _GlobalIgnoreEndDate
                );
            }

            private void Validate()
            { 
            }
        }

        
    }
}