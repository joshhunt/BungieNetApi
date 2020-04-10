using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Sharpility.Extensions;
using NodaTime;

namespace BungieNetApi._Platform.Models
{
    /// <summary>
    /// If the Milestone or a component has vendors whose inventories could/should be displayed that are relevant to it, this will return the vendor in question.   It also contains information we need to determine whether that vendor is actually relevant at the moment, given the user&#39;s current state.
    /// </summary>
    public sealed class DestinyDefinitionsMilestonesDestinyMilestoneVendorDefinition:  IEquatable<DestinyDefinitionsMilestonesDestinyMilestoneVendorDefinition>
    { 
        /// <summary>
        /// The hash of the vendor whose wares should be shown as associated with the Milestone.
        /// </summary>
        public int? VendorHash { get; private set; }


        /// <summary>
        /// Empty constructor required by some serializers.
        /// Use DestinyDefinitionsMilestonesDestinyMilestoneVendorDefinition.Builder() for instance creation instead.
        /// </summary>
        [Obsolete]
        public DestinyDefinitionsMilestonesDestinyMilestoneVendorDefinition()
        {
        }

        private DestinyDefinitionsMilestonesDestinyMilestoneVendorDefinition(int? VendorHash)
        {
            
            this.VendorHash = VendorHash;
            
        }

        /// <summary>
        /// Returns builder of DestinyDefinitionsMilestonesDestinyMilestoneVendorDefinition.
        /// </summary>
        /// <returns>DestinyDefinitionsMilestonesDestinyMilestoneVendorDefinitionBuilder</returns>
        public static DestinyDefinitionsMilestonesDestinyMilestoneVendorDefinitionBuilder Builder()
        {
            return new DestinyDefinitionsMilestonesDestinyMilestoneVendorDefinitionBuilder();
        }

        /// <summary>
        /// Returns DestinyDefinitionsMilestonesDestinyMilestoneVendorDefinitionBuilder with properties set.
        /// Use it to change properties.
        /// </summary>
        /// <returns>DestinyDefinitionsMilestonesDestinyMilestoneVendorDefinitionBuilder</returns>
        public DestinyDefinitionsMilestonesDestinyMilestoneVendorDefinitionBuilder With()
        {
            return Builder()
                .VendorHash(VendorHash);
        }

        public override string ToString()
        {
            return this.PropertiesToString();
        }

        public override bool Equals(object obj)
        {
            return this.EqualsByProperties(obj);
        }

        public bool Equals(DestinyDefinitionsMilestonesDestinyMilestoneVendorDefinition other)
        {
            return Equals((object) other);
        }

        public override int GetHashCode()
        {
            return this.PropertiesHash();
        }

        /// <summary>
        /// Implementation of == operator for (DestinyDefinitionsMilestonesDestinyMilestoneVendorDefinition.
        /// </summary>
        /// <param name="left">Compared (DestinyDefinitionsMilestonesDestinyMilestoneVendorDefinition</param>
        /// <param name="right">Compared (DestinyDefinitionsMilestonesDestinyMilestoneVendorDefinition</param>
        /// <returns>true if compared items are equals, false otherwise</returns>
        public static bool operator == (DestinyDefinitionsMilestonesDestinyMilestoneVendorDefinition left, DestinyDefinitionsMilestonesDestinyMilestoneVendorDefinition right)
        {
            return Equals(left, right);
        }

        /// <summary>
        /// Implementation of != operator for (DestinyDefinitionsMilestonesDestinyMilestoneVendorDefinition.
        /// </summary>
        /// <param name="left">Compared (DestinyDefinitionsMilestonesDestinyMilestoneVendorDefinition</param>
        /// <param name="right">Compared (DestinyDefinitionsMilestonesDestinyMilestoneVendorDefinition</param>
        /// <returns>true if compared items are not equals, false otherwise</returns>
        public static bool operator != (DestinyDefinitionsMilestonesDestinyMilestoneVendorDefinition left, DestinyDefinitionsMilestonesDestinyMilestoneVendorDefinition right)
        {
            return !Equals(left, right);
        }

        /// <summary>
        /// Builder of DestinyDefinitionsMilestonesDestinyMilestoneVendorDefinition.
        /// </summary>
        public sealed class DestinyDefinitionsMilestonesDestinyMilestoneVendorDefinitionBuilder
        {
            private int? _VendorHash;

            internal DestinyDefinitionsMilestonesDestinyMilestoneVendorDefinitionBuilder()
            {
                SetupDefaults();
            }

            private void SetupDefaults()
            {
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsMilestonesDestinyMilestoneVendorDefinition.VendorHash property.
            /// </summary>
            /// <param name="value">The hash of the vendor whose wares should be shown as associated with the Milestone.</param>
            public DestinyDefinitionsMilestonesDestinyMilestoneVendorDefinitionBuilder VendorHash(int? value)
            {
                _VendorHash = value;
                return this;
            }


            /// <summary>
            /// Builds instance of DestinyDefinitionsMilestonesDestinyMilestoneVendorDefinition.
            /// </summary>
            /// <returns>DestinyDefinitionsMilestonesDestinyMilestoneVendorDefinition</returns>
            public DestinyDefinitionsMilestonesDestinyMilestoneVendorDefinition Build()
            {
                Validate();
                return new DestinyDefinitionsMilestonesDestinyMilestoneVendorDefinition(
                    VendorHash: _VendorHash
                );
            }

            private void Validate()
            { 
            }
        }

        
    }
}