using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformStand : MonoBehaviour
{
    [SerializeField] private GameObject cubeLight;
    [SerializeField] private GameObject linesManager;
    [SerializeField] private GameObject enables;
    [SerializeField] private bool end;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (end == true)
        {

        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            cubeLight.SetActive(true);
            linesManager.SetActive(true);
            enables.SetActive(true);
        }
    }
}
