using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Sharpility.Extensions;
using NodaTime;

namespace BungieNetApi._Platform.Models
{
    /// <summary>
    /// This describes links between the current graph and others, as well as when that link is relevant.
    /// </summary>
    public sealed class DestinyDefinitionsDirectorDestinyLinkedGraphDefinition:  IEquatable<DestinyDefinitionsDirectorDestinyLinkedGraphDefinition>
    { 
        /// <summary>
        /// Description
        /// </summary>
        public string Description { get; private set; }

        /// <summary>
        /// Name
        /// </summary>
        public string Name { get; private set; }

        /// <summary>
        /// UnlockExpression
        /// </summary>
        public DestinyDefinitionsDestinyUnlockExpressionDefinition UnlockExpression { get; private set; }

        /// <summary>
        /// LinkedGraphId
        /// </summary>
        public int? LinkedGraphId { get; private set; }

        /// <summary>
        /// LinkedGraphs
        /// </summary>
        public List<DestinyDefinitionsDirectorDestinyLinkedGraphEntryDefinition> LinkedGraphs { get; private set; }

        /// <summary>
        /// Overview
        /// </summary>
        public string Overview { get; private set; }


        /// <summary>
        /// Empty constructor required by some serializers.
        /// Use DestinyDefinitionsDirectorDestinyLinkedGraphDefinition.Builder() for instance creation instead.
        /// </summary>
        [Obsolete]
        public DestinyDefinitionsDirectorDestinyLinkedGraphDefinition()
        {
        }

        private DestinyDefinitionsDirectorDestinyLinkedGraphDefinition(string Description, string Name, DestinyDefinitionsDestinyUnlockExpressionDefinition UnlockExpression, int? LinkedGraphId, List<DestinyDefinitionsDirectorDestinyLinkedGraphEntryDefinition> LinkedGraphs, string Overview)
        {
            
            this.Description = Description;
            
            this.Name = Name;
            
            this.UnlockExpression = UnlockExpression;
            
            this.LinkedGraphId = LinkedGraphId;
            
            this.LinkedGraphs = LinkedGraphs;
            
            this.Overview = Overview;
            
        }

        /// <summary>
        /// Returns builder of DestinyDefinitionsDirectorDestinyLinkedGraphDefinition.
        /// </summary>
        /// <returns>DestinyDefinitionsDirectorDestinyLinkedGraphDefinitionBuilder</returns>
        public static DestinyDefinitionsDirectorDestinyLinkedGraphDefinitionBuilder Builder()
        {
            return new DestinyDefinitionsDirectorDestinyLinkedGraphDefinitionBuilder();
        }

        /// <summary>
        /// Returns DestinyDefinitionsDirectorDestinyLinkedGraphDefinitionBuilder with properties set.
        /// Use it to change properties.
        /// </summary>
        /// <returns>DestinyDefinitionsDirectorDestinyLinkedGraphDefinitionBuilder</returns>
        public DestinyDefinitionsDirectorDestinyLinkedGraphDefinitionBuilder With()
        {
            return Builder()
                .Description(Description)
                .Name(Name)
                .UnlockExpression(UnlockExpression)
                .LinkedGraphId(LinkedGraphId)
                .LinkedGraphs(LinkedGraphs)
                .Overview(Overview);
        }

        public override string ToString()
        {
            return this.PropertiesToString();
        }

        public override bool Equals(object obj)
        {
            return this.EqualsByProperties(obj);
        }

        public bool Equals(DestinyDefinitionsDirectorDestinyLinkedGraphDefinition other)
        {
            return Equals((object) other);
        }

        public override int GetHashCode()
        {
            return this.PropertiesHash();
        }

        /// <summary>
        /// Implementation of == operator for (DestinyDefinitionsDirectorDestinyLinkedGraphDefinition.
        /// </summary>
        /// <param name="left">Compared (DestinyDefinitionsDirectorDestinyLinkedGraphDefinition</param>
        /// <param name="right">Compared (DestinyDefinitionsDirectorDestinyLinkedGraphDefinition</param>
        /// <returns>true if compared items are equals, false otherwise</returns>
        public static bool operator == (DestinyDefinitionsDirectorDestinyLinkedGraphDefinition left, DestinyDefinitionsDirectorDestinyLinkedGraphDefinition right)
        {
            return Equals(left, right);
        }

