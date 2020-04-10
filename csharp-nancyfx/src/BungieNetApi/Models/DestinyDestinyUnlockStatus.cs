using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Sharpility.Extensions;
using NodaTime;

namespace BungieNetApi._Platform.Models
{
    /// <summary>
    /// Indicates the status of an \&quot;Unlock Flag\&quot; on a Character or Profile.  These are individual bits of state that can be either set or not set, and sometimes provide interesting human-readable information in their related DestinyUnlockDefinition.
    /// </summary>
    public sealed class DestinyDestinyUnlockStatus:  IEquatable<DestinyDestinyUnlockStatus>
    { 
        /// <summary>
        /// The hash identifier for the Unlock Flag. Use to lookup DestinyUnlockDefinition for static data. Not all unlocks have human readable data - in fact, most don&#39;t. But when they do, it can be very useful to show. Even if they don&#39;t have human readable data, you might be able to infer the meaning of an unlock flag with a bit of experimentation...
        /// </summary>
        public int? UnlockHash { get; private set; }

        /// <summary>
        /// Whether the unlock flag is set.
        /// </summary>
        public bool? IsSet { get; private set; }


        /// <summary>
        /// Empty constructor required by some serializers.
        /// Use DestinyDestinyUnlockStatus.Builder() for instance creation instead.
        /// </summary>
        [Obsolete]
        public DestinyDestinyUnlockStatus()
        {
        }

        private DestinyDestinyUnlockStatus(int? UnlockHash, bool? IsSet)
        {
            
            this.UnlockHash = UnlockHash;
            
            this.IsSet = IsSet;
            
        }

        /// <summary>
        /// Returns builder of DestinyDestinyUnlockStatus.
        /// </summary>
        /// <returns>DestinyDestinyUnlockStatusBuilder</returns>
        public static DestinyDestinyUnlockStatusBuilder Builder()
        {
            return new DestinyDestinyUnlockStatusBuilder();
        }

        /// <summary>
        /// Returns DestinyDestinyUnlockStatusBuilder with properties set.
        /// Use it to change properties.
        /// </summary>
        /// <returns>DestinyDestinyUnlockStatusBuilder</returns>
        public DestinyDestinyUnlockStatusBuilder With()
        {
            return Builder()
                .UnlockHash(UnlockHash)
                .IsSet(IsSet);
        }

        public override string ToString()
        {
            return this.PropertiesToString();
        }

        public override bool Equals(object obj)
        {
            return this.EqualsByProperties(obj);
        }

        public bool Equals(DestinyDestinyUnlockStatus other)
        {
            return Equals((object) other);
        }

        public override int GetHashCode()
        {
            return this.PropertiesHash();
        }

        /// <summary>
        /// Implementation of == operator for (DestinyDestinyUnlockStatus.
        /// </summary>
        /// <param name="left">Compared (DestinyDestinyUnlockStatus</param>
        /// <param name="right">Compared (DestinyDestinyUnlockStatus</param>
        /// <returns>true if compared items are equals, false otherwise</returns>
        public static bool operator == (DestinyDestinyUnlockStatus left, DestinyDestinyUnlockStatus right)
        {
            return Equals(left, right);
        }

        /// <summary>
        /// Implementation of != operator for (DestinyDestinyUnlockStatus.
        /// </summary>
        /// <param name="left">Compared (DestinyDestinyUnlockStatus</param>
        /// <param name="right">Compared (DestinyDestinyUnlockStatus</param>
        /// <returns>true if compared items are not equals, false otherwise</returns>
        public static bool operator != (DestinyDestinyUnlockStatus left, DestinyDestinyUnlockStatus right)
        {
            return !Equals(left, right);
        }

        /// <summary>
        /// Builder of DestinyDestinyUnlockStatus.
        /// </summary>
        public sealed class DestinyDestinyUnlockStatusBuilder
        {
            private int? _UnlockHash;
            private bool? _IsSet;

            internal DestinyDestinyUnlockStatusBuilder()
            {
                SetupDefaults();
            }

            private void SetupDefaults()
            {
            }

            /// <summary>
            /// Sets value for DestinyDestinyUnlockStatus.UnlockHash property.
            /// </summary>
            /// <param name="value">The hash identifier for the Unlock Flag. Use to lookup DestinyUnlockDefinition for static data. Not all unlocks have human readable data - in fact, most don&#39;t. But when they do, it can be very useful to show. Even if they don&#39;t have human readable data, you might be able to infer the meaning of an unlock flag with a bit of experimentation...</param>
            public DestinyDestinyUnlockStatusBuilder UnlockHash(int? value)
            {
                _UnlockHash = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDestinyUnlockStatus.IsSet property.
            /// </summary>
            /// <param name="value">Whether the unlock flag is set.</param>
            public DestinyDestinyUnlockStatusBuilder IsSet(bool? value)
            {
                _IsSet = value;
                return this;
            }


            /// <summary>
            /// Builds instance of DestinyDestinyUnlockStatus.
            /// </summary>
            /// <returns>DestinyDestinyUnlockStatus</returns>
            public DestinyDestinyUnlockStatus Build()
            {
                Validate();
                return new DestinyDestinyUnlockStatus(
                    UnlockHash: _UnlockHash,
                    IsSet: _IsSet
                );
            }

            private void Validate()
            { 
            }
        }

        
    }
}