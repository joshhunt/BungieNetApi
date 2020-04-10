using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Sharpility.Extensions;
using NodaTime;

namespace BungieNetApi._Platform.Models
{
    /// <summary>
    /// This component returns anything that could be considered \&quot;Progression\&quot; on a user: data where the user is gaining levels, reputation, completions, rewards, etc...
    /// </summary>
    public sealed class DestinyEntitiesCharactersDestinyCharacterProgressionComponent:  IEquatable<DestinyEntitiesCharactersDestinyCharacterProgressionComponent>
    { 
        /// <summary>
        /// A Dictionary of all known progressions for the Character, keyed by the Progression&#39;s hash.  Not all progressions have user-facing data, but those who do will have that data contained in the DestinyProgressionDefinition.
        /// </summary>
        public Dictionary<string, DestinyDestinyProgression> Progressions { get; private set; }

        /// <summary>
        /// A dictionary of all known Factions, keyed by the Faction&#39;s hash. It contains data about this character&#39;s status with the faction.
        /// </summary>
        public Dictionary<string, DestinyProgressionDestinyFactionProgression> Factions { get; private set; }

        /// <summary>
        /// Milestones are related to the simple progressions shown in the game, but return additional and hopefully helpful information for users about the specifics of the Milestone&#39;s status.
        /// </summary>
        public Dictionary<string, DestinyMilestonesDestinyMilestone> Milestones { get; private set; }

        /// <summary>
        /// If the user has any active quests, the quests&#39; statuses will be returned here.   Note that quests have been largely supplanted by Milestones, but that doesn&#39;t mean that they won&#39;t make a comeback independent of milestones at some point.   (Fun fact: quests came back as I feared they would, but we never looped back to populate this... I&#39;m going to put that in the backlog.)
        /// </summary>
        public List<DestinyQuestsDestinyQuestStatus> Quests { get; private set; }

        /// <summary>
        /// Sometimes, you have items in your inventory that don&#39;t have instances, but still have Objective information. This provides you that objective information for uninstanced items.   This dictionary is keyed by the item&#39;s hash: which you can use to look up the name and description for the overall task(s) implied by the objective. The value is the list of objectives for this item, and their statuses.
        /// </summary>
        public Dictionary<string, List<DestinyQuestsDestinyObjectiveProgress>> UninstancedItemObjectives { get; private set; }

        /// <summary>
        /// The set of checklists that can be examined for this specific character, keyed by the hash identifier of the Checklist (DestinyChecklistDefinition)  For each checklist returned, its value is itself a Dictionary keyed by the checklist&#39;s hash identifier with the value being a boolean indicating if it&#39;s been discovered yet.
        /// </summary>
        public Dictionary<string, Dictionary<string, bool?>> Checklists { get; private set; }

        /// <summary>
        /// Data related to your progress on the current season&#39;s artifact that can vary per character.
        /// </summary>
        public DestinyArtifactsDestinyArtifactCharacterScoped SeasonalArtifact { get; private set; }


        /// <summary>
        /// Empty constructor required by some serializers.
        /// Use DestinyEntitiesCharactersDestinyCharacterProgressionComponent.Builder() for instance creation instead.
        /// </summary>
        [Obsolete]
        public DestinyEntitiesCharactersDestinyCharacterProgressionComponent()
        {
        }

        private DestinyEntitiesCharactersDestinyCharacterProgressionComponent(Dictionary<string, DestinyDestinyProgression> Progressions, Dictionary<string, DestinyProgressionDestinyFactionProgression> Factions, Dictionary<string, DestinyMilestonesDestinyMilestone> Milestones, List<DestinyQuestsDestinyQuestStatus> Quests, Dictionary<string, List<DestinyQuestsDestinyObjectiveProgress>> UninstancedItemObjectives, Dictionary<string, Dictionary<string, bool?>> Checklists, DestinyArtifactsDestinyArtifactCharacterScoped SeasonalArtifact)
        {
            
            this.Progressions = Progressions;
            
            this.Factions = Factions;
            
            this.Milestones = Milestones;
            
            this.Quests = Quests;
            
            this.UninstancedItemObjectives = UninstancedItemObjectives;
            
            this.Checklists = Checklists;
            
            this.SeasonalArtifact = SeasonalArtifact;
            
        }

