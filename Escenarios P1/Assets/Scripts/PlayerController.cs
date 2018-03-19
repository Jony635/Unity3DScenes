using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

    private Transform tf;
    private GameObject cam;

    public float speedMovement;
    public float speedMouseX;
    public float speedMouseY;

	// Use this for initialization
	void Start ()
    {
        tf = GetComponent<Transform>();
        cam = tf.Find("Main Camera").gameObject;
	}
	
	// Update is called once per frame
	void Update ()
    {
        float moveH = Input.GetAxis("Horizontal");
        float moveV = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(moveH, 0.0f, moveV);

        tf.Translate(movement * speedMovement);

        float mouseX = Input.GetAxis("Mouse X");
        float mouseY = Input.GetAxis("Mouse Y");

        Vector3 rotation = new Vector3(0.0f, mouseX, 0.0f);
        tf.Rotate(rotation * Time.deltaTime * speedMouseX);

        cam.transform.Rotate(new Vector3(- mouseY, 0.0f, 0.0f) * speedMouseY);
    }
}
