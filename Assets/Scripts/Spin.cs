using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spin : MonoBehaviour {

    public float rotationSpeed;

	private void Start()
	{
        rotationSpeed = 5;
	}

	// Update is called once per frame
	void Update () {
        transform.Rotate(0, 0, rotationSpeed);
	}
}
