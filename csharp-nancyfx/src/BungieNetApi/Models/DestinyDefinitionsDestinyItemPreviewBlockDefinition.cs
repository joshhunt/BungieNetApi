using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Sharpility.Extensions;
using NodaTime;

namespace BungieNetApi._Platform.Models
{
    /// <summary>
    /// Items like Sacks or Boxes can have items that it shows in-game when you view details that represent the items you can obtain if you use or acquire the item.  This defines those categories, and gives some insights into that data&#39;s source.
    /// </summary>
    public sealed class DestinyDefinitionsDestinyItemPreviewBlockDefinition:  IEquatable<DestinyDefinitionsDestinyItemPreviewBlockDefinition>
    { 
        /// <summary>
        /// A string that the game UI uses as a hint for which detail screen to show for the item. You, too, can leverage this for your own custom screen detail views. Note, however, that these are arbitrarily defined by designers: there&#39;s no guarantees of a fixed, known number of these - so fall back to something reasonable if you don&#39;t recognize it.
        /// </summary>
        public string ScreenStyle { get; private set; }

        /// <summary>
        /// If the preview data is derived from a fake \&quot;Preview\&quot; Vendor, this will be the hash identifier for the DestinyVendorDefinition of that fake vendor.
        /// </summary>
        public int? PreviewVendorHash { get; private set; }

        /// <summary>
        /// If this item should show you Artifact information when you preview it, this is the hash identifier of the DestinyArtifactDefinition for the artifact whose data should be shown.
        /// </summary>
        public int? ArtifactHash { get; private set; }

        /// <summary>
        /// If the preview has an associated action (like \&quot;Open\&quot;), this will be the localized string for that action.
        /// </summary>
        public string PreviewActionString { get; private set; }

        /// <summary>
        /// This is a list of the items being previewed, categorized in the same way as they are in the preview UI.
        /// </summary>
        public List<DestinyDefinitionsItemsDestinyDerivedItemCategoryDefinition> DerivedItemCategories { get; private set; }


        /// <summary>
        /// Empty constructor required by some serializers.
        /// Use DestinyDefinitionsDestinyItemPreviewBlockDefinition.Builder() for instance creation instead.
        /// </summary>
        [Obsolete]
        public DestinyDefinitionsDestinyItemPreviewBlockDefinition()
        {
        }

        private DestinyDefinitionsDestinyItemPreviewBlockDefinition(string ScreenStyle, int? PreviewVendorHash, int? ArtifactHash, string PreviewActionString, List<DestinyDefinitionsItemsDestinyDerivedItemCategoryDefinition> DerivedItemCategories)
        {
            
            this.ScreenStyle = ScreenStyle;
            
            this.PreviewVendorHash = PreviewVendorHash;
            
            this.ArtifactHash = ArtifactHash;
            
            this.PreviewActionString = PreviewActionString;
            
            this.DerivedItemCategories = DerivedItemCategories;
            
        }

        /// <summary>
        /// Returns builder of DestinyDefinitionsDestinyItemPreviewBlockDefinition.
        /// </summary>
        /// <returns>DestinyDefinitionsDestinyItemPreviewBlockDefinitionBuilder</returns>
        public static DestinyDefinitionsDestinyItemPreviewBlockDefinitionBuilder Builder()
        {
            return new DestinyDefinitionsDestinyItemPreviewBlockDefinitionBuilder();
        }

        /// <summary>
        /// Returns DestinyDefinitionsDestinyItemPreviewBlockDefinitionBuilder with properties set.
        /// Use it to change properties.
        /// </summary>
        /// <returns>DestinyDefinitionsDestinyItemPreviewBlockDefinitionBuilder</returns>
        public DestinyDefinitionsDestinyItemPreviewBlockDefinitionBuilder With()
        {
            return Builder()
                .ScreenStyle(ScreenStyle)
                .PreviewVendorHash(PreviewVendorHash)
                .ArtifactHash(ArtifactHash)
                .PreviewActionString(PreviewActionString)
                .DerivedItemCategories(DerivedItemCategories);
        }

        public override string ToString()
        {
            return this.PropertiesToString();
        }

        public override bool Equals(object obj)
        {
            return this.EqualsByProperties(obj);
        }

        public bool Equals(DestinyDefinitionsDestinyItemPreviewBlockDefinition other)
        {
            return Equals((object) other);
        }

        public override int GetHashCode()
        {
            return this.PropertiesHash();
        }

