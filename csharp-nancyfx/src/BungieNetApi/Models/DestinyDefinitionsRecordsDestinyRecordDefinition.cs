using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Sharpility.Extensions;
using NodaTime;

namespace BungieNetApi._Platform.Models
{
    /// <summary>
    /// DestinyDefinitionsRecordsDestinyRecordDefinition
    /// </summary>
    public sealed class DestinyDefinitionsRecordsDestinyRecordDefinition:  IEquatable<DestinyDefinitionsRecordsDestinyRecordDefinition>
    { 
        /// <summary>
        /// DisplayProperties
        /// </summary>
        public DestinyDefinitionsCommonDestinyDisplayPropertiesDefinition DisplayProperties { get; private set; }

        /// <summary>
        /// Indicates whether this Record&#39;s state is determined on a per-character or on an account-wide basis.
        /// </summary>
        public int? Scope { get; private set; }

        /// <summary>
        /// PresentationInfo
        /// </summary>
        public DestinyDefinitionsPresentationDestinyPresentationChildBlock PresentationInfo { get; private set; }

        /// <summary>
        /// LoreHash
        /// </summary>
        public int? LoreHash { get; private set; }

        /// <summary>
        /// ObjectiveHashes
        /// </summary>
        public List<int?> ObjectiveHashes { get; private set; }

        /// <summary>
        /// RecordValueStyle
        /// </summary>
        public int? RecordValueStyle { get; private set; }

        /// <summary>
        /// TitleInfo
        /// </summary>
        public DestinyDefinitionsRecordsDestinyRecordTitleBlock TitleInfo { get; private set; }

        /// <summary>
        /// CompletionInfo
        /// </summary>
        public DestinyDefinitionsRecordsDestinyRecordCompletionBlock CompletionInfo { get; private set; }

        /// <summary>
        /// StateInfo
        /// </summary>
        public DestinyDefinitionsRecordsSchemaRecordStateBlock StateInfo { get; private set; }

        /// <summary>
        /// Requirements
        /// </summary>
        public DestinyDefinitionsPresentationDestinyPresentationNodeRequirementsBlock Requirements { get; private set; }

        /// <summary>
        /// ExpirationInfo
        /// </summary>
        public DestinyDefinitionsRecordsDestinyRecordExpirationBlock ExpirationInfo { get; private set; }

        /// <summary>
        /// Some records have multiple &#39;interval&#39; objectives, and the record may be claimed at each completed interval
        /// </summary>
        public DestinyDefinitionsRecordsDestinyRecordIntervalBlock IntervalInfo { get; private set; }

        /// <summary>
        /// If there is any publicly available information about rewards earned for achieving this record, this is the list of those items.   However, note that some records intentionally have \&quot;hidden\&quot; rewards. These will not be returned in this list.
        /// </summary>
        public List<DestinyDestinyItemQuantity> RewardItems { get; private set; }

        /// <summary>
        /// PresentationNodeType
        /// </summary>
        public int? PresentationNodeType { get; private set; }

        /// <summary>
        /// TraitIds
        /// </summary>
        public List<string> TraitIds { get; private set; }

        /// <summary>
        /// TraitHashes
        /// </summary>
        public List<int?> TraitHashes { get; private set; }

        /// <summary>
        /// A quick reference to presentation nodes that have this node as a child. Presentation nodes can be parented under multiple parents.
        /// </summary>
        public List<int?> ParentNodeHashes { get; private set; }

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
        /// Use DestinyDefinitionsRecordsDestinyRecordDefinition.Builder() for instance creation instead.
        /// </summary>
        [Obsolete]
        public DestinyDefinitionsRecordsDestinyRecordDefinition()
        {
        }

