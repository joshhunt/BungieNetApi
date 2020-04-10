using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Sharpility.Extensions;
using NodaTime;

namespace BungieNetApi._Platform.Models
{
    /// <summary>
    /// This appears to be information used when rendering rewards. We don&#39;t currently use it on BNet.
    /// </summary>
    public sealed class DestinyDefinitionsDestinyItemSummaryBlockDefinition:  IEquatable<DestinyDefinitionsDestinyItemSummaryBlockDefinition>
    { 
        /// <summary>
        /// Apparently when rendering an item in a reward, this should be used as a sort priority. We&#39;re not doing it presently.
        /// </summary>
        public int? SortPriority { get; private set; }


        /// <summary>
        /// Empty constructor required by some serializers.
        /// Use DestinyDefinitionsDestinyItemSummaryBlockDefinition.Builder() for instance creation instead.
        /// </summary>
        [Obsolete]
        public DestinyDefinitionsDestinyItemSummaryBlockDefinition()
        {
        }

        private DestinyDefinitionsDestinyItemSummaryBlockDefinition(int? SortPriority)
        {
            
            this.SortPriority = SortPriority;
            
        }

        /// <summary>
        /// Returns builder of DestinyDefinitionsDestinyItemSummaryBlockDefinition.
        /// </summary>
        /// <returns>DestinyDefinitionsDestinyItemSummaryBlockDefinitionBuilder</returns>
        public static DestinyDefinitionsDestinyItemSummaryBlockDefinitionBuilder Builder()
        {
            return new DestinyDefinitionsDestinyItemSummaryBlockDefinitionBuilder();
        }

        /// <summary>
        /// Returns DestinyDefinitionsDestinyItemSummaryBlockDefinitionBuilder with properties set.
        /// Use it to change properties.
        /// </summary>
        /// <returns>DestinyDefinitionsDestinyItemSummaryBlockDefinitionBuilder</returns>
        public DestinyDefinitionsDestinyItemSummaryBlockDefinitionBuilder With()
        {
            return Builder()
                .SortPriority(SortPriority);
        }

        public override string ToString()
        {
            return this.PropertiesToString();
        }

        public override bool Equals(object obj)
        {
            return this.EqualsByProperties(obj);
        }

        public bool Equals(DestinyDefinitionsDestinyItemSummaryBlockDefinition other)
        {
            return Equals((object) other);
        }

        public override int GetHashCode()
        {
            return this.PropertiesHash();
        }

        /// <summary>
        /// Implementation of == operator for (DestinyDefinitionsDestinyItemSummaryBlockDefinition.
        /// </summary>
        /// <param name="left">Compared (DestinyDefinitionsDestinyItemSummaryBlockDefinition</param>
        /// <param name="right">Compared (DestinyDefinitionsDestinyItemSummaryBlockDefinition</param>
        /// <returns>true if compared items are equals, false otherwise</returns>
        public static bool operator == (DestinyDefinitionsDestinyItemSummaryBlockDefinition left, DestinyDefinitionsDestinyItemSummaryBlockDefinition right)
        {
            return Equals(left, right);
        }

        /// <summary>
        /// Implementation of != operator for (DestinyDefinitionsDestinyItemSummaryBlockDefinition.
        /// </summary>
        /// <param name="left">Compared (DestinyDefinitionsDestinyItemSummaryBlockDefinition</param>
        /// <param name="right">Compared (DestinyDefinitionsDestinyItemSummaryBlockDefinition</param>
        /// <returns>true if compared items are not equals, false otherwise</returns>
        public static bool operator != (DestinyDefinitionsDestinyItemSummaryBlockDefinition left, DestinyDefinitionsDestinyItemSummaryBlockDefinition right)
        {
            return !Equals(left, right);
        }

        /// <summary>
        /// Builder of DestinyDefinitionsDestinyItemSummaryBlockDefinition.
        /// </summary>
        public sealed class DestinyDefinitionsDestinyItemSummaryBlockDefinitionBuilder
        {
            private int? _SortPriority;

            internal DestinyDefinitionsDestinyItemSummaryBlockDefinitionBuilder()
            {
                SetupDefaults();
            }

            private void SetupDefaults()
            {
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsDestinyItemSummaryBlockDefinition.SortPriority property.
            /// </summary>
            /// <param name="value">Apparently when rendering an item in a reward, this should be used as a sort priority. We&#39;re not doing it presently.</param>
            public DestinyDefinitionsDestinyItemSummaryBlockDefinitionBuilder SortPriority(int? value)
            {
                _SortPriority = value;
                return this;
            }


            /// <summary>
            /// Builds instance of DestinyDefinitionsDestinyItemSummaryBlockDefinition.
            /// </summary>
            /// <returns>DestinyDefinitionsDestinyItemSummaryBlockDefinition</returns>
            public DestinyDefinitionsDestinyItemSummaryBlockDefinition Build()
            {
                Validate();
                return new DestinyDefinitionsDestinyItemSummaryBlockDefinition(
                    SortPriority: _SortPriority
                );
            }

            private void Validate()
            { 
            }
        }

        
    }
}