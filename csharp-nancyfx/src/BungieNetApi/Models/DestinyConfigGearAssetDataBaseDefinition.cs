using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Sharpility.Extensions;
using NodaTime;

namespace BungieNetApi._Platform.Models
{
    /// <summary>
    /// DestinyConfigGearAssetDataBaseDefinition
    /// </summary>
    public sealed class DestinyConfigGearAssetDataBaseDefinition:  IEquatable<DestinyConfigGearAssetDataBaseDefinition>
    { 
        /// <summary>
        /// Version
        /// </summary>
        public int? Version { get; private set; }

        /// <summary>
        /// Path
        /// </summary>
        public string Path { get; private set; }


        /// <summary>
        /// Empty constructor required by some serializers.
        /// Use DestinyConfigGearAssetDataBaseDefinition.Builder() for instance creation instead.
        /// </summary>
        [Obsolete]
        public DestinyConfigGearAssetDataBaseDefinition()
        {
        }

        private DestinyConfigGearAssetDataBaseDefinition(int? Version, string Path)
        {
            
            this.Version = Version;
            
            this.Path = Path;
            
        }

        /// <summary>
        /// Returns builder of DestinyConfigGearAssetDataBaseDefinition.
        /// </summary>
        /// <returns>DestinyConfigGearAssetDataBaseDefinitionBuilder</returns>
        public static DestinyConfigGearAssetDataBaseDefinitionBuilder Builder()
        {
            return new DestinyConfigGearAssetDataBaseDefinitionBuilder();
        }

        /// <summary>
        /// Returns DestinyConfigGearAssetDataBaseDefinitionBuilder with properties set.
        /// Use it to change properties.
        /// </summary>
        /// <returns>DestinyConfigGearAssetDataBaseDefinitionBuilder</returns>
        public DestinyConfigGearAssetDataBaseDefinitionBuilder With()
        {
            return Builder()
                .Version(Version)
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

        public bool Equals(DestinyConfigGearAssetDataBaseDefinition other)
        {
            return Equals((object) other);
        }

        public override int GetHashCode()
        {
            return this.PropertiesHash();
        }

        /// <summary>
        /// Implementation of == operator for (DestinyConfigGearAssetDataBaseDefinition.
        /// </summary>
        /// <param name="left">Compared (DestinyConfigGearAssetDataBaseDefinition</param>
        /// <param name="right">Compared (DestinyConfigGearAssetDataBaseDefinition</param>
        /// <returns>true if compared items are equals, false otherwise</returns>
        public static bool operator == (DestinyConfigGearAssetDataBaseDefinition left, DestinyConfigGearAssetDataBaseDefinition right)
        {
            return Equals(left, right);
        }

        /// <summary>
        /// Implementation of != operator for (DestinyConfigGearAssetDataBaseDefinition.
        /// </summary>
        /// <param name="left">Compared (DestinyConfigGearAssetDataBaseDefinition</param>
        /// <param name="right">Compared (DestinyConfigGearAssetDataBaseDefinition</param>
        /// <returns>true if compared items are not equals, false otherwise</returns>
        public static bool operator != (DestinyConfigGearAssetDataBaseDefinition left, DestinyConfigGearAssetDataBaseDefinition right)
        {
            return !Equals(left, right);
        }

        /// <summary>
        /// Builder of DestinyConfigGearAssetDataBaseDefinition.
        /// </summary>
        public sealed class DestinyConfigGearAssetDataBaseDefinitionBuilder
        {
            private int? _Version;
            private string _Path;

            internal DestinyConfigGearAssetDataBaseDefinitionBuilder()
            {
                SetupDefaults();
            }

            private void SetupDefaults()
            {
            }

            /// <summary>
            /// Sets value for DestinyConfigGearAssetDataBaseDefinition.Version property.
            /// </summary>
            /// <param name="value">Version</param>
            public DestinyConfigGearAssetDataBaseDefinitionBuilder Version(int? value)
            {
                _Version = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyConfigGearAssetDataBaseDefinition.Path property.
            /// </summary>
            /// <param name="value">Path</param>
            public DestinyConfigGearAssetDataBaseDefinitionBuilder Path(string value)
            {
                _Path = value;
                return this;
            }


            /// <summary>
            /// Builds instance of DestinyConfigGearAssetDataBaseDefinition.
            /// </summary>
            /// <returns>DestinyConfigGearAssetDataBaseDefinition</returns>
            public DestinyConfigGearAssetDataBaseDefinition Build()
            {
                Validate();
                return new DestinyConfigGearAssetDataBaseDefinition(
                    Version: _Version,
                    Path: _Path
                );
            }

            private void Validate()
            { 
            }
        }

        
    }
}