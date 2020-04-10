using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Sharpility.Extensions;
using NodaTime;

namespace BungieNetApi._Platform.Models
{
    /// <summary>
    /// ContentModelsContentTypeProperty
    /// </summary>
    public sealed class ContentModelsContentTypeProperty:  IEquatable<ContentModelsContentTypeProperty>
    { 
        /// <summary>
        /// Name
        /// </summary>
        public string Name { get; private set; }

        /// <summary>
        /// RootPropertyName
        /// </summary>
        public string RootPropertyName { get; private set; }

        /// <summary>
        /// ReadableName
        /// </summary>
        public string ReadableName { get; private set; }

        /// <summary>
        /// Value
        /// </summary>
        public string Value { get; private set; }

        /// <summary>
        /// PropertyDescription
        /// </summary>
        public string PropertyDescription { get; private set; }

        /// <summary>
        /// Localizable
        /// </summary>
        public bool? Localizable { get; private set; }

        /// <summary>
        /// Fallback
        /// </summary>
        public bool? Fallback { get; private set; }

        /// <summary>
        /// Enabled
        /// </summary>
        public bool? Enabled { get; private set; }

        /// <summary>
        /// Order
        /// </summary>
        public int? Order { get; private set; }

        /// <summary>
        /// Visible
        /// </summary>
        public bool? Visible { get; private set; }

        /// <summary>
        /// IsTitle
        /// </summary>
        public bool? IsTitle { get; private set; }

        /// <summary>
        /// Required
        /// </summary>
        public bool? Required { get; private set; }

        /// <summary>
        /// MaxLength
        /// </summary>
        public int? MaxLength { get; private set; }

        /// <summary>
        /// MaxByteLength
        /// </summary>
        public int? MaxByteLength { get; private set; }

        /// <summary>
        /// MaxFileSize
        /// </summary>
        public int? MaxFileSize { get; private set; }

        /// <summary>
        /// Regexp
        /// </summary>
        public string Regexp { get; private set; }

        /// <summary>
        /// ValidateAs
        /// </summary>
        public string ValidateAs { get; private set; }

        /// <summary>
        /// RssAttribute
        /// </summary>
        public string RssAttribute { get; private set; }

        /// <summary>
        /// VisibleDependency
        /// </summary>
        public string VisibleDependency { get; private set; }

        /// <summary>
        /// VisibleOn
        /// </summary>
        public string VisibleOn { get; private set; }

        /// <summary>
        /// Datatype
        /// </summary>
        public int? Datatype { get; private set; }

        /// <summary>
        /// Attributes
        /// </summary>
        public Dictionary<string, string> Attributes { get; private set; }

        /// <summary>
        /// ChildProperties
        /// </summary>
        public List<ContentModelsContentTypeProperty> ChildProperties { get; private set; }

        /// <summary>
        /// ContentTypeAllowed
        /// </summary>
        public string ContentTypeAllowed { get; private set; }

        /// <summary>
        /// BindToProperty
        /// </summary>
        public string BindToProperty { get; private set; }

        /// <summary>
        /// BoundRegex
        /// </summary>
        public string BoundRegex { get; private set; }

        /// <summary>
        /// RepresentationSelection
        /// </summary>
        public Dictionary<string, string> RepresentationSelection { get; private set; }

        /// <summary>
        /// DefaultValues
        /// </summary>
        public List<ContentModelsContentTypeDefaultValue> DefaultValues { get; private set; }

        /// <summary>
        /// IsExternalAllowed
        /// </summary>
        public bool? IsExternalAllowed { get; private set; }

        /// <summary>
        /// PropertySection
        /// </summary>
        public string PropertySection { get; private set; }

        /// <summary>
        /// Weight
        /// </summary>
        public int? Weight { get; private set; }

        /// <summary>
        /// Entitytype
        /// </summary>
        public string Entitytype { get; private set; }

        /// <summary>
        /// IsCombo
        /// </summary>
        public bool? IsCombo { get; private set; }

        /// <summary>
        /// SuppressProperty
        /// </summary>
        public bool? SuppressProperty { get; private set; }

