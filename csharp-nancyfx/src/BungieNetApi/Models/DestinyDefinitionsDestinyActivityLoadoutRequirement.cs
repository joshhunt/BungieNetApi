using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Sharpility.Extensions;
using NodaTime;

namespace BungieNetApi._Platform.Models
{
    /// <summary>
    /// DestinyDefinitionsDestinyActivityLoadoutRequirement
    /// </summary>
    public sealed class DestinyDefinitionsDestinyActivityLoadoutRequirement:  IEquatable<DestinyDefinitionsDestinyActivityLoadoutRequirement>
    { 
        /// <summary>
        /// EquipmentSlotHash
        /// </summary>
        public int? EquipmentSlotHash { get; private set; }

        /// <summary>
        /// AllowedEquippedItemHashes
        /// </summary>
        public List<int?> AllowedEquippedItemHashes { get; private set; }

        /// <summary>
        /// AllowedWeaponSubTypes
        /// </summary>
        public List<int?> AllowedWeaponSubTypes { get; private set; }


        /// <summary>
        /// Empty constructor required by some serializers.
        /// Use DestinyDefinitionsDestinyActivityLoadoutRequirement.Builder() for instance creation instead.
        /// </summary>
        [Obsolete]
        public DestinyDefinitionsDestinyActivityLoadoutRequirement()
        {
        }

        private DestinyDefinitionsDestinyActivityLoadoutRequirement(int? EquipmentSlotHash, List<int?> AllowedEquippedItemHashes, List<int?> AllowedWeaponSubTypes)
        {
            
            this.EquipmentSlotHash = EquipmentSlotHash;
            
            this.AllowedEquippedItemHashes = AllowedEquippedItemHashes;
            
            this.AllowedWeaponSubTypes = AllowedWeaponSubTypes;
            
        }

        /// <summary>
        /// Returns builder of DestinyDefinitionsDestinyActivityLoadoutRequirement.
        /// </summary>
        /// <returns>DestinyDefinitionsDestinyActivityLoadoutRequirementBuilder</returns>
        public static DestinyDefinitionsDestinyActivityLoadoutRequirementBuilder Builder()
        {
            return new DestinyDefinitionsDestinyActivityLoadoutRequirementBuilder();
        }

        /// <summary>
        /// Returns DestinyDefinitionsDestinyActivityLoadoutRequirementBuilder with properties set.
        /// Use it to change properties.
        /// </summary>
        /// <returns>DestinyDefinitionsDestinyActivityLoadoutRequirementBuilder</returns>
        public DestinyDefinitionsDestinyActivityLoadoutRequirementBuilder With()
        {
            return Builder()
                .EquipmentSlotHash(EquipmentSlotHash)
                .AllowedEquippedItemHashes(AllowedEquippedItemHashes)
                .AllowedWeaponSubTypes(AllowedWeaponSubTypes);
        }

        public override string ToString()
        {
            return this.PropertiesToString();
        }

        public override bool Equals(object obj)
        {
            return this.EqualsByProperties(obj);
        }

        public bool Equals(DestinyDefinitionsDestinyActivityLoadoutRequirement other)
        {
            return Equals((object) other);
        }

        public override int GetHashCode()
        {
            return this.PropertiesHash();
        }

        /// <summary>
        /// Implementation of == operator for (DestinyDefinitionsDestinyActivityLoadoutRequirement.
        /// </summary>
        /// <param name="left">Compared (DestinyDefinitionsDestinyActivityLoadoutRequirement</param>
        /// <param name="right">Compared (DestinyDefinitionsDestinyActivityLoadoutRequirement</param>
        /// <returns>true if compared items are equals, false otherwise</returns>
        public static bool operator == (DestinyDefinitionsDestinyActivityLoadoutRequirement left, DestinyDefinitionsDestinyActivityLoadoutRequirement right)
        {
            return Equals(left, right);
        }

        /// <summary>
        /// Implementation of != operator for (DestinyDefinitionsDestinyActivityLoadoutRequirement.
        /// </summary>
        /// <param name="left">Compared (DestinyDefinitionsDestinyActivityLoadoutRequirement</param>
        /// <param name="right">Compared (DestinyDefinitionsDestinyActivityLoadoutRequirement</param>
        /// <returns>true if compared items are not equals, false otherwise</returns>
        public static bool operator != (DestinyDefinitionsDestinyActivityLoadoutRequirement left, DestinyDefinitionsDestinyActivityLoadoutRequirement right)
        {
            return !Equals(left, right);
        }

        /// <summary>
        /// Builder of DestinyDefinitionsDestinyActivityLoadoutRequirement.
        /// </summary>
        public sealed class DestinyDefinitionsDestinyActivityLoadoutRequirementBuilder
        {
            private int? _EquipmentSlotHash;
            private List<int?> _AllowedEquippedItemHashes;
            private List<int?> _AllowedWeaponSubTypes;

            internal DestinyDefinitionsDestinyActivityLoadoutRequirementBuilder()
            {
                SetupDefaults();
            }

            private void SetupDefaults()
            {
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsDestinyActivityLoadoutRequirement.EquipmentSlotHash property.
            /// </summary>
            /// <param name="value">EquipmentSlotHash</param>
            public DestinyDefinitionsDestinyActivityLoadoutRequirementBuilder EquipmentSlotHash(int? value)
            {
                _EquipmentSlotHash = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsDestinyActivityLoadoutRequirement.AllowedEquippedItemHashes property.
            /// </summary>
            /// <param name="value">AllowedEquippedItemHashes</param>
            public DestinyDefinitionsDestinyActivityLoadoutRequirementBuilder AllowedEquippedItemHashes(List<int?> value)
            {
                _AllowedEquippedItemHashes = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsDestinyActivityLoadoutRequirement.AllowedWeaponSubTypes property.
            /// </summary>
            /// <param name="value">AllowedWeaponSubTypes</param>
            public DestinyDefinitionsDestinyActivityLoadoutRequirementBuilder AllowedWeaponSubTypes(List<int?> value)
            {
                _AllowedWeaponSubTypes = value;
                return this;
            }


            /// <summary>
            /// Builds instance of DestinyDefinitionsDestinyActivityLoadoutRequirement.
            /// </summary>
            /// <returns>DestinyDefinitionsDestinyActivityLoadoutRequirement</returns>
            public DestinyDefinitionsDestinyActivityLoadoutRequirement Build()
            {
                Validate();
                return new DestinyDefinitionsDestinyActivityLoadoutRequirement(
                    EquipmentSlotHash: _EquipmentSlotHash,
                    AllowedEquippedItemHashes: _AllowedEquippedItemHashes,
                    AllowedWeaponSubTypes: _AllowedWeaponSubTypes
                );
            }

            private void Validate()
            { 
            }
        }

        
    }
}