using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace BungieNetApi.Model {

  /// <summary>
  /// The various known UI styles in which an item can be highlighted. It&#39;ll be up to you to determine what you want to show based on this highlighting, BNet doesn&#39;t have any assets that correspond to these states. And yeah, RiseOfIron and Comet have their own special highlight states. Don&#39;t ask me, I can&#39;t imagine they&#39;re still used.
  /// </summary>
  [DataContract]
  public class DestinyActivityGraphNodeHighlightType {

    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class DestinyActivityGraphNodeHighlightType {\n");
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
