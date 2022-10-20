﻿using Newtonsoft.Json;
using PrintfulLib.Models.ChildObjects;

namespace PrintfulLib.Models.ApiResponse.WarehouseShipments
{
    public class GetWarehouseShipmentsResponse : PrintfulApiResponseBaseModel
    {
        [JsonProperty("result")]
        public WarehouseShipment[] WarehouseShipments { get; set; }

        [JsonProperty("paging")]
        public ApiPaging ApiPaging { get; set; }
    }
}