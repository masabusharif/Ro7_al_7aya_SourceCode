using UnityEngine;
using System.Collections;

public class Score : MonoBehaviour {

    public GameObject Bird;

	// Use this for initialization
	void Awake () {
	}
	
	// Update is called once per frame

    void OnTriggerEnter(Collider Bird)
    {
        Bird.SendMessage("AddKeys");
        Destroy(gameObject);
    }
	void Update () {
       
	
	}
}
