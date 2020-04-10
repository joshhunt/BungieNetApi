using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace BungieNetApi.Model {

  /// <summary>
  /// The results of a search for Destiny content. This will be improved on over time, I&#39;ve been doing some experimenting to see what might be useful.
  /// </summary>
  [DataContract]
  public class DestinyDefinitionsDestinyEntitySearchResult {
    /// <summary>
    /// A list of suggested words that might make for better search results, based on the text searched for.
    /// </summary>
    /// <value>A list of suggested words that might make for better search results, based on the text searched for.</value>
    [DataMember(Name="suggestedWords", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "suggestedWords")]
    public List<string> SuggestedWords { get; set; }

    /// <summary>
    /// The items found that are matches/near matches for the searched-for term, sorted by something vaguely resembling \"relevance\". Hopefully this will get better in the future.
    /// </summary>
    /// <value>The items found that are matches/near matches for the searched-for term, sorted by something vaguely resembling \"relevance\". Hopefully this will get better in the future.</value>
    [DataMember(Name="results", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "results")]
    public SearchResultOfDestinyEntitySearchResultItem Results { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class DestinyDefinitionsDestinyEntitySearchResult {\n");
      sb.Append("  SuggestedWords: ").Append(SuggestedWords).Append("\n");
      sb.Append("  Results: ").Append(Results).Append("\n");
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
