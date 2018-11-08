using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using LiveBoard.Data;
using LiveBoard.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Authentication;

namespace LiveBoard.Controllers
{
    public class NotesController : Controller
    {
        private readonly ApplicationDbContext _context;

        private readonly UserManager<ApplicationUser> _userManager;

        public NotesController(ApplicationDbContext context, UserManager<ApplicationUser> userManager)
        {
            _context = context;
            _userManager = userManager;
        }
        private Task<ApplicationUser> GetCurrentUserAsync() => _userManager.GetUserAsync(HttpContext.User);

        // GET: Notes
        public async Task<IActionResult> Index()
        {
            ApplicationUser currentUser = await GetCurrentUserAsync();

            var applicationDbContext = _context.Notes.Include(n => n.User).Where(n => n.UserId == currentUser.Id);
            return View(await applicationDbContext.ToListAsync());
        }

        // GET: Notes/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var notes = await _context.Notes
                //.Include(n => n.Image)
                .Include(n => n.User)
                .FirstOrDefaultAsync(m => m.NoteId == id);
            if (notes == null)
            {
                return NotFound();
            }

            return View(notes);
        }

        // GET: Notes/Create
        public IActionResult Create()
        {
            //ViewData["ImageId"] = new SelectList(_context.Image, "ImageId", "ImgB64");
            ViewData["UserId"] = new SelectList(_context.ApplicationUsers, "Id", "Id");
            return View();
        }

        // POST: Notes/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(string note, string imageData)
        {

            ApplicationUser currentUser = await GetCurrentUserAsync();

            var notes = new Notes();
            notes.Text = note;
                byte[] data = Convert.FromBase64String(imageData);
                notes.Img64 = data;
            notes.UserId = currentUser.Id;



                _context.Add(notes);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            
            //ViewData["ImageId"] = new SelectList(_context.Image, "ImageId", "ImgB64", notes.ImageId);
            //ViewData["UserId"] = new SelectList(_context.ApplicationUsers, "Id", "Id", notes.UserId);
            //return View(notes);
        }

        // GET: Notes/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var notes = await _context.Notes.FindAsync(id);
            if (notes == null)
            {
                return NotFound();
            }
            //ViewData["ImageId"] = new SelectList(_context.Image, "ImageId", "ImgB64", notes.ImageId);
            ViewData["UserId"] = new SelectList(_context.ApplicationUsers, "Id", "Id", notes.UserId);
            return View(notes);
        }

        // POST: Notes/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, Notes notes)
        {
            if (id != notes.NoteId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {

                    ApplicationUser currentUser = await GetCurrentUserAsync();


                    //byte[] data = Convert.FromBase64String(imageData);
                    //notes.Img64 = data;
                    //notes.UserId = currentUser.Id;

                    _context.Update(notes);
                    await _context.SaveChangesAsync();
                    return RedirectToAction(nameof(Index));

                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!NotesExists(notes.NoteId))
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
            //ViewData["ImageId"] = new SelectList(_context.Image, "ImageId", "ImgB64", notes.ImageId);
            ViewData["UserId"] = new SelectList(_context.ApplicationUsers, "Id", "Id", notes.UserId);
            return View(notes);
        }

        // GET: Notes/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var notes = await _context.Notes
                //.Include(n => n.Image)
                .Include(n => n.User)
                .FirstOrDefaultAsync(m => m.NoteId == id);
            if (notes == null)
            {
                return NotFound();
            }

            return View(notes);
        }

        // POST: Notes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var notes = await _context.Notes.FindAsync(id);
            _context.Notes.Remove(notes);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool NotesExists(int id)
        {
            return _context.Notes.Any(e => e.NoteId == id);
        }
    }
}
