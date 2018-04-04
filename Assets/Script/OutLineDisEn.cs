using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OutLineDisEn : MonoBehaviour {

    //public bool useGraphicAlpha;
    private Outline outlin;
    private Vector4 color;
   // private Vector2 distance;



    // Use this for initialization
    void Start () {
        outlin = gameObject.AddComponent<Outline>();
        color = outlin.effectColor;
        //distance = outlin.effectDistance;
        outlin.effectDistance = new Vector2(0.25f, -0.25f);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    public void Enable()
    {
        outlin.useGraphicAlpha = true;
        outlin.effectColor = color;
        //outlin.effectDistance = distance;
        outlin.effectDistance = new Vector2(0.25f, -0.25f);
    }
    public void Disable()
    {
        outlin.useGraphicAlpha = false;
        outlin.effectColor = new Color(0f, 0f, 0f, 1f);
        outlin.effectDistance = new Vector2(0.5f, -0.5f);
    }
}
