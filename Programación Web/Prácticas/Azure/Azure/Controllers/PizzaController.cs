using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

using Azure.Models;

namespace Azure.Controllers {
    public class PizzaController : Controller {
        // GET: /<controller>
        public IActionResult Index() {
            List<Pizza> pizzas = new List<Pizza>();

            // Añadir pizzas aquí

            // 1
            pizzas.Add(new Pizza{
                Nombre = "Pizza Napolitana",
                Descripcion = "La auténtica pizza italiana nació en Nápoles y lleva con orgullo su nombre.",
                Ingredientes = "Queso Mozzarella, Perejil, Aceitunas y Tomates",
                Precio = 200.50f,
                Imagen = "https://t1.rg.ltmcdn.com/es/images/5/2/6/img_pizza_napolitana_32625_600.jpg"
            });

            // 2
            pizzas.Add(new Pizza {
                Nombre = "Pizza Clásica",
                Descripcion = "Nuestra Pizza más popular, preparada con los ingredientes que más te gustan.",
                Ingredientes = "Pepperoni, Queso Mozzarella, Perejil y Salsa de Tomate",
                Precio = 150.00f,
                Imagen = "https://placeralplato.com/files/2016/01/Pizza-con-pepperoni.jpg"
            });

            // 3
            pizzas.Add(new Pizza {
                Nombre = "Pizza Chicago",
                Descripcion = "Pizza Preparada en un sarten, rellena de queso",
                Ingredientes = "Queso Mozzarella, Carne de Res y Salsa de Tomate",
                Precio = 120.99f,
                Imagen = "https://amerikanisch-kochen.de/Wordpress/wp-content/uploads/2017/09/chicago-pizza.jpg"
            });

            // 4
            pizzas.Add(new Pizza {
                Nombre = "Pizza Nueva York",
                Descripcion = "Derivada de la Pizza napolitana, hecha con masa ligera",
                Ingredientes = "Orégano Seco, Hojuelas de chile rojo, Mostaza",
                Precio = 99.99f,
                Imagen = "https://upload.wikimedia.org/wikipedia/commons/6/64/NYPizzaPie.jpg"
            });

            // 5
            pizzas.Add(new Pizza {
                Nombre = "Pizza Siciliana",
                Descripcion = "Originaria de Palermo, hecha con masa esponjosa.",
                Ingredientes = "Pecorino, Anchoas, Pepperoni y Jamón",
                Precio = 350.33f,
                Imagen = "https://media-cdn.tripadvisor.com/media/photo-s/0a/54/5b/6c/pizza-siciliana.jpg"
            });

            // 6
            pizzas.Add(new Pizza{
                Nombre = "Pizza de Salmón",
                Descripcion = "Una pizza deliciosa nacida en nuestra tienda.",
                Ingredientes = "Orégano, Cebolla asada, Trozos de Salmón Ahumado y Camarones",
                Precio = 400.99f,
                Imagen = "https://www.recetaparapizzacasera.com/wp-content/uploads/2018/08/pizza-de-salmon-y-gambas.jpg"
            });

            // 7
            pizzas.Add(new Pizza {
                Nombre = "BBQ Chicken Pizza",
                Descripcion = "La pizza más deliciosa del mundo, nada más que decir",
                Ingredientes = "Tiras de Pollo, Tocino, Salsa de tomate y Salsa BBQ",
                Precio = 200.00f,
                Imagen = "http://aucdn.ar-cdn.com/recipes/port500/e702f0c4-adfc-4074-8228-676739284d09.jpg"
            });

            // 8
            pizzas.Add(new Pizza {
                Nombre = "Pizza de Cuatro Quesos",
                Descripcion = "Otra de nuestras pizzas más populares",
                Ingredientes = "Queso 1, Queso 2, Queso 3 y Queso 4",
                Precio = 200.00f,
                Imagen = "https://www.recetin.com/wp-content/uploads/2012/01/pizza_cuatro_quesos.jpg"
            });

            // 9
            pizzas.Add(new Pizza {
                Nombre = "Pizza Vegana",
                Descripcion = "Pizza Creada especialmente para Veganos",
                Ingredientes = "Hielo, Agua, Vapor",
                Precio = 500.00f,
                Imagen = "https://i.redd.it/zfqrcw5zzd721.jpg"
            });

            // 10
            pizzas.Add(new Pizza {
                Nombre = "Pizza SCP-458",
                Descripcion = "Robada de la fundación SCP, esta pizza es ██████ ",
                Ingredientes = "███, ██ y Queso Mozzarella",
                Precio = 200.00f,
                Imagen = "https://i.ytimg.com/vi/Ignai05sxVw/maxresdefault.jpg"
            });

            return View("Pizzas", pizzas);
        }
    }
}