using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Sharpility.Extensions;
using NodaTime;

namespace BungieNetApi._Platform.Models
{
    /// <summary>
    /// The properties of an individual checklist item. Note that almost everything is optional: it is *highly* variable what kind of data we&#39;ll actually be able to return: at times we may have no other relationships to entities at all.  Whatever UI you build, do it with the knowledge that any given entry might not actually be able to be associated with some other Destiny entity.
    /// </summary>
    public sealed class DestinyDefinitionsChecklistsDestinyChecklistEntryDefinition:  IEquatable<DestinyDefinitionsChecklistsDestinyChecklistEntryDefinition>
    { 
        /// <summary>
        /// The identifier for this Checklist entry. Guaranteed unique only within this Checklist Definition, and not globally/for all checklists.
        /// </summary>
        public int? Hash { get; private set; }

        /// <summary>
        /// Even if no other associations exist, we will give you *something* for display properties. In cases where we have no associated entities, it may be as simple as a numerical identifier.
        /// </summary>
        public DestinyDefinitionsCommonDestinyDisplayPropertiesDefinition DisplayProperties { get; private set; }

        /// <summary>
        /// DestinationHash
        /// </summary>
        public int? DestinationHash { get; private set; }

        /// <summary>
        /// LocationHash
        /// </summary>
        public int? LocationHash { get; private set; }

        /// <summary>
        /// Note that a Bubble&#39;s hash doesn&#39;t uniquely identify a \&quot;top level\&quot; entity in Destiny. Only the combination of location and bubble can uniquely identify a place in the world of Destiny: so if bubbleHash is populated, locationHash must too be populated for it to have any meaning.  You can use this property if it is populated to look up the DestinyLocationDefinition&#39;s associated .locationReleases[].activityBubbleName property.
        /// </summary>
        public int? BubbleHash { get; private set; }

        /// <summary>
        /// ActivityHash
        /// </summary>
        public int? ActivityHash { get; private set; }

        /// <summary>
        /// ItemHash
        /// </summary>
        public int? ItemHash { get; private set; }

        /// <summary>
        /// VendorHash
        /// </summary>
        public int? VendorHash { get; private set; }

        /// <summary>
        /// VendorInteractionIndex
        /// </summary>
        public int? VendorInteractionIndex { get; private set; }

        /// <summary>
        /// The scope at which this specific entry can be computed.
        /// </summary>
        public int? Scope { get; private set; }


        /// <summary>
        /// Empty constructor required by some serializers.
        /// Use DestinyDefinitionsChecklistsDestinyChecklistEntryDefinition.Builder() for instance creation instead.
        /// </summary>
        [Obsolete]
        public DestinyDefinitionsChecklistsDestinyChecklistEntryDefinition()
        {
        }

        private DestinyDefinitionsChecklistsDestinyChecklistEntryDefinition(int? Hash, DestinyDefinitionsCommonDestinyDisplayPropertiesDefinition DisplayProperties, int? DestinationHash, int? LocationHash, int? BubbleHash, int? ActivityHash, int? ItemHash, int? VendorHash, int? VendorInteractionIndex, int? Scope)
        {
            
            this.Hash = Hash;
            
            this.DisplayProperties = DisplayProperties;
            
            this.DestinationHash = DestinationHash;
            
            this.LocationHash = LocationHash;
            
            this.BubbleHash = BubbleHash;
            
            this.ActivityHash = ActivityHash;
            
            this.ItemHash = ItemHash;
            
            this.VendorHash = VendorHash;
            
            this.VendorInteractionIndex = VendorInteractionIndex;
            
            this.Scope = Scope;
            
        }

        /// <summary>
        /// Returns builder of DestinyDefinitionsChecklistsDestinyChecklistEntryDefinition.
        /// </summary>
        /// <returns>DestinyDefinitionsChecklistsDestinyChecklistEntryDefinitionBuilder</returns>
        public static DestinyDefinitionsChecklistsDestinyChecklistEntryDefinitionBuilder Builder()
        {
            return new DestinyDefinitionsChecklistsDestinyChecklistEntryDefinitionBuilder();
        }

