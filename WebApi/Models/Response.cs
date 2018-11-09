using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApi.Models
{
    public enum ResponseCodes
    {
        SUCCESS = 0,
        FAIL = 1
    }

    public class Response
    {
        public ResponseCodes code;
    }

    public class SuccessResponse: Response
    {
        public Array results;

        public SuccessResponse()
        {
            code = ResponseCodes.SUCCESS;
        }
    }

    public class FailureResponse : Response
    {
        public string message;
        public string innerMessage;

        public FailureResponse()
        {
            code = ResponseCodes.FAIL;
        }
    }
}