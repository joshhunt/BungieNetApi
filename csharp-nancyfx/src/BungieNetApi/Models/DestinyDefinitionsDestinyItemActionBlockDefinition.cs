using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Sharpility.Extensions;
using NodaTime;

namespace BungieNetApi._Platform.Models
{
    /// <summary>
    /// If an item can have an action performed on it (like \&quot;Dismantle\&quot;), it will be defined here if you care.
    /// </summary>
    public sealed class DestinyDefinitionsDestinyItemActionBlockDefinition:  IEquatable<DestinyDefinitionsDestinyItemActionBlockDefinition>
    { 
        /// <summary>
        /// Localized text for the verb of the action being performed.
        /// </summary>
        public string VerbName { get; private set; }

        /// <summary>
        /// Localized text describing the action being performed.
        /// </summary>
        public string VerbDescription { get; private set; }

        /// <summary>
        /// The content has this property, however it&#39;s not entirely clear how it is used.
        /// </summary>
        public bool? IsPositive { get; private set; }

        /// <summary>
        /// If the action has an overlay screen associated with it, this is the name of that screen. Unfortunately, we cannot return the screen&#39;s data itself.
        /// </summary>
        public string OverlayScreenName { get; private set; }

        /// <summary>
        /// The icon associated with the overlay screen for the action, if any.
        /// </summary>
        public string OverlayIcon { get; private set; }

        /// <summary>
        /// The number of seconds to delay before allowing this action to be performed again.
        /// </summary>
        public int? RequiredCooldownSeconds { get; private set; }

        /// <summary>
        /// If the action requires other items to exist or be destroyed, this is the list of those items and requirements.
        /// </summary>
        public List<DestinyDefinitionsDestinyItemActionRequiredItemDefinition> RequiredItems { get; private set; }

        /// <summary>
        /// If performing this action earns you Progression, this is the list of progressions and values granted for those progressions by performing this action.
        /// </summary>
        public List<DestinyDefinitionsDestinyProgressionRewardDefinition> ProgressionRewards { get; private set; }

        /// <summary>
        /// The internal identifier for the action.
        /// </summary>
        public string ActionTypeLabel { get; private set; }

        /// <summary>
        /// Theoretically, an item could have a localized string for a hint about the location in which the action should be performed. In practice, no items yet have this property.
        /// </summary>
        public string RequiredLocation { get; private set; }

        /// <summary>
        /// The identifier hash for the Cooldown associated with this action. We have not pulled this data yet for you to have more data to use for cooldowns.
        /// </summary>
        public int? RequiredCooldownHash { get; private set; }

        /// <summary>
        /// If true, the item is deleted when the action completes.
        /// </summary>
        public bool? DeleteOnAction { get; private set; }

        /// <summary>
        /// If true, the entire stack is deleted when the action completes.
        /// </summary>
        public bool? ConsumeEntireStack { get; private set; }

        /// <summary>
        /// If true, this action will be performed as soon as you earn this item. Some rewards work this way, providing you a single item to pick up from a reward-granting vendor in-game and then immediately consuming itself to provide you multiple items.
        /// </summary>
        public bool? UseOnAcquire { get; private set; }


        /// <summary>
        /// Empty constructor required by some serializers.
        /// Use DestinyDefinitionsDestinyItemActionBlockDefinition.Builder() for instance creation instead.
        /// </summary>
        [Obsolete]
        public DestinyDefinitionsDestinyItemActionBlockDefinition()
        {
        }

        private DestinyDefinitionsDestinyItemActionBlockDefinition(string VerbName, string VerbDescription, bool? IsPositive, string OverlayScreenName, string OverlayIcon, int? RequiredCooldownSeconds, List<DestinyDefinitionsDestinyItemActionRequiredItemDefinition> RequiredItems, List<DestinyDefinitionsDestinyProgressionRewardDefinition> ProgressionRewards, string ActionTypeLabel, string RequiredLocation, int? RequiredCooldownHash, bool? DeleteOnAction, bool? ConsumeEntireStack, bool? UseOnAcquire)
        {
            
            this.VerbName = VerbName;
            
            this.VerbDescription = VerbDescription;
            
            this.IsPositive = IsPositive;
            
            this.OverlayScreenName = OverlayScreenName;
            
            this.OverlayIcon = OverlayIcon;
            
            this.RequiredCooldownSeconds = RequiredCooldownSeconds;
            
            this.RequiredItems = RequiredItems;
            
            this.ProgressionRewards = ProgressionRewards;
            
            this.ActionTypeLabel = ActionTypeLabel;
            
            this.RequiredLocation = RequiredLocation;
            
            this.RequiredCooldownHash = RequiredCooldownHash;
            
            this.DeleteOnAction = DeleteOnAction;
            
            this.ConsumeEntireStack = ConsumeEntireStack;
            
            this.UseOnAcquire = UseOnAcquire;
            
        }

        /// <summary>
        /// Returns builder of DestinyDefinitionsDestinyItemActionBlockDefinition.
        /// </summary>
        /// <returns>DestinyDefinitionsDestinyItemActionBlockDefinitionBuilder</returns>
        public static DestinyDefinitionsDestinyItemActionBlockDefinitionBuilder Builder()
        {
            return new DestinyDefinitionsDestinyItemActionBlockDefinitionBuilder();
        }

