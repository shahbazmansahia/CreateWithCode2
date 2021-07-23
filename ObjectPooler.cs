using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectPooler : MonoBehaviour
{
    public static ObjectPooler SharedInstance;
    public List <GameObject> pooledProjectiles;
    public GameObject objectToPool;
    public int amountToPool;


    private void Awake()
    {
        SharedInstance = this;
    }

    // Start is called before the first frame update
    void Start()
    {

        pooledProjectiles = new List<GameObject>();
        for (int i = 0; i < amountToPool; i++)
        {
            GameObject temp = (GameObject) Instantiate (objectToPool);
            temp.SetActive(false);
            pooledProjectiles.Add(temp);
            temp.transform.SetParent(this.transform);
        }


    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public GameObject GetPooledObject()
    {
        for (int i = 0; i < pooledProjectiles.Count; i++)
        {
            if (!pooledProjectiles[i].activeInHierarchy)
            {
                return pooledProjectiles[i];
            }
        }

        return null;
    }
}