        /// <summary>
        /// LegalContentTypes
        /// </summary>
        public List<string> LegalContentTypes { get; private set; }

        /// <summary>
        /// RepresentationValidationString
        /// </summary>
        public string RepresentationValidationString { get; private set; }

        /// <summary>
        /// MinWidth
        /// </summary>
        public int? MinWidth { get; private set; }

        /// <summary>
        /// MaxWidth
        /// </summary>
        public int? MaxWidth { get; private set; }

        /// <summary>
        /// MinHeight
        /// </summary>
        public int? MinHeight { get; private set; }

        /// <summary>
        /// MaxHeight
        /// </summary>
        public int? MaxHeight { get; private set; }

        /// <summary>
        /// IsVideo
        /// </summary>
        public bool? IsVideo { get; private set; }

        /// <summary>
        /// IsImage
        /// </summary>
        public bool? IsImage { get; private set; }


        /// <summary>
        /// Empty constructor required by some serializers.
        /// Use ContentModelsContentTypeProperty.Builder() for instance creation instead.
        /// </summary>
        [Obsolete]
        public ContentModelsContentTypeProperty()
        {
        }

        private ContentModelsContentTypeProperty(string Name, string RootPropertyName, string ReadableName, string Value, string PropertyDescription, bool? Localizable, bool? Fallback, bool? Enabled, int? Order, bool? Visible, bool? IsTitle, bool? Required, int? MaxLength, int? MaxByteLength, int? MaxFileSize, string Regexp, string ValidateAs, string RssAttribute, string VisibleDependency, string VisibleOn, int? Datatype, Dictionary<string, string> Attributes, List<ContentModelsContentTypeProperty> ChildProperties, string ContentTypeAllowed, string BindToProperty, string BoundRegex, Dictionary<string, string> RepresentationSelection, List<ContentModelsContentTypeDefaultValue> DefaultValues, bool? IsExternalAllowed, string PropertySection, int? Weight, string Entitytype, bool? IsCombo, bool? SuppressProperty, List<string> LegalContentTypes, string RepresentationValidationString, int? MinWidth, int? MaxWidth, int? MinHeight, int? MaxHeight, bool? IsVideo, bool? IsImage)
        {
            
            this.Name = Name;
            
            this.RootPropertyName = RootPropertyName;
            
            this.ReadableName = ReadableName;
            
            this.Value = Value;
            
            this.PropertyDescription = PropertyDescription;
            
            this.Localizable = Localizable;
            
            this.Fallback = Fallback;
            
            this.Enabled = Enabled;
            
            this.Order = Order;
            
            this.Visible = Visible;
            
            this.IsTitle = IsTitle;
            
            this.Required = Required;
            
            this.MaxLength = MaxLength;
            
            this.MaxByteLength = MaxByteLength;
            
            this.MaxFileSize = MaxFileSize;
            
            this.Regexp = Regexp;
            
            this.ValidateAs = ValidateAs;
            
            this.RssAttribute = RssAttribute;
            
            this.VisibleDependency = VisibleDependency;
            
            this.VisibleOn = VisibleOn;
            
            this.Datatype = Datatype;
            
            this.Attributes = Attributes;
            
            this.ChildProperties = ChildProperties;
            
            this.ContentTypeAllowed = ContentTypeAllowed;
            
            this.BindToProperty = BindToProperty;
            
            this.BoundRegex = BoundRegex;
            
            this.RepresentationSelection = RepresentationSelection;
            
            this.DefaultValues = DefaultValues;
            
            this.IsExternalAllowed = IsExternalAllowed;
            
            this.PropertySection = PropertySection;
            
            this.Weight = Weight;
            
            this.Entitytype = Entitytype;
            
            this.IsCombo = IsCombo;
            
            this.SuppressProperty = SuppressProperty;
            
            this.LegalContentTypes = LegalContentTypes;
            
            this.RepresentationValidationString = RepresentationValidationString;
            
            this.MinWidth = MinWidth;
            
            this.MaxWidth = MaxWidth;
            
            this.MinHeight = MinHeight;
            
            this.MaxHeight = MaxHeight;
            
            this.IsVideo = IsVideo;
            
            this.IsImage = IsImage;
            
        }

