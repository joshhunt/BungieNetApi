using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Sharpility.Extensions;
using NodaTime;

namespace BungieNetApi._Platform.Models
{
    /// <summary>
    /// A specific \&quot;spot\&quot; referred to by a location. Only one of these can be active at a time for a given Location.
    /// </summary>
    public sealed class DestinyDefinitionsDestinyLocationReleaseDefinition:  IEquatable<DestinyDefinitionsDestinyLocationReleaseDefinition>
    { 
        /// <summary>
        /// Sadly, these don&#39;t appear to be populated anymore (ever?)
        /// </summary>
        public DestinyDefinitionsCommonDestinyDisplayPropertiesDefinition DisplayProperties { get; private set; }

        /// <summary>
        /// SmallTransparentIcon
        /// </summary>
        public string SmallTransparentIcon { get; private set; }

        /// <summary>
        /// MapIcon
        /// </summary>
        public string MapIcon { get; private set; }

        /// <summary>
        /// LargeTransparentIcon
        /// </summary>
        public string LargeTransparentIcon { get; private set; }

        /// <summary>
        /// If we had map information, this spawnPoint would be interesting. But sadly, we don&#39;t have that info.
        /// </summary>
        public int? SpawnPoint { get; private set; }

        /// <summary>
        /// The Destination being pointed to by this location.
        /// </summary>
        public int? DestinationHash { get; private set; }

        /// <summary>
        /// The Activity being pointed to by this location.
        /// </summary>
        public int? ActivityHash { get; private set; }

        /// <summary>
        /// The Activity Graph being pointed to by this location.
        /// </summary>
        public int? ActivityGraphHash { get; private set; }

        /// <summary>
        /// The Activity Graph Node being pointed to by this location. (Remember that Activity Graph Node hashes are only unique within an Activity Graph: so use the combination to find the node being spoken of)
        /// </summary>
        public int? ActivityGraphNodeHash { get; private set; }

        /// <summary>
        /// The Activity Bubble within the Destination. Look this up in the DestinyDestinationDefinition&#39;s bubbles and bubbleSettings properties.
        /// </summary>
        public int? ActivityBubbleName { get; private set; }

        /// <summary>
        /// If we had map information, this would tell us something cool about the path this location wants you to take. I wish we had map information.
        /// </summary>
        public int? ActivityPathBundle { get; private set; }

        /// <summary>
        /// If we had map information, this would tell us about path information related to destination on the map. Sad. Maybe you can do something cool with it. Go to town man.
        /// </summary>
        public int? ActivityPathDestination { get; private set; }

        /// <summary>
        /// The type of Nav Point that this represents. See the enumeration for more info.
        /// </summary>
        public int? NavPointType { get; private set; }

        /// <summary>
        /// Looks like it should be the position on the map, but sadly it does not look populated... yet?
        /// </summary>
        public List<int?> WorldPosition { get; private set; }


        /// <summary>
        /// Empty constructor required by some serializers.
        /// Use DestinyDefinitionsDestinyLocationReleaseDefinition.Builder() for instance creation instead.
        /// </summary>
        [Obsolete]
        public DestinyDefinitionsDestinyLocationReleaseDefinition()
        {
        }

        private DestinyDefinitionsDestinyLocationReleaseDefinition(DestinyDefinitionsCommonDestinyDisplayPropertiesDefinition DisplayProperties, string SmallTransparentIcon, string MapIcon, string LargeTransparentIcon, int? SpawnPoint, int? DestinationHash, int? ActivityHash, int? ActivityGraphHash, int? ActivityGraphNodeHash, int? ActivityBubbleName, int? ActivityPathBundle, int? ActivityPathDestination, int? NavPointType, List<int?> WorldPosition)
        {
            
            this.DisplayProperties = DisplayProperties;
            
            this.SmallTransparentIcon = SmallTransparentIcon;
            
            this.MapIcon = MapIcon;
            
            this.LargeTransparentIcon = LargeTransparentIcon;
            
            this.SpawnPoint = SpawnPoint;
            
            this.DestinationHash = DestinationHash;
            
            this.ActivityHash = ActivityHash;
            
            this.ActivityGraphHash = ActivityGraphHash;
            
            this.ActivityGraphNodeHash = ActivityGraphNodeHash;
            
            this.ActivityBubbleName = ActivityBubbleName;
            
            this.ActivityPathBundle = ActivityPathBundle;
            
            this.ActivityPathDestination = ActivityPathDestination;
            
            this.NavPointType = NavPointType;
            
            this.WorldPosition = WorldPosition;
            
        }

        /// <summary>
        /// Returns builder of DestinyDefinitionsDestinyLocationReleaseDefinition.
        /// </summary>
        /// <returns>DestinyDefinitionsDestinyLocationReleaseDefinitionBuilder</returns>
        public static DestinyDefinitionsDestinyLocationReleaseDefinitionBuilder Builder()
        {
            return new DestinyDefinitionsDestinyLocationReleaseDefinitionBuilder();
        }

