using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetBounds : MonoBehaviour
{

    public static TargetBounds Instance;

    private void Awake()
    {
        Instance = this;
    }

    [SerializeField] BoxCollider targetBounds;

    public Vector3 GetRandomPosition()
    {
        Vector3 center = targetBounds.center + transform.position;

        float minX = center.x - targetBounds.size.x / 2f;
        float maxX = center.x + targetBounds.size.x / 2f;

        float minY = center.y - targetBounds.size.y / 2f;
        float maxY = center.y + targetBounds.size.y / 2f;

        float minZ = center.z - targetBounds.size.z / 2f;
        float maxZ = center.z + targetBounds.size.z / 2f;

        float randomX = Random.Range(minX, maxX);
        float randomY = Random.Range(minY, maxY);
        float randomZ = Random.Range(minZ, maxZ);

        Vector3 randomPos = new Vector3(randomX, randomY, randomZ);

        return randomPos;
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
