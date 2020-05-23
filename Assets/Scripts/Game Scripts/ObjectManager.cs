using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectManager : MonoBehaviour
{
    public GameObject objPrefab;
    public Vector3 objPosition;

    void Awake()
    {
        GameObject obj = Instantiate(objPrefab, new Vector3(Random.Range(-100, 100), Random.Range(-100, 100), objPrefab.transform.position.z), Quaternion.identity);
        objPosition = objPrefab.transform.position;
    }

    
    void Update()
    {
        
    }
}