        private DestinyDefinitionsRecordsDestinyRecordDefinition(DestinyDefinitionsCommonDestinyDisplayPropertiesDefinition DisplayProperties, int? Scope, DestinyDefinitionsPresentationDestinyPresentationChildBlock PresentationInfo, int? LoreHash, List<int?> ObjectiveHashes, int? RecordValueStyle, DestinyDefinitionsRecordsDestinyRecordTitleBlock TitleInfo, DestinyDefinitionsRecordsDestinyRecordCompletionBlock CompletionInfo, DestinyDefinitionsRecordsSchemaRecordStateBlock StateInfo, DestinyDefinitionsPresentationDestinyPresentationNodeRequirementsBlock Requirements, DestinyDefinitionsRecordsDestinyRecordExpirationBlock ExpirationInfo, DestinyDefinitionsRecordsDestinyRecordIntervalBlock IntervalInfo, List<DestinyDestinyItemQuantity> RewardItems, int? PresentationNodeType, List<string> TraitIds, List<int?> TraitHashes, List<int?> ParentNodeHashes, int? Hash, int? Index, bool? Redacted)
        {
            
            this.DisplayProperties = DisplayProperties;
            
            this.Scope = Scope;
            
            this.PresentationInfo = PresentationInfo;
            
            this.LoreHash = LoreHash;
            
            this.ObjectiveHashes = ObjectiveHashes;
            
            this.RecordValueStyle = RecordValueStyle;
            
            this.TitleInfo = TitleInfo;
            
            this.CompletionInfo = CompletionInfo;
            
            this.StateInfo = StateInfo;
            
            this.Requirements = Requirements;
            
            this.ExpirationInfo = ExpirationInfo;
            
            this.IntervalInfo = IntervalInfo;
            
            this.RewardItems = RewardItems;
            
            this.PresentationNodeType = PresentationNodeType;
            
            this.TraitIds = TraitIds;
            
            this.TraitHashes = TraitHashes;
            
            this.ParentNodeHashes = ParentNodeHashes;
            
            this.Hash = Hash;
            
            this.Index = Index;
            
            this.Redacted = Redacted;
            
        }

        /// <summary>
        /// Returns builder of DestinyDefinitionsRecordsDestinyRecordDefinition.
        /// </summary>
        /// <returns>DestinyDefinitionsRecordsDestinyRecordDefinitionBuilder</returns>
        public static DestinyDefinitionsRecordsDestinyRecordDefinitionBuilder Builder()
        {
            return new DestinyDefinitionsRecordsDestinyRecordDefinitionBuilder();
        }

