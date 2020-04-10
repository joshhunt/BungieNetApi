using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Sharpility.Extensions;
using NodaTime;

namespace BungieNetApi._Platform.Models
{
    /// <summary>
    /// Represents a single state that a graph node might end up in. Depending on what&#39;s going on in the game, graph nodes could be shown in different ways or even excluded from view entirely.
    /// </summary>
    public sealed class DestinyDefinitionsDirectorDestinyActivityGraphNodeStateEntry:  IEquatable<DestinyDefinitionsDirectorDestinyActivityGraphNodeStateEntry>
    { 
        /// <summary>
        /// State
        /// </summary>
        public int? State { get; private set; }


        /// <summary>
        /// Empty constructor required by some serializers.
        /// Use DestinyDefinitionsDirectorDestinyActivityGraphNodeStateEntry.Builder() for instance creation instead.
        /// </summary>
        [Obsolete]
        public DestinyDefinitionsDirectorDestinyActivityGraphNodeStateEntry()
        {
        }

        private DestinyDefinitionsDirectorDestinyActivityGraphNodeStateEntry(int? State)
        {
            
            this.State = State;
            
        }

        /// <summary>
        /// Returns builder of DestinyDefinitionsDirectorDestinyActivityGraphNodeStateEntry.
        /// </summary>
        /// <returns>DestinyDefinitionsDirectorDestinyActivityGraphNodeStateEntryBuilder</returns>
        public static DestinyDefinitionsDirectorDestinyActivityGraphNodeStateEntryBuilder Builder()
        {
            return new DestinyDefinitionsDirectorDestinyActivityGraphNodeStateEntryBuilder();
        }

        /// <summary>
        /// Returns DestinyDefinitionsDirectorDestinyActivityGraphNodeStateEntryBuilder with properties set.
        /// Use it to change properties.
        /// </summary>
        /// <returns>DestinyDefinitionsDirectorDestinyActivityGraphNodeStateEntryBuilder</returns>
        public DestinyDefinitionsDirectorDestinyActivityGraphNodeStateEntryBuilder With()
        {
            return Builder()
                .State(State);
        }

        public override string ToString()
        {
            return this.PropertiesToString();
        }

        public override bool Equals(object obj)
        {
            return this.EqualsByProperties(obj);
        }

        public bool Equals(DestinyDefinitionsDirectorDestinyActivityGraphNodeStateEntry other)
        {
            return Equals((object) other);
        }

        public override int GetHashCode()
        {
            return this.PropertiesHash();
        }

        /// <summary>
        /// Implementation of == operator for (DestinyDefinitionsDirectorDestinyActivityGraphNodeStateEntry.
        /// </summary>
        /// <param name="left">Compared (DestinyDefinitionsDirectorDestinyActivityGraphNodeStateEntry</param>
        /// <param name="right">Compared (DestinyDefinitionsDirectorDestinyActivityGraphNodeStateEntry</param>
        /// <returns>true if compared items are equals, false otherwise</returns>
        public static bool operator == (DestinyDefinitionsDirectorDestinyActivityGraphNodeStateEntry left, DestinyDefinitionsDirectorDestinyActivityGraphNodeStateEntry right)
        {
            return Equals(left, right);
        }

        /// <summary>
        /// Implementation of != operator for (DestinyDefinitionsDirectorDestinyActivityGraphNodeStateEntry.
        /// </summary>
        /// <param name="left">Compared (DestinyDefinitionsDirectorDestinyActivityGraphNodeStateEntry</param>
        /// <param name="right">Compared (DestinyDefinitionsDirectorDestinyActivityGraphNodeStateEntry</param>
        /// <returns>true if compared items are not equals, false otherwise</returns>
        public static bool operator != (DestinyDefinitionsDirectorDestinyActivityGraphNodeStateEntry left, DestinyDefinitionsDirectorDestinyActivityGraphNodeStateEntry right)
        {
            return !Equals(left, right);
        }

        /// <summary>
        /// Builder of DestinyDefinitionsDirectorDestinyActivityGraphNodeStateEntry.
        /// </summary>
        public sealed class DestinyDefinitionsDirectorDestinyActivityGraphNodeStateEntryBuilder
        {
            private int? _State;

            internal DestinyDefinitionsDirectorDestinyActivityGraphNodeStateEntryBuilder()
            {
                SetupDefaults();
            }

            private void SetupDefaults()
            {
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsDirectorDestinyActivityGraphNodeStateEntry.State property.
            /// </summary>
            /// <param name="value">State</param>
            public DestinyDefinitionsDirectorDestinyActivityGraphNodeStateEntryBuilder State(int? value)
            {
                _State = value;
                return this;
            }


            /// <summary>
            /// Builds instance of DestinyDefinitionsDirectorDestinyActivityGraphNodeStateEntry.
            /// </summary>
            /// <returns>DestinyDefinitionsDirectorDestinyActivityGraphNodeStateEntry</returns>
            public DestinyDefinitionsDirectorDestinyActivityGraphNodeStateEntry Build()
            {
                Validate();
                return new DestinyDefinitionsDirectorDestinyActivityGraphNodeStateEntry(
                    State: _State
                );
            }

            private void Validate()
            { 
            }
        }

        
    }
}