using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrumpController : MonoBehaviour
{
    private Rigidbody rigidB;
    private Animation animT;
    public GameObject mobileB;
    public float velocityF = 4f;
    
    // Start is called before the first frame update
    void Start()
    {
        rigidB = GetComponent<Rigidbody>();
        animT = GetComponent<Animation>();

    }

    // Update is called once per frame
    void Update()
    {
        float x = (mobileB.GetComponent<RectTransform>().position.x) - 152f;
        float y = (mobileB.GetComponent<RectTransform>().position.y) - 119f;

        Vector3 movement = new Vector3(x, 0, y);

        rigidB.velocity = movement / velocityF;

        if (x!=0 && y!=0)
        {
            transform.eulerAngles = new Vector3(transform.eulerAngles.x, Mathf.Atan2(x,y)*Mathf.Rad2Deg, transform.eulerAngles.z);
        }

        if (x!=0 || y!=0)
        {
            animT.Play("Walk");
        }
        else
        {
            animT.Play("Idle");
        }
        //Debug.Log(x);
        //Debug.Log(y);
    }
}
