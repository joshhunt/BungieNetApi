using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Sharpility.Extensions;
using NodaTime;

namespace BungieNetApi._Platform.Models
{
    /// <summary>
    /// Represents a variant on an activity for a Milestone: a specific difficulty tier, or a specific activity variant for example.  These will often have more specific details, such as an associated Guided Game, progression steps, tier-specific rewards, and custom values.
    /// </summary>
    public sealed class DestinyDefinitionsMilestonesDestinyMilestoneActivityVariantDefinition:  IEquatable<DestinyDefinitionsMilestonesDestinyMilestoneActivityVariantDefinition>
    { 
        /// <summary>
        /// The hash to use for looking up the variant Activity&#39;s definition (DestinyActivityDefinition), where you can find its distinguishing characteristics such as difficulty level and recommended light level.   Frequently, that will be the only distinguishing characteristics in practice, which is somewhat of a bummer.
        /// </summary>
        public int? ActivityHash { get; private set; }

        /// <summary>
        /// If you care to do so, render the variants in the order prescribed by this value.  When you combine live Milestone data with the definition, the order becomes more useful because you&#39;ll be cross-referencing between the definition and live data.
        /// </summary>
        public int? Order { get; private set; }


        /// <summary>
        /// Empty constructor required by some serializers.
        /// Use DestinyDefinitionsMilestonesDestinyMilestoneActivityVariantDefinition.Builder() for instance creation instead.
        /// </summary>
        [Obsolete]
        public DestinyDefinitionsMilestonesDestinyMilestoneActivityVariantDefinition()
        {
        }

        private DestinyDefinitionsMilestonesDestinyMilestoneActivityVariantDefinition(int? ActivityHash, int? Order)
        {
            
            this.ActivityHash = ActivityHash;
            
            this.Order = Order;
            
        }

        /// <summary>
        /// Returns builder of DestinyDefinitionsMilestonesDestinyMilestoneActivityVariantDefinition.
        /// </summary>
        /// <returns>DestinyDefinitionsMilestonesDestinyMilestoneActivityVariantDefinitionBuilder</returns>
        public static DestinyDefinitionsMilestonesDestinyMilestoneActivityVariantDefinitionBuilder Builder()
        {
            return new DestinyDefinitionsMilestonesDestinyMilestoneActivityVariantDefinitionBuilder();
        }

        /// <summary>
        /// Returns DestinyDefinitionsMilestonesDestinyMilestoneActivityVariantDefinitionBuilder with properties set.
        /// Use it to change properties.
        /// </summary>
        /// <returns>DestinyDefinitionsMilestonesDestinyMilestoneActivityVariantDefinitionBuilder</returns>
        public DestinyDefinitionsMilestonesDestinyMilestoneActivityVariantDefinitionBuilder With()
        {
            return Builder()
                .ActivityHash(ActivityHash)
                .Order(Order);
        }

        public override string ToString()
        {
            return this.PropertiesToString();
        }

        public override bool Equals(object obj)
        {
            return this.EqualsByProperties(obj);
        }

        public bool Equals(DestinyDefinitionsMilestonesDestinyMilestoneActivityVariantDefinition other)
        {
            return Equals((object) other);
        }

        public override int GetHashCode()
        {
            return this.PropertiesHash();
        }

        /// <summary>
        /// Implementation of == operator for (DestinyDefinitionsMilestonesDestinyMilestoneActivityVariantDefinition.
        /// </summary>
        /// <param name="left">Compared (DestinyDefinitionsMilestonesDestinyMilestoneActivityVariantDefinition</param>
        /// <param name="right">Compared (DestinyDefinitionsMilestonesDestinyMilestoneActivityVariantDefinition</param>
        /// <returns>true if compared items are equals, false otherwise</returns>
        public static bool operator == (DestinyDefinitionsMilestonesDestinyMilestoneActivityVariantDefinition left, DestinyDefinitionsMilestonesDestinyMilestoneActivityVariantDefinition right)
        {
            return Equals(left, right);
        }

        /// <summary>
        /// Implementation of != operator for (DestinyDefinitionsMilestonesDestinyMilestoneActivityVariantDefinition.
        /// </summary>
        /// <param name="left">Compared (DestinyDefinitionsMilestonesDestinyMilestoneActivityVariantDefinition</param>
        /// <param name="right">Compared (DestinyDefinitionsMilestonesDestinyMilestoneActivityVariantDefinition</param>
        /// <returns>true if compared items are not equals, false otherwise</returns>
        public static bool operator != (DestinyDefinitionsMilestonesDestinyMilestoneActivityVariantDefinition left, DestinyDefinitionsMilestonesDestinyMilestoneActivityVariantDefinition right)
        {
            return !Equals(left, right);
        }

        /// <summary>
        /// Builder of DestinyDefinitionsMilestonesDestinyMilestoneActivityVariantDefinition.
        /// </summary>
        public sealed class DestinyDefinitionsMilestonesDestinyMilestoneActivityVariantDefinitionBuilder
        {
            private int? _ActivityHash;
            private int? _Order;

            internal DestinyDefinitionsMilestonesDestinyMilestoneActivityVariantDefinitionBuilder()
            {
                SetupDefaults();
            }

            private void SetupDefaults()
            {
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsMilestonesDestinyMilestoneActivityVariantDefinition.ActivityHash property.
            /// </summary>
            /// <param name="value">The hash to use for looking up the variant Activity&#39;s definition (DestinyActivityDefinition), where you can find its distinguishing characteristics such as difficulty level and recommended light level.   Frequently, that will be the only distinguishing characteristics in practice, which is somewhat of a bummer.</param>
            public DestinyDefinitionsMilestonesDestinyMilestoneActivityVariantDefinitionBuilder ActivityHash(int? value)
            {
                _ActivityHash = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsMilestonesDestinyMilestoneActivityVariantDefinition.Order property.
            /// </summary>
            /// <param name="value">If you care to do so, render the variants in the order prescribed by this value.  When you combine live Milestone data with the definition, the order becomes more useful because you&#39;ll be cross-referencing between the definition and live data.</param>
            public DestinyDefinitionsMilestonesDestinyMilestoneActivityVariantDefinitionBuilder Order(int? value)
            {
                _Order = value;
                return this;
            }


            /// <summary>
            /// Builds instance of DestinyDefinitionsMilestonesDestinyMilestoneActivityVariantDefinition.
            /// </summary>
            /// <returns>DestinyDefinitionsMilestonesDestinyMilestoneActivityVariantDefinition</returns>
            public DestinyDefinitionsMilestonesDestinyMilestoneActivityVariantDefinition Build()
            {
                Validate();
                return new DestinyDefinitionsMilestonesDestinyMilestoneActivityVariantDefinition(
                    ActivityHash: _ActivityHash,
                    Order: _Order
                );
            }

            private void Validate()
            { 
            }
        }

        
    }
}