using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Sharpility.Extensions;
using NodaTime;

namespace BungieNetApi._Platform.Models
{
    /// <summary>
    /// The definition for an \&quot;inventory flyout\&quot;: a UI screen where we show you part of an otherwise hidden vendor inventory: like the Vault inventory buckets.
    /// </summary>
    public sealed class DestinyDefinitionsDestinyVendorInventoryFlyoutDefinition:  IEquatable<DestinyDefinitionsDestinyVendorInventoryFlyoutDefinition>
    { 
        /// <summary>
        /// If the flyout is locked, this is the reason why.
        /// </summary>
        public string LockedDescription { get; private set; }

        /// <summary>
        /// The title and other common properties of the flyout.
        /// </summary>
        public DestinyDefinitionsCommonDestinyDisplayPropertiesDefinition DisplayProperties { get; private set; }

        /// <summary>
        /// A list of inventory buckets and other metadata to show on the screen.
        /// </summary>
        public List<DestinyDefinitionsDestinyVendorInventoryFlyoutBucketDefinition> Buckets { get; private set; }

        /// <summary>
        /// An identifier for the flyout, in case anything else needs to refer to them.
        /// </summary>
        public int? FlyoutId { get; private set; }

        /// <summary>
        /// If this is true, don&#39;t show any of the glistening \&quot;this is a new item\&quot; UI elements, like we show on the inventory items themselves in in-game UI.
        /// </summary>
        public bool? SuppressNewness { get; private set; }

        /// <summary>
        /// If this flyout is meant to show you the contents of the player&#39;s equipment slot, this is the slot to show.
        /// </summary>
        public int? EquipmentSlotHash { get; private set; }


        /// <summary>
        /// Empty constructor required by some serializers.
        /// Use DestinyDefinitionsDestinyVendorInventoryFlyoutDefinition.Builder() for instance creation instead.
        /// </summary>
        [Obsolete]
        public DestinyDefinitionsDestinyVendorInventoryFlyoutDefinition()
        {
        }

        private DestinyDefinitionsDestinyVendorInventoryFlyoutDefinition(string LockedDescription, DestinyDefinitionsCommonDestinyDisplayPropertiesDefinition DisplayProperties, List<DestinyDefinitionsDestinyVendorInventoryFlyoutBucketDefinition> Buckets, int? FlyoutId, bool? SuppressNewness, int? EquipmentSlotHash)
        {
            
            this.LockedDescription = LockedDescription;
            
            this.DisplayProperties = DisplayProperties;
            
            this.Buckets = Buckets;
            
            this.FlyoutId = FlyoutId;
            
            this.SuppressNewness = SuppressNewness;
            
            this.EquipmentSlotHash = EquipmentSlotHash;
            
        }

        /// <summary>
        /// Returns builder of DestinyDefinitionsDestinyVendorInventoryFlyoutDefinition.
        /// </summary>
        /// <returns>DestinyDefinitionsDestinyVendorInventoryFlyoutDefinitionBuilder</returns>
        public static DestinyDefinitionsDestinyVendorInventoryFlyoutDefinitionBuilder Builder()
        {
            return new DestinyDefinitionsDestinyVendorInventoryFlyoutDefinitionBuilder();
        }

        /// <summary>
        /// Returns DestinyDefinitionsDestinyVendorInventoryFlyoutDefinitionBuilder with properties set.
        /// Use it to change properties.
        /// </summary>
        /// <returns>DestinyDefinitionsDestinyVendorInventoryFlyoutDefinitionBuilder</returns>
        public DestinyDefinitionsDestinyVendorInventoryFlyoutDefinitionBuilder With()
        {
            return Builder()
                .LockedDescription(LockedDescription)
                .DisplayProperties(DisplayProperties)
                .Buckets(Buckets)
                .FlyoutId(FlyoutId)
                .SuppressNewness(SuppressNewness)
                .EquipmentSlotHash(EquipmentSlotHash);
        }

        public override string ToString()
        {
            return this.PropertiesToString();
        }

        public override bool Equals(object obj)
        {
            return this.EqualsByProperties(obj);
        }

        public bool Equals(DestinyDefinitionsDestinyVendorInventoryFlyoutDefinition other)
        {
            return Equals((object) other);
        }

        public override int GetHashCode()
        {
            return this.PropertiesHash();
        }

        /// <summary>
        /// Implementation of == operator for (DestinyDefinitionsDestinyVendorInventoryFlyoutDefinition.
        /// </summary>
        /// <param name="left">Compared (DestinyDefinitionsDestinyVendorInventoryFlyoutDefinition</param>
        /// <param name="right">Compared (DestinyDefinitionsDestinyVendorInventoryFlyoutDefinition</param>
        /// <returns>true if compared items are equals, false otherwise</returns>
        public static bool operator == (DestinyDefinitionsDestinyVendorInventoryFlyoutDefinition left, DestinyDefinitionsDestinyVendorInventoryFlyoutDefinition right)
        {
            return Equals(left, right);
        }

