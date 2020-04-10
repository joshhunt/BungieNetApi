using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Sharpility.Extensions;
using NodaTime;

namespace BungieNetApi._Platform.Models
{
    /// <summary>
    /// DestinyManifest is the external-facing contract for just the properties needed by those calling the Destiny Platform.
    /// </summary>
    public sealed class DestinyConfigDestinyManifest:  IEquatable<DestinyConfigDestinyManifest>
    { 
        /// <summary>
        /// Version
        /// </summary>
        public string Version { get; private set; }

        /// <summary>
        /// MobileAssetContentPath
        /// </summary>
        public string MobileAssetContentPath { get; private set; }

        /// <summary>
        /// MobileGearAssetDataBases
        /// </summary>
        public List<DestinyConfigGearAssetDataBaseDefinition> MobileGearAssetDataBases { get; private set; }

        /// <summary>
        /// MobileWorldContentPaths
        /// </summary>
        public Dictionary<string, string> MobileWorldContentPaths { get; private set; }

        /// <summary>
        /// This points to the generated JSON that contains all the Definitions. Each key is a locale. The value is a path to the aggregated world definitions (warning: large file!)
        /// </summary>
        public Dictionary<string, string> JsonWorldContentPaths { get; private set; }

        /// <summary>
        /// This points to the generated JSON that contains all the Definitions. Each key is a locale. The value is a dictionary, where the key is a definition type by name, and the value is the path to the file for that definition. WARNING: This is unsafe and subject to change - do not depend on data in these files staying around long-term.
        /// </summary>
        public Dictionary<string, Dictionary<string, string>> JsonWorldComponentContentPaths { get; private set; }

        /// <summary>
        /// MobileClanBannerDatabasePath
        /// </summary>
        public string MobileClanBannerDatabasePath { get; private set; }

        /// <summary>
        /// MobileGearCDN
        /// </summary>
        public Dictionary<string, string> MobileGearCDN { get; private set; }

        /// <summary>
        /// Information about the \&quot;Image Pyramid\&quot; for Destiny icons. Where possible, we create smaller versions of Destiny icons. These are found as subfolders under the location of the \&quot;original/full size\&quot; Destiny images, with the same file name and extension as the original image itself. (this lets us avoid sending largely redundant path info with every entity, at the expense of the smaller versions of the image being less discoverable)
        /// </summary>
        public List<DestinyConfigImagePyramidEntry> IconImagePyramidInfo { get; private set; }


        /// <summary>
        /// Empty constructor required by some serializers.
        /// Use DestinyConfigDestinyManifest.Builder() for instance creation instead.
        /// </summary>
        [Obsolete]
        public DestinyConfigDestinyManifest()
        {
        }

        private DestinyConfigDestinyManifest(string Version, string MobileAssetContentPath, List<DestinyConfigGearAssetDataBaseDefinition> MobileGearAssetDataBases, Dictionary<string, string> MobileWorldContentPaths, Dictionary<string, string> JsonWorldContentPaths, Dictionary<string, Dictionary<string, string>> JsonWorldComponentContentPaths, string MobileClanBannerDatabasePath, Dictionary<string, string> MobileGearCDN, List<DestinyConfigImagePyramidEntry> IconImagePyramidInfo)
        {
            
            this.Version = Version;
            
            this.MobileAssetContentPath = MobileAssetContentPath;
            
            this.MobileGearAssetDataBases = MobileGearAssetDataBases;
            
            this.MobileWorldContentPaths = MobileWorldContentPaths;
            
            this.JsonWorldContentPaths = JsonWorldContentPaths;
            
            this.JsonWorldComponentContentPaths = JsonWorldComponentContentPaths;
            
            this.MobileClanBannerDatabasePath = MobileClanBannerDatabasePath;
            
            this.MobileGearCDN = MobileGearCDN;
            
            this.IconImagePyramidInfo = IconImagePyramidInfo;
            
        }

