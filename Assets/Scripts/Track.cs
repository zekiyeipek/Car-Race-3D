using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Track : MonoBehaviour
{
	public GameObject TheMarker;
	public GameObject Mark1;
	public GameObject Mark2;
	public GameObject Mark3;
	public GameObject Mark4;
	public int MarkTracker;

	void Update()
	{
		if (MarkTracker == 0)
		{
			TheMarker.transform.position = Mark1.transform.position;
		}
		if (MarkTracker == 1)
		{
			TheMarker.transform.position = Mark2.transform.position;
		}
		if (MarkTracker == 2)
		{
			TheMarker.transform.position = Mark3.transform.position;
		}
		if (MarkTracker == 3)
		{
			TheMarker.transform.position = Mark4.transform.position;
		}
	}

	IEnumerator OnTriggerEnter(Collider collision)
	{
		if (collision.gameObject.tag == "RacerCar")
		{
			this.GetComponent<BoxCollider>().enabled = false;
			MarkTracker += 1;
			if (MarkTracker == 6)
			{
				MarkTracker = 0;
			}
			yield return new WaitForSeconds(1);
			this.GetComponent<BoxCollider>().enabled = true;
		}
	}
}
