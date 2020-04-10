using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Sharpility.Extensions;
using NodaTime;

namespace BungieNetApi._Platform.Models
{
    /// <summary>
    /// The response contract for GetDestinyCharacter, with components that can be returned for character and item-level data.
    /// </summary>
    public sealed class DestinyResponsesDestinyCharacterResponse:  IEquatable<DestinyResponsesDestinyCharacterResponse>
    { 
        /// <summary>
        /// The character-level non-equipped inventory items.  COMPONENT TYPE: CharacterInventories
        /// </summary>
        public SingleComponentResponseOfDestinyInventoryComponent Inventory { get; private set; }

        /// <summary>
        /// Base information about the character in question.  COMPONENT TYPE: Characters
        /// </summary>
        public SingleComponentResponseOfDestinyCharacterComponent Character { get; private set; }

        /// <summary>
        /// Character progression data, including Milestones.  COMPONENT TYPE: CharacterProgressions
        /// </summary>
        public SingleComponentResponseOfDestinyCharacterProgressionComponent Progressions { get; private set; }

        /// <summary>
        /// Character rendering data - a minimal set of information about equipment and dyes used for rendering.  COMPONENT TYPE: CharacterRenderData
        /// </summary>
        public SingleComponentResponseOfDestinyCharacterRenderComponent RenderData { get; private set; }

        /// <summary>
        /// Activity data - info about current activities available to the player.  COMPONENT TYPE: CharacterActivities
        /// </summary>
        public SingleComponentResponseOfDestinyCharacterActivitiesComponent Activities { get; private set; }

        /// <summary>
        /// Equipped items on the character.  COMPONENT TYPE: CharacterEquipment
        /// </summary>
        public SingleComponentResponseOfDestinyInventoryComponent Equipment { get; private set; }

        /// <summary>
        /// Items available from Kiosks that are available to this specific character.   COMPONENT TYPE: Kiosks
        /// </summary>
        public SingleComponentResponseOfDestinyKiosksComponent Kiosks { get; private set; }

        /// <summary>
        /// When sockets refer to reusable Plug Sets (see DestinyPlugSetDefinition for more info), this is the set of plugs and their states that are scoped to this character.  This comes back with ItemSockets, as it is needed for a complete picture of the sockets on requested items.  COMPONENT TYPE: ItemSockets
        /// </summary>
        public SingleComponentResponseOfDestinyPlugSetsComponent PlugSets { get; private set; }

        /// <summary>
        /// COMPONENT TYPE: PresentationNodes
        /// </summary>
        public SingleComponentResponseOfDestinyPresentationNodesComponent PresentationNodes { get; private set; }

        /// <summary>
        /// COMPONENT TYPE: Records
        /// </summary>
        public SingleComponentResponseOfDestinyCharacterRecordsComponent Records { get; private set; }

        /// <summary>
        /// COMPONENT TYPE: Collectibles
        /// </summary>
        public SingleComponentResponseOfDestinyCollectiblesComponent Collectibles { get; private set; }

        /// <summary>
        /// The set of components belonging to the player&#39;s instanced items.  COMPONENT TYPE: [See inside the DestinyItemComponentSet contract for component types.]
        /// </summary>
        public DestinyItemComponentSetOfint64 ItemComponents { get; private set; }

        /// <summary>
        /// The set of components belonging to the player&#39;s UNinstanced items. Because apparently now those too can have information relevant to the character&#39;s state.  COMPONENT TYPE: [See inside the DestinyItemComponentSet contract for component types.]
        /// </summary>
        public DestinyBaseItemComponentSetOfuint32 UninstancedItemComponents { get; private set; }

        /// <summary>
        /// A \&quot;lookup\&quot; convenience component that can be used to quickly check if the character has access to items that can be used for purchasing.  COMPONENT TYPE: CurrencyLookups
        /// </summary>
        public SingleComponentResponseOfDestinyCurrenciesComponent CurrencyLookups { get; private set; }


        /// <summary>
        /// Empty constructor required by some serializers.
        /// Use DestinyResponsesDestinyCharacterResponse.Builder() for instance creation instead.
        /// </summary>
        [Obsolete]
        public DestinyResponsesDestinyCharacterResponse()
        {
        }

