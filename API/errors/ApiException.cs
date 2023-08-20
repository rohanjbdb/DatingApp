using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.errors
{
    public class ApiException
    {
        public ApiException(int statuscode, string message, string details)
        {
            StatusCode = statuscode;
            Message = message;
            Details = details;
        }

        public int StatusCode { get; set; }

        public string Message { get; set; }

        public string Details { get; set; }
    }
}