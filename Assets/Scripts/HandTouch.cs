using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HandTouch : MonoBehaviour
{

    public GameObject grass;

    
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Collision Triggered." + transform.position);
        GameObject[] AllGrass = GameObject.FindGameObjectsWithTag("Grass");
        Vector3 location = transform.position + new Vector3(Random.Range(0, 0.05f), Random.Range(0, 0.05f), Random.Range(0, 0.05f));
        bool safe = true;
        foreach (var item in AllGrass)
        {
            if (Vector3.Distance(location, item.transform.position) < 0.05)
            {
                safe = false;
            }
        }
        if (safe)
        {
            Debug.Log("Instantiate: " + location);
            Instantiate(grass, location, other.transform.rotation);
        }
    }
}
