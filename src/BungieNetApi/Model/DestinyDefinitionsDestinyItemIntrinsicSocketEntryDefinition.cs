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
    /// Represents a socket that has a plug associated with it intrinsically. This is useful for situations where the weapon needs to have a visual plug/Mod on it, but that plug/Mod should never change.
    /// </summary>
    [DataContract]
    public partial class DestinyDefinitionsDestinyItemIntrinsicSocketEntryDefinition :  IEquatable<DestinyDefinitionsDestinyItemIntrinsicSocketEntryDefinition>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DestinyDefinitionsDestinyItemIntrinsicSocketEntryDefinition" /> class.
        /// </summary>
        /// <param name="plugItemHash">Indicates the plug that is intrinsically inserted into this socket..</param>
        /// <param name="socketTypeHash">Indicates the type of this intrinsic socket..</param>
        /// <param name="defaultVisible">If true, then this socket is visible in the item&#39;s \&quot;default\&quot; state. If you have an instance, you should always check the runtime state, as that can override this visibility setting: but if you&#39;re looking at the item on a conceptual level, this property can be useful for hiding data such as legacy sockets - which remain defined on items for infrastructure purposes, but can be confusing for users to see..</param>
        public DestinyDefinitionsDestinyItemIntrinsicSocketEntryDefinition(int plugItemHash = default(int), int socketTypeHash = default(int), bool defaultVisible = default(bool))
        {
            this.PlugItemHash = plugItemHash;
            this.SocketTypeHash = socketTypeHash;
            this.DefaultVisible = defaultVisible;
        }
        
        /// <summary>
        /// Indicates the plug that is intrinsically inserted into this socket.
        /// </summary>
        /// <value>Indicates the plug that is intrinsically inserted into this socket.</value>
        [DataMember(Name="plugItemHash", EmitDefaultValue=false)]
        public int PlugItemHash { get; set; }

        /// <summary>
        /// Indicates the type of this intrinsic socket.
        /// </summary>
        /// <value>Indicates the type of this intrinsic socket.</value>
        [DataMember(Name="socketTypeHash", EmitDefaultValue=false)]
        public int SocketTypeHash { get; set; }

        /// <summary>
        /// If true, then this socket is visible in the item&#39;s \&quot;default\&quot; state. If you have an instance, you should always check the runtime state, as that can override this visibility setting: but if you&#39;re looking at the item on a conceptual level, this property can be useful for hiding data such as legacy sockets - which remain defined on items for infrastructure purposes, but can be confusing for users to see.
        /// </summary>
        /// <value>If true, then this socket is visible in the item&#39;s \&quot;default\&quot; state. If you have an instance, you should always check the runtime state, as that can override this visibility setting: but if you&#39;re looking at the item on a conceptual level, this property can be useful for hiding data such as legacy sockets - which remain defined on items for infrastructure purposes, but can be confusing for users to see.</value>
        [DataMember(Name="defaultVisible", EmitDefaultValue=false)]
        public bool DefaultVisible { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DestinyDefinitionsDestinyItemIntrinsicSocketEntryDefinition {\n");
            sb.Append("  PlugItemHash: ").Append(PlugItemHash).Append("\n");
            sb.Append("  SocketTypeHash: ").Append(SocketTypeHash).Append("\n");
            sb.Append("  DefaultVisible: ").Append(DefaultVisible).Append("\n");
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
            return this.Equals(input as DestinyDefinitionsDestinyItemIntrinsicSocketEntryDefinition);
        }

        /// <summary>
        /// Returns true if DestinyDefinitionsDestinyItemIntrinsicSocketEntryDefinition instances are equal
        /// </summary>
        /// <param name="input">Instance of DestinyDefinitionsDestinyItemIntrinsicSocketEntryDefinition to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DestinyDefinitionsDestinyItemIntrinsicSocketEntryDefinition input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.PlugItemHash == input.PlugItemHash ||
                    (this.PlugItemHash != null &&
                    this.PlugItemHash.Equals(input.PlugItemHash))
                ) && 
                (
                    this.SocketTypeHash == input.SocketTypeHash ||
                    (this.SocketTypeHash != null &&
                    this.SocketTypeHash.Equals(input.SocketTypeHash))
                ) && 
                (
                    this.DefaultVisible == input.DefaultVisible ||
                    (this.DefaultVisible != null &&
                    this.DefaultVisible.Equals(input.DefaultVisible))
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
                if (this.PlugItemHash != null)
                    hashCode = hashCode * 59 + this.PlugItemHash.GetHashCode();
                if (this.SocketTypeHash != null)
                    hashCode = hashCode * 59 + this.SocketTypeHash.GetHashCode();
                if (this.DefaultVisible != null)
                    hashCode = hashCode * 59 + this.DefaultVisible.GetHashCode();
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
