
namespace Actividad_Integradora_3_Problema_3
{
    class Puntuacion
    {
        private int puntuacion;

        public Puntuacion() { }
        public void reiniciarPuntuacion()
        {
            puntuacion = 0;
        }
        public void sumarPunto()
        {
            puntuacion++;
        }
        public void restarPunto()
        {
            puntuacion--;
        }
        public int getPuntuacion()
        {
            return puntuacion;
        }
    }
}
