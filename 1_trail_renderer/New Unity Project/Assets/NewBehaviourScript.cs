using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public float speed = 3.0f;
    GameObject sword;
    // Start is called before the first frame update
    void Start()
    {
        sword = transform.GetChild(0).gameObject;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey("up"))
        {
            this.transform.position += new Vector3(0f, 0f, speed);
        };
        if (Input.GetKey("down"))
        {
            this.transform.position += new Vector3(0f, 0f, -speed);
        };
        if (Input.GetKey("right"))
        {
            this.transform.position += new Vector3(-speed, 0f, 0f);
        };
        if (Input.GetKey("left"))
        {
            this.transform.position += new Vector3(speed, 0f, 0f);
        };

        Swipe();
    }
    void Swipe()
    {
        if(Input.GetMouseButton(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            Vector3 target_pos = ray.GetPoint(5.0f);

            sword.transform.LookAt(target_pos);
        }
    }
}
