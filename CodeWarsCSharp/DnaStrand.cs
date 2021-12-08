using System;
public class DnaStrand {
    public static string MakeComplement(string dna) {
        string returnValue = "";
        foreach (var character in dna) {
            switch (character) {
                case 'A':
                    returnValue += 'T';
                    break;
                case 'T':
                    returnValue += 'A';
                    break;
                case 'G':
                    returnValue += 'C';
                    break;
                case 'C':
                    returnValue += 'G';
                    break;
                default:
                    returnValue += character;
                    break;
            }
        }
        return returnValue;
    }
}