        /// <summary>
        /// Returns builder of ContentModelsContentTypeProperty.
        /// </summary>
        /// <returns>ContentModelsContentTypePropertyBuilder</returns>
        public static ContentModelsContentTypePropertyBuilder Builder()
        {
            return new ContentModelsContentTypePropertyBuilder();
        }

        /// <summary>
        /// Returns ContentModelsContentTypePropertyBuilder with properties set.
        /// Use it to change properties.
        /// </summary>
        /// <returns>ContentModelsContentTypePropertyBuilder</returns>
        public ContentModelsContentTypePropertyBuilder With()
        {
            return Builder()
                .Name(Name)
                .RootPropertyName(RootPropertyName)
                .ReadableName(ReadableName)
                .Value(Value)
                .PropertyDescription(PropertyDescription)
                .Localizable(Localizable)
                .Fallback(Fallback)
                .Enabled(Enabled)
                .Order(Order)
                .Visible(Visible)
                .IsTitle(IsTitle)
                .Required(Required)
                .MaxLength(MaxLength)
                .MaxByteLength(MaxByteLength)
                .MaxFileSize(MaxFileSize)
                .Regexp(Regexp)
                .ValidateAs(ValidateAs)
                .RssAttribute(RssAttribute)
                .VisibleDependency(VisibleDependency)
                .VisibleOn(VisibleOn)
                .Datatype(Datatype)
                .Attributes(Attributes)
                .ChildProperties(ChildProperties)
                .ContentTypeAllowed(ContentTypeAllowed)
                .BindToProperty(BindToProperty)
                .BoundRegex(BoundRegex)
                .RepresentationSelection(RepresentationSelection)
                .DefaultValues(DefaultValues)
                .IsExternalAllowed(IsExternalAllowed)
                .PropertySection(PropertySection)
                .Weight(Weight)
                .Entitytype(Entitytype)
                .IsCombo(IsCombo)
                .SuppressProperty(SuppressProperty)
                .LegalContentTypes(LegalContentTypes)
                .RepresentationValidationString(RepresentationValidationString)
                .MinWidth(MinWidth)
                .MaxWidth(MaxWidth)
                .MinHeight(MinHeight)
                .MaxHeight(MaxHeight)
                .IsVideo(IsVideo)
                .IsImage(IsImage);
        }

        public override string ToString()
        {
            return this.PropertiesToString();
        }

        public override bool Equals(object obj)
        {
            return this.EqualsByProperties(obj);
        }

        public bool Equals(ContentModelsContentTypeProperty other)
        {
            return Equals((object) other);
        }

        public override int GetHashCode()
        {
            return this.PropertiesHash();
        }

        /// <summary>
        /// Implementation of == operator for (ContentModelsContentTypeProperty.
        /// </summary>
        /// <param name="left">Compared (ContentModelsContentTypeProperty</param>
        /// <param name="right">Compared (ContentModelsContentTypeProperty</param>
        /// <returns>true if compared items are equals, false otherwise</returns>
        public static bool operator == (ContentModelsContentTypeProperty left, ContentModelsContentTypeProperty right)
        {
            return Equals(left, right);
        }

        /// <summary>
        /// Implementation of != operator for (ContentModelsContentTypeProperty.
        /// </summary>
        /// <param name="left">Compared (ContentModelsContentTypeProperty</param>
        /// <param name="right">Compared (ContentModelsContentTypeProperty</param>
        /// <returns>true if compared items are not equals, false otherwise</returns>
        public static bool operator != (ContentModelsContentTypeProperty left, ContentModelsContentTypeProperty right)
        {
            return !Equals(left, right);
        }

