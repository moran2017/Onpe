using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Onpe.Web.Controllers;

using Onpe.Web.Models;
using Onpe.Web.ViewModel;

namespace Onpe.Web.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return RedirectToAction("Login");
        }

        //DasBoard
        public ActionResult Dashboard()
        {
            DashBoardViewModel objViewModel = new DashBoardViewModel();

            return View(objViewModel);
        }

        //LstDustritos Lista
        public ActionResult LstDistrito()
        {
            LstDistritoViewModel objViewModel = new LstDistritoViewModel();

            return View(objViewModel);
        }

        //LstCandidatos lista
        public ActionResult LstCandidato()
        {

            LstCandidatoViewModel objViewModel = new LstCandidatoViewModel();

            return View(objViewModel);
        }

        //LstCandidatos Filtro
        [HttpPost]
        public ActionResult LstCandidato(LstCandidatoViewModel objViewModel)
        {
            objViewModel.CargarDatos(objViewModel.Filtro);
            return View(objViewModel);

        }

        //LstDistrito Filtro
        [HttpPost]
        public ActionResult LstDistrito(LstDistritoViewModel objViewModel)
        {
            objViewModel.CargarDatos(objViewModel.Filtro);
            return View(objViewModel);

        }

        //LstPartido Politico Filtro
        [HttpPost]
        public ActionResult LstPartidoPolitico(LstPartidoPoliticoViewModel objViewModel)
        {
            objViewModel.CargarDatos(objViewModel.Filtro);
            return View(objViewModel);

        }

        //Lst Partido Politico Lista
        public ActionResult LstPartidoPolitico()
        {
            LstPartidoPoliticoViewModel objViewModel = new LstPartidoPoliticoViewModel();

            return View(objViewModel);
        }

        //Agregar y Editar Distritos Get
        [HttpGet]
        public ActionResult AddEditDistrito(int? DistritoId)
        {
            AddEditDistritoViewModel objViewModel = new AddEditDistritoViewModel();
            objViewModel.CargarDatos(DistritoId);
            return View(objViewModel);
        }

        //Agregar y Editar Distritos Post
        [HttpPost]
        public ActionResult AddEditDistrito(AddEditDistritoViewModel objViewModel)
        {
            ONPEEntities context = new ONPEEntities();
            Distrito objDistrito = new Distrito();

            if (objViewModel.DistritoId.HasValue)
            {
                objDistrito = context.Distrito.FirstOrDefault(X =>
                                            X.DistritoId == objViewModel.DistritoId);
                objDistrito.Nombre = objViewModel.Nombre;
            }
            else
            {
                objDistrito.Nombre = objViewModel.Nombre;
                objDistrito.Estado = "ACT";
                context.Distrito.Add(objDistrito);
            }

            context.SaveChanges();
            return RedirectToAction("LstDistrito");
        }

        //Agregar y Editar Candidato Get
        [HttpGet]
        public ActionResult AddEditCandidato(int? CandidatoId)
        {
            AddEditCandidatoViewModel objViewModel = new AddEditCandidatoViewModel();
            objViewModel.CargarDatos(CandidatoId);
            return View(objViewModel);
        }

        //Agregar y Editar Candidato Post
        [HttpPost]
        public ActionResult AddEditCandidato(AddEditCandidatoViewModel objViewModel)
        {
            ONPEEntities context = new ONPEEntities();
            Candidato objCandidato = new Candidato();

            if (objViewModel.CandidatoId.HasValue)
            {
                objCandidato = context.Candidato.FirstOrDefault(X =>
                                            X.CandidatoId == objViewModel.CandidatoId);
                objCandidato.Nombre = objViewModel.Nombre;
                objCandidato.Apellidos = objViewModel.Apellidos;
                objCandidato.DistritoId = (int)objViewModel.DistritoId;
                objCandidato.PartidoPoliticoId = (int)objViewModel.PartidoPoliticoId;

            }
            else
            {
                objCandidato.Nombre = objViewModel.Nombre;
                objCandidato.Apellidos = objViewModel.Apellidos;
                objCandidato.DistritoId = (int)objViewModel.DistritoId;
                objCandidato.PartidoPoliticoId = (int)objViewModel.PartidoPoliticoId;
                objCandidato.Estado = "ACT";
                context.Candidato.Add(objCandidato);
            }

            context.SaveChanges();
            return RedirectToAction("LstCandidato");
        }

        //Agregar y Editar partido Politico Get
        [HttpGet]
        public ActionResult AddEditPartidoPolitico(int? PartidoPoliticoId)
        {
            AddEditPartidoPoliticoViewModel objViewModel = new AddEditPartidoPoliticoViewModel();
            objViewModel.CargarDatos(PartidoPoliticoId);
            return View(objViewModel);
        }

        //Agregar y Editar partido Politico Post
        [HttpPost]
        public ActionResult AddEditPartidoPolitico(AddEditPartidoPoliticoViewModel objViewModel)
        {
            ONPEEntities context = new ONPEEntities();
            PartidoPolitico objPartidoPolitico = new PartidoPolitico();

            if (objViewModel.PartidoPoliticoId.HasValue)
            {
                objPartidoPolitico = context.PartidoPolitico.FirstOrDefault(X =>
                                            X.PartidoPoliticoId == objViewModel.PartidoPoliticoId);
                objPartidoPolitico.Nombre = objViewModel.Nombre;
            }
            else
            {
                objPartidoPolitico.Nombre = objViewModel.Nombre;
                objPartidoPolitico.Estado = "ACT";
                context.PartidoPolitico.Add(objPartidoPolitico);
            }

            context.SaveChanges();
            return RedirectToAction("LstPartidoPolitico");
        }

        //Delete Candidato Get
        [HttpGet]
        public ActionResult DeleteCandidato(int? CandidatoId)
        {
            DeleteCandidatoViewModel objViewModel = new DeleteCandidatoViewModel();
            objViewModel.CargarDatos(CandidatoId);
            return View(objViewModel);
        }

        // Delete Candodato Post
        [HttpPost]
        public ActionResult DeleteCandidato(DeleteCandidatoViewModel objViewModel)
        {
            ONPEEntities context = new ONPEEntities();
            Candidato objCandidato = new Candidato();

            if (objViewModel.CandidatoId.HasValue)
            {
                objCandidato = context.Candidato.FirstOrDefault(X =>
                                            X.CandidatoId == objViewModel.CandidatoId);


            }
            context.Candidato.Remove(objCandidato);
            context.SaveChanges();

            return RedirectToAction("LstCandidato");
        }

        //Delete partido Politico Get
        [HttpGet]
        public ActionResult DeletePartidoPolitico(int? PartidoPoliticoId)
        {
            DeletePartidoPoliticoViewModel objViewModel = new DeletePartidoPoliticoViewModel();
            objViewModel.CargarDatos(PartidoPoliticoId);
            return View(objViewModel);
        }

        //Delete partido Politico Post
        [HttpPost]
        public ActionResult DeletePartidoPolitico(DeletePartidoPoliticoViewModel objViewModel)
        {
            ONPEEntities context = new ONPEEntities();
            PartidoPolitico objPartidoPolitico = new PartidoPolitico();

            if (objViewModel.PartidoPoliticoId.HasValue)
            {
                objPartidoPolitico = context.PartidoPolitico.FirstOrDefault(X =>
                                            X.PartidoPoliticoId == objViewModel.PartidoPoliticoId);


            }
            context.PartidoPolitico.Remove(objPartidoPolitico);
            context.SaveChanges();

            return RedirectToAction("LstPartidoPolitico");
        }

        // delete Distrito Get
        [HttpGet]
        public ActionResult DeleteDistrito(int? DistritoId)
        {
            DeleteDistritoViewModel objViewModel = new DeleteDistritoViewModel();
            objViewModel.CargarDatos(DistritoId);
            return View(objViewModel);
        }

        // delete Distrito Post
        [HttpPost]
        public ActionResult DeleteDistrito(DeleteDistritoViewModel objViewModel)
        {
            ONPEEntities context = new ONPEEntities();
            Distrito objDistrito = new Distrito();

            if (objViewModel.DistritoId.HasValue)
            {
                objDistrito = context.Distrito.FirstOrDefault(X =>
                                            X.DistritoId == objViewModel.DistritoId);


            }
            context.Distrito.Remove(objDistrito);
            context.SaveChanges();

            return RedirectToAction("LstDistrito");
        }

        //LstUsuarios Lista Get
        [HttpGet]
        public ActionResult LstUsuarios()
        {
            LstUsuariosViewModel objViewModel = new LstUsuariosViewModel();

            return View(objViewModel);
        }

        //LstUsuarios Lista Post
        [HttpPost]
        public ActionResult LstUsuarios(LstUsuariosViewModel objViewModel)
        {
            objViewModel.CargarDatos(objViewModel.Filtro);
            return View(objViewModel);
        }

        //Agragar y Editar Usuarios Get
        [HttpGet]
        public ActionResult AddEditUsuarios(int? UsuarioId)
        {
            AddEditUsuariosViewModel objViewModel = new AddEditUsuariosViewModel();
            objViewModel.CargarDatos(UsuarioId);
            return View(objViewModel);
        }

        //Agregar y Editar Usuario Post
        [HttpPost]
        public ActionResult AddEditUsuarios(AddEditUsuariosViewModel objViewModel)
        {
            ONPEEntities context = new ONPEEntities();
            Usuario objUsuario = new Usuario();

            if (objViewModel.UsuarioId.HasValue)
            {
                objUsuario = context.Usuario.FirstOrDefault(X =>
                                            X.UsuarioId == objViewModel.UsuarioId);
                objUsuario.Nombres = objViewModel.Nombres;
                objUsuario.Apellidos = objViewModel.Apellidos;
                objUsuario.RolId = objViewModel.RolId;
                objUsuario.Codigo = objViewModel.Codigo;
                objUsuario.Password = objViewModel.Password;
            }
            else
            {
                objUsuario.Nombres = objViewModel.Nombres;
                objUsuario.Apellidos = objViewModel.Apellidos;
                objUsuario.RolId = objViewModel.RolId;
                objUsuario.Estado = "ACT";
                objUsuario.Codigo = objViewModel.Codigo;
                objUsuario.Password = objViewModel.Password;
                context.Usuario.Add(objUsuario);
            }
            context.SaveChanges();
            return RedirectToAction("LstUsuarios");

        }

        // delete Usuario Get
        [HttpGet]
        public ActionResult DeleteUsuario(int? UsuarioId)
        {
            DeleteUsuarioViewModel objViewModel = new DeleteUsuarioViewModel();
            objViewModel.CargarDatos(UsuarioId);
            return View(objViewModel);
        }

        // delete Usuarios Post
        [HttpPost]
        public ActionResult DeleteUsuario(DeleteUsuarioViewModel objViewModel)
        {
            ONPEEntities context = new ONPEEntities();
            Usuario objUsuario = new Usuario();

            if (objViewModel.UsuarioId.HasValue)
            {
                objUsuario = context.Usuario.FirstOrDefault(X =>
                                            X.UsuarioId == objViewModel.UsuarioId);
            }
            context.Usuario.Remove(objUsuario);
            context.SaveChanges();

            return RedirectToAction("LstUsuarios");
        }

        //LstRoles Lista Get
        [HttpGet]
        public ActionResult LstRoles()
        {
            LstRolesViewModel objViewModel = new LstRolesViewModel();

            return View(objViewModel);
        }

        //LstRoles Lista Post
        [HttpPost]
        public ActionResult LstRoles(LstRolesViewModel objViewModel)
        {
            objViewModel.CargarDatos(objViewModel.Filtro);
            return View(objViewModel);
        }

        //Agregar y Ediar roles Get
        [HttpGet]
        public ActionResult AddEditRoles(int? RolId)
        {
            AddEditRolesViewModel objViewModel = new AddEditRolesViewModel();
            objViewModel.CargarDatos(RolId);
            return View(objViewModel);
        }

        //Agregar y Ediar roles Post
        [HttpPost]
        public ActionResult AddEditRoles(AddEditRolesViewModel objViewModel)
        {
            ONPEEntities context = new ONPEEntities();
            Roles objRoles = new Roles();

            if (objViewModel.RolId.HasValue)
            {
                objRoles = context.Roles.FirstOrDefault(X =>
                                            X.RolId == objViewModel.RolId);
                objRoles.Acronimo = objViewModel.Acronimo;
                objRoles.Descripcion = objViewModel.Descripcion;

            }
            else
            {
                objRoles.Acronimo = objViewModel.Acronimo;
                objRoles.Descripcion = objViewModel.Descripcion;

                context.Roles.Add(objRoles);
            }
            context.SaveChanges();
            return RedirectToAction("LstRoles");
        }


        //Elimimar Roles Get
        [HttpGet]
        public ActionResult DeleteRoles(int? RolId)
        {
            DeleteRolesViewModel objViewModel = new DeleteRolesViewModel();
            objViewModel.CargarDatos(RolId);
            return View(objViewModel);
        }

        //Elimimar Roles Post
        [HttpPost]
        public ActionResult DeleteRoles(DeleteRolesViewModel objViewModel)
        {
            ONPEEntities context = new ONPEEntities();
            Roles objRoles = new Roles();

            if (objViewModel.RolId.HasValue)
            {
                objRoles = context.Roles.FirstOrDefault(X =>
                                            X.RolId == objViewModel.RolId);
            }
            context.Roles.Remove(objRoles);
            context.SaveChanges();

            return RedirectToAction("LstUsuarios");
        }

        //view login get
        [HttpGet]
        public ActionResult Login()
        {
            LoginViewModel objViewMolel = new LoginViewModel();

            return View(objViewMolel);

        }

        //Login  post
        [HttpPost]
        public ActionResult Login(LoginViewModel objViewModel)
        {
            ONPEEntities context = new ONPEEntities();

            Usuario objUsuario = context.Usuario.FirstOrDefault(X => X.Codigo == objViewModel.codigo
            && X.Password == objViewModel.password);

            if (objUsuario == null)
            {
                return View(objViewModel);
            }
            else
            {
                ViewBag.Error = "Todos lo campos deben ser llenados";
            }
                
            Session["objUsuario"] = objUsuario;
            return RedirectToAction("DashBoard");


          

        }


        // cerrar seion
        public ActionResult CerrarSesion()
        {
            Session.Clear();
            return RedirectToAction("Login");
        }
        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}