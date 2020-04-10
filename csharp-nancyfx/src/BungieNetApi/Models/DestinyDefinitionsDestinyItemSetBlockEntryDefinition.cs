using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Sharpility.Extensions;
using NodaTime;

namespace BungieNetApi._Platform.Models
{
    /// <summary>
    /// Defines a particular entry in an ItemSet (AKA a particular Quest Step in a Quest)
    /// </summary>
    public sealed class DestinyDefinitionsDestinyItemSetBlockEntryDefinition:  IEquatable<DestinyDefinitionsDestinyItemSetBlockEntryDefinition>
    { 
        /// <summary>
        /// Used for tracking which step a user reached. These values will be populated in the user&#39;s internal state, which we expose externally as a more usable DestinyQuestStatus object. If this item has been obtained, this value will be set in trackingUnlockValueHash.
        /// </summary>
        public int? TrackingValue { get; private set; }

        /// <summary>
        /// This is the hash identifier for a DestinyInventoryItemDefinition representing this quest step.
        /// </summary>
        public int? ItemHash { get; private set; }


        /// <summary>
        /// Empty constructor required by some serializers.
        /// Use DestinyDefinitionsDestinyItemSetBlockEntryDefinition.Builder() for instance creation instead.
        /// </summary>
        [Obsolete]
        public DestinyDefinitionsDestinyItemSetBlockEntryDefinition()
        {
        }

        private DestinyDefinitionsDestinyItemSetBlockEntryDefinition(int? TrackingValue, int? ItemHash)
        {
            
            this.TrackingValue = TrackingValue;
            
            this.ItemHash = ItemHash;
            
        }

        /// <summary>
        /// Returns builder of DestinyDefinitionsDestinyItemSetBlockEntryDefinition.
        /// </summary>
        /// <returns>DestinyDefinitionsDestinyItemSetBlockEntryDefinitionBuilder</returns>
        public static DestinyDefinitionsDestinyItemSetBlockEntryDefinitionBuilder Builder()
        {
            return new DestinyDefinitionsDestinyItemSetBlockEntryDefinitionBuilder();
        }

        /// <summary>
        /// Returns DestinyDefinitionsDestinyItemSetBlockEntryDefinitionBuilder with properties set.
        /// Use it to change properties.
        /// </summary>
        /// <returns>DestinyDefinitionsDestinyItemSetBlockEntryDefinitionBuilder</returns>
        public DestinyDefinitionsDestinyItemSetBlockEntryDefinitionBuilder With()
        {
            return Builder()
                .TrackingValue(TrackingValue)
                .ItemHash(ItemHash);
        }

        public override string ToString()
        {
            return this.PropertiesToString();
        }

        public override bool Equals(object obj)
        {
            return this.EqualsByProperties(obj);
        }

        public bool Equals(DestinyDefinitionsDestinyItemSetBlockEntryDefinition other)
        {
            return Equals((object) other);
        }

        public override int GetHashCode()
        {
            return this.PropertiesHash();
        }

        /// <summary>
        /// Implementation of == operator for (DestinyDefinitionsDestinyItemSetBlockEntryDefinition.
        /// </summary>
        /// <param name="left">Compared (DestinyDefinitionsDestinyItemSetBlockEntryDefinition</param>
        /// <param name="right">Compared (DestinyDefinitionsDestinyItemSetBlockEntryDefinition</param>
        /// <returns>true if compared items are equals, false otherwise</returns>
        public static bool operator == (DestinyDefinitionsDestinyItemSetBlockEntryDefinition left, DestinyDefinitionsDestinyItemSetBlockEntryDefinition right)
        {
            return Equals(left, right);
        }

        /// <summary>
        /// Implementation of != operator for (DestinyDefinitionsDestinyItemSetBlockEntryDefinition.
        /// </summary>
        /// <param name="left">Compared (DestinyDefinitionsDestinyItemSetBlockEntryDefinition</param>
        /// <param name="right">Compared (DestinyDefinitionsDestinyItemSetBlockEntryDefinition</param>
        /// <returns>true if compared items are not equals, false otherwise</returns>
        public static bool operator != (DestinyDefinitionsDestinyItemSetBlockEntryDefinition left, DestinyDefinitionsDestinyItemSetBlockEntryDefinition right)
        {
            return !Equals(left, right);
        }

        /// <summary>
        /// Builder of DestinyDefinitionsDestinyItemSetBlockEntryDefinition.
        /// </summary>
        public sealed class DestinyDefinitionsDestinyItemSetBlockEntryDefinitionBuilder
        {
            private int? _TrackingValue;
            private int? _ItemHash;

            internal DestinyDefinitionsDestinyItemSetBlockEntryDefinitionBuilder()
            {
                SetupDefaults();
            }

            private void SetupDefaults()
            {
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsDestinyItemSetBlockEntryDefinition.TrackingValue property.
            /// </summary>
            /// <param name="value">Used for tracking which step a user reached. These values will be populated in the user&#39;s internal state, which we expose externally as a more usable DestinyQuestStatus object. If this item has been obtained, this value will be set in trackingUnlockValueHash.</param>
            public DestinyDefinitionsDestinyItemSetBlockEntryDefinitionBuilder TrackingValue(int? value)
            {
                _TrackingValue = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsDestinyItemSetBlockEntryDefinition.ItemHash property.
            /// </summary>
            /// <param name="value">This is the hash identifier for a DestinyInventoryItemDefinition representing this quest step.</param>
            public DestinyDefinitionsDestinyItemSetBlockEntryDefinitionBuilder ItemHash(int? value)
            {
                _ItemHash = value;
                return this;
            }


            /// <summary>
            /// Builds instance of DestinyDefinitionsDestinyItemSetBlockEntryDefinition.
            /// </summary>
            /// <returns>DestinyDefinitionsDestinyItemSetBlockEntryDefinition</returns>
            public DestinyDefinitionsDestinyItemSetBlockEntryDefinition Build()
            {
                Validate();
                return new DestinyDefinitionsDestinyItemSetBlockEntryDefinition(
                    TrackingValue: _TrackingValue,
                    ItemHash: _ItemHash
                );
            }

            private void Validate()
            { 
            }
        }

        
    }
}