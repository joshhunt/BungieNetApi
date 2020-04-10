using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Sharpility.Extensions;
using NodaTime;

namespace BungieNetApi._Platform.Models
{
    /// <summary>
    /// Well, we&#39;re here in Destiny 2, and Talent Grids are unfortunately still around.  The good news is that they&#39;re pretty much only being used for certain base information on items and for Builds/Subclasses. The bad news is that they still suck. If you really want this information, grab this component.  An important note is that talent grids are defined as such:  A Grid has 1:M Nodes, which has 1:M Steps.  Any given node can only have a single step active at one time, which represents the actual visual contents and effects of the Node (for instance, if you see a \&quot;Super Cool Bonus\&quot; node, the actual icon and text for the node is coming from the current Step of that node).  Nodes can be grouped into exclusivity sets *and* as of D2, exclusivity groups (which are collections of exclusivity sets that affect each other).  See DestinyTalentGridDefinition for more information. Brace yourself, the water&#39;s cold out there in the deep end.
    /// </summary>
    public sealed class DestinyEntitiesItemsDestinyItemTalentGridComponent:  IEquatable<DestinyEntitiesItemsDestinyItemTalentGridComponent>
    { 
        /// <summary>
        /// Most items don&#39;t have useful talent grids anymore, but Builds in particular still do.  You can use this hash to lookup the DestinyTalentGridDefinition attached to this item, which will be crucial for understanding the node values on the item.
        /// </summary>
        public int? TalentGridHash { get; private set; }

        /// <summary>
        /// Detailed information about the individual nodes in the talent grid.  A node represents a single visual \&quot;pip\&quot; in the talent grid or Build detail view, though each node may have multiple \&quot;steps\&quot; which indicate the actual bonuses and visual representation of that node.
        /// </summary>
        public List<DestinyDestinyTalentNode> Nodes { get; private set; }

        /// <summary>
        /// Indicates whether the talent grid on this item is completed, and thus whether it should have a gold border around it.  Only will be true if the item actually *has* a talent grid, and only then if it is completed (i.e. every exclusive set has an activated node, and every non-exclusive set node has been activated)
        /// </summary>
        public bool? IsGridComplete { get; private set; }

        /// <summary>
        /// If the item has a progression, it will be detailed here. A progression means that the item can gain experience. Thresholds of experience are what determines whether and when a talent node can be activated.
        /// </summary>
        public DestinyDestinyProgression GridProgression { get; private set; }


        /// <summary>
        /// Empty constructor required by some serializers.
        /// Use DestinyEntitiesItemsDestinyItemTalentGridComponent.Builder() for instance creation instead.
        /// </summary>
        [Obsolete]
        public DestinyEntitiesItemsDestinyItemTalentGridComponent()
        {
        }

        private DestinyEntitiesItemsDestinyItemTalentGridComponent(int? TalentGridHash, List<DestinyDestinyTalentNode> Nodes, bool? IsGridComplete, DestinyDestinyProgression GridProgression)
        {
            
            this.TalentGridHash = TalentGridHash;
            
            this.Nodes = Nodes;
            
            this.IsGridComplete = IsGridComplete;
            
            this.GridProgression = GridProgression;
            
        }

        /// <summary>
        /// Returns builder of DestinyEntitiesItemsDestinyItemTalentGridComponent.
        /// </summary>
        /// <returns>DestinyEntitiesItemsDestinyItemTalentGridComponentBuilder</returns>
        public static DestinyEntitiesItemsDestinyItemTalentGridComponentBuilder Builder()
        {
            return new DestinyEntitiesItemsDestinyItemTalentGridComponentBuilder();
        }

        /// <summary>
        /// Returns DestinyEntitiesItemsDestinyItemTalentGridComponentBuilder with properties set.
        /// Use it to change properties.
        /// </summary>
        /// <returns>DestinyEntitiesItemsDestinyItemTalentGridComponentBuilder</returns>
        public DestinyEntitiesItemsDestinyItemTalentGridComponentBuilder With()
        {
            return Builder()
                .TalentGridHash(TalentGridHash)
                .Nodes(Nodes)
                .IsGridComplete(IsGridComplete)
                .GridProgression(GridProgression);
        }

        public override string ToString()
        {
            return this.PropertiesToString();
        }

        public override bool Equals(object obj)
        {
            return this.EqualsByProperties(obj);
        }

        public bool Equals(DestinyEntitiesItemsDestinyItemTalentGridComponent other)
        {
            return Equals((object) other);
        }

        public override int GetHashCode()
        {
            return this.PropertiesHash();
        }