        /// <summary>
        /// Returns DestinyDefinitionsChecklistsDestinyChecklistEntryDefinitionBuilder with properties set.
        /// Use it to change properties.
        /// </summary>
        /// <returns>DestinyDefinitionsChecklistsDestinyChecklistEntryDefinitionBuilder</returns>
        public DestinyDefinitionsChecklistsDestinyChecklistEntryDefinitionBuilder With()
        {
            return Builder()
                .Hash(Hash)
                .DisplayProperties(DisplayProperties)
                .DestinationHash(DestinationHash)
                .LocationHash(LocationHash)
                .BubbleHash(BubbleHash)
                .ActivityHash(ActivityHash)
                .ItemHash(ItemHash)
                .VendorHash(VendorHash)
                .VendorInteractionIndex(VendorInteractionIndex)
                .Scope(Scope);
        }

        public override string ToString()
        {
            return this.PropertiesToString();
        }

        public override bool Equals(object obj)
        {
            return this.EqualsByProperties(obj);
        }

        public bool Equals(DestinyDefinitionsChecklistsDestinyChecklistEntryDefinition other)
        {
            return Equals((object) other);
        }

        public override int GetHashCode()
        {
            return this.PropertiesHash();
        }

        /// <summary>
        /// Implementation of == operator for (DestinyDefinitionsChecklistsDestinyChecklistEntryDefinition.
        /// </summary>
        /// <param name="left">Compared (DestinyDefinitionsChecklistsDestinyChecklistEntryDefinition</param>
        /// <param name="right">Compared (DestinyDefinitionsChecklistsDestinyChecklistEntryDefinition</param>
        /// <returns>true if compared items are equals, false otherwise</returns>
        public static bool operator == (DestinyDefinitionsChecklistsDestinyChecklistEntryDefinition left, DestinyDefinitionsChecklistsDestinyChecklistEntryDefinition right)
        {
            return Equals(left, right);
        }

        /// <summary>
        /// Implementation of != operator for (DestinyDefinitionsChecklistsDestinyChecklistEntryDefinition.
        /// </summary>
        /// <param name="left">Compared (DestinyDefinitionsChecklistsDestinyChecklistEntryDefinition</param>
        /// <param name="right">Compared (DestinyDefinitionsChecklistsDestinyChecklistEntryDefinition</param>
        /// <returns>true if compared items are not equals, false otherwise</returns>
        public static bool operator != (DestinyDefinitionsChecklistsDestinyChecklistEntryDefinition left, DestinyDefinitionsChecklistsDestinyChecklistEntryDefinition right)
        {
            return !Equals(left, right);
        }

        /// <summary>
        /// Builder of DestinyDefinitionsChecklistsDestinyChecklistEntryDefinition.
        /// </summary>
        public sealed class DestinyDefinitionsChecklistsDestinyChecklistEntryDefinitionBuilder
        {
            private int? _Hash;
            private DestinyDefinitionsCommonDestinyDisplayPropertiesDefinition _DisplayProperties;
            private int? _DestinationHash;
            private int? _LocationHash;
            private int? _BubbleHash;
            private int? _ActivityHash;
            private int? _ItemHash;
            private int? _VendorHash;
            private int? _VendorInteractionIndex;
            private int? _Scope;

            internal DestinyDefinitionsChecklistsDestinyChecklistEntryDefinitionBuilder()
            {
                SetupDefaults();
            }

