/*
Description

Deoxyribonucleic acid (DNA) is a chemical found in the nucleus of cells and carries the "instructions" for the 
development and functioning of living organisms.

If you want to know more: http://en.wikipedia.org/wiki/DNA

In DNA strings, symbols "A" and "T" are complements of each other, as "C" and "G". Your function receives one 
side of the DNA (string, except for Haskell); you need to return the other complementary side. DNA strand is never 
empty or there is no DNA at all (again, except for Haskell).

More similar exercise are found here: http://rosalind.info/problems/list-view/ (source)

Example: (input --> output)
"ATTGC" --> "TAACG"
"GTAT" --> "CATA"
*/

public class DnaStrand 
{
  public static string MakeComplement(string dna)
  {
    char[] complement = new char[dna.Length];

    for (int i = 0; i < dna.Length; i++)
    {
        switch (dna[i])
        {
            case 'A':
                complement[i] = 'T';
                break;
            case 'T':
                complement[i] = 'A';
                break;
            case 'C':
                complement[i] = 'G';
                break;
            case 'G':
                complement[i] = 'C';
                break;
            default:
                complement[i] = '?';
                break;
        }
    }

    return new string(complement);
  }
}