        /// <summary>
        /// Builder of ContentModelsContentTypeProperty.
        /// </summary>
        public sealed class ContentModelsContentTypePropertyBuilder
        {
            private string _Name;
            private string _RootPropertyName;
            private string _ReadableName;
            private string _Value;
            private string _PropertyDescription;
            private bool? _Localizable;
            private bool? _Fallback;
            private bool? _Enabled;
            private int? _Order;
            private bool? _Visible;
            private bool? _IsTitle;
            private bool? _Required;
            private int? _MaxLength;
            private int? _MaxByteLength;
            private int? _MaxFileSize;
            private string _Regexp;
            private string _ValidateAs;
            private string _RssAttribute;
            private string _VisibleDependency;
            private string _VisibleOn;
            private int? _Datatype;
            private Dictionary<string, string> _Attributes;
            private List<ContentModelsContentTypeProperty> _ChildProperties;
            private string _ContentTypeAllowed;
            private string _BindToProperty;
            private string _BoundRegex;
            private Dictionary<string, string> _RepresentationSelection;
            private List<ContentModelsContentTypeDefaultValue> _DefaultValues;
            private bool? _IsExternalAllowed;
            private string _PropertySection;
            private int? _Weight;
            private string _Entitytype;
            private bool? _IsCombo;
            private bool? _SuppressProperty;
            private List<string> _LegalContentTypes;
            private string _RepresentationValidationString;
            private int? _MinWidth;
            private int? _MaxWidth;
            private int? _MinHeight;
            private int? _MaxHeight;
            private bool? _IsVideo;
            private bool? _IsImage;

            internal ContentModelsContentTypePropertyBuilder()
            {
                SetupDefaults();
            }

            private void SetupDefaults()
            {
            }

            /// <summary>
            /// Sets value for ContentModelsContentTypeProperty.Name property.
            /// </summary>
            /// <param name="value">Name</param>
            public ContentModelsContentTypePropertyBuilder Name(string value)
            {
                _Name = value;
                return this;
            }

            /// <summary>
            /// Sets value for ContentModelsContentTypeProperty.RootPropertyName property.
            /// </summary>
            /// <param name="value">RootPropertyName</param>
            public ContentModelsContentTypePropertyBuilder RootPropertyName(string value)
            {
                _RootPropertyName = value;
                return this;
            }

            /// <summary>
            /// Sets value for ContentModelsContentTypeProperty.ReadableName property.
            /// </summary>
            /// <param name="value">ReadableName</param>
            public ContentModelsContentTypePropertyBuilder ReadableName(string value)
            {
                _ReadableName = value;
                return this;
            }

            /// <summary>
            /// Sets value for ContentModelsContentTypeProperty.Value property.
            /// </summary>
            /// <param name="value">Value</param>
            public ContentModelsContentTypePropertyBuilder Value(string value)
            {
                _Value = value;
                return this;
            }

            /// <summary>
            /// Sets value for ContentModelsContentTypeProperty.PropertyDescription property.
            /// </summary>
            /// <param name="value">PropertyDescription</param>
            public ContentModelsContentTypePropertyBuilder PropertyDescription(string value)
            {
                _PropertyDescription = value;
                return this;
            }

            /// <summary>
            /// Sets value for ContentModelsContentTypeProperty.Localizable property.
            /// </summary>
            /// <param name="value">Localizable</param>
            public ContentModelsContentTypePropertyBuilder Localizable(bool? value)
            {
                _Localizable = value;
                return this;
            }

            /// <summary>
            /// Sets value for ContentModelsContentTypeProperty.Fallback property.
            /// </summary>
            /// <param name="value">Fallback</param>
            public ContentModelsContentTypePropertyBuilder Fallback(bool? value)
            {
                _Fallback = value;
                return this;
            }

            /// <summary>
            /// Sets value for ContentModelsContentTypeProperty.Enabled property.
            /// </summary>
            /// <param name="value">Enabled</param>
            public ContentModelsContentTypePropertyBuilder Enabled(bool? value)
            {
                _Enabled = value;
                return this;
            }

            /// <summary>
            /// Sets value for ContentModelsContentTypeProperty.Order property.
            /// </summary>
            /// <param name="value">Order</param>
            public ContentModelsContentTypePropertyBuilder Order(int? value)
            {
                _Order = value;
                return this;
            }

