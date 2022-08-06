

namespace Entidades
{
    public class Categoria
    {

        public int Id { get; set; }
        public string DescripcionCategoria { get; set; }

        public override string ToString()
        {
            return DescripcionCategoria;
        }

    }
}