        /// <summary>
        /// Returns builder of DestinyEntitiesCharactersDestinyCharacterProgressionComponent.
        /// </summary>
        /// <returns>DestinyEntitiesCharactersDestinyCharacterProgressionComponentBuilder</returns>
        public static DestinyEntitiesCharactersDestinyCharacterProgressionComponentBuilder Builder()
        {
            return new DestinyEntitiesCharactersDestinyCharacterProgressionComponentBuilder();
        }

        /// <summary>
        /// Returns DestinyEntitiesCharactersDestinyCharacterProgressionComponentBuilder with properties set.
        /// Use it to change properties.
        /// </summary>
        /// <returns>DestinyEntitiesCharactersDestinyCharacterProgressionComponentBuilder</returns>
        public DestinyEntitiesCharactersDestinyCharacterProgressionComponentBuilder With()
        {
            return Builder()
                .Progressions(Progressions)
                .Factions(Factions)
                .Milestones(Milestones)
                .Quests(Quests)
                .UninstancedItemObjectives(UninstancedItemObjectives)
                .Checklists(Checklists)
                .SeasonalArtifact(SeasonalArtifact);
        }

        public override string ToString()
        {
            return this.PropertiesToString();
        }

        public override bool Equals(object obj)
        {
            return this.EqualsByProperties(obj);
        }

        public bool Equals(DestinyEntitiesCharactersDestinyCharacterProgressionComponent other)
        {
            return Equals((object) other);
        }

        public override int GetHashCode()
        {
            return this.PropertiesHash();
        }

        /// <summary>
        /// Implementation of == operator for (DestinyEntitiesCharactersDestinyCharacterProgressionComponent.
        /// </summary>
        /// <param name="left">Compared (DestinyEntitiesCharactersDestinyCharacterProgressionComponent</param>
        /// <param name="right">Compared (DestinyEntitiesCharactersDestinyCharacterProgressionComponent</param>
        /// <returns>true if compared items are equals, false otherwise</returns>
        public static bool operator == (DestinyEntitiesCharactersDestinyCharacterProgressionComponent left, DestinyEntitiesCharactersDestinyCharacterProgressionComponent right)
        {
            return Equals(left, right);
        }

        /// <summary>
        /// Implementation of != operator for (DestinyEntitiesCharactersDestinyCharacterProgressionComponent.
        /// </summary>
        /// <param name="left">Compared (DestinyEntitiesCharactersDestinyCharacterProgressionComponent</param>
        /// <param name="right">Compared (DestinyEntitiesCharactersDestinyCharacterProgressionComponent</param>
        /// <returns>true if compared items are not equals, false otherwise</returns>
        public static bool operator != (DestinyEntitiesCharactersDestinyCharacterProgressionComponent left, DestinyEntitiesCharactersDestinyCharacterProgressionComponent right)
        {
            return !Equals(left, right);
        }

        /// <summary>
        /// Builder of DestinyEntitiesCharactersDestinyCharacterProgressionComponent.
        /// </summary>
        public sealed class DestinyEntitiesCharactersDestinyCharacterProgressionComponentBuilder
        {
            private Dictionary<string, DestinyDestinyProgression> _Progressions;
            private Dictionary<string, DestinyProgressionDestinyFactionProgression> _Factions;
            private Dictionary<string, DestinyMilestonesDestinyMilestone> _Milestones;
            private List<DestinyQuestsDestinyQuestStatus> _Quests;
            private Dictionary<string, List<DestinyQuestsDestinyObjectiveProgress>> _UninstancedItemObjectives;
            private Dictionary<string, Dictionary<string, bool?>> _Checklists;
            private DestinyArtifactsDestinyArtifactCharacterScoped _SeasonalArtifact;

            internal DestinyEntitiesCharactersDestinyCharacterProgressionComponentBuilder()
            {
                SetupDefaults();
            }

            private void SetupDefaults()
            {
            }

