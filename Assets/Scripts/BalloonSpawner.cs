using UnityEngine;

public class BalloonSpawner : MonoBehaviour
{
    public GameObject balloonPrefab;
    public float spawnInterval = 1.5f;

    void Start()
    {
        InvokeRepeating(nameof(SpawnBalloon), 0f, spawnInterval);
    }

    void SpawnBalloon()
    {
        float x = Random.Range(-7f, 7f);
        Vector3 spawnPos = new Vector3(x, -5f, 0f);
        GameObject balloonObj = Instantiate(balloonPrefab, spawnPos, Quaternion.identity);

        Balloon balloon = balloonObj.GetComponent<Balloon>();


        int r = Random.Range(0, 3);

        if (r == 0) 
            balloon.SetColorAndScore(Color.blue, 1);
        else if (r == 1) 
            balloon.SetColorAndScore(Color.green, 5);
        else if (r == 2) 
            balloon.SetColorAndScore(Color.black, -1);
    }
}
