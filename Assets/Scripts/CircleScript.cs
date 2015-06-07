using UnityEngine;
using System.Collections;

public class CircleScript : MonoBehaviour {

    public static float c_Speed = 5;

	// Use this for initialization
	void Start () 
    {

	
	}
	
	// Update is called once per frame
	void Update () 
    {
        this.gameObject.transform.Translate(Vector3.left * Time.deltaTime * c_Speed);
	
	}

    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.tag == "Destroyer")
        {
            Destroy(this.gameObject);
        }
    }
        


}
