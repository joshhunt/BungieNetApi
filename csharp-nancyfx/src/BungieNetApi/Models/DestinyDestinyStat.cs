using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Sharpility.Extensions;
using NodaTime;

namespace BungieNetApi._Platform.Models
{
    /// <summary>
    /// Represents a stat on an item *or* Character (NOT a Historical Stat, but a physical attribute stat like Attack, Defense etc...)
    /// </summary>
    public sealed class DestinyDestinyStat:  IEquatable<DestinyDestinyStat>
    { 
        /// <summary>
        /// The hash identifier for the Stat. Use it to look up the DestinyStatDefinition for static data about the stat.
        /// </summary>
        public int? StatHash { get; private set; }

        /// <summary>
        /// The current value of the Stat.
        /// </summary>
        public int? Value { get; private set; }


        /// <summary>
        /// Empty constructor required by some serializers.
        /// Use DestinyDestinyStat.Builder() for instance creation instead.
        /// </summary>
        [Obsolete]
        public DestinyDestinyStat()
        {
        }

        private DestinyDestinyStat(int? StatHash, int? Value)
        {
            
            this.StatHash = StatHash;
            
            this.Value = Value;
            
        }

        /// <summary>
        /// Returns builder of DestinyDestinyStat.
        /// </summary>
        /// <returns>DestinyDestinyStatBuilder</returns>
        public static DestinyDestinyStatBuilder Builder()
        {
            return new DestinyDestinyStatBuilder();
        }

        /// <summary>
        /// Returns DestinyDestinyStatBuilder with properties set.
        /// Use it to change properties.
        /// </summary>
        /// <returns>DestinyDestinyStatBuilder</returns>
        public DestinyDestinyStatBuilder With()
        {
            return Builder()
                .StatHash(StatHash)
                .Value(Value);
        }

        public override string ToString()
        {
            return this.PropertiesToString();
        }

        public override bool Equals(object obj)
        {
            return this.EqualsByProperties(obj);
        }

        public bool Equals(DestinyDestinyStat other)
        {
            return Equals((object) other);
        }

        public override int GetHashCode()
        {
            return this.PropertiesHash();
        }

        /// <summary>
        /// Implementation of == operator for (DestinyDestinyStat.
        /// </summary>
        /// <param name="left">Compared (DestinyDestinyStat</param>
        /// <param name="right">Compared (DestinyDestinyStat</param>
        /// <returns>true if compared items are equals, false otherwise</returns>
        public static bool operator == (DestinyDestinyStat left, DestinyDestinyStat right)
        {
            return Equals(left, right);
        }

        /// <summary>
        /// Implementation of != operator for (DestinyDestinyStat.
        /// </summary>
        /// <param name="left">Compared (DestinyDestinyStat</param>
        /// <param name="right">Compared (DestinyDestinyStat</param>
        /// <returns>true if compared items are not equals, false otherwise</returns>
        public static bool operator != (DestinyDestinyStat left, DestinyDestinyStat right)
        {
            return !Equals(left, right);
        }

        /// <summary>
        /// Builder of DestinyDestinyStat.
        /// </summary>
        public sealed class DestinyDestinyStatBuilder
        {
            private int? _StatHash;
            private int? _Value;

            internal DestinyDestinyStatBuilder()
            {
                SetupDefaults();
            }

            private void SetupDefaults()
            {
            }

            /// <summary>
            /// Sets value for DestinyDestinyStat.StatHash property.
            /// </summary>
            /// <param name="value">The hash identifier for the Stat. Use it to look up the DestinyStatDefinition for static data about the stat.</param>
            public DestinyDestinyStatBuilder StatHash(int? value)
            {
                _StatHash = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDestinyStat.Value property.
            /// </summary>
            /// <param name="value">The current value of the Stat.</param>
            public DestinyDestinyStatBuilder Value(int? value)
            {
                _Value = value;
                return this;
            }


            /// <summary>
            /// Builds instance of DestinyDestinyStat.
            /// </summary>
            /// <returns>DestinyDestinyStat</returns>
            public DestinyDestinyStat Build()
            {
                Validate();
                return new DestinyDestinyStat(
                    StatHash: _StatHash,
                    Value: _Value
                );
            }

            private void Validate()
            { 
            }
        }

        
    }
}