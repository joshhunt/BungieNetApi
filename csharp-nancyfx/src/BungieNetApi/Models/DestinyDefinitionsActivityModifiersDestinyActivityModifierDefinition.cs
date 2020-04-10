using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Sharpility.Extensions;
using NodaTime;

namespace BungieNetApi._Platform.Models
{
    /// <summary>
    /// Modifiers - in Destiny 1, these were referred to as \&quot;Skulls\&quot; - are changes that can be applied to an Activity.
    /// </summary>
    public sealed class DestinyDefinitionsActivityModifiersDestinyActivityModifierDefinition:  IEquatable<DestinyDefinitionsActivityModifiersDestinyActivityModifierDefinition>
    { 
        /// <summary>
        /// DisplayProperties
        /// </summary>
        public DestinyDefinitionsCommonDestinyDisplayPropertiesDefinition DisplayProperties { get; private set; }

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
        /// Use DestinyDefinitionsActivityModifiersDestinyActivityModifierDefinition.Builder() for instance creation instead.
        /// </summary>
        [Obsolete]
        public DestinyDefinitionsActivityModifiersDestinyActivityModifierDefinition()
        {
        }

        private DestinyDefinitionsActivityModifiersDestinyActivityModifierDefinition(DestinyDefinitionsCommonDestinyDisplayPropertiesDefinition DisplayProperties, int? Hash, int? Index, bool? Redacted)
        {
            
            this.DisplayProperties = DisplayProperties;
            
            this.Hash = Hash;
            
            this.Index = Index;
            
            this.Redacted = Redacted;
            
        }

        /// <summary>
        /// Returns builder of DestinyDefinitionsActivityModifiersDestinyActivityModifierDefinition.
        /// </summary>
        /// <returns>DestinyDefinitionsActivityModifiersDestinyActivityModifierDefinitionBuilder</returns>
        public static DestinyDefinitionsActivityModifiersDestinyActivityModifierDefinitionBuilder Builder()
        {
            return new DestinyDefinitionsActivityModifiersDestinyActivityModifierDefinitionBuilder();
        }

        /// <summary>
        /// Returns DestinyDefinitionsActivityModifiersDestinyActivityModifierDefinitionBuilder with properties set.
        /// Use it to change properties.
        /// </summary>
        /// <returns>DestinyDefinitionsActivityModifiersDestinyActivityModifierDefinitionBuilder</returns>
        public DestinyDefinitionsActivityModifiersDestinyActivityModifierDefinitionBuilder With()
        {
            return Builder()
                .DisplayProperties(DisplayProperties)
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

        public bool Equals(DestinyDefinitionsActivityModifiersDestinyActivityModifierDefinition other)
        {
            return Equals((object) other);
        }

        public override int GetHashCode()
        {
            return this.PropertiesHash();
        }

        /// <summary>
        /// Implementation of == operator for (DestinyDefinitionsActivityModifiersDestinyActivityModifierDefinition.
        /// </summary>
        /// <param name="left">Compared (DestinyDefinitionsActivityModifiersDestinyActivityModifierDefinition</param>
        /// <param name="right">Compared (DestinyDefinitionsActivityModifiersDestinyActivityModifierDefinition</param>
        /// <returns>true if compared items are equals, false otherwise</returns>
        public static bool operator == (DestinyDefinitionsActivityModifiersDestinyActivityModifierDefinition left, DestinyDefinitionsActivityModifiersDestinyActivityModifierDefinition right)
        {
            return Equals(left, right);
        }

        /// <summary>
        /// Implementation of != operator for (DestinyDefinitionsActivityModifiersDestinyActivityModifierDefinition.
        /// </summary>
        /// <param name="left">Compared (DestinyDefinitionsActivityModifiersDestinyActivityModifierDefinition</param>
        /// <param name="right">Compared (DestinyDefinitionsActivityModifiersDestinyActivityModifierDefinition</param>
        /// <returns>true if compared items are not equals, false otherwise</returns>
        public static bool operator != (DestinyDefinitionsActivityModifiersDestinyActivityModifierDefinition left, DestinyDefinitionsActivityModifiersDestinyActivityModifierDefinition right)
        {
            return !Equals(left, right);
        }

        /// <summary>
        /// Builder of DestinyDefinitionsActivityModifiersDestinyActivityModifierDefinition.
        /// </summary>
        public sealed class DestinyDefinitionsActivityModifiersDestinyActivityModifierDefinitionBuilder
        {
            private DestinyDefinitionsCommonDestinyDisplayPropertiesDefinition _DisplayProperties;
            private int? _Hash;
            private int? _Index;
            private bool? _Redacted;

            internal DestinyDefinitionsActivityModifiersDestinyActivityModifierDefinitionBuilder()
            {
                SetupDefaults();
            }

            private void SetupDefaults()
            {
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsActivityModifiersDestinyActivityModifierDefinition.DisplayProperties property.
            /// </summary>
            /// <param name="value">DisplayProperties</param>
            public DestinyDefinitionsActivityModifiersDestinyActivityModifierDefinitionBuilder DisplayProperties(DestinyDefinitionsCommonDestinyDisplayPropertiesDefinition value)
            {
                _DisplayProperties = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsActivityModifiersDestinyActivityModifierDefinition.Hash property.
            /// </summary>
            /// <param name="value">The unique identifier for this entity. Guaranteed to be unique for the type of entity, but not globally.  When entities refer to each other in Destiny content, it is this hash that they are referring to.</param>
            public DestinyDefinitionsActivityModifiersDestinyActivityModifierDefinitionBuilder Hash(int? value)
            {
                _Hash = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsActivityModifiersDestinyActivityModifierDefinition.Index property.
            /// </summary>
            /// <param name="value">The index of the entity as it was found in the investment tables.</param>
            public DestinyDefinitionsActivityModifiersDestinyActivityModifierDefinitionBuilder Index(int? value)
            {
                _Index = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsActivityModifiersDestinyActivityModifierDefinition.Redacted property.
            /// </summary>
            /// <param name="value">If this is true, then there is an entity with this identifier/type combination, but BNet is not yet allowed to show it. Sorry!</param>
            public DestinyDefinitionsActivityModifiersDestinyActivityModifierDefinitionBuilder Redacted(bool? value)
            {
                _Redacted = value;
                return this;
            }


            /// <summary>
            /// Builds instance of DestinyDefinitionsActivityModifiersDestinyActivityModifierDefinition.
            /// </summary>
            /// <returns>DestinyDefinitionsActivityModifiersDestinyActivityModifierDefinition</returns>
            public DestinyDefinitionsActivityModifiersDestinyActivityModifierDefinition Build()
            {
                Validate();
                return new DestinyDefinitionsActivityModifiersDestinyActivityModifierDefinition(
                    DisplayProperties: _DisplayProperties,
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