using UnityEngine;
using System.Collections;

public class PickUpManager : MonoBehaviour {

    public GameObject Pucks;
    public int secondsToWait = 5;
    public int numberOfPucksInEachWave = 6;
    
    public static string currentPuckPathName;
    public static GameObject HpGUI;
    public GameObject CurrentHpGUI;

    string pathNamePattern = "Path_{0}";
   
    int count;
    float delayBetweenEachPuck = 0.5f;
    int currentLoopCount = 0;

	void Start ()
    {
        pickRandomPucksPath();

        InvokeRepeating("PucksProducer", delayBetweenEachPuck, delayBetweenEachPuck);
	}
    void pickRandomPucksPath()
    {
        currentPuckPathName = string.Format(pathNamePattern, Random.Range(1, 6));
    }
    void PucksProducer()
    {
        if (CurrentHpGUI != HpGUI) HpGUI = CurrentHpGUI;

        currentLoopCount++;

        if (currentLoopCount <= numberOfPucksInEachWave)
        {
            Instantiate(Pucks, new Vector3(-14, -2, 0), Quaternion.identity);
        }
        else{

            if ( (currentLoopCount * delayBetweenEachPuck) % secondsToWait == 0 ){
                
                pickRandomPucksPath();
                currentLoopCount = 0;

            }
        }
    }
}
