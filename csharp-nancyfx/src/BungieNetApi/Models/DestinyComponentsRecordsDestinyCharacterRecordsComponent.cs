using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Sharpility.Extensions;
using NodaTime;

namespace BungieNetApi._Platform.Models
{
    /// <summary>
    /// DestinyComponentsRecordsDestinyCharacterRecordsComponent
    /// </summary>
    public sealed class DestinyComponentsRecordsDestinyCharacterRecordsComponent:  IEquatable<DestinyComponentsRecordsDestinyCharacterRecordsComponent>
    { 
        /// <summary>
        /// FeaturedRecordHashes
        /// </summary>
        public List<int?> FeaturedRecordHashes { get; private set; }

        /// <summary>
        /// Records
        /// </summary>
        public Dictionary<string, DestinyComponentsRecordsDestinyRecordComponent> Records { get; private set; }

        /// <summary>
        /// The hash for the root presentation node definition of Triumph categories.
        /// </summary>
        public int? RecordCategoriesRootNodeHash { get; private set; }

        /// <summary>
        /// The hash for the root presentation node definition of Triumph Seals.
        /// </summary>
        public int? RecordSealsRootNodeHash { get; private set; }


        /// <summary>
        /// Empty constructor required by some serializers.
        /// Use DestinyComponentsRecordsDestinyCharacterRecordsComponent.Builder() for instance creation instead.
        /// </summary>
        [Obsolete]
        public DestinyComponentsRecordsDestinyCharacterRecordsComponent()
        {
        }

        private DestinyComponentsRecordsDestinyCharacterRecordsComponent(List<int?> FeaturedRecordHashes, Dictionary<string, DestinyComponentsRecordsDestinyRecordComponent> Records, int? RecordCategoriesRootNodeHash, int? RecordSealsRootNodeHash)
        {
            
            this.FeaturedRecordHashes = FeaturedRecordHashes;
            
            this.Records = Records;
            
            this.RecordCategoriesRootNodeHash = RecordCategoriesRootNodeHash;
            
            this.RecordSealsRootNodeHash = RecordSealsRootNodeHash;
            
        }

        /// <summary>
        /// Returns builder of DestinyComponentsRecordsDestinyCharacterRecordsComponent.
        /// </summary>
        /// <returns>DestinyComponentsRecordsDestinyCharacterRecordsComponentBuilder</returns>
        public static DestinyComponentsRecordsDestinyCharacterRecordsComponentBuilder Builder()
        {
            return new DestinyComponentsRecordsDestinyCharacterRecordsComponentBuilder();
        }

        /// <summary>
        /// Returns DestinyComponentsRecordsDestinyCharacterRecordsComponentBuilder with properties set.
        /// Use it to change properties.
        /// </summary>
        /// <returns>DestinyComponentsRecordsDestinyCharacterRecordsComponentBuilder</returns>
        public DestinyComponentsRecordsDestinyCharacterRecordsComponentBuilder With()
        {
            return Builder()
                .FeaturedRecordHashes(FeaturedRecordHashes)
                .Records(Records)
                .RecordCategoriesRootNodeHash(RecordCategoriesRootNodeHash)
                .RecordSealsRootNodeHash(RecordSealsRootNodeHash);
        }

        public override string ToString()
        {
            return this.PropertiesToString();
        }

        public override bool Equals(object obj)
        {
            return this.EqualsByProperties(obj);
        }

        public bool Equals(DestinyComponentsRecordsDestinyCharacterRecordsComponent other)
        {
            return Equals((object) other);
        }

        public override int GetHashCode()
        {
            return this.PropertiesHash();
        }

        /// <summary>
        /// Implementation of == operator for (DestinyComponentsRecordsDestinyCharacterRecordsComponent.
        /// </summary>
        /// <param name="left">Compared (DestinyComponentsRecordsDestinyCharacterRecordsComponent</param>
        /// <param name="right">Compared (DestinyComponentsRecordsDestinyCharacterRecordsComponent</param>
        /// <returns>true if compared items are equals, false otherwise</returns>
        public static bool operator == (DestinyComponentsRecordsDestinyCharacterRecordsComponent left, DestinyComponentsRecordsDestinyCharacterRecordsComponent right)
        {
            return Equals(left, right);
        }

