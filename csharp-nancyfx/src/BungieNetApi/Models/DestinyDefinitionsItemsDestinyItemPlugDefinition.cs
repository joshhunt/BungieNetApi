using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Sharpility.Extensions;
using NodaTime;

namespace BungieNetApi._Platform.Models
{
    /// <summary>
    /// If an item is a Plug, its DestinyInventoryItemDefinition.plug property will be populated with an instance of one of these bad boys.  This gives information about when it can be inserted, what the plug&#39;s category is (and thus whether it is compatible with a socket... see DestinySocketTypeDefinition for information about Plug Categories and socket compatibility), whether it is enabled and other Plug info.
    /// </summary>
    public sealed class DestinyDefinitionsItemsDestinyItemPlugDefinition:  IEquatable<DestinyDefinitionsItemsDestinyItemPlugDefinition>
    { 
        /// <summary>
        /// The rules around when this plug can be inserted into a socket, aside from the socket&#39;s individual restrictions.  The live data DestinyItemPlugComponent.insertFailIndexes will be an index into this array, so you can pull out the failure strings appropriate for the user.
        /// </summary>
        public List<DestinyDefinitionsItemsDestinyPlugRuleDefinition> InsertionRules { get; private set; }

        /// <summary>
        /// The string identifier for the plug&#39;s category. Use the socket&#39;s DestinySocketTypeDefinition.plugWhitelist to determine whether this plug can be inserted into the socket.
        /// </summary>
        public string PlugCategoryIdentifier { get; private set; }

        /// <summary>
        /// The hash for the plugCategoryIdentifier. You can use this instead if you wish: I put both in the definition for debugging purposes.
        /// </summary>
        public int? PlugCategoryHash { get; private set; }

        /// <summary>
        /// If you successfully socket the item, this will determine whether or not you get \&quot;refunded\&quot; on the plug.
        /// </summary>
        public bool? OnActionRecreateSelf { get; private set; }

        /// <summary>
        /// If inserting this plug requires materials, this is the hash identifier for looking up the DestinyMaterialRequirementSetDefinition for those requirements.
        /// </summary>
        public int? InsertionMaterialRequirementHash { get; private set; }

        /// <summary>
        /// In the game, if you&#39;re inspecting a plug item directly, this will be the item shown with the plug attached. Look up the DestinyInventoryItemDefinition for this hash for the item.
        /// </summary>
        public int? PreviewItemOverrideHash { get; private set; }

        /// <summary>
        /// It&#39;s not enough for the plug to be inserted. It has to be enabled as well. For it to be enabled, it may require materials. This is the hash identifier for the DestinyMaterialRequirementSetDefinition for those requirements, if there is one.
        /// </summary>
        public int? EnabledMaterialRequirementHash { get; private set; }

        /// <summary>
        /// The rules around whether the plug, once inserted, is enabled and providing its benefits.  The live data DestinyItemPlugComponent.enableFailIndexes will be an index into this array, so you can pull out the failure strings appropriate for the user.
        /// </summary>
        public List<DestinyDefinitionsItemsDestinyPlugRuleDefinition> EnabledRules { get; private set; }

        /// <summary>
        /// Plugs can have arbitrary, UI-defined identifiers that the UI designers use to determine the style applied to plugs. Unfortunately, we have neither a definitive list of these labels nor advance warning of when new labels might be applied or how that relates to how they get rendered. If you want to, you can refer to known labels to change your own styles: but know that new ones can be created arbitrarily, and we have no way of associating the labels with any specific UI style guidance... you&#39;ll have to piece that together on your end. Or do what we do, and just show plugs more generically, without specialized styles.
        /// </summary>
        public string UiPlugLabel { get; private set; }

        /// <summary>
        /// PlugStyle
        /// </summary>
        public int? PlugStyle { get; private set; }

        /// <summary>
        /// Indicates the rules about when this plug can be used. See the PlugAvailabilityMode enumeration for more information!
        /// </summary>
        public int? PlugAvailability { get; private set; }

        /// <summary>
        /// If the plug meets certain state requirements, it may have an alternative label applied to it. This is the alternative label that will be applied in such a situation.
        /// </summary>
        public string AlternateUiPlugLabel { get; private set; }

        /// <summary>
        /// The alternate plug of the plug: only applies when the item is in states that only the server can know about and control, unfortunately. See AlternateUiPlugLabel for the related label info.
        /// </summary>
        public int? AlternatePlugStyle { get; private set; }

