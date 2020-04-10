using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace BungieNetApi.Model {

  /// <summary>
  /// The details of an overlay prompt to show to a user. They are all fairly self-explanatory localized strings that can be shown.
  /// </summary>
  [DataContract]
  public class DestinyDefinitionsDestinyVendorCategoryOverlayDefinition {
    /// <summary>
    /// Gets or Sets ChoiceDescription
    /// </summary>
    [DataMember(Name="choiceDescription", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "choiceDescription")]
    public string ChoiceDescription { get; set; }

    /// <summary>
    /// Gets or Sets Description
    /// </summary>
    [DataMember(Name="description", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "description")]
    public string Description { get; set; }

    /// <summary>
    /// Gets or Sets Icon
    /// </summary>
    [DataMember(Name="icon", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "icon")]
    public string Icon { get; set; }

    /// <summary>
    /// Gets or Sets Title
    /// </summary>
    [DataMember(Name="title", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "title")]
    public string Title { get; set; }

    /// <summary>
    /// If this overlay has a currency item that it features, this is said featured item.
    /// </summary>
    /// <value>If this overlay has a currency item that it features, this is said featured item.</value>
    [DataMember(Name="currencyItemHash", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "currencyItemHash")]
    public int? CurrencyItemHash { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class DestinyDefinitionsDestinyVendorCategoryOverlayDefinition {\n");
      sb.Append("  ChoiceDescription: ").Append(ChoiceDescription).Append("\n");
      sb.Append("  Description: ").Append(Description).Append("\n");
      sb.Append("  Icon: ").Append(Icon).Append("\n");
      sb.Append("  Title: ").Append(Title).Append("\n");
      sb.Append("  CurrencyItemHash: ").Append(CurrencyItemHash).Append("\n");
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
