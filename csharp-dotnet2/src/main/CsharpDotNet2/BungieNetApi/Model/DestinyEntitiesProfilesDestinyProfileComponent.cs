using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace BungieNetApi.Model {

  /// <summary>
  /// The most essential summary information about a Profile (in Destiny 1, we called these \&quot;Accounts\&quot;).
  /// </summary>
  [DataContract]
  public class DestinyEntitiesProfilesDestinyProfileComponent {
    /// <summary>
    /// If you need to render the Profile (their platform name, icon, etc...) somewhere, this property contains that information.
    /// </summary>
    /// <value>If you need to render the Profile (their platform name, icon, etc...) somewhere, this property contains that information.</value>
    [DataMember(Name="userInfo", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "userInfo")]
    public UserUserInfoCard UserInfo { get; set; }

    /// <summary>
    /// The last time the user played with any character on this Profile.
    /// </summary>
    /// <value>The last time the user played with any character on this Profile.</value>
    [DataMember(Name="dateLastPlayed", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "dateLastPlayed")]
    public DateTime? DateLastPlayed { get; set; }

    /// <summary>
    /// If you want to know what expansions they own, this will contain that data.   IMPORTANT: This field may not return the data you're interested in for Cross-Saved users. It returns the last ownership data we saw for this account - which is to say, what they've purchased on the platform on which they last played, which now could be a different platform.   If you don't care about per-platform ownership and only care about whatever platform it seems they are playing on most recently, then this should be \"good enough.\" Otherwise, this should be considered deprecated. We do not have a good alternative to provide at this time with platform specific ownership data for DLC.
    /// </summary>
    /// <value>If you want to know what expansions they own, this will contain that data.   IMPORTANT: This field may not return the data you're interested in for Cross-Saved users. It returns the last ownership data we saw for this account - which is to say, what they've purchased on the platform on which they last played, which now could be a different platform.   If you don't care about per-platform ownership and only care about whatever platform it seems they are playing on most recently, then this should be \"good enough.\" Otherwise, this should be considered deprecated. We do not have a good alternative to provide at this time with platform specific ownership data for DLC.</value>
    [DataMember(Name="versionsOwned", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "versionsOwned")]
    public int? VersionsOwned { get; set; }

    /// <summary>
    /// A list of the character IDs, for further querying on your part.
    /// </summary>
    /// <value>A list of the character IDs, for further querying on your part.</value>
    [DataMember(Name="characterIds", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "characterIds")]
    public List<long?> CharacterIds { get; set; }

    /// <summary>
    /// A list of seasons that this profile owns. Unlike versionsOwned, these stay with the profile across Platforms, and thus will be valid.   It turns out that Stadia Pro subscriptions will give access to seasons but only while playing on Stadia and with an active subscription. So some users (users who have Stadia Pro but choose to play on some other platform) won't see these as available: it will be whatever seasons are available for the platform on which they last played.
    /// </summary>
    /// <value>A list of seasons that this profile owns. Unlike versionsOwned, these stay with the profile across Platforms, and thus will be valid.   It turns out that Stadia Pro subscriptions will give access to seasons but only while playing on Stadia and with an active subscription. So some users (users who have Stadia Pro but choose to play on some other platform) won't see these as available: it will be whatever seasons are available for the platform on which they last played.</value>
    [DataMember(Name="seasonHashes", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "seasonHashes")]
    public List<int?> SeasonHashes { get; set; }

    /// <summary>
    /// If populated, this is a reference to the season that is currently active.
    /// </summary>
    /// <value>If populated, this is a reference to the season that is currently active.</value>
    [DataMember(Name="currentSeasonHash", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "currentSeasonHash")]
    public int? CurrentSeasonHash { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class DestinyEntitiesProfilesDestinyProfileComponent {\n");
      sb.Append("  UserInfo: ").Append(UserInfo).Append("\n");
      sb.Append("  DateLastPlayed: ").Append(DateLastPlayed).Append("\n");
      sb.Append("  VersionsOwned: ").Append(VersionsOwned).Append("\n");
      sb.Append("  CharacterIds: ").Append(CharacterIds).Append("\n");
      sb.Append("  SeasonHashes: ").Append(SeasonHashes).Append("\n");
      sb.Append("  CurrentSeasonHash: ").Append(CurrentSeasonHash).Append("\n");
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
