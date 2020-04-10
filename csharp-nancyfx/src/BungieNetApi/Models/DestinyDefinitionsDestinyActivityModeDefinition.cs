using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Sharpility.Extensions;
using NodaTime;

namespace BungieNetApi._Platform.Models
{
    /// <summary>
    /// This definition represents an \&quot;Activity Mode\&quot; as it exists in the Historical Stats endpoints. An individual Activity Mode represents a collection of activities that are played in a certain way. For example, Nightfall Strikes are part of a \&quot;Nightfall\&quot; activity mode, and any activities played as the PVP mode \&quot;Clash\&quot; are part of the \&quot;Clash activity mode.  Activity modes are nested under each other in a hierarchy, so that if you ask for - for example - \&quot;AllPvP\&quot;, you will get any PVP activities that the user has played, regardless of what specific PVP mode was being played.
    /// </summary>
    public sealed class DestinyDefinitionsDestinyActivityModeDefinition:  IEquatable<DestinyDefinitionsDestinyActivityModeDefinition>
    { 
        /// <summary>
        /// DisplayProperties
        /// </summary>
        public DestinyDefinitionsCommonDestinyDisplayPropertiesDefinition DisplayProperties { get; private set; }

        /// <summary>
        /// If this activity mode has a related PGCR image, this will be the path to said image.
        /// </summary>
        public string PgcrImage { get; private set; }

        /// <summary>
        /// The Enumeration value for this Activity Mode. Pass this identifier into Stats endpoints to get aggregate stats for this mode.
        /// </summary>
        public int? ModeType { get; private set; }

        /// <summary>
        /// The type of play being performed in broad terms (PVP, PVE)
        /// </summary>
        public int? ActivityModeCategory { get; private set; }

        /// <summary>
        /// If True, this mode has oppositional teams fighting against each other rather than \&quot;Free-For-All\&quot; or Co-operative modes of play.  Note that Aggregate modes are never marked as team based, even if they happen to be team based at the moment. At any time, an aggregate whose subordinates are only team based could be changed so that one or more aren&#39;t team based, and then this boolean won&#39;t make much sense (the aggregation would become \&quot;sometimes team based\&quot;). Let&#39;s not deal with that right now.
        /// </summary>
        public bool? IsTeamBased { get; private set; }

        /// <summary>
        /// If true, this mode is an aggregation of other, more specific modes rather than being a mode in itself. This includes modes that group Features/Events rather than Gameplay, such as Trials of The Nine: Trials of the Nine being an Event that is interesting to see aggregate data for, but when you play the activities within Trials of the Nine they are more specific activity modes such as Clash.
        /// </summary>
        public bool? IsAggregateMode { get; private set; }

        /// <summary>
        /// The hash identifiers of the DestinyActivityModeDefinitions that represent all of the \&quot;parent\&quot; modes for this mode. For instance, the Nightfall Mode is also a member of AllStrikes and AllPvE.
        /// </summary>
        public List<int?> ParentHashes { get; private set; }

        /// <summary>
        /// A Friendly identifier you can use for referring to this Activity Mode. We really only used this in our URLs, so... you know, take that for whatever it&#39;s worth.
        /// </summary>
        public string FriendlyName { get; private set; }

        /// <summary>
        /// If this exists, the mode has specific Activities (referred to by the Key) that should instead map to other Activity Modes when they are played. This was useful in D1 for Private Matches, where we wanted to have Private Matches as an activity mode while still referring to the specific mode being played.
        /// </summary>
        public Dictionary<string, int?> ActivityModeMappings { get; private set; }

        /// <summary>
        /// If FALSE, we want to ignore this type when we&#39;re showing activity modes in BNet UI. It will still be returned in case 3rd parties want to use it for any purpose.
        /// </summary>
        public bool? Display { get; private set; }

        /// <summary>
        /// The relative ordering of activity modes.
        /// </summary>
        public int? Order { get; private set; }

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
        /// Use DestinyDefinitionsDestinyActivityModeDefinition.Builder() for instance creation instead.
        /// </summary>
        [Obsolete]
        public DestinyDefinitionsDestinyActivityModeDefinition()
        {
        }

        private DestinyDefinitionsDestinyActivityModeDefinition(DestinyDefinitionsCommonDestinyDisplayPropertiesDefinition DisplayProperties, string PgcrImage, int? ModeType, int? ActivityModeCategory, bool? IsTeamBased, bool? IsAggregateMode, List<int?> ParentHashes, string FriendlyName, Dictionary<string, int?> ActivityModeMappings, bool? Display, int? Order, int? Hash, int? Index, bool? Redacted)
        {
            
            this.DisplayProperties = DisplayProperties;
            
            this.PgcrImage = PgcrImage;
            
            this.ModeType = ModeType;
            
            this.ActivityModeCategory = ActivityModeCategory;
            
            this.IsTeamBased = IsTeamBased;
            
            this.IsAggregateMode = IsAggregateMode;
            
            this.ParentHashes = ParentHashes;
            
            this.FriendlyName = FriendlyName;
            
            this.ActivityModeMappings = ActivityModeMappings;
            
            this.Display = Display;
            
            this.Order = Order;
            
            this.Hash = Hash;
            
            this.Index = Index;
            
            this.Redacted = Redacted;
            
        }

