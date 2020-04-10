using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Sharpility.Extensions;
using NodaTime;

namespace BungieNetApi._Platform.Models
{
    /// <summary>
    /// If a vendor can ever end up performing actions, these are the properties that will be related to those actions. I&#39;m not going to bother documenting this yet, as it is unused and unclear if it will ever be used... but in case it is ever populated and someone finds it useful, it is defined here.
    /// </summary>
    public sealed class DestinyDefinitionsDestinyVendorActionDefinition:  IEquatable<DestinyDefinitionsDestinyVendorActionDefinition>
    { 
        /// <summary>
        /// Description
        /// </summary>
        public string Description { get; private set; }

        /// <summary>
        /// ExecuteSeconds
        /// </summary>
        public int? ExecuteSeconds { get; private set; }

        /// <summary>
        /// Icon
        /// </summary>
        public string Icon { get; private set; }

        /// <summary>
        /// Name
        /// </summary>
        public string Name { get; private set; }

        /// <summary>
        /// Verb
        /// </summary>
        public string Verb { get; private set; }

        /// <summary>
        /// IsPositive
        /// </summary>
        public bool? IsPositive { get; private set; }

        /// <summary>
        /// ActionId
        /// </summary>
        public string ActionId { get; private set; }

        /// <summary>
        /// ActionHash
        /// </summary>
        public int? ActionHash { get; private set; }

        /// <summary>
        /// AutoPerformAction
        /// </summary>
        public bool? AutoPerformAction { get; private set; }


        /// <summary>
        /// Empty constructor required by some serializers.
        /// Use DestinyDefinitionsDestinyVendorActionDefinition.Builder() for instance creation instead.
        /// </summary>
        [Obsolete]
        public DestinyDefinitionsDestinyVendorActionDefinition()
        {
        }

        private DestinyDefinitionsDestinyVendorActionDefinition(string Description, int? ExecuteSeconds, string Icon, string Name, string Verb, bool? IsPositive, string ActionId, int? ActionHash, bool? AutoPerformAction)
        {
            
            this.Description = Description;
            
            this.ExecuteSeconds = ExecuteSeconds;
            
            this.Icon = Icon;
            
            this.Name = Name;
            
            this.Verb = Verb;
            
            this.IsPositive = IsPositive;
            
            this.ActionId = ActionId;
            
            this.ActionHash = ActionHash;
            
            this.AutoPerformAction = AutoPerformAction;
            
        }

        /// <summary>
        /// Returns builder of DestinyDefinitionsDestinyVendorActionDefinition.
        /// </summary>
        /// <returns>DestinyDefinitionsDestinyVendorActionDefinitionBuilder</returns>
        public static DestinyDefinitionsDestinyVendorActionDefinitionBuilder Builder()
        {
            return new DestinyDefinitionsDestinyVendorActionDefinitionBuilder();
        }

        /// <summary>
        /// Returns DestinyDefinitionsDestinyVendorActionDefinitionBuilder with properties set.
        /// Use it to change properties.
        /// </summary>
        /// <returns>DestinyDefinitionsDestinyVendorActionDefinitionBuilder</returns>
        public DestinyDefinitionsDestinyVendorActionDefinitionBuilder With()
        {
            return Builder()
                .Description(Description)
                .ExecuteSeconds(ExecuteSeconds)
                .Icon(Icon)
                .Name(Name)
                .Verb(Verb)
                .IsPositive(IsPositive)
                .ActionId(ActionId)
                .ActionHash(ActionHash)
                .AutoPerformAction(AutoPerformAction);
        }

        public override string ToString()
        {
            return this.PropertiesToString();
        }

        public override bool Equals(object obj)
        {
            return this.EqualsByProperties(obj);
        }

        public bool Equals(DestinyDefinitionsDestinyVendorActionDefinition other)
        {
            return Equals((object) other);
        }

        public override int GetHashCode()
        {
            return this.PropertiesHash();
        }

        /// <summary>
        /// Implementation of == operator for (DestinyDefinitionsDestinyVendorActionDefinition.
        /// </summary>
        /// <param name="left">Compared (DestinyDefinitionsDestinyVendorActionDefinition</param>
        /// <param name="right">Compared (DestinyDefinitionsDestinyVendorActionDefinition</param>
        /// <returns>true if compared items are equals, false otherwise</returns>
        public static bool operator == (DestinyDefinitionsDestinyVendorActionDefinition left, DestinyDefinitionsDestinyVendorActionDefinition right)
        {
            return Equals(left, right);
        }

