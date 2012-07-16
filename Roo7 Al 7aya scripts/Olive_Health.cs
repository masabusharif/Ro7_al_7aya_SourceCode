using UnityEngine;
using System.Collections;

public class Olive_Health : MonoBehaviour {

    public GameObject Bird;
    public GameObject HpGUI;

    

    void Awake()
    {
       HpGUI = PickUpManager.HpGUI;

       //Bird=GameObject.FindGameObjectWithTag("Player");
       //HpGUI = GameObject.FindGameObjectWithTag("HpGUI");
    }

    void OnTriggerEnter(Collider Bird)
    {
        //Bird.SendMessage("AddHealth");
        HpGUI.SendMessage("EditHP");

        Destroy(gameObject);
    }
}
