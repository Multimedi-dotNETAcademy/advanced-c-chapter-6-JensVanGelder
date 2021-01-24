namespace Geometric_Figures
{
    internal class Driehoek : GeometricFigure
    {
        public override int BerekenOppervlakte()
        {
            return (Hoogte * Breedte) / 2;
        }
    }
}