        /// <summary>
        /// Implementation of != operator for (DestinyComponentsRecordsDestinyCharacterRecordsComponent.
        /// </summary>
        /// <param name="left">Compared (DestinyComponentsRecordsDestinyCharacterRecordsComponent</param>
        /// <param name="right">Compared (DestinyComponentsRecordsDestinyCharacterRecordsComponent</param>
        /// <returns>true if compared items are not equals, false otherwise</returns>
        public static bool operator != (DestinyComponentsRecordsDestinyCharacterRecordsComponent left, DestinyComponentsRecordsDestinyCharacterRecordsComponent right)
        {
            return !Equals(left, right);
        }

        /// <summary>
        /// Builder of DestinyComponentsRecordsDestinyCharacterRecordsComponent.
        /// </summary>
        public sealed class DestinyComponentsRecordsDestinyCharacterRecordsComponentBuilder
        {
            private List<int?> _FeaturedRecordHashes;
            private Dictionary<string, DestinyComponentsRecordsDestinyRecordComponent> _Records;
            private int? _RecordCategoriesRootNodeHash;
            private int? _RecordSealsRootNodeHash;

            internal DestinyComponentsRecordsDestinyCharacterRecordsComponentBuilder()
            {
                SetupDefaults();
            }

            private void SetupDefaults()
            {
            }

            /// <summary>
            /// Sets value for DestinyComponentsRecordsDestinyCharacterRecordsComponent.FeaturedRecordHashes property.
            /// </summary>
            /// <param name="value">FeaturedRecordHashes</param>
            public DestinyComponentsRecordsDestinyCharacterRecordsComponentBuilder FeaturedRecordHashes(List<int?> value)
            {
                _FeaturedRecordHashes = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyComponentsRecordsDestinyCharacterRecordsComponent.Records property.
            /// </summary>
            /// <param name="value">Records</param>
            public DestinyComponentsRecordsDestinyCharacterRecordsComponentBuilder Records(Dictionary<string, DestinyComponentsRecordsDestinyRecordComponent> value)
            {
                _Records = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyComponentsRecordsDestinyCharacterRecordsComponent.RecordCategoriesRootNodeHash property.
            /// </summary>
            /// <param name="value">The hash for the root presentation node definition of Triumph categories.</param>
            public DestinyComponentsRecordsDestinyCharacterRecordsComponentBuilder RecordCategoriesRootNodeHash(int? value)
            {
                _RecordCategoriesRootNodeHash = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyComponentsRecordsDestinyCharacterRecordsComponent.RecordSealsRootNodeHash property.
            /// </summary>
            /// <param name="value">The hash for the root presentation node definition of Triumph Seals.</param>
            public DestinyComponentsRecordsDestinyCharacterRecordsComponentBuilder RecordSealsRootNodeHash(int? value)
            {
                _RecordSealsRootNodeHash = value;
                return this;
            }


            /// <summary>
            /// Builds instance of DestinyComponentsRecordsDestinyCharacterRecordsComponent.
            /// </summary>
            /// <returns>DestinyComponentsRecordsDestinyCharacterRecordsComponent</returns>
            public DestinyComponentsRecordsDestinyCharacterRecordsComponent Build()
            {
                Validate();
                return new DestinyComponentsRecordsDestinyCharacterRecordsComponent(
                    FeaturedRecordHashes: _FeaturedRecordHashes,
                    Records: _Records,
                    RecordCategoriesRootNodeHash: _RecordCategoriesRootNodeHash,
                    RecordSealsRootNodeHash: _RecordSealsRootNodeHash
                );
            }

            private void Validate()
            { 
            }
        }

        
    }
}