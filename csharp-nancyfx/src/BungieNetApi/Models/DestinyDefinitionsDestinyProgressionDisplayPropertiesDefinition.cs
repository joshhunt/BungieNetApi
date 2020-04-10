using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Sharpility.Extensions;
using NodaTime;

namespace BungieNetApi._Platform.Models
{
    /// <summary>
    /// DestinyDefinitionsDestinyProgressionDisplayPropertiesDefinition
    /// </summary>
    public sealed class DestinyDefinitionsDestinyProgressionDisplayPropertiesDefinition:  IEquatable<DestinyDefinitionsDestinyProgressionDisplayPropertiesDefinition>
    { 
        /// <summary>
        /// When progressions show your \&quot;experience\&quot; gained, that bar has units (i.e. \&quot;Experience\&quot;, \&quot;Bad Dudes Snuffed Out\&quot;, whatever). This is the localized string for that unit of measurement.
        /// </summary>
        public string DisplayUnitsName { get; private set; }

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
        /// Use DestinyDefinitionsDestinyProgressionDisplayPropertiesDefinition.Builder() for instance creation instead.
        /// </summary>
        [Obsolete]
        public DestinyDefinitionsDestinyProgressionDisplayPropertiesDefinition()
        {
        }

        private DestinyDefinitionsDestinyProgressionDisplayPropertiesDefinition(string DisplayUnitsName, string Description, string Name, string Icon, List<DestinyDefinitionsCommonDestinyIconSequenceDefinition> IconSequences, string HighResIcon, bool? HasIcon)
        {
            
            this.DisplayUnitsName = DisplayUnitsName;
            
            this.Description = Description;
            
            this.Name = Name;
            
            this.Icon = Icon;
            
            this.IconSequences = IconSequences;
            
            this.HighResIcon = HighResIcon;
            
            this.HasIcon = HasIcon;
            
        }

        /// <summary>
        /// Returns builder of DestinyDefinitionsDestinyProgressionDisplayPropertiesDefinition.
        /// </summary>
        /// <returns>DestinyDefinitionsDestinyProgressionDisplayPropertiesDefinitionBuilder</returns>
        public static DestinyDefinitionsDestinyProgressionDisplayPropertiesDefinitionBuilder Builder()
        {
            return new DestinyDefinitionsDestinyProgressionDisplayPropertiesDefinitionBuilder();
        }