        /// <summary>
        /// Returns DestinyDefinitionsRecordsDestinyRecordDefinitionBuilder with properties set.
        /// Use it to change properties.
        /// </summary>
        /// <returns>DestinyDefinitionsRecordsDestinyRecordDefinitionBuilder</returns>
        public DestinyDefinitionsRecordsDestinyRecordDefinitionBuilder With()
        {
            return Builder()
                .DisplayProperties(DisplayProperties)
                .Scope(Scope)
                .PresentationInfo(PresentationInfo)
                .LoreHash(LoreHash)
                .ObjectiveHashes(ObjectiveHashes)
                .RecordValueStyle(RecordValueStyle)
                .TitleInfo(TitleInfo)
                .CompletionInfo(CompletionInfo)
                .StateInfo(StateInfo)
                .Requirements(Requirements)
                .ExpirationInfo(ExpirationInfo)
                .IntervalInfo(IntervalInfo)
                .RewardItems(RewardItems)
                .PresentationNodeType(PresentationNodeType)
                .TraitIds(TraitIds)
                .TraitHashes(TraitHashes)
                .ParentNodeHashes(ParentNodeHashes)
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

        public bool Equals(DestinyDefinitionsRecordsDestinyRecordDefinition other)
        {
            return Equals((object) other);
        }

        public override int GetHashCode()
        {
            return this.PropertiesHash();
        }

        /// <summary>
        /// Implementation of == operator for (DestinyDefinitionsRecordsDestinyRecordDefinition.
        /// </summary>
        /// <param name="left">Compared (DestinyDefinitionsRecordsDestinyRecordDefinition</param>
        /// <param name="right">Compared (DestinyDefinitionsRecordsDestinyRecordDefinition</param>
        /// <returns>true if compared items are equals, false otherwise</returns>
        public static bool operator == (DestinyDefinitionsRecordsDestinyRecordDefinition left, DestinyDefinitionsRecordsDestinyRecordDefinition right)
        {
            return Equals(left, right);
        }

        /// <summary>
        /// Implementation of != operator for (DestinyDefinitionsRecordsDestinyRecordDefinition.
        /// </summary>
        /// <param name="left">Compared (DestinyDefinitionsRecordsDestinyRecordDefinition</param>
        /// <param name="right">Compared (DestinyDefinitionsRecordsDestinyRecordDefinition</param>
        /// <returns>true if compared items are not equals, false otherwise</returns>
        public static bool operator != (DestinyDefinitionsRecordsDestinyRecordDefinition left, DestinyDefinitionsRecordsDestinyRecordDefinition right)
        {
            return !Equals(left, right);
        }

        /// <summary>
        /// Builder of DestinyDefinitionsRecordsDestinyRecordDefinition.
        /// </summary>
        public sealed class DestinyDefinitionsRecordsDestinyRecordDefinitionBuilder
        {
            private DestinyDefinitionsCommonDestinyDisplayPropertiesDefinition _DisplayProperties;
            private int? _Scope;
            private DestinyDefinitionsPresentationDestinyPresentationChildBlock _PresentationInfo;
            private int? _LoreHash;
            private List<int?> _ObjectiveHashes;
            private int? _RecordValueStyle;
            private DestinyDefinitionsRecordsDestinyRecordTitleBlock _TitleInfo;
            private DestinyDefinitionsRecordsDestinyRecordCompletionBlock _CompletionInfo;
            private DestinyDefinitionsRecordsSchemaRecordStateBlock _StateInfo;
            private DestinyDefinitionsPresentationDestinyPresentationNodeRequirementsBlock _Requirements;
            private DestinyDefinitionsRecordsDestinyRecordExpirationBlock _ExpirationInfo;
            private DestinyDefinitionsRecordsDestinyRecordIntervalBlock _IntervalInfo;
            private List<DestinyDestinyItemQuantity> _RewardItems;
            private int? _PresentationNodeType;
            private List<string> _TraitIds;
            private List<int?> _TraitHashes;
            private List<int?> _ParentNodeHashes;
            private int? _Hash;
            private int? _Index;
            private bool? _Redacted;

            internal DestinyDefinitionsRecordsDestinyRecordDefinitionBuilder()
            {
                SetupDefaults();
            }

            private void SetupDefaults()
            {
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsRecordsDestinyRecordDefinition.DisplayProperties property.
            /// </summary>
            /// <param name="value">DisplayProperties</param>
            public DestinyDefinitionsRecordsDestinyRecordDefinitionBuilder DisplayProperties(DestinyDefinitionsCommonDestinyDisplayPropertiesDefinition value)
            {
                _DisplayProperties = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsRecordsDestinyRecordDefinition.Scope property.
            /// </summary>
            /// <param name="value">Indicates whether this Record&#39;s state is determined on a per-character or on an account-wide basis.</param>
            public DestinyDefinitionsRecordsDestinyRecordDefinitionBuilder Scope(int? value)
            {
                _Scope = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsRecordsDestinyRecordDefinition.PresentationInfo property.
            /// </summary>
            /// <param name="value">PresentationInfo</param>
            public DestinyDefinitionsRecordsDestinyRecordDefinitionBuilder PresentationInfo(DestinyDefinitionsPresentationDestinyPresentationChildBlock value)
            {
                _PresentationInfo = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsRecordsDestinyRecordDefinition.LoreHash property.
            /// </summary>
            /// <param name="value">LoreHash</param>
            public DestinyDefinitionsRecordsDestinyRecordDefinitionBuilder LoreHash(int? value)
            {
                _LoreHash = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsRecordsDestinyRecordDefinition.ObjectiveHashes property.
            /// </summary>
            /// <param name="value">ObjectiveHashes</param>
            public DestinyDefinitionsRecordsDestinyRecordDefinitionBuilder ObjectiveHashes(List<int?> value)
            {
                _ObjectiveHashes = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsRecordsDestinyRecordDefinition.RecordValueStyle property.
            /// </summary>
            /// <param name="value">RecordValueStyle</param>
            public DestinyDefinitionsRecordsDestinyRecordDefinitionBuilder RecordValueStyle(int? value)
            {
                _RecordValueStyle = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsRecordsDestinyRecordDefinition.TitleInfo property.
            /// </summary>
            /// <param name="value">TitleInfo</param>
            public DestinyDefinitionsRecordsDestinyRecordDefinitionBuilder TitleInfo(DestinyDefinitionsRecordsDestinyRecordTitleBlock value)
            {
                _TitleInfo = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsRecordsDestinyRecordDefinition.CompletionInfo property.
            /// </summary>
            /// <param name="value">CompletionInfo</param>
            public DestinyDefinitionsRecordsDestinyRecordDefinitionBuilder CompletionInfo(DestinyDefinitionsRecordsDestinyRecordCompletionBlock value)
            {
                _CompletionInfo = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsRecordsDestinyRecordDefinition.StateInfo property.
            /// </summary>
            /// <param name="value">StateInfo</param>
            public DestinyDefinitionsRecordsDestinyRecordDefinitionBuilder StateInfo(DestinyDefinitionsRecordsSchemaRecordStateBlock value)
            {
                _StateInfo = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsRecordsDestinyRecordDefinition.Requirements property.
            /// </summary>
            /// <param name="value">Requirements</param>
            public DestinyDefinitionsRecordsDestinyRecordDefinitionBuilder Requirements(DestinyDefinitionsPresentationDestinyPresentationNodeRequirementsBlock value)
            {
                _Requirements = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsRecordsDestinyRecordDefinition.ExpirationInfo property.
            /// </summary>
            /// <param name="value">ExpirationInfo</param>
            public DestinyDefinitionsRecordsDestinyRecordDefinitionBuilder ExpirationInfo(DestinyDefinitionsRecordsDestinyRecordExpirationBlock value)
            {
                _ExpirationInfo = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsRecordsDestinyRecordDefinition.IntervalInfo property.
            /// </summary>
            /// <param name="value">Some records have multiple &#39;interval&#39; objectives, and the record may be claimed at each completed interval</param>
            public DestinyDefinitionsRecordsDestinyRecordDefinitionBuilder IntervalInfo(DestinyDefinitionsRecordsDestinyRecordIntervalBlock value)
            {
                _IntervalInfo = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsRecordsDestinyRecordDefinition.RewardItems property.
            /// </summary>
            /// <param name="value">If there is any publicly available information about rewards earned for achieving this record, this is the list of those items.   However, note that some records intentionally have \&quot;hidden\&quot; rewards. These will not be returned in this list.</param>
            public DestinyDefinitionsRecordsDestinyRecordDefinitionBuilder RewardItems(List<DestinyDestinyItemQuantity> value)
            {
                _RewardItems = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsRecordsDestinyRecordDefinition.PresentationNodeType property.
            /// </summary>
            /// <param name="value">PresentationNodeType</param>
            public DestinyDefinitionsRecordsDestinyRecordDefinitionBuilder PresentationNodeType(int? value)
            {
                _PresentationNodeType = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsRecordsDestinyRecordDefinition.TraitIds property.
            /// </summary>
            /// <param name="value">TraitIds</param>
            public DestinyDefinitionsRecordsDestinyRecordDefinitionBuilder TraitIds(List<string> value)
            {
                _TraitIds = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsRecordsDestinyRecordDefinition.TraitHashes property.
            /// </summary>
            /// <param name="value">TraitHashes</param>
            public DestinyDefinitionsRecordsDestinyRecordDefinitionBuilder TraitHashes(List<int?> value)
            {
                _TraitHashes = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsRecordsDestinyRecordDefinition.ParentNodeHashes property.
            /// </summary>
            /// <param name="value">A quick reference to presentation nodes that have this node as a child. Presentation nodes can be parented under multiple parents.</param>
            public DestinyDefinitionsRecordsDestinyRecordDefinitionBuilder ParentNodeHashes(List<int?> value)
            {
                _ParentNodeHashes = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsRecordsDestinyRecordDefinition.Hash property.
            /// </summary>
            /// <param name="value">The unique identifier for this entity. Guaranteed to be unique for the type of entity, but not globally.  When entities refer to each other in Destiny content, it is this hash that they are referring to.</param>
            public DestinyDefinitionsRecordsDestinyRecordDefinitionBuilder Hash(int? value)
            {
                _Hash = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsRecordsDestinyRecordDefinition.Index property.
            /// </summary>
            /// <param name="value">The index of the entity as it was found in the investment tables.</param>
            public DestinyDefinitionsRecordsDestinyRecordDefinitionBuilder Index(int? value)
            {
                _Index = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsRecordsDestinyRecordDefinition.Redacted property.
            /// </summary>
            /// <param name="value">If this is true, then there is an entity with this identifier/type combination, but BNet is not yet allowed to show it. Sorry!</param>
            public DestinyDefinitionsRecordsDestinyRecordDefinitionBuilder Redacted(bool? value)
            {
                _Redacted = value;
                return this;
            }


            /// <summary>
            /// Builds instance of DestinyDefinitionsRecordsDestinyRecordDefinition.
            /// </summary>
            /// <returns>DestinyDefinitionsRecordsDestinyRecordDefinition</returns>
            public DestinyDefinitionsRecordsDestinyRecordDefinition Build()
            {
                Validate();
                return new DestinyDefinitionsRecordsDestinyRecordDefinition(
                    DisplayProperties: _DisplayProperties,
                    Scope: _Scope,
                    PresentationInfo: _PresentationInfo,
                    LoreHash: _LoreHash,
                    ObjectiveHashes: _ObjectiveHashes,
                    RecordValueStyle: _RecordValueStyle,
                    TitleInfo: _TitleInfo,
                    CompletionInfo: _CompletionInfo,
                    StateInfo: _StateInfo,
                    Requirements: _Requirements,
                    ExpirationInfo: _ExpirationInfo,
                    IntervalInfo: _IntervalInfo,
                    RewardItems: _RewardItems,
                    PresentationNodeType: _PresentationNodeType,
                    TraitIds: _TraitIds,
                    TraitHashes: _TraitHashes,
                    ParentNodeHashes: _ParentNodeHashes,
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