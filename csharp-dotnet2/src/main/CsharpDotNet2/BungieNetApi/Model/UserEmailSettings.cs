using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace BungieNetApi.Model {

  /// <summary>
  /// The set of all email subscription/opt-in settings and definitions.
  /// </summary>
  [DataContract]
  public class UserEmailSettings {
    /// <summary>
    /// Keyed by the name identifier of the opt-in definition.
    /// </summary>
    /// <value>Keyed by the name identifier of the opt-in definition.</value>
    [DataMember(Name="optInDefinitions", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "optInDefinitions")]
    public Dictionary<string, UserEmailOptInDefinition> OptInDefinitions { get; set; }

    /// <summary>
    /// Keyed by the name identifier of the Subscription definition.
    /// </summary>
    /// <value>Keyed by the name identifier of the Subscription definition.</value>
    [DataMember(Name="subscriptionDefinitions", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "subscriptionDefinitions")]
    public Dictionary<string, UserEmailSubscriptionDefinition> SubscriptionDefinitions { get; set; }

    /// <summary>
    /// Keyed by the name identifier of the View definition.
    /// </summary>
    /// <value>Keyed by the name identifier of the View definition.</value>
    [DataMember(Name="views", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "views")]
    public Dictionary<string, UserEmailViewDefinition> Views { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class UserEmailSettings {\n");
      sb.Append("  OptInDefinitions: ").Append(OptInDefinitions).Append("\n");
      sb.Append("  SubscriptionDefinitions: ").Append(SubscriptionDefinitions).Append("\n");
      sb.Append("  Views: ").Append(Views).Append("\n");
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
