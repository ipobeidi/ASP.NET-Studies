﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Vidly.Models;
using Vidly.DTO;
using AutoMapper;

namespace Vidly.Controllers.Api
{
    public class MoviesController : ApiController
    {
        private ApplicationDbContext _context;
        public MoviesController()
        {
            _context = new ApplicationDbContext();
        }

        public IEnumerable<MoviesDTO> GetMovies()
        {
            return _context.Movies.ToList().Select(Mapper.Map<Movie, MoviesDTO>);
        }
        //get /api/movie/id
        public IHttpActionResult GetMovies(int id)
        {
            var movies = _context.Movies.SingleOrDefault(m => m.Id == id);

            if (movies == null)
            {
                return NotFound();
            }

            return Ok(Mapper.Map<Movie, MoviesDTO>(movies));
        }
        [HttpPost]
        public IHttpActionResult CreateMovie(MoviesDTO moviesDTO)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }
            var movie = Mapper.Map<MoviesDTO, Movie>(moviesDTO);

            _context.Movies.Add(movie);
            _context.SaveChanges();

            return Created(new Uri(Request.RequestUri + "/" + movie.Id), moviesDTO);
        }
        [HttpPut]
        public void UpdateMovie(int id, MoviesDTO moviesDto)
        {
            if (!ModelState.IsValid)
            {
                throw new HttpResponseException(HttpStatusCode.BadRequest);

            }
            var movieInDb = _context.Movies.SingleOrDefault(c => c.Id == id);
            if (movieInDb == null)
            {
                throw new HttpResponseException(HttpStatusCode.NotFound);
            }
            Mapper.Map(moviesDto, movieInDb);

            _context.SaveChanges();
        }
        [HttpDelete]
        public void DeleteMovie(int id)
        {

            var movieInDb = _context.Movies.SingleOrDefault(c => c.Id == id);
            if (movieInDb == null)
            {
                throw new HttpResponseException(HttpStatusCode.NotFound);
            }
            _context.Movies.Remove(movieInDb);
            _context.SaveChanges();

        }
    }
}
