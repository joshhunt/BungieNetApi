using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Sharpility.Extensions;
using NodaTime;

namespace BungieNetApi._Platform.Models
{
    /// <summary>
    /// Represents a specific group of vendors that can be rendered in the recommended order.  How do we figure out this order? It&#39;s a long story, and will likely get more complicated over time.
    /// </summary>
    public sealed class DestinyComponentsVendorsDestinyVendorGroup:  IEquatable<DestinyComponentsVendorsDestinyVendorGroup>
    { 
        /// <summary>
        /// VendorGroupHash
        /// </summary>
        public int? VendorGroupHash { get; private set; }

        /// <summary>
        /// The ordered list of vendors within a particular group.
        /// </summary>
        public List<int?> VendorHashes { get; private set; }


        /// <summary>
        /// Empty constructor required by some serializers.
        /// Use DestinyComponentsVendorsDestinyVendorGroup.Builder() for instance creation instead.
        /// </summary>
        [Obsolete]
        public DestinyComponentsVendorsDestinyVendorGroup()
        {
        }

        private DestinyComponentsVendorsDestinyVendorGroup(int? VendorGroupHash, List<int?> VendorHashes)
        {
            
            this.VendorGroupHash = VendorGroupHash;
            
            this.VendorHashes = VendorHashes;
            
        }

        /// <summary>
        /// Returns builder of DestinyComponentsVendorsDestinyVendorGroup.
        /// </summary>
        /// <returns>DestinyComponentsVendorsDestinyVendorGroupBuilder</returns>
        public static DestinyComponentsVendorsDestinyVendorGroupBuilder Builder()
        {
            return new DestinyComponentsVendorsDestinyVendorGroupBuilder();
        }

        /// <summary>
        /// Returns DestinyComponentsVendorsDestinyVendorGroupBuilder with properties set.
        /// Use it to change properties.
        /// </summary>
        /// <returns>DestinyComponentsVendorsDestinyVendorGroupBuilder</returns>
        public DestinyComponentsVendorsDestinyVendorGroupBuilder With()
        {
            return Builder()
                .VendorGroupHash(VendorGroupHash)
                .VendorHashes(VendorHashes);
        }

        public override string ToString()
        {
            return this.PropertiesToString();
        }

        public override bool Equals(object obj)
        {
            return this.EqualsByProperties(obj);
        }

        public bool Equals(DestinyComponentsVendorsDestinyVendorGroup other)
        {
            return Equals((object) other);
        }

        public override int GetHashCode()
        {
            return this.PropertiesHash();
        }

        /// <summary>
        /// Implementation of == operator for (DestinyComponentsVendorsDestinyVendorGroup.
        /// </summary>
        /// <param name="left">Compared (DestinyComponentsVendorsDestinyVendorGroup</param>
        /// <param name="right">Compared (DestinyComponentsVendorsDestinyVendorGroup</param>
        /// <returns>true if compared items are equals, false otherwise</returns>
        public static bool operator == (DestinyComponentsVendorsDestinyVendorGroup left, DestinyComponentsVendorsDestinyVendorGroup right)
        {
            return Equals(left, right);
        }

        /// <summary>
        /// Implementation of != operator for (DestinyComponentsVendorsDestinyVendorGroup.
        /// </summary>
        /// <param name="left">Compared (DestinyComponentsVendorsDestinyVendorGroup</param>
        /// <param name="right">Compared (DestinyComponentsVendorsDestinyVendorGroup</param>
        /// <returns>true if compared items are not equals, false otherwise</returns>
        public static bool operator != (DestinyComponentsVendorsDestinyVendorGroup left, DestinyComponentsVendorsDestinyVendorGroup right)
        {
            return !Equals(left, right);
        }

        /// <summary>
        /// Builder of DestinyComponentsVendorsDestinyVendorGroup.
        /// </summary>
        public sealed class DestinyComponentsVendorsDestinyVendorGroupBuilder
        {
            private int? _VendorGroupHash;
            private List<int?> _VendorHashes;

            internal DestinyComponentsVendorsDestinyVendorGroupBuilder()
            {
                SetupDefaults();
            }

            private void SetupDefaults()
            {
            }

            /// <summary>
            /// Sets value for DestinyComponentsVendorsDestinyVendorGroup.VendorGroupHash property.
            /// </summary>
            /// <param name="value">VendorGroupHash</param>
            public DestinyComponentsVendorsDestinyVendorGroupBuilder VendorGroupHash(int? value)
            {
                _VendorGroupHash = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyComponentsVendorsDestinyVendorGroup.VendorHashes property.
            /// </summary>
            /// <param name="value">The ordered list of vendors within a particular group.</param>
            public DestinyComponentsVendorsDestinyVendorGroupBuilder VendorHashes(List<int?> value)
            {
                _VendorHashes = value;
                return this;
            }


            /// <summary>
            /// Builds instance of DestinyComponentsVendorsDestinyVendorGroup.
            /// </summary>
            /// <returns>DestinyComponentsVendorsDestinyVendorGroup</returns>
            public DestinyComponentsVendorsDestinyVendorGroup Build()
            {
                Validate();
                return new DestinyComponentsVendorsDestinyVendorGroup(
                    VendorGroupHash: _VendorGroupHash,
                    VendorHashes: _VendorHashes
                );
            }

            private void Validate()
            { 
            }
        }

        
    }
}