using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Sharpility.Extensions;
using NodaTime;

namespace BungieNetApi._Platform.Models
{
    /// <summary>
    /// ContentModelsContentTypeDescription
    /// </summary>
    public sealed class ContentModelsContentTypeDescription:  IEquatable<ContentModelsContentTypeDescription>
    { 
        /// <summary>
        /// CType
        /// </summary>
        public string CType { get; private set; }

        /// <summary>
        /// Name
        /// </summary>
        public string Name { get; private set; }

        /// <summary>
        /// ContentDescription
        /// </summary>
        public string ContentDescription { get; private set; }

        /// <summary>
        /// PreviewImage
        /// </summary>
        public string PreviewImage { get; private set; }

        /// <summary>
        /// Priority
        /// </summary>
        public int? Priority { get; private set; }

        /// <summary>
        /// Reminder
        /// </summary>
        public string Reminder { get; private set; }

        /// <summary>
        /// Properties
        /// </summary>
        public List<ContentModelsContentTypeProperty> Properties { get; private set; }

        /// <summary>
        /// TagMetadata
        /// </summary>
        public List<ContentModelsTagMetadataDefinition> TagMetadata { get; private set; }

        /// <summary>
        /// TagMetadataItems
        /// </summary>
        public Dictionary<string, ContentModelsTagMetadataItem> TagMetadataItems { get; private set; }

        /// <summary>
        /// UsageExamples
        /// </summary>
        public List<string> UsageExamples { get; private set; }

        /// <summary>
        /// ShowInContentEditor
        /// </summary>
        public bool? ShowInContentEditor { get; private set; }

        /// <summary>
        /// TypeOf
        /// </summary>
        public string TypeOf { get; private set; }

        /// <summary>
        /// BindIdentifierToProperty
        /// </summary>
        public string BindIdentifierToProperty { get; private set; }

        /// <summary>
        /// BoundRegex
        /// </summary>
        public string BoundRegex { get; private set; }

        /// <summary>
        /// ForceIdentifierBinding
        /// </summary>
        public bool? ForceIdentifierBinding { get; private set; }

        /// <summary>
        /// AllowComments
        /// </summary>
        public bool? AllowComments { get; private set; }

        /// <summary>
        /// AutoEnglishPropertyFallback
        /// </summary>
        public bool? AutoEnglishPropertyFallback { get; private set; }

        /// <summary>
        /// BulkUploadable
        /// </summary>
        public bool? BulkUploadable { get; private set; }

        /// <summary>
        /// Previews
        /// </summary>
        public List<ContentModelsContentPreview> Previews { get; private set; }

        /// <summary>
        /// SuppressCmsPath
        /// </summary>
        public bool? SuppressCmsPath { get; private set; }

        /// <summary>
        /// PropertySections
        /// </summary>
        public List<ContentModelsContentTypePropertySection> PropertySections { get; private set; }


        /// <summary>
        /// Empty constructor required by some serializers.
        /// Use ContentModelsContentTypeDescription.Builder() for instance creation instead.
        /// </summary>
        [Obsolete]
        public ContentModelsContentTypeDescription()
        {
        }

        private ContentModelsContentTypeDescription(string CType, string Name, string ContentDescription, string PreviewImage, int? Priority, string Reminder, List<ContentModelsContentTypeProperty> Properties, List<ContentModelsTagMetadataDefinition> TagMetadata, Dictionary<string, ContentModelsTagMetadataItem> TagMetadataItems, List<string> UsageExamples, bool? ShowInContentEditor, string TypeOf, string BindIdentifierToProperty, string BoundRegex, bool? ForceIdentifierBinding, bool? AllowComments, bool? AutoEnglishPropertyFallback, bool? BulkUploadable, List<ContentModelsContentPreview> Previews, bool? SuppressCmsPath, List<ContentModelsContentTypePropertySection> PropertySections)
        {
            
            this.CType = CType;
            
            this.Name = Name;
            
            this.ContentDescription = ContentDescription;
            
            this.PreviewImage = PreviewImage;
            
            this.Priority = Priority;
            
            this.Reminder = Reminder;
            
            this.Properties = Properties;
            
            this.TagMetadata = TagMetadata;
            
            this.TagMetadataItems = TagMetadataItems;
            
            this.UsageExamples = UsageExamples;
            
            this.ShowInContentEditor = ShowInContentEditor;
            
            this.TypeOf = TypeOf;
            
            this.BindIdentifierToProperty = BindIdentifierToProperty;
            
            this.BoundRegex = BoundRegex;
            
            this.ForceIdentifierBinding = ForceIdentifierBinding;
            
            this.AllowComments = AllowComments;
            
            this.AutoEnglishPropertyFallback = AutoEnglishPropertyFallback;
            
            this.BulkUploadable = BulkUploadable;
            
            this.Previews = Previews;
            
            this.SuppressCmsPath = SuppressCmsPath;
            
            this.PropertySections = PropertySections;
            
        }

