using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Sharpility.Extensions;
using NodaTime;

namespace BungieNetApi._Platform.Models
{
    /// <summary>
    /// Milestones are an in-game concept where they&#39;re attempting to tell you what you can do next in-game.  If that sounds a lot like Advisors in Destiny 1, it is! So we threw out Advisors in the Destiny 2 API and tacked all of the data we would have put on Advisors onto Milestones instead.  Each Milestone represents something going on in the game right now:  - A \&quot;ritual activity\&quot; you can perform, like nightfall  - A \&quot;special event\&quot; that may have activities related to it, like Taco Tuesday (there&#39;s no Taco Tuesday in Destiny 2)  - A checklist you can fulfill, like helping your Clan complete all of its weekly objectives  - A tutorial quest you can play through, like the introduction to the Crucible.  Most of these milestones appear in game as well. Some of them are BNet only, because we&#39;re so extra. You&#39;re welcome.  There are some important caveats to understand about how we currently render Milestones and their deficiencies. The game currently doesn&#39;t have any content that actually tells you oughtright *what* the Milestone is: that is to say, what you&#39;ll be doing. The best we get is either a description of the overall Milestone, or of the Quest that the Milestone is having you partake in: which is usually something that assumes you already know what it&#39;s talking about, like \&quot;Complete 5 Challenges\&quot;. 5 Challenges for what? What&#39;s a challenge? These are not questions that the Milestone data will answer for you unfortunately.  This isn&#39;t great, and in the future I&#39;d like to add some custom text to give you more contextual information to pass on to your users. But for now, you can do what we do to render what little display info we do have:  Start by looking at the currently active quest (ideally, you&#39;ve fetched DestinyMilestone or DestinyPublicMilestone data from the API, so you know the currently active quest for the Milestone in question). Look up the Quests property in the Milestone Definition, and check if it has display properties. If it does, show that as the description of the Milestone. If it doesn&#39;t, fall back on the Milestone&#39;s description.  This approach will let you avoid, whenever possible, the even less useful (and sometimes nonexistant) milestone-level names and descriptions.
    /// </summary>
    public sealed class DestinyDefinitionsMilestonesDestinyMilestoneDefinition:  IEquatable<DestinyDefinitionsMilestonesDestinyMilestoneDefinition>
    { 
        /// <summary>
        /// DisplayProperties
        /// </summary>
        public DestinyDefinitionsCommonDestinyDisplayPropertiesDefinition DisplayProperties { get; private set; }

        /// <summary>
        /// A hint to the UI to indicate what to show as the display properties for this Milestone when showing \&quot;Live\&quot; milestone data. Feel free to show more than this if desired: this hint is meant to simplify our own UI, but it may prove useful to you as well.
        /// </summary>
        public int? DisplayPreference { get; private set; }

        /// <summary>
        /// A custom image someone made just for the milestone. Isn&#39;t that special?
        /// </summary>
        public string Image { get; private set; }

        /// <summary>
        /// An enumeration listing one of the possible types of milestones. Check out the DestinyMilestoneType enum for more info!
        /// </summary>
        public int? MilestoneType { get; private set; }

        /// <summary>
        /// If True, then the Milestone has been integrated with BNet&#39;s recruiting feature.
        /// </summary>
        public bool? Recruitable { get; private set; }

        /// <summary>
        /// If the milestone has a friendly identifier for association with other features - such as Recruiting - that identifier can be found here. This is \&quot;friendly\&quot; in that it looks better in a URL than whatever the identifier for the Milestone actually is.
        /// </summary>
        public string FriendlyName { get; private set; }

        /// <summary>
        /// If TRUE, this entry should be returned in the list of milestones for the \&quot;Explore Destiny\&quot; (i.e. new BNet homepage) features of Bungie.net (as long as the underlying event is active) Note that this is a property specifically used by BNet and the companion app for the \&quot;Live Events\&quot; feature of the front page/welcome view: it&#39;s not a reflection of what you see in-game.
        /// </summary>
        public bool? ShowInExplorer { get; private set; }

