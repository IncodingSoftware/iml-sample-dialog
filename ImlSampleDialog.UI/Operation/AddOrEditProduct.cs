namespace ImlSampleDialog.UI
{
    #region << Using >>

    using System;
    using System.Linq;
    using FluentValidation;
    using Incoding.CQRS;

    #endregion

    public class AddOrEditProduct : CommandBase
    {
        public string Id { get; set; }

        public string Name { get; set; }

        public override void Execute()
        {
            var fromDb = Product.Db.SingleOrDefault(r => r.Id == Id);
            var product = fromDb ?? new Product()
                                    {
                                            Id = Guid.NewGuid().ToString(),
                                            CreatedDt = DateTime.Now
                                    };
            product.Name = Name = Name;
            if (fromDb == null)
                Product.Db.Add(product);
        }

        public class Validator : AbstractValidator<AddOrEditProduct>
        {
            public Validator()
            {
                RuleFor(r => r.Name).NotEmpty();
            }
        }

        public class Get : QueryBase<AddOrEditProduct>
        {
            public string Id { get; set; }

            protected override AddOrEditProduct ExecuteResult()
            {
                var product = Product.Db.Single(r => r.Id == Id);
                return new AddOrEditProduct()
                       {
                               Id = product.Id,
                               Name = product.Name
                       };
            }
        }
    }
}