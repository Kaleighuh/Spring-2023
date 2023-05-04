using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundScript : MonoBehaviour
{
    public float groundHeight;
    BoxCollider2D collider;
    
    private void Awake()
    {
        collider = GetComponent<BoxCollider2D>();
        groundHeight = transform.position.y + (collider.size.y / 2);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