        /// <summary>
        /// Determines whether we&#39;ll show this Milestone in the user&#39;s personal Milestones list.
        /// </summary>
        public bool? ShowInMilestones { get; private set; }

        /// <summary>
        /// If TRUE, \&quot;Explore Destiny\&quot; (the front page of BNet and the companion app) prioritize using the activity image over any overriding Quest or Milestone image provided. This unfortunate hack is brought to you by Trials of The Nine.
        /// </summary>
        public bool? ExplorePrioritizesActivityImage { get; private set; }

        /// <summary>
        /// A shortcut for clients - and the server - to understand whether we can predict the start and end dates for this event. In practice, there are multiple ways that an event could have predictable date ranges, but not all events will be able to be predicted via any mechanism (for instance, events that are manually triggered on and off)
        /// </summary>
        public bool? HasPredictableDates { get; private set; }

        /// <summary>
        /// The full set of possible Quests that give the overview of the Milestone event/activity in question. Only one of these can be active at a time for a given Conceptual Milestone, but many of them may be \&quot;available\&quot; for the user to choose from. (for instance, with Milestones you can choose from the three available Quests, but only one can be active at a time) Keyed by the quest item.  As of Forsaken (~September 2018), Quest-style Milestones are being removed for many types of activities. There will likely be further revisions to the Milestone concept in the future.
        /// </summary>
        public Dictionary<string, DestinyDefinitionsMilestonesDestinyMilestoneQuestDefinition> Quests { get; private set; }

        /// <summary>
        /// If this milestone can provide rewards, this will define the categories into which the individual reward entries are placed.  This is keyed by the Category&#39;s hash, which is only guaranteed to be unique within a given Milestone.
        /// </summary>
        public Dictionary<string, DestinyDefinitionsMilestonesDestinyMilestoneRewardCategoryDefinition> Rewards { get; private set; }

        /// <summary>
        /// If you&#39;re going to show Vendors for the Milestone, you can use this as a localized \&quot;header\&quot; for the section where you show that vendor data. It&#39;ll provide a more context-relevant clue about what the vendor&#39;s role is in the Milestone.
        /// </summary>
        public string VendorsDisplayTitle { get; private set; }

        /// <summary>
        /// Sometimes, milestones will have rewards provided by Vendors. This definition gives the information needed to understand which vendors are relevant, the order in which they should be returned if order matters, and the conditions under which the Vendor is relevant to the user.
        /// </summary>
        public List<DestinyDefinitionsMilestonesDestinyMilestoneVendorDefinition> Vendors { get; private set; }

        /// <summary>
        /// Sometimes, milestones will have arbitrary values associated with them that are of interest to us or to third party developers. This is the collection of those values&#39; definitions, keyed by the identifier of the value and providing useful definition information such as localizable names and descriptions for the value.
        /// </summary>
        public Dictionary<string, DestinyDefinitionsMilestonesDestinyMilestoneValueDefinition> Values { get; private set; }

        /// <summary>
        /// Some milestones are explicit objectives that you can see and interact with in the game. Some milestones are more conceptual, built by BNet to help advise you on activities and events that happen in-game but that aren&#39;t explicitly shown in game as Milestones. If this is TRUE, you can see this as a milestone in the game. If this is FALSE, it&#39;s an event or activity you can participate in, but you won&#39;t see it as a Milestone in the game&#39;s UI.
        /// </summary>
        public bool? IsInGameMilestone { get; private set; }

        /// <summary>
        /// A Milestone can now be represented by one or more activities directly (without a backing Quest), and that activity can have many challenges, modifiers, and related to it.
        /// </summary>
        public List<DestinyDefinitionsMilestonesDestinyMilestoneChallengeActivityDefinition> Activities { get; private set; }

        /// <summary>
        /// DefaultOrder
        /// </summary>
        public int? DefaultOrder { get; private set; }

