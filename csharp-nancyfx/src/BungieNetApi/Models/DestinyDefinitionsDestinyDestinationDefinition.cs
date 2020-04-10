using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Sharpility.Extensions;
using NodaTime;

namespace BungieNetApi._Platform.Models
{
    /// <summary>
    /// On to one of the more confusing subjects of the API. What is a Destination, and what is the relationship between it, Activities, Locations, and Places?  A \&quot;Destination\&quot; is a specific region/city/area of a larger \&quot;Place\&quot;. For instance, a Place might be Earth where a Destination might be Bellevue, Washington. (Please, pick a more interesting destination if you come to visit Earth).
    /// </summary>
    public sealed class DestinyDefinitionsDestinyDestinationDefinition:  IEquatable<DestinyDefinitionsDestinyDestinationDefinition>
    { 
        /// <summary>
        /// DisplayProperties
        /// </summary>
        public DestinyDefinitionsCommonDestinyDisplayPropertiesDefinition DisplayProperties { get; private set; }

        /// <summary>
        /// The place that \&quot;owns\&quot; this Destination. Use this hash to look up the DestinyPlaceDefinition.
        /// </summary>
        public int? PlaceHash { get; private set; }

        /// <summary>
        /// If this Destination has a default Free-Roam activity, this is the hash for that Activity. Use it to look up the DestinyActivityDefintion.
        /// </summary>
        public int? DefaultFreeroamActivityHash { get; private set; }

        /// <summary>
        /// If the Destination has default Activity Graphs (i.e. \&quot;Map\&quot;) that should be shown in the director, this is the list of those Graphs. At most, only one should be active at any given time for a Destination: these would represent, for example, different variants on a Map if the Destination is changing on a macro level based on game state.
        /// </summary>
        public List<DestinyDefinitionsDestinyActivityGraphListEntryDefinition> ActivityGraphEntries { get; private set; }

        /// <summary>
        /// A Destination may have many \&quot;Bubbles\&quot; zones with human readable properties.  We don&#39;t get as much info as I&#39;d like about them - I&#39;d love to return info like where on the map they are located - but at least this gives you the name of those bubbles. bubbleSettings and bubbles both have the identical number of entries, and you should match up their indexes to provide matching bubble and bubbleSettings data.  DEPRECATED - Just use bubbles, it now has this data.
        /// </summary>
        public List<DestinyDefinitionsDestinyDestinationBubbleSettingDefinition> BubbleSettings { get; private set; }

        /// <summary>
        /// This provides the unique identifiers for every bubble in the destination (only guaranteed unique within the destination), and any intrinsic properties of the bubble.  bubbleSettings and bubbles both have the identical number of entries, and you should match up their indexes to provide matching bubble and bubbleSettings data.
        /// </summary>
        public List<DestinyDefinitionsDestinyBubbleDefinition> Bubbles { get; private set; }

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
        /// Use DestinyDefinitionsDestinyDestinationDefinition.Builder() for instance creation instead.
        /// </summary>
        [Obsolete]
        public DestinyDefinitionsDestinyDestinationDefinition()
        {
        }

        private DestinyDefinitionsDestinyDestinationDefinition(DestinyDefinitionsCommonDestinyDisplayPropertiesDefinition DisplayProperties, int? PlaceHash, int? DefaultFreeroamActivityHash, List<DestinyDefinitionsDestinyActivityGraphListEntryDefinition> ActivityGraphEntries, List<DestinyDefinitionsDestinyDestinationBubbleSettingDefinition> BubbleSettings, List<DestinyDefinitionsDestinyBubbleDefinition> Bubbles, int? Hash, int? Index, bool? Redacted)
        {
            
            this.DisplayProperties = DisplayProperties;
            
            this.PlaceHash = PlaceHash;
            
            this.DefaultFreeroamActivityHash = DefaultFreeroamActivityHash;
            
            this.ActivityGraphEntries = ActivityGraphEntries;
            
            this.BubbleSettings = BubbleSettings;
            
            this.Bubbles = Bubbles;
            
            this.Hash = Hash;
            
            this.Index = Index;
            
            this.Redacted = Redacted;
            
        }

