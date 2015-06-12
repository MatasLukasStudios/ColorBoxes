using UnityEngine;
using System.Collections;

public class s_Play : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () 
    {
	
	}

    void OnMouseDown()
    {
        Application.LoadLevel("Maingame");
    }
}
