using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Sharpility.Extensions;
using NodaTime;

namespace BungieNetApi._Platform.Models
{
    /// <summary>
    /// Defines a plug \&quot;Category\&quot; that is allowed to be plugged into a socket of this type.  This should be compared against a given plug item&#39;s DestinyInventoryItemDefinition.plug.plugCategoryHash, which indicates the plug item&#39;s category.
    /// </summary>
    public sealed class DestinyDefinitionsSocketsDestinyPlugWhitelistEntryDefinition:  IEquatable<DestinyDefinitionsSocketsDestinyPlugWhitelistEntryDefinition>
    { 
        /// <summary>
        /// The hash identifier of the Plug Category to compare against the plug item&#39;s plug.plugCategoryHash.  Note that this does NOT relate to any Definition in itself, it is only used for comparison purposes.
        /// </summary>
        public int? CategoryHash { get; private set; }

        /// <summary>
        /// The string identifier for the category, which is here mostly for debug purposes.
        /// </summary>
        public string CategoryIdentifier { get; private set; }

        /// <summary>
        /// The list of all plug items (DestinyInventoryItemDefinition) that the socket may randomly be populated with when reinitialized.  Which ones you should actually show are determined by the plug being inserted into the socket, and the socket’s type.  When you inspect the plug that could go into a Masterwork Socket, look up the socket type of the socket being inspected and find the DestinySocketTypeDefinition.  Then, look at the Plugs that can fit in that socket. Find the Whitelist in the DestinySocketTypeDefinition that matches the plug item’s categoryhash.  That whitelist entry will potentially have a new “reinitializationPossiblePlugHashes” property.If it does, that means we know what it will roll if you try to insert this plug into this socket.
        /// </summary>
        public List<int?> ReinitializationPossiblePlugHashes { get; private set; }


        /// <summary>
        /// Empty constructor required by some serializers.
        /// Use DestinyDefinitionsSocketsDestinyPlugWhitelistEntryDefinition.Builder() for instance creation instead.
        /// </summary>
        [Obsolete]
        public DestinyDefinitionsSocketsDestinyPlugWhitelistEntryDefinition()
        {
        }

        private DestinyDefinitionsSocketsDestinyPlugWhitelistEntryDefinition(int? CategoryHash, string CategoryIdentifier, List<int?> ReinitializationPossiblePlugHashes)
        {
            
            this.CategoryHash = CategoryHash;
            
            this.CategoryIdentifier = CategoryIdentifier;
            
            this.ReinitializationPossiblePlugHashes = ReinitializationPossiblePlugHashes;
            
        }

        /// <summary>
        /// Returns builder of DestinyDefinitionsSocketsDestinyPlugWhitelistEntryDefinition.
        /// </summary>
        /// <returns>DestinyDefinitionsSocketsDestinyPlugWhitelistEntryDefinitionBuilder</returns>
        public static DestinyDefinitionsSocketsDestinyPlugWhitelistEntryDefinitionBuilder Builder()
        {
            return new DestinyDefinitionsSocketsDestinyPlugWhitelistEntryDefinitionBuilder();
        }

        /// <summary>
        /// Returns DestinyDefinitionsSocketsDestinyPlugWhitelistEntryDefinitionBuilder with properties set.
        /// Use it to change properties.
        /// </summary>
        /// <returns>DestinyDefinitionsSocketsDestinyPlugWhitelistEntryDefinitionBuilder</returns>
        public DestinyDefinitionsSocketsDestinyPlugWhitelistEntryDefinitionBuilder With()
        {
            return Builder()
                .CategoryHash(CategoryHash)
                .CategoryIdentifier(CategoryIdentifier)
                .ReinitializationPossiblePlugHashes(ReinitializationPossiblePlugHashes);
        }

        public override string ToString()
        {
            return this.PropertiesToString();
        }

        public override bool Equals(object obj)
        {
            return this.EqualsByProperties(obj);
        }

        public bool Equals(DestinyDefinitionsSocketsDestinyPlugWhitelistEntryDefinition other)
        {
            return Equals((object) other);
        }

        public override int GetHashCode()
        {
            return this.PropertiesHash();
        }

