using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Sharpility.Extensions;
using NodaTime;

namespace BungieNetApi._Platform.Models
{
    /// <summary>
    /// If you&#39;re going to report someone for a Terms of Service violation, you need to choose a category and reason for the report. This definition holds both the categories and the reasons within those categories, for simplicity and my own laziness&#39; sake.  Note tha this means that, to refer to a Reason by reasonHash, you need a combination of the reasonHash *and* the associated ReasonCategory&#39;s hash: there are some reasons defined under multiple categories.
    /// </summary>
    public sealed class DestinyDefinitionsReportingDestinyReportReasonCategoryDefinition:  IEquatable<DestinyDefinitionsReportingDestinyReportReasonCategoryDefinition>
    { 
        /// <summary>
        /// DisplayProperties
        /// </summary>
        public DestinyDefinitionsCommonDestinyDisplayPropertiesDefinition DisplayProperties { get; private set; }

        /// <summary>
        /// The specific reasons for the report under this category.
        /// </summary>
        public Dictionary<string, DestinyDefinitionsReportingDestinyReportReasonDefinition> Reasons { get; private set; }

        /// <summary>
        /// The unique identifier for this entity. Guaranteed to be unique for the type of entity, but not globally.  When entities refer to each other in Destiny content, it is this hash that they are referring to.
        /// </summary>
        public int? Hash { get; private set; }

        /// <summary>
        /// The index of the entity as it was found in the investment tables.
        /// </summary>
        public int? Index { get; private set; }

        /// <summary>
        /// If this is true, then there is an entity with this identifier/type combination, but BNet is not yet allowed to show it. Sorry!
        /// </summary>
        public bool? Redacted { get; private set; }


        /// <summary>
        /// Empty constructor required by some serializers.
        /// Use DestinyDefinitionsReportingDestinyReportReasonCategoryDefinition.Builder() for instance creation instead.
        /// </summary>
        [Obsolete]
        public DestinyDefinitionsReportingDestinyReportReasonCategoryDefinition()
        {
        }

        private DestinyDefinitionsReportingDestinyReportReasonCategoryDefinition(DestinyDefinitionsCommonDestinyDisplayPropertiesDefinition DisplayProperties, Dictionary<string, DestinyDefinitionsReportingDestinyReportReasonDefinition> Reasons, int? Hash, int? Index, bool? Redacted)
        {
            
            this.DisplayProperties = DisplayProperties;
            
            this.Reasons = Reasons;
            
            this.Hash = Hash;
            
            this.Index = Index;
            
            this.Redacted = Redacted;
            
        }

        /// <summary>
        /// Returns builder of DestinyDefinitionsReportingDestinyReportReasonCategoryDefinition.
        /// </summary>
        /// <returns>DestinyDefinitionsReportingDestinyReportReasonCategoryDefinitionBuilder</returns>
        public static DestinyDefinitionsReportingDestinyReportReasonCategoryDefinitionBuilder Builder()
        {
            return new DestinyDefinitionsReportingDestinyReportReasonCategoryDefinitionBuilder();
        }

        /// <summary>
        /// Returns DestinyDefinitionsReportingDestinyReportReasonCategoryDefinitionBuilder with properties set.
        /// Use it to change properties.
        /// </summary>
        /// <returns>DestinyDefinitionsReportingDestinyReportReasonCategoryDefinitionBuilder</returns>
        public DestinyDefinitionsReportingDestinyReportReasonCategoryDefinitionBuilder With()
        {
            return Builder()
                .DisplayProperties(DisplayProperties)
                .Reasons(Reasons)
                .Hash(Hash)
                .Index(Index)
                .Redacted(Redacted);
        }

        public override string ToString()
        {
            return this.PropertiesToString();
        }

        public override bool Equals(object obj)
        {
            return this.EqualsByProperties(obj);
        }

        public bool Equals(DestinyDefinitionsReportingDestinyReportReasonCategoryDefinition other)
        {
            return Equals((object) other);
        }

        public override int GetHashCode()
        {
            return this.PropertiesHash();
        }