        /// <summary>
        /// Returns builder of ContentModelsContentTypeDescription.
        /// </summary>
        /// <returns>ContentModelsContentTypeDescriptionBuilder</returns>
        public static ContentModelsContentTypeDescriptionBuilder Builder()
        {
            return new ContentModelsContentTypeDescriptionBuilder();
        }

        /// <summary>
        /// Returns ContentModelsContentTypeDescriptionBuilder with properties set.
        /// Use it to change properties.
        /// </summary>
        /// <returns>ContentModelsContentTypeDescriptionBuilder</returns>
        public ContentModelsContentTypeDescriptionBuilder With()
        {
            return Builder()
                .CType(CType)
                .Name(Name)
                .ContentDescription(ContentDescription)
                .PreviewImage(PreviewImage)
                .Priority(Priority)
                .Reminder(Reminder)
                .Properties(Properties)
                .TagMetadata(TagMetadata)
                .TagMetadataItems(TagMetadataItems)
                .UsageExamples(UsageExamples)
                .ShowInContentEditor(ShowInContentEditor)
                .TypeOf(TypeOf)
                .BindIdentifierToProperty(BindIdentifierToProperty)
                .BoundRegex(BoundRegex)
                .ForceIdentifierBinding(ForceIdentifierBinding)
                .AllowComments(AllowComments)
                .AutoEnglishPropertyFallback(AutoEnglishPropertyFallback)
                .BulkUploadable(BulkUploadable)
                .Previews(Previews)
                .SuppressCmsPath(SuppressCmsPath)
                .PropertySections(PropertySections);
        }

        public override string ToString()
        {
            return this.PropertiesToString();
        }

        public override bool Equals(object obj)
        {
            return this.EqualsByProperties(obj);
        }

        public bool Equals(ContentModelsContentTypeDescription other)
        {
            return Equals((object) other);
        }

        public override int GetHashCode()
        {
            return this.PropertiesHash();
        }

        /// <summary>
        /// Implementation of == operator for (ContentModelsContentTypeDescription.
        /// </summary>
        /// <param name="left">Compared (ContentModelsContentTypeDescription</param>
        /// <param name="right">Compared (ContentModelsContentTypeDescription</param>
        /// <returns>true if compared items are equals, false otherwise</returns>
        public static bool operator == (ContentModelsContentTypeDescription left, ContentModelsContentTypeDescription right)
        {
            return Equals(left, right);
        }

        /// <summary>
        /// Implementation of != operator for (ContentModelsContentTypeDescription.
        /// </summary>
        /// <param name="left">Compared (ContentModelsContentTypeDescription</param>
        /// <param name="right">Compared (ContentModelsContentTypeDescription</param>
        /// <returns>true if compared items are not equals, false otherwise</returns>
        public static bool operator != (ContentModelsContentTypeDescription left, ContentModelsContentTypeDescription right)
        {
            return !Equals(left, right);
        }

        /// <summary>
        /// Builder of ContentModelsContentTypeDescription.
        /// </summary>
        public sealed class ContentModelsContentTypeDescriptionBuilder
        {
            private string _CType;
            private string _Name;
            private string _ContentDescription;
            private string _PreviewImage;
            private int? _Priority;
            private string _Reminder;
            private List<ContentModelsContentTypeProperty> _Properties;
            private List<ContentModelsTagMetadataDefinition> _TagMetadata;
            private Dictionary<string, ContentModelsTagMetadataItem> _TagMetadataItems;
            private List<string> _UsageExamples;
            private bool? _ShowInContentEditor;
            private string _TypeOf;
            private string _BindIdentifierToProperty;
            private string _BoundRegex;
            private bool? _ForceIdentifierBinding;
            private bool? _AllowComments;
            private bool? _AutoEnglishPropertyFallback;
            private bool? _BulkUploadable;
            private List<ContentModelsContentPreview> _Previews;
            private bool? _SuppressCmsPath;
            private List<ContentModelsContentTypePropertySection> _PropertySections;

