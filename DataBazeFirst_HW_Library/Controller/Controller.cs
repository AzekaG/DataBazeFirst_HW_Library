using DataBazeFirst_HW_Library;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data.Entity;
using System.Data.Entity.Core.Metadata.Edm;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace RelationshipEF_LoadingDb_18._07_WF.Model
{
    class Controller
    {
        public Model1 libraryContext;
        public Controller() { }



 
        public ICollection<Books> GetBooks()
        {
            ICollection<Books> books = new Collection<Books>();
            using (libraryContext = new Model1())
            {
                books = libraryContext.Books.ToList();
            }
            return books;
        }

        public DbSet<Authors> GetAuthors()
        {
            using (libraryContext = new Model1())
            {
                return libraryContext.Authors;
            }

        }
        public DbSet<Categories> GetCategory()
        {
            using (libraryContext = new Model1())
            {
                return libraryContext.Categories;
            }
        }

        public DbSet<ProductionHouses> GetProductionHouse()
        {
            using (libraryContext = new Model1())
            {
                return libraryContext.ProductionHouses;
            }

        }
        public void AddBook(string name, int pages, string category, string author, string productionHouse)
        {
            using (libraryContext = new Model1())
            {
                Authors author1 = null;
                Categories category1 = null;
                ProductionHouses productionHouse1 = null;
                foreach (var el in libraryContext.Books.Include("Authors"))
                {
                    if (el.Authors.Name == author)
                        author1 = el.Authors;
                    else author1 = new Authors() { Name = author };
                }

                foreach (var el in libraryContext.Books.Include("Categories"))
                {
                    if (el.Categories.Name == category)
                        category1 = el.Categories;
                    else category1 = new Categories() { Name = category };
                }
                foreach (var el in libraryContext.Books.Include("ProductionHouses"))
                {
                    if (el.ProductionHouses.Name == productionHouse)
                        productionHouse1 = el.ProductionHouses;
                    else productionHouse1 = new ProductionHouses() { Name = productionHouse };
                }


                Books book = new Books()
                {
                    Name = name,
                    AmountPages = pages,
                    Categories = category1,
                    Authors = author1,
                    ProductionHouses = productionHouse1
                };

                libraryContext.Books.Add(book);
                libraryContext.SaveChanges();
            }
        }

        public void DelBook(int ID)
        {
            using (libraryContext = new Model1())
            {
                Books book = libraryContext.Books.Where(x => x.Id == ID).FirstOrDefault();
                libraryContext.Books.Remove(book);
                libraryContext.SaveChanges();
            }
        }


        public void ChangeBook(Books bk)
        {
            using (libraryContext = new Model1())
            {
                Books book = libraryContext.Books.Where(x => x.Id == bk.Id).FirstOrDefault();
                book.Name = bk.Name;
                book.Authors = bk.Authors;
                book.AmountPages = bk.AmountPages;
                book.Categories = bk.Categories;
                book.ProductionHouses = bk.ProductionHouses;
                libraryContext.SaveChanges();

            }
        }
        #region EagerLoading
        public Collection<Books> SearchBookByName(string nameBook)
        {
            Collection<Books> bk = new Collection<Books>();
            using (libraryContext = new Model1())
            {

                foreach (var book in libraryContext.Books)
                {
                    if (book.Name == nameBook)
                        bk.Add(book);
                }
            }
            return bk;
        }

        public Collection<Books> SearchBookByAuthor(string nameAuthor)
        {
            Collection<Books> bk = new Collection<Books>();
            using (libraryContext = new Model1())
            {
                foreach (var book in libraryContext.Books.Include("Author"))
                {
                    if (book.Authors.Name == nameAuthor)
                        bk.Add(book);
                }
            }
            return bk;
        }


        public Collection<Books> SearchBookByCategory(string nameCategory)
        {
            Collection<Books> bk = new Collection<Books>();
            using (libraryContext = new Model1())
            {
                foreach (var book in libraryContext.Books.Include("Category"))
                {
                    if (book.Categories.Name == nameCategory)
                        bk.Add(book);
                }
            }
            return bk;
        }


        public Collection<Books> SearchBookByPublishHouse(string namePublishHouse)
        {
            Collection<Books> bk = new Collection<Books>();
            using (libraryContext = new Model1())
            {
                foreach (var book in libraryContext.Books.Include("ProductionHouse"))
                {
                    if (book.ProductionHouses.Name == namePublishHouse)
                        bk.Add(book);

                }
            }

            return bk;
        }
        #endregion EagerLoading

        #region ExplicitLoading


        public Collection<Books> SearchBookByAuthor_2(string nameAuthor)
        {
            Collection<Books> bk = new Collection<Books>();   // коллекция , которую возвращаем в форму1

            using (libraryContext = new Model1())
            {
                Authors ath = libraryContext.Authors.Where(x => x.Name == nameAuthor).FirstOrDefault();    //наш объект для свойства
                if (ath != null)
                {
                    libraryContext.Entry(ath).Collection("Books").Load();
                    foreach (var book in ath.Books)
                    {

                        bk.Add(book);
                    }
                }
            }
            return bk;
        }


        public Collection<Books> SearchBookByCategory_2(string nameCategory)
        {
            Collection<Books> bk = new Collection<Books>();


            using (libraryContext = new Model1())
            {
                Categories ct = libraryContext.Categories.Where(c => c.Name == nameCategory).FirstOrDefault();
                if (ct != null)
                {
                    libraryContext.Entry(ct).Collection("Books").Load();
                    foreach (var book in ct.Books)
                    {

                        bk.Add(book);
                    }
                }
            }
            return bk;
        }


        public Collection<Books> SearchBookByPublishHouse_2(string namePublishHouse)
        {
            Collection<Books> bk = new Collection<Books>();
            ProductionHouses ph = libraryContext.ProductionHouses.Where(x => x.Name == namePublishHouse).FirstOrDefault();
            using (libraryContext = new Model1())
            {
                foreach (var book in ph.Books)
                {
                    bk.Add(book);
                }
            }

            return bk;
        }
        #endregion ExplicitLoading


    }
}
