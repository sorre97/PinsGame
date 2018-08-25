using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PlayerController : MonoBehaviour {

    public GameObject pinPrefab;
    public float pinSpeed, fireRatio;

    private GameObject spinningWeel, pinSpawner, pin;


	// Use this for initialization
	void Start () {
        spinningWeel = GameObject.Find("SpinningCircle"); // finding spinning weel
        pinSpawner = GameObject.Find("PinSpawner"); // finding pinSpawner
	}
	
	// Update is called once per frame
    void FixedUpdate () {
        if (Input.GetKey(KeyCode.Space)) // on space translate the pin
        {
            Fire();
        }
	}

	public void Fire()
    {
        pin = Instantiate(pinPrefab, pinSpawner.transform.position, Quaternion.Euler(0, 0, 180)) as GameObject;
        StartCoroutine(TestCoroutine(pin, spinningWeel.transform));
    }

    IEnumerator TestCoroutine(GameObject pin, Transform target)
    {
        Pin prova = pin.GetComponent<Pin>();
        Debug.Log(prova.isCollided());
        while(!prova.isCollided())
        {
            pin.transform.position = Vector3.Lerp(pin.transform.position, target.position, pinSpeed * Time.fixedDeltaTime);
            yield return null;
        }
        pin.transform.parent = target;
        Debug.Log(prova.isCollided());
        yield return new WaitForSeconds(fireRatio);

        print("Target Reached");
    }
}
