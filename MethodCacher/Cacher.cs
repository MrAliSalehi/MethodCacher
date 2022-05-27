namespace MethodCacher
{
    /// <summary>
    /// Cacher is The Class That Help Your To Cache Your Methods With Specific Input And Output
    /// </summary>
    /// <typeparam name="TIn">Input of your method</typeparam>
    /// <typeparam name="TOut">result of your method</typeparam>
    public sealed class Cacher<TIn, TOut> where TIn : notnull
    {
        private readonly Func<TIn, TOut> _func;
        private readonly Dictionary<TIn, TOut> _tDictionary = new();
        /// <summary>
        /// Create The Cacher To Handle All your Methods With The Same TIn And TOut
        /// </summary>
        /// <param name="func">Pass Down Your Target Method.</param>
        public Cacher(Func<TIn, TOut> func) => _func = func;
        /// <summary>
        /// Try To Run Method,If Its Already Executed,If Will Return The Cached TOut. Other vise Will Execute The Method.
        /// </summary>
        /// <param name="tin">Input Of Your Method That Your Specified</param>
        /// <returns>Output Of Your Method.</returns>
        public TOut Invoke(TIn tin) => _tDictionary.TryGetValue(tin, out var value) ? value : _tDictionary[tin] = _func(tin);

    }
}