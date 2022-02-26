using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movingPlatform : MonoBehaviour
{
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
	private void OnCollisionEnter(Collision collision)
	{
        collision.transform.parent = transform;
	}

	private void OnCollisionExit(Collision collision)
	{
        collision.transform.parent = null;
	}
}
