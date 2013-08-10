using UnityEngine;
using System.Collections;

public class Fire : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

        if (Input.GetMouseButtonDown(0) || Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Began)
        {

            GameObject sphere = GameObject.CreatePrimitive(PrimitiveType.Sphere);
            sphere.transform.position = new Vector3(950, 180, 81);
            sphere.transform.localScale = new Vector3(10, 10, 10);
            sphere.AddComponent("Rigidbody");
            sphere.rigidbody.mass = 5;
            sphere.rigidbody.useGravity = false;

            sphere.rigidbody.AddForce(new Vector3(0, 0, 90000));
        }

	}
}
