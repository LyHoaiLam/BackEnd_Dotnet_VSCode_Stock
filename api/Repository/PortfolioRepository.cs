using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using api.Data;
using api.Interfaces;
using api.Models;
using Microsoft.EntityFrameworkCore;

namespace api.Properties {
    public class PortfolioRepository : IPortfolioRepository {

        private readonly ApplicationDBContext _context;


        public PortfolioRepository(ApplicationDBContext context) {
            _context = context;
        }

        public async Task<Portfolio> CreateAsync(Portfolio portfolio)
        {
             // throw new NotImplementedException();
            await _context.Portfolios.AddAsync(portfolio);
            await _context.SaveChangesAsync();
            return portfolio;
        }

        public async Task<Portfolio> DetelePortfolio(AppUser appUser, string symbol)
        {
            // throw new NotImplementedException();
            var portfolioModel = await _context.Portfolios.FirstOrDefaultAsync(x => x.AppUserId == appUser.Id && x.Stock.Symbol.ToLower() == symbol.ToLower());
            if(portfolioModel == null) {
                return null;
            }
            _context.Portfolios.Remove(portfolioModel);
            await _context.SaveChangesAsync();
            return portfolioModel;
        }

        public async Task<List<Stock>> GetUserPortfolio(AppUser user) {
            // throw new NotImplementedException();
            return await _context.Portfolios.Where(u => u.AppUserId == user.Id).Select(stock => 
            new Stock {
                Id = stock.StockId,
                Symbol = stock.Stock.Symbol,
                CompanyName = stock.Stock.CompanyName,
                Purchase = stock.Stock.Purchase,
                LastDiv = stock.Stock.LastDiv,
                Industry = stock.Stock.Industry,
                MrketCap = stock.Stock.MrketCap
            }).ToListAsync();

        }
    }
}