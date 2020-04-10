using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Sharpility.Extensions;
using NodaTime;

namespace BungieNetApi._Platform.Models
{
    /// <summary>
    /// If you ever wondered how the Vault works, here it is.  The Vault is merely a set of inventory buckets that exist on your Profile/Account level. When you transfer items in the Vault, the game is using the Vault Vendor&#39;s DestinyVendorAcceptedItemDefinitions to see where the appropriate destination bucket is for the source bucket from whence your item is moving. If it finds such an entry, it transfers the item to the other bucket.  The mechanics for Postmaster works similarly, which is also a vendor. All driven by Accepted Items.
    /// </summary>
    public sealed class DestinyDefinitionsDestinyVendorAcceptedItemDefinition:  IEquatable<DestinyDefinitionsDestinyVendorAcceptedItemDefinition>
    { 
        /// <summary>
        /// The \&quot;source\&quot; bucket for a transfer. When a user wants to transfer an item, the appropriate DestinyVendorDefinition&#39;s acceptedItems property is evaluated, looking for an entry where acceptedInventoryBucketHash matches the bucket that the item being transferred is currently located. If it exists, the item will be transferred into whatever bucket is defined by destinationInventoryBucketHash.
        /// </summary>
        public int? AcceptedInventoryBucketHash { get; private set; }

        /// <summary>
        /// This is the bucket where the item being transferred will be put, given that it was being transferred *from* the bucket defined in acceptedInventoryBucketHash.
        /// </summary>
        public int? DestinationInventoryBucketHash { get; private set; }


        /// <summary>
        /// Empty constructor required by some serializers.
        /// Use DestinyDefinitionsDestinyVendorAcceptedItemDefinition.Builder() for instance creation instead.
        /// </summary>
        [Obsolete]
        public DestinyDefinitionsDestinyVendorAcceptedItemDefinition()
        {
        }

        private DestinyDefinitionsDestinyVendorAcceptedItemDefinition(int? AcceptedInventoryBucketHash, int? DestinationInventoryBucketHash)
        {
            
            this.AcceptedInventoryBucketHash = AcceptedInventoryBucketHash;
            
            this.DestinationInventoryBucketHash = DestinationInventoryBucketHash;
            
        }

        /// <summary>
        /// Returns builder of DestinyDefinitionsDestinyVendorAcceptedItemDefinition.
        /// </summary>
        /// <returns>DestinyDefinitionsDestinyVendorAcceptedItemDefinitionBuilder</returns>
        public static DestinyDefinitionsDestinyVendorAcceptedItemDefinitionBuilder Builder()
        {
            return new DestinyDefinitionsDestinyVendorAcceptedItemDefinitionBuilder();
        }

        /// <summary>
        /// Returns DestinyDefinitionsDestinyVendorAcceptedItemDefinitionBuilder with properties set.
        /// Use it to change properties.
        /// </summary>
        /// <returns>DestinyDefinitionsDestinyVendorAcceptedItemDefinitionBuilder</returns>
        public DestinyDefinitionsDestinyVendorAcceptedItemDefinitionBuilder With()
        {
            return Builder()
                .AcceptedInventoryBucketHash(AcceptedInventoryBucketHash)
                .DestinationInventoryBucketHash(DestinationInventoryBucketHash);
        }

        public override string ToString()
        {
            return this.PropertiesToString();
        }

        public override bool Equals(object obj)
        {
            return this.EqualsByProperties(obj);
        }

        public bool Equals(DestinyDefinitionsDestinyVendorAcceptedItemDefinition other)
        {
            return Equals((object) other);
        }

        public override int GetHashCode()
        {
            return this.PropertiesHash();
        }

        /// <summary>
        /// Implementation of == operator for (DestinyDefinitionsDestinyVendorAcceptedItemDefinition.
        /// </summary>
        /// <param name="left">Compared (DestinyDefinitionsDestinyVendorAcceptedItemDefinition</param>
        /// <param name="right">Compared (DestinyDefinitionsDestinyVendorAcceptedItemDefinition</param>
        /// <returns>true if compared items are equals, false otherwise</returns>
        public static bool operator == (DestinyDefinitionsDestinyVendorAcceptedItemDefinition left, DestinyDefinitionsDestinyVendorAcceptedItemDefinition right)
        {
            return Equals(left, right);
        }

        /// <summary>
        /// Implementation of != operator for (DestinyDefinitionsDestinyVendorAcceptedItemDefinition.
        /// </summary>
        /// <param name="left">Compared (DestinyDefinitionsDestinyVendorAcceptedItemDefinition</param>
        /// <param name="right">Compared (DestinyDefinitionsDestinyVendorAcceptedItemDefinition</param>
        /// <returns>true if compared items are not equals, false otherwise</returns>
        public static bool operator != (DestinyDefinitionsDestinyVendorAcceptedItemDefinition left, DestinyDefinitionsDestinyVendorAcceptedItemDefinition right)
        {
            return !Equals(left, right);
        }

        /// <summary>
        /// Builder of DestinyDefinitionsDestinyVendorAcceptedItemDefinition.
        /// </summary>
        public sealed class DestinyDefinitionsDestinyVendorAcceptedItemDefinitionBuilder
        {
            private int? _AcceptedInventoryBucketHash;
            private int? _DestinationInventoryBucketHash;

            internal DestinyDefinitionsDestinyVendorAcceptedItemDefinitionBuilder()
            {
                SetupDefaults();
            }

            private void SetupDefaults()
            {
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsDestinyVendorAcceptedItemDefinition.AcceptedInventoryBucketHash property.
            /// </summary>
            /// <param name="value">The \&quot;source\&quot; bucket for a transfer. When a user wants to transfer an item, the appropriate DestinyVendorDefinition&#39;s acceptedItems property is evaluated, looking for an entry where acceptedInventoryBucketHash matches the bucket that the item being transferred is currently located. If it exists, the item will be transferred into whatever bucket is defined by destinationInventoryBucketHash.</param>
            public DestinyDefinitionsDestinyVendorAcceptedItemDefinitionBuilder AcceptedInventoryBucketHash(int? value)
            {
                _AcceptedInventoryBucketHash = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsDestinyVendorAcceptedItemDefinition.DestinationInventoryBucketHash property.
            /// </summary>
            /// <param name="value">This is the bucket where the item being transferred will be put, given that it was being transferred *from* the bucket defined in acceptedInventoryBucketHash.</param>
            public DestinyDefinitionsDestinyVendorAcceptedItemDefinitionBuilder DestinationInventoryBucketHash(int? value)
            {
                _DestinationInventoryBucketHash = value;
                return this;
            }


            /// <summary>
            /// Builds instance of DestinyDefinitionsDestinyVendorAcceptedItemDefinition.
            /// </summary>
            /// <returns>DestinyDefinitionsDestinyVendorAcceptedItemDefinition</returns>
            public DestinyDefinitionsDestinyVendorAcceptedItemDefinition Build()
            {
                Validate();
                return new DestinyDefinitionsDestinyVendorAcceptedItemDefinition(
                    AcceptedInventoryBucketHash: _AcceptedInventoryBucketHash,
                    DestinationInventoryBucketHash: _DestinationInventoryBucketHash
                );
            }

            private void Validate()
            { 
            }
        }

        
    }
}