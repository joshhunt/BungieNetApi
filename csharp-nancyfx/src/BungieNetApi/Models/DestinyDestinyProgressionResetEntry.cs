using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Sharpility.Extensions;
using NodaTime;

namespace BungieNetApi._Platform.Models
{
    /// <summary>
    /// Represents a season and the number of resets you had in that season.   We do not necessarily - even for progressions with resets - track it over all seasons. So be careful and check the season numbers being returned.
    /// </summary>
    public sealed class DestinyDestinyProgressionResetEntry:  IEquatable<DestinyDestinyProgressionResetEntry>
    { 
        /// <summary>
        /// Season
        /// </summary>
        public int? Season { get; private set; }

        /// <summary>
        /// Resets
        /// </summary>
        public int? Resets { get; private set; }


        /// <summary>
        /// Empty constructor required by some serializers.
        /// Use DestinyDestinyProgressionResetEntry.Builder() for instance creation instead.
        /// </summary>
        [Obsolete]
        public DestinyDestinyProgressionResetEntry()
        {
        }

        private DestinyDestinyProgressionResetEntry(int? Season, int? Resets)
        {
            
            this.Season = Season;
            
            this.Resets = Resets;
            
        }

        /// <summary>
        /// Returns builder of DestinyDestinyProgressionResetEntry.
        /// </summary>
        /// <returns>DestinyDestinyProgressionResetEntryBuilder</returns>
        public static DestinyDestinyProgressionResetEntryBuilder Builder()
        {
            return new DestinyDestinyProgressionResetEntryBuilder();
        }

        /// <summary>
        /// Returns DestinyDestinyProgressionResetEntryBuilder with properties set.
        /// Use it to change properties.
        /// </summary>
        /// <returns>DestinyDestinyProgressionResetEntryBuilder</returns>
        public DestinyDestinyProgressionResetEntryBuilder With()
        {
            return Builder()
                .Season(Season)
                .Resets(Resets);
        }

        public override string ToString()
        {
            return this.PropertiesToString();
        }

        public override bool Equals(object obj)
        {
            return this.EqualsByProperties(obj);
        }

        public bool Equals(DestinyDestinyProgressionResetEntry other)
        {
            return Equals((object) other);
        }

        public override int GetHashCode()
        {
            return this.PropertiesHash();
        }

        /// <summary>
        /// Implementation of == operator for (DestinyDestinyProgressionResetEntry.
        /// </summary>
        /// <param name="left">Compared (DestinyDestinyProgressionResetEntry</param>
        /// <param name="right">Compared (DestinyDestinyProgressionResetEntry</param>
        /// <returns>true if compared items are equals, false otherwise</returns>
        public static bool operator == (DestinyDestinyProgressionResetEntry left, DestinyDestinyProgressionResetEntry right)
        {
            return Equals(left, right);
        }

        /// <summary>
        /// Implementation of != operator for (DestinyDestinyProgressionResetEntry.
        /// </summary>
        /// <param name="left">Compared (DestinyDestinyProgressionResetEntry</param>
        /// <param name="right">Compared (DestinyDestinyProgressionResetEntry</param>
        /// <returns>true if compared items are not equals, false otherwise</returns>
        public static bool operator != (DestinyDestinyProgressionResetEntry left, DestinyDestinyProgressionResetEntry right)
        {
            return !Equals(left, right);
        }

        /// <summary>
        /// Builder of DestinyDestinyProgressionResetEntry.
        /// </summary>
        public sealed class DestinyDestinyProgressionResetEntryBuilder
        {
            private int? _Season;
            private int? _Resets;

            internal DestinyDestinyProgressionResetEntryBuilder()
            {
                SetupDefaults();
            }

            private void SetupDefaults()
            {
            }

            /// <summary>
            /// Sets value for DestinyDestinyProgressionResetEntry.Season property.
            /// </summary>
            /// <param name="value">Season</param>
            public DestinyDestinyProgressionResetEntryBuilder Season(int? value)
            {
                _Season = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDestinyProgressionResetEntry.Resets property.
            /// </summary>
            /// <param name="value">Resets</param>
            public DestinyDestinyProgressionResetEntryBuilder Resets(int? value)
            {
                _Resets = value;
                return this;
            }


            /// <summary>
            /// Builds instance of DestinyDestinyProgressionResetEntry.
            /// </summary>
            /// <returns>DestinyDestinyProgressionResetEntry</returns>
            public DestinyDestinyProgressionResetEntry Build()
            {
                Validate();
                return new DestinyDestinyProgressionResetEntry(
                    Season: _Season,
                    Resets: _Resets
                );
            }

            private void Validate()
            { 
            }
        }

        
    }
}