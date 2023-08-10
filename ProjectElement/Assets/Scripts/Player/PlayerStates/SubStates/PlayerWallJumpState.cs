using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerWallJumpState : PlayerAbilityState
{
    private float timer;
    private float timeToEnd;

    public PlayerWallJumpState(Player player, PlayerStateMachine stateMachine, PlayerData playerData, string animName) : base(player, stateMachine, playerData, animName)
    {
    }

    public override void Enter()
    {
        base.Enter();

        timer = 0f;
        timeToEnd = 0.2f;
        player.Flip();
        player.SetVelocityX(playerData.wallJumpVelocityX * player.FacingDirection);
        player.SetVelocityY(playerData.wallJumpVelocityY);
    }

    public override void LogicUpdate()
    {
        base.LogicUpdate();

        timer += Time.deltaTime;

        if(timer >= timeToEnd)
        {
            isAbilityDone = true;
        }
    }
}