        /// <summary>
        /// Returns DestinyDefinitionsDestinyProgressionDisplayPropertiesDefinitionBuilder with properties set.
        /// Use it to change properties.
        /// </summary>
        /// <returns>DestinyDefinitionsDestinyProgressionDisplayPropertiesDefinitionBuilder</returns>
        public DestinyDefinitionsDestinyProgressionDisplayPropertiesDefinitionBuilder With()
        {
            return Builder()
                .DisplayUnitsName(DisplayUnitsName)
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

        public bool Equals(DestinyDefinitionsDestinyProgressionDisplayPropertiesDefinition other)
        {
            return Equals((object) other);
        }

        public override int GetHashCode()
        {
            return this.PropertiesHash();
        }

        /// <summary>
        /// Implementation of == operator for (DestinyDefinitionsDestinyProgressionDisplayPropertiesDefinition.
        /// </summary>
        /// <param name="left">Compared (DestinyDefinitionsDestinyProgressionDisplayPropertiesDefinition</param>
        /// <param name="right">Compared (DestinyDefinitionsDestinyProgressionDisplayPropertiesDefinition</param>
        /// <returns>true if compared items are equals, false otherwise</returns>
        public static bool operator == (DestinyDefinitionsDestinyProgressionDisplayPropertiesDefinition left, DestinyDefinitionsDestinyProgressionDisplayPropertiesDefinition right)
        {
            return Equals(left, right);
        }

        /// <summary>
        /// Implementation of != operator for (DestinyDefinitionsDestinyProgressionDisplayPropertiesDefinition.
        /// </summary>
        /// <param name="left">Compared (DestinyDefinitionsDestinyProgressionDisplayPropertiesDefinition</param>
        /// <param name="right">Compared (DestinyDefinitionsDestinyProgressionDisplayPropertiesDefinition</param>
        /// <returns>true if compared items are not equals, false otherwise</returns>
        public static bool operator != (DestinyDefinitionsDestinyProgressionDisplayPropertiesDefinition left, DestinyDefinitionsDestinyProgressionDisplayPropertiesDefinition right)
        {
            return !Equals(left, right);
        }

        /// <summary>
        /// Builder of DestinyDefinitionsDestinyProgressionDisplayPropertiesDefinition.
        /// </summary>
        public sealed class DestinyDefinitionsDestinyProgressionDisplayPropertiesDefinitionBuilder
        {
            private string _DisplayUnitsName;
            private string _Description;
            private string _Name;
            private string _Icon;
            private List<DestinyDefinitionsCommonDestinyIconSequenceDefinition> _IconSequences;
            private string _HighResIcon;
            private bool? _HasIcon;

            internal DestinyDefinitionsDestinyProgressionDisplayPropertiesDefinitionBuilder()
            {
                SetupDefaults();
            }

            private void SetupDefaults()
            {
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsDestinyProgressionDisplayPropertiesDefinition.DisplayUnitsName property.
            /// </summary>
            /// <param name="value">When progressions show your \&quot;experience\&quot; gained, that bar has units (i.e. \&quot;Experience\&quot;, \&quot;Bad Dudes Snuffed Out\&quot;, whatever). This is the localized string for that unit of measurement.</param>
            public DestinyDefinitionsDestinyProgressionDisplayPropertiesDefinitionBuilder DisplayUnitsName(string value)
            {
                _DisplayUnitsName = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsDestinyProgressionDisplayPropertiesDefinition.Description property.
            /// </summary>
            /// <param name="value">Description</param>
            public DestinyDefinitionsDestinyProgressionDisplayPropertiesDefinitionBuilder Description(string value)
            {
                _Description = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsDestinyProgressionDisplayPropertiesDefinition.Name property.
            /// </summary>
            /// <param name="value">Name</param>
            public DestinyDefinitionsDestinyProgressionDisplayPropertiesDefinitionBuilder Name(string value)
            {
                _Name = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsDestinyProgressionDisplayPropertiesDefinition.Icon property.
            /// </summary>
            /// <param name="value">Note that \&quot;icon\&quot; is sometimes misleading, and should be interpreted in the context of the entity. For instance, in Destiny 1 the DestinyRecordBookDefinition&#39;s icon was a big picture of a book.  But usually, it will be a small square image that you can use as... well, an icon.  They are currently represented as 96px x 96px images.</param>
            public DestinyDefinitionsDestinyProgressionDisplayPropertiesDefinitionBuilder Icon(string value)
            {
                _Icon = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsDestinyProgressionDisplayPropertiesDefinition.IconSequences property.
            /// </summary>
            /// <param name="value">IconSequences</param>
            public DestinyDefinitionsDestinyProgressionDisplayPropertiesDefinitionBuilder IconSequences(List<DestinyDefinitionsCommonDestinyIconSequenceDefinition> value)
            {
                _IconSequences = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsDestinyProgressionDisplayPropertiesDefinition.HighResIcon property.
            /// </summary>
            /// <param name="value">If this item has a high-res icon (at least for now, many things won&#39;t), then the path to that icon will be here.</param>
            public DestinyDefinitionsDestinyProgressionDisplayPropertiesDefinitionBuilder HighResIcon(string value)
            {
                _HighResIcon = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsDestinyProgressionDisplayPropertiesDefinition.HasIcon property.
            /// </summary>
            /// <param name="value">HasIcon</param>
            public DestinyDefinitionsDestinyProgressionDisplayPropertiesDefinitionBuilder HasIcon(bool? value)
            {
                _HasIcon = value;
                return this;
            }


            /// <summary>
            /// Builds instance of DestinyDefinitionsDestinyProgressionDisplayPropertiesDefinition.
            /// </summary>
            /// <returns>DestinyDefinitionsDestinyProgressionDisplayPropertiesDefinition</returns>
            public DestinyDefinitionsDestinyProgressionDisplayPropertiesDefinition Build()
            {
                Validate();
                return new DestinyDefinitionsDestinyProgressionDisplayPropertiesDefinition(
                    DisplayUnitsName: _DisplayUnitsName,
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