using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Sharpility.Extensions;
using NodaTime;

namespace BungieNetApi._Platform.Models
{
    /// <summary>
    /// SingleComponentResponseOfDestinyCharacterProgressionComponent
    /// </summary>
    public sealed class SingleComponentResponseOfDestinyCharacterProgressionComponent:  IEquatable<SingleComponentResponseOfDestinyCharacterProgressionComponent>
    { 
        /// <summary>
        /// Data
        /// </summary>
        public DestinyEntitiesCharactersDestinyCharacterProgressionComponent Data { get; private set; }

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
        /// Use SingleComponentResponseOfDestinyCharacterProgressionComponent.Builder() for instance creation instead.
        /// </summary>
        [Obsolete]
        public SingleComponentResponseOfDestinyCharacterProgressionComponent()
        {
        }

        private SingleComponentResponseOfDestinyCharacterProgressionComponent(DestinyEntitiesCharactersDestinyCharacterProgressionComponent Data, int? Privacy, bool? Disabled)
        {
            
            this.Data = Data;
            
            this.Privacy = Privacy;
            
            this.Disabled = Disabled;
            
        }

        /// <summary>
        /// Returns builder of SingleComponentResponseOfDestinyCharacterProgressionComponent.
        /// </summary>
        /// <returns>SingleComponentResponseOfDestinyCharacterProgressionComponentBuilder</returns>
        public static SingleComponentResponseOfDestinyCharacterProgressionComponentBuilder Builder()
        {
            return new SingleComponentResponseOfDestinyCharacterProgressionComponentBuilder();
        }

        /// <summary>
        /// Returns SingleComponentResponseOfDestinyCharacterProgressionComponentBuilder with properties set.
        /// Use it to change properties.
        /// </summary>
        /// <returns>SingleComponentResponseOfDestinyCharacterProgressionComponentBuilder</returns>
        public SingleComponentResponseOfDestinyCharacterProgressionComponentBuilder With()
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

        public bool Equals(SingleComponentResponseOfDestinyCharacterProgressionComponent other)
        {
            return Equals((object) other);
        }

        public override int GetHashCode()
        {
            return this.PropertiesHash();
        }

        /// <summary>
        /// Implementation of == operator for (SingleComponentResponseOfDestinyCharacterProgressionComponent.
        /// </summary>
        /// <param name="left">Compared (SingleComponentResponseOfDestinyCharacterProgressionComponent</param>
        /// <param name="right">Compared (SingleComponentResponseOfDestinyCharacterProgressionComponent</param>
        /// <returns>true if compared items are equals, false otherwise</returns>
        public static bool operator == (SingleComponentResponseOfDestinyCharacterProgressionComponent left, SingleComponentResponseOfDestinyCharacterProgressionComponent right)
        {
            return Equals(left, right);
        }

        /// <summary>
        /// Implementation of != operator for (SingleComponentResponseOfDestinyCharacterProgressionComponent.
        /// </summary>
        /// <param name="left">Compared (SingleComponentResponseOfDestinyCharacterProgressionComponent</param>
        /// <param name="right">Compared (SingleComponentResponseOfDestinyCharacterProgressionComponent</param>
        /// <returns>true if compared items are not equals, false otherwise</returns>
        public static bool operator != (SingleComponentResponseOfDestinyCharacterProgressionComponent left, SingleComponentResponseOfDestinyCharacterProgressionComponent right)
        {
            return !Equals(left, right);
        }

        /// <summary>
        /// Builder of SingleComponentResponseOfDestinyCharacterProgressionComponent.
        /// </summary>
        public sealed class SingleComponentResponseOfDestinyCharacterProgressionComponentBuilder
        {
            private DestinyEntitiesCharactersDestinyCharacterProgressionComponent _Data;
            private int? _Privacy;
            private bool? _Disabled;

            internal SingleComponentResponseOfDestinyCharacterProgressionComponentBuilder()
            {
                SetupDefaults();
            }

            private void SetupDefaults()
            {
            }

            /// <summary>
            /// Sets value for SingleComponentResponseOfDestinyCharacterProgressionComponent.Data property.
            /// </summary>
            /// <param name="value">Data</param>
            public SingleComponentResponseOfDestinyCharacterProgressionComponentBuilder Data(DestinyEntitiesCharactersDestinyCharacterProgressionComponent value)
            {
                _Data = value;
                return this;
            }

            /// <summary>
            /// Sets value for SingleComponentResponseOfDestinyCharacterProgressionComponent.Privacy property.
            /// </summary>
            /// <param name="value">Privacy</param>
            public SingleComponentResponseOfDestinyCharacterProgressionComponentBuilder Privacy(int? value)
            {
                _Privacy = value;
                return this;
            }

            /// <summary>
            /// Sets value for SingleComponentResponseOfDestinyCharacterProgressionComponent.Disabled property.
            /// </summary>
            /// <param name="value">If true, this component is disabled.</param>
            public SingleComponentResponseOfDestinyCharacterProgressionComponentBuilder Disabled(bool? value)
            {
                _Disabled = value;
                return this;
            }


            /// <summary>
            /// Builds instance of SingleComponentResponseOfDestinyCharacterProgressionComponent.
            /// </summary>
            /// <returns>SingleComponentResponseOfDestinyCharacterProgressionComponent</returns>
            public SingleComponentResponseOfDestinyCharacterProgressionComponent Build()
            {
                Validate();
                return new SingleComponentResponseOfDestinyCharacterProgressionComponent(
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