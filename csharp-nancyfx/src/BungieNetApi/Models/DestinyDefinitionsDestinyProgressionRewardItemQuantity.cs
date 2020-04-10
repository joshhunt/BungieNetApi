using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Sharpility.Extensions;
using NodaTime;

namespace BungieNetApi._Platform.Models
{
    /// <summary>
    /// DestinyDefinitionsDestinyProgressionRewardItemQuantity
    /// </summary>
    public sealed class DestinyDefinitionsDestinyProgressionRewardItemQuantity:  IEquatable<DestinyDefinitionsDestinyProgressionRewardItemQuantity>
    { 
        /// <summary>
        /// RewardedAtProgressionLevel
        /// </summary>
        public int? RewardedAtProgressionLevel { get; private set; }

        /// <summary>
        /// AcquisitionBehavior
        /// </summary>
        public int? AcquisitionBehavior { get; private set; }

        /// <summary>
        /// UiDisplayStyle
        /// </summary>
        public string UiDisplayStyle { get; private set; }

        /// <summary>
        /// ClaimUnlockDisplayStrings
        /// </summary>
        public List<string> ClaimUnlockDisplayStrings { get; private set; }

        /// <summary>
        /// The hash identifier for the item in question. Use it to look up the item&#39;s DestinyInventoryItemDefinition.
        /// </summary>
        public int? ItemHash { get; private set; }

        /// <summary>
        /// If this quantity is referring to a specific instance of an item, this will have the item&#39;s instance ID. Normally, this will be null.
        /// </summary>
        public long? ItemInstanceId { get; private set; }

        /// <summary>
        /// The amount of the item needed/available depending on the context of where DestinyItemQuantity is being used.
        /// </summary>
        public int? Quantity { get; private set; }


        /// <summary>
        /// Empty constructor required by some serializers.
        /// Use DestinyDefinitionsDestinyProgressionRewardItemQuantity.Builder() for instance creation instead.
        /// </summary>
        [Obsolete]
        public DestinyDefinitionsDestinyProgressionRewardItemQuantity()
        {
        }

        private DestinyDefinitionsDestinyProgressionRewardItemQuantity(int? RewardedAtProgressionLevel, int? AcquisitionBehavior, string UiDisplayStyle, List<string> ClaimUnlockDisplayStrings, int? ItemHash, long? ItemInstanceId, int? Quantity)
        {
            
            this.RewardedAtProgressionLevel = RewardedAtProgressionLevel;
            
            this.AcquisitionBehavior = AcquisitionBehavior;
            
            this.UiDisplayStyle = UiDisplayStyle;
            
            this.ClaimUnlockDisplayStrings = ClaimUnlockDisplayStrings;
            
            this.ItemHash = ItemHash;
            
            this.ItemInstanceId = ItemInstanceId;
            
            this.Quantity = Quantity;
            
        }

        /// <summary>
        /// Returns builder of DestinyDefinitionsDestinyProgressionRewardItemQuantity.
        /// </summary>
        /// <returns>DestinyDefinitionsDestinyProgressionRewardItemQuantityBuilder</returns>
        public static DestinyDefinitionsDestinyProgressionRewardItemQuantityBuilder Builder()
        {
            return new DestinyDefinitionsDestinyProgressionRewardItemQuantityBuilder();
        }

        /// <summary>
        /// Returns DestinyDefinitionsDestinyProgressionRewardItemQuantityBuilder with properties set.
        /// Use it to change properties.
        /// </summary>
        /// <returns>DestinyDefinitionsDestinyProgressionRewardItemQuantityBuilder</returns>
        public DestinyDefinitionsDestinyProgressionRewardItemQuantityBuilder With()
        {
            return Builder()
                .RewardedAtProgressionLevel(RewardedAtProgressionLevel)
                .AcquisitionBehavior(AcquisitionBehavior)
                .UiDisplayStyle(UiDisplayStyle)
                .ClaimUnlockDisplayStrings(ClaimUnlockDisplayStrings)
                .ItemHash(ItemHash)
                .ItemInstanceId(ItemInstanceId)
                .Quantity(Quantity);
        }

        public override string ToString()
        {
            return this.PropertiesToString();
        }

        public override bool Equals(object obj)
        {
            return this.EqualsByProperties(obj);
        }

        public bool Equals(DestinyDefinitionsDestinyProgressionRewardItemQuantity other)
        {
            return Equals((object) other);
        }

        public override int GetHashCode()
        {
            return this.PropertiesHash();
        }

        /// <summary>
        /// Implementation of == operator for (DestinyDefinitionsDestinyProgressionRewardItemQuantity.
        /// </summary>
        /// <param name="left">Compared (DestinyDefinitionsDestinyProgressionRewardItemQuantity</param>
        /// <param name="right">Compared (DestinyDefinitionsDestinyProgressionRewardItemQuantity</param>
        /// <returns>true if compared items are equals, false otherwise</returns>
        public static bool operator == (DestinyDefinitionsDestinyProgressionRewardItemQuantity left, DestinyDefinitionsDestinyProgressionRewardItemQuantity right)
        {
            return Equals(left, right);
        }