            /// <summary>
            /// Sets value for ContentModelsContentTypeProperty.Visible property.
            /// </summary>
            /// <param name="value">Visible</param>
            public ContentModelsContentTypePropertyBuilder Visible(bool? value)
            {
                _Visible = value;
                return this;
            }

            /// <summary>
            /// Sets value for ContentModelsContentTypeProperty.IsTitle property.
            /// </summary>
            /// <param name="value">IsTitle</param>
            public ContentModelsContentTypePropertyBuilder IsTitle(bool? value)
            {
                _IsTitle = value;
                return this;
            }

            /// <summary>
            /// Sets value for ContentModelsContentTypeProperty.Required property.
            /// </summary>
            /// <param name="value">Required</param>
            public ContentModelsContentTypePropertyBuilder Required(bool? value)
            {
                _Required = value;
                return this;
            }

            /// <summary>
            /// Sets value for ContentModelsContentTypeProperty.MaxLength property.
            /// </summary>
            /// <param name="value">MaxLength</param>
            public ContentModelsContentTypePropertyBuilder MaxLength(int? value)
            {
                _MaxLength = value;
                return this;
            }

            /// <summary>
            /// Sets value for ContentModelsContentTypeProperty.MaxByteLength property.
            /// </summary>
            /// <param name="value">MaxByteLength</param>
            public ContentModelsContentTypePropertyBuilder MaxByteLength(int? value)
            {
                _MaxByteLength = value;
                return this;
            }

            /// <summary>
            /// Sets value for ContentModelsContentTypeProperty.MaxFileSize property.
            /// </summary>
            /// <param name="value">MaxFileSize</param>
            public ContentModelsContentTypePropertyBuilder MaxFileSize(int? value)
            {
                _MaxFileSize = value;
                return this;
            }

            /// <summary>
            /// Sets value for ContentModelsContentTypeProperty.Regexp property.
            /// </summary>
            /// <param name="value">Regexp</param>
            public ContentModelsContentTypePropertyBuilder Regexp(string value)
            {
                _Regexp = value;
                return this;
            }

            /// <summary>
            /// Sets value for ContentModelsContentTypeProperty.ValidateAs property.
            /// </summary>
            /// <param name="value">ValidateAs</param>
            public ContentModelsContentTypePropertyBuilder ValidateAs(string value)
            {
                _ValidateAs = value;
                return this;
            }

            /// <summary>
            /// Sets value for ContentModelsContentTypeProperty.RssAttribute property.
            /// </summary>
            /// <param name="value">RssAttribute</param>
            public ContentModelsContentTypePropertyBuilder RssAttribute(string value)
            {
                _RssAttribute = value;
                return this;
            }

            /// <summary>
            /// Sets value for ContentModelsContentTypeProperty.VisibleDependency property.
            /// </summary>
            /// <param name="value">VisibleDependency</param>
            public ContentModelsContentTypePropertyBuilder VisibleDependency(string value)
            {
                _VisibleDependency = value;
                return this;
            }

            /// <summary>
            /// Sets value for ContentModelsContentTypeProperty.VisibleOn property.
            /// </summary>
            /// <param name="value">VisibleOn</param>
            public ContentModelsContentTypePropertyBuilder VisibleOn(string value)
            {
                _VisibleOn = value;
                return this;
            }

            /// <summary>
            /// Sets value for ContentModelsContentTypeProperty.Datatype property.
            /// </summary>
            /// <param name="value">Datatype</param>
            public ContentModelsContentTypePropertyBuilder Datatype(int? value)
            {
                _Datatype = value;
                return this;
            }

            /// <summary>
            /// Sets value for ContentModelsContentTypeProperty.Attributes property.
            /// </summary>
            /// <param name="value">Attributes</param>
            public ContentModelsContentTypePropertyBuilder Attributes(Dictionary<string, string> value)
            {
                _Attributes = value;
                return this;
            }

            /// <summary>
            /// Sets value for ContentModelsContentTypeProperty.ChildProperties property.
            /// </summary>
            /// <param name="value">ChildProperties</param>
            public ContentModelsContentTypePropertyBuilder ChildProperties(List<ContentModelsContentTypeProperty> value)
            {
                _ChildProperties = value;
                return this;
            }