            internal ContentModelsContentTypeDescriptionBuilder()
            {
                SetupDefaults();
            }

            private void SetupDefaults()
            {
            }

            /// <summary>
            /// Sets value for ContentModelsContentTypeDescription.CType property.
            /// </summary>
            /// <param name="value">CType</param>
            public ContentModelsContentTypeDescriptionBuilder CType(string value)
            {
                _CType = value;
                return this;
            }

            /// <summary>
            /// Sets value for ContentModelsContentTypeDescription.Name property.
            /// </summary>
            /// <param name="value">Name</param>
            public ContentModelsContentTypeDescriptionBuilder Name(string value)
            {
                _Name = value;
                return this;
            }

            /// <summary>
            /// Sets value for ContentModelsContentTypeDescription.ContentDescription property.
            /// </summary>
            /// <param name="value">ContentDescription</param>
            public ContentModelsContentTypeDescriptionBuilder ContentDescription(string value)
            {
                _ContentDescription = value;
                return this;
            }

            /// <summary>
            /// Sets value for ContentModelsContentTypeDescription.PreviewImage property.
            /// </summary>
            /// <param name="value">PreviewImage</param>
            public ContentModelsContentTypeDescriptionBuilder PreviewImage(string value)
            {
                _PreviewImage = value;
                return this;
            }

            /// <summary>
            /// Sets value for ContentModelsContentTypeDescription.Priority property.
            /// </summary>
            /// <param name="value">Priority</param>
            public ContentModelsContentTypeDescriptionBuilder Priority(int? value)
            {
                _Priority = value;
                return this;
            }

            /// <summary>
            /// Sets value for ContentModelsContentTypeDescription.Reminder property.
            /// </summary>
            /// <param name="value">Reminder</param>
            public ContentModelsContentTypeDescriptionBuilder Reminder(string value)
            {
                _Reminder = value;
                return this;
            }

            /// <summary>
            /// Sets value for ContentModelsContentTypeDescription.Properties property.
            /// </summary>
            /// <param name="value">Properties</param>
            public ContentModelsContentTypeDescriptionBuilder Properties(List<ContentModelsContentTypeProperty> value)
            {
                _Properties = value;
                return this;
            }

            /// <summary>
            /// Sets value for ContentModelsContentTypeDescription.TagMetadata property.
            /// </summary>
            /// <param name="value">TagMetadata</param>
            public ContentModelsContentTypeDescriptionBuilder TagMetadata(List<ContentModelsTagMetadataDefinition> value)
            {
                _TagMetadata = value;
                return this;
            }

            /// <summary>
            /// Sets value for ContentModelsContentTypeDescription.TagMetadataItems property.
            /// </summary>
            /// <param name="value">TagMetadataItems</param>
            public ContentModelsContentTypeDescriptionBuilder TagMetadataItems(Dictionary<string, ContentModelsTagMetadataItem> value)
            {
                _TagMetadataItems = value;
                return this;
            }

            /// <summary>
            /// Sets value for ContentModelsContentTypeDescription.UsageExamples property.
            /// </summary>
            /// <param name="value">UsageExamples</param>
            public ContentModelsContentTypeDescriptionBuilder UsageExamples(List<string> value)
            {
                _UsageExamples = value;
                return this;
            }

            /// <summary>
            /// Sets value for ContentModelsContentTypeDescription.ShowInContentEditor property.
            /// </summary>
            /// <param name="value">ShowInContentEditor</param>
            public ContentModelsContentTypeDescriptionBuilder ShowInContentEditor(bool? value)
            {
                _ShowInContentEditor = value;
                return this;
            }

            /// <summary>
            /// Sets value for ContentModelsContentTypeDescription.TypeOf property.
            /// </summary>
            /// <param name="value">TypeOf</param>
            public ContentModelsContentTypeDescriptionBuilder TypeOf(string value)
            {
                _TypeOf = value;
                return this;
            }

