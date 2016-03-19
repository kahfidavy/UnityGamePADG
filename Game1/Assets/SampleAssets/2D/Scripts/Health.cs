using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Health : MonoBehaviour {
	public Slider healthbar;

	// Use this for initialization
	void Start () {
		healthbar.value = 200;
		Debug.Log(""+healthbar.value);
	}
	void OnCollisionStay2D(Collision2D col){
		if (col.gameObject.tag == "Dor") {
			healthbar.value -= 1;
			Debug.Log(""+healthbar.value);
		}
	//	if (healthbar.value < 1) {
	//		Application.LoadLevel("Game Over");
	//	}
	}
	// Update is called once per frame
	void Update () {
	
	}
}
