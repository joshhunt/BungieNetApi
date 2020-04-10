/* 
 * Bungie.Net API
 *
 * These endpoints constitute the functionality exposed by Bungie.net, both for more traditional website functionality and for connectivity to Bungie video games and their related functionality.
 *
 * The version of the OpenAPI document: 2.8.0
 * Contact: support@bungie.com
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;
using OpenAPIDateConverter = BungieNetApi.Client.OpenAPIDateConverter;

namespace BungieNetApi.Model
{
    /// <summary>
    /// NOTE: GroupQuery, as of Destiny 2, has essentially two totally different and incompatible \&quot;modes\&quot;.  If you are querying for a group, you can pass any of the properties below.  If you are querying for a Clan, you MUST NOT pass any of the following properties (they must be null or undefined in your request, not just empty string/default values):  - groupMemberCountFilter - localeFilter - tagText  If you pass these, you will get a useless InvalidParameters error.
    /// </summary>
    [DataContract]
    public partial class GroupsV2GroupQuery :  IEquatable<GroupsV2GroupQuery>, IValidatableObject
    {
        /// <summary>
        /// Defines GroupMemberCountFilter
        /// </summary>
        public enum GroupMemberCountFilterEnum
        {
            /// <summary>
            /// Enum NUMBER_0 for value: 0
            /// </summary>
            NUMBER_0 = 0,

            /// <summary>
            /// Enum NUMBER_1 for value: 1
            /// </summary>
            NUMBER_1 = 1,

            /// <summary>
            /// Enum NUMBER_2 for value: 2
            /// </summary>
            NUMBER_2 = 2,

            /// <summary>
            /// Enum NUMBER_3 for value: 3
            /// </summary>
            NUMBER_3 = 3

        }

        /// <summary>
        /// Gets or Sets GroupMemberCountFilter
        /// </summary>
        [DataMember(Name="groupMemberCountFilter", EmitDefaultValue=false)]
        public GroupMemberCountFilterEnum? GroupMemberCountFilter { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="GroupsV2GroupQuery" /> class.
        /// </summary>
        /// <param name="name">name.</param>
        /// <param name="groupType">groupType.</param>
        /// <param name="creationDate">creationDate.</param>
        /// <param name="sortBy">sortBy.</param>
        /// <param name="groupMemberCountFilter">groupMemberCountFilter.</param>
        /// <param name="localeFilter">localeFilter.</param>
        /// <param name="tagText">tagText.</param>
        /// <param name="itemsPerPage">itemsPerPage.</param>
        /// <param name="currentPage">currentPage.</param>
        /// <param name="requestContinuationToken">requestContinuationToken.</param>
        public GroupsV2GroupQuery(string name = default(string), int groupType = default(int), int creationDate = default(int), int sortBy = default(int), GroupMemberCountFilterEnum? groupMemberCountFilter = default(GroupMemberCountFilterEnum?), string localeFilter = default(string), string tagText = default(string), int itemsPerPage = default(int), int currentPage = default(int), string requestContinuationToken = default(string))
        {
            this.Name = name;
            this.GroupType = groupType;
            this.CreationDate = creationDate;
            this.SortBy = sortBy;
            this.GroupMemberCountFilter = groupMemberCountFilter;
            this.LocaleFilter = localeFilter;
            this.TagText = tagText;
            this.ItemsPerPage = itemsPerPage;
            this.CurrentPage = currentPage;
            this.RequestContinuationToken = requestContinuationToken;
        }
        
        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets GroupType
        /// </summary>
        [DataMember(Name="groupType", EmitDefaultValue=false)]
        public int GroupType { get; set; }

        /// <summary>
        /// Gets or Sets CreationDate
        /// </summary>
        [DataMember(Name="creationDate", EmitDefaultValue=false)]
        public int CreationDate { get; set; }

        /// <summary>
        /// Gets or Sets SortBy
        /// </summary>
        [DataMember(Name="sortBy", EmitDefaultValue=false)]
        public int SortBy { get; set; }

        /// <summary>
        /// Gets or Sets LocaleFilter
        /// </summary>
        [DataMember(Name="localeFilter", EmitDefaultValue=false)]
        public string LocaleFilter { get; set; }

        /// <summary>
        /// Gets or Sets TagText
        /// </summary>
        [DataMember(Name="tagText", EmitDefaultValue=false)]
        public string TagText { get; set; }

        /// <summary>
        /// Gets or Sets ItemsPerPage
        /// </summary>
        [DataMember(Name="itemsPerPage", EmitDefaultValue=false)]
        public int ItemsPerPage { get; set; }

        /// <summary>
        /// Gets or Sets CurrentPage
        /// </summary>
        [DataMember(Name="currentPage", EmitDefaultValue=false)]
        public int CurrentPage { get; set; }

        /// <summary>
        /// Gets or Sets RequestContinuationToken
        /// </summary>
        [DataMember(Name="requestContinuationToken", EmitDefaultValue=false)]
        public string RequestContinuationToken { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class GroupsV2GroupQuery {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  GroupType: ").Append(GroupType).Append("\n");
            sb.Append("  CreationDate: ").Append(CreationDate).Append("\n");
            sb.Append("  SortBy: ").Append(SortBy).Append("\n");
            sb.Append("  GroupMemberCountFilter: ").Append(GroupMemberCountFilter).Append("\n");
            sb.Append("  LocaleFilter: ").Append(LocaleFilter).Append("\n");
            sb.Append("  TagText: ").Append(TagText).Append("\n");
            sb.Append("  ItemsPerPage: ").Append(ItemsPerPage).Append("\n");
            sb.Append("  CurrentPage: ").Append(CurrentPage).Append("\n");
            sb.Append("  RequestContinuationToken: ").Append(RequestContinuationToken).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as GroupsV2GroupQuery);
        }

        /// <summary>
        /// Returns true if GroupsV2GroupQuery instances are equal
        /// </summary>
        /// <param name="input">Instance of GroupsV2GroupQuery to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GroupsV2GroupQuery input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.GroupType == input.GroupType ||
                    this.GroupType.Equals(input.GroupType)
                ) && 
                (
                    this.CreationDate == input.CreationDate ||
                    this.CreationDate.Equals(input.CreationDate)
                ) && 
                (
                    this.SortBy == input.SortBy ||
                    this.SortBy.Equals(input.SortBy)
                ) && 
                (
                    this.GroupMemberCountFilter == input.GroupMemberCountFilter ||
                    this.GroupMemberCountFilter.Equals(input.GroupMemberCountFilter)
                ) && 
                (
                    this.LocaleFilter == input.LocaleFilter ||
                    (this.LocaleFilter != null &&
                    this.LocaleFilter.Equals(input.LocaleFilter))
                ) && 
                (
                    this.TagText == input.TagText ||
                    (this.TagText != null &&
                    this.TagText.Equals(input.TagText))
                ) && 
                (
                    this.ItemsPerPage == input.ItemsPerPage ||
                    this.ItemsPerPage.Equals(input.ItemsPerPage)
                ) && 
                (
                    this.CurrentPage == input.CurrentPage ||
                    this.CurrentPage.Equals(input.CurrentPage)
                ) && 
                (
                    this.RequestContinuationToken == input.RequestContinuationToken ||
                    (this.RequestContinuationToken != null &&
                    this.RequestContinuationToken.Equals(input.RequestContinuationToken))
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                hashCode = hashCode * 59 + this.GroupType.GetHashCode();
                hashCode = hashCode * 59 + this.CreationDate.GetHashCode();
                hashCode = hashCode * 59 + this.SortBy.GetHashCode();
                hashCode = hashCode * 59 + this.GroupMemberCountFilter.GetHashCode();
                if (this.LocaleFilter != null)
                    hashCode = hashCode * 59 + this.LocaleFilter.GetHashCode();
                if (this.TagText != null)
                    hashCode = hashCode * 59 + this.TagText.GetHashCode();
                hashCode = hashCode * 59 + this.ItemsPerPage.GetHashCode();
                hashCode = hashCode * 59 + this.CurrentPage.GetHashCode();
                if (this.RequestContinuationToken != null)
                    hashCode = hashCode * 59 + this.RequestContinuationToken.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
