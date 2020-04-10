using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Sharpility.Extensions;
using NodaTime;

namespace BungieNetApi._Platform.Models
{
    /// <summary>
    /// DestinyDefinitionsDestinyVendorDisplayPropertiesDefinition
    /// </summary>
    public sealed class DestinyDefinitionsDestinyVendorDisplayPropertiesDefinition:  IEquatable<DestinyDefinitionsDestinyVendorDisplayPropertiesDefinition>
    { 
        /// <summary>
        /// I regret calling this a \&quot;large icon\&quot;. It&#39;s more like a medium-sized image with a picture of the vendor&#39;s mug on it, trying their best to look cool. Not what one would call an icon.
        /// </summary>
        public string LargeIcon { get; private set; }

        /// <summary>
        /// Subtitle
        /// </summary>
        public string Subtitle { get; private set; }

        /// <summary>
        /// If we replaced the icon with something more glitzy, this is the original icon that the vendor had according to the game&#39;s content. It may be more lame and/or have less razzle-dazzle. But who am I to tell you which icon to use.
        /// </summary>
        public string OriginalIcon { get; private set; }

        /// <summary>
        /// Vendors, in addition to expected display property data, may also show some \&quot;common requirements\&quot; as statically defined definition data. This might be when a vendor accepts a single type of currency, or when the currency is unique to the vendor and the designers wanted to show that currency when you interact with the vendor.
        /// </summary>
        public List<DestinyDefinitionsDestinyVendorRequirementDisplayEntryDefinition> RequirementsDisplay { get; private set; }

        /// <summary>
        /// This is the icon used in parts of the game UI such as the vendor&#39;s waypoint.
        /// </summary>
        public string SmallTransparentIcon { get; private set; }

        /// <summary>
        /// This is the icon used in the map overview, when the vendor is located on the map.
        /// </summary>
        public string MapIcon { get; private set; }

        /// <summary>
        /// This is apparently the \&quot;Watermark\&quot;. I am not certain offhand where this is actually used in the Game UI, but some people may find it useful.
        /// </summary>
        public string LargeTransparentIcon { get; private set; }

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
        /// Use DestinyDefinitionsDestinyVendorDisplayPropertiesDefinition.Builder() for instance creation instead.
        /// </summary>
        [Obsolete]
        public DestinyDefinitionsDestinyVendorDisplayPropertiesDefinition()
        {
        }

        private DestinyDefinitionsDestinyVendorDisplayPropertiesDefinition(string LargeIcon, string Subtitle, string OriginalIcon, List<DestinyDefinitionsDestinyVendorRequirementDisplayEntryDefinition> RequirementsDisplay, string SmallTransparentIcon, string MapIcon, string LargeTransparentIcon, string Description, string Name, string Icon, List<DestinyDefinitionsCommonDestinyIconSequenceDefinition> IconSequences, string HighResIcon, bool? HasIcon)
        {
            
            this.LargeIcon = LargeIcon;
            
            this.Subtitle = Subtitle;
            
            this.OriginalIcon = OriginalIcon;
            
            this.RequirementsDisplay = RequirementsDisplay;
            
            this.SmallTransparentIcon = SmallTransparentIcon;
            
            this.MapIcon = MapIcon;
            
            this.LargeTransparentIcon = LargeTransparentIcon;
            
            this.Description = Description;
            
            this.Name = Name;
            
            this.Icon = Icon;
            
            this.IconSequences = IconSequences;
            
            this.HighResIcon = HighResIcon;
            
            this.HasIcon = HasIcon;
            
        }

        /// <summary>
        /// Returns builder of DestinyDefinitionsDestinyVendorDisplayPropertiesDefinition.
        /// </summary>
        /// <returns>DestinyDefinitionsDestinyVendorDisplayPropertiesDefinitionBuilder</returns>
        public static DestinyDefinitionsDestinyVendorDisplayPropertiesDefinitionBuilder Builder()
        {
            return new DestinyDefinitionsDestinyVendorDisplayPropertiesDefinitionBuilder();
        }

