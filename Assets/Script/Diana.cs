using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UIElements;

public class Diana : MonoBehaviour
{
    public GameObject diana;
    

    // Start is called before the first frame update
    void Start()
    {
        PonerDiana();
    }

    // Update is called once per frame
    void Update()
    {
        if(GameObject.FindGameObjectWithTag("Diana") == null) 
        {
            GameObject clone;
            diana.transform.position= new Vector3(Random.Range(0.9f,2.4f), Random.Range(1.1f, 1.9f), 5.5f);
            clone = Instantiate(diana);
        }
    }
    private void PonerDiana()
    {
        GameObject clone;
        clone = Instantiate(diana);
    }
    

}

