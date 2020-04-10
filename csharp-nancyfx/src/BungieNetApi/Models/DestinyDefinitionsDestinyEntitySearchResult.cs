using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Sharpility.Extensions;
using NodaTime;

namespace BungieNetApi._Platform.Models
{
    /// <summary>
    /// The results of a search for Destiny content. This will be improved on over time, I&#39;ve been doing some experimenting to see what might be useful.
    /// </summary>
    public sealed class DestinyDefinitionsDestinyEntitySearchResult:  IEquatable<DestinyDefinitionsDestinyEntitySearchResult>
    { 
        /// <summary>
        /// A list of suggested words that might make for better search results, based on the text searched for.
        /// </summary>
        public List<string> SuggestedWords { get; private set; }

        /// <summary>
        /// The items found that are matches/near matches for the searched-for term, sorted by something vaguely resembling \&quot;relevance\&quot;. Hopefully this will get better in the future.
        /// </summary>
        public SearchResultOfDestinyEntitySearchResultItem Results { get; private set; }


        /// <summary>
        /// Empty constructor required by some serializers.
        /// Use DestinyDefinitionsDestinyEntitySearchResult.Builder() for instance creation instead.
        /// </summary>
        [Obsolete]
        public DestinyDefinitionsDestinyEntitySearchResult()
        {
        }

        private DestinyDefinitionsDestinyEntitySearchResult(List<string> SuggestedWords, SearchResultOfDestinyEntitySearchResultItem Results)
        {
            
            this.SuggestedWords = SuggestedWords;
            
            this.Results = Results;
            
        }

        /// <summary>
        /// Returns builder of DestinyDefinitionsDestinyEntitySearchResult.
        /// </summary>
        /// <returns>DestinyDefinitionsDestinyEntitySearchResultBuilder</returns>
        public static DestinyDefinitionsDestinyEntitySearchResultBuilder Builder()
        {
            return new DestinyDefinitionsDestinyEntitySearchResultBuilder();
        }

        /// <summary>
        /// Returns DestinyDefinitionsDestinyEntitySearchResultBuilder with properties set.
        /// Use it to change properties.
        /// </summary>
        /// <returns>DestinyDefinitionsDestinyEntitySearchResultBuilder</returns>
        public DestinyDefinitionsDestinyEntitySearchResultBuilder With()
        {
            return Builder()
                .SuggestedWords(SuggestedWords)
                .Results(Results);
        }

        public override string ToString()
        {
            return this.PropertiesToString();
        }

        public override bool Equals(object obj)
        {
            return this.EqualsByProperties(obj);
        }

        public bool Equals(DestinyDefinitionsDestinyEntitySearchResult other)
        {
            return Equals((object) other);
        }

        public override int GetHashCode()
        {
            return this.PropertiesHash();
        }

        /// <summary>
        /// Implementation of == operator for (DestinyDefinitionsDestinyEntitySearchResult.
        /// </summary>
        /// <param name="left">Compared (DestinyDefinitionsDestinyEntitySearchResult</param>
        /// <param name="right">Compared (DestinyDefinitionsDestinyEntitySearchResult</param>
        /// <returns>true if compared items are equals, false otherwise</returns>
        public static bool operator == (DestinyDefinitionsDestinyEntitySearchResult left, DestinyDefinitionsDestinyEntitySearchResult right)
        {
            return Equals(left, right);
        }

        /// <summary>
        /// Implementation of != operator for (DestinyDefinitionsDestinyEntitySearchResult.
        /// </summary>
        /// <param name="left">Compared (DestinyDefinitionsDestinyEntitySearchResult</param>
        /// <param name="right">Compared (DestinyDefinitionsDestinyEntitySearchResult</param>
        /// <returns>true if compared items are not equals, false otherwise</returns>
        public static bool operator != (DestinyDefinitionsDestinyEntitySearchResult left, DestinyDefinitionsDestinyEntitySearchResult right)
        {
            return !Equals(left, right);
        }

        /// <summary>
        /// Builder of DestinyDefinitionsDestinyEntitySearchResult.
        /// </summary>
        public sealed class DestinyDefinitionsDestinyEntitySearchResultBuilder
        {
            private List<string> _SuggestedWords;
            private SearchResultOfDestinyEntitySearchResultItem _Results;

            internal DestinyDefinitionsDestinyEntitySearchResultBuilder()
            {
                SetupDefaults();
            }

            private void SetupDefaults()
            {
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsDestinyEntitySearchResult.SuggestedWords property.
            /// </summary>
            /// <param name="value">A list of suggested words that might make for better search results, based on the text searched for.</param>
            public DestinyDefinitionsDestinyEntitySearchResultBuilder SuggestedWords(List<string> value)
            {
                _SuggestedWords = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsDestinyEntitySearchResult.Results property.
            /// </summary>
            /// <param name="value">The items found that are matches/near matches for the searched-for term, sorted by something vaguely resembling \&quot;relevance\&quot;. Hopefully this will get better in the future.</param>
            public DestinyDefinitionsDestinyEntitySearchResultBuilder Results(SearchResultOfDestinyEntitySearchResultItem value)
            {
                _Results = value;
                return this;
            }


            /// <summary>
            /// Builds instance of DestinyDefinitionsDestinyEntitySearchResult.
            /// </summary>
            /// <returns>DestinyDefinitionsDestinyEntitySearchResult</returns>
            public DestinyDefinitionsDestinyEntitySearchResult Build()
            {
                Validate();
                return new DestinyDefinitionsDestinyEntitySearchResult(
                    SuggestedWords: _SuggestedWords,
                    Results: _Results
                );
            }

            private void Validate()
            { 
            }
        }

        
    }
}