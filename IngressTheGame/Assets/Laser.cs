using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Laser : MonoBehaviour
{
    private LineRenderer LineRenderer;

    [SerializeField]
    private Transform startPoint;

	[SerializeField]
	private Transform reset;

	public GameObject playerobj;
	public CharacterController charControl;
	private void Start()
	{
		LineRenderer = GetComponent<LineRenderer>();
		 charControl = playerobj.GetComponent<CharacterController>();
	}
	// Update is called once per frame
	void Update()
    {
		//Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out hit, 20f)
		LineRenderer.SetPosition(0, startPoint.position);
		RaycastHit hit;
		if (Physics.Raycast(transform.position, -transform.right, out hit)) //direction
		{

			//Debug.Log("hit something");
			Debug.DrawRay(transform.position, -transform.right * hit.distance, Color.red);
			LineRenderer.SetPosition(1, hit.point);
			if (hit.collider)
			{
				LineRenderer.SetPosition(1, hit.point);
			}
			if (hit.transform.tag == "Player")
			{
				
				charControl.enabled = false; //disable it

				
				hit.transform.parent.position = reset.position; //teleport our player 

				charControl.enabled = true; //re-enable it

				//hit.transform.position = reset.transform.position;

				Debug.Log("hit player");
			}
		}
		else LineRenderer.SetPosition(1, -transform.right * 5000);

		//else
		//{
		//	Debug.Log("hit nothing");
		//	LineRenderer.SetPosition(1,-transform.right*5000);
		//	Debug.DrawRay(transform.position, transform.TransformDirection(Vector3.forward) * 20f, Color.blue);
		//}
    }
}
