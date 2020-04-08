/* 
 * Bungie.Net API
 *
 * These endpoints constitute the functionality exposed by Bungie.net, both for more traditional website functionality and for connectivity to Bungie video games and their related functionality.
 *
 * The version of the OpenAPI document: 2.8.0
 * Contact: support@bungie.com
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */

using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;
using OpenAPIDateConverter = BungieNetApi.Client.OpenAPIDateConverter;

namespace BungieNetApi.Model
{
    /// <summary>
    /// A response containing all valid components for the public Vendors endpoint.   It is a decisively smaller subset of data compared to what we can get when we know the specific user making the request.   If you want any of the other data - item details, whether or not you can buy it, etc... you&#39;ll have to call in the context of a character. I know, sad but true.
    /// </summary>
    [DataContract]
    public partial class DestinyResponsesDestinyPublicVendorsResponse :  IEquatable<DestinyResponsesDestinyPublicVendorsResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DestinyResponsesDestinyPublicVendorsResponse" /> class.
        /// </summary>
        /// <param name="vendorGroups">For Vendors being returned, this will give you the information you need to group them and order them in the same way that the Bungie Companion app performs grouping. It will automatically be returned if you request the Vendors component.  COMPONENT TYPE: Vendors.</param>
        /// <param name="vendors">The base properties of the vendor. These are keyed by the Vendor Hash, so you will get one Vendor Component per vendor returned.  COMPONENT TYPE: Vendors.</param>
        /// <param name="categories">Categories that the vendor has available, and references to the sales therein. These are keyed by the Vendor Hash, so you will get one Categories Component per vendor returned.  COMPONENT TYPE: VendorCategories.</param>
        /// <param name="sales">Sales, keyed by the vendorItemIndex of the item being sold. These are keyed by the Vendor Hash, so you will get one Sale Item Set Component per vendor returned.  Note that within the Sale Item Set component, the sales are themselves keyed by the vendorSaleIndex, so you can relate it to the corrent sale item definition within the Vendor&#39;s definition.  COMPONENT TYPE: VendorSales.</param>
        public DestinyResponsesDestinyPublicVendorsResponse(SingleComponentResponseOfDestinyVendorGroupComponent vendorGroups = default(SingleComponentResponseOfDestinyVendorGroupComponent), DictionaryComponentResponseOfuint32AndDestinyPublicVendorComponent vendors = default(DictionaryComponentResponseOfuint32AndDestinyPublicVendorComponent), DictionaryComponentResponseOfuint32AndDestinyVendorCategoriesComponent categories = default(DictionaryComponentResponseOfuint32AndDestinyVendorCategoriesComponent), DictionaryComponentResponseOfuint32AndPublicDestinyVendorSaleItemSetComponent sales = default(DictionaryComponentResponseOfuint32AndPublicDestinyVendorSaleItemSetComponent))
        {
            this.VendorGroups = vendorGroups;
            this.Vendors = vendors;
            this.Categories = categories;
            this.Sales = sales;
        }
        
        /// <summary>
        /// For Vendors being returned, this will give you the information you need to group them and order them in the same way that the Bungie Companion app performs grouping. It will automatically be returned if you request the Vendors component.  COMPONENT TYPE: Vendors
        /// </summary>
        /// <value>For Vendors being returned, this will give you the information you need to group them and order them in the same way that the Bungie Companion app performs grouping. It will automatically be returned if you request the Vendors component.  COMPONENT TYPE: Vendors</value>
        [DataMember(Name="vendorGroups", EmitDefaultValue=false)]
        public SingleComponentResponseOfDestinyVendorGroupComponent VendorGroups { get; set; }

        /// <summary>
        /// The base properties of the vendor. These are keyed by the Vendor Hash, so you will get one Vendor Component per vendor returned.  COMPONENT TYPE: Vendors
        /// </summary>
        /// <value>The base properties of the vendor. These are keyed by the Vendor Hash, so you will get one Vendor Component per vendor returned.  COMPONENT TYPE: Vendors</value>
        [DataMember(Name="vendors", EmitDefaultValue=false)]
        public DictionaryComponentResponseOfuint32AndDestinyPublicVendorComponent Vendors { get; set; }

        /// <summary>
        /// Categories that the vendor has available, and references to the sales therein. These are keyed by the Vendor Hash, so you will get one Categories Component per vendor returned.  COMPONENT TYPE: VendorCategories
        /// </summary>
        /// <value>Categories that the vendor has available, and references to the sales therein. These are keyed by the Vendor Hash, so you will get one Categories Component per vendor returned.  COMPONENT TYPE: VendorCategories</value>
        [DataMember(Name="categories", EmitDefaultValue=false)]
        public DictionaryComponentResponseOfuint32AndDestinyVendorCategoriesComponent Categories { get; set; }

        /// <summary>
        /// Sales, keyed by the vendorItemIndex of the item being sold. These are keyed by the Vendor Hash, so you will get one Sale Item Set Component per vendor returned.  Note that within the Sale Item Set component, the sales are themselves keyed by the vendorSaleIndex, so you can relate it to the corrent sale item definition within the Vendor&#39;s definition.  COMPONENT TYPE: VendorSales
        /// </summary>
        /// <value>Sales, keyed by the vendorItemIndex of the item being sold. These are keyed by the Vendor Hash, so you will get one Sale Item Set Component per vendor returned.  Note that within the Sale Item Set component, the sales are themselves keyed by the vendorSaleIndex, so you can relate it to the corrent sale item definition within the Vendor&#39;s definition.  COMPONENT TYPE: VendorSales</value>
        [DataMember(Name="sales", EmitDefaultValue=false)]
        public DictionaryComponentResponseOfuint32AndPublicDestinyVendorSaleItemSetComponent Sales { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DestinyResponsesDestinyPublicVendorsResponse {\n");
            sb.Append("  VendorGroups: ").Append(VendorGroups).Append("\n");
            sb.Append("  Vendors: ").Append(Vendors).Append("\n");
            sb.Append("  Categories: ").Append(Categories).Append("\n");
            sb.Append("  Sales: ").Append(Sales).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as DestinyResponsesDestinyPublicVendorsResponse);
        }

        /// <summary>
        /// Returns true if DestinyResponsesDestinyPublicVendorsResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of DestinyResponsesDestinyPublicVendorsResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DestinyResponsesDestinyPublicVendorsResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.VendorGroups == input.VendorGroups ||
                    (this.VendorGroups != null &&
                    this.VendorGroups.Equals(input.VendorGroups))
                ) && 
                (
                    this.Vendors == input.Vendors ||
                    (this.Vendors != null &&
                    this.Vendors.Equals(input.Vendors))
                ) && 
                (
                    this.Categories == input.Categories ||
                    (this.Categories != null &&
                    this.Categories.Equals(input.Categories))
                ) && 
                (
                    this.Sales == input.Sales ||
                    (this.Sales != null &&
                    this.Sales.Equals(input.Sales))
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.VendorGroups != null)
                    hashCode = hashCode * 59 + this.VendorGroups.GetHashCode();
                if (this.Vendors != null)
                    hashCode = hashCode * 59 + this.Vendors.GetHashCode();
                if (this.Categories != null)
                    hashCode = hashCode * 59 + this.Categories.GetHashCode();
                if (this.Sales != null)
                    hashCode = hashCode * 59 + this.Sales.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
