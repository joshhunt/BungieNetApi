using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Sharpility.Extensions;
using NodaTime;

namespace BungieNetApi._Platform.Models
{
    /// <summary>
    /// DestinyDefinitionsItemsDestinyParentItemOverride
    /// </summary>
    public sealed class DestinyDefinitionsItemsDestinyParentItemOverride:  IEquatable<DestinyDefinitionsItemsDestinyParentItemOverride>
    { 
        /// <summary>
        /// AdditionalEquipRequirementsDisplayStrings
        /// </summary>
        public List<string> AdditionalEquipRequirementsDisplayStrings { get; private set; }

        /// <summary>
        /// PipIcon
        /// </summary>
        public string PipIcon { get; private set; }


        /// <summary>
        /// Empty constructor required by some serializers.
        /// Use DestinyDefinitionsItemsDestinyParentItemOverride.Builder() for instance creation instead.
        /// </summary>
        [Obsolete]
        public DestinyDefinitionsItemsDestinyParentItemOverride()
        {
        }

        private DestinyDefinitionsItemsDestinyParentItemOverride(List<string> AdditionalEquipRequirementsDisplayStrings, string PipIcon)
        {
            
            this.AdditionalEquipRequirementsDisplayStrings = AdditionalEquipRequirementsDisplayStrings;
            
            this.PipIcon = PipIcon;
            
        }

        /// <summary>
        /// Returns builder of DestinyDefinitionsItemsDestinyParentItemOverride.
        /// </summary>
        /// <returns>DestinyDefinitionsItemsDestinyParentItemOverrideBuilder</returns>
        public static DestinyDefinitionsItemsDestinyParentItemOverrideBuilder Builder()
        {
            return new DestinyDefinitionsItemsDestinyParentItemOverrideBuilder();
        }

        /// <summary>
        /// Returns DestinyDefinitionsItemsDestinyParentItemOverrideBuilder with properties set.
        /// Use it to change properties.
        /// </summary>
        /// <returns>DestinyDefinitionsItemsDestinyParentItemOverrideBuilder</returns>
        public DestinyDefinitionsItemsDestinyParentItemOverrideBuilder With()
        {
            return Builder()
                .AdditionalEquipRequirementsDisplayStrings(AdditionalEquipRequirementsDisplayStrings)
                .PipIcon(PipIcon);
        }

        public override string ToString()
        {
            return this.PropertiesToString();
        }

        public override bool Equals(object obj)
        {
            return this.EqualsByProperties(obj);
        }

        public bool Equals(DestinyDefinitionsItemsDestinyParentItemOverride other)
        {
            return Equals((object) other);
        }

        public override int GetHashCode()
        {
            return this.PropertiesHash();
        }

        /// <summary>
        /// Implementation of == operator for (DestinyDefinitionsItemsDestinyParentItemOverride.
        /// </summary>
        /// <param name="left">Compared (DestinyDefinitionsItemsDestinyParentItemOverride</param>
        /// <param name="right">Compared (DestinyDefinitionsItemsDestinyParentItemOverride</param>
        /// <returns>true if compared items are equals, false otherwise</returns>
        public static bool operator == (DestinyDefinitionsItemsDestinyParentItemOverride left, DestinyDefinitionsItemsDestinyParentItemOverride right)
        {
            return Equals(left, right);
        }

        /// <summary>
        /// Implementation of != operator for (DestinyDefinitionsItemsDestinyParentItemOverride.
        /// </summary>
        /// <param name="left">Compared (DestinyDefinitionsItemsDestinyParentItemOverride</param>
        /// <param name="right">Compared (DestinyDefinitionsItemsDestinyParentItemOverride</param>
        /// <returns>true if compared items are not equals, false otherwise</returns>
        public static bool operator != (DestinyDefinitionsItemsDestinyParentItemOverride left, DestinyDefinitionsItemsDestinyParentItemOverride right)
        {
            return !Equals(left, right);
        }

        /// <summary>
        /// Builder of DestinyDefinitionsItemsDestinyParentItemOverride.
        /// </summary>
        public sealed class DestinyDefinitionsItemsDestinyParentItemOverrideBuilder
        {
            private List<string> _AdditionalEquipRequirementsDisplayStrings;
            private string _PipIcon;

            internal DestinyDefinitionsItemsDestinyParentItemOverrideBuilder()
            {
                SetupDefaults();
            }

            private void SetupDefaults()
            {
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsItemsDestinyParentItemOverride.AdditionalEquipRequirementsDisplayStrings property.
            /// </summary>
            /// <param name="value">AdditionalEquipRequirementsDisplayStrings</param>
            public DestinyDefinitionsItemsDestinyParentItemOverrideBuilder AdditionalEquipRequirementsDisplayStrings(List<string> value)
            {
                _AdditionalEquipRequirementsDisplayStrings = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsItemsDestinyParentItemOverride.PipIcon property.
            /// </summary>
            /// <param name="value">PipIcon</param>
            public DestinyDefinitionsItemsDestinyParentItemOverrideBuilder PipIcon(string value)
            {
                _PipIcon = value;
                return this;
            }


            /// <summary>
            /// Builds instance of DestinyDefinitionsItemsDestinyParentItemOverride.
            /// </summary>
            /// <returns>DestinyDefinitionsItemsDestinyParentItemOverride</returns>
            public DestinyDefinitionsItemsDestinyParentItemOverride Build()
            {
                Validate();
                return new DestinyDefinitionsItemsDestinyParentItemOverride(
                    AdditionalEquipRequirementsDisplayStrings: _AdditionalEquipRequirementsDisplayStrings,
                    PipIcon: _PipIcon
                );
            }

            private void Validate()
            { 
            }
        }

        
    }
}