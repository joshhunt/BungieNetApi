using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Sharpility.Extensions;
using NodaTime;

namespace BungieNetApi._Platform.Models
{
    /// <summary>
    /// The definition information for a specific socket on an item. This will determine how the socket behaves in-game.
    /// </summary>
    public sealed class DestinyDefinitionsDestinyItemSocketEntryDefinition:  IEquatable<DestinyDefinitionsDestinyItemSocketEntryDefinition>
    { 
        /// <summary>
        /// All sockets have a type, and this is the hash identifier for this particular type. Use it to look up the DestinySocketTypeDefinition: read there for more information on how socket types affect the behavior of the socket.
        /// </summary>
        public int? SocketTypeHash { get; private set; }

        /// <summary>
        /// If a valid hash, this is the hash identifier for the DestinyInventoryItemDefinition representing the Plug that will be initially inserted into the item on item creation. Otherwise, this Socket will either start without a plug inserted, or will have one randomly inserted.
        /// </summary>
        public int? SingleInitialItemHash { get; private set; }

        /// <summary>
        /// This is a list of pre-determined plugs that can *always* be plugged into this socket, without the character having the plug in their inventory.  If this list is populated, you will not be allowed to plug an arbitrary item in the socket: you will only be able to choose from one of these reusable plugs.
        /// </summary>
        public List<DestinyDefinitionsDestinyItemSocketEntryPlugItemDefinition> ReusablePlugItems { get; private set; }

        /// <summary>
        /// If this is true, then the socket will not be initialized with a plug if the item is purchased from a Vendor.  Remember that Vendors are much more than conceptual vendors: they include \&quot;Collection Kiosks\&quot; and other entities. See DestinyVendorDefinition for more information.
        /// </summary>
        public bool? PreventInitializationOnVendorPurchase { get; private set; }

        /// <summary>
        /// If this is true, the perks provided by this socket shouldn&#39;t be shown in the item&#39;s tooltip. This might be useful if it&#39;s providing a hidden bonus, or if the bonus is less important than other benefits on the item.
        /// </summary>
        public bool? HidePerksInItemTooltip { get; private set; }

        /// <summary>
        /// Indicates where you should go to get plugs for this socket. This will affect how you populate your UI, as well as what plugs are valid for this socket. It&#39;s an alternative to having to check for the existence of certain properties (reusablePlugItems for example) to infer where plugs should come from.
        /// </summary>
        public int? PlugSources { get; private set; }

        /// <summary>
        /// If this socket&#39;s plugs come from a reusable DestinyPlugSetDefinition, this is the identifier for that set. We added this concept to reduce some major duplication that&#39;s going to come from sockets as replacements for what was once implemented as large sets of items and kiosks (like Emotes).   As of Shadowkeep, these will come up much more frequently and be driven by game content rather than custom curation.
        /// </summary>
        public int? ReusablePlugSetHash { get; private set; }

        /// <summary>
        /// This field replaces \&quot;randomizedPlugItems\&quot; as of Shadowkeep launch. If a socket has randomized plugs, this is a pointer to the set of plugs that could be used, as defined in DestinyPlugSetDefinition.   If null, the item has no randomized plugs.
        /// </summary>
        public int? RandomizedPlugSetHash { get; private set; }

        /// <summary>
        /// If true, then this socket is visible in the item&#39;s \&quot;default\&quot; state. If you have an instance, you should always check the runtime state, as that can override this visibility setting: but if you&#39;re looking at the item on a conceptual level, this property can be useful for hiding data such as legacy sockets - which remain defined on items for infrastructure purposes, but can be confusing for users to see.
        /// </summary>
        public bool? DefaultVisible { get; private set; }


        /// <summary>
        /// Empty constructor required by some serializers.
        /// Use DestinyDefinitionsDestinyItemSocketEntryDefinition.Builder() for instance creation instead.
        /// </summary>
        [Obsolete]
        public DestinyDefinitionsDestinyItemSocketEntryDefinition()
        {
        }

        private DestinyDefinitionsDestinyItemSocketEntryDefinition(int? SocketTypeHash, int? SingleInitialItemHash, List<DestinyDefinitionsDestinyItemSocketEntryPlugItemDefinition> ReusablePlugItems, bool? PreventInitializationOnVendorPurchase, bool? HidePerksInItemTooltip, int? PlugSources, int? ReusablePlugSetHash, int? RandomizedPlugSetHash, bool? DefaultVisible)
        {
            
            this.SocketTypeHash = SocketTypeHash;
            
            this.SingleInitialItemHash = SingleInitialItemHash;
            
            this.ReusablePlugItems = ReusablePlugItems;
            
            this.PreventInitializationOnVendorPurchase = PreventInitializationOnVendorPurchase;
            
            this.HidePerksInItemTooltip = HidePerksInItemTooltip;
            
            this.PlugSources = PlugSources;
            
            this.ReusablePlugSetHash = ReusablePlugSetHash;
            
            this.RandomizedPlugSetHash = RandomizedPlugSetHash;
            
            this.DefaultVisible = DefaultVisible;
            
        }

