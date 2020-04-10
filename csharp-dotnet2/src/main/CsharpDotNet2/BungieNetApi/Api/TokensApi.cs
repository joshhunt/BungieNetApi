using System;
using System.Collections.Generic;
using RestSharp;
using Org.OpenAPITools.Client;
using BungieNetApi.Model;

namespace BungieNetApi.Api
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface ITokensApi
    {
        /// <summary>
        ///  Apply a partner offer to the targeted user. This endpoint does not claim a new offer, but any already claimed offers will be applied to the game if not already.
        /// </summary>
        /// <param name="partnerApplicationId">The partner application identifier.</param>
        /// <param name="targetBnetMembershipId">The bungie.net user to apply missing offers to. If not self, elevated permissions are required.</param>
        /// <returns>InlineResponse20017</returns>
        InlineResponse20017 TokensApplyMissingPartnerOffersWithoutClaim (int? partnerApplicationId, long? targetBnetMembershipId);
        /// <summary>
        ///  Claim a partner offer as the authenticated user.
        /// </summary>
        /// <returns>InlineResponse20017</returns>
        InlineResponse20017 TokensClaimPartnerOffer ();
        /// <summary>
        ///  Returns the partner sku and offer history of the targeted user. Elevated permissions are required to see users that are not yourself.
        /// </summary>
        /// <param name="partnerApplicationId">The partner application identifier.</param>
        /// <param name="targetBnetMembershipId">The bungie.net user to apply missing offers to. If not self, elevated permissions are required.</param>
        /// <returns>InlineResponse20032</returns>
        InlineResponse20032 TokensGetPartnerOfferSkuHistory (int? partnerApplicationId, long? targetBnetMembershipId);
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class TokensApi : ITokensApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TokensApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public TokensApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient; 
            else
                this.ApiClient = apiClient;
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="TokensApi"/> class.
        /// </summary>
        /// <returns></returns>
        public TokensApi(String basePath)
        {
            this.ApiClient = new ApiClient(basePath);
        }
    
        /// <summary>
        /// Sets the base path of the API client.
        /// </summary>
        /// <param name="basePath">The base path</param>
        /// <value>The base path</value>
        public void SetBasePath(String basePath)
        {
            this.ApiClient.BasePath = basePath;
        }
    
        /// <summary>
        /// Gets the base path of the API client.
        /// </summary>
        /// <param name="basePath">The base path</param>
        /// <value>The base path</value>
        public String GetBasePath(String basePath)
        {
            return this.ApiClient.BasePath;
        }
    
        /// <summary>
        /// Gets or sets the API client.
        /// </summary>
        /// <value>An instance of the ApiClient</value>
        public ApiClient ApiClient {get; set;}
    
        /// <summary>
        ///  Apply a partner offer to the targeted user. This endpoint does not claim a new offer, but any already claimed offers will be applied to the game if not already.
        /// </summary>
        /// <param name="partnerApplicationId">The partner application identifier.</param> 
        /// <param name="targetBnetMembershipId">The bungie.net user to apply missing offers to. If not self, elevated permissions are required.</param> 
        /// <returns>InlineResponse20017</returns>            
        public InlineResponse20017 TokensApplyMissingPartnerOffersWithoutClaim (int? partnerApplicationId, long? targetBnetMembershipId)
        {
            
            // verify the required parameter 'partnerApplicationId' is set
            if (partnerApplicationId == null) throw new ApiException(400, "Missing required parameter 'partnerApplicationId' when calling TokensApplyMissingPartnerOffersWithoutClaim");
            
            // verify the required parameter 'targetBnetMembershipId' is set
            if (targetBnetMembershipId == null) throw new ApiException(400, "Missing required parameter 'targetBnetMembershipId' when calling TokensApplyMissingPartnerOffersWithoutClaim");
            
    
            var path = "/Tokens/Partner/ApplyMissingOffers/{partnerApplicationId}/{targetBnetMembershipId}/";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "partnerApplicationId" + "}", ApiClient.ParameterToString(partnerApplicationId));
path = path.Replace("{" + "targetBnetMembershipId" + "}", ApiClient.ParameterToString(targetBnetMembershipId));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                                    
            // authentication setting, if any
            String[] authSettings = new String[] { "oauth2" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling TokensApplyMissingPartnerOffersWithoutClaim: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling TokensApplyMissingPartnerOffersWithoutClaim: " + response.ErrorMessage, response.ErrorMessage);
    
            return (InlineResponse20017) ApiClient.Deserialize(response.Content, typeof(InlineResponse20017), response.Headers);
        }
    
        /// <summary>
        ///  Claim a partner offer as the authenticated user.
        /// </summary>
        /// <returns>InlineResponse20017</returns>            
        public InlineResponse20017 TokensClaimPartnerOffer ()
        {
            
    
            var path = "/Tokens/Partner/ClaimOffer/";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                                    
            // authentication setting, if any
            String[] authSettings = new String[] { "oauth2" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling TokensClaimPartnerOffer: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling TokensClaimPartnerOffer: " + response.ErrorMessage, response.ErrorMessage);
    
            return (InlineResponse20017) ApiClient.Deserialize(response.Content, typeof(InlineResponse20017), response.Headers);
        }
    
        /// <summary>
        ///  Returns the partner sku and offer history of the targeted user. Elevated permissions are required to see users that are not yourself.
        /// </summary>
        /// <param name="partnerApplicationId">The partner application identifier.</param> 
        /// <param name="targetBnetMembershipId">The bungie.net user to apply missing offers to. If not self, elevated permissions are required.</param> 
        /// <returns>InlineResponse20032</returns>            
        public InlineResponse20032 TokensGetPartnerOfferSkuHistory (int? partnerApplicationId, long? targetBnetMembershipId)
        {
            
            // verify the required parameter 'partnerApplicationId' is set
            if (partnerApplicationId == null) throw new ApiException(400, "Missing required parameter 'partnerApplicationId' when calling TokensGetPartnerOfferSkuHistory");
            
            // verify the required parameter 'targetBnetMembershipId' is set
            if (targetBnetMembershipId == null) throw new ApiException(400, "Missing required parameter 'targetBnetMembershipId' when calling TokensGetPartnerOfferSkuHistory");
            
    
            var path = "/Tokens/Partner/History/{partnerApplicationId}/{targetBnetMembershipId}/";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "partnerApplicationId" + "}", ApiClient.ParameterToString(partnerApplicationId));
path = path.Replace("{" + "targetBnetMembershipId" + "}", ApiClient.ParameterToString(targetBnetMembershipId));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                                    
            // authentication setting, if any
            String[] authSettings = new String[] { "oauth2" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling TokensGetPartnerOfferSkuHistory: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling TokensGetPartnerOfferSkuHistory: " + response.ErrorMessage, response.ErrorMessage);
    
            return (InlineResponse20032) ApiClient.Deserialize(response.Content, typeof(InlineResponse20032), response.Headers);
        }
    
    }
}
