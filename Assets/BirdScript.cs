using UnityEngine;

public class BirdScript : MonoBehaviour
{

    public Rigidbody2D birdRigidbody2D;
    public float flapStrength = 5;
    public LogicManagerScript logicManagerScript;

    public bool birdIsAlive = true;

    void Start()
    {
        logicManagerScript = GameObject.FindGameObjectWithTag("ScoreLogicTag").GetComponent<LogicManagerScript>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && birdIsAlive)
        {
            birdRigidbody2D.linearVelocity = Vector2.up * flapStrength;
        }
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        logicManagerScript.GameOver();
        birdIsAlive = false;
    }
}
