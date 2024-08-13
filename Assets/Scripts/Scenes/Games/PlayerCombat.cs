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
        
        // todo video 09:40
        
        void Attack() { }

        void ExitAttack() { }

        void EndCombo() { }
    }
}