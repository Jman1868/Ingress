using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleport : MonoBehaviour
{
    [SerializeField] private Transform target; //respawn point
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
       
         if (other.gameObject.tag == "Player" ) 
        {
            var charControl = other.gameObject.GetComponent<CharacterController>(); //Get component to disable
            charControl.enabled = false; //disable it
            other.gameObject.transform.position = target.position; //teleport our player
            charControl.enabled = true; //re-enable it
            print("teleporting player");
        }

    
    }
}
