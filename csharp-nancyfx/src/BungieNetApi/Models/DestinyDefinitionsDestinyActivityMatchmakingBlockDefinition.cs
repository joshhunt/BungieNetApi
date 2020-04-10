using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Sharpility.Extensions;
using NodaTime;

namespace BungieNetApi._Platform.Models
{
    /// <summary>
    /// Information about matchmaking and party size for the activity.
    /// </summary>
    public sealed class DestinyDefinitionsDestinyActivityMatchmakingBlockDefinition:  IEquatable<DestinyDefinitionsDestinyActivityMatchmakingBlockDefinition>
    { 
        /// <summary>
        /// If TRUE, the activity is matchmade. Otherwise, it requires explicit forming of a party.
        /// </summary>
        public bool? IsMatchmade { get; private set; }

        /// <summary>
        /// The minimum # of people in the fireteam for the activity to launch.
        /// </summary>
        public int? MinParty { get; private set; }

        /// <summary>
        /// The maximum # of people allowed in a Fireteam.
        /// </summary>
        public int? MaxParty { get; private set; }

        /// <summary>
        /// The maximum # of people allowed across all teams in the activity.
        /// </summary>
        public int? MaxPlayers { get; private set; }

        /// <summary>
        /// If true, you have to Solemnly Swear to be up to Nothing But Good(tm) to play.
        /// </summary>
        public bool? RequiresGuardianOath { get; private set; }


        /// <summary>
        /// Empty constructor required by some serializers.
        /// Use DestinyDefinitionsDestinyActivityMatchmakingBlockDefinition.Builder() for instance creation instead.
        /// </summary>
        [Obsolete]
        public DestinyDefinitionsDestinyActivityMatchmakingBlockDefinition()
        {
        }

        private DestinyDefinitionsDestinyActivityMatchmakingBlockDefinition(bool? IsMatchmade, int? MinParty, int? MaxParty, int? MaxPlayers, bool? RequiresGuardianOath)
        {
            
            this.IsMatchmade = IsMatchmade;
            
            this.MinParty = MinParty;
            
            this.MaxParty = MaxParty;
            
            this.MaxPlayers = MaxPlayers;
            
            this.RequiresGuardianOath = RequiresGuardianOath;
            
        }

        /// <summary>
        /// Returns builder of DestinyDefinitionsDestinyActivityMatchmakingBlockDefinition.
        /// </summary>
        /// <returns>DestinyDefinitionsDestinyActivityMatchmakingBlockDefinitionBuilder</returns>
        public static DestinyDefinitionsDestinyActivityMatchmakingBlockDefinitionBuilder Builder()
        {
            return new DestinyDefinitionsDestinyActivityMatchmakingBlockDefinitionBuilder();
        }

        /// <summary>
        /// Returns DestinyDefinitionsDestinyActivityMatchmakingBlockDefinitionBuilder with properties set.
        /// Use it to change properties.
        /// </summary>
        /// <returns>DestinyDefinitionsDestinyActivityMatchmakingBlockDefinitionBuilder</returns>
        public DestinyDefinitionsDestinyActivityMatchmakingBlockDefinitionBuilder With()
        {
            return Builder()
                .IsMatchmade(IsMatchmade)
                .MinParty(MinParty)
                .MaxParty(MaxParty)
                .MaxPlayers(MaxPlayers)
                .RequiresGuardianOath(RequiresGuardianOath);
        }

        public override string ToString()
        {
            return this.PropertiesToString();
        }

        public override bool Equals(object obj)
        {
            return this.EqualsByProperties(obj);
        }

        public bool Equals(DestinyDefinitionsDestinyActivityMatchmakingBlockDefinition other)
        {
            return Equals((object) other);
        }

        public override int GetHashCode()
        {
            return this.PropertiesHash();
        }

        /// <summary>
        /// Implementation of == operator for (DestinyDefinitionsDestinyActivityMatchmakingBlockDefinition.
        /// </summary>
        /// <param name="left">Compared (DestinyDefinitionsDestinyActivityMatchmakingBlockDefinition</param>
        /// <param name="right">Compared (DestinyDefinitionsDestinyActivityMatchmakingBlockDefinition</param>
        /// <returns>true if compared items are equals, false otherwise</returns>
        public static bool operator == (DestinyDefinitionsDestinyActivityMatchmakingBlockDefinition left, DestinyDefinitionsDestinyActivityMatchmakingBlockDefinition right)
        {
            return Equals(left, right);
        }

