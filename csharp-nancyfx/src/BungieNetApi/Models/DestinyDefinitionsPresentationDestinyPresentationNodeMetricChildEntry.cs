using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Sharpility.Extensions;
using NodaTime;

namespace BungieNetApi._Platform.Models
{
    /// <summary>
    /// DestinyDefinitionsPresentationDestinyPresentationNodeMetricChildEntry
    /// </summary>
    public sealed class DestinyDefinitionsPresentationDestinyPresentationNodeMetricChildEntry:  IEquatable<DestinyDefinitionsPresentationDestinyPresentationNodeMetricChildEntry>
    { 
        /// <summary>
        /// MetricHash
        /// </summary>
        public int? MetricHash { get; private set; }


        /// <summary>
        /// Empty constructor required by some serializers.
        /// Use DestinyDefinitionsPresentationDestinyPresentationNodeMetricChildEntry.Builder() for instance creation instead.
        /// </summary>
        [Obsolete]
        public DestinyDefinitionsPresentationDestinyPresentationNodeMetricChildEntry()
        {
        }

        private DestinyDefinitionsPresentationDestinyPresentationNodeMetricChildEntry(int? MetricHash)
        {
            
            this.MetricHash = MetricHash;
            
        }

        /// <summary>
        /// Returns builder of DestinyDefinitionsPresentationDestinyPresentationNodeMetricChildEntry.
        /// </summary>
        /// <returns>DestinyDefinitionsPresentationDestinyPresentationNodeMetricChildEntryBuilder</returns>
        public static DestinyDefinitionsPresentationDestinyPresentationNodeMetricChildEntryBuilder Builder()
        {
            return new DestinyDefinitionsPresentationDestinyPresentationNodeMetricChildEntryBuilder();
        }

        /// <summary>
        /// Returns DestinyDefinitionsPresentationDestinyPresentationNodeMetricChildEntryBuilder with properties set.
        /// Use it to change properties.
        /// </summary>
        /// <returns>DestinyDefinitionsPresentationDestinyPresentationNodeMetricChildEntryBuilder</returns>
        public DestinyDefinitionsPresentationDestinyPresentationNodeMetricChildEntryBuilder With()
        {
            return Builder()
                .MetricHash(MetricHash);
        }

        public override string ToString()
        {
            return this.PropertiesToString();
        }

        public override bool Equals(object obj)
        {
            return this.EqualsByProperties(obj);
        }

        public bool Equals(DestinyDefinitionsPresentationDestinyPresentationNodeMetricChildEntry other)
        {
            return Equals((object) other);
        }

        public override int GetHashCode()
        {
            return this.PropertiesHash();
        }

        /// <summary>
        /// Implementation of == operator for (DestinyDefinitionsPresentationDestinyPresentationNodeMetricChildEntry.
        /// </summary>
        /// <param name="left">Compared (DestinyDefinitionsPresentationDestinyPresentationNodeMetricChildEntry</param>
        /// <param name="right">Compared (DestinyDefinitionsPresentationDestinyPresentationNodeMetricChildEntry</param>
        /// <returns>true if compared items are equals, false otherwise</returns>
        public static bool operator == (DestinyDefinitionsPresentationDestinyPresentationNodeMetricChildEntry left, DestinyDefinitionsPresentationDestinyPresentationNodeMetricChildEntry right)
        {
            return Equals(left, right);
        }

        /// <summary>
        /// Implementation of != operator for (DestinyDefinitionsPresentationDestinyPresentationNodeMetricChildEntry.
        /// </summary>
        /// <param name="left">Compared (DestinyDefinitionsPresentationDestinyPresentationNodeMetricChildEntry</param>
        /// <param name="right">Compared (DestinyDefinitionsPresentationDestinyPresentationNodeMetricChildEntry</param>
        /// <returns>true if compared items are not equals, false otherwise</returns>
        public static bool operator != (DestinyDefinitionsPresentationDestinyPresentationNodeMetricChildEntry left, DestinyDefinitionsPresentationDestinyPresentationNodeMetricChildEntry right)
        {
            return !Equals(left, right);
        }

        /// <summary>
        /// Builder of DestinyDefinitionsPresentationDestinyPresentationNodeMetricChildEntry.
        /// </summary>
        public sealed class DestinyDefinitionsPresentationDestinyPresentationNodeMetricChildEntryBuilder
        {
            private int? _MetricHash;

            internal DestinyDefinitionsPresentationDestinyPresentationNodeMetricChildEntryBuilder()
            {
                SetupDefaults();
            }

            private void SetupDefaults()
            {
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsPresentationDestinyPresentationNodeMetricChildEntry.MetricHash property.
            /// </summary>
            /// <param name="value">MetricHash</param>
            public DestinyDefinitionsPresentationDestinyPresentationNodeMetricChildEntryBuilder MetricHash(int? value)
            {
                _MetricHash = value;
                return this;
            }


            /// <summary>
            /// Builds instance of DestinyDefinitionsPresentationDestinyPresentationNodeMetricChildEntry.
            /// </summary>
            /// <returns>DestinyDefinitionsPresentationDestinyPresentationNodeMetricChildEntry</returns>
            public DestinyDefinitionsPresentationDestinyPresentationNodeMetricChildEntry Build()
            {
                Validate();
                return new DestinyDefinitionsPresentationDestinyPresentationNodeMetricChildEntry(
                    MetricHash: _MetricHash
                );
            }

            private void Validate()
            { 
            }
        }

        
    }
}