using UnityEngine;
using System.Collections;

public class DistanceIncrease : MonoBehaviour {

    public TextMesh TM;
    int count;
    bool stopCount = true;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

        if (stopCount)
        {
            count++;
            TM.text = count.ToString();
        }
      
	}
    public void StopCounter()
    {
        stopCount = false;
    }

}
