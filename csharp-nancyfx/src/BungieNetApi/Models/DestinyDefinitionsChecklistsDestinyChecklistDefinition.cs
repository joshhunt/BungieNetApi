using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Sharpility.Extensions;
using NodaTime;

namespace BungieNetApi._Platform.Models
{
    /// <summary>
    /// By public demand, Checklists are loose sets of \&quot;things to do/things you have done\&quot; in Destiny that we were actually able to track. They include easter eggs you find in the world, unique chests you unlock, and other such data where the first time you do it is significant enough to be tracked, and you have the potential to \&quot;get them all\&quot;.  These may be account-wide, or may be per character. The status of these will be returned in related \&quot;Checklist\&quot; data coming down from API requests such as GetProfile or GetCharacter.  Generally speaking, the items in a checklist can be completed in any order: we return an ordered list which only implies the way we are showing them in our own UI, and you can feel free to alter it as you wish.  Note that, in the future, there will be something resembling the old D1 Record Books in at least some vague form. When that is created, it may be that it will supercede much or all of this Checklist data. It remains to be seen if that will be the case, so for now assume that the Checklists will still exist even after the release of D2: Forsaken.
    /// </summary>
    public sealed class DestinyDefinitionsChecklistsDestinyChecklistDefinition:  IEquatable<DestinyDefinitionsChecklistsDestinyChecklistDefinition>
    { 
        /// <summary>
        /// DisplayProperties
        /// </summary>
        public DestinyDefinitionsCommonDestinyDisplayPropertiesDefinition DisplayProperties { get; private set; }

        /// <summary>
        /// A localized string prompting you to view the checklist.
        /// </summary>
        public string ViewActionString { get; private set; }

        /// <summary>
        /// Indicates whether you will find this checklist on the Profile or Character components.
        /// </summary>
        public int? Scope { get; private set; }

        /// <summary>
        /// The individual checklist items. Gotta catch &#39;em all.
        /// </summary>
        public List<DestinyDefinitionsChecklistsDestinyChecklistEntryDefinition> Entries { get; private set; }

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
        /// Use DestinyDefinitionsChecklistsDestinyChecklistDefinition.Builder() for instance creation instead.
        /// </summary>
        [Obsolete]
        public DestinyDefinitionsChecklistsDestinyChecklistDefinition()
        {
        }

        private DestinyDefinitionsChecklistsDestinyChecklistDefinition(DestinyDefinitionsCommonDestinyDisplayPropertiesDefinition DisplayProperties, string ViewActionString, int? Scope, List<DestinyDefinitionsChecklistsDestinyChecklistEntryDefinition> Entries, int? Hash, int? Index, bool? Redacted)
        {
            
            this.DisplayProperties = DisplayProperties;
            
            this.ViewActionString = ViewActionString;
            
            this.Scope = Scope;
            
            this.Entries = Entries;
            
            this.Hash = Hash;
            
            this.Index = Index;
            
            this.Redacted = Redacted;
            
        }

        /// <summary>
        /// Returns builder of DestinyDefinitionsChecklistsDestinyChecklistDefinition.
        /// </summary>
        /// <returns>DestinyDefinitionsChecklistsDestinyChecklistDefinitionBuilder</returns>
        public static DestinyDefinitionsChecklistsDestinyChecklistDefinitionBuilder Builder()
        {
            return new DestinyDefinitionsChecklistsDestinyChecklistDefinitionBuilder();
        }

