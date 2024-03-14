using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerPoint : MonoBehaviour
{
	public GameObject StartPoint;
	public GameObject EndPoint;

	void OnTriggerEnter()
	{
		StartPoint.SetActive(true);
		EndPoint.SetActive(false);
	}
}
