using UnityEngine;
using System.Collections;

public class instantiate : MonoBehaviour {


	public GameObject stoop;
	public float stxPos;
	public float styPos;
	public float stzPos;
	public GameObject chrysler;
	public float boxPos;
	public float boyPos;
	public float bozPos;
	public GameObject fence;
	public float fxPos;
	public float fyPos;
	public float fzPos;
	public GameObject bridge;
	public float bxPos;
	public float byPos;
	public float bzPos;



	//public GameObject gameObject1 = null;
	// Use this for initialization
	void Start () {

		for (int i=1; i <=10; i++) {
			Vector3 position = new Vector3 (stxPos, styPos, i*stzPos++);
			//I can rename GameObject that is green
			
			// call the game object- action folder, load folder place postion, rotation, and as is to cast
			stoop = Instantiate (Resources.Load ("Prefab/stoop"), position, Quaternion.identity) as GameObject;

		
			
		}
		
		for (int i=1; i <=30; i++) {
			Vector3 position = new Vector3 (boxPos, boyPos++, bozPos);
			//I can rename GameObject that is green

			boxPos++;

			// call the game object- action folder, load folder place postion, rotation, and as is to cast
			chrysler= Instantiate (Resources.Load ("Prefab/chrysler"), position, Quaternion.identity) as GameObject;
			
		}
		for (int i=1; i <=20; i++) {
			Vector3 position = new Vector3 (fxPos, fyPos++, fzPos);
			//I can rename GameObject that is green
			
			boxPos++;
			
			// call the game object- action folder, load folder place postion, rotation, and as is to cast
			fence= Instantiate (Resources.Load ("Prefab/fence"), position, Quaternion.identity) as GameObject;
			
		}
		for (int i=1; i <=40; i++) {
			Vector3 position = new Vector3 (i*bxPos++, i*byPos, bzPos);
			//I can rename GameObject that is green
			
			boxPos++;
			
			// call the game object- action folder, load folder place postion, rotation, and as is to cast
			bridge= Instantiate (Resources.Load ("Prefab/bridge"), position, Quaternion.identity) as GameObject;
			
		}
	


	}
	


	// Update is called once per frame
	void Update () {



		if(Input.GetKeyDown(KeyCode.R)){
			
			Application.LoadLevel(0); //or whatever number your scene is
			
		}
	
	}
}
