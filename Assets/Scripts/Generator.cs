using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class Generator : MonoBehaviour {


    public GameObject whiteCircle;
    public float spawnRate;
    public static bool isDead;
    
    public static int score;
    private GameObject scoreText;
   
    // Lines
    private float redLine = 3.5f;
    private float greenLine = 1.3f;
    private float blueLine = -0.9f;
    private float yellowLine = -3.2f;
    //Line end

	// Use this for initialization
	void Start () 
    {
        scoreText = GameObject.Find("Score");
        InvokeRepeating("SpawnCircle", 0, spawnRate);
        

	}
	
	// Update is called once per frame
	void Update () 
    {
        scoreText.GetComponent<Text>().text = "Score: " + score;

        if(isDead)
        {
            Time.timeScale = 0;

        }

	}

    public void SpawnCircle()
    {
        GameObject circle = Instantiate(whiteCircle);
        Vector3 c_Pos = Vector3.zero;
        c_Pos.x = 7;
        int ranLine = Random.Range(1, 5);
        switch (ranLine)
        {
            case 1:
                c_Pos.y = redLine;
                break;
            case 2:
                c_Pos.y = greenLine;
                break;
            case 3:
                c_Pos.y = blueLine;
                break;
            case 4:
                c_Pos.y = yellowLine;
                break;

        }
        circle.transform.position = c_Pos;

    }
   
}
