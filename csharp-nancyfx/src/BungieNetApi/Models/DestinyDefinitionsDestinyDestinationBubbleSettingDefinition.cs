using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Sharpility.Extensions;
using NodaTime;

namespace BungieNetApi._Platform.Models
{
    /// <summary>
    /// Human readable data about the bubble. Combine with DestinyBubbleDefinition - see DestinyDestinationDefinition.bubbleSettings for more information.  DEPRECATED - Just use bubbles.
    /// </summary>
    public sealed class DestinyDefinitionsDestinyDestinationBubbleSettingDefinition:  IEquatable<DestinyDefinitionsDestinyDestinationBubbleSettingDefinition>
    { 
        /// <summary>
        /// DisplayProperties
        /// </summary>
        public DestinyDefinitionsCommonDestinyDisplayPropertiesDefinition DisplayProperties { get; private set; }


        /// <summary>
        /// Empty constructor required by some serializers.
        /// Use DestinyDefinitionsDestinyDestinationBubbleSettingDefinition.Builder() for instance creation instead.
        /// </summary>
        [Obsolete]
        public DestinyDefinitionsDestinyDestinationBubbleSettingDefinition()
        {
        }

        private DestinyDefinitionsDestinyDestinationBubbleSettingDefinition(DestinyDefinitionsCommonDestinyDisplayPropertiesDefinition DisplayProperties)
        {
            
            this.DisplayProperties = DisplayProperties;
            
        }

        /// <summary>
        /// Returns builder of DestinyDefinitionsDestinyDestinationBubbleSettingDefinition.
        /// </summary>
        /// <returns>DestinyDefinitionsDestinyDestinationBubbleSettingDefinitionBuilder</returns>
        public static DestinyDefinitionsDestinyDestinationBubbleSettingDefinitionBuilder Builder()
        {
            return new DestinyDefinitionsDestinyDestinationBubbleSettingDefinitionBuilder();
        }

        /// <summary>
        /// Returns DestinyDefinitionsDestinyDestinationBubbleSettingDefinitionBuilder with properties set.
        /// Use it to change properties.
        /// </summary>
        /// <returns>DestinyDefinitionsDestinyDestinationBubbleSettingDefinitionBuilder</returns>
        public DestinyDefinitionsDestinyDestinationBubbleSettingDefinitionBuilder With()
        {
            return Builder()
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

        public bool Equals(DestinyDefinitionsDestinyDestinationBubbleSettingDefinition other)
        {
            return Equals((object) other);
        }

        public override int GetHashCode()
        {
            return this.PropertiesHash();
        }

        /// <summary>
        /// Implementation of == operator for (DestinyDefinitionsDestinyDestinationBubbleSettingDefinition.
        /// </summary>
        /// <param name="left">Compared (DestinyDefinitionsDestinyDestinationBubbleSettingDefinition</param>
        /// <param name="right">Compared (DestinyDefinitionsDestinyDestinationBubbleSettingDefinition</param>
        /// <returns>true if compared items are equals, false otherwise</returns>
        public static bool operator == (DestinyDefinitionsDestinyDestinationBubbleSettingDefinition left, DestinyDefinitionsDestinyDestinationBubbleSettingDefinition right)
        {
            return Equals(left, right);
        }

        /// <summary>
        /// Implementation of != operator for (DestinyDefinitionsDestinyDestinationBubbleSettingDefinition.
        /// </summary>
        /// <param name="left">Compared (DestinyDefinitionsDestinyDestinationBubbleSettingDefinition</param>
        /// <param name="right">Compared (DestinyDefinitionsDestinyDestinationBubbleSettingDefinition</param>
        /// <returns>true if compared items are not equals, false otherwise</returns>
        public static bool operator != (DestinyDefinitionsDestinyDestinationBubbleSettingDefinition left, DestinyDefinitionsDestinyDestinationBubbleSettingDefinition right)
        {
            return !Equals(left, right);
        }

        /// <summary>
        /// Builder of DestinyDefinitionsDestinyDestinationBubbleSettingDefinition.
        /// </summary>
        public sealed class DestinyDefinitionsDestinyDestinationBubbleSettingDefinitionBuilder
        {
            private DestinyDefinitionsCommonDestinyDisplayPropertiesDefinition _DisplayProperties;

            internal DestinyDefinitionsDestinyDestinationBubbleSettingDefinitionBuilder()
            {
                SetupDefaults();
            }

            private void SetupDefaults()
            {
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsDestinyDestinationBubbleSettingDefinition.DisplayProperties property.
            /// </summary>
            /// <param name="value">DisplayProperties</param>
            public DestinyDefinitionsDestinyDestinationBubbleSettingDefinitionBuilder DisplayProperties(DestinyDefinitionsCommonDestinyDisplayPropertiesDefinition value)
            {
                _DisplayProperties = value;
                return this;
            }


            /// <summary>
            /// Builds instance of DestinyDefinitionsDestinyDestinationBubbleSettingDefinition.
            /// </summary>
            /// <returns>DestinyDefinitionsDestinyDestinationBubbleSettingDefinition</returns>
            public DestinyDefinitionsDestinyDestinationBubbleSettingDefinition Build()
            {
                Validate();
                return new DestinyDefinitionsDestinyDestinationBubbleSettingDefinition(
                    DisplayProperties: _DisplayProperties
                );
            }

            private void Validate()
            { 
            }
        }

        
    }
}