        /// <summary>
        /// Implementation of != operator for (DestinyDefinitionsDestinyVendorActionDefinition.
        /// </summary>
        /// <param name="left">Compared (DestinyDefinitionsDestinyVendorActionDefinition</param>
        /// <param name="right">Compared (DestinyDefinitionsDestinyVendorActionDefinition</param>
        /// <returns>true if compared items are not equals, false otherwise</returns>
        public static bool operator != (DestinyDefinitionsDestinyVendorActionDefinition left, DestinyDefinitionsDestinyVendorActionDefinition right)
        {
            return !Equals(left, right);
        }

        /// <summary>
        /// Builder of DestinyDefinitionsDestinyVendorActionDefinition.
        /// </summary>
        public sealed class DestinyDefinitionsDestinyVendorActionDefinitionBuilder
        {
            private string _Description;
            private int? _ExecuteSeconds;
            private string _Icon;
            private string _Name;
            private string _Verb;
            private bool? _IsPositive;
            private string _ActionId;
            private int? _ActionHash;
            private bool? _AutoPerformAction;

            internal DestinyDefinitionsDestinyVendorActionDefinitionBuilder()
            {
                SetupDefaults();
            }

            private void SetupDefaults()
            {
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsDestinyVendorActionDefinition.Description property.
            /// </summary>
            /// <param name="value">Description</param>
            public DestinyDefinitionsDestinyVendorActionDefinitionBuilder Description(string value)
            {
                _Description = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsDestinyVendorActionDefinition.ExecuteSeconds property.
            /// </summary>
            /// <param name="value">ExecuteSeconds</param>
            public DestinyDefinitionsDestinyVendorActionDefinitionBuilder ExecuteSeconds(int? value)
            {
                _ExecuteSeconds = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsDestinyVendorActionDefinition.Icon property.
            /// </summary>
            /// <param name="value">Icon</param>
            public DestinyDefinitionsDestinyVendorActionDefinitionBuilder Icon(string value)
            {
                _Icon = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsDestinyVendorActionDefinition.Name property.
            /// </summary>
            /// <param name="value">Name</param>
            public DestinyDefinitionsDestinyVendorActionDefinitionBuilder Name(string value)
            {
                _Name = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsDestinyVendorActionDefinition.Verb property.
            /// </summary>
            /// <param name="value">Verb</param>
            public DestinyDefinitionsDestinyVendorActionDefinitionBuilder Verb(string value)
            {
                _Verb = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsDestinyVendorActionDefinition.IsPositive property.
            /// </summary>
            /// <param name="value">IsPositive</param>
            public DestinyDefinitionsDestinyVendorActionDefinitionBuilder IsPositive(bool? value)
            {
                _IsPositive = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsDestinyVendorActionDefinition.ActionId property.
            /// </summary>
            /// <param name="value">ActionId</param>
            public DestinyDefinitionsDestinyVendorActionDefinitionBuilder ActionId(string value)
            {
                _ActionId = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsDestinyVendorActionDefinition.ActionHash property.
            /// </summary>
            /// <param name="value">ActionHash</param>
            public DestinyDefinitionsDestinyVendorActionDefinitionBuilder ActionHash(int? value)
            {
                _ActionHash = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsDestinyVendorActionDefinition.AutoPerformAction property.
            /// </summary>
            /// <param name="value">AutoPerformAction</param>
            public DestinyDefinitionsDestinyVendorActionDefinitionBuilder AutoPerformAction(bool? value)
            {
                _AutoPerformAction = value;
                return this;
            }


            /// <summary>
            /// Builds instance of DestinyDefinitionsDestinyVendorActionDefinition.
            /// </summary>
            /// <returns>DestinyDefinitionsDestinyVendorActionDefinition</returns>
            public DestinyDefinitionsDestinyVendorActionDefinition Build()
            {
                Validate();
                return new DestinyDefinitionsDestinyVendorActionDefinition(
                    Description: _Description,
                    ExecuteSeconds: _ExecuteSeconds,
                    Icon: _Icon,
                    Name: _Name,
                    Verb: _Verb,
                    IsPositive: _IsPositive,
                    ActionId: _ActionId,
                    ActionHash: _ActionHash,
                    AutoPerformAction: _AutoPerformAction
                );
            }

            private void Validate()
            { 
            }
        }

        
    }
}