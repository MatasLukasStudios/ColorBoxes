using UnityEngine;
using System.Collections;

public class Clickers : MonoBehaviour
{

    private bool sutampa;
    private GameObject enemy;

    // Use this for initialization
    void Start()
    {
        sutampa = false;
        Generator.isDead = false;
    }

    // Update is called once per frame
    void Update()
    {

        
        if(sutampa && enemy.transform.position.x <= -7.45f)
        {
          //  Generator.isDead = true;
        }
    }

    void OnMouseDown()
    {
        Generator.isDead = true;

        if (sutampa)
        {
            Generator.isDead = false;
            Generator.score++;
            Destroy(enemy);
            GameObject pusher = GameObject.Find("Pusher");
            pusher.SendMessage("changeDifficulty", Check());
            

        }
        else
            Generator.isDead = true;

    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag + "Box" == this.gameObject.tag)
        {
            sutampa = true;
            enemy = other.gameObject;
        }
    }

    int Check()
    {
        int difficulty = 0;
        if(Generator.score >= 3)
        {
            Generator.spawnRate = 0.8f;
            WhiteScript.c_Speed = 6;
            CircleScript.c_Speed = 6;
            difficulty = 1;
        }
        return difficulty;
    }
}
