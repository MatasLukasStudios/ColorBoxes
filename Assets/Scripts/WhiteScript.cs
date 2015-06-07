using UnityEngine;
using System.Collections;

public class WhiteScript : MonoBehaviour {

    public Sprite[] circles;
    public static float c_Speed = 5;
    private GameObject testlol;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () 
    {
        
        this.gameObject.transform.Translate(Vector3.left * Time.deltaTime * c_Speed);
       
	}

    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.tag == "Pusher")
        {
            GenerateCircle();
        }
       
    }

    void GenerateCircle()
    {
        
        int randomColor = Random.Range(1, 4);
        int color = 0; // 0 = Red // 1 = Green // 2 == Blue // 3 = Yellow
        switch(randomColor)
        {
            case 1:
                this.gameObject.tag = "Red";
                color = 0;
                break;
            case 2:
                this.gameObject.tag = "Green";
                color = 1;
                break;
            case 3:
                this.gameObject.tag = "Blue";
                color = 2;
                break;
            case 4:
                this.gameObject.tag = "Yellow";
                color = 3;
                break;
        }
        this.gameObject.GetComponent<Animator>().SetTrigger("ChangeColor");
        this.gameObject.GetComponent<SpriteRenderer>().sprite = circles[color];
        
    }

}
