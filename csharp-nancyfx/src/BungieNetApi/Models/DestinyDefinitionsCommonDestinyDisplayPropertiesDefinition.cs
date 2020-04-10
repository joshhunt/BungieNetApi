using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Sharpility.Extensions;
using NodaTime;

namespace BungieNetApi._Platform.Models
{
    /// <summary>
    /// Many Destiny*Definition contracts - the \&quot;first order\&quot; entities of Destiny that have their own tables in the Manifest Database - also have displayable information. This is the base class for that display information.
    /// </summary>
    public sealed class DestinyDefinitionsCommonDestinyDisplayPropertiesDefinition:  IEquatable<DestinyDefinitionsCommonDestinyDisplayPropertiesDefinition>
    { 
        /// <summary>
        /// Description
        /// </summary>
        public string Description { get; private set; }

        /// <summary>
        /// Name
        /// </summary>
        public string Name { get; private set; }

        /// <summary>
        /// Note that \&quot;icon\&quot; is sometimes misleading, and should be interpreted in the context of the entity. For instance, in Destiny 1 the DestinyRecordBookDefinition&#39;s icon was a big picture of a book.  But usually, it will be a small square image that you can use as... well, an icon.  They are currently represented as 96px x 96px images.
        /// </summary>
        public string Icon { get; private set; }

        /// <summary>
        /// IconSequences
        /// </summary>
        public List<DestinyDefinitionsCommonDestinyIconSequenceDefinition> IconSequences { get; private set; }

        /// <summary>
        /// If this item has a high-res icon (at least for now, many things won&#39;t), then the path to that icon will be here.
        /// </summary>
        public string HighResIcon { get; private set; }

        /// <summary>
        /// HasIcon
        /// </summary>
        public bool? HasIcon { get; private set; }


        /// <summary>
        /// Empty constructor required by some serializers.
        /// Use DestinyDefinitionsCommonDestinyDisplayPropertiesDefinition.Builder() for instance creation instead.
        /// </summary>
        [Obsolete]
        public DestinyDefinitionsCommonDestinyDisplayPropertiesDefinition()
        {
        }

        private DestinyDefinitionsCommonDestinyDisplayPropertiesDefinition(string Description, string Name, string Icon, List<DestinyDefinitionsCommonDestinyIconSequenceDefinition> IconSequences, string HighResIcon, bool? HasIcon)
        {
            
            this.Description = Description;
            
            this.Name = Name;
            
            this.Icon = Icon;
            
            this.IconSequences = IconSequences;
            
            this.HighResIcon = HighResIcon;
            
            this.HasIcon = HasIcon;
            
        }

        /// <summary>
        /// Returns builder of DestinyDefinitionsCommonDestinyDisplayPropertiesDefinition.
        /// </summary>
        /// <returns>DestinyDefinitionsCommonDestinyDisplayPropertiesDefinitionBuilder</returns>
        public static DestinyDefinitionsCommonDestinyDisplayPropertiesDefinitionBuilder Builder()
        {
            return new DestinyDefinitionsCommonDestinyDisplayPropertiesDefinitionBuilder();
        }

        /// <summary>
        /// Returns DestinyDefinitionsCommonDestinyDisplayPropertiesDefinitionBuilder with properties set.
        /// Use it to change properties.
        /// </summary>
        /// <returns>DestinyDefinitionsCommonDestinyDisplayPropertiesDefinitionBuilder</returns>
        public DestinyDefinitionsCommonDestinyDisplayPropertiesDefinitionBuilder With()
        {
            return Builder()
                .Description(Description)
                .Name(Name)
                .Icon(Icon)
                .IconSequences(IconSequences)
                .HighResIcon(HighResIcon)
                .HasIcon(HasIcon);
        }

        public override string ToString()
        {
            return this.PropertiesToString();
        }

        public override bool Equals(object obj)
        {
            return this.EqualsByProperties(obj);
        }

        public bool Equals(DestinyDefinitionsCommonDestinyDisplayPropertiesDefinition other)
        {
            return Equals((object) other);
        }

        public override int GetHashCode()
        {
            return this.PropertiesHash();
        }

        /// <summary>
        /// Implementation of == operator for (DestinyDefinitionsCommonDestinyDisplayPropertiesDefinition.
        /// </summary>
        /// <param name="left">Compared (DestinyDefinitionsCommonDestinyDisplayPropertiesDefinition</param>
        /// <param name="right">Compared (DestinyDefinitionsCommonDestinyDisplayPropertiesDefinition</param>
        /// <returns>true if compared items are equals, false otherwise</returns>
        public static bool operator == (DestinyDefinitionsCommonDestinyDisplayPropertiesDefinition left, DestinyDefinitionsCommonDestinyDisplayPropertiesDefinition right)
        {
            return Equals(left, right);
        }