        /// <summary>
        /// Implementation of != operator for (DestinyDefinitionsDestinyActivityMatchmakingBlockDefinition.
        /// </summary>
        /// <param name="left">Compared (DestinyDefinitionsDestinyActivityMatchmakingBlockDefinition</param>
        /// <param name="right">Compared (DestinyDefinitionsDestinyActivityMatchmakingBlockDefinition</param>
        /// <returns>true if compared items are not equals, false otherwise</returns>
        public static bool operator != (DestinyDefinitionsDestinyActivityMatchmakingBlockDefinition left, DestinyDefinitionsDestinyActivityMatchmakingBlockDefinition right)
        {
            return !Equals(left, right);
        }

        /// <summary>
        /// Builder of DestinyDefinitionsDestinyActivityMatchmakingBlockDefinition.
        /// </summary>
        public sealed class DestinyDefinitionsDestinyActivityMatchmakingBlockDefinitionBuilder
        {
            private bool? _IsMatchmade;
            private int? _MinParty;
            private int? _MaxParty;
            private int? _MaxPlayers;
            private bool? _RequiresGuardianOath;

            internal DestinyDefinitionsDestinyActivityMatchmakingBlockDefinitionBuilder()
            {
                SetupDefaults();
            }

            private void SetupDefaults()
            {
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsDestinyActivityMatchmakingBlockDefinition.IsMatchmade property.
            /// </summary>
            /// <param name="value">If TRUE, the activity is matchmade. Otherwise, it requires explicit forming of a party.</param>
            public DestinyDefinitionsDestinyActivityMatchmakingBlockDefinitionBuilder IsMatchmade(bool? value)
            {
                _IsMatchmade = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsDestinyActivityMatchmakingBlockDefinition.MinParty property.
            /// </summary>
            /// <param name="value">The minimum # of people in the fireteam for the activity to launch.</param>
            public DestinyDefinitionsDestinyActivityMatchmakingBlockDefinitionBuilder MinParty(int? value)
            {
                _MinParty = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsDestinyActivityMatchmakingBlockDefinition.MaxParty property.
            /// </summary>
            /// <param name="value">The maximum # of people allowed in a Fireteam.</param>
            public DestinyDefinitionsDestinyActivityMatchmakingBlockDefinitionBuilder MaxParty(int? value)
            {
                _MaxParty = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsDestinyActivityMatchmakingBlockDefinition.MaxPlayers property.
            /// </summary>
            /// <param name="value">The maximum # of people allowed across all teams in the activity.</param>
            public DestinyDefinitionsDestinyActivityMatchmakingBlockDefinitionBuilder MaxPlayers(int? value)
            {
                _MaxPlayers = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsDestinyActivityMatchmakingBlockDefinition.RequiresGuardianOath property.
            /// </summary>
            /// <param name="value">If true, you have to Solemnly Swear to be up to Nothing But Good(tm) to play.</param>
            public DestinyDefinitionsDestinyActivityMatchmakingBlockDefinitionBuilder RequiresGuardianOath(bool? value)
            {
                _RequiresGuardianOath = value;
                return this;
            }


            /// <summary>
            /// Builds instance of DestinyDefinitionsDestinyActivityMatchmakingBlockDefinition.
            /// </summary>
            /// <returns>DestinyDefinitionsDestinyActivityMatchmakingBlockDefinition</returns>
            public DestinyDefinitionsDestinyActivityMatchmakingBlockDefinition Build()
            {
                Validate();
                return new DestinyDefinitionsDestinyActivityMatchmakingBlockDefinition(
                    IsMatchmade: _IsMatchmade,
                    MinParty: _MinParty,
                    MaxParty: _MaxParty,
                    MaxPlayers: _MaxPlayers,
                    RequiresGuardianOath: _RequiresGuardianOath
                );
            }

            private void Validate()
            { 
            }
        }

        
    }
}