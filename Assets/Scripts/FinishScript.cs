using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinishScript : MonoBehaviour
{
    private void OnTriggerEnter(Collider col)
    {
        GameObject.Find("Car").SendMessage("Finish");
    }
}
