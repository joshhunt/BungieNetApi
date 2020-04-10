using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Sharpility.Extensions;
using NodaTime;

namespace BungieNetApi._Platform.Models
{
    /// <summary>
    /// If a character purchased an item that is refundable, a Vendor Receipt will be created on the user&#39;s Destiny Profile. These expire after a configurable period of time, but until then can be used to get refunds on items. BNet does not provide the ability to refund a purchase *yet*, but you know.
    /// </summary>
    public sealed class DestinyVendorsDestinyVendorReceipt:  IEquatable<DestinyVendorsDestinyVendorReceipt>
    { 
        /// <summary>
        /// The amount paid for the item, in terms of items that were consumed in the purchase and their quantity.
        /// </summary>
        public List<DestinyDestinyItemQuantity> CurrencyPaid { get; private set; }

        /// <summary>
        /// The item that was received, and its quantity.
        /// </summary>
        public DestinyDestinyItemQuantity ItemReceived { get; private set; }

        /// <summary>
        /// The unlock flag used to determine whether you still have the purchased item.
        /// </summary>
        public int? LicenseUnlockHash { get; private set; }

        /// <summary>
        /// The ID of the character who made the purchase.
        /// </summary>
        public long? PurchasedByCharacterId { get; private set; }

        /// <summary>
        /// Whether you can get a refund, and what happens in order for the refund to be received. See the DestinyVendorItemRefundPolicy enum for details.
        /// </summary>
        public int? RefundPolicy { get; private set; }

        /// <summary>
        /// The identifier of this receipt.
        /// </summary>
        public int? SequenceNumber { get; private set; }

        /// <summary>
        /// The seconds since epoch at which this receipt is rendered invalid.
        /// </summary>
        public long? TimeToExpiration { get; private set; }

        /// <summary>
        /// The date at which this receipt is rendered invalid.
        /// </summary>
        public DateTime? ExpiresOn { get; private set; }


        /// <summary>
        /// Empty constructor required by some serializers.
        /// Use DestinyVendorsDestinyVendorReceipt.Builder() for instance creation instead.
        /// </summary>
        [Obsolete]
        public DestinyVendorsDestinyVendorReceipt()
        {
        }

        private DestinyVendorsDestinyVendorReceipt(List<DestinyDestinyItemQuantity> CurrencyPaid, DestinyDestinyItemQuantity ItemReceived, int? LicenseUnlockHash, long? PurchasedByCharacterId, int? RefundPolicy, int? SequenceNumber, long? TimeToExpiration, DateTime? ExpiresOn)
        {
            
            this.CurrencyPaid = CurrencyPaid;
            
            this.ItemReceived = ItemReceived;
            
            this.LicenseUnlockHash = LicenseUnlockHash;
            
            this.PurchasedByCharacterId = PurchasedByCharacterId;
            
            this.RefundPolicy = RefundPolicy;
            
            this.SequenceNumber = SequenceNumber;
            
            this.TimeToExpiration = TimeToExpiration;
            
            this.ExpiresOn = ExpiresOn;
            
        }

        /// <summary>
        /// Returns builder of DestinyVendorsDestinyVendorReceipt.
        /// </summary>
        /// <returns>DestinyVendorsDestinyVendorReceiptBuilder</returns>
        public static DestinyVendorsDestinyVendorReceiptBuilder Builder()
        {
            return new DestinyVendorsDestinyVendorReceiptBuilder();
        }

        /// <summary>
        /// Returns DestinyVendorsDestinyVendorReceiptBuilder with properties set.
        /// Use it to change properties.
        /// </summary>
        /// <returns>DestinyVendorsDestinyVendorReceiptBuilder</returns>
        public DestinyVendorsDestinyVendorReceiptBuilder With()
        {
            return Builder()
                .CurrencyPaid(CurrencyPaid)
                .ItemReceived(ItemReceived)
                .LicenseUnlockHash(LicenseUnlockHash)
                .PurchasedByCharacterId(PurchasedByCharacterId)
                .RefundPolicy(RefundPolicy)
                .SequenceNumber(SequenceNumber)
                .TimeToExpiration(TimeToExpiration)
                .ExpiresOn(ExpiresOn);
        }

        public override string ToString()
        {
            return this.PropertiesToString();
        }

        public override bool Equals(object obj)
        {
            return this.EqualsByProperties(obj);
        }

        public bool Equals(DestinyVendorsDestinyVendorReceipt other)
        {
            return Equals((object) other);
        }

        public override int GetHashCode()
        {
            return this.PropertiesHash();
        }

        /// <summary>
        /// Implementation of == operator for (DestinyVendorsDestinyVendorReceipt.
        /// </summary>
        /// <param name="left">Compared (DestinyVendorsDestinyVendorReceipt</param>
        /// <param name="right">Compared (DestinyVendorsDestinyVendorReceipt</param>
        /// <returns>true if compared items are equals, false otherwise</returns>
        public static bool operator == (DestinyVendorsDestinyVendorReceipt left, DestinyVendorsDestinyVendorReceipt right)
        {
            return Equals(left, right);
        }

