using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Sharpility.Extensions;
using NodaTime;

namespace BungieNetApi._Platform.Models
{
    /// <summary>
    /// Display Categories are different from \&quot;categories\&quot; in that these are specifically for visual grouping and display of categories in Vendor UI. The \&quot;categories\&quot; structure is for validation of the contained items, and can be categorized entirely separately from \&quot;Display Categories\&quot;, there need be and often will be no meaningful relationship between the two.
    /// </summary>
    public sealed class DestinyDefinitionsDestinyDisplayCategoryDefinition:  IEquatable<DestinyDefinitionsDestinyDisplayCategoryDefinition>
    { 
        /// <summary>
        /// Index
        /// </summary>
        public int? Index { get; private set; }

        /// <summary>
        /// A string identifier for the display category.
        /// </summary>
        public string Identifier { get; private set; }

        /// <summary>
        /// DisplayCategoryHash
        /// </summary>
        public int? DisplayCategoryHash { get; private set; }

        /// <summary>
        /// DisplayProperties
        /// </summary>
        public DestinyDefinitionsCommonDestinyDisplayPropertiesDefinition DisplayProperties { get; private set; }

        /// <summary>
        /// If true, this category should be displayed in the \&quot;Banner\&quot; section of the vendor&#39;s UI.
        /// </summary>
        public bool? DisplayInBanner { get; private set; }

        /// <summary>
        /// If it exists, this is the hash identifier of a DestinyProgressionDefinition that represents the progression to show on this display category.  Specific categories can now have thier own distinct progression, apparently. So that&#39;s cool.
        /// </summary>
        public int? ProgressionHash { get; private set; }

        /// <summary>
        /// If this category sorts items in a nonstandard way, this will be the way we sort.
        /// </summary>
        public int? SortOrder { get; private set; }

        /// <summary>
        /// An indicator of how the category will be displayed in the UI. It&#39;s up to you to do something cool or interesting in response to this, or just to treat it as a normal category.
        /// </summary>
        public int? DisplayStyleHash { get; private set; }

        /// <summary>
        /// An indicator of how the category will be displayed in the UI. It&#39;s up to you to do something cool or interesting in response to this, or just to treat it as a normal category.
        /// </summary>
        public string DisplayStyleIdentifier { get; private set; }


        /// <summary>
        /// Empty constructor required by some serializers.
        /// Use DestinyDefinitionsDestinyDisplayCategoryDefinition.Builder() for instance creation instead.
        /// </summary>
        [Obsolete]
        public DestinyDefinitionsDestinyDisplayCategoryDefinition()
        {
        }

        private DestinyDefinitionsDestinyDisplayCategoryDefinition(int? Index, string Identifier, int? DisplayCategoryHash, DestinyDefinitionsCommonDestinyDisplayPropertiesDefinition DisplayProperties, bool? DisplayInBanner, int? ProgressionHash, int? SortOrder, int? DisplayStyleHash, string DisplayStyleIdentifier)
        {
            
            this.Index = Index;
            
            this.Identifier = Identifier;
            
            this.DisplayCategoryHash = DisplayCategoryHash;
            
            this.DisplayProperties = DisplayProperties;
            
            this.DisplayInBanner = DisplayInBanner;
            
            this.ProgressionHash = ProgressionHash;
            
            this.SortOrder = SortOrder;
            
            this.DisplayStyleHash = DisplayStyleHash;
            
            this.DisplayStyleIdentifier = DisplayStyleIdentifier;
            
        }

        /// <summary>
        /// Returns builder of DestinyDefinitionsDestinyDisplayCategoryDefinition.
        /// </summary>
        /// <returns>DestinyDefinitionsDestinyDisplayCategoryDefinitionBuilder</returns>
        public static DestinyDefinitionsDestinyDisplayCategoryDefinitionBuilder Builder()
        {
            return new DestinyDefinitionsDestinyDisplayCategoryDefinitionBuilder();
        }

        /// <summary>
        /// Returns DestinyDefinitionsDestinyDisplayCategoryDefinitionBuilder with properties set.
        /// Use it to change properties.
        /// </summary>
        /// <returns>DestinyDefinitionsDestinyDisplayCategoryDefinitionBuilder</returns>
        public DestinyDefinitionsDestinyDisplayCategoryDefinitionBuilder With()
        {
            return Builder()
                .Index(Index)
                .Identifier(Identifier)
                .DisplayCategoryHash(DisplayCategoryHash)
                .DisplayProperties(DisplayProperties)
                .DisplayInBanner(DisplayInBanner)
                .ProgressionHash(ProgressionHash)
                .SortOrder(SortOrder)
                .DisplayStyleHash(DisplayStyleHash)
                .DisplayStyleIdentifier(DisplayStyleIdentifier);
        }

        public override string ToString()
        {
            return this.PropertiesToString();
        }

        public override bool Equals(object obj)
        {
            return this.EqualsByProperties(obj);
        }

        public bool Equals(DestinyDefinitionsDestinyDisplayCategoryDefinition other)
        {
            return Equals((object) other);
        }

        public override int GetHashCode()
        {
            return this.PropertiesHash();
        }

        /// <summary>
        /// Implementation of == operator for (DestinyDefinitionsDestinyDisplayCategoryDefinition.
        /// </summary>
        /// <param name="left">Compared (DestinyDefinitionsDestinyDisplayCategoryDefinition</param>
        /// <param name="right">Compared (DestinyDefinitionsDestinyDisplayCategoryDefinition</param>
        /// <returns>true if compared items are equals, false otherwise</returns>
        public static bool operator == (DestinyDefinitionsDestinyDisplayCategoryDefinition left, DestinyDefinitionsDestinyDisplayCategoryDefinition right)
        {
            return Equals(left, right);
        }

