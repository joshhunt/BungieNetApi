using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Sharpility.Extensions;
using NodaTime;

namespace BungieNetApi._Platform.Models
{
    /// <summary>
    /// CommonModelsDestiny2CoreSettings
    /// </summary>
    public sealed class CommonModelsDestiny2CoreSettings:  IEquatable<CommonModelsDestiny2CoreSettings>
    { 
        /// <summary>
        /// CollectionRootNode
        /// </summary>
        public int? CollectionRootNode { get; private set; }

        /// <summary>
        /// BadgesRootNode
        /// </summary>
        public int? BadgesRootNode { get; private set; }

        /// <summary>
        /// RecordsRootNode
        /// </summary>
        public int? RecordsRootNode { get; private set; }

        /// <summary>
        /// MedalsRootNode
        /// </summary>
        public int? MedalsRootNode { get; private set; }

        /// <summary>
        /// MetricsRootNode
        /// </summary>
        public int? MetricsRootNode { get; private set; }

        /// <summary>
        /// CurrentRankProgressionHashes
        /// </summary>
        public List<int?> CurrentRankProgressionHashes { get; private set; }

        /// <summary>
        /// UndiscoveredCollectibleImage
        /// </summary>
        public string UndiscoveredCollectibleImage { get; private set; }

        /// <summary>
        /// AmmoTypeHeavyIcon
        /// </summary>
        public string AmmoTypeHeavyIcon { get; private set; }

        /// <summary>
        /// AmmoTypeSpecialIcon
        /// </summary>
        public string AmmoTypeSpecialIcon { get; private set; }

        /// <summary>
        /// AmmoTypePrimaryIcon
        /// </summary>
        public string AmmoTypePrimaryIcon { get; private set; }

        /// <summary>
        /// CurrentSeasonalArtifactHash
        /// </summary>
        public int? CurrentSeasonalArtifactHash { get; private set; }

        /// <summary>
        /// CurrentSeasonHash
        /// </summary>
        public int? CurrentSeasonHash { get; private set; }

        /// <summary>
        /// FutureSeasonHashes
        /// </summary>
        public List<int?> FutureSeasonHashes { get; private set; }

        /// <summary>
        /// PastSeasonHashes
        /// </summary>
        public List<int?> PastSeasonHashes { get; private set; }


        /// <summary>
        /// Empty constructor required by some serializers.
        /// Use CommonModelsDestiny2CoreSettings.Builder() for instance creation instead.
        /// </summary>
        [Obsolete]
        public CommonModelsDestiny2CoreSettings()
        {
        }

        private CommonModelsDestiny2CoreSettings(int? CollectionRootNode, int? BadgesRootNode, int? RecordsRootNode, int? MedalsRootNode, int? MetricsRootNode, List<int?> CurrentRankProgressionHashes, string UndiscoveredCollectibleImage, string AmmoTypeHeavyIcon, string AmmoTypeSpecialIcon, string AmmoTypePrimaryIcon, int? CurrentSeasonalArtifactHash, int? CurrentSeasonHash, List<int?> FutureSeasonHashes, List<int?> PastSeasonHashes)
        {
            
            this.CollectionRootNode = CollectionRootNode;
            
            this.BadgesRootNode = BadgesRootNode;
            
            this.RecordsRootNode = RecordsRootNode;
            
            this.MedalsRootNode = MedalsRootNode;
            
            this.MetricsRootNode = MetricsRootNode;
            
            this.CurrentRankProgressionHashes = CurrentRankProgressionHashes;
            
            this.UndiscoveredCollectibleImage = UndiscoveredCollectibleImage;
            
            this.AmmoTypeHeavyIcon = AmmoTypeHeavyIcon;
            
            this.AmmoTypeSpecialIcon = AmmoTypeSpecialIcon;
            
            this.AmmoTypePrimaryIcon = AmmoTypePrimaryIcon;
            
            this.CurrentSeasonalArtifactHash = CurrentSeasonalArtifactHash;
            
            this.CurrentSeasonHash = CurrentSeasonHash;
            
            this.FutureSeasonHashes = FutureSeasonHashes;
            
            this.PastSeasonHashes = PastSeasonHashes;
            
        }

        /// <summary>
        /// Returns builder of CommonModelsDestiny2CoreSettings.
        /// </summary>
        /// <returns>CommonModelsDestiny2CoreSettingsBuilder</returns>
        public static CommonModelsDestiny2CoreSettingsBuilder Builder()
        {
            return new CommonModelsDestiny2CoreSettingsBuilder();
        }

