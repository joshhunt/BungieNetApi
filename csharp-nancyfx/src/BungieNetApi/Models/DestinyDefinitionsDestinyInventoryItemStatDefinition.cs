using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Sharpility.Extensions;
using NodaTime;

namespace BungieNetApi._Platform.Models
{
    /// <summary>
    /// Defines a specific stat value on an item, and the minimum/maximum range that we could compute for the item based on our heuristics for how the item might be generated.  Not guaranteed to match real-world instances of the item, but should hopefully at least be close. If it&#39;s not close, let us know on the Bungie API forums.
    /// </summary>
    public sealed class DestinyDefinitionsDestinyInventoryItemStatDefinition:  IEquatable<DestinyDefinitionsDestinyInventoryItemStatDefinition>
    { 
        /// <summary>
        /// The hash for the DestinyStatDefinition representing this stat.
        /// </summary>
        public int? StatHash { get; private set; }

        /// <summary>
        /// This value represents the stat value assuming the minimum possible roll but accounting for any mandatory bonuses that should be applied to the stat on item creation.  In Destiny 1, this was different from the \&quot;minimum\&quot; value because there were certain conditions where an item could be theoretically lower level/value than the initial roll.   In Destiny 2, this is not possible unless Talent Grids begin to be used again for these purposes or some other system change occurs... thus in practice, value and minimum should be the same in Destiny 2. Good riddance.
        /// </summary>
        public int? Value { get; private set; }

        /// <summary>
        /// The minimum possible value for this stat that we think the item can roll.
        /// </summary>
        public int? Minimum { get; private set; }

        /// <summary>
        /// The maximum possible value for this stat that we think the item can roll.  WARNING: In Destiny 1, this field was calculated using the potential stat rolls on the item&#39;s talent grid. In Destiny 2, items no longer have meaningful talent grids and instead have sockets: but the calculation of this field was never altered to adapt to this change. As such, this field should be considered deprecated until we can address this oversight.
        /// </summary>
        public int? Maximum { get; private set; }

        /// <summary>
        /// The maximum possible value for the stat as shown in the UI, if it is being shown somewhere that reveals maximum in the UI (such as a bar chart-style view).  This is pulled directly from the item&#39;s DestinyStatGroupDefinition, and placed here for convenience.  If not returned, there is no maximum to use (and thus the stat should not be shown in a way that assumes there is a limit to the stat)
        /// </summary>
        public int? DisplayMaximum { get; private set; }


        /// <summary>
        /// Empty constructor required by some serializers.
        /// Use DestinyDefinitionsDestinyInventoryItemStatDefinition.Builder() for instance creation instead.
        /// </summary>
        [Obsolete]
        public DestinyDefinitionsDestinyInventoryItemStatDefinition()
        {
        }

        private DestinyDefinitionsDestinyInventoryItemStatDefinition(int? StatHash, int? Value, int? Minimum, int? Maximum, int? DisplayMaximum)
        {
            
            this.StatHash = StatHash;
            
            this.Value = Value;
            
            this.Minimum = Minimum;
            
            this.Maximum = Maximum;
            
            this.DisplayMaximum = DisplayMaximum;
            
        }

        /// <summary>
        /// Returns builder of DestinyDefinitionsDestinyInventoryItemStatDefinition.
        /// </summary>
        /// <returns>DestinyDefinitionsDestinyInventoryItemStatDefinitionBuilder</returns>
        public static DestinyDefinitionsDestinyInventoryItemStatDefinitionBuilder Builder()
        {
            return new DestinyDefinitionsDestinyInventoryItemStatDefinitionBuilder();
        }

        /// <summary>
        /// Returns DestinyDefinitionsDestinyInventoryItemStatDefinitionBuilder with properties set.
        /// Use it to change properties.
        /// </summary>
        /// <returns>DestinyDefinitionsDestinyInventoryItemStatDefinitionBuilder</returns>
        public DestinyDefinitionsDestinyInventoryItemStatDefinitionBuilder With()
        {
            return Builder()
                .StatHash(StatHash)
                .Value(Value)
                .Minimum(Minimum)
                .Maximum(Maximum)
                .DisplayMaximum(DisplayMaximum);
        }

        public override string ToString()
        {
            return this.PropertiesToString();
        }

        public override bool Equals(object obj)
        {
            return this.EqualsByProperties(obj);
        }

        public bool Equals(DestinyDefinitionsDestinyInventoryItemStatDefinition other)
        {
            return Equals((object) other);
        }

        public override int GetHashCode()
        {
            return this.PropertiesHash();
        }

