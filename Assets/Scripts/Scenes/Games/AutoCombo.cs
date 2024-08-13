using UnityEngine;

namespace Scenes.Games
{
    public class AutoCombo : MonoBehaviour
    {
        [SerializeField] private AttackSO attack;

        private void OnTriggerEnter2D(Collider2D other)
        {
            var player = other.GetComponent<PlayerCombat>();
            if (player != null)
            {
                player.combo.Add(attack);
                Destroy(gameObject);
            }
        }
    }
}