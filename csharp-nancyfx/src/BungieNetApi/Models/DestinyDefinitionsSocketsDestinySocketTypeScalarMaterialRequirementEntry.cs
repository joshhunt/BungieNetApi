using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Sharpility.Extensions;
using NodaTime;

namespace BungieNetApi._Platform.Models
{
    /// <summary>
    /// DestinyDefinitionsSocketsDestinySocketTypeScalarMaterialRequirementEntry
    /// </summary>
    public sealed class DestinyDefinitionsSocketsDestinySocketTypeScalarMaterialRequirementEntry:  IEquatable<DestinyDefinitionsSocketsDestinySocketTypeScalarMaterialRequirementEntry>
    { 
        /// <summary>
        /// CurrencyItemHash
        /// </summary>
        public int? CurrencyItemHash { get; private set; }

        /// <summary>
        /// ScalarValue
        /// </summary>
        public int? ScalarValue { get; private set; }


        /// <summary>
        /// Empty constructor required by some serializers.
        /// Use DestinyDefinitionsSocketsDestinySocketTypeScalarMaterialRequirementEntry.Builder() for instance creation instead.
        /// </summary>
        [Obsolete]
        public DestinyDefinitionsSocketsDestinySocketTypeScalarMaterialRequirementEntry()
        {
        }

        private DestinyDefinitionsSocketsDestinySocketTypeScalarMaterialRequirementEntry(int? CurrencyItemHash, int? ScalarValue)
        {
            
            this.CurrencyItemHash = CurrencyItemHash;
            
            this.ScalarValue = ScalarValue;
            
        }

        /// <summary>
        /// Returns builder of DestinyDefinitionsSocketsDestinySocketTypeScalarMaterialRequirementEntry.
        /// </summary>
        /// <returns>DestinyDefinitionsSocketsDestinySocketTypeScalarMaterialRequirementEntryBuilder</returns>
        public static DestinyDefinitionsSocketsDestinySocketTypeScalarMaterialRequirementEntryBuilder Builder()
        {
            return new DestinyDefinitionsSocketsDestinySocketTypeScalarMaterialRequirementEntryBuilder();
        }

        /// <summary>
        /// Returns DestinyDefinitionsSocketsDestinySocketTypeScalarMaterialRequirementEntryBuilder with properties set.
        /// Use it to change properties.
        /// </summary>
        /// <returns>DestinyDefinitionsSocketsDestinySocketTypeScalarMaterialRequirementEntryBuilder</returns>
        public DestinyDefinitionsSocketsDestinySocketTypeScalarMaterialRequirementEntryBuilder With()
        {
            return Builder()
                .CurrencyItemHash(CurrencyItemHash)
                .ScalarValue(ScalarValue);
        }

        public override string ToString()
        {
            return this.PropertiesToString();
        }

        public override bool Equals(object obj)
        {
            return this.EqualsByProperties(obj);
        }

        public bool Equals(DestinyDefinitionsSocketsDestinySocketTypeScalarMaterialRequirementEntry other)
        {
            return Equals((object) other);
        }

        public override int GetHashCode()
        {
            return this.PropertiesHash();
        }

        /// <summary>
        /// Implementation of == operator for (DestinyDefinitionsSocketsDestinySocketTypeScalarMaterialRequirementEntry.
        /// </summary>
        /// <param name="left">Compared (DestinyDefinitionsSocketsDestinySocketTypeScalarMaterialRequirementEntry</param>
        /// <param name="right">Compared (DestinyDefinitionsSocketsDestinySocketTypeScalarMaterialRequirementEntry</param>
        /// <returns>true if compared items are equals, false otherwise</returns>
        public static bool operator == (DestinyDefinitionsSocketsDestinySocketTypeScalarMaterialRequirementEntry left, DestinyDefinitionsSocketsDestinySocketTypeScalarMaterialRequirementEntry right)
        {
            return Equals(left, right);
        }

        /// <summary>
        /// Implementation of != operator for (DestinyDefinitionsSocketsDestinySocketTypeScalarMaterialRequirementEntry.
        /// </summary>
        /// <param name="left">Compared (DestinyDefinitionsSocketsDestinySocketTypeScalarMaterialRequirementEntry</param>
        /// <param name="right">Compared (DestinyDefinitionsSocketsDestinySocketTypeScalarMaterialRequirementEntry</param>
        /// <returns>true if compared items are not equals, false otherwise</returns>
        public static bool operator != (DestinyDefinitionsSocketsDestinySocketTypeScalarMaterialRequirementEntry left, DestinyDefinitionsSocketsDestinySocketTypeScalarMaterialRequirementEntry right)
        {
            return !Equals(left, right);
        }

        /// <summary>
        /// Builder of DestinyDefinitionsSocketsDestinySocketTypeScalarMaterialRequirementEntry.
        /// </summary>
        public sealed class DestinyDefinitionsSocketsDestinySocketTypeScalarMaterialRequirementEntryBuilder
        {
            private int? _CurrencyItemHash;
            private int? _ScalarValue;

            internal DestinyDefinitionsSocketsDestinySocketTypeScalarMaterialRequirementEntryBuilder()
            {
                SetupDefaults();
            }

            private void SetupDefaults()
            {
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsSocketsDestinySocketTypeScalarMaterialRequirementEntry.CurrencyItemHash property.
            /// </summary>
            /// <param name="value">CurrencyItemHash</param>
            public DestinyDefinitionsSocketsDestinySocketTypeScalarMaterialRequirementEntryBuilder CurrencyItemHash(int? value)
            {
                _CurrencyItemHash = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsSocketsDestinySocketTypeScalarMaterialRequirementEntry.ScalarValue property.
            /// </summary>
            /// <param name="value">ScalarValue</param>
            public DestinyDefinitionsSocketsDestinySocketTypeScalarMaterialRequirementEntryBuilder ScalarValue(int? value)
            {
                _ScalarValue = value;
                return this;
            }


            /// <summary>
            /// Builds instance of DestinyDefinitionsSocketsDestinySocketTypeScalarMaterialRequirementEntry.
            /// </summary>
            /// <returns>DestinyDefinitionsSocketsDestinySocketTypeScalarMaterialRequirementEntry</returns>
            public DestinyDefinitionsSocketsDestinySocketTypeScalarMaterialRequirementEntry Build()
            {
                Validate();
                return new DestinyDefinitionsSocketsDestinySocketTypeScalarMaterialRequirementEntry(
                    CurrencyItemHash: _CurrencyItemHash,
                    ScalarValue: _ScalarValue
                );
            }

            private void Validate()
            { 
            }
        }

        
    }
}