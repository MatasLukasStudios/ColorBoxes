using UnityEngine;
using System.Collections;

public class PusherScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () 
    {
       
	}

    void changeDifficulty(int difficulty)
    {
        this.gameObject.transform.position = new Vector3(this.gameObject.transform.position.x - difficulty, this.gameObject.transform.position.y, 8);
        CircleScript.c_Speed += difficulty;
    }
}
