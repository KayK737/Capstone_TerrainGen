using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnObject : MonoBehaviour
{
    public Vector3 center;
    public Vector3 size;
    public GameObject pinePrefab;
    public GameObject spookyPrefab;
    public GameObject usualPrefab;
    public float x;
    public float y;
    public float z;
    
    // Start is called before the first frame update
    void Start()
    {
        SpawnPine();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Q))
        {
            
            SpawnPine();
            SpawnSpooky();
            SpawnUsual();

        }
    }
    public void SpawnPine()
    {
     x = Random.Range(-200f, 200f);
     y = Random.Range(0f, 05f);
     z = Random.Range(-200f, 200f);
    center = new Vector3(x, y, z);
        Vector3 pos = center + new Vector3(Random.Range(-size.x / 2 , size.x /2), y, Random.Range(-size.z / 2, size.z / 2));
        Instantiate(pinePrefab, pos, Quaternion.identity);
    }
    public void SpawnSpooky()
    {
        x = Random.Range(-200f, 200f);
        y = Random.Range(0f, 05f);
        z = Random.Range(-200f, 200f);
        center = new Vector3(x, y, z);
        Vector3 pos = center + new Vector3(Random.Range(-size.x / 2, size.x / 2), y, Random.Range(-size.z / 2, size.z / 2));
        Instantiate(spookyPrefab, pos, Quaternion.identity);
    }
    public void SpawnUsual()
    {
        x = Random.Range(-200f, 200f);
        y = Random.Range(0f, 05f);
        z = Random.Range(-200f, 200f);
        center = new Vector3(x, y, z);
        Vector3 pos = center + new Vector3(Random.Range(-size.x / 2, size.x / 2), y, Random.Range(-size.z / 2, size.z / 2));
        Instantiate(usualPrefab, pos, Quaternion.identity);
    }

}
