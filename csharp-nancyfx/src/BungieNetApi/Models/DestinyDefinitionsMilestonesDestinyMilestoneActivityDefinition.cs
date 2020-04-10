using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Sharpility.Extensions;
using NodaTime;

namespace BungieNetApi._Platform.Models
{
    /// <summary>
    /// Milestones can have associated activities which provide additional information about the context, challenges, modifiers, state etc... related to this Milestone.   Information we need to be able to return that data is defined here, along with Tier data to establish a relationship between a conceptual Activity and its difficulty levels and variants.
    /// </summary>
    public sealed class DestinyDefinitionsMilestonesDestinyMilestoneActivityDefinition:  IEquatable<DestinyDefinitionsMilestonesDestinyMilestoneActivityDefinition>
    { 
        /// <summary>
        /// The \&quot;Conceptual\&quot; activity hash. Basically, we picked the lowest level activity and are treating it as the canonical definition of the activity for rendering purposes.  If you care about the specific difficulty modes and variations, use the activities under \&quot;Variants\&quot;.
        /// </summary>
        public int? ConceptualActivityHash { get; private set; }

        /// <summary>
        /// A milestone-referenced activity can have many variants, such as Tiers or alternative modes of play.  Even if there is only a single variant, the details for these are represented within as a variant definition.  It is assumed that, if this DestinyMilestoneActivityDefinition is active, then all variants should be active.  If a Milestone could ever split the variants&#39; active status conditionally, they should all have their own DestinyMilestoneActivityDefinition instead! The potential duplication will be worth it for the obviousness of processing and use.
        /// </summary>
        public Dictionary<string, DestinyDefinitionsMilestonesDestinyMilestoneActivityVariantDefinition> Variants { get; private set; }


        /// <summary>
        /// Empty constructor required by some serializers.
        /// Use DestinyDefinitionsMilestonesDestinyMilestoneActivityDefinition.Builder() for instance creation instead.
        /// </summary>
        [Obsolete]
        public DestinyDefinitionsMilestonesDestinyMilestoneActivityDefinition()
        {
        }

        private DestinyDefinitionsMilestonesDestinyMilestoneActivityDefinition(int? ConceptualActivityHash, Dictionary<string, DestinyDefinitionsMilestonesDestinyMilestoneActivityVariantDefinition> Variants)
        {
            
            this.ConceptualActivityHash = ConceptualActivityHash;
            
            this.Variants = Variants;
            
        }

        /// <summary>
        /// Returns builder of DestinyDefinitionsMilestonesDestinyMilestoneActivityDefinition.
        /// </summary>
        /// <returns>DestinyDefinitionsMilestonesDestinyMilestoneActivityDefinitionBuilder</returns>
        public static DestinyDefinitionsMilestonesDestinyMilestoneActivityDefinitionBuilder Builder()
        {
            return new DestinyDefinitionsMilestonesDestinyMilestoneActivityDefinitionBuilder();
        }

        /// <summary>
        /// Returns DestinyDefinitionsMilestonesDestinyMilestoneActivityDefinitionBuilder with properties set.
        /// Use it to change properties.
        /// </summary>
        /// <returns>DestinyDefinitionsMilestonesDestinyMilestoneActivityDefinitionBuilder</returns>
        public DestinyDefinitionsMilestonesDestinyMilestoneActivityDefinitionBuilder With()
        {
            return Builder()
                .ConceptualActivityHash(ConceptualActivityHash)
                .Variants(Variants);
        }

        public override string ToString()
        {
            return this.PropertiesToString();
        }

        public override bool Equals(object obj)
        {
            return this.EqualsByProperties(obj);
        }

        public bool Equals(DestinyDefinitionsMilestonesDestinyMilestoneActivityDefinition other)
        {
            return Equals((object) other);
        }

        public override int GetHashCode()
        {
            return this.PropertiesHash();
        }

