using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Blog1.Models;
using System.Data.Entity.Validation;
using System.Diagnostics;
using System.Web.Helpers;

namespace Blog1.Controllers
{
    public class PostController : Controller
    {
        private Blog1Entity model = new Blog1Entity();
        private const int PostsPerPage = 4;
        // GET: /Post/
        public ActionResult Home()
        {
            return View();
        }


        public ActionResult Index(int?id)
        {
            int pageNumber = id ?? 0;
            IEnumerable<Post> posts = (from post in model.Posts
                                      where post.PostDate < DateTime.Now
                                      orderby post.PostDate descending
                                      select post).Skip(pageNumber * PostsPerPage).Take(PostsPerPage+1);

            ViewBag.IsPreviouslinkVisible = pageNumber > 0;
            ViewBag.IsNextLinkVisible = posts.Count() > PostsPerPage;
            ViewBag.PageNumber = pageNumber;
            
            return View(posts.Take(PostsPerPage));
        }
        [ValidateInput(false)]
        public ActionResult Update(int?id, string title, DateTime PostDate, string body)
        {
            if(!IsAdmin)
            {
                    return RedirectToAction("Index");
            }
            Post post = GetPost(id);
            post.Title = title;
            post.PostDate = PostDate;
            post.Body = body;

            if (!id.HasValue)
            {
                model.Posts.Add(post);
            }
            try
            {
                model.SaveChanges();
            }
            catch (DbEntityValidationException dbEx)
            {
                foreach (var validationErrors in dbEx.EntityValidationErrors)
                {
                    foreach (var validationError in validationErrors.ValidationErrors)
                    {
                        Trace.TraceInformation("Property: {0} Error: {1}", validationError.PropertyName, validationError.ErrorMessage);
                    }
                }
            }

            return RedirectToAction("Index");
        }

        private Post GetPost(int? id)
        {
            return id.HasValue ? model.Posts.Where(x => x.ID == id).First() : new Post() { ID = -1};
        }
        public bool IsAdmin 
        {
            get {return true;}
        }
        public ActionResult Edit(int? id)
        {
            Post post = GetPost(id);
            return View(post);
        }
        public ActionResult Details(int id)
        {
            Post post = GetPost(id);
            return View(post);
        }
        [ValidateInput(false)]
        public ActionResult Comment(int id, String name, String body)
        {
            Post post = GetPost(id);
            Comment comment = new Comment();
            comment.Post = post;
            comment.TimePosted = DateTime.Now;
            comment.Name = name;
            comment.Body = body;
            model.Comments.Add(comment);
            model.SaveChanges();
            return RedirectToAction("Details", new { id = id });
        }
    }   
}
