using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Sharpility.Extensions;
using NodaTime;

namespace BungieNetApi._Platform.Models
{
    /// <summary>
    /// Many actions relating to items require you to expend materials: - Activating a talent node - Inserting a plug into a socket The items will refer to material requirements by a materialRequirementsHash in these cases, and this is the definition for those requirements in terms of the item required, how much of it is required and other interesting info. This is one of the rare/strange times where a single contract class is used both in definitions *and* in live data response contracts. I&#39;m not sure yet whether I regret that.
    /// </summary>
    public sealed class DestinyDefinitionsDestinyMaterialRequirement:  IEquatable<DestinyDefinitionsDestinyMaterialRequirement>
    { 
        /// <summary>
        /// The hash identifier of the material required. Use it to look up the material&#39;s DestinyInventoryItemDefinition.
        /// </summary>
        public int? ItemHash { get; private set; }

        /// <summary>
        /// If True, the material will be removed from the character&#39;s inventory when the action is performed.
        /// </summary>
        public bool? DeleteOnAction { get; private set; }

        /// <summary>
        /// The amount of the material required.
        /// </summary>
        public int? Count { get; private set; }

        /// <summary>
        /// If True, this requirement is \&quot;silent\&quot;: don&#39;t bother showing it in a material requirements display. I mean, I&#39;m not your mom: I&#39;m not going to tell you you *can&#39;t* show it. But we won&#39;t show it in our UI.
        /// </summary>
        public bool? OmitFromRequirements { get; private set; }


        /// <summary>
        /// Empty constructor required by some serializers.
        /// Use DestinyDefinitionsDestinyMaterialRequirement.Builder() for instance creation instead.
        /// </summary>
        [Obsolete]
        public DestinyDefinitionsDestinyMaterialRequirement()
        {
        }

        private DestinyDefinitionsDestinyMaterialRequirement(int? ItemHash, bool? DeleteOnAction, int? Count, bool? OmitFromRequirements)
        {
            
            this.ItemHash = ItemHash;
            
            this.DeleteOnAction = DeleteOnAction;
            
            this.Count = Count;
            
            this.OmitFromRequirements = OmitFromRequirements;
            
        }

        /// <summary>
        /// Returns builder of DestinyDefinitionsDestinyMaterialRequirement.
        /// </summary>
        /// <returns>DestinyDefinitionsDestinyMaterialRequirementBuilder</returns>
        public static DestinyDefinitionsDestinyMaterialRequirementBuilder Builder()
        {
            return new DestinyDefinitionsDestinyMaterialRequirementBuilder();
        }

        /// <summary>
        /// Returns DestinyDefinitionsDestinyMaterialRequirementBuilder with properties set.
        /// Use it to change properties.
        /// </summary>
        /// <returns>DestinyDefinitionsDestinyMaterialRequirementBuilder</returns>
        public DestinyDefinitionsDestinyMaterialRequirementBuilder With()
        {
            return Builder()
                .ItemHash(ItemHash)
                .DeleteOnAction(DeleteOnAction)
                .Count(Count)
                .OmitFromRequirements(OmitFromRequirements);
        }

        public override string ToString()
        {
            return this.PropertiesToString();
        }

        public override bool Equals(object obj)
        {
            return this.EqualsByProperties(obj);
        }

        public bool Equals(DestinyDefinitionsDestinyMaterialRequirement other)
        {
            return Equals((object) other);
        }

        public override int GetHashCode()
        {
            return this.PropertiesHash();
        }

        /// <summary>
        /// Implementation of == operator for (DestinyDefinitionsDestinyMaterialRequirement.
        /// </summary>
        /// <param name="left">Compared (DestinyDefinitionsDestinyMaterialRequirement</param>
        /// <param name="right">Compared (DestinyDefinitionsDestinyMaterialRequirement</param>
        /// <returns>true if compared items are equals, false otherwise</returns>
        public static bool operator == (DestinyDefinitionsDestinyMaterialRequirement left, DestinyDefinitionsDestinyMaterialRequirement right)
        {
            return Equals(left, right);
        }

        /// <summary>
        /// Implementation of != operator for (DestinyDefinitionsDestinyMaterialRequirement.
        /// </summary>
        /// <param name="left">Compared (DestinyDefinitionsDestinyMaterialRequirement</param>
        /// <param name="right">Compared (DestinyDefinitionsDestinyMaterialRequirement</param>
        /// <returns>true if compared items are not equals, false otherwise</returns>
        public static bool operator != (DestinyDefinitionsDestinyMaterialRequirement left, DestinyDefinitionsDestinyMaterialRequirement right)
        {
            return !Equals(left, right);
        }

        /// <summary>
        /// Builder of DestinyDefinitionsDestinyMaterialRequirement.
        /// </summary>
        public sealed class DestinyDefinitionsDestinyMaterialRequirementBuilder
        {
            private int? _ItemHash;
            private bool? _DeleteOnAction;
            private int? _Count;
            private bool? _OmitFromRequirements;

            internal DestinyDefinitionsDestinyMaterialRequirementBuilder()
            {
                SetupDefaults();
            }

            private void SetupDefaults()
            {
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsDestinyMaterialRequirement.ItemHash property.
            /// </summary>
            /// <param name="value">The hash identifier of the material required. Use it to look up the material&#39;s DestinyInventoryItemDefinition.</param>
            public DestinyDefinitionsDestinyMaterialRequirementBuilder ItemHash(int? value)
            {
                _ItemHash = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsDestinyMaterialRequirement.DeleteOnAction property.
            /// </summary>
            /// <param name="value">If True, the material will be removed from the character&#39;s inventory when the action is performed.</param>
            public DestinyDefinitionsDestinyMaterialRequirementBuilder DeleteOnAction(bool? value)
            {
                _DeleteOnAction = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsDestinyMaterialRequirement.Count property.
            /// </summary>
            /// <param name="value">The amount of the material required.</param>
            public DestinyDefinitionsDestinyMaterialRequirementBuilder Count(int? value)
            {
                _Count = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsDestinyMaterialRequirement.OmitFromRequirements property.
            /// </summary>
            /// <param name="value">If True, this requirement is \&quot;silent\&quot;: don&#39;t bother showing it in a material requirements display. I mean, I&#39;m not your mom: I&#39;m not going to tell you you *can&#39;t* show it. But we won&#39;t show it in our UI.</param>
            public DestinyDefinitionsDestinyMaterialRequirementBuilder OmitFromRequirements(bool? value)
            {
                _OmitFromRequirements = value;
                return this;
            }


            /// <summary>
            /// Builds instance of DestinyDefinitionsDestinyMaterialRequirement.
            /// </summary>
            /// <returns>DestinyDefinitionsDestinyMaterialRequirement</returns>
            public DestinyDefinitionsDestinyMaterialRequirement Build()
            {
                Validate();
                return new DestinyDefinitionsDestinyMaterialRequirement(
                    ItemHash: _ItemHash,
                    DeleteOnAction: _DeleteOnAction,
                    Count: _Count,
                    OmitFromRequirements: _OmitFromRequirements
                );
            }

            private void Validate()
            { 
            }
        }

        
    }
}