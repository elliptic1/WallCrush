using UnityEngine;
using System.Collections;

public class BuildWall : MonoBehaviour {

    GameObject wallBlock;

	// Use this for initialization
	void Start () {

       float brickWidth = 18f;
       float brickHeight = 36f;
       int wallWidth = 30; // number of bricks
       int wallHeight = 20; // number of rows

        float startX = 950f;
        float startY = 1f;
        float startZ = 830f;
        float hSpace = 0.1f;
        float vSpace = 0.1f;

       for (int rowNum = 0; rowNum < wallHeight; rowNum++)
       {
           for (int brickNum = 0; brickNum < wallWidth; brickNum++)
           {
               float x = (float) (startX + (float)brickNum * (brickWidth + hSpace));
               float y = (float)(startY + (float)rowNum * (brickHeight + vSpace));

               wallBlock = GameObject.CreatePrimitive(PrimitiveType.Cube);
               wallBlock.transform.localScale = new Vector3(brickWidth, brickHeight, brickHeight);
               wallBlock.transform.position = new Vector3(x, y, startZ);
               wallBlock.AddComponent("Rigidbody");
               wallBlock.rigidbody.useGravity = true;


           }
       }
        

	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
