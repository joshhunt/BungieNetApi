using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace BungieNetApi.Model {

  /// <summary>
  /// Presentation nodes can be restricted by various requirements. This defines the rules of those requirements, and the message(s) to be shown if these requirements aren&#39;t met.
  /// </summary>
  [DataContract]
  public class DestinyDefinitionsPresentationDestinyPresentationNodeRequirementsBlock {
    /// <summary>
    /// If this node is not accessible due to Entitlements (for instance, you don't own the required game expansion), this is the message to show.
    /// </summary>
    /// <value>If this node is not accessible due to Entitlements (for instance, you don't own the required game expansion), this is the message to show.</value>
    [DataMember(Name="entitlementUnavailableMessage", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "entitlementUnavailableMessage")]
    public string EntitlementUnavailableMessage { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class DestinyDefinitionsPresentationDestinyPresentationNodeRequirementsBlock {\n");
      sb.Append("  EntitlementUnavailableMessage: ").Append(EntitlementUnavailableMessage).Append("\n");
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
