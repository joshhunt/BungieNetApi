using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Sharpility.Extensions;
using NodaTime;

namespace BungieNetApi._Platform.Models
{
    /// <summary>
    /// DestinyComponentsRecordsDestinyRecordsComponent
    /// </summary>
    public sealed class DestinyComponentsRecordsDestinyRecordsComponent:  IEquatable<DestinyComponentsRecordsDestinyRecordsComponent>
    { 
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
        /// Use DestinyComponentsRecordsDestinyRecordsComponent.Builder() for instance creation instead.
        /// </summary>
        [Obsolete]
        public DestinyComponentsRecordsDestinyRecordsComponent()
        {
        }

        private DestinyComponentsRecordsDestinyRecordsComponent(Dictionary<string, DestinyComponentsRecordsDestinyRecordComponent> Records, int? RecordCategoriesRootNodeHash, int? RecordSealsRootNodeHash)
        {
            
            this.Records = Records;
            
            this.RecordCategoriesRootNodeHash = RecordCategoriesRootNodeHash;
            
            this.RecordSealsRootNodeHash = RecordSealsRootNodeHash;
            
        }

        /// <summary>
        /// Returns builder of DestinyComponentsRecordsDestinyRecordsComponent.
        /// </summary>
        /// <returns>DestinyComponentsRecordsDestinyRecordsComponentBuilder</returns>
        public static DestinyComponentsRecordsDestinyRecordsComponentBuilder Builder()
        {
            return new DestinyComponentsRecordsDestinyRecordsComponentBuilder();
        }

        /// <summary>
        /// Returns DestinyComponentsRecordsDestinyRecordsComponentBuilder with properties set.
        /// Use it to change properties.
        /// </summary>
        /// <returns>DestinyComponentsRecordsDestinyRecordsComponentBuilder</returns>
        public DestinyComponentsRecordsDestinyRecordsComponentBuilder With()
        {
            return Builder()
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

        public bool Equals(DestinyComponentsRecordsDestinyRecordsComponent other)
        {
            return Equals((object) other);
        }

        public override int GetHashCode()
        {
            return this.PropertiesHash();
        }

        /// <summary>
        /// Implementation of == operator for (DestinyComponentsRecordsDestinyRecordsComponent.
        /// </summary>
        /// <param name="left">Compared (DestinyComponentsRecordsDestinyRecordsComponent</param>
        /// <param name="right">Compared (DestinyComponentsRecordsDestinyRecordsComponent</param>
        /// <returns>true if compared items are equals, false otherwise</returns>
        public static bool operator == (DestinyComponentsRecordsDestinyRecordsComponent left, DestinyComponentsRecordsDestinyRecordsComponent right)
        {
            return Equals(left, right);
        }

        /// <summary>
        /// Implementation of != operator for (DestinyComponentsRecordsDestinyRecordsComponent.
        /// </summary>
        /// <param name="left">Compared (DestinyComponentsRecordsDestinyRecordsComponent</param>
        /// <param name="right">Compared (DestinyComponentsRecordsDestinyRecordsComponent</param>
        /// <returns>true if compared items are not equals, false otherwise</returns>
        public static bool operator != (DestinyComponentsRecordsDestinyRecordsComponent left, DestinyComponentsRecordsDestinyRecordsComponent right)
        {
            return !Equals(left, right);
        }

        /// <summary>
        /// Builder of DestinyComponentsRecordsDestinyRecordsComponent.
        /// </summary>
        public sealed class DestinyComponentsRecordsDestinyRecordsComponentBuilder
        {
            private Dictionary<string, DestinyComponentsRecordsDestinyRecordComponent> _Records;
            private int? _RecordCategoriesRootNodeHash;
            private int? _RecordSealsRootNodeHash;

            internal DestinyComponentsRecordsDestinyRecordsComponentBuilder()
            {
                SetupDefaults();
            }

            private void SetupDefaults()
            {
            }

            /// <summary>
            /// Sets value for DestinyComponentsRecordsDestinyRecordsComponent.Records property.
            /// </summary>
            /// <param name="value">Records</param>
            public DestinyComponentsRecordsDestinyRecordsComponentBuilder Records(Dictionary<string, DestinyComponentsRecordsDestinyRecordComponent> value)
            {
                _Records = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyComponentsRecordsDestinyRecordsComponent.RecordCategoriesRootNodeHash property.
            /// </summary>
            /// <param name="value">The hash for the root presentation node definition of Triumph categories.</param>
            public DestinyComponentsRecordsDestinyRecordsComponentBuilder RecordCategoriesRootNodeHash(int? value)
            {
                _RecordCategoriesRootNodeHash = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyComponentsRecordsDestinyRecordsComponent.RecordSealsRootNodeHash property.
            /// </summary>
            /// <param name="value">The hash for the root presentation node definition of Triumph Seals.</param>
            public DestinyComponentsRecordsDestinyRecordsComponentBuilder RecordSealsRootNodeHash(int? value)
            {
                _RecordSealsRootNodeHash = value;
                return this;
            }


            /// <summary>
            /// Builds instance of DestinyComponentsRecordsDestinyRecordsComponent.
            /// </summary>
            /// <returns>DestinyComponentsRecordsDestinyRecordsComponent</returns>
            public DestinyComponentsRecordsDestinyRecordsComponent Build()
            {
                Validate();
                return new DestinyComponentsRecordsDestinyRecordsComponent(
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