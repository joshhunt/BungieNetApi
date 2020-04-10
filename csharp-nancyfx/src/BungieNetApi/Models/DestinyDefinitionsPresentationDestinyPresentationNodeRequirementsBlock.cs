using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Sharpility.Extensions;
using NodaTime;

namespace BungieNetApi._Platform.Models
{
    /// <summary>
    /// Presentation nodes can be restricted by various requirements. This defines the rules of those requirements, and the message(s) to be shown if these requirements aren&#39;t met.
    /// </summary>
    public sealed class DestinyDefinitionsPresentationDestinyPresentationNodeRequirementsBlock:  IEquatable<DestinyDefinitionsPresentationDestinyPresentationNodeRequirementsBlock>
    { 
        /// <summary>
        /// If this node is not accessible due to Entitlements (for instance, you don&#39;t own the required game expansion), this is the message to show.
        /// </summary>
        public string EntitlementUnavailableMessage { get; private set; }


        /// <summary>
        /// Empty constructor required by some serializers.
        /// Use DestinyDefinitionsPresentationDestinyPresentationNodeRequirementsBlock.Builder() for instance creation instead.
        /// </summary>
        [Obsolete]
        public DestinyDefinitionsPresentationDestinyPresentationNodeRequirementsBlock()
        {
        }

        private DestinyDefinitionsPresentationDestinyPresentationNodeRequirementsBlock(string EntitlementUnavailableMessage)
        {
            
            this.EntitlementUnavailableMessage = EntitlementUnavailableMessage;
            
        }

        /// <summary>
        /// Returns builder of DestinyDefinitionsPresentationDestinyPresentationNodeRequirementsBlock.
        /// </summary>
        /// <returns>DestinyDefinitionsPresentationDestinyPresentationNodeRequirementsBlockBuilder</returns>
        public static DestinyDefinitionsPresentationDestinyPresentationNodeRequirementsBlockBuilder Builder()
        {
            return new DestinyDefinitionsPresentationDestinyPresentationNodeRequirementsBlockBuilder();
        }

        /// <summary>
        /// Returns DestinyDefinitionsPresentationDestinyPresentationNodeRequirementsBlockBuilder with properties set.
        /// Use it to change properties.
        /// </summary>
        /// <returns>DestinyDefinitionsPresentationDestinyPresentationNodeRequirementsBlockBuilder</returns>
        public DestinyDefinitionsPresentationDestinyPresentationNodeRequirementsBlockBuilder With()
        {
            return Builder()
                .EntitlementUnavailableMessage(EntitlementUnavailableMessage);
        }

        public override string ToString()
        {
            return this.PropertiesToString();
        }

        public override bool Equals(object obj)
        {
            return this.EqualsByProperties(obj);
        }

        public bool Equals(DestinyDefinitionsPresentationDestinyPresentationNodeRequirementsBlock other)
        {
            return Equals((object) other);
        }

        public override int GetHashCode()
        {
            return this.PropertiesHash();
        }

        /// <summary>
        /// Implementation of == operator for (DestinyDefinitionsPresentationDestinyPresentationNodeRequirementsBlock.
        /// </summary>
        /// <param name="left">Compared (DestinyDefinitionsPresentationDestinyPresentationNodeRequirementsBlock</param>
        /// <param name="right">Compared (DestinyDefinitionsPresentationDestinyPresentationNodeRequirementsBlock</param>
        /// <returns>true if compared items are equals, false otherwise</returns>
        public static bool operator == (DestinyDefinitionsPresentationDestinyPresentationNodeRequirementsBlock left, DestinyDefinitionsPresentationDestinyPresentationNodeRequirementsBlock right)
        {
            return Equals(left, right);
        }

        /// <summary>
        /// Implementation of != operator for (DestinyDefinitionsPresentationDestinyPresentationNodeRequirementsBlock.
        /// </summary>
        /// <param name="left">Compared (DestinyDefinitionsPresentationDestinyPresentationNodeRequirementsBlock</param>
        /// <param name="right">Compared (DestinyDefinitionsPresentationDestinyPresentationNodeRequirementsBlock</param>
        /// <returns>true if compared items are not equals, false otherwise</returns>
        public static bool operator != (DestinyDefinitionsPresentationDestinyPresentationNodeRequirementsBlock left, DestinyDefinitionsPresentationDestinyPresentationNodeRequirementsBlock right)
        {
            return !Equals(left, right);
        }

        /// <summary>
        /// Builder of DestinyDefinitionsPresentationDestinyPresentationNodeRequirementsBlock.
        /// </summary>
        public sealed class DestinyDefinitionsPresentationDestinyPresentationNodeRequirementsBlockBuilder
        {
            private string _EntitlementUnavailableMessage;

            internal DestinyDefinitionsPresentationDestinyPresentationNodeRequirementsBlockBuilder()
            {
                SetupDefaults();
            }

            private void SetupDefaults()
            {
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsPresentationDestinyPresentationNodeRequirementsBlock.EntitlementUnavailableMessage property.
            /// </summary>
            /// <param name="value">If this node is not accessible due to Entitlements (for instance, you don&#39;t own the required game expansion), this is the message to show.</param>
            public DestinyDefinitionsPresentationDestinyPresentationNodeRequirementsBlockBuilder EntitlementUnavailableMessage(string value)
            {
                _EntitlementUnavailableMessage = value;
                return this;
            }


            /// <summary>
            /// Builds instance of DestinyDefinitionsPresentationDestinyPresentationNodeRequirementsBlock.
            /// </summary>
            /// <returns>DestinyDefinitionsPresentationDestinyPresentationNodeRequirementsBlock</returns>
            public DestinyDefinitionsPresentationDestinyPresentationNodeRequirementsBlock Build()
            {
                Validate();
                return new DestinyDefinitionsPresentationDestinyPresentationNodeRequirementsBlock(
                    EntitlementUnavailableMessage: _EntitlementUnavailableMessage
                );
            }

            private void Validate()
            { 
            }
        }

        
    }
}