        /// <summary>
        /// Implementation of != operator for (DestinyVendorsDestinyVendorReceipt.
        /// </summary>
        /// <param name="left">Compared (DestinyVendorsDestinyVendorReceipt</param>
        /// <param name="right">Compared (DestinyVendorsDestinyVendorReceipt</param>
        /// <returns>true if compared items are not equals, false otherwise</returns>
        public static bool operator != (DestinyVendorsDestinyVendorReceipt left, DestinyVendorsDestinyVendorReceipt right)
        {
            return !Equals(left, right);
        }

        /// <summary>
        /// Builder of DestinyVendorsDestinyVendorReceipt.
        /// </summary>
        public sealed class DestinyVendorsDestinyVendorReceiptBuilder
        {
            private List<DestinyDestinyItemQuantity> _CurrencyPaid;
            private DestinyDestinyItemQuantity _ItemReceived;
            private int? _LicenseUnlockHash;
            private long? _PurchasedByCharacterId;
            private int? _RefundPolicy;
            private int? _SequenceNumber;
            private long? _TimeToExpiration;
            private DateTime? _ExpiresOn;

            internal DestinyVendorsDestinyVendorReceiptBuilder()
            {
                SetupDefaults();
            }

            private void SetupDefaults()
            {
            }

            /// <summary>
            /// Sets value for DestinyVendorsDestinyVendorReceipt.CurrencyPaid property.
            /// </summary>
            /// <param name="value">The amount paid for the item, in terms of items that were consumed in the purchase and their quantity.</param>
            public DestinyVendorsDestinyVendorReceiptBuilder CurrencyPaid(List<DestinyDestinyItemQuantity> value)
            {
                _CurrencyPaid = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyVendorsDestinyVendorReceipt.ItemReceived property.
            /// </summary>
            /// <param name="value">The item that was received, and its quantity.</param>
            public DestinyVendorsDestinyVendorReceiptBuilder ItemReceived(DestinyDestinyItemQuantity value)
            {
                _ItemReceived = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyVendorsDestinyVendorReceipt.LicenseUnlockHash property.
            /// </summary>
            /// <param name="value">The unlock flag used to determine whether you still have the purchased item.</param>
            public DestinyVendorsDestinyVendorReceiptBuilder LicenseUnlockHash(int? value)
            {
                _LicenseUnlockHash = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyVendorsDestinyVendorReceipt.PurchasedByCharacterId property.
            /// </summary>
            /// <param name="value">The ID of the character who made the purchase.</param>
            public DestinyVendorsDestinyVendorReceiptBuilder PurchasedByCharacterId(long? value)
            {
                _PurchasedByCharacterId = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyVendorsDestinyVendorReceipt.RefundPolicy property.
            /// </summary>
            /// <param name="value">Whether you can get a refund, and what happens in order for the refund to be received. See the DestinyVendorItemRefundPolicy enum for details.</param>
            public DestinyVendorsDestinyVendorReceiptBuilder RefundPolicy(int? value)
            {
                _RefundPolicy = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyVendorsDestinyVendorReceipt.SequenceNumber property.
            /// </summary>
            /// <param name="value">The identifier of this receipt.</param>
            public DestinyVendorsDestinyVendorReceiptBuilder SequenceNumber(int? value)
            {
                _SequenceNumber = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyVendorsDestinyVendorReceipt.TimeToExpiration property.
            /// </summary>
            /// <param name="value">The seconds since epoch at which this receipt is rendered invalid.</param>
            public DestinyVendorsDestinyVendorReceiptBuilder TimeToExpiration(long? value)
            {
                _TimeToExpiration = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyVendorsDestinyVendorReceipt.ExpiresOn property.
            /// </summary>
            /// <param name="value">The date at which this receipt is rendered invalid.</param>
            public DestinyVendorsDestinyVendorReceiptBuilder ExpiresOn(DateTime? value)
            {
                _ExpiresOn = value;
                return this;
            }


            /// <summary>
            /// Builds instance of DestinyVendorsDestinyVendorReceipt.
            /// </summary>
            /// <returns>DestinyVendorsDestinyVendorReceipt</returns>
            public DestinyVendorsDestinyVendorReceipt Build()
            {
                Validate();
                return new DestinyVendorsDestinyVendorReceipt(
                    CurrencyPaid: _CurrencyPaid,
                    ItemReceived: _ItemReceived,
                    LicenseUnlockHash: _LicenseUnlockHash,
                    PurchasedByCharacterId: _PurchasedByCharacterId,
                    RefundPolicy: _RefundPolicy,
                    SequenceNumber: _SequenceNumber,
                    TimeToExpiration: _TimeToExpiration,
                    ExpiresOn: _ExpiresOn
                );
            }

            private void Validate()
            { 
            }
        }

        
    }
}