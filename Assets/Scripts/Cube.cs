using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : MonoBehaviour {
    public int health;

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
        transform.Translate((Input.GetAxis("Horizontal")*Time.deltaTime * 3),0f,0f);
        transform.Translate(0f,0f,(Input.GetAxis("Vertical"))*Time.deltaTime * 3);
	}
}
