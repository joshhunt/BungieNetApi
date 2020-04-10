using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Sharpility.Extensions;
using NodaTime;

namespace BungieNetApi._Platform.Models
{
    /// <summary>
    /// When the interaction is replied to, Reward sites will fire and items potentially selected based on whether the given unlock expression is TRUE.  You can potentially choose one from multiple replies when replying to an interaction: this is how you get either/or rewards from vendors.
    /// </summary>
    public sealed class DestinyDefinitionsDestinyVendorInteractionReplyDefinition:  IEquatable<DestinyDefinitionsDestinyVendorInteractionReplyDefinition>
    { 
        /// <summary>
        /// The rewards granted upon responding to the vendor.
        /// </summary>
        public int? ItemRewardsSelection { get; private set; }

        /// <summary>
        /// The localized text for the reply.
        /// </summary>
        public string Reply { get; private set; }

        /// <summary>
        /// An enum indicating the type of reply being made.
        /// </summary>
        public int? ReplyType { get; private set; }


        /// <summary>
        /// Empty constructor required by some serializers.
        /// Use DestinyDefinitionsDestinyVendorInteractionReplyDefinition.Builder() for instance creation instead.
        /// </summary>
        [Obsolete]
        public DestinyDefinitionsDestinyVendorInteractionReplyDefinition()
        {
        }

        private DestinyDefinitionsDestinyVendorInteractionReplyDefinition(int? ItemRewardsSelection, string Reply, int? ReplyType)
        {
            
            this.ItemRewardsSelection = ItemRewardsSelection;
            
            this.Reply = Reply;
            
            this.ReplyType = ReplyType;
            
        }

        /// <summary>
        /// Returns builder of DestinyDefinitionsDestinyVendorInteractionReplyDefinition.
        /// </summary>
        /// <returns>DestinyDefinitionsDestinyVendorInteractionReplyDefinitionBuilder</returns>
        public static DestinyDefinitionsDestinyVendorInteractionReplyDefinitionBuilder Builder()
        {
            return new DestinyDefinitionsDestinyVendorInteractionReplyDefinitionBuilder();
        }

        /// <summary>
        /// Returns DestinyDefinitionsDestinyVendorInteractionReplyDefinitionBuilder with properties set.
        /// Use it to change properties.
        /// </summary>
        /// <returns>DestinyDefinitionsDestinyVendorInteractionReplyDefinitionBuilder</returns>
        public DestinyDefinitionsDestinyVendorInteractionReplyDefinitionBuilder With()
        {
            return Builder()
                .ItemRewardsSelection(ItemRewardsSelection)
                .Reply(Reply)
                .ReplyType(ReplyType);
        }

        public override string ToString()
        {
            return this.PropertiesToString();
        }

        public override bool Equals(object obj)
        {
            return this.EqualsByProperties(obj);
        }

        public bool Equals(DestinyDefinitionsDestinyVendorInteractionReplyDefinition other)
        {
            return Equals((object) other);
        }

        public override int GetHashCode()
        {
            return this.PropertiesHash();
        }

        /// <summary>
        /// Implementation of == operator for (DestinyDefinitionsDestinyVendorInteractionReplyDefinition.
        /// </summary>
        /// <param name="left">Compared (DestinyDefinitionsDestinyVendorInteractionReplyDefinition</param>
        /// <param name="right">Compared (DestinyDefinitionsDestinyVendorInteractionReplyDefinition</param>
        /// <returns>true if compared items are equals, false otherwise</returns>
        public static bool operator == (DestinyDefinitionsDestinyVendorInteractionReplyDefinition left, DestinyDefinitionsDestinyVendorInteractionReplyDefinition right)
        {
            return Equals(left, right);
        }

        /// <summary>
        /// Implementation of != operator for (DestinyDefinitionsDestinyVendorInteractionReplyDefinition.
        /// </summary>
        /// <param name="left">Compared (DestinyDefinitionsDestinyVendorInteractionReplyDefinition</param>
        /// <param name="right">Compared (DestinyDefinitionsDestinyVendorInteractionReplyDefinition</param>
        /// <returns>true if compared items are not equals, false otherwise</returns>
        public static bool operator != (DestinyDefinitionsDestinyVendorInteractionReplyDefinition left, DestinyDefinitionsDestinyVendorInteractionReplyDefinition right)
        {
            return !Equals(left, right);
        }

        /// <summary>
        /// Builder of DestinyDefinitionsDestinyVendorInteractionReplyDefinition.
        /// </summary>
        public sealed class DestinyDefinitionsDestinyVendorInteractionReplyDefinitionBuilder
        {
            private int? _ItemRewardsSelection;
            private string _Reply;
            private int? _ReplyType;

            internal DestinyDefinitionsDestinyVendorInteractionReplyDefinitionBuilder()
            {
                SetupDefaults();
            }

            private void SetupDefaults()
            {
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsDestinyVendorInteractionReplyDefinition.ItemRewardsSelection property.
            /// </summary>
            /// <param name="value">The rewards granted upon responding to the vendor.</param>
            public DestinyDefinitionsDestinyVendorInteractionReplyDefinitionBuilder ItemRewardsSelection(int? value)
            {
                _ItemRewardsSelection = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsDestinyVendorInteractionReplyDefinition.Reply property.
            /// </summary>
            /// <param name="value">The localized text for the reply.</param>
            public DestinyDefinitionsDestinyVendorInteractionReplyDefinitionBuilder Reply(string value)
            {
                _Reply = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsDestinyVendorInteractionReplyDefinition.ReplyType property.
            /// </summary>
            /// <param name="value">An enum indicating the type of reply being made.</param>
            public DestinyDefinitionsDestinyVendorInteractionReplyDefinitionBuilder ReplyType(int? value)
            {
                _ReplyType = value;
                return this;
            }


            /// <summary>
            /// Builds instance of DestinyDefinitionsDestinyVendorInteractionReplyDefinition.
            /// </summary>
            /// <returns>DestinyDefinitionsDestinyVendorInteractionReplyDefinition</returns>
            public DestinyDefinitionsDestinyVendorInteractionReplyDefinition Build()
            {
                Validate();
                return new DestinyDefinitionsDestinyVendorInteractionReplyDefinition(
                    ItemRewardsSelection: _ItemRewardsSelection,
                    Reply: _Reply,
                    ReplyType: _ReplyType
                );
            }

            private void Validate()
            { 
            }
        }

        
    }
}