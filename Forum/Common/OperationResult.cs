using Newtonsoft.Json;
using System.Runtime.Serialization;

namespace Forum.Models
{
    [DataContract]
    public class OperationResult
    {
        [DataMember]
        [JsonProperty("result_code")]
        private int ResultCode { get; set; }

        [DataMember] private string Message { get; set; }

        public OperationResult()
        {
        }

        public OperationResult(int resultCode, string message)
        {
            ResultCode = resultCode;
            Message = message;
        }

        internal static OperationResult Ok { get; } = new()
        {
            ResultCode = (int)OperationResultStatus.OK,
            Message = OperationResultStatus.OK.ToString()
        };

        internal static OperationResult Created { get; } = new()
        {
            ResultCode = (int)OperationResultStatus.Created,
            Message = OperationResultStatus.Created.ToString()
        };

        internal static OperationResult BadRequest { get; } = new()
        {
            ResultCode = (int)OperationResultStatus.BadRequest,
            Message = OperationResultStatus.BadRequest.ToString()
        };

        internal static OperationResult Unauthorized { get; } = new()
        {
            ResultCode = (int)OperationResultStatus.Unauthorized,
            Message = OperationResultStatus.Unauthorized.ToString()
        };

        internal static OperationResult Forbidden { get; } = new()
        {
            ResultCode = (int)OperationResultStatus.Forbidden,
            Message = OperationResultStatus.Forbidden.ToString()
        };

        internal static OperationResult NotFound { get; } = new()
        {
            ResultCode = (int)OperationResultStatus.NotFound,
            Message = OperationResultStatus.NotFound.ToString()
        };

        internal static OperationResult InteralError { get; } = new()
        {
            ResultCode = (int)OperationResultStatus.InternalError,
            Message = OperationResultStatus.InternalError.ToString()
        };

        internal static OperationResult InteralErrorWithMessage(string message)
        {
            return new OperationResult
            {
                ResultCode = (int)OperationResultStatus.InternalError,
                Message = message
            };
        }

        internal static OperationResult OkWithMessage(string message)
        {
            return new OperationResult
            {
                ResultCode = (int)OperationResultStatus.OK,
                Message = message
            };
        }

        internal static OperationResult ManyRequest { get; } = new()
        {
            ResultCode = (int)OperationResultStatus.ManyRequest,
            Message = OperationResultStatus.ManyRequest.ToString()
        };

        internal static OperationResult GeneralErrorWithMessage(string message)
        {
            return new OperationResult
            {
                ResultCode = (int)OperationResultStatus.GeneralError,
                Message = message
            };
        }

     
        public override string ToString()
        {
            return "Result Code: " + ResultCode + " " + "Message: " + Message;
        }
    }

    public enum OperationResultStatus
    {
        OK = 200,
        Created = 201,
        BadRequest = 400,
        Unauthorized = 401,
        Forbidden = 403,
        NotFound = 404,
        InternalError = 500,
        ManyRequest = 429,
        GeneralError = -1,
       
    }
}