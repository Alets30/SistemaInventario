﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaInventario.Modelos
{
    public class Producto
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "El número de serie es requerido")]
        [MaxLength(30, ErrorMessage = "Máximo 30 caracteres")]
        public string NumeroSerie { get; set; }
        [Required(ErrorMessage = "La descripción es requerida")]
        [MaxLength(100, ErrorMessage = "Máximo 100 caracteres")]
        public string Descripcion { get; set; }
        [Required(ErrorMessage = "Precio requerido")]
        public double Precio { get; set; }
        [Required(ErrorMessage = "Costo requerido")]
        public double Costo { get; set; }
        public string ImagenUrl { get; set; }
        [Required(ErrorMessage = "El Estado es Requerido")]
        public bool Estado { get; set; }

        //Hagamos la relación con la tabla categoría
        [Required(ErrorMessage = "La categoría es requerida")]
        public int CategoriaId { get; set; }
        [ForeignKey("CategoriaId")]
        public Categoria Categoria { get; set; }

        //Hagamos la relación con la tabla Marca
        [Required(ErrorMessage = "La marca es requerida")]
        public int MarcaId { get; set; }
        [ForeignKey("MarcaId")]
        public Marca Marca { get; set; }

        //Hagamos la recursividad del padre
        public int? PadreId { get; set; }
        public virtual Producto Padre { get; set;}
    }
}
