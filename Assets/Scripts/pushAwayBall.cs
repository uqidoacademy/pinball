using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pushAwayBall : MonoBehaviour {

    public enum dimensioniBumper { small = 1, medium = 2, big = 3 };
    public dimensioniBumper dimensioneDelBumper;
    public void OnCollisionEnter (Collision pallina) {

        if (pallina.collider.tag == ("pallina")) {
            Vector3 force = pallina.transform.position - transform.position + new Vector3 (Random.Range (10.0f, 20.0f), Random.Range (10.0f, 20.0f), Random.Range (10.0f, 20.0f));
            force.Normalize ();
            pallina.gameObject.GetComponent<Rigidbody> ().AddForce (force * Random.Range (1000, 1500));
            //TODO aggiungo segnalazione AGGIUNTA punteggio
            gameManager.I.AddPoints (100 * (int) dimensioneDelBumper);
            Debug.Log ((int) dimensioneDelBumper);

        } //if pallina

    } //OnCollisionEnter

} //pushAwayBall