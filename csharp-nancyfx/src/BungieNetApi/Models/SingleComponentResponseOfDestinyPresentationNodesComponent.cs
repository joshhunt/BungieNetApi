using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Sharpility.Extensions;
using NodaTime;

namespace BungieNetApi._Platform.Models
{
    /// <summary>
    /// SingleComponentResponseOfDestinyPresentationNodesComponent
    /// </summary>
    public sealed class SingleComponentResponseOfDestinyPresentationNodesComponent:  IEquatable<SingleComponentResponseOfDestinyPresentationNodesComponent>
    { 
        /// <summary>
        /// Data
        /// </summary>
        public DestinyComponentsPresentationDestinyPresentationNodesComponent Data { get; private set; }

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
        /// Use SingleComponentResponseOfDestinyPresentationNodesComponent.Builder() for instance creation instead.
        /// </summary>
        [Obsolete]
        public SingleComponentResponseOfDestinyPresentationNodesComponent()
        {
        }

        private SingleComponentResponseOfDestinyPresentationNodesComponent(DestinyComponentsPresentationDestinyPresentationNodesComponent Data, int? Privacy, bool? Disabled)
        {
            
            this.Data = Data;
            
            this.Privacy = Privacy;
            
            this.Disabled = Disabled;
            
        }

        /// <summary>
        /// Returns builder of SingleComponentResponseOfDestinyPresentationNodesComponent.
        /// </summary>
        /// <returns>SingleComponentResponseOfDestinyPresentationNodesComponentBuilder</returns>
        public static SingleComponentResponseOfDestinyPresentationNodesComponentBuilder Builder()
        {
            return new SingleComponentResponseOfDestinyPresentationNodesComponentBuilder();
        }

        /// <summary>
        /// Returns SingleComponentResponseOfDestinyPresentationNodesComponentBuilder with properties set.
        /// Use it to change properties.
        /// </summary>
        /// <returns>SingleComponentResponseOfDestinyPresentationNodesComponentBuilder</returns>
        public SingleComponentResponseOfDestinyPresentationNodesComponentBuilder With()
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

        public bool Equals(SingleComponentResponseOfDestinyPresentationNodesComponent other)
        {
            return Equals((object) other);
        }

        public override int GetHashCode()
        {
            return this.PropertiesHash();
        }

        /// <summary>
        /// Implementation of == operator for (SingleComponentResponseOfDestinyPresentationNodesComponent.
        /// </summary>
        /// <param name="left">Compared (SingleComponentResponseOfDestinyPresentationNodesComponent</param>
        /// <param name="right">Compared (SingleComponentResponseOfDestinyPresentationNodesComponent</param>
        /// <returns>true if compared items are equals, false otherwise</returns>
        public static bool operator == (SingleComponentResponseOfDestinyPresentationNodesComponent left, SingleComponentResponseOfDestinyPresentationNodesComponent right)
        {
            return Equals(left, right);
        }

        /// <summary>
        /// Implementation of != operator for (SingleComponentResponseOfDestinyPresentationNodesComponent.
        /// </summary>
        /// <param name="left">Compared (SingleComponentResponseOfDestinyPresentationNodesComponent</param>
        /// <param name="right">Compared (SingleComponentResponseOfDestinyPresentationNodesComponent</param>
        /// <returns>true if compared items are not equals, false otherwise</returns>
        public static bool operator != (SingleComponentResponseOfDestinyPresentationNodesComponent left, SingleComponentResponseOfDestinyPresentationNodesComponent right)
        {
            return !Equals(left, right);
        }

        /// <summary>
        /// Builder of SingleComponentResponseOfDestinyPresentationNodesComponent.
        /// </summary>
        public sealed class SingleComponentResponseOfDestinyPresentationNodesComponentBuilder
        {
            private DestinyComponentsPresentationDestinyPresentationNodesComponent _Data;
            private int? _Privacy;
            private bool? _Disabled;

            internal SingleComponentResponseOfDestinyPresentationNodesComponentBuilder()
            {
                SetupDefaults();
            }

            private void SetupDefaults()
            {
            }

            /// <summary>
            /// Sets value for SingleComponentResponseOfDestinyPresentationNodesComponent.Data property.
            /// </summary>
            /// <param name="value">Data</param>
            public SingleComponentResponseOfDestinyPresentationNodesComponentBuilder Data(DestinyComponentsPresentationDestinyPresentationNodesComponent value)
            {
                _Data = value;
                return this;
            }

            /// <summary>
            /// Sets value for SingleComponentResponseOfDestinyPresentationNodesComponent.Privacy property.
            /// </summary>
            /// <param name="value">Privacy</param>
            public SingleComponentResponseOfDestinyPresentationNodesComponentBuilder Privacy(int? value)
            {
                _Privacy = value;
                return this;
            }

            /// <summary>
            /// Sets value for SingleComponentResponseOfDestinyPresentationNodesComponent.Disabled property.
            /// </summary>
            /// <param name="value">If true, this component is disabled.</param>
            public SingleComponentResponseOfDestinyPresentationNodesComponentBuilder Disabled(bool? value)
            {
                _Disabled = value;
                return this;
            }


            /// <summary>
            /// Builds instance of SingleComponentResponseOfDestinyPresentationNodesComponent.
            /// </summary>
            /// <returns>SingleComponentResponseOfDestinyPresentationNodesComponent</returns>
            public SingleComponentResponseOfDestinyPresentationNodesComponent Build()
            {
                Validate();
                return new SingleComponentResponseOfDestinyPresentationNodesComponent(
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