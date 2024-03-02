using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class player : MonoBehaviour
{
    [SerializeField] Transform center;
    [SerializeField] Transform left;
    [SerializeField] Transform right;
    [SerializeField] Rigidbody rb;


    int currunt_pos = 0 ;


    public float side_speed;
    public float running_speed;



  


    

    // Start is called before the first frame update
    void Start()
    {
        currunt_pos = 0;  // 0 = center, 1 =  left , 2 =  right,
       
    }

    // Update is called once per frame
    void Update()
    {
        

        transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z + running_speed * Time.deltaTime);


        if (currunt_pos == 0)
        {
            if (Input.GetKeyDown(KeyCode.LeftArrow))
             {

                currunt_pos = 1;
             }
             else if(Input.GetKeyDown(KeyCode.RightArrow))
            { 
                currunt_pos = 2;
            
            }
        }
        else if(currunt_pos == 1)
        {
            if(Input.GetKeyDown(KeyCode.RightArrow))
            {
                currunt_pos = 0;             
            }

        }
        else if(currunt_pos == 2)
        {
            if (Input.GetKeyDown(KeyCode.LeftArrow))
            { 
                currunt_pos = 0;
            
            }

        }
        if (currunt_pos == 0)

          
        {
            Vector3 dir =  new Vector3(center.position.x, transform.position.y, transform.position.z) - transform.position ;
            transform.Translate(dir.normalized * side_speed * Time.deltaTime,Space.World);
        }

        else if (currunt_pos == 1)
        {
                
                { 
            Vector3 dir =  new Vector3(left.position.x, transform.position.y, transform.position.z) - transform.position;
            transform.Translate(dir.normalized * side_speed * Time.deltaTime, Space.World);
                }
               
            }
        else if (currunt_pos == 2)
        {
                
                { 
                    Vector3 dir =  new Vector3(right.position.x, transform.position.y, transform.position.z) - transform.position;
            transform.Translate(dir.normalized * side_speed * Time.deltaTime, Space.World);
                  }  
        }
        


    }    
    
}