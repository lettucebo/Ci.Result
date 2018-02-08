namespace Ci.Result
{
    /// <summary>
    /// 執行結果
    /// </summary>
    public class Result
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Result"/> class.
        /// </summary>
        public Result()
        {
            Status = Status.Fail;
        }

        /// <summary>
        /// 是否執行成功
        /// </summary>
        public Status Status { get; set; }

        /// <summary>
        /// 執行訊息
        /// </summary>
        public string Message { get; set; }
    }

    /// <summary>
    /// 執行結果
    /// </summary>
    /// <typeparam name="T">泛型回傳</typeparam>
    /// <seealso cref="Result" />
    public class Result<T> : Result
    {
        /// <summary>
        /// 結果物件
        /// </summary>
        public T Data { get; set; }
    }
}