        /// <summary>
        /// The unique identifier for this entity. Guaranteed to be unique for the type of entity, but not globally.  When entities refer to each other in Destiny content, it is this hash that they are referring to.
        /// </summary>
        public int? Hash { get; private set; }

        /// <summary>
        /// The index of the entity as it was found in the investment tables.
        /// </summary>
        public int? Index { get; private set; }

        /// <summary>
        /// If this is true, then there is an entity with this identifier/type combination, but BNet is not yet allowed to show it. Sorry!
        /// </summary>
        public bool? Redacted { get; private set; }


        /// <summary>
        /// Empty constructor required by some serializers.
        /// Use DestinyDefinitionsMilestonesDestinyMilestoneDefinition.Builder() for instance creation instead.
        /// </summary>
        [Obsolete]
        public DestinyDefinitionsMilestonesDestinyMilestoneDefinition()
        {
        }

        private DestinyDefinitionsMilestonesDestinyMilestoneDefinition(DestinyDefinitionsCommonDestinyDisplayPropertiesDefinition DisplayProperties, int? DisplayPreference, string Image, int? MilestoneType, bool? Recruitable, string FriendlyName, bool? ShowInExplorer, bool? ShowInMilestones, bool? ExplorePrioritizesActivityImage, bool? HasPredictableDates, Dictionary<string, DestinyDefinitionsMilestonesDestinyMilestoneQuestDefinition> Quests, Dictionary<string, DestinyDefinitionsMilestonesDestinyMilestoneRewardCategoryDefinition> Rewards, string VendorsDisplayTitle, List<DestinyDefinitionsMilestonesDestinyMilestoneVendorDefinition> Vendors, Dictionary<string, DestinyDefinitionsMilestonesDestinyMilestoneValueDefinition> Values, bool? IsInGameMilestone, List<DestinyDefinitionsMilestonesDestinyMilestoneChallengeActivityDefinition> Activities, int? DefaultOrder, int? Hash, int? Index, bool? Redacted)
        {
            
            this.DisplayProperties = DisplayProperties;
            
            this.DisplayPreference = DisplayPreference;
            
            this.Image = Image;
            
            this.MilestoneType = MilestoneType;
            
            this.Recruitable = Recruitable;
            
            this.FriendlyName = FriendlyName;
            
            this.ShowInExplorer = ShowInExplorer;
            
            this.ShowInMilestones = ShowInMilestones;
            
            this.ExplorePrioritizesActivityImage = ExplorePrioritizesActivityImage;
            
            this.HasPredictableDates = HasPredictableDates;
            
            this.Quests = Quests;
            
            this.Rewards = Rewards;
            
            this.VendorsDisplayTitle = VendorsDisplayTitle;
            
            this.Vendors = Vendors;
            
            this.Values = Values;
            
            this.IsInGameMilestone = IsInGameMilestone;
            
            this.Activities = Activities;
            
            this.DefaultOrder = DefaultOrder;
            
            this.Hash = Hash;
            
            this.Index = Index;
            
            this.Redacted = Redacted;
            
        }

        /// <summary>
        /// Returns builder of DestinyDefinitionsMilestonesDestinyMilestoneDefinition.
        /// </summary>
        /// <returns>DestinyDefinitionsMilestonesDestinyMilestoneDefinitionBuilder</returns>
        public static DestinyDefinitionsMilestonesDestinyMilestoneDefinitionBuilder Builder()
        {
            return new DestinyDefinitionsMilestonesDestinyMilestoneDefinitionBuilder();
        }