        /// <summary>
        /// Implementation of == operator for (DestinyEntitiesItemsDestinyItemTalentGridComponent.
        /// </summary>
        /// <param name="left">Compared (DestinyEntitiesItemsDestinyItemTalentGridComponent</param>
        /// <param name="right">Compared (DestinyEntitiesItemsDestinyItemTalentGridComponent</param>
        /// <returns>true if compared items are equals, false otherwise</returns>
        public static bool operator == (DestinyEntitiesItemsDestinyItemTalentGridComponent left, DestinyEntitiesItemsDestinyItemTalentGridComponent right)
        {
            return Equals(left, right);
        }

        /// <summary>
        /// Implementation of != operator for (DestinyEntitiesItemsDestinyItemTalentGridComponent.
        /// </summary>
        /// <param name="left">Compared (DestinyEntitiesItemsDestinyItemTalentGridComponent</param>
        /// <param name="right">Compared (DestinyEntitiesItemsDestinyItemTalentGridComponent</param>
        /// <returns>true if compared items are not equals, false otherwise</returns>
        public static bool operator != (DestinyEntitiesItemsDestinyItemTalentGridComponent left, DestinyEntitiesItemsDestinyItemTalentGridComponent right)
        {
            return !Equals(left, right);
        }

        /// <summary>
        /// Builder of DestinyEntitiesItemsDestinyItemTalentGridComponent.
        /// </summary>
        public sealed class DestinyEntitiesItemsDestinyItemTalentGridComponentBuilder
        {
            private int? _TalentGridHash;
            private List<DestinyDestinyTalentNode> _Nodes;
            private bool? _IsGridComplete;
            private DestinyDestinyProgression _GridProgression;

            internal DestinyEntitiesItemsDestinyItemTalentGridComponentBuilder()
            {
                SetupDefaults();
            }

            private void SetupDefaults()
            {
            }

            /// <summary>
            /// Sets value for DestinyEntitiesItemsDestinyItemTalentGridComponent.TalentGridHash property.
            /// </summary>
            /// <param name="value">Most items don&#39;t have useful talent grids anymore, but Builds in particular still do.  You can use this hash to lookup the DestinyTalentGridDefinition attached to this item, which will be crucial for understanding the node values on the item.</param>
            public DestinyEntitiesItemsDestinyItemTalentGridComponentBuilder TalentGridHash(int? value)
            {
                _TalentGridHash = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyEntitiesItemsDestinyItemTalentGridComponent.Nodes property.
            /// </summary>
            /// <param name="value">Detailed information about the individual nodes in the talent grid.  A node represents a single visual \&quot;pip\&quot; in the talent grid or Build detail view, though each node may have multiple \&quot;steps\&quot; which indicate the actual bonuses and visual representation of that node.</param>
            public DestinyEntitiesItemsDestinyItemTalentGridComponentBuilder Nodes(List<DestinyDestinyTalentNode> value)
            {
                _Nodes = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyEntitiesItemsDestinyItemTalentGridComponent.IsGridComplete property.
            /// </summary>
            /// <param name="value">Indicates whether the talent grid on this item is completed, and thus whether it should have a gold border around it.  Only will be true if the item actually *has* a talent grid, and only then if it is completed (i.e. every exclusive set has an activated node, and every non-exclusive set node has been activated)</param>
            public DestinyEntitiesItemsDestinyItemTalentGridComponentBuilder IsGridComplete(bool? value)
            {
                _IsGridComplete = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyEntitiesItemsDestinyItemTalentGridComponent.GridProgression property.
            /// </summary>
            /// <param name="value">If the item has a progression, it will be detailed here. A progression means that the item can gain experience. Thresholds of experience are what determines whether and when a talent node can be activated.</param>
            public DestinyEntitiesItemsDestinyItemTalentGridComponentBuilder GridProgression(DestinyDestinyProgression value)
            {
                _GridProgression = value;
                return this;
            }


            /// <summary>
            /// Builds instance of DestinyEntitiesItemsDestinyItemTalentGridComponent.
            /// </summary>
            /// <returns>DestinyEntitiesItemsDestinyItemTalentGridComponent</returns>
            public DestinyEntitiesItemsDestinyItemTalentGridComponent Build()
            {
                Validate();
                return new DestinyEntitiesItemsDestinyItemTalentGridComponent(
                    TalentGridHash: _TalentGridHash,
                    Nodes: _Nodes,
                    IsGridComplete: _IsGridComplete,
                    GridProgression: _GridProgression
                );
            }

            private void Validate()
            { 
            }
        }

        
    }
}