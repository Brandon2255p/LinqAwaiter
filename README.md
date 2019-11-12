# LinqAwaiter
Shorter version to wait on all tasks in a list
```
        static async Task Main(string[] args)
        {
            var list = new List<int> { 1, 5, 3, 10, 55, 6 };
            var tasks = list.Select(async x => await Foo(x));
            var results = await Task.WhenAll(tasks);
            foreach(var num in results)
            {
                Console.WriteLine(num);
            }

            var tasks2 = list.Select(async x => await Foo(x));
            var res2 = await tasks2.AwaiterAsync();
            foreach (var num in res2)
            {
                Console.WriteLine(num);
            }
        }
```