        /// <summary>
        /// If TRUE, this plug is used for UI display purposes only, and doesn&#39;t have any interesting effects of its own.
        /// </summary>
        public bool? IsDummyPlug { get; private set; }

        /// <summary>
        /// Do you ever get the feeling that a system has become so overburdened by edge cases that it probably should have become some other system entirely? So do I!  In totally unrelated news, Plugs can now override properties of their parent items. This is some of the relevant definition data for those overrides.  If this is populated, it will have the override data to be applied when this plug is applied to an item.
        /// </summary>
        public DestinyDefinitionsItemsDestinyParentItemOverride ParentItemOverride { get; private set; }

        /// <summary>
        /// IF not null, this plug provides Energy capacity to the item in which it is socketed. In Armor 2.0 for example, is implemented in a similar way to Masterworks, where visually it&#39;s a single area of the UI being clicked on to \&quot;Upgrade\&quot; to higher energy levels, but it&#39;s actually socketing new plugs.
        /// </summary>
        public DestinyDefinitionsItemsDestinyEnergyCapacityEntry EnergyCapacity { get; private set; }

        /// <summary>
        /// IF not null, this plug has an energy cost. This contains the details of that cost.
        /// </summary>
        public DestinyDefinitionsItemsDestinyEnergyCostEntry EnergyCost { get; private set; }


        /// <summary>
        /// Empty constructor required by some serializers.
        /// Use DestinyDefinitionsItemsDestinyItemPlugDefinition.Builder() for instance creation instead.
        /// </summary>
        [Obsolete]
        public DestinyDefinitionsItemsDestinyItemPlugDefinition()
        {
        }

        private DestinyDefinitionsItemsDestinyItemPlugDefinition(List<DestinyDefinitionsItemsDestinyPlugRuleDefinition> InsertionRules, string PlugCategoryIdentifier, int? PlugCategoryHash, bool? OnActionRecreateSelf, int? InsertionMaterialRequirementHash, int? PreviewItemOverrideHash, int? EnabledMaterialRequirementHash, List<DestinyDefinitionsItemsDestinyPlugRuleDefinition> EnabledRules, string UiPlugLabel, int? PlugStyle, int? PlugAvailability, string AlternateUiPlugLabel, int? AlternatePlugStyle, bool? IsDummyPlug, DestinyDefinitionsItemsDestinyParentItemOverride ParentItemOverride, DestinyDefinitionsItemsDestinyEnergyCapacityEntry EnergyCapacity, DestinyDefinitionsItemsDestinyEnergyCostEntry EnergyCost)
        {
            
            this.InsertionRules = InsertionRules;
            
            this.PlugCategoryIdentifier = PlugCategoryIdentifier;
            
            this.PlugCategoryHash = PlugCategoryHash;
            
            this.OnActionRecreateSelf = OnActionRecreateSelf;
            
            this.InsertionMaterialRequirementHash = InsertionMaterialRequirementHash;
            
            this.PreviewItemOverrideHash = PreviewItemOverrideHash;
            
            this.EnabledMaterialRequirementHash = EnabledMaterialRequirementHash;
            
            this.EnabledRules = EnabledRules;
            
            this.UiPlugLabel = UiPlugLabel;
            
            this.PlugStyle = PlugStyle;
            
            this.PlugAvailability = PlugAvailability;
            
            this.AlternateUiPlugLabel = AlternateUiPlugLabel;
            
            this.AlternatePlugStyle = AlternatePlugStyle;
            
            this.IsDummyPlug = IsDummyPlug;
            
            this.ParentItemOverride = ParentItemOverride;
            
            this.EnergyCapacity = EnergyCapacity;
            
            this.EnergyCost = EnergyCost;
            
        }

        /// <summary>
        /// Returns builder of DestinyDefinitionsItemsDestinyItemPlugDefinition.
        /// </summary>
        /// <returns>DestinyDefinitionsItemsDestinyItemPlugDefinitionBuilder</returns>
        public static DestinyDefinitionsItemsDestinyItemPlugDefinitionBuilder Builder()
        {
            return new DestinyDefinitionsItemsDestinyItemPlugDefinitionBuilder();
        }

