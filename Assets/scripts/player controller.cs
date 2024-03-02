using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class player : MonoBehaviour
{
    [SerializeField] Transform center;
    [SerializeField] Transform left;
    [SerializeField] Transform right;



    int currunt_pos = 0 ;


    public float side_speed;
    public float running_speed;
    public float jump_Force;
    public float baseSpeed = 10f; // Velocidad base del personaje
    public float speedIncrease = 0.1f; // Aumento de velocidad al tocar un objeto (10%)

    private float currentSpeed; // Velocidad actual del personaje


    [SerializeField] Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
        currunt_pos = 0;  // 0 = center, 1 =  left , 2 =  right,
        currunt_pos = 0;
        rb = GetComponent<Rigidbody>(); // Obtener el componente Rigidbody del GameObject
        rb.useGravity = true; // Activar la gravedad en el Rigidbody
        currentSpeed = baseSpeed;
    }

    // Update is called once per frame
    void Update()
    {
        rb.AddForce(Vector3.down * Physics.gravity.y * Time.deltaTime);

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
        if(Input.GetKeyDown(KeyCode.Space))
        {
            rb.AddForce(Vector3.up * jump_Force);
        }

        if (Input.GetKeyDown(KeyCode.E)) // Reemplaza "E" por la tecla de interacción
        {
            currentSpeed *= (1f + speedIncrease); // Aumenta la velocidad en un 10%
        }
    }
    public float GetCurrentSpeed()
    {
        return currentSpeed;
    }

}