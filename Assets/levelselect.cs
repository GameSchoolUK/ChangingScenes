using UnityEngine;
using System.Collections;

[ExecuteInEditMode]
public class levelselect : MonoBehaviour {

	public Rect button = new Rect(15,15, 200,110);
	public string buttonLabel = "Load Level";
	public string levelToLoad = "Character Basics";


	private void OnGUI(){
		if (GUI.Button(new Rect(15,15, 200,110), "Load Level 1")){
			Application.LoadLevel("Character Basics");
		}
	}
}
