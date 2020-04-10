using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Sharpility.Extensions;
using NodaTime;

namespace BungieNetApi._Platform.Models
{
    /// <summary>
    /// DestinyDefinitionsAnimationsDestinyAnimationReference
    /// </summary>
    public sealed class DestinyDefinitionsAnimationsDestinyAnimationReference:  IEquatable<DestinyDefinitionsAnimationsDestinyAnimationReference>
    { 
        /// <summary>
        /// AnimName
        /// </summary>
        public string AnimName { get; private set; }

        /// <summary>
        /// AnimIdentifier
        /// </summary>
        public string AnimIdentifier { get; private set; }

        /// <summary>
        /// Path
        /// </summary>
        public string Path { get; private set; }


        /// <summary>
        /// Empty constructor required by some serializers.
        /// Use DestinyDefinitionsAnimationsDestinyAnimationReference.Builder() for instance creation instead.
        /// </summary>
        [Obsolete]
        public DestinyDefinitionsAnimationsDestinyAnimationReference()
        {
        }

        private DestinyDefinitionsAnimationsDestinyAnimationReference(string AnimName, string AnimIdentifier, string Path)
        {
            
            this.AnimName = AnimName;
            
            this.AnimIdentifier = AnimIdentifier;
            
            this.Path = Path;
            
        }

        /// <summary>
        /// Returns builder of DestinyDefinitionsAnimationsDestinyAnimationReference.
        /// </summary>
        /// <returns>DestinyDefinitionsAnimationsDestinyAnimationReferenceBuilder</returns>
        public static DestinyDefinitionsAnimationsDestinyAnimationReferenceBuilder Builder()
        {
            return new DestinyDefinitionsAnimationsDestinyAnimationReferenceBuilder();
        }

        /// <summary>
        /// Returns DestinyDefinitionsAnimationsDestinyAnimationReferenceBuilder with properties set.
        /// Use it to change properties.
        /// </summary>
        /// <returns>DestinyDefinitionsAnimationsDestinyAnimationReferenceBuilder</returns>
        public DestinyDefinitionsAnimationsDestinyAnimationReferenceBuilder With()
        {
            return Builder()
                .AnimName(AnimName)
                .AnimIdentifier(AnimIdentifier)
                .Path(Path);
        }

        public override string ToString()
        {
            return this.PropertiesToString();
        }

        public override bool Equals(object obj)
        {
            return this.EqualsByProperties(obj);
        }

        public bool Equals(DestinyDefinitionsAnimationsDestinyAnimationReference other)
        {
            return Equals((object) other);
        }

        public override int GetHashCode()
        {
            return this.PropertiesHash();
        }

        /// <summary>
        /// Implementation of == operator for (DestinyDefinitionsAnimationsDestinyAnimationReference.
        /// </summary>
        /// <param name="left">Compared (DestinyDefinitionsAnimationsDestinyAnimationReference</param>
        /// <param name="right">Compared (DestinyDefinitionsAnimationsDestinyAnimationReference</param>
        /// <returns>true if compared items are equals, false otherwise</returns>
        public static bool operator == (DestinyDefinitionsAnimationsDestinyAnimationReference left, DestinyDefinitionsAnimationsDestinyAnimationReference right)
        {
            return Equals(left, right);
        }

        /// <summary>
        /// Implementation of != operator for (DestinyDefinitionsAnimationsDestinyAnimationReference.
        /// </summary>
        /// <param name="left">Compared (DestinyDefinitionsAnimationsDestinyAnimationReference</param>
        /// <param name="right">Compared (DestinyDefinitionsAnimationsDestinyAnimationReference</param>
        /// <returns>true if compared items are not equals, false otherwise</returns>
        public static bool operator != (DestinyDefinitionsAnimationsDestinyAnimationReference left, DestinyDefinitionsAnimationsDestinyAnimationReference right)
        {
            return !Equals(left, right);
        }

        /// <summary>
        /// Builder of DestinyDefinitionsAnimationsDestinyAnimationReference.
        /// </summary>
        public sealed class DestinyDefinitionsAnimationsDestinyAnimationReferenceBuilder
        {
            private string _AnimName;
            private string _AnimIdentifier;
            private string _Path;

            internal DestinyDefinitionsAnimationsDestinyAnimationReferenceBuilder()
            {
                SetupDefaults();
            }

            private void SetupDefaults()
            {
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsAnimationsDestinyAnimationReference.AnimName property.
            /// </summary>
            /// <param name="value">AnimName</param>
            public DestinyDefinitionsAnimationsDestinyAnimationReferenceBuilder AnimName(string value)
            {
                _AnimName = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsAnimationsDestinyAnimationReference.AnimIdentifier property.
            /// </summary>
            /// <param name="value">AnimIdentifier</param>
            public DestinyDefinitionsAnimationsDestinyAnimationReferenceBuilder AnimIdentifier(string value)
            {
                _AnimIdentifier = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsAnimationsDestinyAnimationReference.Path property.
            /// </summary>
            /// <param name="value">Path</param>
            public DestinyDefinitionsAnimationsDestinyAnimationReferenceBuilder Path(string value)
            {
                _Path = value;
                return this;
            }


            /// <summary>
            /// Builds instance of DestinyDefinitionsAnimationsDestinyAnimationReference.
            /// </summary>
            /// <returns>DestinyDefinitionsAnimationsDestinyAnimationReference</returns>
            public DestinyDefinitionsAnimationsDestinyAnimationReference Build()
            {
                Validate();
                return new DestinyDefinitionsAnimationsDestinyAnimationReference(
                    AnimName: _AnimName,
                    AnimIdentifier: _AnimIdentifier,
                    Path: _Path
                );
            }

            private void Validate()
            { 
            }
        }

        
    }
}