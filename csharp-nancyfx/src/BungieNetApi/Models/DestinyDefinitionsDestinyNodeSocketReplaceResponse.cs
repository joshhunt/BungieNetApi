using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Sharpility.Extensions;
using NodaTime;

namespace BungieNetApi._Platform.Models
{
    /// <summary>
    /// This is a bit of an odd duck. Apparently, if talent nodes steps have this data, the game will go through on step activation and alter the first Socket it finds on the item that has a type matching the given socket type, inserting the indicated plug item.
    /// </summary>
    public sealed class DestinyDefinitionsDestinyNodeSocketReplaceResponse:  IEquatable<DestinyDefinitionsDestinyNodeSocketReplaceResponse>
    { 
        /// <summary>
        /// The hash identifier of the socket type to find amidst the item&#39;s sockets (the item to which this talent grid is attached). See DestinyInventoryItemDefinition.sockets.socketEntries to find the socket type of sockets on the item in question.
        /// </summary>
        public int? SocketTypeHash { get; private set; }

        /// <summary>
        /// The hash identifier of the plug item that will be inserted into the socket found.
        /// </summary>
        public int? PlugItemHash { get; private set; }


        /// <summary>
        /// Empty constructor required by some serializers.
        /// Use DestinyDefinitionsDestinyNodeSocketReplaceResponse.Builder() for instance creation instead.
        /// </summary>
        [Obsolete]
        public DestinyDefinitionsDestinyNodeSocketReplaceResponse()
        {
        }

        private DestinyDefinitionsDestinyNodeSocketReplaceResponse(int? SocketTypeHash, int? PlugItemHash)
        {
            
            this.SocketTypeHash = SocketTypeHash;
            
            this.PlugItemHash = PlugItemHash;
            
        }

        /// <summary>
        /// Returns builder of DestinyDefinitionsDestinyNodeSocketReplaceResponse.
        /// </summary>
        /// <returns>DestinyDefinitionsDestinyNodeSocketReplaceResponseBuilder</returns>
        public static DestinyDefinitionsDestinyNodeSocketReplaceResponseBuilder Builder()
        {
            return new DestinyDefinitionsDestinyNodeSocketReplaceResponseBuilder();
        }

        /// <summary>
        /// Returns DestinyDefinitionsDestinyNodeSocketReplaceResponseBuilder with properties set.
        /// Use it to change properties.
        /// </summary>
        /// <returns>DestinyDefinitionsDestinyNodeSocketReplaceResponseBuilder</returns>
        public DestinyDefinitionsDestinyNodeSocketReplaceResponseBuilder With()
        {
            return Builder()
                .SocketTypeHash(SocketTypeHash)
                .PlugItemHash(PlugItemHash);
        }

        public override string ToString()
        {
            return this.PropertiesToString();
        }

        public override bool Equals(object obj)
        {
            return this.EqualsByProperties(obj);
        }

        public bool Equals(DestinyDefinitionsDestinyNodeSocketReplaceResponse other)
        {
            return Equals((object) other);
        }

        public override int GetHashCode()
        {
            return this.PropertiesHash();
        }

        /// <summary>
        /// Implementation of == operator for (DestinyDefinitionsDestinyNodeSocketReplaceResponse.
        /// </summary>
        /// <param name="left">Compared (DestinyDefinitionsDestinyNodeSocketReplaceResponse</param>
        /// <param name="right">Compared (DestinyDefinitionsDestinyNodeSocketReplaceResponse</param>
        /// <returns>true if compared items are equals, false otherwise</returns>
        public static bool operator == (DestinyDefinitionsDestinyNodeSocketReplaceResponse left, DestinyDefinitionsDestinyNodeSocketReplaceResponse right)
        {
            return Equals(left, right);
        }

        /// <summary>
        /// Implementation of != operator for (DestinyDefinitionsDestinyNodeSocketReplaceResponse.
        /// </summary>
        /// <param name="left">Compared (DestinyDefinitionsDestinyNodeSocketReplaceResponse</param>
        /// <param name="right">Compared (DestinyDefinitionsDestinyNodeSocketReplaceResponse</param>
        /// <returns>true if compared items are not equals, false otherwise</returns>
        public static bool operator != (DestinyDefinitionsDestinyNodeSocketReplaceResponse left, DestinyDefinitionsDestinyNodeSocketReplaceResponse right)
        {
            return !Equals(left, right);
        }

        /// <summary>
        /// Builder of DestinyDefinitionsDestinyNodeSocketReplaceResponse.
        /// </summary>
        public sealed class DestinyDefinitionsDestinyNodeSocketReplaceResponseBuilder
        {
            private int? _SocketTypeHash;
            private int? _PlugItemHash;

            internal DestinyDefinitionsDestinyNodeSocketReplaceResponseBuilder()
            {
                SetupDefaults();
            }

            private void SetupDefaults()
            {
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsDestinyNodeSocketReplaceResponse.SocketTypeHash property.
            /// </summary>
            /// <param name="value">The hash identifier of the socket type to find amidst the item&#39;s sockets (the item to which this talent grid is attached). See DestinyInventoryItemDefinition.sockets.socketEntries to find the socket type of sockets on the item in question.</param>
            public DestinyDefinitionsDestinyNodeSocketReplaceResponseBuilder SocketTypeHash(int? value)
            {
                _SocketTypeHash = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsDestinyNodeSocketReplaceResponse.PlugItemHash property.
            /// </summary>
            /// <param name="value">The hash identifier of the plug item that will be inserted into the socket found.</param>
            public DestinyDefinitionsDestinyNodeSocketReplaceResponseBuilder PlugItemHash(int? value)
            {
                _PlugItemHash = value;
                return this;
            }


            /// <summary>
            /// Builds instance of DestinyDefinitionsDestinyNodeSocketReplaceResponse.
            /// </summary>
            /// <returns>DestinyDefinitionsDestinyNodeSocketReplaceResponse</returns>
            public DestinyDefinitionsDestinyNodeSocketReplaceResponse Build()
            {
                Validate();
                return new DestinyDefinitionsDestinyNodeSocketReplaceResponse(
                    SocketTypeHash: _SocketTypeHash,
                    PlugItemHash: _PlugItemHash
                );
            }

            private void Validate()
            { 
            }
        }

        
    }
}