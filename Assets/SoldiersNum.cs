using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoldiersNum : MonoBehaviour
{
    public int numberOfSoldiers;
    void Start()
    {
        DontDestroyOnLoad(this);
    }
}