        /// <summary>
        /// Implementation of != operator for (DestinyDefinitionsCommonDestinyDisplayPropertiesDefinition.
        /// </summary>
        /// <param name="left">Compared (DestinyDefinitionsCommonDestinyDisplayPropertiesDefinition</param>
        /// <param name="right">Compared (DestinyDefinitionsCommonDestinyDisplayPropertiesDefinition</param>
        /// <returns>true if compared items are not equals, false otherwise</returns>
        public static bool operator != (DestinyDefinitionsCommonDestinyDisplayPropertiesDefinition left, DestinyDefinitionsCommonDestinyDisplayPropertiesDefinition right)
        {
            return !Equals(left, right);
        }

        /// <summary>
        /// Builder of DestinyDefinitionsCommonDestinyDisplayPropertiesDefinition.
        /// </summary>
        public sealed class DestinyDefinitionsCommonDestinyDisplayPropertiesDefinitionBuilder
        {
            private string _Description;
            private string _Name;
            private string _Icon;
            private List<DestinyDefinitionsCommonDestinyIconSequenceDefinition> _IconSequences;
            private string _HighResIcon;
            private bool? _HasIcon;

            internal DestinyDefinitionsCommonDestinyDisplayPropertiesDefinitionBuilder()
            {
                SetupDefaults();
            }

            private void SetupDefaults()
            {
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsCommonDestinyDisplayPropertiesDefinition.Description property.
            /// </summary>
            /// <param name="value">Description</param>
            public DestinyDefinitionsCommonDestinyDisplayPropertiesDefinitionBuilder Description(string value)
            {
                _Description = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsCommonDestinyDisplayPropertiesDefinition.Name property.
            /// </summary>
            /// <param name="value">Name</param>
            public DestinyDefinitionsCommonDestinyDisplayPropertiesDefinitionBuilder Name(string value)
            {
                _Name = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsCommonDestinyDisplayPropertiesDefinition.Icon property.
            /// </summary>
            /// <param name="value">Note that \&quot;icon\&quot; is sometimes misleading, and should be interpreted in the context of the entity. For instance, in Destiny 1 the DestinyRecordBookDefinition&#39;s icon was a big picture of a book.  But usually, it will be a small square image that you can use as... well, an icon.  They are currently represented as 96px x 96px images.</param>
            public DestinyDefinitionsCommonDestinyDisplayPropertiesDefinitionBuilder Icon(string value)
            {
                _Icon = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsCommonDestinyDisplayPropertiesDefinition.IconSequences property.
            /// </summary>
            /// <param name="value">IconSequences</param>
            public DestinyDefinitionsCommonDestinyDisplayPropertiesDefinitionBuilder IconSequences(List<DestinyDefinitionsCommonDestinyIconSequenceDefinition> value)
            {
                _IconSequences = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsCommonDestinyDisplayPropertiesDefinition.HighResIcon property.
            /// </summary>
            /// <param name="value">If this item has a high-res icon (at least for now, many things won&#39;t), then the path to that icon will be here.</param>
            public DestinyDefinitionsCommonDestinyDisplayPropertiesDefinitionBuilder HighResIcon(string value)
            {
                _HighResIcon = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsCommonDestinyDisplayPropertiesDefinition.HasIcon property.
            /// </summary>
            /// <param name="value">HasIcon</param>
            public DestinyDefinitionsCommonDestinyDisplayPropertiesDefinitionBuilder HasIcon(bool? value)
            {
                _HasIcon = value;
                return this;
            }


            /// <summary>
            /// Builds instance of DestinyDefinitionsCommonDestinyDisplayPropertiesDefinition.
            /// </summary>
            /// <returns>DestinyDefinitionsCommonDestinyDisplayPropertiesDefinition</returns>
            public DestinyDefinitionsCommonDestinyDisplayPropertiesDefinition Build()
            {
                Validate();
                return new DestinyDefinitionsCommonDestinyDisplayPropertiesDefinition(
                    Description: _Description,
                    Name: _Name,
                    Icon: _Icon,
                    IconSequences: _IconSequences,
                    HighResIcon: _HighResIcon,
                    HasIcon: _HasIcon
                );
            }

            private void Validate()
            { 
            }
        }

        
    }
}