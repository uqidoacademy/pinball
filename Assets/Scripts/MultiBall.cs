using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MultiBall : MonoBehaviour {
    private bool readyToSpawn = true;
    private GameObject newBall;

    private void OnCollisionEnter (Collision collision) {
        if (readyToSpawn)
        {
            ContatorePalline.aggiungiPalline();
            newBall = Instantiate(collision.gameObject, collision.gameObject.transform.position, collision.gameObject.transform.rotation);
            StartCoroutine(WaitForSpawn());
        }
    }
    IEnumerator WaitForSpawn()
    {
        readyToSpawn = false;
        yield return new WaitForSeconds(1);
        readyToSpawn = true;
    }
}