using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Sharpility.Extensions;
using NodaTime;

namespace BungieNetApi._Platform.Models
{
    /// <summary>
    /// Describes the way that an Item Stat (see DestinyStatDefinition) is transformed using the DestinyStatGroupDefinition related to that item. See both of the aforementioned definitions for more information about the stages of stat transformation.  This represents the transformation of a stat into a \&quot;Display\&quot; stat (the closest value that BNet can get to the in-game display value of the stat)
    /// </summary>
    public sealed class DestinyDefinitionsDestinyStatDisplayDefinition:  IEquatable<DestinyDefinitionsDestinyStatDisplayDefinition>
    { 
        /// <summary>
        /// The hash identifier for the stat being transformed into a Display stat.  Use it to look up the DestinyStatDefinition, or key into a DestinyInventoryItemDefinition&#39;s stats property.
        /// </summary>
        public int? StatHash { get; private set; }

        /// <summary>
        /// Regardless of the output of interpolation, this is the maximum possible value that the stat can be. It should also be used as the upper bound for displaying the stat as a progress bar (the minimum always being 0)
        /// </summary>
        public int? MaximumValue { get; private set; }

        /// <summary>
        /// If this is true, the stat should be displayed as a number. Otherwise, display it as a progress bar. Or, you know, do whatever you want. There&#39;s no displayAsNumeric police.
        /// </summary>
        public bool? DisplayAsNumeric { get; private set; }

        /// <summary>
        /// The interpolation table representing how the Investment Stat is transformed into a Display Stat.   See DestinyStatDefinition for a description of the stages of stat transformation.
        /// </summary>
        public List<InterpolationInterpolationPoint> DisplayInterpolation { get; private set; }


        /// <summary>
        /// Empty constructor required by some serializers.
        /// Use DestinyDefinitionsDestinyStatDisplayDefinition.Builder() for instance creation instead.
        /// </summary>
        [Obsolete]
        public DestinyDefinitionsDestinyStatDisplayDefinition()
        {
        }

        private DestinyDefinitionsDestinyStatDisplayDefinition(int? StatHash, int? MaximumValue, bool? DisplayAsNumeric, List<InterpolationInterpolationPoint> DisplayInterpolation)
        {
            
            this.StatHash = StatHash;
            
            this.MaximumValue = MaximumValue;
            
            this.DisplayAsNumeric = DisplayAsNumeric;
            
            this.DisplayInterpolation = DisplayInterpolation;
            
        }

        /// <summary>
        /// Returns builder of DestinyDefinitionsDestinyStatDisplayDefinition.
        /// </summary>
        /// <returns>DestinyDefinitionsDestinyStatDisplayDefinitionBuilder</returns>
        public static DestinyDefinitionsDestinyStatDisplayDefinitionBuilder Builder()
        {
            return new DestinyDefinitionsDestinyStatDisplayDefinitionBuilder();
        }

        /// <summary>
        /// Returns DestinyDefinitionsDestinyStatDisplayDefinitionBuilder with properties set.
        /// Use it to change properties.
        /// </summary>
        /// <returns>DestinyDefinitionsDestinyStatDisplayDefinitionBuilder</returns>
        public DestinyDefinitionsDestinyStatDisplayDefinitionBuilder With()
        {
            return Builder()
                .StatHash(StatHash)
                .MaximumValue(MaximumValue)
                .DisplayAsNumeric(DisplayAsNumeric)
                .DisplayInterpolation(DisplayInterpolation);
        }

        public override string ToString()
        {
            return this.PropertiesToString();
        }

        public override bool Equals(object obj)
        {
            return this.EqualsByProperties(obj);
        }

        public bool Equals(DestinyDefinitionsDestinyStatDisplayDefinition other)
        {
            return Equals((object) other);
        }

        public override int GetHashCode()
        {
            return this.PropertiesHash();
        }