        /// <summary>
        /// Returns builder of DestinyConfigDestinyManifest.
        /// </summary>
        /// <returns>DestinyConfigDestinyManifestBuilder</returns>
        public static DestinyConfigDestinyManifestBuilder Builder()
        {
            return new DestinyConfigDestinyManifestBuilder();
        }

        /// <summary>
        /// Returns DestinyConfigDestinyManifestBuilder with properties set.
        /// Use it to change properties.
        /// </summary>
        /// <returns>DestinyConfigDestinyManifestBuilder</returns>
        public DestinyConfigDestinyManifestBuilder With()
        {
            return Builder()
                .Version(Version)
                .MobileAssetContentPath(MobileAssetContentPath)
                .MobileGearAssetDataBases(MobileGearAssetDataBases)
                .MobileWorldContentPaths(MobileWorldContentPaths)
                .JsonWorldContentPaths(JsonWorldContentPaths)
                .JsonWorldComponentContentPaths(JsonWorldComponentContentPaths)
                .MobileClanBannerDatabasePath(MobileClanBannerDatabasePath)
                .MobileGearCDN(MobileGearCDN)
                .IconImagePyramidInfo(IconImagePyramidInfo);
        }

        public override string ToString()
        {
            return this.PropertiesToString();
        }

        public override bool Equals(object obj)
        {
            return this.EqualsByProperties(obj);
        }

        public bool Equals(DestinyConfigDestinyManifest other)
        {
            return Equals((object) other);
        }

        public override int GetHashCode()
        {
            return this.PropertiesHash();
        }

        /// <summary>
        /// Implementation of == operator for (DestinyConfigDestinyManifest.
        /// </summary>
        /// <param name="left">Compared (DestinyConfigDestinyManifest</param>
        /// <param name="right">Compared (DestinyConfigDestinyManifest</param>
        /// <returns>true if compared items are equals, false otherwise</returns>
        public static bool operator == (DestinyConfigDestinyManifest left, DestinyConfigDestinyManifest right)
        {
            return Equals(left, right);
        }

        /// <summary>
        /// Implementation of != operator for (DestinyConfigDestinyManifest.
        /// </summary>
        /// <param name="left">Compared (DestinyConfigDestinyManifest</param>
        /// <param name="right">Compared (DestinyConfigDestinyManifest</param>
        /// <returns>true if compared items are not equals, false otherwise</returns>
        public static bool operator != (DestinyConfigDestinyManifest left, DestinyConfigDestinyManifest right)
        {
            return !Equals(left, right);
        }

        /// <summary>
        /// Builder of DestinyConfigDestinyManifest.
        /// </summary>
        public sealed class DestinyConfigDestinyManifestBuilder
        {
            private string _Version;
            private string _MobileAssetContentPath;
            private List<DestinyConfigGearAssetDataBaseDefinition> _MobileGearAssetDataBases;
            private Dictionary<string, string> _MobileWorldContentPaths;
            private Dictionary<string, string> _JsonWorldContentPaths;
            private Dictionary<string, Dictionary<string, string>> _JsonWorldComponentContentPaths;
            private string _MobileClanBannerDatabasePath;
            private Dictionary<string, string> _MobileGearCDN;
            private List<DestinyConfigImagePyramidEntry> _IconImagePyramidInfo;

            internal DestinyConfigDestinyManifestBuilder()
            {
                SetupDefaults();
            }

            private void SetupDefaults()
            {
            }

