using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Sharpility.Extensions;
using NodaTime;

namespace BungieNetApi._Platform.Models
{
    /// <summary>
    /// Primarily for Quests, this is the definition of properties related to the item if it is a quest and its various quest steps.
    /// </summary>
    public sealed class DestinyDefinitionsDestinyItemSetBlockDefinition:  IEquatable<DestinyDefinitionsDestinyItemSetBlockDefinition>
    { 
        /// <summary>
        /// A collection of hashes of set items, for items such as Quest Metadata items that possess this data.
        /// </summary>
        public List<DestinyDefinitionsDestinyItemSetBlockEntryDefinition> ItemList { get; private set; }

        /// <summary>
        /// If true, items in the set can only be added in increasing order, and adding an item will remove any previous item. For Quests, this is by necessity true. Only one quest step is present at a time, and previous steps are removed as you advance in the quest.
        /// </summary>
        public bool? RequireOrderedSetItemAdd { get; private set; }

        /// <summary>
        /// If true, the UI should treat this quest as \&quot;featured\&quot;
        /// </summary>
        public bool? SetIsFeatured { get; private set; }

        /// <summary>
        /// A string identifier we can use to attempt to identify the category of the Quest.
        /// </summary>
        public string SetType { get; private set; }

        /// <summary>
        /// The name of the quest line that this quest step is a part of.
        /// </summary>
        public string QuestLineName { get; private set; }


        /// <summary>
        /// Empty constructor required by some serializers.
        /// Use DestinyDefinitionsDestinyItemSetBlockDefinition.Builder() for instance creation instead.
        /// </summary>
        [Obsolete]
        public DestinyDefinitionsDestinyItemSetBlockDefinition()
        {
        }

        private DestinyDefinitionsDestinyItemSetBlockDefinition(List<DestinyDefinitionsDestinyItemSetBlockEntryDefinition> ItemList, bool? RequireOrderedSetItemAdd, bool? SetIsFeatured, string SetType, string QuestLineName)
        {
            
            this.ItemList = ItemList;
            
            this.RequireOrderedSetItemAdd = RequireOrderedSetItemAdd;
            
            this.SetIsFeatured = SetIsFeatured;
            
            this.SetType = SetType;
            
            this.QuestLineName = QuestLineName;
            
        }

        /// <summary>
        /// Returns builder of DestinyDefinitionsDestinyItemSetBlockDefinition.
        /// </summary>
        /// <returns>DestinyDefinitionsDestinyItemSetBlockDefinitionBuilder</returns>
        public static DestinyDefinitionsDestinyItemSetBlockDefinitionBuilder Builder()
        {
            return new DestinyDefinitionsDestinyItemSetBlockDefinitionBuilder();
        }

        /// <summary>
        /// Returns DestinyDefinitionsDestinyItemSetBlockDefinitionBuilder with properties set.
        /// Use it to change properties.
        /// </summary>
        /// <returns>DestinyDefinitionsDestinyItemSetBlockDefinitionBuilder</returns>
        public DestinyDefinitionsDestinyItemSetBlockDefinitionBuilder With()
        {
            return Builder()
                .ItemList(ItemList)
                .RequireOrderedSetItemAdd(RequireOrderedSetItemAdd)
                .SetIsFeatured(SetIsFeatured)
                .SetType(SetType)
                .QuestLineName(QuestLineName);
        }

        public override string ToString()
        {
            return this.PropertiesToString();
        }

        public override bool Equals(object obj)
        {
            return this.EqualsByProperties(obj);
        }

        public bool Equals(DestinyDefinitionsDestinyItemSetBlockDefinition other)
        {
            return Equals((object) other);
        }

        public override int GetHashCode()
        {
            return this.PropertiesHash();
        }

        /// <summary>
        /// Implementation of == operator for (DestinyDefinitionsDestinyItemSetBlockDefinition.
        /// </summary>
        /// <param name="left">Compared (DestinyDefinitionsDestinyItemSetBlockDefinition</param>
        /// <param name="right">Compared (DestinyDefinitionsDestinyItemSetBlockDefinition</param>
        /// <returns>true if compared items are equals, false otherwise</returns>
        public static bool operator == (DestinyDefinitionsDestinyItemSetBlockDefinition left, DestinyDefinitionsDestinyItemSetBlockDefinition right)
        {
            return Equals(left, right);
        }

