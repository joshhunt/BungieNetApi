using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Sharpility.Extensions;
using NodaTime;

namespace BungieNetApi._Platform.Models
{
    /// <summary>
    /// The results of an Equipping operation performed through the Destiny API.
    /// </summary>
    public sealed class DestinyDestinyEquipItemResult:  IEquatable<DestinyDestinyEquipItemResult>
    { 
        /// <summary>
        /// The instance ID of the item in question (all items that can be equipped must, but definition, be Instanced and thus have an Instance ID that you can use to refer to them)
        /// </summary>
        public long? ItemInstanceId { get; private set; }

        /// <summary>
        /// A PlatformErrorCodes enum indicating whether it succeeded, and if it failed why.
        /// </summary>
        public int? EquipStatus { get; private set; }


        /// <summary>
        /// Empty constructor required by some serializers.
        /// Use DestinyDestinyEquipItemResult.Builder() for instance creation instead.
        /// </summary>
        [Obsolete]
        public DestinyDestinyEquipItemResult()
        {
        }

        private DestinyDestinyEquipItemResult(long? ItemInstanceId, int? EquipStatus)
        {
            
            this.ItemInstanceId = ItemInstanceId;
            
            this.EquipStatus = EquipStatus;
            
        }

        /// <summary>
        /// Returns builder of DestinyDestinyEquipItemResult.
        /// </summary>
        /// <returns>DestinyDestinyEquipItemResultBuilder</returns>
        public static DestinyDestinyEquipItemResultBuilder Builder()
        {
            return new DestinyDestinyEquipItemResultBuilder();
        }

        /// <summary>
        /// Returns DestinyDestinyEquipItemResultBuilder with properties set.
        /// Use it to change properties.
        /// </summary>
        /// <returns>DestinyDestinyEquipItemResultBuilder</returns>
        public DestinyDestinyEquipItemResultBuilder With()
        {
            return Builder()
                .ItemInstanceId(ItemInstanceId)
                .EquipStatus(EquipStatus);
        }

        public override string ToString()
        {
            return this.PropertiesToString();
        }

        public override bool Equals(object obj)
        {
            return this.EqualsByProperties(obj);
        }

        public bool Equals(DestinyDestinyEquipItemResult other)
        {
            return Equals((object) other);
        }

        public override int GetHashCode()
        {
            return this.PropertiesHash();
        }

        /// <summary>
        /// Implementation of == operator for (DestinyDestinyEquipItemResult.
        /// </summary>
        /// <param name="left">Compared (DestinyDestinyEquipItemResult</param>
        /// <param name="right">Compared (DestinyDestinyEquipItemResult</param>
        /// <returns>true if compared items are equals, false otherwise</returns>
        public static bool operator == (DestinyDestinyEquipItemResult left, DestinyDestinyEquipItemResult right)
        {
            return Equals(left, right);
        }

        /// <summary>
        /// Implementation of != operator for (DestinyDestinyEquipItemResult.
        /// </summary>
        /// <param name="left">Compared (DestinyDestinyEquipItemResult</param>
        /// <param name="right">Compared (DestinyDestinyEquipItemResult</param>
        /// <returns>true if compared items are not equals, false otherwise</returns>
        public static bool operator != (DestinyDestinyEquipItemResult left, DestinyDestinyEquipItemResult right)
        {
            return !Equals(left, right);
        }

        /// <summary>
        /// Builder of DestinyDestinyEquipItemResult.
        /// </summary>
        public sealed class DestinyDestinyEquipItemResultBuilder
        {
            private long? _ItemInstanceId;
            private int? _EquipStatus;

            internal DestinyDestinyEquipItemResultBuilder()
            {
                SetupDefaults();
            }

            private void SetupDefaults()
            {
            }

            /// <summary>
            /// Sets value for DestinyDestinyEquipItemResult.ItemInstanceId property.
            /// </summary>
            /// <param name="value">The instance ID of the item in question (all items that can be equipped must, but definition, be Instanced and thus have an Instance ID that you can use to refer to them)</param>
            public DestinyDestinyEquipItemResultBuilder ItemInstanceId(long? value)
            {
                _ItemInstanceId = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDestinyEquipItemResult.EquipStatus property.
            /// </summary>
            /// <param name="value">A PlatformErrorCodes enum indicating whether it succeeded, and if it failed why.</param>
            public DestinyDestinyEquipItemResultBuilder EquipStatus(int? value)
            {
                _EquipStatus = value;
                return this;
            }


            /// <summary>
            /// Builds instance of DestinyDestinyEquipItemResult.
            /// </summary>
            /// <returns>DestinyDestinyEquipItemResult</returns>
            public DestinyDestinyEquipItemResult Build()
            {
                Validate();
                return new DestinyDestinyEquipItemResult(
                    ItemInstanceId: _ItemInstanceId,
                    EquipStatus: _EquipStatus
                );
            }

            private void Validate()
            { 
            }
        }

        
    }
}