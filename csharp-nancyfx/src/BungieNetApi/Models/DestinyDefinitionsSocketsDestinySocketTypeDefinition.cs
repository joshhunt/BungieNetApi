using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Sharpility.Extensions;
using NodaTime;

namespace BungieNetApi._Platform.Models
{
    /// <summary>
    /// All Sockets have a \&quot;Type\&quot;: a set of common properties that determine when the socket allows Plugs to be inserted, what Categories of Plugs can be inserted, and whether the socket is even visible at all given the current game/character/account state.  See DestinyInventoryItemDefinition for more information about Socketed items and Plugs.
    /// </summary>
    public sealed class DestinyDefinitionsSocketsDestinySocketTypeDefinition:  IEquatable<DestinyDefinitionsSocketsDestinySocketTypeDefinition>
    { 
        /// <summary>
        /// There are fields for this display data, but they appear to be unpopulated as of now. I am not sure where in the UI these would show if they even were populated, but I will continue to return this data in case it becomes useful.
        /// </summary>
        public DestinyDefinitionsCommonDestinyDisplayPropertiesDefinition DisplayProperties { get; private set; }

        /// <summary>
        /// Defines what happens when a plug is inserted into sockets of this type.
        /// </summary>
        public DestinyDefinitionsSocketsDestinyInsertPlugActionDefinition InsertAction { get; private set; }

        /// <summary>
        /// A list of Plug \&quot;Categories\&quot; that are allowed to be plugged into sockets of this type.  These should be compared against a given plug item&#39;s DestinyInventoryItemDefinition.plug.plugCategoryHash, which indicates the plug item&#39;s category.  If the plug&#39;s category matches any whitelisted plug, or if the whitelist is empty, it is allowed to be inserted.
        /// </summary>
        public List<DestinyDefinitionsSocketsDestinyPlugWhitelistEntryDefinition> PlugWhitelist { get; private set; }

        /// <summary>
        /// SocketCategoryHash
        /// </summary>
        public int? SocketCategoryHash { get; private set; }

        /// <summary>
        /// Sometimes a socket isn&#39;t visible. These are some of the conditions under which sockets of this type are not visible. Unfortunately, the truth of visibility is much, much more complex. Best to rely on the live data for whether the socket is visible and enabled.
        /// </summary>
        public int? Visibility { get; private set; }

        /// <summary>
        /// AlwaysRandomizeSockets
        /// </summary>
        public bool? AlwaysRandomizeSockets { get; private set; }

        /// <summary>
        /// IsPreviewEnabled
        /// </summary>
        public bool? IsPreviewEnabled { get; private set; }

        /// <summary>
        /// HideDuplicateReusablePlugs
        /// </summary>
        public bool? HideDuplicateReusablePlugs { get; private set; }

        /// <summary>
        /// This property indicates if the socket type determines whether Emblem icons and nameplates should be overridden by the inserted plug item&#39;s icon and nameplate.
        /// </summary>
        public bool? OverridesUiAppearance { get; private set; }

        /// <summary>
        /// AvoidDuplicatesOnInitialization
        /// </summary>
        public bool? AvoidDuplicatesOnInitialization { get; private set; }

        /// <summary>
        /// CurrencyScalars
        /// </summary>
        public List<DestinyDefinitionsSocketsDestinySocketTypeScalarMaterialRequirementEntry> CurrencyScalars { get; private set; }

        /// <summary>
        /// The unique identifier for this entity. Guaranteed to be unique for the type of entity, but not globally.  When entities refer to each other in Destiny content, it is this hash that they are referring to.
        /// </summary>
        public int? Hash { get; private set; }

        /// <summary>
        /// The index of the entity as it was found in the investment tables.
        /// </summary>
        public int? Index { get; private set; }

        /// <summary>
        /// If this is true, then there is an entity with this identifier/type combination, but BNet is not yet allowed to show it. Sorry!
        /// </summary>
        public bool? Redacted { get; private set; }


        /// <summary>
        /// Empty constructor required by some serializers.
        /// Use DestinyDefinitionsSocketsDestinySocketTypeDefinition.Builder() for instance creation instead.
        /// </summary>
        [Obsolete]
        public DestinyDefinitionsSocketsDestinySocketTypeDefinition()
        {
        }

