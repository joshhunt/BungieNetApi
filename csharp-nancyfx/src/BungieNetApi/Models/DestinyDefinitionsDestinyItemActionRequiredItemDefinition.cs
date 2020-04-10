using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Sharpility.Extensions;
using NodaTime;

namespace BungieNetApi._Platform.Models
{
    /// <summary>
    /// The definition of an item and quantity required in a character&#39;s inventory in order to perform an action.
    /// </summary>
    public sealed class DestinyDefinitionsDestinyItemActionRequiredItemDefinition:  IEquatable<DestinyDefinitionsDestinyItemActionRequiredItemDefinition>
    { 
        /// <summary>
        /// The minimum quantity of the item you have to have.
        /// </summary>
        public int? Count { get; private set; }

        /// <summary>
        /// The hash identifier of the item you need to have. Use it to look up the DestinyInventoryItemDefinition for more info.
        /// </summary>
        public int? ItemHash { get; private set; }

        /// <summary>
        /// If true, the item/quantity will be deleted from your inventory when the action is performed. Otherwise, you&#39;ll retain these required items after the action is complete.
        /// </summary>
        public bool? DeleteOnAction { get; private set; }


        /// <summary>
        /// Empty constructor required by some serializers.
        /// Use DestinyDefinitionsDestinyItemActionRequiredItemDefinition.Builder() for instance creation instead.
        /// </summary>
        [Obsolete]
        public DestinyDefinitionsDestinyItemActionRequiredItemDefinition()
        {
        }

        private DestinyDefinitionsDestinyItemActionRequiredItemDefinition(int? Count, int? ItemHash, bool? DeleteOnAction)
        {
            
            this.Count = Count;
            
            this.ItemHash = ItemHash;
            
            this.DeleteOnAction = DeleteOnAction;
            
        }

        /// <summary>
        /// Returns builder of DestinyDefinitionsDestinyItemActionRequiredItemDefinition.
        /// </summary>
        /// <returns>DestinyDefinitionsDestinyItemActionRequiredItemDefinitionBuilder</returns>
        public static DestinyDefinitionsDestinyItemActionRequiredItemDefinitionBuilder Builder()
        {
            return new DestinyDefinitionsDestinyItemActionRequiredItemDefinitionBuilder();
        }

        /// <summary>
        /// Returns DestinyDefinitionsDestinyItemActionRequiredItemDefinitionBuilder with properties set.
        /// Use it to change properties.
        /// </summary>
        /// <returns>DestinyDefinitionsDestinyItemActionRequiredItemDefinitionBuilder</returns>
        public DestinyDefinitionsDestinyItemActionRequiredItemDefinitionBuilder With()
        {
            return Builder()
                .Count(Count)
                .ItemHash(ItemHash)
                .DeleteOnAction(DeleteOnAction);
        }

        public override string ToString()
        {
            return this.PropertiesToString();
        }

        public override bool Equals(object obj)
        {
            return this.EqualsByProperties(obj);
        }

        public bool Equals(DestinyDefinitionsDestinyItemActionRequiredItemDefinition other)
        {
            return Equals((object) other);
        }

        public override int GetHashCode()
        {
            return this.PropertiesHash();
        }

        /// <summary>
        /// Implementation of == operator for (DestinyDefinitionsDestinyItemActionRequiredItemDefinition.
        /// </summary>
        /// <param name="left">Compared (DestinyDefinitionsDestinyItemActionRequiredItemDefinition</param>
        /// <param name="right">Compared (DestinyDefinitionsDestinyItemActionRequiredItemDefinition</param>
        /// <returns>true if compared items are equals, false otherwise</returns>
        public static bool operator == (DestinyDefinitionsDestinyItemActionRequiredItemDefinition left, DestinyDefinitionsDestinyItemActionRequiredItemDefinition right)
        {
            return Equals(left, right);
        }

        /// <summary>
        /// Implementation of != operator for (DestinyDefinitionsDestinyItemActionRequiredItemDefinition.
        /// </summary>
        /// <param name="left">Compared (DestinyDefinitionsDestinyItemActionRequiredItemDefinition</param>
        /// <param name="right">Compared (DestinyDefinitionsDestinyItemActionRequiredItemDefinition</param>
        /// <returns>true if compared items are not equals, false otherwise</returns>
        public static bool operator != (DestinyDefinitionsDestinyItemActionRequiredItemDefinition left, DestinyDefinitionsDestinyItemActionRequiredItemDefinition right)
        {
            return !Equals(left, right);
        }

        /// <summary>
        /// Builder of DestinyDefinitionsDestinyItemActionRequiredItemDefinition.
        /// </summary>
        public sealed class DestinyDefinitionsDestinyItemActionRequiredItemDefinitionBuilder
        {
            private int? _Count;
            private int? _ItemHash;
            private bool? _DeleteOnAction;

            internal DestinyDefinitionsDestinyItemActionRequiredItemDefinitionBuilder()
            {
                SetupDefaults();
            }

            private void SetupDefaults()
            {
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsDestinyItemActionRequiredItemDefinition.Count property.
            /// </summary>
            /// <param name="value">The minimum quantity of the item you have to have.</param>
            public DestinyDefinitionsDestinyItemActionRequiredItemDefinitionBuilder Count(int? value)
            {
                _Count = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsDestinyItemActionRequiredItemDefinition.ItemHash property.
            /// </summary>
            /// <param name="value">The hash identifier of the item you need to have. Use it to look up the DestinyInventoryItemDefinition for more info.</param>
            public DestinyDefinitionsDestinyItemActionRequiredItemDefinitionBuilder ItemHash(int? value)
            {
                _ItemHash = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsDestinyItemActionRequiredItemDefinition.DeleteOnAction property.
            /// </summary>
            /// <param name="value">If true, the item/quantity will be deleted from your inventory when the action is performed. Otherwise, you&#39;ll retain these required items after the action is complete.</param>
            public DestinyDefinitionsDestinyItemActionRequiredItemDefinitionBuilder DeleteOnAction(bool? value)
            {
                _DeleteOnAction = value;
                return this;
            }


            /// <summary>
            /// Builds instance of DestinyDefinitionsDestinyItemActionRequiredItemDefinition.
            /// </summary>
            /// <returns>DestinyDefinitionsDestinyItemActionRequiredItemDefinition</returns>
            public DestinyDefinitionsDestinyItemActionRequiredItemDefinition Build()
            {
                Validate();
                return new DestinyDefinitionsDestinyItemActionRequiredItemDefinition(
                    Count: _Count,
                    ItemHash: _ItemHash,
                    DeleteOnAction: _DeleteOnAction
                );
            }

            private void Validate()
            { 
            }
        }

        
    }
}