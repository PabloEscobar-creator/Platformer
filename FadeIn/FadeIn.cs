using Godot;
using System;

public class FadeIn : ColorRect
{
    [Signal] 
    delegate void FadeFinished();
    
    public void OnAnimationPlayerAnimationFinished() {
        EmitSignal("FadeFinished");
    }
}
