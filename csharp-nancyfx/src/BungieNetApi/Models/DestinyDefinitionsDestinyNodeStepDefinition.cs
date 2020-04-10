using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Sharpility.Extensions;
using NodaTime;

namespace BungieNetApi._Platform.Models
{
    /// <summary>
    /// This defines the properties of a \&quot;Talent Node Step\&quot;. When you see a talent node in game, the actual visible properties that you see (its icon, description, the perks and stats it provides) are not provided by the Node itself, but rather by the currently active Step on the node.  When a Talent Node is activated, the currently active step&#39;s benefits are conferred upon the item and character.  The currently active step on talent nodes are determined when an item is first instantiated. Sometimes it is random, sometimes it is more deterministic (particularly when a node has only a single step).  Note that, when dealing with Talent Node Steps, you must ensure that you have the latest version of content. stepIndex and nodeStepHash - two ways of identifying the step within a node - are both content version dependent, and thus are subject to change between content updates.
    /// </summary>
    public sealed class DestinyDefinitionsDestinyNodeStepDefinition:  IEquatable<DestinyDefinitionsDestinyNodeStepDefinition>
    { 
        /// <summary>
        /// These are the display properties actually used to render the Talent Node. The currently active step&#39;s displayProperties are shown.
        /// </summary>
        public DestinyDefinitionsCommonDestinyDisplayPropertiesDefinition DisplayProperties { get; private set; }

        /// <summary>
        /// The index of this step in the list of Steps on the Talent Node.  Unfortunately, this is the closest thing we have to an identifier for the Step: steps are not provided a content version agnostic identifier. This means that, when you are dealing with talent nodes, you will need to first ensure that you have the latest version of content.
        /// </summary>
        public int? StepIndex { get; private set; }

        /// <summary>
        /// The hash of this node step. Unfortunately, while it can be used to uniquely identify the step within a node, it is also content version dependent and should not be relied on without ensuring you have the latest vesion of content.
        /// </summary>
        public int? NodeStepHash { get; private set; }

        /// <summary>
        /// If you can interact with this node in some way, this is the localized description of that interaction.
        /// </summary>
        public string InteractionDescription { get; private set; }

        /// <summary>
        /// An enum representing a damage type granted by activating this step, if any.
        /// </summary>
        public int? DamageType { get; private set; }

        /// <summary>
        /// If the step provides a damage type, this will be the hash identifier used to look up the damage type&#39;s DestinyDamageTypeDefinition.
        /// </summary>
        public int? DamageTypeHash { get; private set; }

        /// <summary>
        /// If the step has requirements for activation (they almost always do, if nothing else than for the Talent Grid&#39;s Progression to have reached a certain level), they will be defined here.
        /// </summary>
        public DestinyDefinitionsDestinyNodeActivationRequirement ActivationRequirement { get; private set; }

        /// <summary>
        /// There was a time when talent nodes could be activated multiple times, and the effects of subsequent Steps would be compounded on each other, essentially \&quot;upgrading\&quot; the node. We have moved away from this, but theoretically the capability still exists.  I continue to return this in case it is used in the future: if true and this step is the current step in the node, you are allowed to activate the node a second time to receive the benefits of the next step in the node, which will then become the active step.
        /// </summary>
        public bool? CanActivateNextStep { get; private set; }

        /// <summary>
        /// The stepIndex of the next step in the talent node, or -1 if this is the last step or if the next step to be chosen is random.  This doesn&#39;t really matter anymore unless canActivateNextStep begins to be used again.
        /// </summary>
        public int? NextStepIndex { get; private set; }

        /// <summary>
        /// If true, the next step to be chosen is random, and if you&#39;re allowed to activate the next step. (if canActivateNextStep &#x3D; true)
        /// </summary>
        public bool? IsNextStepRandom { get; private set; }

        /// <summary>
        /// The list of hash identifiers for Perks (DestinySandboxPerkDefinition) that are applied when this step is active. Perks provide a variety of benefits and modifications - examine DestinySandboxPerkDefinition to learn more.
        /// </summary>
        public List<int?> PerkHashes { get; private set; }

        /// <summary>
        /// When the Talent Grid&#39;s progression reaches this value, the circular \&quot;progress bar\&quot; that surrounds the talent node should be shown.  This also indicates the lower bound of said progress bar, with the upper bound being the progress required to reach activationRequirement.gridLevel. (at some point I should precalculate the upper bound and put it in the definition to save people time)
        /// </summary>
        public int? StartProgressionBarAtProgress { get; private set; }

