using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Sharpility.Extensions;
using NodaTime;

namespace BungieNetApi._Platform.Models
{
    /// <summary>
    /// If the item can exist in an inventory - the overwhelming majority of them can and do - then this is the basic properties regarding the item&#39;s relationship with the inventory.
    /// </summary>
    public sealed class DestinyDefinitionsDestinyItemInventoryBlockDefinition:  IEquatable<DestinyDefinitionsDestinyItemInventoryBlockDefinition>
    { 
        /// <summary>
        /// If this string is populated, you can&#39;t have more than one stack with this label in a given inventory. Note that this is different from the equipping block&#39;s unique label, which is used for equipping uniqueness.
        /// </summary>
        public string StackUniqueLabel { get; private set; }

        /// <summary>
        /// The maximum quantity of this item that can exist in a stack.
        /// </summary>
        public int? MaxStackSize { get; private set; }

        /// <summary>
        /// The hash identifier for the DestinyInventoryBucketDefinition to which this item belongs. I should have named this \&quot;bucketHash\&quot;, but too many things refer to it now. Sigh.
        /// </summary>
        public int? BucketTypeHash { get; private set; }

        /// <summary>
        /// If the item is picked up by the lost loot queue, this is the hash identifier for the DestinyInventoryBucketDefinition into which it will be placed. Again, I should have named this recoveryBucketHash instead.
        /// </summary>
        public int? RecoveryBucketTypeHash { get; private set; }

        /// <summary>
        /// The hash identifier for the Tier Type of the item, use to look up its DestinyItemTierTypeDefinition if you need to show localized data for the item&#39;s tier.
        /// </summary>
        public int? TierTypeHash { get; private set; }

        /// <summary>
        /// If TRUE, this item is instanced. Otherwise, it is a generic item that merely has a quantity in a stack (like Glimmer).
        /// </summary>
        public bool? IsInstanceItem { get; private set; }

        /// <summary>
        /// The localized name of the tier type, which is a useful shortcut so you don&#39;t have to look up the definition every time. However, it&#39;s mostly a holdover from days before we had a DestinyItemTierTypeDefinition to refer to.
        /// </summary>
        public string TierTypeName { get; private set; }

        /// <summary>
        /// The enumeration matching the tier type of the item to known values, again for convenience sake.
        /// </summary>
        public int? TierType { get; private set; }

        /// <summary>
        /// The tooltip message to show, if any, when the item expires.
        /// </summary>
        public string ExpirationTooltip { get; private set; }

        /// <summary>
        /// If the item expires while playing in an activity, we show a different message.
        /// </summary>
        public string ExpiredInActivityMessage { get; private set; }

        /// <summary>
        /// If the item expires in orbit, we show a... more different message. (\&quot;Consummate V&#39;s, consummate!\&quot;)
        /// </summary>
        public string ExpiredInOrbitMessage { get; private set; }

        /// <summary>
        /// SuppressExpirationWhenObjectivesComplete
        /// </summary>
        public bool? SuppressExpirationWhenObjectivesComplete { get; private set; }


        /// <summary>
        /// Empty constructor required by some serializers.
        /// Use DestinyDefinitionsDestinyItemInventoryBlockDefinition.Builder() for instance creation instead.
        /// </summary>
        [Obsolete]
        public DestinyDefinitionsDestinyItemInventoryBlockDefinition()
        {
        }

        private DestinyDefinitionsDestinyItemInventoryBlockDefinition(string StackUniqueLabel, int? MaxStackSize, int? BucketTypeHash, int? RecoveryBucketTypeHash, int? TierTypeHash, bool? IsInstanceItem, string TierTypeName, int? TierType, string ExpirationTooltip, string ExpiredInActivityMessage, string ExpiredInOrbitMessage, bool? SuppressExpirationWhenObjectivesComplete)
        {
            
            this.StackUniqueLabel = StackUniqueLabel;
            
            this.MaxStackSize = MaxStackSize;
            
            this.BucketTypeHash = BucketTypeHash;
            
            this.RecoveryBucketTypeHash = RecoveryBucketTypeHash;
            
            this.TierTypeHash = TierTypeHash;
            
            this.IsInstanceItem = IsInstanceItem;
            
            this.TierTypeName = TierTypeName;
            
            this.TierType = TierType;
            
            this.ExpirationTooltip = ExpirationTooltip;
            
            this.ExpiredInActivityMessage = ExpiredInActivityMessage;
            
            this.ExpiredInOrbitMessage = ExpiredInOrbitMessage;
            
            this.SuppressExpirationWhenObjectivesComplete = SuppressExpirationWhenObjectivesComplete;
            
        }

        /// <summary>
        /// Returns builder of DestinyDefinitionsDestinyItemInventoryBlockDefinition.
        /// </summary>
        /// <returns>DestinyDefinitionsDestinyItemInventoryBlockDefinitionBuilder</returns>
        public static DestinyDefinitionsDestinyItemInventoryBlockDefinitionBuilder Builder()
        {
            return new DestinyDefinitionsDestinyItemInventoryBlockDefinitionBuilder();
        }

