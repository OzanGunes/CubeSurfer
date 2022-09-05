using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private float speed;
    [SerializeField] private float horSpeed;
    
    void Start()
    {
        
    }

 
    void Update()
    {
        float xAxis = Input.GetAxis("Horizontal") * horSpeed * Time.deltaTime;
        this.transform.Translate(xAxis, 0, speed * Time.deltaTime);
        
    }
}
