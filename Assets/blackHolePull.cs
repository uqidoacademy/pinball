using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class blackHolePull : MonoBehaviour {

	void OnTriggerEnter (Collider collider) {
		collider.GetComponent<Rigidbody> ().isKinematic = true;
		StartCoroutine(AnimateMove( collider.transform.localPosition, gameObject.transform.localPosition, 1f,collider.transform));
		collider.GetComponent<Rigidbody> ().isKinematic = false;
	}

	IEnumerator AnimateMove (Vector3 origin, Vector3 target, float duration,Transform objectToMove) {
		float journey = 0f;
		while (journey <= duration) {
			journey = journey + Time.deltaTime;
			float percent = Mathf.Clamp01 (journey / duration);

			objectToMove.transform.position = Vector3.Lerp (origin, target, percent);

			yield return null;
		}
	}
}