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
  public class DestinyComponentsPresentationDestinyPresentationNodeComponent {
    /// <summary>
    /// Gets or Sets State
    /// </summary>
    [DataMember(Name="state", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "state")]
    public int? State { get; set; }

    /// <summary>
    /// An optional property: presentation nodes MAY have objectives, which can be used to infer more human readable data about the progress. However, progressValue and completionValue ought to be considered the canonical values for progress on Progression Nodes.
    /// </summary>
    /// <value>An optional property: presentation nodes MAY have objectives, which can be used to infer more human readable data about the progress. However, progressValue and completionValue ought to be considered the canonical values for progress on Progression Nodes.</value>
    [DataMember(Name="objective", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "objective")]
    public DestinyQuestsDestinyObjectiveProgress Objective { get; set; }

    /// <summary>
    /// How much of the presentation node is considered to be completed so far by the given character/profile.
    /// </summary>
    /// <value>How much of the presentation node is considered to be completed so far by the given character/profile.</value>
    [DataMember(Name="progressValue", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "progressValue")]
    public int? ProgressValue { get; set; }

    /// <summary>
    /// The value at which the presentation node is considered to be completed.
    /// </summary>
    /// <value>The value at which the presentation node is considered to be completed.</value>
    [DataMember(Name="completionValue", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "completionValue")]
    public int? CompletionValue { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class DestinyComponentsPresentationDestinyPresentationNodeComponent {\n");
      sb.Append("  State: ").Append(State).Append("\n");
      sb.Append("  Objective: ").Append(Objective).Append("\n");
      sb.Append("  ProgressValue: ").Append(ProgressValue).Append("\n");
      sb.Append("  CompletionValue: ").Append(CompletionValue).Append("\n");
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
