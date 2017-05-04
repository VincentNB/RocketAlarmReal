using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {

   private float maxSpeed = 6f;
   private float shipBoundryRadius = 0.5f;
   private float rotSpeed = 180f;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        //Returns float from -1.0 to 1.0
        // Input.GetAxis("Vertical");

        
        //Grab rotation quaternion
        Quaternion rot = transform.rotation;
        //Grab Z euler angle
        float z = rot.eulerAngles.z;
        //CHange z angle based on input
        z -= Input.GetAxis("Horizontal") * rotSpeed * Time.deltaTime;
        //Recreate quaternion
        rot = Quaternion.Euler(0, 0, z);
        //Feed quaternion into rotation
        transform.rotation = rot;

        //Move ship
        /*
        Vector2 pos = transform.position;
        pos.y += Input.GetAxis("Vertical") * maxSpeed * Time.deltaTime;
        transform.position = pos;*/
        /*
        Vector2 posX = transform.position;
        posX.x += Input.GetAxis("Horizontal") * maxSpeed * Time.deltaTime;
        transform.position = posX;*/

        
        Vector3 pos = transform.position;
        Vector3 velocity = new Vector3(0, Input.GetAxis("Vertical") * maxSpeed * Time.deltaTime, 0);
        pos += rot * velocity;

        //Restrict player to cameras boundaries
        //Vertical
        if (pos.y + shipBoundryRadius > Camera.main.orthographicSize)
        {
            pos.y = Camera.main.orthographicSize - shipBoundryRadius;
        }

        if (pos.y - shipBoundryRadius < -Camera.main.orthographicSize)
        {
            pos.y = -Camera.main.orthographicSize + shipBoundryRadius;
        }

        //Calculate orthographic width based on screen ratio
        float screenRatio = (float) Screen.width / Screen.height;
        float width0rtho = Camera.main.orthographicSize * screenRatio;

        //Horizontal
        if (pos.x + shipBoundryRadius > width0rtho)
        {
            pos.x = width0rtho - shipBoundryRadius;
        }

        if (pos.x - shipBoundryRadius < -width0rtho)
        {
            pos.x = -width0rtho + shipBoundryRadius;
        }

        //Update position
        transform.position = pos;
        
    }
}
