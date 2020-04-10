using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Sharpility.Extensions;
using NodaTime;

namespace BungieNetApi._Platform.Models
{
    /// <summary>
    /// This defines information that can only come from a talent grid on an item. Items mostly have negligible talent grid data these days, but instanced items still retain grids as a source for some of this common information.  Builds/Subclasses are the only items left that still have talent grids with meaningful Nodes.
    /// </summary>
    public sealed class DestinyDefinitionsDestinyItemTalentGridBlockDefinition:  IEquatable<DestinyDefinitionsDestinyItemTalentGridBlockDefinition>
    { 
        /// <summary>
        /// The hash identifier of the DestinyTalentGridDefinition attached to this item.
        /// </summary>
        public int? TalentGridHash { get; private set; }

        /// <summary>
        /// This is meant to be a subtitle for looking at the talent grid. In practice, somewhat frustratingly, this always merely says the localized word for \&quot;Details\&quot;. Great. Maybe it&#39;ll have more if talent grids ever get used for more than builds and subclasses again.
        /// </summary>
        public string ItemDetailString { get; private set; }

        /// <summary>
        /// A shortcut string identifier for the \&quot;build\&quot; in question, if this talent grid has an associated build. Doesn&#39;t map to anything we can expose at the moment.
        /// </summary>
        public string BuildName { get; private set; }

        /// <summary>
        /// If the talent grid implies a damage type, this is the enum value for that damage type.
        /// </summary>
        public int? HudDamageType { get; private set; }

        /// <summary>
        /// If the talent grid has a special icon that&#39;s shown in the game UI (like builds, funny that), this is the identifier for that icon. Sadly, we don&#39;t actually get that icon right now. I&#39;ll be looking to replace this with a path to the actual icon itself.
        /// </summary>
        public string HudIcon { get; private set; }


        /// <summary>
        /// Empty constructor required by some serializers.
        /// Use DestinyDefinitionsDestinyItemTalentGridBlockDefinition.Builder() for instance creation instead.
        /// </summary>
        [Obsolete]
        public DestinyDefinitionsDestinyItemTalentGridBlockDefinition()
        {
        }

        private DestinyDefinitionsDestinyItemTalentGridBlockDefinition(int? TalentGridHash, string ItemDetailString, string BuildName, int? HudDamageType, string HudIcon)
        {
            
            this.TalentGridHash = TalentGridHash;
            
            this.ItemDetailString = ItemDetailString;
            
            this.BuildName = BuildName;
            
            this.HudDamageType = HudDamageType;
            
            this.HudIcon = HudIcon;
            
        }

        /// <summary>
        /// Returns builder of DestinyDefinitionsDestinyItemTalentGridBlockDefinition.
        /// </summary>
        /// <returns>DestinyDefinitionsDestinyItemTalentGridBlockDefinitionBuilder</returns>
        public static DestinyDefinitionsDestinyItemTalentGridBlockDefinitionBuilder Builder()
        {
            return new DestinyDefinitionsDestinyItemTalentGridBlockDefinitionBuilder();
        }

        /// <summary>
        /// Returns DestinyDefinitionsDestinyItemTalentGridBlockDefinitionBuilder with properties set.
        /// Use it to change properties.
        /// </summary>
        /// <returns>DestinyDefinitionsDestinyItemTalentGridBlockDefinitionBuilder</returns>
        public DestinyDefinitionsDestinyItemTalentGridBlockDefinitionBuilder With()
        {
            return Builder()
                .TalentGridHash(TalentGridHash)
                .ItemDetailString(ItemDetailString)
                .BuildName(BuildName)
                .HudDamageType(HudDamageType)
                .HudIcon(HudIcon);
        }

        public override string ToString()
        {
            return this.PropertiesToString();
        }

        public override bool Equals(object obj)
        {
            return this.EqualsByProperties(obj);
        }

        public bool Equals(DestinyDefinitionsDestinyItemTalentGridBlockDefinition other)
        {
            return Equals((object) other);
        }

        public override int GetHashCode()
        {
            return this.PropertiesHash();
        }

        /// <summary>
        /// Implementation of == operator for (DestinyDefinitionsDestinyItemTalentGridBlockDefinition.
        /// </summary>
        /// <param name="left">Compared (DestinyDefinitionsDestinyItemTalentGridBlockDefinition</param>
        /// <param name="right">Compared (DestinyDefinitionsDestinyItemTalentGridBlockDefinition</param>
        /// <returns>true if compared items are equals, false otherwise</returns>
        public static bool operator == (DestinyDefinitionsDestinyItemTalentGridBlockDefinition left, DestinyDefinitionsDestinyItemTalentGridBlockDefinition right)
        {
            return Equals(left, right);
        }

