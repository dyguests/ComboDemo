using UnityEngine;

namespace Scenes.Games
{
    public class Weapon : MonoBehaviour
    {
        public float damage;
    
        [SerializeField] private BoxCollider2D triggerBox;
    }
}