        /// <summary>
        /// Returns DestinyDefinitionsDestinyLocationReleaseDefinitionBuilder with properties set.
        /// Use it to change properties.
        /// </summary>
        /// <returns>DestinyDefinitionsDestinyLocationReleaseDefinitionBuilder</returns>
        public DestinyDefinitionsDestinyLocationReleaseDefinitionBuilder With()
        {
            return Builder()
                .DisplayProperties(DisplayProperties)
                .SmallTransparentIcon(SmallTransparentIcon)
                .MapIcon(MapIcon)
                .LargeTransparentIcon(LargeTransparentIcon)
                .SpawnPoint(SpawnPoint)
                .DestinationHash(DestinationHash)
                .ActivityHash(ActivityHash)
                .ActivityGraphHash(ActivityGraphHash)
                .ActivityGraphNodeHash(ActivityGraphNodeHash)
                .ActivityBubbleName(ActivityBubbleName)
                .ActivityPathBundle(ActivityPathBundle)
                .ActivityPathDestination(ActivityPathDestination)
                .NavPointType(NavPointType)
                .WorldPosition(WorldPosition);
        }

        public override string ToString()
        {
            return this.PropertiesToString();
        }

        public override bool Equals(object obj)
        {
            return this.EqualsByProperties(obj);
        }

        public bool Equals(DestinyDefinitionsDestinyLocationReleaseDefinition other)
        {
            return Equals((object) other);
        }

        public override int GetHashCode()
        {
            return this.PropertiesHash();
        }

        /// <summary>
        /// Implementation of == operator for (DestinyDefinitionsDestinyLocationReleaseDefinition.
        /// </summary>
        /// <param name="left">Compared (DestinyDefinitionsDestinyLocationReleaseDefinition</param>
        /// <param name="right">Compared (DestinyDefinitionsDestinyLocationReleaseDefinition</param>
        /// <returns>true if compared items are equals, false otherwise</returns>
        public static bool operator == (DestinyDefinitionsDestinyLocationReleaseDefinition left, DestinyDefinitionsDestinyLocationReleaseDefinition right)
        {
            return Equals(left, right);
        }

        /// <summary>
        /// Implementation of != operator for (DestinyDefinitionsDestinyLocationReleaseDefinition.
        /// </summary>
        /// <param name="left">Compared (DestinyDefinitionsDestinyLocationReleaseDefinition</param>
        /// <param name="right">Compared (DestinyDefinitionsDestinyLocationReleaseDefinition</param>
        /// <returns>true if compared items are not equals, false otherwise</returns>
        public static bool operator != (DestinyDefinitionsDestinyLocationReleaseDefinition left, DestinyDefinitionsDestinyLocationReleaseDefinition right)
        {
            return !Equals(left, right);
        }

        /// <summary>
        /// Builder of DestinyDefinitionsDestinyLocationReleaseDefinition.
        /// </summary>
        public sealed class DestinyDefinitionsDestinyLocationReleaseDefinitionBuilder
        {
            private DestinyDefinitionsCommonDestinyDisplayPropertiesDefinition _DisplayProperties;
            private string _SmallTransparentIcon;
            private string _MapIcon;
            private string _LargeTransparentIcon;
            private int? _SpawnPoint;
            private int? _DestinationHash;
            private int? _ActivityHash;
            private int? _ActivityGraphHash;
            private int? _ActivityGraphNodeHash;
            private int? _ActivityBubbleName;
            private int? _ActivityPathBundle;
            private int? _ActivityPathDestination;
            private int? _NavPointType;
            private List<int?> _WorldPosition;

            internal DestinyDefinitionsDestinyLocationReleaseDefinitionBuilder()
            {
                SetupDefaults();
            }