        /// <summary>
        /// Implementation of != operator for (DestinyDefinitionsDestinyVendorInventoryFlyoutDefinition.
        /// </summary>
        /// <param name="left">Compared (DestinyDefinitionsDestinyVendorInventoryFlyoutDefinition</param>
        /// <param name="right">Compared (DestinyDefinitionsDestinyVendorInventoryFlyoutDefinition</param>
        /// <returns>true if compared items are not equals, false otherwise</returns>
        public static bool operator != (DestinyDefinitionsDestinyVendorInventoryFlyoutDefinition left, DestinyDefinitionsDestinyVendorInventoryFlyoutDefinition right)
        {
            return !Equals(left, right);
        }

        /// <summary>
        /// Builder of DestinyDefinitionsDestinyVendorInventoryFlyoutDefinition.
        /// </summary>
        public sealed class DestinyDefinitionsDestinyVendorInventoryFlyoutDefinitionBuilder
        {
            private string _LockedDescription;
            private DestinyDefinitionsCommonDestinyDisplayPropertiesDefinition _DisplayProperties;
            private List<DestinyDefinitionsDestinyVendorInventoryFlyoutBucketDefinition> _Buckets;
            private int? _FlyoutId;
            private bool? _SuppressNewness;
            private int? _EquipmentSlotHash;

            internal DestinyDefinitionsDestinyVendorInventoryFlyoutDefinitionBuilder()
            {
                SetupDefaults();
            }

            private void SetupDefaults()
            {
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsDestinyVendorInventoryFlyoutDefinition.LockedDescription property.
            /// </summary>
            /// <param name="value">If the flyout is locked, this is the reason why.</param>
            public DestinyDefinitionsDestinyVendorInventoryFlyoutDefinitionBuilder LockedDescription(string value)
            {
                _LockedDescription = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsDestinyVendorInventoryFlyoutDefinition.DisplayProperties property.
            /// </summary>
            /// <param name="value">The title and other common properties of the flyout.</param>
            public DestinyDefinitionsDestinyVendorInventoryFlyoutDefinitionBuilder DisplayProperties(DestinyDefinitionsCommonDestinyDisplayPropertiesDefinition value)
            {
                _DisplayProperties = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsDestinyVendorInventoryFlyoutDefinition.Buckets property.
            /// </summary>
            /// <param name="value">A list of inventory buckets and other metadata to show on the screen.</param>
            public DestinyDefinitionsDestinyVendorInventoryFlyoutDefinitionBuilder Buckets(List<DestinyDefinitionsDestinyVendorInventoryFlyoutBucketDefinition> value)
            {
                _Buckets = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsDestinyVendorInventoryFlyoutDefinition.FlyoutId property.
            /// </summary>
            /// <param name="value">An identifier for the flyout, in case anything else needs to refer to them.</param>
            public DestinyDefinitionsDestinyVendorInventoryFlyoutDefinitionBuilder FlyoutId(int? value)
            {
                _FlyoutId = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsDestinyVendorInventoryFlyoutDefinition.SuppressNewness property.
            /// </summary>
            /// <param name="value">If this is true, don&#39;t show any of the glistening \&quot;this is a new item\&quot; UI elements, like we show on the inventory items themselves in in-game UI.</param>
            public DestinyDefinitionsDestinyVendorInventoryFlyoutDefinitionBuilder SuppressNewness(bool? value)
            {
                _SuppressNewness = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsDestinyVendorInventoryFlyoutDefinition.EquipmentSlotHash property.
            /// </summary>
            /// <param name="value">If this flyout is meant to show you the contents of the player&#39;s equipment slot, this is the slot to show.</param>
            public DestinyDefinitionsDestinyVendorInventoryFlyoutDefinitionBuilder EquipmentSlotHash(int? value)
            {
                _EquipmentSlotHash = value;
                return this;
            }


            /// <summary>
            /// Builds instance of DestinyDefinitionsDestinyVendorInventoryFlyoutDefinition.
            /// </summary>
            /// <returns>DestinyDefinitionsDestinyVendorInventoryFlyoutDefinition</returns>
            public DestinyDefinitionsDestinyVendorInventoryFlyoutDefinition Build()
            {
                Validate();
                return new DestinyDefinitionsDestinyVendorInventoryFlyoutDefinition(
                    LockedDescription: _LockedDescription,
                    DisplayProperties: _DisplayProperties,
                    Buckets: _Buckets,
                    FlyoutId: _FlyoutId,
                    SuppressNewness: _SuppressNewness,
                    EquipmentSlotHash: _EquipmentSlotHash
                );
            }

            private void Validate()
            { 
            }
        }

        
    }
}