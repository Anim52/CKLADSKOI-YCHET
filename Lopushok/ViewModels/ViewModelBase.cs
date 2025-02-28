using Lopushok.Models;
using Lopushok.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace Lopushok.ViewModels
{
    public class ViewModelBase
    {
        //Материалы
        static public List<Material> GetMaterial()
        {
            using (Context context = new Context())
            {
                return context.Materials.ToList();
            }
        }

        static public bool IsFindMaterial(Material Data)
        {
            using (Context context = new Context())
            {
                if (Data is not null && context.Materials.Find(Data.Id) is not null)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

        static public void ToogleMaterial(Material Data)
        {
            using (Context context = new Context())
            {
                var Row = context.Materials.Find(Data.Id);

                if (Row != null)
                {
                    Row.TypeMaterial = Data.TypeMaterial;
                    Row.CountMaterials = Data.CountMaterials;
                }
                else
                {
                    context.Materials.Add(Data);
                }

                context.SaveChanges();
            }
        }

        static public void DeletMaterial(Material Data)
        {
            using (Context context = new Context())
            {
                var Row = context.Materials.Find(Data.Id);

                if (Row != null)
                {
                    context.Materials.Remove(Row);
                }

                context.SaveChanges();
            }
        }

        //Продукция
        static public List<Product> GetProduct()
        {
            using (Context context = new Context())
            {
                return context.Products.ToList();
            }
        }

        static public bool IsFindProduct(Product Data)
        {
            using (Context context = new Context())
            {
                if (Data is not null && context.Products.Find(Data.Id) is not null)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

        static public void ToogleProduct(Product Data)
        {
            using (Context context = new Context())
            {
                var Row = context.Products.Find(Data.Id);

                if (Row != null)
                {
                    Row.Name = Data.Name;
                    Row.MaterialId = Data.MaterialId;
                    Row.Articul = Data.Articul;
                    Row.MinPrice = Data.MinPrice;
                    Row.ImagePath = Data.ImagePath;
                    Row.PeopleMake = Data.PeopleMake;
                    Row.ManafacturAdrres = Data.ManafacturAdrres;
                }
                else
                {
                    context.Products.Add(Data);
                }

                context.SaveChanges();
            }
        }

        static public void DeletProduct(Product Data)
        {
            using (Context context = new Context())
            {
                var Row = context.Products.Find(Data.Id);

                if (Row != null)
                {
                    context.Products.Remove(Row);
                }

                context.SaveChanges();
            }
        }

        //Скалады
        static public List<Warehouse> GetWarehouse()
        {
            using (Context context = new Context())
            {
                return context.Warehouses.ToList();
            }
        }

        static public bool IsFindWarehouse(Warehouse Data)
        {
            using (Context context = new Context())
            {
                if (Data is not null && context.Warehouses.Find(Data.Id) is not null)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

        static public void ToogleWarehouse(Warehouse Data)
        {
            using (Context context = new Context())
            {
                var Row = context.Warehouses.Find(Data.Id);

                if (Row != null)
                {
                    Row.Name = Data.Name;
                    Row.Adress = Data.Adress;
                }
                else
                {
                    context.Warehouses.Add(Data);
                }

                context.SaveChanges();
            }
        }

        static public void DeletWarehouse(Warehouse Data)
        {
            using (Context context = new Context())
            {
                var Row = context.Warehouses.Find(Data.Id);

                if (Row != null)
                {
                    context.Warehouses.Remove(Row);
                }

                context.SaveChanges();
            }
        }


        //СкаладыПродукты
        static public List<WarehouseProduct> GetWarehouseProduct()
        {
            using (Context context = new Context())
            {
                return context.WarehouseProducts.ToList();
            }
        }

        static public bool IsFindWarehouseProduct(WarehouseProduct Data)
        {
            using (Context context = new Context())
            {
                if (Data is not null && context.WarehouseProducts.Find(Data.Id) is not null)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

        static public void ToogleWarehouseProduct(WarehouseProduct Data)
        {
            using (Context context = new Context())
            {
                var Row = context.WarehouseProducts.Find(Data.Id);

                if (Row != null)
                {
                    Row.WarehouseId = Data.WarehouseId;
                    Row.ProductId = Data.ProductId;
                    Row.CountProduct = Data.CountProduct;
                }
                else
                {
                    context.WarehouseProducts.Add(Data);
                }

                context.SaveChanges();
            }
        }

        static public void DeletWarehouseProduct(WarehouseProduct Data)
        {
            using (Context context = new Context())
            {
                var Row = context.WarehouseProducts.Find(Data.Id);

                if (Row != null)
                {
                    context.WarehouseProducts.Remove(Row);
                }

                context.SaveChanges();
            }
        }

        //Агенты
        static public List<Agent> GetAgent()
        {
            using (Context context = new Context())
            {
                return context.Agents.ToList();
            }
        }

        static public bool IsFindAgent(Agent Data)
        {
            using (Context context = new Context())
            {
                if (Data is not null && context.Agents.Find(Data.Id) is not null)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

        static public void ToogleAgent(Agent Data)
        {
            using (Context context = new Context())
            {
                var Row = context.Agents.Find(Data.Id);

                if (Row != null)
                {
                    Row.Name = Data.Name;
                    Row.INN = Data.INN;
                    Row.LegalAdress = Data.LegalAdress;
                    Row.Directro = Data.Directro;
                }
                else
                {
                    context.Agents.Add(Data);
                }

                context.SaveChanges();
            }
        }

        static public void DeletAgent(Agent Data)
        {
            using (Context context = new Context())
            {
                var Row = context.Agents.Find(Data.Id);

                if (Row != null)
                {
                    context.Agents.Remove(Row);
                }

                context.SaveChanges();
            }
        }

        //Продажи
        static public List<Sales> GetSales()
        {
            using (Context context = new Context())
            {
                return context.Sales.ToList();
            }
        }

        static public bool IsFindSales(Sales Data)
        {
            using (Context context = new Context())
            {
                if (Data is not null && context.Sales.Find(Data.Id) is not null)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

        static public void ToogleSales(Sales Data)
        {
            using (Context context = new Context())
            {
                var Row = context.Sales.Find(Data.Id);

                if (Row != null)
                {
                    Row.AgentId = Data.AgentId;
                    Row.WarehouseProductId = Data.WarehouseProductId;
                    Row.SalesCount = Data.SalesCount;
                    Row.SalesDate = Data.SalesDate;
                }
                else
                {
                    context.Sales.Add(Data);
                }

                context.SaveChanges();
            }
        }

        static public void DeletSales(Sales Data)
        {
            using (Context context = new Context())
            {
                var Row = context.Sales.Find(Data.Id);

                if (Row != null)
                {
                    context.Sales.Remove(Row);
                }

                context.SaveChanges();
            }
        }


    }
}
