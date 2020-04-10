using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Sharpility.Extensions;
using NodaTime;

namespace BungieNetApi._Platform.Models
{
    /// <summary>
    /// DestinyComponentsKiosksDestinyKioskItem
    /// </summary>
    public sealed class DestinyComponentsKiosksDestinyKioskItem:  IEquatable<DestinyComponentsKiosksDestinyKioskItem>
    { 
        /// <summary>
        /// The index of the item in the related DestinyVendorDefintion&#39;s itemList property, representing the sale.
        /// </summary>
        public int? Index { get; private set; }

        /// <summary>
        /// If true, the user can not only see the item, but they can acquire it. It is possible that a user can see a kiosk item and not be able to acquire it.
        /// </summary>
        public bool? CanAcquire { get; private set; }

        /// <summary>
        /// Indexes into failureStrings for the Vendor, indicating the reasons why it failed if any.
        /// </summary>
        public List<int?> FailureIndexes { get; private set; }

        /// <summary>
        /// I may regret naming it this way - but this represents when an item has an objective that doesn&#39;t serve a beneficial purpose, but rather is used for \&quot;flavor\&quot; or additional information. For instance, when Emblems track specific stats, those stats are represented as Objectives on the item.
        /// </summary>
        public DestinyQuestsDestinyObjectiveProgress FlavorObjective { get; private set; }


        /// <summary>
        /// Empty constructor required by some serializers.
        /// Use DestinyComponentsKiosksDestinyKioskItem.Builder() for instance creation instead.
        /// </summary>
        [Obsolete]
        public DestinyComponentsKiosksDestinyKioskItem()
        {
        }

        private DestinyComponentsKiosksDestinyKioskItem(int? Index, bool? CanAcquire, List<int?> FailureIndexes, DestinyQuestsDestinyObjectiveProgress FlavorObjective)
        {
            
            this.Index = Index;
            
            this.CanAcquire = CanAcquire;
            
            this.FailureIndexes = FailureIndexes;
            
            this.FlavorObjective = FlavorObjective;
            
        }

        /// <summary>
        /// Returns builder of DestinyComponentsKiosksDestinyKioskItem.
        /// </summary>
        /// <returns>DestinyComponentsKiosksDestinyKioskItemBuilder</returns>
        public static DestinyComponentsKiosksDestinyKioskItemBuilder Builder()
        {
            return new DestinyComponentsKiosksDestinyKioskItemBuilder();
        }

        /// <summary>
        /// Returns DestinyComponentsKiosksDestinyKioskItemBuilder with properties set.
        /// Use it to change properties.
        /// </summary>
        /// <returns>DestinyComponentsKiosksDestinyKioskItemBuilder</returns>
        public DestinyComponentsKiosksDestinyKioskItemBuilder With()
        {
            return Builder()
                .Index(Index)
                .CanAcquire(CanAcquire)
                .FailureIndexes(FailureIndexes)
                .FlavorObjective(FlavorObjective);
        }

        public override string ToString()
        {
            return this.PropertiesToString();
        }

        public override bool Equals(object obj)
        {
            return this.EqualsByProperties(obj);
        }

        public bool Equals(DestinyComponentsKiosksDestinyKioskItem other)
        {
            return Equals((object) other);
        }

        public override int GetHashCode()
        {
            return this.PropertiesHash();
        }

        /// <summary>
        /// Implementation of == operator for (DestinyComponentsKiosksDestinyKioskItem.
        /// </summary>
        /// <param name="left">Compared (DestinyComponentsKiosksDestinyKioskItem</param>
        /// <param name="right">Compared (DestinyComponentsKiosksDestinyKioskItem</param>
        /// <returns>true if compared items are equals, false otherwise</returns>
        public static bool operator == (DestinyComponentsKiosksDestinyKioskItem left, DestinyComponentsKiosksDestinyKioskItem right)
        {
            return Equals(left, right);
        }

        /// <summary>
        /// Implementation of != operator for (DestinyComponentsKiosksDestinyKioskItem.
        /// </summary>
        /// <param name="left">Compared (DestinyComponentsKiosksDestinyKioskItem</param>
        /// <param name="right">Compared (DestinyComponentsKiosksDestinyKioskItem</param>
        /// <returns>true if compared items are not equals, false otherwise</returns>
        public static bool operator != (DestinyComponentsKiosksDestinyKioskItem left, DestinyComponentsKiosksDestinyKioskItem right)
        {
            return !Equals(left, right);
        }

        /// <summary>
        /// Builder of DestinyComponentsKiosksDestinyKioskItem.
        /// </summary>
        public sealed class DestinyComponentsKiosksDestinyKioskItemBuilder
        {
            private int? _Index;
            private bool? _CanAcquire;
            private List<int?> _FailureIndexes;
            private DestinyQuestsDestinyObjectiveProgress _FlavorObjective;

            internal DestinyComponentsKiosksDestinyKioskItemBuilder()
            {
                SetupDefaults();
            }

            private void SetupDefaults()
            {
            }

            /// <summary>
            /// Sets value for DestinyComponentsKiosksDestinyKioskItem.Index property.
            /// </summary>
            /// <param name="value">The index of the item in the related DestinyVendorDefintion&#39;s itemList property, representing the sale.</param>
            public DestinyComponentsKiosksDestinyKioskItemBuilder Index(int? value)
            {
                _Index = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyComponentsKiosksDestinyKioskItem.CanAcquire property.
            /// </summary>
            /// <param name="value">If true, the user can not only see the item, but they can acquire it. It is possible that a user can see a kiosk item and not be able to acquire it.</param>
            public DestinyComponentsKiosksDestinyKioskItemBuilder CanAcquire(bool? value)
            {
                _CanAcquire = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyComponentsKiosksDestinyKioskItem.FailureIndexes property.
            /// </summary>
            /// <param name="value">Indexes into failureStrings for the Vendor, indicating the reasons why it failed if any.</param>
            public DestinyComponentsKiosksDestinyKioskItemBuilder FailureIndexes(List<int?> value)
            {
                _FailureIndexes = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyComponentsKiosksDestinyKioskItem.FlavorObjective property.
            /// </summary>
            /// <param name="value">I may regret naming it this way - but this represents when an item has an objective that doesn&#39;t serve a beneficial purpose, but rather is used for \&quot;flavor\&quot; or additional information. For instance, when Emblems track specific stats, those stats are represented as Objectives on the item.</param>
            public DestinyComponentsKiosksDestinyKioskItemBuilder FlavorObjective(DestinyQuestsDestinyObjectiveProgress value)
            {
                _FlavorObjective = value;
                return this;
            }


            /// <summary>
            /// Builds instance of DestinyComponentsKiosksDestinyKioskItem.
            /// </summary>
            /// <returns>DestinyComponentsKiosksDestinyKioskItem</returns>
            public DestinyComponentsKiosksDestinyKioskItem Build()
            {
                Validate();
                return new DestinyComponentsKiosksDestinyKioskItem(
                    Index: _Index,
                    CanAcquire: _CanAcquire,
                    FailureIndexes: _FailureIndexes,
                    FlavorObjective: _FlavorObjective
                );
            }

            private void Validate()
            { 
            }
        }

        
    }
}