using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Sharpility.Extensions;
using NodaTime;

namespace BungieNetApi._Platform.Models
{
    /// <summary>
    /// The response for GetDestinyProfile, with components for character and item-level data.
    /// </summary>
    public sealed class DestinyResponsesDestinyProfileResponse:  IEquatable<DestinyResponsesDestinyProfileResponse>
    { 
        /// <summary>
        /// Recent, refundable purchases you have made from vendors. When will you use it? Couldn&#39;t say...  COMPONENT TYPE: VendorReceipts
        /// </summary>
        public SingleComponentResponseOfDestinyVendorReceiptsComponent VendorReceipts { get; private set; }

        /// <summary>
        /// The profile-level inventory of the Destiny Profile.  COMPONENT TYPE: ProfileInventories
        /// </summary>
        public SingleComponentResponseOfDestinyInventoryComponent ProfileInventory { get; private set; }

        /// <summary>
        /// The profile-level currencies owned by the Destiny Profile.  COMPONENT TYPE: ProfileCurrencies
        /// </summary>
        public SingleComponentResponseOfDestinyInventoryComponent ProfileCurrencies { get; private set; }

        /// <summary>
        /// The basic information about the Destiny Profile (formerly \&quot;Account\&quot;).  COMPONENT TYPE: Profiles
        /// </summary>
        public SingleComponentResponseOfDestinyProfileComponent Profile { get; private set; }

        /// <summary>
        /// Silver quantities for any platform on which this Profile plays destiny.   COMPONENT TYPE: PlatformSilver
        /// </summary>
        public SingleComponentResponseOfDestinyPlatformSilverComponent PlatformSilver { get; private set; }

        /// <summary>
        /// Items available from Kiosks that are available Profile-wide (i.e. across all characters)  This component returns information about what Kiosk items are available to you on a *Profile* level. It is theoretically possible for Kiosks to have items gated by specific Character as well. If you ever have those, you will find them on the characterKiosks property.  COMPONENT TYPE: Kiosks
        /// </summary>
        public SingleComponentResponseOfDestinyKiosksComponent ProfileKiosks { get; private set; }

        /// <summary>
        /// When sockets refer to reusable Plug Sets (see DestinyPlugSetDefinition for more info), this is the set of plugs and their states that are profile-scoped.  This comes back with ItemSockets, as it is needed for a complete picture of the sockets on requested items.  COMPONENT TYPE: ItemSockets
        /// </summary>
        public SingleComponentResponseOfDestinyPlugSetsComponent ProfilePlugSets { get; private set; }

        /// <summary>
        /// When we have progression information - such as Checklists - that may apply profile-wide, it will be returned here rather than in the per-character progression data.  COMPONENT TYPE: ProfileProgression
        /// </summary>
        public SingleComponentResponseOfDestinyProfileProgressionComponent ProfileProgression { get; private set; }

        /// <summary>
        /// COMPONENT TYPE: PresentationNodes
        /// </summary>
        public SingleComponentResponseOfDestinyPresentationNodesComponent ProfilePresentationNodes { get; private set; }

        /// <summary>
        /// COMPONENT TYPE: Records
        /// </summary>
        public SingleComponentResponseOfDestinyProfileRecordsComponent ProfileRecords { get; private set; }

        /// <summary>
        /// COMPONENT TYPE: Collectibles
        /// </summary>
        public SingleComponentResponseOfDestinyProfileCollectiblesComponent ProfileCollectibles { get; private set; }

        /// <summary>
        /// COMPONENT TYPE: Transitory
        /// </summary>
        public SingleComponentResponseOfDestinyProfileTransitoryComponent ProfileTransitoryData { get; private set; }

        /// <summary>
        /// COMPONENT TYPE: Metrics
        /// </summary>
        public SingleComponentResponseOfDestinyMetricsComponent Metrics { get; private set; }

        /// <summary>
        /// Basic information about each character, keyed by the CharacterId.  COMPONENT TYPE: Characters
        /// </summary>
        public DictionaryComponentResponseOfint64AndDestinyCharacterComponent Characters { get; private set; }

        /// <summary>
        /// The character-level non-equipped inventory items, keyed by the Character&#39;s Id.  COMPONENT TYPE: CharacterInventories
        /// </summary>
        public DictionaryComponentResponseOfint64AndDestinyInventoryComponent CharacterInventories { get; private set; }

