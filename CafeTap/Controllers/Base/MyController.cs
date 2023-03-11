using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using AutoMapper;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Routing;
using Microsoft.Extensions.DependencyInjection;

namespace CafeTap.Controllers.Base
{
    public class MyController : Controller
    {
        private IMediator _mediator;
        private IMapper _mapper;

        protected IMediator Mediator => _mediator ??= HttpContext.RequestServices
            .GetService<IMediator>();
        protected IMapper Mapper => _mapper ??= HttpContext.RequestServices.GetService<IMapper>();


        protected void ErrorHandler()
        {
            foreach (var error in ModelState.Values.SelectMany(e => e.Errors.Select(e => e.ErrorMessage)))
            {
                ModelState.AddModelError(string.Empty, error);
            }
        }
        protected void AddError(string errorName)
        {
            ModelState.AddModelError(string.Empty, errorName);
        }

        protected void AddError(List<string> errorNames)
        {
            foreach (var error in errorNames)
            {
                ModelState.AddModelError(string.Empty, error);
            }
        }

        public virtual IActionResult RedirectToAnotherAction<TDestination>(Expression<Action<TDestination>> destinationAction) where TDestination : ControllerBase
        {
            if (destinationAction.Body.NodeType != ExpressionType.Call)
            {
                throw new InvalidOperationException($"Expression is not a valid method call: {destinationAction.Body}");
            }
            var methodCallExpression = (MethodCallExpression)destinationAction.Body;
            var actionName = GetActionName(methodCallExpression);
            var controllerName = typeof(TDestination).Name.ToUpper().Replace(nameof(Controller).ToUpper(), string.Empty);
            controllerName = controllerName.ToLower();
            var parameters = ExtractRouteValue(methodCallExpression);
            return this.RedirectToAction(actionName, controllerName, parameters);
        }
        private static RouteValueDictionary ExtractRouteValue(MethodCallExpression methodCallExpression)
        {
            var parameters = methodCallExpression.Method.GetParameters().Select(e => e.Name).ToArray();
            var values = methodCallExpression.Arguments.Select(arg =>
            {
                if (arg.NodeType == ExpressionType.Constant)
                {
                    var constExt = (ConstantExpression)arg;
                    return constExt.Value;
                }

                var convertedValue = Expression.Convert(arg, typeof(object));
                var funExpression = Expression.Lambda<Func<object>>(convertedValue);
                return funExpression.Compile().Invoke();
            }).ToArray();

            RouteValueDictionary routeValueDictionary = new RouteValueDictionary();
            for (int i = 0; i < parameters.Length; i++)
            {
                if (parameters[i] is null || values[i] is null)
                {
                    continue;
                }
                routeValueDictionary.TryAdd(parameters[i], values[i]);

            }

            return routeValueDictionary;
        }

        private static string GetActionName(MethodCallExpression expression)
        {
            var methodName = expression.Method.Name;

            var actionName =
                expression
                    .Method
                    .GetCustomAttributes(true)
                    .OfType<ActionNameAttribute>()
                    .FirstOrDefault()
                    ?.Name;

            return actionName ?? methodName;

        }
    }
}
