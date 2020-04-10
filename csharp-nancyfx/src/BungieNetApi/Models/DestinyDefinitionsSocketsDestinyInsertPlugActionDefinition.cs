using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Sharpility.Extensions;
using NodaTime;

namespace BungieNetApi._Platform.Models
{
    /// <summary>
    /// Data related to what happens while a plug is being inserted, mostly for UI purposes.
    /// </summary>
    public sealed class DestinyDefinitionsSocketsDestinyInsertPlugActionDefinition:  IEquatable<DestinyDefinitionsSocketsDestinyInsertPlugActionDefinition>
    { 
        /// <summary>
        /// How long it takes for the Plugging of the item to be completed once it is initiated, if you care.
        /// </summary>
        public int? ActionExecuteSeconds { get; private set; }

        /// <summary>
        /// The type of action being performed when you act on this Socket Type. The most common value is \&quot;insert plug\&quot;, but there are others as well (for instance, a \&quot;Masterwork\&quot; socket may allow for Re-initialization, and an Infusion socket allows for items to be consumed to upgrade the item)
        /// </summary>
        public int? ActionType { get; private set; }


        /// <summary>
        /// Empty constructor required by some serializers.
        /// Use DestinyDefinitionsSocketsDestinyInsertPlugActionDefinition.Builder() for instance creation instead.
        /// </summary>
        [Obsolete]
        public DestinyDefinitionsSocketsDestinyInsertPlugActionDefinition()
        {
        }

        private DestinyDefinitionsSocketsDestinyInsertPlugActionDefinition(int? ActionExecuteSeconds, int? ActionType)
        {
            
            this.ActionExecuteSeconds = ActionExecuteSeconds;
            
            this.ActionType = ActionType;
            
        }

        /// <summary>
        /// Returns builder of DestinyDefinitionsSocketsDestinyInsertPlugActionDefinition.
        /// </summary>
        /// <returns>DestinyDefinitionsSocketsDestinyInsertPlugActionDefinitionBuilder</returns>
        public static DestinyDefinitionsSocketsDestinyInsertPlugActionDefinitionBuilder Builder()
        {
            return new DestinyDefinitionsSocketsDestinyInsertPlugActionDefinitionBuilder();
        }

        /// <summary>
        /// Returns DestinyDefinitionsSocketsDestinyInsertPlugActionDefinitionBuilder with properties set.
        /// Use it to change properties.
        /// </summary>
        /// <returns>DestinyDefinitionsSocketsDestinyInsertPlugActionDefinitionBuilder</returns>
        public DestinyDefinitionsSocketsDestinyInsertPlugActionDefinitionBuilder With()
        {
            return Builder()
                .ActionExecuteSeconds(ActionExecuteSeconds)
                .ActionType(ActionType);
        }

        public override string ToString()
        {
            return this.PropertiesToString();
        }

        public override bool Equals(object obj)
        {
            return this.EqualsByProperties(obj);
        }

        public bool Equals(DestinyDefinitionsSocketsDestinyInsertPlugActionDefinition other)
        {
            return Equals((object) other);
        }

        public override int GetHashCode()
        {
            return this.PropertiesHash();
        }

        /// <summary>
        /// Implementation of == operator for (DestinyDefinitionsSocketsDestinyInsertPlugActionDefinition.
        /// </summary>
        /// <param name="left">Compared (DestinyDefinitionsSocketsDestinyInsertPlugActionDefinition</param>
        /// <param name="right">Compared (DestinyDefinitionsSocketsDestinyInsertPlugActionDefinition</param>
        /// <returns>true if compared items are equals, false otherwise</returns>
        public static bool operator == (DestinyDefinitionsSocketsDestinyInsertPlugActionDefinition left, DestinyDefinitionsSocketsDestinyInsertPlugActionDefinition right)
        {
            return Equals(left, right);
        }

        /// <summary>
        /// Implementation of != operator for (DestinyDefinitionsSocketsDestinyInsertPlugActionDefinition.
        /// </summary>
        /// <param name="left">Compared (DestinyDefinitionsSocketsDestinyInsertPlugActionDefinition</param>
        /// <param name="right">Compared (DestinyDefinitionsSocketsDestinyInsertPlugActionDefinition</param>
        /// <returns>true if compared items are not equals, false otherwise</returns>
        public static bool operator != (DestinyDefinitionsSocketsDestinyInsertPlugActionDefinition left, DestinyDefinitionsSocketsDestinyInsertPlugActionDefinition right)
        {
            return !Equals(left, right);
        }

        /// <summary>
        /// Builder of DestinyDefinitionsSocketsDestinyInsertPlugActionDefinition.
        /// </summary>
        public sealed class DestinyDefinitionsSocketsDestinyInsertPlugActionDefinitionBuilder
        {
            private int? _ActionExecuteSeconds;
            private int? _ActionType;

            internal DestinyDefinitionsSocketsDestinyInsertPlugActionDefinitionBuilder()
            {
                SetupDefaults();
            }

            private void SetupDefaults()
            {
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsSocketsDestinyInsertPlugActionDefinition.ActionExecuteSeconds property.
            /// </summary>
            /// <param name="value">How long it takes for the Plugging of the item to be completed once it is initiated, if you care.</param>
            public DestinyDefinitionsSocketsDestinyInsertPlugActionDefinitionBuilder ActionExecuteSeconds(int? value)
            {
                _ActionExecuteSeconds = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsSocketsDestinyInsertPlugActionDefinition.ActionType property.
            /// </summary>
            /// <param name="value">The type of action being performed when you act on this Socket Type. The most common value is \&quot;insert plug\&quot;, but there are others as well (for instance, a \&quot;Masterwork\&quot; socket may allow for Re-initialization, and an Infusion socket allows for items to be consumed to upgrade the item)</param>
            public DestinyDefinitionsSocketsDestinyInsertPlugActionDefinitionBuilder ActionType(int? value)
            {
                _ActionType = value;
                return this;
            }


            /// <summary>
            /// Builds instance of DestinyDefinitionsSocketsDestinyInsertPlugActionDefinition.
            /// </summary>
            /// <returns>DestinyDefinitionsSocketsDestinyInsertPlugActionDefinition</returns>
            public DestinyDefinitionsSocketsDestinyInsertPlugActionDefinition Build()
            {
                Validate();
                return new DestinyDefinitionsSocketsDestinyInsertPlugActionDefinition(
                    ActionExecuteSeconds: _ActionExecuteSeconds,
                    ActionType: _ActionType
                );
            }

            private void Validate()
            { 
            }
        }

        
    }
}