        /// <summary>
        /// Returns builder of DestinyDefinitionsDestinyItemSocketEntryDefinition.
        /// </summary>
        /// <returns>DestinyDefinitionsDestinyItemSocketEntryDefinitionBuilder</returns>
        public static DestinyDefinitionsDestinyItemSocketEntryDefinitionBuilder Builder()
        {
            return new DestinyDefinitionsDestinyItemSocketEntryDefinitionBuilder();
        }

        /// <summary>
        /// Returns DestinyDefinitionsDestinyItemSocketEntryDefinitionBuilder with properties set.
        /// Use it to change properties.
        /// </summary>
        /// <returns>DestinyDefinitionsDestinyItemSocketEntryDefinitionBuilder</returns>
        public DestinyDefinitionsDestinyItemSocketEntryDefinitionBuilder With()
        {
            return Builder()
                .SocketTypeHash(SocketTypeHash)
                .SingleInitialItemHash(SingleInitialItemHash)
                .ReusablePlugItems(ReusablePlugItems)
                .PreventInitializationOnVendorPurchase(PreventInitializationOnVendorPurchase)
                .HidePerksInItemTooltip(HidePerksInItemTooltip)
                .PlugSources(PlugSources)
                .ReusablePlugSetHash(ReusablePlugSetHash)
                .RandomizedPlugSetHash(RandomizedPlugSetHash)
                .DefaultVisible(DefaultVisible);
        }

        public override string ToString()
        {
            return this.PropertiesToString();
        }

        public override bool Equals(object obj)
        {
            return this.EqualsByProperties(obj);
        }

        public bool Equals(DestinyDefinitionsDestinyItemSocketEntryDefinition other)
        {
            return Equals((object) other);
        }

        public override int GetHashCode()
        {
            return this.PropertiesHash();
        }

        /// <summary>
        /// Implementation of == operator for (DestinyDefinitionsDestinyItemSocketEntryDefinition.
        /// </summary>
        /// <param name="left">Compared (DestinyDefinitionsDestinyItemSocketEntryDefinition</param>
        /// <param name="right">Compared (DestinyDefinitionsDestinyItemSocketEntryDefinition</param>
        /// <returns>true if compared items are equals, false otherwise</returns>
        public static bool operator == (DestinyDefinitionsDestinyItemSocketEntryDefinition left, DestinyDefinitionsDestinyItemSocketEntryDefinition right)
        {
            return Equals(left, right);
        }

        /// <summary>
        /// Implementation of != operator for (DestinyDefinitionsDestinyItemSocketEntryDefinition.
        /// </summary>
        /// <param name="left">Compared (DestinyDefinitionsDestinyItemSocketEntryDefinition</param>
        /// <param name="right">Compared (DestinyDefinitionsDestinyItemSocketEntryDefinition</param>
        /// <returns>true if compared items are not equals, false otherwise</returns>
        public static bool operator != (DestinyDefinitionsDestinyItemSocketEntryDefinition left, DestinyDefinitionsDestinyItemSocketEntryDefinition right)
        {
            return !Equals(left, right);
        }

        /// <summary>
        /// Builder of DestinyDefinitionsDestinyItemSocketEntryDefinition.
        /// </summary>
        public sealed class DestinyDefinitionsDestinyItemSocketEntryDefinitionBuilder
        {
            private int? _SocketTypeHash;
            private int? _SingleInitialItemHash;
            private List<DestinyDefinitionsDestinyItemSocketEntryPlugItemDefinition> _ReusablePlugItems;
            private bool? _PreventInitializationOnVendorPurchase;
            private bool? _HidePerksInItemTooltip;
            private int? _PlugSources;
            private int? _ReusablePlugSetHash;
            private int? _RandomizedPlugSetHash;
            private bool? _DefaultVisible;

            internal DestinyDefinitionsDestinyItemSocketEntryDefinitionBuilder()
            {
                SetupDefaults();
            }

