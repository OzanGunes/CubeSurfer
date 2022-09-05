using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Collecter : MonoBehaviour
{
    private GameObject player;
    private int height;
    void Start()
    {
        player = GameObject.Find("Player");
    }
    
    void Update()
    {
        player.transform.position = new Vector3(transform.position.x, height + 1, transform.position.z);
        this.transform.localPosition = new Vector3(0, -height, 0);
    }

    public void HeightReduce()
    {
        height--;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Collect" && other.gameObject.GetComponent<CollectCube>().GetIsCollect()==false)
        {
            height += 1;
            other.gameObject.GetComponent<CollectCube>().DoCollected();
            other.gameObject.GetComponent<CollectCube>().IndexSet(height);
            other.gameObject.transform.parent = player.transform;
        }
    }
    
     
}
