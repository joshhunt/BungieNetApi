using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Sharpility.Extensions;
using NodaTime;

namespace BungieNetApi._Platform.Models
{
    /// <summary>
    /// DestinyDefinitionsPresentationDestinyPresentationNodeChildEntry
    /// </summary>
    public sealed class DestinyDefinitionsPresentationDestinyPresentationNodeChildEntry:  IEquatable<DestinyDefinitionsPresentationDestinyPresentationNodeChildEntry>
    { 
        /// <summary>
        /// PresentationNodeHash
        /// </summary>
        public int? PresentationNodeHash { get; private set; }


        /// <summary>
        /// Empty constructor required by some serializers.
        /// Use DestinyDefinitionsPresentationDestinyPresentationNodeChildEntry.Builder() for instance creation instead.
        /// </summary>
        [Obsolete]
        public DestinyDefinitionsPresentationDestinyPresentationNodeChildEntry()
        {
        }

        private DestinyDefinitionsPresentationDestinyPresentationNodeChildEntry(int? PresentationNodeHash)
        {
            
            this.PresentationNodeHash = PresentationNodeHash;
            
        }

        /// <summary>
        /// Returns builder of DestinyDefinitionsPresentationDestinyPresentationNodeChildEntry.
        /// </summary>
        /// <returns>DestinyDefinitionsPresentationDestinyPresentationNodeChildEntryBuilder</returns>
        public static DestinyDefinitionsPresentationDestinyPresentationNodeChildEntryBuilder Builder()
        {
            return new DestinyDefinitionsPresentationDestinyPresentationNodeChildEntryBuilder();
        }

        /// <summary>
        /// Returns DestinyDefinitionsPresentationDestinyPresentationNodeChildEntryBuilder with properties set.
        /// Use it to change properties.
        /// </summary>
        /// <returns>DestinyDefinitionsPresentationDestinyPresentationNodeChildEntryBuilder</returns>
        public DestinyDefinitionsPresentationDestinyPresentationNodeChildEntryBuilder With()
        {
            return Builder()
                .PresentationNodeHash(PresentationNodeHash);
        }

        public override string ToString()
        {
            return this.PropertiesToString();
        }

        public override bool Equals(object obj)
        {
            return this.EqualsByProperties(obj);
        }

        public bool Equals(DestinyDefinitionsPresentationDestinyPresentationNodeChildEntry other)
        {
            return Equals((object) other);
        }

        public override int GetHashCode()
        {
            return this.PropertiesHash();
        }

        /// <summary>
        /// Implementation of == operator for (DestinyDefinitionsPresentationDestinyPresentationNodeChildEntry.
        /// </summary>
        /// <param name="left">Compared (DestinyDefinitionsPresentationDestinyPresentationNodeChildEntry</param>
        /// <param name="right">Compared (DestinyDefinitionsPresentationDestinyPresentationNodeChildEntry</param>
        /// <returns>true if compared items are equals, false otherwise</returns>
        public static bool operator == (DestinyDefinitionsPresentationDestinyPresentationNodeChildEntry left, DestinyDefinitionsPresentationDestinyPresentationNodeChildEntry right)
        {
            return Equals(left, right);
        }

        /// <summary>
        /// Implementation of != operator for (DestinyDefinitionsPresentationDestinyPresentationNodeChildEntry.
        /// </summary>
        /// <param name="left">Compared (DestinyDefinitionsPresentationDestinyPresentationNodeChildEntry</param>
        /// <param name="right">Compared (DestinyDefinitionsPresentationDestinyPresentationNodeChildEntry</param>
        /// <returns>true if compared items are not equals, false otherwise</returns>
        public static bool operator != (DestinyDefinitionsPresentationDestinyPresentationNodeChildEntry left, DestinyDefinitionsPresentationDestinyPresentationNodeChildEntry right)
        {
            return !Equals(left, right);
        }

        /// <summary>
        /// Builder of DestinyDefinitionsPresentationDestinyPresentationNodeChildEntry.
        /// </summary>
        public sealed class DestinyDefinitionsPresentationDestinyPresentationNodeChildEntryBuilder
        {
            private int? _PresentationNodeHash;

            internal DestinyDefinitionsPresentationDestinyPresentationNodeChildEntryBuilder()
            {
                SetupDefaults();
            }

            private void SetupDefaults()
            {
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsPresentationDestinyPresentationNodeChildEntry.PresentationNodeHash property.
            /// </summary>
            /// <param name="value">PresentationNodeHash</param>
            public DestinyDefinitionsPresentationDestinyPresentationNodeChildEntryBuilder PresentationNodeHash(int? value)
            {
                _PresentationNodeHash = value;
                return this;
            }


            /// <summary>
            /// Builds instance of DestinyDefinitionsPresentationDestinyPresentationNodeChildEntry.
            /// </summary>
            /// <returns>DestinyDefinitionsPresentationDestinyPresentationNodeChildEntry</returns>
            public DestinyDefinitionsPresentationDestinyPresentationNodeChildEntry Build()
            {
                Validate();
                return new DestinyDefinitionsPresentationDestinyPresentationNodeChildEntry(
                    PresentationNodeHash: _PresentationNodeHash
                );
            }

            private void Validate()
            { 
            }
        }

        
    }
}