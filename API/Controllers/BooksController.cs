using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Persistence;


namespace API.Controllers
{
    public class BooksController : BaseApiController
    {
        private readonly DataContext _context;
        public BooksController(DataContext context)
        {
            _context = context;
        }
        [HttpGet]
        public async Task<ActionResult<List<Book>>> GetBook() {
           return await _context.Books.ToListAsync();
        }
    [HttpGet("{id}")]
    public async Task<ActionResult<Book>> GetBook(Guid id)
    {
        return await _context.Books.FindAsync(id);

    }
        }
    }
