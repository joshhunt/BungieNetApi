using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Sharpility.Extensions;
using NodaTime;

namespace BungieNetApi._Platform.Models
{
    /// <summary>
    /// Sockets may refer to a \&quot;Plug Set\&quot;: a set of reusable plugs that may be shared across multiple sockets (or even, in theory, multiple sockets over multiple items).  This is the set of those plugs that we came across in the users&#39; inventory, along with the values for plugs in the set. Any given set in this component may be represented in Character and Profile-level, as some plugs may be Profile-level restricted, and some character-level restricted. (note that the ones that are even more specific will remain on the actual socket component itself, as they cannot be reused)
    /// </summary>
    public sealed class DestinyComponentsPlugSetsDestinyPlugSetsComponent:  IEquatable<DestinyComponentsPlugSetsDestinyPlugSetsComponent>
    { 
        /// <summary>
        /// The shared list of plugs for each relevant PlugSet, keyed by the hash identifier of the PlugSet (DestinyPlugSetDefinition).
        /// </summary>
        public Dictionary<string, List<DestinySocketsDestinyItemPlug>> Plugs { get; private set; }


        /// <summary>
        /// Empty constructor required by some serializers.
        /// Use DestinyComponentsPlugSetsDestinyPlugSetsComponent.Builder() for instance creation instead.
        /// </summary>
        [Obsolete]
        public DestinyComponentsPlugSetsDestinyPlugSetsComponent()
        {
        }

        private DestinyComponentsPlugSetsDestinyPlugSetsComponent(Dictionary<string, List<DestinySocketsDestinyItemPlug>> Plugs)
        {
            
            this.Plugs = Plugs;
            
        }

        /// <summary>
        /// Returns builder of DestinyComponentsPlugSetsDestinyPlugSetsComponent.
        /// </summary>
        /// <returns>DestinyComponentsPlugSetsDestinyPlugSetsComponentBuilder</returns>
        public static DestinyComponentsPlugSetsDestinyPlugSetsComponentBuilder Builder()
        {
            return new DestinyComponentsPlugSetsDestinyPlugSetsComponentBuilder();
        }

        /// <summary>
        /// Returns DestinyComponentsPlugSetsDestinyPlugSetsComponentBuilder with properties set.
        /// Use it to change properties.
        /// </summary>
        /// <returns>DestinyComponentsPlugSetsDestinyPlugSetsComponentBuilder</returns>
        public DestinyComponentsPlugSetsDestinyPlugSetsComponentBuilder With()
        {
            return Builder()
                .Plugs(Plugs);
        }

        public override string ToString()
        {
            return this.PropertiesToString();
        }

        public override bool Equals(object obj)
        {
            return this.EqualsByProperties(obj);
        }

        public bool Equals(DestinyComponentsPlugSetsDestinyPlugSetsComponent other)
        {
            return Equals((object) other);
        }

        public override int GetHashCode()
        {
            return this.PropertiesHash();
        }

        /// <summary>
        /// Implementation of == operator for (DestinyComponentsPlugSetsDestinyPlugSetsComponent.
        /// </summary>
        /// <param name="left">Compared (DestinyComponentsPlugSetsDestinyPlugSetsComponent</param>
        /// <param name="right">Compared (DestinyComponentsPlugSetsDestinyPlugSetsComponent</param>
        /// <returns>true if compared items are equals, false otherwise</returns>
        public static bool operator == (DestinyComponentsPlugSetsDestinyPlugSetsComponent left, DestinyComponentsPlugSetsDestinyPlugSetsComponent right)
        {
            return Equals(left, right);
        }

        /// <summary>
        /// Implementation of != operator for (DestinyComponentsPlugSetsDestinyPlugSetsComponent.
        /// </summary>
        /// <param name="left">Compared (DestinyComponentsPlugSetsDestinyPlugSetsComponent</param>
        /// <param name="right">Compared (DestinyComponentsPlugSetsDestinyPlugSetsComponent</param>
        /// <returns>true if compared items are not equals, false otherwise</returns>
        public static bool operator != (DestinyComponentsPlugSetsDestinyPlugSetsComponent left, DestinyComponentsPlugSetsDestinyPlugSetsComponent right)
        {
            return !Equals(left, right);
        }

        /// <summary>
        /// Builder of DestinyComponentsPlugSetsDestinyPlugSetsComponent.
        /// </summary>
        public sealed class DestinyComponentsPlugSetsDestinyPlugSetsComponentBuilder
        {
            private Dictionary<string, List<DestinySocketsDestinyItemPlug>> _Plugs;

            internal DestinyComponentsPlugSetsDestinyPlugSetsComponentBuilder()
            {
                SetupDefaults();
            }

            private void SetupDefaults()
            {
            }

            /// <summary>
            /// Sets value for DestinyComponentsPlugSetsDestinyPlugSetsComponent.Plugs property.
            /// </summary>
            /// <param name="value">The shared list of plugs for each relevant PlugSet, keyed by the hash identifier of the PlugSet (DestinyPlugSetDefinition).</param>
            public DestinyComponentsPlugSetsDestinyPlugSetsComponentBuilder Plugs(Dictionary<string, List<DestinySocketsDestinyItemPlug>> value)
            {
                _Plugs = value;
                return this;
            }


            /// <summary>
            /// Builds instance of DestinyComponentsPlugSetsDestinyPlugSetsComponent.
            /// </summary>
            /// <returns>DestinyComponentsPlugSetsDestinyPlugSetsComponent</returns>
            public DestinyComponentsPlugSetsDestinyPlugSetsComponent Build()
            {
                Validate();
                return new DestinyComponentsPlugSetsDestinyPlugSetsComponent(
                    Plugs: _Plugs
                );
            }

            private void Validate()
            { 
            }
        }

        
    }
}