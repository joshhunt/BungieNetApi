using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Sharpility.Extensions;
using NodaTime;

namespace BungieNetApi._Platform.Models
{
    /// <summary>
    /// All damage types that are possible in the game are defined here, along with localized info and icons as needed.
    /// </summary>
    public sealed class DestinyDefinitionsDestinyDamageTypeDefinition:  IEquatable<DestinyDefinitionsDestinyDamageTypeDefinition>
    { 
        /// <summary>
        /// The description of the damage type, icon etc...
        /// </summary>
        public DestinyDefinitionsCommonDestinyDisplayPropertiesDefinition DisplayProperties { get; private set; }

        /// <summary>
        /// A variant of the icon that is transparent and colorless.
        /// </summary>
        public string TransparentIconPath { get; private set; }

        /// <summary>
        /// If TRUE, the game shows this damage type&#39;s icon. Otherwise, it doesn&#39;t. Whether you show it or not is up to you.
        /// </summary>
        public bool? ShowIcon { get; private set; }

        /// <summary>
        /// We have an enumeration for damage types for quick reference. This is the current definition&#39;s damage type enum value.
        /// </summary>
        public int? EnumValue { get; private set; }

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
        /// Use DestinyDefinitionsDestinyDamageTypeDefinition.Builder() for instance creation instead.
        /// </summary>
        [Obsolete]
        public DestinyDefinitionsDestinyDamageTypeDefinition()
        {
        }

        private DestinyDefinitionsDestinyDamageTypeDefinition(DestinyDefinitionsCommonDestinyDisplayPropertiesDefinition DisplayProperties, string TransparentIconPath, bool? ShowIcon, int? EnumValue, int? Hash, int? Index, bool? Redacted)
        {
            
            this.DisplayProperties = DisplayProperties;
            
            this.TransparentIconPath = TransparentIconPath;
            
            this.ShowIcon = ShowIcon;
            
            this.EnumValue = EnumValue;
            
            this.Hash = Hash;
            
            this.Index = Index;
            
            this.Redacted = Redacted;
            
        }

        /// <summary>
        /// Returns builder of DestinyDefinitionsDestinyDamageTypeDefinition.
        /// </summary>
        /// <returns>DestinyDefinitionsDestinyDamageTypeDefinitionBuilder</returns>
        public static DestinyDefinitionsDestinyDamageTypeDefinitionBuilder Builder()
        {
            return new DestinyDefinitionsDestinyDamageTypeDefinitionBuilder();
        }

