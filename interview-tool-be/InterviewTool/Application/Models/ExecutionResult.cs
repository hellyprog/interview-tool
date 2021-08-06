namespace InterviewTool.Application.Models
{
    public class ExecutionResult
    {
        public bool Success { get; protected set; }
        public string ErrorMessage { get; protected set; }
        public int? ExecutionCode { get; protected set; }

        public static ExecutionResult FromSuccess(int? executionCode = null)
        {
            return new ExecutionResult
            {
                ExecutionCode = executionCode,
                Success = true
            };
        }

        public static ExecutionResult FromFailure(string errorMessage, int? executionCode = null)
        {
            return new ExecutionResult
            {
                ExecutionCode = executionCode,
                ErrorMessage = errorMessage,
                Success = false
            };
        }
    }
}
