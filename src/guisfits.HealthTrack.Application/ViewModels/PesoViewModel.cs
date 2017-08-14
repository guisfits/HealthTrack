﻿using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace guisfits.HealthTrack.Application.ViewModels
{
    public class PesoViewModel
    {
        [Key]
        public Guid Id { get; set; }

        public PesoViewModel()
        {
            Id = Guid.NewGuid();
        }

        [Required(ErrorMessage = "O campo Pesagem (kg) é requerido")]
        [DisplayName("Pesagem {kg}")]
        public double ValorKg { get; set; }

        [Required(ErrorMessage = "O campo Data e Hora é requerido")]
        [DisplayName("Data e Hora")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:yyyy/MM/dd H:mm}")]
        [DataType(DataType.DateTime, ErrorMessage = "Data e Hora no formato inválido")]
        public DateTime DataHora { get; set; }

        [ScaffoldColumn(false)]
        public Guid UsuarioId { get; set; }
    }
}