        /// <summary>
        /// Implementation of != operator for (DestinyDefinitionsDestinyItemTalentGridBlockDefinition.
        /// </summary>
        /// <param name="left">Compared (DestinyDefinitionsDestinyItemTalentGridBlockDefinition</param>
        /// <param name="right">Compared (DestinyDefinitionsDestinyItemTalentGridBlockDefinition</param>
        /// <returns>true if compared items are not equals, false otherwise</returns>
        public static bool operator != (DestinyDefinitionsDestinyItemTalentGridBlockDefinition left, DestinyDefinitionsDestinyItemTalentGridBlockDefinition right)
        {
            return !Equals(left, right);
        }

        /// <summary>
        /// Builder of DestinyDefinitionsDestinyItemTalentGridBlockDefinition.
        /// </summary>
        public sealed class DestinyDefinitionsDestinyItemTalentGridBlockDefinitionBuilder
        {
            private int? _TalentGridHash;
            private string _ItemDetailString;
            private string _BuildName;
            private int? _HudDamageType;
            private string _HudIcon;

            internal DestinyDefinitionsDestinyItemTalentGridBlockDefinitionBuilder()
            {
                SetupDefaults();
            }

            private void SetupDefaults()
            {
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsDestinyItemTalentGridBlockDefinition.TalentGridHash property.
            /// </summary>
            /// <param name="value">The hash identifier of the DestinyTalentGridDefinition attached to this item.</param>
            public DestinyDefinitionsDestinyItemTalentGridBlockDefinitionBuilder TalentGridHash(int? value)
            {
                _TalentGridHash = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsDestinyItemTalentGridBlockDefinition.ItemDetailString property.
            /// </summary>
            /// <param name="value">This is meant to be a subtitle for looking at the talent grid. In practice, somewhat frustratingly, this always merely says the localized word for \&quot;Details\&quot;. Great. Maybe it&#39;ll have more if talent grids ever get used for more than builds and subclasses again.</param>
            public DestinyDefinitionsDestinyItemTalentGridBlockDefinitionBuilder ItemDetailString(string value)
            {
                _ItemDetailString = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsDestinyItemTalentGridBlockDefinition.BuildName property.
            /// </summary>
            /// <param name="value">A shortcut string identifier for the \&quot;build\&quot; in question, if this talent grid has an associated build. Doesn&#39;t map to anything we can expose at the moment.</param>
            public DestinyDefinitionsDestinyItemTalentGridBlockDefinitionBuilder BuildName(string value)
            {
                _BuildName = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsDestinyItemTalentGridBlockDefinition.HudDamageType property.
            /// </summary>
            /// <param name="value">If the talent grid implies a damage type, this is the enum value for that damage type.</param>
            public DestinyDefinitionsDestinyItemTalentGridBlockDefinitionBuilder HudDamageType(int? value)
            {
                _HudDamageType = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsDestinyItemTalentGridBlockDefinition.HudIcon property.
            /// </summary>
            /// <param name="value">If the talent grid has a special icon that&#39;s shown in the game UI (like builds, funny that), this is the identifier for that icon. Sadly, we don&#39;t actually get that icon right now. I&#39;ll be looking to replace this with a path to the actual icon itself.</param>
            public DestinyDefinitionsDestinyItemTalentGridBlockDefinitionBuilder HudIcon(string value)
            {
                _HudIcon = value;
                return this;
            }


            /// <summary>
            /// Builds instance of DestinyDefinitionsDestinyItemTalentGridBlockDefinition.
            /// </summary>
            /// <returns>DestinyDefinitionsDestinyItemTalentGridBlockDefinition</returns>
            public DestinyDefinitionsDestinyItemTalentGridBlockDefinition Build()
            {
                Validate();
                return new DestinyDefinitionsDestinyItemTalentGridBlockDefinition(
                    TalentGridHash: _TalentGridHash,
                    ItemDetailString: _ItemDetailString,
                    BuildName: _BuildName,
                    HudDamageType: _HudDamageType,
                    HudIcon: _HudIcon
                );
            }

            private void Validate()
            { 
            }
        }

        
    }
}