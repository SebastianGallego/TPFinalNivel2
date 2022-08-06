﻿using System.ComponentModel;


namespace Entidades
{
    public class Articulo
    {
        public int Id { get; set; }

        [DisplayName("Código")]
        public string Codigo { get; set; }
        
        public string Nombre { get; set; }
        
        [DisplayName("Descripción")]
        public string Descripcion { get; set; }
        
        public Marca Marca { get; set; }
        public Categoria Categoria  { get; set; }

        public string ImagenUrl { get; set; }

        public decimal Precio { get; set; }   



    }
}
