using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Sharpility.Extensions;
using NodaTime;

namespace BungieNetApi._Platform.Models
{
    /// <summary>
    /// Defines a
    /// </summary>
    public sealed class DestinyDefinitionsCollectiblesDestinyCollectibleDefinition:  IEquatable<DestinyDefinitionsCollectiblesDestinyCollectibleDefinition>
    { 
        /// <summary>
        /// DisplayProperties
        /// </summary>
        public DestinyDefinitionsCommonDestinyDisplayPropertiesDefinition DisplayProperties { get; private set; }

        /// <summary>
        /// Indicates whether the state of this Collectible is determined on a per-character or on an account-wide basis.
        /// </summary>
        public int? Scope { get; private set; }

        /// <summary>
        /// A human readable string for a hint about how to acquire the item.
        /// </summary>
        public string SourceString { get; private set; }

        /// <summary>
        /// This is a hash identifier we are building on the BNet side in an attempt to let people group collectibles by similar sources.  I can&#39;t promise that it&#39;s going to be 100% accurate, but if the designers were consistent in assigning the same source strings to items with the same sources, it *ought to* be. No promises though.  This hash also doesn&#39;t relate to an actual definition, just to note: we&#39;ve got nothing useful other than the source string for this data.
        /// </summary>
        public int? SourceHash { get; private set; }

        /// <summary>
        /// ItemHash
        /// </summary>
        public int? ItemHash { get; private set; }

        /// <summary>
        /// AcquisitionInfo
        /// </summary>
        public DestinyDefinitionsCollectiblesDestinyCollectibleAcquisitionBlock AcquisitionInfo { get; private set; }

        /// <summary>
        /// StateInfo
        /// </summary>
        public DestinyDefinitionsCollectiblesDestinyCollectibleStateBlock StateInfo { get; private set; }

        /// <summary>
        /// PresentationInfo
        /// </summary>
        public DestinyDefinitionsPresentationDestinyPresentationChildBlock PresentationInfo { get; private set; }

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
        /// Use DestinyDefinitionsCollectiblesDestinyCollectibleDefinition.Builder() for instance creation instead.
        /// </summary>
        [Obsolete]
        public DestinyDefinitionsCollectiblesDestinyCollectibleDefinition()
        {
        }

        private DestinyDefinitionsCollectiblesDestinyCollectibleDefinition(DestinyDefinitionsCommonDestinyDisplayPropertiesDefinition DisplayProperties, int? Scope, string SourceString, int? SourceHash, int? ItemHash, DestinyDefinitionsCollectiblesDestinyCollectibleAcquisitionBlock AcquisitionInfo, DestinyDefinitionsCollectiblesDestinyCollectibleStateBlock StateInfo, DestinyDefinitionsPresentationDestinyPresentationChildBlock PresentationInfo, int? PresentationNodeType, List<string> TraitIds, List<int?> TraitHashes, List<int?> ParentNodeHashes, int? Hash, int? Index, bool? Redacted)
        {
            
            this.DisplayProperties = DisplayProperties;
            
            this.Scope = Scope;
            
            this.SourceString = SourceString;
            
            this.SourceHash = SourceHash;
            
            this.ItemHash = ItemHash;
            
            this.AcquisitionInfo = AcquisitionInfo;
            
            this.StateInfo = StateInfo;
            
            this.PresentationInfo = PresentationInfo;
            
            this.PresentationNodeType = PresentationNodeType;
            
            this.TraitIds = TraitIds;
            
            this.TraitHashes = TraitHashes;
            
            this.ParentNodeHashes = ParentNodeHashes;
            
            this.Hash = Hash;
            
            this.Index = Index;
            
            this.Redacted = Redacted;
            
        }

        /// <summary>
        /// Returns builder of DestinyDefinitionsCollectiblesDestinyCollectibleDefinition.
        /// </summary>
        /// <returns>DestinyDefinitionsCollectiblesDestinyCollectibleDefinitionBuilder</returns>
        public static DestinyDefinitionsCollectiblesDestinyCollectibleDefinitionBuilder Builder()
        {
            return new DestinyDefinitionsCollectiblesDestinyCollectibleDefinitionBuilder();
        }

