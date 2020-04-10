using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Sharpility.Extensions;
using NodaTime;

namespace BungieNetApi._Platform.Models
{
    /// <summary>
    /// Represents a socket that has a plug associated with it intrinsically. This is useful for situations where the weapon needs to have a visual plug/Mod on it, but that plug/Mod should never change.
    /// </summary>
    public sealed class DestinyDefinitionsDestinyItemIntrinsicSocketEntryDefinition:  IEquatable<DestinyDefinitionsDestinyItemIntrinsicSocketEntryDefinition>
    { 
        /// <summary>
        /// Indicates the plug that is intrinsically inserted into this socket.
        /// </summary>
        public int? PlugItemHash { get; private set; }

        /// <summary>
        /// Indicates the type of this intrinsic socket.
        /// </summary>
        public int? SocketTypeHash { get; private set; }

        /// <summary>
        /// If true, then this socket is visible in the item&#39;s \&quot;default\&quot; state. If you have an instance, you should always check the runtime state, as that can override this visibility setting: but if you&#39;re looking at the item on a conceptual level, this property can be useful for hiding data such as legacy sockets - which remain defined on items for infrastructure purposes, but can be confusing for users to see.
        /// </summary>
        public bool? DefaultVisible { get; private set; }


        /// <summary>
        /// Empty constructor required by some serializers.
        /// Use DestinyDefinitionsDestinyItemIntrinsicSocketEntryDefinition.Builder() for instance creation instead.
        /// </summary>
        [Obsolete]
        public DestinyDefinitionsDestinyItemIntrinsicSocketEntryDefinition()
        {
        }

        private DestinyDefinitionsDestinyItemIntrinsicSocketEntryDefinition(int? PlugItemHash, int? SocketTypeHash, bool? DefaultVisible)
        {
            
            this.PlugItemHash = PlugItemHash;
            
            this.SocketTypeHash = SocketTypeHash;
            
            this.DefaultVisible = DefaultVisible;
            
        }

        /// <summary>
        /// Returns builder of DestinyDefinitionsDestinyItemIntrinsicSocketEntryDefinition.
        /// </summary>
        /// <returns>DestinyDefinitionsDestinyItemIntrinsicSocketEntryDefinitionBuilder</returns>
        public static DestinyDefinitionsDestinyItemIntrinsicSocketEntryDefinitionBuilder Builder()
        {
            return new DestinyDefinitionsDestinyItemIntrinsicSocketEntryDefinitionBuilder();
        }

        /// <summary>
        /// Returns DestinyDefinitionsDestinyItemIntrinsicSocketEntryDefinitionBuilder with properties set.
        /// Use it to change properties.
        /// </summary>
        /// <returns>DestinyDefinitionsDestinyItemIntrinsicSocketEntryDefinitionBuilder</returns>
        public DestinyDefinitionsDestinyItemIntrinsicSocketEntryDefinitionBuilder With()
        {
            return Builder()
                .PlugItemHash(PlugItemHash)
                .SocketTypeHash(SocketTypeHash)
                .DefaultVisible(DefaultVisible);
        }

        public override string ToString()
        {
            return this.PropertiesToString();
        }

        public override bool Equals(object obj)
        {
            return this.EqualsByProperties(obj);
        }

        public bool Equals(DestinyDefinitionsDestinyItemIntrinsicSocketEntryDefinition other)
        {
            return Equals((object) other);
        }

        public override int GetHashCode()
        {
            return this.PropertiesHash();
        }

        /// <summary>
        /// Implementation of == operator for (DestinyDefinitionsDestinyItemIntrinsicSocketEntryDefinition.
        /// </summary>
        /// <param name="left">Compared (DestinyDefinitionsDestinyItemIntrinsicSocketEntryDefinition</param>
        /// <param name="right">Compared (DestinyDefinitionsDestinyItemIntrinsicSocketEntryDefinition</param>
        /// <returns>true if compared items are equals, false otherwise</returns>
        public static bool operator == (DestinyDefinitionsDestinyItemIntrinsicSocketEntryDefinition left, DestinyDefinitionsDestinyItemIntrinsicSocketEntryDefinition right)
        {
            return Equals(left, right);
        }

        /// <summary>
        /// Implementation of != operator for (DestinyDefinitionsDestinyItemIntrinsicSocketEntryDefinition.
        /// </summary>
        /// <param name="left">Compared (DestinyDefinitionsDestinyItemIntrinsicSocketEntryDefinition</param>
        /// <param name="right">Compared (DestinyDefinitionsDestinyItemIntrinsicSocketEntryDefinition</param>
        /// <returns>true if compared items are not equals, false otherwise</returns>
        public static bool operator != (DestinyDefinitionsDestinyItemIntrinsicSocketEntryDefinition left, DestinyDefinitionsDestinyItemIntrinsicSocketEntryDefinition right)
        {
            return !Equals(left, right);
        }

        /// <summary>
        /// Builder of DestinyDefinitionsDestinyItemIntrinsicSocketEntryDefinition.
        /// </summary>
        public sealed class DestinyDefinitionsDestinyItemIntrinsicSocketEntryDefinitionBuilder
        {
            private int? _PlugItemHash;
            private int? _SocketTypeHash;
            private bool? _DefaultVisible;

            internal DestinyDefinitionsDestinyItemIntrinsicSocketEntryDefinitionBuilder()
            {
                SetupDefaults();
            }

            private void SetupDefaults()
            {
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsDestinyItemIntrinsicSocketEntryDefinition.PlugItemHash property.
            /// </summary>
            /// <param name="value">Indicates the plug that is intrinsically inserted into this socket.</param>
            public DestinyDefinitionsDestinyItemIntrinsicSocketEntryDefinitionBuilder PlugItemHash(int? value)
            {
                _PlugItemHash = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsDestinyItemIntrinsicSocketEntryDefinition.SocketTypeHash property.
            /// </summary>
            /// <param name="value">Indicates the type of this intrinsic socket.</param>
            public DestinyDefinitionsDestinyItemIntrinsicSocketEntryDefinitionBuilder SocketTypeHash(int? value)
            {
                _SocketTypeHash = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsDestinyItemIntrinsicSocketEntryDefinition.DefaultVisible property.
            /// </summary>
            /// <param name="value">If true, then this socket is visible in the item&#39;s \&quot;default\&quot; state. If you have an instance, you should always check the runtime state, as that can override this visibility setting: but if you&#39;re looking at the item on a conceptual level, this property can be useful for hiding data such as legacy sockets - which remain defined on items for infrastructure purposes, but can be confusing for users to see.</param>
            public DestinyDefinitionsDestinyItemIntrinsicSocketEntryDefinitionBuilder DefaultVisible(bool? value)
            {
                _DefaultVisible = value;
                return this;
            }


            /// <summary>
            /// Builds instance of DestinyDefinitionsDestinyItemIntrinsicSocketEntryDefinition.
            /// </summary>
            /// <returns>DestinyDefinitionsDestinyItemIntrinsicSocketEntryDefinition</returns>
            public DestinyDefinitionsDestinyItemIntrinsicSocketEntryDefinition Build()
            {
                Validate();
                return new DestinyDefinitionsDestinyItemIntrinsicSocketEntryDefinition(
                    PlugItemHash: _PlugItemHash,
                    SocketTypeHash: _SocketTypeHash,
                    DefaultVisible: _DefaultVisible
                );
            }

            private void Validate()
            { 
            }
        }

        
    }
}