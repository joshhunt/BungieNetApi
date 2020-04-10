using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace BungieNetApi.Model {

  /// <summary>
  /// Represents the possible components that can be returned from Destiny \&quot;Get\&quot; calls such as GetProfile, GetCharacter, GetVendor etc...  When making one of these requests, you will pass one or more of these components as a comma separated list in the \&quot;?components&#x3D;\&quot; querystring parameter. For instance, if you want baseline Profile data, Character Data, and character progressions, you would pass \&quot;?components&#x3D;Profiles,Characters,CharacterProgressions\&quot; You may use either the numerical or string values.
  /// </summary>
  [DataContract]
  public class DestinyDestinyComponentType {

    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class DestinyDestinyComponentType {\n");
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
