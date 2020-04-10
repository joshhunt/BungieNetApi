using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Sharpility.Extensions;
using NodaTime;

namespace BungieNetApi._Platform.Models
{
    /// <summary>
    /// DestinyItemComponentSetOfuint32
    /// </summary>
    public sealed class DestinyItemComponentSetOfuint32:  IEquatable<DestinyItemComponentSetOfuint32>
    { 
        /// <summary>
        /// Instances
        /// </summary>
        public DictionaryComponentResponseOfuint32AndDestinyItemInstanceComponent Instances { get; private set; }

        /// <summary>
        /// Perks
        /// </summary>
        public DictionaryComponentResponseOfuint32AndDestinyItemPerksComponent Perks { get; private set; }

        /// <summary>
        /// RenderData
        /// </summary>
        public DictionaryComponentResponseOfuint32AndDestinyItemRenderComponent RenderData { get; private set; }

        /// <summary>
        /// Stats
        /// </summary>
        public DictionaryComponentResponseOfuint32AndDestinyItemStatsComponent Stats { get; private set; }

        /// <summary>
        /// Sockets
        /// </summary>
        public DictionaryComponentResponseOfuint32AndDestinyItemSocketsComponent Sockets { get; private set; }

        /// <summary>
        /// ReusablePlugs
        /// </summary>
        public DictionaryComponentResponseOfuint32AndDestinyItemReusablePlugsComponent ReusablePlugs { get; private set; }

        /// <summary>
        /// PlugObjectives
        /// </summary>
        public DictionaryComponentResponseOfuint32AndDestinyItemPlugObjectivesComponent PlugObjectives { get; private set; }

        /// <summary>
        /// TalentGrids
        /// </summary>
        public DictionaryComponentResponseOfuint32AndDestinyItemTalentGridComponent TalentGrids { get; private set; }

        /// <summary>
        /// PlugStates
        /// </summary>
        public DictionaryComponentResponseOfuint32AndDestinyItemPlugComponent PlugStates { get; private set; }

        /// <summary>
        /// Objectives
        /// </summary>
        public DictionaryComponentResponseOfuint32AndDestinyItemObjectivesComponent Objectives { get; private set; }


        /// <summary>
        /// Empty constructor required by some serializers.
        /// Use DestinyItemComponentSetOfuint32.Builder() for instance creation instead.
        /// </summary>
        [Obsolete]
        public DestinyItemComponentSetOfuint32()
        {
        }

        private DestinyItemComponentSetOfuint32(DictionaryComponentResponseOfuint32AndDestinyItemInstanceComponent Instances, DictionaryComponentResponseOfuint32AndDestinyItemPerksComponent Perks, DictionaryComponentResponseOfuint32AndDestinyItemRenderComponent RenderData, DictionaryComponentResponseOfuint32AndDestinyItemStatsComponent Stats, DictionaryComponentResponseOfuint32AndDestinyItemSocketsComponent Sockets, DictionaryComponentResponseOfuint32AndDestinyItemReusablePlugsComponent ReusablePlugs, DictionaryComponentResponseOfuint32AndDestinyItemPlugObjectivesComponent PlugObjectives, DictionaryComponentResponseOfuint32AndDestinyItemTalentGridComponent TalentGrids, DictionaryComponentResponseOfuint32AndDestinyItemPlugComponent PlugStates, DictionaryComponentResponseOfuint32AndDestinyItemObjectivesComponent Objectives)
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
        /// Returns builder of DestinyItemComponentSetOfuint32.
        /// </summary>
        /// <returns>DestinyItemComponentSetOfuint32Builder</returns>
        public static DestinyItemComponentSetOfuint32Builder Builder()
        {
            return new DestinyItemComponentSetOfuint32Builder();
        }

        /// <summary>
        /// Returns DestinyItemComponentSetOfuint32Builder with properties set.
        /// Use it to change properties.
        /// </summary>
        /// <returns>DestinyItemComponentSetOfuint32Builder</returns>
        public DestinyItemComponentSetOfuint32Builder With()
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

        public bool Equals(DestinyItemComponentSetOfuint32 other)
        {
            return Equals((object) other);
        }

        public override int GetHashCode()
        {
            return this.PropertiesHash();
        }

        /// <summary>
        /// Implementation of == operator for (DestinyItemComponentSetOfuint32.
        /// </summary>
        /// <param name="left">Compared (DestinyItemComponentSetOfuint32</param>
        /// <param name="right">Compared (DestinyItemComponentSetOfuint32</param>
        /// <returns>true if compared items are equals, false otherwise</returns>
        public static bool operator == (DestinyItemComponentSetOfuint32 left, DestinyItemComponentSetOfuint32 right)
        {
            return Equals(left, right);
        }

        /// <summary>
        /// Implementation of != operator for (DestinyItemComponentSetOfuint32.
        /// </summary>
        /// <param name="left">Compared (DestinyItemComponentSetOfuint32</param>
        /// <param name="right">Compared (DestinyItemComponentSetOfuint32</param>
        /// <returns>true if compared items are not equals, false otherwise</returns>
        public static bool operator != (DestinyItemComponentSetOfuint32 left, DestinyItemComponentSetOfuint32 right)
        {
            return !Equals(left, right);
        }

