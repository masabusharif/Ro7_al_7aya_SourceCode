using UnityEngine;
using System.Collections;

public class BirdState : MonoBehaviour {

	// Use this for initialization
    int KeysCount;
    float health;
    float healthSpeed;
    public GameObject distanceMeter;
    public GameObject distanceMeterBig;
    public GameObject distanceMeterBig2;
    
    
	void Start () {
        KeysCount = 0;
        health = 100;
        healthSpeed = 0.1f;
	}

    public void AddKeys()
    {
        KeysCount++;
    }

    public void AddHealth()
    {
        health += 20;
        if (health > 100)
            health = 100;
    }

    public void Die()
    {
        gameObject.BroadcastMessage("disableControl");
       // this.transform.GetChild(1).GetComponent<SkinnedMeshRenderer>().enabled = false;
        distanceMeterBig.SendMessage("ShowHide");
        distanceMeterBig.SendMessage("StopCounter");

        distanceMeterBig2.SendMessage("ShowHide");

        distanceMeter.SendMessage("StopCounter");

        Invoke("MainMen", 4.0f);
    }

    public void MainMen()
    {
        Application.LoadLevel(0);
        //Destroy(gameObject);
  
    }

    void OnTriggerEnter(Collider obj)
    {
        if (obj.transform.tag == "rocket")
        {
            Die();
        }
    
    }

	// Update is called once per frame
	void Update () {
        health -= Time.deltaTime + healthSpeed;

        //print("Key Count =" + KeysCount);
       // print("Health: " + health);
	}
}
