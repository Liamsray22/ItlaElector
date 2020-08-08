﻿using System.IO;
using System.Threading.Tasks;
using AutoMapper;
using DataBase.Models;
using Microsoft.AspNetCore.Identity;

namespace Repository.Repository
{
    public class AdminRepo : RepositoryBase<Ciudadanos, ItlaElectorDBContext>
    {
        private readonly ItlaElectorDBContext _context;
        private readonly UserManager<IdentityUser> _userManager;
        private readonly SignInManager<IdentityUser> _signInManager;
        private readonly IMapper _mapper;


        public AdminRepo(ItlaElectorDBContext context, UserManager<IdentityUser> userManager,
                            SignInManager<IdentityUser> signInManager, IMapper mapper) : base(context)
        {
            _context = context;
            _userManager = userManager;
            _signInManager = signInManager;
            _mapper = mapper;
        }

        public async Task CrearAdmin()
        {

            var user = new IdentityUser { UserName = "Liam" };
            var result = await _userManager.CreateAsync(user, "222");
        }

        public async Task<bool> LoguearAdmin(string user, string pass)
        {
            user = "Liam";
            pass= "222";
            var result = await _signInManager.PasswordSignInAsync(user, pass, false, true);

            if (result.Succeeded)
            {
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