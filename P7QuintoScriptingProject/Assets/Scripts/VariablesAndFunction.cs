using UnityEngine;
using System.Collections;

public class VariablesAndFunction : MonoBehaviour
{
    int myInt = 5;

    // Start is called before the first frame update
    void Start()
    {
        myInt = MultiplyByTwo(myInt);
        Debug.Log(myInt);
    }

    // Update is called once per frame
    void Update()
    {

    }

    int MultiplyByTwo (int number)
    {
        int result;
        result = number * 2;
        return result;
    }
}
