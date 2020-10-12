using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class color_pick : MonoBehaviour
{
    public GameObject colorObj;
    Vector3 mpos;
    //public bool isrun = false;
    public Color lastcolor;

    void Start()
    {

    }

    void Update()
    {
        // if (Input.GetMouseButtonDown(2)) { moonrake(); }

        // print (Input.mousePosition);
        
        mpos = Input.mousePosition;
        if (Input.GetMouseButtonDown(0))
        {
            StartCoroutine(ScreenShotAndSpoid());
        }
         
        
    }
    IEnumerator ScreenShotAndSpoid()
    {
        Texture2D tex = new Texture2D(Screen.width, Screen.height, TextureFormat.RGB24, false);
        yield return new WaitForEndOfFrame();
        tex.ReadPixels(new Rect(0, 0, Screen.width, Screen.height), 0, 0);
        tex.Apply();

        Color color = tex.GetPixel((int)mpos.x, (int)mpos.y);
        //colorObj.GetComponent<Renderer>().material.color = color;
        lastcolor = color;

        if (!EventSystem.current.IsPointerOverGameObject())
        {
            colorObj.GetComponent<Image>().color = color;
        }
        
    }
    //public void OnSpoteButton()
    //{
    //    isrun = true;
    //}
    //public void OffSpoteButton()    // 펜 입력할 경우 isrun = false;
    //{
    //    isrun = false;
    //}
}