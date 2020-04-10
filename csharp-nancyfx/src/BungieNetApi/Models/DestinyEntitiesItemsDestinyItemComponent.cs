using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Sharpility.Extensions;
using NodaTime;

namespace BungieNetApi._Platform.Models
{
    /// <summary>
    /// The base item component, filled with properties that are generally useful to know in any item request or that don&#39;t feel worthwhile to put in their own component.
    /// </summary>
    public sealed class DestinyEntitiesItemsDestinyItemComponent:  IEquatable<DestinyEntitiesItemsDestinyItemComponent>
    { 
        /// <summary>
        /// The identifier for the item&#39;s definition, which is where most of the useful static information for the item can be found.
        /// </summary>
        public int? ItemHash { get; private set; }

        /// <summary>
        /// If the item is instanced, it will have an instance ID. Lack of an instance ID implies that the item has no distinct local qualities aside from stack size.
        /// </summary>
        public long? ItemInstanceId { get; private set; }

        /// <summary>
        /// The quantity of the item in this stack. Note that Instanced items cannot stack. If an instanced item, this value will always be 1 (as the stack has exactly one item in it)
        /// </summary>
        public int? Quantity { get; private set; }

        /// <summary>
        /// If the item is bound to a location, it will be specified in this enum.
        /// </summary>
        public int? BindStatus { get; private set; }

        /// <summary>
        /// An easy reference for where the item is located. Redundant if you got the item from an Inventory, but useful when making detail calls on specific items.
        /// </summary>
        public int? Location { get; private set; }

        /// <summary>
        /// The hash identifier for the specific inventory bucket in which the item is located.
        /// </summary>
        public int? BucketHash { get; private set; }

        /// <summary>
        /// If there is a known error state that would cause this item to not be transferable, this Flags enum will indicate all of those error states. Otherwise, it will be 0 (CanTransfer).
        /// </summary>
        public int? TransferStatus { get; private set; }

        /// <summary>
        /// If the item can be locked, this will indicate that state.
        /// </summary>
        public bool? Lockable { get; private set; }

        /// <summary>
        /// A flags enumeration indicating the transient/custom states of the item that affect how it is rendered: whether it&#39;s tracked or locked for example, or whether it has a masterwork plug inserted.
        /// </summary>
        public int? State { get; private set; }

        /// <summary>
        /// If populated, this is the hash of the item whose icon (and other secondary styles, but *not* the human readable strings) should override whatever icons/styles are on the item being sold.  If you don&#39;t do this, certain items whose styles are being overridden by socketed items - such as the \&quot;Recycle Shader\&quot; item - would show whatever their default icon/style is, and it wouldn&#39;t be pretty or look accurate.
        /// </summary>
        public int? OverrideStyleItemHash { get; private set; }

        /// <summary>
        /// If the item can expire, this is the date at which it will/did expire.
        /// </summary>
        public DateTime? ExpirationDate { get; private set; }

        /// <summary>
        /// If this is true, the object is actually a \&quot;wrapper\&quot; of the object it&#39;s representing. This means that it&#39;s not the actual item itself, but rather an item that must be \&quot;opened\&quot; in game before you have and can use the item.   Wrappers are an evolution of \&quot;bundles\&quot;, which give an easy way to let you preview the contents of what you purchased while still letting you get a refund before you \&quot;open\&quot; it.
        /// </summary>
        public bool? IsWrapper { get; private set; }

        /// <summary>
        /// If this is populated, it is a list of indexes into DestinyInventoryItemDefinition.tooltipNotifications for any special tooltip messages that need to be shown for this item.
        /// </summary>
        public List<int?> TooltipNotificationIndexes { get; private set; }

        /// <summary>
        /// The identifier for the currently-selected metric definition, to be displayed on the emblem nameplate.
        /// </summary>
        public int? MetricHash { get; private set; }

        /// <summary>
        /// The objective progress for the currently-selected metric definition, to be displayed on the emblem nameplate.
        /// </summary>
        public DestinyQuestsDestinyObjectiveProgress MetricObjective { get; private set; }


