using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Sharpility.Extensions;
using NodaTime;

namespace BungieNetApi._Platform.Models
{
    /// <summary>
    /// For now, this isn&#39;t used for much: it&#39;s a record of the recent refundable purchases that the user has made. In the future, it could be used for providing refunds/buyback via the API. Wouldn&#39;t that be fun?
    /// </summary>
    public sealed class DestinyEntitiesProfilesDestinyVendorReceiptsComponent:  IEquatable<DestinyEntitiesProfilesDestinyVendorReceiptsComponent>
    { 
        /// <summary>
        /// The receipts for refundable purchases made at a vendor.
        /// </summary>
        public List<DestinyVendorsDestinyVendorReceipt> Receipts { get; private set; }


        /// <summary>
        /// Empty constructor required by some serializers.
        /// Use DestinyEntitiesProfilesDestinyVendorReceiptsComponent.Builder() for instance creation instead.
        /// </summary>
        [Obsolete]
        public DestinyEntitiesProfilesDestinyVendorReceiptsComponent()
        {
        }

        private DestinyEntitiesProfilesDestinyVendorReceiptsComponent(List<DestinyVendorsDestinyVendorReceipt> Receipts)
        {
            
            this.Receipts = Receipts;
            
        }

        /// <summary>
        /// Returns builder of DestinyEntitiesProfilesDestinyVendorReceiptsComponent.
        /// </summary>
        /// <returns>DestinyEntitiesProfilesDestinyVendorReceiptsComponentBuilder</returns>
        public static DestinyEntitiesProfilesDestinyVendorReceiptsComponentBuilder Builder()
        {
            return new DestinyEntitiesProfilesDestinyVendorReceiptsComponentBuilder();
        }

        /// <summary>
        /// Returns DestinyEntitiesProfilesDestinyVendorReceiptsComponentBuilder with properties set.
        /// Use it to change properties.
        /// </summary>
        /// <returns>DestinyEntitiesProfilesDestinyVendorReceiptsComponentBuilder</returns>
        public DestinyEntitiesProfilesDestinyVendorReceiptsComponentBuilder With()
        {
            return Builder()
                .Receipts(Receipts);
        }

        public override string ToString()
        {
            return this.PropertiesToString();
        }

        public override bool Equals(object obj)
        {
            return this.EqualsByProperties(obj);
        }

        public bool Equals(DestinyEntitiesProfilesDestinyVendorReceiptsComponent other)
        {
            return Equals((object) other);
        }

        public override int GetHashCode()
        {
            return this.PropertiesHash();
        }

        /// <summary>
        /// Implementation of == operator for (DestinyEntitiesProfilesDestinyVendorReceiptsComponent.
        /// </summary>
        /// <param name="left">Compared (DestinyEntitiesProfilesDestinyVendorReceiptsComponent</param>
        /// <param name="right">Compared (DestinyEntitiesProfilesDestinyVendorReceiptsComponent</param>
        /// <returns>true if compared items are equals, false otherwise</returns>
        public static bool operator == (DestinyEntitiesProfilesDestinyVendorReceiptsComponent left, DestinyEntitiesProfilesDestinyVendorReceiptsComponent right)
        {
            return Equals(left, right);
        }

        /// <summary>
        /// Implementation of != operator for (DestinyEntitiesProfilesDestinyVendorReceiptsComponent.
        /// </summary>
        /// <param name="left">Compared (DestinyEntitiesProfilesDestinyVendorReceiptsComponent</param>
        /// <param name="right">Compared (DestinyEntitiesProfilesDestinyVendorReceiptsComponent</param>
        /// <returns>true if compared items are not equals, false otherwise</returns>
        public static bool operator != (DestinyEntitiesProfilesDestinyVendorReceiptsComponent left, DestinyEntitiesProfilesDestinyVendorReceiptsComponent right)
        {
            return !Equals(left, right);
        }

        /// <summary>
        /// Builder of DestinyEntitiesProfilesDestinyVendorReceiptsComponent.
        /// </summary>
        public sealed class DestinyEntitiesProfilesDestinyVendorReceiptsComponentBuilder
        {
            private List<DestinyVendorsDestinyVendorReceipt> _Receipts;

            internal DestinyEntitiesProfilesDestinyVendorReceiptsComponentBuilder()
            {
                SetupDefaults();
            }

            private void SetupDefaults()
            {
            }

            /// <summary>
            /// Sets value for DestinyEntitiesProfilesDestinyVendorReceiptsComponent.Receipts property.
            /// </summary>
            /// <param name="value">The receipts for refundable purchases made at a vendor.</param>
            public DestinyEntitiesProfilesDestinyVendorReceiptsComponentBuilder Receipts(List<DestinyVendorsDestinyVendorReceipt> value)
            {
                _Receipts = value;
                return this;
            }


            /// <summary>
            /// Builds instance of DestinyEntitiesProfilesDestinyVendorReceiptsComponent.
            /// </summary>
            /// <returns>DestinyEntitiesProfilesDestinyVendorReceiptsComponent</returns>
            public DestinyEntitiesProfilesDestinyVendorReceiptsComponent Build()
            {
                Validate();
                return new DestinyEntitiesProfilesDestinyVendorReceiptsComponent(
                    Receipts: _Receipts
                );
            }

            private void Validate()
            { 
            }
        }

        
    }
}