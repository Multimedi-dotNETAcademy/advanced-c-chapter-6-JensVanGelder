namespace Geometric_Figures
{
    internal abstract class GeometricFigure
    {
        public int Hoogte { get; set; }
        public int Breedte { get; set; }
        public int Oppervlakte { get { return BerekenOppervlakte(); } }

        public abstract int BerekenOppervlakte();

        public override string ToString()
        {
            return $"{this.GetType().Name} - [{Hoogte},{Breedte}] - Oppervlakte: {Oppervlakte}";
        }
    }
}