using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Sharpility.Extensions;
using NodaTime;

namespace BungieNetApi._Platform.Models
{
    /// <summary>
    /// The base class for any component-returning object that may need to indicate information about the state of the component being returned.
    /// </summary>
    public sealed class ComponentsComponentResponse:  IEquatable<ComponentsComponentResponse>
    { 
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
        /// Use ComponentsComponentResponse.Builder() for instance creation instead.
        /// </summary>
        [Obsolete]
        public ComponentsComponentResponse()
        {
        }

        private ComponentsComponentResponse(int? Privacy, bool? Disabled)
        {
            
            this.Privacy = Privacy;
            
            this.Disabled = Disabled;
            
        }

        /// <summary>
        /// Returns builder of ComponentsComponentResponse.
        /// </summary>
        /// <returns>ComponentsComponentResponseBuilder</returns>
        public static ComponentsComponentResponseBuilder Builder()
        {
            return new ComponentsComponentResponseBuilder();
        }

        /// <summary>
        /// Returns ComponentsComponentResponseBuilder with properties set.
        /// Use it to change properties.
        /// </summary>
        /// <returns>ComponentsComponentResponseBuilder</returns>
        public ComponentsComponentResponseBuilder With()
        {
            return Builder()
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

        public bool Equals(ComponentsComponentResponse other)
        {
            return Equals((object) other);
        }

        public override int GetHashCode()
        {
            return this.PropertiesHash();
        }

        /// <summary>
        /// Implementation of == operator for (ComponentsComponentResponse.
        /// </summary>
        /// <param name="left">Compared (ComponentsComponentResponse</param>
        /// <param name="right">Compared (ComponentsComponentResponse</param>
        /// <returns>true if compared items are equals, false otherwise</returns>
        public static bool operator == (ComponentsComponentResponse left, ComponentsComponentResponse right)
        {
            return Equals(left, right);
        }

        /// <summary>
        /// Implementation of != operator for (ComponentsComponentResponse.
        /// </summary>
        /// <param name="left">Compared (ComponentsComponentResponse</param>
        /// <param name="right">Compared (ComponentsComponentResponse</param>
        /// <returns>true if compared items are not equals, false otherwise</returns>
        public static bool operator != (ComponentsComponentResponse left, ComponentsComponentResponse right)
        {
            return !Equals(left, right);
        }

        /// <summary>
        /// Builder of ComponentsComponentResponse.
        /// </summary>
        public sealed class ComponentsComponentResponseBuilder
        {
            private int? _Privacy;
            private bool? _Disabled;

            internal ComponentsComponentResponseBuilder()
            {
                SetupDefaults();
            }

            private void SetupDefaults()
            {
            }

            /// <summary>
            /// Sets value for ComponentsComponentResponse.Privacy property.
            /// </summary>
            /// <param name="value">Privacy</param>
            public ComponentsComponentResponseBuilder Privacy(int? value)
            {
                _Privacy = value;
                return this;
            }

            /// <summary>
            /// Sets value for ComponentsComponentResponse.Disabled property.
            /// </summary>
            /// <param name="value">If true, this component is disabled.</param>
            public ComponentsComponentResponseBuilder Disabled(bool? value)
            {
                _Disabled = value;
                return this;
            }


            /// <summary>
            /// Builds instance of ComponentsComponentResponse.
            /// </summary>
            /// <returns>ComponentsComponentResponse</returns>
            public ComponentsComponentResponse Build()
            {
                Validate();
                return new ComponentsComponentResponse(
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