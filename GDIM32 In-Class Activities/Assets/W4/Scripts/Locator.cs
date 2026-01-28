using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Locator : MonoBehaviour
{
    // Start is called before the first frame update
    public static Locator Instance { get; private set; }
    public W4Pigeon player { get; private set; }


    private void Awake()
    {
        if(Instance != null && Instance != this)
        {
            Destroy(this);
            return;
        }

        Instance = this;

        GameObject pigeonObj = GameObject.FindWithTag("Player");
        player = pigeonObj.GetComponent<W4Pigeon>();
    }

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
