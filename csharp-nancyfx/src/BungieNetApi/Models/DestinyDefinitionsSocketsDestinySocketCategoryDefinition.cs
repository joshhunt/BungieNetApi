using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Sharpility.Extensions;
using NodaTime;

namespace BungieNetApi._Platform.Models
{
    /// <summary>
    /// Sockets on an item are organized into Categories visually.  You can find references to the socket category defined on an item&#39;s DestinyInventoryItemDefinition.sockets.socketCategories property.  This has the display information for rendering the categories&#39; header, and a hint for how the UI should handle showing this category.  The shitty thing about this, however, is that the socket categories&#39; UI style can be overridden by the item&#39;s UI style. For instance, the Socket Category used by Emote Sockets says it&#39;s \&quot;consumable,\&quot; but that&#39;s a lie: they&#39;re all reusable, and overridden by the detail UI pages in ways that we can&#39;t easily account for in the API.  As a result, I will try to compile these rules into the individual sockets on items, and provide the best hint possible there through the plugSources property. In the future, I may attempt to use this information in conjunction with the item to provide a more usable UI hint on the socket layer, but for now improving the consistency of plugSources is the best I have time to provide. (See https://github.com/Bungie-net/api/issues/522 for more info)
    /// </summary>
    public sealed class DestinyDefinitionsSocketsDestinySocketCategoryDefinition:  IEquatable<DestinyDefinitionsSocketsDestinySocketCategoryDefinition>
    { 
        /// <summary>
        /// DisplayProperties
        /// </summary>
        public DestinyDefinitionsCommonDestinyDisplayPropertiesDefinition DisplayProperties { get; private set; }

        /// <summary>
        /// A string hinting to the game&#39;s UI system about how the sockets in this category should be displayed.  BNet doesn&#39;t use it: it&#39;s up to you to find valid values and make your own special UI if you want to honor this category style.
        /// </summary>
        public int? UiCategoryStyle { get; private set; }

        /// <summary>
        /// Same as uiCategoryStyle, but in a more usable enumeration form.
        /// </summary>
        public int? CategoryStyle { get; private set; }

        /// <summary>
        /// The unique identifier for this entity. Guaranteed to be unique for the type of entity, but not globally.  When entities refer to each other in Destiny content, it is this hash that they are referring to.
        /// </summary>
        public int? Hash { get; private set; }

        /// <summary>
        /// The index of the entity as it was found in the investment tables.
        /// </summary>
        public int? Index { get; private set; }

        /// <summary>
        /// If this is true, then there is an entity with this identifier/type combination, but BNet is not yet allowed to show it. Sorry!
        /// </summary>
        public bool? Redacted { get; private set; }


        /// <summary>
        /// Empty constructor required by some serializers.
        /// Use DestinyDefinitionsSocketsDestinySocketCategoryDefinition.Builder() for instance creation instead.
        /// </summary>
        [Obsolete]
        public DestinyDefinitionsSocketsDestinySocketCategoryDefinition()
        {
        }

        private DestinyDefinitionsSocketsDestinySocketCategoryDefinition(DestinyDefinitionsCommonDestinyDisplayPropertiesDefinition DisplayProperties, int? UiCategoryStyle, int? CategoryStyle, int? Hash, int? Index, bool? Redacted)
        {
            
            this.DisplayProperties = DisplayProperties;
            
            this.UiCategoryStyle = UiCategoryStyle;
            
            this.CategoryStyle = CategoryStyle;
            
            this.Hash = Hash;
            
            this.Index = Index;
            
            this.Redacted = Redacted;
            
        }

        /// <summary>
        /// Returns builder of DestinyDefinitionsSocketsDestinySocketCategoryDefinition.
        /// </summary>
        /// <returns>DestinyDefinitionsSocketsDestinySocketCategoryDefinitionBuilder</returns>
        public static DestinyDefinitionsSocketsDestinySocketCategoryDefinitionBuilder Builder()
        {
            return new DestinyDefinitionsSocketsDestinySocketCategoryDefinitionBuilder();
        }

        /// <summary>
        /// Returns DestinyDefinitionsSocketsDestinySocketCategoryDefinitionBuilder with properties set.
        /// Use it to change properties.
        /// </summary>
        /// <returns>DestinyDefinitionsSocketsDestinySocketCategoryDefinitionBuilder</returns>
        public DestinyDefinitionsSocketsDestinySocketCategoryDefinitionBuilder With()
        {
            return Builder()
                .DisplayProperties(DisplayProperties)
                .UiCategoryStyle(UiCategoryStyle)
                .CategoryStyle(CategoryStyle)
                .Hash(Hash)
                .Index(Index)
                .Redacted(Redacted);
        }

        public override string ToString()
        {
            return this.PropertiesToString();
        }

        public override bool Equals(object obj)
        {
            return this.EqualsByProperties(obj);
        }

        public bool Equals(DestinyDefinitionsSocketsDestinySocketCategoryDefinition other)
        {
            return Equals((object) other);
        }

        public override int GetHashCode()
        {
            return this.PropertiesHash();
        }

