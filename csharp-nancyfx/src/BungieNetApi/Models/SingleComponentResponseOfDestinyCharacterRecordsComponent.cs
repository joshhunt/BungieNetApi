using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Sharpility.Extensions;
using NodaTime;

namespace BungieNetApi._Platform.Models
{
    /// <summary>
    /// SingleComponentResponseOfDestinyCharacterRecordsComponent
    /// </summary>
    public sealed class SingleComponentResponseOfDestinyCharacterRecordsComponent:  IEquatable<SingleComponentResponseOfDestinyCharacterRecordsComponent>
    { 
        /// <summary>
        /// Data
        /// </summary>
        public DestinyComponentsRecordsDestinyCharacterRecordsComponent Data { get; private set; }

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
        /// Use SingleComponentResponseOfDestinyCharacterRecordsComponent.Builder() for instance creation instead.
        /// </summary>
        [Obsolete]
        public SingleComponentResponseOfDestinyCharacterRecordsComponent()
        {
        }

        private SingleComponentResponseOfDestinyCharacterRecordsComponent(DestinyComponentsRecordsDestinyCharacterRecordsComponent Data, int? Privacy, bool? Disabled)
        {
            
            this.Data = Data;
            
            this.Privacy = Privacy;
            
            this.Disabled = Disabled;
            
        }

        /// <summary>
        /// Returns builder of SingleComponentResponseOfDestinyCharacterRecordsComponent.
        /// </summary>
        /// <returns>SingleComponentResponseOfDestinyCharacterRecordsComponentBuilder</returns>
        public static SingleComponentResponseOfDestinyCharacterRecordsComponentBuilder Builder()
        {
            return new SingleComponentResponseOfDestinyCharacterRecordsComponentBuilder();
        }

        /// <summary>
        /// Returns SingleComponentResponseOfDestinyCharacterRecordsComponentBuilder with properties set.
        /// Use it to change properties.
        /// </summary>
        /// <returns>SingleComponentResponseOfDestinyCharacterRecordsComponentBuilder</returns>
        public SingleComponentResponseOfDestinyCharacterRecordsComponentBuilder With()
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

        public bool Equals(SingleComponentResponseOfDestinyCharacterRecordsComponent other)
        {
            return Equals((object) other);
        }

        public override int GetHashCode()
        {
            return this.PropertiesHash();
        }

        /// <summary>
        /// Implementation of == operator for (SingleComponentResponseOfDestinyCharacterRecordsComponent.
        /// </summary>
        /// <param name="left">Compared (SingleComponentResponseOfDestinyCharacterRecordsComponent</param>
        /// <param name="right">Compared (SingleComponentResponseOfDestinyCharacterRecordsComponent</param>
        /// <returns>true if compared items are equals, false otherwise</returns>
        public static bool operator == (SingleComponentResponseOfDestinyCharacterRecordsComponent left, SingleComponentResponseOfDestinyCharacterRecordsComponent right)
        {
            return Equals(left, right);
        }

        /// <summary>
        /// Implementation of != operator for (SingleComponentResponseOfDestinyCharacterRecordsComponent.
        /// </summary>
        /// <param name="left">Compared (SingleComponentResponseOfDestinyCharacterRecordsComponent</param>
        /// <param name="right">Compared (SingleComponentResponseOfDestinyCharacterRecordsComponent</param>
        /// <returns>true if compared items are not equals, false otherwise</returns>
        public static bool operator != (SingleComponentResponseOfDestinyCharacterRecordsComponent left, SingleComponentResponseOfDestinyCharacterRecordsComponent right)
        {
            return !Equals(left, right);
        }

        /// <summary>
        /// Builder of SingleComponentResponseOfDestinyCharacterRecordsComponent.
        /// </summary>
        public sealed class SingleComponentResponseOfDestinyCharacterRecordsComponentBuilder
        {
            private DestinyComponentsRecordsDestinyCharacterRecordsComponent _Data;
            private int? _Privacy;
            private bool? _Disabled;

            internal SingleComponentResponseOfDestinyCharacterRecordsComponentBuilder()
            {
                SetupDefaults();
            }

            private void SetupDefaults()
            {
            }

            /// <summary>
            /// Sets value for SingleComponentResponseOfDestinyCharacterRecordsComponent.Data property.
            /// </summary>
            /// <param name="value">Data</param>
            public SingleComponentResponseOfDestinyCharacterRecordsComponentBuilder Data(DestinyComponentsRecordsDestinyCharacterRecordsComponent value)
            {
                _Data = value;
                return this;
            }

            /// <summary>
            /// Sets value for SingleComponentResponseOfDestinyCharacterRecordsComponent.Privacy property.
            /// </summary>
            /// <param name="value">Privacy</param>
            public SingleComponentResponseOfDestinyCharacterRecordsComponentBuilder Privacy(int? value)
            {
                _Privacy = value;
                return this;
            }

            /// <summary>
            /// Sets value for SingleComponentResponseOfDestinyCharacterRecordsComponent.Disabled property.
            /// </summary>
            /// <param name="value">If true, this component is disabled.</param>
            public SingleComponentResponseOfDestinyCharacterRecordsComponentBuilder Disabled(bool? value)
            {
                _Disabled = value;
                return this;
            }


            /// <summary>
            /// Builds instance of SingleComponentResponseOfDestinyCharacterRecordsComponent.
            /// </summary>
            /// <returns>SingleComponentResponseOfDestinyCharacterRecordsComponent</returns>
            public SingleComponentResponseOfDestinyCharacterRecordsComponent Build()
            {
                Validate();
                return new SingleComponentResponseOfDestinyCharacterRecordsComponent(
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