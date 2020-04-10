using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Sharpility.Extensions;
using NodaTime;

namespace BungieNetApi._Platform.Models
{
    /// <summary>
    /// These properties are an attempt to categorize talent node steps by certain common properties. See the related enumerations for the type of properties being categorized.
    /// </summary>
    public sealed class DestinyDefinitionsDestinyTalentNodeStepGroups:  IEquatable<DestinyDefinitionsDestinyTalentNodeStepGroups>
    { 
        /// <summary>
        /// WeaponPerformance
        /// </summary>
        public int? WeaponPerformance { get; private set; }

        /// <summary>
        /// ImpactEffects
        /// </summary>
        public int? ImpactEffects { get; private set; }

        /// <summary>
        /// GuardianAttributes
        /// </summary>
        public int? GuardianAttributes { get; private set; }

        /// <summary>
        /// LightAbilities
        /// </summary>
        public int? LightAbilities { get; private set; }

        /// <summary>
        /// DamageTypes
        /// </summary>
        public int? DamageTypes { get; private set; }


        /// <summary>
        /// Empty constructor required by some serializers.
        /// Use DestinyDefinitionsDestinyTalentNodeStepGroups.Builder() for instance creation instead.
        /// </summary>
        [Obsolete]
        public DestinyDefinitionsDestinyTalentNodeStepGroups()
        {
        }

        private DestinyDefinitionsDestinyTalentNodeStepGroups(int? WeaponPerformance, int? ImpactEffects, int? GuardianAttributes, int? LightAbilities, int? DamageTypes)
        {
            
            this.WeaponPerformance = WeaponPerformance;
            
            this.ImpactEffects = ImpactEffects;
            
            this.GuardianAttributes = GuardianAttributes;
            
            this.LightAbilities = LightAbilities;
            
            this.DamageTypes = DamageTypes;
            
        }

        /// <summary>
        /// Returns builder of DestinyDefinitionsDestinyTalentNodeStepGroups.
        /// </summary>
        /// <returns>DestinyDefinitionsDestinyTalentNodeStepGroupsBuilder</returns>
        public static DestinyDefinitionsDestinyTalentNodeStepGroupsBuilder Builder()
        {
            return new DestinyDefinitionsDestinyTalentNodeStepGroupsBuilder();
        }

        /// <summary>
        /// Returns DestinyDefinitionsDestinyTalentNodeStepGroupsBuilder with properties set.
        /// Use it to change properties.
        /// </summary>
        /// <returns>DestinyDefinitionsDestinyTalentNodeStepGroupsBuilder</returns>
        public DestinyDefinitionsDestinyTalentNodeStepGroupsBuilder With()
        {
            return Builder()
                .WeaponPerformance(WeaponPerformance)
                .ImpactEffects(ImpactEffects)
                .GuardianAttributes(GuardianAttributes)
                .LightAbilities(LightAbilities)
                .DamageTypes(DamageTypes);
        }

        public override string ToString()
        {
            return this.PropertiesToString();
        }

        public override bool Equals(object obj)
        {
            return this.EqualsByProperties(obj);
        }

        public bool Equals(DestinyDefinitionsDestinyTalentNodeStepGroups other)
        {
            return Equals((object) other);
        }

        public override int GetHashCode()
        {
            return this.PropertiesHash();
        }

        /// <summary>
        /// Implementation of == operator for (DestinyDefinitionsDestinyTalentNodeStepGroups.
        /// </summary>
        /// <param name="left">Compared (DestinyDefinitionsDestinyTalentNodeStepGroups</param>
        /// <param name="right">Compared (DestinyDefinitionsDestinyTalentNodeStepGroups</param>
        /// <returns>true if compared items are equals, false otherwise</returns>
        public static bool operator == (DestinyDefinitionsDestinyTalentNodeStepGroups left, DestinyDefinitionsDestinyTalentNodeStepGroups right)
        {
            return Equals(left, right);
        }

        /// <summary>
        /// Implementation of != operator for (DestinyDefinitionsDestinyTalentNodeStepGroups.
        /// </summary>
        /// <param name="left">Compared (DestinyDefinitionsDestinyTalentNodeStepGroups</param>
        /// <param name="right">Compared (DestinyDefinitionsDestinyTalentNodeStepGroups</param>
        /// <returns>true if compared items are not equals, false otherwise</returns>
        public static bool operator != (DestinyDefinitionsDestinyTalentNodeStepGroups left, DestinyDefinitionsDestinyTalentNodeStepGroups right)
        {
            return !Equals(left, right);
        }

        /// <summary>
        /// Builder of DestinyDefinitionsDestinyTalentNodeStepGroups.
        /// </summary>
        public sealed class DestinyDefinitionsDestinyTalentNodeStepGroupsBuilder
        {
            private int? _WeaponPerformance;
            private int? _ImpactEffects;
            private int? _GuardianAttributes;
            private int? _LightAbilities;
            private int? _DamageTypes;

            internal DestinyDefinitionsDestinyTalentNodeStepGroupsBuilder()
            {
                SetupDefaults();
            }

            private void SetupDefaults()
            {
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsDestinyTalentNodeStepGroups.WeaponPerformance property.
            /// </summary>
            /// <param name="value">WeaponPerformance</param>
            public DestinyDefinitionsDestinyTalentNodeStepGroupsBuilder WeaponPerformance(int? value)
            {
                _WeaponPerformance = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsDestinyTalentNodeStepGroups.ImpactEffects property.
            /// </summary>
            /// <param name="value">ImpactEffects</param>
            public DestinyDefinitionsDestinyTalentNodeStepGroupsBuilder ImpactEffects(int? value)
            {
                _ImpactEffects = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsDestinyTalentNodeStepGroups.GuardianAttributes property.
            /// </summary>
            /// <param name="value">GuardianAttributes</param>
            public DestinyDefinitionsDestinyTalentNodeStepGroupsBuilder GuardianAttributes(int? value)
            {
                _GuardianAttributes = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsDestinyTalentNodeStepGroups.LightAbilities property.
            /// </summary>
            /// <param name="value">LightAbilities</param>
            public DestinyDefinitionsDestinyTalentNodeStepGroupsBuilder LightAbilities(int? value)
            {
                _LightAbilities = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsDestinyTalentNodeStepGroups.DamageTypes property.
            /// </summary>
            /// <param name="value">DamageTypes</param>
            public DestinyDefinitionsDestinyTalentNodeStepGroupsBuilder DamageTypes(int? value)
            {
                _DamageTypes = value;
                return this;
            }


            /// <summary>
            /// Builds instance of DestinyDefinitionsDestinyTalentNodeStepGroups.
            /// </summary>
            /// <returns>DestinyDefinitionsDestinyTalentNodeStepGroups</returns>
            public DestinyDefinitionsDestinyTalentNodeStepGroups Build()
            {
                Validate();
                return new DestinyDefinitionsDestinyTalentNodeStepGroups(
                    WeaponPerformance: _WeaponPerformance,
                    ImpactEffects: _ImpactEffects,
                    GuardianAttributes: _GuardianAttributes,
                    LightAbilities: _LightAbilities,
                    DamageTypes: _DamageTypes
                );
            }

            private void Validate()
            { 
            }
        }

        
    }
}