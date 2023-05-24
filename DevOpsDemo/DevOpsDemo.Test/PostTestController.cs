using DevOpsDemo.Controllers;
using DevOpsDemo.Repository;
using Microsoft.Extensions.Logging;
using NUnit.Framework;

namespace DevOpsDemo.Test
{
    public class PostTestController
    {
        private readonly IPostRepository _postRepository;        
        public PostTestController()
        {
            _postRepository = new PostRepository();            
        }
        [SetUp]
        public void Setup()
        {

        }

        [Test]
        public void Test1()
        {
            Assert.Pass();
        }        
        
        [Test]
        public void Test_Index_Return_Result()
        {
            var controller = new HomeController(this._postRepository);
            var result = controller.Index();
            Assert.IsNotNull(result);            
        }       
    }
}