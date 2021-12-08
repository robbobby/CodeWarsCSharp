using System;
using System.Collections.Generic;

namespace CodeWarsCSharp {
    class Program {
        static void Main(string[] args) {
            var x = ListFilterer.GetIntegersFromList(new List<object>(){1, 2, "a", "b"});
            Console.WriteLine(x.Count.ToString());
            x = ListFilterer.GetIntegersFromList(new List<object>(){1, 2, "a", "b", 0, 15});
            Console.WriteLine(x.Count.ToString());
            x = ListFilterer.GetIntegersFromList(new List<object>(){1, 2, "a", "b", "aasf", "1", "123", 231});
            Console.WriteLine(x.Count.ToString());
            x = ListFilterer.GetIntegersFromList(new List<object>(){1, 2, "a", "b"});
            Console.WriteLine(x.Count.ToString());
        }
    }
}
