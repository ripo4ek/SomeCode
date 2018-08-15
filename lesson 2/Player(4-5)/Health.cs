namespace Player
{
    class Health
    {
        public float Value;

        public bool IsAlive
        {
            get
            {
                return Value > 0;
            }
        }

        public void ApplyDamage(float damage)
        {
            Value -= damage;
        }
    }
}