        /// <summary>
        /// Character-level progression data, keyed by the Character&#39;s Id.  COMPONENT TYPE: CharacterProgressions
        /// </summary>
        public DictionaryComponentResponseOfint64AndDestinyCharacterProgressionComponent CharacterProgressions { get; private set; }

        /// <summary>
        /// Character rendering data - a minimal set of info needed to render a character in 3D - keyed by the Character&#39;s Id.  COMPONENT TYPE: CharacterRenderData
        /// </summary>
        public DictionaryComponentResponseOfint64AndDestinyCharacterRenderComponent CharacterRenderData { get; private set; }

        /// <summary>
        /// Character activity data - the activities available to this character and its status, keyed by the Character&#39;s Id.  COMPONENT TYPE: CharacterActivities
        /// </summary>
        public DictionaryComponentResponseOfint64AndDestinyCharacterActivitiesComponent CharacterActivities { get; private set; }

        /// <summary>
        /// The character&#39;s equipped items, keyed by the Character&#39;s Id.  COMPONENT TYPE: CharacterEquipment
        /// </summary>
        public DictionaryComponentResponseOfint64AndDestinyInventoryComponent CharacterEquipment { get; private set; }

        /// <summary>
        /// Items available from Kiosks that are available to a specific character as opposed to the account as a whole. It must be combined with data from the profileKiosks property to get a full picture of the character&#39;s available items to check out of a kiosk.  This component returns information about what Kiosk items are available to you on a *Character* level. Usually, kiosk items will be earned for the entire Profile (all characters) at once. To find those, look in the profileKiosks property.  COMPONENT TYPE: Kiosks
        /// </summary>
        public DictionaryComponentResponseOfint64AndDestinyKiosksComponent CharacterKiosks { get; private set; }

        /// <summary>
        /// When sockets refer to reusable Plug Sets (see DestinyPlugSetDefinition for more info), this is the set of plugs and their states, per character, that are character-scoped.  This comes back with ItemSockets, as it is needed for a complete picture of the sockets on requested items.  COMPONENT TYPE: ItemSockets
        /// </summary>
        public DictionaryComponentResponseOfint64AndDestinyPlugSetsComponent CharacterPlugSets { get; private set; }

        /// <summary>
        /// Do you ever get the feeling that a system was designed *too* flexibly? That it can be used in so many different ways that you end up being unable to provide an easy to use abstraction for the mess that&#39;s happening under the surface?  Let&#39;s talk about character-specific data that might be related to items without instances. These two statements are totally unrelated, I promise.  At some point during D2, it was decided that items - such as Bounties - could be given to characters and *not* have instance data, but that *could* display and even use relevant state information on your account and character.  Up to now, any item that had meaningful dependencies on character or account state had to be instanced, and thus \&quot;itemComponents\&quot; was all that you needed: it was keyed by item&#39;s instance IDs and provided the stateful information you needed inside.  Unfortunately, we don&#39;t live in such a magical world anymore. This is information held on a per-character basis about non-instanced items that the characters have in their inventory - or that reference character-specific state information even if it&#39;s in Account-level inventory - and the values related to that item&#39;s state in relation to the given character.  To give a concrete example, look at a Moments of Triumph bounty. They exist in a character&#39;s inventory, and show/care about a character&#39;s progression toward completing the bounty. But the bounty itself is a non-instanced item, like a mod or a currency. This returns that data for the characters who have the bounty in their inventory.  I&#39;m not crying, you&#39;re crying Okay we&#39;re both crying but it&#39;s going to be okay I promise Actually I shouldn&#39;t promise that, I don&#39;t know if it&#39;s going to be okay
        /// </summary>
        public Dictionary<string, DestinyBaseItemComponentSetOfuint32> CharacterUninstancedItemComponents { get; private set; }

        /// <summary>
        /// COMPONENT TYPE: PresentationNodes
        /// </summary>
        public DictionaryComponentResponseOfint64AndDestinyPresentationNodesComponent CharacterPresentationNodes { get; private set; }

        /// <summary>
        /// COMPONENT TYPE: Records
        /// </summary>
        public DictionaryComponentResponseOfint64AndDestinyCharacterRecordsComponent CharacterRecords { get; private set; }

        /// <summary>
        /// COMPONENT TYPE: Collectibles
        /// </summary>
        public DictionaryComponentResponseOfint64AndDestinyCollectiblesComponent CharacterCollectibles { get; private set; }

