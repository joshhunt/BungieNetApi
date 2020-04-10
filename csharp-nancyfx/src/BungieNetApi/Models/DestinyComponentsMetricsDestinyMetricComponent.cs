using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Sharpility.Extensions;
using NodaTime;

namespace BungieNetApi._Platform.Models
{
    /// <summary>
    /// DestinyComponentsMetricsDestinyMetricComponent
    /// </summary>
    public sealed class DestinyComponentsMetricsDestinyMetricComponent:  IEquatable<DestinyComponentsMetricsDestinyMetricComponent>
    { 
        /// <summary>
        /// Invisible
        /// </summary>
        public bool? Invisible { get; private set; }

        /// <summary>
        /// ObjectiveProgress
        /// </summary>
        public DestinyQuestsDestinyObjectiveProgress ObjectiveProgress { get; private set; }


        /// <summary>
        /// Empty constructor required by some serializers.
        /// Use DestinyComponentsMetricsDestinyMetricComponent.Builder() for instance creation instead.
        /// </summary>
        [Obsolete]
        public DestinyComponentsMetricsDestinyMetricComponent()
        {
        }

        private DestinyComponentsMetricsDestinyMetricComponent(bool? Invisible, DestinyQuestsDestinyObjectiveProgress ObjectiveProgress)
        {
            
            this.Invisible = Invisible;
            
            this.ObjectiveProgress = ObjectiveProgress;
            
        }

        /// <summary>
        /// Returns builder of DestinyComponentsMetricsDestinyMetricComponent.
        /// </summary>
        /// <returns>DestinyComponentsMetricsDestinyMetricComponentBuilder</returns>
        public static DestinyComponentsMetricsDestinyMetricComponentBuilder Builder()
        {
            return new DestinyComponentsMetricsDestinyMetricComponentBuilder();
        }

        /// <summary>
        /// Returns DestinyComponentsMetricsDestinyMetricComponentBuilder with properties set.
        /// Use it to change properties.
        /// </summary>
        /// <returns>DestinyComponentsMetricsDestinyMetricComponentBuilder</returns>
        public DestinyComponentsMetricsDestinyMetricComponentBuilder With()
        {
            return Builder()
                .Invisible(Invisible)
                .ObjectiveProgress(ObjectiveProgress);
        }

        public override string ToString()
        {
            return this.PropertiesToString();
        }

        public override bool Equals(object obj)
        {
            return this.EqualsByProperties(obj);
        }

        public bool Equals(DestinyComponentsMetricsDestinyMetricComponent other)
        {
            return Equals((object) other);
        }

        public override int GetHashCode()
        {
            return this.PropertiesHash();
        }

        /// <summary>
        /// Implementation of == operator for (DestinyComponentsMetricsDestinyMetricComponent.
        /// </summary>
        /// <param name="left">Compared (DestinyComponentsMetricsDestinyMetricComponent</param>
        /// <param name="right">Compared (DestinyComponentsMetricsDestinyMetricComponent</param>
        /// <returns>true if compared items are equals, false otherwise</returns>
        public static bool operator == (DestinyComponentsMetricsDestinyMetricComponent left, DestinyComponentsMetricsDestinyMetricComponent right)
        {
            return Equals(left, right);
        }

        /// <summary>
        /// Implementation of != operator for (DestinyComponentsMetricsDestinyMetricComponent.
        /// </summary>
        /// <param name="left">Compared (DestinyComponentsMetricsDestinyMetricComponent</param>
        /// <param name="right">Compared (DestinyComponentsMetricsDestinyMetricComponent</param>
        /// <returns>true if compared items are not equals, false otherwise</returns>
        public static bool operator != (DestinyComponentsMetricsDestinyMetricComponent left, DestinyComponentsMetricsDestinyMetricComponent right)
        {
            return !Equals(left, right);
        }

        /// <summary>
        /// Builder of DestinyComponentsMetricsDestinyMetricComponent.
        /// </summary>
        public sealed class DestinyComponentsMetricsDestinyMetricComponentBuilder
        {
            private bool? _Invisible;
            private DestinyQuestsDestinyObjectiveProgress _ObjectiveProgress;

            internal DestinyComponentsMetricsDestinyMetricComponentBuilder()
            {
                SetupDefaults();
            }

            private void SetupDefaults()
            {
            }

            /// <summary>
            /// Sets value for DestinyComponentsMetricsDestinyMetricComponent.Invisible property.
            /// </summary>
            /// <param name="value">Invisible</param>
            public DestinyComponentsMetricsDestinyMetricComponentBuilder Invisible(bool? value)
            {
                _Invisible = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyComponentsMetricsDestinyMetricComponent.ObjectiveProgress property.
            /// </summary>
            /// <param name="value">ObjectiveProgress</param>
            public DestinyComponentsMetricsDestinyMetricComponentBuilder ObjectiveProgress(DestinyQuestsDestinyObjectiveProgress value)
            {
                _ObjectiveProgress = value;
                return this;
            }


            /// <summary>
            /// Builds instance of DestinyComponentsMetricsDestinyMetricComponent.
            /// </summary>
            /// <returns>DestinyComponentsMetricsDestinyMetricComponent</returns>
            public DestinyComponentsMetricsDestinyMetricComponent Build()
            {
                Validate();
                return new DestinyComponentsMetricsDestinyMetricComponent(
                    Invisible: _Invisible,
                    ObjectiveProgress: _ObjectiveProgress
                );
            }

            private void Validate()
            { 
            }
        }

        
    }
}