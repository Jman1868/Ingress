using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Music : MonoBehaviour
{
    private static Music musicManager;
    // Start is called before the first frame update
    private void Awake()
    {
        DontDestroyOnLoad(this);

        if (musicManager == null)
        {
            musicManager = this;
        } 
        else
        {
            Destroy(gameObject);
        }
    }
	void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