        private DestinyDefinitionsSocketsDestinySocketTypeDefinition(DestinyDefinitionsCommonDestinyDisplayPropertiesDefinition DisplayProperties, DestinyDefinitionsSocketsDestinyInsertPlugActionDefinition InsertAction, List<DestinyDefinitionsSocketsDestinyPlugWhitelistEntryDefinition> PlugWhitelist, int? SocketCategoryHash, int? Visibility, bool? AlwaysRandomizeSockets, bool? IsPreviewEnabled, bool? HideDuplicateReusablePlugs, bool? OverridesUiAppearance, bool? AvoidDuplicatesOnInitialization, List<DestinyDefinitionsSocketsDestinySocketTypeScalarMaterialRequirementEntry> CurrencyScalars, int? Hash, int? Index, bool? Redacted)
        {
            
            this.DisplayProperties = DisplayProperties;
            
            this.InsertAction = InsertAction;
            
            this.PlugWhitelist = PlugWhitelist;
            
            this.SocketCategoryHash = SocketCategoryHash;
            
            this.Visibility = Visibility;
            
            this.AlwaysRandomizeSockets = AlwaysRandomizeSockets;
            
            this.IsPreviewEnabled = IsPreviewEnabled;
            
            this.HideDuplicateReusablePlugs = HideDuplicateReusablePlugs;
            
            this.OverridesUiAppearance = OverridesUiAppearance;
            
            this.AvoidDuplicatesOnInitialization = AvoidDuplicatesOnInitialization;
            
            this.CurrencyScalars = CurrencyScalars;
            
            this.Hash = Hash;
            
            this.Index = Index;
            
            this.Redacted = Redacted;
            
        }

        /// <summary>
        /// Returns builder of DestinyDefinitionsSocketsDestinySocketTypeDefinition.
        /// </summary>
        /// <returns>DestinyDefinitionsSocketsDestinySocketTypeDefinitionBuilder</returns>
        public static DestinyDefinitionsSocketsDestinySocketTypeDefinitionBuilder Builder()
        {
            return new DestinyDefinitionsSocketsDestinySocketTypeDefinitionBuilder();
        }

        /// <summary>
        /// Returns DestinyDefinitionsSocketsDestinySocketTypeDefinitionBuilder with properties set.
        /// Use it to change properties.
        /// </summary>
        /// <returns>DestinyDefinitionsSocketsDestinySocketTypeDefinitionBuilder</returns>
        public DestinyDefinitionsSocketsDestinySocketTypeDefinitionBuilder With()
        {
            return Builder()
                .DisplayProperties(DisplayProperties)
                .InsertAction(InsertAction)
                .PlugWhitelist(PlugWhitelist)
                .SocketCategoryHash(SocketCategoryHash)
                .Visibility(Visibility)
                .AlwaysRandomizeSockets(AlwaysRandomizeSockets)
                .IsPreviewEnabled(IsPreviewEnabled)
                .HideDuplicateReusablePlugs(HideDuplicateReusablePlugs)
                .OverridesUiAppearance(OverridesUiAppearance)
                .AvoidDuplicatesOnInitialization(AvoidDuplicatesOnInitialization)
                .CurrencyScalars(CurrencyScalars)
                .Hash(Hash)
                .Index(Index)
                .Redacted(Redacted);
        }

        public override string ToString()
        {
            return this.PropertiesToString();
        }

        public override bool Equals(object obj)
        {
            return this.EqualsByProperties(obj);
        }

        public bool Equals(DestinyDefinitionsSocketsDestinySocketTypeDefinition other)
        {
            return Equals((object) other);
        }

        public override int GetHashCode()
        {
            return this.PropertiesHash();
        }

        /// <summary>
        /// Implementation of == operator for (DestinyDefinitionsSocketsDestinySocketTypeDefinition.
        /// </summary>
        /// <param name="left">Compared (DestinyDefinitionsSocketsDestinySocketTypeDefinition</param>
        /// <param name="right">Compared (DestinyDefinitionsSocketsDestinySocketTypeDefinition</param>
        /// <returns>true if compared items are equals, false otherwise</returns>
        public static bool operator == (DestinyDefinitionsSocketsDestinySocketTypeDefinition left, DestinyDefinitionsSocketsDestinySocketTypeDefinition right)
        {
            return Equals(left, right);
        }

