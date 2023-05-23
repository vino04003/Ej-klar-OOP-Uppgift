class Joker : Batman, IDamage
{
    public int JOcurrentLife; //JO --- står för Jokers nuvarande och max liv (dålig fantasi)
    public int JOmaxLife;
    private int damage = 2;
    public Joker(): base(10){
        this.JOmaxLife = 20;
        this.JOcurrentLife = 9;
    }

    public override void Attack()
    {
        Console.WriteLine("Joker takes big damage");
        JOcurrentLife -= 5;

    }
    public void batmanAttack()
    {
        BAcurrentLife -= 2;
    }

     public new int Damage
    {
        get { return damage; }
    }
    public new void DealDamage(string target)
    {
        Console.WriteLine("Joker deals " + Damage + " damage to " + target);
    }
}