        /// <summary>
        /// Implementation of != operator for (DestinyDefinitionsDestinyItemSetBlockDefinition.
        /// </summary>
        /// <param name="left">Compared (DestinyDefinitionsDestinyItemSetBlockDefinition</param>
        /// <param name="right">Compared (DestinyDefinitionsDestinyItemSetBlockDefinition</param>
        /// <returns>true if compared items are not equals, false otherwise</returns>
        public static bool operator != (DestinyDefinitionsDestinyItemSetBlockDefinition left, DestinyDefinitionsDestinyItemSetBlockDefinition right)
        {
            return !Equals(left, right);
        }

        /// <summary>
        /// Builder of DestinyDefinitionsDestinyItemSetBlockDefinition.
        /// </summary>
        public sealed class DestinyDefinitionsDestinyItemSetBlockDefinitionBuilder
        {
            private List<DestinyDefinitionsDestinyItemSetBlockEntryDefinition> _ItemList;
            private bool? _RequireOrderedSetItemAdd;
            private bool? _SetIsFeatured;
            private string _SetType;
            private string _QuestLineName;

            internal DestinyDefinitionsDestinyItemSetBlockDefinitionBuilder()
            {
                SetupDefaults();
            }

            private void SetupDefaults()
            {
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsDestinyItemSetBlockDefinition.ItemList property.
            /// </summary>
            /// <param name="value">A collection of hashes of set items, for items such as Quest Metadata items that possess this data.</param>
            public DestinyDefinitionsDestinyItemSetBlockDefinitionBuilder ItemList(List<DestinyDefinitionsDestinyItemSetBlockEntryDefinition> value)
            {
                _ItemList = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsDestinyItemSetBlockDefinition.RequireOrderedSetItemAdd property.
            /// </summary>
            /// <param name="value">If true, items in the set can only be added in increasing order, and adding an item will remove any previous item. For Quests, this is by necessity true. Only one quest step is present at a time, and previous steps are removed as you advance in the quest.</param>
            public DestinyDefinitionsDestinyItemSetBlockDefinitionBuilder RequireOrderedSetItemAdd(bool? value)
            {
                _RequireOrderedSetItemAdd = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsDestinyItemSetBlockDefinition.SetIsFeatured property.
            /// </summary>
            /// <param name="value">If true, the UI should treat this quest as \&quot;featured\&quot;</param>
            public DestinyDefinitionsDestinyItemSetBlockDefinitionBuilder SetIsFeatured(bool? value)
            {
                _SetIsFeatured = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsDestinyItemSetBlockDefinition.SetType property.
            /// </summary>
            /// <param name="value">A string identifier we can use to attempt to identify the category of the Quest.</param>
            public DestinyDefinitionsDestinyItemSetBlockDefinitionBuilder SetType(string value)
            {
                _SetType = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsDestinyItemSetBlockDefinition.QuestLineName property.
            /// </summary>
            /// <param name="value">The name of the quest line that this quest step is a part of.</param>
            public DestinyDefinitionsDestinyItemSetBlockDefinitionBuilder QuestLineName(string value)
            {
                _QuestLineName = value;
                return this;
            }


            /// <summary>
            /// Builds instance of DestinyDefinitionsDestinyItemSetBlockDefinition.
            /// </summary>
            /// <returns>DestinyDefinitionsDestinyItemSetBlockDefinition</returns>
            public DestinyDefinitionsDestinyItemSetBlockDefinition Build()
            {
                Validate();
                return new DestinyDefinitionsDestinyItemSetBlockDefinition(
                    ItemList: _ItemList,
                    RequireOrderedSetItemAdd: _RequireOrderedSetItemAdd,
                    SetIsFeatured: _SetIsFeatured,
                    SetType: _SetType,
                    QuestLineName: _QuestLineName
                );
            }

            private void Validate()
            { 
            }
        }

        
    }
}