        /// <summary>
        /// Implementation of == operator for (DestinyDefinitionsDestinyStatDisplayDefinition.
        /// </summary>
        /// <param name="left">Compared (DestinyDefinitionsDestinyStatDisplayDefinition</param>
        /// <param name="right">Compared (DestinyDefinitionsDestinyStatDisplayDefinition</param>
        /// <returns>true if compared items are equals, false otherwise</returns>
        public static bool operator == (DestinyDefinitionsDestinyStatDisplayDefinition left, DestinyDefinitionsDestinyStatDisplayDefinition right)
        {
            return Equals(left, right);
        }

        /// <summary>
        /// Implementation of != operator for (DestinyDefinitionsDestinyStatDisplayDefinition.
        /// </summary>
        /// <param name="left">Compared (DestinyDefinitionsDestinyStatDisplayDefinition</param>
        /// <param name="right">Compared (DestinyDefinitionsDestinyStatDisplayDefinition</param>
        /// <returns>true if compared items are not equals, false otherwise</returns>
        public static bool operator != (DestinyDefinitionsDestinyStatDisplayDefinition left, DestinyDefinitionsDestinyStatDisplayDefinition right)
        {
            return !Equals(left, right);
        }

        /// <summary>
        /// Builder of DestinyDefinitionsDestinyStatDisplayDefinition.
        /// </summary>
        public sealed class DestinyDefinitionsDestinyStatDisplayDefinitionBuilder
        {
            private int? _StatHash;
            private int? _MaximumValue;
            private bool? _DisplayAsNumeric;
            private List<InterpolationInterpolationPoint> _DisplayInterpolation;

            internal DestinyDefinitionsDestinyStatDisplayDefinitionBuilder()
            {
                SetupDefaults();
            }

            private void SetupDefaults()
            {
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsDestinyStatDisplayDefinition.StatHash property.
            /// </summary>
            /// <param name="value">The hash identifier for the stat being transformed into a Display stat.  Use it to look up the DestinyStatDefinition, or key into a DestinyInventoryItemDefinition&#39;s stats property.</param>
            public DestinyDefinitionsDestinyStatDisplayDefinitionBuilder StatHash(int? value)
            {
                _StatHash = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsDestinyStatDisplayDefinition.MaximumValue property.
            /// </summary>
            /// <param name="value">Regardless of the output of interpolation, this is the maximum possible value that the stat can be. It should also be used as the upper bound for displaying the stat as a progress bar (the minimum always being 0)</param>
            public DestinyDefinitionsDestinyStatDisplayDefinitionBuilder MaximumValue(int? value)
            {
                _MaximumValue = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsDestinyStatDisplayDefinition.DisplayAsNumeric property.
            /// </summary>
            /// <param name="value">If this is true, the stat should be displayed as a number. Otherwise, display it as a progress bar. Or, you know, do whatever you want. There&#39;s no displayAsNumeric police.</param>
            public DestinyDefinitionsDestinyStatDisplayDefinitionBuilder DisplayAsNumeric(bool? value)
            {
                _DisplayAsNumeric = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsDestinyStatDisplayDefinition.DisplayInterpolation property.
            /// </summary>
            /// <param name="value">The interpolation table representing how the Investment Stat is transformed into a Display Stat.   See DestinyStatDefinition for a description of the stages of stat transformation.</param>
            public DestinyDefinitionsDestinyStatDisplayDefinitionBuilder DisplayInterpolation(List<InterpolationInterpolationPoint> value)
            {
                _DisplayInterpolation = value;
                return this;
            }


            /// <summary>
            /// Builds instance of DestinyDefinitionsDestinyStatDisplayDefinition.
            /// </summary>
            /// <returns>DestinyDefinitionsDestinyStatDisplayDefinition</returns>
            public DestinyDefinitionsDestinyStatDisplayDefinition Build()
            {
                Validate();
                return new DestinyDefinitionsDestinyStatDisplayDefinition(
                    StatHash: _StatHash,
                    MaximumValue: _MaximumValue,
                    DisplayAsNumeric: _DisplayAsNumeric,
                    DisplayInterpolation: _DisplayInterpolation
                );
            }

            private void Validate()
            { 
            }
        }

        
    }
}