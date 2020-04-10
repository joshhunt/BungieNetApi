using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace BungieNetApi.Model {

  /// <summary>
  /// 
  /// </summary>
  [DataContract]
  public class UserEmailViewDefinitionSetting {
    /// <summary>
    /// The identifier for this UI Setting, which can be used to relate it to custom strings or other data as desired.
    /// </summary>
    /// <value>The identifier for this UI Setting, which can be used to relate it to custom strings or other data as desired.</value>
    [DataMember(Name="name", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "name")]
    public string Name { get; set; }

    /// <summary>
    /// A dictionary of localized text for the EMail setting, keyed by the locale.
    /// </summary>
    /// <value>A dictionary of localized text for the EMail setting, keyed by the locale.</value>
    [DataMember(Name="localization", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "localization")]
    public Dictionary<string, UserEMailSettingLocalization> Localization { get; set; }

    /// <summary>
    /// If true, this setting should be set by default if the user hasn't chosen whether it's set or cleared yet.
    /// </summary>
    /// <value>If true, this setting should be set by default if the user hasn't chosen whether it's set or cleared yet.</value>
    [DataMember(Name="setByDefault", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "setByDefault")]
    public bool? SetByDefault { get; set; }

    /// <summary>
    /// The OptInFlags value to set or clear if this setting is set or cleared in the UI. It is the aggregate of all underlying opt-in flags related to this setting.
    /// </summary>
    /// <value>The OptInFlags value to set or clear if this setting is set or cleared in the UI. It is the aggregate of all underlying opt-in flags related to this setting.</value>
    [DataMember(Name="optInAggregateValue", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "optInAggregateValue")]
    public long? OptInAggregateValue { get; set; }

    /// <summary>
    /// The subscriptions to show as children of this setting, if any.
    /// </summary>
    /// <value>The subscriptions to show as children of this setting, if any.</value>
    [DataMember(Name="subscriptions", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "subscriptions")]
    public List<UserEmailSubscriptionDefinition> Subscriptions { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class UserEmailViewDefinitionSetting {\n");
      sb.Append("  Name: ").Append(Name).Append("\n");
      sb.Append("  Localization: ").Append(Localization).Append("\n");
      sb.Append("  SetByDefault: ").Append(SetByDefault).Append("\n");
      sb.Append("  OptInAggregateValue: ").Append(OptInAggregateValue).Append("\n");
      sb.Append("  Subscriptions: ").Append(Subscriptions).Append("\n");
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
