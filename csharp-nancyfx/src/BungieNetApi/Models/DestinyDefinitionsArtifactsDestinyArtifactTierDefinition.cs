using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Sharpility.Extensions;
using NodaTime;

namespace BungieNetApi._Platform.Models
{
    /// <summary>
    /// DestinyDefinitionsArtifactsDestinyArtifactTierDefinition
    /// </summary>
    public sealed class DestinyDefinitionsArtifactsDestinyArtifactTierDefinition:  IEquatable<DestinyDefinitionsArtifactsDestinyArtifactTierDefinition>
    { 
        /// <summary>
        /// An identifier, unique within the Artifact, for this specific tier.
        /// </summary>
        public int? TierHash { get; private set; }

        /// <summary>
        /// The human readable title of this tier, if any.
        /// </summary>
        public string DisplayTitle { get; private set; }

        /// <summary>
        /// A string representing the localized minimum requirement text for this Tier, if any.
        /// </summary>
        public string ProgressRequirementMessage { get; private set; }

        /// <summary>
        /// The items that can be earned within this tier.
        /// </summary>
        public List<DestinyDefinitionsArtifactsDestinyArtifactTierItemDefinition> Items { get; private set; }

        /// <summary>
        /// The minimum number of \&quot;unlock points\&quot; that you must have used before you can unlock items from this tier.
        /// </summary>
        public int? MinimumUnlockPointsUsedRequirement { get; private set; }


        /// <summary>
        /// Empty constructor required by some serializers.
        /// Use DestinyDefinitionsArtifactsDestinyArtifactTierDefinition.Builder() for instance creation instead.
        /// </summary>
        [Obsolete]
        public DestinyDefinitionsArtifactsDestinyArtifactTierDefinition()
        {
        }

        private DestinyDefinitionsArtifactsDestinyArtifactTierDefinition(int? TierHash, string DisplayTitle, string ProgressRequirementMessage, List<DestinyDefinitionsArtifactsDestinyArtifactTierItemDefinition> Items, int? MinimumUnlockPointsUsedRequirement)
        {
            
            this.TierHash = TierHash;
            
            this.DisplayTitle = DisplayTitle;
            
            this.ProgressRequirementMessage = ProgressRequirementMessage;
            
            this.Items = Items;
            
            this.MinimumUnlockPointsUsedRequirement = MinimumUnlockPointsUsedRequirement;
            
        }

        /// <summary>
        /// Returns builder of DestinyDefinitionsArtifactsDestinyArtifactTierDefinition.
        /// </summary>
        /// <returns>DestinyDefinitionsArtifactsDestinyArtifactTierDefinitionBuilder</returns>
        public static DestinyDefinitionsArtifactsDestinyArtifactTierDefinitionBuilder Builder()
        {
            return new DestinyDefinitionsArtifactsDestinyArtifactTierDefinitionBuilder();
        }

        /// <summary>
        /// Returns DestinyDefinitionsArtifactsDestinyArtifactTierDefinitionBuilder with properties set.
        /// Use it to change properties.
        /// </summary>
        /// <returns>DestinyDefinitionsArtifactsDestinyArtifactTierDefinitionBuilder</returns>
        public DestinyDefinitionsArtifactsDestinyArtifactTierDefinitionBuilder With()
        {
            return Builder()
                .TierHash(TierHash)
                .DisplayTitle(DisplayTitle)
                .ProgressRequirementMessage(ProgressRequirementMessage)
                .Items(Items)
                .MinimumUnlockPointsUsedRequirement(MinimumUnlockPointsUsedRequirement);
        }

        public override string ToString()
        {
            return this.PropertiesToString();
        }

        public override bool Equals(object obj)
        {
            return this.EqualsByProperties(obj);
        }

        public bool Equals(DestinyDefinitionsArtifactsDestinyArtifactTierDefinition other)
        {
            return Equals((object) other);
        }

        public override int GetHashCode()
        {
            return this.PropertiesHash();
        }

        /// <summary>
        /// Implementation of == operator for (DestinyDefinitionsArtifactsDestinyArtifactTierDefinition.
        /// </summary>
        /// <param name="left">Compared (DestinyDefinitionsArtifactsDestinyArtifactTierDefinition</param>
        /// <param name="right">Compared (DestinyDefinitionsArtifactsDestinyArtifactTierDefinition</param>
        /// <returns>true if compared items are equals, false otherwise</returns>
        public static bool operator == (DestinyDefinitionsArtifactsDestinyArtifactTierDefinition left, DestinyDefinitionsArtifactsDestinyArtifactTierDefinition right)
        {
            return Equals(left, right);
        }