            /// <summary>
            /// Sets value for ContentModelsContentTypeDescription.BindIdentifierToProperty property.
            /// </summary>
            /// <param name="value">BindIdentifierToProperty</param>
            public ContentModelsContentTypeDescriptionBuilder BindIdentifierToProperty(string value)
            {
                _BindIdentifierToProperty = value;
                return this;
            }

            /// <summary>
            /// Sets value for ContentModelsContentTypeDescription.BoundRegex property.
            /// </summary>
            /// <param name="value">BoundRegex</param>
            public ContentModelsContentTypeDescriptionBuilder BoundRegex(string value)
            {
                _BoundRegex = value;
                return this;
            }

            /// <summary>
            /// Sets value for ContentModelsContentTypeDescription.ForceIdentifierBinding property.
            /// </summary>
            /// <param name="value">ForceIdentifierBinding</param>
            public ContentModelsContentTypeDescriptionBuilder ForceIdentifierBinding(bool? value)
            {
                _ForceIdentifierBinding = value;
                return this;
            }

            /// <summary>
            /// Sets value for ContentModelsContentTypeDescription.AllowComments property.
            /// </summary>
            /// <param name="value">AllowComments</param>
            public ContentModelsContentTypeDescriptionBuilder AllowComments(bool? value)
            {
                _AllowComments = value;
                return this;
            }

            /// <summary>
            /// Sets value for ContentModelsContentTypeDescription.AutoEnglishPropertyFallback property.
            /// </summary>
            /// <param name="value">AutoEnglishPropertyFallback</param>
            public ContentModelsContentTypeDescriptionBuilder AutoEnglishPropertyFallback(bool? value)
            {
                _AutoEnglishPropertyFallback = value;
                return this;
            }

            /// <summary>
            /// Sets value for ContentModelsContentTypeDescription.BulkUploadable property.
            /// </summary>
            /// <param name="value">BulkUploadable</param>
            public ContentModelsContentTypeDescriptionBuilder BulkUploadable(bool? value)
            {
                _BulkUploadable = value;
                return this;
            }

            /// <summary>
            /// Sets value for ContentModelsContentTypeDescription.Previews property.
            /// </summary>
            /// <param name="value">Previews</param>
            public ContentModelsContentTypeDescriptionBuilder Previews(List<ContentModelsContentPreview> value)
            {
                _Previews = value;
                return this;
            }

            /// <summary>
            /// Sets value for ContentModelsContentTypeDescription.SuppressCmsPath property.
            /// </summary>
            /// <param name="value">SuppressCmsPath</param>
            public ContentModelsContentTypeDescriptionBuilder SuppressCmsPath(bool? value)
            {
                _SuppressCmsPath = value;
                return this;
            }

            /// <summary>
            /// Sets value for ContentModelsContentTypeDescription.PropertySections property.
            /// </summary>
            /// <param name="value">PropertySections</param>
            public ContentModelsContentTypeDescriptionBuilder PropertySections(List<ContentModelsContentTypePropertySection> value)
            {
                _PropertySections = value;
                return this;
            }


            /// <summary>
            /// Builds instance of ContentModelsContentTypeDescription.
            /// </summary>
            /// <returns>ContentModelsContentTypeDescription</returns>
            public ContentModelsContentTypeDescription Build()
            {
                Validate();
                return new ContentModelsContentTypeDescription(
                    CType: _CType,
                    Name: _Name,
                    ContentDescription: _ContentDescription,
                    PreviewImage: _PreviewImage,
                    Priority: _Priority,
                    Reminder: _Reminder,
                    Properties: _Properties,
                    TagMetadata: _TagMetadata,
                    TagMetadataItems: _TagMetadataItems,
                    UsageExamples: _UsageExamples,
                    ShowInContentEditor: _ShowInContentEditor,
                    TypeOf: _TypeOf,
                    BindIdentifierToProperty: _BindIdentifierToProperty,
                    BoundRegex: _BoundRegex,
                    ForceIdentifierBinding: _ForceIdentifierBinding,
                    AllowComments: _AllowComments,
                    AutoEnglishPropertyFallback: _AutoEnglishPropertyFallback,
                    BulkUploadable: _BulkUploadable,
                    Previews: _Previews,
                    SuppressCmsPath: _SuppressCmsPath,
                    PropertySections: _PropertySections
                );
            }

            private void Validate()
            { 
            }
        }

        
    }
}