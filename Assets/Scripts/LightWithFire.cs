using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightWithFire : MonoBehaviour
{
    public GameObject fire;

    // Start is called before the first frame update
    void Start()
    {
        fire.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Fireball")
        {
            fire.SetActive(true);
        }

        if (other.tag == "Water")
        {
            fire.SetActive(false);
        }
    }
}
