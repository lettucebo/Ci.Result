namespace Ci.Result
{
    /// <summary>
    /// Execution result container
    /// </summary>
    public class CiResult
    {
        /// <summary>
        /// Execution result
        /// </summary>
        public CiStatus Status { get; set; } = CiStatus.Failure;

        /// <summary>
        /// Execution message
        /// </summary>
        public string Message { get; set; } = string.Empty;
    }

    /// <summary>
    /// Execution result container
    /// </summary>
    /// <typeparam name="T">Execution return data</typeparam>
    /// <seealso cref="Result" />
    public class CiResult<T> : CiResult
    {
        /// <summary>
        /// Execution return data
        /// </summary>
        public T Payload { get; set; }
    }
}
