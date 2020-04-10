using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Sharpility.Extensions;
using NodaTime;

namespace BungieNetApi._Platform.Models
{
    /// <summary>
    /// ApplicationsApplicationDeveloper
    /// </summary>
    public sealed class ApplicationsApplicationDeveloper:  IEquatable<ApplicationsApplicationDeveloper>
    { 
        /// <summary>
        /// Role
        /// </summary>
        public int? Role { get; private set; }

        /// <summary>
        /// ApiEulaVersion
        /// </summary>
        public int? ApiEulaVersion { get; private set; }

        /// <summary>
        /// User
        /// </summary>
        public UserUserInfoCard User { get; private set; }


        /// <summary>
        /// Empty constructor required by some serializers.
        /// Use ApplicationsApplicationDeveloper.Builder() for instance creation instead.
        /// </summary>
        [Obsolete]
        public ApplicationsApplicationDeveloper()
        {
        }

        private ApplicationsApplicationDeveloper(int? Role, int? ApiEulaVersion, UserUserInfoCard User)
        {
            
            this.Role = Role;
            
            this.ApiEulaVersion = ApiEulaVersion;
            
            this.User = User;
            
        }

        /// <summary>
        /// Returns builder of ApplicationsApplicationDeveloper.
        /// </summary>
        /// <returns>ApplicationsApplicationDeveloperBuilder</returns>
        public static ApplicationsApplicationDeveloperBuilder Builder()
        {
            return new ApplicationsApplicationDeveloperBuilder();
        }

        /// <summary>
        /// Returns ApplicationsApplicationDeveloperBuilder with properties set.
        /// Use it to change properties.
        /// </summary>
        /// <returns>ApplicationsApplicationDeveloperBuilder</returns>
        public ApplicationsApplicationDeveloperBuilder With()
        {
            return Builder()
                .Role(Role)
                .ApiEulaVersion(ApiEulaVersion)
                .User(User);
        }

        public override string ToString()
        {
            return this.PropertiesToString();
        }

        public override bool Equals(object obj)
        {
            return this.EqualsByProperties(obj);
        }

        public bool Equals(ApplicationsApplicationDeveloper other)
        {
            return Equals((object) other);
        }

        public override int GetHashCode()
        {
            return this.PropertiesHash();
        }

        /// <summary>
        /// Implementation of == operator for (ApplicationsApplicationDeveloper.
        /// </summary>
        /// <param name="left">Compared (ApplicationsApplicationDeveloper</param>
        /// <param name="right">Compared (ApplicationsApplicationDeveloper</param>
        /// <returns>true if compared items are equals, false otherwise</returns>
        public static bool operator == (ApplicationsApplicationDeveloper left, ApplicationsApplicationDeveloper right)
        {
            return Equals(left, right);
        }

        /// <summary>
        /// Implementation of != operator for (ApplicationsApplicationDeveloper.
        /// </summary>
        /// <param name="left">Compared (ApplicationsApplicationDeveloper</param>
        /// <param name="right">Compared (ApplicationsApplicationDeveloper</param>
        /// <returns>true if compared items are not equals, false otherwise</returns>
        public static bool operator != (ApplicationsApplicationDeveloper left, ApplicationsApplicationDeveloper right)
        {
            return !Equals(left, right);
        }

        /// <summary>
        /// Builder of ApplicationsApplicationDeveloper.
        /// </summary>
        public sealed class ApplicationsApplicationDeveloperBuilder
        {
            private int? _Role;
            private int? _ApiEulaVersion;
            private UserUserInfoCard _User;

            internal ApplicationsApplicationDeveloperBuilder()
            {
                SetupDefaults();
            }

            private void SetupDefaults()
            {
            }

            /// <summary>
            /// Sets value for ApplicationsApplicationDeveloper.Role property.
            /// </summary>
            /// <param name="value">Role</param>
            public ApplicationsApplicationDeveloperBuilder Role(int? value)
            {
                _Role = value;
                return this;
            }

            /// <summary>
            /// Sets value for ApplicationsApplicationDeveloper.ApiEulaVersion property.
            /// </summary>
            /// <param name="value">ApiEulaVersion</param>
            public ApplicationsApplicationDeveloperBuilder ApiEulaVersion(int? value)
            {
                _ApiEulaVersion = value;
                return this;
            }

            /// <summary>
            /// Sets value for ApplicationsApplicationDeveloper.User property.
            /// </summary>
            /// <param name="value">User</param>
            public ApplicationsApplicationDeveloperBuilder User(UserUserInfoCard value)
            {
                _User = value;
                return this;
            }


            /// <summary>
            /// Builds instance of ApplicationsApplicationDeveloper.
            /// </summary>
            /// <returns>ApplicationsApplicationDeveloper</returns>
            public ApplicationsApplicationDeveloper Build()
            {
                Validate();
                return new ApplicationsApplicationDeveloper(
                    Role: _Role,
                    ApiEulaVersion: _ApiEulaVersion,
                    User: _User
                );
            }

            private void Validate()
            { 
            }
        }

        
    }
}