        /// <summary>
        /// Information about instanced items across all returned characters, keyed by the item&#39;s instance ID.  COMPONENT TYPE: [See inside the DestinyItemComponentSet contract for component types.]
        /// </summary>
        public DestinyItemComponentSetOfint64 ItemComponents { get; private set; }

        /// <summary>
        /// A \&quot;lookup\&quot; convenience component that can be used to quickly check if the character has access to items that can be used for purchasing.  COMPONENT TYPE: CurrencyLookups
        /// </summary>
        public DictionaryComponentResponseOfint64AndDestinyCurrenciesComponent CharacterCurrencyLookups { get; private set; }


        /// <summary>
        /// Empty constructor required by some serializers.
        /// Use DestinyResponsesDestinyProfileResponse.Builder() for instance creation instead.
        /// </summary>
        [Obsolete]
        public DestinyResponsesDestinyProfileResponse()
        {
        }

        private DestinyResponsesDestinyProfileResponse(SingleComponentResponseOfDestinyVendorReceiptsComponent VendorReceipts, SingleComponentResponseOfDestinyInventoryComponent ProfileInventory, SingleComponentResponseOfDestinyInventoryComponent ProfileCurrencies, SingleComponentResponseOfDestinyProfileComponent Profile, SingleComponentResponseOfDestinyPlatformSilverComponent PlatformSilver, SingleComponentResponseOfDestinyKiosksComponent ProfileKiosks, SingleComponentResponseOfDestinyPlugSetsComponent ProfilePlugSets, SingleComponentResponseOfDestinyProfileProgressionComponent ProfileProgression, SingleComponentResponseOfDestinyPresentationNodesComponent ProfilePresentationNodes, SingleComponentResponseOfDestinyProfileRecordsComponent ProfileRecords, SingleComponentResponseOfDestinyProfileCollectiblesComponent ProfileCollectibles, SingleComponentResponseOfDestinyProfileTransitoryComponent ProfileTransitoryData, SingleComponentResponseOfDestinyMetricsComponent Metrics, DictionaryComponentResponseOfint64AndDestinyCharacterComponent Characters, DictionaryComponentResponseOfint64AndDestinyInventoryComponent CharacterInventories, DictionaryComponentResponseOfint64AndDestinyCharacterProgressionComponent CharacterProgressions, DictionaryComponentResponseOfint64AndDestinyCharacterRenderComponent CharacterRenderData, DictionaryComponentResponseOfint64AndDestinyCharacterActivitiesComponent CharacterActivities, DictionaryComponentResponseOfint64AndDestinyInventoryComponent CharacterEquipment, DictionaryComponentResponseOfint64AndDestinyKiosksComponent CharacterKiosks, DictionaryComponentResponseOfint64AndDestinyPlugSetsComponent CharacterPlugSets, Dictionary<string, DestinyBaseItemComponentSetOfuint32> CharacterUninstancedItemComponents, DictionaryComponentResponseOfint64AndDestinyPresentationNodesComponent CharacterPresentationNodes, DictionaryComponentResponseOfint64AndDestinyCharacterRecordsComponent CharacterRecords, DictionaryComponentResponseOfint64AndDestinyCollectiblesComponent CharacterCollectibles, DestinyItemComponentSetOfint64 ItemComponents, DictionaryComponentResponseOfint64AndDestinyCurrenciesComponent CharacterCurrencyLookups)
        {
            
            this.VendorReceipts = VendorReceipts;
            
            this.ProfileInventory = ProfileInventory;
            
            this.ProfileCurrencies = ProfileCurrencies;
            
            this.Profile = Profile;
            
            this.PlatformSilver = PlatformSilver;
            
            this.ProfileKiosks = ProfileKiosks;
            
            this.ProfilePlugSets = ProfilePlugSets;
            
            this.ProfileProgression = ProfileProgression;
            
            this.ProfilePresentationNodes = ProfilePresentationNodes;
            
            this.ProfileRecords = ProfileRecords;
            
            this.ProfileCollectibles = ProfileCollectibles;
            
            this.ProfileTransitoryData = ProfileTransitoryData;
            
            this.Metrics = Metrics;
            
            this.Characters = Characters;
            
            this.CharacterInventories = CharacterInventories;
            
            this.CharacterProgressions = CharacterProgressions;
            
            this.CharacterRenderData = CharacterRenderData;
            
            this.CharacterActivities = CharacterActivities;
            
            this.CharacterEquipment = CharacterEquipment;
            
            this.CharacterKiosks = CharacterKiosks;
            
            this.CharacterPlugSets = CharacterPlugSets;
            
            this.CharacterUninstancedItemComponents = CharacterUninstancedItemComponents;
            
            this.CharacterPresentationNodes = CharacterPresentationNodes;
            
            this.CharacterRecords = CharacterRecords;
            
            this.CharacterCollectibles = CharacterCollectibles;
            
            this.ItemComponents = ItemComponents;
            
            this.CharacterCurrencyLookups = CharacterCurrencyLookups;
            
        }

