using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Class that represents a Joystick (gamepad, controller ...)
// Concrete subclasses need simply to do the mapping
// VirtualButton-->Unity Input Button  
public abstract class VirtualJoystick  
{
    public abstract Vector2 LeftAnalogueData();
    public abstract Vector2 RightAnalogueData();
    
    public abstract bool IsStartPressed();
    public abstract bool IsSelectPressed();
    
    public abstract bool IsFaceUpPressed();
    public abstract bool IsFaceDownressed();
    public abstract bool IsFaceLeftPressed();
    public abstract bool IsFaceRightPressed();
    
    public abstract bool IsArrowUpPressed();
    public abstract bool IsArrowDownressed();
    public abstract bool IsArrowLeftPressed();
    public abstract bool IsArrowRightPressed();
    
    public abstract bool IsLeftShoulderPressed();
    public abstract bool IsLeftTriggerPressed();
    
    public abstract bool IsRightShoulderPressed();
    public abstract bool IsRightTriggerPressed();
}
