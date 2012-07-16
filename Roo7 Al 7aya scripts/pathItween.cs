using UnityEngine;
using System.Collections;

public class pathItween : MonoBehaviour {

	// Use this for initialization

	void Start () 
    {
        
        iTween.MoveTo(gameObject, iTween.Hash("path", iTweenPath.GetPath( PickUpManager.currentPuckPathName ), "time", 10, "easetype", iTween.EaseType.easeOutSine));
	}
}
