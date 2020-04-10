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
    /// Milestones are an in-game concept where they&#39;re attempting to tell you what you can do next in-game.  If that sounds a lot like Advisors in Destiny 1, it is! So we threw out Advisors in the Destiny 2 API and tacked all of the data we would have put on Advisors onto Milestones instead.  Each Milestone represents something going on in the game right now:  - A \&quot;ritual activity\&quot; you can perform, like nightfall  - A \&quot;special event\&quot; that may have activities related to it, like Taco Tuesday (there&#39;s no Taco Tuesday in Destiny 2)  - A checklist you can fulfill, like helping your Clan complete all of its weekly objectives  - A tutorial quest you can play through, like the introduction to the Crucible.  Most of these milestones appear in game as well. Some of them are BNet only, because we&#39;re so extra. You&#39;re welcome.  There are some important caveats to understand about how we currently render Milestones and their deficiencies. The game currently doesn&#39;t have any content that actually tells you oughtright *what* the Milestone is: that is to say, what you&#39;ll be doing. The best we get is either a description of the overall Milestone, or of the Quest that the Milestone is having you partake in: which is usually something that assumes you already know what it&#39;s talking about, like \&quot;Complete 5 Challenges\&quot;. 5 Challenges for what? What&#39;s a challenge? These are not questions that the Milestone data will answer for you unfortunately.  This isn&#39;t great, and in the future I&#39;d like to add some custom text to give you more contextual information to pass on to your users. But for now, you can do what we do to render what little display info we do have:  Start by looking at the currently active quest (ideally, you&#39;ve fetched DestinyMilestone or DestinyPublicMilestone data from the API, so you know the currently active quest for the Milestone in question). Look up the Quests property in the Milestone Definition, and check if it has display properties. If it does, show that as the description of the Milestone. If it doesn&#39;t, fall back on the Milestone&#39;s description.  This approach will let you avoid, whenever possible, the even less useful (and sometimes nonexistant) milestone-level names and descriptions.
    /// </summary>
    [DataContract]
    public partial class DestinyDefinitionsMilestonesDestinyMilestoneDefinition :  IEquatable<DestinyDefinitionsMilestonesDestinyMilestoneDefinition>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DestinyDefinitionsMilestonesDestinyMilestoneDefinition" /> class.
        /// </summary>
        /// <param name="displayProperties">displayProperties.</param>
        /// <param name="displayPreference">A hint to the UI to indicate what to show as the display properties for this Milestone when showing \&quot;Live\&quot; milestone data. Feel free to show more than this if desired: this hint is meant to simplify our own UI, but it may prove useful to you as well..</param>
        /// <param name="image">A custom image someone made just for the milestone. Isn&#39;t that special?.</param>
        /// <param name="milestoneType">An enumeration listing one of the possible types of milestones. Check out the DestinyMilestoneType enum for more info!.</param>
        /// <param name="recruitable">If True, then the Milestone has been integrated with BNet&#39;s recruiting feature..</param>
        /// <param name="friendlyName">If the milestone has a friendly identifier for association with other features - such as Recruiting - that identifier can be found here. This is \&quot;friendly\&quot; in that it looks better in a URL than whatever the identifier for the Milestone actually is..</param>
        /// <param name="showInExplorer">If TRUE, this entry should be returned in the list of milestones for the \&quot;Explore Destiny\&quot; (i.e. new BNet homepage) features of Bungie.net (as long as the underlying event is active) Note that this is a property specifically used by BNet and the companion app for the \&quot;Live Events\&quot; feature of the front page/welcome view: it&#39;s not a reflection of what you see in-game..</param>
        /// <param name="showInMilestones">Determines whether we&#39;ll show this Milestone in the user&#39;s personal Milestones list..</param>
        /// <param name="explorePrioritizesActivityImage">If TRUE, \&quot;Explore Destiny\&quot; (the front page of BNet and the companion app) prioritize using the activity image over any overriding Quest or Milestone image provided. This unfortunate hack is brought to you by Trials of The Nine..</param>
        /// <param name="hasPredictableDates">A shortcut for clients - and the server - to understand whether we can predict the start and end dates for this event. In practice, there are multiple ways that an event could have predictable date ranges, but not all events will be able to be predicted via any mechanism (for instance, events that are manually triggered on and off).</param>
        /// <param name="quests">The full set of possible Quests that give the overview of the Milestone event/activity in question. Only one of these can be active at a time for a given Conceptual Milestone, but many of them may be \&quot;available\&quot; for the user to choose from. (for instance, with Milestones you can choose from the three available Quests, but only one can be active at a time) Keyed by the quest item.  As of Forsaken (~September 2018), Quest-style Milestones are being removed for many types of activities. There will likely be further revisions to the Milestone concept in the future..</param>
        /// <param name="rewards">If this milestone can provide rewards, this will define the categories into which the individual reward entries are placed.  This is keyed by the Category&#39;s hash, which is only guaranteed to be unique within a given Milestone..</param>
        /// <param name="vendorsDisplayTitle">If you&#39;re going to show Vendors for the Milestone, you can use this as a localized \&quot;header\&quot; for the section where you show that vendor data. It&#39;ll provide a more context-relevant clue about what the vendor&#39;s role is in the Milestone..</param>
        /// <param name="vendors">Sometimes, milestones will have rewards provided by Vendors. This definition gives the information needed to understand which vendors are relevant, the order in which they should be returned if order matters, and the conditions under which the Vendor is relevant to the user..</param>
        /// <param name="values">Sometimes, milestones will have arbitrary values associated with them that are of interest to us or to third party developers. This is the collection of those values&#39; definitions, keyed by the identifier of the value and providing useful definition information such as localizable names and descriptions for the value..</param>
        /// <param name="isInGameMilestone">Some milestones are explicit objectives that you can see and interact with in the game. Some milestones are more conceptual, built by BNet to help advise you on activities and events that happen in-game but that aren&#39;t explicitly shown in game as Milestones. If this is TRUE, you can see this as a milestone in the game. If this is FALSE, it&#39;s an event or activity you can participate in, but you won&#39;t see it as a Milestone in the game&#39;s UI..</param>
        /// <param name="activities">A Milestone can now be represented by one or more activities directly (without a backing Quest), and that activity can have many challenges, modifiers, and related to it..</param>
        /// <param name="defaultOrder">defaultOrder.</param>
        /// <param name="hash">The unique identifier for this entity. Guaranteed to be unique for the type of entity, but not globally.  When entities refer to each other in Destiny content, it is this hash that they are referring to..</param>
        /// <param name="index">The index of the entity as it was found in the investment tables..</param>
        /// <param name="redacted">If this is true, then there is an entity with this identifier/type combination, but BNet is not yet allowed to show it. Sorry!.</param>
        public DestinyDefinitionsMilestonesDestinyMilestoneDefinition(DestinyDefinitionsCommonDestinyDisplayPropertiesDefinition displayProperties = default(DestinyDefinitionsCommonDestinyDisplayPropertiesDefinition), int displayPreference = default(int), string image = default(string), int milestoneType = default(int), bool recruitable = default(bool), string friendlyName = default(string), bool showInExplorer = default(bool), bool showInMilestones = default(bool), bool explorePrioritizesActivityImage = default(bool), bool hasPredictableDates = default(bool), Dictionary<string, DestinyDefinitionsMilestonesDestinyMilestoneQuestDefinition> quests = default(Dictionary<string, DestinyDefinitionsMilestonesDestinyMilestoneQuestDefinition>), Dictionary<string, DestinyDefinitionsMilestonesDestinyMilestoneRewardCategoryDefinition> rewards = default(Dictionary<string, DestinyDefinitionsMilestonesDestinyMilestoneRewardCategoryDefinition>), string vendorsDisplayTitle = default(string), List<DestinyDefinitionsMilestonesDestinyMilestoneVendorDefinition> vendors = default(List<DestinyDefinitionsMilestonesDestinyMilestoneVendorDefinition>), Dictionary<string, DestinyDefinitionsMilestonesDestinyMilestoneValueDefinition> values = default(Dictionary<string, DestinyDefinitionsMilestonesDestinyMilestoneValueDefinition>), bool isInGameMilestone = default(bool), List<DestinyDefinitionsMilestonesDestinyMilestoneChallengeActivityDefinition> activities = default(List<DestinyDefinitionsMilestonesDestinyMilestoneChallengeActivityDefinition>), int defaultOrder = default(int), int hash = default(int), int index = default(int), bool redacted = default(bool))
        {
            this.DisplayProperties = displayProperties;
            this.DisplayPreference = displayPreference;
            this.Image = image;
            this.MilestoneType = milestoneType;
            this.Recruitable = recruitable;
            this.FriendlyName = friendlyName;
            this.ShowInExplorer = showInExplorer;
            this.ShowInMilestones = showInMilestones;
            this.ExplorePrioritizesActivityImage = explorePrioritizesActivityImage;
            this.HasPredictableDates = hasPredictableDates;
            this.Quests = quests;
            this.Rewards = rewards;
            this.VendorsDisplayTitle = vendorsDisplayTitle;
            this.Vendors = vendors;
            this.Values = values;
            this.IsInGameMilestone = isInGameMilestone;
            this.Activities = activities;
            this.DefaultOrder = defaultOrder;
            this.Hash = hash;
            this.Index = index;
            this.Redacted = redacted;
        }
        
        /// <summary>
        /// Gets or Sets DisplayProperties
        /// </summary>
        [DataMember(Name="displayProperties", EmitDefaultValue=false)]
        public DestinyDefinitionsCommonDestinyDisplayPropertiesDefinition DisplayProperties { get; set; }

        /// <summary>
        /// A hint to the UI to indicate what to show as the display properties for this Milestone when showing \&quot;Live\&quot; milestone data. Feel free to show more than this if desired: this hint is meant to simplify our own UI, but it may prove useful to you as well.
        /// </summary>
        /// <value>A hint to the UI to indicate what to show as the display properties for this Milestone when showing \&quot;Live\&quot; milestone data. Feel free to show more than this if desired: this hint is meant to simplify our own UI, but it may prove useful to you as well.</value>
        [DataMember(Name="displayPreference", EmitDefaultValue=false)]
        public int DisplayPreference { get; set; }

        /// <summary>
        /// A custom image someone made just for the milestone. Isn&#39;t that special?
        /// </summary>
        /// <value>A custom image someone made just for the milestone. Isn&#39;t that special?</value>
        [DataMember(Name="image", EmitDefaultValue=false)]
        public string Image { get; set; }

        /// <summary>
        /// An enumeration listing one of the possible types of milestones. Check out the DestinyMilestoneType enum for more info!
        /// </summary>
        /// <value>An enumeration listing one of the possible types of milestones. Check out the DestinyMilestoneType enum for more info!</value>
        [DataMember(Name="milestoneType", EmitDefaultValue=false)]
        public int MilestoneType { get; set; }

        /// <summary>
        /// If True, then the Milestone has been integrated with BNet&#39;s recruiting feature.
        /// </summary>
        /// <value>If True, then the Milestone has been integrated with BNet&#39;s recruiting feature.</value>
        [DataMember(Name="recruitable", EmitDefaultValue=false)]
        public bool Recruitable { get; set; }

        /// <summary>
        /// If the milestone has a friendly identifier for association with other features - such as Recruiting - that identifier can be found here. This is \&quot;friendly\&quot; in that it looks better in a URL than whatever the identifier for the Milestone actually is.
        /// </summary>
        /// <value>If the milestone has a friendly identifier for association with other features - such as Recruiting - that identifier can be found here. This is \&quot;friendly\&quot; in that it looks better in a URL than whatever the identifier for the Milestone actually is.</value>
        [DataMember(Name="friendlyName", EmitDefaultValue=false)]
        public string FriendlyName { get; set; }

        /// <summary>
        /// If TRUE, this entry should be returned in the list of milestones for the \&quot;Explore Destiny\&quot; (i.e. new BNet homepage) features of Bungie.net (as long as the underlying event is active) Note that this is a property specifically used by BNet and the companion app for the \&quot;Live Events\&quot; feature of the front page/welcome view: it&#39;s not a reflection of what you see in-game.
        /// </summary>
        /// <value>If TRUE, this entry should be returned in the list of milestones for the \&quot;Explore Destiny\&quot; (i.e. new BNet homepage) features of Bungie.net (as long as the underlying event is active) Note that this is a property specifically used by BNet and the companion app for the \&quot;Live Events\&quot; feature of the front page/welcome view: it&#39;s not a reflection of what you see in-game.</value>
        [DataMember(Name="showInExplorer", EmitDefaultValue=false)]
        public bool ShowInExplorer { get; set; }

        /// <summary>
        /// Determines whether we&#39;ll show this Milestone in the user&#39;s personal Milestones list.
        /// </summary>
        /// <value>Determines whether we&#39;ll show this Milestone in the user&#39;s personal Milestones list.</value>
        [DataMember(Name="showInMilestones", EmitDefaultValue=false)]
        public bool ShowInMilestones { get; set; }

        /// <summary>
        /// If TRUE, \&quot;Explore Destiny\&quot; (the front page of BNet and the companion app) prioritize using the activity image over any overriding Quest or Milestone image provided. This unfortunate hack is brought to you by Trials of The Nine.
        /// </summary>
        /// <value>If TRUE, \&quot;Explore Destiny\&quot; (the front page of BNet and the companion app) prioritize using the activity image over any overriding Quest or Milestone image provided. This unfortunate hack is brought to you by Trials of The Nine.</value>
        [DataMember(Name="explorePrioritizesActivityImage", EmitDefaultValue=false)]
        public bool ExplorePrioritizesActivityImage { get; set; }

        /// <summary>
        /// A shortcut for clients - and the server - to understand whether we can predict the start and end dates for this event. In practice, there are multiple ways that an event could have predictable date ranges, but not all events will be able to be predicted via any mechanism (for instance, events that are manually triggered on and off)
        /// </summary>
        /// <value>A shortcut for clients - and the server - to understand whether we can predict the start and end dates for this event. In practice, there are multiple ways that an event could have predictable date ranges, but not all events will be able to be predicted via any mechanism (for instance, events that are manually triggered on and off)</value>
        [DataMember(Name="hasPredictableDates", EmitDefaultValue=false)]
        public bool HasPredictableDates { get; set; }

        /// <summary>
        /// The full set of possible Quests that give the overview of the Milestone event/activity in question. Only one of these can be active at a time for a given Conceptual Milestone, but many of them may be \&quot;available\&quot; for the user to choose from. (for instance, with Milestones you can choose from the three available Quests, but only one can be active at a time) Keyed by the quest item.  As of Forsaken (~September 2018), Quest-style Milestones are being removed for many types of activities. There will likely be further revisions to the Milestone concept in the future.
        /// </summary>
        /// <value>The full set of possible Quests that give the overview of the Milestone event/activity in question. Only one of these can be active at a time for a given Conceptual Milestone, but many of them may be \&quot;available\&quot; for the user to choose from. (for instance, with Milestones you can choose from the three available Quests, but only one can be active at a time) Keyed by the quest item.  As of Forsaken (~September 2018), Quest-style Milestones are being removed for many types of activities. There will likely be further revisions to the Milestone concept in the future.</value>
        [DataMember(Name="quests", EmitDefaultValue=false)]
        public Dictionary<string, DestinyDefinitionsMilestonesDestinyMilestoneQuestDefinition> Quests { get; set; }

        /// <summary>
        /// If this milestone can provide rewards, this will define the categories into which the individual reward entries are placed.  This is keyed by the Category&#39;s hash, which is only guaranteed to be unique within a given Milestone.
        /// </summary>
        /// <value>If this milestone can provide rewards, this will define the categories into which the individual reward entries are placed.  This is keyed by the Category&#39;s hash, which is only guaranteed to be unique within a given Milestone.</value>
        [DataMember(Name="rewards", EmitDefaultValue=false)]
        public Dictionary<string, DestinyDefinitionsMilestonesDestinyMilestoneRewardCategoryDefinition> Rewards { get; set; }

        /// <summary>
        /// If you&#39;re going to show Vendors for the Milestone, you can use this as a localized \&quot;header\&quot; for the section where you show that vendor data. It&#39;ll provide a more context-relevant clue about what the vendor&#39;s role is in the Milestone.
        /// </summary>
        /// <value>If you&#39;re going to show Vendors for the Milestone, you can use this as a localized \&quot;header\&quot; for the section where you show that vendor data. It&#39;ll provide a more context-relevant clue about what the vendor&#39;s role is in the Milestone.</value>
        [DataMember(Name="vendorsDisplayTitle", EmitDefaultValue=false)]
        public string VendorsDisplayTitle { get; set; }

        /// <summary>
        /// Sometimes, milestones will have rewards provided by Vendors. This definition gives the information needed to understand which vendors are relevant, the order in which they should be returned if order matters, and the conditions under which the Vendor is relevant to the user.
        /// </summary>
        /// <value>Sometimes, milestones will have rewards provided by Vendors. This definition gives the information needed to understand which vendors are relevant, the order in which they should be returned if order matters, and the conditions under which the Vendor is relevant to the user.</value>
        [DataMember(Name="vendors", EmitDefaultValue=false)]
        public List<DestinyDefinitionsMilestonesDestinyMilestoneVendorDefinition> Vendors { get; set; }

        /// <summary>
        /// Sometimes, milestones will have arbitrary values associated with them that are of interest to us or to third party developers. This is the collection of those values&#39; definitions, keyed by the identifier of the value and providing useful definition information such as localizable names and descriptions for the value.
        /// </summary>
        /// <value>Sometimes, milestones will have arbitrary values associated with them that are of interest to us or to third party developers. This is the collection of those values&#39; definitions, keyed by the identifier of the value and providing useful definition information such as localizable names and descriptions for the value.</value>
        [DataMember(Name="values", EmitDefaultValue=false)]
        public Dictionary<string, DestinyDefinitionsMilestonesDestinyMilestoneValueDefinition> Values { get; set; }

        /// <summary>
        /// Some milestones are explicit objectives that you can see and interact with in the game. Some milestones are more conceptual, built by BNet to help advise you on activities and events that happen in-game but that aren&#39;t explicitly shown in game as Milestones. If this is TRUE, you can see this as a milestone in the game. If this is FALSE, it&#39;s an event or activity you can participate in, but you won&#39;t see it as a Milestone in the game&#39;s UI.
        /// </summary>
        /// <value>Some milestones are explicit objectives that you can see and interact with in the game. Some milestones are more conceptual, built by BNet to help advise you on activities and events that happen in-game but that aren&#39;t explicitly shown in game as Milestones. If this is TRUE, you can see this as a milestone in the game. If this is FALSE, it&#39;s an event or activity you can participate in, but you won&#39;t see it as a Milestone in the game&#39;s UI.</value>
        [DataMember(Name="isInGameMilestone", EmitDefaultValue=false)]
        public bool IsInGameMilestone { get; set; }

        /// <summary>
        /// A Milestone can now be represented by one or more activities directly (without a backing Quest), and that activity can have many challenges, modifiers, and related to it.
        /// </summary>
        /// <value>A Milestone can now be represented by one or more activities directly (without a backing Quest), and that activity can have many challenges, modifiers, and related to it.</value>
        [DataMember(Name="activities", EmitDefaultValue=false)]
        public List<DestinyDefinitionsMilestonesDestinyMilestoneChallengeActivityDefinition> Activities { get; set; }

        /// <summary>
        /// Gets or Sets DefaultOrder
        /// </summary>
        [DataMember(Name="defaultOrder", EmitDefaultValue=false)]
        public int DefaultOrder { get; set; }

        /// <summary>
        /// The unique identifier for this entity. Guaranteed to be unique for the type of entity, but not globally.  When entities refer to each other in Destiny content, it is this hash that they are referring to.
        /// </summary>
        /// <value>The unique identifier for this entity. Guaranteed to be unique for the type of entity, but not globally.  When entities refer to each other in Destiny content, it is this hash that they are referring to.</value>
        [DataMember(Name="hash", EmitDefaultValue=false)]
        public int Hash { get; set; }

        /// <summary>
        /// The index of the entity as it was found in the investment tables.
        /// </summary>
        /// <value>The index of the entity as it was found in the investment tables.</value>
        [DataMember(Name="index", EmitDefaultValue=false)]
        public int Index { get; set; }

        /// <summary>
        /// If this is true, then there is an entity with this identifier/type combination, but BNet is not yet allowed to show it. Sorry!
        /// </summary>
        /// <value>If this is true, then there is an entity with this identifier/type combination, but BNet is not yet allowed to show it. Sorry!</value>
        [DataMember(Name="redacted", EmitDefaultValue=false)]
        public bool Redacted { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DestinyDefinitionsMilestonesDestinyMilestoneDefinition {\n");
            sb.Append("  DisplayProperties: ").Append(DisplayProperties).Append("\n");
            sb.Append("  DisplayPreference: ").Append(DisplayPreference).Append("\n");
            sb.Append("  Image: ").Append(Image).Append("\n");
            sb.Append("  MilestoneType: ").Append(MilestoneType).Append("\n");
            sb.Append("  Recruitable: ").Append(Recruitable).Append("\n");
            sb.Append("  FriendlyName: ").Append(FriendlyName).Append("\n");
            sb.Append("  ShowInExplorer: ").Append(ShowInExplorer).Append("\n");
            sb.Append("  ShowInMilestones: ").Append(ShowInMilestones).Append("\n");
            sb.Append("  ExplorePrioritizesActivityImage: ").Append(ExplorePrioritizesActivityImage).Append("\n");
            sb.Append("  HasPredictableDates: ").Append(HasPredictableDates).Append("\n");
            sb.Append("  Quests: ").Append(Quests).Append("\n");
            sb.Append("  Rewards: ").Append(Rewards).Append("\n");
            sb.Append("  VendorsDisplayTitle: ").Append(VendorsDisplayTitle).Append("\n");
            sb.Append("  Vendors: ").Append(Vendors).Append("\n");
            sb.Append("  Values: ").Append(Values).Append("\n");
            sb.Append("  IsInGameMilestone: ").Append(IsInGameMilestone).Append("\n");
            sb.Append("  Activities: ").Append(Activities).Append("\n");
            sb.Append("  DefaultOrder: ").Append(DefaultOrder).Append("\n");
            sb.Append("  Hash: ").Append(Hash).Append("\n");
            sb.Append("  Index: ").Append(Index).Append("\n");
            sb.Append("  Redacted: ").Append(Redacted).Append("\n");
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
            return this.Equals(input as DestinyDefinitionsMilestonesDestinyMilestoneDefinition);
        }

        /// <summary>
        /// Returns true if DestinyDefinitionsMilestonesDestinyMilestoneDefinition instances are equal
        /// </summary>
        /// <param name="input">Instance of DestinyDefinitionsMilestonesDestinyMilestoneDefinition to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DestinyDefinitionsMilestonesDestinyMilestoneDefinition input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.DisplayProperties == input.DisplayProperties ||
                    (this.DisplayProperties != null &&
                    this.DisplayProperties.Equals(input.DisplayProperties))
                ) && 
                (
                    this.DisplayPreference == input.DisplayPreference ||
                    this.DisplayPreference.Equals(input.DisplayPreference)
                ) && 
                (
                    this.Image == input.Image ||
                    (this.Image != null &&
                    this.Image.Equals(input.Image))
                ) && 
                (
                    this.MilestoneType == input.MilestoneType ||
                    this.MilestoneType.Equals(input.MilestoneType)
                ) && 
                (
                    this.Recruitable == input.Recruitable ||
                    this.Recruitable.Equals(input.Recruitable)
                ) && 
                (
                    this.FriendlyName == input.FriendlyName ||
                    (this.FriendlyName != null &&
                    this.FriendlyName.Equals(input.FriendlyName))
                ) && 
                (
                    this.ShowInExplorer == input.ShowInExplorer ||
                    this.ShowInExplorer.Equals(input.ShowInExplorer)
                ) && 
                (
                    this.ShowInMilestones == input.ShowInMilestones ||
                    this.ShowInMilestones.Equals(input.ShowInMilestones)
                ) && 
                (
                    this.ExplorePrioritizesActivityImage == input.ExplorePrioritizesActivityImage ||
                    this.ExplorePrioritizesActivityImage.Equals(input.ExplorePrioritizesActivityImage)
                ) && 
                (
                    this.HasPredictableDates == input.HasPredictableDates ||
                    this.HasPredictableDates.Equals(input.HasPredictableDates)
                ) && 
                (
                    this.Quests == input.Quests ||
                    this.Quests != null &&
                    input.Quests != null &&
                    this.Quests.SequenceEqual(input.Quests)
                ) && 
                (
                    this.Rewards == input.Rewards ||
                    this.Rewards != null &&
                    input.Rewards != null &&
                    this.Rewards.SequenceEqual(input.Rewards)
                ) && 
                (
                    this.VendorsDisplayTitle == input.VendorsDisplayTitle ||
                    (this.VendorsDisplayTitle != null &&
                    this.VendorsDisplayTitle.Equals(input.VendorsDisplayTitle))
                ) && 
                (
                    this.Vendors == input.Vendors ||
                    this.Vendors != null &&
                    input.Vendors != null &&
                    this.Vendors.SequenceEqual(input.Vendors)
                ) && 
                (
                    this.Values == input.Values ||
                    this.Values != null &&
                    input.Values != null &&
                    this.Values.SequenceEqual(input.Values)
                ) && 
                (
                    this.IsInGameMilestone == input.IsInGameMilestone ||
                    this.IsInGameMilestone.Equals(input.IsInGameMilestone)
                ) && 
                (
                    this.Activities == input.Activities ||
                    this.Activities != null &&
                    input.Activities != null &&
                    this.Activities.SequenceEqual(input.Activities)
                ) && 
                (
                    this.DefaultOrder == input.DefaultOrder ||
                    this.DefaultOrder.Equals(input.DefaultOrder)
                ) && 
                (
                    this.Hash == input.Hash ||
                    this.Hash.Equals(input.Hash)
                ) && 
                (
                    this.Index == input.Index ||
                    this.Index.Equals(input.Index)
                ) && 
                (
                    this.Redacted == input.Redacted ||
                    this.Redacted.Equals(input.Redacted)
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
                if (this.DisplayProperties != null)
                    hashCode = hashCode * 59 + this.DisplayProperties.GetHashCode();
                hashCode = hashCode * 59 + this.DisplayPreference.GetHashCode();
                if (this.Image != null)
                    hashCode = hashCode * 59 + this.Image.GetHashCode();
                hashCode = hashCode * 59 + this.MilestoneType.GetHashCode();
                hashCode = hashCode * 59 + this.Recruitable.GetHashCode();
                if (this.FriendlyName != null)
                    hashCode = hashCode * 59 + this.FriendlyName.GetHashCode();
                hashCode = hashCode * 59 + this.ShowInExplorer.GetHashCode();
                hashCode = hashCode * 59 + this.ShowInMilestones.GetHashCode();
                hashCode = hashCode * 59 + this.ExplorePrioritizesActivityImage.GetHashCode();
                hashCode = hashCode * 59 + this.HasPredictableDates.GetHashCode();
                if (this.Quests != null)
                    hashCode = hashCode * 59 + this.Quests.GetHashCode();
                if (this.Rewards != null)
                    hashCode = hashCode * 59 + this.Rewards.GetHashCode();
                if (this.VendorsDisplayTitle != null)
                    hashCode = hashCode * 59 + this.VendorsDisplayTitle.GetHashCode();
                if (this.Vendors != null)
                    hashCode = hashCode * 59 + this.Vendors.GetHashCode();
                if (this.Values != null)
                    hashCode = hashCode * 59 + this.Values.GetHashCode();
                hashCode = hashCode * 59 + this.IsInGameMilestone.GetHashCode();
                if (this.Activities != null)
                    hashCode = hashCode * 59 + this.Activities.GetHashCode();
                hashCode = hashCode * 59 + this.DefaultOrder.GetHashCode();
                hashCode = hashCode * 59 + this.Hash.GetHashCode();
                hashCode = hashCode * 59 + this.Index.GetHashCode();
                hashCode = hashCode * 59 + this.Redacted.GetHashCode();
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
