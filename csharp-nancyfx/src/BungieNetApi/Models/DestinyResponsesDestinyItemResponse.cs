using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Sharpility.Extensions;
using NodaTime;

namespace BungieNetApi._Platform.Models
{
    /// <summary>
    /// The response object for retrieving an individual instanced item. None of these components are relevant for an item that doesn&#39;t have an \&quot;itemInstanceId\&quot;: for those, get your information from the DestinyInventoryDefinition.
    /// </summary>
    public sealed class DestinyResponsesDestinyItemResponse:  IEquatable<DestinyResponsesDestinyItemResponse>
    { 
        /// <summary>
        /// If the item is on a character, this will return the ID of the character that is holding the item.
        /// </summary>
        public long? CharacterId { get; private set; }

        /// <summary>
        /// Common data for the item relevant to its non-instanced properties.  COMPONENT TYPE: ItemCommonData
        /// </summary>
        public SingleComponentResponseOfDestinyItemComponent Item { get; private set; }

        /// <summary>
        /// Basic instance data for the item.  COMPONENT TYPE: ItemInstances
        /// </summary>
        public SingleComponentResponseOfDestinyItemInstanceComponent Instance { get; private set; }

        /// <summary>
        /// Information specifically about the item&#39;s objectives.  COMPONENT TYPE: ItemObjectives
        /// </summary>
        public SingleComponentResponseOfDestinyItemObjectivesComponent Objectives { get; private set; }

        /// <summary>
        /// Information specifically about the perks currently active on the item.  COMPONENT TYPE: ItemPerks
        /// </summary>
        public SingleComponentResponseOfDestinyItemPerksComponent Perks { get; private set; }

        /// <summary>
        /// Information about how to render the item in 3D.  COMPONENT TYPE: ItemRenderData
        /// </summary>
        public SingleComponentResponseOfDestinyItemRenderComponent RenderData { get; private set; }

        /// <summary>
        /// Information about the computed stats of the item: power, defense, etc...  COMPONENT TYPE: ItemStats
        /// </summary>
        public SingleComponentResponseOfDestinyItemStatsComponent Stats { get; private set; }

        /// <summary>
        /// Information about the talent grid attached to the item. Talent nodes can provide a variety of benefits and abilities, and in Destiny 2 are used almost exclusively for the character&#39;s \&quot;Builds\&quot;.  COMPONENT TYPE: ItemTalentGrids
        /// </summary>
        public SingleComponentResponseOfDestinyItemTalentGridComponent TalentGrid { get; private set; }

        /// <summary>
        /// Information about the sockets of the item: which are currently active, what potential sockets you could have and the stats/abilities/perks you can gain from them.  COMPONENT TYPE: ItemSockets
        /// </summary>
        public SingleComponentResponseOfDestinyItemSocketsComponent Sockets { get; private set; }

        /// <summary>
        /// Information about the Reusable Plugs for sockets on an item. These are plugs that you can insert into the given socket regardless of if you actually own an instance of that plug: they are logic-driven plugs rather than inventory-driven.   These may need to be combined with Plug Set component data to get a full picture of available plugs on a given socket.   COMPONENT TYPE: ItemReusablePlugs
        /// </summary>
        public SingleComponentResponseOfDestinyItemReusablePlugsComponent ReusablePlugs { get; private set; }

        /// <summary>
        /// Information about objectives on Plugs for a given item. See the component&#39;s documentation for more info.  COMPONENT TYPE: ItemPlugObjectives
        /// </summary>
        public SingleComponentResponseOfDestinyItemPlugObjectivesComponent PlugObjectives { get; private set; }


        /// <summary>
        /// Empty constructor required by some serializers.
        /// Use DestinyResponsesDestinyItemResponse.Builder() for instance creation instead.
        /// </summary>
        [Obsolete]
        public DestinyResponsesDestinyItemResponse()
        {
        }

        private DestinyResponsesDestinyItemResponse(long? CharacterId, SingleComponentResponseOfDestinyItemComponent Item, SingleComponentResponseOfDestinyItemInstanceComponent Instance, SingleComponentResponseOfDestinyItemObjectivesComponent Objectives, SingleComponentResponseOfDestinyItemPerksComponent Perks, SingleComponentResponseOfDestinyItemRenderComponent RenderData, SingleComponentResponseOfDestinyItemStatsComponent Stats, SingleComponentResponseOfDestinyItemTalentGridComponent TalentGrid, SingleComponentResponseOfDestinyItemSocketsComponent Sockets, SingleComponentResponseOfDestinyItemReusablePlugsComponent ReusablePlugs, SingleComponentResponseOfDestinyItemPlugObjectivesComponent PlugObjectives)
        {
            
            this.CharacterId = CharacterId;
            
            this.Item = Item;
            
            this.Instance = Instance;
            
            this.Objectives = Objectives;
            
            this.Perks = Perks;
            
            this.RenderData = RenderData;
            
            this.Stats = Stats;
            
            this.TalentGrid = TalentGrid;
            
            this.Sockets = Sockets;
            
            this.ReusablePlugs = ReusablePlugs;
            
            this.PlugObjectives = PlugObjectives;
            
        }

