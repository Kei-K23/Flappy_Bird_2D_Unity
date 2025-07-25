using System;
using UnityEngine;

public class MiddlePipeScript : MonoBehaviour
{
    public ScoreLogicManagerScript scoreLogicManagerScript;
    void Start()
    {
        scoreLogicManagerScript = GameObject.FindGameObjectWithTag("ScoreLogicTag").GetComponent<ScoreLogicManagerScript>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.layer == 3)
        {
            scoreLogicManagerScript.addScore();
        }
    }
}
