using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Sharpility.Extensions;
using NodaTime;

namespace BungieNetApi._Platform.Models
{
    /// <summary>
    /// DestinyDefinitionsCollectiblesDestinyCollectibleAcquisitionBlock
    /// </summary>
    public sealed class DestinyDefinitionsCollectiblesDestinyCollectibleAcquisitionBlock:  IEquatable<DestinyDefinitionsCollectiblesDestinyCollectibleAcquisitionBlock>
    { 
        /// <summary>
        /// AcquireMaterialRequirementHash
        /// </summary>
        public int? AcquireMaterialRequirementHash { get; private set; }

        /// <summary>
        /// AcquireTimestampUnlockValueHash
        /// </summary>
        public int? AcquireTimestampUnlockValueHash { get; private set; }


        /// <summary>
        /// Empty constructor required by some serializers.
        /// Use DestinyDefinitionsCollectiblesDestinyCollectibleAcquisitionBlock.Builder() for instance creation instead.
        /// </summary>
        [Obsolete]
        public DestinyDefinitionsCollectiblesDestinyCollectibleAcquisitionBlock()
        {
        }

        private DestinyDefinitionsCollectiblesDestinyCollectibleAcquisitionBlock(int? AcquireMaterialRequirementHash, int? AcquireTimestampUnlockValueHash)
        {
            
            this.AcquireMaterialRequirementHash = AcquireMaterialRequirementHash;
            
            this.AcquireTimestampUnlockValueHash = AcquireTimestampUnlockValueHash;
            
        }

        /// <summary>
        /// Returns builder of DestinyDefinitionsCollectiblesDestinyCollectibleAcquisitionBlock.
        /// </summary>
        /// <returns>DestinyDefinitionsCollectiblesDestinyCollectibleAcquisitionBlockBuilder</returns>
        public static DestinyDefinitionsCollectiblesDestinyCollectibleAcquisitionBlockBuilder Builder()
        {
            return new DestinyDefinitionsCollectiblesDestinyCollectibleAcquisitionBlockBuilder();
        }

        /// <summary>
        /// Returns DestinyDefinitionsCollectiblesDestinyCollectibleAcquisitionBlockBuilder with properties set.
        /// Use it to change properties.
        /// </summary>
        /// <returns>DestinyDefinitionsCollectiblesDestinyCollectibleAcquisitionBlockBuilder</returns>
        public DestinyDefinitionsCollectiblesDestinyCollectibleAcquisitionBlockBuilder With()
        {
            return Builder()
                .AcquireMaterialRequirementHash(AcquireMaterialRequirementHash)
                .AcquireTimestampUnlockValueHash(AcquireTimestampUnlockValueHash);
        }

        public override string ToString()
        {
            return this.PropertiesToString();
        }

        public override bool Equals(object obj)
        {
            return this.EqualsByProperties(obj);
        }

        public bool Equals(DestinyDefinitionsCollectiblesDestinyCollectibleAcquisitionBlock other)
        {
            return Equals((object) other);
        }

        public override int GetHashCode()
        {
            return this.PropertiesHash();
        }

        /// <summary>
        /// Implementation of == operator for (DestinyDefinitionsCollectiblesDestinyCollectibleAcquisitionBlock.
        /// </summary>
        /// <param name="left">Compared (DestinyDefinitionsCollectiblesDestinyCollectibleAcquisitionBlock</param>
        /// <param name="right">Compared (DestinyDefinitionsCollectiblesDestinyCollectibleAcquisitionBlock</param>
        /// <returns>true if compared items are equals, false otherwise</returns>
        public static bool operator == (DestinyDefinitionsCollectiblesDestinyCollectibleAcquisitionBlock left, DestinyDefinitionsCollectiblesDestinyCollectibleAcquisitionBlock right)
        {
            return Equals(left, right);
        }

        /// <summary>
        /// Implementation of != operator for (DestinyDefinitionsCollectiblesDestinyCollectibleAcquisitionBlock.
        /// </summary>
        /// <param name="left">Compared (DestinyDefinitionsCollectiblesDestinyCollectibleAcquisitionBlock</param>
        /// <param name="right">Compared (DestinyDefinitionsCollectiblesDestinyCollectibleAcquisitionBlock</param>
        /// <returns>true if compared items are not equals, false otherwise</returns>
        public static bool operator != (DestinyDefinitionsCollectiblesDestinyCollectibleAcquisitionBlock left, DestinyDefinitionsCollectiblesDestinyCollectibleAcquisitionBlock right)
        {
            return !Equals(left, right);
        }

        /// <summary>
        /// Builder of DestinyDefinitionsCollectiblesDestinyCollectibleAcquisitionBlock.
        /// </summary>
        public sealed class DestinyDefinitionsCollectiblesDestinyCollectibleAcquisitionBlockBuilder
        {
            private int? _AcquireMaterialRequirementHash;
            private int? _AcquireTimestampUnlockValueHash;

            internal DestinyDefinitionsCollectiblesDestinyCollectibleAcquisitionBlockBuilder()
            {
                SetupDefaults();
            }

            private void SetupDefaults()
            {
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsCollectiblesDestinyCollectibleAcquisitionBlock.AcquireMaterialRequirementHash property.
            /// </summary>
            /// <param name="value">AcquireMaterialRequirementHash</param>
            public DestinyDefinitionsCollectiblesDestinyCollectibleAcquisitionBlockBuilder AcquireMaterialRequirementHash(int? value)
            {
                _AcquireMaterialRequirementHash = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsCollectiblesDestinyCollectibleAcquisitionBlock.AcquireTimestampUnlockValueHash property.
            /// </summary>
            /// <param name="value">AcquireTimestampUnlockValueHash</param>
            public DestinyDefinitionsCollectiblesDestinyCollectibleAcquisitionBlockBuilder AcquireTimestampUnlockValueHash(int? value)
            {
                _AcquireTimestampUnlockValueHash = value;
                return this;
            }


            /// <summary>
            /// Builds instance of DestinyDefinitionsCollectiblesDestinyCollectibleAcquisitionBlock.
            /// </summary>
            /// <returns>DestinyDefinitionsCollectiblesDestinyCollectibleAcquisitionBlock</returns>
            public DestinyDefinitionsCollectiblesDestinyCollectibleAcquisitionBlock Build()
            {
                Validate();
                return new DestinyDefinitionsCollectiblesDestinyCollectibleAcquisitionBlock(
                    AcquireMaterialRequirementHash: _AcquireMaterialRequirementHash,
                    AcquireTimestampUnlockValueHash: _AcquireTimestampUnlockValueHash
                );
            }

            private void Validate()
            { 
            }
        }

        
    }
}