        /// <summary>
        /// Returns builder of DestinyResponsesDestinyItemResponse.
        /// </summary>
        /// <returns>DestinyResponsesDestinyItemResponseBuilder</returns>
        public static DestinyResponsesDestinyItemResponseBuilder Builder()
        {
            return new DestinyResponsesDestinyItemResponseBuilder();
        }

        /// <summary>
        /// Returns DestinyResponsesDestinyItemResponseBuilder with properties set.
        /// Use it to change properties.
        /// </summary>
        /// <returns>DestinyResponsesDestinyItemResponseBuilder</returns>
        public DestinyResponsesDestinyItemResponseBuilder With()
        {
            return Builder()
                .CharacterId(CharacterId)
                .Item(Item)
                .Instance(Instance)
                .Objectives(Objectives)
                .Perks(Perks)
                .RenderData(RenderData)
                .Stats(Stats)
                .TalentGrid(TalentGrid)
                .Sockets(Sockets)
                .ReusablePlugs(ReusablePlugs)
                .PlugObjectives(PlugObjectives);
        }

        public override string ToString()
        {
            return this.PropertiesToString();
        }

        public override bool Equals(object obj)
        {
            return this.EqualsByProperties(obj);
        }

        public bool Equals(DestinyResponsesDestinyItemResponse other)
        {
            return Equals((object) other);
        }

        public override int GetHashCode()
        {
            return this.PropertiesHash();
        }

        /// <summary>
        /// Implementation of == operator for (DestinyResponsesDestinyItemResponse.
        /// </summary>
        /// <param name="left">Compared (DestinyResponsesDestinyItemResponse</param>
        /// <param name="right">Compared (DestinyResponsesDestinyItemResponse</param>
        /// <returns>true if compared items are equals, false otherwise</returns>
        public static bool operator == (DestinyResponsesDestinyItemResponse left, DestinyResponsesDestinyItemResponse right)
        {
            return Equals(left, right);
        }

        /// <summary>
        /// Implementation of != operator for (DestinyResponsesDestinyItemResponse.
        /// </summary>
        /// <param name="left">Compared (DestinyResponsesDestinyItemResponse</param>
        /// <param name="right">Compared (DestinyResponsesDestinyItemResponse</param>
        /// <returns>true if compared items are not equals, false otherwise</returns>
        public static bool operator != (DestinyResponsesDestinyItemResponse left, DestinyResponsesDestinyItemResponse right)
        {
            return !Equals(left, right);
        }

        /// <summary>
        /// Builder of DestinyResponsesDestinyItemResponse.
        /// </summary>
        public sealed class DestinyResponsesDestinyItemResponseBuilder
        {
            private long? _CharacterId;
            private SingleComponentResponseOfDestinyItemComponent _Item;
            private SingleComponentResponseOfDestinyItemInstanceComponent _Instance;
            private SingleComponentResponseOfDestinyItemObjectivesComponent _Objectives;
            private SingleComponentResponseOfDestinyItemPerksComponent _Perks;
            private SingleComponentResponseOfDestinyItemRenderComponent _RenderData;
            private SingleComponentResponseOfDestinyItemStatsComponent _Stats;
            private SingleComponentResponseOfDestinyItemTalentGridComponent _TalentGrid;
            private SingleComponentResponseOfDestinyItemSocketsComponent _Sockets;
            private SingleComponentResponseOfDestinyItemReusablePlugsComponent _ReusablePlugs;
            private SingleComponentResponseOfDestinyItemPlugObjectivesComponent _PlugObjectives;

            internal DestinyResponsesDestinyItemResponseBuilder()
            {
                SetupDefaults();
            }

            private void SetupDefaults()
            {
            }

