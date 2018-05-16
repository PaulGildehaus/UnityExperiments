using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sphere : MonoBehaviour {
    Queue<Vector3> queue;
    Vector3 currentVector;


	// Use this for initialization
	void Start () {
        //iTween.MoveUpdate(this.gameObject, new Vector3(0f, 0.5f, 3f), 3f);
        iTween.MoveBy(this.gameObject, iTween.Hash("x", 2, "time", 2.5f));
    }


    void OnTriggerEnter(Collider col)
    {
        if (col.name == "Cube")
        {
            GameObject curr = col.gameObject;
            curr.transform.SetPositionAndRotation(new Vector3(0f, 0.5f, 0f), new Quaternion());
        }
    }

    // Update is called once per frame
    void Update () {

        /*
        Vector3 currVec = queue.Peek();
        //print("Queue: " + currVec.ToString() + " | Position: " + currentVector.ToString());
        if (currentVector.Equals(currVec))
        {
            queue.Dequeue();
            if(currVec.x > 0)
            {
                transform.Translate(-3f,0f,3f);
            }
            else if(currVec.x < 0)
            {
                transform.Translate(3f, 0f, -3f);
            }
            else if(currVec.z > 0)
            {
                transform.Translate(-3f, 0f, -3f);
            }
            else if(currVec.z < 0)
            {
                transform.Translate(3f, 0f, 3f);
            }
            queue.Enqueue(currVec);
        }
        currentVector = transform.position;
	*/
    }
}
