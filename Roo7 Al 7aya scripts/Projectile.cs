using UnityEngine;
using System.Collections;

public class Projectile : MonoBehaviour {

    public Rigidbody projectile;
    public float MinSpeed;
    public float MaxSpeed;

	// Use this for initialization
	void Start () {
	
	}
    int currentF = 0;
	// Update is called once per frame
	void Update () {
        currentF++;
        if (currentF % Random.Range(90, 130) == 0)
        {
            Rigidbody instantiatedProjectile;

            instantiatedProjectile = Instantiate(projectile, transform.position, transform.rotation) as Rigidbody;
            instantiatedProjectile.velocity = transform.TransformDirection(Random.Range(MinSpeed,MaxSpeed), 0, 0);

          
            currentF = 0;
        }
	}
}
