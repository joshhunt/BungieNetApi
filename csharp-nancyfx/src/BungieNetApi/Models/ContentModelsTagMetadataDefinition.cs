using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Sharpility.Extensions;
using NodaTime;

namespace BungieNetApi._Platform.Models
{
    /// <summary>
    /// ContentModelsTagMetadataDefinition
    /// </summary>
    public sealed class ContentModelsTagMetadataDefinition:  IEquatable<ContentModelsTagMetadataDefinition>
    { 
        /// <summary>
        /// Description
        /// </summary>
        public string Description { get; private set; }

        /// <summary>
        /// Order
        /// </summary>
        public int? Order { get; private set; }

        /// <summary>
        /// Items
        /// </summary>
        public List<ContentModelsTagMetadataItem> Items { get; private set; }

        /// <summary>
        /// Datatype
        /// </summary>
        public string Datatype { get; private set; }

        /// <summary>
        /// Name
        /// </summary>
        public string Name { get; private set; }

        /// <summary>
        /// IsRequired
        /// </summary>
        public bool? IsRequired { get; private set; }


        /// <summary>
        /// Empty constructor required by some serializers.
        /// Use ContentModelsTagMetadataDefinition.Builder() for instance creation instead.
        /// </summary>
        [Obsolete]
        public ContentModelsTagMetadataDefinition()
        {
        }

        private ContentModelsTagMetadataDefinition(string Description, int? Order, List<ContentModelsTagMetadataItem> Items, string Datatype, string Name, bool? IsRequired)
        {
            
            this.Description = Description;
            
            this.Order = Order;
            
            this.Items = Items;
            
            this.Datatype = Datatype;
            
            this.Name = Name;
            
            this.IsRequired = IsRequired;
            
        }

        /// <summary>
        /// Returns builder of ContentModelsTagMetadataDefinition.
        /// </summary>
        /// <returns>ContentModelsTagMetadataDefinitionBuilder</returns>
        public static ContentModelsTagMetadataDefinitionBuilder Builder()
        {
            return new ContentModelsTagMetadataDefinitionBuilder();
        }

        /// <summary>
        /// Returns ContentModelsTagMetadataDefinitionBuilder with properties set.
        /// Use it to change properties.
        /// </summary>
        /// <returns>ContentModelsTagMetadataDefinitionBuilder</returns>
        public ContentModelsTagMetadataDefinitionBuilder With()
        {
            return Builder()
                .Description(Description)
                .Order(Order)
                .Items(Items)
                .Datatype(Datatype)
                .Name(Name)
                .IsRequired(IsRequired);
        }

        public override string ToString()
        {
            return this.PropertiesToString();
        }

        public override bool Equals(object obj)
        {
            return this.EqualsByProperties(obj);
        }

        public bool Equals(ContentModelsTagMetadataDefinition other)
        {
            return Equals((object) other);
        }

        public override int GetHashCode()
        {
            return this.PropertiesHash();
        }

        /// <summary>
        /// Implementation of == operator for (ContentModelsTagMetadataDefinition.
        /// </summary>
        /// <param name="left">Compared (ContentModelsTagMetadataDefinition</param>
        /// <param name="right">Compared (ContentModelsTagMetadataDefinition</param>
        /// <returns>true if compared items are equals, false otherwise</returns>
        public static bool operator == (ContentModelsTagMetadataDefinition left, ContentModelsTagMetadataDefinition right)
        {
            return Equals(left, right);
        }

        /// <summary>
        /// Implementation of != operator for (ContentModelsTagMetadataDefinition.
        /// </summary>
        /// <param name="left">Compared (ContentModelsTagMetadataDefinition</param>
        /// <param name="right">Compared (ContentModelsTagMetadataDefinition</param>
        /// <returns>true if compared items are not equals, false otherwise</returns>
        public static bool operator != (ContentModelsTagMetadataDefinition left, ContentModelsTagMetadataDefinition right)
        {
            return !Equals(left, right);
        }

        /// <summary>
        /// Builder of ContentModelsTagMetadataDefinition.
        /// </summary>
        public sealed class ContentModelsTagMetadataDefinitionBuilder
        {
            private string _Description;
            private int? _Order;
            private List<ContentModelsTagMetadataItem> _Items;
            private string _Datatype;
            private string _Name;
            private bool? _IsRequired;

            internal ContentModelsTagMetadataDefinitionBuilder()
            {
                SetupDefaults();
            }

            private void SetupDefaults()
            {
            }

            /// <summary>
            /// Sets value for ContentModelsTagMetadataDefinition.Description property.
            /// </summary>
            /// <param name="value">Description</param>
            public ContentModelsTagMetadataDefinitionBuilder Description(string value)
            {
                _Description = value;
                return this;
            }

            /// <summary>
            /// Sets value for ContentModelsTagMetadataDefinition.Order property.
            /// </summary>
            /// <param name="value">Order</param>
            public ContentModelsTagMetadataDefinitionBuilder Order(int? value)
            {
                _Order = value;
                return this;
            }

            /// <summary>
            /// Sets value for ContentModelsTagMetadataDefinition.Items property.
            /// </summary>
            /// <param name="value">Items</param>
            public ContentModelsTagMetadataDefinitionBuilder Items(List<ContentModelsTagMetadataItem> value)
            {
                _Items = value;
                return this;
            }

            /// <summary>
            /// Sets value for ContentModelsTagMetadataDefinition.Datatype property.
            /// </summary>
            /// <param name="value">Datatype</param>
            public ContentModelsTagMetadataDefinitionBuilder Datatype(string value)
            {
                _Datatype = value;
                return this;
            }

            /// <summary>
            /// Sets value for ContentModelsTagMetadataDefinition.Name property.
            /// </summary>
            /// <param name="value">Name</param>
            public ContentModelsTagMetadataDefinitionBuilder Name(string value)
            {
                _Name = value;
                return this;
            }

            /// <summary>
            /// Sets value for ContentModelsTagMetadataDefinition.IsRequired property.
            /// </summary>
            /// <param name="value">IsRequired</param>
            public ContentModelsTagMetadataDefinitionBuilder IsRequired(bool? value)
            {
                _IsRequired = value;
                return this;
            }


            /// <summary>
            /// Builds instance of ContentModelsTagMetadataDefinition.
            /// </summary>
            /// <returns>ContentModelsTagMetadataDefinition</returns>
            public ContentModelsTagMetadataDefinition Build()
            {
                Validate();
                return new ContentModelsTagMetadataDefinition(
                    Description: _Description,
                    Order: _Order,
                    Items: _Items,
                    Datatype: _Datatype,
                    Name: _Name,
                    IsRequired: _IsRequired
                );
            }

            private void Validate()
            { 
            }
        }

        
    }
}