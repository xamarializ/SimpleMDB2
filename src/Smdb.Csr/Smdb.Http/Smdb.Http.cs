namespace Smdb.Http
{
    public class HttpServer
    {
        protected Router router = new Router();

        public virtual void Init() { }

        public virtual async Task Start()
        {
            // Minimal start implementation for the CSR app.
            // Call Init to ensure routes/middlewares are configured,
            // then keep the process alive until cancelled.
            Init();
            await Task.Delay(-1);
        }
    }

    public class HttpRequest { }

    public class HttpResponse
    {
        public void Redirect(
            string url
        )
        { /* aquí pones la lógica si quieres */
        }
    }

    public class RouteProperties { }

    public class Router
    {
        public void Use(
            Func<HttpRequest, HttpResponse, RouteProperties, Func<Task>, Task> middleware
        )
        { }

        public void MapGet(
            string path,
            Func<HttpRequest, HttpResponse, RouteProperties, Func<Task>, Task> handler
        )
        { }

        public void UseSimpleRouteMatching() { }
    }

    public static class HttpUtils
    {
        public static Func<
            HttpRequest,
            HttpResponse,
            RouteProperties,
            Func<Task>,
            Task
        > StructuredLogging = async (req, res, props, next) => await next();

        public static Func<
            HttpRequest,
            HttpResponse,
            RouteProperties,
            Func<Task>,
            Task
        > CentralizedErrorHandling = async (req, res, props, next) => await next();

        public static Func<
            HttpRequest,
            HttpResponse,
            RouteProperties,
            Func<Task>,
            Task
        > AddResponseCorsHeaders = async (req, res, props, next) => await next();

        public static Func<
            HttpRequest,
            HttpResponse,
            RouteProperties,
            Func<Task>,
            Task
        > DefaultResponse = async (req, res, props, next) => await next();

        public static Func<
            HttpRequest,
            HttpResponse,
            RouteProperties,
            Func<Task>,
            Task
        > ParseRequestUrl = async (req, res, props, next) => await next();

        public static Func<
            HttpRequest,
            HttpResponse,
            RouteProperties,
            Func<Task>,
            Task
        > ParseRequestQueryString = async (req, res, props, next) => await next();

        public static Func<
            HttpRequest,
            HttpResponse,
            RouteProperties,
            Func<Task>,
            Task
        > ServeStaticFiles = async (req, res, props, next) => await next();
    }
}
