using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Sharpility.Extensions;
using NodaTime;

namespace BungieNetApi._Platform.Models
{
    /// <summary>
    /// SingleComponentResponseOfDestinyMetricsComponent
    /// </summary>
    public sealed class SingleComponentResponseOfDestinyMetricsComponent:  IEquatable<SingleComponentResponseOfDestinyMetricsComponent>
    { 
        /// <summary>
        /// Data
        /// </summary>
        public DestinyComponentsMetricsDestinyMetricsComponent Data { get; private set; }

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
        /// Use SingleComponentResponseOfDestinyMetricsComponent.Builder() for instance creation instead.
        /// </summary>
        [Obsolete]
        public SingleComponentResponseOfDestinyMetricsComponent()
        {
        }

        private SingleComponentResponseOfDestinyMetricsComponent(DestinyComponentsMetricsDestinyMetricsComponent Data, int? Privacy, bool? Disabled)
        {
            
            this.Data = Data;
            
            this.Privacy = Privacy;
            
            this.Disabled = Disabled;
            
        }

        /// <summary>
        /// Returns builder of SingleComponentResponseOfDestinyMetricsComponent.
        /// </summary>
        /// <returns>SingleComponentResponseOfDestinyMetricsComponentBuilder</returns>
        public static SingleComponentResponseOfDestinyMetricsComponentBuilder Builder()
        {
            return new SingleComponentResponseOfDestinyMetricsComponentBuilder();
        }

        /// <summary>
        /// Returns SingleComponentResponseOfDestinyMetricsComponentBuilder with properties set.
        /// Use it to change properties.
        /// </summary>
        /// <returns>SingleComponentResponseOfDestinyMetricsComponentBuilder</returns>
        public SingleComponentResponseOfDestinyMetricsComponentBuilder With()
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

        public bool Equals(SingleComponentResponseOfDestinyMetricsComponent other)
        {
            return Equals((object) other);
        }

        public override int GetHashCode()
        {
            return this.PropertiesHash();
        }

        /// <summary>
        /// Implementation of == operator for (SingleComponentResponseOfDestinyMetricsComponent.
        /// </summary>
        /// <param name="left">Compared (SingleComponentResponseOfDestinyMetricsComponent</param>
        /// <param name="right">Compared (SingleComponentResponseOfDestinyMetricsComponent</param>
        /// <returns>true if compared items are equals, false otherwise</returns>
        public static bool operator == (SingleComponentResponseOfDestinyMetricsComponent left, SingleComponentResponseOfDestinyMetricsComponent right)
        {
            return Equals(left, right);
        }

        /// <summary>
        /// Implementation of != operator for (SingleComponentResponseOfDestinyMetricsComponent.
        /// </summary>
        /// <param name="left">Compared (SingleComponentResponseOfDestinyMetricsComponent</param>
        /// <param name="right">Compared (SingleComponentResponseOfDestinyMetricsComponent</param>
        /// <returns>true if compared items are not equals, false otherwise</returns>
        public static bool operator != (SingleComponentResponseOfDestinyMetricsComponent left, SingleComponentResponseOfDestinyMetricsComponent right)
        {
            return !Equals(left, right);
        }

        /// <summary>
        /// Builder of SingleComponentResponseOfDestinyMetricsComponent.
        /// </summary>
        public sealed class SingleComponentResponseOfDestinyMetricsComponentBuilder
        {
            private DestinyComponentsMetricsDestinyMetricsComponent _Data;
            private int? _Privacy;
            private bool? _Disabled;

            internal SingleComponentResponseOfDestinyMetricsComponentBuilder()
            {
                SetupDefaults();
            }

            private void SetupDefaults()
            {
            }

            /// <summary>
            /// Sets value for SingleComponentResponseOfDestinyMetricsComponent.Data property.
            /// </summary>
            /// <param name="value">Data</param>
            public SingleComponentResponseOfDestinyMetricsComponentBuilder Data(DestinyComponentsMetricsDestinyMetricsComponent value)
            {
                _Data = value;
                return this;
            }

            /// <summary>
            /// Sets value for SingleComponentResponseOfDestinyMetricsComponent.Privacy property.
            /// </summary>
            /// <param name="value">Privacy</param>
            public SingleComponentResponseOfDestinyMetricsComponentBuilder Privacy(int? value)
            {
                _Privacy = value;
                return this;
            }

            /// <summary>
            /// Sets value for SingleComponentResponseOfDestinyMetricsComponent.Disabled property.
            /// </summary>
            /// <param name="value">If true, this component is disabled.</param>
            public SingleComponentResponseOfDestinyMetricsComponentBuilder Disabled(bool? value)
            {
                _Disabled = value;
                return this;
            }


            /// <summary>
            /// Builds instance of SingleComponentResponseOfDestinyMetricsComponent.
            /// </summary>
            /// <returns>SingleComponentResponseOfDestinyMetricsComponent</returns>
            public SingleComponentResponseOfDestinyMetricsComponent Build()
            {
                Validate();
                return new SingleComponentResponseOfDestinyMetricsComponent(
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