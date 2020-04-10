using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Sharpility.Extensions;
using NodaTime;

namespace BungieNetApi._Platform.Models
{
    /// <summary>
    /// An artificial construct provided by Bungie.Net, where we attempt to group talent nodes by functionality.  This is a single set of references to Talent Nodes that share a common trait or purpose.
    /// </summary>
    public sealed class DestinyDefinitionsDestinyTalentNodeCategory:  IEquatable<DestinyDefinitionsDestinyTalentNodeCategory>
    { 
        /// <summary>
        /// Mostly just for debug purposes, but if you find it useful you can have it. This is BNet&#39;s manually created identifier for this category.
        /// </summary>
        public string Identifier { get; private set; }

        /// <summary>
        /// If true, we found the localized content in a related DestinyLoreDefinition instead of local BNet localization files. This is mostly for ease of my own future investigations.
        /// </summary>
        public bool? IsLoreDriven { get; private set; }

        /// <summary>
        /// Will contain at least the \&quot;name\&quot;, which will be the title of the category. We will likely not have description and an icon yet, but I&#39;m going to keep my options open.
        /// </summary>
        public DestinyDefinitionsCommonDestinyDisplayPropertiesDefinition DisplayProperties { get; private set; }

        /// <summary>
        /// The set of all hash identifiers for Talent Nodes (DestinyTalentNodeDefinition) in this Talent Grid that are part of this Category.
        /// </summary>
        public List<int?> NodeHashes { get; private set; }


        /// <summary>
        /// Empty constructor required by some serializers.
        /// Use DestinyDefinitionsDestinyTalentNodeCategory.Builder() for instance creation instead.
        /// </summary>
        [Obsolete]
        public DestinyDefinitionsDestinyTalentNodeCategory()
        {
        }

        private DestinyDefinitionsDestinyTalentNodeCategory(string Identifier, bool? IsLoreDriven, DestinyDefinitionsCommonDestinyDisplayPropertiesDefinition DisplayProperties, List<int?> NodeHashes)
        {
            
            this.Identifier = Identifier;
            
            this.IsLoreDriven = IsLoreDriven;
            
            this.DisplayProperties = DisplayProperties;
            
            this.NodeHashes = NodeHashes;
            
        }

        /// <summary>
        /// Returns builder of DestinyDefinitionsDestinyTalentNodeCategory.
        /// </summary>
        /// <returns>DestinyDefinitionsDestinyTalentNodeCategoryBuilder</returns>
        public static DestinyDefinitionsDestinyTalentNodeCategoryBuilder Builder()
        {
            return new DestinyDefinitionsDestinyTalentNodeCategoryBuilder();
        }

        /// <summary>
        /// Returns DestinyDefinitionsDestinyTalentNodeCategoryBuilder with properties set.
        /// Use it to change properties.
        /// </summary>
        /// <returns>DestinyDefinitionsDestinyTalentNodeCategoryBuilder</returns>
        public DestinyDefinitionsDestinyTalentNodeCategoryBuilder With()
        {
            return Builder()
                .Identifier(Identifier)
                .IsLoreDriven(IsLoreDriven)
                .DisplayProperties(DisplayProperties)
                .NodeHashes(NodeHashes);
        }

        public override string ToString()
        {
            return this.PropertiesToString();
        }

        public override bool Equals(object obj)
        {
            return this.EqualsByProperties(obj);
        }

        public bool Equals(DestinyDefinitionsDestinyTalentNodeCategory other)
        {
            return Equals((object) other);
        }

        public override int GetHashCode()
        {
            return this.PropertiesHash();
        }

        /// <summary>
        /// Implementation of == operator for (DestinyDefinitionsDestinyTalentNodeCategory.
        /// </summary>
        /// <param name="left">Compared (DestinyDefinitionsDestinyTalentNodeCategory</param>
        /// <param name="right">Compared (DestinyDefinitionsDestinyTalentNodeCategory</param>
        /// <returns>true if compared items are equals, false otherwise</returns>
        public static bool operator == (DestinyDefinitionsDestinyTalentNodeCategory left, DestinyDefinitionsDestinyTalentNodeCategory right)
        {
            return Equals(left, right);
        }

        /// <summary>
        /// Implementation of != operator for (DestinyDefinitionsDestinyTalentNodeCategory.
        /// </summary>
        /// <param name="left">Compared (DestinyDefinitionsDestinyTalentNodeCategory</param>
        /// <param name="right">Compared (DestinyDefinitionsDestinyTalentNodeCategory</param>
        /// <returns>true if compared items are not equals, false otherwise</returns>
        public static bool operator != (DestinyDefinitionsDestinyTalentNodeCategory left, DestinyDefinitionsDestinyTalentNodeCategory right)
        {
            return !Equals(left, right);
        }

        /// <summary>
        /// Builder of DestinyDefinitionsDestinyTalentNodeCategory.
        /// </summary>
        public sealed class DestinyDefinitionsDestinyTalentNodeCategoryBuilder
        {
            private string _Identifier;
            private bool? _IsLoreDriven;
            private DestinyDefinitionsCommonDestinyDisplayPropertiesDefinition _DisplayProperties;
            private List<int?> _NodeHashes;

            internal DestinyDefinitionsDestinyTalentNodeCategoryBuilder()
            {
                SetupDefaults();
            }

            private void SetupDefaults()
            {
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsDestinyTalentNodeCategory.Identifier property.
            /// </summary>
            /// <param name="value">Mostly just for debug purposes, but if you find it useful you can have it. This is BNet&#39;s manually created identifier for this category.</param>
            public DestinyDefinitionsDestinyTalentNodeCategoryBuilder Identifier(string value)
            {
                _Identifier = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsDestinyTalentNodeCategory.IsLoreDriven property.
            /// </summary>
            /// <param name="value">If true, we found the localized content in a related DestinyLoreDefinition instead of local BNet localization files. This is mostly for ease of my own future investigations.</param>
            public DestinyDefinitionsDestinyTalentNodeCategoryBuilder IsLoreDriven(bool? value)
            {
                _IsLoreDriven = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsDestinyTalentNodeCategory.DisplayProperties property.
            /// </summary>
            /// <param name="value">Will contain at least the \&quot;name\&quot;, which will be the title of the category. We will likely not have description and an icon yet, but I&#39;m going to keep my options open.</param>
            public DestinyDefinitionsDestinyTalentNodeCategoryBuilder DisplayProperties(DestinyDefinitionsCommonDestinyDisplayPropertiesDefinition value)
            {
                _DisplayProperties = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsDestinyTalentNodeCategory.NodeHashes property.
            /// </summary>
            /// <param name="value">The set of all hash identifiers for Talent Nodes (DestinyTalentNodeDefinition) in this Talent Grid that are part of this Category.</param>
            public DestinyDefinitionsDestinyTalentNodeCategoryBuilder NodeHashes(List<int?> value)
            {
                _NodeHashes = value;
                return this;
            }


            /// <summary>
            /// Builds instance of DestinyDefinitionsDestinyTalentNodeCategory.
            /// </summary>
            /// <returns>DestinyDefinitionsDestinyTalentNodeCategory</returns>
            public DestinyDefinitionsDestinyTalentNodeCategory Build()
            {
                Validate();
                return new DestinyDefinitionsDestinyTalentNodeCategory(
                    Identifier: _Identifier,
                    IsLoreDriven: _IsLoreDriven,
                    DisplayProperties: _DisplayProperties,
                    NodeHashes: _NodeHashes
                );
            }

            private void Validate()
            { 
            }
        }

        
    }
}