using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace BungieNetApi.Model {

  /// <summary>
  /// If you ever wondered how the Vault works, here it is.  The Vault is merely a set of inventory buckets that exist on your Profile/Account level. When you transfer items in the Vault, the game is using the Vault Vendor&#39;s DestinyVendorAcceptedItemDefinitions to see where the appropriate destination bucket is for the source bucket from whence your item is moving. If it finds such an entry, it transfers the item to the other bucket.  The mechanics for Postmaster works similarly, which is also a vendor. All driven by Accepted Items.
  /// </summary>
  [DataContract]
  public class DestinyDefinitionsDestinyVendorAcceptedItemDefinition {
    /// <summary>
    /// The \"source\" bucket for a transfer. When a user wants to transfer an item, the appropriate DestinyVendorDefinition's acceptedItems property is evaluated, looking for an entry where acceptedInventoryBucketHash matches the bucket that the item being transferred is currently located. If it exists, the item will be transferred into whatever bucket is defined by destinationInventoryBucketHash.
    /// </summary>
    /// <value>The \"source\" bucket for a transfer. When a user wants to transfer an item, the appropriate DestinyVendorDefinition's acceptedItems property is evaluated, looking for an entry where acceptedInventoryBucketHash matches the bucket that the item being transferred is currently located. If it exists, the item will be transferred into whatever bucket is defined by destinationInventoryBucketHash.</value>
    [DataMember(Name="acceptedInventoryBucketHash", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "acceptedInventoryBucketHash")]
    public int? AcceptedInventoryBucketHash { get; set; }

    /// <summary>
    /// This is the bucket where the item being transferred will be put, given that it was being transferred *from* the bucket defined in acceptedInventoryBucketHash.
    /// </summary>
    /// <value>This is the bucket where the item being transferred will be put, given that it was being transferred *from* the bucket defined in acceptedInventoryBucketHash.</value>
    [DataMember(Name="destinationInventoryBucketHash", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "destinationInventoryBucketHash")]
    public int? DestinationInventoryBucketHash { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class DestinyDefinitionsDestinyVendorAcceptedItemDefinition {\n");
      sb.Append("  AcceptedInventoryBucketHash: ").Append(AcceptedInventoryBucketHash).Append("\n");
      sb.Append("  DestinationInventoryBucketHash: ").Append(DestinationInventoryBucketHash).Append("\n");
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
