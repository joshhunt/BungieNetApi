/* 
 * Bungie.Net API
 *
 * These endpoints constitute the functionality exposed by Bungie.net, both for more traditional website functionality and for connectivity to Bungie video games and their related functionality.
 *
 * The version of the OpenAPI document: 2.8.0
 * Contact: support@bungie.com
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Net;
using System.Net.Mime;
using BungieNetApi.Client;
using BungieNetApi.Model;

namespace BungieNetApi.Api
{

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface ITokensApiSync : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Apply a partner offer to the targeted user. This endpoint does not claim a new offer, but any already claimed offers will be applied to the game if not already.
        /// </remarks>
        /// <exception cref="BungieNetApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="partnerApplicationId">The partner application identifier.</param>
        /// <param name="targetBnetMembershipId">The bungie.net user to apply missing offers to. If not self, elevated permissions are required.</param>
        /// <returns>InlineResponse20017</returns>
        InlineResponse20017 TokensApplyMissingPartnerOffersWithoutClaim (int partnerApplicationId, long targetBnetMembershipId);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Apply a partner offer to the targeted user. This endpoint does not claim a new offer, but any already claimed offers will be applied to the game if not already.
        /// </remarks>
        /// <exception cref="BungieNetApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="partnerApplicationId">The partner application identifier.</param>
        /// <param name="targetBnetMembershipId">The bungie.net user to apply missing offers to. If not self, elevated permissions are required.</param>
        /// <returns>ApiResponse of InlineResponse20017</returns>
        ApiResponse<InlineResponse20017> TokensApplyMissingPartnerOffersWithoutClaimWithHttpInfo (int partnerApplicationId, long targetBnetMembershipId);
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Claim a partner offer as the authenticated user.
        /// </remarks>
        /// <exception cref="BungieNetApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>InlineResponse20017</returns>
        InlineResponse20017 TokensClaimPartnerOffer ();

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Claim a partner offer as the authenticated user.
        /// </remarks>
        /// <exception cref="BungieNetApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of InlineResponse20017</returns>
        ApiResponse<InlineResponse20017> TokensClaimPartnerOfferWithHttpInfo ();
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Returns the partner sku and offer history of the targeted user. Elevated permissions are required to see users that are not yourself.
        /// </remarks>
        /// <exception cref="BungieNetApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="partnerApplicationId">The partner application identifier.</param>
        /// <param name="targetBnetMembershipId">The bungie.net user to apply missing offers to. If not self, elevated permissions are required.</param>
        /// <returns>InlineResponse20032</returns>
        InlineResponse20032 TokensGetPartnerOfferSkuHistory (int partnerApplicationId, long targetBnetMembershipId);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Returns the partner sku and offer history of the targeted user. Elevated permissions are required to see users that are not yourself.
        /// </remarks>
        /// <exception cref="BungieNetApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="partnerApplicationId">The partner application identifier.</param>
        /// <param name="targetBnetMembershipId">The bungie.net user to apply missing offers to. If not self, elevated permissions are required.</param>
        /// <returns>ApiResponse of InlineResponse20032</returns>
        ApiResponse<InlineResponse20032> TokensGetPartnerOfferSkuHistoryWithHttpInfo (int partnerApplicationId, long targetBnetMembershipId);
        #endregion Synchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface ITokensApiAsync : IApiAccessor
    {
        #region Asynchronous Operations
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Apply a partner offer to the targeted user. This endpoint does not claim a new offer, but any already claimed offers will be applied to the game if not already.
        /// </remarks>
        /// <exception cref="BungieNetApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="partnerApplicationId">The partner application identifier.</param>
        /// <param name="targetBnetMembershipId">The bungie.net user to apply missing offers to. If not self, elevated permissions are required.</param>
        /// <returns>Task of InlineResponse20017</returns>
        System.Threading.Tasks.Task<InlineResponse20017> TokensApplyMissingPartnerOffersWithoutClaimAsync (int partnerApplicationId, long targetBnetMembershipId);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Apply a partner offer to the targeted user. This endpoint does not claim a new offer, but any already claimed offers will be applied to the game if not already.
        /// </remarks>
        /// <exception cref="BungieNetApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="partnerApplicationId">The partner application identifier.</param>
        /// <param name="targetBnetMembershipId">The bungie.net user to apply missing offers to. If not self, elevated permissions are required.</param>
        /// <returns>Task of ApiResponse (InlineResponse20017)</returns>
        System.Threading.Tasks.Task<ApiResponse<InlineResponse20017>> TokensApplyMissingPartnerOffersWithoutClaimAsyncWithHttpInfo (int partnerApplicationId, long targetBnetMembershipId);
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Claim a partner offer as the authenticated user.
        /// </remarks>
        /// <exception cref="BungieNetApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of InlineResponse20017</returns>
        System.Threading.Tasks.Task<InlineResponse20017> TokensClaimPartnerOfferAsync ();

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Claim a partner offer as the authenticated user.
        /// </remarks>
        /// <exception cref="BungieNetApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse (InlineResponse20017)</returns>
        System.Threading.Tasks.Task<ApiResponse<InlineResponse20017>> TokensClaimPartnerOfferAsyncWithHttpInfo ();
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Returns the partner sku and offer history of the targeted user. Elevated permissions are required to see users that are not yourself.
        /// </remarks>
        /// <exception cref="BungieNetApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="partnerApplicationId">The partner application identifier.</param>
        /// <param name="targetBnetMembershipId">The bungie.net user to apply missing offers to. If not self, elevated permissions are required.</param>
        /// <returns>Task of InlineResponse20032</returns>
        System.Threading.Tasks.Task<InlineResponse20032> TokensGetPartnerOfferSkuHistoryAsync (int partnerApplicationId, long targetBnetMembershipId);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Returns the partner sku and offer history of the targeted user. Elevated permissions are required to see users that are not yourself.
        /// </remarks>
        /// <exception cref="BungieNetApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="partnerApplicationId">The partner application identifier.</param>
        /// <param name="targetBnetMembershipId">The bungie.net user to apply missing offers to. If not self, elevated permissions are required.</param>
        /// <returns>Task of ApiResponse (InlineResponse20032)</returns>
        System.Threading.Tasks.Task<ApiResponse<InlineResponse20032>> TokensGetPartnerOfferSkuHistoryAsyncWithHttpInfo (int partnerApplicationId, long targetBnetMembershipId);
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface ITokensApi : ITokensApiSync, ITokensApiAsync
    {

    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class TokensApi : ITokensApi
    {
        private BungieNetApi.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="TokensApi"/> class.
        /// </summary>
        /// <returns></returns>
        public TokensApi() : this((string) null)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TokensApi"/> class.
        /// </summary>
        /// <returns></returns>
        public TokensApi(String basePath)
        {
            this.Configuration = BungieNetApi.Client.Configuration.MergeConfigurations(
                BungieNetApi.Client.GlobalConfiguration.Instance,
                new BungieNetApi.Client.Configuration { BasePath = basePath }
            );
            this.Client = new BungieNetApi.Client.ApiClient(this.Configuration.BasePath);
            this.AsynchronousClient = new BungieNetApi.Client.ApiClient(this.Configuration.BasePath);
            this.ExceptionFactory = BungieNetApi.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TokensApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public TokensApi(BungieNetApi.Client.Configuration configuration)
        {
            if (configuration == null) throw new ArgumentNullException("configuration");

            this.Configuration = BungieNetApi.Client.Configuration.MergeConfigurations(
                BungieNetApi.Client.GlobalConfiguration.Instance,
                configuration
            );
            this.Client = new BungieNetApi.Client.ApiClient(this.Configuration.BasePath);
            this.AsynchronousClient = new BungieNetApi.Client.ApiClient(this.Configuration.BasePath);
            ExceptionFactory = BungieNetApi.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TokensApi"/> class
        /// using a Configuration object and client instance.
        /// </summary>
        /// <param name="client">The client interface for synchronous API access.</param>
        /// <param name="asyncClient">The client interface for asynchronous API access.</param>
        /// <param name="configuration">The configuration object.</param>
        public TokensApi(BungieNetApi.Client.ISynchronousClient client,BungieNetApi.Client.IAsynchronousClient asyncClient, BungieNetApi.Client.IReadableConfiguration configuration)
        {
            if(client == null) throw new ArgumentNullException("client");
            if(asyncClient == null) throw new ArgumentNullException("asyncClient");
            if(configuration == null) throw new ArgumentNullException("configuration");

            this.Client = client;
            this.AsynchronousClient = asyncClient;
            this.Configuration = configuration;
            this.ExceptionFactory = BungieNetApi.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// The client for accessing this underlying API asynchronously.
        /// </summary>
        public BungieNetApi.Client.IAsynchronousClient AsynchronousClient { get; set; }

        /// <summary>
        /// The client for accessing this underlying API synchronously.
        /// </summary>
        public BungieNetApi.Client.ISynchronousClient Client { get; set; }

        /// <summary>
        /// Gets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        public String GetBasePath()
        {
            return this.Configuration.BasePath;
        }

        /// <summary>
        /// Gets or sets the configuration object
        /// </summary>
        /// <value>An instance of the Configuration</value>
        public BungieNetApi.Client.IReadableConfiguration Configuration {get; set;}

        /// <summary>
        /// Provides a factory method hook for the creation of exceptions.
        /// </summary>
        public BungieNetApi.Client.ExceptionFactory ExceptionFactory
        {
            get
            {
                if (_exceptionFactory != null && _exceptionFactory.GetInvocationList().Length > 1)
                {
                    throw new InvalidOperationException("Multicast delegate for ExceptionFactory is unsupported.");
                }
                return _exceptionFactory;
            }
            set { _exceptionFactory = value; }
        }

        /// <summary>
        ///  Apply a partner offer to the targeted user. This endpoint does not claim a new offer, but any already claimed offers will be applied to the game if not already.
        /// </summary>
        /// <exception cref="BungieNetApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="partnerApplicationId">The partner application identifier.</param>
        /// <param name="targetBnetMembershipId">The bungie.net user to apply missing offers to. If not self, elevated permissions are required.</param>
        /// <returns>InlineResponse20017</returns>
        public InlineResponse20017 TokensApplyMissingPartnerOffersWithoutClaim (int partnerApplicationId, long targetBnetMembershipId)
        {
             BungieNetApi.Client.ApiResponse<InlineResponse20017> localVarResponse = TokensApplyMissingPartnerOffersWithoutClaimWithHttpInfo(partnerApplicationId, targetBnetMembershipId);
             return localVarResponse.Data;
        }

        /// <summary>
        ///  Apply a partner offer to the targeted user. This endpoint does not claim a new offer, but any already claimed offers will be applied to the game if not already.
        /// </summary>
        /// <exception cref="BungieNetApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="partnerApplicationId">The partner application identifier.</param>
        /// <param name="targetBnetMembershipId">The bungie.net user to apply missing offers to. If not self, elevated permissions are required.</param>
        /// <returns>ApiResponse of InlineResponse20017</returns>
        public BungieNetApi.Client.ApiResponse< InlineResponse20017 > TokensApplyMissingPartnerOffersWithoutClaimWithHttpInfo (int partnerApplicationId, long targetBnetMembershipId)
        {
            BungieNetApi.Client.RequestOptions localVarRequestOptions = new BungieNetApi.Client.RequestOptions();

            String[] _contentTypes = new String[] {
            };

            // to determine the Accept header
            String[] _accepts = new String[] {
                "*/*"
            };

            var localVarContentType = BungieNetApi.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = BungieNetApi.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.PathParameters.Add("partnerApplicationId", BungieNetApi.Client.ClientUtils.ParameterToString(partnerApplicationId)); // path parameter
            localVarRequestOptions.PathParameters.Add("targetBnetMembershipId", BungieNetApi.Client.ClientUtils.ParameterToString(targetBnetMembershipId)); // path parameter

            // authentication (oauth2) required
            // oauth required
            if (!String.IsNullOrEmpty(this.Configuration.AccessToken))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }

            // make the HTTP request
            var localVarResponse = this.Client.Post< InlineResponse20017 >("/Tokens/Partner/ApplyMissingOffers/{partnerApplicationId}/{targetBnetMembershipId}/", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("TokensApplyMissingPartnerOffersWithoutClaim", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        ///  Apply a partner offer to the targeted user. This endpoint does not claim a new offer, but any already claimed offers will be applied to the game if not already.
        /// </summary>
        /// <exception cref="BungieNetApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="partnerApplicationId">The partner application identifier.</param>
        /// <param name="targetBnetMembershipId">The bungie.net user to apply missing offers to. If not self, elevated permissions are required.</param>
        /// <returns>Task of InlineResponse20017</returns>
        public async System.Threading.Tasks.Task<InlineResponse20017> TokensApplyMissingPartnerOffersWithoutClaimAsync (int partnerApplicationId, long targetBnetMembershipId)
        {
             BungieNetApi.Client.ApiResponse<InlineResponse20017> localVarResponse = await TokensApplyMissingPartnerOffersWithoutClaimAsyncWithHttpInfo(partnerApplicationId, targetBnetMembershipId);
             return localVarResponse.Data;

        }

        /// <summary>
        ///  Apply a partner offer to the targeted user. This endpoint does not claim a new offer, but any already claimed offers will be applied to the game if not already.
        /// </summary>
        /// <exception cref="BungieNetApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="partnerApplicationId">The partner application identifier.</param>
        /// <param name="targetBnetMembershipId">The bungie.net user to apply missing offers to. If not self, elevated permissions are required.</param>
        /// <returns>Task of ApiResponse (InlineResponse20017)</returns>
        public async System.Threading.Tasks.Task<BungieNetApi.Client.ApiResponse<InlineResponse20017>> TokensApplyMissingPartnerOffersWithoutClaimAsyncWithHttpInfo (int partnerApplicationId, long targetBnetMembershipId)
        {

            BungieNetApi.Client.RequestOptions localVarRequestOptions = new BungieNetApi.Client.RequestOptions();

            String[] _contentTypes = new String[] {
            };

            // to determine the Accept header
            String[] _accepts = new String[] {
                "*/*"
            };
            
            foreach (var _contentType in _contentTypes)
                localVarRequestOptions.HeaderParameters.Add("Content-Type", _contentType);
            
            foreach (var _accept in _accepts)
                localVarRequestOptions.HeaderParameters.Add("Accept", _accept);
            
            localVarRequestOptions.PathParameters.Add("partnerApplicationId", BungieNetApi.Client.ClientUtils.ParameterToString(partnerApplicationId)); // path parameter
            localVarRequestOptions.PathParameters.Add("targetBnetMembershipId", BungieNetApi.Client.ClientUtils.ParameterToString(targetBnetMembershipId)); // path parameter

            // authentication (oauth2) required
            // oauth required
            if (!String.IsNullOrEmpty(this.Configuration.AccessToken))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }

            // make the HTTP request

            var localVarResponse = await this.AsynchronousClient.PostAsync<InlineResponse20017>("/Tokens/Partner/ApplyMissingOffers/{partnerApplicationId}/{targetBnetMembershipId}/", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("TokensApplyMissingPartnerOffersWithoutClaim", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        ///  Claim a partner offer as the authenticated user.
        /// </summary>
        /// <exception cref="BungieNetApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>InlineResponse20017</returns>
        public InlineResponse20017 TokensClaimPartnerOffer ()
        {
             BungieNetApi.Client.ApiResponse<InlineResponse20017> localVarResponse = TokensClaimPartnerOfferWithHttpInfo();
             return localVarResponse.Data;
        }

        /// <summary>
        ///  Claim a partner offer as the authenticated user.
        /// </summary>
        /// <exception cref="BungieNetApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of InlineResponse20017</returns>
        public BungieNetApi.Client.ApiResponse< InlineResponse20017 > TokensClaimPartnerOfferWithHttpInfo ()
        {
            BungieNetApi.Client.RequestOptions localVarRequestOptions = new BungieNetApi.Client.RequestOptions();

            String[] _contentTypes = new String[] {
            };

            // to determine the Accept header
            String[] _accepts = new String[] {
                "*/*"
            };

            var localVarContentType = BungieNetApi.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = BungieNetApi.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);


            // authentication (oauth2) required
            // oauth required
            if (!String.IsNullOrEmpty(this.Configuration.AccessToken))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }

            // make the HTTP request
            var localVarResponse = this.Client.Post< InlineResponse20017 >("/Tokens/Partner/ClaimOffer/", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("TokensClaimPartnerOffer", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        ///  Claim a partner offer as the authenticated user.
        /// </summary>
        /// <exception cref="BungieNetApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of InlineResponse20017</returns>
        public async System.Threading.Tasks.Task<InlineResponse20017> TokensClaimPartnerOfferAsync ()
        {
             BungieNetApi.Client.ApiResponse<InlineResponse20017> localVarResponse = await TokensClaimPartnerOfferAsyncWithHttpInfo();
             return localVarResponse.Data;

        }

        /// <summary>
        ///  Claim a partner offer as the authenticated user.
        /// </summary>
        /// <exception cref="BungieNetApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse (InlineResponse20017)</returns>
        public async System.Threading.Tasks.Task<BungieNetApi.Client.ApiResponse<InlineResponse20017>> TokensClaimPartnerOfferAsyncWithHttpInfo ()
        {

            BungieNetApi.Client.RequestOptions localVarRequestOptions = new BungieNetApi.Client.RequestOptions();

            String[] _contentTypes = new String[] {
            };

            // to determine the Accept header
            String[] _accepts = new String[] {
                "*/*"
            };
            
            foreach (var _contentType in _contentTypes)
                localVarRequestOptions.HeaderParameters.Add("Content-Type", _contentType);
            
            foreach (var _accept in _accepts)
                localVarRequestOptions.HeaderParameters.Add("Accept", _accept);
            

            // authentication (oauth2) required
            // oauth required
            if (!String.IsNullOrEmpty(this.Configuration.AccessToken))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }

            // make the HTTP request

            var localVarResponse = await this.AsynchronousClient.PostAsync<InlineResponse20017>("/Tokens/Partner/ClaimOffer/", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("TokensClaimPartnerOffer", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        ///  Returns the partner sku and offer history of the targeted user. Elevated permissions are required to see users that are not yourself.
        /// </summary>
        /// <exception cref="BungieNetApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="partnerApplicationId">The partner application identifier.</param>
        /// <param name="targetBnetMembershipId">The bungie.net user to apply missing offers to. If not self, elevated permissions are required.</param>
        /// <returns>InlineResponse20032</returns>
        public InlineResponse20032 TokensGetPartnerOfferSkuHistory (int partnerApplicationId, long targetBnetMembershipId)
        {
             BungieNetApi.Client.ApiResponse<InlineResponse20032> localVarResponse = TokensGetPartnerOfferSkuHistoryWithHttpInfo(partnerApplicationId, targetBnetMembershipId);
             return localVarResponse.Data;
        }

        /// <summary>
        ///  Returns the partner sku and offer history of the targeted user. Elevated permissions are required to see users that are not yourself.
        /// </summary>
        /// <exception cref="BungieNetApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="partnerApplicationId">The partner application identifier.</param>
        /// <param name="targetBnetMembershipId">The bungie.net user to apply missing offers to. If not self, elevated permissions are required.</param>
        /// <returns>ApiResponse of InlineResponse20032</returns>
        public BungieNetApi.Client.ApiResponse< InlineResponse20032 > TokensGetPartnerOfferSkuHistoryWithHttpInfo (int partnerApplicationId, long targetBnetMembershipId)
        {
            BungieNetApi.Client.RequestOptions localVarRequestOptions = new BungieNetApi.Client.RequestOptions();

            String[] _contentTypes = new String[] {
            };

            // to determine the Accept header
            String[] _accepts = new String[] {
                "*/*"
            };

            var localVarContentType = BungieNetApi.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = BungieNetApi.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.PathParameters.Add("partnerApplicationId", BungieNetApi.Client.ClientUtils.ParameterToString(partnerApplicationId)); // path parameter
            localVarRequestOptions.PathParameters.Add("targetBnetMembershipId", BungieNetApi.Client.ClientUtils.ParameterToString(targetBnetMembershipId)); // path parameter

            // authentication (oauth2) required
            // oauth required
            if (!String.IsNullOrEmpty(this.Configuration.AccessToken))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }

            // make the HTTP request
            var localVarResponse = this.Client.Get< InlineResponse20032 >("/Tokens/Partner/History/{partnerApplicationId}/{targetBnetMembershipId}/", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("TokensGetPartnerOfferSkuHistory", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        ///  Returns the partner sku and offer history of the targeted user. Elevated permissions are required to see users that are not yourself.
        /// </summary>
        /// <exception cref="BungieNetApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="partnerApplicationId">The partner application identifier.</param>
        /// <param name="targetBnetMembershipId">The bungie.net user to apply missing offers to. If not self, elevated permissions are required.</param>
        /// <returns>Task of InlineResponse20032</returns>
        public async System.Threading.Tasks.Task<InlineResponse20032> TokensGetPartnerOfferSkuHistoryAsync (int partnerApplicationId, long targetBnetMembershipId)
        {
             BungieNetApi.Client.ApiResponse<InlineResponse20032> localVarResponse = await TokensGetPartnerOfferSkuHistoryAsyncWithHttpInfo(partnerApplicationId, targetBnetMembershipId);
             return localVarResponse.Data;

        }

        /// <summary>
        ///  Returns the partner sku and offer history of the targeted user. Elevated permissions are required to see users that are not yourself.
        /// </summary>
        /// <exception cref="BungieNetApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="partnerApplicationId">The partner application identifier.</param>
        /// <param name="targetBnetMembershipId">The bungie.net user to apply missing offers to. If not self, elevated permissions are required.</param>
        /// <returns>Task of ApiResponse (InlineResponse20032)</returns>
        public async System.Threading.Tasks.Task<BungieNetApi.Client.ApiResponse<InlineResponse20032>> TokensGetPartnerOfferSkuHistoryAsyncWithHttpInfo (int partnerApplicationId, long targetBnetMembershipId)
        {

            BungieNetApi.Client.RequestOptions localVarRequestOptions = new BungieNetApi.Client.RequestOptions();

            String[] _contentTypes = new String[] {
            };

            // to determine the Accept header
            String[] _accepts = new String[] {
                "*/*"
            };
            
            foreach (var _contentType in _contentTypes)
                localVarRequestOptions.HeaderParameters.Add("Content-Type", _contentType);
            
            foreach (var _accept in _accepts)
                localVarRequestOptions.HeaderParameters.Add("Accept", _accept);
            
            localVarRequestOptions.PathParameters.Add("partnerApplicationId", BungieNetApi.Client.ClientUtils.ParameterToString(partnerApplicationId)); // path parameter
            localVarRequestOptions.PathParameters.Add("targetBnetMembershipId", BungieNetApi.Client.ClientUtils.ParameterToString(targetBnetMembershipId)); // path parameter

            // authentication (oauth2) required
            // oauth required
            if (!String.IsNullOrEmpty(this.Configuration.AccessToken))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }

            // make the HTTP request

            var localVarResponse = await this.AsynchronousClient.GetAsync<InlineResponse20032>("/Tokens/Partner/History/{partnerApplicationId}/{targetBnetMembershipId}/", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("TokensGetPartnerOfferSkuHistory", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

    }
}
