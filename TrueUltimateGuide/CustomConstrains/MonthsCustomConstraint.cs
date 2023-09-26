using System.Text.RegularExpressions;

namespace TrueUltimateGuide.CustomConstrains
{
    //Eg: sales-report/2020/apr
    public class MonthsCustomConstraint : IRouteConstraint
    {
        public bool Match(HttpContext? httpContext, IRouter? route, string routeKey, RouteValueDictionary values, RouteDirection routeDirection)
        {
            if (!values.ContainsKey(routeKey)) //month
            {
                return false; //not match
            }

            Regex regex = new Regex("^(apr|jul|oct|jan)$");
            string? monthValue = Convert.ToString(values[routeKey]);

            if (regex.IsMatch(monthValue))
            {
                return true; //match
            }
            return false; //not match
        }
    }
}
