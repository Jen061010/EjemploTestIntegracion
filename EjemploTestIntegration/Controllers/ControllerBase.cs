using BusinessLogic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EjemploTestIntegration.Controllers
{
    public class ControllerBase:Controller
    {
        IUnitOfWork _unitOfWork;
        public ControllerBase(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        protected int Save()
        {
            return _unitOfWork.SaveChanges();        
        }
        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
        }
    }
}