using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Sharpility.Extensions;
using NodaTime;

namespace BungieNetApi._Platform.Models
{
    /// <summary>
    /// If defined, the item has at least one socket.
    /// </summary>
    public sealed class DestinyDefinitionsDestinyItemSocketBlockDefinition:  IEquatable<DestinyDefinitionsDestinyItemSocketBlockDefinition>
    { 
        /// <summary>
        /// This was supposed to be a string that would give per-item details about sockets. In practice, it turns out that all this ever has is the localized word \&quot;details\&quot;. ... that&#39;s lame, but perhaps it will become something cool in the future.
        /// </summary>
        public string Detail { get; private set; }

        /// <summary>
        /// Each non-intrinsic (or mutable) socket on an item is defined here. Check inside for more info.
        /// </summary>
        public List<DestinyDefinitionsDestinyItemSocketEntryDefinition> SocketEntries { get; private set; }

        /// <summary>
        /// Each intrinsic (or immutable/permanent) socket on an item is defined here, along with the plug that is permanently affixed to the socket.
        /// </summary>
        public List<DestinyDefinitionsDestinyItemIntrinsicSocketEntryDefinition> IntrinsicSockets { get; private set; }

        /// <summary>
        /// A convenience property, that refers to the sockets in the \&quot;sockets\&quot; property, pre-grouped by category and ordered in the manner that they should be grouped in the UI. You could form this yourself with the existing data, but why would you want to? Enjoy life man.
        /// </summary>
        public List<DestinyDefinitionsDestinyItemSocketCategoryDefinition> SocketCategories { get; private set; }


        /// <summary>
        /// Empty constructor required by some serializers.
        /// Use DestinyDefinitionsDestinyItemSocketBlockDefinition.Builder() for instance creation instead.
        /// </summary>
        [Obsolete]
        public DestinyDefinitionsDestinyItemSocketBlockDefinition()
        {
        }

        private DestinyDefinitionsDestinyItemSocketBlockDefinition(string Detail, List<DestinyDefinitionsDestinyItemSocketEntryDefinition> SocketEntries, List<DestinyDefinitionsDestinyItemIntrinsicSocketEntryDefinition> IntrinsicSockets, List<DestinyDefinitionsDestinyItemSocketCategoryDefinition> SocketCategories)
        {
            
            this.Detail = Detail;
            
            this.SocketEntries = SocketEntries;
            
            this.IntrinsicSockets = IntrinsicSockets;
            
            this.SocketCategories = SocketCategories;
            
        }

        /// <summary>
        /// Returns builder of DestinyDefinitionsDestinyItemSocketBlockDefinition.
        /// </summary>
        /// <returns>DestinyDefinitionsDestinyItemSocketBlockDefinitionBuilder</returns>
        public static DestinyDefinitionsDestinyItemSocketBlockDefinitionBuilder Builder()
        {
            return new DestinyDefinitionsDestinyItemSocketBlockDefinitionBuilder();
        }

        /// <summary>
        /// Returns DestinyDefinitionsDestinyItemSocketBlockDefinitionBuilder with properties set.
        /// Use it to change properties.
        /// </summary>
        /// <returns>DestinyDefinitionsDestinyItemSocketBlockDefinitionBuilder</returns>
        public DestinyDefinitionsDestinyItemSocketBlockDefinitionBuilder With()
        {
            return Builder()
                .Detail(Detail)
                .SocketEntries(SocketEntries)
                .IntrinsicSockets(IntrinsicSockets)
                .SocketCategories(SocketCategories);
        }

        public override string ToString()
        {
            return this.PropertiesToString();
        }

        public override bool Equals(object obj)
        {
            return this.EqualsByProperties(obj);
        }

        public bool Equals(DestinyDefinitionsDestinyItemSocketBlockDefinition other)
        {
            return Equals((object) other);
        }

        public override int GetHashCode()
        {
            return this.PropertiesHash();
        }

        /// <summary>
        /// Implementation of == operator for (DestinyDefinitionsDestinyItemSocketBlockDefinition.
        /// </summary>
        /// <param name="left">Compared (DestinyDefinitionsDestinyItemSocketBlockDefinition</param>
        /// <param name="right">Compared (DestinyDefinitionsDestinyItemSocketBlockDefinition</param>
        /// <returns>true if compared items are equals, false otherwise</returns>
        public static bool operator == (DestinyDefinitionsDestinyItemSocketBlockDefinition left, DestinyDefinitionsDestinyItemSocketBlockDefinition right)
        {
            return Equals(left, right);
        }