        /// <summary>
        /// Returns DestinyDefinitionsDestinyDamageTypeDefinitionBuilder with properties set.
        /// Use it to change properties.
        /// </summary>
        /// <returns>DestinyDefinitionsDestinyDamageTypeDefinitionBuilder</returns>
        public DestinyDefinitionsDestinyDamageTypeDefinitionBuilder With()
        {
            return Builder()
                .DisplayProperties(DisplayProperties)
                .TransparentIconPath(TransparentIconPath)
                .ShowIcon(ShowIcon)
                .EnumValue(EnumValue)
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

        public bool Equals(DestinyDefinitionsDestinyDamageTypeDefinition other)
        {
            return Equals((object) other);
        }

        public override int GetHashCode()
        {
            return this.PropertiesHash();
        }

        /// <summary>
        /// Implementation of == operator for (DestinyDefinitionsDestinyDamageTypeDefinition.
        /// </summary>
        /// <param name="left">Compared (DestinyDefinitionsDestinyDamageTypeDefinition</param>
        /// <param name="right">Compared (DestinyDefinitionsDestinyDamageTypeDefinition</param>
        /// <returns>true if compared items are equals, false otherwise</returns>
        public static bool operator == (DestinyDefinitionsDestinyDamageTypeDefinition left, DestinyDefinitionsDestinyDamageTypeDefinition right)
        {
            return Equals(left, right);
        }

        /// <summary>
        /// Implementation of != operator for (DestinyDefinitionsDestinyDamageTypeDefinition.
        /// </summary>
        /// <param name="left">Compared (DestinyDefinitionsDestinyDamageTypeDefinition</param>
        /// <param name="right">Compared (DestinyDefinitionsDestinyDamageTypeDefinition</param>
        /// <returns>true if compared items are not equals, false otherwise</returns>
        public static bool operator != (DestinyDefinitionsDestinyDamageTypeDefinition left, DestinyDefinitionsDestinyDamageTypeDefinition right)
        {
            return !Equals(left, right);
        }

        /// <summary>
        /// Builder of DestinyDefinitionsDestinyDamageTypeDefinition.
        /// </summary>
        public sealed class DestinyDefinitionsDestinyDamageTypeDefinitionBuilder
        {
            private DestinyDefinitionsCommonDestinyDisplayPropertiesDefinition _DisplayProperties;
            private string _TransparentIconPath;
            private bool? _ShowIcon;
            private int? _EnumValue;
            private int? _Hash;
            private int? _Index;
            private bool? _Redacted;

            internal DestinyDefinitionsDestinyDamageTypeDefinitionBuilder()
            {
                SetupDefaults();
            }

            private void SetupDefaults()
            {
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsDestinyDamageTypeDefinition.DisplayProperties property.
            /// </summary>
            /// <param name="value">The description of the damage type, icon etc...</param>
            public DestinyDefinitionsDestinyDamageTypeDefinitionBuilder DisplayProperties(DestinyDefinitionsCommonDestinyDisplayPropertiesDefinition value)
            {
                _DisplayProperties = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsDestinyDamageTypeDefinition.TransparentIconPath property.
            /// </summary>
            /// <param name="value">A variant of the icon that is transparent and colorless.</param>
            public DestinyDefinitionsDestinyDamageTypeDefinitionBuilder TransparentIconPath(string value)
            {
                _TransparentIconPath = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsDestinyDamageTypeDefinition.ShowIcon property.
            /// </summary>
            /// <param name="value">If TRUE, the game shows this damage type&#39;s icon. Otherwise, it doesn&#39;t. Whether you show it or not is up to you.</param>
            public DestinyDefinitionsDestinyDamageTypeDefinitionBuilder ShowIcon(bool? value)
            {
                _ShowIcon = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsDestinyDamageTypeDefinition.EnumValue property.
            /// </summary>
            /// <param name="value">We have an enumeration for damage types for quick reference. This is the current definition&#39;s damage type enum value.</param>
            public DestinyDefinitionsDestinyDamageTypeDefinitionBuilder EnumValue(int? value)
            {
                _EnumValue = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsDestinyDamageTypeDefinition.Hash property.
            /// </summary>
            /// <param name="value">The unique identifier for this entity. Guaranteed to be unique for the type of entity, but not globally.  When entities refer to each other in Destiny content, it is this hash that they are referring to.</param>
            public DestinyDefinitionsDestinyDamageTypeDefinitionBuilder Hash(int? value)
            {
                _Hash = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsDestinyDamageTypeDefinition.Index property.
            /// </summary>
            /// <param name="value">The index of the entity as it was found in the investment tables.</param>
            public DestinyDefinitionsDestinyDamageTypeDefinitionBuilder Index(int? value)
            {
                _Index = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsDestinyDamageTypeDefinition.Redacted property.
            /// </summary>
            /// <param name="value">If this is true, then there is an entity with this identifier/type combination, but BNet is not yet allowed to show it. Sorry!</param>
            public DestinyDefinitionsDestinyDamageTypeDefinitionBuilder Redacted(bool? value)
            {
                _Redacted = value;
                return this;
            }


            /// <summary>
            /// Builds instance of DestinyDefinitionsDestinyDamageTypeDefinition.
            /// </summary>
            /// <returns>DestinyDefinitionsDestinyDamageTypeDefinition</returns>
            public DestinyDefinitionsDestinyDamageTypeDefinition Build()
            {
                Validate();
                return new DestinyDefinitionsDestinyDamageTypeDefinition(
                    DisplayProperties: _DisplayProperties,
                    TransparentIconPath: _TransparentIconPath,
                    ShowIcon: _ShowIcon,
                    EnumValue: _EnumValue,
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