using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using EjemploTestIntegration.Controllers;
using System.Collections.Generic;
using EjemploTestIntegration.Models;
using System.Linq;
using System.Web.Mvc;

namespace TestUnitario
{
    [TestClass]
    public class IntegrationTest
    {/*
        ProductController _productController;
        private readonly int PRODUCT=1;
        //private IEnumerable<Product> products;
        [TestInitialize]
        public void Setup()
        {

            _productController = new ProductController();
            using(var ctx=new UsersContext()){
                if (ctx.Database.Exists())
                    ctx.Database.Delete();
                ctx.Database.Create();
            }
            //crear el controller y crear la BD
        }
        [TestMethod]
        public void Index_ProductController_TestIntegration()
        {
            using(var ctx=new UsersContext()){
                ctx.Product.Add(new Product(){Name="manzanas"});
                ctx.SaveChanges();
            }
            //hacer test del homecontroller.Index
            //HomeController.Create
            var result = _productController.Index() as ViewResult;
            var product = result.Model as IEnumerable<Product>;
            Assert.AreEqual(PRODUCT,product.ToList().Count);
            
        }*/
    }
}
