using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Sharpility.Extensions;
using NodaTime;

namespace BungieNetApi._Platform.Models
{
    /// <summary>
    /// SingleComponentResponseOfDestinyItemStatsComponent
    /// </summary>
    public sealed class SingleComponentResponseOfDestinyItemStatsComponent:  IEquatable<SingleComponentResponseOfDestinyItemStatsComponent>
    { 
        /// <summary>
        /// Data
        /// </summary>
        public DestinyEntitiesItemsDestinyItemStatsComponent Data { get; private set; }

        /// <summary>
        /// Privacy
        /// </summary>
        public int? Privacy { get; private set; }

        /// <summary>
        /// If true, this component is disabled.
        /// </summary>
        public bool? Disabled { get; private set; }


        /// <summary>
        /// Empty constructor required by some serializers.
        /// Use SingleComponentResponseOfDestinyItemStatsComponent.Builder() for instance creation instead.
        /// </summary>
        [Obsolete]
        public SingleComponentResponseOfDestinyItemStatsComponent()
        {
        }

        private SingleComponentResponseOfDestinyItemStatsComponent(DestinyEntitiesItemsDestinyItemStatsComponent Data, int? Privacy, bool? Disabled)
        {
            
            this.Data = Data;
            
            this.Privacy = Privacy;
            
            this.Disabled = Disabled;
            
        }

        /// <summary>
        /// Returns builder of SingleComponentResponseOfDestinyItemStatsComponent.
        /// </summary>
        /// <returns>SingleComponentResponseOfDestinyItemStatsComponentBuilder</returns>
        public static SingleComponentResponseOfDestinyItemStatsComponentBuilder Builder()
        {
            return new SingleComponentResponseOfDestinyItemStatsComponentBuilder();
        }

        /// <summary>
        /// Returns SingleComponentResponseOfDestinyItemStatsComponentBuilder with properties set.
        /// Use it to change properties.
        /// </summary>
        /// <returns>SingleComponentResponseOfDestinyItemStatsComponentBuilder</returns>
        public SingleComponentResponseOfDestinyItemStatsComponentBuilder With()
        {
            return Builder()
                .Data(Data)
                .Privacy(Privacy)
                .Disabled(Disabled);
        }

        public override string ToString()
        {
            return this.PropertiesToString();
        }

        public override bool Equals(object obj)
        {
            return this.EqualsByProperties(obj);
        }

        public bool Equals(SingleComponentResponseOfDestinyItemStatsComponent other)
        {
            return Equals((object) other);
        }

        public override int GetHashCode()
        {
            return this.PropertiesHash();
        }

        /// <summary>
        /// Implementation of == operator for (SingleComponentResponseOfDestinyItemStatsComponent.
        /// </summary>
        /// <param name="left">Compared (SingleComponentResponseOfDestinyItemStatsComponent</param>
        /// <param name="right">Compared (SingleComponentResponseOfDestinyItemStatsComponent</param>
        /// <returns>true if compared items are equals, false otherwise</returns>
        public static bool operator == (SingleComponentResponseOfDestinyItemStatsComponent left, SingleComponentResponseOfDestinyItemStatsComponent right)
        {
            return Equals(left, right);
        }

        /// <summary>
        /// Implementation of != operator for (SingleComponentResponseOfDestinyItemStatsComponent.
        /// </summary>
        /// <param name="left">Compared (SingleComponentResponseOfDestinyItemStatsComponent</param>
        /// <param name="right">Compared (SingleComponentResponseOfDestinyItemStatsComponent</param>
        /// <returns>true if compared items are not equals, false otherwise</returns>
        public static bool operator != (SingleComponentResponseOfDestinyItemStatsComponent left, SingleComponentResponseOfDestinyItemStatsComponent right)
        {
            return !Equals(left, right);
        }

        /// <summary>
        /// Builder of SingleComponentResponseOfDestinyItemStatsComponent.
        /// </summary>
        public sealed class SingleComponentResponseOfDestinyItemStatsComponentBuilder
        {
            private DestinyEntitiesItemsDestinyItemStatsComponent _Data;
            private int? _Privacy;
            private bool? _Disabled;

            internal SingleComponentResponseOfDestinyItemStatsComponentBuilder()
            {
                SetupDefaults();
            }

            private void SetupDefaults()
            {
            }

            /// <summary>
            /// Sets value for SingleComponentResponseOfDestinyItemStatsComponent.Data property.
            /// </summary>
            /// <param name="value">Data</param>
            public SingleComponentResponseOfDestinyItemStatsComponentBuilder Data(DestinyEntitiesItemsDestinyItemStatsComponent value)
            {
                _Data = value;
                return this;
            }

            /// <summary>
            /// Sets value for SingleComponentResponseOfDestinyItemStatsComponent.Privacy property.
            /// </summary>
            /// <param name="value">Privacy</param>
            public SingleComponentResponseOfDestinyItemStatsComponentBuilder Privacy(int? value)
            {
                _Privacy = value;
                return this;
            }

            /// <summary>
            /// Sets value for SingleComponentResponseOfDestinyItemStatsComponent.Disabled property.
            /// </summary>
            /// <param name="value">If true, this component is disabled.</param>
            public SingleComponentResponseOfDestinyItemStatsComponentBuilder Disabled(bool? value)
            {
                _Disabled = value;
                return this;
            }


            /// <summary>
            /// Builds instance of SingleComponentResponseOfDestinyItemStatsComponent.
            /// </summary>
            /// <returns>SingleComponentResponseOfDestinyItemStatsComponent</returns>
            public SingleComponentResponseOfDestinyItemStatsComponent Build()
            {
                Validate();
                return new SingleComponentResponseOfDestinyItemStatsComponent(
                    Data: _Data,
                    Privacy: _Privacy,
                    Disabled: _Disabled
                );
            }

            private void Validate()
            { 
            }
        }

        
    }
}