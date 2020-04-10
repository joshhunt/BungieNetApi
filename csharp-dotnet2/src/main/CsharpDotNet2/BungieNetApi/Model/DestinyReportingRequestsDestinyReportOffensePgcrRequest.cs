using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace BungieNetApi.Model {

  /// <summary>
  /// If you want to report a player causing trouble in a game, this request will let you report that player and the specific PGCR in which the trouble was caused, along with why.  Please don&#39;t do this just because you dislike the person! I mean, I know people will do it anyways, but can you like take a good walk, or put a curse on them or something? Do me a solid and reconsider.  Note that this request object doesn&#39;t have the actual PGCR ID nor your Account/Character ID in it. We will infer that information from your authentication information and the PGCR ID that you pass into the URL of the reporting endpoint itself.
  /// </summary>
  [DataContract]
  public class DestinyReportingRequestsDestinyReportOffensePgcrRequest {
    /// <summary>
    /// So you've decided to report someone instead of cursing them and their descendants. Well, okay then. This is the category or categorie(s) of infractions for which you are reporting the user. These are hash identifiers that map to DestinyReportReasonCategoryDefinition entries.
    /// </summary>
    /// <value>So you've decided to report someone instead of cursing them and their descendants. Well, okay then. This is the category or categorie(s) of infractions for which you are reporting the user. These are hash identifiers that map to DestinyReportReasonCategoryDefinition entries.</value>
    [DataMember(Name="reasonCategoryHashes", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "reasonCategoryHashes")]
    public List<int?> ReasonCategoryHashes { get; set; }

    /// <summary>
    /// If applicable, provide a more specific reason(s) within the general category of problems provided by the reasonHash. This is also an identifier for a reason. All reasonHashes provided must be children of at least one the reasonCategoryHashes provided.
    /// </summary>
    /// <value>If applicable, provide a more specific reason(s) within the general category of problems provided by the reasonHash. This is also an identifier for a reason. All reasonHashes provided must be children of at least one the reasonCategoryHashes provided.</value>
    [DataMember(Name="reasonHashes", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "reasonHashes")]
    public List<int?> ReasonHashes { get; set; }

    /// <summary>
    /// Within the PGCR provided when calling the Reporting endpoint, this should be the character ID of the user that you thought was violating terms of use. They must exist in the PGCR provided.
    /// </summary>
    /// <value>Within the PGCR provided when calling the Reporting endpoint, this should be the character ID of the user that you thought was violating terms of use. They must exist in the PGCR provided.</value>
    [DataMember(Name="offendingCharacterId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "offendingCharacterId")]
    public long? OffendingCharacterId { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class DestinyReportingRequestsDestinyReportOffensePgcrRequest {\n");
      sb.Append("  ReasonCategoryHashes: ").Append(ReasonCategoryHashes).Append("\n");
      sb.Append("  ReasonHashes: ").Append(ReasonHashes).Append("\n");
      sb.Append("  OffendingCharacterId: ").Append(OffendingCharacterId).Append("\n");
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
