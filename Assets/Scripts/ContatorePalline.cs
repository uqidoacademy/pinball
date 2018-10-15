using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ContatorePalline {

    public static int contatorePalline = 0;

    public static void rimuoviPalline(int numPalline)
    {
        contatorePalline -= numPalline;
    }

    public static void aggiungiPalline(int numPalline)
    {
        contatorePalline += numPalline;
    }
}