        /// <summary>
        /// Returns DestinyDefinitionsMilestonesDestinyMilestoneDefinitionBuilder with properties set.
        /// Use it to change properties.
        /// </summary>
        /// <returns>DestinyDefinitionsMilestonesDestinyMilestoneDefinitionBuilder</returns>
        public DestinyDefinitionsMilestonesDestinyMilestoneDefinitionBuilder With()
        {
            return Builder()
                .DisplayProperties(DisplayProperties)
                .DisplayPreference(DisplayPreference)
                .Image(Image)
                .MilestoneType(MilestoneType)
                .Recruitable(Recruitable)
                .FriendlyName(FriendlyName)
                .ShowInExplorer(ShowInExplorer)
                .ShowInMilestones(ShowInMilestones)
                .ExplorePrioritizesActivityImage(ExplorePrioritizesActivityImage)
                .HasPredictableDates(HasPredictableDates)
                .Quests(Quests)
                .Rewards(Rewards)
                .VendorsDisplayTitle(VendorsDisplayTitle)
                .Vendors(Vendors)
                .Values(Values)
                .IsInGameMilestone(IsInGameMilestone)
                .Activities(Activities)
                .DefaultOrder(DefaultOrder)
                .Hash(Hash)
                .Index(Index)
                .Redacted(Redacted);
        }

        public override string ToString()
        {
            return this.PropertiesToString();
        }

        public override bool Equals(object obj)
        {
            return this.EqualsByProperties(obj);
        }

        public bool Equals(DestinyDefinitionsMilestonesDestinyMilestoneDefinition other)
        {
            return Equals((object) other);
        }

        public override int GetHashCode()
        {
            return this.PropertiesHash();
        }

        /// <summary>
        /// Implementation of == operator for (DestinyDefinitionsMilestonesDestinyMilestoneDefinition.
        /// </summary>
        /// <param name="left">Compared (DestinyDefinitionsMilestonesDestinyMilestoneDefinition</param>
        /// <param name="right">Compared (DestinyDefinitionsMilestonesDestinyMilestoneDefinition</param>
        /// <returns>true if compared items are equals, false otherwise</returns>
        public static bool operator == (DestinyDefinitionsMilestonesDestinyMilestoneDefinition left, DestinyDefinitionsMilestonesDestinyMilestoneDefinition right)
        {
            return Equals(left, right);
        }

        /// <summary>
        /// Implementation of != operator for (DestinyDefinitionsMilestonesDestinyMilestoneDefinition.
        /// </summary>
        /// <param name="left">Compared (DestinyDefinitionsMilestonesDestinyMilestoneDefinition</param>
        /// <param name="right">Compared (DestinyDefinitionsMilestonesDestinyMilestoneDefinition</param>
        /// <returns>true if compared items are not equals, false otherwise</returns>
        public static bool operator != (DestinyDefinitionsMilestonesDestinyMilestoneDefinition left, DestinyDefinitionsMilestonesDestinyMilestoneDefinition right)
        {
            return !Equals(left, right);
        }

        /// <summary>
        /// Builder of DestinyDefinitionsMilestonesDestinyMilestoneDefinition.
        /// </summary>
        public sealed class DestinyDefinitionsMilestonesDestinyMilestoneDefinitionBuilder
        {
            private DestinyDefinitionsCommonDestinyDisplayPropertiesDefinition _DisplayProperties;
            private int? _DisplayPreference;
            private string _Image;
            private int? _MilestoneType;
            private bool? _Recruitable;
            private string _FriendlyName;
            private bool? _ShowInExplorer;
            private bool? _ShowInMilestones;
            private bool? _ExplorePrioritizesActivityImage;
            private bool? _HasPredictableDates;
            private Dictionary<string, DestinyDefinitionsMilestonesDestinyMilestoneQuestDefinition> _Quests;
            private Dictionary<string, DestinyDefinitionsMilestonesDestinyMilestoneRewardCategoryDefinition> _Rewards;
            private string _VendorsDisplayTitle;
            private List<DestinyDefinitionsMilestonesDestinyMilestoneVendorDefinition> _Vendors;
            private Dictionary<string, DestinyDefinitionsMilestonesDestinyMilestoneValueDefinition> _Values;
            private bool? _IsInGameMilestone;
            private List<DestinyDefinitionsMilestonesDestinyMilestoneChallengeActivityDefinition> _Activities;
            private int? _DefaultOrder;
            private int? _Hash;
            private int? _Index;
            private bool? _Redacted;

