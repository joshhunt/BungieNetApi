using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Sharpility.Extensions;
using NodaTime;

namespace BungieNetApi._Platform.Models
{
    /// <summary>
    /// Information about a single inventory bucket in a vendor flyout UI and how it is shown.
    /// </summary>
    public sealed class DestinyDefinitionsDestinyVendorInventoryFlyoutBucketDefinition:  IEquatable<DestinyDefinitionsDestinyVendorInventoryFlyoutBucketDefinition>
    { 
        /// <summary>
        /// If true, the inventory bucket should be able to be collapsed visually.
        /// </summary>
        public bool? Collapsible { get; private set; }

        /// <summary>
        /// The inventory bucket whose contents should be shown.
        /// </summary>
        public int? InventoryBucketHash { get; private set; }

        /// <summary>
        /// The methodology to use for sorting items from the flyout.
        /// </summary>
        public int? SortItemsBy { get; private set; }


        /// <summary>
        /// Empty constructor required by some serializers.
        /// Use DestinyDefinitionsDestinyVendorInventoryFlyoutBucketDefinition.Builder() for instance creation instead.
        /// </summary>
        [Obsolete]
        public DestinyDefinitionsDestinyVendorInventoryFlyoutBucketDefinition()
        {
        }

        private DestinyDefinitionsDestinyVendorInventoryFlyoutBucketDefinition(bool? Collapsible, int? InventoryBucketHash, int? SortItemsBy)
        {
            
            this.Collapsible = Collapsible;
            
            this.InventoryBucketHash = InventoryBucketHash;
            
            this.SortItemsBy = SortItemsBy;
            
        }

        /// <summary>
        /// Returns builder of DestinyDefinitionsDestinyVendorInventoryFlyoutBucketDefinition.
        /// </summary>
        /// <returns>DestinyDefinitionsDestinyVendorInventoryFlyoutBucketDefinitionBuilder</returns>
        public static DestinyDefinitionsDestinyVendorInventoryFlyoutBucketDefinitionBuilder Builder()
        {
            return new DestinyDefinitionsDestinyVendorInventoryFlyoutBucketDefinitionBuilder();
        }

        /// <summary>
        /// Returns DestinyDefinitionsDestinyVendorInventoryFlyoutBucketDefinitionBuilder with properties set.
        /// Use it to change properties.
        /// </summary>
        /// <returns>DestinyDefinitionsDestinyVendorInventoryFlyoutBucketDefinitionBuilder</returns>
        public DestinyDefinitionsDestinyVendorInventoryFlyoutBucketDefinitionBuilder With()
        {
            return Builder()
                .Collapsible(Collapsible)
                .InventoryBucketHash(InventoryBucketHash)
                .SortItemsBy(SortItemsBy);
        }

        public override string ToString()
        {
            return this.PropertiesToString();
        }

        public override bool Equals(object obj)
        {
            return this.EqualsByProperties(obj);
        }

        public bool Equals(DestinyDefinitionsDestinyVendorInventoryFlyoutBucketDefinition other)
        {
            return Equals((object) other);
        }

        public override int GetHashCode()
        {
            return this.PropertiesHash();
        }

        /// <summary>
        /// Implementation of == operator for (DestinyDefinitionsDestinyVendorInventoryFlyoutBucketDefinition.
        /// </summary>
        /// <param name="left">Compared (DestinyDefinitionsDestinyVendorInventoryFlyoutBucketDefinition</param>
        /// <param name="right">Compared (DestinyDefinitionsDestinyVendorInventoryFlyoutBucketDefinition</param>
        /// <returns>true if compared items are equals, false otherwise</returns>
        public static bool operator == (DestinyDefinitionsDestinyVendorInventoryFlyoutBucketDefinition left, DestinyDefinitionsDestinyVendorInventoryFlyoutBucketDefinition right)
        {
            return Equals(left, right);
        }

        /// <summary>
        /// Implementation of != operator for (DestinyDefinitionsDestinyVendorInventoryFlyoutBucketDefinition.
        /// </summary>
        /// <param name="left">Compared (DestinyDefinitionsDestinyVendorInventoryFlyoutBucketDefinition</param>
        /// <param name="right">Compared (DestinyDefinitionsDestinyVendorInventoryFlyoutBucketDefinition</param>
        /// <returns>true if compared items are not equals, false otherwise</returns>
        public static bool operator != (DestinyDefinitionsDestinyVendorInventoryFlyoutBucketDefinition left, DestinyDefinitionsDestinyVendorInventoryFlyoutBucketDefinition right)
        {
            return !Equals(left, right);
        }

        /// <summary>
        /// Builder of DestinyDefinitionsDestinyVendorInventoryFlyoutBucketDefinition.
        /// </summary>
        public sealed class DestinyDefinitionsDestinyVendorInventoryFlyoutBucketDefinitionBuilder
        {
            private bool? _Collapsible;
            private int? _InventoryBucketHash;
            private int? _SortItemsBy;

            internal DestinyDefinitionsDestinyVendorInventoryFlyoutBucketDefinitionBuilder()
            {
                SetupDefaults();
            }

            private void SetupDefaults()
            {
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsDestinyVendorInventoryFlyoutBucketDefinition.Collapsible property.
            /// </summary>
            /// <param name="value">If true, the inventory bucket should be able to be collapsed visually.</param>
            public DestinyDefinitionsDestinyVendorInventoryFlyoutBucketDefinitionBuilder Collapsible(bool? value)
            {
                _Collapsible = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsDestinyVendorInventoryFlyoutBucketDefinition.InventoryBucketHash property.
            /// </summary>
            /// <param name="value">The inventory bucket whose contents should be shown.</param>
            public DestinyDefinitionsDestinyVendorInventoryFlyoutBucketDefinitionBuilder InventoryBucketHash(int? value)
            {
                _InventoryBucketHash = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsDestinyVendorInventoryFlyoutBucketDefinition.SortItemsBy property.
            /// </summary>
            /// <param name="value">The methodology to use for sorting items from the flyout.</param>
            public DestinyDefinitionsDestinyVendorInventoryFlyoutBucketDefinitionBuilder SortItemsBy(int? value)
            {
                _SortItemsBy = value;
                return this;
            }


            /// <summary>
            /// Builds instance of DestinyDefinitionsDestinyVendorInventoryFlyoutBucketDefinition.
            /// </summary>
            /// <returns>DestinyDefinitionsDestinyVendorInventoryFlyoutBucketDefinition</returns>
            public DestinyDefinitionsDestinyVendorInventoryFlyoutBucketDefinition Build()
            {
                Validate();
                return new DestinyDefinitionsDestinyVendorInventoryFlyoutBucketDefinition(
                    Collapsible: _Collapsible,
                    InventoryBucketHash: _InventoryBucketHash,
                    SortItemsBy: _SortItemsBy
                );
            }

            private void Validate()
            { 
            }
        }

        
    }
}