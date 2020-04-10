using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Sharpility.Extensions;
using NodaTime;

namespace BungieNetApi._Platform.Models
{
    /// <summary>
    /// These are pre-constructed collections of data that can be used to determine the Level Requirement for an item given a Progression to be tested (such as the Character&#39;s level).  For instance, say a character receives a new Auto Rifle, and that Auto Rifle&#39;s DestinyInventoryItemDefinition.quality.progressionLevelRequirementHash property is pointing at one of these DestinyProgressionLevelRequirementDefinitions. Let&#39;s pretend also that the progressionHash it is pointing at is the Character Level progression. In that situation, the character&#39;s level will be used to interpolate a value in the requirementCurve property. The value picked up from that interpolation will be the required level for the item.
    /// </summary>
    public sealed class DestinyDefinitionsProgressionDestinyProgressionLevelRequirementDefinition:  IEquatable<DestinyDefinitionsProgressionDestinyProgressionLevelRequirementDefinition>
    { 
        /// <summary>
        /// A curve of level requirements, weighted by the related progressions&#39; level.  Interpolate against this curve with the character&#39;s progression level to determine what the level requirement of the generated item that is using this data will be.
        /// </summary>
        public List<InterpolationInterpolationPointFloat> RequirementCurve { get; private set; }

        /// <summary>
        /// The progression whose level should be used to determine the level requirement.  Look up the DestinyProgressionDefinition with this hash for more information about the progression in question.
        /// </summary>
        public int? ProgressionHash { get; private set; }

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
        /// Use DestinyDefinitionsProgressionDestinyProgressionLevelRequirementDefinition.Builder() for instance creation instead.
        /// </summary>
        [Obsolete]
        public DestinyDefinitionsProgressionDestinyProgressionLevelRequirementDefinition()
        {
        }

        private DestinyDefinitionsProgressionDestinyProgressionLevelRequirementDefinition(List<InterpolationInterpolationPointFloat> RequirementCurve, int? ProgressionHash, int? Hash, int? Index, bool? Redacted)
        {
            
            this.RequirementCurve = RequirementCurve;
            
            this.ProgressionHash = ProgressionHash;
            
            this.Hash = Hash;
            
            this.Index = Index;
            
            this.Redacted = Redacted;
            
        }

        /// <summary>
        /// Returns builder of DestinyDefinitionsProgressionDestinyProgressionLevelRequirementDefinition.
        /// </summary>
        /// <returns>DestinyDefinitionsProgressionDestinyProgressionLevelRequirementDefinitionBuilder</returns>
        public static DestinyDefinitionsProgressionDestinyProgressionLevelRequirementDefinitionBuilder Builder()
        {
            return new DestinyDefinitionsProgressionDestinyProgressionLevelRequirementDefinitionBuilder();
        }

