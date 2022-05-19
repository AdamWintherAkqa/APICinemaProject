﻿using APICinemaProject.DAL.Database;
using APICinemaProject.DAL.Database.Models;
using Microsoft.EntityFrameworkCore;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace APICinemaProject.DAL.Repositories
{
    public interface IActorRepository
    {
        Task<List<Actor>> GetAllActors();
        Task<Actor> GetActorByID(int id);
        Task<Actor> CreateActor(Actor actor);
        Task<Actor> DeleteActorByID(int id);
        Task<Actor> UpdateActor(int id, Actor actor);
    }
    public class ActorRepository : IActorRepository
    {
        private readonly AbContext context;
        public ActorRepository(AbContext _context)
        {
            context = _context;
        }

        public async Task<List<Actor>> GetAllActors()
        {
            return await context.Actors.ToListAsync();
        }
        public async Task<Actor> GetActorByID(int id)
        {
            return await context.Actors.FirstOrDefaultAsync((actorObj) => actorObj.ActorID == id);
        }
        public async Task<Actor> CreateActor(Actor actor)
        {
            context.Actors.Add(actor);
            await context.SaveChangesAsync();

            return actor;
        }
        public async Task<Actor> DeleteActorByID(int id)
        {
            try
            {
                Actor item = context.Actors.Where(item => item.ActorID == id).Single();
                if (item != null)
                {
                    context.Actors.Remove(item);
                    await context.SaveChangesAsync();
                    return item;
                }
                else
                {
                    return null;
                }
            }
            catch
            {

                return null;
            }
        }
        public async Task<Actor> UpdateActor(int id, Actor actor)
        {
            context.Entry(actor).State = EntityState.Modified;

            try
            {
                await context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ActorExists(id))
                {
                    return null;
                }
                else
                {
                    throw;
                }
            }
            return null;
        }
        private bool ActorExists(int id)
        {
            return context.Actors.Any(e => e.ActorID == id);
        }
    }
}