        private DestinyResponsesDestinyCharacterResponse(SingleComponentResponseOfDestinyInventoryComponent Inventory, SingleComponentResponseOfDestinyCharacterComponent Character, SingleComponentResponseOfDestinyCharacterProgressionComponent Progressions, SingleComponentResponseOfDestinyCharacterRenderComponent RenderData, SingleComponentResponseOfDestinyCharacterActivitiesComponent Activities, SingleComponentResponseOfDestinyInventoryComponent Equipment, SingleComponentResponseOfDestinyKiosksComponent Kiosks, SingleComponentResponseOfDestinyPlugSetsComponent PlugSets, SingleComponentResponseOfDestinyPresentationNodesComponent PresentationNodes, SingleComponentResponseOfDestinyCharacterRecordsComponent Records, SingleComponentResponseOfDestinyCollectiblesComponent Collectibles, DestinyItemComponentSetOfint64 ItemComponents, DestinyBaseItemComponentSetOfuint32 UninstancedItemComponents, SingleComponentResponseOfDestinyCurrenciesComponent CurrencyLookups)
        {
            
            this.Inventory = Inventory;
            
            this.Character = Character;
            
            this.Progressions = Progressions;
            
            this.RenderData = RenderData;
            
            this.Activities = Activities;
            
            this.Equipment = Equipment;
            
            this.Kiosks = Kiosks;
            
            this.PlugSets = PlugSets;
            
            this.PresentationNodes = PresentationNodes;
            
            this.Records = Records;
            
            this.Collectibles = Collectibles;
            
            this.ItemComponents = ItemComponents;
            
            this.UninstancedItemComponents = UninstancedItemComponents;
            
            this.CurrencyLookups = CurrencyLookups;
            
        }

        /// <summary>
        /// Returns builder of DestinyResponsesDestinyCharacterResponse.
        /// </summary>
        /// <returns>DestinyResponsesDestinyCharacterResponseBuilder</returns>
        public static DestinyResponsesDestinyCharacterResponseBuilder Builder()
        {
            return new DestinyResponsesDestinyCharacterResponseBuilder();
        }

        /// <summary>
        /// Returns DestinyResponsesDestinyCharacterResponseBuilder with properties set.
        /// Use it to change properties.
        /// </summary>
        /// <returns>DestinyResponsesDestinyCharacterResponseBuilder</returns>
        public DestinyResponsesDestinyCharacterResponseBuilder With()
        {
            return Builder()
                .Inventory(Inventory)
                .Character(Character)
                .Progressions(Progressions)
                .RenderData(RenderData)
                .Activities(Activities)
                .Equipment(Equipment)
                .Kiosks(Kiosks)
                .PlugSets(PlugSets)
                .PresentationNodes(PresentationNodes)
                .Records(Records)
                .Collectibles(Collectibles)
                .ItemComponents(ItemComponents)
                .UninstancedItemComponents(UninstancedItemComponents)
                .CurrencyLookups(CurrencyLookups);
        }

        public override string ToString()
        {
            return this.PropertiesToString();
        }

        public override bool Equals(object obj)
        {
            return this.EqualsByProperties(obj);
        }

        public bool Equals(DestinyResponsesDestinyCharacterResponse other)
        {
            return Equals((object) other);
        }

        public override int GetHashCode()
        {
            return this.PropertiesHash();
        }

        /// <summary>
        /// Implementation of == operator for (DestinyResponsesDestinyCharacterResponse.
        /// </summary>
        /// <param name="left">Compared (DestinyResponsesDestinyCharacterResponse</param>
        /// <param name="right">Compared (DestinyResponsesDestinyCharacterResponse</param>
        /// <returns>true if compared items are equals, false otherwise</returns>
        public static bool operator == (DestinyResponsesDestinyCharacterResponse left, DestinyResponsesDestinyCharacterResponse right)
        {
            return Equals(left, right);
        }

        /// <summary>
        /// Implementation of != operator for (DestinyResponsesDestinyCharacterResponse.
        /// </summary>
        /// <param name="left">Compared (DestinyResponsesDestinyCharacterResponse</param>
        /// <param name="right">Compared (DestinyResponsesDestinyCharacterResponse</param>
        /// <returns>true if compared items are not equals, false otherwise</returns>
        public static bool operator != (DestinyResponsesDestinyCharacterResponse left, DestinyResponsesDestinyCharacterResponse right)
        {
            return !Equals(left, right);
        }

