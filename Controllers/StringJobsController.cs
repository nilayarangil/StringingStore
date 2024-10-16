using Microsoft.AspNetCore.Mvc;
using StringingStore.Models;
using StringingStore.Data;
using StringingStore.Models.Entities;
using Microsoft.EntityFrameworkCore;
using System.Numerics;
using System;

namespace StringingStore.Controllers
{
    public class StringJobsController : Controller
    {
        private readonly AppDbContext dbContext;

        public StringJobsController(AppDbContext dbContext)
        {
            this.dbContext = dbContext;
        }
        
        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Add(StringJob viewModel)
        {
            var stringJob = new StringJob
            {
                FirstName = viewModel.FirstName,
                LastName = viewModel.LastName,
                Email = viewModel.Email,
                Phone = viewModel.Phone,
                RacketModel = viewModel.RacketModel,
                StringPattern = viewModel.StringPattern,
                StringName = viewModel.StringName,
                Tension = viewModel.Tension
            };

            await dbContext.stringJobs.AddAsync(stringJob);
            await dbContext.SaveChangesAsync();
           
            return RedirectToAction("List", "StringJobs");
        }

        [HttpGet]
        public async Task<IActionResult> List()
        {
            var stringJobs = await dbContext.stringJobs.ToListAsync();

            return View(stringJobs);
        }
        [HttpGet]
        public async Task<IActionResult> Edit(Guid id)
        {
            var stringJob = await dbContext.stringJobs.FindAsync(id);
            return View(stringJob);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(StringJob viewModel)
        {
            var stringJob = await dbContext.stringJobs.FindAsync(viewModel.Id);

            if (stringJob != null)
            {
                stringJob.FirstName = viewModel.FirstName;
                stringJob.LastName = viewModel.LastName;
                stringJob.Email = viewModel.Email;
                stringJob.Phone = viewModel.Phone;
                stringJob.RacketModel = viewModel.RacketModel;
                stringJob.StringPattern = viewModel.StringPattern;
                stringJob.StringName = viewModel.StringName;
                stringJob.Tension = viewModel.Tension;

                await dbContext.SaveChangesAsync();
            }

            return RedirectToAction("List", "StringJobs");

        }

        [HttpGet]
        public async Task<IActionResult> Delete(Guid id)
        {
            var stringJob = await dbContext.stringJobs
                .AsNoTracking()
                .FirstOrDefaultAsync(x => x.Id == id);

            dbContext.stringJobs.Remove(stringJob);
            await dbContext.SaveChangesAsync();

            return RedirectToAction("List", "StringJobs");
        }


    }
}
