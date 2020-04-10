using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Sharpility.Extensions;
using NodaTime;

namespace BungieNetApi._Platform.Models
{
    /// <summary>
    /// Many items can be rendered in 3D. When you request this block, you will obtain the custom data needed to render this specific instance of the item.
    /// </summary>
    public sealed class DestinyEntitiesItemsDestinyItemRenderComponent:  IEquatable<DestinyEntitiesItemsDestinyItemRenderComponent>
    { 
        /// <summary>
        /// If you should use custom dyes on this item, it will be indicated here.
        /// </summary>
        public bool? UseCustomDyes { get; private set; }

        /// <summary>
        /// A dictionary for rendering gear components, with:  key &#x3D; Art Arrangement Region Index  value &#x3D; The chosen Arrangement Index for the Region, based on the value of a stat on the item used for making the choice.
        /// </summary>
        public Dictionary<string, int?> ArtRegions { get; private set; }


        /// <summary>
        /// Empty constructor required by some serializers.
        /// Use DestinyEntitiesItemsDestinyItemRenderComponent.Builder() for instance creation instead.
        /// </summary>
        [Obsolete]
        public DestinyEntitiesItemsDestinyItemRenderComponent()
        {
        }

        private DestinyEntitiesItemsDestinyItemRenderComponent(bool? UseCustomDyes, Dictionary<string, int?> ArtRegions)
        {
            
            this.UseCustomDyes = UseCustomDyes;
            
            this.ArtRegions = ArtRegions;
            
        }

        /// <summary>
        /// Returns builder of DestinyEntitiesItemsDestinyItemRenderComponent.
        /// </summary>
        /// <returns>DestinyEntitiesItemsDestinyItemRenderComponentBuilder</returns>
        public static DestinyEntitiesItemsDestinyItemRenderComponentBuilder Builder()
        {
            return new DestinyEntitiesItemsDestinyItemRenderComponentBuilder();
        }

        /// <summary>
        /// Returns DestinyEntitiesItemsDestinyItemRenderComponentBuilder with properties set.
        /// Use it to change properties.
        /// </summary>
        /// <returns>DestinyEntitiesItemsDestinyItemRenderComponentBuilder</returns>
        public DestinyEntitiesItemsDestinyItemRenderComponentBuilder With()
        {
            return Builder()
                .UseCustomDyes(UseCustomDyes)
                .ArtRegions(ArtRegions);
        }

        public override string ToString()
        {
            return this.PropertiesToString();
        }

        public override bool Equals(object obj)
        {
            return this.EqualsByProperties(obj);
        }

        public bool Equals(DestinyEntitiesItemsDestinyItemRenderComponent other)
        {
            return Equals((object) other);
        }

        public override int GetHashCode()
        {
            return this.PropertiesHash();
        }

        /// <summary>
        /// Implementation of == operator for (DestinyEntitiesItemsDestinyItemRenderComponent.
        /// </summary>
        /// <param name="left">Compared (DestinyEntitiesItemsDestinyItemRenderComponent</param>
        /// <param name="right">Compared (DestinyEntitiesItemsDestinyItemRenderComponent</param>
        /// <returns>true if compared items are equals, false otherwise</returns>
        public static bool operator == (DestinyEntitiesItemsDestinyItemRenderComponent left, DestinyEntitiesItemsDestinyItemRenderComponent right)
        {
            return Equals(left, right);
        }

        /// <summary>
        /// Implementation of != operator for (DestinyEntitiesItemsDestinyItemRenderComponent.
        /// </summary>
        /// <param name="left">Compared (DestinyEntitiesItemsDestinyItemRenderComponent</param>
        /// <param name="right">Compared (DestinyEntitiesItemsDestinyItemRenderComponent</param>
        /// <returns>true if compared items are not equals, false otherwise</returns>
        public static bool operator != (DestinyEntitiesItemsDestinyItemRenderComponent left, DestinyEntitiesItemsDestinyItemRenderComponent right)
        {
            return !Equals(left, right);
        }

        /// <summary>
        /// Builder of DestinyEntitiesItemsDestinyItemRenderComponent.
        /// </summary>
        public sealed class DestinyEntitiesItemsDestinyItemRenderComponentBuilder
        {
            private bool? _UseCustomDyes;
            private Dictionary<string, int?> _ArtRegions;

            internal DestinyEntitiesItemsDestinyItemRenderComponentBuilder()
            {
                SetupDefaults();
            }

            private void SetupDefaults()
            {
            }

            /// <summary>
            /// Sets value for DestinyEntitiesItemsDestinyItemRenderComponent.UseCustomDyes property.
            /// </summary>
            /// <param name="value">If you should use custom dyes on this item, it will be indicated here.</param>
            public DestinyEntitiesItemsDestinyItemRenderComponentBuilder UseCustomDyes(bool? value)
            {
                _UseCustomDyes = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyEntitiesItemsDestinyItemRenderComponent.ArtRegions property.
            /// </summary>
            /// <param name="value">A dictionary for rendering gear components, with:  key &#x3D; Art Arrangement Region Index  value &#x3D; The chosen Arrangement Index for the Region, based on the value of a stat on the item used for making the choice.</param>
            public DestinyEntitiesItemsDestinyItemRenderComponentBuilder ArtRegions(Dictionary<string, int?> value)
            {
                _ArtRegions = value;
                return this;
            }


            /// <summary>
            /// Builds instance of DestinyEntitiesItemsDestinyItemRenderComponent.
            /// </summary>
            /// <returns>DestinyEntitiesItemsDestinyItemRenderComponent</returns>
            public DestinyEntitiesItemsDestinyItemRenderComponent Build()
            {
                Validate();
                return new DestinyEntitiesItemsDestinyItemRenderComponent(
                    UseCustomDyes: _UseCustomDyes,
                    ArtRegions: _ArtRegions
                );
            }

            private void Validate()
            { 
            }
        }

        
    }
}