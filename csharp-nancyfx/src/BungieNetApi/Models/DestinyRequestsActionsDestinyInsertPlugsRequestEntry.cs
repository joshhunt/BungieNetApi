using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Sharpility.Extensions;
using NodaTime;

namespace BungieNetApi._Platform.Models
{
    /// <summary>
    /// Represents all of the data related to a single plug to be inserted.  Note that, while you *can* point to a socket that represents infusion, you will receive an error if you attempt to do so. Come on guys, let&#39;s play nice.
    /// </summary>
    public sealed class DestinyRequestsActionsDestinyInsertPlugsRequestEntry:  IEquatable<DestinyRequestsActionsDestinyInsertPlugsRequestEntry>
    { 
        /// <summary>
        /// The index into the socket array, which identifies the specific socket being operated on. We also need to know the socketArrayType in order to uniquely identify the socket.  Don&#39;t point to or try to insert a plug into an infusion socket. It won&#39;t work.
        /// </summary>
        public int? SocketIndex { get; private set; }

        /// <summary>
        /// This property, combined with the socketIndex, tells us which socket we are referring to (since operations can be performed on both Intrinsic and \&quot;default\&quot; sockets, and they occupy different arrays in the Inventory Item Definition). I know, I know. Don&#39;t give me that look.
        /// </summary>
        public int? SocketArrayType { get; private set; }

        /// <summary>
        /// Plugs are never instanced (except in infusion). So with the hash alone, we should be able to: 1) Infer whether the player actually needs to have the item, or if it&#39;s a reusable plug 2) Perform any operation needed to use the Plug, including removing the plug item and running reward sheets.
        /// </summary>
        public int? PlugItemHash { get; private set; }


        /// <summary>
        /// Empty constructor required by some serializers.
        /// Use DestinyRequestsActionsDestinyInsertPlugsRequestEntry.Builder() for instance creation instead.
        /// </summary>
        [Obsolete]
        public DestinyRequestsActionsDestinyInsertPlugsRequestEntry()
        {
        }

        private DestinyRequestsActionsDestinyInsertPlugsRequestEntry(int? SocketIndex, int? SocketArrayType, int? PlugItemHash)
        {
            
            this.SocketIndex = SocketIndex;
            
            this.SocketArrayType = SocketArrayType;
            
            this.PlugItemHash = PlugItemHash;
            
        }

        /// <summary>
        /// Returns builder of DestinyRequestsActionsDestinyInsertPlugsRequestEntry.
        /// </summary>
        /// <returns>DestinyRequestsActionsDestinyInsertPlugsRequestEntryBuilder</returns>
        public static DestinyRequestsActionsDestinyInsertPlugsRequestEntryBuilder Builder()
        {
            return new DestinyRequestsActionsDestinyInsertPlugsRequestEntryBuilder();
        }

        /// <summary>
        /// Returns DestinyRequestsActionsDestinyInsertPlugsRequestEntryBuilder with properties set.
        /// Use it to change properties.
        /// </summary>
        /// <returns>DestinyRequestsActionsDestinyInsertPlugsRequestEntryBuilder</returns>
        public DestinyRequestsActionsDestinyInsertPlugsRequestEntryBuilder With()
        {
            return Builder()
                .SocketIndex(SocketIndex)
                .SocketArrayType(SocketArrayType)
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

        public bool Equals(DestinyRequestsActionsDestinyInsertPlugsRequestEntry other)
        {
            return Equals((object) other);
        }

        public override int GetHashCode()
        {
            return this.PropertiesHash();
        }

        /// <summary>
        /// Implementation of == operator for (DestinyRequestsActionsDestinyInsertPlugsRequestEntry.
        /// </summary>
        /// <param name="left">Compared (DestinyRequestsActionsDestinyInsertPlugsRequestEntry</param>
        /// <param name="right">Compared (DestinyRequestsActionsDestinyInsertPlugsRequestEntry</param>
        /// <returns>true if compared items are equals, false otherwise</returns>
        public static bool operator == (DestinyRequestsActionsDestinyInsertPlugsRequestEntry left, DestinyRequestsActionsDestinyInsertPlugsRequestEntry right)
        {
            return Equals(left, right);
        }

        /// <summary>
        /// Implementation of != operator for (DestinyRequestsActionsDestinyInsertPlugsRequestEntry.
        /// </summary>
        /// <param name="left">Compared (DestinyRequestsActionsDestinyInsertPlugsRequestEntry</param>
        /// <param name="right">Compared (DestinyRequestsActionsDestinyInsertPlugsRequestEntry</param>
        /// <returns>true if compared items are not equals, false otherwise</returns>
        public static bool operator != (DestinyRequestsActionsDestinyInsertPlugsRequestEntry left, DestinyRequestsActionsDestinyInsertPlugsRequestEntry right)
        {
            return !Equals(left, right);
        }

        /// <summary>
        /// Builder of DestinyRequestsActionsDestinyInsertPlugsRequestEntry.
        /// </summary>
        public sealed class DestinyRequestsActionsDestinyInsertPlugsRequestEntryBuilder
        {
            private int? _SocketIndex;
            private int? _SocketArrayType;
            private int? _PlugItemHash;

            internal DestinyRequestsActionsDestinyInsertPlugsRequestEntryBuilder()
            {
                SetupDefaults();
            }

            private void SetupDefaults()
            {
            }

            /// <summary>
            /// Sets value for DestinyRequestsActionsDestinyInsertPlugsRequestEntry.SocketIndex property.
            /// </summary>
            /// <param name="value">The index into the socket array, which identifies the specific socket being operated on. We also need to know the socketArrayType in order to uniquely identify the socket.  Don&#39;t point to or try to insert a plug into an infusion socket. It won&#39;t work.</param>
            public DestinyRequestsActionsDestinyInsertPlugsRequestEntryBuilder SocketIndex(int? value)
            {
                _SocketIndex = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyRequestsActionsDestinyInsertPlugsRequestEntry.SocketArrayType property.
            /// </summary>
            /// <param name="value">This property, combined with the socketIndex, tells us which socket we are referring to (since operations can be performed on both Intrinsic and \&quot;default\&quot; sockets, and they occupy different arrays in the Inventory Item Definition). I know, I know. Don&#39;t give me that look.</param>
            public DestinyRequestsActionsDestinyInsertPlugsRequestEntryBuilder SocketArrayType(int? value)
            {
                _SocketArrayType = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyRequestsActionsDestinyInsertPlugsRequestEntry.PlugItemHash property.
            /// </summary>
            /// <param name="value">Plugs are never instanced (except in infusion). So with the hash alone, we should be able to: 1) Infer whether the player actually needs to have the item, or if it&#39;s a reusable plug 2) Perform any operation needed to use the Plug, including removing the plug item and running reward sheets.</param>
            public DestinyRequestsActionsDestinyInsertPlugsRequestEntryBuilder PlugItemHash(int? value)
            {
                _PlugItemHash = value;
                return this;
            }


            /// <summary>
            /// Builds instance of DestinyRequestsActionsDestinyInsertPlugsRequestEntry.
            /// </summary>
            /// <returns>DestinyRequestsActionsDestinyInsertPlugsRequestEntry</returns>
            public DestinyRequestsActionsDestinyInsertPlugsRequestEntry Build()
            {
                Validate();
                return new DestinyRequestsActionsDestinyInsertPlugsRequestEntry(
                    SocketIndex: _SocketIndex,
                    SocketArrayType: _SocketArrayType,
                    PlugItemHash: _PlugItemHash
                );
            }

            private void Validate()
            { 
            }
        }

        
    }
}