        /// <summary>
        /// Builder of DestinyResponsesDestinyCharacterResponse.
        /// </summary>
        public sealed class DestinyResponsesDestinyCharacterResponseBuilder
        {
            private SingleComponentResponseOfDestinyInventoryComponent _Inventory;
            private SingleComponentResponseOfDestinyCharacterComponent _Character;
            private SingleComponentResponseOfDestinyCharacterProgressionComponent _Progressions;
            private SingleComponentResponseOfDestinyCharacterRenderComponent _RenderData;
            private SingleComponentResponseOfDestinyCharacterActivitiesComponent _Activities;
            private SingleComponentResponseOfDestinyInventoryComponent _Equipment;
            private SingleComponentResponseOfDestinyKiosksComponent _Kiosks;
            private SingleComponentResponseOfDestinyPlugSetsComponent _PlugSets;
            private SingleComponentResponseOfDestinyPresentationNodesComponent _PresentationNodes;
            private SingleComponentResponseOfDestinyCharacterRecordsComponent _Records;
            private SingleComponentResponseOfDestinyCollectiblesComponent _Collectibles;
            private DestinyItemComponentSetOfint64 _ItemComponents;
            private DestinyBaseItemComponentSetOfuint32 _UninstancedItemComponents;
            private SingleComponentResponseOfDestinyCurrenciesComponent _CurrencyLookups;

            internal DestinyResponsesDestinyCharacterResponseBuilder()
            {
                SetupDefaults();
            }

            private void SetupDefaults()
            {
            }

