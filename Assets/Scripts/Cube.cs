using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : MonoBehaviour {
    public int health;

	// Use this for initialization
	void Start () {

	}
	
    void OnTriggerEnter(Collider col)
    {
        if(col.name == "Sphere")
        {
            print("Don't touch that");
        }
    }


	// Update is called once per frame
	void Update () {
        transform.Translate((Input.GetAxis("Horizontal")*Time.deltaTime * 3),0f,0f);
        transform.Translate(0f,0f,(Input.GetAxis("Vertical"))*Time.deltaTime * 3);

        if(CheckOutOfBounds())
        {
            transform.SetPositionAndRotation(new Vector3(0, .5f, 0), new Quaternion());
        }
	}

    private bool CheckOutOfBounds()
    {
        if(transform.position.x > 5.25 || transform.position.x < -5.25)
        {
            return true;
        }
        else if(transform.position.z > 5.25 || transform.position.z < -5.25)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}
