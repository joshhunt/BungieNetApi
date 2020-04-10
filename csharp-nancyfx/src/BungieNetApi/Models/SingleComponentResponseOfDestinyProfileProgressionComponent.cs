using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Sharpility.Extensions;
using NodaTime;

namespace BungieNetApi._Platform.Models
{
    /// <summary>
    /// SingleComponentResponseOfDestinyProfileProgressionComponent
    /// </summary>
    public sealed class SingleComponentResponseOfDestinyProfileProgressionComponent:  IEquatable<SingleComponentResponseOfDestinyProfileProgressionComponent>
    { 
        /// <summary>
        /// Data
        /// </summary>
        public DestinyComponentsProfilesDestinyProfileProgressionComponent Data { get; private set; }

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
        /// Use SingleComponentResponseOfDestinyProfileProgressionComponent.Builder() for instance creation instead.
        /// </summary>
        [Obsolete]
        public SingleComponentResponseOfDestinyProfileProgressionComponent()
        {
        }

        private SingleComponentResponseOfDestinyProfileProgressionComponent(DestinyComponentsProfilesDestinyProfileProgressionComponent Data, int? Privacy, bool? Disabled)
        {
            
            this.Data = Data;
            
            this.Privacy = Privacy;
            
            this.Disabled = Disabled;
            
        }

        /// <summary>
        /// Returns builder of SingleComponentResponseOfDestinyProfileProgressionComponent.
        /// </summary>
        /// <returns>SingleComponentResponseOfDestinyProfileProgressionComponentBuilder</returns>
        public static SingleComponentResponseOfDestinyProfileProgressionComponentBuilder Builder()
        {
            return new SingleComponentResponseOfDestinyProfileProgressionComponentBuilder();
        }

        /// <summary>
        /// Returns SingleComponentResponseOfDestinyProfileProgressionComponentBuilder with properties set.
        /// Use it to change properties.
        /// </summary>
        /// <returns>SingleComponentResponseOfDestinyProfileProgressionComponentBuilder</returns>
        public SingleComponentResponseOfDestinyProfileProgressionComponentBuilder With()
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

        public bool Equals(SingleComponentResponseOfDestinyProfileProgressionComponent other)
        {
            return Equals((object) other);
        }

        public override int GetHashCode()
        {
            return this.PropertiesHash();
        }

        /// <summary>
        /// Implementation of == operator for (SingleComponentResponseOfDestinyProfileProgressionComponent.
        /// </summary>
        /// <param name="left">Compared (SingleComponentResponseOfDestinyProfileProgressionComponent</param>
        /// <param name="right">Compared (SingleComponentResponseOfDestinyProfileProgressionComponent</param>
        /// <returns>true if compared items are equals, false otherwise</returns>
        public static bool operator == (SingleComponentResponseOfDestinyProfileProgressionComponent left, SingleComponentResponseOfDestinyProfileProgressionComponent right)
        {
            return Equals(left, right);
        }

        /// <summary>
        /// Implementation of != operator for (SingleComponentResponseOfDestinyProfileProgressionComponent.
        /// </summary>
        /// <param name="left">Compared (SingleComponentResponseOfDestinyProfileProgressionComponent</param>
        /// <param name="right">Compared (SingleComponentResponseOfDestinyProfileProgressionComponent</param>
        /// <returns>true if compared items are not equals, false otherwise</returns>
        public static bool operator != (SingleComponentResponseOfDestinyProfileProgressionComponent left, SingleComponentResponseOfDestinyProfileProgressionComponent right)
        {
            return !Equals(left, right);
        }

        /// <summary>
        /// Builder of SingleComponentResponseOfDestinyProfileProgressionComponent.
        /// </summary>
        public sealed class SingleComponentResponseOfDestinyProfileProgressionComponentBuilder
        {
            private DestinyComponentsProfilesDestinyProfileProgressionComponent _Data;
            private int? _Privacy;
            private bool? _Disabled;

            internal SingleComponentResponseOfDestinyProfileProgressionComponentBuilder()
            {
                SetupDefaults();
            }

            private void SetupDefaults()
            {
            }

            /// <summary>
            /// Sets value for SingleComponentResponseOfDestinyProfileProgressionComponent.Data property.
            /// </summary>
            /// <param name="value">Data</param>
            public SingleComponentResponseOfDestinyProfileProgressionComponentBuilder Data(DestinyComponentsProfilesDestinyProfileProgressionComponent value)
            {
                _Data = value;
                return this;
            }

            /// <summary>
            /// Sets value for SingleComponentResponseOfDestinyProfileProgressionComponent.Privacy property.
            /// </summary>
            /// <param name="value">Privacy</param>
            public SingleComponentResponseOfDestinyProfileProgressionComponentBuilder Privacy(int? value)
            {
                _Privacy = value;
                return this;
            }

            /// <summary>
            /// Sets value for SingleComponentResponseOfDestinyProfileProgressionComponent.Disabled property.
            /// </summary>
            /// <param name="value">If true, this component is disabled.</param>
            public SingleComponentResponseOfDestinyProfileProgressionComponentBuilder Disabled(bool? value)
            {
                _Disabled = value;
                return this;
            }


            /// <summary>
            /// Builds instance of SingleComponentResponseOfDestinyProfileProgressionComponent.
            /// </summary>
            /// <returns>SingleComponentResponseOfDestinyProfileProgressionComponent</returns>
            public SingleComponentResponseOfDestinyProfileProgressionComponent Build()
            {
                Validate();
                return new SingleComponentResponseOfDestinyProfileProgressionComponent(
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