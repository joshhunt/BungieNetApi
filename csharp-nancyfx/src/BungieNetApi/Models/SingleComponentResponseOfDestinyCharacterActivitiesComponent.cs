using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Sharpility.Extensions;
using NodaTime;

namespace BungieNetApi._Platform.Models
{
    /// <summary>
    /// SingleComponentResponseOfDestinyCharacterActivitiesComponent
    /// </summary>
    public sealed class SingleComponentResponseOfDestinyCharacterActivitiesComponent:  IEquatable<SingleComponentResponseOfDestinyCharacterActivitiesComponent>
    { 
        /// <summary>
        /// Data
        /// </summary>
        public DestinyEntitiesCharactersDestinyCharacterActivitiesComponent Data { get; private set; }

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
        /// Use SingleComponentResponseOfDestinyCharacterActivitiesComponent.Builder() for instance creation instead.
        /// </summary>
        [Obsolete]
        public SingleComponentResponseOfDestinyCharacterActivitiesComponent()
        {
        }

        private SingleComponentResponseOfDestinyCharacterActivitiesComponent(DestinyEntitiesCharactersDestinyCharacterActivitiesComponent Data, int? Privacy, bool? Disabled)
        {
            
            this.Data = Data;
            
            this.Privacy = Privacy;
            
            this.Disabled = Disabled;
            
        }

        /// <summary>
        /// Returns builder of SingleComponentResponseOfDestinyCharacterActivitiesComponent.
        /// </summary>
        /// <returns>SingleComponentResponseOfDestinyCharacterActivitiesComponentBuilder</returns>
        public static SingleComponentResponseOfDestinyCharacterActivitiesComponentBuilder Builder()
        {
            return new SingleComponentResponseOfDestinyCharacterActivitiesComponentBuilder();
        }

        /// <summary>
        /// Returns SingleComponentResponseOfDestinyCharacterActivitiesComponentBuilder with properties set.
        /// Use it to change properties.
        /// </summary>
        /// <returns>SingleComponentResponseOfDestinyCharacterActivitiesComponentBuilder</returns>
        public SingleComponentResponseOfDestinyCharacterActivitiesComponentBuilder With()
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

        public bool Equals(SingleComponentResponseOfDestinyCharacterActivitiesComponent other)
        {
            return Equals((object) other);
        }

        public override int GetHashCode()
        {
            return this.PropertiesHash();
        }

        /// <summary>
        /// Implementation of == operator for (SingleComponentResponseOfDestinyCharacterActivitiesComponent.
        /// </summary>
        /// <param name="left">Compared (SingleComponentResponseOfDestinyCharacterActivitiesComponent</param>
        /// <param name="right">Compared (SingleComponentResponseOfDestinyCharacterActivitiesComponent</param>
        /// <returns>true if compared items are equals, false otherwise</returns>
        public static bool operator == (SingleComponentResponseOfDestinyCharacterActivitiesComponent left, SingleComponentResponseOfDestinyCharacterActivitiesComponent right)
        {
            return Equals(left, right);
        }

        /// <summary>
        /// Implementation of != operator for (SingleComponentResponseOfDestinyCharacterActivitiesComponent.
        /// </summary>
        /// <param name="left">Compared (SingleComponentResponseOfDestinyCharacterActivitiesComponent</param>
        /// <param name="right">Compared (SingleComponentResponseOfDestinyCharacterActivitiesComponent</param>
        /// <returns>true if compared items are not equals, false otherwise</returns>
        public static bool operator != (SingleComponentResponseOfDestinyCharacterActivitiesComponent left, SingleComponentResponseOfDestinyCharacterActivitiesComponent right)
        {
            return !Equals(left, right);
        }

        /// <summary>
        /// Builder of SingleComponentResponseOfDestinyCharacterActivitiesComponent.
        /// </summary>
        public sealed class SingleComponentResponseOfDestinyCharacterActivitiesComponentBuilder
        {
            private DestinyEntitiesCharactersDestinyCharacterActivitiesComponent _Data;
            private int? _Privacy;
            private bool? _Disabled;

            internal SingleComponentResponseOfDestinyCharacterActivitiesComponentBuilder()
            {
                SetupDefaults();
            }

            private void SetupDefaults()
            {
            }

            /// <summary>
            /// Sets value for SingleComponentResponseOfDestinyCharacterActivitiesComponent.Data property.
            /// </summary>
            /// <param name="value">Data</param>
            public SingleComponentResponseOfDestinyCharacterActivitiesComponentBuilder Data(DestinyEntitiesCharactersDestinyCharacterActivitiesComponent value)
            {
                _Data = value;
                return this;
            }

            /// <summary>
            /// Sets value for SingleComponentResponseOfDestinyCharacterActivitiesComponent.Privacy property.
            /// </summary>
            /// <param name="value">Privacy</param>
            public SingleComponentResponseOfDestinyCharacterActivitiesComponentBuilder Privacy(int? value)
            {
                _Privacy = value;
                return this;
            }

            /// <summary>
            /// Sets value for SingleComponentResponseOfDestinyCharacterActivitiesComponent.Disabled property.
            /// </summary>
            /// <param name="value">If true, this component is disabled.</param>
            public SingleComponentResponseOfDestinyCharacterActivitiesComponentBuilder Disabled(bool? value)
            {
                _Disabled = value;
                return this;
            }


            /// <summary>
            /// Builds instance of SingleComponentResponseOfDestinyCharacterActivitiesComponent.
            /// </summary>
            /// <returns>SingleComponentResponseOfDestinyCharacterActivitiesComponent</returns>
            public SingleComponentResponseOfDestinyCharacterActivitiesComponent Build()
            {
                Validate();
                return new SingleComponentResponseOfDestinyCharacterActivitiesComponent(
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