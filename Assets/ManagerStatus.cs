using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ManagerStatus : MonoBehaviour
{
    // Start is called before the first frame update
    public enum ManagerStatus
    {
        Shutdown,
        Initializing,
        Started
    }
}

