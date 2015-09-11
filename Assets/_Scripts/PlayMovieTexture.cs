using UnityEngine;
using System.Collections;

public class PlayMovieTexture : MonoBehaviour {

	public GameObject screen;

	// Use this for initialization
	void Start () {
		// this line of code will make the Movie Texture begin playing
		((MovieTexture)screen.GetComponent<Renderer>().material.mainTexture).Play ();
	}

}
