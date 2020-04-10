using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Sharpility.Extensions;
using NodaTime;

namespace BungieNetApi._Platform.Models
{
    /// <summary>
    /// Items can have objectives and progression. When you request this block, you will obtain information about any Objectives and progression tied to this item.
    /// </summary>
    public sealed class DestinyEntitiesItemsDestinyItemObjectivesComponent:  IEquatable<DestinyEntitiesItemsDestinyItemObjectivesComponent>
    { 
        /// <summary>
        /// If the item has a hard association with objectives, your progress on them will be defined here.   Objectives are our standard way to describe a series of tasks that have to be completed for a reward.
        /// </summary>
        public List<DestinyQuestsDestinyObjectiveProgress> Objectives { get; private set; }

        /// <summary>
        /// I may regret naming it this way - but this represents when an item has an objective that doesn&#39;t serve a beneficial purpose, but rather is used for \&quot;flavor\&quot; or additional information. For instance, when Emblems track specific stats, those stats are represented as Objectives on the item.
        /// </summary>
        public DestinyQuestsDestinyObjectiveProgress FlavorObjective { get; private set; }

        /// <summary>
        /// If we have any information on when these objectives were completed, this will be the date of that completion. This won&#39;t be on many items, but could be interesting for some items that do store this information.
        /// </summary>
        public DateTime? DateCompleted { get; private set; }


        /// <summary>
        /// Empty constructor required by some serializers.
        /// Use DestinyEntitiesItemsDestinyItemObjectivesComponent.Builder() for instance creation instead.
        /// </summary>
        [Obsolete]
        public DestinyEntitiesItemsDestinyItemObjectivesComponent()
        {
        }

        private DestinyEntitiesItemsDestinyItemObjectivesComponent(List<DestinyQuestsDestinyObjectiveProgress> Objectives, DestinyQuestsDestinyObjectiveProgress FlavorObjective, DateTime? DateCompleted)
        {
            
            this.Objectives = Objectives;
            
            this.FlavorObjective = FlavorObjective;
            
            this.DateCompleted = DateCompleted;
            
        }

        /// <summary>
        /// Returns builder of DestinyEntitiesItemsDestinyItemObjectivesComponent.
        /// </summary>
        /// <returns>DestinyEntitiesItemsDestinyItemObjectivesComponentBuilder</returns>
        public static DestinyEntitiesItemsDestinyItemObjectivesComponentBuilder Builder()
        {
            return new DestinyEntitiesItemsDestinyItemObjectivesComponentBuilder();
        }

        /// <summary>
        /// Returns DestinyEntitiesItemsDestinyItemObjectivesComponentBuilder with properties set.
        /// Use it to change properties.
        /// </summary>
        /// <returns>DestinyEntitiesItemsDestinyItemObjectivesComponentBuilder</returns>
        public DestinyEntitiesItemsDestinyItemObjectivesComponentBuilder With()
        {
            return Builder()
                .Objectives(Objectives)
                .FlavorObjective(FlavorObjective)
                .DateCompleted(DateCompleted);
        }

        public override string ToString()
        {
            return this.PropertiesToString();
        }

        public override bool Equals(object obj)
        {
            return this.EqualsByProperties(obj);
        }

        public bool Equals(DestinyEntitiesItemsDestinyItemObjectivesComponent other)
        {
            return Equals((object) other);
        }

        public override int GetHashCode()
        {
            return this.PropertiesHash();
        }

        /// <summary>
        /// Implementation of == operator for (DestinyEntitiesItemsDestinyItemObjectivesComponent.
        /// </summary>
        /// <param name="left">Compared (DestinyEntitiesItemsDestinyItemObjectivesComponent</param>
        /// <param name="right">Compared (DestinyEntitiesItemsDestinyItemObjectivesComponent</param>
        /// <returns>true if compared items are equals, false otherwise</returns>
        public static bool operator == (DestinyEntitiesItemsDestinyItemObjectivesComponent left, DestinyEntitiesItemsDestinyItemObjectivesComponent right)
        {
            return Equals(left, right);
        }

        /// <summary>
        /// Implementation of != operator for (DestinyEntitiesItemsDestinyItemObjectivesComponent.
        /// </summary>
        /// <param name="left">Compared (DestinyEntitiesItemsDestinyItemObjectivesComponent</param>
        /// <param name="right">Compared (DestinyEntitiesItemsDestinyItemObjectivesComponent</param>
        /// <returns>true if compared items are not equals, false otherwise</returns>
        public static bool operator != (DestinyEntitiesItemsDestinyItemObjectivesComponent left, DestinyEntitiesItemsDestinyItemObjectivesComponent right)
        {
            return !Equals(left, right);
        }

        /// <summary>
        /// Builder of DestinyEntitiesItemsDestinyItemObjectivesComponent.
        /// </summary>
        public sealed class DestinyEntitiesItemsDestinyItemObjectivesComponentBuilder
        {
            private List<DestinyQuestsDestinyObjectiveProgress> _Objectives;
            private DestinyQuestsDestinyObjectiveProgress _FlavorObjective;
            private DateTime? _DateCompleted;

            internal DestinyEntitiesItemsDestinyItemObjectivesComponentBuilder()
            {
                SetupDefaults();
            }

            private void SetupDefaults()
            {
            }

            /// <summary>
            /// Sets value for DestinyEntitiesItemsDestinyItemObjectivesComponent.Objectives property.
            /// </summary>
            /// <param name="value">If the item has a hard association with objectives, your progress on them will be defined here.   Objectives are our standard way to describe a series of tasks that have to be completed for a reward.</param>
            public DestinyEntitiesItemsDestinyItemObjectivesComponentBuilder Objectives(List<DestinyQuestsDestinyObjectiveProgress> value)
            {
                _Objectives = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyEntitiesItemsDestinyItemObjectivesComponent.FlavorObjective property.
            /// </summary>
            /// <param name="value">I may regret naming it this way - but this represents when an item has an objective that doesn&#39;t serve a beneficial purpose, but rather is used for \&quot;flavor\&quot; or additional information. For instance, when Emblems track specific stats, those stats are represented as Objectives on the item.</param>
            public DestinyEntitiesItemsDestinyItemObjectivesComponentBuilder FlavorObjective(DestinyQuestsDestinyObjectiveProgress value)
            {
                _FlavorObjective = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyEntitiesItemsDestinyItemObjectivesComponent.DateCompleted property.
            /// </summary>
            /// <param name="value">If we have any information on when these objectives were completed, this will be the date of that completion. This won&#39;t be on many items, but could be interesting for some items that do store this information.</param>
            public DestinyEntitiesItemsDestinyItemObjectivesComponentBuilder DateCompleted(DateTime? value)
            {
                _DateCompleted = value;
                return this;
            }


            /// <summary>
            /// Builds instance of DestinyEntitiesItemsDestinyItemObjectivesComponent.
            /// </summary>
            /// <returns>DestinyEntitiesItemsDestinyItemObjectivesComponent</returns>
            public DestinyEntitiesItemsDestinyItemObjectivesComponent Build()
            {
                Validate();
                return new DestinyEntitiesItemsDestinyItemObjectivesComponent(
                    Objectives: _Objectives,
                    FlavorObjective: _FlavorObjective,
                    DateCompleted: _DateCompleted
                );
            }

            private void Validate()
            { 
            }
        }

        
    }
}