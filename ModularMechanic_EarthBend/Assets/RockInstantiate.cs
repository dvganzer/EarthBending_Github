using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RockInstantiate : MonoBehaviour
{
    public GameObject RockPrefab;



    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            Instantiate(RockPrefab, transform.position + (transform.right * 3), transform.rotation);
        }

    }
}


