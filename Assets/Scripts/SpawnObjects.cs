using UnityEngine;

public class SpawnObjects : MonoBehaviour
{
    public float maxTime = 1f;
    public GameObject[] prefabs;
    public float maxHeight = 5f;
    public float minHeight = -5f;

    private float timer;

    private void Start()
    {
        InstantiateObject();
    }

    private void Update()
    {
        if (timer > maxTime)
        {
            InstantiateObject();
            timer = 0;
        }

        timer += Time.deltaTime;
    }

    private void InstantiateObject()
    {
        GameObject prefabToSpawn = prefabs[Random.Range(0, prefabs.Length)];
        var instance = Instantiate(prefabToSpawn);
        var y = Random.Range(minHeight, maxHeight);
        instance.transform.position = transform.position + new Vector3(0, y, 0);

        Destroy(instance, 20f);
    }
}