            internal DestinyDefinitionsMilestonesDestinyMilestoneDefinitionBuilder()
            {
                SetupDefaults();
            }

            private void SetupDefaults()
            {
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsMilestonesDestinyMilestoneDefinition.DisplayProperties property.
            /// </summary>
            /// <param name="value">DisplayProperties</param>
            public DestinyDefinitionsMilestonesDestinyMilestoneDefinitionBuilder DisplayProperties(DestinyDefinitionsCommonDestinyDisplayPropertiesDefinition value)
            {
                _DisplayProperties = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsMilestonesDestinyMilestoneDefinition.DisplayPreference property.
            /// </summary>
            /// <param name="value">A hint to the UI to indicate what to show as the display properties for this Milestone when showing \&quot;Live\&quot; milestone data. Feel free to show more than this if desired: this hint is meant to simplify our own UI, but it may prove useful to you as well.</param>
            public DestinyDefinitionsMilestonesDestinyMilestoneDefinitionBuilder DisplayPreference(int? value)
            {
                _DisplayPreference = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsMilestonesDestinyMilestoneDefinition.Image property.
            /// </summary>
            /// <param name="value">A custom image someone made just for the milestone. Isn&#39;t that special?</param>
            public DestinyDefinitionsMilestonesDestinyMilestoneDefinitionBuilder Image(string value)
            {
                _Image = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsMilestonesDestinyMilestoneDefinition.MilestoneType property.
            /// </summary>
            /// <param name="value">An enumeration listing one of the possible types of milestones. Check out the DestinyMilestoneType enum for more info!</param>
            public DestinyDefinitionsMilestonesDestinyMilestoneDefinitionBuilder MilestoneType(int? value)
            {
                _MilestoneType = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsMilestonesDestinyMilestoneDefinition.Recruitable property.
            /// </summary>
            /// <param name="value">If True, then the Milestone has been integrated with BNet&#39;s recruiting feature.</param>
            public DestinyDefinitionsMilestonesDestinyMilestoneDefinitionBuilder Recruitable(bool? value)
            {
                _Recruitable = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsMilestonesDestinyMilestoneDefinition.FriendlyName property.
            /// </summary>
            /// <param name="value">If the milestone has a friendly identifier for association with other features - such as Recruiting - that identifier can be found here. This is \&quot;friendly\&quot; in that it looks better in a URL than whatever the identifier for the Milestone actually is.</param>
            public DestinyDefinitionsMilestonesDestinyMilestoneDefinitionBuilder FriendlyName(string value)
            {
                _FriendlyName = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsMilestonesDestinyMilestoneDefinition.ShowInExplorer property.
            /// </summary>
            /// <param name="value">If TRUE, this entry should be returned in the list of milestones for the \&quot;Explore Destiny\&quot; (i.e. new BNet homepage) features of Bungie.net (as long as the underlying event is active) Note that this is a property specifically used by BNet and the companion app for the \&quot;Live Events\&quot; feature of the front page/welcome view: it&#39;s not a reflection of what you see in-game.</param>
            public DestinyDefinitionsMilestonesDestinyMilestoneDefinitionBuilder ShowInExplorer(bool? value)
            {
                _ShowInExplorer = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsMilestonesDestinyMilestoneDefinition.ShowInMilestones property.
            /// </summary>
            /// <param name="value">Determines whether we&#39;ll show this Milestone in the user&#39;s personal Milestones list.</param>
            public DestinyDefinitionsMilestonesDestinyMilestoneDefinitionBuilder ShowInMilestones(bool? value)
            {
                _ShowInMilestones = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsMilestonesDestinyMilestoneDefinition.ExplorePrioritizesActivityImage property.
            /// </summary>
            /// <param name="value">If TRUE, \&quot;Explore Destiny\&quot; (the front page of BNet and the companion app) prioritize using the activity image over any overriding Quest or Milestone image provided. This unfortunate hack is brought to you by Trials of The Nine.</param>
            public DestinyDefinitionsMilestonesDestinyMilestoneDefinitionBuilder ExplorePrioritizesActivityImage(bool? value)
            {
                _ExplorePrioritizesActivityImage = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsMilestonesDestinyMilestoneDefinition.HasPredictableDates property.
            /// </summary>
            /// <param name="value">A shortcut for clients - and the server - to understand whether we can predict the start and end dates for this event. In practice, there are multiple ways that an event could have predictable date ranges, but not all events will be able to be predicted via any mechanism (for instance, events that are manually triggered on and off)</param>
            public DestinyDefinitionsMilestonesDestinyMilestoneDefinitionBuilder HasPredictableDates(bool? value)
            {
                _HasPredictableDates = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsMilestonesDestinyMilestoneDefinition.Quests property.
            /// </summary>
            /// <param name="value">The full set of possible Quests that give the overview of the Milestone event/activity in question. Only one of these can be active at a time for a given Conceptual Milestone, but many of them may be \&quot;available\&quot; for the user to choose from. (for instance, with Milestones you can choose from the three available Quests, but only one can be active at a time) Keyed by the quest item.  As of Forsaken (~September 2018), Quest-style Milestones are being removed for many types of activities. There will likely be further revisions to the Milestone concept in the future.</param>
            public DestinyDefinitionsMilestonesDestinyMilestoneDefinitionBuilder Quests(Dictionary<string, DestinyDefinitionsMilestonesDestinyMilestoneQuestDefinition> value)
            {
                _Quests = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsMilestonesDestinyMilestoneDefinition.Rewards property.
            /// </summary>
            /// <param name="value">If this milestone can provide rewards, this will define the categories into which the individual reward entries are placed.  This is keyed by the Category&#39;s hash, which is only guaranteed to be unique within a given Milestone.</param>
            public DestinyDefinitionsMilestonesDestinyMilestoneDefinitionBuilder Rewards(Dictionary<string, DestinyDefinitionsMilestonesDestinyMilestoneRewardCategoryDefinition> value)
            {
                _Rewards = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsMilestonesDestinyMilestoneDefinition.VendorsDisplayTitle property.
            /// </summary>
            /// <param name="value">If you&#39;re going to show Vendors for the Milestone, you can use this as a localized \&quot;header\&quot; for the section where you show that vendor data. It&#39;ll provide a more context-relevant clue about what the vendor&#39;s role is in the Milestone.</param>
            public DestinyDefinitionsMilestonesDestinyMilestoneDefinitionBuilder VendorsDisplayTitle(string value)
            {
                _VendorsDisplayTitle = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsMilestonesDestinyMilestoneDefinition.Vendors property.
            /// </summary>
            /// <param name="value">Sometimes, milestones will have rewards provided by Vendors. This definition gives the information needed to understand which vendors are relevant, the order in which they should be returned if order matters, and the conditions under which the Vendor is relevant to the user.</param>
            public DestinyDefinitionsMilestonesDestinyMilestoneDefinitionBuilder Vendors(List<DestinyDefinitionsMilestonesDestinyMilestoneVendorDefinition> value)
            {
                _Vendors = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsMilestonesDestinyMilestoneDefinition.Values property.
            /// </summary>
            /// <param name="value">Sometimes, milestones will have arbitrary values associated with them that are of interest to us or to third party developers. This is the collection of those values&#39; definitions, keyed by the identifier of the value and providing useful definition information such as localizable names and descriptions for the value.</param>
            public DestinyDefinitionsMilestonesDestinyMilestoneDefinitionBuilder Values(Dictionary<string, DestinyDefinitionsMilestonesDestinyMilestoneValueDefinition> value)
            {
                _Values = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsMilestonesDestinyMilestoneDefinition.IsInGameMilestone property.
            /// </summary>
            /// <param name="value">Some milestones are explicit objectives that you can see and interact with in the game. Some milestones are more conceptual, built by BNet to help advise you on activities and events that happen in-game but that aren&#39;t explicitly shown in game as Milestones. If this is TRUE, you can see this as a milestone in the game. If this is FALSE, it&#39;s an event or activity you can participate in, but you won&#39;t see it as a Milestone in the game&#39;s UI.</param>
            public DestinyDefinitionsMilestonesDestinyMilestoneDefinitionBuilder IsInGameMilestone(bool? value)
            {
                _IsInGameMilestone = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsMilestonesDestinyMilestoneDefinition.Activities property.
            /// </summary>
            /// <param name="value">A Milestone can now be represented by one or more activities directly (without a backing Quest), and that activity can have many challenges, modifiers, and related to it.</param>
            public DestinyDefinitionsMilestonesDestinyMilestoneDefinitionBuilder Activities(List<DestinyDefinitionsMilestonesDestinyMilestoneChallengeActivityDefinition> value)
            {
                _Activities = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsMilestonesDestinyMilestoneDefinition.DefaultOrder property.
            /// </summary>
            /// <param name="value">DefaultOrder</param>
            public DestinyDefinitionsMilestonesDestinyMilestoneDefinitionBuilder DefaultOrder(int? value)
            {
                _DefaultOrder = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsMilestonesDestinyMilestoneDefinition.Hash property.
            /// </summary>
            /// <param name="value">The unique identifier for this entity. Guaranteed to be unique for the type of entity, but not globally.  When entities refer to each other in Destiny content, it is this hash that they are referring to.</param>
            public DestinyDefinitionsMilestonesDestinyMilestoneDefinitionBuilder Hash(int? value)
            {
                _Hash = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsMilestonesDestinyMilestoneDefinition.Index property.
            /// </summary>
            /// <param name="value">The index of the entity as it was found in the investment tables.</param>
            public DestinyDefinitionsMilestonesDestinyMilestoneDefinitionBuilder Index(int? value)
            {
                _Index = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsMilestonesDestinyMilestoneDefinition.Redacted property.
            /// </summary>
            /// <param name="value">If this is true, then there is an entity with this identifier/type combination, but BNet is not yet allowed to show it. Sorry!</param>
            public DestinyDefinitionsMilestonesDestinyMilestoneDefinitionBuilder Redacted(bool? value)
            {
                _Redacted = value;
                return this;
            }


            /// <summary>
            /// Builds instance of DestinyDefinitionsMilestonesDestinyMilestoneDefinition.
            /// </summary>
            /// <returns>DestinyDefinitionsMilestonesDestinyMilestoneDefinition</returns>
            public DestinyDefinitionsMilestonesDestinyMilestoneDefinition Build()
            {
                Validate();
                return new DestinyDefinitionsMilestonesDestinyMilestoneDefinition(
                    DisplayProperties: _DisplayProperties,
                    DisplayPreference: _DisplayPreference,
                    Image: _Image,
                    MilestoneType: _MilestoneType,
                    Recruitable: _Recruitable,
                    FriendlyName: _FriendlyName,
                    ShowInExplorer: _ShowInExplorer,
                    ShowInMilestones: _ShowInMilestones,
                    ExplorePrioritizesActivityImage: _ExplorePrioritizesActivityImage,
                    HasPredictableDates: _HasPredictableDates,
                    Quests: _Quests,
                    Rewards: _Rewards,
                    VendorsDisplayTitle: _VendorsDisplayTitle,
                    Vendors: _Vendors,
                    Values: _Values,
                    IsInGameMilestone: _IsInGameMilestone,
                    Activities: _Activities,
                    DefaultOrder: _DefaultOrder,
                    Hash: _Hash,
                    Index: _Index,
                    Redacted: _Redacted
                );
            }

            private void Validate()
            { 
            }
        }

        
    }
}