using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnPalline : MonoBehaviour{

    //GameObject contenente lo script del gestore numero palline
   
   
   

    public void Spawn(GameObject myPrefab)
    {
        GameObject spawnObject = (GameObject)Instantiate(myPrefab, transform.position, transform.rotation);
        spawnObject.transform.parent = gameObject.transform.parent;
        ContatorePalline.aggiungiPalline(1);
    }
}
