using HaulvShop.Model.Models;
using HaulvShop.Service;
using HaulvShop.Web.Infrastructure.Core;
using System.Net;
using System.Net.Http;
using System.Web.Http;


namespace HaulvShop.Web.Api
{
    [RoutePrefix("api/postcategory")]
    public class PostCategoryController : ApiControllerBase
    {
        private IPostCategoryService _postCategoryService;

        public PostCategoryController(IErrorService errorService, IPostCategoryService postCategoryService) : base(errorService)
        {
            this._postCategoryService = postCategoryService;
        }

        [Route("getall")]
        public HttpResponseMessage Get(HttpRequestMessage request)
        {
            //ham nac danh
            HttpResponseMessage respone = null;
            return CreateHttpResponse(request, () =>
            {
                if (ModelState.IsValid)
                {
                    request.CreateErrorResponse(HttpStatusCode.BadRequest, ModelState);
                }
                else
                {
                    var listCategory = _postCategoryService.GetAll();
                    respone = request.CreateResponse(HttpStatusCode.OK, listCategory);
                }
                return respone;
            });
        }

        public HttpResponseMessage Post(HttpRequestMessage request, PostCategory postCategory)
        {
            //ham nac danh
            HttpResponseMessage respone = null;
            return CreateHttpResponse(request, () =>
            {
                if (ModelState.IsValid)
                {
                    request.CreateErrorResponse(HttpStatusCode.BadRequest, ModelState);
                }
                else
                {
                    var category = _postCategoryService.Add(postCategory);
                    _postCategoryService.Save();
                    respone = request.CreateResponse(HttpStatusCode.Created, category);
                }
                return respone;
            });
        }

        public HttpResponseMessage Put(HttpRequestMessage request, PostCategory postCategory)
        {
            //ham nac danh
            HttpResponseMessage respone = null;
            return CreateHttpResponse(request, () =>
            {
                if (ModelState.IsValid)
                {
                    request.CreateErrorResponse(HttpStatusCode.BadRequest, ModelState);
                }
                else
                {
                    _postCategoryService.Update(postCategory);
                    _postCategoryService.Save();
                    respone = request.CreateResponse(HttpStatusCode.OK);
                }
                return respone;
            });
        }

        public HttpResponseMessage Delete(HttpRequestMessage request, int id)
        {
            //ham nac danh
            HttpResponseMessage respone = null;
            return CreateHttpResponse(request, () =>
            {
                if (ModelState.IsValid)
                {
                    request.CreateErrorResponse(HttpStatusCode.BadRequest, ModelState);
                }
                else
                {
                    _postCategoryService.Delete(id);
                    _postCategoryService.Save();
                    respone = request.CreateResponse(HttpStatusCode.OK);
                }
                return respone;
            });
        }
    }
}