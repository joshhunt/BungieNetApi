using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Sharpility.Extensions;
using NodaTime;

namespace BungieNetApi._Platform.Models
{
    /// <summary>
    /// DestinyComponentsRecordsDestinyProfileRecordsComponent
    /// </summary>
    public sealed class DestinyComponentsRecordsDestinyProfileRecordsComponent:  IEquatable<DestinyComponentsRecordsDestinyProfileRecordsComponent>
    { 
        /// <summary>
        /// Your \&quot;Triumphs\&quot; score.
        /// </summary>
        public int? Score { get; private set; }

        /// <summary>
        /// If this profile is tracking a record, this is the hash identifier of the record it is tracking.
        /// </summary>
        public int? TrackedRecordHash { get; private set; }

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
        /// Use DestinyComponentsRecordsDestinyProfileRecordsComponent.Builder() for instance creation instead.
        /// </summary>
        [Obsolete]
        public DestinyComponentsRecordsDestinyProfileRecordsComponent()
        {
        }

        private DestinyComponentsRecordsDestinyProfileRecordsComponent(int? Score, int? TrackedRecordHash, Dictionary<string, DestinyComponentsRecordsDestinyRecordComponent> Records, int? RecordCategoriesRootNodeHash, int? RecordSealsRootNodeHash)
        {
            
            this.Score = Score;
            
            this.TrackedRecordHash = TrackedRecordHash;
            
            this.Records = Records;
            
            this.RecordCategoriesRootNodeHash = RecordCategoriesRootNodeHash;
            
            this.RecordSealsRootNodeHash = RecordSealsRootNodeHash;
            
        }

        /// <summary>
        /// Returns builder of DestinyComponentsRecordsDestinyProfileRecordsComponent.
        /// </summary>
        /// <returns>DestinyComponentsRecordsDestinyProfileRecordsComponentBuilder</returns>
        public static DestinyComponentsRecordsDestinyProfileRecordsComponentBuilder Builder()
        {
            return new DestinyComponentsRecordsDestinyProfileRecordsComponentBuilder();
        }

        /// <summary>
        /// Returns DestinyComponentsRecordsDestinyProfileRecordsComponentBuilder with properties set.
        /// Use it to change properties.
        /// </summary>
        /// <returns>DestinyComponentsRecordsDestinyProfileRecordsComponentBuilder</returns>
        public DestinyComponentsRecordsDestinyProfileRecordsComponentBuilder With()
        {
            return Builder()
                .Score(Score)
                .TrackedRecordHash(TrackedRecordHash)
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

        public bool Equals(DestinyComponentsRecordsDestinyProfileRecordsComponent other)
        {
            return Equals((object) other);
        }

        public override int GetHashCode()
        {
            return this.PropertiesHash();
        }

        /// <summary>
        /// Implementation of == operator for (DestinyComponentsRecordsDestinyProfileRecordsComponent.
        /// </summary>
        /// <param name="left">Compared (DestinyComponentsRecordsDestinyProfileRecordsComponent</param>
        /// <param name="right">Compared (DestinyComponentsRecordsDestinyProfileRecordsComponent</param>
        /// <returns>true if compared items are equals, false otherwise</returns>
        public static bool operator == (DestinyComponentsRecordsDestinyProfileRecordsComponent left, DestinyComponentsRecordsDestinyProfileRecordsComponent right)
        {
            return Equals(left, right);
        }

        /// <summary>
        /// Implementation of != operator for (DestinyComponentsRecordsDestinyProfileRecordsComponent.
        /// </summary>
        /// <param name="left">Compared (DestinyComponentsRecordsDestinyProfileRecordsComponent</param>
        /// <param name="right">Compared (DestinyComponentsRecordsDestinyProfileRecordsComponent</param>
        /// <returns>true if compared items are not equals, false otherwise</returns>
        public static bool operator != (DestinyComponentsRecordsDestinyProfileRecordsComponent left, DestinyComponentsRecordsDestinyProfileRecordsComponent right)
        {
            return !Equals(left, right);
        }

        /// <summary>
        /// Builder of DestinyComponentsRecordsDestinyProfileRecordsComponent.
        /// </summary>
        public sealed class DestinyComponentsRecordsDestinyProfileRecordsComponentBuilder
        {
            private int? _Score;
            private int? _TrackedRecordHash;
            private Dictionary<string, DestinyComponentsRecordsDestinyRecordComponent> _Records;
            private int? _RecordCategoriesRootNodeHash;
            private int? _RecordSealsRootNodeHash;

            internal DestinyComponentsRecordsDestinyProfileRecordsComponentBuilder()
            {
                SetupDefaults();
            }

            private void SetupDefaults()
            {
            }

            /// <summary>
            /// Sets value for DestinyComponentsRecordsDestinyProfileRecordsComponent.Score property.
            /// </summary>
            /// <param name="value">Your \&quot;Triumphs\&quot; score.</param>
            public DestinyComponentsRecordsDestinyProfileRecordsComponentBuilder Score(int? value)
            {
                _Score = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyComponentsRecordsDestinyProfileRecordsComponent.TrackedRecordHash property.
            /// </summary>
            /// <param name="value">If this profile is tracking a record, this is the hash identifier of the record it is tracking.</param>
            public DestinyComponentsRecordsDestinyProfileRecordsComponentBuilder TrackedRecordHash(int? value)
            {
                _TrackedRecordHash = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyComponentsRecordsDestinyProfileRecordsComponent.Records property.
            /// </summary>
            /// <param name="value">Records</param>
            public DestinyComponentsRecordsDestinyProfileRecordsComponentBuilder Records(Dictionary<string, DestinyComponentsRecordsDestinyRecordComponent> value)
            {
                _Records = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyComponentsRecordsDestinyProfileRecordsComponent.RecordCategoriesRootNodeHash property.
            /// </summary>
            /// <param name="value">The hash for the root presentation node definition of Triumph categories.</param>
            public DestinyComponentsRecordsDestinyProfileRecordsComponentBuilder RecordCategoriesRootNodeHash(int? value)
            {
                _RecordCategoriesRootNodeHash = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyComponentsRecordsDestinyProfileRecordsComponent.RecordSealsRootNodeHash property.
            /// </summary>
            /// <param name="value">The hash for the root presentation node definition of Triumph Seals.</param>
            public DestinyComponentsRecordsDestinyProfileRecordsComponentBuilder RecordSealsRootNodeHash(int? value)
            {
                _RecordSealsRootNodeHash = value;
                return this;
            }


            /// <summary>
            /// Builds instance of DestinyComponentsRecordsDestinyProfileRecordsComponent.
            /// </summary>
            /// <returns>DestinyComponentsRecordsDestinyProfileRecordsComponent</returns>
            public DestinyComponentsRecordsDestinyProfileRecordsComponent Build()
            {
                Validate();
                return new DestinyComponentsRecordsDestinyProfileRecordsComponent(
                    Score: _Score,
                    TrackedRecordHash: _TrackedRecordHash,
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