        /// <summary>
        /// Implementation of != operator for (DestinyDefinitionsDirectorDestinyLinkedGraphDefinition.
        /// </summary>
        /// <param name="left">Compared (DestinyDefinitionsDirectorDestinyLinkedGraphDefinition</param>
        /// <param name="right">Compared (DestinyDefinitionsDirectorDestinyLinkedGraphDefinition</param>
        /// <returns>true if compared items are not equals, false otherwise</returns>
        public static bool operator != (DestinyDefinitionsDirectorDestinyLinkedGraphDefinition left, DestinyDefinitionsDirectorDestinyLinkedGraphDefinition right)
        {
            return !Equals(left, right);
        }

        /// <summary>
        /// Builder of DestinyDefinitionsDirectorDestinyLinkedGraphDefinition.
        /// </summary>
        public sealed class DestinyDefinitionsDirectorDestinyLinkedGraphDefinitionBuilder
        {
            private string _Description;
            private string _Name;
            private DestinyDefinitionsDestinyUnlockExpressionDefinition _UnlockExpression;
            private int? _LinkedGraphId;
            private List<DestinyDefinitionsDirectorDestinyLinkedGraphEntryDefinition> _LinkedGraphs;
            private string _Overview;

            internal DestinyDefinitionsDirectorDestinyLinkedGraphDefinitionBuilder()
            {
                SetupDefaults();
            }

            private void SetupDefaults()
            {
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsDirectorDestinyLinkedGraphDefinition.Description property.
            /// </summary>
            /// <param name="value">Description</param>
            public DestinyDefinitionsDirectorDestinyLinkedGraphDefinitionBuilder Description(string value)
            {
                _Description = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsDirectorDestinyLinkedGraphDefinition.Name property.
            /// </summary>
            /// <param name="value">Name</param>
            public DestinyDefinitionsDirectorDestinyLinkedGraphDefinitionBuilder Name(string value)
            {
                _Name = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsDirectorDestinyLinkedGraphDefinition.UnlockExpression property.
            /// </summary>
            /// <param name="value">UnlockExpression</param>
            public DestinyDefinitionsDirectorDestinyLinkedGraphDefinitionBuilder UnlockExpression(DestinyDefinitionsDestinyUnlockExpressionDefinition value)
            {
                _UnlockExpression = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsDirectorDestinyLinkedGraphDefinition.LinkedGraphId property.
            /// </summary>
            /// <param name="value">LinkedGraphId</param>
            public DestinyDefinitionsDirectorDestinyLinkedGraphDefinitionBuilder LinkedGraphId(int? value)
            {
                _LinkedGraphId = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsDirectorDestinyLinkedGraphDefinition.LinkedGraphs property.
            /// </summary>
            /// <param name="value">LinkedGraphs</param>
            public DestinyDefinitionsDirectorDestinyLinkedGraphDefinitionBuilder LinkedGraphs(List<DestinyDefinitionsDirectorDestinyLinkedGraphEntryDefinition> value)
            {
                _LinkedGraphs = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsDirectorDestinyLinkedGraphDefinition.Overview property.
            /// </summary>
            /// <param name="value">Overview</param>
            public DestinyDefinitionsDirectorDestinyLinkedGraphDefinitionBuilder Overview(string value)
            {
                _Overview = value;
                return this;
            }


            /// <summary>
            /// Builds instance of DestinyDefinitionsDirectorDestinyLinkedGraphDefinition.
            /// </summary>
            /// <returns>DestinyDefinitionsDirectorDestinyLinkedGraphDefinition</returns>
            public DestinyDefinitionsDirectorDestinyLinkedGraphDefinition Build()
            {
                Validate();
                return new DestinyDefinitionsDirectorDestinyLinkedGraphDefinition(
                    Description: _Description,
                    Name: _Name,
                    UnlockExpression: _UnlockExpression,
                    LinkedGraphId: _LinkedGraphId,
                    LinkedGraphs: _LinkedGraphs,
                    Overview: _Overview
                );
            }

            private void Validate()
            { 
            }
        }

        
    }
}