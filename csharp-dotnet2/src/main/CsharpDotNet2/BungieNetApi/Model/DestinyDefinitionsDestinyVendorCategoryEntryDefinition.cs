using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace BungieNetApi.Model {

  /// <summary>
  /// This is the definition for a single Vendor Category, into which Sale Items are grouped.
  /// </summary>
  [DataContract]
  public class DestinyDefinitionsDestinyVendorCategoryEntryDefinition {
    /// <summary>
    /// The index of the category in the original category definitions for the vendor.
    /// </summary>
    /// <value>The index of the category in the original category definitions for the vendor.</value>
    [DataMember(Name="categoryIndex", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "categoryIndex")]
    public int? CategoryIndex { get; set; }

    /// <summary>
    /// Used in sorting items in vendors... but there's a lot more to it. Just go with the order provided in the itemIndexes property on the DestinyVendorCategoryComponent instead, it should be more reliable than trying to recalculate it yourself.
    /// </summary>
    /// <value>Used in sorting items in vendors... but there's a lot more to it. Just go with the order provided in the itemIndexes property on the DestinyVendorCategoryComponent instead, it should be more reliable than trying to recalculate it yourself.</value>
    [DataMember(Name="sortValue", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "sortValue")]
    public int? SortValue { get; set; }

    /// <summary>
    /// The hashed identifier for the category.
    /// </summary>
    /// <value>The hashed identifier for the category.</value>
    [DataMember(Name="categoryHash", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "categoryHash")]
    public int? CategoryHash { get; set; }

    /// <summary>
    /// The amount of items that will be available when this category is shown.
    /// </summary>
    /// <value>The amount of items that will be available when this category is shown.</value>
    [DataMember(Name="quantityAvailable", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "quantityAvailable")]
    public int? QuantityAvailable { get; set; }

    /// <summary>
    /// If items aren't up for sale in this category, should we still show them (greyed out)?
    /// </summary>
    /// <value>If items aren't up for sale in this category, should we still show them (greyed out)?</value>
    [DataMember(Name="showUnavailableItems", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "showUnavailableItems")]
    public bool? ShowUnavailableItems { get; set; }

    /// <summary>
    /// If you don't have the currency required to buy items from this category, should the items be hidden?
    /// </summary>
    /// <value>If you don't have the currency required to buy items from this category, should the items be hidden?</value>
    [DataMember(Name="hideIfNoCurrency", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "hideIfNoCurrency")]
    public bool? HideIfNoCurrency { get; set; }

    /// <summary>
    /// True if this category doesn't allow purchases.
    /// </summary>
    /// <value>True if this category doesn't allow purchases.</value>
    [DataMember(Name="hideFromRegularPurchase", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "hideFromRegularPurchase")]
    public bool? HideFromRegularPurchase { get; set; }

    /// <summary>
    /// The localized string for making purchases from this category, if it is different from the vendor's string for purchasing.
    /// </summary>
    /// <value>The localized string for making purchases from this category, if it is different from the vendor's string for purchasing.</value>
    [DataMember(Name="buyStringOverride", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "buyStringOverride")]
    public string BuyStringOverride { get; set; }

    /// <summary>
    /// If the category is disabled, this is the localized description to show.
    /// </summary>
    /// <value>If the category is disabled, this is the localized description to show.</value>
    [DataMember(Name="disabledDescription", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "disabledDescription")]
    public string DisabledDescription { get; set; }

    /// <summary>
    /// The localized title of the category.
    /// </summary>
    /// <value>The localized title of the category.</value>
    [DataMember(Name="displayTitle", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "displayTitle")]
    public string DisplayTitle { get; set; }

    /// <summary>
    /// If this category has an overlay prompt that should appear, this contains the details of that prompt.
    /// </summary>
    /// <value>If this category has an overlay prompt that should appear, this contains the details of that prompt.</value>
    [DataMember(Name="overlay", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "overlay")]
    public DestinyDefinitionsDestinyVendorCategoryOverlayDefinition Overlay { get; set; }

    /// <summary>
    /// A shortcut for the vendor item indexes sold under this category. Saves us from some expensive reorganization at runtime.
    /// </summary>
    /// <value>A shortcut for the vendor item indexes sold under this category. Saves us from some expensive reorganization at runtime.</value>
    [DataMember(Name="vendorItemIndexes", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "vendorItemIndexes")]
    public List<int?> VendorItemIndexes { get; set; }

    /// <summary>
    /// Sometimes a category isn't actually used to sell items, but rather to preview them. This implies different UI (and manual placement of the category in the UI) in the game, and special treatment.
    /// </summary>
    /// <value>Sometimes a category isn't actually used to sell items, but rather to preview them. This implies different UI (and manual placement of the category in the UI) in the game, and special treatment.</value>
    [DataMember(Name="isPreview", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "isPreview")]
    public bool? IsPreview { get; set; }

    /// <summary>
    /// If true, this category only displays items: you can't purchase anything in them.
    /// </summary>
    /// <value>If true, this category only displays items: you can't purchase anything in them.</value>
    [DataMember(Name="isDisplayOnly", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "isDisplayOnly")]
    public bool? IsDisplayOnly { get; set; }

    /// <summary>
    /// Gets or Sets ResetIntervalMinutesOverride
    /// </summary>
    [DataMember(Name="resetIntervalMinutesOverride", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "resetIntervalMinutesOverride")]
    public int? ResetIntervalMinutesOverride { get; set; }

    /// <summary>
    /// Gets or Sets ResetOffsetMinutesOverride
    /// </summary>
    [DataMember(Name="resetOffsetMinutesOverride", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "resetOffsetMinutesOverride")]
    public int? ResetOffsetMinutesOverride { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class DestinyDefinitionsDestinyVendorCategoryEntryDefinition {\n");
      sb.Append("  CategoryIndex: ").Append(CategoryIndex).Append("\n");
      sb.Append("  SortValue: ").Append(SortValue).Append("\n");
      sb.Append("  CategoryHash: ").Append(CategoryHash).Append("\n");
      sb.Append("  QuantityAvailable: ").Append(QuantityAvailable).Append("\n");
      sb.Append("  ShowUnavailableItems: ").Append(ShowUnavailableItems).Append("\n");
      sb.Append("  HideIfNoCurrency: ").Append(HideIfNoCurrency).Append("\n");
      sb.Append("  HideFromRegularPurchase: ").Append(HideFromRegularPurchase).Append("\n");
      sb.Append("  BuyStringOverride: ").Append(BuyStringOverride).Append("\n");
      sb.Append("  DisabledDescription: ").Append(DisabledDescription).Append("\n");
      sb.Append("  DisplayTitle: ").Append(DisplayTitle).Append("\n");
      sb.Append("  Overlay: ").Append(Overlay).Append("\n");
      sb.Append("  VendorItemIndexes: ").Append(VendorItemIndexes).Append("\n");
      sb.Append("  IsPreview: ").Append(IsPreview).Append("\n");
      sb.Append("  IsDisplayOnly: ").Append(IsDisplayOnly).Append("\n");
      sb.Append("  ResetIntervalMinutesOverride: ").Append(ResetIntervalMinutesOverride).Append("\n");
      sb.Append("  ResetOffsetMinutesOverride: ").Append(ResetOffsetMinutesOverride).Append("\n");
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
