using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pin : MonoBehaviour {

    const bool DEBUG = true; // debug testing

    private bool collided = false;

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
        
	}

	private void OnTriggerEnter2D(Collider2D collision)
	{
        
        //Debug.Log("Collided with " + collision);
        if(collision.GetComponent<Pin>() != null)
        {
            //Debug.Log("Collided with Pin");
        }
        else if (collision.GetComponent<Spin>() != null)
        {
            Debug.Log("Collided with Spin");
            collided = true;
            this.enabled = false;
        }
	}

    public bool isCollided()
    {
        return collided;
    }

}
