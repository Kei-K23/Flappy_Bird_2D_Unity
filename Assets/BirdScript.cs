using UnityEngine;

public class BirdScript : MonoBehaviour
{
    
    public Rigidbody2D birdRigidbody2D;
    public float flapStrength = 5;

    void Start()
    {
        gameObject.name = "Hello Bird";
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            birdRigidbody2D.linearVelocity = Vector2.up * flapStrength;   
        }
    }
}