            /// <summary>
            /// Sets value for DestinyResponsesDestinyCharacterResponse.Inventory property.
            /// </summary>
            /// <param name="value">The character-level non-equipped inventory items.  COMPONENT TYPE: CharacterInventories</param>
            public DestinyResponsesDestinyCharacterResponseBuilder Inventory(SingleComponentResponseOfDestinyInventoryComponent value)
            {
                _Inventory = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyResponsesDestinyCharacterResponse.Character property.
            /// </summary>
            /// <param name="value">Base information about the character in question.  COMPONENT TYPE: Characters</param>
            public DestinyResponsesDestinyCharacterResponseBuilder Character(SingleComponentResponseOfDestinyCharacterComponent value)
            {
                _Character = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyResponsesDestinyCharacterResponse.Progressions property.
            /// </summary>
            /// <param name="value">Character progression data, including Milestones.  COMPONENT TYPE: CharacterProgressions</param>
            public DestinyResponsesDestinyCharacterResponseBuilder Progressions(SingleComponentResponseOfDestinyCharacterProgressionComponent value)
            {
                _Progressions = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyResponsesDestinyCharacterResponse.RenderData property.
            /// </summary>
            /// <param name="value">Character rendering data - a minimal set of information about equipment and dyes used for rendering.  COMPONENT TYPE: CharacterRenderData</param>
            public DestinyResponsesDestinyCharacterResponseBuilder RenderData(SingleComponentResponseOfDestinyCharacterRenderComponent value)
            {
                _RenderData = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyResponsesDestinyCharacterResponse.Activities property.
            /// </summary>
            /// <param name="value">Activity data - info about current activities available to the player.  COMPONENT TYPE: CharacterActivities</param>
            public DestinyResponsesDestinyCharacterResponseBuilder Activities(SingleComponentResponseOfDestinyCharacterActivitiesComponent value)
            {
                _Activities = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyResponsesDestinyCharacterResponse.Equipment property.
            /// </summary>
            /// <param name="value">Equipped items on the character.  COMPONENT TYPE: CharacterEquipment</param>
            public DestinyResponsesDestinyCharacterResponseBuilder Equipment(SingleComponentResponseOfDestinyInventoryComponent value)
            {
                _Equipment = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyResponsesDestinyCharacterResponse.Kiosks property.
            /// </summary>
            /// <param name="value">Items available from Kiosks that are available to this specific character.   COMPONENT TYPE: Kiosks</param>
            public DestinyResponsesDestinyCharacterResponseBuilder Kiosks(SingleComponentResponseOfDestinyKiosksComponent value)
            {
                _Kiosks = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyResponsesDestinyCharacterResponse.PlugSets property.
            /// </summary>
            /// <param name="value">When sockets refer to reusable Plug Sets (see DestinyPlugSetDefinition for more info), this is the set of plugs and their states that are scoped to this character.  This comes back with ItemSockets, as it is needed for a complete picture of the sockets on requested items.  COMPONENT TYPE: ItemSockets</param>
            public DestinyResponsesDestinyCharacterResponseBuilder PlugSets(SingleComponentResponseOfDestinyPlugSetsComponent value)
            {
                _PlugSets = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyResponsesDestinyCharacterResponse.PresentationNodes property.
            /// </summary>
            /// <param name="value">COMPONENT TYPE: PresentationNodes</param>
            public DestinyResponsesDestinyCharacterResponseBuilder PresentationNodes(SingleComponentResponseOfDestinyPresentationNodesComponent value)
            {
                _PresentationNodes = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyResponsesDestinyCharacterResponse.Records property.
            /// </summary>
            /// <param name="value">COMPONENT TYPE: Records</param>
            public DestinyResponsesDestinyCharacterResponseBuilder Records(SingleComponentResponseOfDestinyCharacterRecordsComponent value)
            {
                _Records = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyResponsesDestinyCharacterResponse.Collectibles property.
            /// </summary>
            /// <param name="value">COMPONENT TYPE: Collectibles</param>
            public DestinyResponsesDestinyCharacterResponseBuilder Collectibles(SingleComponentResponseOfDestinyCollectiblesComponent value)
            {
                _Collectibles = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyResponsesDestinyCharacterResponse.ItemComponents property.
            /// </summary>
            /// <param name="value">The set of components belonging to the player&#39;s instanced items.  COMPONENT TYPE: [See inside the DestinyItemComponentSet contract for component types.]</param>
            public DestinyResponsesDestinyCharacterResponseBuilder ItemComponents(DestinyItemComponentSetOfint64 value)
            {
                _ItemComponents = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyResponsesDestinyCharacterResponse.UninstancedItemComponents property.
            /// </summary>
            /// <param name="value">The set of components belonging to the player&#39;s UNinstanced items. Because apparently now those too can have information relevant to the character&#39;s state.  COMPONENT TYPE: [See inside the DestinyItemComponentSet contract for component types.]</param>
            public DestinyResponsesDestinyCharacterResponseBuilder UninstancedItemComponents(DestinyBaseItemComponentSetOfuint32 value)
            {
                _UninstancedItemComponents = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyResponsesDestinyCharacterResponse.CurrencyLookups property.
            /// </summary>
            /// <param name="value">A \&quot;lookup\&quot; convenience component that can be used to quickly check if the character has access to items that can be used for purchasing.  COMPONENT TYPE: CurrencyLookups</param>
            public DestinyResponsesDestinyCharacterResponseBuilder CurrencyLookups(SingleComponentResponseOfDestinyCurrenciesComponent value)
            {
                _CurrencyLookups = value;
                return this;
            }


            /// <summary>
            /// Builds instance of DestinyResponsesDestinyCharacterResponse.
            /// </summary>
            /// <returns>DestinyResponsesDestinyCharacterResponse</returns>
            public DestinyResponsesDestinyCharacterResponse Build()
            {
                Validate();
                return new DestinyResponsesDestinyCharacterResponse(
                    Inventory: _Inventory,
                    Character: _Character,
                    Progressions: _Progressions,
                    RenderData: _RenderData,
                    Activities: _Activities,
                    Equipment: _Equipment,
                    Kiosks: _Kiosks,
                    PlugSets: _PlugSets,
                    PresentationNodes: _PresentationNodes,
                    Records: _Records,
                    Collectibles: _Collectibles,
                    ItemComponents: _ItemComponents,
                    UninstancedItemComponents: _UninstancedItemComponents,
                    CurrencyLookups: _CurrencyLookups
                );
            }

            private void Validate()
            { 
            }
        }

        
    }
}