        /// <summary>
        /// When the step provides stat benefits on the item or character, this is the list of hash identifiers for stats (DestinyStatDefinition) that are provided.
        /// </summary>
        public List<int?> StatHashes { get; private set; }

        /// <summary>
        /// If this is true, the step affects the item&#39;s Quality in some way. See DestinyInventoryItemDefinition for more information about the meaning of Quality. I already made a joke about Zen and the Art of Motorcycle Maintenance elsewhere in the documentation, so I will avoid doing it again. Oops too late
        /// </summary>
        public bool? AffectsQuality { get; private set; }

        /// <summary>
        /// In Destiny 1, the Armory&#39;s Perk Filtering was driven by a concept of TalentNodeStepGroups: categorizations of talent nodes based on their functionality. While the Armory isn&#39;t a BNet-facing thing for now, and the new Armory will need to account for Sockets rather than Talent Nodes, this categorization capability feels useful enough to still keep around.
        /// </summary>
        public DestinyDefinitionsDestinyTalentNodeStepGroups StepGroups { get; private set; }

        /// <summary>
        /// If true, this step can affect the level of the item. See DestinyInventoryItemDefintion for more information about item levels and their effect on stats.
        /// </summary>
        public bool? AffectsLevel { get; private set; }

        /// <summary>
        /// If this step is activated, this will be a list of information used to replace socket items with new Plugs. See DestinyInventoryItemDefinition for more information about sockets and plugs.
        /// </summary>
        public List<DestinyDefinitionsDestinyNodeSocketReplaceResponse> SocketReplacements { get; private set; }


        /// <summary>
        /// Empty constructor required by some serializers.
        /// Use DestinyDefinitionsDestinyNodeStepDefinition.Builder() for instance creation instead.
        /// </summary>
        [Obsolete]
        public DestinyDefinitionsDestinyNodeStepDefinition()
        {
        }

        private DestinyDefinitionsDestinyNodeStepDefinition(DestinyDefinitionsCommonDestinyDisplayPropertiesDefinition DisplayProperties, int? StepIndex, int? NodeStepHash, string InteractionDescription, int? DamageType, int? DamageTypeHash, DestinyDefinitionsDestinyNodeActivationRequirement ActivationRequirement, bool? CanActivateNextStep, int? NextStepIndex, bool? IsNextStepRandom, List<int?> PerkHashes, int? StartProgressionBarAtProgress, List<int?> StatHashes, bool? AffectsQuality, DestinyDefinitionsDestinyTalentNodeStepGroups StepGroups, bool? AffectsLevel, List<DestinyDefinitionsDestinyNodeSocketReplaceResponse> SocketReplacements)
        {
            
            this.DisplayProperties = DisplayProperties;
            
            this.StepIndex = StepIndex;
            
            this.NodeStepHash = NodeStepHash;
            
            this.InteractionDescription = InteractionDescription;
            
            this.DamageType = DamageType;
            
            this.DamageTypeHash = DamageTypeHash;
            
            this.ActivationRequirement = ActivationRequirement;
            
            this.CanActivateNextStep = CanActivateNextStep;
            
            this.NextStepIndex = NextStepIndex;
            
            this.IsNextStepRandom = IsNextStepRandom;
            
            this.PerkHashes = PerkHashes;
            
            this.StartProgressionBarAtProgress = StartProgressionBarAtProgress;
            
            this.StatHashes = StatHashes;
            
            this.AffectsQuality = AffectsQuality;
            
            this.StepGroups = StepGroups;
            
            this.AffectsLevel = AffectsLevel;
            
            this.SocketReplacements = SocketReplacements;
            
        }

        /// <summary>
        /// Returns builder of DestinyDefinitionsDestinyNodeStepDefinition.
        /// </summary>
        /// <returns>DestinyDefinitionsDestinyNodeStepDefinitionBuilder</returns>
        public static DestinyDefinitionsDestinyNodeStepDefinitionBuilder Builder()
        {
            return new DestinyDefinitionsDestinyNodeStepDefinitionBuilder();
        }

