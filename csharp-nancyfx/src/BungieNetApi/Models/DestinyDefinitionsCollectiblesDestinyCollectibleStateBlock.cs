using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Sharpility.Extensions;
using NodaTime;

namespace BungieNetApi._Platform.Models
{
    /// <summary>
    /// DestinyDefinitionsCollectiblesDestinyCollectibleStateBlock
    /// </summary>
    public sealed class DestinyDefinitionsCollectiblesDestinyCollectibleStateBlock:  IEquatable<DestinyDefinitionsCollectiblesDestinyCollectibleStateBlock>
    { 
        /// <summary>
        /// ObscuredOverrideItemHash
        /// </summary>
        public int? ObscuredOverrideItemHash { get; private set; }

        /// <summary>
        /// Requirements
        /// </summary>
        public DestinyDefinitionsPresentationDestinyPresentationNodeRequirementsBlock Requirements { get; private set; }


        /// <summary>
        /// Empty constructor required by some serializers.
        /// Use DestinyDefinitionsCollectiblesDestinyCollectibleStateBlock.Builder() for instance creation instead.
        /// </summary>
        [Obsolete]
        public DestinyDefinitionsCollectiblesDestinyCollectibleStateBlock()
        {
        }

        private DestinyDefinitionsCollectiblesDestinyCollectibleStateBlock(int? ObscuredOverrideItemHash, DestinyDefinitionsPresentationDestinyPresentationNodeRequirementsBlock Requirements)
        {
            
            this.ObscuredOverrideItemHash = ObscuredOverrideItemHash;
            
            this.Requirements = Requirements;
            
        }

        /// <summary>
        /// Returns builder of DestinyDefinitionsCollectiblesDestinyCollectibleStateBlock.
        /// </summary>
        /// <returns>DestinyDefinitionsCollectiblesDestinyCollectibleStateBlockBuilder</returns>
        public static DestinyDefinitionsCollectiblesDestinyCollectibleStateBlockBuilder Builder()
        {
            return new DestinyDefinitionsCollectiblesDestinyCollectibleStateBlockBuilder();
        }

        /// <summary>
        /// Returns DestinyDefinitionsCollectiblesDestinyCollectibleStateBlockBuilder with properties set.
        /// Use it to change properties.
        /// </summary>
        /// <returns>DestinyDefinitionsCollectiblesDestinyCollectibleStateBlockBuilder</returns>
        public DestinyDefinitionsCollectiblesDestinyCollectibleStateBlockBuilder With()
        {
            return Builder()
                .ObscuredOverrideItemHash(ObscuredOverrideItemHash)
                .Requirements(Requirements);
        }

        public override string ToString()
        {
            return this.PropertiesToString();
        }

        public override bool Equals(object obj)
        {
            return this.EqualsByProperties(obj);
        }

        public bool Equals(DestinyDefinitionsCollectiblesDestinyCollectibleStateBlock other)
        {
            return Equals((object) other);
        }

        public override int GetHashCode()
        {
            return this.PropertiesHash();
        }

        /// <summary>
        /// Implementation of == operator for (DestinyDefinitionsCollectiblesDestinyCollectibleStateBlock.
        /// </summary>
        /// <param name="left">Compared (DestinyDefinitionsCollectiblesDestinyCollectibleStateBlock</param>
        /// <param name="right">Compared (DestinyDefinitionsCollectiblesDestinyCollectibleStateBlock</param>
        /// <returns>true if compared items are equals, false otherwise</returns>
        public static bool operator == (DestinyDefinitionsCollectiblesDestinyCollectibleStateBlock left, DestinyDefinitionsCollectiblesDestinyCollectibleStateBlock right)
        {
            return Equals(left, right);
        }

        /// <summary>
        /// Implementation of != operator for (DestinyDefinitionsCollectiblesDestinyCollectibleStateBlock.
        /// </summary>
        /// <param name="left">Compared (DestinyDefinitionsCollectiblesDestinyCollectibleStateBlock</param>
        /// <param name="right">Compared (DestinyDefinitionsCollectiblesDestinyCollectibleStateBlock</param>
        /// <returns>true if compared items are not equals, false otherwise</returns>
        public static bool operator != (DestinyDefinitionsCollectiblesDestinyCollectibleStateBlock left, DestinyDefinitionsCollectiblesDestinyCollectibleStateBlock right)
        {
            return !Equals(left, right);
        }

        /// <summary>
        /// Builder of DestinyDefinitionsCollectiblesDestinyCollectibleStateBlock.
        /// </summary>
        public sealed class DestinyDefinitionsCollectiblesDestinyCollectibleStateBlockBuilder
        {
            private int? _ObscuredOverrideItemHash;
            private DestinyDefinitionsPresentationDestinyPresentationNodeRequirementsBlock _Requirements;

            internal DestinyDefinitionsCollectiblesDestinyCollectibleStateBlockBuilder()
            {
                SetupDefaults();
            }

            private void SetupDefaults()
            {
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsCollectiblesDestinyCollectibleStateBlock.ObscuredOverrideItemHash property.
            /// </summary>
            /// <param name="value">ObscuredOverrideItemHash</param>
            public DestinyDefinitionsCollectiblesDestinyCollectibleStateBlockBuilder ObscuredOverrideItemHash(int? value)
            {
                _ObscuredOverrideItemHash = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsCollectiblesDestinyCollectibleStateBlock.Requirements property.
            /// </summary>
            /// <param name="value">Requirements</param>
            public DestinyDefinitionsCollectiblesDestinyCollectibleStateBlockBuilder Requirements(DestinyDefinitionsPresentationDestinyPresentationNodeRequirementsBlock value)
            {
                _Requirements = value;
                return this;
            }


            /// <summary>
            /// Builds instance of DestinyDefinitionsCollectiblesDestinyCollectibleStateBlock.
            /// </summary>
            /// <returns>DestinyDefinitionsCollectiblesDestinyCollectibleStateBlock</returns>
            public DestinyDefinitionsCollectiblesDestinyCollectibleStateBlock Build()
            {
                Validate();
                return new DestinyDefinitionsCollectiblesDestinyCollectibleStateBlock(
                    ObscuredOverrideItemHash: _ObscuredOverrideItemHash,
                    Requirements: _Requirements
                );
            }

            private void Validate()
            { 
            }
        }

        
    }
}