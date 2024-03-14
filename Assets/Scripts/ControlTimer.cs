using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlTimer : MonoBehaviour
{
    private void OnControllerColliderHit(ControllerColliderHit hit)
    {
        if(hit.gameObject.name == "StartPoint")
        {
            setTimer(1);
        }
        if(hit.gameObject.name == "EndPoint")
        {
            setTimer(0);
        }
        
    }
    void setTimer(int t)
    {
        Timer playerTimer = this.GetComponent<Timer>();
        playerTimer.startTimer = t;
    }
}
