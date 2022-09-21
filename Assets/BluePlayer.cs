using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BluePlayer : MonoBehaviour
{
	float f = 0.05f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
	    if(Input.GetKey("up"))
		{
			this.transform.position += new Vector3(0, 0, f);
		}
		else if(Input.GetKey("left"))
		{
			this.transform.position += new Vector3(-f, 0, 0);
		}
		else if(Input.GetKey("down"))
		{
			this.transform.position += new Vector3(0, 0, -f);
		}
		else if(Input.GetKey("right"))
		{
			this.transform.position += new Vector3(f, 0, 0);
		}
    }
}
