using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sphere : MonoBehaviour {
    Queue<Vector3> queue;
    Vector3 currentVector;


	// Use this for initialization
	void Start () {
        currentVector = new Vector3();
        queue = new Queue<Vector3>();
        queue.Enqueue(new Vector3(3f, .5f, 0f));
        queue.Enqueue(new Vector3(0f, .5f, 3f));
        queue.Enqueue(new Vector3(-3f, .5f, 0f));
        queue.Enqueue(new Vector3(0f, .5f, -3f));

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
        //iTween.MoveTo(gameObject, new Vector3(0f, .5f, 5f), 2f);

        
        Vector3 currVec = queue.Peek();
        print(currVec + "   |   " + currentVector);
        if (currentVector.Equals(currVec))
        {
            queue.Dequeue();
            iTween.MoveTo(gameObject, currVec, 3f);
            queue.Enqueue(currVec);
        }
        currentVector = transform.position;
        
    }
}
