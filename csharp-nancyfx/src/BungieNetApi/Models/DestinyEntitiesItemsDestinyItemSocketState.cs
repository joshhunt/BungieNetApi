using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Sharpility.Extensions;
using NodaTime;

namespace BungieNetApi._Platform.Models
{
    /// <summary>
    /// The status of a given item&#39;s socket. (which plug is inserted, if any: whether it is enabled, what \&quot;reusable\&quot; plugs can be inserted, etc...)  If I had it to do over, this would probably have a DestinyItemPlug representing the inserted item instead of most of these properties. :shrug:
    /// </summary>
    public sealed class DestinyEntitiesItemsDestinyItemSocketState:  IEquatable<DestinyEntitiesItemsDestinyItemSocketState>
    { 
        /// <summary>
        /// The currently active plug, if any.  Note that, because all plugs are statically defined, its effect on stats and perks can be statically determined using the plug item&#39;s definition. The stats and perks can be taken at face value on the plug item as the stats and perks it will provide to the user/item.
        /// </summary>
        public int? PlugHash { get; private set; }

        /// <summary>
        /// Even if a plug is inserted, it doesn&#39;t mean it&#39;s enabled.  This flag indicates whether the plug is active and providing its benefits.
        /// </summary>
        public bool? IsEnabled { get; private set; }

        /// <summary>
        /// A plug may theoretically provide benefits but not be visible - for instance, some older items use a plug&#39;s damage type perk to modify their own damage type. These, though they are not visible, still affect the item. This field indicates that state.  An invisible plug, while it provides benefits if it is Enabled, cannot be directly modified by the user.
        /// </summary>
        public bool? IsVisible { get; private set; }

        /// <summary>
        /// If a plug is inserted but not enabled, this will be populated with indexes into the plug item definition&#39;s plug.enabledRules property, so that you can show the reasons why it is not enabled.
        /// </summary>
        public List<int?> EnableFailIndexes { get; private set; }


        /// <summary>
        /// Empty constructor required by some serializers.
        /// Use DestinyEntitiesItemsDestinyItemSocketState.Builder() for instance creation instead.
        /// </summary>
        [Obsolete]
        public DestinyEntitiesItemsDestinyItemSocketState()
        {
        }

        private DestinyEntitiesItemsDestinyItemSocketState(int? PlugHash, bool? IsEnabled, bool? IsVisible, List<int?> EnableFailIndexes)
        {
            
            this.PlugHash = PlugHash;
            
            this.IsEnabled = IsEnabled;
            
            this.IsVisible = IsVisible;
            
            this.EnableFailIndexes = EnableFailIndexes;
            
        }

        /// <summary>
        /// Returns builder of DestinyEntitiesItemsDestinyItemSocketState.
        /// </summary>
        /// <returns>DestinyEntitiesItemsDestinyItemSocketStateBuilder</returns>
        public static DestinyEntitiesItemsDestinyItemSocketStateBuilder Builder()
        {
            return new DestinyEntitiesItemsDestinyItemSocketStateBuilder();
        }

        /// <summary>
        /// Returns DestinyEntitiesItemsDestinyItemSocketStateBuilder with properties set.
        /// Use it to change properties.
        /// </summary>
        /// <returns>DestinyEntitiesItemsDestinyItemSocketStateBuilder</returns>
        public DestinyEntitiesItemsDestinyItemSocketStateBuilder With()
        {
            return Builder()
                .PlugHash(PlugHash)
                .IsEnabled(IsEnabled)
                .IsVisible(IsVisible)
                .EnableFailIndexes(EnableFailIndexes);
        }

        public override string ToString()
        {
            return this.PropertiesToString();
        }

        public override bool Equals(object obj)
        {
            return this.EqualsByProperties(obj);
        }

        public bool Equals(DestinyEntitiesItemsDestinyItemSocketState other)
        {
            return Equals((object) other);
        }

        public override int GetHashCode()
        {
            return this.PropertiesHash();
        }

