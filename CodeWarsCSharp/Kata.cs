using System.Collections.Generic;

public class Kata {
    public static IEnumerable<string> OpenOrSenior(int[][] data) {
        foreach (int[] member in data) {
            if (member[0] >= 55 && member[1] > 7)
                yield return "Senior";
            else 
                yield return "Open";
        }
    }
}
