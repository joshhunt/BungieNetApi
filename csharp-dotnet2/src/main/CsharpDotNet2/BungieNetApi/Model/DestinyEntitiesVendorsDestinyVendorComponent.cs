using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace BungieNetApi.Model {

  /// <summary>
  /// This component contains essential/summary information about the vendor.
  /// </summary>
  [DataContract]
  public class DestinyEntitiesVendorsDestinyVendorComponent {
    /// <summary>
    /// If True, you can purchase from the Vendor.  Theoretically, Vendors can be restricted from selling items. In practice, none do that (yet?).
    /// </summary>
    /// <value>If True, you can purchase from the Vendor.  Theoretically, Vendors can be restricted from selling items. In practice, none do that (yet?).</value>
    [DataMember(Name="canPurchase", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "canPurchase")]
    public bool? CanPurchase { get; set; }

    /// <summary>
    /// If the Vendor has a related Reputation, this is the Progression data that represents the character's Reputation level with this Vendor.
    /// </summary>
    /// <value>If the Vendor has a related Reputation, this is the Progression data that represents the character's Reputation level with this Vendor.</value>
    [DataMember(Name="progression", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "progression")]
    public DestinyDestinyProgression Progression { get; set; }

    /// <summary>
    /// An index into the vendor definition's \"locations\" property array, indicating which location they are at currently. If -1, then the vendor has no known location (and you may choose not to show them in your UI as a result. I mean, it's your bag honey)
    /// </summary>
    /// <value>An index into the vendor definition's \"locations\" property array, indicating which location they are at currently. If -1, then the vendor has no known location (and you may choose not to show them in your UI as a result. I mean, it's your bag honey)</value>
    [DataMember(Name="vendorLocationIndex", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "vendorLocationIndex")]
    public int? VendorLocationIndex { get; set; }

    /// <summary>
    /// If this vendor has a seasonal rank, this will be the calculated value of that rank. How nice is that? I mean, that's pretty sweeet. It's a whole 32 bit integer.
    /// </summary>
    /// <value>If this vendor has a seasonal rank, this will be the calculated value of that rank. How nice is that? I mean, that's pretty sweeet. It's a whole 32 bit integer.</value>
    [DataMember(Name="seasonalRank", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "seasonalRank")]
    public int? SeasonalRank { get; set; }

    /// <summary>
    /// The unique identifier for the vendor. Use it to look up their DestinyVendorDefinition.
    /// </summary>
    /// <value>The unique identifier for the vendor. Use it to look up their DestinyVendorDefinition.</value>
    [DataMember(Name="vendorHash", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "vendorHash")]
    public int? VendorHash { get; set; }

    /// <summary>
    /// The date when this vendor's inventory will next rotate/refresh.  Note that this is distinct from the date ranges that the vendor is visible/available in-game: this field indicates the specific time when the vendor's available items refresh and rotate, regardless of whether the vendor is actually available at that time. Unfortunately, these two values may be (and are, for the case of important vendors like Xur) different.  Issue https://github.com/Bungie-net/api/issues/353 is tracking a fix to start providing visibility date ranges where possible in addition to this refresh date, so that all important dates for vendors are available for use.
    /// </summary>
    /// <value>The date when this vendor's inventory will next rotate/refresh.  Note that this is distinct from the date ranges that the vendor is visible/available in-game: this field indicates the specific time when the vendor's available items refresh and rotate, regardless of whether the vendor is actually available at that time. Unfortunately, these two values may be (and are, for the case of important vendors like Xur) different.  Issue https://github.com/Bungie-net/api/issues/353 is tracking a fix to start providing visibility date ranges where possible in addition to this refresh date, so that all important dates for vendors are available for use.</value>
    [DataMember(Name="nextRefreshDate", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "nextRefreshDate")]
    public DateTime? NextRefreshDate { get; set; }

    /// <summary>
    /// If True, the Vendor is currently accessible.   If False, they may not actually be visible in the world at the moment.
    /// </summary>
    /// <value>If True, the Vendor is currently accessible.   If False, they may not actually be visible in the world at the moment.</value>
    [DataMember(Name="enabled", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "enabled")]
    public bool? Enabled { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class DestinyEntitiesVendorsDestinyVendorComponent {\n");
      sb.Append("  CanPurchase: ").Append(CanPurchase).Append("\n");
      sb.Append("  Progression: ").Append(Progression).Append("\n");
      sb.Append("  VendorLocationIndex: ").Append(VendorLocationIndex).Append("\n");
      sb.Append("  SeasonalRank: ").Append(SeasonalRank).Append("\n");
      sb.Append("  VendorHash: ").Append(VendorHash).Append("\n");
      sb.Append("  NextRefreshDate: ").Append(NextRefreshDate).Append("\n");
      sb.Append("  Enabled: ").Append(Enabled).Append("\n");
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
