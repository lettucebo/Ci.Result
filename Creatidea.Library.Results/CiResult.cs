namespace Creatidea.Library.Results
{
    /// <summary>
    /// 執行結果
    /// </summary>
    public class CiResult
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CiResult"/> class.
        /// </summary>
        public CiResult()
        {
            Result = Result.Fail;
        }

        /// <summary>
        /// 是否執行成功
        /// </summary>
        public Result Result { get; set; }

        /// <summary>
        /// 執行訊息
        /// </summary>
        public string Message { get; set; }
    }

    /// <summary>
    /// 執行結果
    /// </summary>
    /// <typeparam name="T">泛型回傳</typeparam>
    /// <seealso cref="CiResult" />
    public class CiResult<T> : CiResult
    {
        /// <summary>
        /// 結果物件
        /// </summary>
        public T Data { get; set; }
    }
}
