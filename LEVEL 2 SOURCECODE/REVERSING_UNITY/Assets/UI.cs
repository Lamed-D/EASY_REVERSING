using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UI : MonoBehaviour
{
    public int testvalue;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (testvalue != 77777)
        {
            this.GetComponent<Text>().text = "TEST = " + testvalue.ToString("D5") + "\nTEST 값을 77777으로 바꾸면 FLAG가나옵니다 OR 시작하면 삭제될FLAG를살리세요";
        }
        else
            this.GetComponent<Text>().text = "FLAG:{YOU_CRACKED_GAME}";
    }
}
