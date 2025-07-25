using System;
using UnityEngine;

public class MiddlePipeScript : MonoBehaviour
{
    public LogicManagerScript logicManagerScript;
    void Start()
    {
        logicManagerScript = GameObject.FindGameObjectWithTag("ScoreLogicTag").GetComponent<LogicManagerScript>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.layer == 3)
        {
            logicManagerScript.AddScore();
        }
    }
}