        /// <summary>
        /// Implementation of == operator for (DestinyDefinitionsDestinyItemPreviewBlockDefinition.
        /// </summary>
        /// <param name="left">Compared (DestinyDefinitionsDestinyItemPreviewBlockDefinition</param>
        /// <param name="right">Compared (DestinyDefinitionsDestinyItemPreviewBlockDefinition</param>
        /// <returns>true if compared items are equals, false otherwise</returns>
        public static bool operator == (DestinyDefinitionsDestinyItemPreviewBlockDefinition left, DestinyDefinitionsDestinyItemPreviewBlockDefinition right)
        {
            return Equals(left, right);
        }

        /// <summary>
        /// Implementation of != operator for (DestinyDefinitionsDestinyItemPreviewBlockDefinition.
        /// </summary>
        /// <param name="left">Compared (DestinyDefinitionsDestinyItemPreviewBlockDefinition</param>
        /// <param name="right">Compared (DestinyDefinitionsDestinyItemPreviewBlockDefinition</param>
        /// <returns>true if compared items are not equals, false otherwise</returns>
        public static bool operator != (DestinyDefinitionsDestinyItemPreviewBlockDefinition left, DestinyDefinitionsDestinyItemPreviewBlockDefinition right)
        {
            return !Equals(left, right);
        }

        /// <summary>
        /// Builder of DestinyDefinitionsDestinyItemPreviewBlockDefinition.
        /// </summary>
        public sealed class DestinyDefinitionsDestinyItemPreviewBlockDefinitionBuilder
        {
            private string _ScreenStyle;
            private int? _PreviewVendorHash;
            private int? _ArtifactHash;
            private string _PreviewActionString;
            private List<DestinyDefinitionsItemsDestinyDerivedItemCategoryDefinition> _DerivedItemCategories;

            internal DestinyDefinitionsDestinyItemPreviewBlockDefinitionBuilder()
            {
                SetupDefaults();
            }

            private void SetupDefaults()
            {
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsDestinyItemPreviewBlockDefinition.ScreenStyle property.
            /// </summary>
            /// <param name="value">A string that the game UI uses as a hint for which detail screen to show for the item. You, too, can leverage this for your own custom screen detail views. Note, however, that these are arbitrarily defined by designers: there&#39;s no guarantees of a fixed, known number of these - so fall back to something reasonable if you don&#39;t recognize it.</param>
            public DestinyDefinitionsDestinyItemPreviewBlockDefinitionBuilder ScreenStyle(string value)
            {
                _ScreenStyle = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsDestinyItemPreviewBlockDefinition.PreviewVendorHash property.
            /// </summary>
            /// <param name="value">If the preview data is derived from a fake \&quot;Preview\&quot; Vendor, this will be the hash identifier for the DestinyVendorDefinition of that fake vendor.</param>
            public DestinyDefinitionsDestinyItemPreviewBlockDefinitionBuilder PreviewVendorHash(int? value)
            {
                _PreviewVendorHash = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsDestinyItemPreviewBlockDefinition.ArtifactHash property.
            /// </summary>
            /// <param name="value">If this item should show you Artifact information when you preview it, this is the hash identifier of the DestinyArtifactDefinition for the artifact whose data should be shown.</param>
            public DestinyDefinitionsDestinyItemPreviewBlockDefinitionBuilder ArtifactHash(int? value)
            {
                _ArtifactHash = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsDestinyItemPreviewBlockDefinition.PreviewActionString property.
            /// </summary>
            /// <param name="value">If the preview has an associated action (like \&quot;Open\&quot;), this will be the localized string for that action.</param>
            public DestinyDefinitionsDestinyItemPreviewBlockDefinitionBuilder PreviewActionString(string value)
            {
                _PreviewActionString = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsDestinyItemPreviewBlockDefinition.DerivedItemCategories property.
            /// </summary>
            /// <param name="value">This is a list of the items being previewed, categorized in the same way as they are in the preview UI.</param>
            public DestinyDefinitionsDestinyItemPreviewBlockDefinitionBuilder DerivedItemCategories(List<DestinyDefinitionsItemsDestinyDerivedItemCategoryDefinition> value)
            {
                _DerivedItemCategories = value;
                return this;
            }


            /// <summary>
            /// Builds instance of DestinyDefinitionsDestinyItemPreviewBlockDefinition.
            /// </summary>
            /// <returns>DestinyDefinitionsDestinyItemPreviewBlockDefinition</returns>
            public DestinyDefinitionsDestinyItemPreviewBlockDefinition Build()
            {
                Validate();
                return new DestinyDefinitionsDestinyItemPreviewBlockDefinition(
                    ScreenStyle: _ScreenStyle,
                    PreviewVendorHash: _PreviewVendorHash,
                    ArtifactHash: _ArtifactHash,
                    PreviewActionString: _PreviewActionString,
                    DerivedItemCategories: _DerivedItemCategories
                );
            }

            private void Validate()
            { 
            }
        }

        
    }
}