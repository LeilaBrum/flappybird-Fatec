using UnityEngine;

public class Pipes : MonoBehaviour
{
    public float speed = 5f;
    public GameManager gameManager;
    private bool movingUp = true;
    private float currentHeight;

    private void Awake()
    {
        gameManager = FindObjectOfType<GameManager>();
    }

    private void Update()
    {
        if (gameManager.Score >= 10)
        {
            speed = 8f;
        }

        if (gameManager.Score >= 20)
        {
            if (movingUp)
            {
                currentHeight += 1f * Time.deltaTime;
                if (currentHeight >= 1.5f)
                {
                    currentHeight = 1.5f;
                    movingUp = false;
                }
            }
            else
            {
                currentHeight -= 1f * Time.deltaTime;
                if (currentHeight <= 0.45f)
                {
                    currentHeight = 0.45f;
                    movingUp = true;
                }
            }

            Vector3 newPosition = transform.position;
            newPosition.y = currentHeight;
            transform.position = newPosition;
        }


        transform.position += speed * Time.deltaTime * Vector3.left;
    }

    /*private void OnBecameInvisible()
    {
        Destroy(gameObject);
    }*/
}
