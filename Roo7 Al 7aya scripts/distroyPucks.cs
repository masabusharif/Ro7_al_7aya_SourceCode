using UnityEngine;
using System.Collections;

public class distroyPucks : MonoBehaviour 
{


    void Update() 
    {
        if (gameObject.transform.position.x >= 9)
            GameObject.Destroy(this.gameObject);
    }	
}
