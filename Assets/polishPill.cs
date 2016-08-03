using UnityEngine;
using System.Collections;

public class polishPill : MonoBehaviour {

	private timeManager gameTimer;
	AudioSource pillBonus;

	// Use this for initialization
	void Start () {
		
		gameTimer = GameObject.Find ("TimeManager").GetComponent<timeManager>();
		pillBonus = GameObject.Find("pillAudio").GetComponent<AudioSource>();

	}
	void OnCollisionEnter(Collision other){
		
		if (other.gameObject.CompareTag ("Player")) {
			gameTimer.timeLeft += gameTimer.bonus;
		}
		pillBonus.Play();
		Destroy (this.gameObject);
	}
}
