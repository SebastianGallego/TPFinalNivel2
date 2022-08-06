
namespace Entidades
{
    public class Marca
    {
        public int Id { get; set; }
        public string DescripcionMarca { get; set; }

        public override string ToString()
        {
            return DescripcionMarca;
        }


    }
}
