/* 
 * Bungie.Net API
 *
 * These endpoints constitute the functionality exposed by Bungie.net, both for more traditional website functionality and for connectivity to Bungie video games and their related functionality.
 *
 * The version of the OpenAPI document: 2.8.0
 * Contact: support@bungie.com
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;
using OpenAPIDateConverter = BungieNetApi.Client.OpenAPIDateConverter;

namespace BungieNetApi.Model
{
    /// <summary>
    /// This component contains base properties of the character. You&#39;ll probably want to always request this component, but hey you do you.
    /// </summary>
    [DataContract]
    public partial class DestinyEntitiesCharactersDestinyCharacterComponent :  IEquatable<DestinyEntitiesCharactersDestinyCharacterComponent>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DestinyEntitiesCharactersDestinyCharacterComponent" /> class.
        /// </summary>
        /// <param name="membershipId">Every Destiny Profile has a membershipId. This is provided on the character as well for convenience..</param>
        /// <param name="membershipType">membershipType tells you the platform on which the character plays. Examine the BungieMembershipType enumeration for possible values..</param>
        /// <param name="characterId">The unique identifier for the character..</param>
        /// <param name="dateLastPlayed">The last date that the user played Destiny..</param>
        /// <param name="minutesPlayedThisSession">If the user is currently playing, this is how long they&#39;ve been playing..</param>
        /// <param name="minutesPlayedTotal">If this value is 525,600, then they played Destiny for a year. Or they&#39;re a very dedicated Rent fan. Note that this includes idle time, not just time spent actually in activities shooting things..</param>
        /// <param name="light">The user&#39;s calculated \&quot;Light Level\&quot;. Light level is an indicator of your power that mostly matters in the end game, once you&#39;ve reached the maximum character level: it&#39;s a level that&#39;s dependent on the average Attack/Defense power of your items..</param>
        /// <param name="stats">Your character&#39;s stats, such as Agility, Resilience, etc... *not* historical stats.  You&#39;ll have to call a different endpoint for those..</param>
        /// <param name="raceHash">Use this hash to look up the character&#39;s DestinyRaceDefinition..</param>
        /// <param name="genderHash">Use this hash to look up the character&#39;s DestinyGenderDefinition..</param>
        /// <param name="classHash">Use this hash to look up the character&#39;s DestinyClassDefinition..</param>
        /// <param name="raceType">Mostly for historical purposes at this point, this is an enumeration for the character&#39;s race.  It&#39;ll be preferable in the general case to look up the related definition: but for some people this was too convenient to remove..</param>
        /// <param name="classType">Mostly for historical purposes at this point, this is an enumeration for the character&#39;s class.  It&#39;ll be preferable in the general case to look up the related definition: but for some people this was too convenient to remove..</param>
        /// <param name="genderType">Mostly for historical purposes at this point, this is an enumeration for the character&#39;s Gender.  It&#39;ll be preferable in the general case to look up the related definition: but for some people this was too convenient to remove. And yeah, it&#39;s an enumeration and not a boolean. Fight me..</param>
        /// <param name="emblemPath">A shortcut path to the user&#39;s currently equipped emblem image. If you&#39;re just showing summary info for a user, this is more convenient than examining their equipped emblem and looking up the definition..</param>
        /// <param name="emblemBackgroundPath">A shortcut path to the user&#39;s currently equipped emblem background image. If you&#39;re just showing summary info for a user, this is more convenient than examining their equipped emblem and looking up the definition..</param>
        /// <param name="emblemHash">The hash of the currently equipped emblem for the user. Can be used to look up the DestinyInventoryItemDefinition..</param>
        /// <param name="emblemColor">A shortcut for getting the background color of the user&#39;s currently equipped emblem without having to do a DestinyInventoryItemDefinition lookup..</param>
        /// <param name="levelProgression">The progression that indicates your character&#39;s level. Not their light level, but their character level: you know, the thing you max out a couple hours in and then ignore for the sake of light level..</param>
        /// <param name="baseCharacterLevel">The \&quot;base\&quot; level of your character, not accounting for any light level..</param>
        /// <param name="percentToNextLevel">A number between 0 and 100, indicating the whole and fractional % remaining to get to the next character level..</param>
        /// <param name="titleRecordHash">If this Character has a title assigned to it, this is the identifier of the DestinyRecordDefinition that has that title information..</param>
        public DestinyEntitiesCharactersDestinyCharacterComponent(long membershipId = default(long), int membershipType = default(int), long characterId = default(long), DateTime dateLastPlayed = default(DateTime), long minutesPlayedThisSession = default(long), long minutesPlayedTotal = default(long), int light = default(int), Dictionary<string, int> stats = default(Dictionary<string, int>), int raceHash = default(int), int genderHash = default(int), int classHash = default(int), int raceType = default(int), int classType = default(int), int genderType = default(int), string emblemPath = default(string), string emblemBackgroundPath = default(string), int emblemHash = default(int), DestinyMiscDestinyColor emblemColor = default(DestinyMiscDestinyColor), DestinyDestinyProgression levelProgression = default(DestinyDestinyProgression), int baseCharacterLevel = default(int), float percentToNextLevel = default(float), int titleRecordHash = default(int))
        {
            this.MembershipId = membershipId;
            this.MembershipType = membershipType;
            this.CharacterId = characterId;
            this.DateLastPlayed = dateLastPlayed;
            this.MinutesPlayedThisSession = minutesPlayedThisSession;
            this.MinutesPlayedTotal = minutesPlayedTotal;
            this.Light = light;
            this.Stats = stats;
            this.RaceHash = raceHash;
            this.GenderHash = genderHash;
            this.ClassHash = classHash;
            this.RaceType = raceType;
            this.ClassType = classType;
            this.GenderType = genderType;
            this.EmblemPath = emblemPath;
            this.EmblemBackgroundPath = emblemBackgroundPath;
            this.EmblemHash = emblemHash;
            this.EmblemColor = emblemColor;
            this.LevelProgression = levelProgression;
            this.BaseCharacterLevel = baseCharacterLevel;
            this.PercentToNextLevel = percentToNextLevel;
            this.TitleRecordHash = titleRecordHash;
        }
        
        /// <summary>
        /// Every Destiny Profile has a membershipId. This is provided on the character as well for convenience.
        /// </summary>
        /// <value>Every Destiny Profile has a membershipId. This is provided on the character as well for convenience.</value>
        [DataMember(Name="membershipId", EmitDefaultValue=false)]
        public long MembershipId { get; set; }

        /// <summary>
        /// membershipType tells you the platform on which the character plays. Examine the BungieMembershipType enumeration for possible values.
        /// </summary>
        /// <value>membershipType tells you the platform on which the character plays. Examine the BungieMembershipType enumeration for possible values.</value>
        [DataMember(Name="membershipType", EmitDefaultValue=false)]
        public int MembershipType { get; set; }

        /// <summary>
        /// The unique identifier for the character.
        /// </summary>
        /// <value>The unique identifier for the character.</value>
        [DataMember(Name="characterId", EmitDefaultValue=false)]
        public long CharacterId { get; set; }

        /// <summary>
        /// The last date that the user played Destiny.
        /// </summary>
        /// <value>The last date that the user played Destiny.</value>
        [DataMember(Name="dateLastPlayed", EmitDefaultValue=false)]
        public DateTime DateLastPlayed { get; set; }

        /// <summary>
        /// If the user is currently playing, this is how long they&#39;ve been playing.
        /// </summary>
        /// <value>If the user is currently playing, this is how long they&#39;ve been playing.</value>
        [DataMember(Name="minutesPlayedThisSession", EmitDefaultValue=false)]
        public long MinutesPlayedThisSession { get; set; }

        /// <summary>
        /// If this value is 525,600, then they played Destiny for a year. Or they&#39;re a very dedicated Rent fan. Note that this includes idle time, not just time spent actually in activities shooting things.
        /// </summary>
        /// <value>If this value is 525,600, then they played Destiny for a year. Or they&#39;re a very dedicated Rent fan. Note that this includes idle time, not just time spent actually in activities shooting things.</value>
        [DataMember(Name="minutesPlayedTotal", EmitDefaultValue=false)]
        public long MinutesPlayedTotal { get; set; }

        /// <summary>
        /// The user&#39;s calculated \&quot;Light Level\&quot;. Light level is an indicator of your power that mostly matters in the end game, once you&#39;ve reached the maximum character level: it&#39;s a level that&#39;s dependent on the average Attack/Defense power of your items.
        /// </summary>
        /// <value>The user&#39;s calculated \&quot;Light Level\&quot;. Light level is an indicator of your power that mostly matters in the end game, once you&#39;ve reached the maximum character level: it&#39;s a level that&#39;s dependent on the average Attack/Defense power of your items.</value>
        [DataMember(Name="light", EmitDefaultValue=false)]
        public int Light { get; set; }

        /// <summary>
        /// Your character&#39;s stats, such as Agility, Resilience, etc... *not* historical stats.  You&#39;ll have to call a different endpoint for those.
        /// </summary>
        /// <value>Your character&#39;s stats, such as Agility, Resilience, etc... *not* historical stats.  You&#39;ll have to call a different endpoint for those.</value>
        [DataMember(Name="stats", EmitDefaultValue=false)]
        public Dictionary<string, int> Stats { get; set; }

        /// <summary>
        /// Use this hash to look up the character&#39;s DestinyRaceDefinition.
        /// </summary>
        /// <value>Use this hash to look up the character&#39;s DestinyRaceDefinition.</value>
        [DataMember(Name="raceHash", EmitDefaultValue=false)]
        public int RaceHash { get; set; }

        /// <summary>
        /// Use this hash to look up the character&#39;s DestinyGenderDefinition.
        /// </summary>
        /// <value>Use this hash to look up the character&#39;s DestinyGenderDefinition.</value>
        [DataMember(Name="genderHash", EmitDefaultValue=false)]
        public int GenderHash { get; set; }

        /// <summary>
        /// Use this hash to look up the character&#39;s DestinyClassDefinition.
        /// </summary>
        /// <value>Use this hash to look up the character&#39;s DestinyClassDefinition.</value>
        [DataMember(Name="classHash", EmitDefaultValue=false)]
        public int ClassHash { get; set; }

        /// <summary>
        /// Mostly for historical purposes at this point, this is an enumeration for the character&#39;s race.  It&#39;ll be preferable in the general case to look up the related definition: but for some people this was too convenient to remove.
        /// </summary>
        /// <value>Mostly for historical purposes at this point, this is an enumeration for the character&#39;s race.  It&#39;ll be preferable in the general case to look up the related definition: but for some people this was too convenient to remove.</value>
        [DataMember(Name="raceType", EmitDefaultValue=false)]
        public int RaceType { get; set; }

        /// <summary>
        /// Mostly for historical purposes at this point, this is an enumeration for the character&#39;s class.  It&#39;ll be preferable in the general case to look up the related definition: but for some people this was too convenient to remove.
        /// </summary>
        /// <value>Mostly for historical purposes at this point, this is an enumeration for the character&#39;s class.  It&#39;ll be preferable in the general case to look up the related definition: but for some people this was too convenient to remove.</value>
        [DataMember(Name="classType", EmitDefaultValue=false)]
        public int ClassType { get; set; }

        /// <summary>
        /// Mostly for historical purposes at this point, this is an enumeration for the character&#39;s Gender.  It&#39;ll be preferable in the general case to look up the related definition: but for some people this was too convenient to remove. And yeah, it&#39;s an enumeration and not a boolean. Fight me.
        /// </summary>
        /// <value>Mostly for historical purposes at this point, this is an enumeration for the character&#39;s Gender.  It&#39;ll be preferable in the general case to look up the related definition: but for some people this was too convenient to remove. And yeah, it&#39;s an enumeration and not a boolean. Fight me.</value>
        [DataMember(Name="genderType", EmitDefaultValue=false)]
        public int GenderType { get; set; }

        /// <summary>
        /// A shortcut path to the user&#39;s currently equipped emblem image. If you&#39;re just showing summary info for a user, this is more convenient than examining their equipped emblem and looking up the definition.
        /// </summary>
        /// <value>A shortcut path to the user&#39;s currently equipped emblem image. If you&#39;re just showing summary info for a user, this is more convenient than examining their equipped emblem and looking up the definition.</value>
        [DataMember(Name="emblemPath", EmitDefaultValue=false)]
        public string EmblemPath { get; set; }

        /// <summary>
        /// A shortcut path to the user&#39;s currently equipped emblem background image. If you&#39;re just showing summary info for a user, this is more convenient than examining their equipped emblem and looking up the definition.
        /// </summary>
        /// <value>A shortcut path to the user&#39;s currently equipped emblem background image. If you&#39;re just showing summary info for a user, this is more convenient than examining their equipped emblem and looking up the definition.</value>
        [DataMember(Name="emblemBackgroundPath", EmitDefaultValue=false)]
        public string EmblemBackgroundPath { get; set; }

        /// <summary>
        /// The hash of the currently equipped emblem for the user. Can be used to look up the DestinyInventoryItemDefinition.
        /// </summary>
        /// <value>The hash of the currently equipped emblem for the user. Can be used to look up the DestinyInventoryItemDefinition.</value>
        [DataMember(Name="emblemHash", EmitDefaultValue=false)]
        public int EmblemHash { get; set; }

        /// <summary>
        /// A shortcut for getting the background color of the user&#39;s currently equipped emblem without having to do a DestinyInventoryItemDefinition lookup.
        /// </summary>
        /// <value>A shortcut for getting the background color of the user&#39;s currently equipped emblem without having to do a DestinyInventoryItemDefinition lookup.</value>
        [DataMember(Name="emblemColor", EmitDefaultValue=false)]
        public DestinyMiscDestinyColor EmblemColor { get; set; }

        /// <summary>
        /// The progression that indicates your character&#39;s level. Not their light level, but their character level: you know, the thing you max out a couple hours in and then ignore for the sake of light level.
        /// </summary>
        /// <value>The progression that indicates your character&#39;s level. Not their light level, but their character level: you know, the thing you max out a couple hours in and then ignore for the sake of light level.</value>
        [DataMember(Name="levelProgression", EmitDefaultValue=false)]
        public DestinyDestinyProgression LevelProgression { get; set; }

        /// <summary>
        /// The \&quot;base\&quot; level of your character, not accounting for any light level.
        /// </summary>
        /// <value>The \&quot;base\&quot; level of your character, not accounting for any light level.</value>
        [DataMember(Name="baseCharacterLevel", EmitDefaultValue=false)]
        public int BaseCharacterLevel { get; set; }

        /// <summary>
        /// A number between 0 and 100, indicating the whole and fractional % remaining to get to the next character level.
        /// </summary>
        /// <value>A number between 0 and 100, indicating the whole and fractional % remaining to get to the next character level.</value>
        [DataMember(Name="percentToNextLevel", EmitDefaultValue=false)]
        public float PercentToNextLevel { get; set; }

        /// <summary>
        /// If this Character has a title assigned to it, this is the identifier of the DestinyRecordDefinition that has that title information.
        /// </summary>
        /// <value>If this Character has a title assigned to it, this is the identifier of the DestinyRecordDefinition that has that title information.</value>
        [DataMember(Name="titleRecordHash", EmitDefaultValue=false)]
        public int TitleRecordHash { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DestinyEntitiesCharactersDestinyCharacterComponent {\n");
            sb.Append("  MembershipId: ").Append(MembershipId).Append("\n");
            sb.Append("  MembershipType: ").Append(MembershipType).Append("\n");
            sb.Append("  CharacterId: ").Append(CharacterId).Append("\n");
            sb.Append("  DateLastPlayed: ").Append(DateLastPlayed).Append("\n");
            sb.Append("  MinutesPlayedThisSession: ").Append(MinutesPlayedThisSession).Append("\n");
            sb.Append("  MinutesPlayedTotal: ").Append(MinutesPlayedTotal).Append("\n");
            sb.Append("  Light: ").Append(Light).Append("\n");
            sb.Append("  Stats: ").Append(Stats).Append("\n");
            sb.Append("  RaceHash: ").Append(RaceHash).Append("\n");
            sb.Append("  GenderHash: ").Append(GenderHash).Append("\n");
            sb.Append("  ClassHash: ").Append(ClassHash).Append("\n");
            sb.Append("  RaceType: ").Append(RaceType).Append("\n");
            sb.Append("  ClassType: ").Append(ClassType).Append("\n");
            sb.Append("  GenderType: ").Append(GenderType).Append("\n");
            sb.Append("  EmblemPath: ").Append(EmblemPath).Append("\n");
            sb.Append("  EmblemBackgroundPath: ").Append(EmblemBackgroundPath).Append("\n");
            sb.Append("  EmblemHash: ").Append(EmblemHash).Append("\n");
            sb.Append("  EmblemColor: ").Append(EmblemColor).Append("\n");
            sb.Append("  LevelProgression: ").Append(LevelProgression).Append("\n");
            sb.Append("  BaseCharacterLevel: ").Append(BaseCharacterLevel).Append("\n");
            sb.Append("  PercentToNextLevel: ").Append(PercentToNextLevel).Append("\n");
            sb.Append("  TitleRecordHash: ").Append(TitleRecordHash).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as DestinyEntitiesCharactersDestinyCharacterComponent);
        }

        /// <summary>
        /// Returns true if DestinyEntitiesCharactersDestinyCharacterComponent instances are equal
        /// </summary>
        /// <param name="input">Instance of DestinyEntitiesCharactersDestinyCharacterComponent to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DestinyEntitiesCharactersDestinyCharacterComponent input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.MembershipId == input.MembershipId ||
                    this.MembershipId.Equals(input.MembershipId)
                ) && 
                (
                    this.MembershipType == input.MembershipType ||
                    this.MembershipType.Equals(input.MembershipType)
                ) && 
                (
                    this.CharacterId == input.CharacterId ||
                    this.CharacterId.Equals(input.CharacterId)
                ) && 
                (
                    this.DateLastPlayed == input.DateLastPlayed ||
                    (this.DateLastPlayed != null &&
                    this.DateLastPlayed.Equals(input.DateLastPlayed))
                ) && 
                (
                    this.MinutesPlayedThisSession == input.MinutesPlayedThisSession ||
                    this.MinutesPlayedThisSession.Equals(input.MinutesPlayedThisSession)
                ) && 
                (
                    this.MinutesPlayedTotal == input.MinutesPlayedTotal ||
                    this.MinutesPlayedTotal.Equals(input.MinutesPlayedTotal)
                ) && 
                (
                    this.Light == input.Light ||
                    this.Light.Equals(input.Light)
                ) && 
                (
                    this.Stats == input.Stats ||
                    this.Stats != null &&
                    input.Stats != null &&
                    this.Stats.SequenceEqual(input.Stats)
                ) && 
                (
                    this.RaceHash == input.RaceHash ||
                    this.RaceHash.Equals(input.RaceHash)
                ) && 
                (
                    this.GenderHash == input.GenderHash ||
                    this.GenderHash.Equals(input.GenderHash)
                ) && 
                (
                    this.ClassHash == input.ClassHash ||
                    this.ClassHash.Equals(input.ClassHash)
                ) && 
                (
                    this.RaceType == input.RaceType ||
                    this.RaceType.Equals(input.RaceType)
                ) && 
                (
                    this.ClassType == input.ClassType ||
                    this.ClassType.Equals(input.ClassType)
                ) && 
                (
                    this.GenderType == input.GenderType ||
                    this.GenderType.Equals(input.GenderType)
                ) && 
                (
                    this.EmblemPath == input.EmblemPath ||
                    (this.EmblemPath != null &&
                    this.EmblemPath.Equals(input.EmblemPath))
                ) && 
                (
                    this.EmblemBackgroundPath == input.EmblemBackgroundPath ||
                    (this.EmblemBackgroundPath != null &&
                    this.EmblemBackgroundPath.Equals(input.EmblemBackgroundPath))
                ) && 
                (
                    this.EmblemHash == input.EmblemHash ||
                    this.EmblemHash.Equals(input.EmblemHash)
                ) && 
                (
                    this.EmblemColor == input.EmblemColor ||
                    (this.EmblemColor != null &&
                    this.EmblemColor.Equals(input.EmblemColor))
                ) && 
                (
                    this.LevelProgression == input.LevelProgression ||
                    (this.LevelProgression != null &&
                    this.LevelProgression.Equals(input.LevelProgression))
                ) && 
                (
                    this.BaseCharacterLevel == input.BaseCharacterLevel ||
                    this.BaseCharacterLevel.Equals(input.BaseCharacterLevel)
                ) && 
                (
                    this.PercentToNextLevel == input.PercentToNextLevel ||
                    this.PercentToNextLevel.Equals(input.PercentToNextLevel)
                ) && 
                (
                    this.TitleRecordHash == input.TitleRecordHash ||
                    this.TitleRecordHash.Equals(input.TitleRecordHash)
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                hashCode = hashCode * 59 + this.MembershipId.GetHashCode();
                hashCode = hashCode * 59 + this.MembershipType.GetHashCode();
                hashCode = hashCode * 59 + this.CharacterId.GetHashCode();
                if (this.DateLastPlayed != null)
                    hashCode = hashCode * 59 + this.DateLastPlayed.GetHashCode();
                hashCode = hashCode * 59 + this.MinutesPlayedThisSession.GetHashCode();
                hashCode = hashCode * 59 + this.MinutesPlayedTotal.GetHashCode();
                hashCode = hashCode * 59 + this.Light.GetHashCode();
                if (this.Stats != null)
                    hashCode = hashCode * 59 + this.Stats.GetHashCode();
                hashCode = hashCode * 59 + this.RaceHash.GetHashCode();
                hashCode = hashCode * 59 + this.GenderHash.GetHashCode();
                hashCode = hashCode * 59 + this.ClassHash.GetHashCode();
                hashCode = hashCode * 59 + this.RaceType.GetHashCode();
                hashCode = hashCode * 59 + this.ClassType.GetHashCode();
                hashCode = hashCode * 59 + this.GenderType.GetHashCode();
                if (this.EmblemPath != null)
                    hashCode = hashCode * 59 + this.EmblemPath.GetHashCode();
                if (this.EmblemBackgroundPath != null)
                    hashCode = hashCode * 59 + this.EmblemBackgroundPath.GetHashCode();
                hashCode = hashCode * 59 + this.EmblemHash.GetHashCode();
                if (this.EmblemColor != null)
                    hashCode = hashCode * 59 + this.EmblemColor.GetHashCode();
                if (this.LevelProgression != null)
                    hashCode = hashCode * 59 + this.LevelProgression.GetHashCode();
                hashCode = hashCode * 59 + this.BaseCharacterLevel.GetHashCode();
                hashCode = hashCode * 59 + this.PercentToNextLevel.GetHashCode();
                hashCode = hashCode * 59 + this.TitleRecordHash.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
