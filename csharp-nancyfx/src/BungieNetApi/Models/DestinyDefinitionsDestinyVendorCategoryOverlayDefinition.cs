using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Sharpility.Extensions;
using NodaTime;

namespace BungieNetApi._Platform.Models
{
    /// <summary>
    /// The details of an overlay prompt to show to a user. They are all fairly self-explanatory localized strings that can be shown.
    /// </summary>
    public sealed class DestinyDefinitionsDestinyVendorCategoryOverlayDefinition:  IEquatable<DestinyDefinitionsDestinyVendorCategoryOverlayDefinition>
    { 
        /// <summary>
        /// ChoiceDescription
        /// </summary>
        public string ChoiceDescription { get; private set; }

        /// <summary>
        /// Description
        /// </summary>
        public string Description { get; private set; }

        /// <summary>
        /// Icon
        /// </summary>
        public string Icon { get; private set; }

        /// <summary>
        /// Title
        /// </summary>
        public string Title { get; private set; }

        /// <summary>
        /// If this overlay has a currency item that it features, this is said featured item.
        /// </summary>
        public int? CurrencyItemHash { get; private set; }


        /// <summary>
        /// Empty constructor required by some serializers.
        /// Use DestinyDefinitionsDestinyVendorCategoryOverlayDefinition.Builder() for instance creation instead.
        /// </summary>
        [Obsolete]
        public DestinyDefinitionsDestinyVendorCategoryOverlayDefinition()
        {
        }

        private DestinyDefinitionsDestinyVendorCategoryOverlayDefinition(string ChoiceDescription, string Description, string Icon, string Title, int? CurrencyItemHash)
        {
            
            this.ChoiceDescription = ChoiceDescription;
            
            this.Description = Description;
            
            this.Icon = Icon;
            
            this.Title = Title;
            
            this.CurrencyItemHash = CurrencyItemHash;
            
        }

        /// <summary>
        /// Returns builder of DestinyDefinitionsDestinyVendorCategoryOverlayDefinition.
        /// </summary>
        /// <returns>DestinyDefinitionsDestinyVendorCategoryOverlayDefinitionBuilder</returns>
        public static DestinyDefinitionsDestinyVendorCategoryOverlayDefinitionBuilder Builder()
        {
            return new DestinyDefinitionsDestinyVendorCategoryOverlayDefinitionBuilder();
        }

        /// <summary>
        /// Returns DestinyDefinitionsDestinyVendorCategoryOverlayDefinitionBuilder with properties set.
        /// Use it to change properties.
        /// </summary>
        /// <returns>DestinyDefinitionsDestinyVendorCategoryOverlayDefinitionBuilder</returns>
        public DestinyDefinitionsDestinyVendorCategoryOverlayDefinitionBuilder With()
        {
            return Builder()
                .ChoiceDescription(ChoiceDescription)
                .Description(Description)
                .Icon(Icon)
                .Title(Title)
                .CurrencyItemHash(CurrencyItemHash);
        }

        public override string ToString()
        {
            return this.PropertiesToString();
        }

        public override bool Equals(object obj)
        {
            return this.EqualsByProperties(obj);
        }

        public bool Equals(DestinyDefinitionsDestinyVendorCategoryOverlayDefinition other)
        {
            return Equals((object) other);
        }

        public override int GetHashCode()
        {
            return this.PropertiesHash();
        }

        /// <summary>
        /// Implementation of == operator for (DestinyDefinitionsDestinyVendorCategoryOverlayDefinition.
        /// </summary>
        /// <param name="left">Compared (DestinyDefinitionsDestinyVendorCategoryOverlayDefinition</param>
        /// <param name="right">Compared (DestinyDefinitionsDestinyVendorCategoryOverlayDefinition</param>
        /// <returns>true if compared items are equals, false otherwise</returns>
        public static bool operator == (DestinyDefinitionsDestinyVendorCategoryOverlayDefinition left, DestinyDefinitionsDestinyVendorCategoryOverlayDefinition right)
        {
            return Equals(left, right);
        }

        /// <summary>
        /// Implementation of != operator for (DestinyDefinitionsDestinyVendorCategoryOverlayDefinition.
        /// </summary>
        /// <param name="left">Compared (DestinyDefinitionsDestinyVendorCategoryOverlayDefinition</param>
        /// <param name="right">Compared (DestinyDefinitionsDestinyVendorCategoryOverlayDefinition</param>
        /// <returns>true if compared items are not equals, false otherwise</returns>
        public static bool operator != (DestinyDefinitionsDestinyVendorCategoryOverlayDefinition left, DestinyDefinitionsDestinyVendorCategoryOverlayDefinition right)
        {
            return !Equals(left, right);
        }

        /// <summary>
        /// Builder of DestinyDefinitionsDestinyVendorCategoryOverlayDefinition.
        /// </summary>
        public sealed class DestinyDefinitionsDestinyVendorCategoryOverlayDefinitionBuilder
        {
            private string _ChoiceDescription;
            private string _Description;
            private string _Icon;
            private string _Title;
            private int? _CurrencyItemHash;

            internal DestinyDefinitionsDestinyVendorCategoryOverlayDefinitionBuilder()
            {
                SetupDefaults();
            }

            private void SetupDefaults()
            {
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsDestinyVendorCategoryOverlayDefinition.ChoiceDescription property.
            /// </summary>
            /// <param name="value">ChoiceDescription</param>
            public DestinyDefinitionsDestinyVendorCategoryOverlayDefinitionBuilder ChoiceDescription(string value)
            {
                _ChoiceDescription = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsDestinyVendorCategoryOverlayDefinition.Description property.
            /// </summary>
            /// <param name="value">Description</param>
            public DestinyDefinitionsDestinyVendorCategoryOverlayDefinitionBuilder Description(string value)
            {
                _Description = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsDestinyVendorCategoryOverlayDefinition.Icon property.
            /// </summary>
            /// <param name="value">Icon</param>
            public DestinyDefinitionsDestinyVendorCategoryOverlayDefinitionBuilder Icon(string value)
            {
                _Icon = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsDestinyVendorCategoryOverlayDefinition.Title property.
            /// </summary>
            /// <param name="value">Title</param>
            public DestinyDefinitionsDestinyVendorCategoryOverlayDefinitionBuilder Title(string value)
            {
                _Title = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsDestinyVendorCategoryOverlayDefinition.CurrencyItemHash property.
            /// </summary>
            /// <param name="value">If this overlay has a currency item that it features, this is said featured item.</param>
            public DestinyDefinitionsDestinyVendorCategoryOverlayDefinitionBuilder CurrencyItemHash(int? value)
            {
                _CurrencyItemHash = value;
                return this;
            }


            /// <summary>
            /// Builds instance of DestinyDefinitionsDestinyVendorCategoryOverlayDefinition.
            /// </summary>
            /// <returns>DestinyDefinitionsDestinyVendorCategoryOverlayDefinition</returns>
            public DestinyDefinitionsDestinyVendorCategoryOverlayDefinition Build()
            {
                Validate();
                return new DestinyDefinitionsDestinyVendorCategoryOverlayDefinition(
                    ChoiceDescription: _ChoiceDescription,
                    Description: _Description,
                    Icon: _Icon,
                    Title: _Title,
                    CurrencyItemHash: _CurrencyItemHash
                );
            }

            private void Validate()
            { 
            }
        }

        
    }
}