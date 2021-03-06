using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackColliderCheck : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D col)
    {
        // 攻撃を行ったときに相手のモードと自分のモードが違うときに攻撃を通す 
        if (col.transform.tag.Equals("Enemy") && PlayerStatus.playerModeState != col.gameObject.GetComponent<EnemyControler>().enemyMode)
        {
            // EnemyオブジェクトのHP実数値を習得してきてPlayerのATK分値を減らす
            col.gameObject.GetComponent<EnemyControler>()._localHp -= PlayerStatus.atk;
            SoundManager.Instance.PlaySE(0);
        }
    }
}
