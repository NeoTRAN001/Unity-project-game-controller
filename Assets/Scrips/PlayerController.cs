using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] float speed = 5.0f;
    
    void Start()
    {
        
    }

    void Update()
    {
        this.transform.Translate(speed * Time.deltaTime * Vector3.forward); // S = s0 + Vtd
    }
}
