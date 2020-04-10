using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Sharpility.Extensions;
using NodaTime;

namespace BungieNetApi._Platform.Models
{
    /// <summary>
    /// Perks are modifiers to a character or item that can be applied situationally.  - Perks determine a weapons&#39; damage type.  - Perks put the Mods in Modifiers (they are literally the entity that bestows the Sandbox benefit for whatever fluff text about the modifier in the Socket, Plug or Talent Node)  - Perks are applied for unique alterations of state in Objectives  Anyways, I&#39;m sure you can see why perks are so interesting.  What Perks often don&#39;t have is human readable information, so we attempt to reverse engineer that by pulling that data from places that uniquely refer to these perks: namely, Talent Nodes and Plugs. That only gives us a subset of perks that are human readable, but those perks are the ones people generally care about anyways. The others are left as a mystery, their true purpose mostly unknown and undocumented.
    /// </summary>
    public sealed class DestinyDefinitionsDestinySandboxPerkDefinition:  IEquatable<DestinyDefinitionsDestinySandboxPerkDefinition>
    { 
        /// <summary>
        /// These display properties are by no means guaranteed to be populated. Usually when it is, it&#39;s only because we back-filled them with the displayProperties of some Talent Node or Plug item that happened to be uniquely providing that perk.
        /// </summary>
        public DestinyDefinitionsCommonDestinyDisplayPropertiesDefinition DisplayProperties { get; private set; }

        /// <summary>
        /// The string identifier for the perk.
        /// </summary>
        public string PerkIdentifier { get; private set; }

        /// <summary>
        /// If true, you can actually show the perk in the UI. Otherwise, it doesn&#39;t have useful player-facing information.
        /// </summary>
        public bool? IsDisplayable { get; private set; }

        /// <summary>
        /// If this perk grants a damage type to a weapon, the damage type will be defined here.  Unless you have a compelling reason to use this enum value, use the damageTypeHash instead to look up the actual DestinyDamageTypeDefinition.
        /// </summary>
        public int? DamageType { get; private set; }

        /// <summary>
        /// The hash identifier for looking up the DestinyDamageTypeDefinition, if this perk has a damage type.  This is preferred over using the damageType enumeration value, which has been left purely because it is occasionally convenient.
        /// </summary>
        public int? DamageTypeHash { get; private set; }

        /// <summary>
        /// An old holdover from the original Armory, this was an attempt to group perks by functionality.  It is as yet unpopulated, and there will be quite a bit of work needed to restore it to its former working order.
        /// </summary>
        public DestinyDefinitionsDestinyTalentNodeStepGroups PerkGroups { get; private set; }

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
        /// Use DestinyDefinitionsDestinySandboxPerkDefinition.Builder() for instance creation instead.
        /// </summary>
        [Obsolete]
        public DestinyDefinitionsDestinySandboxPerkDefinition()
        {
        }

        private DestinyDefinitionsDestinySandboxPerkDefinition(DestinyDefinitionsCommonDestinyDisplayPropertiesDefinition DisplayProperties, string PerkIdentifier, bool? IsDisplayable, int? DamageType, int? DamageTypeHash, DestinyDefinitionsDestinyTalentNodeStepGroups PerkGroups, int? Hash, int? Index, bool? Redacted)
        {
            
            this.DisplayProperties = DisplayProperties;
            
            this.PerkIdentifier = PerkIdentifier;
            
            this.IsDisplayable = IsDisplayable;
            
            this.DamageType = DamageType;
            
            this.DamageTypeHash = DamageTypeHash;
            
            this.PerkGroups = PerkGroups;
            
            this.Hash = Hash;
            
            this.Index = Index;
            
            this.Redacted = Redacted;
            
        }

        /// <summary>
        /// Returns builder of DestinyDefinitionsDestinySandboxPerkDefinition.
        /// </summary>
        /// <returns>DestinyDefinitionsDestinySandboxPerkDefinitionBuilder</returns>
        public static DestinyDefinitionsDestinySandboxPerkDefinitionBuilder Builder()
        {
            return new DestinyDefinitionsDestinySandboxPerkDefinitionBuilder();
        }

