using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Sharpility.Extensions;
using NodaTime;

namespace BungieNetApi._Platform.Models
{
    /// <summary>
    /// SingleComponentResponseOfDestinyKiosksComponent
    /// </summary>
    public sealed class SingleComponentResponseOfDestinyKiosksComponent:  IEquatable<SingleComponentResponseOfDestinyKiosksComponent>
    { 
        /// <summary>
        /// Data
        /// </summary>
        public DestinyComponentsKiosksDestinyKiosksComponent Data { get; private set; }

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
        /// Use SingleComponentResponseOfDestinyKiosksComponent.Builder() for instance creation instead.
        /// </summary>
        [Obsolete]
        public SingleComponentResponseOfDestinyKiosksComponent()
        {
        }

        private SingleComponentResponseOfDestinyKiosksComponent(DestinyComponentsKiosksDestinyKiosksComponent Data, int? Privacy, bool? Disabled)
        {
            
            this.Data = Data;
            
            this.Privacy = Privacy;
            
            this.Disabled = Disabled;
            
        }

        /// <summary>
        /// Returns builder of SingleComponentResponseOfDestinyKiosksComponent.
        /// </summary>
        /// <returns>SingleComponentResponseOfDestinyKiosksComponentBuilder</returns>
        public static SingleComponentResponseOfDestinyKiosksComponentBuilder Builder()
        {
            return new SingleComponentResponseOfDestinyKiosksComponentBuilder();
        }

        /// <summary>
        /// Returns SingleComponentResponseOfDestinyKiosksComponentBuilder with properties set.
        /// Use it to change properties.
        /// </summary>
        /// <returns>SingleComponentResponseOfDestinyKiosksComponentBuilder</returns>
        public SingleComponentResponseOfDestinyKiosksComponentBuilder With()
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

        public bool Equals(SingleComponentResponseOfDestinyKiosksComponent other)
        {
            return Equals((object) other);
        }

        public override int GetHashCode()
        {
            return this.PropertiesHash();
        }

        /// <summary>
        /// Implementation of == operator for (SingleComponentResponseOfDestinyKiosksComponent.
        /// </summary>
        /// <param name="left">Compared (SingleComponentResponseOfDestinyKiosksComponent</param>
        /// <param name="right">Compared (SingleComponentResponseOfDestinyKiosksComponent</param>
        /// <returns>true if compared items are equals, false otherwise</returns>
        public static bool operator == (SingleComponentResponseOfDestinyKiosksComponent left, SingleComponentResponseOfDestinyKiosksComponent right)
        {
            return Equals(left, right);
        }

        /// <summary>
        /// Implementation of != operator for (SingleComponentResponseOfDestinyKiosksComponent.
        /// </summary>
        /// <param name="left">Compared (SingleComponentResponseOfDestinyKiosksComponent</param>
        /// <param name="right">Compared (SingleComponentResponseOfDestinyKiosksComponent</param>
        /// <returns>true if compared items are not equals, false otherwise</returns>
        public static bool operator != (SingleComponentResponseOfDestinyKiosksComponent left, SingleComponentResponseOfDestinyKiosksComponent right)
        {
            return !Equals(left, right);
        }

        /// <summary>
        /// Builder of SingleComponentResponseOfDestinyKiosksComponent.
        /// </summary>
        public sealed class SingleComponentResponseOfDestinyKiosksComponentBuilder
        {
            private DestinyComponentsKiosksDestinyKiosksComponent _Data;
            private int? _Privacy;
            private bool? _Disabled;

            internal SingleComponentResponseOfDestinyKiosksComponentBuilder()
            {
                SetupDefaults();
            }

            private void SetupDefaults()
            {
            }

            /// <summary>
            /// Sets value for SingleComponentResponseOfDestinyKiosksComponent.Data property.
            /// </summary>
            /// <param name="value">Data</param>
            public SingleComponentResponseOfDestinyKiosksComponentBuilder Data(DestinyComponentsKiosksDestinyKiosksComponent value)
            {
                _Data = value;
                return this;
            }

            /// <summary>
            /// Sets value for SingleComponentResponseOfDestinyKiosksComponent.Privacy property.
            /// </summary>
            /// <param name="value">Privacy</param>
            public SingleComponentResponseOfDestinyKiosksComponentBuilder Privacy(int? value)
            {
                _Privacy = value;
                return this;
            }

            /// <summary>
            /// Sets value for SingleComponentResponseOfDestinyKiosksComponent.Disabled property.
            /// </summary>
            /// <param name="value">If true, this component is disabled.</param>
            public SingleComponentResponseOfDestinyKiosksComponentBuilder Disabled(bool? value)
            {
                _Disabled = value;
                return this;
            }


            /// <summary>
            /// Builds instance of SingleComponentResponseOfDestinyKiosksComponent.
            /// </summary>
            /// <returns>SingleComponentResponseOfDestinyKiosksComponent</returns>
            public SingleComponentResponseOfDestinyKiosksComponent Build()
            {
                Validate();
                return new SingleComponentResponseOfDestinyKiosksComponent(
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