            /// <summary>
            /// Sets value for ContentModelsContentTypeProperty.ContentTypeAllowed property.
            /// </summary>
            /// <param name="value">ContentTypeAllowed</param>
            public ContentModelsContentTypePropertyBuilder ContentTypeAllowed(string value)
            {
                _ContentTypeAllowed = value;
                return this;
            }

            /// <summary>
            /// Sets value for ContentModelsContentTypeProperty.BindToProperty property.
            /// </summary>
            /// <param name="value">BindToProperty</param>
            public ContentModelsContentTypePropertyBuilder BindToProperty(string value)
            {
                _BindToProperty = value;
                return this;
            }

            /// <summary>
            /// Sets value for ContentModelsContentTypeProperty.BoundRegex property.
            /// </summary>
            /// <param name="value">BoundRegex</param>
            public ContentModelsContentTypePropertyBuilder BoundRegex(string value)
            {
                _BoundRegex = value;
                return this;
            }

            /// <summary>
            /// Sets value for ContentModelsContentTypeProperty.RepresentationSelection property.
            /// </summary>
            /// <param name="value">RepresentationSelection</param>
            public ContentModelsContentTypePropertyBuilder RepresentationSelection(Dictionary<string, string> value)
            {
                _RepresentationSelection = value;
                return this;
            }

            /// <summary>
            /// Sets value for ContentModelsContentTypeProperty.DefaultValues property.
            /// </summary>
            /// <param name="value">DefaultValues</param>
            public ContentModelsContentTypePropertyBuilder DefaultValues(List<ContentModelsContentTypeDefaultValue> value)
            {
                _DefaultValues = value;
                return this;
            }

            /// <summary>
            /// Sets value for ContentModelsContentTypeProperty.IsExternalAllowed property.
            /// </summary>
            /// <param name="value">IsExternalAllowed</param>
            public ContentModelsContentTypePropertyBuilder IsExternalAllowed(bool? value)
            {
                _IsExternalAllowed = value;
                return this;
            }

            /// <summary>
            /// Sets value for ContentModelsContentTypeProperty.PropertySection property.
            /// </summary>
            /// <param name="value">PropertySection</param>
            public ContentModelsContentTypePropertyBuilder PropertySection(string value)
            {
                _PropertySection = value;
                return this;
            }

            /// <summary>
            /// Sets value for ContentModelsContentTypeProperty.Weight property.
            /// </summary>
            /// <param name="value">Weight</param>
            public ContentModelsContentTypePropertyBuilder Weight(int? value)
            {
                _Weight = value;
                return this;
            }

            /// <summary>
            /// Sets value for ContentModelsContentTypeProperty.Entitytype property.
            /// </summary>
            /// <param name="value">Entitytype</param>
            public ContentModelsContentTypePropertyBuilder Entitytype(string value)
            {
                _Entitytype = value;
                return this;
            }

            /// <summary>
            /// Sets value for ContentModelsContentTypeProperty.IsCombo property.
            /// </summary>
            /// <param name="value">IsCombo</param>
            public ContentModelsContentTypePropertyBuilder IsCombo(bool? value)
            {
                _IsCombo = value;
                return this;
            }

            /// <summary>
            /// Sets value for ContentModelsContentTypeProperty.SuppressProperty property.
            /// </summary>
            /// <param name="value">SuppressProperty</param>
            public ContentModelsContentTypePropertyBuilder SuppressProperty(bool? value)
            {
                _SuppressProperty = value;
                return this;
            }

            /// <summary>
            /// Sets value for ContentModelsContentTypeProperty.LegalContentTypes property.
            /// </summary>
            /// <param name="value">LegalContentTypes</param>
            public ContentModelsContentTypePropertyBuilder LegalContentTypes(List<string> value)
            {
                _LegalContentTypes = value;
                return this;
            }

            /// <summary>
            /// Sets value for ContentModelsContentTypeProperty.RepresentationValidationString property.
            /// </summary>
            /// <param name="value">RepresentationValidationString</param>
            public ContentModelsContentTypePropertyBuilder RepresentationValidationString(string value)
            {
                _RepresentationValidationString = value;
                return this;
            }

