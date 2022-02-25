using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawner : MonoBehaviour
{

    [SerializeField] private Transform spawnPos;
    [SerializeField] private GameObject theBox;
    [SerializeField] private int allowedAmount = 1;

    public int counter = 0;
    private bool pressE;
    private bool pressF;

    public List<GameObject> cubes = new List<GameObject>();

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            pressE = true;
        } 
        if (Input.GetKeyDown(KeyCode.F))
        {
            pressF = true;
        }
    }
    private void OnTriggerStay(Collider other)
    {
            if (counter < allowedAmount)
            {

                if (pressE == true)
                {
                   
                    print("pressed");

                    cubes.Add(Instantiate(theBox, spawnPos));
                    //activePrefab[counter] = Instantiate(theBox, spawnPos);
                    counter++;

            }
               
            }
		if (counter > 0)
		{
            if (pressF == true)
            {

                print("pressed f");
                var temp = cubes[counter-1].gameObject;
                cubes.RemoveAt(counter-1); //list sorts itself so we need to go back
                Destroy(temp);

                counter--;
            }
        }
 

		
            
            
            
		

        pressE = false;
        pressF = false;
    }

    private void CreatePrefab()
    {
        //if (activePrefab != null) Destroy(activePrefab);
        //activePrefab = Instantiate(YourPrefab, YourTouchPosition, Quaternion.identity) as GameObject;

    }
}
  
