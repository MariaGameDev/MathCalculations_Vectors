using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    [SerializeField] private Transform playerTarget;

    void Start()
    {
        
    }

    
    void Update()
    {
        this.transform.position = new Vector3(playerTarget.position.x, playerTarget.position.y, this.transform.position.z);
    }
}
