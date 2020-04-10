using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace BungieNetApi.Model {

  /// <summary>
  /// Represents all of the data related to a single plug to be inserted.  Note that, while you *can* point to a socket that represents infusion, you will receive an error if you attempt to do so. Come on guys, let&#39;s play nice.
  /// </summary>
  [DataContract]
  public class DestinyRequestsActionsDestinyInsertPlugsRequestEntry {
    /// <summary>
    /// The index into the socket array, which identifies the specific socket being operated on. We also need to know the socketArrayType in order to uniquely identify the socket.  Don't point to or try to insert a plug into an infusion socket. It won't work.
    /// </summary>
    /// <value>The index into the socket array, which identifies the specific socket being operated on. We also need to know the socketArrayType in order to uniquely identify the socket.  Don't point to or try to insert a plug into an infusion socket. It won't work.</value>
    [DataMember(Name="socketIndex", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "socketIndex")]
    public int? SocketIndex { get; set; }

    /// <summary>
    /// This property, combined with the socketIndex, tells us which socket we are referring to (since operations can be performed on both Intrinsic and \"default\" sockets, and they occupy different arrays in the Inventory Item Definition). I know, I know. Don't give me that look.
    /// </summary>
    /// <value>This property, combined with the socketIndex, tells us which socket we are referring to (since operations can be performed on both Intrinsic and \"default\" sockets, and they occupy different arrays in the Inventory Item Definition). I know, I know. Don't give me that look.</value>
    [DataMember(Name="socketArrayType", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "socketArrayType")]
    public int? SocketArrayType { get; set; }

    /// <summary>
    /// Plugs are never instanced (except in infusion). So with the hash alone, we should be able to: 1) Infer whether the player actually needs to have the item, or if it's a reusable plug 2) Perform any operation needed to use the Plug, including removing the plug item and running reward sheets.
    /// </summary>
    /// <value>Plugs are never instanced (except in infusion). So with the hash alone, we should be able to: 1) Infer whether the player actually needs to have the item, or if it's a reusable plug 2) Perform any operation needed to use the Plug, including removing the plug item and running reward sheets.</value>
    [DataMember(Name="plugItemHash", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "plugItemHash")]
    public int? PlugItemHash { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class DestinyRequestsActionsDestinyInsertPlugsRequestEntry {\n");
      sb.Append("  SocketIndex: ").Append(SocketIndex).Append("\n");
      sb.Append("  SocketArrayType: ").Append(SocketArrayType).Append("\n");
      sb.Append("  PlugItemHash: ").Append(PlugItemHash).Append("\n");
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
