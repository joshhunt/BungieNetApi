using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace BungieNetApi.Model {

  /// <summary>
  /// This represents an item being sold by the vendor.
  /// </summary>
  [DataContract]
  public class DestinyDefinitionsDestinyVendorItemDefinition {
    /// <summary>
    /// The index into the DestinyVendorDefinition.saleList. This is what we use to refer to items being sold throughout live and definition data.
    /// </summary>
    /// <value>The index into the DestinyVendorDefinition.saleList. This is what we use to refer to items being sold throughout live and definition data.</value>
    [DataMember(Name="vendorItemIndex", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "vendorItemIndex")]
    public int? VendorItemIndex { get; set; }

    /// <summary>
    /// The hash identifier of the item being sold (DestinyInventoryItemDefinition).  Note that a vendor can sell the same item in multiple ways, so don't assume that itemHash is a unique identifier for this entity.
    /// </summary>
    /// <value>The hash identifier of the item being sold (DestinyInventoryItemDefinition).  Note that a vendor can sell the same item in multiple ways, so don't assume that itemHash is a unique identifier for this entity.</value>
    [DataMember(Name="itemHash", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "itemHash")]
    public int? ItemHash { get; set; }

    /// <summary>
    /// The amount you will recieve of the item described in itemHash if you make the purchase.
    /// </summary>
    /// <value>The amount you will recieve of the item described in itemHash if you make the purchase.</value>
    [DataMember(Name="quantity", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "quantity")]
    public int? Quantity { get; set; }

    /// <summary>
    /// An list of indexes into the DestinyVendorDefinition.failureStrings array, indicating the possible failure strings that can be relevant for this item.
    /// </summary>
    /// <value>An list of indexes into the DestinyVendorDefinition.failureStrings array, indicating the possible failure strings that can be relevant for this item.</value>
    [DataMember(Name="failureIndexes", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "failureIndexes")]
    public List<int?> FailureIndexes { get; set; }

    /// <summary>
    /// This is a pre-compiled aggregation of item value and priceOverrideList, so that we have one place to check for what the purchaser must pay for the item. Use this instead of trying to piece together the price separately.  The somewhat crappy part about this is that, now that item quantity overrides have dynamic modifiers, this will not necessarily be statically true. If you were using this instead of live data, switch to using live data.
    /// </summary>
    /// <value>This is a pre-compiled aggregation of item value and priceOverrideList, so that we have one place to check for what the purchaser must pay for the item. Use this instead of trying to piece together the price separately.  The somewhat crappy part about this is that, now that item quantity overrides have dynamic modifiers, this will not necessarily be statically true. If you were using this instead of live data, switch to using live data.</value>
    [DataMember(Name="currencies", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "currencies")]
    public List<DestinyDefinitionsDestinyVendorItemQuantity> Currencies { get; set; }

    /// <summary>
    /// If this item can be refunded, this is the policy for what will be refundd, how, and in what time period.
    /// </summary>
    /// <value>If this item can be refunded, this is the policy for what will be refundd, how, and in what time period.</value>
    [DataMember(Name="refundPolicy", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "refundPolicy")]
    public int? RefundPolicy { get; set; }

    /// <summary>
    /// The amount of time before refundability of the newly purchased item will expire.
    /// </summary>
    /// <value>The amount of time before refundability of the newly purchased item will expire.</value>
    [DataMember(Name="refundTimeLimit", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "refundTimeLimit")]
    public int? RefundTimeLimit { get; set; }

    /// <summary>
    /// The Default level at which the item will spawn. Almost always driven by an adjusto these days. Ideally should be singular. It's a long story how this ended up as a list, but there is always either going to be 0:1 of these entities.
    /// </summary>
    /// <value>The Default level at which the item will spawn. Almost always driven by an adjusto these days. Ideally should be singular. It's a long story how this ended up as a list, but there is always either going to be 0:1 of these entities.</value>
    [DataMember(Name="creationLevels", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "creationLevels")]
    public List<DestinyDefinitionsDestinyItemCreationEntryLevelDefinition> CreationLevels { get; set; }

    /// <summary>
    /// This is an index specifically into the display category, as opposed to the server-side Categories (which do not need to match or pair with each other in any way: server side categories are really just structures for common validation. Display Category will let us more easily categorize items visually)
    /// </summary>
    /// <value>This is an index specifically into the display category, as opposed to the server-side Categories (which do not need to match or pair with each other in any way: server side categories are really just structures for common validation. Display Category will let us more easily categorize items visually)</value>
    [DataMember(Name="displayCategoryIndex", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "displayCategoryIndex")]
    public int? DisplayCategoryIndex { get; set; }

    /// <summary>
    /// The index into the DestinyVendorDefinition.categories array, so you can find the category associated with this item.
    /// </summary>
    /// <value>The index into the DestinyVendorDefinition.categories array, so you can find the category associated with this item.</value>
    [DataMember(Name="categoryIndex", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "categoryIndex")]
    public int? CategoryIndex { get; set; }

    /// <summary>
    /// Same as above, but for the original category indexes.
    /// </summary>
    /// <value>Same as above, but for the original category indexes.</value>
    [DataMember(Name="originalCategoryIndex", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "originalCategoryIndex")]
    public int? OriginalCategoryIndex { get; set; }

    /// <summary>
    /// The minimum character level at which this item is available for sale.
    /// </summary>
    /// <value>The minimum character level at which this item is available for sale.</value>
    [DataMember(Name="minimumLevel", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "minimumLevel")]
    public int? MinimumLevel { get; set; }

    /// <summary>
    /// The maximum character level at which this item is available for sale.
    /// </summary>
    /// <value>The maximum character level at which this item is available for sale.</value>
    [DataMember(Name="maximumLevel", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "maximumLevel")]
    public int? MaximumLevel { get; set; }

    /// <summary>
    /// The action to be performed when purchasing the item, if it's not just \"buy\".
    /// </summary>
    /// <value>The action to be performed when purchasing the item, if it's not just \"buy\".</value>
    [DataMember(Name="action", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "action")]
    public DestinyDefinitionsDestinyVendorSaleItemActionBlockDefinition Action { get; set; }

    /// <summary>
    /// The string identifier for the category selling this item.
    /// </summary>
    /// <value>The string identifier for the category selling this item.</value>
    [DataMember(Name="displayCategory", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "displayCategory")]
    public string DisplayCategory { get; set; }

    /// <summary>
    /// The inventory bucket into which this item will be placed upon purchase.
    /// </summary>
    /// <value>The inventory bucket into which this item will be placed upon purchase.</value>
    [DataMember(Name="inventoryBucketHash", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "inventoryBucketHash")]
    public int? InventoryBucketHash { get; set; }

    /// <summary>
    /// The most restrictive scope that determines whether the item is available in the Vendor's inventory. See DestinyGatingScope's documentation for more information.  This can be determined by Unlock gating, or by whether or not the item has purchase level requirements (minimumLevel and maximumLevel properties).
    /// </summary>
    /// <value>The most restrictive scope that determines whether the item is available in the Vendor's inventory. See DestinyGatingScope's documentation for more information.  This can be determined by Unlock gating, or by whether or not the item has purchase level requirements (minimumLevel and maximumLevel properties).</value>
    [DataMember(Name="visibilityScope", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "visibilityScope")]
    public int? VisibilityScope { get; set; }

    /// <summary>
    /// Similar to visibilityScope, it represents the most restrictive scope that determines whether the item can be purchased. It will at least be as restrictive as visibilityScope, but could be more restrictive if the item has additional purchase requirements beyond whether it is merely visible or not.  See DestinyGatingScope's documentation for more information.
    /// </summary>
    /// <value>Similar to visibilityScope, it represents the most restrictive scope that determines whether the item can be purchased. It will at least be as restrictive as visibilityScope, but could be more restrictive if the item has additional purchase requirements beyond whether it is merely visible or not.  See DestinyGatingScope's documentation for more information.</value>
    [DataMember(Name="purchasableScope", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "purchasableScope")]
    public int? PurchasableScope { get; set; }

    /// <summary>
    /// If this item can only be purchased by a given platform, this indicates the platform to which it is restricted.
    /// </summary>
    /// <value>If this item can only be purchased by a given platform, this indicates the platform to which it is restricted.</value>
    [DataMember(Name="exclusivity", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "exclusivity")]
    public int? Exclusivity { get; set; }

    /// <summary>
    /// If this sale can only be performed as the result of an offer check, this is true.
    /// </summary>
    /// <value>If this sale can only be performed as the result of an offer check, this is true.</value>
    [DataMember(Name="isOffer", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "isOffer")]
    public bool? IsOffer { get; set; }

    /// <summary>
    /// If this sale can only be performed as the result of receiving a CRM offer, this is true.
    /// </summary>
    /// <value>If this sale can only be performed as the result of receiving a CRM offer, this is true.</value>
    [DataMember(Name="isCrm", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "isCrm")]
    public bool? IsCrm { get; set; }

    /// <summary>
    /// *if* the category this item is in supports non-default sorting, this value should represent the sorting value to use, pre-processed and ready to go.
    /// </summary>
    /// <value>*if* the category this item is in supports non-default sorting, this value should represent the sorting value to use, pre-processed and ready to go.</value>
    [DataMember(Name="sortValue", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "sortValue")]
    public int? SortValue { get; set; }

    /// <summary>
    /// If this item can expire, this is the tooltip message to show with its expiration info.
    /// </summary>
    /// <value>If this item can expire, this is the tooltip message to show with its expiration info.</value>
    [DataMember(Name="expirationTooltip", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "expirationTooltip")]
    public string ExpirationTooltip { get; set; }

    /// <summary>
    /// If this is populated, the purchase of this item should redirect to purchasing these other items instead.
    /// </summary>
    /// <value>If this is populated, the purchase of this item should redirect to purchasing these other items instead.</value>
    [DataMember(Name="redirectToSaleIndexes", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "redirectToSaleIndexes")]
    public List<int?> RedirectToSaleIndexes { get; set; }

    /// <summary>
    /// Gets or Sets SocketOverrides
    /// </summary>
    [DataMember(Name="socketOverrides", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "socketOverrides")]
    public List<DestinyDefinitionsDestinyVendorItemSocketOverride> SocketOverrides { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class DestinyDefinitionsDestinyVendorItemDefinition {\n");
      sb.Append("  VendorItemIndex: ").Append(VendorItemIndex).Append("\n");
      sb.Append("  ItemHash: ").Append(ItemHash).Append("\n");
      sb.Append("  Quantity: ").Append(Quantity).Append("\n");
      sb.Append("  FailureIndexes: ").Append(FailureIndexes).Append("\n");
      sb.Append("  Currencies: ").Append(Currencies).Append("\n");
      sb.Append("  RefundPolicy: ").Append(RefundPolicy).Append("\n");
      sb.Append("  RefundTimeLimit: ").Append(RefundTimeLimit).Append("\n");
      sb.Append("  CreationLevels: ").Append(CreationLevels).Append("\n");
      sb.Append("  DisplayCategoryIndex: ").Append(DisplayCategoryIndex).Append("\n");
      sb.Append("  CategoryIndex: ").Append(CategoryIndex).Append("\n");
      sb.Append("  OriginalCategoryIndex: ").Append(OriginalCategoryIndex).Append("\n");
      sb.Append("  MinimumLevel: ").Append(MinimumLevel).Append("\n");
      sb.Append("  MaximumLevel: ").Append(MaximumLevel).Append("\n");
      sb.Append("  Action: ").Append(Action).Append("\n");
      sb.Append("  DisplayCategory: ").Append(DisplayCategory).Append("\n");
      sb.Append("  InventoryBucketHash: ").Append(InventoryBucketHash).Append("\n");
      sb.Append("  VisibilityScope: ").Append(VisibilityScope).Append("\n");
      sb.Append("  PurchasableScope: ").Append(PurchasableScope).Append("\n");
      sb.Append("  Exclusivity: ").Append(Exclusivity).Append("\n");
      sb.Append("  IsOffer: ").Append(IsOffer).Append("\n");
      sb.Append("  IsCrm: ").Append(IsCrm).Append("\n");
      sb.Append("  SortValue: ").Append(SortValue).Append("\n");
      sb.Append("  ExpirationTooltip: ").Append(ExpirationTooltip).Append("\n");
      sb.Append("  RedirectToSaleIndexes: ").Append(RedirectToSaleIndexes).Append("\n");
      sb.Append("  SocketOverrides: ").Append(SocketOverrides).Append("\n");
      sb.Append("}\n");
      return sb.ToString();
    }

    /// <summary>
    /// Get the JSON string presentation of the object
    /// </summary>
    /// <returns>JSON string presentation of the object</returns>
    public string ToJson() {
      return JsonConvert.SerializeObject(this, Formatting.Indented);
    }

}
}
