﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Abp.Application.Services.Dto;

namespace Wu.MyProject.People.Dtos
{
    public class GetAllPeopleOutput : IOutputDto
    {
        public List<PersonDto> People { get; set; }

    }
}