        /// <summary>
        /// Implementation of != operator for (DestinyDefinitionsDestinyDisplayCategoryDefinition.
        /// </summary>
        /// <param name="left">Compared (DestinyDefinitionsDestinyDisplayCategoryDefinition</param>
        /// <param name="right">Compared (DestinyDefinitionsDestinyDisplayCategoryDefinition</param>
        /// <returns>true if compared items are not equals, false otherwise</returns>
        public static bool operator != (DestinyDefinitionsDestinyDisplayCategoryDefinition left, DestinyDefinitionsDestinyDisplayCategoryDefinition right)
        {
            return !Equals(left, right);
        }

        /// <summary>
        /// Builder of DestinyDefinitionsDestinyDisplayCategoryDefinition.
        /// </summary>
        public sealed class DestinyDefinitionsDestinyDisplayCategoryDefinitionBuilder
        {
            private int? _Index;
            private string _Identifier;
            private int? _DisplayCategoryHash;
            private DestinyDefinitionsCommonDestinyDisplayPropertiesDefinition _DisplayProperties;
            private bool? _DisplayInBanner;
            private int? _ProgressionHash;
            private int? _SortOrder;
            private int? _DisplayStyleHash;
            private string _DisplayStyleIdentifier;

            internal DestinyDefinitionsDestinyDisplayCategoryDefinitionBuilder()
            {
                SetupDefaults();
            }

            private void SetupDefaults()
            {
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsDestinyDisplayCategoryDefinition.Index property.
            /// </summary>
            /// <param name="value">Index</param>
            public DestinyDefinitionsDestinyDisplayCategoryDefinitionBuilder Index(int? value)
            {
                _Index = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsDestinyDisplayCategoryDefinition.Identifier property.
            /// </summary>
            /// <param name="value">A string identifier for the display category.</param>
            public DestinyDefinitionsDestinyDisplayCategoryDefinitionBuilder Identifier(string value)
            {
                _Identifier = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsDestinyDisplayCategoryDefinition.DisplayCategoryHash property.
            /// </summary>
            /// <param name="value">DisplayCategoryHash</param>
            public DestinyDefinitionsDestinyDisplayCategoryDefinitionBuilder DisplayCategoryHash(int? value)
            {
                _DisplayCategoryHash = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsDestinyDisplayCategoryDefinition.DisplayProperties property.
            /// </summary>
            /// <param name="value">DisplayProperties</param>
            public DestinyDefinitionsDestinyDisplayCategoryDefinitionBuilder DisplayProperties(DestinyDefinitionsCommonDestinyDisplayPropertiesDefinition value)
            {
                _DisplayProperties = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsDestinyDisplayCategoryDefinition.DisplayInBanner property.
            /// </summary>
            /// <param name="value">If true, this category should be displayed in the \&quot;Banner\&quot; section of the vendor&#39;s UI.</param>
            public DestinyDefinitionsDestinyDisplayCategoryDefinitionBuilder DisplayInBanner(bool? value)
            {
                _DisplayInBanner = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsDestinyDisplayCategoryDefinition.ProgressionHash property.
            /// </summary>
            /// <param name="value">If it exists, this is the hash identifier of a DestinyProgressionDefinition that represents the progression to show on this display category.  Specific categories can now have thier own distinct progression, apparently. So that&#39;s cool.</param>
            public DestinyDefinitionsDestinyDisplayCategoryDefinitionBuilder ProgressionHash(int? value)
            {
                _ProgressionHash = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsDestinyDisplayCategoryDefinition.SortOrder property.
            /// </summary>
            /// <param name="value">If this category sorts items in a nonstandard way, this will be the way we sort.</param>
            public DestinyDefinitionsDestinyDisplayCategoryDefinitionBuilder SortOrder(int? value)
            {
                _SortOrder = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsDestinyDisplayCategoryDefinition.DisplayStyleHash property.
            /// </summary>
            /// <param name="value">An indicator of how the category will be displayed in the UI. It&#39;s up to you to do something cool or interesting in response to this, or just to treat it as a normal category.</param>
            public DestinyDefinitionsDestinyDisplayCategoryDefinitionBuilder DisplayStyleHash(int? value)
            {
                _DisplayStyleHash = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsDestinyDisplayCategoryDefinition.DisplayStyleIdentifier property.
            /// </summary>
            /// <param name="value">An indicator of how the category will be displayed in the UI. It&#39;s up to you to do something cool or interesting in response to this, or just to treat it as a normal category.</param>
            public DestinyDefinitionsDestinyDisplayCategoryDefinitionBuilder DisplayStyleIdentifier(string value)
            {
                _DisplayStyleIdentifier = value;
                return this;
            }


            /// <summary>
            /// Builds instance of DestinyDefinitionsDestinyDisplayCategoryDefinition.
            /// </summary>
            /// <returns>DestinyDefinitionsDestinyDisplayCategoryDefinition</returns>
            public DestinyDefinitionsDestinyDisplayCategoryDefinition Build()
            {
                Validate();
                return new DestinyDefinitionsDestinyDisplayCategoryDefinition(
                    Index: _Index,
                    Identifier: _Identifier,
                    DisplayCategoryHash: _DisplayCategoryHash,
                    DisplayProperties: _DisplayProperties,
                    DisplayInBanner: _DisplayInBanner,
                    ProgressionHash: _ProgressionHash,
                    SortOrder: _SortOrder,
                    DisplayStyleHash: _DisplayStyleHash,
                    DisplayStyleIdentifier: _DisplayStyleIdentifier
                );
            }

            private void Validate()
            { 
            }
        }

        
    }
}