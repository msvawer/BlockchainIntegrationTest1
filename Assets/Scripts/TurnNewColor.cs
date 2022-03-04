using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurnNewColor : MonoBehaviour
{

    public GameObject ObjToChangeColor;

    // Start is called before the first frame update
    public void ChangeColor()
    {
        var ObjRenderer = ObjToChangeColor.GetComponent < Renderer > ();

        ObjRenderer.material.SetColor("_Color", Color.cyan);
    }

   
}
