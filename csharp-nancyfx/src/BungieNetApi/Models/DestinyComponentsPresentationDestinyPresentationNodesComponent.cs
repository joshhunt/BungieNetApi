using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Sharpility.Extensions;
using NodaTime;

namespace BungieNetApi._Platform.Models
{
    /// <summary>
    /// DestinyComponentsPresentationDestinyPresentationNodesComponent
    /// </summary>
    public sealed class DestinyComponentsPresentationDestinyPresentationNodesComponent:  IEquatable<DestinyComponentsPresentationDestinyPresentationNodesComponent>
    { 
        /// <summary>
        /// Nodes
        /// </summary>
        public Dictionary<string, DestinyComponentsPresentationDestinyPresentationNodeComponent> Nodes { get; private set; }


        /// <summary>
        /// Empty constructor required by some serializers.
        /// Use DestinyComponentsPresentationDestinyPresentationNodesComponent.Builder() for instance creation instead.
        /// </summary>
        [Obsolete]
        public DestinyComponentsPresentationDestinyPresentationNodesComponent()
        {
        }

        private DestinyComponentsPresentationDestinyPresentationNodesComponent(Dictionary<string, DestinyComponentsPresentationDestinyPresentationNodeComponent> Nodes)
        {
            
            this.Nodes = Nodes;
            
        }

        /// <summary>
        /// Returns builder of DestinyComponentsPresentationDestinyPresentationNodesComponent.
        /// </summary>
        /// <returns>DestinyComponentsPresentationDestinyPresentationNodesComponentBuilder</returns>
        public static DestinyComponentsPresentationDestinyPresentationNodesComponentBuilder Builder()
        {
            return new DestinyComponentsPresentationDestinyPresentationNodesComponentBuilder();
        }

        /// <summary>
        /// Returns DestinyComponentsPresentationDestinyPresentationNodesComponentBuilder with properties set.
        /// Use it to change properties.
        /// </summary>
        /// <returns>DestinyComponentsPresentationDestinyPresentationNodesComponentBuilder</returns>
        public DestinyComponentsPresentationDestinyPresentationNodesComponentBuilder With()
        {
            return Builder()
                .Nodes(Nodes);
        }

        public override string ToString()
        {
            return this.PropertiesToString();
        }

        public override bool Equals(object obj)
        {
            return this.EqualsByProperties(obj);
        }

        public bool Equals(DestinyComponentsPresentationDestinyPresentationNodesComponent other)
        {
            return Equals((object) other);
        }

        public override int GetHashCode()
        {
            return this.PropertiesHash();
        }

        /// <summary>
        /// Implementation of == operator for (DestinyComponentsPresentationDestinyPresentationNodesComponent.
        /// </summary>
        /// <param name="left">Compared (DestinyComponentsPresentationDestinyPresentationNodesComponent</param>
        /// <param name="right">Compared (DestinyComponentsPresentationDestinyPresentationNodesComponent</param>
        /// <returns>true if compared items are equals, false otherwise</returns>
        public static bool operator == (DestinyComponentsPresentationDestinyPresentationNodesComponent left, DestinyComponentsPresentationDestinyPresentationNodesComponent right)
        {
            return Equals(left, right);
        }

        /// <summary>
        /// Implementation of != operator for (DestinyComponentsPresentationDestinyPresentationNodesComponent.
        /// </summary>
        /// <param name="left">Compared (DestinyComponentsPresentationDestinyPresentationNodesComponent</param>
        /// <param name="right">Compared (DestinyComponentsPresentationDestinyPresentationNodesComponent</param>
        /// <returns>true if compared items are not equals, false otherwise</returns>
        public static bool operator != (DestinyComponentsPresentationDestinyPresentationNodesComponent left, DestinyComponentsPresentationDestinyPresentationNodesComponent right)
        {
            return !Equals(left, right);
        }

        /// <summary>
        /// Builder of DestinyComponentsPresentationDestinyPresentationNodesComponent.
        /// </summary>
        public sealed class DestinyComponentsPresentationDestinyPresentationNodesComponentBuilder
        {
            private Dictionary<string, DestinyComponentsPresentationDestinyPresentationNodeComponent> _Nodes;

            internal DestinyComponentsPresentationDestinyPresentationNodesComponentBuilder()
            {
                SetupDefaults();
            }

            private void SetupDefaults()
            {
            }

            /// <summary>
            /// Sets value for DestinyComponentsPresentationDestinyPresentationNodesComponent.Nodes property.
            /// </summary>
            /// <param name="value">Nodes</param>
            public DestinyComponentsPresentationDestinyPresentationNodesComponentBuilder Nodes(Dictionary<string, DestinyComponentsPresentationDestinyPresentationNodeComponent> value)
            {
                _Nodes = value;
                return this;
            }


            /// <summary>
            /// Builds instance of DestinyComponentsPresentationDestinyPresentationNodesComponent.
            /// </summary>
            /// <returns>DestinyComponentsPresentationDestinyPresentationNodesComponent</returns>
            public DestinyComponentsPresentationDestinyPresentationNodesComponent Build()
            {
                Validate();
                return new DestinyComponentsPresentationDestinyPresentationNodesComponent(
                    Nodes: _Nodes
                );
            }

            private void Validate()
            { 
            }
        }

        
    }
}