        /// <summary>
        /// Returns builder of DestinyDefinitionsDestinyActivityModeDefinition.
        /// </summary>
        /// <returns>DestinyDefinitionsDestinyActivityModeDefinitionBuilder</returns>
        public static DestinyDefinitionsDestinyActivityModeDefinitionBuilder Builder()
        {
            return new DestinyDefinitionsDestinyActivityModeDefinitionBuilder();
        }

        /// <summary>
        /// Returns DestinyDefinitionsDestinyActivityModeDefinitionBuilder with properties set.
        /// Use it to change properties.
        /// </summary>
        /// <returns>DestinyDefinitionsDestinyActivityModeDefinitionBuilder</returns>
        public DestinyDefinitionsDestinyActivityModeDefinitionBuilder With()
        {
            return Builder()
                .DisplayProperties(DisplayProperties)
                .PgcrImage(PgcrImage)
                .ModeType(ModeType)
                .ActivityModeCategory(ActivityModeCategory)
                .IsTeamBased(IsTeamBased)
                .IsAggregateMode(IsAggregateMode)
                .ParentHashes(ParentHashes)
                .FriendlyName(FriendlyName)
                .ActivityModeMappings(ActivityModeMappings)
                .Display(Display)
                .Order(Order)
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

        public bool Equals(DestinyDefinitionsDestinyActivityModeDefinition other)
        {
            return Equals((object) other);
        }

        public override int GetHashCode()
        {
            return this.PropertiesHash();
        }

        /// <summary>
        /// Implementation of == operator for (DestinyDefinitionsDestinyActivityModeDefinition.
        /// </summary>
        /// <param name="left">Compared (DestinyDefinitionsDestinyActivityModeDefinition</param>
        /// <param name="right">Compared (DestinyDefinitionsDestinyActivityModeDefinition</param>
        /// <returns>true if compared items are equals, false otherwise</returns>
        public static bool operator == (DestinyDefinitionsDestinyActivityModeDefinition left, DestinyDefinitionsDestinyActivityModeDefinition right)
        {
            return Equals(left, right);
        }

        /// <summary>
        /// Implementation of != operator for (DestinyDefinitionsDestinyActivityModeDefinition.
        /// </summary>
        /// <param name="left">Compared (DestinyDefinitionsDestinyActivityModeDefinition</param>
        /// <param name="right">Compared (DestinyDefinitionsDestinyActivityModeDefinition</param>
        /// <returns>true if compared items are not equals, false otherwise</returns>
        public static bool operator != (DestinyDefinitionsDestinyActivityModeDefinition left, DestinyDefinitionsDestinyActivityModeDefinition right)
        {
            return !Equals(left, right);
        }

        /// <summary>
        /// Builder of DestinyDefinitionsDestinyActivityModeDefinition.
        /// </summary>
        public sealed class DestinyDefinitionsDestinyActivityModeDefinitionBuilder
        {
            private DestinyDefinitionsCommonDestinyDisplayPropertiesDefinition _DisplayProperties;
            private string _PgcrImage;
            private int? _ModeType;
            private int? _ActivityModeCategory;
            private bool? _IsTeamBased;
            private bool? _IsAggregateMode;
            private List<int?> _ParentHashes;
            private string _FriendlyName;
            private Dictionary<string, int?> _ActivityModeMappings;
            private bool? _Display;
            private int? _Order;
            private int? _Hash;
            private int? _Index;
            private bool? _Redacted;

            internal DestinyDefinitionsDestinyActivityModeDefinitionBuilder()
            {
                SetupDefaults();
            }

            private void SetupDefaults()
            {
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsDestinyActivityModeDefinition.DisplayProperties property.
            /// </summary>
            /// <param name="value">DisplayProperties</param>
            public DestinyDefinitionsDestinyActivityModeDefinitionBuilder DisplayProperties(DestinyDefinitionsCommonDestinyDisplayPropertiesDefinition value)
            {
                _DisplayProperties = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsDestinyActivityModeDefinition.PgcrImage property.
            /// </summary>
            /// <param name="value">If this activity mode has a related PGCR image, this will be the path to said image.</param>
            public DestinyDefinitionsDestinyActivityModeDefinitionBuilder PgcrImage(string value)
            {
                _PgcrImage = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsDestinyActivityModeDefinition.ModeType property.
            /// </summary>
            /// <param name="value">The Enumeration value for this Activity Mode. Pass this identifier into Stats endpoints to get aggregate stats for this mode.</param>
            public DestinyDefinitionsDestinyActivityModeDefinitionBuilder ModeType(int? value)
            {
                _ModeType = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsDestinyActivityModeDefinition.ActivityModeCategory property.
            /// </summary>
            /// <param name="value">The type of play being performed in broad terms (PVP, PVE)</param>
            public DestinyDefinitionsDestinyActivityModeDefinitionBuilder ActivityModeCategory(int? value)
            {
                _ActivityModeCategory = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsDestinyActivityModeDefinition.IsTeamBased property.
            /// </summary>
            /// <param name="value">If True, this mode has oppositional teams fighting against each other rather than \&quot;Free-For-All\&quot; or Co-operative modes of play.  Note that Aggregate modes are never marked as team based, even if they happen to be team based at the moment. At any time, an aggregate whose subordinates are only team based could be changed so that one or more aren&#39;t team based, and then this boolean won&#39;t make much sense (the aggregation would become \&quot;sometimes team based\&quot;). Let&#39;s not deal with that right now.</param>
            public DestinyDefinitionsDestinyActivityModeDefinitionBuilder IsTeamBased(bool? value)
            {
                _IsTeamBased = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsDestinyActivityModeDefinition.IsAggregateMode property.
            /// </summary>
            /// <param name="value">If true, this mode is an aggregation of other, more specific modes rather than being a mode in itself. This includes modes that group Features/Events rather than Gameplay, such as Trials of The Nine: Trials of the Nine being an Event that is interesting to see aggregate data for, but when you play the activities within Trials of the Nine they are more specific activity modes such as Clash.</param>
            public DestinyDefinitionsDestinyActivityModeDefinitionBuilder IsAggregateMode(bool? value)
            {
                _IsAggregateMode = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsDestinyActivityModeDefinition.ParentHashes property.
            /// </summary>
            /// <param name="value">The hash identifiers of the DestinyActivityModeDefinitions that represent all of the \&quot;parent\&quot; modes for this mode. For instance, the Nightfall Mode is also a member of AllStrikes and AllPvE.</param>
            public DestinyDefinitionsDestinyActivityModeDefinitionBuilder ParentHashes(List<int?> value)
            {
                _ParentHashes = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsDestinyActivityModeDefinition.FriendlyName property.
            /// </summary>
            /// <param name="value">A Friendly identifier you can use for referring to this Activity Mode. We really only used this in our URLs, so... you know, take that for whatever it&#39;s worth.</param>
            public DestinyDefinitionsDestinyActivityModeDefinitionBuilder FriendlyName(string value)
            {
                _FriendlyName = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsDestinyActivityModeDefinition.ActivityModeMappings property.
            /// </summary>
            /// <param name="value">If this exists, the mode has specific Activities (referred to by the Key) that should instead map to other Activity Modes when they are played. This was useful in D1 for Private Matches, where we wanted to have Private Matches as an activity mode while still referring to the specific mode being played.</param>
            public DestinyDefinitionsDestinyActivityModeDefinitionBuilder ActivityModeMappings(Dictionary<string, int?> value)
            {
                _ActivityModeMappings = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsDestinyActivityModeDefinition.Display property.
            /// </summary>
            /// <param name="value">If FALSE, we want to ignore this type when we&#39;re showing activity modes in BNet UI. It will still be returned in case 3rd parties want to use it for any purpose.</param>
            public DestinyDefinitionsDestinyActivityModeDefinitionBuilder Display(bool? value)
            {
                _Display = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsDestinyActivityModeDefinition.Order property.
            /// </summary>
            /// <param name="value">The relative ordering of activity modes.</param>
            public DestinyDefinitionsDestinyActivityModeDefinitionBuilder Order(int? value)
            {
                _Order = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsDestinyActivityModeDefinition.Hash property.
            /// </summary>
            /// <param name="value">The unique identifier for this entity. Guaranteed to be unique for the type of entity, but not globally.  When entities refer to each other in Destiny content, it is this hash that they are referring to.</param>
            public DestinyDefinitionsDestinyActivityModeDefinitionBuilder Hash(int? value)
            {
                _Hash = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsDestinyActivityModeDefinition.Index property.
            /// </summary>
            /// <param name="value">The index of the entity as it was found in the investment tables.</param>
            public DestinyDefinitionsDestinyActivityModeDefinitionBuilder Index(int? value)
            {
                _Index = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsDestinyActivityModeDefinition.Redacted property.
            /// </summary>
            /// <param name="value">If this is true, then there is an entity with this identifier/type combination, but BNet is not yet allowed to show it. Sorry!</param>
            public DestinyDefinitionsDestinyActivityModeDefinitionBuilder Redacted(bool? value)
            {
                _Redacted = value;
                return this;
            }


            /// <summary>
            /// Builds instance of DestinyDefinitionsDestinyActivityModeDefinition.
            /// </summary>
            /// <returns>DestinyDefinitionsDestinyActivityModeDefinition</returns>
            public DestinyDefinitionsDestinyActivityModeDefinition Build()
            {
                Validate();
                return new DestinyDefinitionsDestinyActivityModeDefinition(
                    DisplayProperties: _DisplayProperties,
                    PgcrImage: _PgcrImage,
                    ModeType: _ModeType,
                    ActivityModeCategory: _ActivityModeCategory,
                    IsTeamBased: _IsTeamBased,
                    IsAggregateMode: _IsAggregateMode,
                    ParentHashes: _ParentHashes,
                    FriendlyName: _FriendlyName,
                    ActivityModeMappings: _ActivityModeMappings,
                    Display: _Display,
                    Order: _Order,
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