        /// <summary>
        /// Returns builder of DestinyResponsesDestinyProfileResponse.
        /// </summary>
        /// <returns>DestinyResponsesDestinyProfileResponseBuilder</returns>
        public static DestinyResponsesDestinyProfileResponseBuilder Builder()
        {
            return new DestinyResponsesDestinyProfileResponseBuilder();
        }

        /// <summary>
        /// Returns DestinyResponsesDestinyProfileResponseBuilder with properties set.
        /// Use it to change properties.
        /// </summary>
        /// <returns>DestinyResponsesDestinyProfileResponseBuilder</returns>
        public DestinyResponsesDestinyProfileResponseBuilder With()
        {
            return Builder()
                .VendorReceipts(VendorReceipts)
                .ProfileInventory(ProfileInventory)
                .ProfileCurrencies(ProfileCurrencies)
                .Profile(Profile)
                .PlatformSilver(PlatformSilver)
                .ProfileKiosks(ProfileKiosks)
                .ProfilePlugSets(ProfilePlugSets)
                .ProfileProgression(ProfileProgression)
                .ProfilePresentationNodes(ProfilePresentationNodes)
                .ProfileRecords(ProfileRecords)
                .ProfileCollectibles(ProfileCollectibles)
                .ProfileTransitoryData(ProfileTransitoryData)
                .Metrics(Metrics)
                .Characters(Characters)
                .CharacterInventories(CharacterInventories)
                .CharacterProgressions(CharacterProgressions)
                .CharacterRenderData(CharacterRenderData)
                .CharacterActivities(CharacterActivities)
                .CharacterEquipment(CharacterEquipment)
                .CharacterKiosks(CharacterKiosks)
                .CharacterPlugSets(CharacterPlugSets)
                .CharacterUninstancedItemComponents(CharacterUninstancedItemComponents)
                .CharacterPresentationNodes(CharacterPresentationNodes)
                .CharacterRecords(CharacterRecords)
                .CharacterCollectibles(CharacterCollectibles)
                .ItemComponents(ItemComponents)
                .CharacterCurrencyLookups(CharacterCurrencyLookups);
        }

        public override string ToString()
        {
            return this.PropertiesToString();
        }

        public override bool Equals(object obj)
        {
            return this.EqualsByProperties(obj);
        }

        public bool Equals(DestinyResponsesDestinyProfileResponse other)
        {
            return Equals((object) other);
        }

        public override int GetHashCode()
        {
            return this.PropertiesHash();
        }

        /// <summary>
        /// Implementation of == operator for (DestinyResponsesDestinyProfileResponse.
        /// </summary>
        /// <param name="left">Compared (DestinyResponsesDestinyProfileResponse</param>
        /// <param name="right">Compared (DestinyResponsesDestinyProfileResponse</param>
        /// <returns>true if compared items are equals, false otherwise</returns>
        public static bool operator == (DestinyResponsesDestinyProfileResponse left, DestinyResponsesDestinyProfileResponse right)
        {
            return Equals(left, right);
        }

        /// <summary>
        /// Implementation of != operator for (DestinyResponsesDestinyProfileResponse.
        /// </summary>
        /// <param name="left">Compared (DestinyResponsesDestinyProfileResponse</param>
        /// <param name="right">Compared (DestinyResponsesDestinyProfileResponse</param>
        /// <returns>true if compared items are not equals, false otherwise</returns>
        public static bool operator != (DestinyResponsesDestinyProfileResponse left, DestinyResponsesDestinyProfileResponse right)
        {
            return !Equals(left, right);
        }

