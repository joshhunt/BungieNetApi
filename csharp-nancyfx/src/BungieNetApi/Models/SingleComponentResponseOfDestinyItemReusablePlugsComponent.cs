using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Sharpility.Extensions;
using NodaTime;

namespace BungieNetApi._Platform.Models
{
    /// <summary>
    /// SingleComponentResponseOfDestinyItemReusablePlugsComponent
    /// </summary>
    public sealed class SingleComponentResponseOfDestinyItemReusablePlugsComponent:  IEquatable<SingleComponentResponseOfDestinyItemReusablePlugsComponent>
    { 
        /// <summary>
        /// Data
        /// </summary>
        public DestinyComponentsItemsDestinyItemReusablePlugsComponent Data { get; private set; }

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
        /// Use SingleComponentResponseOfDestinyItemReusablePlugsComponent.Builder() for instance creation instead.
        /// </summary>
        [Obsolete]
        public SingleComponentResponseOfDestinyItemReusablePlugsComponent()
        {
        }

        private SingleComponentResponseOfDestinyItemReusablePlugsComponent(DestinyComponentsItemsDestinyItemReusablePlugsComponent Data, int? Privacy, bool? Disabled)
        {
            
            this.Data = Data;
            
            this.Privacy = Privacy;
            
            this.Disabled = Disabled;
            
        }

        /// <summary>
        /// Returns builder of SingleComponentResponseOfDestinyItemReusablePlugsComponent.
        /// </summary>
        /// <returns>SingleComponentResponseOfDestinyItemReusablePlugsComponentBuilder</returns>
        public static SingleComponentResponseOfDestinyItemReusablePlugsComponentBuilder Builder()
        {
            return new SingleComponentResponseOfDestinyItemReusablePlugsComponentBuilder();
        }

        /// <summary>
        /// Returns SingleComponentResponseOfDestinyItemReusablePlugsComponentBuilder with properties set.
        /// Use it to change properties.
        /// </summary>
        /// <returns>SingleComponentResponseOfDestinyItemReusablePlugsComponentBuilder</returns>
        public SingleComponentResponseOfDestinyItemReusablePlugsComponentBuilder With()
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

        public bool Equals(SingleComponentResponseOfDestinyItemReusablePlugsComponent other)
        {
            return Equals((object) other);
        }

        public override int GetHashCode()
        {
            return this.PropertiesHash();
        }

        /// <summary>
        /// Implementation of == operator for (SingleComponentResponseOfDestinyItemReusablePlugsComponent.
        /// </summary>
        /// <param name="left">Compared (SingleComponentResponseOfDestinyItemReusablePlugsComponent</param>
        /// <param name="right">Compared (SingleComponentResponseOfDestinyItemReusablePlugsComponent</param>
        /// <returns>true if compared items are equals, false otherwise</returns>
        public static bool operator == (SingleComponentResponseOfDestinyItemReusablePlugsComponent left, SingleComponentResponseOfDestinyItemReusablePlugsComponent right)
        {
            return Equals(left, right);
        }

        /// <summary>
        /// Implementation of != operator for (SingleComponentResponseOfDestinyItemReusablePlugsComponent.
        /// </summary>
        /// <param name="left">Compared (SingleComponentResponseOfDestinyItemReusablePlugsComponent</param>
        /// <param name="right">Compared (SingleComponentResponseOfDestinyItemReusablePlugsComponent</param>
        /// <returns>true if compared items are not equals, false otherwise</returns>
        public static bool operator != (SingleComponentResponseOfDestinyItemReusablePlugsComponent left, SingleComponentResponseOfDestinyItemReusablePlugsComponent right)
        {
            return !Equals(left, right);
        }

        /// <summary>
        /// Builder of SingleComponentResponseOfDestinyItemReusablePlugsComponent.
        /// </summary>
        public sealed class SingleComponentResponseOfDestinyItemReusablePlugsComponentBuilder
        {
            private DestinyComponentsItemsDestinyItemReusablePlugsComponent _Data;
            private int? _Privacy;
            private bool? _Disabled;

            internal SingleComponentResponseOfDestinyItemReusablePlugsComponentBuilder()
            {
                SetupDefaults();
            }

            private void SetupDefaults()
            {
            }

            /// <summary>
            /// Sets value for SingleComponentResponseOfDestinyItemReusablePlugsComponent.Data property.
            /// </summary>
            /// <param name="value">Data</param>
            public SingleComponentResponseOfDestinyItemReusablePlugsComponentBuilder Data(DestinyComponentsItemsDestinyItemReusablePlugsComponent value)
            {
                _Data = value;
                return this;
            }

            /// <summary>
            /// Sets value for SingleComponentResponseOfDestinyItemReusablePlugsComponent.Privacy property.
            /// </summary>
            /// <param name="value">Privacy</param>
            public SingleComponentResponseOfDestinyItemReusablePlugsComponentBuilder Privacy(int? value)
            {
                _Privacy = value;
                return this;
            }

            /// <summary>
            /// Sets value for SingleComponentResponseOfDestinyItemReusablePlugsComponent.Disabled property.
            /// </summary>
            /// <param name="value">If true, this component is disabled.</param>
            public SingleComponentResponseOfDestinyItemReusablePlugsComponentBuilder Disabled(bool? value)
            {
                _Disabled = value;
                return this;
            }


            /// <summary>
            /// Builds instance of SingleComponentResponseOfDestinyItemReusablePlugsComponent.
            /// </summary>
            /// <returns>SingleComponentResponseOfDestinyItemReusablePlugsComponent</returns>
            public SingleComponentResponseOfDestinyItemReusablePlugsComponent Build()
            {
                Validate();
                return new SingleComponentResponseOfDestinyItemReusablePlugsComponent(
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