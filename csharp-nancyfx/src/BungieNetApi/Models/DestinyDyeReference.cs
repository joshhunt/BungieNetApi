using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Sharpility.Extensions;
using NodaTime;

namespace BungieNetApi._Platform.Models
{
    /// <summary>
    /// DestinyDyeReference
    /// </summary>
    public sealed class DestinyDyeReference:  IEquatable<DestinyDyeReference>
    { 
        /// <summary>
        /// ChannelHash
        /// </summary>
        public int? ChannelHash { get; private set; }

        /// <summary>
        /// DyeHash
        /// </summary>
        public int? DyeHash { get; private set; }


        /// <summary>
        /// Empty constructor required by some serializers.
        /// Use DestinyDyeReference.Builder() for instance creation instead.
        /// </summary>
        [Obsolete]
        public DestinyDyeReference()
        {
        }

        private DestinyDyeReference(int? ChannelHash, int? DyeHash)
        {
            
            this.ChannelHash = ChannelHash;
            
            this.DyeHash = DyeHash;
            
        }

        /// <summary>
        /// Returns builder of DestinyDyeReference.
        /// </summary>
        /// <returns>DestinyDyeReferenceBuilder</returns>
        public static DestinyDyeReferenceBuilder Builder()
        {
            return new DestinyDyeReferenceBuilder();
        }

        /// <summary>
        /// Returns DestinyDyeReferenceBuilder with properties set.
        /// Use it to change properties.
        /// </summary>
        /// <returns>DestinyDyeReferenceBuilder</returns>
        public DestinyDyeReferenceBuilder With()
        {
            return Builder()
                .ChannelHash(ChannelHash)
                .DyeHash(DyeHash);
        }

        public override string ToString()
        {
            return this.PropertiesToString();
        }

        public override bool Equals(object obj)
        {
            return this.EqualsByProperties(obj);
        }

        public bool Equals(DestinyDyeReference other)
        {
            return Equals((object) other);
        }

        public override int GetHashCode()
        {
            return this.PropertiesHash();
        }

        /// <summary>
        /// Implementation of == operator for (DestinyDyeReference.
        /// </summary>
        /// <param name="left">Compared (DestinyDyeReference</param>
        /// <param name="right">Compared (DestinyDyeReference</param>
        /// <returns>true if compared items are equals, false otherwise</returns>
        public static bool operator == (DestinyDyeReference left, DestinyDyeReference right)
        {
            return Equals(left, right);
        }

        /// <summary>
        /// Implementation of != operator for (DestinyDyeReference.
        /// </summary>
        /// <param name="left">Compared (DestinyDyeReference</param>
        /// <param name="right">Compared (DestinyDyeReference</param>
        /// <returns>true if compared items are not equals, false otherwise</returns>
        public static bool operator != (DestinyDyeReference left, DestinyDyeReference right)
        {
            return !Equals(left, right);
        }

        /// <summary>
        /// Builder of DestinyDyeReference.
        /// </summary>
        public sealed class DestinyDyeReferenceBuilder
        {
            private int? _ChannelHash;
            private int? _DyeHash;

            internal DestinyDyeReferenceBuilder()
            {
                SetupDefaults();
            }

            private void SetupDefaults()
            {
            }

            /// <summary>
            /// Sets value for DestinyDyeReference.ChannelHash property.
            /// </summary>
            /// <param name="value">ChannelHash</param>
            public DestinyDyeReferenceBuilder ChannelHash(int? value)
            {
                _ChannelHash = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDyeReference.DyeHash property.
            /// </summary>
            /// <param name="value">DyeHash</param>
            public DestinyDyeReferenceBuilder DyeHash(int? value)
            {
                _DyeHash = value;
                return this;
            }


            /// <summary>
            /// Builds instance of DestinyDyeReference.
            /// </summary>
            /// <returns>DestinyDyeReference</returns>
            public DestinyDyeReference Build()
            {
                Validate();
                return new DestinyDyeReference(
                    ChannelHash: _ChannelHash,
                    DyeHash: _DyeHash
                );
            }

            private void Validate()
            { 
            }
        }

        
    }
}