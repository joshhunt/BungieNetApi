using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace BungieNetApi.Model {

  /// <summary>
  /// Defines a single opt-in category: a wide-scoped permission to send emails for the subject related to the opt-in.
  /// </summary>
  [DataContract]
  public class UserEmailOptInDefinition {
    /// <summary>
    /// The unique identifier for this opt-in category.
    /// </summary>
    /// <value>The unique identifier for this opt-in category.</value>
    [DataMember(Name="name", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "name")]
    public string Name { get; set; }

    /// <summary>
    /// The flag value for this opt-in category. For historical reasons, this is defined as a flags enum.
    /// </summary>
    /// <value>The flag value for this opt-in category. For historical reasons, this is defined as a flags enum.</value>
    [DataMember(Name="value", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "value")]
    public long? Value { get; set; }

    /// <summary>
    /// If true, this opt-in setting should be set by default in situations where accounts are created without explicit choices about what they're opting into.
    /// </summary>
    /// <value>If true, this opt-in setting should be set by default in situations where accounts are created without explicit choices about what they're opting into.</value>
    [DataMember(Name="setByDefault", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "setByDefault")]
    public bool? SetByDefault { get; set; }

    /// <summary>
    /// Information about the dependent subscriptions for this opt-in.
    /// </summary>
    /// <value>Information about the dependent subscriptions for this opt-in.</value>
    [DataMember(Name="dependentSubscriptions", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "dependentSubscriptions")]
    public List<UserEmailSubscriptionDefinition> DependentSubscriptions { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class UserEmailOptInDefinition {\n");
      sb.Append("  Name: ").Append(Name).Append("\n");
      sb.Append("  Value: ").Append(Value).Append("\n");
      sb.Append("  SetByDefault: ").Append(SetByDefault).Append("\n");
      sb.Append("  DependentSubscriptions: ").Append(DependentSubscriptions).Append("\n");
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
