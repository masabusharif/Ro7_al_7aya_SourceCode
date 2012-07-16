using UnityEngine;
using System.Collections;


public enum GUIBuuton
{
    Start = 0,
    Tut = 1,
    Abouts = 2,
}
public class RCollisionGUI : MonoBehaviour {

    public GUIBuuton type;
    public Texture2D texDown;
    public Texture2D texUp;
    void OnMouseOver()
    {
       // if (type == GUIBuuton.Start )
       // {
            this.renderer.material.mainTexture = texDown;
       // }

     
    }
    void OnMouseExit()
    {
       // if (type == GUIBuuton.Start)
       // {
            this.renderer.material.mainTexture = texUp;
       // }

    }
    void OnMouseDown()
    {
        if (type == GUIBuuton.Start)
        {
            Application.LoadLevel("Scene_2");
        }

        if (type == GUIBuuton.Tut)
        {
            Application.LoadLevel("Scene_4");
        }
    }
}
