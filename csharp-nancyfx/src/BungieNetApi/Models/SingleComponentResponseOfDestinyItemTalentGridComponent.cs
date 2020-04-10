using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Sharpility.Extensions;
using NodaTime;

namespace BungieNetApi._Platform.Models
{
    /// <summary>
    /// SingleComponentResponseOfDestinyItemTalentGridComponent
    /// </summary>
    public sealed class SingleComponentResponseOfDestinyItemTalentGridComponent:  IEquatable<SingleComponentResponseOfDestinyItemTalentGridComponent>
    { 
        /// <summary>
        /// Data
        /// </summary>
        public DestinyEntitiesItemsDestinyItemTalentGridComponent Data { get; private set; }

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
        /// Use SingleComponentResponseOfDestinyItemTalentGridComponent.Builder() for instance creation instead.
        /// </summary>
        [Obsolete]
        public SingleComponentResponseOfDestinyItemTalentGridComponent()
        {
        }

        private SingleComponentResponseOfDestinyItemTalentGridComponent(DestinyEntitiesItemsDestinyItemTalentGridComponent Data, int? Privacy, bool? Disabled)
        {
            
            this.Data = Data;
            
            this.Privacy = Privacy;
            
            this.Disabled = Disabled;
            
        }

        /// <summary>
        /// Returns builder of SingleComponentResponseOfDestinyItemTalentGridComponent.
        /// </summary>
        /// <returns>SingleComponentResponseOfDestinyItemTalentGridComponentBuilder</returns>
        public static SingleComponentResponseOfDestinyItemTalentGridComponentBuilder Builder()
        {
            return new SingleComponentResponseOfDestinyItemTalentGridComponentBuilder();
        }

        /// <summary>
        /// Returns SingleComponentResponseOfDestinyItemTalentGridComponentBuilder with properties set.
        /// Use it to change properties.
        /// </summary>
        /// <returns>SingleComponentResponseOfDestinyItemTalentGridComponentBuilder</returns>
        public SingleComponentResponseOfDestinyItemTalentGridComponentBuilder With()
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

        public bool Equals(SingleComponentResponseOfDestinyItemTalentGridComponent other)
        {
            return Equals((object) other);
        }

        public override int GetHashCode()
        {
            return this.PropertiesHash();
        }

        /// <summary>
        /// Implementation of == operator for (SingleComponentResponseOfDestinyItemTalentGridComponent.
        /// </summary>
        /// <param name="left">Compared (SingleComponentResponseOfDestinyItemTalentGridComponent</param>
        /// <param name="right">Compared (SingleComponentResponseOfDestinyItemTalentGridComponent</param>
        /// <returns>true if compared items are equals, false otherwise</returns>
        public static bool operator == (SingleComponentResponseOfDestinyItemTalentGridComponent left, SingleComponentResponseOfDestinyItemTalentGridComponent right)
        {
            return Equals(left, right);
        }

        /// <summary>
        /// Implementation of != operator for (SingleComponentResponseOfDestinyItemTalentGridComponent.
        /// </summary>
        /// <param name="left">Compared (SingleComponentResponseOfDestinyItemTalentGridComponent</param>
        /// <param name="right">Compared (SingleComponentResponseOfDestinyItemTalentGridComponent</param>
        /// <returns>true if compared items are not equals, false otherwise</returns>
        public static bool operator != (SingleComponentResponseOfDestinyItemTalentGridComponent left, SingleComponentResponseOfDestinyItemTalentGridComponent right)
        {
            return !Equals(left, right);
        }

        /// <summary>
        /// Builder of SingleComponentResponseOfDestinyItemTalentGridComponent.
        /// </summary>
        public sealed class SingleComponentResponseOfDestinyItemTalentGridComponentBuilder
        {
            private DestinyEntitiesItemsDestinyItemTalentGridComponent _Data;
            private int? _Privacy;
            private bool? _Disabled;

            internal SingleComponentResponseOfDestinyItemTalentGridComponentBuilder()
            {
                SetupDefaults();
            }

            private void SetupDefaults()
            {
            }

            /// <summary>
            /// Sets value for SingleComponentResponseOfDestinyItemTalentGridComponent.Data property.
            /// </summary>
            /// <param name="value">Data</param>
            public SingleComponentResponseOfDestinyItemTalentGridComponentBuilder Data(DestinyEntitiesItemsDestinyItemTalentGridComponent value)
            {
                _Data = value;
                return this;
            }

            /// <summary>
            /// Sets value for SingleComponentResponseOfDestinyItemTalentGridComponent.Privacy property.
            /// </summary>
            /// <param name="value">Privacy</param>
            public SingleComponentResponseOfDestinyItemTalentGridComponentBuilder Privacy(int? value)
            {
                _Privacy = value;
                return this;
            }

            /// <summary>
            /// Sets value for SingleComponentResponseOfDestinyItemTalentGridComponent.Disabled property.
            /// </summary>
            /// <param name="value">If true, this component is disabled.</param>
            public SingleComponentResponseOfDestinyItemTalentGridComponentBuilder Disabled(bool? value)
            {
                _Disabled = value;
                return this;
            }


            /// <summary>
            /// Builds instance of SingleComponentResponseOfDestinyItemTalentGridComponent.
            /// </summary>
            /// <returns>SingleComponentResponseOfDestinyItemTalentGridComponent</returns>
            public SingleComponentResponseOfDestinyItemTalentGridComponent Build()
            {
                Validate();
                return new SingleComponentResponseOfDestinyItemTalentGridComponent(
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