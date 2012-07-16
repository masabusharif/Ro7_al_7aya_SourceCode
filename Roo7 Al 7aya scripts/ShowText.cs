using UnityEngine;
using System.Collections;

public class ShowText : MonoBehaviour {

	// Update is called once per frame

    public void ShowHide()
    {
        this.transform.GetComponent<MeshRenderer>().enabled = true;
    }
}
