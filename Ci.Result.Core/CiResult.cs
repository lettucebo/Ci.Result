namespace Ci.Result.Core
{
    /// <summary>
    /// Execution result container
    /// </summary>
    public class CiResult
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Ci.Result"/> class.
        /// </summary>
        public CiResult()
        {
            Result = Result.Fail;
        }

        /// <summary>
        /// Execution result
        /// </summary>
        public Result Result { get; set; }

        /// <summary>
        /// Execution message
        /// </summary>
        public string Message { get; set; }
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
        public T Data { get; set; }
    }
}
