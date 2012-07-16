using UnityEngine;
using System.Collections;

public class Move_Keys : MonoBehaviour {

    float counter;
	// Use this for initialization
	void Start () {
        counter = -73.29644f;
	}
	
	// Update is called once per frame
	void Update () {
        counter += 0.02f;
        gameObject.transform.position = new Vector3(counter, 0, 0);
	
	}
}
