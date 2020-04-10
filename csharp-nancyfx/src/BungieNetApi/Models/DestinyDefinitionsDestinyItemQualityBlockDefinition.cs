using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Sharpility.Extensions;
using NodaTime;

namespace BungieNetApi._Platform.Models
{
    /// <summary>
    /// An item&#39;s \&quot;Quality\&quot; determines its calculated stats. The Level at which the item spawns is combined with its \&quot;qualityLevel\&quot; along with some additional calculations to determine the value of those stats.  In Destiny 2, most items don&#39;t have default item levels and quality, making this property less useful: these apparently are almost always determined by the complex mechanisms of the Reward system rather than statically. They are still provided here in case they are still useful for people. This also contains some information about Infusion.
    /// </summary>
    public sealed class DestinyDefinitionsDestinyItemQualityBlockDefinition:  IEquatable<DestinyDefinitionsDestinyItemQualityBlockDefinition>
    { 
        /// <summary>
        /// The \&quot;base\&quot; defined level of an item. This is a list because, in theory, each Expansion could define its own base level for an item.  In practice, not only was that never done in Destiny 1, but now this isn&#39;t even populated at all. When it&#39;s not populated, the level at which it spawns has to be inferred by Reward information, of which BNet receives an imperfect view and will only be reliable on instanced data as a result.
        /// </summary>
        public List<int?> ItemLevels { get; private set; }

        /// <summary>
        /// qualityLevel is used in combination with the item&#39;s level to calculate stats like Attack and Defense. It plays a role in that calculation, but not nearly as large as itemLevel does.
        /// </summary>
        public int? QualityLevel { get; private set; }

        /// <summary>
        /// The string identifier for this item&#39;s \&quot;infusability\&quot;, if any.   Items that match the same infusionCategoryName are allowed to infuse with each other.  DEPRECATED: Items can now have multiple infusion categories. Please use infusionCategoryHashes instead.
        /// </summary>
        public string InfusionCategoryName { get; private set; }

        /// <summary>
        /// The hash identifier for the infusion. It does not map to a Definition entity.  DEPRECATED: Items can now have multiple infusion categories. Please use infusionCategoryHashes instead.
        /// </summary>
        public int? InfusionCategoryHash { get; private set; }

        /// <summary>
        /// If any one of these hashes matches any value in another item&#39;s infusionCategoryHashes, the two can infuse with each other.
        /// </summary>
        public List<int?> InfusionCategoryHashes { get; private set; }

        /// <summary>
        /// An item can refer to pre-set level requirements. They are defined in DestinyProgressionLevelRequirementDefinition, and you can use this hash to find the appropriate definition.
        /// </summary>
        public int? ProgressionLevelRequirementHash { get; private set; }


        /// <summary>
        /// Empty constructor required by some serializers.
        /// Use DestinyDefinitionsDestinyItemQualityBlockDefinition.Builder() for instance creation instead.
        /// </summary>
        [Obsolete]
        public DestinyDefinitionsDestinyItemQualityBlockDefinition()
        {
        }

        private DestinyDefinitionsDestinyItemQualityBlockDefinition(List<int?> ItemLevels, int? QualityLevel, string InfusionCategoryName, int? InfusionCategoryHash, List<int?> InfusionCategoryHashes, int? ProgressionLevelRequirementHash)
        {
            
            this.ItemLevels = ItemLevels;
            
            this.QualityLevel = QualityLevel;
            
            this.InfusionCategoryName = InfusionCategoryName;
            
            this.InfusionCategoryHash = InfusionCategoryHash;
            
            this.InfusionCategoryHashes = InfusionCategoryHashes;
            
            this.ProgressionLevelRequirementHash = ProgressionLevelRequirementHash;
            
        }

        /// <summary>
        /// Returns builder of DestinyDefinitionsDestinyItemQualityBlockDefinition.
        /// </summary>
        /// <returns>DestinyDefinitionsDestinyItemQualityBlockDefinitionBuilder</returns>
        public static DestinyDefinitionsDestinyItemQualityBlockDefinitionBuilder Builder()
        {
            return new DestinyDefinitionsDestinyItemQualityBlockDefinitionBuilder();
        }

        /// <summary>
        /// Returns DestinyDefinitionsDestinyItemQualityBlockDefinitionBuilder with properties set.
        /// Use it to change properties.
        /// </summary>
        /// <returns>DestinyDefinitionsDestinyItemQualityBlockDefinitionBuilder</returns>
        public DestinyDefinitionsDestinyItemQualityBlockDefinitionBuilder With()
        {
            return Builder()
                .ItemLevels(ItemLevels)
                .QualityLevel(QualityLevel)
                .InfusionCategoryName(InfusionCategoryName)
                .InfusionCategoryHash(InfusionCategoryHash)
                .InfusionCategoryHashes(InfusionCategoryHashes)
                .ProgressionLevelRequirementHash(ProgressionLevelRequirementHash);
        }

        public override string ToString()
        {
            return this.PropertiesToString();
        }

        public override bool Equals(object obj)
        {
            return this.EqualsByProperties(obj);
        }

        public bool Equals(DestinyDefinitionsDestinyItemQualityBlockDefinition other)
        {
            return Equals((object) other);
        }

        public override int GetHashCode()
        {
            return this.PropertiesHash();
        }

