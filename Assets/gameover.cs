using UnityEngine;
using System.Collections;

public class gameover : MonoBehaviour {

	float timer = 0.0f;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
		timer += Time.deltaTime;
		if (timer > 5.0)
		{
			Application.LoadLevel("main");
		}
	}
}
