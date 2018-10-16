using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RuotaPianoInizioGioco : MonoBehaviour {

	// Use this for initialization

	public float AngoloRotazionePinball=80f;

	void Start () {
		// ruoto il piano rendendolo inclinato
		this.transform.eulerAngles = new Vector3(-AngoloRotazionePinball,0,0);
	}

}
