using UnityEngine;
using System.Collections;

public class DestroyRocket : MonoBehaviour
{


    void Update()
    {
        if (gameObject.transform.position.y <= -3)
            GameObject.Destroy(this.gameObject);
    }
}
