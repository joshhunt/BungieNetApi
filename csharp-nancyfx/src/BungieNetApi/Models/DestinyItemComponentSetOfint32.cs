using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Sharpility.Extensions;
using NodaTime;

namespace BungieNetApi._Platform.Models
{
    /// <summary>
    /// DestinyItemComponentSetOfint32
    /// </summary>
    public sealed class DestinyItemComponentSetOfint32:  IEquatable<DestinyItemComponentSetOfint32>
    { 
        /// <summary>
        /// Instances
        /// </summary>
        public DictionaryComponentResponseOfint32AndDestinyItemInstanceComponent Instances { get; private set; }

        /// <summary>
        /// Perks
        /// </summary>
        public DictionaryComponentResponseOfint32AndDestinyItemPerksComponent Perks { get; private set; }

        /// <summary>
        /// RenderData
        /// </summary>
        public DictionaryComponentResponseOfint32AndDestinyItemRenderComponent RenderData { get; private set; }

        /// <summary>
        /// Stats
        /// </summary>
        public DictionaryComponentResponseOfint32AndDestinyItemStatsComponent Stats { get; private set; }

        /// <summary>
        /// Sockets
        /// </summary>
        public DictionaryComponentResponseOfint32AndDestinyItemSocketsComponent Sockets { get; private set; }

        /// <summary>
        /// ReusablePlugs
        /// </summary>
        public DictionaryComponentResponseOfint32AndDestinyItemReusablePlugsComponent ReusablePlugs { get; private set; }

        /// <summary>
        /// PlugObjectives
        /// </summary>
        public DictionaryComponentResponseOfint32AndDestinyItemPlugObjectivesComponent PlugObjectives { get; private set; }

        /// <summary>
        /// TalentGrids
        /// </summary>
        public DictionaryComponentResponseOfint32AndDestinyItemTalentGridComponent TalentGrids { get; private set; }

        /// <summary>
        /// PlugStates
        /// </summary>
        public DictionaryComponentResponseOfuint32AndDestinyItemPlugComponent PlugStates { get; private set; }

        /// <summary>
        /// Objectives
        /// </summary>
        public DictionaryComponentResponseOfint32AndDestinyItemObjectivesComponent Objectives { get; private set; }


        /// <summary>
        /// Empty constructor required by some serializers.
        /// Use DestinyItemComponentSetOfint32.Builder() for instance creation instead.
        /// </summary>
        [Obsolete]
        public DestinyItemComponentSetOfint32()
        {
        }

        private DestinyItemComponentSetOfint32(DictionaryComponentResponseOfint32AndDestinyItemInstanceComponent Instances, DictionaryComponentResponseOfint32AndDestinyItemPerksComponent Perks, DictionaryComponentResponseOfint32AndDestinyItemRenderComponent RenderData, DictionaryComponentResponseOfint32AndDestinyItemStatsComponent Stats, DictionaryComponentResponseOfint32AndDestinyItemSocketsComponent Sockets, DictionaryComponentResponseOfint32AndDestinyItemReusablePlugsComponent ReusablePlugs, DictionaryComponentResponseOfint32AndDestinyItemPlugObjectivesComponent PlugObjectives, DictionaryComponentResponseOfint32AndDestinyItemTalentGridComponent TalentGrids, DictionaryComponentResponseOfuint32AndDestinyItemPlugComponent PlugStates, DictionaryComponentResponseOfint32AndDestinyItemObjectivesComponent Objectives)
        {
            
            this.Instances = Instances;
            
            this.Perks = Perks;
            
            this.RenderData = RenderData;
            
            this.Stats = Stats;
            
            this.Sockets = Sockets;
            
            this.ReusablePlugs = ReusablePlugs;
            
            this.PlugObjectives = PlugObjectives;
            
            this.TalentGrids = TalentGrids;
            
            this.PlugStates = PlugStates;
            
            this.Objectives = Objectives;
            
        }

        /// <summary>
        /// Returns builder of DestinyItemComponentSetOfint32.
        /// </summary>
        /// <returns>DestinyItemComponentSetOfint32Builder</returns>
        public static DestinyItemComponentSetOfint32Builder Builder()
        {
            return new DestinyItemComponentSetOfint32Builder();
        }

        /// <summary>
        /// Returns DestinyItemComponentSetOfint32Builder with properties set.
        /// Use it to change properties.
        /// </summary>
        /// <returns>DestinyItemComponentSetOfint32Builder</returns>
        public DestinyItemComponentSetOfint32Builder With()
        {
            return Builder()
                .Instances(Instances)
                .Perks(Perks)
                .RenderData(RenderData)
                .Stats(Stats)
                .Sockets(Sockets)
                .ReusablePlugs(ReusablePlugs)
                .PlugObjectives(PlugObjectives)
                .TalentGrids(TalentGrids)
                .PlugStates(PlugStates)
                .Objectives(Objectives);
        }

        public override string ToString()
        {
            return this.PropertiesToString();
        }

        public override bool Equals(object obj)
        {
            return this.EqualsByProperties(obj);
        }

        public bool Equals(DestinyItemComponentSetOfint32 other)
        {
            return Equals((object) other);
        }

        public override int GetHashCode()
        {
            return this.PropertiesHash();
        }

        /// <summary>
        /// Implementation of == operator for (DestinyItemComponentSetOfint32.
        /// </summary>
        /// <param name="left">Compared (DestinyItemComponentSetOfint32</param>
        /// <param name="right">Compared (DestinyItemComponentSetOfint32</param>
        /// <returns>true if compared items are equals, false otherwise</returns>
        public static bool operator == (DestinyItemComponentSetOfint32 left, DestinyItemComponentSetOfint32 right)
        {
            return Equals(left, right);
        }

