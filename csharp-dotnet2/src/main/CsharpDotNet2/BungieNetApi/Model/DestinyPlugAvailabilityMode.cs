using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace BungieNetApi.Model {

  /// <summary>
  /// This enum determines whether the plug is available to be inserted.  - Normal means that all existing rules for plug insertion apply.  - UnavailableIfSocketContainsMatchingPlugCategory means that the plug is only available if the socket does NOT match the plug category.  - AvailableIfSocketContainsMatchingPlugCategory means that the plug is only available if the socket DOES match the plug category.  For category matching, use the plug&#39;s \&quot;plugCategoryIdentifier\&quot; property, comparing it to
  /// </summary>
  [DataContract]
  public class DestinyPlugAvailabilityMode {

    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class DestinyPlugAvailabilityMode {\n");
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