        /// <summary>
        /// Returns DestinyDefinitionsDestinyVendorDisplayPropertiesDefinitionBuilder with properties set.
        /// Use it to change properties.
        /// </summary>
        /// <returns>DestinyDefinitionsDestinyVendorDisplayPropertiesDefinitionBuilder</returns>
        public DestinyDefinitionsDestinyVendorDisplayPropertiesDefinitionBuilder With()
        {
            return Builder()
                .LargeIcon(LargeIcon)
                .Subtitle(Subtitle)
                .OriginalIcon(OriginalIcon)
                .RequirementsDisplay(RequirementsDisplay)
                .SmallTransparentIcon(SmallTransparentIcon)
                .MapIcon(MapIcon)
                .LargeTransparentIcon(LargeTransparentIcon)
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

        public bool Equals(DestinyDefinitionsDestinyVendorDisplayPropertiesDefinition other)
        {
            return Equals((object) other);
        }

        public override int GetHashCode()
        {
            return this.PropertiesHash();
        }

        /// <summary>
        /// Implementation of == operator for (DestinyDefinitionsDestinyVendorDisplayPropertiesDefinition.
        /// </summary>
        /// <param name="left">Compared (DestinyDefinitionsDestinyVendorDisplayPropertiesDefinition</param>
        /// <param name="right">Compared (DestinyDefinitionsDestinyVendorDisplayPropertiesDefinition</param>
        /// <returns>true if compared items are equals, false otherwise</returns>
        public static bool operator == (DestinyDefinitionsDestinyVendorDisplayPropertiesDefinition left, DestinyDefinitionsDestinyVendorDisplayPropertiesDefinition right)
        {
            return Equals(left, right);
        }

        /// <summary>
        /// Implementation of != operator for (DestinyDefinitionsDestinyVendorDisplayPropertiesDefinition.
        /// </summary>
        /// <param name="left">Compared (DestinyDefinitionsDestinyVendorDisplayPropertiesDefinition</param>
        /// <param name="right">Compared (DestinyDefinitionsDestinyVendorDisplayPropertiesDefinition</param>
        /// <returns>true if compared items are not equals, false otherwise</returns>
        public static bool operator != (DestinyDefinitionsDestinyVendorDisplayPropertiesDefinition left, DestinyDefinitionsDestinyVendorDisplayPropertiesDefinition right)
        {
            return !Equals(left, right);
        }

        /// <summary>
        /// Builder of DestinyDefinitionsDestinyVendorDisplayPropertiesDefinition.
        /// </summary>
        public sealed class DestinyDefinitionsDestinyVendorDisplayPropertiesDefinitionBuilder
        {
            private string _LargeIcon;
            private string _Subtitle;
            private string _OriginalIcon;
            private List<DestinyDefinitionsDestinyVendorRequirementDisplayEntryDefinition> _RequirementsDisplay;
            private string _SmallTransparentIcon;
            private string _MapIcon;
            private string _LargeTransparentIcon;
            private string _Description;
            private string _Name;
            private string _Icon;
            private List<DestinyDefinitionsCommonDestinyIconSequenceDefinition> _IconSequences;
            private string _HighResIcon;
            private bool? _HasIcon;

            internal DestinyDefinitionsDestinyVendorDisplayPropertiesDefinitionBuilder()
            {
                SetupDefaults();
            }

            private void SetupDefaults()
            {
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsDestinyVendorDisplayPropertiesDefinition.LargeIcon property.
            /// </summary>
            /// <param name="value">I regret calling this a \&quot;large icon\&quot;. It&#39;s more like a medium-sized image with a picture of the vendor&#39;s mug on it, trying their best to look cool. Not what one would call an icon.</param>
            public DestinyDefinitionsDestinyVendorDisplayPropertiesDefinitionBuilder LargeIcon(string value)
            {
                _LargeIcon = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsDestinyVendorDisplayPropertiesDefinition.Subtitle property.
            /// </summary>
            /// <param name="value">Subtitle</param>
            public DestinyDefinitionsDestinyVendorDisplayPropertiesDefinitionBuilder Subtitle(string value)
            {
                _Subtitle = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsDestinyVendorDisplayPropertiesDefinition.OriginalIcon property.
            /// </summary>
            /// <param name="value">If we replaced the icon with something more glitzy, this is the original icon that the vendor had according to the game&#39;s content. It may be more lame and/or have less razzle-dazzle. But who am I to tell you which icon to use.</param>
            public DestinyDefinitionsDestinyVendorDisplayPropertiesDefinitionBuilder OriginalIcon(string value)
            {
                _OriginalIcon = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsDestinyVendorDisplayPropertiesDefinition.RequirementsDisplay property.
            /// </summary>
            /// <param name="value">Vendors, in addition to expected display property data, may also show some \&quot;common requirements\&quot; as statically defined definition data. This might be when a vendor accepts a single type of currency, or when the currency is unique to the vendor and the designers wanted to show that currency when you interact with the vendor.</param>
            public DestinyDefinitionsDestinyVendorDisplayPropertiesDefinitionBuilder RequirementsDisplay(List<DestinyDefinitionsDestinyVendorRequirementDisplayEntryDefinition> value)
            {
                _RequirementsDisplay = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsDestinyVendorDisplayPropertiesDefinition.SmallTransparentIcon property.
            /// </summary>
            /// <param name="value">This is the icon used in parts of the game UI such as the vendor&#39;s waypoint.</param>
            public DestinyDefinitionsDestinyVendorDisplayPropertiesDefinitionBuilder SmallTransparentIcon(string value)
            {
                _SmallTransparentIcon = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsDestinyVendorDisplayPropertiesDefinition.MapIcon property.
            /// </summary>
            /// <param name="value">This is the icon used in the map overview, when the vendor is located on the map.</param>
            public DestinyDefinitionsDestinyVendorDisplayPropertiesDefinitionBuilder MapIcon(string value)
            {
                _MapIcon = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsDestinyVendorDisplayPropertiesDefinition.LargeTransparentIcon property.
            /// </summary>
            /// <param name="value">This is apparently the \&quot;Watermark\&quot;. I am not certain offhand where this is actually used in the Game UI, but some people may find it useful.</param>
            public DestinyDefinitionsDestinyVendorDisplayPropertiesDefinitionBuilder LargeTransparentIcon(string value)
            {
                _LargeTransparentIcon = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsDestinyVendorDisplayPropertiesDefinition.Description property.
            /// </summary>
            /// <param name="value">Description</param>
            public DestinyDefinitionsDestinyVendorDisplayPropertiesDefinitionBuilder Description(string value)
            {
                _Description = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsDestinyVendorDisplayPropertiesDefinition.Name property.
            /// </summary>
            /// <param name="value">Name</param>
            public DestinyDefinitionsDestinyVendorDisplayPropertiesDefinitionBuilder Name(string value)
            {
                _Name = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsDestinyVendorDisplayPropertiesDefinition.Icon property.
            /// </summary>
            /// <param name="value">Note that \&quot;icon\&quot; is sometimes misleading, and should be interpreted in the context of the entity. For instance, in Destiny 1 the DestinyRecordBookDefinition&#39;s icon was a big picture of a book.  But usually, it will be a small square image that you can use as... well, an icon.  They are currently represented as 96px x 96px images.</param>
            public DestinyDefinitionsDestinyVendorDisplayPropertiesDefinitionBuilder Icon(string value)
            {
                _Icon = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsDestinyVendorDisplayPropertiesDefinition.IconSequences property.
            /// </summary>
            /// <param name="value">IconSequences</param>
            public DestinyDefinitionsDestinyVendorDisplayPropertiesDefinitionBuilder IconSequences(List<DestinyDefinitionsCommonDestinyIconSequenceDefinition> value)
            {
                _IconSequences = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsDestinyVendorDisplayPropertiesDefinition.HighResIcon property.
            /// </summary>
            /// <param name="value">If this item has a high-res icon (at least for now, many things won&#39;t), then the path to that icon will be here.</param>
            public DestinyDefinitionsDestinyVendorDisplayPropertiesDefinitionBuilder HighResIcon(string value)
            {
                _HighResIcon = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsDestinyVendorDisplayPropertiesDefinition.HasIcon property.
            /// </summary>
            /// <param name="value">HasIcon</param>
            public DestinyDefinitionsDestinyVendorDisplayPropertiesDefinitionBuilder HasIcon(bool? value)
            {
                _HasIcon = value;
                return this;
            }


            /// <summary>
            /// Builds instance of DestinyDefinitionsDestinyVendorDisplayPropertiesDefinition.
            /// </summary>
            /// <returns>DestinyDefinitionsDestinyVendorDisplayPropertiesDefinition</returns>
            public DestinyDefinitionsDestinyVendorDisplayPropertiesDefinition Build()
            {
                Validate();
                return new DestinyDefinitionsDestinyVendorDisplayPropertiesDefinition(
                    LargeIcon: _LargeIcon,
                    Subtitle: _Subtitle,
                    OriginalIcon: _OriginalIcon,
                    RequirementsDisplay: _RequirementsDisplay,
                    SmallTransparentIcon: _SmallTransparentIcon,
                    MapIcon: _MapIcon,
                    LargeTransparentIcon: _LargeTransparentIcon,
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