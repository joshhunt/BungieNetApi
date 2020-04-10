using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Sharpility.Extensions;
using NodaTime;

namespace BungieNetApi._Platform.Models
{
    /// <summary>
    /// QueriesPagedQuery
    /// </summary>
    public sealed class QueriesPagedQuery:  IEquatable<QueriesPagedQuery>
    { 
        /// <summary>
        /// ItemsPerPage
        /// </summary>
        public int? ItemsPerPage { get; private set; }

        /// <summary>
        /// CurrentPage
        /// </summary>
        public int? CurrentPage { get; private set; }

        /// <summary>
        /// RequestContinuationToken
        /// </summary>
        public string RequestContinuationToken { get; private set; }


        /// <summary>
        /// Empty constructor required by some serializers.
        /// Use QueriesPagedQuery.Builder() for instance creation instead.
        /// </summary>
        [Obsolete]
        public QueriesPagedQuery()
        {
        }

        private QueriesPagedQuery(int? ItemsPerPage, int? CurrentPage, string RequestContinuationToken)
        {
            
            this.ItemsPerPage = ItemsPerPage;
            
            this.CurrentPage = CurrentPage;
            
            this.RequestContinuationToken = RequestContinuationToken;
            
        }

        /// <summary>
        /// Returns builder of QueriesPagedQuery.
        /// </summary>
        /// <returns>QueriesPagedQueryBuilder</returns>
        public static QueriesPagedQueryBuilder Builder()
        {
            return new QueriesPagedQueryBuilder();
        }

        /// <summary>
        /// Returns QueriesPagedQueryBuilder with properties set.
        /// Use it to change properties.
        /// </summary>
        /// <returns>QueriesPagedQueryBuilder</returns>
        public QueriesPagedQueryBuilder With()
        {
            return Builder()
                .ItemsPerPage(ItemsPerPage)
                .CurrentPage(CurrentPage)
                .RequestContinuationToken(RequestContinuationToken);
        }

        public override string ToString()
        {
            return this.PropertiesToString();
        }

        public override bool Equals(object obj)
        {
            return this.EqualsByProperties(obj);
        }

        public bool Equals(QueriesPagedQuery other)
        {
            return Equals((object) other);
        }

        public override int GetHashCode()
        {
            return this.PropertiesHash();
        }

        /// <summary>
        /// Implementation of == operator for (QueriesPagedQuery.
        /// </summary>
        /// <param name="left">Compared (QueriesPagedQuery</param>
        /// <param name="right">Compared (QueriesPagedQuery</param>
        /// <returns>true if compared items are equals, false otherwise</returns>
        public static bool operator == (QueriesPagedQuery left, QueriesPagedQuery right)
        {
            return Equals(left, right);
        }

        /// <summary>
        /// Implementation of != operator for (QueriesPagedQuery.
        /// </summary>
        /// <param name="left">Compared (QueriesPagedQuery</param>
        /// <param name="right">Compared (QueriesPagedQuery</param>
        /// <returns>true if compared items are not equals, false otherwise</returns>
        public static bool operator != (QueriesPagedQuery left, QueriesPagedQuery right)
        {
            return !Equals(left, right);
        }

        /// <summary>
        /// Builder of QueriesPagedQuery.
        /// </summary>
        public sealed class QueriesPagedQueryBuilder
        {
            private int? _ItemsPerPage;
            private int? _CurrentPage;
            private string _RequestContinuationToken;

            internal QueriesPagedQueryBuilder()
            {
                SetupDefaults();
            }

            private void SetupDefaults()
            {
            }

            /// <summary>
            /// Sets value for QueriesPagedQuery.ItemsPerPage property.
            /// </summary>
            /// <param name="value">ItemsPerPage</param>
            public QueriesPagedQueryBuilder ItemsPerPage(int? value)
            {
                _ItemsPerPage = value;
                return this;
            }

            /// <summary>
            /// Sets value for QueriesPagedQuery.CurrentPage property.
            /// </summary>
            /// <param name="value">CurrentPage</param>
            public QueriesPagedQueryBuilder CurrentPage(int? value)
            {
                _CurrentPage = value;
                return this;
            }

            /// <summary>
            /// Sets value for QueriesPagedQuery.RequestContinuationToken property.
            /// </summary>
            /// <param name="value">RequestContinuationToken</param>
            public QueriesPagedQueryBuilder RequestContinuationToken(string value)
            {
                _RequestContinuationToken = value;
                return this;
            }


            /// <summary>
            /// Builds instance of QueriesPagedQuery.
            /// </summary>
            /// <returns>QueriesPagedQuery</returns>
            public QueriesPagedQuery Build()
            {
                Validate();
                return new QueriesPagedQuery(
                    ItemsPerPage: _ItemsPerPage,
                    CurrentPage: _CurrentPage,
                    RequestContinuationToken: _RequestContinuationToken
                );
            }

            private void Validate()
            { 
            }
        }

        
    }
}