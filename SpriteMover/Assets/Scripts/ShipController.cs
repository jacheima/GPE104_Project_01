 using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipController : MonoBehaviour {

    public Vector2 center = new Vector2(0.0f, 0.0f);
    private Transform ship;
    public float speed;
    


	// Use this for initialization
	void Start () {
        ship = GetComponent<Transform>();
	}
	
	// Update is called once per frame
	void Update () {
	    if (Input.GetKey(KeyCode.LeftShift) || Input.GetKey(KeyCode.RightShift)) //if the user presses left or right shift
        {
	        if (Input.GetKeyDown(KeyCode.LeftArrow) || Input.GetKeyDown(KeyCode.A)) //and if the user presses the left arrow or a key
	        {
	            
                
	        }

	        if (Input.GetKeyDown(KeyCode.RightArrow) || Input.GetKeyDown(KeyCode.D))  //if the user presses right arrow or d key
            {
                
            }

            if (Input.GetKeyDown(KeyCode.UpArrow) || Input.GetKeyDown(KeyCode.W))  //if the user presses the up arrow or the w key
            {
                

            }
            if (Input.GetKeyDown(KeyCode.DownArrow) || Input.GetKeyDown(KeyCode.S))  //if the user presses the down arrow or the s key
            {
                

            }

        }
	    else //Otherwise
	    {
	        if (Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.A)) // if the player presses the left arrow or the a key
	        {
                transform.Rotate(new Vector3(0, 0, 90) * Time.deltaTime);
            }

	        if (Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.D))  // if the player presses the right arrow or d key
	        {
                transform.Rotate(new Vector3(0, 0, -90) * Time.deltaTime);
            }
            if (Input.GetKey(KeyCode.UpArrow) || Input.GetKey(KeyCode.W))  //if the player presses the up arrow or the w key
            {
                transform.position += transform.up * speed;
            }
            
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            transform.position = center;

        }

        if (Input.GetKeyDown(KeyCode.Q))
        {
            gameObject.SetActive(false);
        }
	    
	}
}