        /// <summary>
        /// Returns CommonModelsDestiny2CoreSettingsBuilder with properties set.
        /// Use it to change properties.
        /// </summary>
        /// <returns>CommonModelsDestiny2CoreSettingsBuilder</returns>
        public CommonModelsDestiny2CoreSettingsBuilder With()
        {
            return Builder()
                .CollectionRootNode(CollectionRootNode)
                .BadgesRootNode(BadgesRootNode)
                .RecordsRootNode(RecordsRootNode)
                .MedalsRootNode(MedalsRootNode)
                .MetricsRootNode(MetricsRootNode)
                .CurrentRankProgressionHashes(CurrentRankProgressionHashes)
                .UndiscoveredCollectibleImage(UndiscoveredCollectibleImage)
                .AmmoTypeHeavyIcon(AmmoTypeHeavyIcon)
                .AmmoTypeSpecialIcon(AmmoTypeSpecialIcon)
                .AmmoTypePrimaryIcon(AmmoTypePrimaryIcon)
                .CurrentSeasonalArtifactHash(CurrentSeasonalArtifactHash)
                .CurrentSeasonHash(CurrentSeasonHash)
                .FutureSeasonHashes(FutureSeasonHashes)
                .PastSeasonHashes(PastSeasonHashes);
        }

        public override string ToString()
        {
            return this.PropertiesToString();
        }

        public override bool Equals(object obj)
        {
            return this.EqualsByProperties(obj);
        }

        public bool Equals(CommonModelsDestiny2CoreSettings other)
        {
            return Equals((object) other);
        }

        public override int GetHashCode()
        {
            return this.PropertiesHash();
        }

        /// <summary>
        /// Implementation of == operator for (CommonModelsDestiny2CoreSettings.
        /// </summary>
        /// <param name="left">Compared (CommonModelsDestiny2CoreSettings</param>
        /// <param name="right">Compared (CommonModelsDestiny2CoreSettings</param>
        /// <returns>true if compared items are equals, false otherwise</returns>
        public static bool operator == (CommonModelsDestiny2CoreSettings left, CommonModelsDestiny2CoreSettings right)
        {
            return Equals(left, right);
        }

        /// <summary>
        /// Implementation of != operator for (CommonModelsDestiny2CoreSettings.
        /// </summary>
        /// <param name="left">Compared (CommonModelsDestiny2CoreSettings</param>
        /// <param name="right">Compared (CommonModelsDestiny2CoreSettings</param>
        /// <returns>true if compared items are not equals, false otherwise</returns>
        public static bool operator != (CommonModelsDestiny2CoreSettings left, CommonModelsDestiny2CoreSettings right)
        {
            return !Equals(left, right);
        }

        /// <summary>
        /// Builder of CommonModelsDestiny2CoreSettings.
        /// </summary>
        public sealed class CommonModelsDestiny2CoreSettingsBuilder
        {
            private int? _CollectionRootNode;
            private int? _BadgesRootNode;
            private int? _RecordsRootNode;
            private int? _MedalsRootNode;
            private int? _MetricsRootNode;
            private List<int?> _CurrentRankProgressionHashes;
            private string _UndiscoveredCollectibleImage;
            private string _AmmoTypeHeavyIcon;
            private string _AmmoTypeSpecialIcon;
            private string _AmmoTypePrimaryIcon;
            private int? _CurrentSeasonalArtifactHash;
            private int? _CurrentSeasonHash;
            private List<int?> _FutureSeasonHashes;
            private List<int?> _PastSeasonHashes;

            internal CommonModelsDestiny2CoreSettingsBuilder()
            {
                SetupDefaults();
            }

            private void SetupDefaults()
            {
            }

            /// <summary>
            /// Sets value for CommonModelsDestiny2CoreSettings.CollectionRootNode property.
            /// </summary>
            /// <param name="value">CollectionRootNode</param>
            public CommonModelsDestiny2CoreSettingsBuilder CollectionRootNode(int? value)
            {
                _CollectionRootNode = value;
                return this;
            }

            /// <summary>
            /// Sets value for CommonModelsDestiny2CoreSettings.BadgesRootNode property.
            /// </summary>
            /// <param name="value">BadgesRootNode</param>
            public CommonModelsDestiny2CoreSettingsBuilder BadgesRootNode(int? value)
            {
                _BadgesRootNode = value;
                return this;
            }

            /// <summary>
            /// Sets value for CommonModelsDestiny2CoreSettings.RecordsRootNode property.
            /// </summary>
            /// <param name="value">RecordsRootNode</param>
            public CommonModelsDestiny2CoreSettingsBuilder RecordsRootNode(int? value)
            {
                _RecordsRootNode = value;
                return this;
            }

            /// <summary>
            /// Sets value for CommonModelsDestiny2CoreSettings.MedalsRootNode property.
            /// </summary>
            /// <param name="value">MedalsRootNode</param>
            public CommonModelsDestiny2CoreSettingsBuilder MedalsRootNode(int? value)
            {
                _MedalsRootNode = value;
                return this;
            }

            /// <summary>
            /// Sets value for CommonModelsDestiny2CoreSettings.MetricsRootNode property.
            /// </summary>
            /// <param name="value">MetricsRootNode</param>
            public CommonModelsDestiny2CoreSettingsBuilder MetricsRootNode(int? value)
            {
                _MetricsRootNode = value;
                return this;
            }

