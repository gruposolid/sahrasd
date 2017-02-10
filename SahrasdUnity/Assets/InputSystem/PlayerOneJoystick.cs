using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerOneJoystick : VirtualJoystick
{
    public Vector2 LeftAnalogueData()
    {
        Vector2 data = Vector2.zero;
        data.x = Input.GetRawAxis("P1LeftHorizontal");
        data.y = Input.GetRawAxis("P1LeftVertical");
        return data;
    }
    
    public Vector2 RightAnalogueData()
    {
        Vector2 data = Vector2.zero;
        data.x = Input.GetRawAxis("P1RightHorizontal");
        data.y = Input.GetRawAxis("P1RightVertical");
        return data;
    }
    
    public  bool IsStartPressed()
    {
        return Input.GetButton("P1Start");
    }
    
    public  bool IsSelectPressed()
    {
        return Input.GetButton("P1Select");
    }
    
    // Face Buttons
    public  bool IsFaceUpPressed()
    {
        return Input.GetButton("P1FaceUp");
    }
    
    public  bool IsFaceDownressed()
    {
        return Input.GetButton("P1FaceDown");
    }
    
    public  bool IsFaceLeftPressed()
    {
        return Input.GetButton("P1FaceLeft");
    }
    
    public  bool IsFaceRightPressed()
    {
        return Input.GetButton("P1FaceRight");
    }
    
    
    // Arrow Buttons
    public  bool IsArrowUpPressed()
    {
        return Input.GetButton("P1ArrowUp");
    }
    
    public  bool IsArrowDownressed()
    {
        return Input.GetButton("P1ArrowDown");
    }
    
    public  bool IsArrowLeftPressed()
    {
        return Input.GetButton("P1ArrowLeft");
    }
    
    public  bool IsArrowRightPressed()
    {
        return Input.GetButton("P1ArrowRight");
    }
    
    
    // Left Shoulder Buttons
    public  bool IsLeftShoulderPressed()
    {
        return Input.GetButton("P1LeftShoulder");
    }
    
    public  bool IsLeftTriggerPressed()
    {
        return Input.GetButton("P1LeftTrigger");
    }
    
    
    // Right Shoulder Buttons
    public  bool IsRightShoulderPressed()
    {
        return Input.GetButton("P1RightShoulder");
    }
    
    public  bool IsRightTriggerPressed()
    {
        return Input.GetButton("P1RightTrigger");
    }
}
