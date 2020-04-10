using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Sharpility.Extensions;
using NodaTime;

namespace BungieNetApi._Platform.Models
{
    /// <summary>
    /// SingleComponentResponseOfDestinyProfileComponent
    /// </summary>
    public sealed class SingleComponentResponseOfDestinyProfileComponent:  IEquatable<SingleComponentResponseOfDestinyProfileComponent>
    { 
        /// <summary>
        /// Data
        /// </summary>
        public DestinyEntitiesProfilesDestinyProfileComponent Data { get; private set; }

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
        /// Use SingleComponentResponseOfDestinyProfileComponent.Builder() for instance creation instead.
        /// </summary>
        [Obsolete]
        public SingleComponentResponseOfDestinyProfileComponent()
        {
        }

        private SingleComponentResponseOfDestinyProfileComponent(DestinyEntitiesProfilesDestinyProfileComponent Data, int? Privacy, bool? Disabled)
        {
            
            this.Data = Data;
            
            this.Privacy = Privacy;
            
            this.Disabled = Disabled;
            
        }

        /// <summary>
        /// Returns builder of SingleComponentResponseOfDestinyProfileComponent.
        /// </summary>
        /// <returns>SingleComponentResponseOfDestinyProfileComponentBuilder</returns>
        public static SingleComponentResponseOfDestinyProfileComponentBuilder Builder()
        {
            return new SingleComponentResponseOfDestinyProfileComponentBuilder();
        }

        /// <summary>
        /// Returns SingleComponentResponseOfDestinyProfileComponentBuilder with properties set.
        /// Use it to change properties.
        /// </summary>
        /// <returns>SingleComponentResponseOfDestinyProfileComponentBuilder</returns>
        public SingleComponentResponseOfDestinyProfileComponentBuilder With()
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

        public bool Equals(SingleComponentResponseOfDestinyProfileComponent other)
        {
            return Equals((object) other);
        }

        public override int GetHashCode()
        {
            return this.PropertiesHash();
        }

        /// <summary>
        /// Implementation of == operator for (SingleComponentResponseOfDestinyProfileComponent.
        /// </summary>
        /// <param name="left">Compared (SingleComponentResponseOfDestinyProfileComponent</param>
        /// <param name="right">Compared (SingleComponentResponseOfDestinyProfileComponent</param>
        /// <returns>true if compared items are equals, false otherwise</returns>
        public static bool operator == (SingleComponentResponseOfDestinyProfileComponent left, SingleComponentResponseOfDestinyProfileComponent right)
        {
            return Equals(left, right);
        }

        /// <summary>
        /// Implementation of != operator for (SingleComponentResponseOfDestinyProfileComponent.
        /// </summary>
        /// <param name="left">Compared (SingleComponentResponseOfDestinyProfileComponent</param>
        /// <param name="right">Compared (SingleComponentResponseOfDestinyProfileComponent</param>
        /// <returns>true if compared items are not equals, false otherwise</returns>
        public static bool operator != (SingleComponentResponseOfDestinyProfileComponent left, SingleComponentResponseOfDestinyProfileComponent right)
        {
            return !Equals(left, right);
        }

        /// <summary>
        /// Builder of SingleComponentResponseOfDestinyProfileComponent.
        /// </summary>
        public sealed class SingleComponentResponseOfDestinyProfileComponentBuilder
        {
            private DestinyEntitiesProfilesDestinyProfileComponent _Data;
            private int? _Privacy;
            private bool? _Disabled;

            internal SingleComponentResponseOfDestinyProfileComponentBuilder()
            {
                SetupDefaults();
            }

            private void SetupDefaults()
            {
            }

            /// <summary>
            /// Sets value for SingleComponentResponseOfDestinyProfileComponent.Data property.
            /// </summary>
            /// <param name="value">Data</param>
            public SingleComponentResponseOfDestinyProfileComponentBuilder Data(DestinyEntitiesProfilesDestinyProfileComponent value)
            {
                _Data = value;
                return this;
            }

            /// <summary>
            /// Sets value for SingleComponentResponseOfDestinyProfileComponent.Privacy property.
            /// </summary>
            /// <param name="value">Privacy</param>
            public SingleComponentResponseOfDestinyProfileComponentBuilder Privacy(int? value)
            {
                _Privacy = value;
                return this;
            }

            /// <summary>
            /// Sets value for SingleComponentResponseOfDestinyProfileComponent.Disabled property.
            /// </summary>
            /// <param name="value">If true, this component is disabled.</param>
            public SingleComponentResponseOfDestinyProfileComponentBuilder Disabled(bool? value)
            {
                _Disabled = value;
                return this;
            }


            /// <summary>
            /// Builds instance of SingleComponentResponseOfDestinyProfileComponent.
            /// </summary>
            /// <returns>SingleComponentResponseOfDestinyProfileComponent</returns>
            public SingleComponentResponseOfDestinyProfileComponent Build()
            {
                Validate();
                return new SingleComponentResponseOfDestinyProfileComponent(
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