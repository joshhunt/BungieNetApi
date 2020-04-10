using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace BungieNetApi.Model {

  /// <summary>
  /// Defines a single subscription: permission to send emails for a specific, focused subject (generally timeboxed, such as for a specific release of a product or feature).
  /// </summary>
  [DataContract]
  public class UserEmailSubscriptionDefinition {
    /// <summary>
    /// The unique identifier for this subscription.
    /// </summary>
    /// <value>The unique identifier for this subscription.</value>
    [DataMember(Name="name", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "name")]
    public string Name { get; set; }

    /// <summary>
    /// A dictionary of localized text for the EMail Opt-in setting, keyed by the locale.
    /// </summary>
    /// <value>A dictionary of localized text for the EMail Opt-in setting, keyed by the locale.</value>
    [DataMember(Name="localization", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "localization")]
    public Dictionary<string, UserEMailSettingSubscriptionLocalization> Localization { get; set; }

    /// <summary>
    /// The bitflag value for this subscription. Should be a unique power of two value.
    /// </summary>
    /// <value>The bitflag value for this subscription. Should be a unique power of two value.</value>
    [DataMember(Name="value", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "value")]
    public long? Value { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class UserEmailSubscriptionDefinition {\n");
      sb.Append("  Name: ").Append(Name).Append("\n");
      sb.Append("  Localization: ").Append(Localization).Append("\n");
      sb.Append("  Value: ").Append(Value).Append("\n");
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
