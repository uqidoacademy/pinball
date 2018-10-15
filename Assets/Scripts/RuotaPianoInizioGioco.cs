using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RuotaPianoInizioGioco : MonoBehaviour {

	// Use this for initialization
	void Start () {
		// ruoto il piano rendendolo inclinato
		this.transform.eulerAngles = new Vector3(-80f,0,0);
	}

}
