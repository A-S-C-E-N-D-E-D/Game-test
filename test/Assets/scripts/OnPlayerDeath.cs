using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnPlayerDeath : OnDeath{
    public int lives;
    public override void Die()
    {
        if(lives == 0){
            Application.Quit();
        }
        trans.position = deathPos;
        trans.rotation = new Quaternion(0, 0, 0, 0);
        lives--;
    }
}
