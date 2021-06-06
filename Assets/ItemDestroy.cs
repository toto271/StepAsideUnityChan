using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemDestroy : MonoBehaviour
{
    private GameObject unitychan;
    public GameObject carPrefab;
    public GameObject coinPrefab;
    public GameObject conePrefab;
    // Start is called before the first frame update
    void Start()
    {
        this.unitychan = GameObject.Find("unitychan");

    }


    // Update is called once per frame
    void Update()
    {
    if (this.transform.position.z < this.unitychan.transform.position.z)
    {
        Destroy(this.gameObject);
    }
    }
}
