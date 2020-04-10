using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Sharpility.Extensions;
using NodaTime;

namespace BungieNetApi._Platform.Models
{
    /// <summary>
    /// SingleComponentResponseOfDestinyCharacterRenderComponent
    /// </summary>
    public sealed class SingleComponentResponseOfDestinyCharacterRenderComponent:  IEquatable<SingleComponentResponseOfDestinyCharacterRenderComponent>
    { 
        /// <summary>
        /// Data
        /// </summary>
        public DestinyEntitiesCharactersDestinyCharacterRenderComponent Data { get; private set; }

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
        /// Use SingleComponentResponseOfDestinyCharacterRenderComponent.Builder() for instance creation instead.
        /// </summary>
        [Obsolete]
        public SingleComponentResponseOfDestinyCharacterRenderComponent()
        {
        }

        private SingleComponentResponseOfDestinyCharacterRenderComponent(DestinyEntitiesCharactersDestinyCharacterRenderComponent Data, int? Privacy, bool? Disabled)
        {
            
            this.Data = Data;
            
            this.Privacy = Privacy;
            
            this.Disabled = Disabled;
            
        }

        /// <summary>
        /// Returns builder of SingleComponentResponseOfDestinyCharacterRenderComponent.
        /// </summary>
        /// <returns>SingleComponentResponseOfDestinyCharacterRenderComponentBuilder</returns>
        public static SingleComponentResponseOfDestinyCharacterRenderComponentBuilder Builder()
        {
            return new SingleComponentResponseOfDestinyCharacterRenderComponentBuilder();
        }

        /// <summary>
        /// Returns SingleComponentResponseOfDestinyCharacterRenderComponentBuilder with properties set.
        /// Use it to change properties.
        /// </summary>
        /// <returns>SingleComponentResponseOfDestinyCharacterRenderComponentBuilder</returns>
        public SingleComponentResponseOfDestinyCharacterRenderComponentBuilder With()
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

        public bool Equals(SingleComponentResponseOfDestinyCharacterRenderComponent other)
        {
            return Equals((object) other);
        }

        public override int GetHashCode()
        {
            return this.PropertiesHash();
        }

        /// <summary>
        /// Implementation of == operator for (SingleComponentResponseOfDestinyCharacterRenderComponent.
        /// </summary>
        /// <param name="left">Compared (SingleComponentResponseOfDestinyCharacterRenderComponent</param>
        /// <param name="right">Compared (SingleComponentResponseOfDestinyCharacterRenderComponent</param>
        /// <returns>true if compared items are equals, false otherwise</returns>
        public static bool operator == (SingleComponentResponseOfDestinyCharacterRenderComponent left, SingleComponentResponseOfDestinyCharacterRenderComponent right)
        {
            return Equals(left, right);
        }

        /// <summary>
        /// Implementation of != operator for (SingleComponentResponseOfDestinyCharacterRenderComponent.
        /// </summary>
        /// <param name="left">Compared (SingleComponentResponseOfDestinyCharacterRenderComponent</param>
        /// <param name="right">Compared (SingleComponentResponseOfDestinyCharacterRenderComponent</param>
        /// <returns>true if compared items are not equals, false otherwise</returns>
        public static bool operator != (SingleComponentResponseOfDestinyCharacterRenderComponent left, SingleComponentResponseOfDestinyCharacterRenderComponent right)
        {
            return !Equals(left, right);
        }

        /// <summary>
        /// Builder of SingleComponentResponseOfDestinyCharacterRenderComponent.
        /// </summary>
        public sealed class SingleComponentResponseOfDestinyCharacterRenderComponentBuilder
        {
            private DestinyEntitiesCharactersDestinyCharacterRenderComponent _Data;
            private int? _Privacy;
            private bool? _Disabled;

            internal SingleComponentResponseOfDestinyCharacterRenderComponentBuilder()
            {
                SetupDefaults();
            }

            private void SetupDefaults()
            {
            }

            /// <summary>
            /// Sets value for SingleComponentResponseOfDestinyCharacterRenderComponent.Data property.
            /// </summary>
            /// <param name="value">Data</param>
            public SingleComponentResponseOfDestinyCharacterRenderComponentBuilder Data(DestinyEntitiesCharactersDestinyCharacterRenderComponent value)
            {
                _Data = value;
                return this;
            }

            /// <summary>
            /// Sets value for SingleComponentResponseOfDestinyCharacterRenderComponent.Privacy property.
            /// </summary>
            /// <param name="value">Privacy</param>
            public SingleComponentResponseOfDestinyCharacterRenderComponentBuilder Privacy(int? value)
            {
                _Privacy = value;
                return this;
            }

            /// <summary>
            /// Sets value for SingleComponentResponseOfDestinyCharacterRenderComponent.Disabled property.
            /// </summary>
            /// <param name="value">If true, this component is disabled.</param>
            public SingleComponentResponseOfDestinyCharacterRenderComponentBuilder Disabled(bool? value)
            {
                _Disabled = value;
                return this;
            }


            /// <summary>
            /// Builds instance of SingleComponentResponseOfDestinyCharacterRenderComponent.
            /// </summary>
            /// <returns>SingleComponentResponseOfDestinyCharacterRenderComponent</returns>
            public SingleComponentResponseOfDestinyCharacterRenderComponent Build()
            {
                Validate();
                return new SingleComponentResponseOfDestinyCharacterRenderComponent(
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