using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaddleMovement : MonoBehaviour {

    Vector3 mouseLastPos;
    Vector2 handLastPos;

	// Use this for initialization
	void Start () {
        mouseLastPos = Input.mousePosition;
	}
	
	// Update is called once per frame
	void Update () {

        float xMovement = 0f;

        if (KinectBodySourceView.kinectActive)
        {
            //Kinect Controls here
            xMovement = KinectBodySourceView.handPosition.x - handLastPos.x;
            handLastPos = KinectBodySourceView.handPosition;
        }
        else
        {
            //Mouse Controls here
            xMovement = Input.mousePosition.x - mouseLastPos.x;
            xMovement /= 50;
        }
        
        //This line in case KinectBody is lost, and control reverts to mouse.
        mouseLastPos = Input.mousePosition;

        transform.position = new Vector3(transform.position.x + xMovement, transform.position.y, transform.position.z);

        if(transform.position.x < -4.75f)
        {
            transform.position = new Vector3(-4.75f, transform.position.y, transform.position.z);
        }
        else if (transform.position.x > 4.75f)
        {
            transform.position = new Vector3(4.75f, transform.position.y, transform.position.z);
        }

	}
}
