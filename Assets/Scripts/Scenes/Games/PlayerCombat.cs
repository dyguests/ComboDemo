using System.Collections.Generic;
using UnityEngine;

namespace Scenes.Games
{
    public class PlayerCombat : MonoBehaviour
    {
        public List<AttackSO> combo;
        float lastClickedTime;
        float lastComboEnd;
        int comboCounter;

        Animator anim;

        void Attack()
        {
            if (Time.time - lastComboEnd > 0.2f && comboCounter <= combo.Count)
            {
                CancelInvoke(nameof(EndCombo));
                if (Time.time - lastClickedTime > 0.2f)
                {
                    anim.runtimeAnimatorController = combo[comboCounter].animatorOV;
                    anim.Play("Attack", 0, 0);
                }
            }
        }

        void ExitAttack() { }

        void EndCombo() { }
    }
}