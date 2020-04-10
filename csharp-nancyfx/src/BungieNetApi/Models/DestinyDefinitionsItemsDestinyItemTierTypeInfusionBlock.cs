using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Sharpility.Extensions;
using NodaTime;

namespace BungieNetApi._Platform.Models
{
    /// <summary>
    /// DestinyDefinitionsItemsDestinyItemTierTypeInfusionBlock
    /// </summary>
    public sealed class DestinyDefinitionsItemsDestinyItemTierTypeInfusionBlock:  IEquatable<DestinyDefinitionsItemsDestinyItemTierTypeInfusionBlock>
    { 
        /// <summary>
        /// The default portion of quality that will transfer from the infuser to the infusee item. (InfuserQuality - InfuseeQuality) * baseQualityTransferRatio &#x3D; base quality transferred.
        /// </summary>
        public float? BaseQualityTransferRatio { get; private set; }

        /// <summary>
        /// As long as InfuserQuality &gt; InfuseeQuality, the amount of quality bestowed is guaranteed to be at least this value, even if the transferRatio would dictate that it should be less. The total amount of quality that ends up in the Infusee cannot exceed the Infuser&#39;s quality however (for instance, if you infuse a 300 item with a 301 item and the minimum quality increment is 10, the infused item will not end up with 310 quality)
        /// </summary>
        public int? MinimumQualityIncrement { get; private set; }


        /// <summary>
        /// Empty constructor required by some serializers.
        /// Use DestinyDefinitionsItemsDestinyItemTierTypeInfusionBlock.Builder() for instance creation instead.
        /// </summary>
        [Obsolete]
        public DestinyDefinitionsItemsDestinyItemTierTypeInfusionBlock()
        {
        }

        private DestinyDefinitionsItemsDestinyItemTierTypeInfusionBlock(float? BaseQualityTransferRatio, int? MinimumQualityIncrement)
        {
            
            this.BaseQualityTransferRatio = BaseQualityTransferRatio;
            
            this.MinimumQualityIncrement = MinimumQualityIncrement;
            
        }

        /// <summary>
        /// Returns builder of DestinyDefinitionsItemsDestinyItemTierTypeInfusionBlock.
        /// </summary>
        /// <returns>DestinyDefinitionsItemsDestinyItemTierTypeInfusionBlockBuilder</returns>
        public static DestinyDefinitionsItemsDestinyItemTierTypeInfusionBlockBuilder Builder()
        {
            return new DestinyDefinitionsItemsDestinyItemTierTypeInfusionBlockBuilder();
        }

        /// <summary>
        /// Returns DestinyDefinitionsItemsDestinyItemTierTypeInfusionBlockBuilder with properties set.
        /// Use it to change properties.
        /// </summary>
        /// <returns>DestinyDefinitionsItemsDestinyItemTierTypeInfusionBlockBuilder</returns>
        public DestinyDefinitionsItemsDestinyItemTierTypeInfusionBlockBuilder With()
        {
            return Builder()
                .BaseQualityTransferRatio(BaseQualityTransferRatio)
                .MinimumQualityIncrement(MinimumQualityIncrement);
        }

        public override string ToString()
        {
            return this.PropertiesToString();
        }

        public override bool Equals(object obj)
        {
            return this.EqualsByProperties(obj);
        }

        public bool Equals(DestinyDefinitionsItemsDestinyItemTierTypeInfusionBlock other)
        {
            return Equals((object) other);
        }

        public override int GetHashCode()
        {
            return this.PropertiesHash();
        }

        /// <summary>
        /// Implementation of == operator for (DestinyDefinitionsItemsDestinyItemTierTypeInfusionBlock.
        /// </summary>
        /// <param name="left">Compared (DestinyDefinitionsItemsDestinyItemTierTypeInfusionBlock</param>
        /// <param name="right">Compared (DestinyDefinitionsItemsDestinyItemTierTypeInfusionBlock</param>
        /// <returns>true if compared items are equals, false otherwise</returns>
        public static bool operator == (DestinyDefinitionsItemsDestinyItemTierTypeInfusionBlock left, DestinyDefinitionsItemsDestinyItemTierTypeInfusionBlock right)
        {
            return Equals(left, right);
        }

        /// <summary>
        /// Implementation of != operator for (DestinyDefinitionsItemsDestinyItemTierTypeInfusionBlock.
        /// </summary>
        /// <param name="left">Compared (DestinyDefinitionsItemsDestinyItemTierTypeInfusionBlock</param>
        /// <param name="right">Compared (DestinyDefinitionsItemsDestinyItemTierTypeInfusionBlock</param>
        /// <returns>true if compared items are not equals, false otherwise</returns>
        public static bool operator != (DestinyDefinitionsItemsDestinyItemTierTypeInfusionBlock left, DestinyDefinitionsItemsDestinyItemTierTypeInfusionBlock right)
        {
            return !Equals(left, right);
        }

        /// <summary>
        /// Builder of DestinyDefinitionsItemsDestinyItemTierTypeInfusionBlock.
        /// </summary>
        public sealed class DestinyDefinitionsItemsDestinyItemTierTypeInfusionBlockBuilder
        {
            private float? _BaseQualityTransferRatio;
            private int? _MinimumQualityIncrement;

            internal DestinyDefinitionsItemsDestinyItemTierTypeInfusionBlockBuilder()
            {
                SetupDefaults();
            }

            private void SetupDefaults()
            {
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsItemsDestinyItemTierTypeInfusionBlock.BaseQualityTransferRatio property.
            /// </summary>
            /// <param name="value">The default portion of quality that will transfer from the infuser to the infusee item. (InfuserQuality - InfuseeQuality) * baseQualityTransferRatio &#x3D; base quality transferred.</param>
            public DestinyDefinitionsItemsDestinyItemTierTypeInfusionBlockBuilder BaseQualityTransferRatio(float? value)
            {
                _BaseQualityTransferRatio = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsItemsDestinyItemTierTypeInfusionBlock.MinimumQualityIncrement property.
            /// </summary>
            /// <param name="value">As long as InfuserQuality &gt; InfuseeQuality, the amount of quality bestowed is guaranteed to be at least this value, even if the transferRatio would dictate that it should be less. The total amount of quality that ends up in the Infusee cannot exceed the Infuser&#39;s quality however (for instance, if you infuse a 300 item with a 301 item and the minimum quality increment is 10, the infused item will not end up with 310 quality)</param>
            public DestinyDefinitionsItemsDestinyItemTierTypeInfusionBlockBuilder MinimumQualityIncrement(int? value)
            {
                _MinimumQualityIncrement = value;
                return this;
            }


            /// <summary>
            /// Builds instance of DestinyDefinitionsItemsDestinyItemTierTypeInfusionBlock.
            /// </summary>
            /// <returns>DestinyDefinitionsItemsDestinyItemTierTypeInfusionBlock</returns>
            public DestinyDefinitionsItemsDestinyItemTierTypeInfusionBlock Build()
            {
                Validate();
                return new DestinyDefinitionsItemsDestinyItemTierTypeInfusionBlock(
                    BaseQualityTransferRatio: _BaseQualityTransferRatio,
                    MinimumQualityIncrement: _MinimumQualityIncrement
                );
            }

            private void Validate()
            { 
            }
        }

        
    }
}