        /// <summary>
        /// Returns DestinyDefinitionsDestinyItemInventoryBlockDefinitionBuilder with properties set.
        /// Use it to change properties.
        /// </summary>
        /// <returns>DestinyDefinitionsDestinyItemInventoryBlockDefinitionBuilder</returns>
        public DestinyDefinitionsDestinyItemInventoryBlockDefinitionBuilder With()
        {
            return Builder()
                .StackUniqueLabel(StackUniqueLabel)
                .MaxStackSize(MaxStackSize)
                .BucketTypeHash(BucketTypeHash)
                .RecoveryBucketTypeHash(RecoveryBucketTypeHash)
                .TierTypeHash(TierTypeHash)
                .IsInstanceItem(IsInstanceItem)
                .TierTypeName(TierTypeName)
                .TierType(TierType)
                .ExpirationTooltip(ExpirationTooltip)
                .ExpiredInActivityMessage(ExpiredInActivityMessage)
                .ExpiredInOrbitMessage(ExpiredInOrbitMessage)
                .SuppressExpirationWhenObjectivesComplete(SuppressExpirationWhenObjectivesComplete);
        }

        public override string ToString()
        {
            return this.PropertiesToString();
        }

        public override bool Equals(object obj)
        {
            return this.EqualsByProperties(obj);
        }

        public bool Equals(DestinyDefinitionsDestinyItemInventoryBlockDefinition other)
        {
            return Equals((object) other);
        }

        public override int GetHashCode()
        {
            return this.PropertiesHash();
        }

        /// <summary>
        /// Implementation of == operator for (DestinyDefinitionsDestinyItemInventoryBlockDefinition.
        /// </summary>
        /// <param name="left">Compared (DestinyDefinitionsDestinyItemInventoryBlockDefinition</param>
        /// <param name="right">Compared (DestinyDefinitionsDestinyItemInventoryBlockDefinition</param>
        /// <returns>true if compared items are equals, false otherwise</returns>
        public static bool operator == (DestinyDefinitionsDestinyItemInventoryBlockDefinition left, DestinyDefinitionsDestinyItemInventoryBlockDefinition right)
        {
            return Equals(left, right);
        }

        /// <summary>
        /// Implementation of != operator for (DestinyDefinitionsDestinyItemInventoryBlockDefinition.
        /// </summary>
        /// <param name="left">Compared (DestinyDefinitionsDestinyItemInventoryBlockDefinition</param>
        /// <param name="right">Compared (DestinyDefinitionsDestinyItemInventoryBlockDefinition</param>
        /// <returns>true if compared items are not equals, false otherwise</returns>
        public static bool operator != (DestinyDefinitionsDestinyItemInventoryBlockDefinition left, DestinyDefinitionsDestinyItemInventoryBlockDefinition right)
        {
            return !Equals(left, right);
        }

        /// <summary>
        /// Builder of DestinyDefinitionsDestinyItemInventoryBlockDefinition.
        /// </summary>
        public sealed class DestinyDefinitionsDestinyItemInventoryBlockDefinitionBuilder
        {
            private string _StackUniqueLabel;
            private int? _MaxStackSize;
            private int? _BucketTypeHash;
            private int? _RecoveryBucketTypeHash;
            private int? _TierTypeHash;
            private bool? _IsInstanceItem;
            private string _TierTypeName;
            private int? _TierType;
            private string _ExpirationTooltip;
            private string _ExpiredInActivityMessage;
            private string _ExpiredInOrbitMessage;
            private bool? _SuppressExpirationWhenObjectivesComplete;

            internal DestinyDefinitionsDestinyItemInventoryBlockDefinitionBuilder()
            {
                SetupDefaults();
            }

