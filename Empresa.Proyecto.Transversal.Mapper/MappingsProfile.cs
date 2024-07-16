using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Empresa.Proyecto.Domain.Entity;
using Empresa.Proyecto.Aplicacion.DTO;
using AutoMapper;



namespace Empresa.Proyecto.Transversal.Mapper
{
    public class MappingsProfile: Profile
    {
        public MappingsProfile()
        {
            CreateMap<Customers,CustomersDTO>().ReverseMap();
        }
    }
}