        /// <summary>
        /// Implementation of != operator for (DestinyDefinitionsSocketsDestinySocketTypeDefinition.
        /// </summary>
        /// <param name="left">Compared (DestinyDefinitionsSocketsDestinySocketTypeDefinition</param>
        /// <param name="right">Compared (DestinyDefinitionsSocketsDestinySocketTypeDefinition</param>
        /// <returns>true if compared items are not equals, false otherwise</returns>
        public static bool operator != (DestinyDefinitionsSocketsDestinySocketTypeDefinition left, DestinyDefinitionsSocketsDestinySocketTypeDefinition right)
        {
            return !Equals(left, right);
        }

        /// <summary>
        /// Builder of DestinyDefinitionsSocketsDestinySocketTypeDefinition.
        /// </summary>
        public sealed class DestinyDefinitionsSocketsDestinySocketTypeDefinitionBuilder
        {
            private DestinyDefinitionsCommonDestinyDisplayPropertiesDefinition _DisplayProperties;
            private DestinyDefinitionsSocketsDestinyInsertPlugActionDefinition _InsertAction;
            private List<DestinyDefinitionsSocketsDestinyPlugWhitelistEntryDefinition> _PlugWhitelist;
            private int? _SocketCategoryHash;
            private int? _Visibility;
            private bool? _AlwaysRandomizeSockets;
            private bool? _IsPreviewEnabled;
            private bool? _HideDuplicateReusablePlugs;
            private bool? _OverridesUiAppearance;
            private bool? _AvoidDuplicatesOnInitialization;
            private List<DestinyDefinitionsSocketsDestinySocketTypeScalarMaterialRequirementEntry> _CurrencyScalars;
            private int? _Hash;
            private int? _Index;
            private bool? _Redacted;

            internal DestinyDefinitionsSocketsDestinySocketTypeDefinitionBuilder()
            {
                SetupDefaults();
            }

