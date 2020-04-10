using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Sharpility.Extensions;
using NodaTime;

namespace BungieNetApi._Platform.Models
{
    /// <summary>
    /// SingleComponentResponseOfDestinyProfileTransitoryComponent
    /// </summary>
    public sealed class SingleComponentResponseOfDestinyProfileTransitoryComponent:  IEquatable<SingleComponentResponseOfDestinyProfileTransitoryComponent>
    { 
        /// <summary>
        /// Data
        /// </summary>
        public DestinyComponentsProfilesDestinyProfileTransitoryComponent Data { get; private set; }

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
        /// Use SingleComponentResponseOfDestinyProfileTransitoryComponent.Builder() for instance creation instead.
        /// </summary>
        [Obsolete]
        public SingleComponentResponseOfDestinyProfileTransitoryComponent()
        {
        }

        private SingleComponentResponseOfDestinyProfileTransitoryComponent(DestinyComponentsProfilesDestinyProfileTransitoryComponent Data, int? Privacy, bool? Disabled)
        {
            
            this.Data = Data;
            
            this.Privacy = Privacy;
            
            this.Disabled = Disabled;
            
        }

        /// <summary>
        /// Returns builder of SingleComponentResponseOfDestinyProfileTransitoryComponent.
        /// </summary>
        /// <returns>SingleComponentResponseOfDestinyProfileTransitoryComponentBuilder</returns>
        public static SingleComponentResponseOfDestinyProfileTransitoryComponentBuilder Builder()
        {
            return new SingleComponentResponseOfDestinyProfileTransitoryComponentBuilder();
        }

        /// <summary>
        /// Returns SingleComponentResponseOfDestinyProfileTransitoryComponentBuilder with properties set.
        /// Use it to change properties.
        /// </summary>
        /// <returns>SingleComponentResponseOfDestinyProfileTransitoryComponentBuilder</returns>
        public SingleComponentResponseOfDestinyProfileTransitoryComponentBuilder With()
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

        public bool Equals(SingleComponentResponseOfDestinyProfileTransitoryComponent other)
        {
            return Equals((object) other);
        }

        public override int GetHashCode()
        {
            return this.PropertiesHash();
        }

        /// <summary>
        /// Implementation of == operator for (SingleComponentResponseOfDestinyProfileTransitoryComponent.
        /// </summary>
        /// <param name="left">Compared (SingleComponentResponseOfDestinyProfileTransitoryComponent</param>
        /// <param name="right">Compared (SingleComponentResponseOfDestinyProfileTransitoryComponent</param>
        /// <returns>true if compared items are equals, false otherwise</returns>
        public static bool operator == (SingleComponentResponseOfDestinyProfileTransitoryComponent left, SingleComponentResponseOfDestinyProfileTransitoryComponent right)
        {
            return Equals(left, right);
        }

        /// <summary>
        /// Implementation of != operator for (SingleComponentResponseOfDestinyProfileTransitoryComponent.
        /// </summary>
        /// <param name="left">Compared (SingleComponentResponseOfDestinyProfileTransitoryComponent</param>
        /// <param name="right">Compared (SingleComponentResponseOfDestinyProfileTransitoryComponent</param>
        /// <returns>true if compared items are not equals, false otherwise</returns>
        public static bool operator != (SingleComponentResponseOfDestinyProfileTransitoryComponent left, SingleComponentResponseOfDestinyProfileTransitoryComponent right)
        {
            return !Equals(left, right);
        }

        /// <summary>
        /// Builder of SingleComponentResponseOfDestinyProfileTransitoryComponent.
        /// </summary>
        public sealed class SingleComponentResponseOfDestinyProfileTransitoryComponentBuilder
        {
            private DestinyComponentsProfilesDestinyProfileTransitoryComponent _Data;
            private int? _Privacy;
            private bool? _Disabled;

            internal SingleComponentResponseOfDestinyProfileTransitoryComponentBuilder()
            {
                SetupDefaults();
            }

            private void SetupDefaults()
            {
            }

            /// <summary>
            /// Sets value for SingleComponentResponseOfDestinyProfileTransitoryComponent.Data property.
            /// </summary>
            /// <param name="value">Data</param>
            public SingleComponentResponseOfDestinyProfileTransitoryComponentBuilder Data(DestinyComponentsProfilesDestinyProfileTransitoryComponent value)
            {
                _Data = value;
                return this;
            }

            /// <summary>
            /// Sets value for SingleComponentResponseOfDestinyProfileTransitoryComponent.Privacy property.
            /// </summary>
            /// <param name="value">Privacy</param>
            public SingleComponentResponseOfDestinyProfileTransitoryComponentBuilder Privacy(int? value)
            {
                _Privacy = value;
                return this;
            }

            /// <summary>
            /// Sets value for SingleComponentResponseOfDestinyProfileTransitoryComponent.Disabled property.
            /// </summary>
            /// <param name="value">If true, this component is disabled.</param>
            public SingleComponentResponseOfDestinyProfileTransitoryComponentBuilder Disabled(bool? value)
            {
                _Disabled = value;
                return this;
            }


            /// <summary>
            /// Builds instance of SingleComponentResponseOfDestinyProfileTransitoryComponent.
            /// </summary>
            /// <returns>SingleComponentResponseOfDestinyProfileTransitoryComponent</returns>
            public SingleComponentResponseOfDestinyProfileTransitoryComponent Build()
            {
                Validate();
                return new SingleComponentResponseOfDestinyProfileTransitoryComponent(
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