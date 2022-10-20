﻿using System.Threading.Tasks;
using PrintfulLib.Models.ApiRequest;
using PrintfulLib.Models.ApiRequest.FileLibrary;
using PrintfulLib.Models.ApiRequest.Order;
using PrintfulLib.Models.ApiRequest.Product;
using PrintfulLib.Models.ApiRequest.Shipping;
using PrintfulLib.Models.ApiRequest.StoreInformation;
using PrintfulLib.Models.ApiRequest.Taxes;
using PrintfulLib.Models.ApiRequest.WarehouseProducts;
using PrintfulLib.Models.ApiRequest.WarehouseShipments;
using PrintfulLib.Models.ApiRequest.WebhookSetup;
using PrintfulLib.Models.ApiResponse.Country;
using PrintfulLib.Models.ApiResponse.FileLibrary;
using PrintfulLib.Models.ApiResponse.Order;
using PrintfulLib.Models.ApiResponse.Product;
using PrintfulLib.Models.ApiResponse.Shipping;
using PrintfulLib.Models.ApiResponse.StoreInformation;
using PrintfulLib.Models.ApiResponse.Taxes;
using PrintfulLib.Models.ApiResponse.WarehouseProducts;
using PrintfulLib.Models.ApiResponse.WarehouseShipments;
using PrintfulLib.Models.ApiResponse.WebhookSetup;

namespace PrintfulLib.Interfaces.ExternalClients
{
    public interface IPrintfulClient
    {
        Task<GetRequiredTaxStatesResponse> GetRequiredTaxStates();
        Task<CalculateTaxRateResponse> CalculateTaxRate(TaxRequest taxRequest);
        Task<CalculateShippingRatesResponse> CalculateShippingRates(ShippingRequest shippingRequest);
        Task<GetCountryListResponse> GetCountryList();
        Task<GetStoreInformationResponse> GetStoreInformation();
        Task<ChangePackingSlipResponse> ChangePackingSlip(ChangePackingSlipRequest request);
        Task<GetWarehouseProductsResponse> GetWarehouseProducts(GetWarehouseProductsRequest request);
        Task<GetWarehouseProductDataResponse> GetWarehouseProductData(GetWarehouseProductDataRequest request);
        Task<CreateWarehouseProductResponse> CreateWarehouseProduct(CreateWarehouseProductRequest request);
        Task<GetWarehouseShipmentsResponse> GetWarehouseShipments(GetWarehouseShipmentsRequest request);

        Task<GetWarehouseShipmentDataResponse> GetWarehouseShipmentData(
            GetWarehouseShipmentDataRequest request);

        Task<CreateWarehouseShipmentResponse> CreateWarehouseShipment(
            CreateWarehouseShipmentRequest request);

        Task<GetFilesResponse> GetFiles(GetFilesRequest request);
        Task<GetFileInformationResponse> GetFileInformation(GetFileInformationRequest request);
        Task<AddFileResponse> AddFile(AddFileRequest request);
        Task<GetSyncProductsResponse> GetProducts(GetProductsRequest request);
        Task<GetProductAndVariantsResponse> GetProductAndVariants(GetProductAndVariantsRequest request);
        Task<CreateNewProductResponse> CreateProduct(CreateNewProductRequest request);
        Task<DeleteProductResponse> DeleteProduct(DeleteProductRequest request);
        Task<ModifyProductResponse> ModifyProduct(ModifyProductRequest request);
        Task<CreateNewSyncVariantResponse> CreateNewSyncVariant(CreateNewSyncVariantRequest request);
        Task<GetSyncVariantInformationResponse> GetSyncVariantInfo(
            GetSyncVariantInformationRequest request);

        Task<DeleteSyncVariantResponse> DeleteSyncVariant(DeleteSyncVariantRequest request);
        Task<ModifySyncVariantResponse> ModifySyncVariant(ModifySyncVariantRequest request);
        Task<GetOrdersResponse> GetOrders(GetOrdersRequest request);
        Task<CreateNewOrderResponse> CreateOrder(CreateNewOrderRequest request);
        Task<EstimateCostsResponse> EstimateCosts(EstimateCostsRequest request);
        Task<GetOrderDataResponse> GetOrder(GetOrderDataRequest request);
        Task<CancelOrderResponse> CancelOrder(CancelOrderRequest request);
        Task<UpdateOrderDataResponse> UpdateOrderData(UpdateOrderDataRequest request);
        Task<ConfirmDraftResponse> ConfirmDraftForFulfillment(ConfirmDraftRequest request);
        Task<WebhookConfigurationResponse> GetWebhookConfiguration();
        Task<WebhookConfigurationResponse> SetWebhookConfiguration(SetUpWebhookConfigurationRequest request);
        Task<WebhookConfigurationResponse> DisableWebhookConfiguration();
    }
}