using UnityEngine;

namespace Core
{
    public class Life 
    {
        private const int MAX_VALUE = 100;
        private const int MIN_VALUE = 0;

        public int CurrentValue = MAX_VALUE;
    
        public void ReceiveDamage(int amount)
        {
            CurrentValue = Mathf.Max(MIN_VALUE, CurrentValue - amount);
        }

        public void ReceiveHeal(int amount)
        {
            CurrentValue = Mathf.Min(MAX_VALUE, CurrentValue + amount);
        }
    }
}