            private void SetupDefaults()
            {
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsDestinyLocationReleaseDefinition.DisplayProperties property.
            /// </summary>
            /// <param name="value">Sadly, these don&#39;t appear to be populated anymore (ever?)</param>
            public DestinyDefinitionsDestinyLocationReleaseDefinitionBuilder DisplayProperties(DestinyDefinitionsCommonDestinyDisplayPropertiesDefinition value)
            {
                _DisplayProperties = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsDestinyLocationReleaseDefinition.SmallTransparentIcon property.
            /// </summary>
            /// <param name="value">SmallTransparentIcon</param>
            public DestinyDefinitionsDestinyLocationReleaseDefinitionBuilder SmallTransparentIcon(string value)
            {
                _SmallTransparentIcon = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsDestinyLocationReleaseDefinition.MapIcon property.
            /// </summary>
            /// <param name="value">MapIcon</param>
            public DestinyDefinitionsDestinyLocationReleaseDefinitionBuilder MapIcon(string value)
            {
                _MapIcon = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsDestinyLocationReleaseDefinition.LargeTransparentIcon property.
            /// </summary>
            /// <param name="value">LargeTransparentIcon</param>
            public DestinyDefinitionsDestinyLocationReleaseDefinitionBuilder LargeTransparentIcon(string value)
            {
                _LargeTransparentIcon = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsDestinyLocationReleaseDefinition.SpawnPoint property.
            /// </summary>
            /// <param name="value">If we had map information, this spawnPoint would be interesting. But sadly, we don&#39;t have that info.</param>
            public DestinyDefinitionsDestinyLocationReleaseDefinitionBuilder SpawnPoint(int? value)
            {
                _SpawnPoint = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsDestinyLocationReleaseDefinition.DestinationHash property.
            /// </summary>
            /// <param name="value">The Destination being pointed to by this location.</param>
            public DestinyDefinitionsDestinyLocationReleaseDefinitionBuilder DestinationHash(int? value)
            {
                _DestinationHash = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsDestinyLocationReleaseDefinition.ActivityHash property.
            /// </summary>
            /// <param name="value">The Activity being pointed to by this location.</param>
            public DestinyDefinitionsDestinyLocationReleaseDefinitionBuilder ActivityHash(int? value)
            {
                _ActivityHash = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsDestinyLocationReleaseDefinition.ActivityGraphHash property.
            /// </summary>
            /// <param name="value">The Activity Graph being pointed to by this location.</param>
            public DestinyDefinitionsDestinyLocationReleaseDefinitionBuilder ActivityGraphHash(int? value)
            {
                _ActivityGraphHash = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsDestinyLocationReleaseDefinition.ActivityGraphNodeHash property.
            /// </summary>
            /// <param name="value">The Activity Graph Node being pointed to by this location. (Remember that Activity Graph Node hashes are only unique within an Activity Graph: so use the combination to find the node being spoken of)</param>
            public DestinyDefinitionsDestinyLocationReleaseDefinitionBuilder ActivityGraphNodeHash(int? value)
            {
                _ActivityGraphNodeHash = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsDestinyLocationReleaseDefinition.ActivityBubbleName property.
            /// </summary>
            /// <param name="value">The Activity Bubble within the Destination. Look this up in the DestinyDestinationDefinition&#39;s bubbles and bubbleSettings properties.</param>
            public DestinyDefinitionsDestinyLocationReleaseDefinitionBuilder ActivityBubbleName(int? value)
            {
                _ActivityBubbleName = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsDestinyLocationReleaseDefinition.ActivityPathBundle property.
            /// </summary>
            /// <param name="value">If we had map information, this would tell us something cool about the path this location wants you to take. I wish we had map information.</param>
            public DestinyDefinitionsDestinyLocationReleaseDefinitionBuilder ActivityPathBundle(int? value)
            {
                _ActivityPathBundle = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsDestinyLocationReleaseDefinition.ActivityPathDestination property.
            /// </summary>
            /// <param name="value">If we had map information, this would tell us about path information related to destination on the map. Sad. Maybe you can do something cool with it. Go to town man.</param>
            public DestinyDefinitionsDestinyLocationReleaseDefinitionBuilder ActivityPathDestination(int? value)
            {
                _ActivityPathDestination = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsDestinyLocationReleaseDefinition.NavPointType property.
            /// </summary>
            /// <param name="value">The type of Nav Point that this represents. See the enumeration for more info.</param>
            public DestinyDefinitionsDestinyLocationReleaseDefinitionBuilder NavPointType(int? value)
            {
                _NavPointType = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsDestinyLocationReleaseDefinition.WorldPosition property.
            /// </summary>
            /// <param name="value">Looks like it should be the position on the map, but sadly it does not look populated... yet?</param>
            public DestinyDefinitionsDestinyLocationReleaseDefinitionBuilder WorldPosition(List<int?> value)
            {
                _WorldPosition = value;
                return this;
            }


            /// <summary>
            /// Builds instance of DestinyDefinitionsDestinyLocationReleaseDefinition.
            /// </summary>
            /// <returns>DestinyDefinitionsDestinyLocationReleaseDefinition</returns>
            public DestinyDefinitionsDestinyLocationReleaseDefinition Build()
            {
                Validate();
                return new DestinyDefinitionsDestinyLocationReleaseDefinition(
                    DisplayProperties: _DisplayProperties,
                    SmallTransparentIcon: _SmallTransparentIcon,
                    MapIcon: _MapIcon,
                    LargeTransparentIcon: _LargeTransparentIcon,
                    SpawnPoint: _SpawnPoint,
                    DestinationHash: _DestinationHash,
                    ActivityHash: _ActivityHash,
                    ActivityGraphHash: _ActivityGraphHash,
                    ActivityGraphNodeHash: _ActivityGraphNodeHash,
                    ActivityBubbleName: _ActivityBubbleName,
                    ActivityPathBundle: _ActivityPathBundle,
                    ActivityPathDestination: _ActivityPathDestination,
                    NavPointType: _NavPointType,
                    WorldPosition: _WorldPosition
                );
            }

            private void Validate()
            { 
            }
        }

        
    }
}