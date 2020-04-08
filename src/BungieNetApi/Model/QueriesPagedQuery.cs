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
    /// QueriesPagedQuery
    /// </summary>
    [DataContract]
    public partial class QueriesPagedQuery :  IEquatable<QueriesPagedQuery>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="QueriesPagedQuery" /> class.
        /// </summary>
        /// <param name="itemsPerPage">itemsPerPage.</param>
        /// <param name="currentPage">currentPage.</param>
        /// <param name="requestContinuationToken">requestContinuationToken.</param>
        public QueriesPagedQuery(int itemsPerPage = default(int), int currentPage = default(int), string requestContinuationToken = default(string))
        {
            this.ItemsPerPage = itemsPerPage;
            this.CurrentPage = currentPage;
            this.RequestContinuationToken = requestContinuationToken;
        }
        
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
            sb.Append("class QueriesPagedQuery {\n");
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
            return this.Equals(input as QueriesPagedQuery);
        }

        /// <summary>
        /// Returns true if QueriesPagedQuery instances are equal
        /// </summary>
        /// <param name="input">Instance of QueriesPagedQuery to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(QueriesPagedQuery input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ItemsPerPage == input.ItemsPerPage ||
                    (this.ItemsPerPage != null &&
                    this.ItemsPerPage.Equals(input.ItemsPerPage))
                ) && 
                (
                    this.CurrentPage == input.CurrentPage ||
                    (this.CurrentPage != null &&
                    this.CurrentPage.Equals(input.CurrentPage))
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
                if (this.ItemsPerPage != null)
                    hashCode = hashCode * 59 + this.ItemsPerPage.GetHashCode();
                if (this.CurrentPage != null)
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
