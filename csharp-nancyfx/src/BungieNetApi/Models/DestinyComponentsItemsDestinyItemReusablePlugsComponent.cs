using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Sharpility.Extensions;
using NodaTime;

namespace BungieNetApi._Platform.Models
{
    /// <summary>
    /// DestinyComponentsItemsDestinyItemReusablePlugsComponent
    /// </summary>
    public sealed class DestinyComponentsItemsDestinyItemReusablePlugsComponent:  IEquatable<DestinyComponentsItemsDestinyItemReusablePlugsComponent>
    { 
        /// <summary>
        /// If the item supports reusable plugs, this is the list of plugs that are allowed to be used for the socket, and any relevant information about whether they are \&quot;enabled\&quot;, whether they are allowed to be inserted, and any other information such as objectives.   A Reusable Plug is a plug that you can always insert into this socket as long as its insertion rules are passed, regardless of whether or not you have the plug in your inventory. An example of it failing an insertion rule would be if it has an Objective that needs to be completed before it can be inserted, and that objective hasn&#39;t been completed yet.   In practice, a socket will *either* have reusable plugs *or* it will allow for plugs in your inventory to be inserted. See DestinyInventoryItemDefinition.socket for more info.   KEY &#x3D; The INDEX into the item&#39;s list of sockets. VALUE &#x3D; The set of plugs for that socket.   If a socket doesn&#39;t have any reusable plugs defined at the item scope, there will be no entry for that socket.
        /// </summary>
        public Dictionary<string, List<DestinySocketsDestinyItemPlugBase>> Plugs { get; private set; }


        /// <summary>
        /// Empty constructor required by some serializers.
        /// Use DestinyComponentsItemsDestinyItemReusablePlugsComponent.Builder() for instance creation instead.
        /// </summary>
        [Obsolete]
        public DestinyComponentsItemsDestinyItemReusablePlugsComponent()
        {
        }

        private DestinyComponentsItemsDestinyItemReusablePlugsComponent(Dictionary<string, List<DestinySocketsDestinyItemPlugBase>> Plugs)
        {
            
            this.Plugs = Plugs;
            
        }

        /// <summary>
        /// Returns builder of DestinyComponentsItemsDestinyItemReusablePlugsComponent.
        /// </summary>
        /// <returns>DestinyComponentsItemsDestinyItemReusablePlugsComponentBuilder</returns>
        public static DestinyComponentsItemsDestinyItemReusablePlugsComponentBuilder Builder()
        {
            return new DestinyComponentsItemsDestinyItemReusablePlugsComponentBuilder();
        }

        /// <summary>
        /// Returns DestinyComponentsItemsDestinyItemReusablePlugsComponentBuilder with properties set.
        /// Use it to change properties.
        /// </summary>
        /// <returns>DestinyComponentsItemsDestinyItemReusablePlugsComponentBuilder</returns>
        public DestinyComponentsItemsDestinyItemReusablePlugsComponentBuilder With()
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

        public bool Equals(DestinyComponentsItemsDestinyItemReusablePlugsComponent other)
        {
            return Equals((object) other);
        }

        public override int GetHashCode()
        {
            return this.PropertiesHash();
        }

        /// <summary>
        /// Implementation of == operator for (DestinyComponentsItemsDestinyItemReusablePlugsComponent.
        /// </summary>
        /// <param name="left">Compared (DestinyComponentsItemsDestinyItemReusablePlugsComponent</param>
        /// <param name="right">Compared (DestinyComponentsItemsDestinyItemReusablePlugsComponent</param>
        /// <returns>true if compared items are equals, false otherwise</returns>
        public static bool operator == (DestinyComponentsItemsDestinyItemReusablePlugsComponent left, DestinyComponentsItemsDestinyItemReusablePlugsComponent right)
        {
            return Equals(left, right);
        }

        /// <summary>
        /// Implementation of != operator for (DestinyComponentsItemsDestinyItemReusablePlugsComponent.
        /// </summary>
        /// <param name="left">Compared (DestinyComponentsItemsDestinyItemReusablePlugsComponent</param>
        /// <param name="right">Compared (DestinyComponentsItemsDestinyItemReusablePlugsComponent</param>
        /// <returns>true if compared items are not equals, false otherwise</returns>
        public static bool operator != (DestinyComponentsItemsDestinyItemReusablePlugsComponent left, DestinyComponentsItemsDestinyItemReusablePlugsComponent right)
        {
            return !Equals(left, right);
        }

        /// <summary>
        /// Builder of DestinyComponentsItemsDestinyItemReusablePlugsComponent.
        /// </summary>
        public sealed class DestinyComponentsItemsDestinyItemReusablePlugsComponentBuilder
        {
            private Dictionary<string, List<DestinySocketsDestinyItemPlugBase>> _Plugs;

            internal DestinyComponentsItemsDestinyItemReusablePlugsComponentBuilder()
            {
                SetupDefaults();
            }

            private void SetupDefaults()
            {
            }

            /// <summary>
            /// Sets value for DestinyComponentsItemsDestinyItemReusablePlugsComponent.Plugs property.
            /// </summary>
            /// <param name="value">If the item supports reusable plugs, this is the list of plugs that are allowed to be used for the socket, and any relevant information about whether they are \&quot;enabled\&quot;, whether they are allowed to be inserted, and any other information such as objectives.   A Reusable Plug is a plug that you can always insert into this socket as long as its insertion rules are passed, regardless of whether or not you have the plug in your inventory. An example of it failing an insertion rule would be if it has an Objective that needs to be completed before it can be inserted, and that objective hasn&#39;t been completed yet.   In practice, a socket will *either* have reusable plugs *or* it will allow for plugs in your inventory to be inserted. See DestinyInventoryItemDefinition.socket for more info.   KEY &#x3D; The INDEX into the item&#39;s list of sockets. VALUE &#x3D; The set of plugs for that socket.   If a socket doesn&#39;t have any reusable plugs defined at the item scope, there will be no entry for that socket.</param>
            public DestinyComponentsItemsDestinyItemReusablePlugsComponentBuilder Plugs(Dictionary<string, List<DestinySocketsDestinyItemPlugBase>> value)
            {
                _Plugs = value;
                return this;
            }


            /// <summary>
            /// Builds instance of DestinyComponentsItemsDestinyItemReusablePlugsComponent.
            /// </summary>
            /// <returns>DestinyComponentsItemsDestinyItemReusablePlugsComponent</returns>
            public DestinyComponentsItemsDestinyItemReusablePlugsComponent Build()
            {
                Validate();
                return new DestinyComponentsItemsDestinyItemReusablePlugsComponent(
                    Plugs: _Plugs
                );
            }

            private void Validate()
            { 
            }
        }

        
    }
}