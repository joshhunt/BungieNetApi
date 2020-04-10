using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Sharpility.Extensions;
using NodaTime;

namespace BungieNetApi._Platform.Models
{
    /// <summary>
    /// DestinyDefinitionsPresentationDestinyPresentationNodeCollectibleChildEntry
    /// </summary>
    public sealed class DestinyDefinitionsPresentationDestinyPresentationNodeCollectibleChildEntry:  IEquatable<DestinyDefinitionsPresentationDestinyPresentationNodeCollectibleChildEntry>
    { 
        /// <summary>
        /// CollectibleHash
        /// </summary>
        public int? CollectibleHash { get; private set; }


        /// <summary>
        /// Empty constructor required by some serializers.
        /// Use DestinyDefinitionsPresentationDestinyPresentationNodeCollectibleChildEntry.Builder() for instance creation instead.
        /// </summary>
        [Obsolete]
        public DestinyDefinitionsPresentationDestinyPresentationNodeCollectibleChildEntry()
        {
        }

        private DestinyDefinitionsPresentationDestinyPresentationNodeCollectibleChildEntry(int? CollectibleHash)
        {
            
            this.CollectibleHash = CollectibleHash;
            
        }

        /// <summary>
        /// Returns builder of DestinyDefinitionsPresentationDestinyPresentationNodeCollectibleChildEntry.
        /// </summary>
        /// <returns>DestinyDefinitionsPresentationDestinyPresentationNodeCollectibleChildEntryBuilder</returns>
        public static DestinyDefinitionsPresentationDestinyPresentationNodeCollectibleChildEntryBuilder Builder()
        {
            return new DestinyDefinitionsPresentationDestinyPresentationNodeCollectibleChildEntryBuilder();
        }

        /// <summary>
        /// Returns DestinyDefinitionsPresentationDestinyPresentationNodeCollectibleChildEntryBuilder with properties set.
        /// Use it to change properties.
        /// </summary>
        /// <returns>DestinyDefinitionsPresentationDestinyPresentationNodeCollectibleChildEntryBuilder</returns>
        public DestinyDefinitionsPresentationDestinyPresentationNodeCollectibleChildEntryBuilder With()
        {
            return Builder()
                .CollectibleHash(CollectibleHash);
        }

        public override string ToString()
        {
            return this.PropertiesToString();
        }

        public override bool Equals(object obj)
        {
            return this.EqualsByProperties(obj);
        }

        public bool Equals(DestinyDefinitionsPresentationDestinyPresentationNodeCollectibleChildEntry other)
        {
            return Equals((object) other);
        }

        public override int GetHashCode()
        {
            return this.PropertiesHash();
        }

        /// <summary>
        /// Implementation of == operator for (DestinyDefinitionsPresentationDestinyPresentationNodeCollectibleChildEntry.
        /// </summary>
        /// <param name="left">Compared (DestinyDefinitionsPresentationDestinyPresentationNodeCollectibleChildEntry</param>
        /// <param name="right">Compared (DestinyDefinitionsPresentationDestinyPresentationNodeCollectibleChildEntry</param>
        /// <returns>true if compared items are equals, false otherwise</returns>
        public static bool operator == (DestinyDefinitionsPresentationDestinyPresentationNodeCollectibleChildEntry left, DestinyDefinitionsPresentationDestinyPresentationNodeCollectibleChildEntry right)
        {
            return Equals(left, right);
        }

        /// <summary>
        /// Implementation of != operator for (DestinyDefinitionsPresentationDestinyPresentationNodeCollectibleChildEntry.
        /// </summary>
        /// <param name="left">Compared (DestinyDefinitionsPresentationDestinyPresentationNodeCollectibleChildEntry</param>
        /// <param name="right">Compared (DestinyDefinitionsPresentationDestinyPresentationNodeCollectibleChildEntry</param>
        /// <returns>true if compared items are not equals, false otherwise</returns>
        public static bool operator != (DestinyDefinitionsPresentationDestinyPresentationNodeCollectibleChildEntry left, DestinyDefinitionsPresentationDestinyPresentationNodeCollectibleChildEntry right)
        {
            return !Equals(left, right);
        }

        /// <summary>
        /// Builder of DestinyDefinitionsPresentationDestinyPresentationNodeCollectibleChildEntry.
        /// </summary>
        public sealed class DestinyDefinitionsPresentationDestinyPresentationNodeCollectibleChildEntryBuilder
        {
            private int? _CollectibleHash;

            internal DestinyDefinitionsPresentationDestinyPresentationNodeCollectibleChildEntryBuilder()
            {
                SetupDefaults();
            }

            private void SetupDefaults()
            {
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsPresentationDestinyPresentationNodeCollectibleChildEntry.CollectibleHash property.
            /// </summary>
            /// <param name="value">CollectibleHash</param>
            public DestinyDefinitionsPresentationDestinyPresentationNodeCollectibleChildEntryBuilder CollectibleHash(int? value)
            {
                _CollectibleHash = value;
                return this;
            }


            /// <summary>
            /// Builds instance of DestinyDefinitionsPresentationDestinyPresentationNodeCollectibleChildEntry.
            /// </summary>
            /// <returns>DestinyDefinitionsPresentationDestinyPresentationNodeCollectibleChildEntry</returns>
            public DestinyDefinitionsPresentationDestinyPresentationNodeCollectibleChildEntry Build()
            {
                Validate();
                return new DestinyDefinitionsPresentationDestinyPresentationNodeCollectibleChildEntry(
                    CollectibleHash: _CollectibleHash
                );
            }

            private void Validate()
            { 
            }
        }

        
    }
}