        /// <summary>
        /// Returns DestinyDefinitionsDestinySandboxPerkDefinitionBuilder with properties set.
        /// Use it to change properties.
        /// </summary>
        /// <returns>DestinyDefinitionsDestinySandboxPerkDefinitionBuilder</returns>
        public DestinyDefinitionsDestinySandboxPerkDefinitionBuilder With()
        {
            return Builder()
                .DisplayProperties(DisplayProperties)
                .PerkIdentifier(PerkIdentifier)
                .IsDisplayable(IsDisplayable)
                .DamageType(DamageType)
                .DamageTypeHash(DamageTypeHash)
                .PerkGroups(PerkGroups)
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

        public bool Equals(DestinyDefinitionsDestinySandboxPerkDefinition other)
        {
            return Equals((object) other);
        }

        public override int GetHashCode()
        {
            return this.PropertiesHash();
        }

        /// <summary>
        /// Implementation of == operator for (DestinyDefinitionsDestinySandboxPerkDefinition.
        /// </summary>
        /// <param name="left">Compared (DestinyDefinitionsDestinySandboxPerkDefinition</param>
        /// <param name="right">Compared (DestinyDefinitionsDestinySandboxPerkDefinition</param>
        /// <returns>true if compared items are equals, false otherwise</returns>
        public static bool operator == (DestinyDefinitionsDestinySandboxPerkDefinition left, DestinyDefinitionsDestinySandboxPerkDefinition right)
        {
            return Equals(left, right);
        }

        /// <summary>
        /// Implementation of != operator for (DestinyDefinitionsDestinySandboxPerkDefinition.
        /// </summary>
        /// <param name="left">Compared (DestinyDefinitionsDestinySandboxPerkDefinition</param>
        /// <param name="right">Compared (DestinyDefinitionsDestinySandboxPerkDefinition</param>
        /// <returns>true if compared items are not equals, false otherwise</returns>
        public static bool operator != (DestinyDefinitionsDestinySandboxPerkDefinition left, DestinyDefinitionsDestinySandboxPerkDefinition right)
        {
            return !Equals(left, right);
        }

        /// <summary>
        /// Builder of DestinyDefinitionsDestinySandboxPerkDefinition.
        /// </summary>
        public sealed class DestinyDefinitionsDestinySandboxPerkDefinitionBuilder
        {
            private DestinyDefinitionsCommonDestinyDisplayPropertiesDefinition _DisplayProperties;
            private string _PerkIdentifier;
            private bool? _IsDisplayable;
            private int? _DamageType;
            private int? _DamageTypeHash;
            private DestinyDefinitionsDestinyTalentNodeStepGroups _PerkGroups;
            private int? _Hash;
            private int? _Index;
            private bool? _Redacted;

            internal DestinyDefinitionsDestinySandboxPerkDefinitionBuilder()
            {
                SetupDefaults();
            }

            private void SetupDefaults()
            {
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsDestinySandboxPerkDefinition.DisplayProperties property.
            /// </summary>
            /// <param name="value">These display properties are by no means guaranteed to be populated. Usually when it is, it&#39;s only because we back-filled them with the displayProperties of some Talent Node or Plug item that happened to be uniquely providing that perk.</param>
            public DestinyDefinitionsDestinySandboxPerkDefinitionBuilder DisplayProperties(DestinyDefinitionsCommonDestinyDisplayPropertiesDefinition value)
            {
                _DisplayProperties = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsDestinySandboxPerkDefinition.PerkIdentifier property.
            /// </summary>
            /// <param name="value">The string identifier for the perk.</param>
            public DestinyDefinitionsDestinySandboxPerkDefinitionBuilder PerkIdentifier(string value)
            {
                _PerkIdentifier = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsDestinySandboxPerkDefinition.IsDisplayable property.
            /// </summary>
            /// <param name="value">If true, you can actually show the perk in the UI. Otherwise, it doesn&#39;t have useful player-facing information.</param>
            public DestinyDefinitionsDestinySandboxPerkDefinitionBuilder IsDisplayable(bool? value)
            {
                _IsDisplayable = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsDestinySandboxPerkDefinition.DamageType property.
            /// </summary>
            /// <param name="value">If this perk grants a damage type to a weapon, the damage type will be defined here.  Unless you have a compelling reason to use this enum value, use the damageTypeHash instead to look up the actual DestinyDamageTypeDefinition.</param>
            public DestinyDefinitionsDestinySandboxPerkDefinitionBuilder DamageType(int? value)
            {
                _DamageType = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsDestinySandboxPerkDefinition.DamageTypeHash property.
            /// </summary>
            /// <param name="value">The hash identifier for looking up the DestinyDamageTypeDefinition, if this perk has a damage type.  This is preferred over using the damageType enumeration value, which has been left purely because it is occasionally convenient.</param>
            public DestinyDefinitionsDestinySandboxPerkDefinitionBuilder DamageTypeHash(int? value)
            {
                _DamageTypeHash = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsDestinySandboxPerkDefinition.PerkGroups property.
            /// </summary>
            /// <param name="value">An old holdover from the original Armory, this was an attempt to group perks by functionality.  It is as yet unpopulated, and there will be quite a bit of work needed to restore it to its former working order.</param>
            public DestinyDefinitionsDestinySandboxPerkDefinitionBuilder PerkGroups(DestinyDefinitionsDestinyTalentNodeStepGroups value)
            {
                _PerkGroups = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsDestinySandboxPerkDefinition.Hash property.
            /// </summary>
            /// <param name="value">The unique identifier for this entity. Guaranteed to be unique for the type of entity, but not globally.  When entities refer to each other in Destiny content, it is this hash that they are referring to.</param>
            public DestinyDefinitionsDestinySandboxPerkDefinitionBuilder Hash(int? value)
            {
                _Hash = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsDestinySandboxPerkDefinition.Index property.
            /// </summary>
            /// <param name="value">The index of the entity as it was found in the investment tables.</param>
            public DestinyDefinitionsDestinySandboxPerkDefinitionBuilder Index(int? value)
            {
                _Index = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsDestinySandboxPerkDefinition.Redacted property.
            /// </summary>
            /// <param name="value">If this is true, then there is an entity with this identifier/type combination, but BNet is not yet allowed to show it. Sorry!</param>
            public DestinyDefinitionsDestinySandboxPerkDefinitionBuilder Redacted(bool? value)
            {
                _Redacted = value;
                return this;
            }


            /// <summary>
            /// Builds instance of DestinyDefinitionsDestinySandboxPerkDefinition.
            /// </summary>
            /// <returns>DestinyDefinitionsDestinySandboxPerkDefinition</returns>
            public DestinyDefinitionsDestinySandboxPerkDefinition Build()
            {
                Validate();
                return new DestinyDefinitionsDestinySandboxPerkDefinition(
                    DisplayProperties: _DisplayProperties,
                    PerkIdentifier: _PerkIdentifier,
                    IsDisplayable: _IsDisplayable,
                    DamageType: _DamageType,
                    DamageTypeHash: _DamageTypeHash,
                    PerkGroups: _PerkGroups,
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