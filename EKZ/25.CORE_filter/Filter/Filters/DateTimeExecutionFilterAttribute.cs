using Microsoft.AspNetCore.Mvc.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Filter.Filters
{
    public class DateTimeExecutionFilterAttribute : Attribute, IResultFilter
    {
        //фильтр результата выозвется после выполнения action.Фильтры результатов выполняются только тогда, когда выполнение метода завершилось успешно.
        public void OnResultExecuting(ResultExecutingContext context)
        {
            context.HttpContext.Response.Headers.Add("DateTime", DateTime.Now.ToString());
        }
        public void OnResultExecuted(ResultExecutedContext context)
        {

        }
    }
}
