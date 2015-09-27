Sample dialog (ajax) with <a href="incframework.com/en-US"> Incoding framework </a>

# Open dialog (ajax get)
```
@(Html.When(JqueryBind.Click)
                              .AjaxGet(Url.Dispatcher().Query(new AddOrEditProduct.Get()
                                                              {
                                                                      Id = each.For(r => r.Id)
                                                              })
                                          .AsView("~/Views/Product/AddOrEdit.cshtml"))
                              .OnSuccess(dsl => dsl.WithId("dialogId")
                                                   .Behaviors(inDsl =>
                                                              {
                                       inDsl.Core().Insert.Html();
                                       inDsl.JqueryUI().Dialog.Open(options => { options.Title = "Add product"; });
                                                              })
                                  )
                              .AsHtmlAttributes()
                              .ToLink(each.For(r => r.Name)))
```


# Form (submit ajax)
```
@using (@Html.When(JqueryBind.InitIncoding)
             .Direct()
             .OnSuccess(dsl => dsl.Self().Core().Form.Validation.Parse())
             .When(JqueryBind.Submit)
             .PreventDefault()
             .Submit()
             .OnSuccess(dsl =>
                        {
                            dsl.WithId("dialogId").JqueryUI().Dialog.Close();
                            dsl.WithId(typeof(GetProductsQuery).Name).Core().Trigger.Incoding();
                        })
             .AsHtmlAttributes()
             .ToBeginForm(Html, Url.Dispatcher().Push(new AddOrEditProduct())))
{
    @Html.ForGroup(r => r.Id).Hidden()
    @Html.ForGroup(r => r.Name).TextBox()
    <input type="submit" value="Save"/>
    @(Html.When(JqueryBind.Submit)
          .StopPropagation()
          .Direct()
          .OnSuccess(dsl => dsl.WithId("dialogId").JqueryUI().Dialog.Close())
          .AsHtmlAttributes()
          .ToButton("Close"))
}
```