            /// <summary>
            /// Sets value for CommonModelsDestiny2CoreSettings.CurrentRankProgressionHashes property.
            /// </summary>
            /// <param name="value">CurrentRankProgressionHashes</param>
            public CommonModelsDestiny2CoreSettingsBuilder CurrentRankProgressionHashes(List<int?> value)
            {
                _CurrentRankProgressionHashes = value;
                return this;
            }

            /// <summary>
            /// Sets value for CommonModelsDestiny2CoreSettings.UndiscoveredCollectibleImage property.
            /// </summary>
            /// <param name="value">UndiscoveredCollectibleImage</param>
            public CommonModelsDestiny2CoreSettingsBuilder UndiscoveredCollectibleImage(string value)
            {
                _UndiscoveredCollectibleImage = value;
                return this;
            }

            /// <summary>
            /// Sets value for CommonModelsDestiny2CoreSettings.AmmoTypeHeavyIcon property.
            /// </summary>
            /// <param name="value">AmmoTypeHeavyIcon</param>
            public CommonModelsDestiny2CoreSettingsBuilder AmmoTypeHeavyIcon(string value)
            {
                _AmmoTypeHeavyIcon = value;
                return this;
            }

            /// <summary>
            /// Sets value for CommonModelsDestiny2CoreSettings.AmmoTypeSpecialIcon property.
            /// </summary>
            /// <param name="value">AmmoTypeSpecialIcon</param>
            public CommonModelsDestiny2CoreSettingsBuilder AmmoTypeSpecialIcon(string value)
            {
                _AmmoTypeSpecialIcon = value;
                return this;
            }

            /// <summary>
            /// Sets value for CommonModelsDestiny2CoreSettings.AmmoTypePrimaryIcon property.
            /// </summary>
            /// <param name="value">AmmoTypePrimaryIcon</param>
            public CommonModelsDestiny2CoreSettingsBuilder AmmoTypePrimaryIcon(string value)
            {
                _AmmoTypePrimaryIcon = value;
                return this;
            }

            /// <summary>
            /// Sets value for CommonModelsDestiny2CoreSettings.CurrentSeasonalArtifactHash property.
            /// </summary>
            /// <param name="value">CurrentSeasonalArtifactHash</param>
            public CommonModelsDestiny2CoreSettingsBuilder CurrentSeasonalArtifactHash(int? value)
            {
                _CurrentSeasonalArtifactHash = value;
                return this;
            }

            /// <summary>
            /// Sets value for CommonModelsDestiny2CoreSettings.CurrentSeasonHash property.
            /// </summary>
            /// <param name="value">CurrentSeasonHash</param>
            public CommonModelsDestiny2CoreSettingsBuilder CurrentSeasonHash(int? value)
            {
                _CurrentSeasonHash = value;
                return this;
            }

            /// <summary>
            /// Sets value for CommonModelsDestiny2CoreSettings.FutureSeasonHashes property.
            /// </summary>
            /// <param name="value">FutureSeasonHashes</param>
            public CommonModelsDestiny2CoreSettingsBuilder FutureSeasonHashes(List<int?> value)
            {
                _FutureSeasonHashes = value;
                return this;
            }

            /// <summary>
            /// Sets value for CommonModelsDestiny2CoreSettings.PastSeasonHashes property.
            /// </summary>
            /// <param name="value">PastSeasonHashes</param>
            public CommonModelsDestiny2CoreSettingsBuilder PastSeasonHashes(List<int?> value)
            {
                _PastSeasonHashes = value;
                return this;
            }


            /// <summary>
            /// Builds instance of CommonModelsDestiny2CoreSettings.
            /// </summary>
            /// <returns>CommonModelsDestiny2CoreSettings</returns>
            public CommonModelsDestiny2CoreSettings Build()
            {
                Validate();
                return new CommonModelsDestiny2CoreSettings(
                    CollectionRootNode: _CollectionRootNode,
                    BadgesRootNode: _BadgesRootNode,
                    RecordsRootNode: _RecordsRootNode,
                    MedalsRootNode: _MedalsRootNode,
                    MetricsRootNode: _MetricsRootNode,
                    CurrentRankProgressionHashes: _CurrentRankProgressionHashes,
                    UndiscoveredCollectibleImage: _UndiscoveredCollectibleImage,
                    AmmoTypeHeavyIcon: _AmmoTypeHeavyIcon,
                    AmmoTypeSpecialIcon: _AmmoTypeSpecialIcon,
                    AmmoTypePrimaryIcon: _AmmoTypePrimaryIcon,
                    CurrentSeasonalArtifactHash: _CurrentSeasonalArtifactHash,
                    CurrentSeasonHash: _CurrentSeasonHash,
                    FutureSeasonHashes: _FutureSeasonHashes,
                    PastSeasonHashes: _PastSeasonHashes
                );
            }

            private void Validate()
            { 
            }
        }

        
    }
}