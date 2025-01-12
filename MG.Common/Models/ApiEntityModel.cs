﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Knus.Common.Models
{
    public class ApiEntityModel<T>
    {
		public bool HasError { get; set; } = true;
		public bool HasAlert { get; set; } = true;
		public bool Success { get; set; } = true;
		public string HttpCode { get; set; } = "";
        public string Message { get; set; } = "";
		public T OutValue { get; set; }
        public string StringOutValue { get; set; } = "";
		public string SendValue { get; set; } = "";

		public string SystemMessage { get; set; } = "";

		public ErrorModel ErrorModel { get; set; } = new();
    }
    public class ErrorModel
    {
		public int ResultCode { get; set; } = 0;
        public string Error { get; set; } = "";
    }
}
