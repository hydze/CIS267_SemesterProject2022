using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class PlayerInfo
{
    private static bool isWalking;
    private static bool isFlying;
    private static float jetPackForce;
    private static float walkSpeed;
    private static bool isGrounded;

    //getter an setter for isWalking
    public static bool getIsWalking()
    {
        return isWalking;
    }
    
    public static void setIsWalking(bool walking)
    {
        isWalking = walking;
    }

    //getter and setter for isFlying
    public static bool getIsFlying()
    {
        return isFlying;
    }

    public static void setIsFlying(bool flying)
    {
        isFlying = flying;
    }

    //getter and setter for jetPackForce
    public static float getJetPackForce()
    {
        return jetPackForce;
    }

    public static void setJetPackForce(float jpf)
    {
        jetPackForce = jpf;
    }

    //getter and setter for walkSpeed
    public static float getWalkSpeed()
    {
        return walkSpeed;
    }

    public static void setWalkSpeed(float ws)
    {
        walkSpeed = ws;
    }

    //getter and setter for isGrounded
    public static bool getIsGrounded()
    {
        return isGrounded;
    }

    public static void setIsGrounded(bool grounded)
    {
        isGrounded = grounded;
    }
}