        /// <summary>
        /// Builder of DestinyResponsesDestinyProfileResponse.
        /// </summary>
        public sealed class DestinyResponsesDestinyProfileResponseBuilder
        {
            private SingleComponentResponseOfDestinyVendorReceiptsComponent _VendorReceipts;
            private SingleComponentResponseOfDestinyInventoryComponent _ProfileInventory;
            private SingleComponentResponseOfDestinyInventoryComponent _ProfileCurrencies;
            private SingleComponentResponseOfDestinyProfileComponent _Profile;
            private SingleComponentResponseOfDestinyPlatformSilverComponent _PlatformSilver;
            private SingleComponentResponseOfDestinyKiosksComponent _ProfileKiosks;
            private SingleComponentResponseOfDestinyPlugSetsComponent _ProfilePlugSets;
            private SingleComponentResponseOfDestinyProfileProgressionComponent _ProfileProgression;
            private SingleComponentResponseOfDestinyPresentationNodesComponent _ProfilePresentationNodes;
            private SingleComponentResponseOfDestinyProfileRecordsComponent _ProfileRecords;
            private SingleComponentResponseOfDestinyProfileCollectiblesComponent _ProfileCollectibles;
            private SingleComponentResponseOfDestinyProfileTransitoryComponent _ProfileTransitoryData;
            private SingleComponentResponseOfDestinyMetricsComponent _Metrics;
            private DictionaryComponentResponseOfint64AndDestinyCharacterComponent _Characters;
            private DictionaryComponentResponseOfint64AndDestinyInventoryComponent _CharacterInventories;
            private DictionaryComponentResponseOfint64AndDestinyCharacterProgressionComponent _CharacterProgressions;
            private DictionaryComponentResponseOfint64AndDestinyCharacterRenderComponent _CharacterRenderData;
            private DictionaryComponentResponseOfint64AndDestinyCharacterActivitiesComponent _CharacterActivities;
            private DictionaryComponentResponseOfint64AndDestinyInventoryComponent _CharacterEquipment;
            private DictionaryComponentResponseOfint64AndDestinyKiosksComponent _CharacterKiosks;
            private DictionaryComponentResponseOfint64AndDestinyPlugSetsComponent _CharacterPlugSets;
            private Dictionary<string, DestinyBaseItemComponentSetOfuint32> _CharacterUninstancedItemComponents;
            private DictionaryComponentResponseOfint64AndDestinyPresentationNodesComponent _CharacterPresentationNodes;
            private DictionaryComponentResponseOfint64AndDestinyCharacterRecordsComponent _CharacterRecords;
            private DictionaryComponentResponseOfint64AndDestinyCollectiblesComponent _CharacterCollectibles;
            private DestinyItemComponentSetOfint64 _ItemComponents;
            private DictionaryComponentResponseOfint64AndDestinyCurrenciesComponent _CharacterCurrencyLookups;

            internal DestinyResponsesDestinyProfileResponseBuilder()
            {
                SetupDefaults();
            }

            private void SetupDefaults()
            {
            }

