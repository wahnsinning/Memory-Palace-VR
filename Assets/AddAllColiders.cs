using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddAllColiders : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        // Get all child objects of this game object
        Transform[] children = GetComponentsInChildren<Transform>();

        // Loop through all child objects and add a Box Collider component to each one
        foreach (Transform child in children)
        {
            // Skip the parent object
            if (child.gameObject == gameObject) continue;

            // Add a Box Collider component to the child object
            BoxCollider collider = child.gameObject.AddComponent<BoxCollider>();

            // Adjust the size and position of the collider to match the child object's bounds
            collider.size = child.GetComponent<Renderer>().bounds.size;
            collider.center = child.GetComponent<Renderer>().bounds.center - child.position;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
