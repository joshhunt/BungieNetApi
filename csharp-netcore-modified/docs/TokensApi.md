# BungieNetApi.Api.TokensApi

All URIs are relative to *https://www.bungie.net/Platform*

Method | HTTP request | Description
------------- | ------------- | -------------
[**TokensApplyMissingPartnerOffersWithoutClaim**](TokensApi.md#tokensapplymissingpartnerofferswithoutclaim) | **POST** /Tokens/Partner/ApplyMissingOffers/{partnerApplicationId}/{targetBnetMembershipId}/ | 
[**TokensClaimPartnerOffer**](TokensApi.md#tokensclaimpartneroffer) | **POST** /Tokens/Partner/ClaimOffer/ | 
[**TokensGetPartnerOfferSkuHistory**](TokensApi.md#tokensgetpartnerofferskuhistory) | **GET** /Tokens/Partner/History/{partnerApplicationId}/{targetBnetMembershipId}/ | 


<a name="tokensapplymissingpartnerofferswithoutclaim"></a>
# **TokensApplyMissingPartnerOffersWithoutClaim**
> InlineResponse20017 TokensApplyMissingPartnerOffersWithoutClaim (int partnerApplicationId, long targetBnetMembershipId)



Apply a partner offer to the targeted user. This endpoint does not claim a new offer, but any already claimed offers will be applied to the game if not already.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using BungieNetApi.Api;
using BungieNetApi.Client;
using BungieNetApi.Model;

namespace Example
{
    public class TokensApplyMissingPartnerOffersWithoutClaimExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://www.bungie.net/Platform";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new TokensApi(config);
            var partnerApplicationId = 56;  // int | The partner application identifier.
            var targetBnetMembershipId = 789;  // long | The bungie.net user to apply missing offers to. If not self, elevated permissions are required.

            try
            {
                InlineResponse20017 result = apiInstance.TokensApplyMissingPartnerOffersWithoutClaim(partnerApplicationId, targetBnetMembershipId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TokensApi.TokensApplyMissingPartnerOffersWithoutClaim: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **partnerApplicationId** | **int**| The partner application identifier. | 
 **targetBnetMembershipId** | **long**| The bungie.net user to apply missing offers to. If not self, elevated permissions are required. | 

### Return type

[**InlineResponse20017**](InlineResponse20017.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: */*

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Look at the Response property for more information about the nature of this response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="tokensclaimpartneroffer"></a>
# **TokensClaimPartnerOffer**
> InlineResponse20017 TokensClaimPartnerOffer ()



Claim a partner offer as the authenticated user.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using BungieNetApi.Api;
using BungieNetApi.Client;
using BungieNetApi.Model;

namespace Example
{
    public class TokensClaimPartnerOfferExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://www.bungie.net/Platform";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new TokensApi(config);

            try
            {
                InlineResponse20017 result = apiInstance.TokensClaimPartnerOffer();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TokensApi.TokensClaimPartnerOffer: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**InlineResponse20017**](InlineResponse20017.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: */*

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Look at the Response property for more information about the nature of this response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="tokensgetpartnerofferskuhistory"></a>
# **TokensGetPartnerOfferSkuHistory**
> InlineResponse20032 TokensGetPartnerOfferSkuHistory (int partnerApplicationId, long targetBnetMembershipId)



Returns the partner sku and offer history of the targeted user. Elevated permissions are required to see users that are not yourself.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using BungieNetApi.Api;
using BungieNetApi.Client;
using BungieNetApi.Model;

namespace Example
{
    public class TokensGetPartnerOfferSkuHistoryExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://www.bungie.net/Platform";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new TokensApi(config);
            var partnerApplicationId = 56;  // int | The partner application identifier.
            var targetBnetMembershipId = 789;  // long | The bungie.net user to apply missing offers to. If not self, elevated permissions are required.

            try
            {
                InlineResponse20032 result = apiInstance.TokensGetPartnerOfferSkuHistory(partnerApplicationId, targetBnetMembershipId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TokensApi.TokensGetPartnerOfferSkuHistory: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **partnerApplicationId** | **int**| The partner application identifier. | 
 **targetBnetMembershipId** | **long**| The bungie.net user to apply missing offers to. If not self, elevated permissions are required. | 

### Return type

[**InlineResponse20032**](InlineResponse20032.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: */*

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Look at the Response property for more information about the nature of this response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

