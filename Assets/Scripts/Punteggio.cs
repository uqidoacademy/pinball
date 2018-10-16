using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Punteggio {
    private int puntiGiocatore = 0;

    public Punteggio(int points)
    {
        puntiGiocatore = points;
    }


   public int Punti
   {
       get { return puntiGiocatore; }
       set {
          if (value >= 0)
            puntiGiocatore = value;
          else 
           Debug.Log("ATTENZIONE MAGGIORE di 0 punti");
       }
   }//Punti

}//Punteggio