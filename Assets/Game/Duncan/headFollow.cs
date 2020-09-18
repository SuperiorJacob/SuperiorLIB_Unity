using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class headFollow : MonoBehaviour
{
    [SerializeField] private Transform playerHead;

    void Start()
    {
        
    }

    void Update()
    {
        if (Vector3.Distance(transform.position, playerHead.position) < 10f)
            transform.LookAt(playerHead);
    }
}
