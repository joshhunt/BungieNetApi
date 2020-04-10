using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Sharpility.Extensions;
using NodaTime;

namespace BungieNetApi._Platform.Models
{
    /// <summary>
    /// SingleComponentResponseOfDestinyItemObjectivesComponent
    /// </summary>
    public sealed class SingleComponentResponseOfDestinyItemObjectivesComponent:  IEquatable<SingleComponentResponseOfDestinyItemObjectivesComponent>
    { 
        /// <summary>
        /// Data
        /// </summary>
        public DestinyEntitiesItemsDestinyItemObjectivesComponent Data { get; private set; }

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
        /// Use SingleComponentResponseOfDestinyItemObjectivesComponent.Builder() for instance creation instead.
        /// </summary>
        [Obsolete]
        public SingleComponentResponseOfDestinyItemObjectivesComponent()
        {
        }

        private SingleComponentResponseOfDestinyItemObjectivesComponent(DestinyEntitiesItemsDestinyItemObjectivesComponent Data, int? Privacy, bool? Disabled)
        {
            
            this.Data = Data;
            
            this.Privacy = Privacy;
            
            this.Disabled = Disabled;
            
        }

        /// <summary>
        /// Returns builder of SingleComponentResponseOfDestinyItemObjectivesComponent.
        /// </summary>
        /// <returns>SingleComponentResponseOfDestinyItemObjectivesComponentBuilder</returns>
        public static SingleComponentResponseOfDestinyItemObjectivesComponentBuilder Builder()
        {
            return new SingleComponentResponseOfDestinyItemObjectivesComponentBuilder();
        }

        /// <summary>
        /// Returns SingleComponentResponseOfDestinyItemObjectivesComponentBuilder with properties set.
        /// Use it to change properties.
        /// </summary>
        /// <returns>SingleComponentResponseOfDestinyItemObjectivesComponentBuilder</returns>
        public SingleComponentResponseOfDestinyItemObjectivesComponentBuilder With()
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

        public bool Equals(SingleComponentResponseOfDestinyItemObjectivesComponent other)
        {
            return Equals((object) other);
        }

        public override int GetHashCode()
        {
            return this.PropertiesHash();
        }

        /// <summary>
        /// Implementation of == operator for (SingleComponentResponseOfDestinyItemObjectivesComponent.
        /// </summary>
        /// <param name="left">Compared (SingleComponentResponseOfDestinyItemObjectivesComponent</param>
        /// <param name="right">Compared (SingleComponentResponseOfDestinyItemObjectivesComponent</param>
        /// <returns>true if compared items are equals, false otherwise</returns>
        public static bool operator == (SingleComponentResponseOfDestinyItemObjectivesComponent left, SingleComponentResponseOfDestinyItemObjectivesComponent right)
        {
            return Equals(left, right);
        }

        /// <summary>
        /// Implementation of != operator for (SingleComponentResponseOfDestinyItemObjectivesComponent.
        /// </summary>
        /// <param name="left">Compared (SingleComponentResponseOfDestinyItemObjectivesComponent</param>
        /// <param name="right">Compared (SingleComponentResponseOfDestinyItemObjectivesComponent</param>
        /// <returns>true if compared items are not equals, false otherwise</returns>
        public static bool operator != (SingleComponentResponseOfDestinyItemObjectivesComponent left, SingleComponentResponseOfDestinyItemObjectivesComponent right)
        {
            return !Equals(left, right);
        }

        /// <summary>
        /// Builder of SingleComponentResponseOfDestinyItemObjectivesComponent.
        /// </summary>
        public sealed class SingleComponentResponseOfDestinyItemObjectivesComponentBuilder
        {
            private DestinyEntitiesItemsDestinyItemObjectivesComponent _Data;
            private int? _Privacy;
            private bool? _Disabled;

            internal SingleComponentResponseOfDestinyItemObjectivesComponentBuilder()
            {
                SetupDefaults();
            }

            private void SetupDefaults()
            {
            }

            /// <summary>
            /// Sets value for SingleComponentResponseOfDestinyItemObjectivesComponent.Data property.
            /// </summary>
            /// <param name="value">Data</param>
            public SingleComponentResponseOfDestinyItemObjectivesComponentBuilder Data(DestinyEntitiesItemsDestinyItemObjectivesComponent value)
            {
                _Data = value;
                return this;
            }

            /// <summary>
            /// Sets value for SingleComponentResponseOfDestinyItemObjectivesComponent.Privacy property.
            /// </summary>
            /// <param name="value">Privacy</param>
            public SingleComponentResponseOfDestinyItemObjectivesComponentBuilder Privacy(int? value)
            {
                _Privacy = value;
                return this;
            }

            /// <summary>
            /// Sets value for SingleComponentResponseOfDestinyItemObjectivesComponent.Disabled property.
            /// </summary>
            /// <param name="value">If true, this component is disabled.</param>
            public SingleComponentResponseOfDestinyItemObjectivesComponentBuilder Disabled(bool? value)
            {
                _Disabled = value;
                return this;
            }


            /// <summary>
            /// Builds instance of SingleComponentResponseOfDestinyItemObjectivesComponent.
            /// </summary>
            /// <returns>SingleComponentResponseOfDestinyItemObjectivesComponent</returns>
            public SingleComponentResponseOfDestinyItemObjectivesComponent Build()
            {
                Validate();
                return new SingleComponentResponseOfDestinyItemObjectivesComponent(
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