            /// <summary>
            /// Sets value for ContentModelsContentTypeProperty.MinWidth property.
            /// </summary>
            /// <param name="value">MinWidth</param>
            public ContentModelsContentTypePropertyBuilder MinWidth(int? value)
            {
                _MinWidth = value;
                return this;
            }

            /// <summary>
            /// Sets value for ContentModelsContentTypeProperty.MaxWidth property.
            /// </summary>
            /// <param name="value">MaxWidth</param>
            public ContentModelsContentTypePropertyBuilder MaxWidth(int? value)
            {
                _MaxWidth = value;
                return this;
            }

            /// <summary>
            /// Sets value for ContentModelsContentTypeProperty.MinHeight property.
            /// </summary>
            /// <param name="value">MinHeight</param>
            public ContentModelsContentTypePropertyBuilder MinHeight(int? value)
            {
                _MinHeight = value;
                return this;
            }

            /// <summary>
            /// Sets value for ContentModelsContentTypeProperty.MaxHeight property.
            /// </summary>
            /// <param name="value">MaxHeight</param>
            public ContentModelsContentTypePropertyBuilder MaxHeight(int? value)
            {
                _MaxHeight = value;
                return this;
            }

            /// <summary>
            /// Sets value for ContentModelsContentTypeProperty.IsVideo property.
            /// </summary>
            /// <param name="value">IsVideo</param>
            public ContentModelsContentTypePropertyBuilder IsVideo(bool? value)
            {
                _IsVideo = value;
                return this;
            }

            /// <summary>
            /// Sets value for ContentModelsContentTypeProperty.IsImage property.
            /// </summary>
            /// <param name="value">IsImage</param>
            public ContentModelsContentTypePropertyBuilder IsImage(bool? value)
            {
                _IsImage = value;
                return this;
            }


            /// <summary>
            /// Builds instance of ContentModelsContentTypeProperty.
            /// </summary>
            /// <returns>ContentModelsContentTypeProperty</returns>
            public ContentModelsContentTypeProperty Build()
            {
                Validate();
                return new ContentModelsContentTypeProperty(
                    Name: _Name,
                    RootPropertyName: _RootPropertyName,
                    ReadableName: _ReadableName,
                    Value: _Value,
                    PropertyDescription: _PropertyDescription,
                    Localizable: _Localizable,
                    Fallback: _Fallback,
                    Enabled: _Enabled,
                    Order: _Order,
                    Visible: _Visible,
                    IsTitle: _IsTitle,
                    Required: _Required,
                    MaxLength: _MaxLength,
                    MaxByteLength: _MaxByteLength,
                    MaxFileSize: _MaxFileSize,
                    Regexp: _Regexp,
                    ValidateAs: _ValidateAs,
                    RssAttribute: _RssAttribute,
                    VisibleDependency: _VisibleDependency,
                    VisibleOn: _VisibleOn,
                    Datatype: _Datatype,
                    Attributes: _Attributes,
                    ChildProperties: _ChildProperties,
                    ContentTypeAllowed: _ContentTypeAllowed,
                    BindToProperty: _BindToProperty,
                    BoundRegex: _BoundRegex,
                    RepresentationSelection: _RepresentationSelection,
                    DefaultValues: _DefaultValues,
                    IsExternalAllowed: _IsExternalAllowed,
                    PropertySection: _PropertySection,
                    Weight: _Weight,
                    Entitytype: _Entitytype,
                    IsCombo: _IsCombo,
                    SuppressProperty: _SuppressProperty,
                    LegalContentTypes: _LegalContentTypes,
                    RepresentationValidationString: _RepresentationValidationString,
                    MinWidth: _MinWidth,
                    MaxWidth: _MaxWidth,
                    MinHeight: _MinHeight,
                    MaxHeight: _MaxHeight,
                    IsVideo: _IsVideo,
                    IsImage: _IsImage
                );
            }

            private void Validate()
            { 
            }
        }

        
    }
}