            private void SetupDefaults()
            {
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsDestinyItemInventoryBlockDefinition.StackUniqueLabel property.
            /// </summary>
            /// <param name="value">If this string is populated, you can&#39;t have more than one stack with this label in a given inventory. Note that this is different from the equipping block&#39;s unique label, which is used for equipping uniqueness.</param>
            public DestinyDefinitionsDestinyItemInventoryBlockDefinitionBuilder StackUniqueLabel(string value)
            {
                _StackUniqueLabel = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsDestinyItemInventoryBlockDefinition.MaxStackSize property.
            /// </summary>
            /// <param name="value">The maximum quantity of this item that can exist in a stack.</param>
            public DestinyDefinitionsDestinyItemInventoryBlockDefinitionBuilder MaxStackSize(int? value)
            {
                _MaxStackSize = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsDestinyItemInventoryBlockDefinition.BucketTypeHash property.
            /// </summary>
            /// <param name="value">The hash identifier for the DestinyInventoryBucketDefinition to which this item belongs. I should have named this \&quot;bucketHash\&quot;, but too many things refer to it now. Sigh.</param>
            public DestinyDefinitionsDestinyItemInventoryBlockDefinitionBuilder BucketTypeHash(int? value)
            {
                _BucketTypeHash = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsDestinyItemInventoryBlockDefinition.RecoveryBucketTypeHash property.
            /// </summary>
            /// <param name="value">If the item is picked up by the lost loot queue, this is the hash identifier for the DestinyInventoryBucketDefinition into which it will be placed. Again, I should have named this recoveryBucketHash instead.</param>
            public DestinyDefinitionsDestinyItemInventoryBlockDefinitionBuilder RecoveryBucketTypeHash(int? value)
            {
                _RecoveryBucketTypeHash = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsDestinyItemInventoryBlockDefinition.TierTypeHash property.
            /// </summary>
            /// <param name="value">The hash identifier for the Tier Type of the item, use to look up its DestinyItemTierTypeDefinition if you need to show localized data for the item&#39;s tier.</param>
            public DestinyDefinitionsDestinyItemInventoryBlockDefinitionBuilder TierTypeHash(int? value)
            {
                _TierTypeHash = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsDestinyItemInventoryBlockDefinition.IsInstanceItem property.
            /// </summary>
            /// <param name="value">If TRUE, this item is instanced. Otherwise, it is a generic item that merely has a quantity in a stack (like Glimmer).</param>
            public DestinyDefinitionsDestinyItemInventoryBlockDefinitionBuilder IsInstanceItem(bool? value)
            {
                _IsInstanceItem = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsDestinyItemInventoryBlockDefinition.TierTypeName property.
            /// </summary>
            /// <param name="value">The localized name of the tier type, which is a useful shortcut so you don&#39;t have to look up the definition every time. However, it&#39;s mostly a holdover from days before we had a DestinyItemTierTypeDefinition to refer to.</param>
            public DestinyDefinitionsDestinyItemInventoryBlockDefinitionBuilder TierTypeName(string value)
            {
                _TierTypeName = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsDestinyItemInventoryBlockDefinition.TierType property.
            /// </summary>
            /// <param name="value">The enumeration matching the tier type of the item to known values, again for convenience sake.</param>
            public DestinyDefinitionsDestinyItemInventoryBlockDefinitionBuilder TierType(int? value)
            {
                _TierType = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsDestinyItemInventoryBlockDefinition.ExpirationTooltip property.
            /// </summary>
            /// <param name="value">The tooltip message to show, if any, when the item expires.</param>
            public DestinyDefinitionsDestinyItemInventoryBlockDefinitionBuilder ExpirationTooltip(string value)
            {
                _ExpirationTooltip = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsDestinyItemInventoryBlockDefinition.ExpiredInActivityMessage property.
            /// </summary>
            /// <param name="value">If the item expires while playing in an activity, we show a different message.</param>
            public DestinyDefinitionsDestinyItemInventoryBlockDefinitionBuilder ExpiredInActivityMessage(string value)
            {
                _ExpiredInActivityMessage = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsDestinyItemInventoryBlockDefinition.ExpiredInOrbitMessage property.
            /// </summary>
            /// <param name="value">If the item expires in orbit, we show a... more different message. (\&quot;Consummate V&#39;s, consummate!\&quot;)</param>
            public DestinyDefinitionsDestinyItemInventoryBlockDefinitionBuilder ExpiredInOrbitMessage(string value)
            {
                _ExpiredInOrbitMessage = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsDestinyItemInventoryBlockDefinition.SuppressExpirationWhenObjectivesComplete property.
            /// </summary>
            /// <param name="value">SuppressExpirationWhenObjectivesComplete</param>
            public DestinyDefinitionsDestinyItemInventoryBlockDefinitionBuilder SuppressExpirationWhenObjectivesComplete(bool? value)
            {
                _SuppressExpirationWhenObjectivesComplete = value;
                return this;
            }


            /// <summary>
            /// Builds instance of DestinyDefinitionsDestinyItemInventoryBlockDefinition.
            /// </summary>
            /// <returns>DestinyDefinitionsDestinyItemInventoryBlockDefinition</returns>
            public DestinyDefinitionsDestinyItemInventoryBlockDefinition Build()
            {
                Validate();
                return new DestinyDefinitionsDestinyItemInventoryBlockDefinition(
                    StackUniqueLabel: _StackUniqueLabel,
                    MaxStackSize: _MaxStackSize,
                    BucketTypeHash: _BucketTypeHash,
                    RecoveryBucketTypeHash: _RecoveryBucketTypeHash,
                    TierTypeHash: _TierTypeHash,
                    IsInstanceItem: _IsInstanceItem,
                    TierTypeName: _TierTypeName,
                    TierType: _TierType,
                    ExpirationTooltip: _ExpirationTooltip,
                    ExpiredInActivityMessage: _ExpiredInActivityMessage,
                    ExpiredInOrbitMessage: _ExpiredInOrbitMessage,
                    SuppressExpirationWhenObjectivesComplete: _SuppressExpirationWhenObjectivesComplete
                );
            }

            private void Validate()
            { 
            }
        }

        
    }
}