using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerOneJoystick : VirtualJoystick
{
    public override Vector2 LeftAnalogueData()
    {
        Vector2 data = Vector2.zero;
        data.x = Input.GetAxisRaw("P1LeftHorizontal");
        data.y = Input.GetAxisRaw("P1LeftVertical");
        return data;
    }
    
    public override Vector2 RightAnalogueData()
    {
        Vector2 data = Vector2.zero;
        data.x = Input.GetAxisRaw("P1RightHorizontal");
        data.y = Input.GetAxisRaw("P1RightVertical");
        return data;
    }
    
    public override  bool IsStartPressed()
    {
        return Input.GetButton("P1Start");
    }
    
    public override  bool IsSelectPressed()
    {
        return Input.GetButton("P1Select");
    }
    
    // Face Buttons
    public override  bool IsFaceUpPressed()
    {
        return Input.GetButton("P1FaceUp");
    }
    
    public override  bool IsFaceDownressed()
    {
        return Input.GetButton("P1FaceDown");
    }
    
    public override  bool IsFaceLeftPressed()
    {
        return Input.GetButton("P1FaceLeft");
    }
    
    public override  bool IsFaceRightPressed()
    {
        return Input.GetButton("P1FaceRight");
    }
    
    
    // Arrow Buttons
    public override  bool IsArrowUpPressed()
    {
        return Input.GetButton("P1ArrowUp");
    }
    
    public override  bool IsArrowDownressed()
    {
        return Input.GetButton("P1ArrowDown");
    }
    
    public override  bool IsArrowLeftPressed()
    {
        return Input.GetButton("P1ArrowLeft");
    }
    
    public override  bool IsArrowRightPressed()
    {
        return Input.GetButton("P1ArrowRight");
    }
    
    
    // Left Shoulder Buttons
    public override  bool IsLeftShoulderPressed()
    {
        return Input.GetButton("P1LeftShoulder");
    }
    
    public override  bool IsLeftTriggerPressed()
    {
        return Input.GetButton("P1LeftTrigger");
    }
    
    
    // Right Shoulder Buttons
    public override  bool IsRightShoulderPressed()
    {
        return Input.GetButton("P1RightShoulder");
    }
    
    public override  bool IsRightTriggerPressed()
    {
        return Input.GetButton("P1RightTrigger");
    }
}
