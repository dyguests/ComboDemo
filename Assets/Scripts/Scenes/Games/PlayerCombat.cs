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

        public Animator anim;
        [SerializeField] Weapon weapon;

        private void Start()
        {
            // todo impl
            // anim = GetComponent<Animator>();
        }

        private void Update()
        {
            if (Input.GetButtonDown("Fire1"))
            {
                Attack();
            }

            ExitAttack();
        }

        void Attack()
        {
            if (Time.time - lastComboEnd > 0.2f && comboCounter < combo.Count)
            {
                CancelInvoke(nameof(EndCombo));
                if (Time.time - lastClickedTime > 0.2f)
                {
                    anim.runtimeAnimatorController = combo[comboCounter].animatorOV;
                    anim.Play("Attack", 0, 0);
                    weapon.damage = combo[comboCounter].damage;
                    comboCounter++;
                    lastClickedTime = Time.time;

                    if (comboCounter >= combo.Count)
                    {
                        comboCounter = 0;
                    }
                }
            }
        }

        void ExitAttack()
        {
            if (anim.GetCurrentAnimatorStateInfo(0).normalizedTime > 0.9f && anim.GetCurrentAnimatorStateInfo(0).IsTag("Attack"))
            {
                Invoke(nameof(EndCombo), 1f);
            }
        }

        void EndCombo()
        {
            comboCounter = 0;
            lastComboEnd = Time.time;
        }
    }
}