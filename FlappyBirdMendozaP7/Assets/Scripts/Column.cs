using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Column : MonoBehaviour

{
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.GetComponent<Bird> () != null)
        {

        }

    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}