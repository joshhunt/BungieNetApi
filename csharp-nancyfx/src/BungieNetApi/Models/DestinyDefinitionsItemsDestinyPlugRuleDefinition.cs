using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Sharpility.Extensions;
using NodaTime;

namespace BungieNetApi._Platform.Models
{
    /// <summary>
    /// Dictates a rule around whether the plug is enabled or insertable.  In practice, the live Destiny data will refer to these entries by index. You can then look up that index in the appropriate property (enabledRules or insertionRules) to get the localized string for the failure message if it failed.
    /// </summary>
    public sealed class DestinyDefinitionsItemsDestinyPlugRuleDefinition:  IEquatable<DestinyDefinitionsItemsDestinyPlugRuleDefinition>
    { 
        /// <summary>
        /// The localized string to show if this rule fails.
        /// </summary>
        public string FailureMessage { get; private set; }


        /// <summary>
        /// Empty constructor required by some serializers.
        /// Use DestinyDefinitionsItemsDestinyPlugRuleDefinition.Builder() for instance creation instead.
        /// </summary>
        [Obsolete]
        public DestinyDefinitionsItemsDestinyPlugRuleDefinition()
        {
        }

        private DestinyDefinitionsItemsDestinyPlugRuleDefinition(string FailureMessage)
        {
            
            this.FailureMessage = FailureMessage;
            
        }

        /// <summary>
        /// Returns builder of DestinyDefinitionsItemsDestinyPlugRuleDefinition.
        /// </summary>
        /// <returns>DestinyDefinitionsItemsDestinyPlugRuleDefinitionBuilder</returns>
        public static DestinyDefinitionsItemsDestinyPlugRuleDefinitionBuilder Builder()
        {
            return new DestinyDefinitionsItemsDestinyPlugRuleDefinitionBuilder();
        }

        /// <summary>
        /// Returns DestinyDefinitionsItemsDestinyPlugRuleDefinitionBuilder with properties set.
        /// Use it to change properties.
        /// </summary>
        /// <returns>DestinyDefinitionsItemsDestinyPlugRuleDefinitionBuilder</returns>
        public DestinyDefinitionsItemsDestinyPlugRuleDefinitionBuilder With()
        {
            return Builder()
                .FailureMessage(FailureMessage);
        }

        public override string ToString()
        {
            return this.PropertiesToString();
        }

        public override bool Equals(object obj)
        {
            return this.EqualsByProperties(obj);
        }

        public bool Equals(DestinyDefinitionsItemsDestinyPlugRuleDefinition other)
        {
            return Equals((object) other);
        }

        public override int GetHashCode()
        {
            return this.PropertiesHash();
        }

        /// <summary>
        /// Implementation of == operator for (DestinyDefinitionsItemsDestinyPlugRuleDefinition.
        /// </summary>
        /// <param name="left">Compared (DestinyDefinitionsItemsDestinyPlugRuleDefinition</param>
        /// <param name="right">Compared (DestinyDefinitionsItemsDestinyPlugRuleDefinition</param>
        /// <returns>true if compared items are equals, false otherwise</returns>
        public static bool operator == (DestinyDefinitionsItemsDestinyPlugRuleDefinition left, DestinyDefinitionsItemsDestinyPlugRuleDefinition right)
        {
            return Equals(left, right);
        }

        /// <summary>
        /// Implementation of != operator for (DestinyDefinitionsItemsDestinyPlugRuleDefinition.
        /// </summary>
        /// <param name="left">Compared (DestinyDefinitionsItemsDestinyPlugRuleDefinition</param>
        /// <param name="right">Compared (DestinyDefinitionsItemsDestinyPlugRuleDefinition</param>
        /// <returns>true if compared items are not equals, false otherwise</returns>
        public static bool operator != (DestinyDefinitionsItemsDestinyPlugRuleDefinition left, DestinyDefinitionsItemsDestinyPlugRuleDefinition right)
        {
            return !Equals(left, right);
        }

        /// <summary>
        /// Builder of DestinyDefinitionsItemsDestinyPlugRuleDefinition.
        /// </summary>
        public sealed class DestinyDefinitionsItemsDestinyPlugRuleDefinitionBuilder
        {
            private string _FailureMessage;

            internal DestinyDefinitionsItemsDestinyPlugRuleDefinitionBuilder()
            {
                SetupDefaults();
            }

            private void SetupDefaults()
            {
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsItemsDestinyPlugRuleDefinition.FailureMessage property.
            /// </summary>
            /// <param name="value">The localized string to show if this rule fails.</param>
            public DestinyDefinitionsItemsDestinyPlugRuleDefinitionBuilder FailureMessage(string value)
            {
                _FailureMessage = value;
                return this;
            }


            /// <summary>
            /// Builds instance of DestinyDefinitionsItemsDestinyPlugRuleDefinition.
            /// </summary>
            /// <returns>DestinyDefinitionsItemsDestinyPlugRuleDefinition</returns>
            public DestinyDefinitionsItemsDestinyPlugRuleDefinition Build()
            {
                Validate();
                return new DestinyDefinitionsItemsDestinyPlugRuleDefinition(
                    FailureMessage: _FailureMessage
                );
            }

            private void Validate()
            { 
            }
        }

        
    }
}