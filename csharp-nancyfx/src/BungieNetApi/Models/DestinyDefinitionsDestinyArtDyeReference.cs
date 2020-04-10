using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Sharpility.Extensions;
using NodaTime;

namespace BungieNetApi._Platform.Models
{
    /// <summary>
    /// DestinyDefinitionsDestinyArtDyeReference
    /// </summary>
    public sealed class DestinyDefinitionsDestinyArtDyeReference:  IEquatable<DestinyDefinitionsDestinyArtDyeReference>
    { 
        /// <summary>
        /// ArtDyeChannelHash
        /// </summary>
        public int? ArtDyeChannelHash { get; private set; }


        /// <summary>
        /// Empty constructor required by some serializers.
        /// Use DestinyDefinitionsDestinyArtDyeReference.Builder() for instance creation instead.
        /// </summary>
        [Obsolete]
        public DestinyDefinitionsDestinyArtDyeReference()
        {
        }

        private DestinyDefinitionsDestinyArtDyeReference(int? ArtDyeChannelHash)
        {
            
            this.ArtDyeChannelHash = ArtDyeChannelHash;
            
        }

        /// <summary>
        /// Returns builder of DestinyDefinitionsDestinyArtDyeReference.
        /// </summary>
        /// <returns>DestinyDefinitionsDestinyArtDyeReferenceBuilder</returns>
        public static DestinyDefinitionsDestinyArtDyeReferenceBuilder Builder()
        {
            return new DestinyDefinitionsDestinyArtDyeReferenceBuilder();
        }

        /// <summary>
        /// Returns DestinyDefinitionsDestinyArtDyeReferenceBuilder with properties set.
        /// Use it to change properties.
        /// </summary>
        /// <returns>DestinyDefinitionsDestinyArtDyeReferenceBuilder</returns>
        public DestinyDefinitionsDestinyArtDyeReferenceBuilder With()
        {
            return Builder()
                .ArtDyeChannelHash(ArtDyeChannelHash);
        }

        public override string ToString()
        {
            return this.PropertiesToString();
        }

        public override bool Equals(object obj)
        {
            return this.EqualsByProperties(obj);
        }

        public bool Equals(DestinyDefinitionsDestinyArtDyeReference other)
        {
            return Equals((object) other);
        }

        public override int GetHashCode()
        {
            return this.PropertiesHash();
        }

        /// <summary>
        /// Implementation of == operator for (DestinyDefinitionsDestinyArtDyeReference.
        /// </summary>
        /// <param name="left">Compared (DestinyDefinitionsDestinyArtDyeReference</param>
        /// <param name="right">Compared (DestinyDefinitionsDestinyArtDyeReference</param>
        /// <returns>true if compared items are equals, false otherwise</returns>
        public static bool operator == (DestinyDefinitionsDestinyArtDyeReference left, DestinyDefinitionsDestinyArtDyeReference right)
        {
            return Equals(left, right);
        }

        /// <summary>
        /// Implementation of != operator for (DestinyDefinitionsDestinyArtDyeReference.
        /// </summary>
        /// <param name="left">Compared (DestinyDefinitionsDestinyArtDyeReference</param>
        /// <param name="right">Compared (DestinyDefinitionsDestinyArtDyeReference</param>
        /// <returns>true if compared items are not equals, false otherwise</returns>
        public static bool operator != (DestinyDefinitionsDestinyArtDyeReference left, DestinyDefinitionsDestinyArtDyeReference right)
        {
            return !Equals(left, right);
        }

        /// <summary>
        /// Builder of DestinyDefinitionsDestinyArtDyeReference.
        /// </summary>
        public sealed class DestinyDefinitionsDestinyArtDyeReferenceBuilder
        {
            private int? _ArtDyeChannelHash;

            internal DestinyDefinitionsDestinyArtDyeReferenceBuilder()
            {
                SetupDefaults();
            }

            private void SetupDefaults()
            {
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsDestinyArtDyeReference.ArtDyeChannelHash property.
            /// </summary>
            /// <param name="value">ArtDyeChannelHash</param>
            public DestinyDefinitionsDestinyArtDyeReferenceBuilder ArtDyeChannelHash(int? value)
            {
                _ArtDyeChannelHash = value;
                return this;
            }


            /// <summary>
            /// Builds instance of DestinyDefinitionsDestinyArtDyeReference.
            /// </summary>
            /// <returns>DestinyDefinitionsDestinyArtDyeReference</returns>
            public DestinyDefinitionsDestinyArtDyeReference Build()
            {
                Validate();
                return new DestinyDefinitionsDestinyArtDyeReference(
                    ArtDyeChannelHash: _ArtDyeChannelHash
                );
            }

            private void Validate()
            { 
            }
        }

        
    }
}