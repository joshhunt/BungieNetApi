using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Sharpility.Extensions;
using NodaTime;

namespace BungieNetApi._Platform.Models
{
    /// <summary>
    /// When an inventory item (DestinyInventoryItemDefinition) has Stats (such as Attack Power), the item will refer to a Stat Group. This definition enumerates the properties used to transform the item&#39;s \&quot;Investment\&quot; stats into \&quot;Display\&quot; stats.  See DestinyStatDefinition&#39;s documentation for information about the transformation of Stats, and the meaning of an Investment vs. a Display stat.  If you don&#39;t want to do these calculations on your own, fear not: pulling live data from the BNet endpoints will return display stat values pre-computed and ready for you to use. I highly recommend this approach, saves a lot of time and also accounts for certain stat modifiers that can&#39;t easily be accounted for without live data (such as stat modifiers on Talent Grids and Socket Plugs)
    /// </summary>
    public sealed class DestinyDefinitionsDestinyStatGroupDefinition:  IEquatable<DestinyDefinitionsDestinyStatGroupDefinition>
    { 
        /// <summary>
        /// The maximum possible value that any stat in this group can be transformed into.  This is used by stats that *don&#39;t* have scaledStats entries below, but that still need to be displayed as a progress bar, in which case this is used as the upper bound for said progress bar. (the lower bound is always 0)
        /// </summary>
        public int? MaximumValue { get; private set; }

        /// <summary>
        /// This apparently indicates the position of the stats in the UI? I&#39;ve returned it in case anyone can use it, but it&#39;s not of any use to us on BNet. Something&#39;s being lost in translation with this value.
        /// </summary>
        public int? UiPosition { get; private set; }

        /// <summary>
        /// Any stat that requires scaling to be transformed from an \&quot;Investment\&quot; stat to a \&quot;Display\&quot; stat will have an entry in this list. For more information on what those types of stats mean and the transformation process, see DestinyStatDefinition.  In retrospect, I wouldn&#39;t mind if this was a dictionary keyed by the stat hash instead. But I&#39;m going to leave it be because [[After Apple Picking]].
        /// </summary>
        public List<DestinyDefinitionsDestinyStatDisplayDefinition> ScaledStats { get; private set; }

        /// <summary>
        /// The game has the ability to override, based on the stat group, what the localized text is that is displayed for Stats being shown on the item.  Mercifully, no Stat Groups use this feature currently. If they start using them, we&#39;ll all need to start using them (and those of you who are more prudent than I am can go ahead and start pre-checking for this.)
        /// </summary>
        public Dictionary<string, DestinyDefinitionsDestinyStatOverrideDefinition> Overrides { get; private set; }

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
        /// Use DestinyDefinitionsDestinyStatGroupDefinition.Builder() for instance creation instead.
        /// </summary>
        [Obsolete]
        public DestinyDefinitionsDestinyStatGroupDefinition()
        {
        }

        private DestinyDefinitionsDestinyStatGroupDefinition(int? MaximumValue, int? UiPosition, List<DestinyDefinitionsDestinyStatDisplayDefinition> ScaledStats, Dictionary<string, DestinyDefinitionsDestinyStatOverrideDefinition> Overrides, int? Hash, int? Index, bool? Redacted)
        {
            
            this.MaximumValue = MaximumValue;
            
            this.UiPosition = UiPosition;
            
            this.ScaledStats = ScaledStats;
            
            this.Overrides = Overrides;
            
            this.Hash = Hash;
            
            this.Index = Index;
            
            this.Redacted = Redacted;
            
        }

        /// <summary>
        /// Returns builder of DestinyDefinitionsDestinyStatGroupDefinition.
        /// </summary>
        /// <returns>DestinyDefinitionsDestinyStatGroupDefinitionBuilder</returns>
        public static DestinyDefinitionsDestinyStatGroupDefinitionBuilder Builder()
        {
            return new DestinyDefinitionsDestinyStatGroupDefinitionBuilder();
        }

