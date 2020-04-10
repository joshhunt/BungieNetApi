using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Sharpility.Extensions;
using NodaTime;

namespace BungieNetApi._Platform.Models
{
    /// <summary>
    /// DestinyArtifactsDestinyArtifactTierItem
    /// </summary>
    public sealed class DestinyArtifactsDestinyArtifactTierItem:  IEquatable<DestinyArtifactsDestinyArtifactTierItem>
    { 
        /// <summary>
        /// ItemHash
        /// </summary>
        public int? ItemHash { get; private set; }

        /// <summary>
        /// IsActive
        /// </summary>
        public bool? IsActive { get; private set; }


        /// <summary>
        /// Empty constructor required by some serializers.
        /// Use DestinyArtifactsDestinyArtifactTierItem.Builder() for instance creation instead.
        /// </summary>
        [Obsolete]
        public DestinyArtifactsDestinyArtifactTierItem()
        {
        }

        private DestinyArtifactsDestinyArtifactTierItem(int? ItemHash, bool? IsActive)
        {
            
            this.ItemHash = ItemHash;
            
            this.IsActive = IsActive;
            
        }

        /// <summary>
        /// Returns builder of DestinyArtifactsDestinyArtifactTierItem.
        /// </summary>
        /// <returns>DestinyArtifactsDestinyArtifactTierItemBuilder</returns>
        public static DestinyArtifactsDestinyArtifactTierItemBuilder Builder()
        {
            return new DestinyArtifactsDestinyArtifactTierItemBuilder();
        }

        /// <summary>
        /// Returns DestinyArtifactsDestinyArtifactTierItemBuilder with properties set.
        /// Use it to change properties.
        /// </summary>
        /// <returns>DestinyArtifactsDestinyArtifactTierItemBuilder</returns>
        public DestinyArtifactsDestinyArtifactTierItemBuilder With()
        {
            return Builder()
                .ItemHash(ItemHash)
                .IsActive(IsActive);
        }

        public override string ToString()
        {
            return this.PropertiesToString();
        }

        public override bool Equals(object obj)
        {
            return this.EqualsByProperties(obj);
        }

        public bool Equals(DestinyArtifactsDestinyArtifactTierItem other)
        {
            return Equals((object) other);
        }

        public override int GetHashCode()
        {
            return this.PropertiesHash();
        }

        /// <summary>
        /// Implementation of == operator for (DestinyArtifactsDestinyArtifactTierItem.
        /// </summary>
        /// <param name="left">Compared (DestinyArtifactsDestinyArtifactTierItem</param>
        /// <param name="right">Compared (DestinyArtifactsDestinyArtifactTierItem</param>
        /// <returns>true if compared items are equals, false otherwise</returns>
        public static bool operator == (DestinyArtifactsDestinyArtifactTierItem left, DestinyArtifactsDestinyArtifactTierItem right)
        {
            return Equals(left, right);
        }

        /// <summary>
        /// Implementation of != operator for (DestinyArtifactsDestinyArtifactTierItem.
        /// </summary>
        /// <param name="left">Compared (DestinyArtifactsDestinyArtifactTierItem</param>
        /// <param name="right">Compared (DestinyArtifactsDestinyArtifactTierItem</param>
        /// <returns>true if compared items are not equals, false otherwise</returns>
        public static bool operator != (DestinyArtifactsDestinyArtifactTierItem left, DestinyArtifactsDestinyArtifactTierItem right)
        {
            return !Equals(left, right);
        }

        /// <summary>
        /// Builder of DestinyArtifactsDestinyArtifactTierItem.
        /// </summary>
        public sealed class DestinyArtifactsDestinyArtifactTierItemBuilder
        {
            private int? _ItemHash;
            private bool? _IsActive;

            internal DestinyArtifactsDestinyArtifactTierItemBuilder()
            {
                SetupDefaults();
            }

            private void SetupDefaults()
            {
            }

            /// <summary>
            /// Sets value for DestinyArtifactsDestinyArtifactTierItem.ItemHash property.
            /// </summary>
            /// <param name="value">ItemHash</param>
            public DestinyArtifactsDestinyArtifactTierItemBuilder ItemHash(int? value)
            {
                _ItemHash = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyArtifactsDestinyArtifactTierItem.IsActive property.
            /// </summary>
            /// <param name="value">IsActive</param>
            public DestinyArtifactsDestinyArtifactTierItemBuilder IsActive(bool? value)
            {
                _IsActive = value;
                return this;
            }


            /// <summary>
            /// Builds instance of DestinyArtifactsDestinyArtifactTierItem.
            /// </summary>
            /// <returns>DestinyArtifactsDestinyArtifactTierItem</returns>
            public DestinyArtifactsDestinyArtifactTierItem Build()
            {
                Validate();
                return new DestinyArtifactsDestinyArtifactTierItem(
                    ItemHash: _ItemHash,
                    IsActive: _IsActive
                );
            }

            private void Validate()
            { 
            }
        }

        
    }
}