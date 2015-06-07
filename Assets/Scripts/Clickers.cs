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

        Debug.Log(Generator.isDead);

    }

    void OnMouseDown()
    {
        if (sutampa)
        {
            Generator.score++;
            GameObject pusher = GameObject.Find("Pusher");
            pusher.SendMessage("changeDifficulty", Check());
            Destroy(enemy);

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
            difficulty = 1;
        }
        return difficulty;
    }
}
