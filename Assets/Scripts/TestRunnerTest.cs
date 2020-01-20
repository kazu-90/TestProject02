using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestRunnerTest : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public static string GetText(int id)
    {
        //Debug.Log(string.Format("id:{0}" + id));
        return string.Format("id:{0}", id);
    }
}
