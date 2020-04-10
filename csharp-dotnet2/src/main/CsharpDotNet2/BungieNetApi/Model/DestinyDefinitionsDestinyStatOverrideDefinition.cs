using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace BungieNetApi.Model {

  /// <summary>
  /// Stat Groups (DestinyStatGroupDefinition) has the ability to override the localized text associated with stats that are to be shown on the items with which they are associated.  This defines a specific overridden stat. You could theoretically check these before rendering your stat UI, and for each stat that has an override show these displayProperties instead of those on the DestinyStatDefinition.  Or you could be like us, and skip that for now because the game has yet to actually use this feature. But know that it&#39;s here, waiting for a resilliant young designer to take up the mantle and make us all look foolish by showing the wrong name for stats.  Note that, if this gets used, the override will apply only to items using the overriding Stat Group. Other items will still show the default stat&#39;s name/description.
  /// </summary>
  [DataContract]
  public class DestinyDefinitionsDestinyStatOverrideDefinition {
    /// <summary>
    /// The hash identifier of the stat whose display properties are being overridden.
    /// </summary>
    /// <value>The hash identifier of the stat whose display properties are being overridden.</value>
    [DataMember(Name="statHash", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "statHash")]
    public int? StatHash { get; set; }

    /// <summary>
    /// The display properties to show instead of the base DestinyStatDefinition display properties.
    /// </summary>
    /// <value>The display properties to show instead of the base DestinyStatDefinition display properties.</value>
    [DataMember(Name="displayProperties", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "displayProperties")]
    public DestinyDefinitionsCommonDestinyDisplayPropertiesDefinition DisplayProperties { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class DestinyDefinitionsDestinyStatOverrideDefinition {\n");
      sb.Append("  StatHash: ").Append(StatHash).Append("\n");
      sb.Append("  DisplayProperties: ").Append(DisplayProperties).Append("\n");
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
