using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript1 : MonoBehaviour
{
    public Vector3 sfact = new Vector3(0.1f, 0.1f, 0.1f);
    public float deg = 0f;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.A))
        {
            deg += 0.5f;

            transform.rotation = Quaternion.Euler(new Vector3(deg, 0, 0));
        }
        else if (Input.GetKey(KeyCode.D))
        {

            deg -= 0.5f;

            transform.rotation = Quaternion.Euler(new Vector3(deg, 0, 0));
        }

    }
}
