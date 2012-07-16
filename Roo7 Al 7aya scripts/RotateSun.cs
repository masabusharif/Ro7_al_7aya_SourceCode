using UnityEngine;
using System.Collections;

public class RotateSun : MonoBehaviour {

    public float speed;
	// Update is called once per frame
	void Update () {

        gameObject.transform.Rotate(0, 0, speed);
	}
}
