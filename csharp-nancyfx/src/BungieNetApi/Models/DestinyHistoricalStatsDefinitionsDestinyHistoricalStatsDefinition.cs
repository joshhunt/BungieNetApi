using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Sharpility.Extensions;
using NodaTime;

namespace BungieNetApi._Platform.Models
{
    /// <summary>
    /// DestinyHistoricalStatsDefinitionsDestinyHistoricalStatsDefinition
    /// </summary>
    public sealed class DestinyHistoricalStatsDefinitionsDestinyHistoricalStatsDefinition:  IEquatable<DestinyHistoricalStatsDefinitionsDestinyHistoricalStatsDefinition>
    { 
        /// <summary>
        /// Unique programmer friendly ID for this stat
        /// </summary>
        public string StatId { get; private set; }

        /// <summary>
        /// Statistic group
        /// </summary>
        public int? Group { get; private set; }

        /// <summary>
        /// Time periods the statistic covers
        /// </summary>
        public List<int?> PeriodTypes { get; private set; }

        /// <summary>
        /// Game modes where this statistic can be reported.
        /// </summary>
        public List<int?> Modes { get; private set; }

        /// <summary>
        /// Category for the stat.
        /// </summary>
        public int? Category { get; private set; }

        /// <summary>
        /// Display name
        /// </summary>
        public string StatName { get; private set; }

        /// <summary>
        /// Display name abbreviated
        /// </summary>
        public string StatNameAbbr { get; private set; }

        /// <summary>
        /// Description of a stat if applicable.
        /// </summary>
        public string StatDescription { get; private set; }

        /// <summary>
        /// Unit, if any, for the statistic
        /// </summary>
        public int? UnitType { get; private set; }

        /// <summary>
        /// Optional URI to an icon for the statistic
        /// </summary>
        public string IconImage { get; private set; }

        /// <summary>
        /// Optional icon for the statistic
        /// </summary>
        public MergeMethodEnum? MergeMethod { get; private set; }

        /// <summary>
        /// Localized Unit Name for the stat.
        /// </summary>
        public string UnitLabel { get; private set; }

        /// <summary>
        /// Weight assigned to this stat indicating its relative impressiveness.
        /// </summary>
        public int? Weight { get; private set; }

        /// <summary>
        /// The tier associated with this medal - be it implicitly or explicitly.
        /// </summary>
        public int? MedalTierHash { get; private set; }


        /// <summary>
        /// Empty constructor required by some serializers.
        /// Use DestinyHistoricalStatsDefinitionsDestinyHistoricalStatsDefinition.Builder() for instance creation instead.
        /// </summary>
        [Obsolete]
        public DestinyHistoricalStatsDefinitionsDestinyHistoricalStatsDefinition()
        {
        }

        private DestinyHistoricalStatsDefinitionsDestinyHistoricalStatsDefinition(string StatId, int? Group, List<int?> PeriodTypes, List<int?> Modes, int? Category, string StatName, string StatNameAbbr, string StatDescription, int? UnitType, string IconImage, MergeMethodEnum? MergeMethod, string UnitLabel, int? Weight, int? MedalTierHash)
        {
            
            this.StatId = StatId;
            
            this.Group = Group;
            
            this.PeriodTypes = PeriodTypes;
            
            this.Modes = Modes;
            
            this.Category = Category;
            
            this.StatName = StatName;
            
            this.StatNameAbbr = StatNameAbbr;
            
            this.StatDescription = StatDescription;
            
            this.UnitType = UnitType;
            
            this.IconImage = IconImage;
            
            this.MergeMethod = MergeMethod;
            
            this.UnitLabel = UnitLabel;
            
            this.Weight = Weight;
            
            this.MedalTierHash = MedalTierHash;
            
        }

        /// <summary>
        /// Returns builder of DestinyHistoricalStatsDefinitionsDestinyHistoricalStatsDefinition.
        /// </summary>
        /// <returns>DestinyHistoricalStatsDefinitionsDestinyHistoricalStatsDefinitionBuilder</returns>
        public static DestinyHistoricalStatsDefinitionsDestinyHistoricalStatsDefinitionBuilder Builder()
        {
            return new DestinyHistoricalStatsDefinitionsDestinyHistoricalStatsDefinitionBuilder();
        }

