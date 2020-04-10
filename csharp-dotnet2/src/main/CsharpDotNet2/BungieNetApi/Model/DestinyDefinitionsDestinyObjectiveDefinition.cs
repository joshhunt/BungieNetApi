using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace BungieNetApi.Model {

  /// <summary>
  /// Defines an \&quot;Objective\&quot;.  An objective is a specific task you should accomplish in the game. These are referred to by:  - Quest Steps (which are DestinyInventoryItemDefinition entities with Objectives)  - Challenges (which are Objectives defined on an DestinyActivityDefintion)  - Milestones (which refer to Objectives that are defined on both Quest Steps and Activities)  - Anything else that the designers decide to do later.  Objectives have progress, a notion of having been Completed, human readable data describing the task to be accomplished, and a lot of optional tack-on data that can enhance the information provided about the task.
  /// </summary>
  [DataContract]
  public class DestinyDefinitionsDestinyObjectiveDefinition {
    /// <summary>
    /// Ideally, this should tell you what your task is. I'm not going to lie to you though. Sometimes this doesn't have useful information at all. Which sucks, but there's nothing either of us can do about it.
    /// </summary>
    /// <value>Ideally, this should tell you what your task is. I'm not going to lie to you though. Sometimes this doesn't have useful information at all. Which sucks, but there's nothing either of us can do about it.</value>
    [DataMember(Name="displayProperties", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "displayProperties")]
    public DestinyDefinitionsCommonDestinyDisplayPropertiesDefinition DisplayProperties { get; set; }

    /// <summary>
    /// The value that the unlock value defined in unlockValueHash must reach in order for the objective to be considered Completed. Used in calculating progress and completion status.
    /// </summary>
    /// <value>The value that the unlock value defined in unlockValueHash must reach in order for the objective to be considered Completed. Used in calculating progress and completion status.</value>
    [DataMember(Name="completionValue", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "completionValue")]
    public int? CompletionValue { get; set; }

    /// <summary>
    /// A shortcut for determining the most restrictive gating that this Objective is set to use. This includes both the dynamic determination of progress and of completion values. See the DestinyGatingScope enum's documentation for more details.
    /// </summary>
    /// <value>A shortcut for determining the most restrictive gating that this Objective is set to use. This includes both the dynamic determination of progress and of completion values. See the DestinyGatingScope enum's documentation for more details.</value>
    [DataMember(Name="scope", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "scope")]
    public int? Scope { get; set; }

    /// <summary>
    /// OPTIONAL: a hash identifier for the location at which this objective must be accomplished, if there is a location defined. Look up the DestinyLocationDefinition for this hash for that additional location info.
    /// </summary>
    /// <value>OPTIONAL: a hash identifier for the location at which this objective must be accomplished, if there is a location defined. Look up the DestinyLocationDefinition for this hash for that additional location info.</value>
    [DataMember(Name="locationHash", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "locationHash")]
    public int? LocationHash { get; set; }

    /// <summary>
    /// If true, the value is allowed to go negative.
    /// </summary>
    /// <value>If true, the value is allowed to go negative.</value>
    [DataMember(Name="allowNegativeValue", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "allowNegativeValue")]
    public bool? AllowNegativeValue { get; set; }

    /// <summary>
    /// If true, you can effectively \"un-complete\" this objective if you lose progress after crossing the completion threshold.   If False, once you complete the task it will remain completed forever by locking the value.
    /// </summary>
    /// <value>If true, you can effectively \"un-complete\" this objective if you lose progress after crossing the completion threshold.   If False, once you complete the task it will remain completed forever by locking the value.</value>
    [DataMember(Name="allowValueChangeWhenCompleted", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "allowValueChangeWhenCompleted")]
    public bool? AllowValueChangeWhenCompleted { get; set; }

    /// <summary>
    /// If true, completion means having an unlock value less than or equal to the completionValue.  If False, completion means having an unlock value greater than or equal to the completionValue.
    /// </summary>
    /// <value>If true, completion means having an unlock value less than or equal to the completionValue.  If False, completion means having an unlock value greater than or equal to the completionValue.</value>
    [DataMember(Name="isCountingDownward", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "isCountingDownward")]
    public bool? IsCountingDownward { get; set; }

    /// <summary>
    /// The UI style applied to the objective. It's an enum, take a look at DestinyUnlockValueUIStyle for details of the possible styles. Use this info as you wish to customize your UI.
    /// </summary>
    /// <value>The UI style applied to the objective. It's an enum, take a look at DestinyUnlockValueUIStyle for details of the possible styles. Use this info as you wish to customize your UI.</value>
    [DataMember(Name="valueStyle", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "valueStyle")]
    public int? ValueStyle { get; set; }

    /// <summary>
    /// Text to describe the progress bar.
    /// </summary>
    /// <value>Text to describe the progress bar.</value>
    [DataMember(Name="progressDescription", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "progressDescription")]
    public string ProgressDescription { get; set; }

    /// <summary>
    /// If this objective enables Perks intrinsically, the conditions for that enabling are defined here.
    /// </summary>
    /// <value>If this objective enables Perks intrinsically, the conditions for that enabling are defined here.</value>
    [DataMember(Name="perks", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "perks")]
    public DestinyDefinitionsDestinyObjectivePerkEntryDefinition Perks { get; set; }

    /// <summary>
    /// If this objective enables modifications on a player's stats intrinsically, the conditions are defined here.
    /// </summary>
    /// <value>If this objective enables modifications on a player's stats intrinsically, the conditions are defined here.</value>
    [DataMember(Name="stats", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "stats")]
    public DestinyDefinitionsDestinyObjectiveStatEntryDefinition Stats { get; set; }

    /// <summary>
    /// If nonzero, this is the minimum value at which the objective's progression should be shown. Otherwise, don't show it yet.
    /// </summary>
    /// <value>If nonzero, this is the minimum value at which the objective's progression should be shown. Otherwise, don't show it yet.</value>
    [DataMember(Name="minimumVisibilityThreshold", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "minimumVisibilityThreshold")]
    public int? MinimumVisibilityThreshold { get; set; }

    /// <summary>
    /// If True, the progress will continue even beyond the point where the objective met its minimum completion requirements. Your UI will have to accommodate it.
    /// </summary>
    /// <value>If True, the progress will continue even beyond the point where the objective met its minimum completion requirements. Your UI will have to accommodate it.</value>
    [DataMember(Name="allowOvercompletion", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "allowOvercompletion")]
    public bool? AllowOvercompletion { get; set; }

    /// <summary>
    /// If True, you should continue showing the progression value in the UI after it's complete. I mean, we already do that in BNet anyways, but if you want to be better behaved than us you could honor this flag.
    /// </summary>
    /// <value>If True, you should continue showing the progression value in the UI after it's complete. I mean, we already do that in BNet anyways, but if you want to be better behaved than us you could honor this flag.</value>
    [DataMember(Name="showValueOnComplete", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "showValueOnComplete")]
    public bool? ShowValueOnComplete { get; set; }

    /// <summary>
    /// The style to use when the objective is completed.
    /// </summary>
    /// <value>The style to use when the objective is completed.</value>
    [DataMember(Name="completedValueStyle", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "completedValueStyle")]
    public int? CompletedValueStyle { get; set; }

    /// <summary>
    /// The style to use when the objective is still in progress.
    /// </summary>
    /// <value>The style to use when the objective is still in progress.</value>
    [DataMember(Name="inProgressValueStyle", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "inProgressValueStyle")]
    public int? InProgressValueStyle { get; set; }

    /// <summary>
    /// The unique identifier for this entity. Guaranteed to be unique for the type of entity, but not globally.  When entities refer to each other in Destiny content, it is this hash that they are referring to.
    /// </summary>
    /// <value>The unique identifier for this entity. Guaranteed to be unique for the type of entity, but not globally.  When entities refer to each other in Destiny content, it is this hash that they are referring to.</value>
    [DataMember(Name="hash", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "hash")]
    public int? Hash { get; set; }

    /// <summary>
    /// The index of the entity as it was found in the investment tables.
    /// </summary>
    /// <value>The index of the entity as it was found in the investment tables.</value>
    [DataMember(Name="index", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "index")]
    public int? Index { get; set; }

    /// <summary>
    /// If this is true, then there is an entity with this identifier/type combination, but BNet is not yet allowed to show it. Sorry!
    /// </summary>
    /// <value>If this is true, then there is an entity with this identifier/type combination, but BNet is not yet allowed to show it. Sorry!</value>
    [DataMember(Name="redacted", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "redacted")]
    public bool? Redacted { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class DestinyDefinitionsDestinyObjectiveDefinition {\n");
      sb.Append("  DisplayProperties: ").Append(DisplayProperties).Append("\n");
      sb.Append("  CompletionValue: ").Append(CompletionValue).Append("\n");
      sb.Append("  Scope: ").Append(Scope).Append("\n");
      sb.Append("  LocationHash: ").Append(LocationHash).Append("\n");
      sb.Append("  AllowNegativeValue: ").Append(AllowNegativeValue).Append("\n");
      sb.Append("  AllowValueChangeWhenCompleted: ").Append(AllowValueChangeWhenCompleted).Append("\n");
      sb.Append("  IsCountingDownward: ").Append(IsCountingDownward).Append("\n");
      sb.Append("  ValueStyle: ").Append(ValueStyle).Append("\n");
      sb.Append("  ProgressDescription: ").Append(ProgressDescription).Append("\n");
      sb.Append("  Perks: ").Append(Perks).Append("\n");
      sb.Append("  Stats: ").Append(Stats).Append("\n");
      sb.Append("  MinimumVisibilityThreshold: ").Append(MinimumVisibilityThreshold).Append("\n");
      sb.Append("  AllowOvercompletion: ").Append(AllowOvercompletion).Append("\n");
      sb.Append("  ShowValueOnComplete: ").Append(ShowValueOnComplete).Append("\n");
      sb.Append("  CompletedValueStyle: ").Append(CompletedValueStyle).Append("\n");
      sb.Append("  InProgressValueStyle: ").Append(InProgressValueStyle).Append("\n");
      sb.Append("  Hash: ").Append(Hash).Append("\n");
      sb.Append("  Index: ").Append(Index).Append("\n");
      sb.Append("  Redacted: ").Append(Redacted).Append("\n");
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
