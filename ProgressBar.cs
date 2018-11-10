using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ProgressBar : MonoBehaviour {

    public float playerPos { get; set; }

    public Slider progressbar;

	// Use this for initialization
	void Start () {
        progressbar.value = CalculatePosition();
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKeyDown(KeyCode.W))
        {
            playerPos += 0.01f;
        }
	}

    //Calculate player position
    float CalculatePosition ()
    {
        return playerPos;
    }
}
