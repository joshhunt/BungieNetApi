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
  public class DestinyDefinitionsDestinyObjectiveDisplayProperties {
    /// <summary>
    /// The activity associated with this objective in the context of this item, if any.
    /// </summary>
    /// <value>The activity associated with this objective in the context of this item, if any.</value>
    [DataMember(Name="activityHash", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "activityHash")]
    public int? ActivityHash { get; set; }

    /// <summary>
    /// If true, the game shows this objective on item preview screens.
    /// </summary>
    /// <value>If true, the game shows this objective on item preview screens.</value>
    [DataMember(Name="displayOnItemPreviewScreen", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "displayOnItemPreviewScreen")]
    public bool? DisplayOnItemPreviewScreen { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class DestinyDefinitionsDestinyObjectiveDisplayProperties {\n");
      sb.Append("  ActivityHash: ").Append(ActivityHash).Append("\n");
      sb.Append("  DisplayOnItemPreviewScreen: ").Append(DisplayOnItemPreviewScreen).Append("\n");
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