        /// <summary>
        /// Implementation of == operator for (DestinyDefinitionsReportingDestinyReportReasonCategoryDefinition.
        /// </summary>
        /// <param name="left">Compared (DestinyDefinitionsReportingDestinyReportReasonCategoryDefinition</param>
        /// <param name="right">Compared (DestinyDefinitionsReportingDestinyReportReasonCategoryDefinition</param>
        /// <returns>true if compared items are equals, false otherwise</returns>
        public static bool operator == (DestinyDefinitionsReportingDestinyReportReasonCategoryDefinition left, DestinyDefinitionsReportingDestinyReportReasonCategoryDefinition right)
        {
            return Equals(left, right);
        }

        /// <summary>
        /// Implementation of != operator for (DestinyDefinitionsReportingDestinyReportReasonCategoryDefinition.
        /// </summary>
        /// <param name="left">Compared (DestinyDefinitionsReportingDestinyReportReasonCategoryDefinition</param>
        /// <param name="right">Compared (DestinyDefinitionsReportingDestinyReportReasonCategoryDefinition</param>
        /// <returns>true if compared items are not equals, false otherwise</returns>
        public static bool operator != (DestinyDefinitionsReportingDestinyReportReasonCategoryDefinition left, DestinyDefinitionsReportingDestinyReportReasonCategoryDefinition right)
        {
            return !Equals(left, right);
        }

        /// <summary>
        /// Builder of DestinyDefinitionsReportingDestinyReportReasonCategoryDefinition.
        /// </summary>
        public sealed class DestinyDefinitionsReportingDestinyReportReasonCategoryDefinitionBuilder
        {
            private DestinyDefinitionsCommonDestinyDisplayPropertiesDefinition _DisplayProperties;
            private Dictionary<string, DestinyDefinitionsReportingDestinyReportReasonDefinition> _Reasons;
            private int? _Hash;
            private int? _Index;
            private bool? _Redacted;

            internal DestinyDefinitionsReportingDestinyReportReasonCategoryDefinitionBuilder()
            {
                SetupDefaults();
            }

            private void SetupDefaults()
            {
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsReportingDestinyReportReasonCategoryDefinition.DisplayProperties property.
            /// </summary>
            /// <param name="value">DisplayProperties</param>
            public DestinyDefinitionsReportingDestinyReportReasonCategoryDefinitionBuilder DisplayProperties(DestinyDefinitionsCommonDestinyDisplayPropertiesDefinition value)
            {
                _DisplayProperties = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsReportingDestinyReportReasonCategoryDefinition.Reasons property.
            /// </summary>
            /// <param name="value">The specific reasons for the report under this category.</param>
            public DestinyDefinitionsReportingDestinyReportReasonCategoryDefinitionBuilder Reasons(Dictionary<string, DestinyDefinitionsReportingDestinyReportReasonDefinition> value)
            {
                _Reasons = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsReportingDestinyReportReasonCategoryDefinition.Hash property.
            /// </summary>
            /// <param name="value">The unique identifier for this entity. Guaranteed to be unique for the type of entity, but not globally.  When entities refer to each other in Destiny content, it is this hash that they are referring to.</param>
            public DestinyDefinitionsReportingDestinyReportReasonCategoryDefinitionBuilder Hash(int? value)
            {
                _Hash = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsReportingDestinyReportReasonCategoryDefinition.Index property.
            /// </summary>
            /// <param name="value">The index of the entity as it was found in the investment tables.</param>
            public DestinyDefinitionsReportingDestinyReportReasonCategoryDefinitionBuilder Index(int? value)
            {
                _Index = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsReportingDestinyReportReasonCategoryDefinition.Redacted property.
            /// </summary>
            /// <param name="value">If this is true, then there is an entity with this identifier/type combination, but BNet is not yet allowed to show it. Sorry!</param>
            public DestinyDefinitionsReportingDestinyReportReasonCategoryDefinitionBuilder Redacted(bool? value)
            {
                _Redacted = value;
                return this;
            }


            /// <summary>
            /// Builds instance of DestinyDefinitionsReportingDestinyReportReasonCategoryDefinition.
            /// </summary>
            /// <returns>DestinyDefinitionsReportingDestinyReportReasonCategoryDefinition</returns>
            public DestinyDefinitionsReportingDestinyReportReasonCategoryDefinition Build()
            {
                Validate();
                return new DestinyDefinitionsReportingDestinyReportReasonCategoryDefinition(
                    DisplayProperties: _DisplayProperties,
                    Reasons: _Reasons,
                    Hash: _Hash,
                    Index: _Index,
                    Redacted: _Redacted
                );
            }

            private void Validate()
            { 
            }
        }

        
    }
}