        /// <summary>
        /// Returns DestinyDefinitionsDestinyItemActionBlockDefinitionBuilder with properties set.
        /// Use it to change properties.
        /// </summary>
        /// <returns>DestinyDefinitionsDestinyItemActionBlockDefinitionBuilder</returns>
        public DestinyDefinitionsDestinyItemActionBlockDefinitionBuilder With()
        {
            return Builder()
                .VerbName(VerbName)
                .VerbDescription(VerbDescription)
                .IsPositive(IsPositive)
                .OverlayScreenName(OverlayScreenName)
                .OverlayIcon(OverlayIcon)
                .RequiredCooldownSeconds(RequiredCooldownSeconds)
                .RequiredItems(RequiredItems)
                .ProgressionRewards(ProgressionRewards)
                .ActionTypeLabel(ActionTypeLabel)
                .RequiredLocation(RequiredLocation)
                .RequiredCooldownHash(RequiredCooldownHash)
                .DeleteOnAction(DeleteOnAction)
                .ConsumeEntireStack(ConsumeEntireStack)
                .UseOnAcquire(UseOnAcquire);
        }

        public override string ToString()
        {
            return this.PropertiesToString();
        }

        public override bool Equals(object obj)
        {
            return this.EqualsByProperties(obj);
        }

        public bool Equals(DestinyDefinitionsDestinyItemActionBlockDefinition other)
        {
            return Equals((object) other);
        }

        public override int GetHashCode()
        {
            return this.PropertiesHash();
        }

        /// <summary>
        /// Implementation of == operator for (DestinyDefinitionsDestinyItemActionBlockDefinition.
        /// </summary>
        /// <param name="left">Compared (DestinyDefinitionsDestinyItemActionBlockDefinition</param>
        /// <param name="right">Compared (DestinyDefinitionsDestinyItemActionBlockDefinition</param>
        /// <returns>true if compared items are equals, false otherwise</returns>
        public static bool operator == (DestinyDefinitionsDestinyItemActionBlockDefinition left, DestinyDefinitionsDestinyItemActionBlockDefinition right)
        {
            return Equals(left, right);
        }

        /// <summary>
        /// Implementation of != operator for (DestinyDefinitionsDestinyItemActionBlockDefinition.
        /// </summary>
        /// <param name="left">Compared (DestinyDefinitionsDestinyItemActionBlockDefinition</param>
        /// <param name="right">Compared (DestinyDefinitionsDestinyItemActionBlockDefinition</param>
        /// <returns>true if compared items are not equals, false otherwise</returns>
        public static bool operator != (DestinyDefinitionsDestinyItemActionBlockDefinition left, DestinyDefinitionsDestinyItemActionBlockDefinition right)
        {
            return !Equals(left, right);
        }

        /// <summary>
        /// Builder of DestinyDefinitionsDestinyItemActionBlockDefinition.
        /// </summary>
        public sealed class DestinyDefinitionsDestinyItemActionBlockDefinitionBuilder
        {
            private string _VerbName;
            private string _VerbDescription;
            private bool? _IsPositive;
            private string _OverlayScreenName;
            private string _OverlayIcon;
            private int? _RequiredCooldownSeconds;
            private List<DestinyDefinitionsDestinyItemActionRequiredItemDefinition> _RequiredItems;
            private List<DestinyDefinitionsDestinyProgressionRewardDefinition> _ProgressionRewards;
            private string _ActionTypeLabel;
            private string _RequiredLocation;
            private int? _RequiredCooldownHash;
            private bool? _DeleteOnAction;
            private bool? _ConsumeEntireStack;
            private bool? _UseOnAcquire;

            internal DestinyDefinitionsDestinyItemActionBlockDefinitionBuilder()
            {
                SetupDefaults();
            }

