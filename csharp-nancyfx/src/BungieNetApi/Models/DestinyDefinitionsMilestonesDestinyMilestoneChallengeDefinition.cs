using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Sharpility.Extensions;
using NodaTime;

namespace BungieNetApi._Platform.Models
{
    /// <summary>
    /// DestinyDefinitionsMilestonesDestinyMilestoneChallengeDefinition
    /// </summary>
    public sealed class DestinyDefinitionsMilestonesDestinyMilestoneChallengeDefinition:  IEquatable<DestinyDefinitionsMilestonesDestinyMilestoneChallengeDefinition>
    { 
        /// <summary>
        /// The challenge related to this milestone.
        /// </summary>
        public int? ChallengeObjectiveHash { get; private set; }


        /// <summary>
        /// Empty constructor required by some serializers.
        /// Use DestinyDefinitionsMilestonesDestinyMilestoneChallengeDefinition.Builder() for instance creation instead.
        /// </summary>
        [Obsolete]
        public DestinyDefinitionsMilestonesDestinyMilestoneChallengeDefinition()
        {
        }

        private DestinyDefinitionsMilestonesDestinyMilestoneChallengeDefinition(int? ChallengeObjectiveHash)
        {
            
            this.ChallengeObjectiveHash = ChallengeObjectiveHash;
            
        }

        /// <summary>
        /// Returns builder of DestinyDefinitionsMilestonesDestinyMilestoneChallengeDefinition.
        /// </summary>
        /// <returns>DestinyDefinitionsMilestonesDestinyMilestoneChallengeDefinitionBuilder</returns>
        public static DestinyDefinitionsMilestonesDestinyMilestoneChallengeDefinitionBuilder Builder()
        {
            return new DestinyDefinitionsMilestonesDestinyMilestoneChallengeDefinitionBuilder();
        }

        /// <summary>
        /// Returns DestinyDefinitionsMilestonesDestinyMilestoneChallengeDefinitionBuilder with properties set.
        /// Use it to change properties.
        /// </summary>
        /// <returns>DestinyDefinitionsMilestonesDestinyMilestoneChallengeDefinitionBuilder</returns>
        public DestinyDefinitionsMilestonesDestinyMilestoneChallengeDefinitionBuilder With()
        {
            return Builder()
                .ChallengeObjectiveHash(ChallengeObjectiveHash);
        }

        public override string ToString()
        {
            return this.PropertiesToString();
        }

        public override bool Equals(object obj)
        {
            return this.EqualsByProperties(obj);
        }

        public bool Equals(DestinyDefinitionsMilestonesDestinyMilestoneChallengeDefinition other)
        {
            return Equals((object) other);
        }

        public override int GetHashCode()
        {
            return this.PropertiesHash();
        }

        /// <summary>
        /// Implementation of == operator for (DestinyDefinitionsMilestonesDestinyMilestoneChallengeDefinition.
        /// </summary>
        /// <param name="left">Compared (DestinyDefinitionsMilestonesDestinyMilestoneChallengeDefinition</param>
        /// <param name="right">Compared (DestinyDefinitionsMilestonesDestinyMilestoneChallengeDefinition</param>
        /// <returns>true if compared items are equals, false otherwise</returns>
        public static bool operator == (DestinyDefinitionsMilestonesDestinyMilestoneChallengeDefinition left, DestinyDefinitionsMilestonesDestinyMilestoneChallengeDefinition right)
        {
            return Equals(left, right);
        }

        /// <summary>
        /// Implementation of != operator for (DestinyDefinitionsMilestonesDestinyMilestoneChallengeDefinition.
        /// </summary>
        /// <param name="left">Compared (DestinyDefinitionsMilestonesDestinyMilestoneChallengeDefinition</param>
        /// <param name="right">Compared (DestinyDefinitionsMilestonesDestinyMilestoneChallengeDefinition</param>
        /// <returns>true if compared items are not equals, false otherwise</returns>
        public static bool operator != (DestinyDefinitionsMilestonesDestinyMilestoneChallengeDefinition left, DestinyDefinitionsMilestonesDestinyMilestoneChallengeDefinition right)
        {
            return !Equals(left, right);
        }

        /// <summary>
        /// Builder of DestinyDefinitionsMilestonesDestinyMilestoneChallengeDefinition.
        /// </summary>
        public sealed class DestinyDefinitionsMilestonesDestinyMilestoneChallengeDefinitionBuilder
        {
            private int? _ChallengeObjectiveHash;

            internal DestinyDefinitionsMilestonesDestinyMilestoneChallengeDefinitionBuilder()
            {
                SetupDefaults();
            }

            private void SetupDefaults()
            {
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsMilestonesDestinyMilestoneChallengeDefinition.ChallengeObjectiveHash property.
            /// </summary>
            /// <param name="value">The challenge related to this milestone.</param>
            public DestinyDefinitionsMilestonesDestinyMilestoneChallengeDefinitionBuilder ChallengeObjectiveHash(int? value)
            {
                _ChallengeObjectiveHash = value;
                return this;
            }


            /// <summary>
            /// Builds instance of DestinyDefinitionsMilestonesDestinyMilestoneChallengeDefinition.
            /// </summary>
            /// <returns>DestinyDefinitionsMilestonesDestinyMilestoneChallengeDefinition</returns>
            public DestinyDefinitionsMilestonesDestinyMilestoneChallengeDefinition Build()
            {
                Validate();
                return new DestinyDefinitionsMilestonesDestinyMilestoneChallengeDefinition(
                    ChallengeObjectiveHash: _ChallengeObjectiveHash
                );
            }

            private void Validate()
            { 
            }
        }

        
    }
}