        /// <summary>
        /// Empty constructor required by some serializers.
        /// Use DestinyEntitiesItemsDestinyItemComponent.Builder() for instance creation instead.
        /// </summary>
        [Obsolete]
        public DestinyEntitiesItemsDestinyItemComponent()
        {
        }

        private DestinyEntitiesItemsDestinyItemComponent(int? ItemHash, long? ItemInstanceId, int? Quantity, int? BindStatus, int? Location, int? BucketHash, int? TransferStatus, bool? Lockable, int? State, int? OverrideStyleItemHash, DateTime? ExpirationDate, bool? IsWrapper, List<int?> TooltipNotificationIndexes, int? MetricHash, DestinyQuestsDestinyObjectiveProgress MetricObjective)
        {
            
            this.ItemHash = ItemHash;
            
            this.ItemInstanceId = ItemInstanceId;
            
            this.Quantity = Quantity;
            
            this.BindStatus = BindStatus;
            
            this.Location = Location;
            
            this.BucketHash = BucketHash;
            
            this.TransferStatus = TransferStatus;
            
            this.Lockable = Lockable;
            
            this.State = State;
            
            this.OverrideStyleItemHash = OverrideStyleItemHash;
            
            this.ExpirationDate = ExpirationDate;
            
            this.IsWrapper = IsWrapper;
            
            this.TooltipNotificationIndexes = TooltipNotificationIndexes;
            
            this.MetricHash = MetricHash;
            
            this.MetricObjective = MetricObjective;
            
        }

        /// <summary>
        /// Returns builder of DestinyEntitiesItemsDestinyItemComponent.
        /// </summary>
        /// <returns>DestinyEntitiesItemsDestinyItemComponentBuilder</returns>
        public static DestinyEntitiesItemsDestinyItemComponentBuilder Builder()
        {
            return new DestinyEntitiesItemsDestinyItemComponentBuilder();
        }

        /// <summary>
        /// Returns DestinyEntitiesItemsDestinyItemComponentBuilder with properties set.
        /// Use it to change properties.
        /// </summary>
        /// <returns>DestinyEntitiesItemsDestinyItemComponentBuilder</returns>
        public DestinyEntitiesItemsDestinyItemComponentBuilder With()
        {
            return Builder()
                .ItemHash(ItemHash)
                .ItemInstanceId(ItemInstanceId)
                .Quantity(Quantity)
                .BindStatus(BindStatus)
                .Location(Location)
                .BucketHash(BucketHash)
                .TransferStatus(TransferStatus)
                .Lockable(Lockable)
                .State(State)
                .OverrideStyleItemHash(OverrideStyleItemHash)
                .ExpirationDate(ExpirationDate)
                .IsWrapper(IsWrapper)
                .TooltipNotificationIndexes(TooltipNotificationIndexes)
                .MetricHash(MetricHash)
                .MetricObjective(MetricObjective);
        }

        public override string ToString()
        {
            return this.PropertiesToString();
        }

        public override bool Equals(object obj)
        {
            return this.EqualsByProperties(obj);
        }

        public bool Equals(DestinyEntitiesItemsDestinyItemComponent other)
        {
            return Equals((object) other);
        }

        public override int GetHashCode()
        {
            return this.PropertiesHash();
        }

        /// <summary>
        /// Implementation of == operator for (DestinyEntitiesItemsDestinyItemComponent.
        /// </summary>
        /// <param name="left">Compared (DestinyEntitiesItemsDestinyItemComponent</param>
        /// <param name="right">Compared (DestinyEntitiesItemsDestinyItemComponent</param>
        /// <returns>true if compared items are equals, false otherwise</returns>
        public static bool operator == (DestinyEntitiesItemsDestinyItemComponent left, DestinyEntitiesItemsDestinyItemComponent right)
        {
            return Equals(left, right);
        }

        /// <summary>
        /// Implementation of != operator for (DestinyEntitiesItemsDestinyItemComponent.
        /// </summary>
        /// <param name="left">Compared (DestinyEntitiesItemsDestinyItemComponent</param>
        /// <param name="right">Compared (DestinyEntitiesItemsDestinyItemComponent</param>
        /// <returns>true if compared items are not equals, false otherwise</returns>
        public static bool operator != (DestinyEntitiesItemsDestinyItemComponent left, DestinyEntitiesItemsDestinyItemComponent right)
        {
            return !Equals(left, right);
        }

