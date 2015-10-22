using UnityEngine;
using System.Collections;

public class ChangeTexture : MonoBehaviour {


	public Texture2D cavodrittoattivo;
	public Texture2D cavodrittodisattivo;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnEnable(){
		GetComponent<Renderer>().material.mainTexture = cavodrittoattivo;

	}

	void OnDisable(){
		GetComponent<Renderer>().material.mainTexture = cavodrittodisattivo;
	}
}