            /// <summary>
            /// Sets value for DestinyResponsesDestinyProfileResponse.VendorReceipts property.
            /// </summary>
            /// <param name="value">Recent, refundable purchases you have made from vendors. When will you use it? Couldn&#39;t say...  COMPONENT TYPE: VendorReceipts</param>
            public DestinyResponsesDestinyProfileResponseBuilder VendorReceipts(SingleComponentResponseOfDestinyVendorReceiptsComponent value)
            {
                _VendorReceipts = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyResponsesDestinyProfileResponse.ProfileInventory property.
            /// </summary>
            /// <param name="value">The profile-level inventory of the Destiny Profile.  COMPONENT TYPE: ProfileInventories</param>
            public DestinyResponsesDestinyProfileResponseBuilder ProfileInventory(SingleComponentResponseOfDestinyInventoryComponent value)
            {
                _ProfileInventory = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyResponsesDestinyProfileResponse.ProfileCurrencies property.
            /// </summary>
            /// <param name="value">The profile-level currencies owned by the Destiny Profile.  COMPONENT TYPE: ProfileCurrencies</param>
            public DestinyResponsesDestinyProfileResponseBuilder ProfileCurrencies(SingleComponentResponseOfDestinyInventoryComponent value)
            {
                _ProfileCurrencies = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyResponsesDestinyProfileResponse.Profile property.
            /// </summary>
            /// <param name="value">The basic information about the Destiny Profile (formerly \&quot;Account\&quot;).  COMPONENT TYPE: Profiles</param>
            public DestinyResponsesDestinyProfileResponseBuilder Profile(SingleComponentResponseOfDestinyProfileComponent value)
            {
                _Profile = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyResponsesDestinyProfileResponse.PlatformSilver property.
            /// </summary>
            /// <param name="value">Silver quantities for any platform on which this Profile plays destiny.   COMPONENT TYPE: PlatformSilver</param>
            public DestinyResponsesDestinyProfileResponseBuilder PlatformSilver(SingleComponentResponseOfDestinyPlatformSilverComponent value)
            {
                _PlatformSilver = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyResponsesDestinyProfileResponse.ProfileKiosks property.
            /// </summary>
            /// <param name="value">Items available from Kiosks that are available Profile-wide (i.e. across all characters)  This component returns information about what Kiosk items are available to you on a *Profile* level. It is theoretically possible for Kiosks to have items gated by specific Character as well. If you ever have those, you will find them on the characterKiosks property.  COMPONENT TYPE: Kiosks</param>
            public DestinyResponsesDestinyProfileResponseBuilder ProfileKiosks(SingleComponentResponseOfDestinyKiosksComponent value)
            {
                _ProfileKiosks = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyResponsesDestinyProfileResponse.ProfilePlugSets property.
            /// </summary>
            /// <param name="value">When sockets refer to reusable Plug Sets (see DestinyPlugSetDefinition for more info), this is the set of plugs and their states that are profile-scoped.  This comes back with ItemSockets, as it is needed for a complete picture of the sockets on requested items.  COMPONENT TYPE: ItemSockets</param>
            public DestinyResponsesDestinyProfileResponseBuilder ProfilePlugSets(SingleComponentResponseOfDestinyPlugSetsComponent value)
            {
                _ProfilePlugSets = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyResponsesDestinyProfileResponse.ProfileProgression property.
            /// </summary>
            /// <param name="value">When we have progression information - such as Checklists - that may apply profile-wide, it will be returned here rather than in the per-character progression data.  COMPONENT TYPE: ProfileProgression</param>
            public DestinyResponsesDestinyProfileResponseBuilder ProfileProgression(SingleComponentResponseOfDestinyProfileProgressionComponent value)
            {
                _ProfileProgression = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyResponsesDestinyProfileResponse.ProfilePresentationNodes property.
            /// </summary>
            /// <param name="value">COMPONENT TYPE: PresentationNodes</param>
            public DestinyResponsesDestinyProfileResponseBuilder ProfilePresentationNodes(SingleComponentResponseOfDestinyPresentationNodesComponent value)
            {
                _ProfilePresentationNodes = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyResponsesDestinyProfileResponse.ProfileRecords property.
            /// </summary>
            /// <param name="value">COMPONENT TYPE: Records</param>
            public DestinyResponsesDestinyProfileResponseBuilder ProfileRecords(SingleComponentResponseOfDestinyProfileRecordsComponent value)
            {
                _ProfileRecords = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyResponsesDestinyProfileResponse.ProfileCollectibles property.
            /// </summary>
            /// <param name="value">COMPONENT TYPE: Collectibles</param>
            public DestinyResponsesDestinyProfileResponseBuilder ProfileCollectibles(SingleComponentResponseOfDestinyProfileCollectiblesComponent value)
            {
                _ProfileCollectibles = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyResponsesDestinyProfileResponse.ProfileTransitoryData property.
            /// </summary>
            /// <param name="value">COMPONENT TYPE: Transitory</param>
            public DestinyResponsesDestinyProfileResponseBuilder ProfileTransitoryData(SingleComponentResponseOfDestinyProfileTransitoryComponent value)
            {
                _ProfileTransitoryData = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyResponsesDestinyProfileResponse.Metrics property.
            /// </summary>
            /// <param name="value">COMPONENT TYPE: Metrics</param>
            public DestinyResponsesDestinyProfileResponseBuilder Metrics(SingleComponentResponseOfDestinyMetricsComponent value)
            {
                _Metrics = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyResponsesDestinyProfileResponse.Characters property.
            /// </summary>
            /// <param name="value">Basic information about each character, keyed by the CharacterId.  COMPONENT TYPE: Characters</param>
            public DestinyResponsesDestinyProfileResponseBuilder Characters(DictionaryComponentResponseOfint64AndDestinyCharacterComponent value)
            {
                _Characters = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyResponsesDestinyProfileResponse.CharacterInventories property.
            /// </summary>
            /// <param name="value">The character-level non-equipped inventory items, keyed by the Character&#39;s Id.  COMPONENT TYPE: CharacterInventories</param>
            public DestinyResponsesDestinyProfileResponseBuilder CharacterInventories(DictionaryComponentResponseOfint64AndDestinyInventoryComponent value)
            {
                _CharacterInventories = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyResponsesDestinyProfileResponse.CharacterProgressions property.
            /// </summary>
            /// <param name="value">Character-level progression data, keyed by the Character&#39;s Id.  COMPONENT TYPE: CharacterProgressions</param>
            public DestinyResponsesDestinyProfileResponseBuilder CharacterProgressions(DictionaryComponentResponseOfint64AndDestinyCharacterProgressionComponent value)
            {
                _CharacterProgressions = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyResponsesDestinyProfileResponse.CharacterRenderData property.
            /// </summary>
            /// <param name="value">Character rendering data - a minimal set of info needed to render a character in 3D - keyed by the Character&#39;s Id.  COMPONENT TYPE: CharacterRenderData</param>
            public DestinyResponsesDestinyProfileResponseBuilder CharacterRenderData(DictionaryComponentResponseOfint64AndDestinyCharacterRenderComponent value)
            {
                _CharacterRenderData = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyResponsesDestinyProfileResponse.CharacterActivities property.
            /// </summary>
            /// <param name="value">Character activity data - the activities available to this character and its status, keyed by the Character&#39;s Id.  COMPONENT TYPE: CharacterActivities</param>
            public DestinyResponsesDestinyProfileResponseBuilder CharacterActivities(DictionaryComponentResponseOfint64AndDestinyCharacterActivitiesComponent value)
            {
                _CharacterActivities = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyResponsesDestinyProfileResponse.CharacterEquipment property.
            /// </summary>
            /// <param name="value">The character&#39;s equipped items, keyed by the Character&#39;s Id.  COMPONENT TYPE: CharacterEquipment</param>
            public DestinyResponsesDestinyProfileResponseBuilder CharacterEquipment(DictionaryComponentResponseOfint64AndDestinyInventoryComponent value)
            {
                _CharacterEquipment = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyResponsesDestinyProfileResponse.CharacterKiosks property.
            /// </summary>
            /// <param name="value">Items available from Kiosks that are available to a specific character as opposed to the account as a whole. It must be combined with data from the profileKiosks property to get a full picture of the character&#39;s available items to check out of a kiosk.  This component returns information about what Kiosk items are available to you on a *Character* level. Usually, kiosk items will be earned for the entire Profile (all characters) at once. To find those, look in the profileKiosks property.  COMPONENT TYPE: Kiosks</param>
            public DestinyResponsesDestinyProfileResponseBuilder CharacterKiosks(DictionaryComponentResponseOfint64AndDestinyKiosksComponent value)
            {
                _CharacterKiosks = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyResponsesDestinyProfileResponse.CharacterPlugSets property.
            /// </summary>
            /// <param name="value">When sockets refer to reusable Plug Sets (see DestinyPlugSetDefinition for more info), this is the set of plugs and their states, per character, that are character-scoped.  This comes back with ItemSockets, as it is needed for a complete picture of the sockets on requested items.  COMPONENT TYPE: ItemSockets</param>
            public DestinyResponsesDestinyProfileResponseBuilder CharacterPlugSets(DictionaryComponentResponseOfint64AndDestinyPlugSetsComponent value)
            {
                _CharacterPlugSets = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyResponsesDestinyProfileResponse.CharacterUninstancedItemComponents property.
            /// </summary>
            /// <param name="value">Do you ever get the feeling that a system was designed *too* flexibly? That it can be used in so many different ways that you end up being unable to provide an easy to use abstraction for the mess that&#39;s happening under the surface?  Let&#39;s talk about character-specific data that might be related to items without instances. These two statements are totally unrelated, I promise.  At some point during D2, it was decided that items - such as Bounties - could be given to characters and *not* have instance data, but that *could* display and even use relevant state information on your account and character.  Up to now, any item that had meaningful dependencies on character or account state had to be instanced, and thus \&quot;itemComponents\&quot; was all that you needed: it was keyed by item&#39;s instance IDs and provided the stateful information you needed inside.  Unfortunately, we don&#39;t live in such a magical world anymore. This is information held on a per-character basis about non-instanced items that the characters have in their inventory - or that reference character-specific state information even if it&#39;s in Account-level inventory - and the values related to that item&#39;s state in relation to the given character.  To give a concrete example, look at a Moments of Triumph bounty. They exist in a character&#39;s inventory, and show/care about a character&#39;s progression toward completing the bounty. But the bounty itself is a non-instanced item, like a mod or a currency. This returns that data for the characters who have the bounty in their inventory.  I&#39;m not crying, you&#39;re crying Okay we&#39;re both crying but it&#39;s going to be okay I promise Actually I shouldn&#39;t promise that, I don&#39;t know if it&#39;s going to be okay</param>
            public DestinyResponsesDestinyProfileResponseBuilder CharacterUninstancedItemComponents(Dictionary<string, DestinyBaseItemComponentSetOfuint32> value)
            {
                _CharacterUninstancedItemComponents = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyResponsesDestinyProfileResponse.CharacterPresentationNodes property.
            /// </summary>
            /// <param name="value">COMPONENT TYPE: PresentationNodes</param>
            public DestinyResponsesDestinyProfileResponseBuilder CharacterPresentationNodes(DictionaryComponentResponseOfint64AndDestinyPresentationNodesComponent value)
            {
                _CharacterPresentationNodes = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyResponsesDestinyProfileResponse.CharacterRecords property.
            /// </summary>
            /// <param name="value">COMPONENT TYPE: Records</param>
            public DestinyResponsesDestinyProfileResponseBuilder CharacterRecords(DictionaryComponentResponseOfint64AndDestinyCharacterRecordsComponent value)
            {
                _CharacterRecords = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyResponsesDestinyProfileResponse.CharacterCollectibles property.
            /// </summary>
            /// <param name="value">COMPONENT TYPE: Collectibles</param>
            public DestinyResponsesDestinyProfileResponseBuilder CharacterCollectibles(DictionaryComponentResponseOfint64AndDestinyCollectiblesComponent value)
            {
                _CharacterCollectibles = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyResponsesDestinyProfileResponse.ItemComponents property.
            /// </summary>
            /// <param name="value">Information about instanced items across all returned characters, keyed by the item&#39;s instance ID.  COMPONENT TYPE: [See inside the DestinyItemComponentSet contract for component types.]</param>
            public DestinyResponsesDestinyProfileResponseBuilder ItemComponents(DestinyItemComponentSetOfint64 value)
            {
                _ItemComponents = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyResponsesDestinyProfileResponse.CharacterCurrencyLookups property.
            /// </summary>
            /// <param name="value">A \&quot;lookup\&quot; convenience component that can be used to quickly check if the character has access to items that can be used for purchasing.  COMPONENT TYPE: CurrencyLookups</param>
            public DestinyResponsesDestinyProfileResponseBuilder CharacterCurrencyLookups(DictionaryComponentResponseOfint64AndDestinyCurrenciesComponent value)
            {
                _CharacterCurrencyLookups = value;
                return this;
            }


            /// <summary>
            /// Builds instance of DestinyResponsesDestinyProfileResponse.
            /// </summary>
            /// <returns>DestinyResponsesDestinyProfileResponse</returns>
            public DestinyResponsesDestinyProfileResponse Build()
            {
                Validate();
                return new DestinyResponsesDestinyProfileResponse(
                    VendorReceipts: _VendorReceipts,
                    ProfileInventory: _ProfileInventory,
                    ProfileCurrencies: _ProfileCurrencies,
                    Profile: _Profile,
                    PlatformSilver: _PlatformSilver,
                    ProfileKiosks: _ProfileKiosks,
                    ProfilePlugSets: _ProfilePlugSets,
                    ProfileProgression: _ProfileProgression,
                    ProfilePresentationNodes: _ProfilePresentationNodes,
                    ProfileRecords: _ProfileRecords,
                    ProfileCollectibles: _ProfileCollectibles,
                    ProfileTransitoryData: _ProfileTransitoryData,
                    Metrics: _Metrics,
                    Characters: _Characters,
                    CharacterInventories: _CharacterInventories,
                    CharacterProgressions: _CharacterProgressions,
                    CharacterRenderData: _CharacterRenderData,
                    CharacterActivities: _CharacterActivities,
                    CharacterEquipment: _CharacterEquipment,
                    CharacterKiosks: _CharacterKiosks,
                    CharacterPlugSets: _CharacterPlugSets,
                    CharacterUninstancedItemComponents: _CharacterUninstancedItemComponents,
                    CharacterPresentationNodes: _CharacterPresentationNodes,
                    CharacterRecords: _CharacterRecords,
                    CharacterCollectibles: _CharacterCollectibles,
                    ItemComponents: _ItemComponents,
                    CharacterCurrencyLookups: _CharacterCurrencyLookups
                );
            }

            private void Validate()
            { 
            }
        }

        
    }
}