            private void SetupDefaults()
            {
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsSocketsDestinySocketTypeDefinition.DisplayProperties property.
            /// </summary>
            /// <param name="value">There are fields for this display data, but they appear to be unpopulated as of now. I am not sure where in the UI these would show if they even were populated, but I will continue to return this data in case it becomes useful.</param>
            public DestinyDefinitionsSocketsDestinySocketTypeDefinitionBuilder DisplayProperties(DestinyDefinitionsCommonDestinyDisplayPropertiesDefinition value)
            {
                _DisplayProperties = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsSocketsDestinySocketTypeDefinition.InsertAction property.
            /// </summary>
            /// <param name="value">Defines what happens when a plug is inserted into sockets of this type.</param>
            public DestinyDefinitionsSocketsDestinySocketTypeDefinitionBuilder InsertAction(DestinyDefinitionsSocketsDestinyInsertPlugActionDefinition value)
            {
                _InsertAction = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsSocketsDestinySocketTypeDefinition.PlugWhitelist property.
            /// </summary>
            /// <param name="value">A list of Plug \&quot;Categories\&quot; that are allowed to be plugged into sockets of this type.  These should be compared against a given plug item&#39;s DestinyInventoryItemDefinition.plug.plugCategoryHash, which indicates the plug item&#39;s category.  If the plug&#39;s category matches any whitelisted plug, or if the whitelist is empty, it is allowed to be inserted.</param>
            public DestinyDefinitionsSocketsDestinySocketTypeDefinitionBuilder PlugWhitelist(List<DestinyDefinitionsSocketsDestinyPlugWhitelistEntryDefinition> value)
            {
                _PlugWhitelist = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsSocketsDestinySocketTypeDefinition.SocketCategoryHash property.
            /// </summary>
            /// <param name="value">SocketCategoryHash</param>
            public DestinyDefinitionsSocketsDestinySocketTypeDefinitionBuilder SocketCategoryHash(int? value)
            {
                _SocketCategoryHash = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsSocketsDestinySocketTypeDefinition.Visibility property.
            /// </summary>
            /// <param name="value">Sometimes a socket isn&#39;t visible. These are some of the conditions under which sockets of this type are not visible. Unfortunately, the truth of visibility is much, much more complex. Best to rely on the live data for whether the socket is visible and enabled.</param>
            public DestinyDefinitionsSocketsDestinySocketTypeDefinitionBuilder Visibility(int? value)
            {
                _Visibility = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsSocketsDestinySocketTypeDefinition.AlwaysRandomizeSockets property.
            /// </summary>
            /// <param name="value">AlwaysRandomizeSockets</param>
            public DestinyDefinitionsSocketsDestinySocketTypeDefinitionBuilder AlwaysRandomizeSockets(bool? value)
            {
                _AlwaysRandomizeSockets = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsSocketsDestinySocketTypeDefinition.IsPreviewEnabled property.
            /// </summary>
            /// <param name="value">IsPreviewEnabled</param>
            public DestinyDefinitionsSocketsDestinySocketTypeDefinitionBuilder IsPreviewEnabled(bool? value)
            {
                _IsPreviewEnabled = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsSocketsDestinySocketTypeDefinition.HideDuplicateReusablePlugs property.
            /// </summary>
            /// <param name="value">HideDuplicateReusablePlugs</param>
            public DestinyDefinitionsSocketsDestinySocketTypeDefinitionBuilder HideDuplicateReusablePlugs(bool? value)
            {
                _HideDuplicateReusablePlugs = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsSocketsDestinySocketTypeDefinition.OverridesUiAppearance property.
            /// </summary>
            /// <param name="value">This property indicates if the socket type determines whether Emblem icons and nameplates should be overridden by the inserted plug item&#39;s icon and nameplate.</param>
            public DestinyDefinitionsSocketsDestinySocketTypeDefinitionBuilder OverridesUiAppearance(bool? value)
            {
                _OverridesUiAppearance = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsSocketsDestinySocketTypeDefinition.AvoidDuplicatesOnInitialization property.
            /// </summary>
            /// <param name="value">AvoidDuplicatesOnInitialization</param>
            public DestinyDefinitionsSocketsDestinySocketTypeDefinitionBuilder AvoidDuplicatesOnInitialization(bool? value)
            {
                _AvoidDuplicatesOnInitialization = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsSocketsDestinySocketTypeDefinition.CurrencyScalars property.
            /// </summary>
            /// <param name="value">CurrencyScalars</param>
            public DestinyDefinitionsSocketsDestinySocketTypeDefinitionBuilder CurrencyScalars(List<DestinyDefinitionsSocketsDestinySocketTypeScalarMaterialRequirementEntry> value)
            {
                _CurrencyScalars = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsSocketsDestinySocketTypeDefinition.Hash property.
            /// </summary>
            /// <param name="value">The unique identifier for this entity. Guaranteed to be unique for the type of entity, but not globally.  When entities refer to each other in Destiny content, it is this hash that they are referring to.</param>
            public DestinyDefinitionsSocketsDestinySocketTypeDefinitionBuilder Hash(int? value)
            {
                _Hash = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsSocketsDestinySocketTypeDefinition.Index property.
            /// </summary>
            /// <param name="value">The index of the entity as it was found in the investment tables.</param>
            public DestinyDefinitionsSocketsDestinySocketTypeDefinitionBuilder Index(int? value)
            {
                _Index = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsSocketsDestinySocketTypeDefinition.Redacted property.
            /// </summary>
            /// <param name="value">If this is true, then there is an entity with this identifier/type combination, but BNet is not yet allowed to show it. Sorry!</param>
            public DestinyDefinitionsSocketsDestinySocketTypeDefinitionBuilder Redacted(bool? value)
            {
                _Redacted = value;
                return this;
            }


            /// <summary>
            /// Builds instance of DestinyDefinitionsSocketsDestinySocketTypeDefinition.
            /// </summary>
            /// <returns>DestinyDefinitionsSocketsDestinySocketTypeDefinition</returns>
            public DestinyDefinitionsSocketsDestinySocketTypeDefinition Build()
            {
                Validate();
                return new DestinyDefinitionsSocketsDestinySocketTypeDefinition(
                    DisplayProperties: _DisplayProperties,
                    InsertAction: _InsertAction,
                    PlugWhitelist: _PlugWhitelist,
                    SocketCategoryHash: _SocketCategoryHash,
                    Visibility: _Visibility,
                    AlwaysRandomizeSockets: _AlwaysRandomizeSockets,
                    IsPreviewEnabled: _IsPreviewEnabled,
                    HideDuplicateReusablePlugs: _HideDuplicateReusablePlugs,
                    OverridesUiAppearance: _OverridesUiAppearance,
                    AvoidDuplicatesOnInitialization: _AvoidDuplicatesOnInitialization,
                    CurrencyScalars: _CurrencyScalars,
                    Hash: _Hash,
                    Index: _Index,
                    Redacted: _Redacted
                );
            }

            private void Validate()
            { 
            }
        }

        
    }
}