using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Sharpility.Extensions;
using NodaTime;

namespace BungieNetApi._Platform.Models
{
    /// <summary>
    /// Basic identifying data about the bubble. Combine with DestinyDestinationBubbleSettingDefinition - see DestinyDestinationDefinition.bubbleSettings for more information.
    /// </summary>
    public sealed class DestinyDefinitionsDestinyBubbleDefinition:  IEquatable<DestinyDefinitionsDestinyBubbleDefinition>
    { 
        /// <summary>
        /// The identifier for the bubble: only guaranteed to be unique within the Destination.
        /// </summary>
        public int? Hash { get; private set; }

        /// <summary>
        /// The display properties of this bubble, so you don&#39;t have to look them up in a separate list anymore.
        /// </summary>
        public DestinyDefinitionsCommonDestinyDisplayPropertiesDefinition DisplayProperties { get; private set; }


        /// <summary>
        /// Empty constructor required by some serializers.
        /// Use DestinyDefinitionsDestinyBubbleDefinition.Builder() for instance creation instead.
        /// </summary>
        [Obsolete]
        public DestinyDefinitionsDestinyBubbleDefinition()
        {
        }

        private DestinyDefinitionsDestinyBubbleDefinition(int? Hash, DestinyDefinitionsCommonDestinyDisplayPropertiesDefinition DisplayProperties)
        {
            
            this.Hash = Hash;
            
            this.DisplayProperties = DisplayProperties;
            
        }

        /// <summary>
        /// Returns builder of DestinyDefinitionsDestinyBubbleDefinition.
        /// </summary>
        /// <returns>DestinyDefinitionsDestinyBubbleDefinitionBuilder</returns>
        public static DestinyDefinitionsDestinyBubbleDefinitionBuilder Builder()
        {
            return new DestinyDefinitionsDestinyBubbleDefinitionBuilder();
        }

        /// <summary>
        /// Returns DestinyDefinitionsDestinyBubbleDefinitionBuilder with properties set.
        /// Use it to change properties.
        /// </summary>
        /// <returns>DestinyDefinitionsDestinyBubbleDefinitionBuilder</returns>
        public DestinyDefinitionsDestinyBubbleDefinitionBuilder With()
        {
            return Builder()
                .Hash(Hash)
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

        public bool Equals(DestinyDefinitionsDestinyBubbleDefinition other)
        {
            return Equals((object) other);
        }

        public override int GetHashCode()
        {
            return this.PropertiesHash();
        }

        /// <summary>
        /// Implementation of == operator for (DestinyDefinitionsDestinyBubbleDefinition.
        /// </summary>
        /// <param name="left">Compared (DestinyDefinitionsDestinyBubbleDefinition</param>
        /// <param name="right">Compared (DestinyDefinitionsDestinyBubbleDefinition</param>
        /// <returns>true if compared items are equals, false otherwise</returns>
        public static bool operator == (DestinyDefinitionsDestinyBubbleDefinition left, DestinyDefinitionsDestinyBubbleDefinition right)
        {
            return Equals(left, right);
        }

        /// <summary>
        /// Implementation of != operator for (DestinyDefinitionsDestinyBubbleDefinition.
        /// </summary>
        /// <param name="left">Compared (DestinyDefinitionsDestinyBubbleDefinition</param>
        /// <param name="right">Compared (DestinyDefinitionsDestinyBubbleDefinition</param>
        /// <returns>true if compared items are not equals, false otherwise</returns>
        public static bool operator != (DestinyDefinitionsDestinyBubbleDefinition left, DestinyDefinitionsDestinyBubbleDefinition right)
        {
            return !Equals(left, right);
        }

        /// <summary>
        /// Builder of DestinyDefinitionsDestinyBubbleDefinition.
        /// </summary>
        public sealed class DestinyDefinitionsDestinyBubbleDefinitionBuilder
        {
            private int? _Hash;
            private DestinyDefinitionsCommonDestinyDisplayPropertiesDefinition _DisplayProperties;

            internal DestinyDefinitionsDestinyBubbleDefinitionBuilder()
            {
                SetupDefaults();
            }

            private void SetupDefaults()
            {
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsDestinyBubbleDefinition.Hash property.
            /// </summary>
            /// <param name="value">The identifier for the bubble: only guaranteed to be unique within the Destination.</param>
            public DestinyDefinitionsDestinyBubbleDefinitionBuilder Hash(int? value)
            {
                _Hash = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsDestinyBubbleDefinition.DisplayProperties property.
            /// </summary>
            /// <param name="value">The display properties of this bubble, so you don&#39;t have to look them up in a separate list anymore.</param>
            public DestinyDefinitionsDestinyBubbleDefinitionBuilder DisplayProperties(DestinyDefinitionsCommonDestinyDisplayPropertiesDefinition value)
            {
                _DisplayProperties = value;
                return this;
            }


            /// <summary>
            /// Builds instance of DestinyDefinitionsDestinyBubbleDefinition.
            /// </summary>
            /// <returns>DestinyDefinitionsDestinyBubbleDefinition</returns>
            public DestinyDefinitionsDestinyBubbleDefinition Build()
            {
                Validate();
                return new DestinyDefinitionsDestinyBubbleDefinition(
                    Hash: _Hash,
                    DisplayProperties: _DisplayProperties
                );
            }

            private void Validate()
            { 
            }
        }

        
    }
}