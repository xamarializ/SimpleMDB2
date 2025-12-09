namespace Smdb.Api;

using System.Collections;
using System.Net;
using Shared.Http;
using Smdb.Api.Movies;
using Smdb.Core.Movies;

public interface IApp
{
    void Init();
}

public interface IApp1
{
    void Init();
}

public interface IApp2
{
    void Init();
}

public class App : HttpServer, IApp, IApp1, IApp2
{
    public override void Init()
    {
        var db = new MemoryDatabase();
        var movieRepo = new MemoryMovieRepository(db);
        var movieServ = new DefaultMovieService(movieRepo);
        var movieCtrl = new MoviesController(movieServ);
        var movieRouter = new MoviesRouter(movieCtrl);
        var apiRouter = new HttpRouter();

        router.Use(HttpUtils.StructuredLogging);
        router.Use(HttpUtils.CentralizedErrorHandling);
        router.Use(HttpUtils.AddResponseCorsHeaders);
        router.Use(HttpUtils.DefaultResponse);
        router.Use(HttpUtils.ParseRequestUrl);
        router.Use(HttpUtils.ParseRequestQueryString);

        // Serve static files (from configured root.dir) before API routing
        router.Use(HttpUtils.ServeStaticFiles);
        // Simple routing for top-level redirects and static pages
        router.UseSimpleRouteMatching();

        // Redirect root to index.html so browsers get the UI
        router.MapGet("/", async (req, res, props, next) =>
        {
            res.Redirect("/index.html");
            await next();
        });

        // API routing
        router.UseParametrizedRouteMatching();
        router.UseRouter("/api/v1", apiRouter);
        apiRouter.UseRouter("/movies", movieRouter);
    }
}
