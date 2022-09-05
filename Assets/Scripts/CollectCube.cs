using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectCube : MonoBehaviour
{
    private bool isCollect;
    private int index;
    public Collecter collecter;
    
    void Start()
    {
        isCollect = false;
    }
    
    
    void Update()
    {
        if (isCollect == true) 
        {
            if (transform.position!=null)
            {
                transform.localPosition = new Vector3(0, -index, 0);
            }
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Obstacle") 
        {
            collecter.HeightReduce();
            transform.parent = null;
            GetComponent<BoxCollider>().enabled = false;
            other.gameObject.GetComponent<BoxCollider>().enabled = false;
        }
    }

    public bool GetIsCollect()
    {
        return isCollect;
    }

    public void DoCollected()
    {
        isCollect = true;
    }

    public void IndexSet(int index)
    {
        this.index = index;
    }
}