        /// <summary>
        /// Returns DestinyDefinitionsDestinyNodeStepDefinitionBuilder with properties set.
        /// Use it to change properties.
        /// </summary>
        /// <returns>DestinyDefinitionsDestinyNodeStepDefinitionBuilder</returns>
        public DestinyDefinitionsDestinyNodeStepDefinitionBuilder With()
        {
            return Builder()
                .DisplayProperties(DisplayProperties)
                .StepIndex(StepIndex)
                .NodeStepHash(NodeStepHash)
                .InteractionDescription(InteractionDescription)
                .DamageType(DamageType)
                .DamageTypeHash(DamageTypeHash)
                .ActivationRequirement(ActivationRequirement)
                .CanActivateNextStep(CanActivateNextStep)
                .NextStepIndex(NextStepIndex)
                .IsNextStepRandom(IsNextStepRandom)
                .PerkHashes(PerkHashes)
                .StartProgressionBarAtProgress(StartProgressionBarAtProgress)
                .StatHashes(StatHashes)
                .AffectsQuality(AffectsQuality)
                .StepGroups(StepGroups)
                .AffectsLevel(AffectsLevel)
                .SocketReplacements(SocketReplacements);
        }

        public override string ToString()
        {
            return this.PropertiesToString();
        }

        public override bool Equals(object obj)
        {
            return this.EqualsByProperties(obj);
        }

        public bool Equals(DestinyDefinitionsDestinyNodeStepDefinition other)
        {
            return Equals((object) other);
        }

        public override int GetHashCode()
        {
            return this.PropertiesHash();
        }

        /// <summary>
        /// Implementation of == operator for (DestinyDefinitionsDestinyNodeStepDefinition.
        /// </summary>
        /// <param name="left">Compared (DestinyDefinitionsDestinyNodeStepDefinition</param>
        /// <param name="right">Compared (DestinyDefinitionsDestinyNodeStepDefinition</param>
        /// <returns>true if compared items are equals, false otherwise</returns>
        public static bool operator == (DestinyDefinitionsDestinyNodeStepDefinition left, DestinyDefinitionsDestinyNodeStepDefinition right)
        {
            return Equals(left, right);
        }

        /// <summary>
        /// Implementation of != operator for (DestinyDefinitionsDestinyNodeStepDefinition.
        /// </summary>
        /// <param name="left">Compared (DestinyDefinitionsDestinyNodeStepDefinition</param>
        /// <param name="right">Compared (DestinyDefinitionsDestinyNodeStepDefinition</param>
        /// <returns>true if compared items are not equals, false otherwise</returns>
        public static bool operator != (DestinyDefinitionsDestinyNodeStepDefinition left, DestinyDefinitionsDestinyNodeStepDefinition right)
        {
            return !Equals(left, right);
        }

        /// <summary>
        /// Builder of DestinyDefinitionsDestinyNodeStepDefinition.
        /// </summary>
        public sealed class DestinyDefinitionsDestinyNodeStepDefinitionBuilder
        {
            private DestinyDefinitionsCommonDestinyDisplayPropertiesDefinition _DisplayProperties;
            private int? _StepIndex;
            private int? _NodeStepHash;
            private string _InteractionDescription;
            private int? _DamageType;
            private int? _DamageTypeHash;
            private DestinyDefinitionsDestinyNodeActivationRequirement _ActivationRequirement;
            private bool? _CanActivateNextStep;
            private int? _NextStepIndex;
            private bool? _IsNextStepRandom;
            private List<int?> _PerkHashes;
            private int? _StartProgressionBarAtProgress;
            private List<int?> _StatHashes;
            private bool? _AffectsQuality;
            private DestinyDefinitionsDestinyTalentNodeStepGroups _StepGroups;
            private bool? _AffectsLevel;
            private List<DestinyDefinitionsDestinyNodeSocketReplaceResponse> _SocketReplacements;

            internal DestinyDefinitionsDestinyNodeStepDefinitionBuilder()
            {
                SetupDefaults();
            }

