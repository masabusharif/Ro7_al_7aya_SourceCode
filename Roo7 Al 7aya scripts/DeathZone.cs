using UnityEngine;
using System.Collections;

public class DeathZone : MonoBehaviour {

    public GameObject Bird;
	// Use this for initialization
	void Start () {


	}
    void OnTriggerEnter()
    {
        Bird.SendMessage("Die");
    }
	
	// Update is called once per frame
	void Update () {
	
	}
}
