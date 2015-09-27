namespace ImlSampleDialog.UI
{
    using System.Collections.Generic;
    using System.Linq;
    using Incoding.CQRS;

    public class GetProductsQuery : QueryBase<List<GetProductsQuery.Response>>
    {
        protected override List<Response> ExecuteResult()
        {
            return Product.Db.Select(r => new Response()
                                          {
                                                  Id = r.Id,
                                                  Name = r.Name,
                                                  CreatedDt = r.CreatedDt.ToShortDateString()
                                          })
                          .ToList();
        }

        public class Response
        {
            public string Id { get; set; }

            public string Name { get; set; }

            public string CreatedDt { get; set; }
        }
    }
}