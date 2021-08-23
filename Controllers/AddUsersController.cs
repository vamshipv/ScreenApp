using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Screens.Data;
using Screens.Models;
using AddUserContext = Screens.Data.AddUserContext;

namespace Screens.Controllers
{
    public class AddUsersController : Controller
    {
        private readonly AddUserContext _context;

        public AddUsersController(AddUserContext context)
        {
            _context = context;
        }

        // GET: AddUsers
        public async Task<IActionResult> Index()
        {
            return View(await _context.AddUser.ToListAsync());
        }

        // GET: AddUsers/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var addUser = await _context.AddUser
                .FirstOrDefaultAsync(m => m.Id == id);
            if (addUser == null)
            {
                return NotFound();
            }

            return View(addUser);
        }

        // GET: AddUsers/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: AddUsers/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,EmpId,FirstName,LastName")] AddUser addUser)
        {
            if (ModelState.IsValid)
            {
                _context.Add(addUser);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(addUser);
        }

        // GET: AddUsers/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var addUser = await _context.AddUser.FindAsync(id);
            if (addUser == null)
            {
                return NotFound();
            }
            return View(addUser);
        }

        // POST: AddUsers/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,EmpId,FirstName,LastName")] AddUser addUser)
        {
            if (id != addUser.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(addUser);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!AddUserExists(addUser.Id))
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
            return View(addUser);
        }

        // GET: AddUsers/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var addUser = await _context.AddUser
                .FirstOrDefaultAsync(m => m.Id == id);
            if (addUser == null)
            {
                return NotFound();
            }

            return View(addUser);
        }

        // POST: AddUsers/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var addUser = await _context.AddUser.FindAsync(id);
            _context.AddUser.Remove(addUser);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool AddUserExists(int id)
        {
            return _context.AddUser.Any(e => e.Id == id);
        }
    }
}