        /// <summary>
        /// Returns DestinyDefinitionsChecklistsDestinyChecklistDefinitionBuilder with properties set.
        /// Use it to change properties.
        /// </summary>
        /// <returns>DestinyDefinitionsChecklistsDestinyChecklistDefinitionBuilder</returns>
        public DestinyDefinitionsChecklistsDestinyChecklistDefinitionBuilder With()
        {
            return Builder()
                .DisplayProperties(DisplayProperties)
                .ViewActionString(ViewActionString)
                .Scope(Scope)
                .Entries(Entries)
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

        public bool Equals(DestinyDefinitionsChecklistsDestinyChecklistDefinition other)
        {
            return Equals((object) other);
        }

        public override int GetHashCode()
        {
            return this.PropertiesHash();
        }

        /// <summary>
        /// Implementation of == operator for (DestinyDefinitionsChecklistsDestinyChecklistDefinition.
        /// </summary>
        /// <param name="left">Compared (DestinyDefinitionsChecklistsDestinyChecklistDefinition</param>
        /// <param name="right">Compared (DestinyDefinitionsChecklistsDestinyChecklistDefinition</param>
        /// <returns>true if compared items are equals, false otherwise</returns>
        public static bool operator == (DestinyDefinitionsChecklistsDestinyChecklistDefinition left, DestinyDefinitionsChecklistsDestinyChecklistDefinition right)
        {
            return Equals(left, right);
        }

        /// <summary>
        /// Implementation of != operator for (DestinyDefinitionsChecklistsDestinyChecklistDefinition.
        /// </summary>
        /// <param name="left">Compared (DestinyDefinitionsChecklistsDestinyChecklistDefinition</param>
        /// <param name="right">Compared (DestinyDefinitionsChecklistsDestinyChecklistDefinition</param>
        /// <returns>true if compared items are not equals, false otherwise</returns>
        public static bool operator != (DestinyDefinitionsChecklistsDestinyChecklistDefinition left, DestinyDefinitionsChecklistsDestinyChecklistDefinition right)
        {
            return !Equals(left, right);
        }

        /// <summary>
        /// Builder of DestinyDefinitionsChecklistsDestinyChecklistDefinition.
        /// </summary>
        public sealed class DestinyDefinitionsChecklistsDestinyChecklistDefinitionBuilder
        {
            private DestinyDefinitionsCommonDestinyDisplayPropertiesDefinition _DisplayProperties;
            private string _ViewActionString;
            private int? _Scope;
            private List<DestinyDefinitionsChecklistsDestinyChecklistEntryDefinition> _Entries;
            private int? _Hash;
            private int? _Index;
            private bool? _Redacted;

            internal DestinyDefinitionsChecklistsDestinyChecklistDefinitionBuilder()
            {
                SetupDefaults();
            }

            private void SetupDefaults()
            {
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsChecklistsDestinyChecklistDefinition.DisplayProperties property.
            /// </summary>
            /// <param name="value">DisplayProperties</param>
            public DestinyDefinitionsChecklistsDestinyChecklistDefinitionBuilder DisplayProperties(DestinyDefinitionsCommonDestinyDisplayPropertiesDefinition value)
            {
                _DisplayProperties = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsChecklistsDestinyChecklistDefinition.ViewActionString property.
            /// </summary>
            /// <param name="value">A localized string prompting you to view the checklist.</param>
            public DestinyDefinitionsChecklistsDestinyChecklistDefinitionBuilder ViewActionString(string value)
            {
                _ViewActionString = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsChecklistsDestinyChecklistDefinition.Scope property.
            /// </summary>
            /// <param name="value">Indicates whether you will find this checklist on the Profile or Character components.</param>
            public DestinyDefinitionsChecklistsDestinyChecklistDefinitionBuilder Scope(int? value)
            {
                _Scope = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsChecklistsDestinyChecklistDefinition.Entries property.
            /// </summary>
            /// <param name="value">The individual checklist items. Gotta catch &#39;em all.</param>
            public DestinyDefinitionsChecklistsDestinyChecklistDefinitionBuilder Entries(List<DestinyDefinitionsChecklistsDestinyChecklistEntryDefinition> value)
            {
                _Entries = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsChecklistsDestinyChecklistDefinition.Hash property.
            /// </summary>
            /// <param name="value">The unique identifier for this entity. Guaranteed to be unique for the type of entity, but not globally.  When entities refer to each other in Destiny content, it is this hash that they are referring to.</param>
            public DestinyDefinitionsChecklistsDestinyChecklistDefinitionBuilder Hash(int? value)
            {
                _Hash = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsChecklistsDestinyChecklistDefinition.Index property.
            /// </summary>
            /// <param name="value">The index of the entity as it was found in the investment tables.</param>
            public DestinyDefinitionsChecklistsDestinyChecklistDefinitionBuilder Index(int? value)
            {
                _Index = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsChecklistsDestinyChecklistDefinition.Redacted property.
            /// </summary>
            /// <param name="value">If this is true, then there is an entity with this identifier/type combination, but BNet is not yet allowed to show it. Sorry!</param>
            public DestinyDefinitionsChecklistsDestinyChecklistDefinitionBuilder Redacted(bool? value)
            {
                _Redacted = value;
                return this;
            }


            /// <summary>
            /// Builds instance of DestinyDefinitionsChecklistsDestinyChecklistDefinition.
            /// </summary>
            /// <returns>DestinyDefinitionsChecklistsDestinyChecklistDefinition</returns>
            public DestinyDefinitionsChecklistsDestinyChecklistDefinition Build()
            {
                Validate();
                return new DestinyDefinitionsChecklistsDestinyChecklistDefinition(
                    DisplayProperties: _DisplayProperties,
                    ViewActionString: _ViewActionString,
                    Scope: _Scope,
                    Entries: _Entries,
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