using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Sharpility.Extensions;
using NodaTime;

namespace BungieNetApi._Platform.Models
{
    /// <summary>
    /// DestinyConstantsDestinyEnvironmentLocationMapping
    /// </summary>
    public sealed class DestinyConstantsDestinyEnvironmentLocationMapping:  IEquatable<DestinyConstantsDestinyEnvironmentLocationMapping>
    { 
        /// <summary>
        /// The location that is revealed on the director by this mapping.
        /// </summary>
        public int? LocationHash { get; private set; }

        /// <summary>
        /// A hint that the UI uses to figure out how this location is activated by the player.
        /// </summary>
        public string ActivationSource { get; private set; }

        /// <summary>
        /// If this is populated, it is the item that you must possess for this location to be active because of this mapping. (theoretically, a location can have multiple mappings, and some might require an item while others don&#39;t)
        /// </summary>
        public int? ItemHash { get; private set; }

        /// <summary>
        /// If this is populated, this is an objective related to the location.
        /// </summary>
        public int? ObjectiveHash { get; private set; }

        /// <summary>
        /// If this is populated, this is the activity you have to be playing in order to see this location appear because of this mapping. (theoretically, a location can have multiple mappings, and some might require you to be in a specific activity when others don&#39;t)
        /// </summary>
        public int? ActivityHash { get; private set; }


        /// <summary>
        /// Empty constructor required by some serializers.
        /// Use DestinyConstantsDestinyEnvironmentLocationMapping.Builder() for instance creation instead.
        /// </summary>
        [Obsolete]
        public DestinyConstantsDestinyEnvironmentLocationMapping()
        {
        }

        private DestinyConstantsDestinyEnvironmentLocationMapping(int? LocationHash, string ActivationSource, int? ItemHash, int? ObjectiveHash, int? ActivityHash)
        {
            
            this.LocationHash = LocationHash;
            
            this.ActivationSource = ActivationSource;
            
            this.ItemHash = ItemHash;
            
            this.ObjectiveHash = ObjectiveHash;
            
            this.ActivityHash = ActivityHash;
            
        }

        /// <summary>
        /// Returns builder of DestinyConstantsDestinyEnvironmentLocationMapping.
        /// </summary>
        /// <returns>DestinyConstantsDestinyEnvironmentLocationMappingBuilder</returns>
        public static DestinyConstantsDestinyEnvironmentLocationMappingBuilder Builder()
        {
            return new DestinyConstantsDestinyEnvironmentLocationMappingBuilder();
        }

        /// <summary>
        /// Returns DestinyConstantsDestinyEnvironmentLocationMappingBuilder with properties set.
        /// Use it to change properties.
        /// </summary>
        /// <returns>DestinyConstantsDestinyEnvironmentLocationMappingBuilder</returns>
        public DestinyConstantsDestinyEnvironmentLocationMappingBuilder With()
        {
            return Builder()
                .LocationHash(LocationHash)
                .ActivationSource(ActivationSource)
                .ItemHash(ItemHash)
                .ObjectiveHash(ObjectiveHash)
                .ActivityHash(ActivityHash);
        }

        public override string ToString()
        {
            return this.PropertiesToString();
        }

        public override bool Equals(object obj)
        {
            return this.EqualsByProperties(obj);
        }

        public bool Equals(DestinyConstantsDestinyEnvironmentLocationMapping other)
        {
            return Equals((object) other);
        }

        public override int GetHashCode()
        {
            return this.PropertiesHash();
        }

        /// <summary>
        /// Implementation of == operator for (DestinyConstantsDestinyEnvironmentLocationMapping.
        /// </summary>
        /// <param name="left">Compared (DestinyConstantsDestinyEnvironmentLocationMapping</param>
        /// <param name="right">Compared (DestinyConstantsDestinyEnvironmentLocationMapping</param>
        /// <returns>true if compared items are equals, false otherwise</returns>
        public static bool operator == (DestinyConstantsDestinyEnvironmentLocationMapping left, DestinyConstantsDestinyEnvironmentLocationMapping right)
        {
            return Equals(left, right);
        }

