using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Sharpility.Extensions;
using NodaTime;

namespace BungieNetApi._Platform.Models
{
    /// <summary>
    /// SingleComponentResponseOfDestinyProfileCollectiblesComponent
    /// </summary>
    public sealed class SingleComponentResponseOfDestinyProfileCollectiblesComponent:  IEquatable<SingleComponentResponseOfDestinyProfileCollectiblesComponent>
    { 
        /// <summary>
        /// Data
        /// </summary>
        public DestinyComponentsCollectiblesDestinyProfileCollectiblesComponent Data { get; private set; }

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
        /// Use SingleComponentResponseOfDestinyProfileCollectiblesComponent.Builder() for instance creation instead.
        /// </summary>
        [Obsolete]
        public SingleComponentResponseOfDestinyProfileCollectiblesComponent()
        {
        }

        private SingleComponentResponseOfDestinyProfileCollectiblesComponent(DestinyComponentsCollectiblesDestinyProfileCollectiblesComponent Data, int? Privacy, bool? Disabled)
        {
            
            this.Data = Data;
            
            this.Privacy = Privacy;
            
            this.Disabled = Disabled;
            
        }

        /// <summary>
        /// Returns builder of SingleComponentResponseOfDestinyProfileCollectiblesComponent.
        /// </summary>
        /// <returns>SingleComponentResponseOfDestinyProfileCollectiblesComponentBuilder</returns>
        public static SingleComponentResponseOfDestinyProfileCollectiblesComponentBuilder Builder()
        {
            return new SingleComponentResponseOfDestinyProfileCollectiblesComponentBuilder();
        }

        /// <summary>
        /// Returns SingleComponentResponseOfDestinyProfileCollectiblesComponentBuilder with properties set.
        /// Use it to change properties.
        /// </summary>
        /// <returns>SingleComponentResponseOfDestinyProfileCollectiblesComponentBuilder</returns>
        public SingleComponentResponseOfDestinyProfileCollectiblesComponentBuilder With()
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

        public bool Equals(SingleComponentResponseOfDestinyProfileCollectiblesComponent other)
        {
            return Equals((object) other);
        }

        public override int GetHashCode()
        {
            return this.PropertiesHash();
        }

        /// <summary>
        /// Implementation of == operator for (SingleComponentResponseOfDestinyProfileCollectiblesComponent.
        /// </summary>
        /// <param name="left">Compared (SingleComponentResponseOfDestinyProfileCollectiblesComponent</param>
        /// <param name="right">Compared (SingleComponentResponseOfDestinyProfileCollectiblesComponent</param>
        /// <returns>true if compared items are equals, false otherwise</returns>
        public static bool operator == (SingleComponentResponseOfDestinyProfileCollectiblesComponent left, SingleComponentResponseOfDestinyProfileCollectiblesComponent right)
        {
            return Equals(left, right);
        }

        /// <summary>
        /// Implementation of != operator for (SingleComponentResponseOfDestinyProfileCollectiblesComponent.
        /// </summary>
        /// <param name="left">Compared (SingleComponentResponseOfDestinyProfileCollectiblesComponent</param>
        /// <param name="right">Compared (SingleComponentResponseOfDestinyProfileCollectiblesComponent</param>
        /// <returns>true if compared items are not equals, false otherwise</returns>
        public static bool operator != (SingleComponentResponseOfDestinyProfileCollectiblesComponent left, SingleComponentResponseOfDestinyProfileCollectiblesComponent right)
        {
            return !Equals(left, right);
        }

        /// <summary>
        /// Builder of SingleComponentResponseOfDestinyProfileCollectiblesComponent.
        /// </summary>
        public sealed class SingleComponentResponseOfDestinyProfileCollectiblesComponentBuilder
        {
            private DestinyComponentsCollectiblesDestinyProfileCollectiblesComponent _Data;
            private int? _Privacy;
            private bool? _Disabled;

            internal SingleComponentResponseOfDestinyProfileCollectiblesComponentBuilder()
            {
                SetupDefaults();
            }

            private void SetupDefaults()
            {
            }

            /// <summary>
            /// Sets value for SingleComponentResponseOfDestinyProfileCollectiblesComponent.Data property.
            /// </summary>
            /// <param name="value">Data</param>
            public SingleComponentResponseOfDestinyProfileCollectiblesComponentBuilder Data(DestinyComponentsCollectiblesDestinyProfileCollectiblesComponent value)
            {
                _Data = value;
                return this;
            }

            /// <summary>
            /// Sets value for SingleComponentResponseOfDestinyProfileCollectiblesComponent.Privacy property.
            /// </summary>
            /// <param name="value">Privacy</param>
            public SingleComponentResponseOfDestinyProfileCollectiblesComponentBuilder Privacy(int? value)
            {
                _Privacy = value;
                return this;
            }

            /// <summary>
            /// Sets value for SingleComponentResponseOfDestinyProfileCollectiblesComponent.Disabled property.
            /// </summary>
            /// <param name="value">If true, this component is disabled.</param>
            public SingleComponentResponseOfDestinyProfileCollectiblesComponentBuilder Disabled(bool? value)
            {
                _Disabled = value;
                return this;
            }


            /// <summary>
            /// Builds instance of SingleComponentResponseOfDestinyProfileCollectiblesComponent.
            /// </summary>
            /// <returns>SingleComponentResponseOfDestinyProfileCollectiblesComponent</returns>
            public SingleComponentResponseOfDestinyProfileCollectiblesComponent Build()
            {
                Validate();
                return new SingleComponentResponseOfDestinyProfileCollectiblesComponent(
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