        /// <summary>
        /// Returns builder of DestinyDefinitionsDestinyDestinationDefinition.
        /// </summary>
        /// <returns>DestinyDefinitionsDestinyDestinationDefinitionBuilder</returns>
        public static DestinyDefinitionsDestinyDestinationDefinitionBuilder Builder()
        {
            return new DestinyDefinitionsDestinyDestinationDefinitionBuilder();
        }

        /// <summary>
        /// Returns DestinyDefinitionsDestinyDestinationDefinitionBuilder with properties set.
        /// Use it to change properties.
        /// </summary>
        /// <returns>DestinyDefinitionsDestinyDestinationDefinitionBuilder</returns>
        public DestinyDefinitionsDestinyDestinationDefinitionBuilder With()
        {
            return Builder()
                .DisplayProperties(DisplayProperties)
                .PlaceHash(PlaceHash)
                .DefaultFreeroamActivityHash(DefaultFreeroamActivityHash)
                .ActivityGraphEntries(ActivityGraphEntries)
                .BubbleSettings(BubbleSettings)
                .Bubbles(Bubbles)
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

        public bool Equals(DestinyDefinitionsDestinyDestinationDefinition other)
        {
            return Equals((object) other);
        }

        public override int GetHashCode()
        {
            return this.PropertiesHash();
        }

        /// <summary>
        /// Implementation of == operator for (DestinyDefinitionsDestinyDestinationDefinition.
        /// </summary>
        /// <param name="left">Compared (DestinyDefinitionsDestinyDestinationDefinition</param>
        /// <param name="right">Compared (DestinyDefinitionsDestinyDestinationDefinition</param>
        /// <returns>true if compared items are equals, false otherwise</returns>
        public static bool operator == (DestinyDefinitionsDestinyDestinationDefinition left, DestinyDefinitionsDestinyDestinationDefinition right)
        {
            return Equals(left, right);
        }

        /// <summary>
        /// Implementation of != operator for (DestinyDefinitionsDestinyDestinationDefinition.
        /// </summary>
        /// <param name="left">Compared (DestinyDefinitionsDestinyDestinationDefinition</param>
        /// <param name="right">Compared (DestinyDefinitionsDestinyDestinationDefinition</param>
        /// <returns>true if compared items are not equals, false otherwise</returns>
        public static bool operator != (DestinyDefinitionsDestinyDestinationDefinition left, DestinyDefinitionsDestinyDestinationDefinition right)
        {
            return !Equals(left, right);
        }

        /// <summary>
        /// Builder of DestinyDefinitionsDestinyDestinationDefinition.
        /// </summary>
        public sealed class DestinyDefinitionsDestinyDestinationDefinitionBuilder
        {
            private DestinyDefinitionsCommonDestinyDisplayPropertiesDefinition _DisplayProperties;
            private int? _PlaceHash;
            private int? _DefaultFreeroamActivityHash;
            private List<DestinyDefinitionsDestinyActivityGraphListEntryDefinition> _ActivityGraphEntries;
            private List<DestinyDefinitionsDestinyDestinationBubbleSettingDefinition> _BubbleSettings;
            private List<DestinyDefinitionsDestinyBubbleDefinition> _Bubbles;
            private int? _Hash;
            private int? _Index;
            private bool? _Redacted;

            internal DestinyDefinitionsDestinyDestinationDefinitionBuilder()
            {
                SetupDefaults();
            }

            private void SetupDefaults()
            {
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsDestinyDestinationDefinition.DisplayProperties property.
            /// </summary>
            /// <param name="value">DisplayProperties</param>
            public DestinyDefinitionsDestinyDestinationDefinitionBuilder DisplayProperties(DestinyDefinitionsCommonDestinyDisplayPropertiesDefinition value)
            {
                _DisplayProperties = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsDestinyDestinationDefinition.PlaceHash property.
            /// </summary>
            /// <param name="value">The place that \&quot;owns\&quot; this Destination. Use this hash to look up the DestinyPlaceDefinition.</param>
            public DestinyDefinitionsDestinyDestinationDefinitionBuilder PlaceHash(int? value)
            {
                _PlaceHash = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsDestinyDestinationDefinition.DefaultFreeroamActivityHash property.
            /// </summary>
            /// <param name="value">If this Destination has a default Free-Roam activity, this is the hash for that Activity. Use it to look up the DestinyActivityDefintion.</param>
            public DestinyDefinitionsDestinyDestinationDefinitionBuilder DefaultFreeroamActivityHash(int? value)
            {
                _DefaultFreeroamActivityHash = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsDestinyDestinationDefinition.ActivityGraphEntries property.
            /// </summary>
            /// <param name="value">If the Destination has default Activity Graphs (i.e. \&quot;Map\&quot;) that should be shown in the director, this is the list of those Graphs. At most, only one should be active at any given time for a Destination: these would represent, for example, different variants on a Map if the Destination is changing on a macro level based on game state.</param>
            public DestinyDefinitionsDestinyDestinationDefinitionBuilder ActivityGraphEntries(List<DestinyDefinitionsDestinyActivityGraphListEntryDefinition> value)
            {
                _ActivityGraphEntries = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsDestinyDestinationDefinition.BubbleSettings property.
            /// </summary>
            /// <param name="value">A Destination may have many \&quot;Bubbles\&quot; zones with human readable properties.  We don&#39;t get as much info as I&#39;d like about them - I&#39;d love to return info like where on the map they are located - but at least this gives you the name of those bubbles. bubbleSettings and bubbles both have the identical number of entries, and you should match up their indexes to provide matching bubble and bubbleSettings data.  DEPRECATED - Just use bubbles, it now has this data.</param>
            public DestinyDefinitionsDestinyDestinationDefinitionBuilder BubbleSettings(List<DestinyDefinitionsDestinyDestinationBubbleSettingDefinition> value)
            {
                _BubbleSettings = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsDestinyDestinationDefinition.Bubbles property.
            /// </summary>
            /// <param name="value">This provides the unique identifiers for every bubble in the destination (only guaranteed unique within the destination), and any intrinsic properties of the bubble.  bubbleSettings and bubbles both have the identical number of entries, and you should match up their indexes to provide matching bubble and bubbleSettings data.</param>
            public DestinyDefinitionsDestinyDestinationDefinitionBuilder Bubbles(List<DestinyDefinitionsDestinyBubbleDefinition> value)
            {
                _Bubbles = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsDestinyDestinationDefinition.Hash property.
            /// </summary>
            /// <param name="value">The unique identifier for this entity. Guaranteed to be unique for the type of entity, but not globally.  When entities refer to each other in Destiny content, it is this hash that they are referring to.</param>
            public DestinyDefinitionsDestinyDestinationDefinitionBuilder Hash(int? value)
            {
                _Hash = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsDestinyDestinationDefinition.Index property.
            /// </summary>
            /// <param name="value">The index of the entity as it was found in the investment tables.</param>
            public DestinyDefinitionsDestinyDestinationDefinitionBuilder Index(int? value)
            {
                _Index = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsDestinyDestinationDefinition.Redacted property.
            /// </summary>
            /// <param name="value">If this is true, then there is an entity with this identifier/type combination, but BNet is not yet allowed to show it. Sorry!</param>
            public DestinyDefinitionsDestinyDestinationDefinitionBuilder Redacted(bool? value)
            {
                _Redacted = value;
                return this;
            }


            /// <summary>
            /// Builds instance of DestinyDefinitionsDestinyDestinationDefinition.
            /// </summary>
            /// <returns>DestinyDefinitionsDestinyDestinationDefinition</returns>
            public DestinyDefinitionsDestinyDestinationDefinition Build()
            {
                Validate();
                return new DestinyDefinitionsDestinyDestinationDefinition(
                    DisplayProperties: _DisplayProperties,
                    PlaceHash: _PlaceHash,
                    DefaultFreeroamActivityHash: _DefaultFreeroamActivityHash,
                    ActivityGraphEntries: _ActivityGraphEntries,
                    BubbleSettings: _BubbleSettings,
                    Bubbles: _Bubbles,
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