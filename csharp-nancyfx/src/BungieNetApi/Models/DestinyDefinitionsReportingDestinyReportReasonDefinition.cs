using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Sharpility.Extensions;
using NodaTime;

namespace BungieNetApi._Platform.Models
{
    /// <summary>
    /// A specific reason for being banned. Only accessible under the related category (DestinyReportReasonCategoryDefinition) under which it is shown. Note that this means that report reasons&#39; reasonHash are not globally unique: and indeed, entries like \&quot;Other\&quot; are defined under most categories for example.
    /// </summary>
    public sealed class DestinyDefinitionsReportingDestinyReportReasonDefinition:  IEquatable<DestinyDefinitionsReportingDestinyReportReasonDefinition>
    { 
        /// <summary>
        /// The identifier for the reason: they are only guaranteed unique under the Category in which they are found.
        /// </summary>
        public int? ReasonHash { get; private set; }

        /// <summary>
        /// DisplayProperties
        /// </summary>
        public DestinyDefinitionsCommonDestinyDisplayPropertiesDefinition DisplayProperties { get; private set; }


        /// <summary>
        /// Empty constructor required by some serializers.
        /// Use DestinyDefinitionsReportingDestinyReportReasonDefinition.Builder() for instance creation instead.
        /// </summary>
        [Obsolete]
        public DestinyDefinitionsReportingDestinyReportReasonDefinition()
        {
        }

        private DestinyDefinitionsReportingDestinyReportReasonDefinition(int? ReasonHash, DestinyDefinitionsCommonDestinyDisplayPropertiesDefinition DisplayProperties)
        {
            
            this.ReasonHash = ReasonHash;
            
            this.DisplayProperties = DisplayProperties;
            
        }

        /// <summary>
        /// Returns builder of DestinyDefinitionsReportingDestinyReportReasonDefinition.
        /// </summary>
        /// <returns>DestinyDefinitionsReportingDestinyReportReasonDefinitionBuilder</returns>
        public static DestinyDefinitionsReportingDestinyReportReasonDefinitionBuilder Builder()
        {
            return new DestinyDefinitionsReportingDestinyReportReasonDefinitionBuilder();
        }

        /// <summary>
        /// Returns DestinyDefinitionsReportingDestinyReportReasonDefinitionBuilder with properties set.
        /// Use it to change properties.
        /// </summary>
        /// <returns>DestinyDefinitionsReportingDestinyReportReasonDefinitionBuilder</returns>
        public DestinyDefinitionsReportingDestinyReportReasonDefinitionBuilder With()
        {
            return Builder()
                .ReasonHash(ReasonHash)
                .DisplayProperties(DisplayProperties);
        }

        public override string ToString()
        {
            return this.PropertiesToString();
        }

        public override bool Equals(object obj)
        {
            return this.EqualsByProperties(obj);
        }

        public bool Equals(DestinyDefinitionsReportingDestinyReportReasonDefinition other)
        {
            return Equals((object) other);
        }

        public override int GetHashCode()
        {
            return this.PropertiesHash();
        }

        /// <summary>
        /// Implementation of == operator for (DestinyDefinitionsReportingDestinyReportReasonDefinition.
        /// </summary>
        /// <param name="left">Compared (DestinyDefinitionsReportingDestinyReportReasonDefinition</param>
        /// <param name="right">Compared (DestinyDefinitionsReportingDestinyReportReasonDefinition</param>
        /// <returns>true if compared items are equals, false otherwise</returns>
        public static bool operator == (DestinyDefinitionsReportingDestinyReportReasonDefinition left, DestinyDefinitionsReportingDestinyReportReasonDefinition right)
        {
            return Equals(left, right);
        }

        /// <summary>
        /// Implementation of != operator for (DestinyDefinitionsReportingDestinyReportReasonDefinition.
        /// </summary>
        /// <param name="left">Compared (DestinyDefinitionsReportingDestinyReportReasonDefinition</param>
        /// <param name="right">Compared (DestinyDefinitionsReportingDestinyReportReasonDefinition</param>
        /// <returns>true if compared items are not equals, false otherwise</returns>
        public static bool operator != (DestinyDefinitionsReportingDestinyReportReasonDefinition left, DestinyDefinitionsReportingDestinyReportReasonDefinition right)
        {
            return !Equals(left, right);
        }

        /// <summary>
        /// Builder of DestinyDefinitionsReportingDestinyReportReasonDefinition.
        /// </summary>
        public sealed class DestinyDefinitionsReportingDestinyReportReasonDefinitionBuilder
        {
            private int? _ReasonHash;
            private DestinyDefinitionsCommonDestinyDisplayPropertiesDefinition _DisplayProperties;

            internal DestinyDefinitionsReportingDestinyReportReasonDefinitionBuilder()
            {
                SetupDefaults();
            }

            private void SetupDefaults()
            {
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsReportingDestinyReportReasonDefinition.ReasonHash property.
            /// </summary>
            /// <param name="value">The identifier for the reason: they are only guaranteed unique under the Category in which they are found.</param>
            public DestinyDefinitionsReportingDestinyReportReasonDefinitionBuilder ReasonHash(int? value)
            {
                _ReasonHash = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsReportingDestinyReportReasonDefinition.DisplayProperties property.
            /// </summary>
            /// <param name="value">DisplayProperties</param>
            public DestinyDefinitionsReportingDestinyReportReasonDefinitionBuilder DisplayProperties(DestinyDefinitionsCommonDestinyDisplayPropertiesDefinition value)
            {
                _DisplayProperties = value;
                return this;
            }


            /// <summary>
            /// Builds instance of DestinyDefinitionsReportingDestinyReportReasonDefinition.
            /// </summary>
            /// <returns>DestinyDefinitionsReportingDestinyReportReasonDefinition</returns>
            public DestinyDefinitionsReportingDestinyReportReasonDefinition Build()
            {
                Validate();
                return new DestinyDefinitionsReportingDestinyReportReasonDefinition(
                    ReasonHash: _ReasonHash,
                    DisplayProperties: _DisplayProperties
                );
            }

            private void Validate()
            { 
            }
        }

        
    }
}