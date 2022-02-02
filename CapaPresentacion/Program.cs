using CapaDatos;
using CapaNegocio;
using Entidades;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Utilidades.Interfaces;

namespace CapaPresentacion
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            var services = new ServiceCollection();
            ConfigureServices(services);
            using (var serviceProvider = services.BuildServiceProvider())
            {
                var form1 = serviceProvider.GetRequiredService<frmPrincipal2>();
                Application.Run(form1);


            }

              

               
        }

        private static void ConfigureServices(ServiceCollection services)
        {

            //AddTransient: Crea y elimina dinamicamente el objeto de la memoria mientras se utiliza

            //addScoped: mantiene los objetos en memoria miestras el sistema corra. Reutiliza la memoria

            //addSingleton: funcionamiento trandicional, por cada objeto crea memoria, no es dinamica.


            //base datos
            services.AddTransient<Entities>();

            //formularios
            services.AddTransient<frmPrincipal2>();
            services.AddTransient<frmConsultaProductos>();
            services.AddTransient<frmProductos>();
            services.AddTransient<frmEstudiantes>();

            //objetos de capa negocio
            services.AddScoped<IGenericaNegocio<tbProductos>, BProductos>();
            services.AddScoped<IGenericaNegocio<tbCategorias>, BCategoria>();
            services.AddScoped<IGenericaNegocio<tbImpuestos>, BImpuestos>();
            services.AddScoped<IGenericaNegocio<tbProveedores>, BProveedores>();


            //objetos de capa de datos
            services.AddScoped<IGenericaDatos<tbProductos>, DProductos>();
            services.AddScoped<IGenericaDatos<tbCategorias>, DCategoria>();
            services.AddScoped<IGenericaDatos<tbImpuestos>, DImpuestos>();
            services.AddScoped<IGenericaDatos<tbProveedores>, DProveedores>();
            // services.AddScoped<IGenerica<clsProveedor>, DProveedores>();





        }
    }
}
