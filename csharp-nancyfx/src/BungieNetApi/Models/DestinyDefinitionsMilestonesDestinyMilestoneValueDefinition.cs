using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Sharpility.Extensions;
using NodaTime;

namespace BungieNetApi._Platform.Models
{
    /// <summary>
    /// The definition for information related to a key/value pair that is relevant for a particular Milestone or component within the Milestone.   This lets us more flexibly pass up information that&#39;s useful to someone, even if it&#39;s not necessarily us.
    /// </summary>
    public sealed class DestinyDefinitionsMilestonesDestinyMilestoneValueDefinition:  IEquatable<DestinyDefinitionsMilestonesDestinyMilestoneValueDefinition>
    { 
        /// <summary>
        /// Key
        /// </summary>
        public string Key { get; private set; }

        /// <summary>
        /// DisplayProperties
        /// </summary>
        public DestinyDefinitionsCommonDestinyDisplayPropertiesDefinition DisplayProperties { get; private set; }


        /// <summary>
        /// Empty constructor required by some serializers.
        /// Use DestinyDefinitionsMilestonesDestinyMilestoneValueDefinition.Builder() for instance creation instead.
        /// </summary>
        [Obsolete]
        public DestinyDefinitionsMilestonesDestinyMilestoneValueDefinition()
        {
        }

        private DestinyDefinitionsMilestonesDestinyMilestoneValueDefinition(string Key, DestinyDefinitionsCommonDestinyDisplayPropertiesDefinition DisplayProperties)
        {
            
            this.Key = Key;
            
            this.DisplayProperties = DisplayProperties;
            
        }

        /// <summary>
        /// Returns builder of DestinyDefinitionsMilestonesDestinyMilestoneValueDefinition.
        /// </summary>
        /// <returns>DestinyDefinitionsMilestonesDestinyMilestoneValueDefinitionBuilder</returns>
        public static DestinyDefinitionsMilestonesDestinyMilestoneValueDefinitionBuilder Builder()
        {
            return new DestinyDefinitionsMilestonesDestinyMilestoneValueDefinitionBuilder();
        }

        /// <summary>
        /// Returns DestinyDefinitionsMilestonesDestinyMilestoneValueDefinitionBuilder with properties set.
        /// Use it to change properties.
        /// </summary>
        /// <returns>DestinyDefinitionsMilestonesDestinyMilestoneValueDefinitionBuilder</returns>
        public DestinyDefinitionsMilestonesDestinyMilestoneValueDefinitionBuilder With()
        {
            return Builder()
                .Key(Key)
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

        public bool Equals(DestinyDefinitionsMilestonesDestinyMilestoneValueDefinition other)
        {
            return Equals((object) other);
        }

        public override int GetHashCode()
        {
            return this.PropertiesHash();
        }

        /// <summary>
        /// Implementation of == operator for (DestinyDefinitionsMilestonesDestinyMilestoneValueDefinition.
        /// </summary>
        /// <param name="left">Compared (DestinyDefinitionsMilestonesDestinyMilestoneValueDefinition</param>
        /// <param name="right">Compared (DestinyDefinitionsMilestonesDestinyMilestoneValueDefinition</param>
        /// <returns>true if compared items are equals, false otherwise</returns>
        public static bool operator == (DestinyDefinitionsMilestonesDestinyMilestoneValueDefinition left, DestinyDefinitionsMilestonesDestinyMilestoneValueDefinition right)
        {
            return Equals(left, right);
        }

        /// <summary>
        /// Implementation of != operator for (DestinyDefinitionsMilestonesDestinyMilestoneValueDefinition.
        /// </summary>
        /// <param name="left">Compared (DestinyDefinitionsMilestonesDestinyMilestoneValueDefinition</param>
        /// <param name="right">Compared (DestinyDefinitionsMilestonesDestinyMilestoneValueDefinition</param>
        /// <returns>true if compared items are not equals, false otherwise</returns>
        public static bool operator != (DestinyDefinitionsMilestonesDestinyMilestoneValueDefinition left, DestinyDefinitionsMilestonesDestinyMilestoneValueDefinition right)
        {
            return !Equals(left, right);
        }

        /// <summary>
        /// Builder of DestinyDefinitionsMilestonesDestinyMilestoneValueDefinition.
        /// </summary>
        public sealed class DestinyDefinitionsMilestonesDestinyMilestoneValueDefinitionBuilder
        {
            private string _Key;
            private DestinyDefinitionsCommonDestinyDisplayPropertiesDefinition _DisplayProperties;

            internal DestinyDefinitionsMilestonesDestinyMilestoneValueDefinitionBuilder()
            {
                SetupDefaults();
            }

            private void SetupDefaults()
            {
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsMilestonesDestinyMilestoneValueDefinition.Key property.
            /// </summary>
            /// <param name="value">Key</param>
            public DestinyDefinitionsMilestonesDestinyMilestoneValueDefinitionBuilder Key(string value)
            {
                _Key = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsMilestonesDestinyMilestoneValueDefinition.DisplayProperties property.
            /// </summary>
            /// <param name="value">DisplayProperties</param>
            public DestinyDefinitionsMilestonesDestinyMilestoneValueDefinitionBuilder DisplayProperties(DestinyDefinitionsCommonDestinyDisplayPropertiesDefinition value)
            {
                _DisplayProperties = value;
                return this;
            }


            /// <summary>
            /// Builds instance of DestinyDefinitionsMilestonesDestinyMilestoneValueDefinition.
            /// </summary>
            /// <returns>DestinyDefinitionsMilestonesDestinyMilestoneValueDefinition</returns>
            public DestinyDefinitionsMilestonesDestinyMilestoneValueDefinition Build()
            {
                Validate();
                return new DestinyDefinitionsMilestonesDestinyMilestoneValueDefinition(
                    Key: _Key,
                    DisplayProperties: _DisplayProperties
                );
            }

            private void Validate()
            { 
            }
        }

        
    }
}