        /// <summary>
        /// Implementation of == operator for (DestinyDefinitionsDestinyInventoryItemStatDefinition.
        /// </summary>
        /// <param name="left">Compared (DestinyDefinitionsDestinyInventoryItemStatDefinition</param>
        /// <param name="right">Compared (DestinyDefinitionsDestinyInventoryItemStatDefinition</param>
        /// <returns>true if compared items are equals, false otherwise</returns>
        public static bool operator == (DestinyDefinitionsDestinyInventoryItemStatDefinition left, DestinyDefinitionsDestinyInventoryItemStatDefinition right)
        {
            return Equals(left, right);
        }

        /// <summary>
        /// Implementation of != operator for (DestinyDefinitionsDestinyInventoryItemStatDefinition.
        /// </summary>
        /// <param name="left">Compared (DestinyDefinitionsDestinyInventoryItemStatDefinition</param>
        /// <param name="right">Compared (DestinyDefinitionsDestinyInventoryItemStatDefinition</param>
        /// <returns>true if compared items are not equals, false otherwise</returns>
        public static bool operator != (DestinyDefinitionsDestinyInventoryItemStatDefinition left, DestinyDefinitionsDestinyInventoryItemStatDefinition right)
        {
            return !Equals(left, right);
        }

        /// <summary>
        /// Builder of DestinyDefinitionsDestinyInventoryItemStatDefinition.
        /// </summary>
        public sealed class DestinyDefinitionsDestinyInventoryItemStatDefinitionBuilder
        {
            private int? _StatHash;
            private int? _Value;
            private int? _Minimum;
            private int? _Maximum;
            private int? _DisplayMaximum;

            internal DestinyDefinitionsDestinyInventoryItemStatDefinitionBuilder()
            {
                SetupDefaults();
            }

            private void SetupDefaults()
            {
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsDestinyInventoryItemStatDefinition.StatHash property.
            /// </summary>
            /// <param name="value">The hash for the DestinyStatDefinition representing this stat.</param>
            public DestinyDefinitionsDestinyInventoryItemStatDefinitionBuilder StatHash(int? value)
            {
                _StatHash = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsDestinyInventoryItemStatDefinition.Value property.
            /// </summary>
            /// <param name="value">This value represents the stat value assuming the minimum possible roll but accounting for any mandatory bonuses that should be applied to the stat on item creation.  In Destiny 1, this was different from the \&quot;minimum\&quot; value because there were certain conditions where an item could be theoretically lower level/value than the initial roll.   In Destiny 2, this is not possible unless Talent Grids begin to be used again for these purposes or some other system change occurs... thus in practice, value and minimum should be the same in Destiny 2. Good riddance.</param>
            public DestinyDefinitionsDestinyInventoryItemStatDefinitionBuilder Value(int? value)
            {
                _Value = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsDestinyInventoryItemStatDefinition.Minimum property.
            /// </summary>
            /// <param name="value">The minimum possible value for this stat that we think the item can roll.</param>
            public DestinyDefinitionsDestinyInventoryItemStatDefinitionBuilder Minimum(int? value)
            {
                _Minimum = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsDestinyInventoryItemStatDefinition.Maximum property.
            /// </summary>
            /// <param name="value">The maximum possible value for this stat that we think the item can roll.  WARNING: In Destiny 1, this field was calculated using the potential stat rolls on the item&#39;s talent grid. In Destiny 2, items no longer have meaningful talent grids and instead have sockets: but the calculation of this field was never altered to adapt to this change. As such, this field should be considered deprecated until we can address this oversight.</param>
            public DestinyDefinitionsDestinyInventoryItemStatDefinitionBuilder Maximum(int? value)
            {
                _Maximum = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsDestinyInventoryItemStatDefinition.DisplayMaximum property.
            /// </summary>
            /// <param name="value">The maximum possible value for the stat as shown in the UI, if it is being shown somewhere that reveals maximum in the UI (such as a bar chart-style view).  This is pulled directly from the item&#39;s DestinyStatGroupDefinition, and placed here for convenience.  If not returned, there is no maximum to use (and thus the stat should not be shown in a way that assumes there is a limit to the stat)</param>
            public DestinyDefinitionsDestinyInventoryItemStatDefinitionBuilder DisplayMaximum(int? value)
            {
                _DisplayMaximum = value;
                return this;
            }


            /// <summary>
            /// Builds instance of DestinyDefinitionsDestinyInventoryItemStatDefinition.
            /// </summary>
            /// <returns>DestinyDefinitionsDestinyInventoryItemStatDefinition</returns>
            public DestinyDefinitionsDestinyInventoryItemStatDefinition Build()
            {
                Validate();
                return new DestinyDefinitionsDestinyInventoryItemStatDefinition(
                    StatHash: _StatHash,
                    Value: _Value,
                    Minimum: _Minimum,
                    Maximum: _Maximum,
                    DisplayMaximum: _DisplayMaximum
                );
            }

            private void Validate()
            { 
            }
        }

        
    }
}