        /// <summary>
        /// Implementation of != operator for (DestinyDefinitionsDestinyItemSocketBlockDefinition.
        /// </summary>
        /// <param name="left">Compared (DestinyDefinitionsDestinyItemSocketBlockDefinition</param>
        /// <param name="right">Compared (DestinyDefinitionsDestinyItemSocketBlockDefinition</param>
        /// <returns>true if compared items are not equals, false otherwise</returns>
        public static bool operator != (DestinyDefinitionsDestinyItemSocketBlockDefinition left, DestinyDefinitionsDestinyItemSocketBlockDefinition right)
        {
            return !Equals(left, right);
        }

        /// <summary>
        /// Builder of DestinyDefinitionsDestinyItemSocketBlockDefinition.
        /// </summary>
        public sealed class DestinyDefinitionsDestinyItemSocketBlockDefinitionBuilder
        {
            private string _Detail;
            private List<DestinyDefinitionsDestinyItemSocketEntryDefinition> _SocketEntries;
            private List<DestinyDefinitionsDestinyItemIntrinsicSocketEntryDefinition> _IntrinsicSockets;
            private List<DestinyDefinitionsDestinyItemSocketCategoryDefinition> _SocketCategories;

            internal DestinyDefinitionsDestinyItemSocketBlockDefinitionBuilder()
            {
                SetupDefaults();
            }

            private void SetupDefaults()
            {
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsDestinyItemSocketBlockDefinition.Detail property.
            /// </summary>
            /// <param name="value">This was supposed to be a string that would give per-item details about sockets. In practice, it turns out that all this ever has is the localized word \&quot;details\&quot;. ... that&#39;s lame, but perhaps it will become something cool in the future.</param>
            public DestinyDefinitionsDestinyItemSocketBlockDefinitionBuilder Detail(string value)
            {
                _Detail = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsDestinyItemSocketBlockDefinition.SocketEntries property.
            /// </summary>
            /// <param name="value">Each non-intrinsic (or mutable) socket on an item is defined here. Check inside for more info.</param>
            public DestinyDefinitionsDestinyItemSocketBlockDefinitionBuilder SocketEntries(List<DestinyDefinitionsDestinyItemSocketEntryDefinition> value)
            {
                _SocketEntries = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsDestinyItemSocketBlockDefinition.IntrinsicSockets property.
            /// </summary>
            /// <param name="value">Each intrinsic (or immutable/permanent) socket on an item is defined here, along with the plug that is permanently affixed to the socket.</param>
            public DestinyDefinitionsDestinyItemSocketBlockDefinitionBuilder IntrinsicSockets(List<DestinyDefinitionsDestinyItemIntrinsicSocketEntryDefinition> value)
            {
                _IntrinsicSockets = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsDestinyItemSocketBlockDefinition.SocketCategories property.
            /// </summary>
            /// <param name="value">A convenience property, that refers to the sockets in the \&quot;sockets\&quot; property, pre-grouped by category and ordered in the manner that they should be grouped in the UI. You could form this yourself with the existing data, but why would you want to? Enjoy life man.</param>
            public DestinyDefinitionsDestinyItemSocketBlockDefinitionBuilder SocketCategories(List<DestinyDefinitionsDestinyItemSocketCategoryDefinition> value)
            {
                _SocketCategories = value;
                return this;
            }


            /// <summary>
            /// Builds instance of DestinyDefinitionsDestinyItemSocketBlockDefinition.
            /// </summary>
            /// <returns>DestinyDefinitionsDestinyItemSocketBlockDefinition</returns>
            public DestinyDefinitionsDestinyItemSocketBlockDefinition Build()
            {
                Validate();
                return new DestinyDefinitionsDestinyItemSocketBlockDefinition(
                    Detail: _Detail,
                    SocketEntries: _SocketEntries,
                    IntrinsicSockets: _IntrinsicSockets,
                    SocketCategories: _SocketCategories
                );
            }

            private void Validate()
            { 
            }
        }

        
    }
}