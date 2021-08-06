namespace InterviewTool.Application.Models
{
    public class ExecutionResult<T> : ExecutionResult
    {
        public T Data { get; protected set; }

        public static ExecutionResult<T> FromSuccess(T data, int? executionCode = null)
        {
            return new ExecutionResult<T>
            {
                Data = data,
                Success = true,
                ExecutionCode = executionCode
            };
        }

        public new static ExecutionResult<T> FromFailure(string errorMessage, int? executionCode = null)
        {
            return new ExecutionResult<T>
            {
                ExecutionCode = executionCode,
                ErrorMessage = errorMessage,
                Success = false
            };
        }
    }
}
