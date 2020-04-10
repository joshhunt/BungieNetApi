using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Sharpility.Extensions;
using NodaTime;

namespace BungieNetApi._Platform.Models
{
    /// <summary>
    /// Sockets are grouped into categories in the UI. These define which category and which sockets are under that category.
    /// </summary>
    public sealed class DestinyDefinitionsDestinyItemSocketCategoryDefinition:  IEquatable<DestinyDefinitionsDestinyItemSocketCategoryDefinition>
    { 
        /// <summary>
        /// The hash for the Socket Category: a quick way to go get the header display information for the category. Use it to look up DestinySocketCategoryDefinition info.
        /// </summary>
        public int? SocketCategoryHash { get; private set; }

        /// <summary>
        /// Use these indexes to look up the sockets in the \&quot;sockets.socketEntries\&quot; property on the item definition. These are the indexes under the category, in game-rendered order.
        /// </summary>
        public List<int?> SocketIndexes { get; private set; }


        /// <summary>
        /// Empty constructor required by some serializers.
        /// Use DestinyDefinitionsDestinyItemSocketCategoryDefinition.Builder() for instance creation instead.
        /// </summary>
        [Obsolete]
        public DestinyDefinitionsDestinyItemSocketCategoryDefinition()
        {
        }

        private DestinyDefinitionsDestinyItemSocketCategoryDefinition(int? SocketCategoryHash, List<int?> SocketIndexes)
        {
            
            this.SocketCategoryHash = SocketCategoryHash;
            
            this.SocketIndexes = SocketIndexes;
            
        }

        /// <summary>
        /// Returns builder of DestinyDefinitionsDestinyItemSocketCategoryDefinition.
        /// </summary>
        /// <returns>DestinyDefinitionsDestinyItemSocketCategoryDefinitionBuilder</returns>
        public static DestinyDefinitionsDestinyItemSocketCategoryDefinitionBuilder Builder()
        {
            return new DestinyDefinitionsDestinyItemSocketCategoryDefinitionBuilder();
        }

        /// <summary>
        /// Returns DestinyDefinitionsDestinyItemSocketCategoryDefinitionBuilder with properties set.
        /// Use it to change properties.
        /// </summary>
        /// <returns>DestinyDefinitionsDestinyItemSocketCategoryDefinitionBuilder</returns>
        public DestinyDefinitionsDestinyItemSocketCategoryDefinitionBuilder With()
        {
            return Builder()
                .SocketCategoryHash(SocketCategoryHash)
                .SocketIndexes(SocketIndexes);
        }

        public override string ToString()
        {
            return this.PropertiesToString();
        }

        public override bool Equals(object obj)
        {
            return this.EqualsByProperties(obj);
        }

        public bool Equals(DestinyDefinitionsDestinyItemSocketCategoryDefinition other)
        {
            return Equals((object) other);
        }

        public override int GetHashCode()
        {
            return this.PropertiesHash();
        }

        /// <summary>
        /// Implementation of == operator for (DestinyDefinitionsDestinyItemSocketCategoryDefinition.
        /// </summary>
        /// <param name="left">Compared (DestinyDefinitionsDestinyItemSocketCategoryDefinition</param>
        /// <param name="right">Compared (DestinyDefinitionsDestinyItemSocketCategoryDefinition</param>
        /// <returns>true if compared items are equals, false otherwise</returns>
        public static bool operator == (DestinyDefinitionsDestinyItemSocketCategoryDefinition left, DestinyDefinitionsDestinyItemSocketCategoryDefinition right)
        {
            return Equals(left, right);
        }

        /// <summary>
        /// Implementation of != operator for (DestinyDefinitionsDestinyItemSocketCategoryDefinition.
        /// </summary>
        /// <param name="left">Compared (DestinyDefinitionsDestinyItemSocketCategoryDefinition</param>
        /// <param name="right">Compared (DestinyDefinitionsDestinyItemSocketCategoryDefinition</param>
        /// <returns>true if compared items are not equals, false otherwise</returns>
        public static bool operator != (DestinyDefinitionsDestinyItemSocketCategoryDefinition left, DestinyDefinitionsDestinyItemSocketCategoryDefinition right)
        {
            return !Equals(left, right);
        }

        /// <summary>
        /// Builder of DestinyDefinitionsDestinyItemSocketCategoryDefinition.
        /// </summary>
        public sealed class DestinyDefinitionsDestinyItemSocketCategoryDefinitionBuilder
        {
            private int? _SocketCategoryHash;
            private List<int?> _SocketIndexes;

            internal DestinyDefinitionsDestinyItemSocketCategoryDefinitionBuilder()
            {
                SetupDefaults();
            }

            private void SetupDefaults()
            {
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsDestinyItemSocketCategoryDefinition.SocketCategoryHash property.
            /// </summary>
            /// <param name="value">The hash for the Socket Category: a quick way to go get the header display information for the category. Use it to look up DestinySocketCategoryDefinition info.</param>
            public DestinyDefinitionsDestinyItemSocketCategoryDefinitionBuilder SocketCategoryHash(int? value)
            {
                _SocketCategoryHash = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsDestinyItemSocketCategoryDefinition.SocketIndexes property.
            /// </summary>
            /// <param name="value">Use these indexes to look up the sockets in the \&quot;sockets.socketEntries\&quot; property on the item definition. These are the indexes under the category, in game-rendered order.</param>
            public DestinyDefinitionsDestinyItemSocketCategoryDefinitionBuilder SocketIndexes(List<int?> value)
            {
                _SocketIndexes = value;
                return this;
            }


            /// <summary>
            /// Builds instance of DestinyDefinitionsDestinyItemSocketCategoryDefinition.
            /// </summary>
            /// <returns>DestinyDefinitionsDestinyItemSocketCategoryDefinition</returns>
            public DestinyDefinitionsDestinyItemSocketCategoryDefinition Build()
            {
                Validate();
                return new DestinyDefinitionsDestinyItemSocketCategoryDefinition(
                    SocketCategoryHash: _SocketCategoryHash,
                    SocketIndexes: _SocketIndexes
                );
            }

            private void Validate()
            { 
            }
        }

        
    }
}