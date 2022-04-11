using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Oscillator : MonoBehaviour
{
    float timeCounter = 0;

    public int speed; //在Inspector Window可以編輯
    public int width; //在Inspector Window可以編輯
    public int height; //在Inspector Window可以編輯
    public int depth; //在Inspector Window可以編輯

    float x;
    float y;
    float z;

    // Start is called before the first frame update
    void Start()
    {
       gameObject.transform.position = new Vector3(x, y, z);
    }

    // Update is called once per frame
    void Update()
    {
        timeCounter += Time.deltaTime * speed;

        //變化軌跡
        //Oscillator：繞圓運動透過三角函數計算位移變量，需再加上被繞物體的position。
        //再計算位移變量的式子中，直接找到GameObject的transform.position.x。
        //正負號意思為以被繞物體的位置作為中心，加減以width, height, depth作為三維座標的自定義定量。

        float x = GameObject.Find("CircleBall1").transform.position.x +- Mathf.Cos(timeCounter) * width;
        float y = GameObject.Find("CircleBall1").transform.position.y +- Mathf.Sin(timeCounter) * height;
        float z = GameObject.Find("CircleBall1").transform.position.z +- Mathf.Cos(timeCounter) * depth;

        transform.position = new Vector3(x, y, z);
    }
}
