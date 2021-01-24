namespace Geometric_Figures
{
    internal class Vierkant : Rechthoek
    {
        public Vierkant(int hoogte, int breedte)
        {
            if (hoogte != breedte)
            {
                breedte = hoogte;
            }
            Hoogte = hoogte;
            Breedte = breedte;
        }

        public Vierkant(int zijde)
        {
            Hoogte = zijde;
            Breedte = zijde;
        }
    }
}