﻿using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Text.Json.Serialization;

namespace BTCPrice.Model
{
    public class DataWrapper
    {
        [JsonPropertyName("BTC-EUR")]
        public Data BtcEur { get; set; }

    }
}