        /// <summary>
        /// Builder of DestinyItemComponentSetOfuint32.
        /// </summary>
        public sealed class DestinyItemComponentSetOfuint32Builder
        {
            private DictionaryComponentResponseOfuint32AndDestinyItemInstanceComponent _Instances;
            private DictionaryComponentResponseOfuint32AndDestinyItemPerksComponent _Perks;
            private DictionaryComponentResponseOfuint32AndDestinyItemRenderComponent _RenderData;
            private DictionaryComponentResponseOfuint32AndDestinyItemStatsComponent _Stats;
            private DictionaryComponentResponseOfuint32AndDestinyItemSocketsComponent _Sockets;
            private DictionaryComponentResponseOfuint32AndDestinyItemReusablePlugsComponent _ReusablePlugs;
            private DictionaryComponentResponseOfuint32AndDestinyItemPlugObjectivesComponent _PlugObjectives;
            private DictionaryComponentResponseOfuint32AndDestinyItemTalentGridComponent _TalentGrids;
            private DictionaryComponentResponseOfuint32AndDestinyItemPlugComponent _PlugStates;
            private DictionaryComponentResponseOfuint32AndDestinyItemObjectivesComponent _Objectives;

            internal DestinyItemComponentSetOfuint32Builder()
            {
                SetupDefaults();
            }

            private void SetupDefaults()
            {
            }

            /// <summary>
            /// Sets value for DestinyItemComponentSetOfuint32.Instances property.
            /// </summary>
            /// <param name="value">Instances</param>
            public DestinyItemComponentSetOfuint32Builder Instances(DictionaryComponentResponseOfuint32AndDestinyItemInstanceComponent value)
            {
                _Instances = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyItemComponentSetOfuint32.Perks property.
            /// </summary>
            /// <param name="value">Perks</param>
            public DestinyItemComponentSetOfuint32Builder Perks(DictionaryComponentResponseOfuint32AndDestinyItemPerksComponent value)
            {
                _Perks = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyItemComponentSetOfuint32.RenderData property.
            /// </summary>
            /// <param name="value">RenderData</param>
            public DestinyItemComponentSetOfuint32Builder RenderData(DictionaryComponentResponseOfuint32AndDestinyItemRenderComponent value)
            {
                _RenderData = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyItemComponentSetOfuint32.Stats property.
            /// </summary>
            /// <param name="value">Stats</param>
            public DestinyItemComponentSetOfuint32Builder Stats(DictionaryComponentResponseOfuint32AndDestinyItemStatsComponent value)
            {
                _Stats = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyItemComponentSetOfuint32.Sockets property.
            /// </summary>
            /// <param name="value">Sockets</param>
            public DestinyItemComponentSetOfuint32Builder Sockets(DictionaryComponentResponseOfuint32AndDestinyItemSocketsComponent value)
            {
                _Sockets = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyItemComponentSetOfuint32.ReusablePlugs property.
            /// </summary>
            /// <param name="value">ReusablePlugs</param>
            public DestinyItemComponentSetOfuint32Builder ReusablePlugs(DictionaryComponentResponseOfuint32AndDestinyItemReusablePlugsComponent value)
            {
                _ReusablePlugs = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyItemComponentSetOfuint32.PlugObjectives property.
            /// </summary>
            /// <param name="value">PlugObjectives</param>
            public DestinyItemComponentSetOfuint32Builder PlugObjectives(DictionaryComponentResponseOfuint32AndDestinyItemPlugObjectivesComponent value)
            {
                _PlugObjectives = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyItemComponentSetOfuint32.TalentGrids property.
            /// </summary>
            /// <param name="value">TalentGrids</param>
            public DestinyItemComponentSetOfuint32Builder TalentGrids(DictionaryComponentResponseOfuint32AndDestinyItemTalentGridComponent value)
            {
                _TalentGrids = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyItemComponentSetOfuint32.PlugStates property.
            /// </summary>
            /// <param name="value">PlugStates</param>
            public DestinyItemComponentSetOfuint32Builder PlugStates(DictionaryComponentResponseOfuint32AndDestinyItemPlugComponent value)
            {
                _PlugStates = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyItemComponentSetOfuint32.Objectives property.
            /// </summary>
            /// <param name="value">Objectives</param>
            public DestinyItemComponentSetOfuint32Builder Objectives(DictionaryComponentResponseOfuint32AndDestinyItemObjectivesComponent value)
            {
                _Objectives = value;
                return this;
            }


            /// <summary>
            /// Builds instance of DestinyItemComponentSetOfuint32.
            /// </summary>
            /// <returns>DestinyItemComponentSetOfuint32</returns>
            public DestinyItemComponentSetOfuint32 Build()
            {
                Validate();
                return new DestinyItemComponentSetOfuint32(
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