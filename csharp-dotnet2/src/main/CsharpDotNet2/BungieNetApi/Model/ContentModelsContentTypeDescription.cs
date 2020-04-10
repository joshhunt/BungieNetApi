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
  public class ContentModelsContentTypeDescription {
    /// <summary>
    /// Gets or Sets CType
    /// </summary>
    [DataMember(Name="cType", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "cType")]
    public string CType { get; set; }

    /// <summary>
    /// Gets or Sets Name
    /// </summary>
    [DataMember(Name="name", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "name")]
    public string Name { get; set; }

    /// <summary>
    /// Gets or Sets ContentDescription
    /// </summary>
    [DataMember(Name="contentDescription", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "contentDescription")]
    public string ContentDescription { get; set; }

    /// <summary>
    /// Gets or Sets PreviewImage
    /// </summary>
    [DataMember(Name="previewImage", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "previewImage")]
    public string PreviewImage { get; set; }

    /// <summary>
    /// Gets or Sets Priority
    /// </summary>
    [DataMember(Name="priority", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "priority")]
    public int? Priority { get; set; }

    /// <summary>
    /// Gets or Sets Reminder
    /// </summary>
    [DataMember(Name="reminder", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "reminder")]
    public string Reminder { get; set; }

    /// <summary>
    /// Gets or Sets Properties
    /// </summary>
    [DataMember(Name="properties", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "properties")]
    public List<ContentModelsContentTypeProperty> Properties { get; set; }

    /// <summary>
    /// Gets or Sets TagMetadata
    /// </summary>
    [DataMember(Name="tagMetadata", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "tagMetadata")]
    public List<ContentModelsTagMetadataDefinition> TagMetadata { get; set; }

    /// <summary>
    /// Gets or Sets TagMetadataItems
    /// </summary>
    [DataMember(Name="tagMetadataItems", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "tagMetadataItems")]
    public Dictionary<string, ContentModelsTagMetadataItem> TagMetadataItems { get; set; }

    /// <summary>
    /// Gets or Sets UsageExamples
    /// </summary>
    [DataMember(Name="usageExamples", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "usageExamples")]
    public List<string> UsageExamples { get; set; }

    /// <summary>
    /// Gets or Sets ShowInContentEditor
    /// </summary>
    [DataMember(Name="showInContentEditor", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "showInContentEditor")]
    public bool? ShowInContentEditor { get; set; }

    /// <summary>
    /// Gets or Sets TypeOf
    /// </summary>
    [DataMember(Name="typeOf", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "typeOf")]
    public string TypeOf { get; set; }

    /// <summary>
    /// Gets or Sets BindIdentifierToProperty
    /// </summary>
    [DataMember(Name="bindIdentifierToProperty", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "bindIdentifierToProperty")]
    public string BindIdentifierToProperty { get; set; }

    /// <summary>
    /// Gets or Sets BoundRegex
    /// </summary>
    [DataMember(Name="boundRegex", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "boundRegex")]
    public string BoundRegex { get; set; }

    /// <summary>
    /// Gets or Sets ForceIdentifierBinding
    /// </summary>
    [DataMember(Name="forceIdentifierBinding", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "forceIdentifierBinding")]
    public bool? ForceIdentifierBinding { get; set; }

    /// <summary>
    /// Gets or Sets AllowComments
    /// </summary>
    [DataMember(Name="allowComments", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "allowComments")]
    public bool? AllowComments { get; set; }

    /// <summary>
    /// Gets or Sets AutoEnglishPropertyFallback
    /// </summary>
    [DataMember(Name="autoEnglishPropertyFallback", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "autoEnglishPropertyFallback")]
    public bool? AutoEnglishPropertyFallback { get; set; }

    /// <summary>
    /// Gets or Sets BulkUploadable
    /// </summary>
    [DataMember(Name="bulkUploadable", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "bulkUploadable")]
    public bool? BulkUploadable { get; set; }

    /// <summary>
    /// Gets or Sets Previews
    /// </summary>
    [DataMember(Name="previews", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "previews")]
    public List<ContentModelsContentPreview> Previews { get; set; }

    /// <summary>
    /// Gets or Sets SuppressCmsPath
    /// </summary>
    [DataMember(Name="suppressCmsPath", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "suppressCmsPath")]
    public bool? SuppressCmsPath { get; set; }

    /// <summary>
    /// Gets or Sets PropertySections
    /// </summary>
    [DataMember(Name="propertySections", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "propertySections")]
    public List<ContentModelsContentTypePropertySection> PropertySections { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class ContentModelsContentTypeDescription {\n");
      sb.Append("  CType: ").Append(CType).Append("\n");
      sb.Append("  Name: ").Append(Name).Append("\n");
      sb.Append("  ContentDescription: ").Append(ContentDescription).Append("\n");
      sb.Append("  PreviewImage: ").Append(PreviewImage).Append("\n");
      sb.Append("  Priority: ").Append(Priority).Append("\n");
      sb.Append("  Reminder: ").Append(Reminder).Append("\n");
      sb.Append("  Properties: ").Append(Properties).Append("\n");
      sb.Append("  TagMetadata: ").Append(TagMetadata).Append("\n");
      sb.Append("  TagMetadataItems: ").Append(TagMetadataItems).Append("\n");
      sb.Append("  UsageExamples: ").Append(UsageExamples).Append("\n");
      sb.Append("  ShowInContentEditor: ").Append(ShowInContentEditor).Append("\n");
      sb.Append("  TypeOf: ").Append(TypeOf).Append("\n");
      sb.Append("  BindIdentifierToProperty: ").Append(BindIdentifierToProperty).Append("\n");
      sb.Append("  BoundRegex: ").Append(BoundRegex).Append("\n");
      sb.Append("  ForceIdentifierBinding: ").Append(ForceIdentifierBinding).Append("\n");
      sb.Append("  AllowComments: ").Append(AllowComments).Append("\n");
      sb.Append("  AutoEnglishPropertyFallback: ").Append(AutoEnglishPropertyFallback).Append("\n");
      sb.Append("  BulkUploadable: ").Append(BulkUploadable).Append("\n");
      sb.Append("  Previews: ").Append(Previews).Append("\n");
      sb.Append("  SuppressCmsPath: ").Append(SuppressCmsPath).Append("\n");
      sb.Append("  PropertySections: ").Append(PropertySections).Append("\n");
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
