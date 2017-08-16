using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Swashbuckle.Swagger.Annotations;
using BdPruebaApiApp.Models;
using BdPruebaApiApp.DTO;

namespace BdPruebaApiApp.Controllers
{
    public class ValuesController : ApiController
    {
        //// GET api/values
        //[SwaggerOperation("GetAll")]
        //public IEnumerable<string> Get()
        //{
        //    return new string[] { "value1", "value2" };
   // }
   // GET api/values
   [SwaggerOperation("GetAllProductos")]
        public IEnumerable<string> GetProductos()
    {

        IEnumerable<string> lista=new string[] { };

        using (DBPRUEBAEntities1 dbo = new DBPRUEBAEntities1())
        {

            var list = dbo.usp_SelectProducts().ToList();

            foreach (var e in list)
            {
               lista= lista.Concat(new string[] { e.Nombre,e.Precio.ToString(),e.SKU,e.IdProducto.ToString() });
            }
        }
        return lista;
    }

    // GET api/values/5
    [SwaggerOperation("GetById")]
        [SwaggerResponse(HttpStatusCode.OK)]
        [SwaggerResponse(HttpStatusCode.NotFound)]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        [SwaggerOperation("Create")]
        [SwaggerResponse(HttpStatusCode.Created)]
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        [SwaggerOperation("Update")]
        [SwaggerResponse(HttpStatusCode.OK)]
        [SwaggerResponse(HttpStatusCode.NotFound)]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        [SwaggerOperation("Delete")]
        [SwaggerResponse(HttpStatusCode.OK)]
        [SwaggerResponse(HttpStatusCode.NotFound)]
        public void Delete(int id)
        {
        }
    }
}