        /// <summary>
        /// Implementation of == operator for (DestinyEntitiesItemsDestinyItemSocketState.
        /// </summary>
        /// <param name="left">Compared (DestinyEntitiesItemsDestinyItemSocketState</param>
        /// <param name="right">Compared (DestinyEntitiesItemsDestinyItemSocketState</param>
        /// <returns>true if compared items are equals, false otherwise</returns>
        public static bool operator == (DestinyEntitiesItemsDestinyItemSocketState left, DestinyEntitiesItemsDestinyItemSocketState right)
        {
            return Equals(left, right);
        }

        /// <summary>
        /// Implementation of != operator for (DestinyEntitiesItemsDestinyItemSocketState.
        /// </summary>
        /// <param name="left">Compared (DestinyEntitiesItemsDestinyItemSocketState</param>
        /// <param name="right">Compared (DestinyEntitiesItemsDestinyItemSocketState</param>
        /// <returns>true if compared items are not equals, false otherwise</returns>
        public static bool operator != (DestinyEntitiesItemsDestinyItemSocketState left, DestinyEntitiesItemsDestinyItemSocketState right)
        {
            return !Equals(left, right);
        }

        /// <summary>
        /// Builder of DestinyEntitiesItemsDestinyItemSocketState.
        /// </summary>
        public sealed class DestinyEntitiesItemsDestinyItemSocketStateBuilder
        {
            private int? _PlugHash;
            private bool? _IsEnabled;
            private bool? _IsVisible;
            private List<int?> _EnableFailIndexes;

            internal DestinyEntitiesItemsDestinyItemSocketStateBuilder()
            {
                SetupDefaults();
            }

            private void SetupDefaults()
            {
            }

            /// <summary>
            /// Sets value for DestinyEntitiesItemsDestinyItemSocketState.PlugHash property.
            /// </summary>
            /// <param name="value">The currently active plug, if any.  Note that, because all plugs are statically defined, its effect on stats and perks can be statically determined using the plug item&#39;s definition. The stats and perks can be taken at face value on the plug item as the stats and perks it will provide to the user/item.</param>
            public DestinyEntitiesItemsDestinyItemSocketStateBuilder PlugHash(int? value)
            {
                _PlugHash = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyEntitiesItemsDestinyItemSocketState.IsEnabled property.
            /// </summary>
            /// <param name="value">Even if a plug is inserted, it doesn&#39;t mean it&#39;s enabled.  This flag indicates whether the plug is active and providing its benefits.</param>
            public DestinyEntitiesItemsDestinyItemSocketStateBuilder IsEnabled(bool? value)
            {
                _IsEnabled = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyEntitiesItemsDestinyItemSocketState.IsVisible property.
            /// </summary>
            /// <param name="value">A plug may theoretically provide benefits but not be visible - for instance, some older items use a plug&#39;s damage type perk to modify their own damage type. These, though they are not visible, still affect the item. This field indicates that state.  An invisible plug, while it provides benefits if it is Enabled, cannot be directly modified by the user.</param>
            public DestinyEntitiesItemsDestinyItemSocketStateBuilder IsVisible(bool? value)
            {
                _IsVisible = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyEntitiesItemsDestinyItemSocketState.EnableFailIndexes property.
            /// </summary>
            /// <param name="value">If a plug is inserted but not enabled, this will be populated with indexes into the plug item definition&#39;s plug.enabledRules property, so that you can show the reasons why it is not enabled.</param>
            public DestinyEntitiesItemsDestinyItemSocketStateBuilder EnableFailIndexes(List<int?> value)
            {
                _EnableFailIndexes = value;
                return this;
            }


            /// <summary>
            /// Builds instance of DestinyEntitiesItemsDestinyItemSocketState.
            /// </summary>
            /// <returns>DestinyEntitiesItemsDestinyItemSocketState</returns>
            public DestinyEntitiesItemsDestinyItemSocketState Build()
            {
                Validate();
                return new DestinyEntitiesItemsDestinyItemSocketState(
                    PlugHash: _PlugHash,
                    IsEnabled: _IsEnabled,
                    IsVisible: _IsVisible,
                    EnableFailIndexes: _EnableFailIndexes
                );
            }

            private void Validate()
            { 
            }
        }

        
    }
}