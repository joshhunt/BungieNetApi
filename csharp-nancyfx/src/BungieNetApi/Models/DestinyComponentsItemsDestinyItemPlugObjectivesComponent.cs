using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Sharpility.Extensions;
using NodaTime;

namespace BungieNetApi._Platform.Models
{
    /// <summary>
    /// DestinyComponentsItemsDestinyItemPlugObjectivesComponent
    /// </summary>
    public sealed class DestinyComponentsItemsDestinyItemPlugObjectivesComponent:  IEquatable<DestinyComponentsItemsDestinyItemPlugObjectivesComponent>
    { 
        /// <summary>
        /// This set of data is keyed by the Item Hash (DestinyInventoryItemDefinition) of the plug whose objectives are being returned, with the value being the list of those objectives.   What if two plugs with the same hash are returned for an item, you ask?   Good question! They share the same item-scoped state, and as such would have identical objective state as a result. How&#39;s that for convenient.   Sometimes, Plugs may have objectives: generally, these are used for flavor and display purposes. For instance, a Plug might be tracking the number of PVP kills you have made. It will use the parent item&#39;s data about that tracking status to determine what to show, and will generally show it using the DestinyObjectiveDefinition&#39;s progressDescription property. Refer to the plug&#39;s itemHash and objective property for more information if you would like to display even more data.
        /// </summary>
        public Dictionary<string, List<DestinyQuestsDestinyObjectiveProgress>> ObjectivesPerPlug { get; private set; }


        /// <summary>
        /// Empty constructor required by some serializers.
        /// Use DestinyComponentsItemsDestinyItemPlugObjectivesComponent.Builder() for instance creation instead.
        /// </summary>
        [Obsolete]
        public DestinyComponentsItemsDestinyItemPlugObjectivesComponent()
        {
        }

        private DestinyComponentsItemsDestinyItemPlugObjectivesComponent(Dictionary<string, List<DestinyQuestsDestinyObjectiveProgress>> ObjectivesPerPlug)
        {
            
            this.ObjectivesPerPlug = ObjectivesPerPlug;
            
        }

        /// <summary>
        /// Returns builder of DestinyComponentsItemsDestinyItemPlugObjectivesComponent.
        /// </summary>
        /// <returns>DestinyComponentsItemsDestinyItemPlugObjectivesComponentBuilder</returns>
        public static DestinyComponentsItemsDestinyItemPlugObjectivesComponentBuilder Builder()
        {
            return new DestinyComponentsItemsDestinyItemPlugObjectivesComponentBuilder();
        }

        /// <summary>
        /// Returns DestinyComponentsItemsDestinyItemPlugObjectivesComponentBuilder with properties set.
        /// Use it to change properties.
        /// </summary>
        /// <returns>DestinyComponentsItemsDestinyItemPlugObjectivesComponentBuilder</returns>
        public DestinyComponentsItemsDestinyItemPlugObjectivesComponentBuilder With()
        {
            return Builder()
                .ObjectivesPerPlug(ObjectivesPerPlug);
        }

        public override string ToString()
        {
            return this.PropertiesToString();
        }

        public override bool Equals(object obj)
        {
            return this.EqualsByProperties(obj);
        }

        public bool Equals(DestinyComponentsItemsDestinyItemPlugObjectivesComponent other)
        {
            return Equals((object) other);
        }

        public override int GetHashCode()
        {
            return this.PropertiesHash();
        }

        /// <summary>
        /// Implementation of == operator for (DestinyComponentsItemsDestinyItemPlugObjectivesComponent.
        /// </summary>
        /// <param name="left">Compared (DestinyComponentsItemsDestinyItemPlugObjectivesComponent</param>
        /// <param name="right">Compared (DestinyComponentsItemsDestinyItemPlugObjectivesComponent</param>
        /// <returns>true if compared items are equals, false otherwise</returns>
        public static bool operator == (DestinyComponentsItemsDestinyItemPlugObjectivesComponent left, DestinyComponentsItemsDestinyItemPlugObjectivesComponent right)
        {
            return Equals(left, right);
        }

        /// <summary>
        /// Implementation of != operator for (DestinyComponentsItemsDestinyItemPlugObjectivesComponent.
        /// </summary>
        /// <param name="left">Compared (DestinyComponentsItemsDestinyItemPlugObjectivesComponent</param>
        /// <param name="right">Compared (DestinyComponentsItemsDestinyItemPlugObjectivesComponent</param>
        /// <returns>true if compared items are not equals, false otherwise</returns>
        public static bool operator != (DestinyComponentsItemsDestinyItemPlugObjectivesComponent left, DestinyComponentsItemsDestinyItemPlugObjectivesComponent right)
        {
            return !Equals(left, right);
        }

        /// <summary>
        /// Builder of DestinyComponentsItemsDestinyItemPlugObjectivesComponent.
        /// </summary>
        public sealed class DestinyComponentsItemsDestinyItemPlugObjectivesComponentBuilder
        {
            private Dictionary<string, List<DestinyQuestsDestinyObjectiveProgress>> _ObjectivesPerPlug;

            internal DestinyComponentsItemsDestinyItemPlugObjectivesComponentBuilder()
            {
                SetupDefaults();
            }

            private void SetupDefaults()
            {
            }

            /// <summary>
            /// Sets value for DestinyComponentsItemsDestinyItemPlugObjectivesComponent.ObjectivesPerPlug property.
            /// </summary>
            /// <param name="value">This set of data is keyed by the Item Hash (DestinyInventoryItemDefinition) of the plug whose objectives are being returned, with the value being the list of those objectives.   What if two plugs with the same hash are returned for an item, you ask?   Good question! They share the same item-scoped state, and as such would have identical objective state as a result. How&#39;s that for convenient.   Sometimes, Plugs may have objectives: generally, these are used for flavor and display purposes. For instance, a Plug might be tracking the number of PVP kills you have made. It will use the parent item&#39;s data about that tracking status to determine what to show, and will generally show it using the DestinyObjectiveDefinition&#39;s progressDescription property. Refer to the plug&#39;s itemHash and objective property for more information if you would like to display even more data.</param>
            public DestinyComponentsItemsDestinyItemPlugObjectivesComponentBuilder ObjectivesPerPlug(Dictionary<string, List<DestinyQuestsDestinyObjectiveProgress>> value)
            {
                _ObjectivesPerPlug = value;
                return this;
            }


            /// <summary>
            /// Builds instance of DestinyComponentsItemsDestinyItemPlugObjectivesComponent.
            /// </summary>
            /// <returns>DestinyComponentsItemsDestinyItemPlugObjectivesComponent</returns>
            public DestinyComponentsItemsDestinyItemPlugObjectivesComponent Build()
            {
                Validate();
                return new DestinyComponentsItemsDestinyItemPlugObjectivesComponent(
                    ObjectivesPerPlug: _ObjectivesPerPlug
                );
            }

            private void Validate()
            { 
            }
        }

        
    }
}