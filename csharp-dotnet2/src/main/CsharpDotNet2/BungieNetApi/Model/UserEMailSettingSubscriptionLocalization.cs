using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace BungieNetApi.Model {

  /// <summary>
  /// Localized text relevant to a given EMail setting in a given localization. Extra settings specifically for subscriptions.
  /// </summary>
  [DataContract]
  public class UserEMailSettingSubscriptionLocalization {
    /// <summary>
    /// Gets or Sets UnknownUserDescription
    /// </summary>
    [DataMember(Name="unknownUserDescription", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "unknownUserDescription")]
    public string UnknownUserDescription { get; set; }

    /// <summary>
    /// Gets or Sets RegisteredUserDescription
    /// </summary>
    [DataMember(Name="registeredUserDescription", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "registeredUserDescription")]
    public string RegisteredUserDescription { get; set; }

    /// <summary>
    /// Gets or Sets UnregisteredUserDescription
    /// </summary>
    [DataMember(Name="unregisteredUserDescription", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "unregisteredUserDescription")]
    public string UnregisteredUserDescription { get; set; }

    /// <summary>
    /// Gets or Sets UnknownUserActionText
    /// </summary>
    [DataMember(Name="unknownUserActionText", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "unknownUserActionText")]
    public string UnknownUserActionText { get; set; }

    /// <summary>
    /// Gets or Sets KnownUserActionText
    /// </summary>
    [DataMember(Name="knownUserActionText", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "knownUserActionText")]
    public string KnownUserActionText { get; set; }

    /// <summary>
    /// Gets or Sets Title
    /// </summary>
    [DataMember(Name="title", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "title")]
    public string Title { get; set; }

    /// <summary>
    /// Gets or Sets Description
    /// </summary>
    [DataMember(Name="description", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "description")]
    public string Description { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class UserEMailSettingSubscriptionLocalization {\n");
      sb.Append("  UnknownUserDescription: ").Append(UnknownUserDescription).Append("\n");
      sb.Append("  RegisteredUserDescription: ").Append(RegisteredUserDescription).Append("\n");
      sb.Append("  UnregisteredUserDescription: ").Append(UnregisteredUserDescription).Append("\n");
      sb.Append("  UnknownUserActionText: ").Append(UnknownUserActionText).Append("\n");
      sb.Append("  KnownUserActionText: ").Append(KnownUserActionText).Append("\n");
      sb.Append("  Title: ").Append(Title).Append("\n");
      sb.Append("  Description: ").Append(Description).Append("\n");
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
