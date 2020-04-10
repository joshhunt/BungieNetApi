using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace BungieNetApi.Model {

  /// <summary>
  /// These definitions represent faction vendors at different points in the game.  A single faction may contain multiple vendors, or the same vendor available at two different locations.
  /// </summary>
  [DataContract]
  public class DestinyDefinitionsDestinyFactionVendorDefinition {
    /// <summary>
    /// The faction vendor hash.
    /// </summary>
    /// <value>The faction vendor hash.</value>
    [DataMember(Name="vendorHash", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "vendorHash")]
    public int? VendorHash { get; set; }

    /// <summary>
    /// The hash identifier for a Destination at which this vendor may be located. Each destination where a Vendor may exist will only ever have a single entry.
    /// </summary>
    /// <value>The hash identifier for a Destination at which this vendor may be located. Each destination where a Vendor may exist will only ever have a single entry.</value>
    [DataMember(Name="destinationHash", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "destinationHash")]
    public int? DestinationHash { get; set; }

    /// <summary>
    /// The relative path to the background image representing this Vendor at this location, for use in a banner.
    /// </summary>
    /// <value>The relative path to the background image representing this Vendor at this location, for use in a banner.</value>
    [DataMember(Name="backgroundImagePath", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "backgroundImagePath")]
    public string BackgroundImagePath { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class DestinyDefinitionsDestinyFactionVendorDefinition {\n");
      sb.Append("  VendorHash: ").Append(VendorHash).Append("\n");
      sb.Append("  DestinationHash: ").Append(DestinationHash).Append("\n");
      sb.Append("  BackgroundImagePath: ").Append(BackgroundImagePath).Append("\n");
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
