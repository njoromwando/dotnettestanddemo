using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using DemoLibrary.Model;
using MediatR;

namespace DemoLibrary.Queries
{
    public record GetPersonListQuery() : IRequest<List<PersonsModel>>;
   
}
