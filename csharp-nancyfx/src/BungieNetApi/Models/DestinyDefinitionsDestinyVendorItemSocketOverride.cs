using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Sharpility.Extensions;
using NodaTime;

namespace BungieNetApi._Platform.Models
{
    /// <summary>
    /// The information for how the vendor purchase should override a given socket with custom plug data.
    /// </summary>
    public sealed class DestinyDefinitionsDestinyVendorItemSocketOverride:  IEquatable<DestinyDefinitionsDestinyVendorItemSocketOverride>
    { 
        /// <summary>
        /// If this is populated, the socket will be overridden with a specific plug.  If this isn&#39;t populated, it&#39;s being overridden by something more complicated that is only known by the Game Server and God, which means we can&#39;t tell you in advance what it&#39;ll be.
        /// </summary>
        public int? SingleItemHash { get; private set; }

        /// <summary>
        /// If this is greater than -1, the number of randomized plugs on this socket will be set to this quantity instead of whatever it&#39;s set to by default.
        /// </summary>
        public int? RandomizedOptionsCount { get; private set; }

        /// <summary>
        /// This appears to be used to select which socket ultimately gets the override defined here.
        /// </summary>
        public int? SocketTypeHash { get; private set; }


        /// <summary>
        /// Empty constructor required by some serializers.
        /// Use DestinyDefinitionsDestinyVendorItemSocketOverride.Builder() for instance creation instead.
        /// </summary>
        [Obsolete]
        public DestinyDefinitionsDestinyVendorItemSocketOverride()
        {
        }

        private DestinyDefinitionsDestinyVendorItemSocketOverride(int? SingleItemHash, int? RandomizedOptionsCount, int? SocketTypeHash)
        {
            
            this.SingleItemHash = SingleItemHash;
            
            this.RandomizedOptionsCount = RandomizedOptionsCount;
            
            this.SocketTypeHash = SocketTypeHash;
            
        }

        /// <summary>
        /// Returns builder of DestinyDefinitionsDestinyVendorItemSocketOverride.
        /// </summary>
        /// <returns>DestinyDefinitionsDestinyVendorItemSocketOverrideBuilder</returns>
        public static DestinyDefinitionsDestinyVendorItemSocketOverrideBuilder Builder()
        {
            return new DestinyDefinitionsDestinyVendorItemSocketOverrideBuilder();
        }

        /// <summary>
        /// Returns DestinyDefinitionsDestinyVendorItemSocketOverrideBuilder with properties set.
        /// Use it to change properties.
        /// </summary>
        /// <returns>DestinyDefinitionsDestinyVendorItemSocketOverrideBuilder</returns>
        public DestinyDefinitionsDestinyVendorItemSocketOverrideBuilder With()
        {
            return Builder()
                .SingleItemHash(SingleItemHash)
                .RandomizedOptionsCount(RandomizedOptionsCount)
                .SocketTypeHash(SocketTypeHash);
        }

        public override string ToString()
        {
            return this.PropertiesToString();
        }

        public override bool Equals(object obj)
        {
            return this.EqualsByProperties(obj);
        }

        public bool Equals(DestinyDefinitionsDestinyVendorItemSocketOverride other)
        {
            return Equals((object) other);
        }

        public override int GetHashCode()
        {
            return this.PropertiesHash();
        }

        /// <summary>
        /// Implementation of == operator for (DestinyDefinitionsDestinyVendorItemSocketOverride.
        /// </summary>
        /// <param name="left">Compared (DestinyDefinitionsDestinyVendorItemSocketOverride</param>
        /// <param name="right">Compared (DestinyDefinitionsDestinyVendorItemSocketOverride</param>
        /// <returns>true if compared items are equals, false otherwise</returns>
        public static bool operator == (DestinyDefinitionsDestinyVendorItemSocketOverride left, DestinyDefinitionsDestinyVendorItemSocketOverride right)
        {
            return Equals(left, right);
        }

        /// <summary>
        /// Implementation of != operator for (DestinyDefinitionsDestinyVendorItemSocketOverride.
        /// </summary>
        /// <param name="left">Compared (DestinyDefinitionsDestinyVendorItemSocketOverride</param>
        /// <param name="right">Compared (DestinyDefinitionsDestinyVendorItemSocketOverride</param>
        /// <returns>true if compared items are not equals, false otherwise</returns>
        public static bool operator != (DestinyDefinitionsDestinyVendorItemSocketOverride left, DestinyDefinitionsDestinyVendorItemSocketOverride right)
        {
            return !Equals(left, right);
        }

        /// <summary>
        /// Builder of DestinyDefinitionsDestinyVendorItemSocketOverride.
        /// </summary>
        public sealed class DestinyDefinitionsDestinyVendorItemSocketOverrideBuilder
        {
            private int? _SingleItemHash;
            private int? _RandomizedOptionsCount;
            private int? _SocketTypeHash;

            internal DestinyDefinitionsDestinyVendorItemSocketOverrideBuilder()
            {
                SetupDefaults();
            }

            private void SetupDefaults()
            {
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsDestinyVendorItemSocketOverride.SingleItemHash property.
            /// </summary>
            /// <param name="value">If this is populated, the socket will be overridden with a specific plug.  If this isn&#39;t populated, it&#39;s being overridden by something more complicated that is only known by the Game Server and God, which means we can&#39;t tell you in advance what it&#39;ll be.</param>
            public DestinyDefinitionsDestinyVendorItemSocketOverrideBuilder SingleItemHash(int? value)
            {
                _SingleItemHash = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsDestinyVendorItemSocketOverride.RandomizedOptionsCount property.
            /// </summary>
            /// <param name="value">If this is greater than -1, the number of randomized plugs on this socket will be set to this quantity instead of whatever it&#39;s set to by default.</param>
            public DestinyDefinitionsDestinyVendorItemSocketOverrideBuilder RandomizedOptionsCount(int? value)
            {
                _RandomizedOptionsCount = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsDestinyVendorItemSocketOverride.SocketTypeHash property.
            /// </summary>
            /// <param name="value">This appears to be used to select which socket ultimately gets the override defined here.</param>
            public DestinyDefinitionsDestinyVendorItemSocketOverrideBuilder SocketTypeHash(int? value)
            {
                _SocketTypeHash = value;
                return this;
            }


            /// <summary>
            /// Builds instance of DestinyDefinitionsDestinyVendorItemSocketOverride.
            /// </summary>
            /// <returns>DestinyDefinitionsDestinyVendorItemSocketOverride</returns>
            public DestinyDefinitionsDestinyVendorItemSocketOverride Build()
            {
                Validate();
                return new DestinyDefinitionsDestinyVendorItemSocketOverride(
                    SingleItemHash: _SingleItemHash,
                    RandomizedOptionsCount: _RandomizedOptionsCount,
                    SocketTypeHash: _SocketTypeHash
                );
            }

            private void Validate()
            { 
            }
        }

        
    }
}