            /// <summary>
            /// Sets value for DestinyConfigDestinyManifest.Version property.
            /// </summary>
            /// <param name="value">Version</param>
            public DestinyConfigDestinyManifestBuilder Version(string value)
            {
                _Version = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyConfigDestinyManifest.MobileAssetContentPath property.
            /// </summary>
            /// <param name="value">MobileAssetContentPath</param>
            public DestinyConfigDestinyManifestBuilder MobileAssetContentPath(string value)
            {
                _MobileAssetContentPath = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyConfigDestinyManifest.MobileGearAssetDataBases property.
            /// </summary>
            /// <param name="value">MobileGearAssetDataBases</param>
            public DestinyConfigDestinyManifestBuilder MobileGearAssetDataBases(List<DestinyConfigGearAssetDataBaseDefinition> value)
            {
                _MobileGearAssetDataBases = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyConfigDestinyManifest.MobileWorldContentPaths property.
            /// </summary>
            /// <param name="value">MobileWorldContentPaths</param>
            public DestinyConfigDestinyManifestBuilder MobileWorldContentPaths(Dictionary<string, string> value)
            {
                _MobileWorldContentPaths = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyConfigDestinyManifest.JsonWorldContentPaths property.
            /// </summary>
            /// <param name="value">This points to the generated JSON that contains all the Definitions. Each key is a locale. The value is a path to the aggregated world definitions (warning: large file!)</param>
            public DestinyConfigDestinyManifestBuilder JsonWorldContentPaths(Dictionary<string, string> value)
            {
                _JsonWorldContentPaths = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyConfigDestinyManifest.JsonWorldComponentContentPaths property.
            /// </summary>
            /// <param name="value">This points to the generated JSON that contains all the Definitions. Each key is a locale. The value is a dictionary, where the key is a definition type by name, and the value is the path to the file for that definition. WARNING: This is unsafe and subject to change - do not depend on data in these files staying around long-term.</param>
            public DestinyConfigDestinyManifestBuilder JsonWorldComponentContentPaths(Dictionary<string, Dictionary<string, string>> value)
            {
                _JsonWorldComponentContentPaths = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyConfigDestinyManifest.MobileClanBannerDatabasePath property.
            /// </summary>
            /// <param name="value">MobileClanBannerDatabasePath</param>
            public DestinyConfigDestinyManifestBuilder MobileClanBannerDatabasePath(string value)
            {
                _MobileClanBannerDatabasePath = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyConfigDestinyManifest.MobileGearCDN property.
            /// </summary>
            /// <param name="value">MobileGearCDN</param>
            public DestinyConfigDestinyManifestBuilder MobileGearCDN(Dictionary<string, string> value)
            {
                _MobileGearCDN = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyConfigDestinyManifest.IconImagePyramidInfo property.
            /// </summary>
            /// <param name="value">Information about the \&quot;Image Pyramid\&quot; for Destiny icons. Where possible, we create smaller versions of Destiny icons. These are found as subfolders under the location of the \&quot;original/full size\&quot; Destiny images, with the same file name and extension as the original image itself. (this lets us avoid sending largely redundant path info with every entity, at the expense of the smaller versions of the image being less discoverable)</param>
            public DestinyConfigDestinyManifestBuilder IconImagePyramidInfo(List<DestinyConfigImagePyramidEntry> value)
            {
                _IconImagePyramidInfo = value;
                return this;
            }


            /// <summary>
            /// Builds instance of DestinyConfigDestinyManifest.
            /// </summary>
            /// <returns>DestinyConfigDestinyManifest</returns>
            public DestinyConfigDestinyManifest Build()
            {
                Validate();
                return new DestinyConfigDestinyManifest(
                    Version: _Version,
                    MobileAssetContentPath: _MobileAssetContentPath,
                    MobileGearAssetDataBases: _MobileGearAssetDataBases,
                    MobileWorldContentPaths: _MobileWorldContentPaths,
                    JsonWorldContentPaths: _JsonWorldContentPaths,
                    JsonWorldComponentContentPaths: _JsonWorldComponentContentPaths,
                    MobileClanBannerDatabasePath: _MobileClanBannerDatabasePath,
                    MobileGearCDN: _MobileGearCDN,
                    IconImagePyramidInfo: _IconImagePyramidInfo
                );
            }

            private void Validate()
            { 
            }
        }

        
    }
}