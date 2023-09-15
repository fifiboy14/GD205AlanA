using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasicMovement : MonoBehaviour
{
    public GameObject hazard;
    public GameObject[] hazards;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown("w"))
        {
            Debug.Log("w Key Pressed");
            transform.position += Vector3.forward;
        }
        
        if(Input.GetKeyDown("s"))
        {
            Debug.Log("s Key Pressed");
            transform.position += Vector3.back;
        }

        if(Input.GetKeyDown("a"))
        {
            Debug.Log("a Key Pressed");
            transform.position += Vector3.left;
        }
        
        if(Input.GetKeyDown("d"))
        {
            Debug.Log("d Key Pressed");
            transform.position += Vector3.right;
        }

        if(Input.GetKeyDown("q"))
        {
            Debug.Log("q Key Pressed");
            transform.position += Vector3.down;
        }
        
        if(Input.GetKeyDown("e"))
        {
            Debug.Log("e Key Pressed");
            transform.position += Vector3.up;
        }
/*        if(transform.position == hazard.transform.position){
            Debug.Log("you are hazards): lul");

        }
*/        
        for (int i = 0; i < hazards.Length; i++){
            if(transform.position == hazards[i].transform.position){
            Debug.Log("you are hazards): lul");
            Destroy(gameObject);

        }
    }
}
}