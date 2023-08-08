using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName ="newPlayerData", menuName ="Data/Player Data/Base Data")]
public class PlayerData : ScriptableObject
{
    [Header("Move State")]
    public float movementVelocity = 10f;
    public float acceleration = 0.1f;

    [Header("Jump State")]
    public float jumpVelocity = 15f;
    public int amountOfJumps = 1;

    [Header("In Air State")]
    public float coyoteTime = 0.2f;
    public float variableJumpHeightMultiplier = 0.5f;
    public float inAirMaxVelocity = 3f;
    public float inAirAcceleration = 0.05f;


    [Header("Wall Slide State")]
    public float wallSlideVelocity = 3f;

    [Header("Wall Jump State")]
    public float wallJumpVelocityX = 10f;
    public float wallJumpVelocityY = 12f;

    [Header("Check Variables")]
    public float groundCheckRadius = 0.2f;
    public float wallCheckRadius = 0.5f;
    public LayerMask whatIsGround;
}
