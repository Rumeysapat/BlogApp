using Blog.Shared.Utilities.Results.Abstract;
using Blog.Shared.Utilities.Results.ComplexTypes;

namespace Blog.Data.Shared.Utilities.Results.Concrete
{
    public class DataResult<T> : IDataResult<T>
    {
        public DataResult(ResultStatus resultStatus, T data)
        {
            ResultStatus = resultStatus;
            Data = data;

        }
         public DataResult(ResultStatus resultStatus,string message,  T data)
        {
            ResultStatus = resultStatus;
            Message = message;
            Data = data;
            
        }
         public DataResult(ResultStatus resultStatus,string message,  T data,Exception exception)
        {
            ResultStatus = resultStatus;
            Message = message;
            Data = data;
            Exception = exception;
            
        }

        public T Data { get; }

        public ResultStatus ResultStatus { get; }

        public string Message { get; }
        public Exception Exception { get; }

    }
}