            /// <summary>
            /// Sets value for DestinyEntitiesCharactersDestinyCharacterProgressionComponent.Progressions property.
            /// </summary>
            /// <param name="value">A Dictionary of all known progressions for the Character, keyed by the Progression&#39;s hash.  Not all progressions have user-facing data, but those who do will have that data contained in the DestinyProgressionDefinition.</param>
            public DestinyEntitiesCharactersDestinyCharacterProgressionComponentBuilder Progressions(Dictionary<string, DestinyDestinyProgression> value)
            {
                _Progressions = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyEntitiesCharactersDestinyCharacterProgressionComponent.Factions property.
            /// </summary>
            /// <param name="value">A dictionary of all known Factions, keyed by the Faction&#39;s hash. It contains data about this character&#39;s status with the faction.</param>
            public DestinyEntitiesCharactersDestinyCharacterProgressionComponentBuilder Factions(Dictionary<string, DestinyProgressionDestinyFactionProgression> value)
            {
                _Factions = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyEntitiesCharactersDestinyCharacterProgressionComponent.Milestones property.
            /// </summary>
            /// <param name="value">Milestones are related to the simple progressions shown in the game, but return additional and hopefully helpful information for users about the specifics of the Milestone&#39;s status.</param>
            public DestinyEntitiesCharactersDestinyCharacterProgressionComponentBuilder Milestones(Dictionary<string, DestinyMilestonesDestinyMilestone> value)
            {
                _Milestones = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyEntitiesCharactersDestinyCharacterProgressionComponent.Quests property.
            /// </summary>
            /// <param name="value">If the user has any active quests, the quests&#39; statuses will be returned here.   Note that quests have been largely supplanted by Milestones, but that doesn&#39;t mean that they won&#39;t make a comeback independent of milestones at some point.   (Fun fact: quests came back as I feared they would, but we never looped back to populate this... I&#39;m going to put that in the backlog.)</param>
            public DestinyEntitiesCharactersDestinyCharacterProgressionComponentBuilder Quests(List<DestinyQuestsDestinyQuestStatus> value)
            {
                _Quests = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyEntitiesCharactersDestinyCharacterProgressionComponent.UninstancedItemObjectives property.
            /// </summary>
            /// <param name="value">Sometimes, you have items in your inventory that don&#39;t have instances, but still have Objective information. This provides you that objective information for uninstanced items.   This dictionary is keyed by the item&#39;s hash: which you can use to look up the name and description for the overall task(s) implied by the objective. The value is the list of objectives for this item, and their statuses.</param>
            public DestinyEntitiesCharactersDestinyCharacterProgressionComponentBuilder UninstancedItemObjectives(Dictionary<string, List<DestinyQuestsDestinyObjectiveProgress>> value)
            {
                _UninstancedItemObjectives = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyEntitiesCharactersDestinyCharacterProgressionComponent.Checklists property.
            /// </summary>
            /// <param name="value">The set of checklists that can be examined for this specific character, keyed by the hash identifier of the Checklist (DestinyChecklistDefinition)  For each checklist returned, its value is itself a Dictionary keyed by the checklist&#39;s hash identifier with the value being a boolean indicating if it&#39;s been discovered yet.</param>
            public DestinyEntitiesCharactersDestinyCharacterProgressionComponentBuilder Checklists(Dictionary<string, Dictionary<string, bool?>> value)
            {
                _Checklists = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyEntitiesCharactersDestinyCharacterProgressionComponent.SeasonalArtifact property.
            /// </summary>
            /// <param name="value">Data related to your progress on the current season&#39;s artifact that can vary per character.</param>
            public DestinyEntitiesCharactersDestinyCharacterProgressionComponentBuilder SeasonalArtifact(DestinyArtifactsDestinyArtifactCharacterScoped value)
            {
                _SeasonalArtifact = value;
                return this;
            }


            /// <summary>
            /// Builds instance of DestinyEntitiesCharactersDestinyCharacterProgressionComponent.
            /// </summary>
            /// <returns>DestinyEntitiesCharactersDestinyCharacterProgressionComponent</returns>
            public DestinyEntitiesCharactersDestinyCharacterProgressionComponent Build()
            {
                Validate();
                return new DestinyEntitiesCharactersDestinyCharacterProgressionComponent(
                    Progressions: _Progressions,
                    Factions: _Factions,
                    Milestones: _Milestones,
                    Quests: _Quests,
                    UninstancedItemObjectives: _UninstancedItemObjectives,
                    Checklists: _Checklists,
                    SeasonalArtifact: _SeasonalArtifact
                );
            }

            private void Validate()
            { 
            }
        }

        
    }
}