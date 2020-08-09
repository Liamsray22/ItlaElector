﻿using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using AutoMapper;
using DataBase.Models;
using DataBase.ViewModels;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace Repository.Repository
{
    public class EleccionesRepo : RepositoryBase<Elecciones, ItlaElectorDBContext>
    {
        private readonly ItlaElectorDBContext _context;
        private readonly UserManager<IdentityUser> _userManager;
        private readonly SignInManager<IdentityUser> _signInManager;
        private readonly IMapper _mapper;


        public EleccionesRepo(ItlaElectorDBContext context, UserManager<IdentityUser> userManager,
                            SignInManager<IdentityUser> signInManager, IMapper mapper) : base(context)
        {
            _context = context;
            _userManager = userManager;
            _signInManager = signInManager;
            _mapper = mapper;
        }

        public async Task<EleccionesViewModel> TraerElecciones()
        {
            var elecciones = await GetAllAsync();
            EleccionesViewModel ele = new EleccionesViewModel();
            List<EleccionesViewModel> TodasLasElecciones = new List<EleccionesViewModel>();
            foreach (var e in elecciones)
            {
                var eleccione = _mapper.Map<EleccionesViewModel>(e);
                TodasLasElecciones.Add(eleccione);
            }
            var eleccion = await _context.Elecciones.FirstOrDefaultAsync(a => a.Estado.Trim() == "Progreso");
            if (eleccion !=null)
            {

                ele.Procesoactivos = true;
            }
            ele.elecciones = TodasLasElecciones;
            return ele;
        }

        public async Task CrearElecciones(EleccionesViewModel evm) {
            var eleccion = _mapper.Map<Elecciones>(evm);
            await AddAsync(eleccion);
        }

        public async Task<bool> eleccionesactivas()
        {

            var eleccion = await _context.Elecciones.FirstOrDefaultAsync(a => a.Estado.Trim() == "Progreso");
            if (eleccion == null)
            {
                return true;
            }
            return false;
        }


        public async Task<bool> FinalizarEleccion()
        {

            var eleccion = await _context.Elecciones.FirstOrDefaultAsync(a => a.Estado.Trim() == "Progreso");
            if (eleccion != null)
            {
                eleccion.Estado = "Finalizado";
                await Update(eleccion);
                return true;

            }
            return false;
        }
            //public void Borrar(string path)
            //{
            //    File.SetAttributes(path, FileAttributes.Normal);
            //    System.GC.Collect();
            //    System.GC.WaitForPendingFinalizers();

            //    File.Delete(path);
            //}


        }
    }
