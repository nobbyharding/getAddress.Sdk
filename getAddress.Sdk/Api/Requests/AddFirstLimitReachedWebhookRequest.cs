﻿using Newtonsoft.Json;
using System;


namespace getAddress.Sdk.Api.Requests
{
    public class AddFirstLimitReachedWebhookRequest
    {
        [JsonProperty("url")]
        public string Url
        {
            get;
        }
        public AddFirstLimitReachedWebhookRequest(string url)
        {
            Url = url;
        }
    }
}
