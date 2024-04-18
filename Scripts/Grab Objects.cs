using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GrabObjects : MonoBehaviour
{
    public Transform grabDetect;
    public Transform itemHolder;
    public float rayDist;
    public GameObject inv;
    bool first;

    // Start is called before the first frame update
    void Start()
    {
        first = true;
    }

    // Update is called once per frame
    void Update()
    {
        /*RaycastHit2D grabCheck = Physics2D.Raycast(grabDetect.position, Vector2.down * transform.localScale * 2, rayDist);
       

        if (grabCheck.collider !=null && grabCheck.collider.tag == "Object")
        {
            if (Input.GetKey(KeyCode.G) || Input.GetKey(KeyCode.F))
            {
                grabCheck.collider.gameObject.transform.parent = itemHolder;
                grabCheck.collider.gameObject.transform.position = itemHolder.position;
                //grabCheck.collider.gameObject.GetComponent<Rigidbody2D>().isKinematic = true;
            }
             else
            {
                grabCheck.collider.gameObject.transform.parent = null;
                //grabCheck.collider.gameObject.GetComponent<Rigidbody2D>().isKinematic = false;
            }
        }*/
    }

    private void OnCollisionStay2D(Collision2D other)
    {
        RaycastHit2D grabCheck = Physics2D.Raycast(grabDetect.position, Vector2.down * transform.localScale, rayDist);

        if (grabCheck.collider != null && grabCheck.collider.tag == "Object")
        {
            grabCheck.collider.gameObject.transform.parent = itemHolder;
            grabCheck.collider.gameObject.transform.position = itemHolder.position;
            Debug.Log("item picked");
        }
        else
        {
            grabCheck.collider.gameObject.transform.parent = null;
        }
    }
}
