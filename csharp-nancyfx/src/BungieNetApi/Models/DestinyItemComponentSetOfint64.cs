using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Sharpility.Extensions;
using NodaTime;

namespace BungieNetApi._Platform.Models
{
    /// <summary>
    /// DestinyItemComponentSetOfint64
    /// </summary>
    public sealed class DestinyItemComponentSetOfint64:  IEquatable<DestinyItemComponentSetOfint64>
    { 
        /// <summary>
        /// Instances
        /// </summary>
        public DictionaryComponentResponseOfint64AndDestinyItemInstanceComponent Instances { get; private set; }

        /// <summary>
        /// Perks
        /// </summary>
        public DictionaryComponentResponseOfint64AndDestinyItemPerksComponent Perks { get; private set; }

        /// <summary>
        /// RenderData
        /// </summary>
        public DictionaryComponentResponseOfint64AndDestinyItemRenderComponent RenderData { get; private set; }

        /// <summary>
        /// Stats
        /// </summary>
        public DictionaryComponentResponseOfint64AndDestinyItemStatsComponent Stats { get; private set; }

        /// <summary>
        /// Sockets
        /// </summary>
        public DictionaryComponentResponseOfint64AndDestinyItemSocketsComponent Sockets { get; private set; }

        /// <summary>
        /// ReusablePlugs
        /// </summary>
        public DictionaryComponentResponseOfint64AndDestinyItemReusablePlugsComponent ReusablePlugs { get; private set; }

        /// <summary>
        /// PlugObjectives
        /// </summary>
        public DictionaryComponentResponseOfint64AndDestinyItemPlugObjectivesComponent PlugObjectives { get; private set; }

        /// <summary>
        /// TalentGrids
        /// </summary>
        public DictionaryComponentResponseOfint64AndDestinyItemTalentGridComponent TalentGrids { get; private set; }

        /// <summary>
        /// PlugStates
        /// </summary>
        public DictionaryComponentResponseOfuint32AndDestinyItemPlugComponent PlugStates { get; private set; }

        /// <summary>
        /// Objectives
        /// </summary>
        public DictionaryComponentResponseOfint64AndDestinyItemObjectivesComponent Objectives { get; private set; }


        /// <summary>
        /// Empty constructor required by some serializers.
        /// Use DestinyItemComponentSetOfint64.Builder() for instance creation instead.
        /// </summary>
        [Obsolete]
        public DestinyItemComponentSetOfint64()
        {
        }

        private DestinyItemComponentSetOfint64(DictionaryComponentResponseOfint64AndDestinyItemInstanceComponent Instances, DictionaryComponentResponseOfint64AndDestinyItemPerksComponent Perks, DictionaryComponentResponseOfint64AndDestinyItemRenderComponent RenderData, DictionaryComponentResponseOfint64AndDestinyItemStatsComponent Stats, DictionaryComponentResponseOfint64AndDestinyItemSocketsComponent Sockets, DictionaryComponentResponseOfint64AndDestinyItemReusablePlugsComponent ReusablePlugs, DictionaryComponentResponseOfint64AndDestinyItemPlugObjectivesComponent PlugObjectives, DictionaryComponentResponseOfint64AndDestinyItemTalentGridComponent TalentGrids, DictionaryComponentResponseOfuint32AndDestinyItemPlugComponent PlugStates, DictionaryComponentResponseOfint64AndDestinyItemObjectivesComponent Objectives)
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
        /// Returns builder of DestinyItemComponentSetOfint64.
        /// </summary>
        /// <returns>DestinyItemComponentSetOfint64Builder</returns>
        public static DestinyItemComponentSetOfint64Builder Builder()
        {
            return new DestinyItemComponentSetOfint64Builder();
        }

        /// <summary>
        /// Returns DestinyItemComponentSetOfint64Builder with properties set.
        /// Use it to change properties.
        /// </summary>
        /// <returns>DestinyItemComponentSetOfint64Builder</returns>
        public DestinyItemComponentSetOfint64Builder With()
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

        public bool Equals(DestinyItemComponentSetOfint64 other)
        {
            return Equals((object) other);
        }

        public override int GetHashCode()
        {
            return this.PropertiesHash();
        }

        /// <summary>
        /// Implementation of == operator for (DestinyItemComponentSetOfint64.
        /// </summary>
        /// <param name="left">Compared (DestinyItemComponentSetOfint64</param>
        /// <param name="right">Compared (DestinyItemComponentSetOfint64</param>
        /// <returns>true if compared items are equals, false otherwise</returns>
        public static bool operator == (DestinyItemComponentSetOfint64 left, DestinyItemComponentSetOfint64 right)
        {
            return Equals(left, right);
        }

