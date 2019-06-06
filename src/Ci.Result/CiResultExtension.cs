namespace Ci.Result
{
    /// <summary>
    /// Extension method for <see cref="CiResult"/>
    /// </summary>
    public static class CiResultExtension
    {
        /// <summary>
        /// Chceck is Message have any string 
        /// </summary>
        /// <param name="result"><see cref="CiResult"/></param>
        /// <returns></returns>
        public static bool HasMessage(this CiResult result)
        {
            return !string.IsNullOrWhiteSpace(result.Message);
        }

        /// <summary>
        /// Check is <see cref="CiResult.Status"/> is represent a good status
        /// </summary>
        /// <param name="result"></param>
        /// <returns></returns>
        public static bool IsGoodStatus(this CiResult result)
        {
            return result.Status == CiStatus.Success;
        }

        /// <summary>
        /// Check is <see cref="CiResult.Status"/> is represent a bad status
        /// </summary>
        /// <param name="result"></param>
        /// <returns></returns>
        public static bool IsBadStatus(this CiResult result)
        {
            return !IsGoodStatus(result);
        }
    }
}
