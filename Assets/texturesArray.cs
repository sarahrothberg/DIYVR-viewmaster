using UnityEngine;
using System.Collections;

public class texturesArray : MonoBehaviour {

	public Texture[] myTextures; 
	private int currentNum; 

	// Use this for initialization
	void Start () {
	
		GetComponent<Renderer> ().material.mainTexture = myTextures [0]; 
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown(KeyCode.Space))
		{
			GetComponent<Renderer> ().material.mainTexture = myTextures [currentNum]; 
			currentNum++; 
			if (currentNum == myTextures.Length) {
				currentNum = 0; 
			}
		}
	}
}