            private void SetupDefaults()
            {
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsDestinyItemActionBlockDefinition.VerbName property.
            /// </summary>
            /// <param name="value">Localized text for the verb of the action being performed.</param>
            public DestinyDefinitionsDestinyItemActionBlockDefinitionBuilder VerbName(string value)
            {
                _VerbName = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsDestinyItemActionBlockDefinition.VerbDescription property.
            /// </summary>
            /// <param name="value">Localized text describing the action being performed.</param>
            public DestinyDefinitionsDestinyItemActionBlockDefinitionBuilder VerbDescription(string value)
            {
                _VerbDescription = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsDestinyItemActionBlockDefinition.IsPositive property.
            /// </summary>
            /// <param name="value">The content has this property, however it&#39;s not entirely clear how it is used.</param>
            public DestinyDefinitionsDestinyItemActionBlockDefinitionBuilder IsPositive(bool? value)
            {
                _IsPositive = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsDestinyItemActionBlockDefinition.OverlayScreenName property.
            /// </summary>
            /// <param name="value">If the action has an overlay screen associated with it, this is the name of that screen. Unfortunately, we cannot return the screen&#39;s data itself.</param>
            public DestinyDefinitionsDestinyItemActionBlockDefinitionBuilder OverlayScreenName(string value)
            {
                _OverlayScreenName = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsDestinyItemActionBlockDefinition.OverlayIcon property.
            /// </summary>
            /// <param name="value">The icon associated with the overlay screen for the action, if any.</param>
            public DestinyDefinitionsDestinyItemActionBlockDefinitionBuilder OverlayIcon(string value)
            {
                _OverlayIcon = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsDestinyItemActionBlockDefinition.RequiredCooldownSeconds property.
            /// </summary>
            /// <param name="value">The number of seconds to delay before allowing this action to be performed again.</param>
            public DestinyDefinitionsDestinyItemActionBlockDefinitionBuilder RequiredCooldownSeconds(int? value)
            {
                _RequiredCooldownSeconds = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsDestinyItemActionBlockDefinition.RequiredItems property.
            /// </summary>
            /// <param name="value">If the action requires other items to exist or be destroyed, this is the list of those items and requirements.</param>
            public DestinyDefinitionsDestinyItemActionBlockDefinitionBuilder RequiredItems(List<DestinyDefinitionsDestinyItemActionRequiredItemDefinition> value)
            {
                _RequiredItems = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsDestinyItemActionBlockDefinition.ProgressionRewards property.
            /// </summary>
            /// <param name="value">If performing this action earns you Progression, this is the list of progressions and values granted for those progressions by performing this action.</param>
            public DestinyDefinitionsDestinyItemActionBlockDefinitionBuilder ProgressionRewards(List<DestinyDefinitionsDestinyProgressionRewardDefinition> value)
            {
                _ProgressionRewards = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsDestinyItemActionBlockDefinition.ActionTypeLabel property.
            /// </summary>
            /// <param name="value">The internal identifier for the action.</param>
            public DestinyDefinitionsDestinyItemActionBlockDefinitionBuilder ActionTypeLabel(string value)
            {
                _ActionTypeLabel = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsDestinyItemActionBlockDefinition.RequiredLocation property.
            /// </summary>
            /// <param name="value">Theoretically, an item could have a localized string for a hint about the location in which the action should be performed. In practice, no items yet have this property.</param>
            public DestinyDefinitionsDestinyItemActionBlockDefinitionBuilder RequiredLocation(string value)
            {
                _RequiredLocation = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsDestinyItemActionBlockDefinition.RequiredCooldownHash property.
            /// </summary>
            /// <param name="value">The identifier hash for the Cooldown associated with this action. We have not pulled this data yet for you to have more data to use for cooldowns.</param>
            public DestinyDefinitionsDestinyItemActionBlockDefinitionBuilder RequiredCooldownHash(int? value)
            {
                _RequiredCooldownHash = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsDestinyItemActionBlockDefinition.DeleteOnAction property.
            /// </summary>
            /// <param name="value">If true, the item is deleted when the action completes.</param>
            public DestinyDefinitionsDestinyItemActionBlockDefinitionBuilder DeleteOnAction(bool? value)
            {
                _DeleteOnAction = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsDestinyItemActionBlockDefinition.ConsumeEntireStack property.
            /// </summary>
            /// <param name="value">If true, the entire stack is deleted when the action completes.</param>
            public DestinyDefinitionsDestinyItemActionBlockDefinitionBuilder ConsumeEntireStack(bool? value)
            {
                _ConsumeEntireStack = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsDestinyItemActionBlockDefinition.UseOnAcquire property.
            /// </summary>
            /// <param name="value">If true, this action will be performed as soon as you earn this item. Some rewards work this way, providing you a single item to pick up from a reward-granting vendor in-game and then immediately consuming itself to provide you multiple items.</param>
            public DestinyDefinitionsDestinyItemActionBlockDefinitionBuilder UseOnAcquire(bool? value)
            {
                _UseOnAcquire = value;
                return this;
            }


            /// <summary>
            /// Builds instance of DestinyDefinitionsDestinyItemActionBlockDefinition.
            /// </summary>
            /// <returns>DestinyDefinitionsDestinyItemActionBlockDefinition</returns>
            public DestinyDefinitionsDestinyItemActionBlockDefinition Build()
            {
                Validate();
                return new DestinyDefinitionsDestinyItemActionBlockDefinition(
                    VerbName: _VerbName,
                    VerbDescription: _VerbDescription,
                    IsPositive: _IsPositive,
                    OverlayScreenName: _OverlayScreenName,
                    OverlayIcon: _OverlayIcon,
                    RequiredCooldownSeconds: _RequiredCooldownSeconds,
                    RequiredItems: _RequiredItems,
                    ProgressionRewards: _ProgressionRewards,
                    ActionTypeLabel: _ActionTypeLabel,
                    RequiredLocation: _RequiredLocation,
                    RequiredCooldownHash: _RequiredCooldownHash,
                    DeleteOnAction: _DeleteOnAction,
                    ConsumeEntireStack: _ConsumeEntireStack,
                    UseOnAcquire: _UseOnAcquire
                );
            }

            private void Validate()
            { 
            }
        }

        
    }
}