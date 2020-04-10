using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Sharpility.Extensions;
using NodaTime;

namespace BungieNetApi._Platform.Models
{
    /// <summary>
    /// CommonModelsCoreSystem
    /// </summary>
    public sealed class CommonModelsCoreSystem:  IEquatable<CommonModelsCoreSystem>
    { 
        /// <summary>
        /// Enabled
        /// </summary>
        public bool? Enabled { get; private set; }

        /// <summary>
        /// Parameters
        /// </summary>
        public Dictionary<string, string> Parameters { get; private set; }


        /// <summary>
        /// Empty constructor required by some serializers.
        /// Use CommonModelsCoreSystem.Builder() for instance creation instead.
        /// </summary>
        [Obsolete]
        public CommonModelsCoreSystem()
        {
        }

        private CommonModelsCoreSystem(bool? Enabled, Dictionary<string, string> Parameters)
        {
            
            this.Enabled = Enabled;
            
            this.Parameters = Parameters;
            
        }

        /// <summary>
        /// Returns builder of CommonModelsCoreSystem.
        /// </summary>
        /// <returns>CommonModelsCoreSystemBuilder</returns>
        public static CommonModelsCoreSystemBuilder Builder()
        {
            return new CommonModelsCoreSystemBuilder();
        }

        /// <summary>
        /// Returns CommonModelsCoreSystemBuilder with properties set.
        /// Use it to change properties.
        /// </summary>
        /// <returns>CommonModelsCoreSystemBuilder</returns>
        public CommonModelsCoreSystemBuilder With()
        {
            return Builder()
                .Enabled(Enabled)
                .Parameters(Parameters);
        }

        public override string ToString()
        {
            return this.PropertiesToString();
        }

        public override bool Equals(object obj)
        {
            return this.EqualsByProperties(obj);
        }

        public bool Equals(CommonModelsCoreSystem other)
        {
            return Equals((object) other);
        }

        public override int GetHashCode()
        {
            return this.PropertiesHash();
        }

        /// <summary>
        /// Implementation of == operator for (CommonModelsCoreSystem.
        /// </summary>
        /// <param name="left">Compared (CommonModelsCoreSystem</param>
        /// <param name="right">Compared (CommonModelsCoreSystem</param>
        /// <returns>true if compared items are equals, false otherwise</returns>
        public static bool operator == (CommonModelsCoreSystem left, CommonModelsCoreSystem right)
        {
            return Equals(left, right);
        }

        /// <summary>
        /// Implementation of != operator for (CommonModelsCoreSystem.
        /// </summary>
        /// <param name="left">Compared (CommonModelsCoreSystem</param>
        /// <param name="right">Compared (CommonModelsCoreSystem</param>
        /// <returns>true if compared items are not equals, false otherwise</returns>
        public static bool operator != (CommonModelsCoreSystem left, CommonModelsCoreSystem right)
        {
            return !Equals(left, right);
        }

        /// <summary>
        /// Builder of CommonModelsCoreSystem.
        /// </summary>
        public sealed class CommonModelsCoreSystemBuilder
        {
            private bool? _Enabled;
            private Dictionary<string, string> _Parameters;

            internal CommonModelsCoreSystemBuilder()
            {
                SetupDefaults();
            }

            private void SetupDefaults()
            {
            }

            /// <summary>
            /// Sets value for CommonModelsCoreSystem.Enabled property.
            /// </summary>
            /// <param name="value">Enabled</param>
            public CommonModelsCoreSystemBuilder Enabled(bool? value)
            {
                _Enabled = value;
                return this;
            }

            /// <summary>
            /// Sets value for CommonModelsCoreSystem.Parameters property.
            /// </summary>
            /// <param name="value">Parameters</param>
            public CommonModelsCoreSystemBuilder Parameters(Dictionary<string, string> value)
            {
                _Parameters = value;
                return this;
            }


            /// <summary>
            /// Builds instance of CommonModelsCoreSystem.
            /// </summary>
            /// <returns>CommonModelsCoreSystem</returns>
            public CommonModelsCoreSystem Build()
            {
                Validate();
                return new CommonModelsCoreSystem(
                    Enabled: _Enabled,
                    Parameters: _Parameters
                );
            }

            private void Validate()
            { 
            }
        }

        
    }
}