using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Sharpility.Extensions;
using NodaTime;

namespace BungieNetApi._Platform.Models
{
    /// <summary>
    /// Not terribly useful, some basic cooldown interaction info.
    /// </summary>
    public sealed class DestinyDefinitionsDestinyVendorSaleItemActionBlockDefinition:  IEquatable<DestinyDefinitionsDestinyVendorSaleItemActionBlockDefinition>
    { 
        /// <summary>
        /// ExecuteSeconds
        /// </summary>
        public float? ExecuteSeconds { get; private set; }

        /// <summary>
        /// IsPositive
        /// </summary>
        public bool? IsPositive { get; private set; }


        /// <summary>
        /// Empty constructor required by some serializers.
        /// Use DestinyDefinitionsDestinyVendorSaleItemActionBlockDefinition.Builder() for instance creation instead.
        /// </summary>
        [Obsolete]
        public DestinyDefinitionsDestinyVendorSaleItemActionBlockDefinition()
        {
        }

        private DestinyDefinitionsDestinyVendorSaleItemActionBlockDefinition(float? ExecuteSeconds, bool? IsPositive)
        {
            
            this.ExecuteSeconds = ExecuteSeconds;
            
            this.IsPositive = IsPositive;
            
        }

        /// <summary>
        /// Returns builder of DestinyDefinitionsDestinyVendorSaleItemActionBlockDefinition.
        /// </summary>
        /// <returns>DestinyDefinitionsDestinyVendorSaleItemActionBlockDefinitionBuilder</returns>
        public static DestinyDefinitionsDestinyVendorSaleItemActionBlockDefinitionBuilder Builder()
        {
            return new DestinyDefinitionsDestinyVendorSaleItemActionBlockDefinitionBuilder();
        }

        /// <summary>
        /// Returns DestinyDefinitionsDestinyVendorSaleItemActionBlockDefinitionBuilder with properties set.
        /// Use it to change properties.
        /// </summary>
        /// <returns>DestinyDefinitionsDestinyVendorSaleItemActionBlockDefinitionBuilder</returns>
        public DestinyDefinitionsDestinyVendorSaleItemActionBlockDefinitionBuilder With()
        {
            return Builder()
                .ExecuteSeconds(ExecuteSeconds)
                .IsPositive(IsPositive);
        }

        public override string ToString()
        {
            return this.PropertiesToString();
        }

        public override bool Equals(object obj)
        {
            return this.EqualsByProperties(obj);
        }

        public bool Equals(DestinyDefinitionsDestinyVendorSaleItemActionBlockDefinition other)
        {
            return Equals((object) other);
        }

        public override int GetHashCode()
        {
            return this.PropertiesHash();
        }

        /// <summary>
        /// Implementation of == operator for (DestinyDefinitionsDestinyVendorSaleItemActionBlockDefinition.
        /// </summary>
        /// <param name="left">Compared (DestinyDefinitionsDestinyVendorSaleItemActionBlockDefinition</param>
        /// <param name="right">Compared (DestinyDefinitionsDestinyVendorSaleItemActionBlockDefinition</param>
        /// <returns>true if compared items are equals, false otherwise</returns>
        public static bool operator == (DestinyDefinitionsDestinyVendorSaleItemActionBlockDefinition left, DestinyDefinitionsDestinyVendorSaleItemActionBlockDefinition right)
        {
            return Equals(left, right);
        }

        /// <summary>
        /// Implementation of != operator for (DestinyDefinitionsDestinyVendorSaleItemActionBlockDefinition.
        /// </summary>
        /// <param name="left">Compared (DestinyDefinitionsDestinyVendorSaleItemActionBlockDefinition</param>
        /// <param name="right">Compared (DestinyDefinitionsDestinyVendorSaleItemActionBlockDefinition</param>
        /// <returns>true if compared items are not equals, false otherwise</returns>
        public static bool operator != (DestinyDefinitionsDestinyVendorSaleItemActionBlockDefinition left, DestinyDefinitionsDestinyVendorSaleItemActionBlockDefinition right)
        {
            return !Equals(left, right);
        }

        /// <summary>
        /// Builder of DestinyDefinitionsDestinyVendorSaleItemActionBlockDefinition.
        /// </summary>
        public sealed class DestinyDefinitionsDestinyVendorSaleItemActionBlockDefinitionBuilder
        {
            private float? _ExecuteSeconds;
            private bool? _IsPositive;

            internal DestinyDefinitionsDestinyVendorSaleItemActionBlockDefinitionBuilder()
            {
                SetupDefaults();
            }

            private void SetupDefaults()
            {
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsDestinyVendorSaleItemActionBlockDefinition.ExecuteSeconds property.
            /// </summary>
            /// <param name="value">ExecuteSeconds</param>
            public DestinyDefinitionsDestinyVendorSaleItemActionBlockDefinitionBuilder ExecuteSeconds(float? value)
            {
                _ExecuteSeconds = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsDestinyVendorSaleItemActionBlockDefinition.IsPositive property.
            /// </summary>
            /// <param name="value">IsPositive</param>
            public DestinyDefinitionsDestinyVendorSaleItemActionBlockDefinitionBuilder IsPositive(bool? value)
            {
                _IsPositive = value;
                return this;
            }


            /// <summary>
            /// Builds instance of DestinyDefinitionsDestinyVendorSaleItemActionBlockDefinition.
            /// </summary>
            /// <returns>DestinyDefinitionsDestinyVendorSaleItemActionBlockDefinition</returns>
            public DestinyDefinitionsDestinyVendorSaleItemActionBlockDefinition Build()
            {
                Validate();
                return new DestinyDefinitionsDestinyVendorSaleItemActionBlockDefinition(
                    ExecuteSeconds: _ExecuteSeconds,
                    IsPositive: _IsPositive
                );
            }

            private void Validate()
            { 
            }
        }

        
    }
}