            private void SetupDefaults()
            {
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsDestinyNodeStepDefinition.DisplayProperties property.
            /// </summary>
            /// <param name="value">These are the display properties actually used to render the Talent Node. The currently active step&#39;s displayProperties are shown.</param>
            public DestinyDefinitionsDestinyNodeStepDefinitionBuilder DisplayProperties(DestinyDefinitionsCommonDestinyDisplayPropertiesDefinition value)
            {
                _DisplayProperties = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsDestinyNodeStepDefinition.StepIndex property.
            /// </summary>
            /// <param name="value">The index of this step in the list of Steps on the Talent Node.  Unfortunately, this is the closest thing we have to an identifier for the Step: steps are not provided a content version agnostic identifier. This means that, when you are dealing with talent nodes, you will need to first ensure that you have the latest version of content.</param>
            public DestinyDefinitionsDestinyNodeStepDefinitionBuilder StepIndex(int? value)
            {
                _StepIndex = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsDestinyNodeStepDefinition.NodeStepHash property.
            /// </summary>
            /// <param name="value">The hash of this node step. Unfortunately, while it can be used to uniquely identify the step within a node, it is also content version dependent and should not be relied on without ensuring you have the latest vesion of content.</param>
            public DestinyDefinitionsDestinyNodeStepDefinitionBuilder NodeStepHash(int? value)
            {
                _NodeStepHash = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsDestinyNodeStepDefinition.InteractionDescription property.
            /// </summary>
            /// <param name="value">If you can interact with this node in some way, this is the localized description of that interaction.</param>
            public DestinyDefinitionsDestinyNodeStepDefinitionBuilder InteractionDescription(string value)
            {
                _InteractionDescription = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsDestinyNodeStepDefinition.DamageType property.
            /// </summary>
            /// <param name="value">An enum representing a damage type granted by activating this step, if any.</param>
            public DestinyDefinitionsDestinyNodeStepDefinitionBuilder DamageType(int? value)
            {
                _DamageType = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsDestinyNodeStepDefinition.DamageTypeHash property.
            /// </summary>
            /// <param name="value">If the step provides a damage type, this will be the hash identifier used to look up the damage type&#39;s DestinyDamageTypeDefinition.</param>
            public DestinyDefinitionsDestinyNodeStepDefinitionBuilder DamageTypeHash(int? value)
            {
                _DamageTypeHash = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsDestinyNodeStepDefinition.ActivationRequirement property.
            /// </summary>
            /// <param name="value">If the step has requirements for activation (they almost always do, if nothing else than for the Talent Grid&#39;s Progression to have reached a certain level), they will be defined here.</param>
            public DestinyDefinitionsDestinyNodeStepDefinitionBuilder ActivationRequirement(DestinyDefinitionsDestinyNodeActivationRequirement value)
            {
                _ActivationRequirement = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsDestinyNodeStepDefinition.CanActivateNextStep property.
            /// </summary>
            /// <param name="value">There was a time when talent nodes could be activated multiple times, and the effects of subsequent Steps would be compounded on each other, essentially \&quot;upgrading\&quot; the node. We have moved away from this, but theoretically the capability still exists.  I continue to return this in case it is used in the future: if true and this step is the current step in the node, you are allowed to activate the node a second time to receive the benefits of the next step in the node, which will then become the active step.</param>
            public DestinyDefinitionsDestinyNodeStepDefinitionBuilder CanActivateNextStep(bool? value)
            {
                _CanActivateNextStep = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsDestinyNodeStepDefinition.NextStepIndex property.
            /// </summary>
            /// <param name="value">The stepIndex of the next step in the talent node, or -1 if this is the last step or if the next step to be chosen is random.  This doesn&#39;t really matter anymore unless canActivateNextStep begins to be used again.</param>
            public DestinyDefinitionsDestinyNodeStepDefinitionBuilder NextStepIndex(int? value)
            {
                _NextStepIndex = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsDestinyNodeStepDefinition.IsNextStepRandom property.
            /// </summary>
            /// <param name="value">If true, the next step to be chosen is random, and if you&#39;re allowed to activate the next step. (if canActivateNextStep &#x3D; true)</param>
            public DestinyDefinitionsDestinyNodeStepDefinitionBuilder IsNextStepRandom(bool? value)
            {
                _IsNextStepRandom = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsDestinyNodeStepDefinition.PerkHashes property.
            /// </summary>
            /// <param name="value">The list of hash identifiers for Perks (DestinySandboxPerkDefinition) that are applied when this step is active. Perks provide a variety of benefits and modifications - examine DestinySandboxPerkDefinition to learn more.</param>
            public DestinyDefinitionsDestinyNodeStepDefinitionBuilder PerkHashes(List<int?> value)
            {
                _PerkHashes = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsDestinyNodeStepDefinition.StartProgressionBarAtProgress property.
            /// </summary>
            /// <param name="value">When the Talent Grid&#39;s progression reaches this value, the circular \&quot;progress bar\&quot; that surrounds the talent node should be shown.  This also indicates the lower bound of said progress bar, with the upper bound being the progress required to reach activationRequirement.gridLevel. (at some point I should precalculate the upper bound and put it in the definition to save people time)</param>
            public DestinyDefinitionsDestinyNodeStepDefinitionBuilder StartProgressionBarAtProgress(int? value)
            {
                _StartProgressionBarAtProgress = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsDestinyNodeStepDefinition.StatHashes property.
            /// </summary>
            /// <param name="value">When the step provides stat benefits on the item or character, this is the list of hash identifiers for stats (DestinyStatDefinition) that are provided.</param>
            public DestinyDefinitionsDestinyNodeStepDefinitionBuilder StatHashes(List<int?> value)
            {
                _StatHashes = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsDestinyNodeStepDefinition.AffectsQuality property.
            /// </summary>
            /// <param name="value">If this is true, the step affects the item&#39;s Quality in some way. See DestinyInventoryItemDefinition for more information about the meaning of Quality. I already made a joke about Zen and the Art of Motorcycle Maintenance elsewhere in the documentation, so I will avoid doing it again. Oops too late</param>
            public DestinyDefinitionsDestinyNodeStepDefinitionBuilder AffectsQuality(bool? value)
            {
                _AffectsQuality = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsDestinyNodeStepDefinition.StepGroups property.
            /// </summary>
            /// <param name="value">In Destiny 1, the Armory&#39;s Perk Filtering was driven by a concept of TalentNodeStepGroups: categorizations of talent nodes based on their functionality. While the Armory isn&#39;t a BNet-facing thing for now, and the new Armory will need to account for Sockets rather than Talent Nodes, this categorization capability feels useful enough to still keep around.</param>
            public DestinyDefinitionsDestinyNodeStepDefinitionBuilder StepGroups(DestinyDefinitionsDestinyTalentNodeStepGroups value)
            {
                _StepGroups = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsDestinyNodeStepDefinition.AffectsLevel property.
            /// </summary>
            /// <param name="value">If true, this step can affect the level of the item. See DestinyInventoryItemDefintion for more information about item levels and their effect on stats.</param>
            public DestinyDefinitionsDestinyNodeStepDefinitionBuilder AffectsLevel(bool? value)
            {
                _AffectsLevel = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsDestinyNodeStepDefinition.SocketReplacements property.
            /// </summary>
            /// <param name="value">If this step is activated, this will be a list of information used to replace socket items with new Plugs. See DestinyInventoryItemDefinition for more information about sockets and plugs.</param>
            public DestinyDefinitionsDestinyNodeStepDefinitionBuilder SocketReplacements(List<DestinyDefinitionsDestinyNodeSocketReplaceResponse> value)
            {
                _SocketReplacements = value;
                return this;
            }


            /// <summary>
            /// Builds instance of DestinyDefinitionsDestinyNodeStepDefinition.
            /// </summary>
            /// <returns>DestinyDefinitionsDestinyNodeStepDefinition</returns>
            public DestinyDefinitionsDestinyNodeStepDefinition Build()
            {
                Validate();
                return new DestinyDefinitionsDestinyNodeStepDefinition(
                    DisplayProperties: _DisplayProperties,
                    StepIndex: _StepIndex,
                    NodeStepHash: _NodeStepHash,
                    InteractionDescription: _InteractionDescription,
                    DamageType: _DamageType,
                    DamageTypeHash: _DamageTypeHash,
                    ActivationRequirement: _ActivationRequirement,
                    CanActivateNextStep: _CanActivateNextStep,
                    NextStepIndex: _NextStepIndex,
                    IsNextStepRandom: _IsNextStepRandom,
                    PerkHashes: _PerkHashes,
                    StartProgressionBarAtProgress: _StartProgressionBarAtProgress,
                    StatHashes: _StatHashes,
                    AffectsQuality: _AffectsQuality,
                    StepGroups: _StepGroups,
                    AffectsLevel: _AffectsLevel,
                    SocketReplacements: _SocketReplacements
                );
            }

            private void Validate()
            { 
            }
        }

        
    }
}