            private void SetupDefaults()
            {
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsDestinyItemSocketEntryDefinition.SocketTypeHash property.
            /// </summary>
            /// <param name="value">All sockets have a type, and this is the hash identifier for this particular type. Use it to look up the DestinySocketTypeDefinition: read there for more information on how socket types affect the behavior of the socket.</param>
            public DestinyDefinitionsDestinyItemSocketEntryDefinitionBuilder SocketTypeHash(int? value)
            {
                _SocketTypeHash = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsDestinyItemSocketEntryDefinition.SingleInitialItemHash property.
            /// </summary>
            /// <param name="value">If a valid hash, this is the hash identifier for the DestinyInventoryItemDefinition representing the Plug that will be initially inserted into the item on item creation. Otherwise, this Socket will either start without a plug inserted, or will have one randomly inserted.</param>
            public DestinyDefinitionsDestinyItemSocketEntryDefinitionBuilder SingleInitialItemHash(int? value)
            {
                _SingleInitialItemHash = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsDestinyItemSocketEntryDefinition.ReusablePlugItems property.
            /// </summary>
            /// <param name="value">This is a list of pre-determined plugs that can *always* be plugged into this socket, without the character having the plug in their inventory.  If this list is populated, you will not be allowed to plug an arbitrary item in the socket: you will only be able to choose from one of these reusable plugs.</param>
            public DestinyDefinitionsDestinyItemSocketEntryDefinitionBuilder ReusablePlugItems(List<DestinyDefinitionsDestinyItemSocketEntryPlugItemDefinition> value)
            {
                _ReusablePlugItems = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsDestinyItemSocketEntryDefinition.PreventInitializationOnVendorPurchase property.
            /// </summary>
            /// <param name="value">If this is true, then the socket will not be initialized with a plug if the item is purchased from a Vendor.  Remember that Vendors are much more than conceptual vendors: they include \&quot;Collection Kiosks\&quot; and other entities. See DestinyVendorDefinition for more information.</param>
            public DestinyDefinitionsDestinyItemSocketEntryDefinitionBuilder PreventInitializationOnVendorPurchase(bool? value)
            {
                _PreventInitializationOnVendorPurchase = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsDestinyItemSocketEntryDefinition.HidePerksInItemTooltip property.
            /// </summary>
            /// <param name="value">If this is true, the perks provided by this socket shouldn&#39;t be shown in the item&#39;s tooltip. This might be useful if it&#39;s providing a hidden bonus, or if the bonus is less important than other benefits on the item.</param>
            public DestinyDefinitionsDestinyItemSocketEntryDefinitionBuilder HidePerksInItemTooltip(bool? value)
            {
                _HidePerksInItemTooltip = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsDestinyItemSocketEntryDefinition.PlugSources property.
            /// </summary>
            /// <param name="value">Indicates where you should go to get plugs for this socket. This will affect how you populate your UI, as well as what plugs are valid for this socket. It&#39;s an alternative to having to check for the existence of certain properties (reusablePlugItems for example) to infer where plugs should come from.</param>
            public DestinyDefinitionsDestinyItemSocketEntryDefinitionBuilder PlugSources(int? value)
            {
                _PlugSources = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsDestinyItemSocketEntryDefinition.ReusablePlugSetHash property.
            /// </summary>
            /// <param name="value">If this socket&#39;s plugs come from a reusable DestinyPlugSetDefinition, this is the identifier for that set. We added this concept to reduce some major duplication that&#39;s going to come from sockets as replacements for what was once implemented as large sets of items and kiosks (like Emotes).   As of Shadowkeep, these will come up much more frequently and be driven by game content rather than custom curation.</param>
            public DestinyDefinitionsDestinyItemSocketEntryDefinitionBuilder ReusablePlugSetHash(int? value)
            {
                _ReusablePlugSetHash = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsDestinyItemSocketEntryDefinition.RandomizedPlugSetHash property.
            /// </summary>
            /// <param name="value">This field replaces \&quot;randomizedPlugItems\&quot; as of Shadowkeep launch. If a socket has randomized plugs, this is a pointer to the set of plugs that could be used, as defined in DestinyPlugSetDefinition.   If null, the item has no randomized plugs.</param>
            public DestinyDefinitionsDestinyItemSocketEntryDefinitionBuilder RandomizedPlugSetHash(int? value)
            {
                _RandomizedPlugSetHash = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsDestinyItemSocketEntryDefinition.DefaultVisible property.
            /// </summary>
            /// <param name="value">If true, then this socket is visible in the item&#39;s \&quot;default\&quot; state. If you have an instance, you should always check the runtime state, as that can override this visibility setting: but if you&#39;re looking at the item on a conceptual level, this property can be useful for hiding data such as legacy sockets - which remain defined on items for infrastructure purposes, but can be confusing for users to see.</param>
            public DestinyDefinitionsDestinyItemSocketEntryDefinitionBuilder DefaultVisible(bool? value)
            {
                _DefaultVisible = value;
                return this;
            }


            /// <summary>
            /// Builds instance of DestinyDefinitionsDestinyItemSocketEntryDefinition.
            /// </summary>
            /// <returns>DestinyDefinitionsDestinyItemSocketEntryDefinition</returns>
            public DestinyDefinitionsDestinyItemSocketEntryDefinition Build()
            {
                Validate();
                return new DestinyDefinitionsDestinyItemSocketEntryDefinition(
                    SocketTypeHash: _SocketTypeHash,
                    SingleInitialItemHash: _SingleInitialItemHash,
                    ReusablePlugItems: _ReusablePlugItems,
                    PreventInitializationOnVendorPurchase: _PreventInitializationOnVendorPurchase,
                    HidePerksInItemTooltip: _HidePerksInItemTooltip,
                    PlugSources: _PlugSources,
                    ReusablePlugSetHash: _ReusablePlugSetHash,
                    RandomizedPlugSetHash: _RandomizedPlugSetHash,
                    DefaultVisible: _DefaultVisible
                );
            }

            private void Validate()
            { 
            }
        }

        
    }
}