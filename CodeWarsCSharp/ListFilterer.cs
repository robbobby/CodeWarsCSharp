using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualBasic.CompilerServices;
namespace CodeWarsCSharp {
    public static class ListFilterer {

        public static List<int> GetIntegersFromList(List<object> objects) {
            var listOfNumbers = new List<int>();
            foreach (var item in objects.Where(item => item is int)) {
                Console.WriteLine(item);
                listOfNumbers.Add((int)item);
            }
            return listOfNumbers;
        }
    }
}
