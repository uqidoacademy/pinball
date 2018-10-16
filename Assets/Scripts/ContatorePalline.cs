using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ContatorePalline {

    public static int contatorePalline = 0;

    public static void rimuoviPalline()
    {
        contatorePalline -= 1;
    }

    public static void aggiungiPalline()
    {
        contatorePalline += 1;
    }
}
