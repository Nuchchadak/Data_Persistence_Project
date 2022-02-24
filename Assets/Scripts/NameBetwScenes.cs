using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NameBetwScenes : MonoBehaviour
{
    public static NameBetwScenes Instance;

    public string playerName; 

    private void Awake()
    {
        if (Instance != null)
        {
            Destroy(gameObject);
            return;
        }

        Instance = this;
        DontDestroyOnLoad(gameObject);
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
