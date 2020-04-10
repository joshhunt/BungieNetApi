using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Sharpility.Extensions;
using NodaTime;

namespace BungieNetApi._Platform.Models
{
    /// <summary>
    /// The results of a bulk Equipping operation performed through the Destiny API.
    /// </summary>
    public sealed class DestinyDestinyEquipItemResults:  IEquatable<DestinyDestinyEquipItemResults>
    { 
        /// <summary>
        /// EquipResults
        /// </summary>
        public List<DestinyDestinyEquipItemResult> EquipResults { get; private set; }


        /// <summary>
        /// Empty constructor required by some serializers.
        /// Use DestinyDestinyEquipItemResults.Builder() for instance creation instead.
        /// </summary>
        [Obsolete]
        public DestinyDestinyEquipItemResults()
        {
        }

        private DestinyDestinyEquipItemResults(List<DestinyDestinyEquipItemResult> EquipResults)
        {
            
            this.EquipResults = EquipResults;
            
        }

        /// <summary>
        /// Returns builder of DestinyDestinyEquipItemResults.
        /// </summary>
        /// <returns>DestinyDestinyEquipItemResultsBuilder</returns>
        public static DestinyDestinyEquipItemResultsBuilder Builder()
        {
            return new DestinyDestinyEquipItemResultsBuilder();
        }

        /// <summary>
        /// Returns DestinyDestinyEquipItemResultsBuilder with properties set.
        /// Use it to change properties.
        /// </summary>
        /// <returns>DestinyDestinyEquipItemResultsBuilder</returns>
        public DestinyDestinyEquipItemResultsBuilder With()
        {
            return Builder()
                .EquipResults(EquipResults);
        }

        public override string ToString()
        {
            return this.PropertiesToString();
        }

        public override bool Equals(object obj)
        {
            return this.EqualsByProperties(obj);
        }

        public bool Equals(DestinyDestinyEquipItemResults other)
        {
            return Equals((object) other);
        }

        public override int GetHashCode()
        {
            return this.PropertiesHash();
        }

        /// <summary>
        /// Implementation of == operator for (DestinyDestinyEquipItemResults.
        /// </summary>
        /// <param name="left">Compared (DestinyDestinyEquipItemResults</param>
        /// <param name="right">Compared (DestinyDestinyEquipItemResults</param>
        /// <returns>true if compared items are equals, false otherwise</returns>
        public static bool operator == (DestinyDestinyEquipItemResults left, DestinyDestinyEquipItemResults right)
        {
            return Equals(left, right);
        }

        /// <summary>
        /// Implementation of != operator for (DestinyDestinyEquipItemResults.
        /// </summary>
        /// <param name="left">Compared (DestinyDestinyEquipItemResults</param>
        /// <param name="right">Compared (DestinyDestinyEquipItemResults</param>
        /// <returns>true if compared items are not equals, false otherwise</returns>
        public static bool operator != (DestinyDestinyEquipItemResults left, DestinyDestinyEquipItemResults right)
        {
            return !Equals(left, right);
        }

        /// <summary>
        /// Builder of DestinyDestinyEquipItemResults.
        /// </summary>
        public sealed class DestinyDestinyEquipItemResultsBuilder
        {
            private List<DestinyDestinyEquipItemResult> _EquipResults;

            internal DestinyDestinyEquipItemResultsBuilder()
            {
                SetupDefaults();
            }

            private void SetupDefaults()
            {
            }

            /// <summary>
            /// Sets value for DestinyDestinyEquipItemResults.EquipResults property.
            /// </summary>
            /// <param name="value">EquipResults</param>
            public DestinyDestinyEquipItemResultsBuilder EquipResults(List<DestinyDestinyEquipItemResult> value)
            {
                _EquipResults = value;
                return this;
            }


            /// <summary>
            /// Builds instance of DestinyDestinyEquipItemResults.
            /// </summary>
            /// <returns>DestinyDestinyEquipItemResults</returns>
            public DestinyDestinyEquipItemResults Build()
            {
                Validate();
                return new DestinyDestinyEquipItemResults(
                    EquipResults: _EquipResults
                );
            }

            private void Validate()
            { 
            }
        }

        
    }
}