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
        Vector3 currVec = queue.Peek();
        if (currentVector.Equals(currVec))
        {
            queue.Dequeue();
            queue.Enqueue(currVec);
            currVec = queue.Peek();
            iTween.MoveTo(gameObject, currVec, 1.5f);
        }
        currentVector = transform.position;
    }
}