        /// <summary>
        /// Returns DestinyDefinitionsDestinyStatGroupDefinitionBuilder with properties set.
        /// Use it to change properties.
        /// </summary>
        /// <returns>DestinyDefinitionsDestinyStatGroupDefinitionBuilder</returns>
        public DestinyDefinitionsDestinyStatGroupDefinitionBuilder With()
        {
            return Builder()
                .MaximumValue(MaximumValue)
                .UiPosition(UiPosition)
                .ScaledStats(ScaledStats)
                .Overrides(Overrides)
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

        public bool Equals(DestinyDefinitionsDestinyStatGroupDefinition other)
        {
            return Equals((object) other);
        }

        public override int GetHashCode()
        {
            return this.PropertiesHash();
        }

        /// <summary>
        /// Implementation of == operator for (DestinyDefinitionsDestinyStatGroupDefinition.
        /// </summary>
        /// <param name="left">Compared (DestinyDefinitionsDestinyStatGroupDefinition</param>
        /// <param name="right">Compared (DestinyDefinitionsDestinyStatGroupDefinition</param>
        /// <returns>true if compared items are equals, false otherwise</returns>
        public static bool operator == (DestinyDefinitionsDestinyStatGroupDefinition left, DestinyDefinitionsDestinyStatGroupDefinition right)
        {
            return Equals(left, right);
        }

        /// <summary>
        /// Implementation of != operator for (DestinyDefinitionsDestinyStatGroupDefinition.
        /// </summary>
        /// <param name="left">Compared (DestinyDefinitionsDestinyStatGroupDefinition</param>
        /// <param name="right">Compared (DestinyDefinitionsDestinyStatGroupDefinition</param>
        /// <returns>true if compared items are not equals, false otherwise</returns>
        public static bool operator != (DestinyDefinitionsDestinyStatGroupDefinition left, DestinyDefinitionsDestinyStatGroupDefinition right)
        {
            return !Equals(left, right);
        }

        /// <summary>
        /// Builder of DestinyDefinitionsDestinyStatGroupDefinition.
        /// </summary>
        public sealed class DestinyDefinitionsDestinyStatGroupDefinitionBuilder
        {
            private int? _MaximumValue;
            private int? _UiPosition;
            private List<DestinyDefinitionsDestinyStatDisplayDefinition> _ScaledStats;
            private Dictionary<string, DestinyDefinitionsDestinyStatOverrideDefinition> _Overrides;
            private int? _Hash;
            private int? _Index;
            private bool? _Redacted;

            internal DestinyDefinitionsDestinyStatGroupDefinitionBuilder()
            {
                SetupDefaults();
            }

            private void SetupDefaults()
            {
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsDestinyStatGroupDefinition.MaximumValue property.
            /// </summary>
            /// <param name="value">The maximum possible value that any stat in this group can be transformed into.  This is used by stats that *don&#39;t* have scaledStats entries below, but that still need to be displayed as a progress bar, in which case this is used as the upper bound for said progress bar. (the lower bound is always 0)</param>
            public DestinyDefinitionsDestinyStatGroupDefinitionBuilder MaximumValue(int? value)
            {
                _MaximumValue = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsDestinyStatGroupDefinition.UiPosition property.
            /// </summary>
            /// <param name="value">This apparently indicates the position of the stats in the UI? I&#39;ve returned it in case anyone can use it, but it&#39;s not of any use to us on BNet. Something&#39;s being lost in translation with this value.</param>
            public DestinyDefinitionsDestinyStatGroupDefinitionBuilder UiPosition(int? value)
            {
                _UiPosition = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsDestinyStatGroupDefinition.ScaledStats property.
            /// </summary>
            /// <param name="value">Any stat that requires scaling to be transformed from an \&quot;Investment\&quot; stat to a \&quot;Display\&quot; stat will have an entry in this list. For more information on what those types of stats mean and the transformation process, see DestinyStatDefinition.  In retrospect, I wouldn&#39;t mind if this was a dictionary keyed by the stat hash instead. But I&#39;m going to leave it be because [[After Apple Picking]].</param>
            public DestinyDefinitionsDestinyStatGroupDefinitionBuilder ScaledStats(List<DestinyDefinitionsDestinyStatDisplayDefinition> value)
            {
                _ScaledStats = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsDestinyStatGroupDefinition.Overrides property.
            /// </summary>
            /// <param name="value">The game has the ability to override, based on the stat group, what the localized text is that is displayed for Stats being shown on the item.  Mercifully, no Stat Groups use this feature currently. If they start using them, we&#39;ll all need to start using them (and those of you who are more prudent than I am can go ahead and start pre-checking for this.)</param>
            public DestinyDefinitionsDestinyStatGroupDefinitionBuilder Overrides(Dictionary<string, DestinyDefinitionsDestinyStatOverrideDefinition> value)
            {
                _Overrides = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsDestinyStatGroupDefinition.Hash property.
            /// </summary>
            /// <param name="value">The unique identifier for this entity. Guaranteed to be unique for the type of entity, but not globally.  When entities refer to each other in Destiny content, it is this hash that they are referring to.</param>
            public DestinyDefinitionsDestinyStatGroupDefinitionBuilder Hash(int? value)
            {
                _Hash = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsDestinyStatGroupDefinition.Index property.
            /// </summary>
            /// <param name="value">The index of the entity as it was found in the investment tables.</param>
            public DestinyDefinitionsDestinyStatGroupDefinitionBuilder Index(int? value)
            {
                _Index = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsDestinyStatGroupDefinition.Redacted property.
            /// </summary>
            /// <param name="value">If this is true, then there is an entity with this identifier/type combination, but BNet is not yet allowed to show it. Sorry!</param>
            public DestinyDefinitionsDestinyStatGroupDefinitionBuilder Redacted(bool? value)
            {
                _Redacted = value;
                return this;
            }


            /// <summary>
            /// Builds instance of DestinyDefinitionsDestinyStatGroupDefinition.
            /// </summary>
            /// <returns>DestinyDefinitionsDestinyStatGroupDefinition</returns>
            public DestinyDefinitionsDestinyStatGroupDefinition Build()
            {
                Validate();
                return new DestinyDefinitionsDestinyStatGroupDefinition(
                    MaximumValue: _MaximumValue,
                    UiPosition: _UiPosition,
                    ScaledStats: _ScaledStats,
                    Overrides: _Overrides,
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