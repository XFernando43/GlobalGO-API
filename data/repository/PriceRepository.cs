﻿using data.repository.interfaces;
using GlobalGO.data;
using GlobalGO.models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace data.repository
{
    public class PriceRepository : Repository<Precios>, IPriceRepository
    {
        private readonly ApplicationDbContext _db;
        public PriceRepository(ApplicationDbContext db) : base(db)
        { 
            _db = db;
        }

        public void AddPrice()
        {
            throw new NotImplementedException();
        }

        public void deletePrices(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Precios>> getPrices()
        {
            return await _db.Precios.ToListAsync();
        }

        public void Save()
        {
            throw new NotImplementedException();
        }

        public void Update()
        {
            throw new NotImplementedException();
        }
    }
}
