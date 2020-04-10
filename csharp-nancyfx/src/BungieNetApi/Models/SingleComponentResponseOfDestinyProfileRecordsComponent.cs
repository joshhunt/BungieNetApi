using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Sharpility.Extensions;
using NodaTime;

namespace BungieNetApi._Platform.Models
{
    /// <summary>
    /// SingleComponentResponseOfDestinyProfileRecordsComponent
    /// </summary>
    public sealed class SingleComponentResponseOfDestinyProfileRecordsComponent:  IEquatable<SingleComponentResponseOfDestinyProfileRecordsComponent>
    { 
        /// <summary>
        /// Data
        /// </summary>
        public DestinyComponentsRecordsDestinyProfileRecordsComponent Data { get; private set; }

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
        /// Use SingleComponentResponseOfDestinyProfileRecordsComponent.Builder() for instance creation instead.
        /// </summary>
        [Obsolete]
        public SingleComponentResponseOfDestinyProfileRecordsComponent()
        {
        }

        private SingleComponentResponseOfDestinyProfileRecordsComponent(DestinyComponentsRecordsDestinyProfileRecordsComponent Data, int? Privacy, bool? Disabled)
        {
            
            this.Data = Data;
            
            this.Privacy = Privacy;
            
            this.Disabled = Disabled;
            
        }

        /// <summary>
        /// Returns builder of SingleComponentResponseOfDestinyProfileRecordsComponent.
        /// </summary>
        /// <returns>SingleComponentResponseOfDestinyProfileRecordsComponentBuilder</returns>
        public static SingleComponentResponseOfDestinyProfileRecordsComponentBuilder Builder()
        {
            return new SingleComponentResponseOfDestinyProfileRecordsComponentBuilder();
        }

        /// <summary>
        /// Returns SingleComponentResponseOfDestinyProfileRecordsComponentBuilder with properties set.
        /// Use it to change properties.
        /// </summary>
        /// <returns>SingleComponentResponseOfDestinyProfileRecordsComponentBuilder</returns>
        public SingleComponentResponseOfDestinyProfileRecordsComponentBuilder With()
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

        public bool Equals(SingleComponentResponseOfDestinyProfileRecordsComponent other)
        {
            return Equals((object) other);
        }

        public override int GetHashCode()
        {
            return this.PropertiesHash();
        }

        /// <summary>
        /// Implementation of == operator for (SingleComponentResponseOfDestinyProfileRecordsComponent.
        /// </summary>
        /// <param name="left">Compared (SingleComponentResponseOfDestinyProfileRecordsComponent</param>
        /// <param name="right">Compared (SingleComponentResponseOfDestinyProfileRecordsComponent</param>
        /// <returns>true if compared items are equals, false otherwise</returns>
        public static bool operator == (SingleComponentResponseOfDestinyProfileRecordsComponent left, SingleComponentResponseOfDestinyProfileRecordsComponent right)
        {
            return Equals(left, right);
        }

        /// <summary>
        /// Implementation of != operator for (SingleComponentResponseOfDestinyProfileRecordsComponent.
        /// </summary>
        /// <param name="left">Compared (SingleComponentResponseOfDestinyProfileRecordsComponent</param>
        /// <param name="right">Compared (SingleComponentResponseOfDestinyProfileRecordsComponent</param>
        /// <returns>true if compared items are not equals, false otherwise</returns>
        public static bool operator != (SingleComponentResponseOfDestinyProfileRecordsComponent left, SingleComponentResponseOfDestinyProfileRecordsComponent right)
        {
            return !Equals(left, right);
        }

        /// <summary>
        /// Builder of SingleComponentResponseOfDestinyProfileRecordsComponent.
        /// </summary>
        public sealed class SingleComponentResponseOfDestinyProfileRecordsComponentBuilder
        {
            private DestinyComponentsRecordsDestinyProfileRecordsComponent _Data;
            private int? _Privacy;
            private bool? _Disabled;

            internal SingleComponentResponseOfDestinyProfileRecordsComponentBuilder()
            {
                SetupDefaults();
            }

            private void SetupDefaults()
            {
            }

            /// <summary>
            /// Sets value for SingleComponentResponseOfDestinyProfileRecordsComponent.Data property.
            /// </summary>
            /// <param name="value">Data</param>
            public SingleComponentResponseOfDestinyProfileRecordsComponentBuilder Data(DestinyComponentsRecordsDestinyProfileRecordsComponent value)
            {
                _Data = value;
                return this;
            }

            /// <summary>
            /// Sets value for SingleComponentResponseOfDestinyProfileRecordsComponent.Privacy property.
            /// </summary>
            /// <param name="value">Privacy</param>
            public SingleComponentResponseOfDestinyProfileRecordsComponentBuilder Privacy(int? value)
            {
                _Privacy = value;
                return this;
            }

            /// <summary>
            /// Sets value for SingleComponentResponseOfDestinyProfileRecordsComponent.Disabled property.
            /// </summary>
            /// <param name="value">If true, this component is disabled.</param>
            public SingleComponentResponseOfDestinyProfileRecordsComponentBuilder Disabled(bool? value)
            {
                _Disabled = value;
                return this;
            }


            /// <summary>
            /// Builds instance of SingleComponentResponseOfDestinyProfileRecordsComponent.
            /// </summary>
            /// <returns>SingleComponentResponseOfDestinyProfileRecordsComponent</returns>
            public SingleComponentResponseOfDestinyProfileRecordsComponent Build()
            {
                Validate();
                return new SingleComponentResponseOfDestinyProfileRecordsComponent(
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