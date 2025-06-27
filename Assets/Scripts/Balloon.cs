using UnityEngine;

public class Balloon : MonoBehaviour
{
    public float speed = 2f;
    public int scoreValue = 0;

    void Update()
    {
        transform.Translate(Vector3.up * speed * Time.deltaTime);

        if (transform.position.y > 6f)
        {
            Destroy(gameObject); 
        }
    }

    void OnMouseDown()
    {
        GameManager.Instance.AddScore(scoreValue);
        Destroy(gameObject);
    }

    public void SetColorAndScore(Color color, int score)
    {
        GetComponent<SpriteRenderer>().color = color;
        scoreValue = score;
    }
}
