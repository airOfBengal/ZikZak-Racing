using System.Collections;
using UnityEngine;

public class PlatformSpawner : MonoBehaviour
{
    public GameObject platform;
    public Transform lastPlatform;
    private Vector3 lastPosition;
    private Vector3 newPos;
    public volatile bool stop;
    public float platformSpawnDelay = 0.5f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        lastPosition = lastPlatform.position;
        StartCoroutine(SpwanPlatform());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private IEnumerator SpwanPlatform(){
        while(!stop){
            GeneratePosition();
            Instantiate(platform, newPos, Quaternion.identity);
            lastPosition = newPos;
            yield return new WaitForSeconds(platformSpawnDelay);
        }
    }

    private void GeneratePosition(){
        newPos = lastPosition;
        int rand = Random.Range(0, 2);

        if(rand > 0){
            newPos.x += 2;
        }
        else{
            newPos.z += 2;
        }
    }
}
