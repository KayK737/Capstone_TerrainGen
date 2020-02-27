using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnObject : MonoBehaviour
{
    public Vector3 center;
    public Vector3 size;
    Vector3 pos;
    public GameObject pinePrefab;
    public GameObject spookyPrefab;
    public GameObject usualPrefab;
    public GameObject firstPerson;
    public int spawnAmount;

    
    public float x;
    public float y;
    public float z;
    public int random;
    
  void Start()
  {
      spawnAmount = Random.Range(10, 50);
      while (spawnAmount > 0)

          x = Random.Range(-40f, 175f);
          y = 20;
          z = Random.Range(-40f, 175f);
          center = new Vector3(x, y, z);
          pos = center + new Vector3(size.x + x, size.y + y, size.z + z);
          SpawnTree();
          spawnAmount--;
         
        }

     
    void Update()
    {
        if (Input.GetKey(KeyCode.Q))
        {
            pos = firstPerson.transform.position;
            SpawnTree();
            
        }
    }
    public void SpawnTree()
    {       
       
        random = Random.Range(0,10);
        if(random > 7) Instantiate(pinePrefab, pos, Quaternion.identity);
        else if(random <= 6 || random > 4) Instantiate(spookyPrefab, pos, Quaternion.identity);
        else if(random < 4) Instantiate(usualPrefab, pos, Quaternion.identity);
 
    }


}
