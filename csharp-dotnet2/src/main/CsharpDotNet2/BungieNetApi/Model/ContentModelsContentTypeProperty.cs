using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace BungieNetApi.Model {

  /// <summary>
  /// 
  /// </summary>
  [DataContract]
  public class ContentModelsContentTypeProperty {
    /// <summary>
    /// Gets or Sets Name
    /// </summary>
    [DataMember(Name="name", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "name")]
    public string Name { get; set; }

    /// <summary>
    /// Gets or Sets RootPropertyName
    /// </summary>
    [DataMember(Name="rootPropertyName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "rootPropertyName")]
    public string RootPropertyName { get; set; }

    /// <summary>
    /// Gets or Sets ReadableName
    /// </summary>
    [DataMember(Name="readableName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "readableName")]
    public string ReadableName { get; set; }

    /// <summary>
    /// Gets or Sets Value
    /// </summary>
    [DataMember(Name="value", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "value")]
    public string Value { get; set; }

    /// <summary>
    /// Gets or Sets PropertyDescription
    /// </summary>
    [DataMember(Name="propertyDescription", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "propertyDescription")]
    public string PropertyDescription { get; set; }

    /// <summary>
    /// Gets or Sets Localizable
    /// </summary>
    [DataMember(Name="localizable", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "localizable")]
    public bool? Localizable { get; set; }

    /// <summary>
    /// Gets or Sets Fallback
    /// </summary>
    [DataMember(Name="fallback", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "fallback")]
    public bool? Fallback { get; set; }

    /// <summary>
    /// Gets or Sets Enabled
    /// </summary>
    [DataMember(Name="enabled", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "enabled")]
    public bool? Enabled { get; set; }

    /// <summary>
    /// Gets or Sets Order
    /// </summary>
    [DataMember(Name="order", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "order")]
    public int? Order { get; set; }

    /// <summary>
    /// Gets or Sets Visible
    /// </summary>
    [DataMember(Name="visible", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "visible")]
    public bool? Visible { get; set; }

    /// <summary>
    /// Gets or Sets IsTitle
    /// </summary>
    [DataMember(Name="isTitle", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "isTitle")]
    public bool? IsTitle { get; set; }

    /// <summary>
    /// Gets or Sets Required
    /// </summary>
    [DataMember(Name="required", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "required")]
    public bool? Required { get; set; }

    /// <summary>
    /// Gets or Sets MaxLength
    /// </summary>
    [DataMember(Name="maxLength", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "maxLength")]
    public int? MaxLength { get; set; }

    /// <summary>
    /// Gets or Sets MaxByteLength
    /// </summary>
    [DataMember(Name="maxByteLength", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "maxByteLength")]
    public int? MaxByteLength { get; set; }

    /// <summary>
    /// Gets or Sets MaxFileSize
    /// </summary>
    [DataMember(Name="maxFileSize", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "maxFileSize")]
    public int? MaxFileSize { get; set; }

    /// <summary>
    /// Gets or Sets Regexp
    /// </summary>
    [DataMember(Name="regexp", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "regexp")]
    public string Regexp { get; set; }

    /// <summary>
    /// Gets or Sets ValidateAs
    /// </summary>
    [DataMember(Name="validateAs", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "validateAs")]
    public string ValidateAs { get; set; }

    /// <summary>
    /// Gets or Sets RssAttribute
    /// </summary>
    [DataMember(Name="rssAttribute", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "rssAttribute")]
    public string RssAttribute { get; set; }

    /// <summary>
    /// Gets or Sets VisibleDependency
    /// </summary>
    [DataMember(Name="visibleDependency", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "visibleDependency")]
    public string VisibleDependency { get; set; }

    /// <summary>
    /// Gets or Sets VisibleOn
    /// </summary>
    [DataMember(Name="visibleOn", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "visibleOn")]
    public string VisibleOn { get; set; }

    /// <summary>
    /// Gets or Sets Datatype
    /// </summary>
    [DataMember(Name="datatype", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "datatype")]
    public int? Datatype { get; set; }

    /// <summary>
    /// Gets or Sets Attributes
    /// </summary>
    [DataMember(Name="attributes", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "attributes")]
    public Dictionary<string, string> Attributes { get; set; }

    /// <summary>
    /// Gets or Sets ChildProperties
    /// </summary>
    [DataMember(Name="childProperties", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "childProperties")]
    public List<ContentModelsContentTypeProperty> ChildProperties { get; set; }

    /// <summary>
    /// Gets or Sets ContentTypeAllowed
    /// </summary>
    [DataMember(Name="contentTypeAllowed", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "contentTypeAllowed")]
    public string ContentTypeAllowed { get; set; }

    /// <summary>
    /// Gets or Sets BindToProperty
    /// </summary>
    [DataMember(Name="bindToProperty", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "bindToProperty")]
    public string BindToProperty { get; set; }

    /// <summary>
    /// Gets or Sets BoundRegex
    /// </summary>
    [DataMember(Name="boundRegex", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "boundRegex")]
    public string BoundRegex { get; set; }

    /// <summary>
    /// Gets or Sets RepresentationSelection
    /// </summary>
    [DataMember(Name="representationSelection", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "representationSelection")]
    public Dictionary<string, string> RepresentationSelection { get; set; }

    /// <summary>
    /// Gets or Sets DefaultValues
    /// </summary>
    [DataMember(Name="defaultValues", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "defaultValues")]
    public List<ContentModelsContentTypeDefaultValue> DefaultValues { get; set; }

    /// <summary>
    /// Gets or Sets IsExternalAllowed
    /// </summary>
    [DataMember(Name="isExternalAllowed", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "isExternalAllowed")]
    public bool? IsExternalAllowed { get; set; }

    /// <summary>
    /// Gets or Sets PropertySection
    /// </summary>
    [DataMember(Name="propertySection", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "propertySection")]
    public string PropertySection { get; set; }

    /// <summary>
    /// Gets or Sets Weight
    /// </summary>
    [DataMember(Name="weight", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "weight")]
    public int? Weight { get; set; }

    /// <summary>
    /// Gets or Sets Entitytype
    /// </summary>
    [DataMember(Name="entitytype", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "entitytype")]
    public string Entitytype { get; set; }

    /// <summary>
    /// Gets or Sets IsCombo
    /// </summary>
    [DataMember(Name="isCombo", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "isCombo")]
    public bool? IsCombo { get; set; }

    /// <summary>
    /// Gets or Sets SuppressProperty
    /// </summary>
    [DataMember(Name="suppressProperty", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "suppressProperty")]
    public bool? SuppressProperty { get; set; }

    /// <summary>
    /// Gets or Sets LegalContentTypes
    /// </summary>
    [DataMember(Name="legalContentTypes", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "legalContentTypes")]
    public List<string> LegalContentTypes { get; set; }

    /// <summary>
    /// Gets or Sets RepresentationValidationString
    /// </summary>
    [DataMember(Name="representationValidationString", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "representationValidationString")]
    public string RepresentationValidationString { get; set; }

    /// <summary>
    /// Gets or Sets MinWidth
    /// </summary>
    [DataMember(Name="minWidth", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "minWidth")]
    public int? MinWidth { get; set; }

    /// <summary>
    /// Gets or Sets MaxWidth
    /// </summary>
    [DataMember(Name="maxWidth", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "maxWidth")]
    public int? MaxWidth { get; set; }

    /// <summary>
    /// Gets or Sets MinHeight
    /// </summary>
    [DataMember(Name="minHeight", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "minHeight")]
    public int? MinHeight { get; set; }

    /// <summary>
    /// Gets or Sets MaxHeight
    /// </summary>
    [DataMember(Name="maxHeight", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "maxHeight")]
    public int? MaxHeight { get; set; }

    /// <summary>
    /// Gets or Sets IsVideo
    /// </summary>
    [DataMember(Name="isVideo", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "isVideo")]
    public bool? IsVideo { get; set; }

    /// <summary>
    /// Gets or Sets IsImage
    /// </summary>
    [DataMember(Name="isImage", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "isImage")]
    public bool? IsImage { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class ContentModelsContentTypeProperty {\n");
      sb.Append("  Name: ").Append(Name).Append("\n");
      sb.Append("  RootPropertyName: ").Append(RootPropertyName).Append("\n");
      sb.Append("  ReadableName: ").Append(ReadableName).Append("\n");
      sb.Append("  Value: ").Append(Value).Append("\n");
      sb.Append("  PropertyDescription: ").Append(PropertyDescription).Append("\n");
      sb.Append("  Localizable: ").Append(Localizable).Append("\n");
      sb.Append("  Fallback: ").Append(Fallback).Append("\n");
      sb.Append("  Enabled: ").Append(Enabled).Append("\n");
      sb.Append("  Order: ").Append(Order).Append("\n");
      sb.Append("  Visible: ").Append(Visible).Append("\n");
      sb.Append("  IsTitle: ").Append(IsTitle).Append("\n");
      sb.Append("  Required: ").Append(Required).Append("\n");
      sb.Append("  MaxLength: ").Append(MaxLength).Append("\n");
      sb.Append("  MaxByteLength: ").Append(MaxByteLength).Append("\n");
      sb.Append("  MaxFileSize: ").Append(MaxFileSize).Append("\n");
      sb.Append("  Regexp: ").Append(Regexp).Append("\n");
      sb.Append("  ValidateAs: ").Append(ValidateAs).Append("\n");
      sb.Append("  RssAttribute: ").Append(RssAttribute).Append("\n");
      sb.Append("  VisibleDependency: ").Append(VisibleDependency).Append("\n");
      sb.Append("  VisibleOn: ").Append(VisibleOn).Append("\n");
      sb.Append("  Datatype: ").Append(Datatype).Append("\n");
      sb.Append("  Attributes: ").Append(Attributes).Append("\n");
      sb.Append("  ChildProperties: ").Append(ChildProperties).Append("\n");
      sb.Append("  ContentTypeAllowed: ").Append(ContentTypeAllowed).Append("\n");
      sb.Append("  BindToProperty: ").Append(BindToProperty).Append("\n");
      sb.Append("  BoundRegex: ").Append(BoundRegex).Append("\n");
      sb.Append("  RepresentationSelection: ").Append(RepresentationSelection).Append("\n");
      sb.Append("  DefaultValues: ").Append(DefaultValues).Append("\n");
      sb.Append("  IsExternalAllowed: ").Append(IsExternalAllowed).Append("\n");
      sb.Append("  PropertySection: ").Append(PropertySection).Append("\n");
      sb.Append("  Weight: ").Append(Weight).Append("\n");
      sb.Append("  Entitytype: ").Append(Entitytype).Append("\n");
      sb.Append("  IsCombo: ").Append(IsCombo).Append("\n");
      sb.Append("  SuppressProperty: ").Append(SuppressProperty).Append("\n");
      sb.Append("  LegalContentTypes: ").Append(LegalContentTypes).Append("\n");
      sb.Append("  RepresentationValidationString: ").Append(RepresentationValidationString).Append("\n");
      sb.Append("  MinWidth: ").Append(MinWidth).Append("\n");
      sb.Append("  MaxWidth: ").Append(MaxWidth).Append("\n");
      sb.Append("  MinHeight: ").Append(MinHeight).Append("\n");
      sb.Append("  MaxHeight: ").Append(MaxHeight).Append("\n");
      sb.Append("  IsVideo: ").Append(IsVideo).Append("\n");
      sb.Append("  IsImage: ").Append(IsImage).Append("\n");
      sb.Append("}\n");
      return sb.ToString();
    }

    /// <summary>
    /// Get the JSON string presentation of the object
    /// </summary>
    /// <returns>JSON string presentation of the object</returns>
    public string ToJson() {
      return JsonConvert.SerializeObject(this, Formatting.Indented);
    }

}
}
