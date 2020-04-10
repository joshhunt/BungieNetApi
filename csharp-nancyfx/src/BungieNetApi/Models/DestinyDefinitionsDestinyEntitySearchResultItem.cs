using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Sharpility.Extensions;
using NodaTime;

namespace BungieNetApi._Platform.Models
{
    /// <summary>
    /// An individual Destiny Entity returned from the entity search.
    /// </summary>
    public sealed class DestinyDefinitionsDestinyEntitySearchResultItem:  IEquatable<DestinyDefinitionsDestinyEntitySearchResultItem>
    { 
        /// <summary>
        /// The hash identifier of the entity. You will use this to look up the DestinyDefinition relevant for the entity found.
        /// </summary>
        public int? Hash { get; private set; }

        /// <summary>
        /// The type of entity, returned as a string matching the DestinyDefinition&#39;s contract class name. You&#39;ll have to have your own mapping from class names to actually looking up those definitions in the manifest databases.
        /// </summary>
        public string EntityType { get; private set; }

        /// <summary>
        /// Basic display properties on the entity, so you don&#39;t have to look up the definition to show basic results for the item.
        /// </summary>
        public DestinyDefinitionsCommonDestinyDisplayPropertiesDefinition DisplayProperties { get; private set; }

        /// <summary>
        /// The ranking value for sorting that we calculated using our relevance formula. This will hopefully get better with time and iteration.
        /// </summary>
        public double? Weight { get; private set; }


        /// <summary>
        /// Empty constructor required by some serializers.
        /// Use DestinyDefinitionsDestinyEntitySearchResultItem.Builder() for instance creation instead.
        /// </summary>
        [Obsolete]
        public DestinyDefinitionsDestinyEntitySearchResultItem()
        {
        }

        private DestinyDefinitionsDestinyEntitySearchResultItem(int? Hash, string EntityType, DestinyDefinitionsCommonDestinyDisplayPropertiesDefinition DisplayProperties, double? Weight)
        {
            
            this.Hash = Hash;
            
            this.EntityType = EntityType;
            
            this.DisplayProperties = DisplayProperties;
            
            this.Weight = Weight;
            
        }

        /// <summary>
        /// Returns builder of DestinyDefinitionsDestinyEntitySearchResultItem.
        /// </summary>
        /// <returns>DestinyDefinitionsDestinyEntitySearchResultItemBuilder</returns>
        public static DestinyDefinitionsDestinyEntitySearchResultItemBuilder Builder()
        {
            return new DestinyDefinitionsDestinyEntitySearchResultItemBuilder();
        }

        /// <summary>
        /// Returns DestinyDefinitionsDestinyEntitySearchResultItemBuilder with properties set.
        /// Use it to change properties.
        /// </summary>
        /// <returns>DestinyDefinitionsDestinyEntitySearchResultItemBuilder</returns>
        public DestinyDefinitionsDestinyEntitySearchResultItemBuilder With()
        {
            return Builder()
                .Hash(Hash)
                .EntityType(EntityType)
                .DisplayProperties(DisplayProperties)
                .Weight(Weight);
        }

        public override string ToString()
        {
            return this.PropertiesToString();
        }

        public override bool Equals(object obj)
        {
            return this.EqualsByProperties(obj);
        }

        public bool Equals(DestinyDefinitionsDestinyEntitySearchResultItem other)
        {
            return Equals((object) other);
        }

        public override int GetHashCode()
        {
            return this.PropertiesHash();
        }

        /// <summary>
        /// Implementation of == operator for (DestinyDefinitionsDestinyEntitySearchResultItem.
        /// </summary>
        /// <param name="left">Compared (DestinyDefinitionsDestinyEntitySearchResultItem</param>
        /// <param name="right">Compared (DestinyDefinitionsDestinyEntitySearchResultItem</param>
        /// <returns>true if compared items are equals, false otherwise</returns>
        public static bool operator == (DestinyDefinitionsDestinyEntitySearchResultItem left, DestinyDefinitionsDestinyEntitySearchResultItem right)
        {
            return Equals(left, right);
        }

        /// <summary>
        /// Implementation of != operator for (DestinyDefinitionsDestinyEntitySearchResultItem.
        /// </summary>
        /// <param name="left">Compared (DestinyDefinitionsDestinyEntitySearchResultItem</param>
        /// <param name="right">Compared (DestinyDefinitionsDestinyEntitySearchResultItem</param>
        /// <returns>true if compared items are not equals, false otherwise</returns>
        public static bool operator != (DestinyDefinitionsDestinyEntitySearchResultItem left, DestinyDefinitionsDestinyEntitySearchResultItem right)
        {
            return !Equals(left, right);
        }

        /// <summary>
        /// Builder of DestinyDefinitionsDestinyEntitySearchResultItem.
        /// </summary>
        public sealed class DestinyDefinitionsDestinyEntitySearchResultItemBuilder
        {
            private int? _Hash;
            private string _EntityType;
            private DestinyDefinitionsCommonDestinyDisplayPropertiesDefinition _DisplayProperties;
            private double? _Weight;

            internal DestinyDefinitionsDestinyEntitySearchResultItemBuilder()
            {
                SetupDefaults();
            }

            private void SetupDefaults()
            {
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsDestinyEntitySearchResultItem.Hash property.
            /// </summary>
            /// <param name="value">The hash identifier of the entity. You will use this to look up the DestinyDefinition relevant for the entity found.</param>
            public DestinyDefinitionsDestinyEntitySearchResultItemBuilder Hash(int? value)
            {
                _Hash = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsDestinyEntitySearchResultItem.EntityType property.
            /// </summary>
            /// <param name="value">The type of entity, returned as a string matching the DestinyDefinition&#39;s contract class name. You&#39;ll have to have your own mapping from class names to actually looking up those definitions in the manifest databases.</param>
            public DestinyDefinitionsDestinyEntitySearchResultItemBuilder EntityType(string value)
            {
                _EntityType = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsDestinyEntitySearchResultItem.DisplayProperties property.
            /// </summary>
            /// <param name="value">Basic display properties on the entity, so you don&#39;t have to look up the definition to show basic results for the item.</param>
            public DestinyDefinitionsDestinyEntitySearchResultItemBuilder DisplayProperties(DestinyDefinitionsCommonDestinyDisplayPropertiesDefinition value)
            {
                _DisplayProperties = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsDestinyEntitySearchResultItem.Weight property.
            /// </summary>
            /// <param name="value">The ranking value for sorting that we calculated using our relevance formula. This will hopefully get better with time and iteration.</param>
            public DestinyDefinitionsDestinyEntitySearchResultItemBuilder Weight(double? value)
            {
                _Weight = value;
                return this;
            }


            /// <summary>
            /// Builds instance of DestinyDefinitionsDestinyEntitySearchResultItem.
            /// </summary>
            /// <returns>DestinyDefinitionsDestinyEntitySearchResultItem</returns>
            public DestinyDefinitionsDestinyEntitySearchResultItem Build()
            {
                Validate();
                return new DestinyDefinitionsDestinyEntitySearchResultItem(
                    Hash: _Hash,
                    EntityType: _EntityType,
                    DisplayProperties: _DisplayProperties,
                    Weight: _Weight
                );
            }

            private void Validate()
            { 
            }
        }

        
    }
}