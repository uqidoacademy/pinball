using System.Collections;
using System.Collections.Generic;
using UnityEngine;
	
	public class InputController : MonoBehaviour {

		public GameObject stickFather;
		Animator anim;
		public KeyCode keyCode;

		// Use this for initialization
		void Start () {
			anim = stickFather.GetComponent<Animator>();
		}
		
		// Update is called once per frame
		void Update () {
			if(Input.GetKeyDown(keyCode)) {
				anim.SetBool("Press", true);
			}

			if(Input.GetKeyUp(keyCode)) {
				anim.SetBool("Press", false);
			}
		}
		
		void OnCollisionEnter(Collision col)
		{
			if(anim.GetBool("Press")) {
				col.gameObject.GetComponent<Rigidbody>().AddForce(new Vector3(gameObject.transform.forward.normalized.x, 
				gameObject.transform.forward.normalized.y, gameObject.transform.forward.normalized.z) * 25, ForceMode.Impulse);
			}
		}

	}