        /// <summary>
        /// Returns DestinyDefinitionsItemsDestinyItemPlugDefinitionBuilder with properties set.
        /// Use it to change properties.
        /// </summary>
        /// <returns>DestinyDefinitionsItemsDestinyItemPlugDefinitionBuilder</returns>
        public DestinyDefinitionsItemsDestinyItemPlugDefinitionBuilder With()
        {
            return Builder()
                .InsertionRules(InsertionRules)
                .PlugCategoryIdentifier(PlugCategoryIdentifier)
                .PlugCategoryHash(PlugCategoryHash)
                .OnActionRecreateSelf(OnActionRecreateSelf)
                .InsertionMaterialRequirementHash(InsertionMaterialRequirementHash)
                .PreviewItemOverrideHash(PreviewItemOverrideHash)
                .EnabledMaterialRequirementHash(EnabledMaterialRequirementHash)
                .EnabledRules(EnabledRules)
                .UiPlugLabel(UiPlugLabel)
                .PlugStyle(PlugStyle)
                .PlugAvailability(PlugAvailability)
                .AlternateUiPlugLabel(AlternateUiPlugLabel)
                .AlternatePlugStyle(AlternatePlugStyle)
                .IsDummyPlug(IsDummyPlug)
                .ParentItemOverride(ParentItemOverride)
                .EnergyCapacity(EnergyCapacity)
                .EnergyCost(EnergyCost);
        }

        public override string ToString()
        {
            return this.PropertiesToString();
        }

        public override bool Equals(object obj)
        {
            return this.EqualsByProperties(obj);
        }

        public bool Equals(DestinyDefinitionsItemsDestinyItemPlugDefinition other)
        {
            return Equals((object) other);
        }

        public override int GetHashCode()
        {
            return this.PropertiesHash();
        }

        /// <summary>
        /// Implementation of == operator for (DestinyDefinitionsItemsDestinyItemPlugDefinition.
        /// </summary>
        /// <param name="left">Compared (DestinyDefinitionsItemsDestinyItemPlugDefinition</param>
        /// <param name="right">Compared (DestinyDefinitionsItemsDestinyItemPlugDefinition</param>
        /// <returns>true if compared items are equals, false otherwise</returns>
        public static bool operator == (DestinyDefinitionsItemsDestinyItemPlugDefinition left, DestinyDefinitionsItemsDestinyItemPlugDefinition right)
        {
            return Equals(left, right);
        }

        /// <summary>
        /// Implementation of != operator for (DestinyDefinitionsItemsDestinyItemPlugDefinition.
        /// </summary>
        /// <param name="left">Compared (DestinyDefinitionsItemsDestinyItemPlugDefinition</param>
        /// <param name="right">Compared (DestinyDefinitionsItemsDestinyItemPlugDefinition</param>
        /// <returns>true if compared items are not equals, false otherwise</returns>
        public static bool operator != (DestinyDefinitionsItemsDestinyItemPlugDefinition left, DestinyDefinitionsItemsDestinyItemPlugDefinition right)
        {
            return !Equals(left, right);
        }

        /// <summary>
        /// Builder of DestinyDefinitionsItemsDestinyItemPlugDefinition.
        /// </summary>
        public sealed class DestinyDefinitionsItemsDestinyItemPlugDefinitionBuilder
        {
            private List<DestinyDefinitionsItemsDestinyPlugRuleDefinition> _InsertionRules;
            private string _PlugCategoryIdentifier;
            private int? _PlugCategoryHash;
            private bool? _OnActionRecreateSelf;
            private int? _InsertionMaterialRequirementHash;
            private int? _PreviewItemOverrideHash;
            private int? _EnabledMaterialRequirementHash;
            private List<DestinyDefinitionsItemsDestinyPlugRuleDefinition> _EnabledRules;
            private string _UiPlugLabel;
            private int? _PlugStyle;
            private int? _PlugAvailability;
            private string _AlternateUiPlugLabel;
            private int? _AlternatePlugStyle;
            private bool? _IsDummyPlug;
            private DestinyDefinitionsItemsDestinyParentItemOverride _ParentItemOverride;
            private DestinyDefinitionsItemsDestinyEnergyCapacityEntry _EnergyCapacity;
            private DestinyDefinitionsItemsDestinyEnergyCostEntry _EnergyCost;

            internal DestinyDefinitionsItemsDestinyItemPlugDefinitionBuilder()
            {
                SetupDefaults();
            }