            /// <summary>
            /// Sets value for DestinyResponsesDestinyItemResponse.CharacterId property.
            /// </summary>
            /// <param name="value">If the item is on a character, this will return the ID of the character that is holding the item.</param>
            public DestinyResponsesDestinyItemResponseBuilder CharacterId(long? value)
            {
                _CharacterId = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyResponsesDestinyItemResponse.Item property.
            /// </summary>
            /// <param name="value">Common data for the item relevant to its non-instanced properties.  COMPONENT TYPE: ItemCommonData</param>
            public DestinyResponsesDestinyItemResponseBuilder Item(SingleComponentResponseOfDestinyItemComponent value)
            {
                _Item = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyResponsesDestinyItemResponse.Instance property.
            /// </summary>
            /// <param name="value">Basic instance data for the item.  COMPONENT TYPE: ItemInstances</param>
            public DestinyResponsesDestinyItemResponseBuilder Instance(SingleComponentResponseOfDestinyItemInstanceComponent value)
            {
                _Instance = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyResponsesDestinyItemResponse.Objectives property.
            /// </summary>
            /// <param name="value">Information specifically about the item&#39;s objectives.  COMPONENT TYPE: ItemObjectives</param>
            public DestinyResponsesDestinyItemResponseBuilder Objectives(SingleComponentResponseOfDestinyItemObjectivesComponent value)
            {
                _Objectives = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyResponsesDestinyItemResponse.Perks property.
            /// </summary>
            /// <param name="value">Information specifically about the perks currently active on the item.  COMPONENT TYPE: ItemPerks</param>
            public DestinyResponsesDestinyItemResponseBuilder Perks(SingleComponentResponseOfDestinyItemPerksComponent value)
            {
                _Perks = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyResponsesDestinyItemResponse.RenderData property.
            /// </summary>
            /// <param name="value">Information about how to render the item in 3D.  COMPONENT TYPE: ItemRenderData</param>
            public DestinyResponsesDestinyItemResponseBuilder RenderData(SingleComponentResponseOfDestinyItemRenderComponent value)
            {
                _RenderData = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyResponsesDestinyItemResponse.Stats property.
            /// </summary>
            /// <param name="value">Information about the computed stats of the item: power, defense, etc...  COMPONENT TYPE: ItemStats</param>
            public DestinyResponsesDestinyItemResponseBuilder Stats(SingleComponentResponseOfDestinyItemStatsComponent value)
            {
                _Stats = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyResponsesDestinyItemResponse.TalentGrid property.
            /// </summary>
            /// <param name="value">Information about the talent grid attached to the item. Talent nodes can provide a variety of benefits and abilities, and in Destiny 2 are used almost exclusively for the character&#39;s \&quot;Builds\&quot;.  COMPONENT TYPE: ItemTalentGrids</param>
            public DestinyResponsesDestinyItemResponseBuilder TalentGrid(SingleComponentResponseOfDestinyItemTalentGridComponent value)
            {
                _TalentGrid = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyResponsesDestinyItemResponse.Sockets property.
            /// </summary>
            /// <param name="value">Information about the sockets of the item: which are currently active, what potential sockets you could have and the stats/abilities/perks you can gain from them.  COMPONENT TYPE: ItemSockets</param>
            public DestinyResponsesDestinyItemResponseBuilder Sockets(SingleComponentResponseOfDestinyItemSocketsComponent value)
            {
                _Sockets = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyResponsesDestinyItemResponse.ReusablePlugs property.
            /// </summary>
            /// <param name="value">Information about the Reusable Plugs for sockets on an item. These are plugs that you can insert into the given socket regardless of if you actually own an instance of that plug: they are logic-driven plugs rather than inventory-driven.   These may need to be combined with Plug Set component data to get a full picture of available plugs on a given socket.   COMPONENT TYPE: ItemReusablePlugs</param>
            public DestinyResponsesDestinyItemResponseBuilder ReusablePlugs(SingleComponentResponseOfDestinyItemReusablePlugsComponent value)
            {
                _ReusablePlugs = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyResponsesDestinyItemResponse.PlugObjectives property.
            /// </summary>
            /// <param name="value">Information about objectives on Plugs for a given item. See the component&#39;s documentation for more info.  COMPONENT TYPE: ItemPlugObjectives</param>
            public DestinyResponsesDestinyItemResponseBuilder PlugObjectives(SingleComponentResponseOfDestinyItemPlugObjectivesComponent value)
            {
                _PlugObjectives = value;
                return this;
            }


            /// <summary>
            /// Builds instance of DestinyResponsesDestinyItemResponse.
            /// </summary>
            /// <returns>DestinyResponsesDestinyItemResponse</returns>
            public DestinyResponsesDestinyItemResponse Build()
            {
                Validate();
                return new DestinyResponsesDestinyItemResponse(
                    CharacterId: _CharacterId,
                    Item: _Item,
                    Instance: _Instance,
                    Objectives: _Objectives,
                    Perks: _Perks,
                    RenderData: _RenderData,
                    Stats: _Stats,
                    TalentGrid: _TalentGrid,
                    Sockets: _Sockets,
                    ReusablePlugs: _ReusablePlugs,
                    PlugObjectives: _PlugObjectives
                );
            }

            private void Validate()
            { 
            }
        }

        
    }
}