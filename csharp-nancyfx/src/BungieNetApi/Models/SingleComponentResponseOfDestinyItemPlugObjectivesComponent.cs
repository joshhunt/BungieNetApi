using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Sharpility.Extensions;
using NodaTime;

namespace BungieNetApi._Platform.Models
{
    /// <summary>
    /// SingleComponentResponseOfDestinyItemPlugObjectivesComponent
    /// </summary>
    public sealed class SingleComponentResponseOfDestinyItemPlugObjectivesComponent:  IEquatable<SingleComponentResponseOfDestinyItemPlugObjectivesComponent>
    { 
        /// <summary>
        /// Data
        /// </summary>
        public DestinyComponentsItemsDestinyItemPlugObjectivesComponent Data { get; private set; }

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
        /// Use SingleComponentResponseOfDestinyItemPlugObjectivesComponent.Builder() for instance creation instead.
        /// </summary>
        [Obsolete]
        public SingleComponentResponseOfDestinyItemPlugObjectivesComponent()
        {
        }

        private SingleComponentResponseOfDestinyItemPlugObjectivesComponent(DestinyComponentsItemsDestinyItemPlugObjectivesComponent Data, int? Privacy, bool? Disabled)
        {
            
            this.Data = Data;
            
            this.Privacy = Privacy;
            
            this.Disabled = Disabled;
            
        }

        /// <summary>
        /// Returns builder of SingleComponentResponseOfDestinyItemPlugObjectivesComponent.
        /// </summary>
        /// <returns>SingleComponentResponseOfDestinyItemPlugObjectivesComponentBuilder</returns>
        public static SingleComponentResponseOfDestinyItemPlugObjectivesComponentBuilder Builder()
        {
            return new SingleComponentResponseOfDestinyItemPlugObjectivesComponentBuilder();
        }

        /// <summary>
        /// Returns SingleComponentResponseOfDestinyItemPlugObjectivesComponentBuilder with properties set.
        /// Use it to change properties.
        /// </summary>
        /// <returns>SingleComponentResponseOfDestinyItemPlugObjectivesComponentBuilder</returns>
        public SingleComponentResponseOfDestinyItemPlugObjectivesComponentBuilder With()
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

        public bool Equals(SingleComponentResponseOfDestinyItemPlugObjectivesComponent other)
        {
            return Equals((object) other);
        }

        public override int GetHashCode()
        {
            return this.PropertiesHash();
        }

        /// <summary>
        /// Implementation of == operator for (SingleComponentResponseOfDestinyItemPlugObjectivesComponent.
        /// </summary>
        /// <param name="left">Compared (SingleComponentResponseOfDestinyItemPlugObjectivesComponent</param>
        /// <param name="right">Compared (SingleComponentResponseOfDestinyItemPlugObjectivesComponent</param>
        /// <returns>true if compared items are equals, false otherwise</returns>
        public static bool operator == (SingleComponentResponseOfDestinyItemPlugObjectivesComponent left, SingleComponentResponseOfDestinyItemPlugObjectivesComponent right)
        {
            return Equals(left, right);
        }

        /// <summary>
        /// Implementation of != operator for (SingleComponentResponseOfDestinyItemPlugObjectivesComponent.
        /// </summary>
        /// <param name="left">Compared (SingleComponentResponseOfDestinyItemPlugObjectivesComponent</param>
        /// <param name="right">Compared (SingleComponentResponseOfDestinyItemPlugObjectivesComponent</param>
        /// <returns>true if compared items are not equals, false otherwise</returns>
        public static bool operator != (SingleComponentResponseOfDestinyItemPlugObjectivesComponent left, SingleComponentResponseOfDestinyItemPlugObjectivesComponent right)
        {
            return !Equals(left, right);
        }

        /// <summary>
        /// Builder of SingleComponentResponseOfDestinyItemPlugObjectivesComponent.
        /// </summary>
        public sealed class SingleComponentResponseOfDestinyItemPlugObjectivesComponentBuilder
        {
            private DestinyComponentsItemsDestinyItemPlugObjectivesComponent _Data;
            private int? _Privacy;
            private bool? _Disabled;

            internal SingleComponentResponseOfDestinyItemPlugObjectivesComponentBuilder()
            {
                SetupDefaults();
            }

            private void SetupDefaults()
            {
            }

            /// <summary>
            /// Sets value for SingleComponentResponseOfDestinyItemPlugObjectivesComponent.Data property.
            /// </summary>
            /// <param name="value">Data</param>
            public SingleComponentResponseOfDestinyItemPlugObjectivesComponentBuilder Data(DestinyComponentsItemsDestinyItemPlugObjectivesComponent value)
            {
                _Data = value;
                return this;
            }

            /// <summary>
            /// Sets value for SingleComponentResponseOfDestinyItemPlugObjectivesComponent.Privacy property.
            /// </summary>
            /// <param name="value">Privacy</param>
            public SingleComponentResponseOfDestinyItemPlugObjectivesComponentBuilder Privacy(int? value)
            {
                _Privacy = value;
                return this;
            }

            /// <summary>
            /// Sets value for SingleComponentResponseOfDestinyItemPlugObjectivesComponent.Disabled property.
            /// </summary>
            /// <param name="value">If true, this component is disabled.</param>
            public SingleComponentResponseOfDestinyItemPlugObjectivesComponentBuilder Disabled(bool? value)
            {
                _Disabled = value;
                return this;
            }


            /// <summary>
            /// Builds instance of SingleComponentResponseOfDestinyItemPlugObjectivesComponent.
            /// </summary>
            /// <returns>SingleComponentResponseOfDestinyItemPlugObjectivesComponent</returns>
            public SingleComponentResponseOfDestinyItemPlugObjectivesComponent Build()
            {
                Validate();
                return new SingleComponentResponseOfDestinyItemPlugObjectivesComponent(
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