using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Sharpility.Extensions;
using NodaTime;

namespace BungieNetApi._Platform.Models
{
    /// <summary>
    /// Represents that a vendor could sell this item, and provides a quick link to that vendor and sale item.   Note that we do not and cannot make a guarantee that the vendor will ever *actually* sell this item, only that the Vendor has a definition that indicates it *could* be sold.   Note also that a vendor may sell the same item in multiple \&quot;ways\&quot;, which means there may be multiple vendorItemIndexes for a single Vendor hash.
    /// </summary>
    public sealed class DestinyDefinitionsDestinyItemVendorSourceReference:  IEquatable<DestinyDefinitionsDestinyItemVendorSourceReference>
    { 
        /// <summary>
        /// The identifier for the vendor that may sell this item.
        /// </summary>
        public int? VendorHash { get; private set; }

        /// <summary>
        /// The Vendor sale item indexes that represent the sale information for this item. The same vendor may sell an item in multiple \&quot;ways\&quot;, hence why this is a list. (for instance, a weapon may be \&quot;sold\&quot; as a reward in a quest, for Glimmer, and for Masterwork Cores: each of those ways would be represented by a different vendor sale item with a different index)
        /// </summary>
        public List<int?> VendorItemIndexes { get; private set; }


        /// <summary>
        /// Empty constructor required by some serializers.
        /// Use DestinyDefinitionsDestinyItemVendorSourceReference.Builder() for instance creation instead.
        /// </summary>
        [Obsolete]
        public DestinyDefinitionsDestinyItemVendorSourceReference()
        {
        }

        private DestinyDefinitionsDestinyItemVendorSourceReference(int? VendorHash, List<int?> VendorItemIndexes)
        {
            
            this.VendorHash = VendorHash;
            
            this.VendorItemIndexes = VendorItemIndexes;
            
        }

        /// <summary>
        /// Returns builder of DestinyDefinitionsDestinyItemVendorSourceReference.
        /// </summary>
        /// <returns>DestinyDefinitionsDestinyItemVendorSourceReferenceBuilder</returns>
        public static DestinyDefinitionsDestinyItemVendorSourceReferenceBuilder Builder()
        {
            return new DestinyDefinitionsDestinyItemVendorSourceReferenceBuilder();
        }

        /// <summary>
        /// Returns DestinyDefinitionsDestinyItemVendorSourceReferenceBuilder with properties set.
        /// Use it to change properties.
        /// </summary>
        /// <returns>DestinyDefinitionsDestinyItemVendorSourceReferenceBuilder</returns>
        public DestinyDefinitionsDestinyItemVendorSourceReferenceBuilder With()
        {
            return Builder()
                .VendorHash(VendorHash)
                .VendorItemIndexes(VendorItemIndexes);
        }

        public override string ToString()
        {
            return this.PropertiesToString();
        }

        public override bool Equals(object obj)
        {
            return this.EqualsByProperties(obj);
        }

        public bool Equals(DestinyDefinitionsDestinyItemVendorSourceReference other)
        {
            return Equals((object) other);
        }

        public override int GetHashCode()
        {
            return this.PropertiesHash();
        }

        /// <summary>
        /// Implementation of == operator for (DestinyDefinitionsDestinyItemVendorSourceReference.
        /// </summary>
        /// <param name="left">Compared (DestinyDefinitionsDestinyItemVendorSourceReference</param>
        /// <param name="right">Compared (DestinyDefinitionsDestinyItemVendorSourceReference</param>
        /// <returns>true if compared items are equals, false otherwise</returns>
        public static bool operator == (DestinyDefinitionsDestinyItemVendorSourceReference left, DestinyDefinitionsDestinyItemVendorSourceReference right)
        {
            return Equals(left, right);
        }

        /// <summary>
        /// Implementation of != operator for (DestinyDefinitionsDestinyItemVendorSourceReference.
        /// </summary>
        /// <param name="left">Compared (DestinyDefinitionsDestinyItemVendorSourceReference</param>
        /// <param name="right">Compared (DestinyDefinitionsDestinyItemVendorSourceReference</param>
        /// <returns>true if compared items are not equals, false otherwise</returns>
        public static bool operator != (DestinyDefinitionsDestinyItemVendorSourceReference left, DestinyDefinitionsDestinyItemVendorSourceReference right)
        {
            return !Equals(left, right);
        }

        /// <summary>
        /// Builder of DestinyDefinitionsDestinyItemVendorSourceReference.
        /// </summary>
        public sealed class DestinyDefinitionsDestinyItemVendorSourceReferenceBuilder
        {
            private int? _VendorHash;
            private List<int?> _VendorItemIndexes;

            internal DestinyDefinitionsDestinyItemVendorSourceReferenceBuilder()
            {
                SetupDefaults();
            }

            private void SetupDefaults()
            {
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsDestinyItemVendorSourceReference.VendorHash property.
            /// </summary>
            /// <param name="value">The identifier for the vendor that may sell this item.</param>
            public DestinyDefinitionsDestinyItemVendorSourceReferenceBuilder VendorHash(int? value)
            {
                _VendorHash = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsDestinyItemVendorSourceReference.VendorItemIndexes property.
            /// </summary>
            /// <param name="value">The Vendor sale item indexes that represent the sale information for this item. The same vendor may sell an item in multiple \&quot;ways\&quot;, hence why this is a list. (for instance, a weapon may be \&quot;sold\&quot; as a reward in a quest, for Glimmer, and for Masterwork Cores: each of those ways would be represented by a different vendor sale item with a different index)</param>
            public DestinyDefinitionsDestinyItemVendorSourceReferenceBuilder VendorItemIndexes(List<int?> value)
            {
                _VendorItemIndexes = value;
                return this;
            }


            /// <summary>
            /// Builds instance of DestinyDefinitionsDestinyItemVendorSourceReference.
            /// </summary>
            /// <returns>DestinyDefinitionsDestinyItemVendorSourceReference</returns>
            public DestinyDefinitionsDestinyItemVendorSourceReference Build()
            {
                Validate();
                return new DestinyDefinitionsDestinyItemVendorSourceReference(
                    VendorHash: _VendorHash,
                    VendorItemIndexes: _VendorItemIndexes
                );
            }

            private void Validate()
            { 
            }
        }

        
    }
}