            private void SetupDefaults()
            {
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsChecklistsDestinyChecklistEntryDefinition.Hash property.
            /// </summary>
            /// <param name="value">The identifier for this Checklist entry. Guaranteed unique only within this Checklist Definition, and not globally/for all checklists.</param>
            public DestinyDefinitionsChecklistsDestinyChecklistEntryDefinitionBuilder Hash(int? value)
            {
                _Hash = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsChecklistsDestinyChecklistEntryDefinition.DisplayProperties property.
            /// </summary>
            /// <param name="value">Even if no other associations exist, we will give you *something* for display properties. In cases where we have no associated entities, it may be as simple as a numerical identifier.</param>
            public DestinyDefinitionsChecklistsDestinyChecklistEntryDefinitionBuilder DisplayProperties(DestinyDefinitionsCommonDestinyDisplayPropertiesDefinition value)
            {
                _DisplayProperties = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsChecklistsDestinyChecklistEntryDefinition.DestinationHash property.
            /// </summary>
            /// <param name="value">DestinationHash</param>
            public DestinyDefinitionsChecklistsDestinyChecklistEntryDefinitionBuilder DestinationHash(int? value)
            {
                _DestinationHash = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsChecklistsDestinyChecklistEntryDefinition.LocationHash property.
            /// </summary>
            /// <param name="value">LocationHash</param>
            public DestinyDefinitionsChecklistsDestinyChecklistEntryDefinitionBuilder LocationHash(int? value)
            {
                _LocationHash = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsChecklistsDestinyChecklistEntryDefinition.BubbleHash property.
            /// </summary>
            /// <param name="value">Note that a Bubble&#39;s hash doesn&#39;t uniquely identify a \&quot;top level\&quot; entity in Destiny. Only the combination of location and bubble can uniquely identify a place in the world of Destiny: so if bubbleHash is populated, locationHash must too be populated for it to have any meaning.  You can use this property if it is populated to look up the DestinyLocationDefinition&#39;s associated .locationReleases[].activityBubbleName property.</param>
            public DestinyDefinitionsChecklistsDestinyChecklistEntryDefinitionBuilder BubbleHash(int? value)
            {
                _BubbleHash = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsChecklistsDestinyChecklistEntryDefinition.ActivityHash property.
            /// </summary>
            /// <param name="value">ActivityHash</param>
            public DestinyDefinitionsChecklistsDestinyChecklistEntryDefinitionBuilder ActivityHash(int? value)
            {
                _ActivityHash = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsChecklistsDestinyChecklistEntryDefinition.ItemHash property.
            /// </summary>
            /// <param name="value">ItemHash</param>
            public DestinyDefinitionsChecklistsDestinyChecklistEntryDefinitionBuilder ItemHash(int? value)
            {
                _ItemHash = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsChecklistsDestinyChecklistEntryDefinition.VendorHash property.
            /// </summary>
            /// <param name="value">VendorHash</param>
            public DestinyDefinitionsChecklistsDestinyChecklistEntryDefinitionBuilder VendorHash(int? value)
            {
                _VendorHash = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsChecklistsDestinyChecklistEntryDefinition.VendorInteractionIndex property.
            /// </summary>
            /// <param name="value">VendorInteractionIndex</param>
            public DestinyDefinitionsChecklistsDestinyChecklistEntryDefinitionBuilder VendorInteractionIndex(int? value)
            {
                _VendorInteractionIndex = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsChecklistsDestinyChecklistEntryDefinition.Scope property.
            /// </summary>
            /// <param name="value">The scope at which this specific entry can be computed.</param>
            public DestinyDefinitionsChecklistsDestinyChecklistEntryDefinitionBuilder Scope(int? value)
            {
                _Scope = value;
                return this;
            }


            /// <summary>
            /// Builds instance of DestinyDefinitionsChecklistsDestinyChecklistEntryDefinition.
            /// </summary>
            /// <returns>DestinyDefinitionsChecklistsDestinyChecklistEntryDefinition</returns>
            public DestinyDefinitionsChecklistsDestinyChecklistEntryDefinition Build()
            {
                Validate();
                return new DestinyDefinitionsChecklistsDestinyChecklistEntryDefinition(
                    Hash: _Hash,
                    DisplayProperties: _DisplayProperties,
                    DestinationHash: _DestinationHash,
                    LocationHash: _LocationHash,
                    BubbleHash: _BubbleHash,
                    ActivityHash: _ActivityHash,
                    ItemHash: _ItemHash,
                    VendorHash: _VendorHash,
                    VendorInteractionIndex: _VendorInteractionIndex,
                    Scope: _Scope
                );
            }

            private void Validate()
            { 
            }
        }

        
    }
}