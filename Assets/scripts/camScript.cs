using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camScript : MonoBehaviour
{

    public Transform Player;

    // Start is called before the first frame update
    void Start()

    {
        
    }

    // Update is called once per frame
    void LateUpdate()
    {
        transform.position = new Vector3(transform.position.x, transform.position.y, Player.transform.position.z - 10f);
    }
}
