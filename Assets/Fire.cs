using UnityEngine;
using System.Collections;

public class Fire : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

        if (Input.touchCount > 0)
        {
            if (Input.GetTouch(0).phase == TouchPhase.Began)
            {
                rigidbody.AddForce(new Vector3(100, 0, 0));
            }
        }
	
	}
}