        /// <summary>
        /// Implementation of != operator for (DestinyDefinitionsArtifactsDestinyArtifactTierDefinition.
        /// </summary>
        /// <param name="left">Compared (DestinyDefinitionsArtifactsDestinyArtifactTierDefinition</param>
        /// <param name="right">Compared (DestinyDefinitionsArtifactsDestinyArtifactTierDefinition</param>
        /// <returns>true if compared items are not equals, false otherwise</returns>
        public static bool operator != (DestinyDefinitionsArtifactsDestinyArtifactTierDefinition left, DestinyDefinitionsArtifactsDestinyArtifactTierDefinition right)
        {
            return !Equals(left, right);
        }

        /// <summary>
        /// Builder of DestinyDefinitionsArtifactsDestinyArtifactTierDefinition.
        /// </summary>
        public sealed class DestinyDefinitionsArtifactsDestinyArtifactTierDefinitionBuilder
        {
            private int? _TierHash;
            private string _DisplayTitle;
            private string _ProgressRequirementMessage;
            private List<DestinyDefinitionsArtifactsDestinyArtifactTierItemDefinition> _Items;
            private int? _MinimumUnlockPointsUsedRequirement;

            internal DestinyDefinitionsArtifactsDestinyArtifactTierDefinitionBuilder()
            {
                SetupDefaults();
            }

            private void SetupDefaults()
            {
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsArtifactsDestinyArtifactTierDefinition.TierHash property.
            /// </summary>
            /// <param name="value">An identifier, unique within the Artifact, for this specific tier.</param>
            public DestinyDefinitionsArtifactsDestinyArtifactTierDefinitionBuilder TierHash(int? value)
            {
                _TierHash = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsArtifactsDestinyArtifactTierDefinition.DisplayTitle property.
            /// </summary>
            /// <param name="value">The human readable title of this tier, if any.</param>
            public DestinyDefinitionsArtifactsDestinyArtifactTierDefinitionBuilder DisplayTitle(string value)
            {
                _DisplayTitle = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsArtifactsDestinyArtifactTierDefinition.ProgressRequirementMessage property.
            /// </summary>
            /// <param name="value">A string representing the localized minimum requirement text for this Tier, if any.</param>
            public DestinyDefinitionsArtifactsDestinyArtifactTierDefinitionBuilder ProgressRequirementMessage(string value)
            {
                _ProgressRequirementMessage = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsArtifactsDestinyArtifactTierDefinition.Items property.
            /// </summary>
            /// <param name="value">The items that can be earned within this tier.</param>
            public DestinyDefinitionsArtifactsDestinyArtifactTierDefinitionBuilder Items(List<DestinyDefinitionsArtifactsDestinyArtifactTierItemDefinition> value)
            {
                _Items = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsArtifactsDestinyArtifactTierDefinition.MinimumUnlockPointsUsedRequirement property.
            /// </summary>
            /// <param name="value">The minimum number of \&quot;unlock points\&quot; that you must have used before you can unlock items from this tier.</param>
            public DestinyDefinitionsArtifactsDestinyArtifactTierDefinitionBuilder MinimumUnlockPointsUsedRequirement(int? value)
            {
                _MinimumUnlockPointsUsedRequirement = value;
                return this;
            }


            /// <summary>
            /// Builds instance of DestinyDefinitionsArtifactsDestinyArtifactTierDefinition.
            /// </summary>
            /// <returns>DestinyDefinitionsArtifactsDestinyArtifactTierDefinition</returns>
            public DestinyDefinitionsArtifactsDestinyArtifactTierDefinition Build()
            {
                Validate();
                return new DestinyDefinitionsArtifactsDestinyArtifactTierDefinition(
                    TierHash: _TierHash,
                    DisplayTitle: _DisplayTitle,
                    ProgressRequirementMessage: _ProgressRequirementMessage,
                    Items: _Items,
                    MinimumUnlockPointsUsedRequirement: _MinimumUnlockPointsUsedRequirement
                );
            }

            private void Validate()
            { 
            }
        }

        
    }
}