        /// <summary>
        /// Builder of DestinyEntitiesItemsDestinyItemComponent.
        /// </summary>
        public sealed class DestinyEntitiesItemsDestinyItemComponentBuilder
        {
            private int? _ItemHash;
            private long? _ItemInstanceId;
            private int? _Quantity;
            private int? _BindStatus;
            private int? _Location;
            private int? _BucketHash;
            private int? _TransferStatus;
            private bool? _Lockable;
            private int? _State;
            private int? _OverrideStyleItemHash;
            private DateTime? _ExpirationDate;
            private bool? _IsWrapper;
            private List<int?> _TooltipNotificationIndexes;
            private int? _MetricHash;
            private DestinyQuestsDestinyObjectiveProgress _MetricObjective;

            internal DestinyEntitiesItemsDestinyItemComponentBuilder()
            {
                SetupDefaults();
            }

            private void SetupDefaults()
            {
            }

            /// <summary>
            /// Sets value for DestinyEntitiesItemsDestinyItemComponent.ItemHash property.
            /// </summary>
            /// <param name="value">The identifier for the item&#39;s definition, which is where most of the useful static information for the item can be found.</param>
            public DestinyEntitiesItemsDestinyItemComponentBuilder ItemHash(int? value)
            {
                _ItemHash = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyEntitiesItemsDestinyItemComponent.ItemInstanceId property.
            /// </summary>
            /// <param name="value">If the item is instanced, it will have an instance ID. Lack of an instance ID implies that the item has no distinct local qualities aside from stack size.</param>
            public DestinyEntitiesItemsDestinyItemComponentBuilder ItemInstanceId(long? value)
            {
                _ItemInstanceId = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyEntitiesItemsDestinyItemComponent.Quantity property.
            /// </summary>
            /// <param name="value">The quantity of the item in this stack. Note that Instanced items cannot stack. If an instanced item, this value will always be 1 (as the stack has exactly one item in it)</param>
            public DestinyEntitiesItemsDestinyItemComponentBuilder Quantity(int? value)
            {
                _Quantity = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyEntitiesItemsDestinyItemComponent.BindStatus property.
            /// </summary>
            /// <param name="value">If the item is bound to a location, it will be specified in this enum.</param>
            public DestinyEntitiesItemsDestinyItemComponentBuilder BindStatus(int? value)
            {
                _BindStatus = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyEntitiesItemsDestinyItemComponent.Location property.
            /// </summary>
            /// <param name="value">An easy reference for where the item is located. Redundant if you got the item from an Inventory, but useful when making detail calls on specific items.</param>
            public DestinyEntitiesItemsDestinyItemComponentBuilder Location(int? value)
            {
                _Location = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyEntitiesItemsDestinyItemComponent.BucketHash property.
            /// </summary>
            /// <param name="value">The hash identifier for the specific inventory bucket in which the item is located.</param>
            public DestinyEntitiesItemsDestinyItemComponentBuilder BucketHash(int? value)
            {
                _BucketHash = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyEntitiesItemsDestinyItemComponent.TransferStatus property.
            /// </summary>
            /// <param name="value">If there is a known error state that would cause this item to not be transferable, this Flags enum will indicate all of those error states. Otherwise, it will be 0 (CanTransfer).</param>
            public DestinyEntitiesItemsDestinyItemComponentBuilder TransferStatus(int? value)
            {
                _TransferStatus = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyEntitiesItemsDestinyItemComponent.Lockable property.
            /// </summary>
            /// <param name="value">If the item can be locked, this will indicate that state.</param>
            public DestinyEntitiesItemsDestinyItemComponentBuilder Lockable(bool? value)
            {
                _Lockable = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyEntitiesItemsDestinyItemComponent.State property.
            /// </summary>
            /// <param name="value">A flags enumeration indicating the transient/custom states of the item that affect how it is rendered: whether it&#39;s tracked or locked for example, or whether it has a masterwork plug inserted.</param>
            public DestinyEntitiesItemsDestinyItemComponentBuilder State(int? value)
            {
                _State = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyEntitiesItemsDestinyItemComponent.OverrideStyleItemHash property.
            /// </summary>
            /// <param name="value">If populated, this is the hash of the item whose icon (and other secondary styles, but *not* the human readable strings) should override whatever icons/styles are on the item being sold.  If you don&#39;t do this, certain items whose styles are being overridden by socketed items - such as the \&quot;Recycle Shader\&quot; item - would show whatever their default icon/style is, and it wouldn&#39;t be pretty or look accurate.</param>
            public DestinyEntitiesItemsDestinyItemComponentBuilder OverrideStyleItemHash(int? value)
            {
                _OverrideStyleItemHash = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyEntitiesItemsDestinyItemComponent.ExpirationDate property.
            /// </summary>
            /// <param name="value">If the item can expire, this is the date at which it will/did expire.</param>
            public DestinyEntitiesItemsDestinyItemComponentBuilder ExpirationDate(DateTime? value)
            {
                _ExpirationDate = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyEntitiesItemsDestinyItemComponent.IsWrapper property.
            /// </summary>
            /// <param name="value">If this is true, the object is actually a \&quot;wrapper\&quot; of the object it&#39;s representing. This means that it&#39;s not the actual item itself, but rather an item that must be \&quot;opened\&quot; in game before you have and can use the item.   Wrappers are an evolution of \&quot;bundles\&quot;, which give an easy way to let you preview the contents of what you purchased while still letting you get a refund before you \&quot;open\&quot; it.</param>
            public DestinyEntitiesItemsDestinyItemComponentBuilder IsWrapper(bool? value)
            {
                _IsWrapper = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyEntitiesItemsDestinyItemComponent.TooltipNotificationIndexes property.
            /// </summary>
            /// <param name="value">If this is populated, it is a list of indexes into DestinyInventoryItemDefinition.tooltipNotifications for any special tooltip messages that need to be shown for this item.</param>
            public DestinyEntitiesItemsDestinyItemComponentBuilder TooltipNotificationIndexes(List<int?> value)
            {
                _TooltipNotificationIndexes = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyEntitiesItemsDestinyItemComponent.MetricHash property.
            /// </summary>
            /// <param name="value">The identifier for the currently-selected metric definition, to be displayed on the emblem nameplate.</param>
            public DestinyEntitiesItemsDestinyItemComponentBuilder MetricHash(int? value)
            {
                _MetricHash = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyEntitiesItemsDestinyItemComponent.MetricObjective property.
            /// </summary>
            /// <param name="value">The objective progress for the currently-selected metric definition, to be displayed on the emblem nameplate.</param>
            public DestinyEntitiesItemsDestinyItemComponentBuilder MetricObjective(DestinyQuestsDestinyObjectiveProgress value)
            {
                _MetricObjective = value;
                return this;
            }


            /// <summary>
            /// Builds instance of DestinyEntitiesItemsDestinyItemComponent.
            /// </summary>
            /// <returns>DestinyEntitiesItemsDestinyItemComponent</returns>
            public DestinyEntitiesItemsDestinyItemComponent Build()
            {
                Validate();
                return new DestinyEntitiesItemsDestinyItemComponent(
                    ItemHash: _ItemHash,
                    ItemInstanceId: _ItemInstanceId,
                    Quantity: _Quantity,
                    BindStatus: _BindStatus,
                    Location: _Location,
                    BucketHash: _BucketHash,
                    TransferStatus: _TransferStatus,
                    Lockable: _Lockable,
                    State: _State,
                    OverrideStyleItemHash: _OverrideStyleItemHash,
                    ExpirationDate: _ExpirationDate,
                    IsWrapper: _IsWrapper,
                    TooltipNotificationIndexes: _TooltipNotificationIndexes,
                    MetricHash: _MetricHash,
                    MetricObjective: _MetricObjective
                );
            }

            private void Validate()
            { 
            }
        }

        
    }
}