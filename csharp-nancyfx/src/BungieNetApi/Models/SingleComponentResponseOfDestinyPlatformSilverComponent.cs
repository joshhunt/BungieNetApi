using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Sharpility.Extensions;
using NodaTime;

namespace BungieNetApi._Platform.Models
{
    /// <summary>
    /// SingleComponentResponseOfDestinyPlatformSilverComponent
    /// </summary>
    public sealed class SingleComponentResponseOfDestinyPlatformSilverComponent:  IEquatable<SingleComponentResponseOfDestinyPlatformSilverComponent>
    { 
        /// <summary>
        /// Data
        /// </summary>
        public DestinyComponentsInventoryDestinyPlatformSilverComponent Data { get; private set; }

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
        /// Use SingleComponentResponseOfDestinyPlatformSilverComponent.Builder() for instance creation instead.
        /// </summary>
        [Obsolete]
        public SingleComponentResponseOfDestinyPlatformSilverComponent()
        {
        }

        private SingleComponentResponseOfDestinyPlatformSilverComponent(DestinyComponentsInventoryDestinyPlatformSilverComponent Data, int? Privacy, bool? Disabled)
        {
            
            this.Data = Data;
            
            this.Privacy = Privacy;
            
            this.Disabled = Disabled;
            
        }

        /// <summary>
        /// Returns builder of SingleComponentResponseOfDestinyPlatformSilverComponent.
        /// </summary>
        /// <returns>SingleComponentResponseOfDestinyPlatformSilverComponentBuilder</returns>
        public static SingleComponentResponseOfDestinyPlatformSilverComponentBuilder Builder()
        {
            return new SingleComponentResponseOfDestinyPlatformSilverComponentBuilder();
        }

        /// <summary>
        /// Returns SingleComponentResponseOfDestinyPlatformSilverComponentBuilder with properties set.
        /// Use it to change properties.
        /// </summary>
        /// <returns>SingleComponentResponseOfDestinyPlatformSilverComponentBuilder</returns>
        public SingleComponentResponseOfDestinyPlatformSilverComponentBuilder With()
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

        public bool Equals(SingleComponentResponseOfDestinyPlatformSilverComponent other)
        {
            return Equals((object) other);
        }

        public override int GetHashCode()
        {
            return this.PropertiesHash();
        }

        /// <summary>
        /// Implementation of == operator for (SingleComponentResponseOfDestinyPlatformSilverComponent.
        /// </summary>
        /// <param name="left">Compared (SingleComponentResponseOfDestinyPlatformSilverComponent</param>
        /// <param name="right">Compared (SingleComponentResponseOfDestinyPlatformSilverComponent</param>
        /// <returns>true if compared items are equals, false otherwise</returns>
        public static bool operator == (SingleComponentResponseOfDestinyPlatformSilverComponent left, SingleComponentResponseOfDestinyPlatformSilverComponent right)
        {
            return Equals(left, right);
        }

        /// <summary>
        /// Implementation of != operator for (SingleComponentResponseOfDestinyPlatformSilverComponent.
        /// </summary>
        /// <param name="left">Compared (SingleComponentResponseOfDestinyPlatformSilverComponent</param>
        /// <param name="right">Compared (SingleComponentResponseOfDestinyPlatformSilverComponent</param>
        /// <returns>true if compared items are not equals, false otherwise</returns>
        public static bool operator != (SingleComponentResponseOfDestinyPlatformSilverComponent left, SingleComponentResponseOfDestinyPlatformSilverComponent right)
        {
            return !Equals(left, right);
        }

        /// <summary>
        /// Builder of SingleComponentResponseOfDestinyPlatformSilverComponent.
        /// </summary>
        public sealed class SingleComponentResponseOfDestinyPlatformSilverComponentBuilder
        {
            private DestinyComponentsInventoryDestinyPlatformSilverComponent _Data;
            private int? _Privacy;
            private bool? _Disabled;

            internal SingleComponentResponseOfDestinyPlatformSilverComponentBuilder()
            {
                SetupDefaults();
            }

            private void SetupDefaults()
            {
            }

            /// <summary>
            /// Sets value for SingleComponentResponseOfDestinyPlatformSilverComponent.Data property.
            /// </summary>
            /// <param name="value">Data</param>
            public SingleComponentResponseOfDestinyPlatformSilverComponentBuilder Data(DestinyComponentsInventoryDestinyPlatformSilverComponent value)
            {
                _Data = value;
                return this;
            }

            /// <summary>
            /// Sets value for SingleComponentResponseOfDestinyPlatformSilverComponent.Privacy property.
            /// </summary>
            /// <param name="value">Privacy</param>
            public SingleComponentResponseOfDestinyPlatformSilverComponentBuilder Privacy(int? value)
            {
                _Privacy = value;
                return this;
            }

            /// <summary>
            /// Sets value for SingleComponentResponseOfDestinyPlatformSilverComponent.Disabled property.
            /// </summary>
            /// <param name="value">If true, this component is disabled.</param>
            public SingleComponentResponseOfDestinyPlatformSilverComponentBuilder Disabled(bool? value)
            {
                _Disabled = value;
                return this;
            }


            /// <summary>
            /// Builds instance of SingleComponentResponseOfDestinyPlatformSilverComponent.
            /// </summary>
            /// <returns>SingleComponentResponseOfDestinyPlatformSilverComponent</returns>
            public SingleComponentResponseOfDestinyPlatformSilverComponent Build()
            {
                Validate();
                return new SingleComponentResponseOfDestinyPlatformSilverComponent(
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