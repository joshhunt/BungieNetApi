using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Sharpility.Extensions;
using NodaTime;

namespace BungieNetApi._Platform.Models
{
    /// <summary>
    /// SingleComponentResponseOfDestinyCollectiblesComponent
    /// </summary>
    public sealed class SingleComponentResponseOfDestinyCollectiblesComponent:  IEquatable<SingleComponentResponseOfDestinyCollectiblesComponent>
    { 
        /// <summary>
        /// Data
        /// </summary>
        public DestinyComponentsCollectiblesDestinyCollectiblesComponent Data { get; private set; }

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
        /// Use SingleComponentResponseOfDestinyCollectiblesComponent.Builder() for instance creation instead.
        /// </summary>
        [Obsolete]
        public SingleComponentResponseOfDestinyCollectiblesComponent()
        {
        }

        private SingleComponentResponseOfDestinyCollectiblesComponent(DestinyComponentsCollectiblesDestinyCollectiblesComponent Data, int? Privacy, bool? Disabled)
        {
            
            this.Data = Data;
            
            this.Privacy = Privacy;
            
            this.Disabled = Disabled;
            
        }

        /// <summary>
        /// Returns builder of SingleComponentResponseOfDestinyCollectiblesComponent.
        /// </summary>
        /// <returns>SingleComponentResponseOfDestinyCollectiblesComponentBuilder</returns>
        public static SingleComponentResponseOfDestinyCollectiblesComponentBuilder Builder()
        {
            return new SingleComponentResponseOfDestinyCollectiblesComponentBuilder();
        }

        /// <summary>
        /// Returns SingleComponentResponseOfDestinyCollectiblesComponentBuilder with properties set.
        /// Use it to change properties.
        /// </summary>
        /// <returns>SingleComponentResponseOfDestinyCollectiblesComponentBuilder</returns>
        public SingleComponentResponseOfDestinyCollectiblesComponentBuilder With()
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

        public bool Equals(SingleComponentResponseOfDestinyCollectiblesComponent other)
        {
            return Equals((object) other);
        }

        public override int GetHashCode()
        {
            return this.PropertiesHash();
        }

        /// <summary>
        /// Implementation of == operator for (SingleComponentResponseOfDestinyCollectiblesComponent.
        /// </summary>
        /// <param name="left">Compared (SingleComponentResponseOfDestinyCollectiblesComponent</param>
        /// <param name="right">Compared (SingleComponentResponseOfDestinyCollectiblesComponent</param>
        /// <returns>true if compared items are equals, false otherwise</returns>
        public static bool operator == (SingleComponentResponseOfDestinyCollectiblesComponent left, SingleComponentResponseOfDestinyCollectiblesComponent right)
        {
            return Equals(left, right);
        }

        /// <summary>
        /// Implementation of != operator for (SingleComponentResponseOfDestinyCollectiblesComponent.
        /// </summary>
        /// <param name="left">Compared (SingleComponentResponseOfDestinyCollectiblesComponent</param>
        /// <param name="right">Compared (SingleComponentResponseOfDestinyCollectiblesComponent</param>
        /// <returns>true if compared items are not equals, false otherwise</returns>
        public static bool operator != (SingleComponentResponseOfDestinyCollectiblesComponent left, SingleComponentResponseOfDestinyCollectiblesComponent right)
        {
            return !Equals(left, right);
        }

        /// <summary>
        /// Builder of SingleComponentResponseOfDestinyCollectiblesComponent.
        /// </summary>
        public sealed class SingleComponentResponseOfDestinyCollectiblesComponentBuilder
        {
            private DestinyComponentsCollectiblesDestinyCollectiblesComponent _Data;
            private int? _Privacy;
            private bool? _Disabled;

            internal SingleComponentResponseOfDestinyCollectiblesComponentBuilder()
            {
                SetupDefaults();
            }

            private void SetupDefaults()
            {
            }

            /// <summary>
            /// Sets value for SingleComponentResponseOfDestinyCollectiblesComponent.Data property.
            /// </summary>
            /// <param name="value">Data</param>
            public SingleComponentResponseOfDestinyCollectiblesComponentBuilder Data(DestinyComponentsCollectiblesDestinyCollectiblesComponent value)
            {
                _Data = value;
                return this;
            }

            /// <summary>
            /// Sets value for SingleComponentResponseOfDestinyCollectiblesComponent.Privacy property.
            /// </summary>
            /// <param name="value">Privacy</param>
            public SingleComponentResponseOfDestinyCollectiblesComponentBuilder Privacy(int? value)
            {
                _Privacy = value;
                return this;
            }

            /// <summary>
            /// Sets value for SingleComponentResponseOfDestinyCollectiblesComponent.Disabled property.
            /// </summary>
            /// <param name="value">If true, this component is disabled.</param>
            public SingleComponentResponseOfDestinyCollectiblesComponentBuilder Disabled(bool? value)
            {
                _Disabled = value;
                return this;
            }


            /// <summary>
            /// Builds instance of SingleComponentResponseOfDestinyCollectiblesComponent.
            /// </summary>
            /// <returns>SingleComponentResponseOfDestinyCollectiblesComponent</returns>
            public SingleComponentResponseOfDestinyCollectiblesComponent Build()
            {
                Validate();
                return new SingleComponentResponseOfDestinyCollectiblesComponent(
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