        /// <summary>
        /// Implementation of == operator for (DestinyDefinitionsSocketsDestinySocketCategoryDefinition.
        /// </summary>
        /// <param name="left">Compared (DestinyDefinitionsSocketsDestinySocketCategoryDefinition</param>
        /// <param name="right">Compared (DestinyDefinitionsSocketsDestinySocketCategoryDefinition</param>
        /// <returns>true if compared items are equals, false otherwise</returns>
        public static bool operator == (DestinyDefinitionsSocketsDestinySocketCategoryDefinition left, DestinyDefinitionsSocketsDestinySocketCategoryDefinition right)
        {
            return Equals(left, right);
        }

        /// <summary>
        /// Implementation of != operator for (DestinyDefinitionsSocketsDestinySocketCategoryDefinition.
        /// </summary>
        /// <param name="left">Compared (DestinyDefinitionsSocketsDestinySocketCategoryDefinition</param>
        /// <param name="right">Compared (DestinyDefinitionsSocketsDestinySocketCategoryDefinition</param>
        /// <returns>true if compared items are not equals, false otherwise</returns>
        public static bool operator != (DestinyDefinitionsSocketsDestinySocketCategoryDefinition left, DestinyDefinitionsSocketsDestinySocketCategoryDefinition right)
        {
            return !Equals(left, right);
        }

        /// <summary>
        /// Builder of DestinyDefinitionsSocketsDestinySocketCategoryDefinition.
        /// </summary>
        public sealed class DestinyDefinitionsSocketsDestinySocketCategoryDefinitionBuilder
        {
            private DestinyDefinitionsCommonDestinyDisplayPropertiesDefinition _DisplayProperties;
            private int? _UiCategoryStyle;
            private int? _CategoryStyle;
            private int? _Hash;
            private int? _Index;
            private bool? _Redacted;

            internal DestinyDefinitionsSocketsDestinySocketCategoryDefinitionBuilder()
            {
                SetupDefaults();
            }

            private void SetupDefaults()
            {
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsSocketsDestinySocketCategoryDefinition.DisplayProperties property.
            /// </summary>
            /// <param name="value">DisplayProperties</param>
            public DestinyDefinitionsSocketsDestinySocketCategoryDefinitionBuilder DisplayProperties(DestinyDefinitionsCommonDestinyDisplayPropertiesDefinition value)
            {
                _DisplayProperties = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsSocketsDestinySocketCategoryDefinition.UiCategoryStyle property.
            /// </summary>
            /// <param name="value">A string hinting to the game&#39;s UI system about how the sockets in this category should be displayed.  BNet doesn&#39;t use it: it&#39;s up to you to find valid values and make your own special UI if you want to honor this category style.</param>
            public DestinyDefinitionsSocketsDestinySocketCategoryDefinitionBuilder UiCategoryStyle(int? value)
            {
                _UiCategoryStyle = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsSocketsDestinySocketCategoryDefinition.CategoryStyle property.
            /// </summary>
            /// <param name="value">Same as uiCategoryStyle, but in a more usable enumeration form.</param>
            public DestinyDefinitionsSocketsDestinySocketCategoryDefinitionBuilder CategoryStyle(int? value)
            {
                _CategoryStyle = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsSocketsDestinySocketCategoryDefinition.Hash property.
            /// </summary>
            /// <param name="value">The unique identifier for this entity. Guaranteed to be unique for the type of entity, but not globally.  When entities refer to each other in Destiny content, it is this hash that they are referring to.</param>
            public DestinyDefinitionsSocketsDestinySocketCategoryDefinitionBuilder Hash(int? value)
            {
                _Hash = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsSocketsDestinySocketCategoryDefinition.Index property.
            /// </summary>
            /// <param name="value">The index of the entity as it was found in the investment tables.</param>
            public DestinyDefinitionsSocketsDestinySocketCategoryDefinitionBuilder Index(int? value)
            {
                _Index = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsSocketsDestinySocketCategoryDefinition.Redacted property.
            /// </summary>
            /// <param name="value">If this is true, then there is an entity with this identifier/type combination, but BNet is not yet allowed to show it. Sorry!</param>
            public DestinyDefinitionsSocketsDestinySocketCategoryDefinitionBuilder Redacted(bool? value)
            {
                _Redacted = value;
                return this;
            }


            /// <summary>
            /// Builds instance of DestinyDefinitionsSocketsDestinySocketCategoryDefinition.
            /// </summary>
            /// <returns>DestinyDefinitionsSocketsDestinySocketCategoryDefinition</returns>
            public DestinyDefinitionsSocketsDestinySocketCategoryDefinition Build()
            {
                Validate();
                return new DestinyDefinitionsSocketsDestinySocketCategoryDefinition(
                    DisplayProperties: _DisplayProperties,
                    UiCategoryStyle: _UiCategoryStyle,
                    CategoryStyle: _CategoryStyle,
                    Hash: _Hash,
                    Index: _Index,
                    Redacted: _Redacted
                );
            }

            private void Validate()
            { 
            }
        }

        
    }
}