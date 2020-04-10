using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace BungieNetApi.Model {

  /// <summary>
  /// If you look in the DestinyInventoryItemDefinition&#39;s \&quot;sockets\&quot; property, you&#39;ll see that there are two types of sockets: intrinsic, and \&quot;socketEntry.\&quot;  Unfortunately, because Intrinsic sockets are a whole separate array, it is no longer sufficient to know the index into that array to know which socket we&#39;re talking about. You have to know whether it&#39;s in the default \&quot;socketEntries\&quot; or if it&#39;s in the \&quot;intrinsic\&quot; list.
  /// </summary>
  [DataContract]
  public class DestinyRequestsActionsDestinySocketArrayType {

    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class DestinyRequestsActionsDestinySocketArrayType {\n");
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
