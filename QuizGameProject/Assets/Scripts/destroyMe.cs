using System.Collections;
//using System.Collections.Generic;
using UnityEngine;

public class destroyMe : MonoBehaviour
{
    public float aliveTime;

    // Use this for initialization
    void Awake() {
        Destroy(gameObject, aliveTime);
    }

}
