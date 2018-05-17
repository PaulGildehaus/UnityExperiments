using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class testItween : MonoBehaviour {

	// Use this for initialization
	void Start () {
        iTween.MoveTo(gameObject, iTween.Hash("x", 4f, "time", 3f));
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