        /// <summary>
        /// Implementation of != operator for (DestinyItemComponentSetOfint32.
        /// </summary>
        /// <param name="left">Compared (DestinyItemComponentSetOfint32</param>
        /// <param name="right">Compared (DestinyItemComponentSetOfint32</param>
        /// <returns>true if compared items are not equals, false otherwise</returns>
        public static bool operator != (DestinyItemComponentSetOfint32 left, DestinyItemComponentSetOfint32 right)
        {
            return !Equals(left, right);
        }

        /// <summary>
        /// Builder of DestinyItemComponentSetOfint32.
        /// </summary>
        public sealed class DestinyItemComponentSetOfint32Builder
        {
            private DictionaryComponentResponseOfint32AndDestinyItemInstanceComponent _Instances;
            private DictionaryComponentResponseOfint32AndDestinyItemPerksComponent _Perks;
            private DictionaryComponentResponseOfint32AndDestinyItemRenderComponent _RenderData;
            private DictionaryComponentResponseOfint32AndDestinyItemStatsComponent _Stats;
            private DictionaryComponentResponseOfint32AndDestinyItemSocketsComponent _Sockets;
            private DictionaryComponentResponseOfint32AndDestinyItemReusablePlugsComponent _ReusablePlugs;
            private DictionaryComponentResponseOfint32AndDestinyItemPlugObjectivesComponent _PlugObjectives;
            private DictionaryComponentResponseOfint32AndDestinyItemTalentGridComponent _TalentGrids;
            private DictionaryComponentResponseOfuint32AndDestinyItemPlugComponent _PlugStates;
            private DictionaryComponentResponseOfint32AndDestinyItemObjectivesComponent _Objectives;

            internal DestinyItemComponentSetOfint32Builder()
            {
                SetupDefaults();
            }

            private void SetupDefaults()
            {
            }

            /// <summary>
            /// Sets value for DestinyItemComponentSetOfint32.Instances property.
            /// </summary>
            /// <param name="value">Instances</param>
            public DestinyItemComponentSetOfint32Builder Instances(DictionaryComponentResponseOfint32AndDestinyItemInstanceComponent value)
            {
                _Instances = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyItemComponentSetOfint32.Perks property.
            /// </summary>
            /// <param name="value">Perks</param>
            public DestinyItemComponentSetOfint32Builder Perks(DictionaryComponentResponseOfint32AndDestinyItemPerksComponent value)
            {
                _Perks = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyItemComponentSetOfint32.RenderData property.
            /// </summary>
            /// <param name="value">RenderData</param>
            public DestinyItemComponentSetOfint32Builder RenderData(DictionaryComponentResponseOfint32AndDestinyItemRenderComponent value)
            {
                _RenderData = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyItemComponentSetOfint32.Stats property.
            /// </summary>
            /// <param name="value">Stats</param>
            public DestinyItemComponentSetOfint32Builder Stats(DictionaryComponentResponseOfint32AndDestinyItemStatsComponent value)
            {
                _Stats = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyItemComponentSetOfint32.Sockets property.
            /// </summary>
            /// <param name="value">Sockets</param>
            public DestinyItemComponentSetOfint32Builder Sockets(DictionaryComponentResponseOfint32AndDestinyItemSocketsComponent value)
            {
                _Sockets = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyItemComponentSetOfint32.ReusablePlugs property.
            /// </summary>
            /// <param name="value">ReusablePlugs</param>
            public DestinyItemComponentSetOfint32Builder ReusablePlugs(DictionaryComponentResponseOfint32AndDestinyItemReusablePlugsComponent value)
            {
                _ReusablePlugs = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyItemComponentSetOfint32.PlugObjectives property.
            /// </summary>
            /// <param name="value">PlugObjectives</param>
            public DestinyItemComponentSetOfint32Builder PlugObjectives(DictionaryComponentResponseOfint32AndDestinyItemPlugObjectivesComponent value)
            {
                _PlugObjectives = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyItemComponentSetOfint32.TalentGrids property.
            /// </summary>
            /// <param name="value">TalentGrids</param>
            public DestinyItemComponentSetOfint32Builder TalentGrids(DictionaryComponentResponseOfint32AndDestinyItemTalentGridComponent value)
            {
                _TalentGrids = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyItemComponentSetOfint32.PlugStates property.
            /// </summary>
            /// <param name="value">PlugStates</param>
            public DestinyItemComponentSetOfint32Builder PlugStates(DictionaryComponentResponseOfuint32AndDestinyItemPlugComponent value)
            {
                _PlugStates = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyItemComponentSetOfint32.Objectives property.
            /// </summary>
            /// <param name="value">Objectives</param>
            public DestinyItemComponentSetOfint32Builder Objectives(DictionaryComponentResponseOfint32AndDestinyItemObjectivesComponent value)
            {
                _Objectives = value;
                return this;
            }


            /// <summary>
            /// Builds instance of DestinyItemComponentSetOfint32.
            /// </summary>
            /// <returns>DestinyItemComponentSetOfint32</returns>
            public DestinyItemComponentSetOfint32 Build()
            {
                Validate();
                return new DestinyItemComponentSetOfint32(
                    Instances: _Instances,
                    Perks: _Perks,
                    RenderData: _RenderData,
                    Stats: _Stats,
                    Sockets: _Sockets,
                    ReusablePlugs: _ReusablePlugs,
                    PlugObjectives: _PlugObjectives,
                    TalentGrids: _TalentGrids,
                    PlugStates: _PlugStates,
                    Objectives: _Objectives
                );
            }

            private void Validate()
            { 
            }
        }

        
    }
}