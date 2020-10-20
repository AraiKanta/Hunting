using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputDemo : MonoBehaviour
{
    void Update()
    {
        if (Input.GetKeyDown("joystick button 0"))
        {
            Debug.Log("buttonA");
        }
        if (Input.GetKeyDown("joystick button 1"))
        {
            Debug.Log("buttonB");
        }
        if (Input.GetKeyDown("joystick button 2"))
        {
            Debug.Log("buttonX");
        }
        if (Input.GetKeyDown("joystick button 3"))
        {
            Debug.Log("buttonY");
        }
        if (Input.GetKeyDown("joystick button 4"))
        {
            Debug.Log("buttonLB");
        }
        if (Input.GetKeyDown("joystick button 5"))
        {
            Debug.Log("buttonRB");
        }
        if (Input.GetKeyDown("joystick button 6"))
        {
            Debug.Log("buttonView");
        }
        if (Input.GetKeyDown("joystick button 7"))
        {
            Debug.Log("buttonMenu");
        }
        if (Input.GetKeyDown("joystick button 8"))
        {
            Debug.Log("buttonLStick");
        }
        if (Input.GetKeyDown("joystick button 9"))
        {
            Debug.Log("buttonRStick");
        }
        float hori = Input.GetAxis("Horizontal");
        float vert = Input.GetAxis("Vertical");
        if ((hori != 0) || (vert != 0))
        {
            Debug.Log("stick:" + hori + "," + vert);
        }
        //L Stick
        float lsh = Input.GetAxis("L_Stick_H");
        float lsv = Input.GetAxis("L_Stick_V");
        if ((lsh != 0) || (lsv != 0))
        {
            Debug.Log("L_stick:" + lsh + "," + lsv);
        }
        //R Stick
        float rsh = Input.GetAxis("R_Stick_H");
        float rsv = Input.GetAxis("R_Stick_V");
        if ((rsh != 0) || (rsv != 0))
        {
            Debug.Log("R_stick:" + rsh + "," + rsv);
        }
        //D-Pad
        float dph = Input.GetAxis("D_Pad_H");
        float dpv = Input.GetAxis("D_Pad_V");
        if ((dph != 0) || (dpv != 0))
        {
            Debug.Log("D_Pad:" + dph + "," + dpv);
        }
        //Trigger
        float tri = Input.GetAxis("Trigger_LR");
        if (tri > 0)
        {
            Debug.Log("L_trigger:" + tri);
        }
        else if (tri < 0)
        {
            Debug.Log("R_trigger:" + tri);
        }
        //else
        //{
        //    Debug.Log("  trigger:none");
        //}
    }
}

