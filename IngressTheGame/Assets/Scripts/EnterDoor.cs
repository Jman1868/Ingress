using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class EnterDoor : MonoBehaviour
{
    [SerializeField] private bool fakeDoor;
    [SerializeField] private Transform PlayerTele; //respawn point
    [SerializeField] private Transform itemTele; //respawn point

    [SerializeField] private AudioClip sound;
    private AudioSource source;

    // Start is called before the first frame update
    void Start()
    {
        source = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    
    /// This funciton teleports or progess to the next scene
    /// depending on our players choice. 
    /// If we want to teleport we need to temp disable the character
    /// controller and then re-enable it.
	private void OnTriggerEnter(Collider other)
	{
        
        if (other.gameObject.tag == "Player" && fakeDoor == false) //Real door
		{
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1); //load next scene in index

        }
        else if (other.gameObject.tag == "Player" && fakeDoor == true) //Fake door
        {
            var charControl = other.gameObject.GetComponent <CharacterController>(); //Get component to disable
            charControl.enabled = false; //disable it
            other.gameObject.transform.position = PlayerTele.position; //teleport our player
            charControl.enabled = true; //re-enable it
            print("wrong door");
            source.clip = sound;
            source.Play();
		}

		if (other.gameObject.layer == 3 && fakeDoor==true) 
        {

            other.transform.position = itemTele.position;
        }
	}

}