        /// <summary>
        /// Returns DestinyHistoricalStatsDefinitionsDestinyHistoricalStatsDefinitionBuilder with properties set.
        /// Use it to change properties.
        /// </summary>
        /// <returns>DestinyHistoricalStatsDefinitionsDestinyHistoricalStatsDefinitionBuilder</returns>
        public DestinyHistoricalStatsDefinitionsDestinyHistoricalStatsDefinitionBuilder With()
        {
            return Builder()
                .StatId(StatId)
                .Group(Group)
                .PeriodTypes(PeriodTypes)
                .Modes(Modes)
                .Category(Category)
                .StatName(StatName)
                .StatNameAbbr(StatNameAbbr)
                .StatDescription(StatDescription)
                .UnitType(UnitType)
                .IconImage(IconImage)
                .MergeMethod(MergeMethod)
                .UnitLabel(UnitLabel)
                .Weight(Weight)
                .MedalTierHash(MedalTierHash);
        }

        public override string ToString()
        {
            return this.PropertiesToString();
        }

        public override bool Equals(object obj)
        {
            return this.EqualsByProperties(obj);
        }

        public bool Equals(DestinyHistoricalStatsDefinitionsDestinyHistoricalStatsDefinition other)
        {
            return Equals((object) other);
        }

        public override int GetHashCode()
        {
            return this.PropertiesHash();
        }

        /// <summary>
        /// Implementation of == operator for (DestinyHistoricalStatsDefinitionsDestinyHistoricalStatsDefinition.
        /// </summary>
        /// <param name="left">Compared (DestinyHistoricalStatsDefinitionsDestinyHistoricalStatsDefinition</param>
        /// <param name="right">Compared (DestinyHistoricalStatsDefinitionsDestinyHistoricalStatsDefinition</param>
        /// <returns>true if compared items are equals, false otherwise</returns>
        public static bool operator == (DestinyHistoricalStatsDefinitionsDestinyHistoricalStatsDefinition left, DestinyHistoricalStatsDefinitionsDestinyHistoricalStatsDefinition right)
        {
            return Equals(left, right);
        }

        /// <summary>
        /// Implementation of != operator for (DestinyHistoricalStatsDefinitionsDestinyHistoricalStatsDefinition.
        /// </summary>
        /// <param name="left">Compared (DestinyHistoricalStatsDefinitionsDestinyHistoricalStatsDefinition</param>
        /// <param name="right">Compared (DestinyHistoricalStatsDefinitionsDestinyHistoricalStatsDefinition</param>
        /// <returns>true if compared items are not equals, false otherwise</returns>
        public static bool operator != (DestinyHistoricalStatsDefinitionsDestinyHistoricalStatsDefinition left, DestinyHistoricalStatsDefinitionsDestinyHistoricalStatsDefinition right)
        {
            return !Equals(left, right);
        }

        /// <summary>
        /// Builder of DestinyHistoricalStatsDefinitionsDestinyHistoricalStatsDefinition.
        /// </summary>
        public sealed class DestinyHistoricalStatsDefinitionsDestinyHistoricalStatsDefinitionBuilder
        {
            private string _StatId;
            private int? _Group;
            private List<int?> _PeriodTypes;
            private List<int?> _Modes;
            private int? _Category;
            private string _StatName;
            private string _StatNameAbbr;
            private string _StatDescription;
            private int? _UnitType;
            private string _IconImage;
            private MergeMethodEnum? _MergeMethod;
            private string _UnitLabel;
            private int? _Weight;
            private int? _MedalTierHash;

            internal DestinyHistoricalStatsDefinitionsDestinyHistoricalStatsDefinitionBuilder()
            {
                SetupDefaults();
            }

            private void SetupDefaults()
            {
            }

