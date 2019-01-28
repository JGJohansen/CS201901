namespace Arv_terning
{
    public class LudoTerning : Terning
    {

        public bool ErGlobus()
        {
            if (this.Værdi == 3)
                return true;
            else
                return false;

        }
        public bool ErStjerne()
        {
            if (this.Værdi == 5)
                return true;
            else
                return false;

        }

        public LudoTerning() : base()
        {

        }

        public LudoTerning(int værdi) : base(værdi)
        {

        }
    }
}

