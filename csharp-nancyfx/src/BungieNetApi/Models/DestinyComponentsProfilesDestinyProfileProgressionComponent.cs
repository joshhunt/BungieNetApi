using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Sharpility.Extensions;
using NodaTime;

namespace BungieNetApi._Platform.Models
{
    /// <summary>
    /// The set of progression-related information that applies at a Profile-wide level for your Destiny experience. This differs from the Jimi Hendrix Experience because there&#39;s less guitars on fire. Yet. #spoileralert?  This will include information such as Checklist info.
    /// </summary>
    public sealed class DestinyComponentsProfilesDestinyProfileProgressionComponent:  IEquatable<DestinyComponentsProfilesDestinyProfileProgressionComponent>
    { 
        /// <summary>
        /// The set of checklists that can be examined on a profile-wide basis, keyed by the hash identifier of the Checklist (DestinyChecklistDefinition)  For each checklist returned, its value is itself a Dictionary keyed by the checklist&#39;s hash identifier with the value being a boolean indicating if it&#39;s been discovered yet.
        /// </summary>
        public Dictionary<string, Dictionary<string, bool?>> Checklists { get; private set; }

        /// <summary>
        /// Data related to your progress on the current season&#39;s artifact that is the same across characters.
        /// </summary>
        public DestinyArtifactsDestinyArtifactProfileScoped SeasonalArtifact { get; private set; }


        /// <summary>
        /// Empty constructor required by some serializers.
        /// Use DestinyComponentsProfilesDestinyProfileProgressionComponent.Builder() for instance creation instead.
        /// </summary>
        [Obsolete]
        public DestinyComponentsProfilesDestinyProfileProgressionComponent()
        {
        }

        private DestinyComponentsProfilesDestinyProfileProgressionComponent(Dictionary<string, Dictionary<string, bool?>> Checklists, DestinyArtifactsDestinyArtifactProfileScoped SeasonalArtifact)
        {
            
            this.Checklists = Checklists;
            
            this.SeasonalArtifact = SeasonalArtifact;
            
        }

        /// <summary>
        /// Returns builder of DestinyComponentsProfilesDestinyProfileProgressionComponent.
        /// </summary>
        /// <returns>DestinyComponentsProfilesDestinyProfileProgressionComponentBuilder</returns>
        public static DestinyComponentsProfilesDestinyProfileProgressionComponentBuilder Builder()
        {
            return new DestinyComponentsProfilesDestinyProfileProgressionComponentBuilder();
        }

        /// <summary>
        /// Returns DestinyComponentsProfilesDestinyProfileProgressionComponentBuilder with properties set.
        /// Use it to change properties.
        /// </summary>
        /// <returns>DestinyComponentsProfilesDestinyProfileProgressionComponentBuilder</returns>
        public DestinyComponentsProfilesDestinyProfileProgressionComponentBuilder With()
        {
            return Builder()
                .Checklists(Checklists)
                .SeasonalArtifact(SeasonalArtifact);
        }

        public override string ToString()
        {
            return this.PropertiesToString();
        }

        public override bool Equals(object obj)
        {
            return this.EqualsByProperties(obj);
        }

        public bool Equals(DestinyComponentsProfilesDestinyProfileProgressionComponent other)
        {
            return Equals((object) other);
        }

        public override int GetHashCode()
        {
            return this.PropertiesHash();
        }

        /// <summary>
        /// Implementation of == operator for (DestinyComponentsProfilesDestinyProfileProgressionComponent.
        /// </summary>
        /// <param name="left">Compared (DestinyComponentsProfilesDestinyProfileProgressionComponent</param>
        /// <param name="right">Compared (DestinyComponentsProfilesDestinyProfileProgressionComponent</param>
        /// <returns>true if compared items are equals, false otherwise</returns>
        public static bool operator == (DestinyComponentsProfilesDestinyProfileProgressionComponent left, DestinyComponentsProfilesDestinyProfileProgressionComponent right)
        {
            return Equals(left, right);
        }

        /// <summary>
        /// Implementation of != operator for (DestinyComponentsProfilesDestinyProfileProgressionComponent.
        /// </summary>
        /// <param name="left">Compared (DestinyComponentsProfilesDestinyProfileProgressionComponent</param>
        /// <param name="right">Compared (DestinyComponentsProfilesDestinyProfileProgressionComponent</param>
        /// <returns>true if compared items are not equals, false otherwise</returns>
        public static bool operator != (DestinyComponentsProfilesDestinyProfileProgressionComponent left, DestinyComponentsProfilesDestinyProfileProgressionComponent right)
        {
            return !Equals(left, right);
        }

        /// <summary>
        /// Builder of DestinyComponentsProfilesDestinyProfileProgressionComponent.
        /// </summary>
        public sealed class DestinyComponentsProfilesDestinyProfileProgressionComponentBuilder
        {
            private Dictionary<string, Dictionary<string, bool?>> _Checklists;
            private DestinyArtifactsDestinyArtifactProfileScoped _SeasonalArtifact;

            internal DestinyComponentsProfilesDestinyProfileProgressionComponentBuilder()
            {
                SetupDefaults();
            }

            private void SetupDefaults()
            {
            }

            /// <summary>
            /// Sets value for DestinyComponentsProfilesDestinyProfileProgressionComponent.Checklists property.
            /// </summary>
            /// <param name="value">The set of checklists that can be examined on a profile-wide basis, keyed by the hash identifier of the Checklist (DestinyChecklistDefinition)  For each checklist returned, its value is itself a Dictionary keyed by the checklist&#39;s hash identifier with the value being a boolean indicating if it&#39;s been discovered yet.</param>
            public DestinyComponentsProfilesDestinyProfileProgressionComponentBuilder Checklists(Dictionary<string, Dictionary<string, bool?>> value)
            {
                _Checklists = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyComponentsProfilesDestinyProfileProgressionComponent.SeasonalArtifact property.
            /// </summary>
            /// <param name="value">Data related to your progress on the current season&#39;s artifact that is the same across characters.</param>
            public DestinyComponentsProfilesDestinyProfileProgressionComponentBuilder SeasonalArtifact(DestinyArtifactsDestinyArtifactProfileScoped value)
            {
                _SeasonalArtifact = value;
                return this;
            }


            /// <summary>
            /// Builds instance of DestinyComponentsProfilesDestinyProfileProgressionComponent.
            /// </summary>
            /// <returns>DestinyComponentsProfilesDestinyProfileProgressionComponent</returns>
            public DestinyComponentsProfilesDestinyProfileProgressionComponent Build()
            {
                Validate();
                return new DestinyComponentsProfilesDestinyProfileProgressionComponent(
                    Checklists: _Checklists,
                    SeasonalArtifact: _SeasonalArtifact
                );
            }

            private void Validate()
            { 
            }
        }

        
    }
}