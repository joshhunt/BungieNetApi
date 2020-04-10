using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Sharpility.Extensions;
using NodaTime;

namespace BungieNetApi._Platform.Models
{
    /// <summary>
    /// These are definitions for in-game \&quot;Lore,\&quot; meant to be narrative enhancements of the game experience.  DestinyInventoryItemDefinitions for interesting items point to these definitions, but nothing&#39;s stopping you from scraping all of these and doing something cool with them. If they end up having cool data.
    /// </summary>
    public sealed class DestinyDefinitionsLoreDestinyLoreDefinition:  IEquatable<DestinyDefinitionsLoreDestinyLoreDefinition>
    { 
        /// <summary>
        /// DisplayProperties
        /// </summary>
        public DestinyDefinitionsCommonDestinyDisplayPropertiesDefinition DisplayProperties { get; private set; }

        /// <summary>
        /// Subtitle
        /// </summary>
        public string Subtitle { get; private set; }

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
        /// Use DestinyDefinitionsLoreDestinyLoreDefinition.Builder() for instance creation instead.
        /// </summary>
        [Obsolete]
        public DestinyDefinitionsLoreDestinyLoreDefinition()
        {
        }

        private DestinyDefinitionsLoreDestinyLoreDefinition(DestinyDefinitionsCommonDestinyDisplayPropertiesDefinition DisplayProperties, string Subtitle, int? Hash, int? Index, bool? Redacted)
        {
            
            this.DisplayProperties = DisplayProperties;
            
            this.Subtitle = Subtitle;
            
            this.Hash = Hash;
            
            this.Index = Index;
            
            this.Redacted = Redacted;
            
        }

        /// <summary>
        /// Returns builder of DestinyDefinitionsLoreDestinyLoreDefinition.
        /// </summary>
        /// <returns>DestinyDefinitionsLoreDestinyLoreDefinitionBuilder</returns>
        public static DestinyDefinitionsLoreDestinyLoreDefinitionBuilder Builder()
        {
            return new DestinyDefinitionsLoreDestinyLoreDefinitionBuilder();
        }

        /// <summary>
        /// Returns DestinyDefinitionsLoreDestinyLoreDefinitionBuilder with properties set.
        /// Use it to change properties.
        /// </summary>
        /// <returns>DestinyDefinitionsLoreDestinyLoreDefinitionBuilder</returns>
        public DestinyDefinitionsLoreDestinyLoreDefinitionBuilder With()
        {
            return Builder()
                .DisplayProperties(DisplayProperties)
                .Subtitle(Subtitle)
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

        public bool Equals(DestinyDefinitionsLoreDestinyLoreDefinition other)
        {
            return Equals((object) other);
        }

        public override int GetHashCode()
        {
            return this.PropertiesHash();
        }

        /// <summary>
        /// Implementation of == operator for (DestinyDefinitionsLoreDestinyLoreDefinition.
        /// </summary>
        /// <param name="left">Compared (DestinyDefinitionsLoreDestinyLoreDefinition</param>
        /// <param name="right">Compared (DestinyDefinitionsLoreDestinyLoreDefinition</param>
        /// <returns>true if compared items are equals, false otherwise</returns>
        public static bool operator == (DestinyDefinitionsLoreDestinyLoreDefinition left, DestinyDefinitionsLoreDestinyLoreDefinition right)
        {
            return Equals(left, right);
        }

        /// <summary>
        /// Implementation of != operator for (DestinyDefinitionsLoreDestinyLoreDefinition.
        /// </summary>
        /// <param name="left">Compared (DestinyDefinitionsLoreDestinyLoreDefinition</param>
        /// <param name="right">Compared (DestinyDefinitionsLoreDestinyLoreDefinition</param>
        /// <returns>true if compared items are not equals, false otherwise</returns>
        public static bool operator != (DestinyDefinitionsLoreDestinyLoreDefinition left, DestinyDefinitionsLoreDestinyLoreDefinition right)
        {
            return !Equals(left, right);
        }

        /// <summary>
        /// Builder of DestinyDefinitionsLoreDestinyLoreDefinition.
        /// </summary>
        public sealed class DestinyDefinitionsLoreDestinyLoreDefinitionBuilder
        {
            private DestinyDefinitionsCommonDestinyDisplayPropertiesDefinition _DisplayProperties;
            private string _Subtitle;
            private int? _Hash;
            private int? _Index;
            private bool? _Redacted;

            internal DestinyDefinitionsLoreDestinyLoreDefinitionBuilder()
            {
                SetupDefaults();
            }

            private void SetupDefaults()
            {
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsLoreDestinyLoreDefinition.DisplayProperties property.
            /// </summary>
            /// <param name="value">DisplayProperties</param>
            public DestinyDefinitionsLoreDestinyLoreDefinitionBuilder DisplayProperties(DestinyDefinitionsCommonDestinyDisplayPropertiesDefinition value)
            {
                _DisplayProperties = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsLoreDestinyLoreDefinition.Subtitle property.
            /// </summary>
            /// <param name="value">Subtitle</param>
            public DestinyDefinitionsLoreDestinyLoreDefinitionBuilder Subtitle(string value)
            {
                _Subtitle = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsLoreDestinyLoreDefinition.Hash property.
            /// </summary>
            /// <param name="value">The unique identifier for this entity. Guaranteed to be unique for the type of entity, but not globally.  When entities refer to each other in Destiny content, it is this hash that they are referring to.</param>
            public DestinyDefinitionsLoreDestinyLoreDefinitionBuilder Hash(int? value)
            {
                _Hash = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsLoreDestinyLoreDefinition.Index property.
            /// </summary>
            /// <param name="value">The index of the entity as it was found in the investment tables.</param>
            public DestinyDefinitionsLoreDestinyLoreDefinitionBuilder Index(int? value)
            {
                _Index = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsLoreDestinyLoreDefinition.Redacted property.
            /// </summary>
            /// <param name="value">If this is true, then there is an entity with this identifier/type combination, but BNet is not yet allowed to show it. Sorry!</param>
            public DestinyDefinitionsLoreDestinyLoreDefinitionBuilder Redacted(bool? value)
            {
                _Redacted = value;
                return this;
            }


            /// <summary>
            /// Builds instance of DestinyDefinitionsLoreDestinyLoreDefinition.
            /// </summary>
            /// <returns>DestinyDefinitionsLoreDestinyLoreDefinition</returns>
            public DestinyDefinitionsLoreDestinyLoreDefinition Build()
            {
                Validate();
                return new DestinyDefinitionsLoreDestinyLoreDefinition(
                    DisplayProperties: _DisplayProperties,
                    Subtitle: _Subtitle,
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