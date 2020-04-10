using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Sharpility.Extensions;
using NodaTime;

namespace BungieNetApi._Platform.Models
{
    /// <summary>
    /// DestinyComponentsMetricsDestinyMetricsComponent
    /// </summary>
    public sealed class DestinyComponentsMetricsDestinyMetricsComponent:  IEquatable<DestinyComponentsMetricsDestinyMetricsComponent>
    { 
        /// <summary>
        /// Metrics
        /// </summary>
        public Dictionary<string, DestinyComponentsMetricsDestinyMetricComponent> Metrics { get; private set; }

        /// <summary>
        /// MetricsRootNodeHash
        /// </summary>
        public int? MetricsRootNodeHash { get; private set; }


        /// <summary>
        /// Empty constructor required by some serializers.
        /// Use DestinyComponentsMetricsDestinyMetricsComponent.Builder() for instance creation instead.
        /// </summary>
        [Obsolete]
        public DestinyComponentsMetricsDestinyMetricsComponent()
        {
        }

        private DestinyComponentsMetricsDestinyMetricsComponent(Dictionary<string, DestinyComponentsMetricsDestinyMetricComponent> Metrics, int? MetricsRootNodeHash)
        {
            
            this.Metrics = Metrics;
            
            this.MetricsRootNodeHash = MetricsRootNodeHash;
            
        }

        /// <summary>
        /// Returns builder of DestinyComponentsMetricsDestinyMetricsComponent.
        /// </summary>
        /// <returns>DestinyComponentsMetricsDestinyMetricsComponentBuilder</returns>
        public static DestinyComponentsMetricsDestinyMetricsComponentBuilder Builder()
        {
            return new DestinyComponentsMetricsDestinyMetricsComponentBuilder();
        }

        /// <summary>
        /// Returns DestinyComponentsMetricsDestinyMetricsComponentBuilder with properties set.
        /// Use it to change properties.
        /// </summary>
        /// <returns>DestinyComponentsMetricsDestinyMetricsComponentBuilder</returns>
        public DestinyComponentsMetricsDestinyMetricsComponentBuilder With()
        {
            return Builder()
                .Metrics(Metrics)
                .MetricsRootNodeHash(MetricsRootNodeHash);
        }

        public override string ToString()
        {
            return this.PropertiesToString();
        }

        public override bool Equals(object obj)
        {
            return this.EqualsByProperties(obj);
        }

        public bool Equals(DestinyComponentsMetricsDestinyMetricsComponent other)
        {
            return Equals((object) other);
        }

        public override int GetHashCode()
        {
            return this.PropertiesHash();
        }

        /// <summary>
        /// Implementation of == operator for (DestinyComponentsMetricsDestinyMetricsComponent.
        /// </summary>
        /// <param name="left">Compared (DestinyComponentsMetricsDestinyMetricsComponent</param>
        /// <param name="right">Compared (DestinyComponentsMetricsDestinyMetricsComponent</param>
        /// <returns>true if compared items are equals, false otherwise</returns>
        public static bool operator == (DestinyComponentsMetricsDestinyMetricsComponent left, DestinyComponentsMetricsDestinyMetricsComponent right)
        {
            return Equals(left, right);
        }

        /// <summary>
        /// Implementation of != operator for (DestinyComponentsMetricsDestinyMetricsComponent.
        /// </summary>
        /// <param name="left">Compared (DestinyComponentsMetricsDestinyMetricsComponent</param>
        /// <param name="right">Compared (DestinyComponentsMetricsDestinyMetricsComponent</param>
        /// <returns>true if compared items are not equals, false otherwise</returns>
        public static bool operator != (DestinyComponentsMetricsDestinyMetricsComponent left, DestinyComponentsMetricsDestinyMetricsComponent right)
        {
            return !Equals(left, right);
        }

        /// <summary>
        /// Builder of DestinyComponentsMetricsDestinyMetricsComponent.
        /// </summary>
        public sealed class DestinyComponentsMetricsDestinyMetricsComponentBuilder
        {
            private Dictionary<string, DestinyComponentsMetricsDestinyMetricComponent> _Metrics;
            private int? _MetricsRootNodeHash;

            internal DestinyComponentsMetricsDestinyMetricsComponentBuilder()
            {
                SetupDefaults();
            }

            private void SetupDefaults()
            {
            }

            /// <summary>
            /// Sets value for DestinyComponentsMetricsDestinyMetricsComponent.Metrics property.
            /// </summary>
            /// <param name="value">Metrics</param>
            public DestinyComponentsMetricsDestinyMetricsComponentBuilder Metrics(Dictionary<string, DestinyComponentsMetricsDestinyMetricComponent> value)
            {
                _Metrics = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyComponentsMetricsDestinyMetricsComponent.MetricsRootNodeHash property.
            /// </summary>
            /// <param name="value">MetricsRootNodeHash</param>
            public DestinyComponentsMetricsDestinyMetricsComponentBuilder MetricsRootNodeHash(int? value)
            {
                _MetricsRootNodeHash = value;
                return this;
            }


            /// <summary>
            /// Builds instance of DestinyComponentsMetricsDestinyMetricsComponent.
            /// </summary>
            /// <returns>DestinyComponentsMetricsDestinyMetricsComponent</returns>
            public DestinyComponentsMetricsDestinyMetricsComponent Build()
            {
                Validate();
                return new DestinyComponentsMetricsDestinyMetricsComponent(
                    Metrics: _Metrics,
                    MetricsRootNodeHash: _MetricsRootNodeHash
                );
            }

            private void Validate()
            { 
            }
        }

        
    }
}