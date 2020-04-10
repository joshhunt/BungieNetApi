using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Sharpility.Extensions;
using NodaTime;

namespace BungieNetApi._Platform.Models
{
    /// <summary>
    /// SingleComponentResponseOfDestinyCharacterComponent
    /// </summary>
    public sealed class SingleComponentResponseOfDestinyCharacterComponent:  IEquatable<SingleComponentResponseOfDestinyCharacterComponent>
    { 
        /// <summary>
        /// Data
        /// </summary>
        public DestinyEntitiesCharactersDestinyCharacterComponent Data { get; private set; }

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
        /// Use SingleComponentResponseOfDestinyCharacterComponent.Builder() for instance creation instead.
        /// </summary>
        [Obsolete]
        public SingleComponentResponseOfDestinyCharacterComponent()
        {
        }

        private SingleComponentResponseOfDestinyCharacterComponent(DestinyEntitiesCharactersDestinyCharacterComponent Data, int? Privacy, bool? Disabled)
        {
            
            this.Data = Data;
            
            this.Privacy = Privacy;
            
            this.Disabled = Disabled;
            
        }

        /// <summary>
        /// Returns builder of SingleComponentResponseOfDestinyCharacterComponent.
        /// </summary>
        /// <returns>SingleComponentResponseOfDestinyCharacterComponentBuilder</returns>
        public static SingleComponentResponseOfDestinyCharacterComponentBuilder Builder()
        {
            return new SingleComponentResponseOfDestinyCharacterComponentBuilder();
        }

        /// <summary>
        /// Returns SingleComponentResponseOfDestinyCharacterComponentBuilder with properties set.
        /// Use it to change properties.
        /// </summary>
        /// <returns>SingleComponentResponseOfDestinyCharacterComponentBuilder</returns>
        public SingleComponentResponseOfDestinyCharacterComponentBuilder With()
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

        public bool Equals(SingleComponentResponseOfDestinyCharacterComponent other)
        {
            return Equals((object) other);
        }

        public override int GetHashCode()
        {
            return this.PropertiesHash();
        }

        /// <summary>
        /// Implementation of == operator for (SingleComponentResponseOfDestinyCharacterComponent.
        /// </summary>
        /// <param name="left">Compared (SingleComponentResponseOfDestinyCharacterComponent</param>
        /// <param name="right">Compared (SingleComponentResponseOfDestinyCharacterComponent</param>
        /// <returns>true if compared items are equals, false otherwise</returns>
        public static bool operator == (SingleComponentResponseOfDestinyCharacterComponent left, SingleComponentResponseOfDestinyCharacterComponent right)
        {
            return Equals(left, right);
        }

        /// <summary>
        /// Implementation of != operator for (SingleComponentResponseOfDestinyCharacterComponent.
        /// </summary>
        /// <param name="left">Compared (SingleComponentResponseOfDestinyCharacterComponent</param>
        /// <param name="right">Compared (SingleComponentResponseOfDestinyCharacterComponent</param>
        /// <returns>true if compared items are not equals, false otherwise</returns>
        public static bool operator != (SingleComponentResponseOfDestinyCharacterComponent left, SingleComponentResponseOfDestinyCharacterComponent right)
        {
            return !Equals(left, right);
        }

        /// <summary>
        /// Builder of SingleComponentResponseOfDestinyCharacterComponent.
        /// </summary>
        public sealed class SingleComponentResponseOfDestinyCharacterComponentBuilder
        {
            private DestinyEntitiesCharactersDestinyCharacterComponent _Data;
            private int? _Privacy;
            private bool? _Disabled;

            internal SingleComponentResponseOfDestinyCharacterComponentBuilder()
            {
                SetupDefaults();
            }

            private void SetupDefaults()
            {
            }

            /// <summary>
            /// Sets value for SingleComponentResponseOfDestinyCharacterComponent.Data property.
            /// </summary>
            /// <param name="value">Data</param>
            public SingleComponentResponseOfDestinyCharacterComponentBuilder Data(DestinyEntitiesCharactersDestinyCharacterComponent value)
            {
                _Data = value;
                return this;
            }

            /// <summary>
            /// Sets value for SingleComponentResponseOfDestinyCharacterComponent.Privacy property.
            /// </summary>
            /// <param name="value">Privacy</param>
            public SingleComponentResponseOfDestinyCharacterComponentBuilder Privacy(int? value)
            {
                _Privacy = value;
                return this;
            }

            /// <summary>
            /// Sets value for SingleComponentResponseOfDestinyCharacterComponent.Disabled property.
            /// </summary>
            /// <param name="value">If true, this component is disabled.</param>
            public SingleComponentResponseOfDestinyCharacterComponentBuilder Disabled(bool? value)
            {
                _Disabled = value;
                return this;
            }


            /// <summary>
            /// Builds instance of SingleComponentResponseOfDestinyCharacterComponent.
            /// </summary>
            /// <returns>SingleComponentResponseOfDestinyCharacterComponent</returns>
            public SingleComponentResponseOfDestinyCharacterComponent Build()
            {
                Validate();
                return new SingleComponentResponseOfDestinyCharacterComponent(
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