using UnityEngine;
using System.Collections;

public class PlayAnim : MonoBehaviour {

    Animation fly;
    bool enabled = true;
	// Use this for initialization

   public float speed;

	void Start () {
	
	}
	
	// Update is called once per frame

    void Update()
    {
        //transform.Rotate(30*Time.deltaTime,0,0, Space.Self);

        transform.Translate(0,Time.deltaTime* speed, 0, Space.World);

        speed -= Time.deltaTime*5;
        if (speed > 3)
            speed = 3;

        if (Input.GetKeyDown(KeyCode.Space) && enabled )
        {
          //  animation.Play();
            speed += 2;
        }
        //else
        //    animation.CrossFade("idle");
        print("Speed: " + speed);
  
    }

    public void disableControl()
    {
        animation.CrossFade("idle");
        enabled = false;
    }

}