            private void SetupDefaults()
            {
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsItemsDestinyItemPlugDefinition.InsertionRules property.
            /// </summary>
            /// <param name="value">The rules around when this plug can be inserted into a socket, aside from the socket&#39;s individual restrictions.  The live data DestinyItemPlugComponent.insertFailIndexes will be an index into this array, so you can pull out the failure strings appropriate for the user.</param>
            public DestinyDefinitionsItemsDestinyItemPlugDefinitionBuilder InsertionRules(List<DestinyDefinitionsItemsDestinyPlugRuleDefinition> value)
            {
                _InsertionRules = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsItemsDestinyItemPlugDefinition.PlugCategoryIdentifier property.
            /// </summary>
            /// <param name="value">The string identifier for the plug&#39;s category. Use the socket&#39;s DestinySocketTypeDefinition.plugWhitelist to determine whether this plug can be inserted into the socket.</param>
            public DestinyDefinitionsItemsDestinyItemPlugDefinitionBuilder PlugCategoryIdentifier(string value)
            {
                _PlugCategoryIdentifier = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsItemsDestinyItemPlugDefinition.PlugCategoryHash property.
            /// </summary>
            /// <param name="value">The hash for the plugCategoryIdentifier. You can use this instead if you wish: I put both in the definition for debugging purposes.</param>
            public DestinyDefinitionsItemsDestinyItemPlugDefinitionBuilder PlugCategoryHash(int? value)
            {
                _PlugCategoryHash = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsItemsDestinyItemPlugDefinition.OnActionRecreateSelf property.
            /// </summary>
            /// <param name="value">If you successfully socket the item, this will determine whether or not you get \&quot;refunded\&quot; on the plug.</param>
            public DestinyDefinitionsItemsDestinyItemPlugDefinitionBuilder OnActionRecreateSelf(bool? value)
            {
                _OnActionRecreateSelf = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsItemsDestinyItemPlugDefinition.InsertionMaterialRequirementHash property.
            /// </summary>
            /// <param name="value">If inserting this plug requires materials, this is the hash identifier for looking up the DestinyMaterialRequirementSetDefinition for those requirements.</param>
            public DestinyDefinitionsItemsDestinyItemPlugDefinitionBuilder InsertionMaterialRequirementHash(int? value)
            {
                _InsertionMaterialRequirementHash = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsItemsDestinyItemPlugDefinition.PreviewItemOverrideHash property.
            /// </summary>
            /// <param name="value">In the game, if you&#39;re inspecting a plug item directly, this will be the item shown with the plug attached. Look up the DestinyInventoryItemDefinition for this hash for the item.</param>
            public DestinyDefinitionsItemsDestinyItemPlugDefinitionBuilder PreviewItemOverrideHash(int? value)
            {
                _PreviewItemOverrideHash = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsItemsDestinyItemPlugDefinition.EnabledMaterialRequirementHash property.
            /// </summary>
            /// <param name="value">It&#39;s not enough for the plug to be inserted. It has to be enabled as well. For it to be enabled, it may require materials. This is the hash identifier for the DestinyMaterialRequirementSetDefinition for those requirements, if there is one.</param>
            public DestinyDefinitionsItemsDestinyItemPlugDefinitionBuilder EnabledMaterialRequirementHash(int? value)
            {
                _EnabledMaterialRequirementHash = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsItemsDestinyItemPlugDefinition.EnabledRules property.
            /// </summary>
            /// <param name="value">The rules around whether the plug, once inserted, is enabled and providing its benefits.  The live data DestinyItemPlugComponent.enableFailIndexes will be an index into this array, so you can pull out the failure strings appropriate for the user.</param>
            public DestinyDefinitionsItemsDestinyItemPlugDefinitionBuilder EnabledRules(List<DestinyDefinitionsItemsDestinyPlugRuleDefinition> value)
            {
                _EnabledRules = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsItemsDestinyItemPlugDefinition.UiPlugLabel property.
            /// </summary>
            /// <param name="value">Plugs can have arbitrary, UI-defined identifiers that the UI designers use to determine the style applied to plugs. Unfortunately, we have neither a definitive list of these labels nor advance warning of when new labels might be applied or how that relates to how they get rendered. If you want to, you can refer to known labels to change your own styles: but know that new ones can be created arbitrarily, and we have no way of associating the labels with any specific UI style guidance... you&#39;ll have to piece that together on your end. Or do what we do, and just show plugs more generically, without specialized styles.</param>
            public DestinyDefinitionsItemsDestinyItemPlugDefinitionBuilder UiPlugLabel(string value)
            {
                _UiPlugLabel = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsItemsDestinyItemPlugDefinition.PlugStyle property.
            /// </summary>
            /// <param name="value">PlugStyle</param>
            public DestinyDefinitionsItemsDestinyItemPlugDefinitionBuilder PlugStyle(int? value)
            {
                _PlugStyle = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsItemsDestinyItemPlugDefinition.PlugAvailability property.
            /// </summary>
            /// <param name="value">Indicates the rules about when this plug can be used. See the PlugAvailabilityMode enumeration for more information!</param>
            public DestinyDefinitionsItemsDestinyItemPlugDefinitionBuilder PlugAvailability(int? value)
            {
                _PlugAvailability = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsItemsDestinyItemPlugDefinition.AlternateUiPlugLabel property.
            /// </summary>
            /// <param name="value">If the plug meets certain state requirements, it may have an alternative label applied to it. This is the alternative label that will be applied in such a situation.</param>
            public DestinyDefinitionsItemsDestinyItemPlugDefinitionBuilder AlternateUiPlugLabel(string value)
            {
                _AlternateUiPlugLabel = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsItemsDestinyItemPlugDefinition.AlternatePlugStyle property.
            /// </summary>
            /// <param name="value">The alternate plug of the plug: only applies when the item is in states that only the server can know about and control, unfortunately. See AlternateUiPlugLabel for the related label info.</param>
            public DestinyDefinitionsItemsDestinyItemPlugDefinitionBuilder AlternatePlugStyle(int? value)
            {
                _AlternatePlugStyle = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsItemsDestinyItemPlugDefinition.IsDummyPlug property.
            /// </summary>
            /// <param name="value">If TRUE, this plug is used for UI display purposes only, and doesn&#39;t have any interesting effects of its own.</param>
            public DestinyDefinitionsItemsDestinyItemPlugDefinitionBuilder IsDummyPlug(bool? value)
            {
                _IsDummyPlug = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsItemsDestinyItemPlugDefinition.ParentItemOverride property.
            /// </summary>
            /// <param name="value">Do you ever get the feeling that a system has become so overburdened by edge cases that it probably should have become some other system entirely? So do I!  In totally unrelated news, Plugs can now override properties of their parent items. This is some of the relevant definition data for those overrides.  If this is populated, it will have the override data to be applied when this plug is applied to an item.</param>
            public DestinyDefinitionsItemsDestinyItemPlugDefinitionBuilder ParentItemOverride(DestinyDefinitionsItemsDestinyParentItemOverride value)
            {
                _ParentItemOverride = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsItemsDestinyItemPlugDefinition.EnergyCapacity property.
            /// </summary>
            /// <param name="value">IF not null, this plug provides Energy capacity to the item in which it is socketed. In Armor 2.0 for example, is implemented in a similar way to Masterworks, where visually it&#39;s a single area of the UI being clicked on to \&quot;Upgrade\&quot; to higher energy levels, but it&#39;s actually socketing new plugs.</param>
            public DestinyDefinitionsItemsDestinyItemPlugDefinitionBuilder EnergyCapacity(DestinyDefinitionsItemsDestinyEnergyCapacityEntry value)
            {
                _EnergyCapacity = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsItemsDestinyItemPlugDefinition.EnergyCost property.
            /// </summary>
            /// <param name="value">IF not null, this plug has an energy cost. This contains the details of that cost.</param>
            public DestinyDefinitionsItemsDestinyItemPlugDefinitionBuilder EnergyCost(DestinyDefinitionsItemsDestinyEnergyCostEntry value)
            {
                _EnergyCost = value;
                return this;
            }


            /// <summary>
            /// Builds instance of DestinyDefinitionsItemsDestinyItemPlugDefinition.
            /// </summary>
            /// <returns>DestinyDefinitionsItemsDestinyItemPlugDefinition</returns>
            public DestinyDefinitionsItemsDestinyItemPlugDefinition Build()
            {
                Validate();
                return new DestinyDefinitionsItemsDestinyItemPlugDefinition(
                    InsertionRules: _InsertionRules,
                    PlugCategoryIdentifier: _PlugCategoryIdentifier,
                    PlugCategoryHash: _PlugCategoryHash,
                    OnActionRecreateSelf: _OnActionRecreateSelf,
                    InsertionMaterialRequirementHash: _InsertionMaterialRequirementHash,
                    PreviewItemOverrideHash: _PreviewItemOverrideHash,
                    EnabledMaterialRequirementHash: _EnabledMaterialRequirementHash,
                    EnabledRules: _EnabledRules,
                    UiPlugLabel: _UiPlugLabel,
                    PlugStyle: _PlugStyle,
                    PlugAvailability: _PlugAvailability,
                    AlternateUiPlugLabel: _AlternateUiPlugLabel,
                    AlternatePlugStyle: _AlternatePlugStyle,
                    IsDummyPlug: _IsDummyPlug,
                    ParentItemOverride: _ParentItemOverride,
                    EnergyCapacity: _EnergyCapacity,
                    EnergyCost: _EnergyCost
                );
            }

            private void Validate()
            { 
            }
        }

        
    }
}