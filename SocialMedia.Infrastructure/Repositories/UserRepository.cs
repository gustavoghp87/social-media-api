﻿using Microsoft.EntityFrameworkCore;
using SocialMedia.Core.Data;
using SocialMedia.Infrastructure.Repositories;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SocialMedia.Core.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly SocialMediaContext _context;
        public UserRepository(SocialMediaContext context)
        {
            _context = context;
        }
        public async Task<IEnumerable<User>> GetUsers()
        {
            var users = await _context.Users.ToListAsync();
            return users;
        }
        public async Task<User> GetUser(int id)
        {
            var user = await _context.Users.FirstOrDefaultAsync(x => x.UserId == id);
            return user;
        }
    }
}
