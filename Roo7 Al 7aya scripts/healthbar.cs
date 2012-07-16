using UnityEngine;
using System.Collections;

public class healthbar : MonoBehaviour
{
    public float barDisplay; //current progress
    public Vector2 pos = new Vector2(20, 40);
    public Vector2 size = new Vector2(60, 20);
    public Texture2D emptyTex;
    public Texture2D fullTex;

    public GameObject Pigeon;

    void OnGUI()
    {
        //draw the background:
        GUI.BeginGroup(new Rect(pos.x, pos.y, size.x, size.y));
        GUI.Box(new Rect(0, 0, size.x, size.y), emptyTex);

        //draw the filled-in part:
        GUI.BeginGroup(new Rect(0, 0, size.x * barDisplay, size.y));
        GUI.Box(new Rect(0, 0, size.x, size.y), fullTex);
        GUI.EndGroup();
        GUI.EndGroup();

    }

    void Update()
    {
        //for this example, the bar display is linked to the current time,
        //however you would set this value based on your desired display
        //eg, the loading progress, the player's health, or whatever.
        
        barDisplay +=  0.002f;
     
        //   barDisplay = MyControlScript.staticHealth;

        //if (Input.GetKeyDown(KeyCode.F))
        //{
        //    if (barDisplay <= 0)
        //        barDisplay = 0;
        //    barDisplay -= 0.2f;
        //}

        if (barDisplay >= 1)
        {
            Pigeon.SendMessage("disableControl");
        }
    }

    public void EditHP()
    {
        if (barDisplay <= 0.2f) barDisplay = 0.2f;
        barDisplay -= 0.2f;
    }

}