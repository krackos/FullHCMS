using FullHCMS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FullHCMS.DAL
{
    public class SellerInitializer
    {
        public static List<Seller> GetSellers()
        {
            List<Seller> sellers = new List<Seller>()
            {
                new Seller(){
                 FullName = "Victor Carranza",
                 Phone = "664490876",
                 Email = "vcarranza@topiv.com",
                 Homes = GetSeller1Houses()
                },
                new Seller() {
                 FullName = "Armando Cruz",
                 Phone = "663098977",
                 Email = "armando.cruz@homets.com",
                 Homes = GetSeller2Houses()
                },
                new Seller() {
                FullName = "Melissa Tarazon",
                Phone = "6622034412",
                Email = "melisaT@cvision.net",
                Homes = GetSeller3Houses()
                }
            };

            return sellers;
        }
        public static List<Home> GetSeller1Houses()
        {
            List<Home> homes = new List<Home>()
            {
                new Home() {
                 Title = "Casa amueblada 3 recamaras",
                 LongDescription = "Casa en venta de 2 plantas, 3 recamaras, 2 baños, sala, cocina, comedor, estancia, cochera",
                 Size=117,
                 Price = 680000,
                 Address1 = "Villas del palmar",
                 City="Hermosillo",
                 PostalCode = 83276,
                 State = "Sonora",
                 Address2 = ""
                },
                new Home() {
                 Title = "Linda Casa en Venta en Asturias Residencial",
                 LongDescription = "Casa en venta de 1 planta, 3 recamaras, 2 baños completos, cuarto de lavado, cocina integral",
                 Size=143,
                 Price = 1050000,
                 Address1 = "Asturias",
                 City="Hermosillo",
                 PostalCode = 83276,
                 State = "Sonora",
                 Address2 = ""
                }
            };

            return homes;
        }
        public static List<Home> GetSeller2Houses()
        {
            List<Home> homes = new List<Home>()
            {
                new Home() {
                 Title = "Se vende preciosa casona en colonia centro",
                 LongDescription = "Preciosa Casona Antigua en el centro",
                 Size=653,
                 Price = 3850000,
                 Address1 = "Calle Serdan",
                 City="Hermosillo",
                 PostalCode = 83068,
                 State = "Sonora",
                 Address2 = "Entre Plutarco Elias Calles y Horacio Soria"
                },
                new Home() {
                 Title = "La Encantada Residencial al Poniente",
                 LongDescription = "Casa en venta de 2 plantas con terreno excedente equipada",
                 Size=700,
                 Price = 4600000,
                 Address1 = "Encantada",
                 City="Hermosillo",
                 PostalCode = 83276,
                 State = "Sonora",
                 Address2 = ""
                }
            };

            return homes;
        }
        public static List<Home> GetSeller3Houses()
        {
            List<Home> homes = new List<Home>()
            {
                new Home() {
                 Title = "El Esplendor al Norponiente",
                 LongDescription = "Casa de dos plantas con sala, comedor, area de lavado, 2 y medio baño",
                 Size=120,
                 Price = 950000,
                 Address1 = "El esplendor",
                 City="Hermosillo",
                 PostalCode = 83068,
                 State = "Sonora",
                 Address2 = ""
                }
            };

            return homes;
        }
 
    }
}