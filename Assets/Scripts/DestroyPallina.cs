using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyPallina : MonoBehaviour {

    private void OnCollisionEnter(Collision collision)
    {                               
        Destroy(collision.gameObject);      //Destroy pallina in collisione e decrementa il contatore di uno
        ContatorePalline.rimuoviPalline(1);
    }
}
