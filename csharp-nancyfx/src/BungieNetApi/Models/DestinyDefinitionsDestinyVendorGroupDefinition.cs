using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Sharpility.Extensions;
using NodaTime;

namespace BungieNetApi._Platform.Models
{
    /// <summary>
    /// BNet attempts to group vendors into similar collections. These groups aren&#39;t technically game canonical, but they are helpful for filtering vendors or showing them organized into a clean view on a webpage or app.  These definitions represent the groups we&#39;ve built. Unlike in Destiny 1, a Vendors&#39; group may change dynamically as the game state changes: thus, you will want to check DestinyVendorComponent responses to find a vendor&#39;s currently active Group (if you care).  Using this will let you group your vendors in your UI in a similar manner to how we will do grouping in the Companion.
    /// </summary>
    public sealed class DestinyDefinitionsDestinyVendorGroupDefinition:  IEquatable<DestinyDefinitionsDestinyVendorGroupDefinition>
    { 
        /// <summary>
        /// The recommended order in which to render the groups, Ascending order.
        /// </summary>
        public int? Order { get; private set; }

        /// <summary>
        /// For now, a group just has a name.
        /// </summary>
        public string CategoryName { get; private set; }

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
        /// Use DestinyDefinitionsDestinyVendorGroupDefinition.Builder() for instance creation instead.
        /// </summary>
        [Obsolete]
        public DestinyDefinitionsDestinyVendorGroupDefinition()
        {
        }

        private DestinyDefinitionsDestinyVendorGroupDefinition(int? Order, string CategoryName, int? Hash, int? Index, bool? Redacted)
        {
            
            this.Order = Order;
            
            this.CategoryName = CategoryName;
            
            this.Hash = Hash;
            
            this.Index = Index;
            
            this.Redacted = Redacted;
            
        }

        /// <summary>
        /// Returns builder of DestinyDefinitionsDestinyVendorGroupDefinition.
        /// </summary>
        /// <returns>DestinyDefinitionsDestinyVendorGroupDefinitionBuilder</returns>
        public static DestinyDefinitionsDestinyVendorGroupDefinitionBuilder Builder()
        {
            return new DestinyDefinitionsDestinyVendorGroupDefinitionBuilder();
        }

        /// <summary>
        /// Returns DestinyDefinitionsDestinyVendorGroupDefinitionBuilder with properties set.
        /// Use it to change properties.
        /// </summary>
        /// <returns>DestinyDefinitionsDestinyVendorGroupDefinitionBuilder</returns>
        public DestinyDefinitionsDestinyVendorGroupDefinitionBuilder With()
        {
            return Builder()
                .Order(Order)
                .CategoryName(CategoryName)
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

        public bool Equals(DestinyDefinitionsDestinyVendorGroupDefinition other)
        {
            return Equals((object) other);
        }

        public override int GetHashCode()
        {
            return this.PropertiesHash();
        }

        /// <summary>
        /// Implementation of == operator for (DestinyDefinitionsDestinyVendorGroupDefinition.
        /// </summary>
        /// <param name="left">Compared (DestinyDefinitionsDestinyVendorGroupDefinition</param>
        /// <param name="right">Compared (DestinyDefinitionsDestinyVendorGroupDefinition</param>
        /// <returns>true if compared items are equals, false otherwise</returns>
        public static bool operator == (DestinyDefinitionsDestinyVendorGroupDefinition left, DestinyDefinitionsDestinyVendorGroupDefinition right)
        {
            return Equals(left, right);
        }

        /// <summary>
        /// Implementation of != operator for (DestinyDefinitionsDestinyVendorGroupDefinition.
        /// </summary>
        /// <param name="left">Compared (DestinyDefinitionsDestinyVendorGroupDefinition</param>
        /// <param name="right">Compared (DestinyDefinitionsDestinyVendorGroupDefinition</param>
        /// <returns>true if compared items are not equals, false otherwise</returns>
        public static bool operator != (DestinyDefinitionsDestinyVendorGroupDefinition left, DestinyDefinitionsDestinyVendorGroupDefinition right)
        {
            return !Equals(left, right);
        }

        /// <summary>
        /// Builder of DestinyDefinitionsDestinyVendorGroupDefinition.
        /// </summary>
        public sealed class DestinyDefinitionsDestinyVendorGroupDefinitionBuilder
        {
            private int? _Order;
            private string _CategoryName;
            private int? _Hash;
            private int? _Index;
            private bool? _Redacted;

            internal DestinyDefinitionsDestinyVendorGroupDefinitionBuilder()
            {
                SetupDefaults();
            }

            private void SetupDefaults()
            {
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsDestinyVendorGroupDefinition.Order property.
            /// </summary>
            /// <param name="value">The recommended order in which to render the groups, Ascending order.</param>
            public DestinyDefinitionsDestinyVendorGroupDefinitionBuilder Order(int? value)
            {
                _Order = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsDestinyVendorGroupDefinition.CategoryName property.
            /// </summary>
            /// <param name="value">For now, a group just has a name.</param>
            public DestinyDefinitionsDestinyVendorGroupDefinitionBuilder CategoryName(string value)
            {
                _CategoryName = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsDestinyVendorGroupDefinition.Hash property.
            /// </summary>
            /// <param name="value">The unique identifier for this entity. Guaranteed to be unique for the type of entity, but not globally.  When entities refer to each other in Destiny content, it is this hash that they are referring to.</param>
            public DestinyDefinitionsDestinyVendorGroupDefinitionBuilder Hash(int? value)
            {
                _Hash = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsDestinyVendorGroupDefinition.Index property.
            /// </summary>
            /// <param name="value">The index of the entity as it was found in the investment tables.</param>
            public DestinyDefinitionsDestinyVendorGroupDefinitionBuilder Index(int? value)
            {
                _Index = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsDestinyVendorGroupDefinition.Redacted property.
            /// </summary>
            /// <param name="value">If this is true, then there is an entity with this identifier/type combination, but BNet is not yet allowed to show it. Sorry!</param>
            public DestinyDefinitionsDestinyVendorGroupDefinitionBuilder Redacted(bool? value)
            {
                _Redacted = value;
                return this;
            }


            /// <summary>
            /// Builds instance of DestinyDefinitionsDestinyVendorGroupDefinition.
            /// </summary>
            /// <returns>DestinyDefinitionsDestinyVendorGroupDefinition</returns>
            public DestinyDefinitionsDestinyVendorGroupDefinition Build()
            {
                Validate();
                return new DestinyDefinitionsDestinyVendorGroupDefinition(
                    Order: _Order,
                    CategoryName: _CategoryName,
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