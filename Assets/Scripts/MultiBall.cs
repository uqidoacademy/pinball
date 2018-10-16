using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MultiBall : MonoBehaviour {

    private GameObject newBall;

    private void OnCollisionEnter (Collision collision) {
        ContatorePalline.aggiungiPalline ();
        newBall = Instantiate (collision.gameObject, collision.gameObject.transform.position, collision.gameObject.transform.rotation);
    }

}