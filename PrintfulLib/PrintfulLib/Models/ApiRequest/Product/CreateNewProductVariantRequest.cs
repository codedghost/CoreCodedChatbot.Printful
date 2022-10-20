﻿using PrintfulLib.Models.ChildObjects;

namespace PrintfulLib.Models.ApiRequest.Product
{
    public class CreateNewProductVariantRequest
    {
        public int ProductId { get; set; }
        public string ExternalId { get; set; }
        public RequestVariant NewProduct { get; set; }
    }
}