        /// <summary>
        /// Implementation of != operator for (DestinyItemComponentSetOfint64.
        /// </summary>
        /// <param name="left">Compared (DestinyItemComponentSetOfint64</param>
        /// <param name="right">Compared (DestinyItemComponentSetOfint64</param>
        /// <returns>true if compared items are not equals, false otherwise</returns>
        public static bool operator != (DestinyItemComponentSetOfint64 left, DestinyItemComponentSetOfint64 right)
        {
            return !Equals(left, right);
        }

        /// <summary>
        /// Builder of DestinyItemComponentSetOfint64.
        /// </summary>
        public sealed class DestinyItemComponentSetOfint64Builder
        {
            private DictionaryComponentResponseOfint64AndDestinyItemInstanceComponent _Instances;
            private DictionaryComponentResponseOfint64AndDestinyItemPerksComponent _Perks;
            private DictionaryComponentResponseOfint64AndDestinyItemRenderComponent _RenderData;
            private DictionaryComponentResponseOfint64AndDestinyItemStatsComponent _Stats;
            private DictionaryComponentResponseOfint64AndDestinyItemSocketsComponent _Sockets;
            private DictionaryComponentResponseOfint64AndDestinyItemReusablePlugsComponent _ReusablePlugs;
            private DictionaryComponentResponseOfint64AndDestinyItemPlugObjectivesComponent _PlugObjectives;
            private DictionaryComponentResponseOfint64AndDestinyItemTalentGridComponent _TalentGrids;
            private DictionaryComponentResponseOfuint32AndDestinyItemPlugComponent _PlugStates;
            private DictionaryComponentResponseOfint64AndDestinyItemObjectivesComponent _Objectives;

            internal DestinyItemComponentSetOfint64Builder()
            {
                SetupDefaults();
            }

            private void SetupDefaults()
            {
            }

            /// <summary>
            /// Sets value for DestinyItemComponentSetOfint64.Instances property.
            /// </summary>
            /// <param name="value">Instances</param>
            public DestinyItemComponentSetOfint64Builder Instances(DictionaryComponentResponseOfint64AndDestinyItemInstanceComponent value)
            {
                _Instances = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyItemComponentSetOfint64.Perks property.
            /// </summary>
            /// <param name="value">Perks</param>
            public DestinyItemComponentSetOfint64Builder Perks(DictionaryComponentResponseOfint64AndDestinyItemPerksComponent value)
            {
                _Perks = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyItemComponentSetOfint64.RenderData property.
            /// </summary>
            /// <param name="value">RenderData</param>
            public DestinyItemComponentSetOfint64Builder RenderData(DictionaryComponentResponseOfint64AndDestinyItemRenderComponent value)
            {
                _RenderData = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyItemComponentSetOfint64.Stats property.
            /// </summary>
            /// <param name="value">Stats</param>
            public DestinyItemComponentSetOfint64Builder Stats(DictionaryComponentResponseOfint64AndDestinyItemStatsComponent value)
            {
                _Stats = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyItemComponentSetOfint64.Sockets property.
            /// </summary>
            /// <param name="value">Sockets</param>
            public DestinyItemComponentSetOfint64Builder Sockets(DictionaryComponentResponseOfint64AndDestinyItemSocketsComponent value)
            {
                _Sockets = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyItemComponentSetOfint64.ReusablePlugs property.
            /// </summary>
            /// <param name="value">ReusablePlugs</param>
            public DestinyItemComponentSetOfint64Builder ReusablePlugs(DictionaryComponentResponseOfint64AndDestinyItemReusablePlugsComponent value)
            {
                _ReusablePlugs = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyItemComponentSetOfint64.PlugObjectives property.
            /// </summary>
            /// <param name="value">PlugObjectives</param>
            public DestinyItemComponentSetOfint64Builder PlugObjectives(DictionaryComponentResponseOfint64AndDestinyItemPlugObjectivesComponent value)
            {
                _PlugObjectives = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyItemComponentSetOfint64.TalentGrids property.
            /// </summary>
            /// <param name="value">TalentGrids</param>
            public DestinyItemComponentSetOfint64Builder TalentGrids(DictionaryComponentResponseOfint64AndDestinyItemTalentGridComponent value)
            {
                _TalentGrids = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyItemComponentSetOfint64.PlugStates property.
            /// </summary>
            /// <param name="value">PlugStates</param>
            public DestinyItemComponentSetOfint64Builder PlugStates(DictionaryComponentResponseOfuint32AndDestinyItemPlugComponent value)
            {
                _PlugStates = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyItemComponentSetOfint64.Objectives property.
            /// </summary>
            /// <param name="value">Objectives</param>
            public DestinyItemComponentSetOfint64Builder Objectives(DictionaryComponentResponseOfint64AndDestinyItemObjectivesComponent value)
            {
                _Objectives = value;
                return this;
            }


            /// <summary>
            /// Builds instance of DestinyItemComponentSetOfint64.
            /// </summary>
            /// <returns>DestinyItemComponentSetOfint64</returns>
            public DestinyItemComponentSetOfint64 Build()
            {
                Validate();
                return new DestinyItemComponentSetOfint64(
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