using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class buttonScript : MonoBehaviour {
    public bool on = false;
    private Light myLight;

    void Start()
    {
        myLight = transform.GetChild(0).GetComponent<Light>();
    }



    private void OnCollisionEnter(Collision collision)
    {

        if (collision.gameObject.name == "Bullet" && on == true)
        {
            //transform.GetChild(0).GetComponent<Light>().enabled = true;
            myLight.enabled = false;
            on = false;
            print("off?");
        }

        else if (collision.gameObject.name == "Bullet" && on == false)
        {
            //transform.GetChild(0).GetComponent<Light>().enabled = true;
            myLight.enabled = true;
            on = true;
            print("on?");
        }


    }

}