        /// <summary>
        /// Implementation of != operator for (DestinyConstantsDestinyEnvironmentLocationMapping.
        /// </summary>
        /// <param name="left">Compared (DestinyConstantsDestinyEnvironmentLocationMapping</param>
        /// <param name="right">Compared (DestinyConstantsDestinyEnvironmentLocationMapping</param>
        /// <returns>true if compared items are not equals, false otherwise</returns>
        public static bool operator != (DestinyConstantsDestinyEnvironmentLocationMapping left, DestinyConstantsDestinyEnvironmentLocationMapping right)
        {
            return !Equals(left, right);
        }

        /// <summary>
        /// Builder of DestinyConstantsDestinyEnvironmentLocationMapping.
        /// </summary>
        public sealed class DestinyConstantsDestinyEnvironmentLocationMappingBuilder
        {
            private int? _LocationHash;
            private string _ActivationSource;
            private int? _ItemHash;
            private int? _ObjectiveHash;
            private int? _ActivityHash;

            internal DestinyConstantsDestinyEnvironmentLocationMappingBuilder()
            {
                SetupDefaults();
            }

            private void SetupDefaults()
            {
            }

            /// <summary>
            /// Sets value for DestinyConstantsDestinyEnvironmentLocationMapping.LocationHash property.
            /// </summary>
            /// <param name="value">The location that is revealed on the director by this mapping.</param>
            public DestinyConstantsDestinyEnvironmentLocationMappingBuilder LocationHash(int? value)
            {
                _LocationHash = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyConstantsDestinyEnvironmentLocationMapping.ActivationSource property.
            /// </summary>
            /// <param name="value">A hint that the UI uses to figure out how this location is activated by the player.</param>
            public DestinyConstantsDestinyEnvironmentLocationMappingBuilder ActivationSource(string value)
            {
                _ActivationSource = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyConstantsDestinyEnvironmentLocationMapping.ItemHash property.
            /// </summary>
            /// <param name="value">If this is populated, it is the item that you must possess for this location to be active because of this mapping. (theoretically, a location can have multiple mappings, and some might require an item while others don&#39;t)</param>
            public DestinyConstantsDestinyEnvironmentLocationMappingBuilder ItemHash(int? value)
            {
                _ItemHash = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyConstantsDestinyEnvironmentLocationMapping.ObjectiveHash property.
            /// </summary>
            /// <param name="value">If this is populated, this is an objective related to the location.</param>
            public DestinyConstantsDestinyEnvironmentLocationMappingBuilder ObjectiveHash(int? value)
            {
                _ObjectiveHash = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyConstantsDestinyEnvironmentLocationMapping.ActivityHash property.
            /// </summary>
            /// <param name="value">If this is populated, this is the activity you have to be playing in order to see this location appear because of this mapping. (theoretically, a location can have multiple mappings, and some might require you to be in a specific activity when others don&#39;t)</param>
            public DestinyConstantsDestinyEnvironmentLocationMappingBuilder ActivityHash(int? value)
            {
                _ActivityHash = value;
                return this;
            }


            /// <summary>
            /// Builds instance of DestinyConstantsDestinyEnvironmentLocationMapping.
            /// </summary>
            /// <returns>DestinyConstantsDestinyEnvironmentLocationMapping</returns>
            public DestinyConstantsDestinyEnvironmentLocationMapping Build()
            {
                Validate();
                return new DestinyConstantsDestinyEnvironmentLocationMapping(
                    LocationHash: _LocationHash,
                    ActivationSource: _ActivationSource,
                    ItemHash: _ItemHash,
                    ObjectiveHash: _ObjectiveHash,
                    ActivityHash: _ActivityHash
                );
            }

            private void Validate()
            { 
            }
        }

        
    }
}