        /// <summary>
        /// Implementation of == operator for (DestinyDefinitionsSocketsDestinyPlugWhitelistEntryDefinition.
        /// </summary>
        /// <param name="left">Compared (DestinyDefinitionsSocketsDestinyPlugWhitelistEntryDefinition</param>
        /// <param name="right">Compared (DestinyDefinitionsSocketsDestinyPlugWhitelistEntryDefinition</param>
        /// <returns>true if compared items are equals, false otherwise</returns>
        public static bool operator == (DestinyDefinitionsSocketsDestinyPlugWhitelistEntryDefinition left, DestinyDefinitionsSocketsDestinyPlugWhitelistEntryDefinition right)
        {
            return Equals(left, right);
        }

        /// <summary>
        /// Implementation of != operator for (DestinyDefinitionsSocketsDestinyPlugWhitelistEntryDefinition.
        /// </summary>
        /// <param name="left">Compared (DestinyDefinitionsSocketsDestinyPlugWhitelistEntryDefinition</param>
        /// <param name="right">Compared (DestinyDefinitionsSocketsDestinyPlugWhitelistEntryDefinition</param>
        /// <returns>true if compared items are not equals, false otherwise</returns>
        public static bool operator != (DestinyDefinitionsSocketsDestinyPlugWhitelistEntryDefinition left, DestinyDefinitionsSocketsDestinyPlugWhitelistEntryDefinition right)
        {
            return !Equals(left, right);
        }

        /// <summary>
        /// Builder of DestinyDefinitionsSocketsDestinyPlugWhitelistEntryDefinition.
        /// </summary>
        public sealed class DestinyDefinitionsSocketsDestinyPlugWhitelistEntryDefinitionBuilder
        {
            private int? _CategoryHash;
            private string _CategoryIdentifier;
            private List<int?> _ReinitializationPossiblePlugHashes;

            internal DestinyDefinitionsSocketsDestinyPlugWhitelistEntryDefinitionBuilder()
            {
                SetupDefaults();
            }

            private void SetupDefaults()
            {
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsSocketsDestinyPlugWhitelistEntryDefinition.CategoryHash property.
            /// </summary>
            /// <param name="value">The hash identifier of the Plug Category to compare against the plug item&#39;s plug.plugCategoryHash.  Note that this does NOT relate to any Definition in itself, it is only used for comparison purposes.</param>
            public DestinyDefinitionsSocketsDestinyPlugWhitelistEntryDefinitionBuilder CategoryHash(int? value)
            {
                _CategoryHash = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsSocketsDestinyPlugWhitelistEntryDefinition.CategoryIdentifier property.
            /// </summary>
            /// <param name="value">The string identifier for the category, which is here mostly for debug purposes.</param>
            public DestinyDefinitionsSocketsDestinyPlugWhitelistEntryDefinitionBuilder CategoryIdentifier(string value)
            {
                _CategoryIdentifier = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsSocketsDestinyPlugWhitelistEntryDefinition.ReinitializationPossiblePlugHashes property.
            /// </summary>
            /// <param name="value">The list of all plug items (DestinyInventoryItemDefinition) that the socket may randomly be populated with when reinitialized.  Which ones you should actually show are determined by the plug being inserted into the socket, and the socket’s type.  When you inspect the plug that could go into a Masterwork Socket, look up the socket type of the socket being inspected and find the DestinySocketTypeDefinition.  Then, look at the Plugs that can fit in that socket. Find the Whitelist in the DestinySocketTypeDefinition that matches the plug item’s categoryhash.  That whitelist entry will potentially have a new “reinitializationPossiblePlugHashes” property.If it does, that means we know what it will roll if you try to insert this plug into this socket.</param>
            public DestinyDefinitionsSocketsDestinyPlugWhitelistEntryDefinitionBuilder ReinitializationPossiblePlugHashes(List<int?> value)
            {
                _ReinitializationPossiblePlugHashes = value;
                return this;
            }


            /// <summary>
            /// Builds instance of DestinyDefinitionsSocketsDestinyPlugWhitelistEntryDefinition.
            /// </summary>
            /// <returns>DestinyDefinitionsSocketsDestinyPlugWhitelistEntryDefinition</returns>
            public DestinyDefinitionsSocketsDestinyPlugWhitelistEntryDefinition Build()
            {
                Validate();
                return new DestinyDefinitionsSocketsDestinyPlugWhitelistEntryDefinition(
                    CategoryHash: _CategoryHash,
                    CategoryIdentifier: _CategoryIdentifier,
                    ReinitializationPossiblePlugHashes: _ReinitializationPossiblePlugHashes
                );
            }

            private void Validate()
            { 
            }
        }

        
    }
}