        /// <summary>
        /// Implementation of != operator for (DestinyDefinitionsDestinyProgressionRewardItemQuantity.
        /// </summary>
        /// <param name="left">Compared (DestinyDefinitionsDestinyProgressionRewardItemQuantity</param>
        /// <param name="right">Compared (DestinyDefinitionsDestinyProgressionRewardItemQuantity</param>
        /// <returns>true if compared items are not equals, false otherwise</returns>
        public static bool operator != (DestinyDefinitionsDestinyProgressionRewardItemQuantity left, DestinyDefinitionsDestinyProgressionRewardItemQuantity right)
        {
            return !Equals(left, right);
        }

        /// <summary>
        /// Builder of DestinyDefinitionsDestinyProgressionRewardItemQuantity.
        /// </summary>
        public sealed class DestinyDefinitionsDestinyProgressionRewardItemQuantityBuilder
        {
            private int? _RewardedAtProgressionLevel;
            private int? _AcquisitionBehavior;
            private string _UiDisplayStyle;
            private List<string> _ClaimUnlockDisplayStrings;
            private int? _ItemHash;
            private long? _ItemInstanceId;
            private int? _Quantity;

            internal DestinyDefinitionsDestinyProgressionRewardItemQuantityBuilder()
            {
                SetupDefaults();
            }

            private void SetupDefaults()
            {
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsDestinyProgressionRewardItemQuantity.RewardedAtProgressionLevel property.
            /// </summary>
            /// <param name="value">RewardedAtProgressionLevel</param>
            public DestinyDefinitionsDestinyProgressionRewardItemQuantityBuilder RewardedAtProgressionLevel(int? value)
            {
                _RewardedAtProgressionLevel = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsDestinyProgressionRewardItemQuantity.AcquisitionBehavior property.
            /// </summary>
            /// <param name="value">AcquisitionBehavior</param>
            public DestinyDefinitionsDestinyProgressionRewardItemQuantityBuilder AcquisitionBehavior(int? value)
            {
                _AcquisitionBehavior = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsDestinyProgressionRewardItemQuantity.UiDisplayStyle property.
            /// </summary>
            /// <param name="value">UiDisplayStyle</param>
            public DestinyDefinitionsDestinyProgressionRewardItemQuantityBuilder UiDisplayStyle(string value)
            {
                _UiDisplayStyle = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsDestinyProgressionRewardItemQuantity.ClaimUnlockDisplayStrings property.
            /// </summary>
            /// <param name="value">ClaimUnlockDisplayStrings</param>
            public DestinyDefinitionsDestinyProgressionRewardItemQuantityBuilder ClaimUnlockDisplayStrings(List<string> value)
            {
                _ClaimUnlockDisplayStrings = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsDestinyProgressionRewardItemQuantity.ItemHash property.
            /// </summary>
            /// <param name="value">The hash identifier for the item in question. Use it to look up the item&#39;s DestinyInventoryItemDefinition.</param>
            public DestinyDefinitionsDestinyProgressionRewardItemQuantityBuilder ItemHash(int? value)
            {
                _ItemHash = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsDestinyProgressionRewardItemQuantity.ItemInstanceId property.
            /// </summary>
            /// <param name="value">If this quantity is referring to a specific instance of an item, this will have the item&#39;s instance ID. Normally, this will be null.</param>
            public DestinyDefinitionsDestinyProgressionRewardItemQuantityBuilder ItemInstanceId(long? value)
            {
                _ItemInstanceId = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsDestinyProgressionRewardItemQuantity.Quantity property.
            /// </summary>
            /// <param name="value">The amount of the item needed/available depending on the context of where DestinyItemQuantity is being used.</param>
            public DestinyDefinitionsDestinyProgressionRewardItemQuantityBuilder Quantity(int? value)
            {
                _Quantity = value;
                return this;
            }


            /// <summary>
            /// Builds instance of DestinyDefinitionsDestinyProgressionRewardItemQuantity.
            /// </summary>
            /// <returns>DestinyDefinitionsDestinyProgressionRewardItemQuantity</returns>
            public DestinyDefinitionsDestinyProgressionRewardItemQuantity Build()
            {
                Validate();
                return new DestinyDefinitionsDestinyProgressionRewardItemQuantity(
                    RewardedAtProgressionLevel: _RewardedAtProgressionLevel,
                    AcquisitionBehavior: _AcquisitionBehavior,
                    UiDisplayStyle: _UiDisplayStyle,
                    ClaimUnlockDisplayStrings: _ClaimUnlockDisplayStrings,
                    ItemHash: _ItemHash,
                    ItemInstanceId: _ItemInstanceId,
                    Quantity: _Quantity
                );
            }

            private void Validate()
            { 
            }
        }

        
    }
}