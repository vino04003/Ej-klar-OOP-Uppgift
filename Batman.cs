class Batman: IDamage
{
    public int BAcurrentLife; //BA-- står för Batmans nuvarande och max liv
    public int BAmaxLife;
    private int damage = 5;

    public Batman()
    {
    }

    public Batman(int BAmaxLife)
    {
        this.BAmaxLife = BAmaxLife;
        this.BAcurrentLife = BAmaxLife;
    }

    public virtual void Attack()
    {
        Console.WriteLine("Batman attacks");
    }

    public int Damage
    {
        get { return damage; }
    }
    public void DealDamage(string target)
    {
        Console.WriteLine("Batman deals " + Damage + " damage to " + target);
    }
}