﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WorldSkills.DataBase;
using WorldSkills.DataBase.Models;

namespace WorldSkills.Controllers
{
    public class GetOrderByIdController : ApiController
    {

        public IEnumerable<Nomenclature> Get(int idOrder)
        {
            Context db = new Context();

            var orderNoms = db.OrderNoms.Where(x => x.OrderId == idOrder).Include(x => x.Nomenclature).Select(x => x.Nomenclature).ToList();

            var order = db.Orders.Include(x => x.OrderNoms).FirstOrDefault(x => x.Id == idOrder);
            return orderNoms;
        }
    }
}
