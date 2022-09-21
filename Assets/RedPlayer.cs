using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RedPlayer : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey("w"))
		{
			this.transform.position += new Vector3(0, 0, 0.05f);
		}
		else if(Input.GetKey("a"))
		{
			this.transform.position += new Vector3(-0.05f, 0, 0);
		}
		else if(Input.GetKey("s"))
		{
			this.transform.position += new Vector3(0, 0, -0.05f);
		}
		else if(Input.GetKey("d"))
		{
			this.transform.position += new Vector3(0.05f, 0, 0);
		}
    }
}
