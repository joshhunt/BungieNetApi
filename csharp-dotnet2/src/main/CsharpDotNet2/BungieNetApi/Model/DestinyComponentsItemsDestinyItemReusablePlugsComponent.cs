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
  public class DestinyComponentsItemsDestinyItemReusablePlugsComponent {
    /// <summary>
    /// If the item supports reusable plugs, this is the list of plugs that are allowed to be used for the socket, and any relevant information about whether they are \"enabled\", whether they are allowed to be inserted, and any other information such as objectives.   A Reusable Plug is a plug that you can always insert into this socket as long as its insertion rules are passed, regardless of whether or not you have the plug in your inventory. An example of it failing an insertion rule would be if it has an Objective that needs to be completed before it can be inserted, and that objective hasn't been completed yet.   In practice, a socket will *either* have reusable plugs *or* it will allow for plugs in your inventory to be inserted. See DestinyInventoryItemDefinition.socket for more info.   KEY = The INDEX into the item's list of sockets. VALUE = The set of plugs for that socket.   If a socket doesn't have any reusable plugs defined at the item scope, there will be no entry for that socket.
    /// </summary>
    /// <value>If the item supports reusable plugs, this is the list of plugs that are allowed to be used for the socket, and any relevant information about whether they are \"enabled\", whether they are allowed to be inserted, and any other information such as objectives.   A Reusable Plug is a plug that you can always insert into this socket as long as its insertion rules are passed, regardless of whether or not you have the plug in your inventory. An example of it failing an insertion rule would be if it has an Objective that needs to be completed before it can be inserted, and that objective hasn't been completed yet.   In practice, a socket will *either* have reusable plugs *or* it will allow for plugs in your inventory to be inserted. See DestinyInventoryItemDefinition.socket for more info.   KEY = The INDEX into the item's list of sockets. VALUE = The set of plugs for that socket.   If a socket doesn't have any reusable plugs defined at the item scope, there will be no entry for that socket.</value>
    [DataMember(Name="plugs", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "plugs")]
    public Dictionary<string, List<DestinySocketsDestinyItemPlugBase>> Plugs { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class DestinyComponentsItemsDestinyItemReusablePlugsComponent {\n");
      sb.Append("  Plugs: ").Append(Plugs).Append("\n");
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
