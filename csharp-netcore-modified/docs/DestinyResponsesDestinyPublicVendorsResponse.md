# BungieNetApi.Model.DestinyResponsesDestinyPublicVendorsResponse
A response containing all valid components for the public Vendors endpoint.   It is a decisively smaller subset of data compared to what we can get when we know the specific user making the request.   If you want any of the other data - item details, whether or not you can buy it, etc... you'll have to call in the context of a character. I know, sad but true.
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**VendorGroups** | [**SingleComponentResponseOfDestinyVendorGroupComponent**](SingleComponentResponseOfDestinyVendorGroupComponent.md) | For Vendors being returned, this will give you the information you need to group them and order them in the same way that the Bungie Companion app performs grouping. It will automatically be returned if you request the Vendors component.  COMPONENT TYPE: Vendors | [optional] 
**Vendors** | [**DictionaryComponentResponseOfint64AndDestinyPublicVendorComponent**](DictionaryComponentResponseOfint64AndDestinyPublicVendorComponent.md) | The base properties of the vendor. These are keyed by the Vendor Hash, so you will get one Vendor Component per vendor returned.  COMPONENT TYPE: Vendors | [optional] 
**Categories** | [**DictionaryComponentResponseOfint64AndDestinyVendorCategoriesComponent**](DictionaryComponentResponseOfint64AndDestinyVendorCategoriesComponent.md) | Categories that the vendor has available, and references to the sales therein. These are keyed by the Vendor Hash, so you will get one Categories Component per vendor returned.  COMPONENT TYPE: VendorCategories | [optional] 
**Sales** | [**DictionaryComponentResponseOfint64AndPublicDestinyVendorSaleItemSetComponent**](DictionaryComponentResponseOfint64AndPublicDestinyVendorSaleItemSetComponent.md) | Sales, keyed by the vendorItemIndex of the item being sold. These are keyed by the Vendor Hash, so you will get one Sale Item Set Component per vendor returned.  Note that within the Sale Item Set component, the sales are themselves keyed by the vendorSaleIndex, so you can relate it to the corrent sale item definition within the Vendor&#39;s definition.  COMPONENT TYPE: VendorSales | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

