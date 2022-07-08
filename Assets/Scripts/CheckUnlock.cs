using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckUnlock : MonoBehaviour
{
    public GameObject door1 = null;

    // Start is called before the first frame update
    void Start()
    {
        door1.SetActive(true);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Key1"))
        {
            if (door1.activeInHierarchy)
            {
                door1.SetActive(false);
            }
            
        }
    }
}