        /// <summary>
        /// Implementation of == operator for (DestinyDefinitionsDestinyItemQualityBlockDefinition.
        /// </summary>
        /// <param name="left">Compared (DestinyDefinitionsDestinyItemQualityBlockDefinition</param>
        /// <param name="right">Compared (DestinyDefinitionsDestinyItemQualityBlockDefinition</param>
        /// <returns>true if compared items are equals, false otherwise</returns>
        public static bool operator == (DestinyDefinitionsDestinyItemQualityBlockDefinition left, DestinyDefinitionsDestinyItemQualityBlockDefinition right)
        {
            return Equals(left, right);
        }

        /// <summary>
        /// Implementation of != operator for (DestinyDefinitionsDestinyItemQualityBlockDefinition.
        /// </summary>
        /// <param name="left">Compared (DestinyDefinitionsDestinyItemQualityBlockDefinition</param>
        /// <param name="right">Compared (DestinyDefinitionsDestinyItemQualityBlockDefinition</param>
        /// <returns>true if compared items are not equals, false otherwise</returns>
        public static bool operator != (DestinyDefinitionsDestinyItemQualityBlockDefinition left, DestinyDefinitionsDestinyItemQualityBlockDefinition right)
        {
            return !Equals(left, right);
        }

        /// <summary>
        /// Builder of DestinyDefinitionsDestinyItemQualityBlockDefinition.
        /// </summary>
        public sealed class DestinyDefinitionsDestinyItemQualityBlockDefinitionBuilder
        {
            private List<int?> _ItemLevels;
            private int? _QualityLevel;
            private string _InfusionCategoryName;
            private int? _InfusionCategoryHash;
            private List<int?> _InfusionCategoryHashes;
            private int? _ProgressionLevelRequirementHash;

            internal DestinyDefinitionsDestinyItemQualityBlockDefinitionBuilder()
            {
                SetupDefaults();
            }

            private void SetupDefaults()
            {
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsDestinyItemQualityBlockDefinition.ItemLevels property.
            /// </summary>
            /// <param name="value">The \&quot;base\&quot; defined level of an item. This is a list because, in theory, each Expansion could define its own base level for an item.  In practice, not only was that never done in Destiny 1, but now this isn&#39;t even populated at all. When it&#39;s not populated, the level at which it spawns has to be inferred by Reward information, of which BNet receives an imperfect view and will only be reliable on instanced data as a result.</param>
            public DestinyDefinitionsDestinyItemQualityBlockDefinitionBuilder ItemLevels(List<int?> value)
            {
                _ItemLevels = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsDestinyItemQualityBlockDefinition.QualityLevel property.
            /// </summary>
            /// <param name="value">qualityLevel is used in combination with the item&#39;s level to calculate stats like Attack and Defense. It plays a role in that calculation, but not nearly as large as itemLevel does.</param>
            public DestinyDefinitionsDestinyItemQualityBlockDefinitionBuilder QualityLevel(int? value)
            {
                _QualityLevel = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsDestinyItemQualityBlockDefinition.InfusionCategoryName property.
            /// </summary>
            /// <param name="value">The string identifier for this item&#39;s \&quot;infusability\&quot;, if any.   Items that match the same infusionCategoryName are allowed to infuse with each other.  DEPRECATED: Items can now have multiple infusion categories. Please use infusionCategoryHashes instead.</param>
            public DestinyDefinitionsDestinyItemQualityBlockDefinitionBuilder InfusionCategoryName(string value)
            {
                _InfusionCategoryName = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsDestinyItemQualityBlockDefinition.InfusionCategoryHash property.
            /// </summary>
            /// <param name="value">The hash identifier for the infusion. It does not map to a Definition entity.  DEPRECATED: Items can now have multiple infusion categories. Please use infusionCategoryHashes instead.</param>
            public DestinyDefinitionsDestinyItemQualityBlockDefinitionBuilder InfusionCategoryHash(int? value)
            {
                _InfusionCategoryHash = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsDestinyItemQualityBlockDefinition.InfusionCategoryHashes property.
            /// </summary>
            /// <param name="value">If any one of these hashes matches any value in another item&#39;s infusionCategoryHashes, the two can infuse with each other.</param>
            public DestinyDefinitionsDestinyItemQualityBlockDefinitionBuilder InfusionCategoryHashes(List<int?> value)
            {
                _InfusionCategoryHashes = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsDestinyItemQualityBlockDefinition.ProgressionLevelRequirementHash property.
            /// </summary>
            /// <param name="value">An item can refer to pre-set level requirements. They are defined in DestinyProgressionLevelRequirementDefinition, and you can use this hash to find the appropriate definition.</param>
            public DestinyDefinitionsDestinyItemQualityBlockDefinitionBuilder ProgressionLevelRequirementHash(int? value)
            {
                _ProgressionLevelRequirementHash = value;
                return this;
            }


            /// <summary>
            /// Builds instance of DestinyDefinitionsDestinyItemQualityBlockDefinition.
            /// </summary>
            /// <returns>DestinyDefinitionsDestinyItemQualityBlockDefinition</returns>
            public DestinyDefinitionsDestinyItemQualityBlockDefinition Build()
            {
                Validate();
                return new DestinyDefinitionsDestinyItemQualityBlockDefinition(
                    ItemLevels: _ItemLevels,
                    QualityLevel: _QualityLevel,
                    InfusionCategoryName: _InfusionCategoryName,
                    InfusionCategoryHash: _InfusionCategoryHash,
                    InfusionCategoryHashes: _InfusionCategoryHashes,
                    ProgressionLevelRequirementHash: _ProgressionLevelRequirementHash
                );
            }

            private void Validate()
            { 
            }
        }

        
    }
}