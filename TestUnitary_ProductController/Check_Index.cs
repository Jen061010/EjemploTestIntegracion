using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NMock;
using Domain;
using BusinessLogic;
using System.Web.Mvc;

namespace TestUnitary_ProductController
{
    [TestClass]
    public class Check_Index
    {
        private MockFactory _factory = new MockFactory();

        [TestCleanup]
        public void Cleanup()
        {
            _factory.VerifyAllExpectationsHaveBeenMet();
            _factory.ClearExpectations();
        }
        [TestMethod]
        public void TestMethod1()
        {
            //Arange
            var products = new[] { new Product { Id = 1, Name = "manzana" } };

            var unitOfWork = _factory.CreateMock<IUnitOfWork>();
            var iRepositoryProduct = _factory.CreateMock<IRepositoryProduct>();

            iRepositoryProduct.Expects.One.Method(c => c.GetAll()).WillReturn(products);
            unitOfWork.Expects.One.Method(c => c.Dispose());

            // Act
            var result = (ViewResult) iRepositoryProduct.controller.List();

            // Assert
            var listCategories = Assert.IsAssignableFrom<IEnumerable<Category>>(result.ViewData.Model);
            Assert.Equal(1, listCategories.Count());    

            //Act

        }
    }
}
