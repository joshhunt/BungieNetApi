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
    /// Sockets are grouped into categories in the UI. These define which category and which sockets are under that category.
    /// </summary>
    [DataContract]
    public partial class DestinyDefinitionsDestinyItemSocketCategoryDefinition :  IEquatable<DestinyDefinitionsDestinyItemSocketCategoryDefinition>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DestinyDefinitionsDestinyItemSocketCategoryDefinition" /> class.
        /// </summary>
        /// <param name="socketCategoryHash">The hash for the Socket Category: a quick way to go get the header display information for the category. Use it to look up DestinySocketCategoryDefinition info..</param>
        /// <param name="socketIndexes">Use these indexes to look up the sockets in the \&quot;sockets.socketEntries\&quot; property on the item definition. These are the indexes under the category, in game-rendered order..</param>
        public DestinyDefinitionsDestinyItemSocketCategoryDefinition(long socketCategoryHash = default(long), List<int> socketIndexes = default(List<int>))
        {
            this.SocketCategoryHash = socketCategoryHash;
            this.SocketIndexes = socketIndexes;
        }
        
        /// <summary>
        /// The hash for the Socket Category: a quick way to go get the header display information for the category. Use it to look up DestinySocketCategoryDefinition info.
        /// </summary>
        /// <value>The hash for the Socket Category: a quick way to go get the header display information for the category. Use it to look up DestinySocketCategoryDefinition info.</value>
        [DataMember(Name="socketCategoryHash", EmitDefaultValue=false)]
        public long SocketCategoryHash { get; set; }

        /// <summary>
        /// Use these indexes to look up the sockets in the \&quot;sockets.socketEntries\&quot; property on the item definition. These are the indexes under the category, in game-rendered order.
        /// </summary>
        /// <value>Use these indexes to look up the sockets in the \&quot;sockets.socketEntries\&quot; property on the item definition. These are the indexes under the category, in game-rendered order.</value>
        [DataMember(Name="socketIndexes", EmitDefaultValue=false)]
        public List<int> SocketIndexes { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DestinyDefinitionsDestinyItemSocketCategoryDefinition {\n");
            sb.Append("  SocketCategoryHash: ").Append(SocketCategoryHash).Append("\n");
            sb.Append("  SocketIndexes: ").Append(SocketIndexes).Append("\n");
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
            return this.Equals(input as DestinyDefinitionsDestinyItemSocketCategoryDefinition);
        }

        /// <summary>
        /// Returns true if DestinyDefinitionsDestinyItemSocketCategoryDefinition instances are equal
        /// </summary>
        /// <param name="input">Instance of DestinyDefinitionsDestinyItemSocketCategoryDefinition to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DestinyDefinitionsDestinyItemSocketCategoryDefinition input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.SocketCategoryHash == input.SocketCategoryHash ||
                    this.SocketCategoryHash.Equals(input.SocketCategoryHash)
                ) && 
                (
                    this.SocketIndexes == input.SocketIndexes ||
                    this.SocketIndexes != null &&
                    input.SocketIndexes != null &&
                    this.SocketIndexes.SequenceEqual(input.SocketIndexes)
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
                hashCode = hashCode * 59 + this.SocketCategoryHash.GetHashCode();
                if (this.SocketIndexes != null)
                    hashCode = hashCode * 59 + this.SocketIndexes.GetHashCode();
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