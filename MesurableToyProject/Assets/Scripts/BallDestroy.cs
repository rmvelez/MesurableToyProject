using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallDestroy : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter(Collision other)
    {
        if(other.gameObject.tag == "RedHoop")
        {
            Destroy(this.gameObject);
        }
        else if (other.gameObject.tag == "BlueHoop")
        {
            Destroy(this.gameObject);
        }
        if (other.gameObject.tag == "YellowHoop")
        {
            Destroy(this.gameObject);
        }
    }
}
