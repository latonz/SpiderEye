﻿using System;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace SpiderEye.Bridge.Models
{
    internal class ApiResultModel
    {
        [JsonIgnore]
        public string Value
        {
            get { return ValueRaw?.Value as string; }
            set { ValueRaw = value == null ? null : new JRaw(value); }
        }

        public bool Success { get; set; }
        public string Error { get; set; }
        public string ErrorTypeName { get; set; }
        public string ErrorTypeFullName { get; set; }
        public string ErrorDetail { get; set; }

        [JsonProperty(nameof(Value))]
        private JRaw ValueRaw { get; set; }

        public static ApiResultModel FromError(string message)
        {
            return new ApiResultModel
            {
                Value = null,
                Success = false,
                Error = message,
            };
        }

        public static ApiResultModel FromError(Exception exception)
        {
            return new ApiResultModel
            {
                Value = null,
                Success = false,
                Error = exception.Message,
                ErrorTypeName = exception.GetType().Name,
                ErrorTypeFullName = exception.GetType().FullName,
                ErrorDetail = exception.ToString(),
            };
        }
    }
}
