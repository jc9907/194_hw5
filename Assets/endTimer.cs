using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class endTimer : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        GameObject.Find("RigidBodyFPSController").SendMessage("finish");
    }
}