        /// <summary>
        /// Implementation of == operator for (DestinyDefinitionsMilestonesDestinyMilestoneActivityDefinition.
        /// </summary>
        /// <param name="left">Compared (DestinyDefinitionsMilestonesDestinyMilestoneActivityDefinition</param>
        /// <param name="right">Compared (DestinyDefinitionsMilestonesDestinyMilestoneActivityDefinition</param>
        /// <returns>true if compared items are equals, false otherwise</returns>
        public static bool operator == (DestinyDefinitionsMilestonesDestinyMilestoneActivityDefinition left, DestinyDefinitionsMilestonesDestinyMilestoneActivityDefinition right)
        {
            return Equals(left, right);
        }

        /// <summary>
        /// Implementation of != operator for (DestinyDefinitionsMilestonesDestinyMilestoneActivityDefinition.
        /// </summary>
        /// <param name="left">Compared (DestinyDefinitionsMilestonesDestinyMilestoneActivityDefinition</param>
        /// <param name="right">Compared (DestinyDefinitionsMilestonesDestinyMilestoneActivityDefinition</param>
        /// <returns>true if compared items are not equals, false otherwise</returns>
        public static bool operator != (DestinyDefinitionsMilestonesDestinyMilestoneActivityDefinition left, DestinyDefinitionsMilestonesDestinyMilestoneActivityDefinition right)
        {
            return !Equals(left, right);
        }

        /// <summary>
        /// Builder of DestinyDefinitionsMilestonesDestinyMilestoneActivityDefinition.
        /// </summary>
        public sealed class DestinyDefinitionsMilestonesDestinyMilestoneActivityDefinitionBuilder
        {
            private int? _ConceptualActivityHash;
            private Dictionary<string, DestinyDefinitionsMilestonesDestinyMilestoneActivityVariantDefinition> _Variants;

            internal DestinyDefinitionsMilestonesDestinyMilestoneActivityDefinitionBuilder()
            {
                SetupDefaults();
            }

            private void SetupDefaults()
            {
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsMilestonesDestinyMilestoneActivityDefinition.ConceptualActivityHash property.
            /// </summary>
            /// <param name="value">The \&quot;Conceptual\&quot; activity hash. Basically, we picked the lowest level activity and are treating it as the canonical definition of the activity for rendering purposes.  If you care about the specific difficulty modes and variations, use the activities under \&quot;Variants\&quot;.</param>
            public DestinyDefinitionsMilestonesDestinyMilestoneActivityDefinitionBuilder ConceptualActivityHash(int? value)
            {
                _ConceptualActivityHash = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsMilestonesDestinyMilestoneActivityDefinition.Variants property.
            /// </summary>
            /// <param name="value">A milestone-referenced activity can have many variants, such as Tiers or alternative modes of play.  Even if there is only a single variant, the details for these are represented within as a variant definition.  It is assumed that, if this DestinyMilestoneActivityDefinition is active, then all variants should be active.  If a Milestone could ever split the variants&#39; active status conditionally, they should all have their own DestinyMilestoneActivityDefinition instead! The potential duplication will be worth it for the obviousness of processing and use.</param>
            public DestinyDefinitionsMilestonesDestinyMilestoneActivityDefinitionBuilder Variants(Dictionary<string, DestinyDefinitionsMilestonesDestinyMilestoneActivityVariantDefinition> value)
            {
                _Variants = value;
                return this;
            }


            /// <summary>
            /// Builds instance of DestinyDefinitionsMilestonesDestinyMilestoneActivityDefinition.
            /// </summary>
            /// <returns>DestinyDefinitionsMilestonesDestinyMilestoneActivityDefinition</returns>
            public DestinyDefinitionsMilestonesDestinyMilestoneActivityDefinition Build()
            {
                Validate();
                return new DestinyDefinitionsMilestonesDestinyMilestoneActivityDefinition(
                    ConceptualActivityHash: _ConceptualActivityHash,
                    Variants: _Variants
                );
            }

            private void Validate()
            { 
            }
        }

        
    }
}