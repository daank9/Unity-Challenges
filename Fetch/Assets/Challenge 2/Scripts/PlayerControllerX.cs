using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;
    private GameObject dogInstance;

    // Update is called once per frame
    void Update()
    {
        // On spacebar press, send dog
        if (Input.GetKeyDown(KeyCode.Space) && !dogInstance)
        {
            dogInstance = Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
        }
    }
}
