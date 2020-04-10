using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Sharpility.Extensions;
using NodaTime;

namespace BungieNetApi._Platform.Models
{
    /// <summary>
    /// This property has some history. A talent grid can provide stats on both the item it&#39;s related to and the character equipping the item. This returns data about those stat bonuses.
    /// </summary>
    public sealed class DestinyDestinyTalentNodeStatBlock:  IEquatable<DestinyDestinyTalentNodeStatBlock>
    { 
        /// <summary>
        /// The stat benefits conferred when this talent node is activated for the current Step that is active on the node.
        /// </summary>
        public List<DestinyDestinyStat> CurrentStepStats { get; private set; }

        /// <summary>
        /// This is a holdover from the old days of Destiny 1, when a node could be activated multiple times, conferring multiple steps worth of benefits: you would use this property to show what activating the \&quot;next\&quot; step on the node would provide vs. what the current step is providing. While Nodes are currently not being used this way, the underlying system for this functionality still exists. I hesitate to remove this property while the ability for designers to make such a talent grid still exists. Whether you want to show it is up to you.
        /// </summary>
        public List<DestinyDestinyStat> NextStepStats { get; private set; }


        /// <summary>
        /// Empty constructor required by some serializers.
        /// Use DestinyDestinyTalentNodeStatBlock.Builder() for instance creation instead.
        /// </summary>
        [Obsolete]
        public DestinyDestinyTalentNodeStatBlock()
        {
        }

        private DestinyDestinyTalentNodeStatBlock(List<DestinyDestinyStat> CurrentStepStats, List<DestinyDestinyStat> NextStepStats)
        {
            
            this.CurrentStepStats = CurrentStepStats;
            
            this.NextStepStats = NextStepStats;
            
        }

        /// <summary>
        /// Returns builder of DestinyDestinyTalentNodeStatBlock.
        /// </summary>
        /// <returns>DestinyDestinyTalentNodeStatBlockBuilder</returns>
        public static DestinyDestinyTalentNodeStatBlockBuilder Builder()
        {
            return new DestinyDestinyTalentNodeStatBlockBuilder();
        }

        /// <summary>
        /// Returns DestinyDestinyTalentNodeStatBlockBuilder with properties set.
        /// Use it to change properties.
        /// </summary>
        /// <returns>DestinyDestinyTalentNodeStatBlockBuilder</returns>
        public DestinyDestinyTalentNodeStatBlockBuilder With()
        {
            return Builder()
                .CurrentStepStats(CurrentStepStats)
                .NextStepStats(NextStepStats);
        }

        public override string ToString()
        {
            return this.PropertiesToString();
        }

        public override bool Equals(object obj)
        {
            return this.EqualsByProperties(obj);
        }

        public bool Equals(DestinyDestinyTalentNodeStatBlock other)
        {
            return Equals((object) other);
        }

        public override int GetHashCode()
        {
            return this.PropertiesHash();
        }

        /// <summary>
        /// Implementation of == operator for (DestinyDestinyTalentNodeStatBlock.
        /// </summary>
        /// <param name="left">Compared (DestinyDestinyTalentNodeStatBlock</param>
        /// <param name="right">Compared (DestinyDestinyTalentNodeStatBlock</param>
        /// <returns>true if compared items are equals, false otherwise</returns>
        public static bool operator == (DestinyDestinyTalentNodeStatBlock left, DestinyDestinyTalentNodeStatBlock right)
        {
            return Equals(left, right);
        }

        /// <summary>
        /// Implementation of != operator for (DestinyDestinyTalentNodeStatBlock.
        /// </summary>
        /// <param name="left">Compared (DestinyDestinyTalentNodeStatBlock</param>
        /// <param name="right">Compared (DestinyDestinyTalentNodeStatBlock</param>
        /// <returns>true if compared items are not equals, false otherwise</returns>
        public static bool operator != (DestinyDestinyTalentNodeStatBlock left, DestinyDestinyTalentNodeStatBlock right)
        {
            return !Equals(left, right);
        }

        /// <summary>
        /// Builder of DestinyDestinyTalentNodeStatBlock.
        /// </summary>
        public sealed class DestinyDestinyTalentNodeStatBlockBuilder
        {
            private List<DestinyDestinyStat> _CurrentStepStats;
            private List<DestinyDestinyStat> _NextStepStats;

            internal DestinyDestinyTalentNodeStatBlockBuilder()
            {
                SetupDefaults();
            }

            private void SetupDefaults()
            {
            }

            /// <summary>
            /// Sets value for DestinyDestinyTalentNodeStatBlock.CurrentStepStats property.
            /// </summary>
            /// <param name="value">The stat benefits conferred when this talent node is activated for the current Step that is active on the node.</param>
            public DestinyDestinyTalentNodeStatBlockBuilder CurrentStepStats(List<DestinyDestinyStat> value)
            {
                _CurrentStepStats = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDestinyTalentNodeStatBlock.NextStepStats property.
            /// </summary>
            /// <param name="value">This is a holdover from the old days of Destiny 1, when a node could be activated multiple times, conferring multiple steps worth of benefits: you would use this property to show what activating the \&quot;next\&quot; step on the node would provide vs. what the current step is providing. While Nodes are currently not being used this way, the underlying system for this functionality still exists. I hesitate to remove this property while the ability for designers to make such a talent grid still exists. Whether you want to show it is up to you.</param>
            public DestinyDestinyTalentNodeStatBlockBuilder NextStepStats(List<DestinyDestinyStat> value)
            {
                _NextStepStats = value;
                return this;
            }


            /// <summary>
            /// Builds instance of DestinyDestinyTalentNodeStatBlock.
            /// </summary>
            /// <returns>DestinyDestinyTalentNodeStatBlock</returns>
            public DestinyDestinyTalentNodeStatBlock Build()
            {
                Validate();
                return new DestinyDestinyTalentNodeStatBlock(
                    CurrentStepStats: _CurrentStepStats,
                    NextStepStats: _NextStepStats
                );
            }

            private void Validate()
            { 
            }
        }

        
    }
}