using System.Linq;
using UnityEngine;

public class PipeSpawnerScript : MonoBehaviour
{

    public GameObject pipe;
    public float spawnInterval = 1.8f;
    public float heightOffset = 2f;

    void Start()
    {
        InvokeRepeating(nameof(SpawnPipe), 0f, spawnInterval);
    }


    void SpawnPipe()
    {
        float camHeight = Camera.main.orthographicSize;
        float screenBottom = Camera.main.transform.position.y - camHeight;
        float screenTop = Camera.main.transform.position.y + camHeight;

        float minY = Mathf.Clamp(transform.position.y - heightOffset, screenBottom + 1, screenTop - 1);
        float maxY = Mathf.Clamp(transform.position.y + heightOffset, screenBottom + 1, screenTop - 1);

        float yPosition = Random.Range(minY, maxY);

        Instantiate(pipe, new Vector3(transform.position.x, yPosition, 0), Quaternion.identity);
    }
}
