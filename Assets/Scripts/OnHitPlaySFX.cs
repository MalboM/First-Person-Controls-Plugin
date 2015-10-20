using UnityEngine;
using System.Collections;

public class OnHitPlaySFX : MonoBehaviour {

    public AudioSource audioSource;

	void OnCollisionEnter (Collision other) {
        if (this.GetComponent<Rigidbody>().velocity.sqrMagnitude > 1f)
            audioSource.Play();
	}
}
