using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Sharpility.Extensions;
using NodaTime;

namespace BungieNetApi._Platform.Models
{
    /// <summary>
    /// DestinyDefinitionsDestinyGearArtArrangementReference
    /// </summary>
    public sealed class DestinyDefinitionsDestinyGearArtArrangementReference:  IEquatable<DestinyDefinitionsDestinyGearArtArrangementReference>
    { 
        /// <summary>
        /// ClassHash
        /// </summary>
        public int? ClassHash { get; private set; }

        /// <summary>
        /// ArtArrangementHash
        /// </summary>
        public int? ArtArrangementHash { get; private set; }


        /// <summary>
        /// Empty constructor required by some serializers.
        /// Use DestinyDefinitionsDestinyGearArtArrangementReference.Builder() for instance creation instead.
        /// </summary>
        [Obsolete]
        public DestinyDefinitionsDestinyGearArtArrangementReference()
        {
        }

        private DestinyDefinitionsDestinyGearArtArrangementReference(int? ClassHash, int? ArtArrangementHash)
        {
            
            this.ClassHash = ClassHash;
            
            this.ArtArrangementHash = ArtArrangementHash;
            
        }

        /// <summary>
        /// Returns builder of DestinyDefinitionsDestinyGearArtArrangementReference.
        /// </summary>
        /// <returns>DestinyDefinitionsDestinyGearArtArrangementReferenceBuilder</returns>
        public static DestinyDefinitionsDestinyGearArtArrangementReferenceBuilder Builder()
        {
            return new DestinyDefinitionsDestinyGearArtArrangementReferenceBuilder();
        }

        /// <summary>
        /// Returns DestinyDefinitionsDestinyGearArtArrangementReferenceBuilder with properties set.
        /// Use it to change properties.
        /// </summary>
        /// <returns>DestinyDefinitionsDestinyGearArtArrangementReferenceBuilder</returns>
        public DestinyDefinitionsDestinyGearArtArrangementReferenceBuilder With()
        {
            return Builder()
                .ClassHash(ClassHash)
                .ArtArrangementHash(ArtArrangementHash);
        }

        public override string ToString()
        {
            return this.PropertiesToString();
        }

        public override bool Equals(object obj)
        {
            return this.EqualsByProperties(obj);
        }

        public bool Equals(DestinyDefinitionsDestinyGearArtArrangementReference other)
        {
            return Equals((object) other);
        }

        public override int GetHashCode()
        {
            return this.PropertiesHash();
        }

        /// <summary>
        /// Implementation of == operator for (DestinyDefinitionsDestinyGearArtArrangementReference.
        /// </summary>
        /// <param name="left">Compared (DestinyDefinitionsDestinyGearArtArrangementReference</param>
        /// <param name="right">Compared (DestinyDefinitionsDestinyGearArtArrangementReference</param>
        /// <returns>true if compared items are equals, false otherwise</returns>
        public static bool operator == (DestinyDefinitionsDestinyGearArtArrangementReference left, DestinyDefinitionsDestinyGearArtArrangementReference right)
        {
            return Equals(left, right);
        }

        /// <summary>
        /// Implementation of != operator for (DestinyDefinitionsDestinyGearArtArrangementReference.
        /// </summary>
        /// <param name="left">Compared (DestinyDefinitionsDestinyGearArtArrangementReference</param>
        /// <param name="right">Compared (DestinyDefinitionsDestinyGearArtArrangementReference</param>
        /// <returns>true if compared items are not equals, false otherwise</returns>
        public static bool operator != (DestinyDefinitionsDestinyGearArtArrangementReference left, DestinyDefinitionsDestinyGearArtArrangementReference right)
        {
            return !Equals(left, right);
        }

        /// <summary>
        /// Builder of DestinyDefinitionsDestinyGearArtArrangementReference.
        /// </summary>
        public sealed class DestinyDefinitionsDestinyGearArtArrangementReferenceBuilder
        {
            private int? _ClassHash;
            private int? _ArtArrangementHash;

            internal DestinyDefinitionsDestinyGearArtArrangementReferenceBuilder()
            {
                SetupDefaults();
            }

            private void SetupDefaults()
            {
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsDestinyGearArtArrangementReference.ClassHash property.
            /// </summary>
            /// <param name="value">ClassHash</param>
            public DestinyDefinitionsDestinyGearArtArrangementReferenceBuilder ClassHash(int? value)
            {
                _ClassHash = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsDestinyGearArtArrangementReference.ArtArrangementHash property.
            /// </summary>
            /// <param name="value">ArtArrangementHash</param>
            public DestinyDefinitionsDestinyGearArtArrangementReferenceBuilder ArtArrangementHash(int? value)
            {
                _ArtArrangementHash = value;
                return this;
            }


            /// <summary>
            /// Builds instance of DestinyDefinitionsDestinyGearArtArrangementReference.
            /// </summary>
            /// <returns>DestinyDefinitionsDestinyGearArtArrangementReference</returns>
            public DestinyDefinitionsDestinyGearArtArrangementReference Build()
            {
                Validate();
                return new DestinyDefinitionsDestinyGearArtArrangementReference(
                    ClassHash: _ClassHash,
                    ArtArrangementHash: _ArtArrangementHash
                );
            }

            private void Validate()
            { 
            }
        }

        
    }
}