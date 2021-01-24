namespace Geometric_Figures
{
    internal class Rechthoek : GeometricFigure
    {
        public override int BerekenOppervlakte()
        {
            return Breedte * Hoogte;
        }
    }
}