        /// <summary>
        /// Returns DestinyDefinitionsProgressionDestinyProgressionLevelRequirementDefinitionBuilder with properties set.
        /// Use it to change properties.
        /// </summary>
        /// <returns>DestinyDefinitionsProgressionDestinyProgressionLevelRequirementDefinitionBuilder</returns>
        public DestinyDefinitionsProgressionDestinyProgressionLevelRequirementDefinitionBuilder With()
        {
            return Builder()
                .RequirementCurve(RequirementCurve)
                .ProgressionHash(ProgressionHash)
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

        public bool Equals(DestinyDefinitionsProgressionDestinyProgressionLevelRequirementDefinition other)
        {
            return Equals((object) other);
        }

        public override int GetHashCode()
        {
            return this.PropertiesHash();
        }

        /// <summary>
        /// Implementation of == operator for (DestinyDefinitionsProgressionDestinyProgressionLevelRequirementDefinition.
        /// </summary>
        /// <param name="left">Compared (DestinyDefinitionsProgressionDestinyProgressionLevelRequirementDefinition</param>
        /// <param name="right">Compared (DestinyDefinitionsProgressionDestinyProgressionLevelRequirementDefinition</param>
        /// <returns>true if compared items are equals, false otherwise</returns>
        public static bool operator == (DestinyDefinitionsProgressionDestinyProgressionLevelRequirementDefinition left, DestinyDefinitionsProgressionDestinyProgressionLevelRequirementDefinition right)
        {
            return Equals(left, right);
        }

        /// <summary>
        /// Implementation of != operator for (DestinyDefinitionsProgressionDestinyProgressionLevelRequirementDefinition.
        /// </summary>
        /// <param name="left">Compared (DestinyDefinitionsProgressionDestinyProgressionLevelRequirementDefinition</param>
        /// <param name="right">Compared (DestinyDefinitionsProgressionDestinyProgressionLevelRequirementDefinition</param>
        /// <returns>true if compared items are not equals, false otherwise</returns>
        public static bool operator != (DestinyDefinitionsProgressionDestinyProgressionLevelRequirementDefinition left, DestinyDefinitionsProgressionDestinyProgressionLevelRequirementDefinition right)
        {
            return !Equals(left, right);
        }

        /// <summary>
        /// Builder of DestinyDefinitionsProgressionDestinyProgressionLevelRequirementDefinition.
        /// </summary>
        public sealed class DestinyDefinitionsProgressionDestinyProgressionLevelRequirementDefinitionBuilder
        {
            private List<InterpolationInterpolationPointFloat> _RequirementCurve;
            private int? _ProgressionHash;
            private int? _Hash;
            private int? _Index;
            private bool? _Redacted;

            internal DestinyDefinitionsProgressionDestinyProgressionLevelRequirementDefinitionBuilder()
            {
                SetupDefaults();
            }

            private void SetupDefaults()
            {
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsProgressionDestinyProgressionLevelRequirementDefinition.RequirementCurve property.
            /// </summary>
            /// <param name="value">A curve of level requirements, weighted by the related progressions&#39; level.  Interpolate against this curve with the character&#39;s progression level to determine what the level requirement of the generated item that is using this data will be.</param>
            public DestinyDefinitionsProgressionDestinyProgressionLevelRequirementDefinitionBuilder RequirementCurve(List<InterpolationInterpolationPointFloat> value)
            {
                _RequirementCurve = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsProgressionDestinyProgressionLevelRequirementDefinition.ProgressionHash property.
            /// </summary>
            /// <param name="value">The progression whose level should be used to determine the level requirement.  Look up the DestinyProgressionDefinition with this hash for more information about the progression in question.</param>
            public DestinyDefinitionsProgressionDestinyProgressionLevelRequirementDefinitionBuilder ProgressionHash(int? value)
            {
                _ProgressionHash = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsProgressionDestinyProgressionLevelRequirementDefinition.Hash property.
            /// </summary>
            /// <param name="value">The unique identifier for this entity. Guaranteed to be unique for the type of entity, but not globally.  When entities refer to each other in Destiny content, it is this hash that they are referring to.</param>
            public DestinyDefinitionsProgressionDestinyProgressionLevelRequirementDefinitionBuilder Hash(int? value)
            {
                _Hash = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsProgressionDestinyProgressionLevelRequirementDefinition.Index property.
            /// </summary>
            /// <param name="value">The index of the entity as it was found in the investment tables.</param>
            public DestinyDefinitionsProgressionDestinyProgressionLevelRequirementDefinitionBuilder Index(int? value)
            {
                _Index = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsProgressionDestinyProgressionLevelRequirementDefinition.Redacted property.
            /// </summary>
            /// <param name="value">If this is true, then there is an entity with this identifier/type combination, but BNet is not yet allowed to show it. Sorry!</param>
            public DestinyDefinitionsProgressionDestinyProgressionLevelRequirementDefinitionBuilder Redacted(bool? value)
            {
                _Redacted = value;
                return this;
            }


            /// <summary>
            /// Builds instance of DestinyDefinitionsProgressionDestinyProgressionLevelRequirementDefinition.
            /// </summary>
            /// <returns>DestinyDefinitionsProgressionDestinyProgressionLevelRequirementDefinition</returns>
            public DestinyDefinitionsProgressionDestinyProgressionLevelRequirementDefinition Build()
            {
                Validate();
                return new DestinyDefinitionsProgressionDestinyProgressionLevelRequirementDefinition(
                    RequirementCurve: _RequirementCurve,
                    ProgressionHash: _ProgressionHash,
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