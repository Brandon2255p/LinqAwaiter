using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace LinqAwaiter
{
    public static partial class Enumerable
    {
        public static async Task<TSource[]> AwaiterAsync<TSource>(this IEnumerable<Task<TSource>> source)
        {
            //if (source == null)
            //{
            //    ThrowHelper.ThrowArgumentNullException(ExceptionArgument.source);
            //}
            var result = await Task.WhenAll(source);
          
            return result;
        }
    }
}