            /// <summary>
            /// Sets value for DestinyHistoricalStatsDefinitionsDestinyHistoricalStatsDefinition.StatId property.
            /// </summary>
            /// <param name="value">Unique programmer friendly ID for this stat</param>
            public DestinyHistoricalStatsDefinitionsDestinyHistoricalStatsDefinitionBuilder StatId(string value)
            {
                _StatId = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyHistoricalStatsDefinitionsDestinyHistoricalStatsDefinition.Group property.
            /// </summary>
            /// <param name="value">Statistic group</param>
            public DestinyHistoricalStatsDefinitionsDestinyHistoricalStatsDefinitionBuilder Group(int? value)
            {
                _Group = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyHistoricalStatsDefinitionsDestinyHistoricalStatsDefinition.PeriodTypes property.
            /// </summary>
            /// <param name="value">Time periods the statistic covers</param>
            public DestinyHistoricalStatsDefinitionsDestinyHistoricalStatsDefinitionBuilder PeriodTypes(List<int?> value)
            {
                _PeriodTypes = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyHistoricalStatsDefinitionsDestinyHistoricalStatsDefinition.Modes property.
            /// </summary>
            /// <param name="value">Game modes where this statistic can be reported.</param>
            public DestinyHistoricalStatsDefinitionsDestinyHistoricalStatsDefinitionBuilder Modes(List<int?> value)
            {
                _Modes = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyHistoricalStatsDefinitionsDestinyHistoricalStatsDefinition.Category property.
            /// </summary>
            /// <param name="value">Category for the stat.</param>
            public DestinyHistoricalStatsDefinitionsDestinyHistoricalStatsDefinitionBuilder Category(int? value)
            {
                _Category = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyHistoricalStatsDefinitionsDestinyHistoricalStatsDefinition.StatName property.
            /// </summary>
            /// <param name="value">Display name</param>
            public DestinyHistoricalStatsDefinitionsDestinyHistoricalStatsDefinitionBuilder StatName(string value)
            {
                _StatName = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyHistoricalStatsDefinitionsDestinyHistoricalStatsDefinition.StatNameAbbr property.
            /// </summary>
            /// <param name="value">Display name abbreviated</param>
            public DestinyHistoricalStatsDefinitionsDestinyHistoricalStatsDefinitionBuilder StatNameAbbr(string value)
            {
                _StatNameAbbr = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyHistoricalStatsDefinitionsDestinyHistoricalStatsDefinition.StatDescription property.
            /// </summary>
            /// <param name="value">Description of a stat if applicable.</param>
            public DestinyHistoricalStatsDefinitionsDestinyHistoricalStatsDefinitionBuilder StatDescription(string value)
            {
                _StatDescription = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyHistoricalStatsDefinitionsDestinyHistoricalStatsDefinition.UnitType property.
            /// </summary>
            /// <param name="value">Unit, if any, for the statistic</param>
            public DestinyHistoricalStatsDefinitionsDestinyHistoricalStatsDefinitionBuilder UnitType(int? value)
            {
                _UnitType = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyHistoricalStatsDefinitionsDestinyHistoricalStatsDefinition.IconImage property.
            /// </summary>
            /// <param name="value">Optional URI to an icon for the statistic</param>
            public DestinyHistoricalStatsDefinitionsDestinyHistoricalStatsDefinitionBuilder IconImage(string value)
            {
                _IconImage = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyHistoricalStatsDefinitionsDestinyHistoricalStatsDefinition.MergeMethod property.
            /// </summary>
            /// <param name="value">Optional icon for the statistic</param>
            public DestinyHistoricalStatsDefinitionsDestinyHistoricalStatsDefinitionBuilder MergeMethod(MergeMethodEnum? value)
            {
                _MergeMethod = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyHistoricalStatsDefinitionsDestinyHistoricalStatsDefinition.UnitLabel property.
            /// </summary>
            /// <param name="value">Localized Unit Name for the stat.</param>
            public DestinyHistoricalStatsDefinitionsDestinyHistoricalStatsDefinitionBuilder UnitLabel(string value)
            {
                _UnitLabel = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyHistoricalStatsDefinitionsDestinyHistoricalStatsDefinition.Weight property.
            /// </summary>
            /// <param name="value">Weight assigned to this stat indicating its relative impressiveness.</param>
            public DestinyHistoricalStatsDefinitionsDestinyHistoricalStatsDefinitionBuilder Weight(int? value)
            {
                _Weight = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyHistoricalStatsDefinitionsDestinyHistoricalStatsDefinition.MedalTierHash property.
            /// </summary>
            /// <param name="value">The tier associated with this medal - be it implicitly or explicitly.</param>
            public DestinyHistoricalStatsDefinitionsDestinyHistoricalStatsDefinitionBuilder MedalTierHash(int? value)
            {
                _MedalTierHash = value;
                return this;
            }


            /// <summary>
            /// Builds instance of DestinyHistoricalStatsDefinitionsDestinyHistoricalStatsDefinition.
            /// </summary>
            /// <returns>DestinyHistoricalStatsDefinitionsDestinyHistoricalStatsDefinition</returns>
            public DestinyHistoricalStatsDefinitionsDestinyHistoricalStatsDefinition Build()
            {
                Validate();
                return new DestinyHistoricalStatsDefinitionsDestinyHistoricalStatsDefinition(
                    StatId: _StatId,
                    Group: _Group,
                    PeriodTypes: _PeriodTypes,
                    Modes: _Modes,
                    Category: _Category,
                    StatName: _StatName,
                    StatNameAbbr: _StatNameAbbr,
                    StatDescription: _StatDescription,
                    UnitType: _UnitType,
                    IconImage: _IconImage,
                    MergeMethod: _MergeMethod,
                    UnitLabel: _UnitLabel,
                    Weight: _Weight,
                    MedalTierHash: _MedalTierHash
                );
            }

            private void Validate()
            { 
            }
        }

        
        public enum MergeMethodEnum { _0, _1, _2 };
    }
}