﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFoo.Application.Features.PatientMaterials.Delete
{
    public class DeletePatientMaterialResponse
    {
        public bool Success { get; set; }
        public string Message { get; set; } = string.Empty;
    }
}
