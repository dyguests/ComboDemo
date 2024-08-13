using UnityEngine;

namespace DefaultNamespace
{
    [CreateAssetMenu(fileName = "Attack", menuName = "Attacks/Normal Attack", order = 0)]
    public class AttackSO : ScriptableObject
    {
        public AnimatorOverrideController animatorOV;
        public float damage;
    }
}