        /// <summary>
        /// Returns DestinyDefinitionsCollectiblesDestinyCollectibleDefinitionBuilder with properties set.
        /// Use it to change properties.
        /// </summary>
        /// <returns>DestinyDefinitionsCollectiblesDestinyCollectibleDefinitionBuilder</returns>
        public DestinyDefinitionsCollectiblesDestinyCollectibleDefinitionBuilder With()
        {
            return Builder()
                .DisplayProperties(DisplayProperties)
                .Scope(Scope)
                .SourceString(SourceString)
                .SourceHash(SourceHash)
                .ItemHash(ItemHash)
                .AcquisitionInfo(AcquisitionInfo)
                .StateInfo(StateInfo)
                .PresentationInfo(PresentationInfo)
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

        public bool Equals(DestinyDefinitionsCollectiblesDestinyCollectibleDefinition other)
        {
            return Equals((object) other);
        }

        public override int GetHashCode()
        {
            return this.PropertiesHash();
        }

        /// <summary>
        /// Implementation of == operator for (DestinyDefinitionsCollectiblesDestinyCollectibleDefinition.
        /// </summary>
        /// <param name="left">Compared (DestinyDefinitionsCollectiblesDestinyCollectibleDefinition</param>
        /// <param name="right">Compared (DestinyDefinitionsCollectiblesDestinyCollectibleDefinition</param>
        /// <returns>true if compared items are equals, false otherwise</returns>
        public static bool operator == (DestinyDefinitionsCollectiblesDestinyCollectibleDefinition left, DestinyDefinitionsCollectiblesDestinyCollectibleDefinition right)
        {
            return Equals(left, right);
        }

        /// <summary>
        /// Implementation of != operator for (DestinyDefinitionsCollectiblesDestinyCollectibleDefinition.
        /// </summary>
        /// <param name="left">Compared (DestinyDefinitionsCollectiblesDestinyCollectibleDefinition</param>
        /// <param name="right">Compared (DestinyDefinitionsCollectiblesDestinyCollectibleDefinition</param>
        /// <returns>true if compared items are not equals, false otherwise</returns>
        public static bool operator != (DestinyDefinitionsCollectiblesDestinyCollectibleDefinition left, DestinyDefinitionsCollectiblesDestinyCollectibleDefinition right)
        {
            return !Equals(left, right);
        }

        /// <summary>
        /// Builder of DestinyDefinitionsCollectiblesDestinyCollectibleDefinition.
        /// </summary>
        public sealed class DestinyDefinitionsCollectiblesDestinyCollectibleDefinitionBuilder
        {
            private DestinyDefinitionsCommonDestinyDisplayPropertiesDefinition _DisplayProperties;
            private int? _Scope;
            private string _SourceString;
            private int? _SourceHash;
            private int? _ItemHash;
            private DestinyDefinitionsCollectiblesDestinyCollectibleAcquisitionBlock _AcquisitionInfo;
            private DestinyDefinitionsCollectiblesDestinyCollectibleStateBlock _StateInfo;
            private DestinyDefinitionsPresentationDestinyPresentationChildBlock _PresentationInfo;
            private int? _PresentationNodeType;
            private List<string> _TraitIds;
            private List<int?> _TraitHashes;
            private List<int?> _ParentNodeHashes;
            private int? _Hash;
            private int? _Index;
            private bool? _Redacted;

            internal DestinyDefinitionsCollectiblesDestinyCollectibleDefinitionBuilder()
            {
                SetupDefaults();
            }

            private void SetupDefaults()
            {
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsCollectiblesDestinyCollectibleDefinition.DisplayProperties property.
            /// </summary>
            /// <param name="value">DisplayProperties</param>
            public DestinyDefinitionsCollectiblesDestinyCollectibleDefinitionBuilder DisplayProperties(DestinyDefinitionsCommonDestinyDisplayPropertiesDefinition value)
            {
                _DisplayProperties = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsCollectiblesDestinyCollectibleDefinition.Scope property.
            /// </summary>
            /// <param name="value">Indicates whether the state of this Collectible is determined on a per-character or on an account-wide basis.</param>
            public DestinyDefinitionsCollectiblesDestinyCollectibleDefinitionBuilder Scope(int? value)
            {
                _Scope = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsCollectiblesDestinyCollectibleDefinition.SourceString property.
            /// </summary>
            /// <param name="value">A human readable string for a hint about how to acquire the item.</param>
            public DestinyDefinitionsCollectiblesDestinyCollectibleDefinitionBuilder SourceString(string value)
            {
                _SourceString = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsCollectiblesDestinyCollectibleDefinition.SourceHash property.
            /// </summary>
            /// <param name="value">This is a hash identifier we are building on the BNet side in an attempt to let people group collectibles by similar sources.  I can&#39;t promise that it&#39;s going to be 100% accurate, but if the designers were consistent in assigning the same source strings to items with the same sources, it *ought to* be. No promises though.  This hash also doesn&#39;t relate to an actual definition, just to note: we&#39;ve got nothing useful other than the source string for this data.</param>
            public DestinyDefinitionsCollectiblesDestinyCollectibleDefinitionBuilder SourceHash(int? value)
            {
                _SourceHash = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsCollectiblesDestinyCollectibleDefinition.ItemHash property.
            /// </summary>
            /// <param name="value">ItemHash</param>
            public DestinyDefinitionsCollectiblesDestinyCollectibleDefinitionBuilder ItemHash(int? value)
            {
                _ItemHash = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsCollectiblesDestinyCollectibleDefinition.AcquisitionInfo property.
            /// </summary>
            /// <param name="value">AcquisitionInfo</param>
            public DestinyDefinitionsCollectiblesDestinyCollectibleDefinitionBuilder AcquisitionInfo(DestinyDefinitionsCollectiblesDestinyCollectibleAcquisitionBlock value)
            {
                _AcquisitionInfo = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsCollectiblesDestinyCollectibleDefinition.StateInfo property.
            /// </summary>
            /// <param name="value">StateInfo</param>
            public DestinyDefinitionsCollectiblesDestinyCollectibleDefinitionBuilder StateInfo(DestinyDefinitionsCollectiblesDestinyCollectibleStateBlock value)
            {
                _StateInfo = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsCollectiblesDestinyCollectibleDefinition.PresentationInfo property.
            /// </summary>
            /// <param name="value">PresentationInfo</param>
            public DestinyDefinitionsCollectiblesDestinyCollectibleDefinitionBuilder PresentationInfo(DestinyDefinitionsPresentationDestinyPresentationChildBlock value)
            {
                _PresentationInfo = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsCollectiblesDestinyCollectibleDefinition.PresentationNodeType property.
            /// </summary>
            /// <param name="value">PresentationNodeType</param>
            public DestinyDefinitionsCollectiblesDestinyCollectibleDefinitionBuilder PresentationNodeType(int? value)
            {
                _PresentationNodeType = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsCollectiblesDestinyCollectibleDefinition.TraitIds property.
            /// </summary>
            /// <param name="value">TraitIds</param>
            public DestinyDefinitionsCollectiblesDestinyCollectibleDefinitionBuilder TraitIds(List<string> value)
            {
                _TraitIds = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsCollectiblesDestinyCollectibleDefinition.TraitHashes property.
            /// </summary>
            /// <param name="value">TraitHashes</param>
            public DestinyDefinitionsCollectiblesDestinyCollectibleDefinitionBuilder TraitHashes(List<int?> value)
            {
                _TraitHashes = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsCollectiblesDestinyCollectibleDefinition.ParentNodeHashes property.
            /// </summary>
            /// <param name="value">A quick reference to presentation nodes that have this node as a child. Presentation nodes can be parented under multiple parents.</param>
            public DestinyDefinitionsCollectiblesDestinyCollectibleDefinitionBuilder ParentNodeHashes(List<int?> value)
            {
                _ParentNodeHashes = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsCollectiblesDestinyCollectibleDefinition.Hash property.
            /// </summary>
            /// <param name="value">The unique identifier for this entity. Guaranteed to be unique for the type of entity, but not globally.  When entities refer to each other in Destiny content, it is this hash that they are referring to.</param>
            public DestinyDefinitionsCollectiblesDestinyCollectibleDefinitionBuilder Hash(int? value)
            {
                _Hash = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsCollectiblesDestinyCollectibleDefinition.Index property.
            /// </summary>
            /// <param name="value">The index of the entity as it was found in the investment tables.</param>
            public DestinyDefinitionsCollectiblesDestinyCollectibleDefinitionBuilder Index(int? value)
            {
                _Index = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsCollectiblesDestinyCollectibleDefinition.Redacted property.
            /// </summary>
            /// <param name="value">If this is true, then there is an entity with this identifier/type combination, but BNet is not yet allowed to show it. Sorry!</param>
            public DestinyDefinitionsCollectiblesDestinyCollectibleDefinitionBuilder Redacted(bool? value)
            {
                _Redacted = value;
                return this;
            }


            /// <summary>
            /// Builds instance of DestinyDefinitionsCollectiblesDestinyCollectibleDefinition.
            /// </summary>
            /// <returns>DestinyDefinitionsCollectiblesDestinyCollectibleDefinition</returns>
            public DestinyDefinitionsCollectiblesDestinyCollectibleDefinition Build()
            {
                Validate();
                return new DestinyDefinitionsCollectiblesDestinyCollectibleDefinition(
                    DisplayProperties: _DisplayProperties,
                    Scope: _Scope,
                    SourceString: _SourceString,
                    SourceHash: _SourceHash,
                    ItemHash: _ItemHash,
                    AcquisitionInfo: _AcquisitionInfo,
                    StateInfo: _StateInfo,
                    PresentationInfo: _PresentationInfo,
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