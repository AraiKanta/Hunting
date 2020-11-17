using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class InputDemo : MonoBehaviour
{
    void Update()
    {
        ////Xbox one
        //if (Input.GetKeyDown("joystick button 0"))
        //{
        //    Debug.Log("buttonA");
        //}
        //if (Input.GetKeyDown("joystick button 1"))
        //{
        //    Debug.Log("buttonB");
        //}
        //if (Input.GetKeyDown("joystick button 2"))
        //{
        //    Debug.Log("buttonX");
        //}
        //if (Input.GetKeyDown("joystick button 3"))
        //{
        //    Debug.Log("buttonY");
        //}
        //if (Input.GetKeyDown("joystick button 4"))
        //{
        //    Debug.Log("buttonLB");
        //}
        //if (Input.GetKeyDown("joystick button 5"))
        //{
        //    Debug.Log("buttonRB");
        //}
        //if (Input.GetKeyDown("joystick button 6"))
        //{
        //    Debug.Log("buttonView");
        //}
        //if (Input.GetKeyDown("joystick button 7"))
        //{
        //    Debug.Log("buttonMenu");
        //}
        //if (Input.GetKeyDown("joystick button 8"))
        //{
        //    Debug.Log("buttonLStick");
        //}
        //if (Input.GetKeyDown("joystick button 9"))
        //{
        //    Debug.Log("buttonRStick");
        //}
        //float hori = Input.GetAxis("Horizontal");
        //float vert = Input.GetAxis("Vertical");
        //if ((hori != 0) || (vert != 0))
        //{
        //    Debug.Log("stick:" + hori + "," + vert);
        //}
        ////L Stick
        //float lsh = Input.GetAxis("L_Stick_H");
        //float lsv = Input.GetAxis("L_Stick_V");
        //if ((lsh != 0) || (lsv != 0))
        //{
        //    Debug.Log("L_stick:" + lsh + "," + lsv);
        //}
        ////R Stick
        //float rsh = Input.GetAxis("R_Stick_H");
        //float rsv = Input.GetAxis("R_Stick_V");
        //if ((rsh != 0) || (rsv != 0))
        //{
        //    Debug.Log("R_stick:" + rsh + "," + rsv);
        //}
        ////D-Pad
        //float dph = Input.GetAxis("D_Pad_H");
        //float dpv = Input.GetAxis("D_Pad_V");
        //if ((dph != 0) || (dpv != 0))
        //{
        //    Debug.Log("D_Pad:" + dph + "," + dpv);
        //}
        ////Trigger
        //float tri = Input.GetAxis("Trigger_LR");
        //if (tri > 0)
        //{
        //    Debug.Log("L_trigger:" + tri);
        //}
        //else if (tri < 0)
        //{
        //    Debug.Log("R_trigger:" + tri);
        //}
        
        //DS4
        if (Input.GetKeyDown("joystick button 0"))
        {
            Debug.Log("button□");
        }
        if (Input.GetKeyDown("joystick button 1"))
        {
            Debug.Log("buttonX");
        }
        if (Input.GetKeyDown("joystick button 2"))
        {
            Debug.Log("button〇");
        }
        if (Input.GetKeyDown("joystick button 3"))
        {
            Debug.Log("button△");
        }
        if (Input.GetKeyDown("joystick button 4"))
        {
            Debug.Log("buttonL1");
        }
        if (Input.GetKeyDown("joystick button 5"))
        {
            Debug.Log("buttonR1");
        }
        if (Input.GetKeyDown("joystick button 6"))
        {
            Debug.Log("buttonL2");
        }
        if (Input.GetKeyDown("joystick button 7"))
        {
            Debug.Log("buttonR2");
        }
        if (Input.GetKeyDown("joystick button 8"))
        {
            Debug.Log("buttonShare");
        }
        if (Input.GetKeyDown("joystick button 9"))
        {
            Debug.Log("buttonOption");
        }
        if (Input.GetKeyDown("joystick button 10"))
        {
            Debug.Log("buttonL3");
        }
        if (Input.GetKeyDown("joystick button 11"))
        {
            Debug.Log("buttonR3");
        }
        if (Input.GetKeyDown("joystick button 12"))
        {
            Debug.Log("buttonPS");
        }
        if (Input.GetKeyDown("joystick button 13"))
        {
            Debug.Log("buttonTrackpad");
        }
        float horizon = Input.GetAxis("Horizontal");
        float verti = Input.GetAxis("Vertical");
        if ((horizon != 0) || (verti != 0))
        {
            Debug.Log("stick:" + horizon + "," + verti);
        }
        //L Stick
        float lshori = Input.GetAxis("DS4_L_Stick_H");
        float lsver = Input.GetAxis("DS4_L_Stick_V");
        if ((lshori != 0) || (lsver != 0))
        {
            Debug.Log("DS4_L_stick:" + lshori + "," + lsver);
        }
        //R Stick
        float rshori = Input.GetAxis("DS4_R_Stick_H");
        float rsverti = Input.GetAxis("DS4_R_Stick_V");
        if ((rshori != 0) || (rsverti != 0))
        {
            Debug.Log("DS4_R_stick:" + rshori + "," + rsverti);
        }
        //D-Pad
        float dphhori = Input.GetAxis("DS4_D_Pad_H");
        float dpverti = Input.GetAxis("DS4_D_Pad_V");
        if ((dphhori != 0) || (dpverti != 0))
        {
            Debug.Log("DS4_D_Pad:" + dphhori + "," + dpverti);
        }
        //Trigger
        float trigger = Input.GetAxis("L2");
        if (trigger > 0)
        {
            Debug.Log("L2:" + trigger);
        }
        float trigger1 = Input.GetAxis("R2");
        if (trigger1 < 0)
        {
            Debug.Log("R2:" + trigger1);
        }
    }
}

