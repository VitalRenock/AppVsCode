using System;
using System.Diagnostics;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using AppVsCode.Models;

namespace AppVsCode.Controllers
{
    public class DatabaseController : Controller
    {
        private readonly Database _context;
        public DatabaseController(Database context)
        {
            _context = context;
        }

        #region Index

        // GET: Movies
        // public IActionResult Index()
        public async Task<IActionResult> Index()
        {
            return View(await _context.Posts.ToListAsync());

            // Appelle l'action du controller.
                // return RedirectToAction("Test");
        }

        #endregion

        #region Details

        // GET: Movies/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var post = await _context.Posts
                .FirstOrDefaultAsync(p => p.Id == id);
            if (post == null)
            {
                return NotFound();
            }

            return View(post);
        }

        #endregion

        #region Create

        // GET: Movies/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Movies/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Title,Content,PostDate")] Post post)
        {
            if (ModelState.IsValid)
            {
                if(post.PostDate == DateTime.MinValue)
                    post.PostDate = DateTime.Now;

                _context.Add(post);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(post);
        }

        #endregion

        #region Edit

        // GET: Movies/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var post = await _context.Posts.FindAsync(id);
            if (post == null)
            {
                return NotFound();
            }
            return View(post);
        }

        // POST: Movies/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Title,Content,PostDate")] Post post)
        {
            if (id != post.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(post);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PostExists(post.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(post);
        }

        #endregion

        #region Delete

        // GET: Movies/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var post = await _context.Posts
                .FirstOrDefaultAsync(m => m.Id == id);
            if (post == null)
            {
                return NotFound();
            }

            return View(post);
        }

        // POST: Movies/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var post = await _context.Posts.FindAsync(id);
            _context.Posts.Remove(post);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        #endregion

        #region Exist
        private bool PostExists(int id)
        {
            return _context.Posts.Any(e => e.Id == id);
        }

        #endregion
    
        #region Test

        public IActionResult Test()
        {

                        
            return View();
        }

        public void GetTablesOfDB()
        {
            // Code pour récupérer la liste des tables de la base de de données.
            var command = _context.Database.GetDbConnection().CreateCommand();
            command.CommandText = "SELECT name from sqlite_master WHERE type='table' AND name NOT LIKE 'sqlite_%' OR '_%'";
            
            _context.Database.OpenConnection();
            using (var result = command.ExecuteReader()) 
            {
                while (result.Read())
                {
                    Console.WriteLine(result.GetString(0));
                    Console.WriteLine(result.GetType());
                }
            }

            // Tester pour récupérer les tables de la DB
            // DbTransaction MyTransit = _context.Database.ExecuteSqlRaw("MA REQUETE SQL");
            // _context.Database.UseTransaction(MyTransit);
        }

        #endregion

    }
}